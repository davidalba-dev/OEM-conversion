// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_batch_statusRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_batch_statusRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_batch_statusTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_batch_statusTable"></seealso>
/// <seealso cref="Equipment_batch_statusRecord"></seealso>
public class BaseEquipment_batch_statusRecord : PrimaryKeyRecord
{

	public readonly static Equipment_batch_statusTable TableUtils = Equipment_batch_statusTable.Instance;

	// Constructors
 
	protected BaseEquipment_batch_statusRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_batch_statusRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_batch_statusRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_batch_statusRecord_ReadRecord); 
	}

	protected BaseEquipment_batch_statusRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_batch_statusRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_batch_statusRecord Equipment_batch_statusRec = (Equipment_batch_statusRecord)sender;
        if(Equipment_batch_statusRec != null && !Equipment_batch_statusRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_batch_statusRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_batch_statusRecord Equipment_batch_statusRec = (Equipment_batch_statusRecord)sender;
        Validate_Inserting();
        if(Equipment_batch_statusRec != null && !Equipment_batch_statusRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_batch_statusRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_batch_statusRecord Equipment_batch_statusRec = (Equipment_batch_statusRecord)sender;
        Validate_Updating();
        if(Equipment_batch_statusRec != null && !Equipment_batch_statusRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_batch_status_.equipment_batch_status_id field.
	/// </summary>
	public ColumnValue Getequipment_batch_status_idValue()
	{
		return this.GetValue(TableUtils.equipment_batch_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_batch_status_.equipment_batch_status_id field.
	/// </summary>
	public Decimal Getequipment_batch_status_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_batch_status_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_batch_status_.batch_status field.
	/// </summary>
	public ColumnValue Getbatch_statusValue()
	{
		return this.GetValue(TableUtils.batch_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_batch_status_.batch_status field.
	/// </summary>
	public string Getbatch_statusFieldValue()
	{
		return this.GetValue(TableUtils.batch_statusColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_batch_status_.batch_status field.
	/// </summary>
	public void Setbatch_statusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.batch_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_batch_status_.batch_status field.
	/// </summary>
	public void Setbatch_statusFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.batch_statusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_batch_status_.batch_status_active field.
	/// </summary>
	public ColumnValue Getbatch_status_activeValue()
	{
		return this.GetValue(TableUtils.batch_status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_batch_status_.batch_status_active field.
	/// </summary>
	public bool Getbatch_status_activeFieldValue()
	{
		return this.GetValue(TableUtils.batch_status_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_batch_status_.batch_status_active field.
	/// </summary>
	public void Setbatch_status_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.batch_status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_batch_status_.batch_status_active field.
	/// </summary>
	public void Setbatch_status_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.batch_status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_batch_status_.batch_status_active field.
	/// </summary>
	public void Setbatch_status_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.batch_status_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_batch_status_.equipment_batch_status_id field.
	/// </summary>
	public Decimal equipment_batch_status_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_batch_status_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_batch_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_batch_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_batch_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_batch_status_.equipment_batch_status_id field.
	/// </summary>
	public string equipment_batch_status_idDefault
	{
		get
		{
			return TableUtils.equipment_batch_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_batch_status_.batch_status field.
	/// </summary>
	public string batch_status
	{
		get
		{
			return this.GetValue(TableUtils.batch_statusColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.batch_statusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool batch_statusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.batch_statusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_batch_status_.batch_status field.
	/// </summary>
	public string batch_statusDefault
	{
		get
		{
			return TableUtils.batch_statusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_batch_status_.batch_status_active field.
	/// </summary>
	public bool batch_status_active
	{
		get
		{
			return this.GetValue(TableUtils.batch_status_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.batch_status_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool batch_status_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.batch_status_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_batch_status_.batch_status_active field.
	/// </summary>
	public string batch_status_activeDefault
	{
		get
		{
			return TableUtils.batch_status_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
