// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_inventory_listingsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_inventory_listingsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_inventory_listingsTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_inventory_listingsTable"></seealso>
/// <seealso cref="Equipment_inventory_listingsRecord"></seealso>
public class BaseEquipment_inventory_listingsRecord : PrimaryKeyRecord
{

	public readonly static Equipment_inventory_listingsTable TableUtils = Equipment_inventory_listingsTable.Instance;

	// Constructors
 
	protected BaseEquipment_inventory_listingsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_inventory_listingsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_inventory_listingsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_inventory_listingsRecord_ReadRecord); 
	}

	protected BaseEquipment_inventory_listingsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_inventory_listingsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_inventory_listingsRecord Equipment_inventory_listingsRec = (Equipment_inventory_listingsRecord)sender;
        if(Equipment_inventory_listingsRec != null && !Equipment_inventory_listingsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_inventory_listingsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_inventory_listingsRecord Equipment_inventory_listingsRec = (Equipment_inventory_listingsRecord)sender;
        Validate_Inserting();
        if(Equipment_inventory_listingsRec != null && !Equipment_inventory_listingsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_inventory_listingsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_inventory_listingsRecord Equipment_inventory_listingsRec = (Equipment_inventory_listingsRecord)sender;
        Validate_Updating();
        if(Equipment_inventory_listingsRec != null && !Equipment_inventory_listingsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.equipment_inventory_listing_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_listing_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.equipment_inventory_listing_id field.
	/// </summary>
	public Decimal Getequipment_inventory_listing_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_listing_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.inventory_id field.
	/// </summary>
	public ColumnValue Getinventory_idValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.inventory_id field.
	/// </summary>
	public Decimal Getinventory_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.equipment_inventory_sales_method_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_sales_method_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_sales_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.equipment_inventory_sales_method_id field.
	/// </summary>
	public Decimal Getequipment_inventory_sales_method_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_sales_method_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.equipment_inventory_sales_method_id field.
	/// </summary>
	public void Setequipment_inventory_sales_method_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_sales_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.equipment_inventory_sales_method_id field.
	/// </summary>
	public void Setequipment_inventory_sales_method_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_sales_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.equipment_inventory_sales_method_id field.
	/// </summary>
	public void Setequipment_inventory_sales_method_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_sales_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.equipment_inventory_sales_method_id field.
	/// </summary>
	public void Setequipment_inventory_sales_method_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_sales_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.equipment_inventory_sales_method_id field.
	/// </summary>
	public void Setequipment_inventory_sales_method_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_sales_method_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_start_date field.
	/// </summary>
	public ColumnValue Getlisting_start_dateValue()
	{
		return this.GetValue(TableUtils.listing_start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_start_date field.
	/// </summary>
	public DateTime Getlisting_start_dateFieldValue()
	{
		return this.GetValue(TableUtils.listing_start_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_start_date field.
	/// </summary>
	public void Setlisting_start_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.listing_start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_start_date field.
	/// </summary>
	public void Setlisting_start_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.listing_start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_start_date field.
	/// </summary>
	public void Setlisting_start_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_start_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_end_date field.
	/// </summary>
	public ColumnValue Getlisting_end_dateValue()
	{
		return this.GetValue(TableUtils.listing_end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_end_date field.
	/// </summary>
	public DateTime Getlisting_end_dateFieldValue()
	{
		return this.GetValue(TableUtils.listing_end_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_end_date field.
	/// </summary>
	public void Setlisting_end_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.listing_end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_end_date field.
	/// </summary>
	public void Setlisting_end_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.listing_end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_end_date field.
	/// </summary>
	public void Setlisting_end_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_end_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.days_on_market field.
	/// </summary>
	public ColumnValue Getdays_on_marketValue()
	{
		return this.GetValue(TableUtils.days_on_marketColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.days_on_market field.
	/// </summary>
	public Int32 Getdays_on_marketFieldValue()
	{
		return this.GetValue(TableUtils.days_on_marketColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_amount field.
	/// </summary>
	public ColumnValue Getlisting_amountValue()
	{
		return this.GetValue(TableUtils.listing_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_amount field.
	/// </summary>
	public Decimal Getlisting_amountFieldValue()
	{
		return this.GetValue(TableUtils.listing_amountColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_amount field.
	/// </summary>
	public void Setlisting_amountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.listing_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_amount field.
	/// </summary>
	public void Setlisting_amountFieldValue(string val)
	{
		this.SetString(val, TableUtils.listing_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_amount field.
	/// </summary>
	public void Setlisting_amountFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_amount field.
	/// </summary>
	public void Setlisting_amountFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_amount field.
	/// </summary>
	public void Setlisting_amountFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_amountColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_url field.
	/// </summary>
	public ColumnValue Getlisting_urlValue()
	{
		return this.GetValue(TableUtils.listing_urlColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_url field.
	/// </summary>
	public string Getlisting_urlFieldValue()
	{
		return this.GetValue(TableUtils.listing_urlColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_url field.
	/// </summary>
	public void Setlisting_urlFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.listing_urlColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_url field.
	/// </summary>
	public void Setlisting_urlFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_urlColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_removal_confirm_date field.
	/// </summary>
	public ColumnValue Getlisting_removal_confirm_dateValue()
	{
		return this.GetValue(TableUtils.listing_removal_confirm_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_removal_confirm_date field.
	/// </summary>
	public DateTime Getlisting_removal_confirm_dateFieldValue()
	{
		return this.GetValue(TableUtils.listing_removal_confirm_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirm_date field.
	/// </summary>
	public void Setlisting_removal_confirm_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.listing_removal_confirm_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirm_date field.
	/// </summary>
	public void Setlisting_removal_confirm_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.listing_removal_confirm_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirm_date field.
	/// </summary>
	public void Setlisting_removal_confirm_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_removal_confirm_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_removal_confirmed_by field.
	/// </summary>
	public ColumnValue Getlisting_removal_confirmed_byValue()
	{
		return this.GetValue(TableUtils.listing_removal_confirmed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_removal_confirmed_by field.
	/// </summary>
	public Int32 Getlisting_removal_confirmed_byFieldValue()
	{
		return this.GetValue(TableUtils.listing_removal_confirmed_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirmed_by field.
	/// </summary>
	public void Setlisting_removal_confirmed_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.listing_removal_confirmed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirmed_by field.
	/// </summary>
	public void Setlisting_removal_confirmed_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.listing_removal_confirmed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirmed_by field.
	/// </summary>
	public void Setlisting_removal_confirmed_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_removal_confirmed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirmed_by field.
	/// </summary>
	public void Setlisting_removal_confirmed_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_removal_confirmed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirmed_by field.
	/// </summary>
	public void Setlisting_removal_confirmed_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_removal_confirmed_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_type field.
	/// </summary>
	public ColumnValue Getlisting_typeValue()
	{
		return this.GetValue(TableUtils.listing_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_listings_.listing_type field.
	/// </summary>
	public string Getlisting_typeFieldValue()
	{
		return this.GetValue(TableUtils.listing_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_type field.
	/// </summary>
	public void Setlisting_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.listing_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_type field.
	/// </summary>
	public void Setlisting_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_typeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.equipment_inventory_listing_id field.
	/// </summary>
	public Decimal equipment_inventory_listing_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_listing_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_listing_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_listing_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_listing_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.equipment_inventory_listing_id field.
	/// </summary>
	public string equipment_inventory_listing_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_listing_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.inventory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.inventory_id field.
	/// </summary>
	public string inventory_idDefault
	{
		get
		{
			return TableUtils.inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.equipment_inventory_sales_method_id field.
	/// </summary>
	public Decimal equipment_inventory_sales_method_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_sales_method_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_sales_method_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_sales_method_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_sales_method_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.equipment_inventory_sales_method_id field.
	/// </summary>
	public string equipment_inventory_sales_method_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_sales_method_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.listing_start_date field.
	/// </summary>
	public DateTime listing_start_date
	{
		get
		{
			return this.GetValue(TableUtils.listing_start_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.listing_start_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool listing_start_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.listing_start_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_start_date field.
	/// </summary>
	public string listing_start_dateDefault
	{
		get
		{
			return TableUtils.listing_start_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.technician_id field.
	/// </summary>
	public Int32 technician_id
	{
		get
		{
			return this.GetValue(TableUtils.technician_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.technician_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technician_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technician_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.listing_end_date field.
	/// </summary>
	public DateTime listing_end_date
	{
		get
		{
			return this.GetValue(TableUtils.listing_end_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.listing_end_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool listing_end_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.listing_end_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_end_date field.
	/// </summary>
	public string listing_end_dateDefault
	{
		get
		{
			return TableUtils.listing_end_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.days_on_market field.
	/// </summary>
	public Int32 days_on_market
	{
		get
		{
			return this.GetValue(TableUtils.days_on_marketColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.days_on_marketColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool days_on_marketSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.days_on_marketColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.days_on_market field.
	/// </summary>
	public string days_on_marketDefault
	{
		get
		{
			return TableUtils.days_on_marketColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.listing_amount field.
	/// </summary>
	public Decimal listing_amount
	{
		get
		{
			return this.GetValue(TableUtils.listing_amountColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.listing_amountColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool listing_amountSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.listing_amountColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_amount field.
	/// </summary>
	public string listing_amountDefault
	{
		get
		{
			return TableUtils.listing_amountColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.listing_url field.
	/// </summary>
	public string listing_url
	{
		get
		{
			return this.GetValue(TableUtils.listing_urlColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.listing_urlColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool listing_urlSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.listing_urlColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_url field.
	/// </summary>
	public string listing_urlDefault
	{
		get
		{
			return TableUtils.listing_urlColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.listing_removal_confirm_date field.
	/// </summary>
	public DateTime listing_removal_confirm_date
	{
		get
		{
			return this.GetValue(TableUtils.listing_removal_confirm_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.listing_removal_confirm_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool listing_removal_confirm_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.listing_removal_confirm_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirm_date field.
	/// </summary>
	public string listing_removal_confirm_dateDefault
	{
		get
		{
			return TableUtils.listing_removal_confirm_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.listing_removal_confirmed_by field.
	/// </summary>
	public Int32 listing_removal_confirmed_by
	{
		get
		{
			return this.GetValue(TableUtils.listing_removal_confirmed_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.listing_removal_confirmed_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool listing_removal_confirmed_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.listing_removal_confirmed_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_removal_confirmed_by field.
	/// </summary>
	public string listing_removal_confirmed_byDefault
	{
		get
		{
			return TableUtils.listing_removal_confirmed_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_listings_.listing_type field.
	/// </summary>
	public string listing_type
	{
		get
		{
			return this.GetValue(TableUtils.listing_typeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.listing_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool listing_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.listing_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_listings_.listing_type field.
	/// </summary>
	public string listing_typeDefault
	{
		get
		{
			return TableUtils.listing_typeColumn.DefaultValue;
		}
	}


#endregion
}

}
