// This class is "generated" and will be overwritten.
// Your customizations should be made in Inventory_locationRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Inventory_locationRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Inventory_locationTable"></see> class.
/// </remarks>
/// <seealso cref="Inventory_locationTable"></seealso>
/// <seealso cref="Inventory_locationRecord"></seealso>
public class BaseInventory_locationRecord : PrimaryKeyRecord
{

	public readonly static Inventory_locationTable TableUtils = Inventory_locationTable.Instance;

	// Constructors
 
	protected BaseInventory_locationRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Inventory_locationRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Inventory_locationRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Inventory_locationRecord_ReadRecord); 
	}

	protected BaseInventory_locationRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Inventory_locationRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Inventory_locationRecord Inventory_locationRec = (Inventory_locationRecord)sender;
        if(Inventory_locationRec != null && !Inventory_locationRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Inventory_locationRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Inventory_locationRecord Inventory_locationRec = (Inventory_locationRecord)sender;
        Validate_Inserting();
        if(Inventory_locationRec != null && !Inventory_locationRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Inventory_locationRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Inventory_locationRecord Inventory_locationRec = (Inventory_locationRecord)sender;
        Validate_Updating();
        if(Inventory_locationRec != null && !Inventory_locationRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.inventory_location_id field.
	/// </summary>
	public ColumnValue Getinventory_location_idValue()
	{
		return this.GetValue(TableUtils.inventory_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.inventory_location_id field.
	/// </summary>
	public Int32 Getinventory_location_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_location_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.inventory_name field.
	/// </summary>
	public ColumnValue Getinventory_nameValue()
	{
		return this.GetValue(TableUtils.inventory_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.inventory_name field.
	/// </summary>
	public string Getinventory_nameFieldValue()
	{
		return this.GetValue(TableUtils.inventory_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_name field.
	/// </summary>
	public void Setinventory_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_name field.
	/// </summary>
	public void Setinventory_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.inventory_loc_notes field.
	/// </summary>
	public ColumnValue Getinventory_loc_notesValue()
	{
		return this.GetValue(TableUtils.inventory_loc_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.inventory_loc_notes field.
	/// </summary>
	public string Getinventory_loc_notesFieldValue()
	{
		return this.GetValue(TableUtils.inventory_loc_notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_loc_notes field.
	/// </summary>
	public void Setinventory_loc_notesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_loc_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_loc_notes field.
	/// </summary>
	public void Setinventory_loc_notesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_notesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.inventory_loc_active field.
	/// </summary>
	public ColumnValue Getinventory_loc_activeValue()
	{
		return this.GetValue(TableUtils.inventory_loc_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.inventory_loc_active field.
	/// </summary>
	public bool Getinventory_loc_activeFieldValue()
	{
		return this.GetValue(TableUtils.inventory_loc_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_loc_active field.
	/// </summary>
	public void Setinventory_loc_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_loc_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_loc_active field.
	/// </summary>
	public void Setinventory_loc_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_loc_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_loc_active field.
	/// </summary>
	public void Setinventory_loc_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's inventory_location_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's inventory_location_.inventory_location_id field.
	/// </summary>
	public Int32 inventory_location_id
	{
		get
		{
			return this.GetValue(TableUtils.inventory_location_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.inventory_location_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool inventory_location_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.inventory_location_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_location_id field.
	/// </summary>
	public string inventory_location_idDefault
	{
		get
		{
			return TableUtils.inventory_location_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's inventory_location_.inventory_name field.
	/// </summary>
	public string inventory_name
	{
		get
		{
			return this.GetValue(TableUtils.inventory_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.inventory_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool inventory_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.inventory_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_name field.
	/// </summary>
	public string inventory_nameDefault
	{
		get
		{
			return TableUtils.inventory_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's inventory_location_.inventory_loc_notes field.
	/// </summary>
	public string inventory_loc_notes
	{
		get
		{
			return this.GetValue(TableUtils.inventory_loc_notesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.inventory_loc_notesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool inventory_loc_notesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.inventory_loc_notesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_loc_notes field.
	/// </summary>
	public string inventory_loc_notesDefault
	{
		get
		{
			return TableUtils.inventory_loc_notesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's inventory_location_.inventory_loc_active field.
	/// </summary>
	public bool inventory_loc_active
	{
		get
		{
			return this.GetValue(TableUtils.inventory_loc_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.inventory_loc_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool inventory_loc_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.inventory_loc_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.inventory_loc_active field.
	/// </summary>
	public string inventory_loc_activeDefault
	{
		get
		{
			return TableUtils.inventory_loc_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's inventory_location_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's inventory_location_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}


#endregion
}

}
