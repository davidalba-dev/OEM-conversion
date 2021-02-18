// This class is "generated" and will be overwritten.
// Your customizations should be made in Loaner_inventoryRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Loaner_inventoryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Loaner_inventoryTable"></see> class.
/// </remarks>
/// <seealso cref="Loaner_inventoryTable"></seealso>
/// <seealso cref="Loaner_inventoryRecord"></seealso>
public class BaseLoaner_inventoryRecord : PrimaryKeyRecord
{

	public readonly static Loaner_inventoryTable TableUtils = Loaner_inventoryTable.Instance;

	// Constructors
 
	protected BaseLoaner_inventoryRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Loaner_inventoryRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Loaner_inventoryRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Loaner_inventoryRecord_ReadRecord); 
	}

	protected BaseLoaner_inventoryRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Loaner_inventoryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Loaner_inventoryRecord Loaner_inventoryRec = (Loaner_inventoryRecord)sender;
        if(Loaner_inventoryRec != null && !Loaner_inventoryRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Loaner_inventoryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Loaner_inventoryRecord Loaner_inventoryRec = (Loaner_inventoryRecord)sender;
        Validate_Inserting();
        if(Loaner_inventoryRec != null && !Loaner_inventoryRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Loaner_inventoryRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Loaner_inventoryRecord Loaner_inventoryRec = (Loaner_inventoryRecord)sender;
        Validate_Updating();
        if(Loaner_inventoryRec != null && !Loaner_inventoryRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.loaner_inventory_id field.
	/// </summary>
	public ColumnValue Getloaner_inventory_idValue()
	{
		return this.GetValue(TableUtils.loaner_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.loaner_inventory_id field.
	/// </summary>
	public Int32 Getloaner_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.loaner_inventory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.make field.
	/// </summary>
	public ColumnValue GetmakeValue()
	{
		return this.GetValue(TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.make field.
	/// </summary>
	public string GetmakeFieldValue()
	{
		return this.GetValue(TableUtils.makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.make field.
	/// </summary>
	public void SetmakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.make field.
	/// </summary>
	public void SetmakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.model field.
	/// </summary>
	public ColumnValue GetmodelValue()
	{
		return this.GetValue(TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.model field.
	/// </summary>
	public string GetmodelFieldValue()
	{
		return this.GetValue(TableUtils.modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.model field.
	/// </summary>
	public void SetmodelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.model field.
	/// </summary>
	public void SetmodelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.serial_number field.
	/// </summary>
	public ColumnValue Getserial_numberValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.serial_number field.
	/// </summary>
	public string Getserial_numberFieldValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.loaner_type_id field.
	/// </summary>
	public ColumnValue Getloaner_type_idValue()
	{
		return this.GetValue(TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.loaner_type_id field.
	/// </summary>
	public Int32 Getloaner_type_idFieldValue()
	{
		return this.GetValue(TableUtils.loaner_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_type_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.loaner_inventory_comment field.
	/// </summary>
	public ColumnValue Getloaner_inventory_commentValue()
	{
		return this.GetValue(TableUtils.loaner_inventory_commentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.loaner_inventory_comment field.
	/// </summary>
	public string Getloaner_inventory_commentFieldValue()
	{
		return this.GetValue(TableUtils.loaner_inventory_commentColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_inventory_comment field.
	/// </summary>
	public void Setloaner_inventory_commentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_inventory_commentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_inventory_comment field.
	/// </summary>
	public void Setloaner_inventory_commentFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_inventory_commentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.loaner_active field.
	/// </summary>
	public ColumnValue Getloaner_activeValue()
	{
		return this.GetValue(TableUtils.loaner_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.loaner_active field.
	/// </summary>
	public bool Getloaner_activeFieldValue()
	{
		return this.GetValue(TableUtils.loaner_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_active field.
	/// </summary>
	public void Setloaner_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_active field.
	/// </summary>
	public void Setloaner_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_active field.
	/// </summary>
	public void Setloaner_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_inventory_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_inventory_.loaner_inventory_id field.
	/// </summary>
	public Int32 loaner_inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.loaner_inventory_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_inventory_id field.
	/// </summary>
	public string loaner_inventory_idDefault
	{
		get
		{
			return TableUtils.loaner_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_inventory_.make field.
	/// </summary>
	public string make
	{
		get
		{
			return this.GetValue(TableUtils.makeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.makeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool makeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.makeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.make field.
	/// </summary>
	public string makeDefault
	{
		get
		{
			return TableUtils.makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_inventory_.model field.
	/// </summary>
	public string model
	{
		get
		{
			return this.GetValue(TableUtils.modelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.modelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool modelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.modelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.model field.
	/// </summary>
	public string modelDefault
	{
		get
		{
			return TableUtils.modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_inventory_.serial_number field.
	/// </summary>
	public string serial_number
	{
		get
		{
			return this.GetValue(TableUtils.serial_numberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_numberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_numberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_numberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.serial_number field.
	/// </summary>
	public string serial_numberDefault
	{
		get
		{
			return TableUtils.serial_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_inventory_.loaner_type_id field.
	/// </summary>
	public Int32 loaner_type_id
	{
		get
		{
			return this.GetValue(TableUtils.loaner_type_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_type_id field.
	/// </summary>
	public string loaner_type_idDefault
	{
		get
		{
			return TableUtils.loaner_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_inventory_.loaner_inventory_comment field.
	/// </summary>
	public string loaner_inventory_comment
	{
		get
		{
			return this.GetValue(TableUtils.loaner_inventory_commentColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_inventory_commentColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_inventory_commentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_inventory_commentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_inventory_comment field.
	/// </summary>
	public string loaner_inventory_commentDefault
	{
		get
		{
			return TableUtils.loaner_inventory_commentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_inventory_.loaner_active field.
	/// </summary>
	public bool loaner_active
	{
		get
		{
			return this.GetValue(TableUtils.loaner_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.loaner_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.loaner_active field.
	/// </summary>
	public string loaner_activeDefault
	{
		get
		{
			return TableUtils.loaner_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_inventory_.category_id field.
	/// </summary>
	public Int32 category_id
	{
		get
		{
			return this.GetValue(TableUtils.category_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.category_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool category_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.category_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_inventory_.category_id field.
	/// </summary>
	public string category_idDefault
	{
		get
		{
			return TableUtils.category_idColumn.DefaultValue;
		}
	}


#endregion
}

}
