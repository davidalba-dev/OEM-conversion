// This class is "generated" and will be overwritten.
// Your customizations should be made in StageRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="StageRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="StageTable"></see> class.
/// </remarks>
/// <seealso cref="StageTable"></seealso>
/// <seealso cref="StageRecord"></seealso>
public class BaseStageRecord : PrimaryKeyRecord
{

	public readonly static StageTable TableUtils = StageTable.Instance;

	// Constructors
 
	protected BaseStageRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.StageRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.StageRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.StageRecord_ReadRecord); 
	}

	protected BaseStageRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void StageRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                StageRecord StageRec = (StageRecord)sender;
        if(StageRec != null && !StageRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void StageRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                StageRecord StageRec = (StageRecord)sender;
        Validate_Inserting();
        if(StageRec != null && !StageRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void StageRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                StageRecord StageRec = (StageRecord)sender;
        Validate_Updating();
        if(StageRec != null && !StageRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's stage_.stage_id field.
	/// </summary>
	public ColumnValue Getstage_idValue()
	{
		return this.GetValue(TableUtils.stage_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's stage_.stage_id field.
	/// </summary>
	public Int32 Getstage_idFieldValue()
	{
		return this.GetValue(TableUtils.stage_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's stage_.stage_name field.
	/// </summary>
	public ColumnValue Getstage_nameValue()
	{
		return this.GetValue(TableUtils.stage_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's stage_.stage_name field.
	/// </summary>
	public string Getstage_nameFieldValue()
	{
		return this.GetValue(TableUtils.stage_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's stage_.stage_name field.
	/// </summary>
	public void Setstage_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.stage_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's stage_.stage_name field.
	/// </summary>
	public void Setstage_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.stage_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's stage_.stage_active field.
	/// </summary>
	public ColumnValue Getstage_activeValue()
	{
		return this.GetValue(TableUtils.stage_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's stage_.stage_active field.
	/// </summary>
	public bool Getstage_activeFieldValue()
	{
		return this.GetValue(TableUtils.stage_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's stage_.stage_active field.
	/// </summary>
	public void Setstage_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.stage_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's stage_.stage_active field.
	/// </summary>
	public void Setstage_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.stage_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's stage_.stage_active field.
	/// </summary>
	public void Setstage_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.stage_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's stage_.stage_id field.
	/// </summary>
	public Int32 stage_id
	{
		get
		{
			return this.GetValue(TableUtils.stage_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.stage_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool stage_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.stage_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's stage_.stage_id field.
	/// </summary>
	public string stage_idDefault
	{
		get
		{
			return TableUtils.stage_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's stage_.stage_name field.
	/// </summary>
	public string stage_name
	{
		get
		{
			return this.GetValue(TableUtils.stage_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.stage_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool stage_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.stage_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's stage_.stage_name field.
	/// </summary>
	public string stage_nameDefault
	{
		get
		{
			return TableUtils.stage_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's stage_.stage_active field.
	/// </summary>
	public bool stage_active
	{
		get
		{
			return this.GetValue(TableUtils.stage_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.stage_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool stage_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.stage_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's stage_.stage_active field.
	/// </summary>
	public string stage_activeDefault
	{
		get
		{
			return TableUtils.stage_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
