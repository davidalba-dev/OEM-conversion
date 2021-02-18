// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_typeRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_typeRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_typeTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_typeTable"></seealso>
/// <seealso cref="Equipment_typeRecord"></seealso>
public class BaseEquipment_typeRecord : PrimaryKeyRecord
{

	public readonly static Equipment_typeTable TableUtils = Equipment_typeTable.Instance;

	// Constructors
 
	protected BaseEquipment_typeRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_typeRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_typeRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_typeRecord_ReadRecord); 
	}

	protected BaseEquipment_typeRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_typeRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_typeRecord Equipment_typeRec = (Equipment_typeRecord)sender;
        if(Equipment_typeRec != null && !Equipment_typeRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_typeRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_typeRecord Equipment_typeRec = (Equipment_typeRecord)sender;
        Validate_Inserting();
        if(Equipment_typeRec != null && !Equipment_typeRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_typeRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_typeRecord Equipment_typeRec = (Equipment_typeRecord)sender;
        Validate_Updating();
        if(Equipment_typeRec != null && !Equipment_typeRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_type_.equipment_type_id field.
	/// </summary>
	public ColumnValue Getequipment_type_idValue()
	{
		return this.GetValue(TableUtils.equipment_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_type_.equipment_type_id field.
	/// </summary>
	public Decimal Getequipment_type_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_type_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_type_.equipment_type_name field.
	/// </summary>
	public ColumnValue Getequipment_type_nameValue()
	{
		return this.GetValue(TableUtils.equipment_type_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_type_.equipment_type_name field.
	/// </summary>
	public string Getequipment_type_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_type_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_type_.equipment_type_name field.
	/// </summary>
	public void Setequipment_type_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_type_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_type_.equipment_type_name field.
	/// </summary>
	public void Setequipment_type_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_type_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_type_.eqiupment_type_active field.
	/// </summary>
	public ColumnValue Geteqiupment_type_activeValue()
	{
		return this.GetValue(TableUtils.eqiupment_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_type_.eqiupment_type_active field.
	/// </summary>
	public bool Geteqiupment_type_activeFieldValue()
	{
		return this.GetValue(TableUtils.eqiupment_type_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_type_.eqiupment_type_active field.
	/// </summary>
	public void Seteqiupment_type_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eqiupment_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_type_.eqiupment_type_active field.
	/// </summary>
	public void Seteqiupment_type_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.eqiupment_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_type_.eqiupment_type_active field.
	/// </summary>
	public void Seteqiupment_type_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eqiupment_type_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_type_.equipment_type_id field.
	/// </summary>
	public Decimal equipment_type_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_type_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_type_.equipment_type_id field.
	/// </summary>
	public string equipment_type_idDefault
	{
		get
		{
			return TableUtils.equipment_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_type_.equipment_type_name field.
	/// </summary>
	public string equipment_type_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_type_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_type_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_type_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_type_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_type_.equipment_type_name field.
	/// </summary>
	public string equipment_type_nameDefault
	{
		get
		{
			return TableUtils.equipment_type_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_type_.eqiupment_type_active field.
	/// </summary>
	public bool eqiupment_type_active
	{
		get
		{
			return this.GetValue(TableUtils.eqiupment_type_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.eqiupment_type_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool eqiupment_type_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.eqiupment_type_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_type_.eqiupment_type_active field.
	/// </summary>
	public string eqiupment_type_activeDefault
	{
		get
		{
			return TableUtils.eqiupment_type_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
