// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_current_inventory_locationRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_current_inventory_locationRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_current_inventory_locationView"></see> class.
/// </remarks>
/// <seealso cref="Vw_current_inventory_locationView"></seealso>
/// <seealso cref="Vw_current_inventory_locationRecord"></seealso>
public class BaseVw_current_inventory_locationRecord : KeylessRecord
{

	public readonly static Vw_current_inventory_locationView TableUtils = Vw_current_inventory_locationView.Instance;

	// Constructors
 
	protected BaseVw_current_inventory_locationRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_current_inventory_locationRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_current_inventory_locationRecord_InsertingRecord);     
	}

	protected BaseVw_current_inventory_locationRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_current_inventory_locationRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_current_inventory_locationRecord Vw_current_inventory_locationRec = (Vw_current_inventory_locationRecord)sender;
        if(Vw_current_inventory_locationRec != null && !Vw_current_inventory_locationRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_current_inventory_locationRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_current_inventory_locationRecord Vw_current_inventory_locationRec = (Vw_current_inventory_locationRecord)sender;
        Validate_Inserting();
        if(Vw_current_inventory_locationRec != null && !Vw_current_inventory_locationRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_id field.
	/// </summary>
	public ColumnValue Getwarehouse_idValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_id field.
	/// </summary>
	public Decimal Getwarehouse_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_location_id field.
	/// </summary>
	public ColumnValue Getwarehouse_location_idValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_location_id field.
	/// </summary>
	public Decimal Getwarehouse_location_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.datetime_entered field.
	/// </summary>
	public ColumnValue Getdatetime_enteredValue()
	{
		return this.GetValue(TableUtils.datetime_enteredColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.datetime_entered field.
	/// </summary>
	public DateTime Getdatetime_enteredFieldValue()
	{
		return this.GetValue(TableUtils.datetime_enteredColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.datetime_entered field.
	/// </summary>
	public void Setdatetime_enteredFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.datetime_enteredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.datetime_entered field.
	/// </summary>
	public void Setdatetime_enteredFieldValue(string val)
	{
		this.SetString(val, TableUtils.datetime_enteredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.datetime_entered field.
	/// </summary>
	public void Setdatetime_enteredFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.datetime_enteredColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.inventory_id field.
	/// </summary>
	public ColumnValue Getinventory_idValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.inventory_id field.
	/// </summary>
	public Decimal Getinventory_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_location field.
	/// </summary>
	public ColumnValue Getwarehouse_locationValue()
	{
		return this.GetValue(TableUtils.warehouse_locationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_location field.
	/// </summary>
	public string Getwarehouse_locationFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_locationColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_location field.
	/// </summary>
	public void Setwarehouse_locationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_locationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_location field.
	/// </summary>
	public void Setwarehouse_locationFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_locationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_name field.
	/// </summary>
	public ColumnValue Getwarehouse_nameValue()
	{
		return this.GetValue(TableUtils.warehouse_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_name field.
	/// </summary>
	public string Getwarehouse_nameFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_name field.
	/// </summary>
	public void Setwarehouse_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_name field.
	/// </summary>
	public void Setwarehouse_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_nameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_id field.
	/// </summary>
	public Decimal warehouse_id
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_id field.
	/// </summary>
	public string warehouse_idDefault
	{
		get
		{
			return TableUtils.warehouse_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_location_id field.
	/// </summary>
	public Decimal warehouse_location_id
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_location_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_location_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_location_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_location_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_location_id field.
	/// </summary>
	public string warehouse_location_idDefault
	{
		get
		{
			return TableUtils.warehouse_location_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_current_inventory_location_.datetime_entered field.
	/// </summary>
	public DateTime datetime_entered
	{
		get
		{
			return this.GetValue(TableUtils.datetime_enteredColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.datetime_enteredColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool datetime_enteredSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.datetime_enteredColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.datetime_entered field.
	/// </summary>
	public string datetime_enteredDefault
	{
		get
		{
			return TableUtils.datetime_enteredColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_current_inventory_location_.inventory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.inventory_id field.
	/// </summary>
	public string inventory_idDefault
	{
		get
		{
			return TableUtils.inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_location field.
	/// </summary>
	public string warehouse_location
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_locationColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_locationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_locationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_locationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_location field.
	/// </summary>
	public string warehouse_locationDefault
	{
		get
		{
			return TableUtils.warehouse_locationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_current_inventory_location_.warehouse_name field.
	/// </summary>
	public string warehouse_name
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_current_inventory_location_.warehouse_name field.
	/// </summary>
	public string warehouse_nameDefault
	{
		get
		{
			return TableUtils.warehouse_nameColumn.DefaultValue;
		}
	}


#endregion

}

}
