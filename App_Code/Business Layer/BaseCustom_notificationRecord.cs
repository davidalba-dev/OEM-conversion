// This class is "generated" and will be overwritten.
// Your customizations should be made in Custom_notificationRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Custom_notificationRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Custom_notificationTable"></see> class.
/// </remarks>
/// <seealso cref="Custom_notificationTable"></seealso>
/// <seealso cref="Custom_notificationRecord"></seealso>
public class BaseCustom_notificationRecord : PrimaryKeyRecord
{

	public readonly static Custom_notificationTable TableUtils = Custom_notificationTable.Instance;

	// Constructors
 
	protected BaseCustom_notificationRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Custom_notificationRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Custom_notificationRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Custom_notificationRecord_ReadRecord); 
	}

	protected BaseCustom_notificationRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Custom_notificationRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Custom_notificationRecord Custom_notificationRec = (Custom_notificationRecord)sender;
        if(Custom_notificationRec != null && !Custom_notificationRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Custom_notificationRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Custom_notificationRecord Custom_notificationRec = (Custom_notificationRecord)sender;
        Validate_Inserting();
        if(Custom_notificationRec != null && !Custom_notificationRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Custom_notificationRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Custom_notificationRecord Custom_notificationRec = (Custom_notificationRecord)sender;
        Validate_Updating();
        if(Custom_notificationRec != null && !Custom_notificationRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's custom_notification_.custom_notification_id field.
	/// </summary>
	public ColumnValue Getcustom_notification_idValue()
	{
		return this.GetValue(TableUtils.custom_notification_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's custom_notification_.custom_notification_id field.
	/// </summary>
	public Int32 Getcustom_notification_idFieldValue()
	{
		return this.GetValue(TableUtils.custom_notification_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's custom_notification_.custom_notification_msg field.
	/// </summary>
	public ColumnValue Getcustom_notification_msgValue()
	{
		return this.GetValue(TableUtils.custom_notification_msgColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's custom_notification_.custom_notification_msg field.
	/// </summary>
	public string Getcustom_notification_msgFieldValue()
	{
		return this.GetValue(TableUtils.custom_notification_msgColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's custom_notification_.custom_notification_msg field.
	/// </summary>
	public void Setcustom_notification_msgFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custom_notification_msgColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's custom_notification_.custom_notification_msg field.
	/// </summary>
	public void Setcustom_notification_msgFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custom_notification_msgColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's custom_notification_.custom_notification_active field.
	/// </summary>
	public ColumnValue Getcustom_notification_activeValue()
	{
		return this.GetValue(TableUtils.custom_notification_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's custom_notification_.custom_notification_active field.
	/// </summary>
	public bool Getcustom_notification_activeFieldValue()
	{
		return this.GetValue(TableUtils.custom_notification_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's custom_notification_.custom_notification_active field.
	/// </summary>
	public void Setcustom_notification_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custom_notification_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's custom_notification_.custom_notification_active field.
	/// </summary>
	public void Setcustom_notification_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.custom_notification_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's custom_notification_.custom_notification_active field.
	/// </summary>
	public void Setcustom_notification_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custom_notification_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's custom_notification_.custom_notification_id field.
	/// </summary>
	public Int32 custom_notification_id
	{
		get
		{
			return this.GetValue(TableUtils.custom_notification_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custom_notification_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custom_notification_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custom_notification_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's custom_notification_.custom_notification_id field.
	/// </summary>
	public string custom_notification_idDefault
	{
		get
		{
			return TableUtils.custom_notification_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's custom_notification_.custom_notification_msg field.
	/// </summary>
	public string custom_notification_msg
	{
		get
		{
			return this.GetValue(TableUtils.custom_notification_msgColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custom_notification_msgColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custom_notification_msgSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custom_notification_msgColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's custom_notification_.custom_notification_msg field.
	/// </summary>
	public string custom_notification_msgDefault
	{
		get
		{
			return TableUtils.custom_notification_msgColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's custom_notification_.custom_notification_active field.
	/// </summary>
	public bool custom_notification_active
	{
		get
		{
			return this.GetValue(TableUtils.custom_notification_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.custom_notification_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custom_notification_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custom_notification_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's custom_notification_.custom_notification_active field.
	/// </summary>
	public string custom_notification_activeDefault
	{
		get
		{
			return TableUtils.custom_notification_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
