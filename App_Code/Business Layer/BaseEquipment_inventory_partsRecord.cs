// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_inventory_partsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_inventory_partsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_inventory_partsTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_inventory_partsTable"></seealso>
/// <seealso cref="Equipment_inventory_partsRecord"></seealso>
public class BaseEquipment_inventory_partsRecord : PrimaryKeyRecord
{

	public readonly static Equipment_inventory_partsTable TableUtils = Equipment_inventory_partsTable.Instance;

	// Constructors
 
	protected BaseEquipment_inventory_partsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_inventory_partsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_inventory_partsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_inventory_partsRecord_ReadRecord); 
	}

	protected BaseEquipment_inventory_partsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_inventory_partsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_inventory_partsRecord Equipment_inventory_partsRec = (Equipment_inventory_partsRecord)sender;
        if(Equipment_inventory_partsRec != null && !Equipment_inventory_partsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_inventory_partsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_inventory_partsRecord Equipment_inventory_partsRec = (Equipment_inventory_partsRecord)sender;
        Validate_Inserting();
        if(Equipment_inventory_partsRec != null && !Equipment_inventory_partsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_inventory_partsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_inventory_partsRecord Equipment_inventory_partsRec = (Equipment_inventory_partsRecord)sender;
        Validate_Updating();
        if(Equipment_inventory_partsRec != null && !Equipment_inventory_partsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.equipment_inventory_part_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_part_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_part_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.equipment_inventory_part_id field.
	/// </summary>
	public Decimal Getequipment_inventory_part_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_part_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.inventory_id field.
	/// </summary>
	public ColumnValue Getinventory_idValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.inventory_id field.
	/// </summary>
	public Decimal Getinventory_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_id field.
	/// </summary>
	public ColumnValue Getrefurb_part_idValue()
	{
		return this.GetValue(TableUtils.refurb_part_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_id field.
	/// </summary>
	public Decimal Getrefurb_part_idFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_id field.
	/// </summary>
	public void Setrefurb_part_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_id field.
	/// </summary>
	public void Setrefurb_part_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.refurb_part_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_id field.
	/// </summary>
	public void Setrefurb_part_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_id field.
	/// </summary>
	public void Setrefurb_part_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_id field.
	/// </summary>
	public void Setrefurb_part_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_name field.
	/// </summary>
	public ColumnValue Getrefurb_part_nameValue()
	{
		return this.GetValue(TableUtils.refurb_part_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_name field.
	/// </summary>
	public string Getrefurb_part_nameFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_name field.
	/// </summary>
	public void Setrefurb_part_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_name field.
	/// </summary>
	public void Setrefurb_part_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_cost field.
	/// </summary>
	public ColumnValue Getrefurb_part_costValue()
	{
		return this.GetValue(TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_cost field.
	/// </summary>
	public Decimal Getrefurb_part_costFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_costColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(string val)
	{
		this.SetString(val, TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_costColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_retail field.
	/// </summary>
	public ColumnValue Getrefurb_part_retailValue()
	{
		return this.GetValue(TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_retail field.
	/// </summary>
	public Decimal Getrefurb_part_retailFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_retailColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(string val)
	{
		this.SetString(val, TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_retailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_vendor_id field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_idValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_vendor_id field.
	/// </summary>
	public Decimal Getrefurb_part_vendor_idFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_vendor_id field.
	/// </summary>
	public void Setrefurb_part_vendor_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_vendor_id field.
	/// </summary>
	public void Setrefurb_part_vendor_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.refurb_part_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_vendor_id field.
	/// </summary>
	public void Setrefurb_part_vendor_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_vendor_id field.
	/// </summary>
	public void Setrefurb_part_vendor_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_vendor_id field.
	/// </summary>
	public void Setrefurb_part_vendor_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_number field.
	/// </summary>
	public ColumnValue Getrefurb_part_numberValue()
	{
		return this.GetValue(TableUtils.refurb_part_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_number field.
	/// </summary>
	public string Getrefurb_part_numberFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_number field.
	/// </summary>
	public void Setrefurb_part_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_number field.
	/// </summary>
	public void Setrefurb_part_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_numberColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_parts_.equipment_inventory_part_id field.
	/// </summary>
	public Decimal equipment_inventory_part_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_part_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_part_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_part_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_part_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.equipment_inventory_part_id field.
	/// </summary>
	public string equipment_inventory_part_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_part_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_parts_.inventory_id field.
	/// </summary>
	public Decimal inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.inventory_id field.
	/// </summary>
	public string inventory_idDefault
	{
		get
		{
			return TableUtils.inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_id field.
	/// </summary>
	public Decimal refurb_part_id
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_id field.
	/// </summary>
	public string refurb_part_idDefault
	{
		get
		{
			return TableUtils.refurb_part_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_name field.
	/// </summary>
	public string refurb_part_name
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_name field.
	/// </summary>
	public string refurb_part_nameDefault
	{
		get
		{
			return TableUtils.refurb_part_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_cost field.
	/// </summary>
	public Decimal refurb_part_cost
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_costColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_costColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_costSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_costColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_cost field.
	/// </summary>
	public string refurb_part_costDefault
	{
		get
		{
			return TableUtils.refurb_part_costColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_retail field.
	/// </summary>
	public Decimal refurb_part_retail
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_retailColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_retailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_retailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_retailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_retail field.
	/// </summary>
	public string refurb_part_retailDefault
	{
		get
		{
			return TableUtils.refurb_part_retailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_vendor_id field.
	/// </summary>
	public Decimal refurb_part_vendor_id
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_vendor_id field.
	/// </summary>
	public string refurb_part_vendor_idDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_parts_.refurb_part_number field.
	/// </summary>
	public string refurb_part_number
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_numberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_numberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_numberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_numberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_parts_.refurb_part_number field.
	/// </summary>
	public string refurb_part_numberDefault
	{
		get
		{
			return TableUtils.refurb_part_numberColumn.DefaultValue;
		}
	}


#endregion
}

}
