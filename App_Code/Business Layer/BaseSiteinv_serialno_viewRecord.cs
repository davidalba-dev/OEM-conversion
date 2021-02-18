// This class is "generated" and will be overwritten.
// Your customizations should be made in Siteinv_serialno_viewRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Siteinv_serialno_viewRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Siteinv_serialno_viewView"></see> class.
/// </remarks>
/// <seealso cref="Siteinv_serialno_viewView"></seealso>
/// <seealso cref="Siteinv_serialno_viewRecord"></seealso>
public class BaseSiteinv_serialno_viewRecord : PrimaryKeyRecord
{

	public readonly static Siteinv_serialno_viewView TableUtils = Siteinv_serialno_viewView.Instance;

	// Constructors
 
	protected BaseSiteinv_serialno_viewRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Siteinv_serialno_viewRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Siteinv_serialno_viewRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Siteinv_serialno_viewRecord_ReadRecord); 
	}

	protected BaseSiteinv_serialno_viewRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Siteinv_serialno_viewRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Siteinv_serialno_viewRecord Siteinv_serialno_viewRec = (Siteinv_serialno_viewRecord)sender;
        if(Siteinv_serialno_viewRec != null && !Siteinv_serialno_viewRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Siteinv_serialno_viewRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Siteinv_serialno_viewRecord Siteinv_serialno_viewRec = (Siteinv_serialno_viewRecord)sender;
        Validate_Inserting();
        if(Siteinv_serialno_viewRec != null && !Siteinv_serialno_viewRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Siteinv_serialno_viewRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Siteinv_serialno_viewRecord Siteinv_serialno_viewRec = (Siteinv_serialno_viewRecord)sender;
        Validate_Updating();
        if(Siteinv_serialno_viewRec != null && !Siteinv_serialno_viewRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.make field.
	/// </summary>
	public ColumnValue GetmakeValue()
	{
		return this.GetValue(TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.make field.
	/// </summary>
	public string GetmakeFieldValue()
	{
		return this.GetValue(TableUtils.makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.make field.
	/// </summary>
	public void SetmakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.make field.
	/// </summary>
	public void SetmakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.model field.
	/// </summary>
	public ColumnValue GetmodelValue()
	{
		return this.GetValue(TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.model field.
	/// </summary>
	public string GetmodelFieldValue()
	{
		return this.GetValue(TableUtils.modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.model field.
	/// </summary>
	public void SetmodelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.model field.
	/// </summary>
	public void SetmodelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_site_inv_id field.
	/// </summary>
	public ColumnValue Getserial_site_inv_idValue()
	{
		return this.GetValue(TableUtils.serial_site_inv_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_site_inv_id field.
	/// </summary>
	public Int32 Getserial_site_inv_idFieldValue()
	{
		return this.GetValue(TableUtils.serial_site_inv_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_site_inv_id field.
	/// </summary>
	public void Setserial_site_inv_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_site_inv_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_site_inv_id field.
	/// </summary>
	public void Setserial_site_inv_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_site_inv_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_site_inv_id field.
	/// </summary>
	public void Setserial_site_inv_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_site_inv_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_site_inv_id field.
	/// </summary>
	public void Setserial_site_inv_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_site_inv_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_site_inv_id field.
	/// </summary>
	public void Setserial_site_inv_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_site_inv_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.category field.
	/// </summary>
	public ColumnValue GetcategoryValue()
	{
		return this.GetValue(TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.category field.
	/// </summary>
	public string GetcategoryFieldValue()
	{
		return this.GetValue(TableUtils.categoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.category field.
	/// </summary>
	public void SetcategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.category field.
	/// </summary>
	public void SetcategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.categoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.condition_id field.
	/// </summary>
	public ColumnValue Getcondition_idValue()
	{
		return this.GetValue(TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.condition_id field.
	/// </summary>
	public Int32 Getcondition_idFieldValue()
	{
		return this.GetValue(TableUtils.condition_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.date_added field.
	/// </summary>
	public ColumnValue Getdate_addedValue()
	{
		return this.GetValue(TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.date_added field.
	/// </summary>
	public DateTime Getdate_addedFieldValue()
	{
		return this.GetValue(TableUtils.date_addedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_addedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.added_by field.
	/// </summary>
	public ColumnValue Getadded_byValue()
	{
		return this.GetValue(TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.added_by field.
	/// </summary>
	public Int32 Getadded_byFieldValue()
	{
		return this.GetValue(TableUtils.added_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.dept_id field.
	/// </summary>
	public ColumnValue Getdept_idValue()
	{
		return this.GetValue(TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.dept_id field.
	/// </summary>
	public Int32 Getdept_idFieldValue()
	{
		return this.GetValue(TableUtils.dept_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.notes field.
	/// </summary>
	public ColumnValue GetnotesValue()
	{
		return this.GetValue(TableUtils.notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.notes field.
	/// </summary>
	public string GetnotesFieldValue()
	{
		return this.GetValue(TableUtils.notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.notes field.
	/// </summary>
	public void SetnotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.notes field.
	/// </summary>
	public void SetnotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.inventory_loc_id field.
	/// </summary>
	public ColumnValue Getinventory_loc_idValue()
	{
		return this.GetValue(TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.inventory_loc_id field.
	/// </summary>
	public Int32 Getinventory_loc_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_loc_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.site_inventory_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.site_inventory_id field.
	/// </summary>
	public Int32 Getsite_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_no_id field.
	/// </summary>
	public ColumnValue Getserial_no_idValue()
	{
		return this.GetValue(TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_no_id field.
	/// </summary>
	public Int32 Getserial_no_idFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_no_date_added field.
	/// </summary>
	public ColumnValue Getserial_no_date_addedValue()
	{
		return this.GetValue(TableUtils.serial_no_date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_no_date_added field.
	/// </summary>
	public DateTime Getserial_no_date_addedFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_date_addedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_date_added field.
	/// </summary>
	public void Setserial_no_date_addedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_no_date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_date_added field.
	/// </summary>
	public void Setserial_no_date_addedFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_no_date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_date_added field.
	/// </summary>
	public void Setserial_no_date_addedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_date_addedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_no field.
	/// </summary>
	public ColumnValue Getserial_noValue()
	{
		return this.GetValue(TableUtils.serial_noColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_no field.
	/// </summary>
	public string Getserial_noFieldValue()
	{
		return this.GetValue(TableUtils.serial_noColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no field.
	/// </summary>
	public void Setserial_noFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_noColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no field.
	/// </summary>
	public void Setserial_noFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_noColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_no_date_removed field.
	/// </summary>
	public ColumnValue Getserial_no_date_removedValue()
	{
		return this.GetValue(TableUtils.serial_no_date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.serial_no_date_removed field.
	/// </summary>
	public DateTime Getserial_no_date_removedFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_date_removedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_date_removed field.
	/// </summary>
	public void Setserial_no_date_removedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_no_date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_date_removed field.
	/// </summary>
	public void Setserial_no_date_removedFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_no_date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_date_removed field.
	/// </summary>
	public void Setserial_no_date_removedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_date_removedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.date_removed field.
	/// </summary>
	public ColumnValue Getdate_removedValue()
	{
		return this.GetValue(TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.date_removed field.
	/// </summary>
	public DateTime Getdate_removedFieldValue()
	{
		return this.GetValue(TableUtils.date_removedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_removedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.category_name field.
	/// </summary>
	public ColumnValue Getcategory_nameValue()
	{
		return this.GetValue(TableUtils.category_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's siteinv_serialno_view_.category_name field.
	/// </summary>
	public string Getcategory_nameFieldValue()
	{
		return this.GetValue(TableUtils.category_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.category_name field.
	/// </summary>
	public void Setcategory_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.category_name field.
	/// </summary>
	public void Setcategory_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_nameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.make field.
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
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.make field.
	/// </summary>
	public string makeDefault
	{
		get
		{
			return TableUtils.makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.model field.
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
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.model field.
	/// </summary>
	public string modelDefault
	{
		get
		{
			return TableUtils.modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.serial_site_inv_id field.
	/// </summary>
	public Int32 serial_site_inv_id
	{
		get
		{
			return this.GetValue(TableUtils.serial_site_inv_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_site_inv_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_site_inv_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_site_inv_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_site_inv_id field.
	/// </summary>
	public string serial_site_inv_idDefault
	{
		get
		{
			return TableUtils.serial_site_inv_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.category field.
	/// </summary>
	public string category
	{
		get
		{
			return this.GetValue(TableUtils.categoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.categoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool categorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.categoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.category field.
	/// </summary>
	public string categoryDefault
	{
		get
		{
			return TableUtils.categoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.condition_id field.
	/// </summary>
	public Int32 condition_id
	{
		get
		{
			return this.GetValue(TableUtils.condition_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.condition_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool condition_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.condition_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.condition_id field.
	/// </summary>
	public string condition_idDefault
	{
		get
		{
			return TableUtils.condition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.date_added field.
	/// </summary>
	public DateTime date_added
	{
		get
		{
			return this.GetValue(TableUtils.date_addedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_addedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_addedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_addedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.date_added field.
	/// </summary>
	public string date_addedDefault
	{
		get
		{
			return TableUtils.date_addedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.added_by field.
	/// </summary>
	public Int32 added_by
	{
		get
		{
			return this.GetValue(TableUtils.added_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.added_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool added_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.added_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.added_by field.
	/// </summary>
	public string added_byDefault
	{
		get
		{
			return TableUtils.added_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.dept_id field.
	/// </summary>
	public Int32 dept_id
	{
		get
		{
			return this.GetValue(TableUtils.dept_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dept_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dept_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dept_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.dept_id field.
	/// </summary>
	public string dept_idDefault
	{
		get
		{
			return TableUtils.dept_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.notes field.
	/// </summary>
	public string notes
	{
		get
		{
			return this.GetValue(TableUtils.notesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.notesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool notesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.notesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.notes field.
	/// </summary>
	public string notesDefault
	{
		get
		{
			return TableUtils.notesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.inventory_loc_id field.
	/// </summary>
	public Int32 inventory_loc_id
	{
		get
		{
			return this.GetValue(TableUtils.inventory_loc_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.inventory_loc_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool inventory_loc_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.inventory_loc_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.inventory_loc_id field.
	/// </summary>
	public string inventory_loc_idDefault
	{
		get
		{
			return TableUtils.inventory_loc_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.site_inventory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.site_inventory_id field.
	/// </summary>
	public string site_inventory_idDefault
	{
		get
		{
			return TableUtils.site_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.serial_no_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_id field.
	/// </summary>
	public string serial_no_idDefault
	{
		get
		{
			return TableUtils.serial_no_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.serial_no_date_added field.
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
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_date_added field.
	/// </summary>
	public string serial_no_date_addedDefault
	{
		get
		{
			return TableUtils.serial_no_date_addedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.serial_no field.
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
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no field.
	/// </summary>
	public string serial_noDefault
	{
		get
		{
			return TableUtils.serial_noColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.serial_no_date_removed field.
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
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.serial_no_date_removed field.
	/// </summary>
	public string serial_no_date_removedDefault
	{
		get
		{
			return TableUtils.serial_no_date_removedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.date_removed field.
	/// </summary>
	public DateTime date_removed
	{
		get
		{
			return this.GetValue(TableUtils.date_removedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_removedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_removedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_removedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.date_removed field.
	/// </summary>
	public string date_removedDefault
	{
		get
		{
			return TableUtils.date_removedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's siteinv_serialno_view_.category_name field.
	/// </summary>
	public string category_name
	{
		get
		{
			return this.GetValue(TableUtils.category_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.category_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool category_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.category_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's siteinv_serialno_view_.category_name field.
	/// </summary>
	public string category_nameDefault
	{
		get
		{
			return TableUtils.category_nameColumn.DefaultValue;
		}
	}


#endregion
}

}
