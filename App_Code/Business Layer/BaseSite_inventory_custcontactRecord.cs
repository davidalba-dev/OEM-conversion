// This class is "generated" and will be overwritten.
// Your customizations should be made in Site_inventory_custcontactRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Site_inventory_custcontactRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Site_inventory_custcontactView"></see> class.
/// </remarks>
/// <seealso cref="Site_inventory_custcontactView"></seealso>
/// <seealso cref="Site_inventory_custcontactRecord"></seealso>
public class BaseSite_inventory_custcontactRecord : KeylessRecord
{

	public readonly static Site_inventory_custcontactView TableUtils = Site_inventory_custcontactView.Instance;

	// Constructors
 
	protected BaseSite_inventory_custcontactRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Site_inventory_custcontactRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Site_inventory_custcontactRecord_InsertingRecord);     
	}

	protected BaseSite_inventory_custcontactRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Site_inventory_custcontactRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Site_inventory_custcontactRecord Site_inventory_custcontactRec = (Site_inventory_custcontactRecord)sender;
        if(Site_inventory_custcontactRec != null && !Site_inventory_custcontactRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Site_inventory_custcontactRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Site_inventory_custcontactRecord Site_inventory_custcontactRec = (Site_inventory_custcontactRecord)sender;
        Validate_Inserting();
        if(Site_inventory_custcontactRec != null && !Site_inventory_custcontactRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.site_inventory_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.site_inventory_id field.
	/// </summary>
	public Int32 Getsite_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.site_inventory_date field.
	/// </summary>
	public ColumnValue Getsite_inventory_dateValue()
	{
		return this.GetValue(TableUtils.site_inventory_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.site_inventory_date field.
	/// </summary>
	public DateTime Getsite_inventory_dateFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_date field.
	/// </summary>
	public void Setsite_inventory_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_date field.
	/// </summary>
	public void Setsite_inventory_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_date field.
	/// </summary>
	public void Setsite_inventory_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.make field.
	/// </summary>
	public ColumnValue GetmakeValue()
	{
		return this.GetValue(TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.make field.
	/// </summary>
	public string GetmakeFieldValue()
	{
		return this.GetValue(TableUtils.makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.make field.
	/// </summary>
	public void SetmakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.make field.
	/// </summary>
	public void SetmakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.model field.
	/// </summary>
	public ColumnValue GetmodelValue()
	{
		return this.GetValue(TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.model field.
	/// </summary>
	public string GetmodelFieldValue()
	{
		return this.GetValue(TableUtils.modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.model field.
	/// </summary>
	public void SetmodelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.model field.
	/// </summary>
	public void SetmodelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.category field.
	/// </summary>
	public ColumnValue GetcategoryValue()
	{
		return this.GetValue(TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.category field.
	/// </summary>
	public string GetcategoryFieldValue()
	{
		return this.GetValue(TableUtils.categoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.category field.
	/// </summary>
	public void SetcategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.category field.
	/// </summary>
	public void SetcategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.categoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.condition_id field.
	/// </summary>
	public ColumnValue Getcondition_idValue()
	{
		return this.GetValue(TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.condition_id field.
	/// </summary>
	public Int32 Getcondition_idFieldValue()
	{
		return this.GetValue(TableUtils.condition_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.date_added field.
	/// </summary>
	public ColumnValue Getdate_addedValue()
	{
		return this.GetValue(TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.date_added field.
	/// </summary>
	public DateTime Getdate_addedFieldValue()
	{
		return this.GetValue(TableUtils.date_addedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_addedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.date_removed field.
	/// </summary>
	public ColumnValue Getdate_removedValue()
	{
		return this.GetValue(TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.date_removed field.
	/// </summary>
	public DateTime Getdate_removedFieldValue()
	{
		return this.GetValue(TableUtils.date_removedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_removedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.added_by field.
	/// </summary>
	public ColumnValue Getadded_byValue()
	{
		return this.GetValue(TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.added_by field.
	/// </summary>
	public Int32 Getadded_byFieldValue()
	{
		return this.GetValue(TableUtils.added_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.removed_by field.
	/// </summary>
	public ColumnValue Getremoved_byValue()
	{
		return this.GetValue(TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.removed_by field.
	/// </summary>
	public Int32 Getremoved_byFieldValue()
	{
		return this.GetValue(TableUtils.removed_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.notes field.
	/// </summary>
	public ColumnValue GetnotesValue()
	{
		return this.GetValue(TableUtils.notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.notes field.
	/// </summary>
	public string GetnotesFieldValue()
	{
		return this.GetValue(TableUtils.notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.notes field.
	/// </summary>
	public void SetnotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.notes field.
	/// </summary>
	public void SetnotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.dept_id field.
	/// </summary>
	public ColumnValue Getdept_idValue()
	{
		return this.GetValue(TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.dept_id field.
	/// </summary>
	public Int32 Getdept_idFieldValue()
	{
		return this.GetValue(TableUtils.dept_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.inventory_loc_id field.
	/// </summary>
	public ColumnValue Getinventory_loc_idValue()
	{
		return this.GetValue(TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.inventory_loc_id field.
	/// </summary>
	public Int32 Getinventory_loc_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_loc_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.image1 field.
	/// </summary>
	public ColumnValue Getimage1Value()
	{
		return this.GetValue(TableUtils.image1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.image1 field.
	/// </summary>
	public byte[] Getimage1FieldValue()
	{
		return this.GetValue(TableUtils.image1Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image1 field.
	/// </summary>
	public void Setimage1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.image1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image1 field.
	/// </summary>
	public void Setimage1FieldValue(string val)
	{
		this.SetString(val, TableUtils.image1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image1 field.
	/// </summary>
	public void Setimage1FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.image1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.image2 field.
	/// </summary>
	public ColumnValue Getimage2Value()
	{
		return this.GetValue(TableUtils.image2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.image2 field.
	/// </summary>
	public byte[] Getimage2FieldValue()
	{
		return this.GetValue(TableUtils.image2Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image2 field.
	/// </summary>
	public void Setimage2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.image2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image2 field.
	/// </summary>
	public void Setimage2FieldValue(string val)
	{
		this.SetString(val, TableUtils.image2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image2 field.
	/// </summary>
	public void Setimage2FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.image2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.image3 field.
	/// </summary>
	public ColumnValue Getimage3Value()
	{
		return this.GetValue(TableUtils.image3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.image3 field.
	/// </summary>
	public byte[] Getimage3FieldValue()
	{
		return this.GetValue(TableUtils.image3Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image3 field.
	/// </summary>
	public void Setimage3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.image3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image3 field.
	/// </summary>
	public void Setimage3FieldValue(string val)
	{
		this.SetString(val, TableUtils.image3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image3 field.
	/// </summary>
	public void Setimage3FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.image3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.serial_no_id field.
	/// </summary>
	public ColumnValue Getserial_no_idValue()
	{
		return this.GetValue(TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.serial_no_id field.
	/// </summary>
	public Int32 Getserial_no_idFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_id field.
	/// </summary>
	public void Setserial_no_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.serial_no_date_removed field.
	/// </summary>
	public ColumnValue Getserial_no_date_removedValue()
	{
		return this.GetValue(TableUtils.serial_no_date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.serial_no_date_removed field.
	/// </summary>
	public DateTime Getserial_no_date_removedFieldValue()
	{
		return this.GetValue(TableUtils.serial_no_date_removedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_date_removed field.
	/// </summary>
	public void Setserial_no_date_removedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_no_date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_date_removed field.
	/// </summary>
	public void Setserial_no_date_removedFieldValue(string val)
	{
		this.SetString(val, TableUtils.serial_no_date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_date_removed field.
	/// </summary>
	public void Setserial_no_date_removedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_no_date_removedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.serial_no field.
	/// </summary>
	public ColumnValue Getserial_noValue()
	{
		return this.GetValue(TableUtils.serial_noColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.serial_no field.
	/// </summary>
	public string Getserial_noFieldValue()
	{
		return this.GetValue(TableUtils.serial_noColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no field.
	/// </summary>
	public void Setserial_noFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_noColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no field.
	/// </summary>
	public void Setserial_noFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_noColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.department_name field.
	/// </summary>
	public ColumnValue Getdepartment_nameValue()
	{
		return this.GetValue(TableUtils.department_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.department_name field.
	/// </summary>
	public string Getdepartment_nameFieldValue()
	{
		return this.GetValue(TableUtils.department_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.department_name field.
	/// </summary>
	public void Setdepartment_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.department_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.department_name field.
	/// </summary>
	public void Setdepartment_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.department_id field.
	/// </summary>
	public ColumnValue Getdepartment_idValue()
	{
		return this.GetValue(TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.department_id field.
	/// </summary>
	public Int32 Getdepartment_idFieldValue()
	{
		return this.GetValue(TableUtils.department_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.custname field.
	/// </summary>
	public ColumnValue GetcustnameValue()
	{
		return this.GetValue(TableUtils.custnameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_custcontact_.custname field.
	/// </summary>
	public string GetcustnameFieldValue()
	{
		return this.GetValue(TableUtils.custnameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.custname field.
	/// </summary>
	public void SetcustnameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.custname field.
	/// </summary>
	public void SetcustnameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.site_inventory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_id field.
	/// </summary>
	public string site_inventory_idDefault
	{
		get
		{
			return TableUtils.site_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.site_inventory_date field.
	/// </summary>
	public DateTime site_inventory_date
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.site_inventory_date field.
	/// </summary>
	public string site_inventory_dateDefault
	{
		get
		{
			return TableUtils.site_inventory_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.make field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.make field.
	/// </summary>
	public string makeDefault
	{
		get
		{
			return TableUtils.makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.model field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.model field.
	/// </summary>
	public string modelDefault
	{
		get
		{
			return TableUtils.modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.category field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.category field.
	/// </summary>
	public string categoryDefault
	{
		get
		{
			return TableUtils.categoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.condition_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.condition_id field.
	/// </summary>
	public string condition_idDefault
	{
		get
		{
			return TableUtils.condition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.date_added field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.date_added field.
	/// </summary>
	public string date_addedDefault
	{
		get
		{
			return TableUtils.date_addedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.date_removed field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.date_removed field.
	/// </summary>
	public string date_removedDefault
	{
		get
		{
			return TableUtils.date_removedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.added_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.added_by field.
	/// </summary>
	public string added_byDefault
	{
		get
		{
			return TableUtils.added_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.removed_by field.
	/// </summary>
	public Int32 removed_by
	{
		get
		{
			return this.GetValue(TableUtils.removed_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.removed_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool removed_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.removed_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.removed_by field.
	/// </summary>
	public string removed_byDefault
	{
		get
		{
			return TableUtils.removed_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.notes field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.notes field.
	/// </summary>
	public string notesDefault
	{
		get
		{
			return TableUtils.notesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.dept_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.dept_id field.
	/// </summary>
	public string dept_idDefault
	{
		get
		{
			return TableUtils.dept_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.inventory_loc_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.inventory_loc_id field.
	/// </summary>
	public string inventory_loc_idDefault
	{
		get
		{
			return TableUtils.inventory_loc_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.image1 field.
	/// </summary>
	public byte[] image1
	{
		get
		{
			return this.GetValue(TableUtils.image1Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.image1Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool image1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.image1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image1 field.
	/// </summary>
	public string image1Default
	{
		get
		{
			return TableUtils.image1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.image2 field.
	/// </summary>
	public byte[] image2
	{
		get
		{
			return this.GetValue(TableUtils.image2Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.image2Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool image2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.image2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image2 field.
	/// </summary>
	public string image2Default
	{
		get
		{
			return TableUtils.image2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.image3 field.
	/// </summary>
	public byte[] image3
	{
		get
		{
			return this.GetValue(TableUtils.image3Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.image3Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool image3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.image3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.image3 field.
	/// </summary>
	public string image3Default
	{
		get
		{
			return TableUtils.image3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.serial_no_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_id field.
	/// </summary>
	public string serial_no_idDefault
	{
		get
		{
			return TableUtils.serial_no_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.serial_no_date_removed field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no_date_removed field.
	/// </summary>
	public string serial_no_date_removedDefault
	{
		get
		{
			return TableUtils.serial_no_date_removedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.serial_no field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.serial_no field.
	/// </summary>
	public string serial_noDefault
	{
		get
		{
			return TableUtils.serial_noColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.department_name field.
	/// </summary>
	public string department_name
	{
		get
		{
			return this.GetValue(TableUtils.department_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.department_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool department_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.department_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.department_name field.
	/// </summary>
	public string department_nameDefault
	{
		get
		{
			return TableUtils.department_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.department_id field.
	/// </summary>
	public Int32 department_id
	{
		get
		{
			return this.GetValue(TableUtils.department_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.department_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool department_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.department_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.department_id field.
	/// </summary>
	public string department_idDefault
	{
		get
		{
			return TableUtils.department_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_custcontact_.custname field.
	/// </summary>
	public string custname
	{
		get
		{
			return this.GetValue(TableUtils.custnameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custnameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custnameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custnameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_custcontact_.custname field.
	/// </summary>
	public string custnameDefault
	{
		get
		{
			return TableUtils.custnameColumn.DefaultValue;
		}
	}


#endregion

}

}
