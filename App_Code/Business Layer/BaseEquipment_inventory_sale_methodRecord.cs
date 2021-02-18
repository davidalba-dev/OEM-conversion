// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_inventory_sale_methodRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_inventory_sale_methodRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_inventory_sale_methodTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_inventory_sale_methodTable"></seealso>
/// <seealso cref="Equipment_inventory_sale_methodRecord"></seealso>
public class BaseEquipment_inventory_sale_methodRecord : PrimaryKeyRecord
{

	public readonly static Equipment_inventory_sale_methodTable TableUtils = Equipment_inventory_sale_methodTable.Instance;

	// Constructors
 
	protected BaseEquipment_inventory_sale_methodRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_inventory_sale_methodRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_inventory_sale_methodRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_inventory_sale_methodRecord_ReadRecord); 
	}

	protected BaseEquipment_inventory_sale_methodRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_inventory_sale_methodRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_inventory_sale_methodRecord Equipment_inventory_sale_methodRec = (Equipment_inventory_sale_methodRecord)sender;
        if(Equipment_inventory_sale_methodRec != null && !Equipment_inventory_sale_methodRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_inventory_sale_methodRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_inventory_sale_methodRecord Equipment_inventory_sale_methodRec = (Equipment_inventory_sale_methodRecord)sender;
        Validate_Inserting();
        if(Equipment_inventory_sale_methodRec != null && !Equipment_inventory_sale_methodRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_inventory_sale_methodRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_inventory_sale_methodRecord Equipment_inventory_sale_methodRec = (Equipment_inventory_sale_methodRecord)sender;
        Validate_Updating();
        if(Equipment_inventory_sale_methodRec != null && !Equipment_inventory_sale_methodRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_sale_method_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_id field.
	/// </summary>
	public Decimal Getequipment_inventory_sale_method_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_sale_method_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_sale_method_.eqiupment_inventory_sale_method field.
	/// </summary>
	public ColumnValue Geteqiupment_inventory_sale_methodValue()
	{
		return this.GetValue(TableUtils.eqiupment_inventory_sale_methodColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_sale_method_.eqiupment_inventory_sale_method field.
	/// </summary>
	public string Geteqiupment_inventory_sale_methodFieldValue()
	{
		return this.GetValue(TableUtils.eqiupment_inventory_sale_methodColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_sale_method_.eqiupment_inventory_sale_method field.
	/// </summary>
	public void Seteqiupment_inventory_sale_methodFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eqiupment_inventory_sale_methodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_sale_method_.eqiupment_inventory_sale_method field.
	/// </summary>
	public void Seteqiupment_inventory_sale_methodFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eqiupment_inventory_sale_methodColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_active field.
	/// </summary>
	public ColumnValue Getequipment_inventory_sale_method_activeValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_sale_method_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_active field.
	/// </summary>
	public bool Getequipment_inventory_sale_method_activeFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_sale_method_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_active field.
	/// </summary>
	public void Setequipment_inventory_sale_method_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_sale_method_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_active field.
	/// </summary>
	public void Setequipment_inventory_sale_method_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_sale_method_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_active field.
	/// </summary>
	public void Setequipment_inventory_sale_method_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_sale_method_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_id field.
	/// </summary>
	public Decimal equipment_inventory_sale_method_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_sale_method_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_sale_method_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_sale_method_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_sale_method_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_id field.
	/// </summary>
	public string equipment_inventory_sale_method_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_sale_method_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_sale_method_.eqiupment_inventory_sale_method field.
	/// </summary>
	public string eqiupment_inventory_sale_method
	{
		get
		{
			return this.GetValue(TableUtils.eqiupment_inventory_sale_methodColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.eqiupment_inventory_sale_methodColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool eqiupment_inventory_sale_methodSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.eqiupment_inventory_sale_methodColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_sale_method_.eqiupment_inventory_sale_method field.
	/// </summary>
	public string eqiupment_inventory_sale_methodDefault
	{
		get
		{
			return TableUtils.eqiupment_inventory_sale_methodColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_active field.
	/// </summary>
	public bool equipment_inventory_sale_method_active
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_sale_method_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.equipment_inventory_sale_method_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_sale_method_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_sale_method_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_sale_method_.equipment_inventory_sale_method_active field.
	/// </summary>
	public string equipment_inventory_sale_method_activeDefault
	{
		get
		{
			return TableUtils.equipment_inventory_sale_method_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
