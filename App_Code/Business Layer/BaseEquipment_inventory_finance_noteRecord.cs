// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_inventory_finance_noteRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_inventory_finance_noteRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_inventory_finance_noteTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_inventory_finance_noteTable"></seealso>
/// <seealso cref="Equipment_inventory_finance_noteRecord"></seealso>
public class BaseEquipment_inventory_finance_noteRecord : PrimaryKeyRecord
{

	public readonly static Equipment_inventory_finance_noteTable TableUtils = Equipment_inventory_finance_noteTable.Instance;

	// Constructors
 
	protected BaseEquipment_inventory_finance_noteRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_inventory_finance_noteRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_inventory_finance_noteRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_inventory_finance_noteRecord_ReadRecord); 
	}

	protected BaseEquipment_inventory_finance_noteRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_inventory_finance_noteRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_inventory_finance_noteRecord Equipment_inventory_finance_noteRec = (Equipment_inventory_finance_noteRecord)sender;
        if(Equipment_inventory_finance_noteRec != null && !Equipment_inventory_finance_noteRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_inventory_finance_noteRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_inventory_finance_noteRecord Equipment_inventory_finance_noteRec = (Equipment_inventory_finance_noteRecord)sender;
        Validate_Inserting();
        if(Equipment_inventory_finance_noteRec != null && !Equipment_inventory_finance_noteRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_inventory_finance_noteRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_inventory_finance_noteRecord Equipment_inventory_finance_noteRec = (Equipment_inventory_finance_noteRecord)sender;
        Validate_Updating();
        if(Equipment_inventory_finance_noteRec != null && !Equipment_inventory_finance_noteRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note_id field.
	/// </summary>
	public ColumnValue Getequip_finance_note_idValue()
	{
		return this.GetValue(TableUtils.equip_finance_note_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note_id field.
	/// </summary>
	public Decimal Getequip_finance_note_idFieldValue()
	{
		return this.GetValue(TableUtils.equip_finance_note_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note_datetime field.
	/// </summary>
	public ColumnValue Getequip_finance_note_datetimeValue()
	{
		return this.GetValue(TableUtils.equip_finance_note_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note_datetime field.
	/// </summary>
	public DateTime Getequip_finance_note_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.equip_finance_note_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_datetime field.
	/// </summary>
	public void Setequip_finance_note_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equip_finance_note_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_datetime field.
	/// </summary>
	public void Setequip_finance_note_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.equip_finance_note_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_datetime field.
	/// </summary>
	public void Setequip_finance_note_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_finance_note_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note field.
	/// </summary>
	public ColumnValue Getequip_finance_noteValue()
	{
		return this.GetValue(TableUtils.equip_finance_noteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note field.
	/// </summary>
	public string Getequip_finance_noteFieldValue()
	{
		return this.GetValue(TableUtils.equip_finance_noteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note field.
	/// </summary>
	public void Setequip_finance_noteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equip_finance_noteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note field.
	/// </summary>
	public void Setequip_finance_noteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_finance_noteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note_enteredby field.
	/// </summary>
	public ColumnValue Getequip_finance_note_enteredbyValue()
	{
		return this.GetValue(TableUtils.equip_finance_note_enteredbyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note_enteredby field.
	/// </summary>
	public Int32 Getequip_finance_note_enteredbyFieldValue()
	{
		return this.GetValue(TableUtils.equip_finance_note_enteredbyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_enteredby field.
	/// </summary>
	public void Setequip_finance_note_enteredbyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equip_finance_note_enteredbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_enteredby field.
	/// </summary>
	public void Setequip_finance_note_enteredbyFieldValue(string val)
	{
		this.SetString(val, TableUtils.equip_finance_note_enteredbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_enteredby field.
	/// </summary>
	public void Setequip_finance_note_enteredbyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_finance_note_enteredbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_enteredby field.
	/// </summary>
	public void Setequip_finance_note_enteredbyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_finance_note_enteredbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_enteredby field.
	/// </summary>
	public void Setequip_finance_note_enteredbyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_finance_note_enteredbyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equipment_id field.
	/// </summary>
	public ColumnValue Getequipment_idValue()
	{
		return this.GetValue(TableUtils.equipment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_finance_note_.equipment_id field.
	/// </summary>
	public Decimal Getequipment_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equipment_id field.
	/// </summary>
	public void Setequipment_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equipment_id field.
	/// </summary>
	public void Setequipment_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equipment_id field.
	/// </summary>
	public void Setequipment_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equipment_id field.
	/// </summary>
	public void Setequipment_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equipment_id field.
	/// </summary>
	public void Setequipment_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note_id field.
	/// </summary>
	public Decimal equip_finance_note_id
	{
		get
		{
			return this.GetValue(TableUtils.equip_finance_note_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_finance_note_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_finance_note_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_finance_note_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_id field.
	/// </summary>
	public string equip_finance_note_idDefault
	{
		get
		{
			return TableUtils.equip_finance_note_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note_datetime field.
	/// </summary>
	public DateTime equip_finance_note_datetime
	{
		get
		{
			return this.GetValue(TableUtils.equip_finance_note_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_finance_note_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_finance_note_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_finance_note_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_datetime field.
	/// </summary>
	public string equip_finance_note_datetimeDefault
	{
		get
		{
			return TableUtils.equip_finance_note_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note field.
	/// </summary>
	public string equip_finance_note
	{
		get
		{
			return this.GetValue(TableUtils.equip_finance_noteColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_finance_noteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_finance_noteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_finance_noteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note field.
	/// </summary>
	public string equip_finance_noteDefault
	{
		get
		{
			return TableUtils.equip_finance_noteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_finance_note_.equip_finance_note_enteredby field.
	/// </summary>
	public Int32 equip_finance_note_enteredby
	{
		get
		{
			return this.GetValue(TableUtils.equip_finance_note_enteredbyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_finance_note_enteredbyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_finance_note_enteredbySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_finance_note_enteredbyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equip_finance_note_enteredby field.
	/// </summary>
	public string equip_finance_note_enteredbyDefault
	{
		get
		{
			return TableUtils.equip_finance_note_enteredbyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_finance_note_.equipment_id field.
	/// </summary>
	public Decimal equipment_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_finance_note_.equipment_id field.
	/// </summary>
	public string equipment_idDefault
	{
		get
		{
			return TableUtils.equipment_idColumn.DefaultValue;
		}
	}


#endregion
}

}
