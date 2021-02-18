// This class is "generated" and will be overwritten.
// Your customizations should be made in Procurement_statusRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Procurement_statusRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Procurement_statusTable"></see> class.
/// </remarks>
/// <seealso cref="Procurement_statusTable"></seealso>
/// <seealso cref="Procurement_statusRecord"></seealso>
public class BaseProcurement_statusRecord : PrimaryKeyRecord
{

	public readonly static Procurement_statusTable TableUtils = Procurement_statusTable.Instance;

	// Constructors
 
	protected BaseProcurement_statusRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Procurement_statusRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Procurement_statusRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Procurement_statusRecord_ReadRecord); 
	}

	protected BaseProcurement_statusRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Procurement_statusRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Procurement_statusRecord Procurement_statusRec = (Procurement_statusRecord)sender;
        if(Procurement_statusRec != null && !Procurement_statusRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Procurement_statusRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Procurement_statusRecord Procurement_statusRec = (Procurement_statusRecord)sender;
        Validate_Inserting();
        if(Procurement_statusRec != null && !Procurement_statusRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Procurement_statusRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Procurement_statusRecord Procurement_statusRec = (Procurement_statusRecord)sender;
        Validate_Updating();
        if(Procurement_statusRec != null && !Procurement_statusRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's procurement_status_.procurement_status_id field.
	/// </summary>
	public ColumnValue Getprocurement_status_idValue()
	{
		return this.GetValue(TableUtils.procurement_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_status_.procurement_status_id field.
	/// </summary>
	public Int32 Getprocurement_status_idFieldValue()
	{
		return this.GetValue(TableUtils.procurement_status_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_status_.procurement_status field.
	/// </summary>
	public ColumnValue Getprocurement_statusValue()
	{
		return this.GetValue(TableUtils.procurement_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_status_.procurement_status field.
	/// </summary>
	public string Getprocurement_statusFieldValue()
	{
		return this.GetValue(TableUtils.procurement_statusColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.procurement_status field.
	/// </summary>
	public void Setprocurement_statusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.procurement_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.procurement_status field.
	/// </summary>
	public void Setprocurement_statusFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.procurement_statusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_status_.procurement_status_active field.
	/// </summary>
	public ColumnValue Getprocurement_status_activeValue()
	{
		return this.GetValue(TableUtils.procurement_status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_status_.procurement_status_active field.
	/// </summary>
	public bool Getprocurement_status_activeFieldValue()
	{
		return this.GetValue(TableUtils.procurement_status_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.procurement_status_active field.
	/// </summary>
	public void Setprocurement_status_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.procurement_status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.procurement_status_active field.
	/// </summary>
	public void Setprocurement_status_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.procurement_status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.procurement_status_active field.
	/// </summary>
	public void Setprocurement_status_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.procurement_status_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_status_.status_color field.
	/// </summary>
	public ColumnValue Getstatus_colorValue()
	{
		return this.GetValue(TableUtils.status_colorColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_status_.status_color field.
	/// </summary>
	public string Getstatus_colorFieldValue()
	{
		return this.GetValue(TableUtils.status_colorColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.status_color field.
	/// </summary>
	public void Setstatus_colorFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.status_colorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.status_color field.
	/// </summary>
	public void Setstatus_colorFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.status_colorColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_status_.procurement_status_id field.
	/// </summary>
	public Int32 procurement_status_id
	{
		get
		{
			return this.GetValue(TableUtils.procurement_status_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.procurement_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.procurement_status_id field.
	/// </summary>
	public string procurement_status_idDefault
	{
		get
		{
			return TableUtils.procurement_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_status_.procurement_status field.
	/// </summary>
	public string procurement_status
	{
		get
		{
			return this.GetValue(TableUtils.procurement_statusColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.procurement_statusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_statusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_statusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.procurement_status field.
	/// </summary>
	public string procurement_statusDefault
	{
		get
		{
			return TableUtils.procurement_statusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_status_.procurement_status_active field.
	/// </summary>
	public bool procurement_status_active
	{
		get
		{
			return this.GetValue(TableUtils.procurement_status_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.procurement_status_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_status_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_status_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.procurement_status_active field.
	/// </summary>
	public string procurement_status_activeDefault
	{
		get
		{
			return TableUtils.procurement_status_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_status_.status_color field.
	/// </summary>
	public string status_color
	{
		get
		{
			return this.GetValue(TableUtils.status_colorColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.status_colorColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool status_colorSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.status_colorColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_status_.status_color field.
	/// </summary>
	public string status_colorDefault
	{
		get
		{
			return TableUtils.status_colorColumn.DefaultValue;
		}
	}


#endregion
}

}
