// This class is "generated" and will be overwritten.
// Your customizations should be made in Notification_logRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Notification_logRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Notification_logTable"></see> class.
/// </remarks>
/// <seealso cref="Notification_logTable"></seealso>
/// <seealso cref="Notification_logRecord"></seealso>
public class BaseNotification_logRecord : PrimaryKeyRecord
{

	public readonly static Notification_logTable TableUtils = Notification_logTable.Instance;

	// Constructors
 
	protected BaseNotification_logRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Notification_logRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Notification_logRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Notification_logRecord_ReadRecord); 
	}

	protected BaseNotification_logRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Notification_logRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Notification_logRecord Notification_logRec = (Notification_logRecord)sender;
        if(Notification_logRec != null && !Notification_logRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Notification_logRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Notification_logRecord Notification_logRec = (Notification_logRecord)sender;
        Validate_Inserting();
        if(Notification_logRec != null && !Notification_logRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Notification_logRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Notification_logRecord Notification_logRec = (Notification_logRecord)sender;
        Validate_Updating();
        if(Notification_logRec != null && !Notification_logRec.IsReadOnly ){
                }
    
    }

   //Evaluates Validate when->Inserting formulas specified at the data access layer
	protected virtual void Validate_Inserting()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
 
	//Evaluates Validate when->Updating formulas specified at the data access layer
	protected virtual void Validate_Updating()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
	public virtual string EvaluateFormula(string formula, BaseRecord  dataSourceForEvaluate, string format)
    {
        Data.BaseFormulaEvaluator e = new Data.BaseFormulaEvaluator();
        
        // All variables referred to in the formula are expected to be
        // properties of the DataSource.  For example, referring to
        // UnitPrice as a variable will refer to DataSource.UnitPrice
        e.DataSource = dataSourceForEvaluate;

        Object resultObj = e.Evaluate(formula);
        if(resultObj == null) 
			return "";
        return resultObj.ToString();
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.repairorder_notify_id field.
	/// </summary>
	public ColumnValue Getrepairorder_notify_idValue()
	{
		return this.GetValue(TableUtils.repairorder_notify_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.repairorder_notify_id field.
	/// </summary>
	public Int32 Getrepairorder_notify_idFieldValue()
	{
		return this.GetValue(TableUtils.repairorder_notify_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.rono field.
	/// </summary>
	public ColumnValue GetronoValue()
	{
		return this.GetValue(TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.rono field.
	/// </summary>
	public Int32 GetronoFieldValue()
	{
		return this.GetValue(TableUtils.ronoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.rono field.
	/// </summary>
	public void SetronoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.rono field.
	/// </summary>
	public void SetronoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.rono field.
	/// </summary>
	public void SetronoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.rono field.
	/// </summary>
	public void SetronoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.rono field.
	/// </summary>
	public void SetronoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notified_by field.
	/// </summary>
	public ColumnValue Getnotified_byValue()
	{
		return this.GetValue(TableUtils.notified_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notified_by field.
	/// </summary>
	public Int32 Getnotified_byFieldValue()
	{
		return this.GetValue(TableUtils.notified_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notified_by field.
	/// </summary>
	public void Setnotified_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notified_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notified_by field.
	/// </summary>
	public void Setnotified_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.notified_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notified_by field.
	/// </summary>
	public void Setnotified_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notified_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notified_by field.
	/// </summary>
	public void Setnotified_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notified_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notified_by field.
	/// </summary>
	public void Setnotified_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notified_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify1 field.
	/// </summary>
	public ColumnValue Getnotify1Value()
	{
		return this.GetValue(TableUtils.notify1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify1 field.
	/// </summary>
	public string Getnotify1FieldValue()
	{
		return this.GetValue(TableUtils.notify1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify1 field.
	/// </summary>
	public void Setnotify1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notify1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify1 field.
	/// </summary>
	public void Setnotify1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notify1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify2 field.
	/// </summary>
	public ColumnValue Getnotify2Value()
	{
		return this.GetValue(TableUtils.notify2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify2 field.
	/// </summary>
	public string Getnotify2FieldValue()
	{
		return this.GetValue(TableUtils.notify2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify2 field.
	/// </summary>
	public void Setnotify2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notify2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify2 field.
	/// </summary>
	public void Setnotify2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notify2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify3 field.
	/// </summary>
	public ColumnValue Getnotify3Value()
	{
		return this.GetValue(TableUtils.notify3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify3 field.
	/// </summary>
	public string Getnotify3FieldValue()
	{
		return this.GetValue(TableUtils.notify3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify3 field.
	/// </summary>
	public void Setnotify3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notify3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify3 field.
	/// </summary>
	public void Setnotify3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notify3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify_message field.
	/// </summary>
	public ColumnValue Getnotify_messageValue()
	{
		return this.GetValue(TableUtils.notify_messageColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify_message field.
	/// </summary>
	public string Getnotify_messageFieldValue()
	{
		return this.GetValue(TableUtils.notify_messageColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_message field.
	/// </summary>
	public void Setnotify_messageFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notify_messageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_message field.
	/// </summary>
	public void Setnotify_messageFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notify_messageColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify_datetime field.
	/// </summary>
	public ColumnValue Getnotify_datetimeValue()
	{
		return this.GetValue(TableUtils.notify_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify_datetime field.
	/// </summary>
	public DateTime Getnotify_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.notify_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_datetime field.
	/// </summary>
	public void Setnotify_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notify_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_datetime field.
	/// </summary>
	public void Setnotify_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.notify_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_datetime field.
	/// </summary>
	public void Setnotify_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notify_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify_url field.
	/// </summary>
	public ColumnValue Getnotify_urlValue()
	{
		return this.GetValue(TableUtils.notify_urlColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.notify_url field.
	/// </summary>
	public string Getnotify_urlFieldValue()
	{
		return this.GetValue(TableUtils.notify_urlColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_url field.
	/// </summary>
	public void Setnotify_urlFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notify_urlColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_url field.
	/// </summary>
	public void Setnotify_urlFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notify_urlColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.custom_notificatian_id field.
	/// </summary>
	public ColumnValue Getcustom_notificatian_idValue()
	{
		return this.GetValue(TableUtils.custom_notificatian_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's notification_log_.custom_notificatian_id field.
	/// </summary>
	public Int32 Getcustom_notificatian_idFieldValue()
	{
		return this.GetValue(TableUtils.custom_notificatian_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custom_notificatian_id field.
	/// </summary>
	public void Setcustom_notificatian_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custom_notificatian_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custom_notificatian_id field.
	/// </summary>
	public void Setcustom_notificatian_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.custom_notificatian_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custom_notificatian_id field.
	/// </summary>
	public void Setcustom_notificatian_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custom_notificatian_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custom_notificatian_id field.
	/// </summary>
	public void Setcustom_notificatian_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custom_notificatian_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custom_notificatian_id field.
	/// </summary>
	public void Setcustom_notificatian_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custom_notificatian_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.repairorder_notify_id field.
	/// </summary>
	public Int32 repairorder_notify_id
	{
		get
		{
			return this.GetValue(TableUtils.repairorder_notify_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repairorder_notify_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repairorder_notify_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repairorder_notify_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.repairorder_notify_id field.
	/// </summary>
	public string repairorder_notify_idDefault
	{
		get
		{
			return TableUtils.repairorder_notify_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.rono field.
	/// </summary>
	public Int32 rono
	{
		get
		{
			return this.GetValue(TableUtils.ronoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ronoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ronoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ronoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.rono field.
	/// </summary>
	public string ronoDefault
	{
		get
		{
			return TableUtils.ronoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.notified_by field.
	/// </summary>
	public Int32 notified_by
	{
		get
		{
			return this.GetValue(TableUtils.notified_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.notified_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool notified_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.notified_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notified_by field.
	/// </summary>
	public string notified_byDefault
	{
		get
		{
			return TableUtils.notified_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.notify1 field.
	/// </summary>
	public string notify1
	{
		get
		{
			return this.GetValue(TableUtils.notify1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.notify1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool notify1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.notify1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify1 field.
	/// </summary>
	public string notify1Default
	{
		get
		{
			return TableUtils.notify1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.notify2 field.
	/// </summary>
	public string notify2
	{
		get
		{
			return this.GetValue(TableUtils.notify2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.notify2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool notify2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.notify2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify2 field.
	/// </summary>
	public string notify2Default
	{
		get
		{
			return TableUtils.notify2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.notify3 field.
	/// </summary>
	public string notify3
	{
		get
		{
			return this.GetValue(TableUtils.notify3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.notify3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool notify3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.notify3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify3 field.
	/// </summary>
	public string notify3Default
	{
		get
		{
			return TableUtils.notify3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.notify_message field.
	/// </summary>
	public string notify_message
	{
		get
		{
			return this.GetValue(TableUtils.notify_messageColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.notify_messageColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool notify_messageSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.notify_messageColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_message field.
	/// </summary>
	public string notify_messageDefault
	{
		get
		{
			return TableUtils.notify_messageColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.notify_datetime field.
	/// </summary>
	public DateTime notify_datetime
	{
		get
		{
			return this.GetValue(TableUtils.notify_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.notify_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool notify_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.notify_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_datetime field.
	/// </summary>
	public string notify_datetimeDefault
	{
		get
		{
			return TableUtils.notify_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.custno field.
	/// </summary>
	public Int32 custno
	{
		get
		{
			return this.GetValue(TableUtils.custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.notify_url field.
	/// </summary>
	public string notify_url
	{
		get
		{
			return this.GetValue(TableUtils.notify_urlColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.notify_urlColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool notify_urlSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.notify_urlColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.notify_url field.
	/// </summary>
	public string notify_urlDefault
	{
		get
		{
			return TableUtils.notify_urlColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's notification_log_.custom_notificatian_id field.
	/// </summary>
	public Int32 custom_notificatian_id
	{
		get
		{
			return this.GetValue(TableUtils.custom_notificatian_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custom_notificatian_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custom_notificatian_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custom_notificatian_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's notification_log_.custom_notificatian_id field.
	/// </summary>
	public string custom_notificatian_idDefault
	{
		get
		{
			return TableUtils.custom_notificatian_idColumn.DefaultValue;
		}
	}


#endregion
}

}
