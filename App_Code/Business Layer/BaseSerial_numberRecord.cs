// This class is "generated" and will be overwritten.
// Your customizations should be made in Serial_numberRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Serial_numberRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Serial_numberTable"></see> class.
/// </remarks>
/// <seealso cref="Serial_numberTable"></seealso>
/// <seealso cref="Serial_numberRecord"></seealso>
public class BaseSerial_numberRecord : PrimaryKeyRecord
{

	public readonly static Serial_numberTable TableUtils = Serial_numberTable.Instance;

	// Constructors
 
	protected BaseSerial_numberRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Serial_numberRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Serial_numberRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Serial_numberRecord_ReadRecord); 
	}

	protected BaseSerial_numberRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Serial_numberRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Serial_numberRecord Serial_numberRec = (Serial_numberRecord)sender;
        if(Serial_numberRec != null && !Serial_numberRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Serial_numberRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Serial_numberRecord Serial_numberRec = (Serial_numberRecord)sender;
        Validate_Inserting();
        if(Serial_numberRec != null && !Serial_numberRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Serial_numberRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Serial_numberRecord Serial_numberRec = (Serial_numberRecord)sender;
        Validate_Updating();
        if(Serial_numberRec != null && !Serial_numberRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_id field.
	/// </summary>
	public ColumnValue Getserial_no_idValue()
	{
		return this.GetValue(TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_id field.
	/// </summary>
	public Int32 Getserial_no_idFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.site_inventory_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.site_inventory_id field.
	/// </summary>
	public Int32 Getsite_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no field.
	/// </summary>
	public ColumnValue Getserial_noValue()
	{
		return this.GetValue(TableUtils.serial_noColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no field.
	/// </summary>
	public string Getserial_noFieldValue()
	{
		return this.GetValue(TableUtils.serial_noColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no field.
	/// </summary>
	public void Setserial_noFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_noColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no field.
	/// </summary>
	public void Setserial_noFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_noColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_date_added field.
	/// </summary>
	public ColumnValue Getserial_no_date_addedValue()
	{
		return this.GetValue(TableUtils.serial_no_date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_date_added field.
	/// </summary>
	public DateTime Getserial_no_date_addedFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_date_addedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_date_added field.
	/// </summary>
	public void Setserial_no_date_addedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_no_date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_date_added field.
	/// </summary>
	public void Setserial_no_date_addedFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_no_date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_date_added field.
	/// </summary>
	public void Setserial_no_date_addedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_date_addedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_date_removed field.
	/// </summary>
	public ColumnValue Getserial_no_date_removedValue()
	{
		return this.GetValue(TableUtils.serial_no_date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_date_removed field.
	/// </summary>
	public DateTime Getserial_no_date_removedFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_date_removedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_date_removed field.
	/// </summary>
	public void Setserial_no_date_removedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_no_date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_date_removed field.
	/// </summary>
	public void Setserial_no_date_removedFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_no_date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_date_removed field.
	/// </summary>
	public void Setserial_no_date_removedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_date_removedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_added_by field.
	/// </summary>
	public ColumnValue Getserial_no_added_byValue()
	{
		return this.GetValue(TableUtils.serial_no_added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_added_by field.
	/// </summary>
	public Int32 Getserial_no_added_byFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_added_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_added_by field.
	/// </summary>
	public void Setserial_no_added_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_no_added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_added_by field.
	/// </summary>
	public void Setserial_no_added_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_no_added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_added_by field.
	/// </summary>
	public void Setserial_no_added_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_added_by field.
	/// </summary>
	public void Setserial_no_added_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_added_by field.
	/// </summary>
	public void Setserial_no_added_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_added_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_removed_by field.
	/// </summary>
	public ColumnValue Getserial_no_removed_byValue()
	{
		return this.GetValue(TableUtils.serial_no_removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.serial_no_removed_by field.
	/// </summary>
	public Int32 Getserial_no_removed_byFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_removed_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_removed_by field.
	/// </summary>
	public void Setserial_no_removed_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_no_removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_removed_by field.
	/// </summary>
	public void Setserial_no_removed_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_no_removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_removed_by field.
	/// </summary>
	public void Setserial_no_removed_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_removed_by field.
	/// </summary>
	public void Setserial_no_removed_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_removed_by field.
	/// </summary>
	public void Setserial_no_removed_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_removed_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's serial_number_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's serial_number_.serial_no_id field.
	/// </summary>
	public Int32 serial_no_id
	{
		get
		{
			return this.GetValue(TableUtils.serial_no_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_no_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_no_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_no_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_id field.
	/// </summary>
	public string serial_no_idDefault
	{
		get
		{
			return TableUtils.serial_no_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's serial_number_.site_inventory_id field.
	/// </summary>
	public Int32 site_inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.site_inventory_id field.
	/// </summary>
	public string site_inventory_idDefault
	{
		get
		{
			return TableUtils.site_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's serial_number_.serial_no field.
	/// </summary>
	public string serial_no
	{
		get
		{
			return this.GetValue(TableUtils.serial_noColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_noColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_noSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_noColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no field.
	/// </summary>
	public string serial_noDefault
	{
		get
		{
			return TableUtils.serial_noColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's serial_number_.serial_no_date_added field.
	/// </summary>
	public DateTime serial_no_date_added
	{
		get
		{
			return this.GetValue(TableUtils.serial_no_date_addedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_no_date_addedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_no_date_addedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_no_date_addedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_date_added field.
	/// </summary>
	public string serial_no_date_addedDefault
	{
		get
		{
			return TableUtils.serial_no_date_addedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's serial_number_.serial_no_date_removed field.
	/// </summary>
	public DateTime serial_no_date_removed
	{
		get
		{
			return this.GetValue(TableUtils.serial_no_date_removedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_no_date_removedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_no_date_removedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_no_date_removedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_date_removed field.
	/// </summary>
	public string serial_no_date_removedDefault
	{
		get
		{
			return TableUtils.serial_no_date_removedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's serial_number_.serial_no_added_by field.
	/// </summary>
	public Int32 serial_no_added_by
	{
		get
		{
			return this.GetValue(TableUtils.serial_no_added_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_no_added_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_no_added_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_no_added_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_added_by field.
	/// </summary>
	public string serial_no_added_byDefault
	{
		get
		{
			return TableUtils.serial_no_added_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's serial_number_.serial_no_removed_by field.
	/// </summary>
	public Int32 serial_no_removed_by
	{
		get
		{
			return this.GetValue(TableUtils.serial_no_removed_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_no_removed_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_no_removed_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_no_removed_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.serial_no_removed_by field.
	/// </summary>
	public string serial_no_removed_byDefault
	{
		get
		{
			return TableUtils.serial_no_removed_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's serial_number_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's serial_number_.custno field.
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
