// This class is "generated" and will be overwritten.
// Your customizations should be made in Site_inventoryRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Site_inventoryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Site_inventoryTable"></see> class.
/// </remarks>
/// <seealso cref="Site_inventoryTable"></seealso>
/// <seealso cref="Site_inventoryRecord"></seealso>
public class BaseSite_inventoryRecord : PrimaryKeyRecord
{

	public readonly static Site_inventoryTable TableUtils = Site_inventoryTable.Instance;

	// Constructors
 
	protected BaseSite_inventoryRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Site_inventoryRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Site_inventoryRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Site_inventoryRecord_ReadRecord); 
	}

	protected BaseSite_inventoryRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Site_inventoryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Site_inventoryRecord Site_inventoryRec = (Site_inventoryRecord)sender;
        if(Site_inventoryRec != null && !Site_inventoryRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Site_inventoryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Site_inventoryRecord Site_inventoryRec = (Site_inventoryRecord)sender;
        Validate_Inserting();
        if(Site_inventoryRec != null && !Site_inventoryRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Site_inventoryRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Site_inventoryRecord Site_inventoryRec = (Site_inventoryRecord)sender;
        Validate_Updating();
        if(Site_inventoryRec != null && !Site_inventoryRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.site_inventory_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.site_inventory_id field.
	/// </summary>
	public Int32 Getsite_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.site_inventory_date field.
	/// </summary>
	public ColumnValue Getsite_inventory_dateValue()
	{
		return this.GetValue(TableUtils.site_inventory_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.site_inventory_date field.
	/// </summary>
	public DateTime Getsite_inventory_dateFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.site_inventory_date field.
	/// </summary>
	public void Setsite_inventory_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.site_inventory_date field.
	/// </summary>
	public void Setsite_inventory_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.site_inventory_date field.
	/// </summary>
	public void Setsite_inventory_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.make field.
	/// </summary>
	public ColumnValue GetmakeValue()
	{
		return this.GetValue(TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.make field.
	/// </summary>
	public string GetmakeFieldValue()
	{
		return this.GetValue(TableUtils.makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.make field.
	/// </summary>
	public void SetmakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.make field.
	/// </summary>
	public void SetmakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.model field.
	/// </summary>
	public ColumnValue GetmodelValue()
	{
		return this.GetValue(TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.model field.
	/// </summary>
	public string GetmodelFieldValue()
	{
		return this.GetValue(TableUtils.modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.model field.
	/// </summary>
	public void SetmodelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.model field.
	/// </summary>
	public void SetmodelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.category field.
	/// </summary>
	public ColumnValue GetcategoryValue()
	{
		return this.GetValue(TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.category field.
	/// </summary>
	public string GetcategoryFieldValue()
	{
		return this.GetValue(TableUtils.categoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.category field.
	/// </summary>
	public void SetcategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.category field.
	/// </summary>
	public void SetcategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.categoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.condition_id field.
	/// </summary>
	public ColumnValue Getcondition_idValue()
	{
		return this.GetValue(TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.condition_id field.
	/// </summary>
	public Int32 Getcondition_idFieldValue()
	{
		return this.GetValue(TableUtils.condition_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.date_added field.
	/// </summary>
	public ColumnValue Getdate_addedValue()
	{
		return this.GetValue(TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.date_added field.
	/// </summary>
	public DateTime Getdate_addedFieldValue()
	{
		return this.GetValue(TableUtils.date_addedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_addedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.date_removed field.
	/// </summary>
	public ColumnValue Getdate_removedValue()
	{
		return this.GetValue(TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.date_removed field.
	/// </summary>
	public DateTime Getdate_removedFieldValue()
	{
		return this.GetValue(TableUtils.date_removedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_removedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.added_by field.
	/// </summary>
	public ColumnValue Getadded_byValue()
	{
		return this.GetValue(TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.added_by field.
	/// </summary>
	public Int32 Getadded_byFieldValue()
	{
		return this.GetValue(TableUtils.added_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.removed_by field.
	/// </summary>
	public ColumnValue Getremoved_byValue()
	{
		return this.GetValue(TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.removed_by field.
	/// </summary>
	public Int32 Getremoved_byFieldValue()
	{
		return this.GetValue(TableUtils.removed_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.notes field.
	/// </summary>
	public ColumnValue GetnotesValue()
	{
		return this.GetValue(TableUtils.notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.notes field.
	/// </summary>
	public string GetnotesFieldValue()
	{
		return this.GetValue(TableUtils.notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.notes field.
	/// </summary>
	public void SetnotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.notes field.
	/// </summary>
	public void SetnotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.notesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.dept_id field.
	/// </summary>
	public ColumnValue Getdept_idValue()
	{
		return this.GetValue(TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.dept_id field.
	/// </summary>
	public Int32 Getdept_idFieldValue()
	{
		return this.GetValue(TableUtils.dept_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.inventory_loc_id field.
	/// </summary>
	public ColumnValue Getinventory_loc_idValue()
	{
		return this.GetValue(TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.inventory_loc_id field.
	/// </summary>
	public Int32 Getinventory_loc_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_loc_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.inventory_loc_id field.
	/// </summary>
	public void Setinventory_loc_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_loc_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.image1 field.
	/// </summary>
	public ColumnValue Getimage1Value()
	{
		return this.GetValue(TableUtils.image1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.image1 field.
	/// </summary>
	public byte[] Getimage1FieldValue()
	{
		return this.GetValue(TableUtils.image1Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image1 field.
	/// </summary>
	public void Setimage1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.image1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image1 field.
	/// </summary>
	public void Setimage1FieldValue(string val)
	{
		this.SetString(val, TableUtils.image1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image1 field.
	/// </summary>
	public void Setimage1FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.image1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.image2 field.
	/// </summary>
	public ColumnValue Getimage2Value()
	{
		return this.GetValue(TableUtils.image2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.image2 field.
	/// </summary>
	public byte[] Getimage2FieldValue()
	{
		return this.GetValue(TableUtils.image2Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image2 field.
	/// </summary>
	public void Setimage2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.image2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image2 field.
	/// </summary>
	public void Setimage2FieldValue(string val)
	{
		this.SetString(val, TableUtils.image2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image2 field.
	/// </summary>
	public void Setimage2FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.image2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.image3 field.
	/// </summary>
	public ColumnValue Getimage3Value()
	{
		return this.GetValue(TableUtils.image3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.image3 field.
	/// </summary>
	public byte[] Getimage3FieldValue()
	{
		return this.GetValue(TableUtils.image3Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image3 field.
	/// </summary>
	public void Setimage3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.image3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image3 field.
	/// </summary>
	public void Setimage3FieldValue(string val)
	{
		this.SetString(val, TableUtils.image3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image3 field.
	/// </summary>
	public void Setimage3FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.image3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.custname field.
	/// </summary>
	public ColumnValue GetcustnameValue()
	{
		return this.GetValue(TableUtils.custnameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.custname field.
	/// </summary>
	public string GetcustnameFieldValue()
	{
		return this.GetValue(TableUtils.custnameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.site_inventory_comments field.
	/// </summary>
	public ColumnValue Getsite_inventory_commentsValue()
	{
		return this.GetValue(TableUtils.site_inventory_commentsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.site_inventory_comments field.
	/// </summary>
	public string Getsite_inventory_commentsFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_commentsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.site_inventory_comments field.
	/// </summary>
	public void Setsite_inventory_commentsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_commentsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.site_inventory_comments field.
	/// </summary>
	public void Setsite_inventory_commentsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_commentsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pmi field.
	/// </summary>
	public ColumnValue GetpmiValue()
	{
		return this.GetValue(TableUtils.pmiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pmi field.
	/// </summary>
	public bool GetpmiFieldValue()
	{
		return this.GetValue(TableUtils.pmiColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi field.
	/// </summary>
	public void SetpmiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pmiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi field.
	/// </summary>
	public void SetpmiFieldValue(string val)
	{
		this.SetString(val, TableUtils.pmiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi field.
	/// </summary>
	public void SetpmiFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pmiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pmi_minutes field.
	/// </summary>
	public ColumnValue Getpmi_minutesValue()
	{
		return this.GetValue(TableUtils.pmi_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pmi_minutes field.
	/// </summary>
	public string Getpmi_minutesFieldValue()
	{
		return this.GetValue(TableUtils.pmi_minutesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi_minutes field.
	/// </summary>
	public void Setpmi_minutesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pmi_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi_minutes field.
	/// </summary>
	public void Setpmi_minutesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pmi_minutesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pm field.
	/// </summary>
	public ColumnValue GetpmValue()
	{
		return this.GetValue(TableUtils.pmColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pm field.
	/// </summary>
	public bool GetpmFieldValue()
	{
		return this.GetValue(TableUtils.pmColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm field.
	/// </summary>
	public void SetpmFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pmColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm field.
	/// </summary>
	public void SetpmFieldValue(string val)
	{
		this.SetString(val, TableUtils.pmColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm field.
	/// </summary>
	public void SetpmFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pmColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pmi_interval field.
	/// </summary>
	public ColumnValue Getpmi_intervalValue()
	{
		return this.GetValue(TableUtils.pmi_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pmi_interval field.
	/// </summary>
	public Int32 Getpmi_intervalFieldValue()
	{
		return this.GetValue(TableUtils.pmi_intervalColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi_interval field.
	/// </summary>
	public void Setpmi_intervalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pmi_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi_interval field.
	/// </summary>
	public void Setpmi_intervalFieldValue(string val)
	{
		this.SetString(val, TableUtils.pmi_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi_interval field.
	/// </summary>
	public void Setpmi_intervalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pmi_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi_interval field.
	/// </summary>
	public void Setpmi_intervalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pmi_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi_interval field.
	/// </summary>
	public void Setpmi_intervalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pmi_intervalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pm_interval field.
	/// </summary>
	public ColumnValue Getpm_intervalValue()
	{
		return this.GetValue(TableUtils.pm_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pm_interval field.
	/// </summary>
	public Int32 Getpm_intervalFieldValue()
	{
		return this.GetValue(TableUtils.pm_intervalColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_interval field.
	/// </summary>
	public void Setpm_intervalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pm_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_interval field.
	/// </summary>
	public void Setpm_intervalFieldValue(string val)
	{
		this.SetString(val, TableUtils.pm_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_interval field.
	/// </summary>
	public void Setpm_intervalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_interval field.
	/// </summary>
	public void Setpm_intervalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_interval field.
	/// </summary>
	public void Setpm_intervalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_intervalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pm_minutes field.
	/// </summary>
	public ColumnValue Getpm_minutesValue()
	{
		return this.GetValue(TableUtils.pm_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.pm_minutes field.
	/// </summary>
	public Int32 Getpm_minutesFieldValue()
	{
		return this.GetValue(TableUtils.pm_minutesColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_minutes field.
	/// </summary>
	public void Setpm_minutesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pm_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_minutes field.
	/// </summary>
	public void Setpm_minutesFieldValue(string val)
	{
		this.SetString(val, TableUtils.pm_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_minutes field.
	/// </summary>
	public void Setpm_minutesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_minutes field.
	/// </summary>
	public void Setpm_minutesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_minutes field.
	/// </summary>
	public void Setpm_minutesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_minutesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.electrical field.
	/// </summary>
	public ColumnValue GetelectricalValue()
	{
		return this.GetValue(TableUtils.electricalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.electrical field.
	/// </summary>
	public bool GetelectricalFieldValue()
	{
		return this.GetValue(TableUtils.electricalColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical field.
	/// </summary>
	public void SetelectricalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.electricalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical field.
	/// </summary>
	public void SetelectricalFieldValue(string val)
	{
		this.SetString(val, TableUtils.electricalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical field.
	/// </summary>
	public void SetelectricalFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.electricalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.electrical_interval field.
	/// </summary>
	public ColumnValue Getelectrical_intervalValue()
	{
		return this.GetValue(TableUtils.electrical_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.electrical_interval field.
	/// </summary>
	public Int32 Getelectrical_intervalFieldValue()
	{
		return this.GetValue(TableUtils.electrical_intervalColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical_interval field.
	/// </summary>
	public void Setelectrical_intervalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.electrical_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical_interval field.
	/// </summary>
	public void Setelectrical_intervalFieldValue(string val)
	{
		this.SetString(val, TableUtils.electrical_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical_interval field.
	/// </summary>
	public void Setelectrical_intervalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.electrical_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical_interval field.
	/// </summary>
	public void Setelectrical_intervalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.electrical_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical_interval field.
	/// </summary>
	public void Setelectrical_intervalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.electrical_intervalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.site_inventory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.site_inventory_id field.
	/// </summary>
	public string site_inventory_idDefault
	{
		get
		{
			return TableUtils.site_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.site_inventory_date field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.site_inventory_date field.
	/// </summary>
	public string site_inventory_dateDefault
	{
		get
		{
			return TableUtils.site_inventory_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.make field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.make field.
	/// </summary>
	public string makeDefault
	{
		get
		{
			return TableUtils.makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.model field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.model field.
	/// </summary>
	public string modelDefault
	{
		get
		{
			return TableUtils.modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.category field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.category field.
	/// </summary>
	public string categoryDefault
	{
		get
		{
			return TableUtils.categoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.condition_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.condition_id field.
	/// </summary>
	public string condition_idDefault
	{
		get
		{
			return TableUtils.condition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.date_added field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.date_added field.
	/// </summary>
	public string date_addedDefault
	{
		get
		{
			return TableUtils.date_addedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.date_removed field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.date_removed field.
	/// </summary>
	public string date_removedDefault
	{
		get
		{
			return TableUtils.date_removedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.added_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.added_by field.
	/// </summary>
	public string added_byDefault
	{
		get
		{
			return TableUtils.added_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.removed_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.removed_by field.
	/// </summary>
	public string removed_byDefault
	{
		get
		{
			return TableUtils.removed_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.notes field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.notes field.
	/// </summary>
	public string notesDefault
	{
		get
		{
			return TableUtils.notesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.dept_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.dept_id field.
	/// </summary>
	public string dept_idDefault
	{
		get
		{
			return TableUtils.dept_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.inventory_loc_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.inventory_loc_id field.
	/// </summary>
	public string inventory_loc_idDefault
	{
		get
		{
			return TableUtils.inventory_loc_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.image1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image1 field.
	/// </summary>
	public string image1Default
	{
		get
		{
			return TableUtils.image1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.image2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image2 field.
	/// </summary>
	public string image2Default
	{
		get
		{
			return TableUtils.image2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.image3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.image3 field.
	/// </summary>
	public string image3Default
	{
		get
		{
			return TableUtils.image3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.custname field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.custname field.
	/// </summary>
	public string custnameDefault
	{
		get
		{
			return TableUtils.custnameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.site_inventory_comments field.
	/// </summary>
	public string site_inventory_comments
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_commentsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_commentsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_commentsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_commentsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.site_inventory_comments field.
	/// </summary>
	public string site_inventory_commentsDefault
	{
		get
		{
			return TableUtils.site_inventory_commentsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.pmi field.
	/// </summary>
	public bool pmi
	{
		get
		{
			return this.GetValue(TableUtils.pmiColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.pmiColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pmiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pmiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi field.
	/// </summary>
	public string pmiDefault
	{
		get
		{
			return TableUtils.pmiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.pmi_minutes field.
	/// </summary>
	public string pmi_minutes
	{
		get
		{
			return this.GetValue(TableUtils.pmi_minutesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pmi_minutesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pmi_minutesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pmi_minutesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi_minutes field.
	/// </summary>
	public string pmi_minutesDefault
	{
		get
		{
			return TableUtils.pmi_minutesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.pm field.
	/// </summary>
	public bool pm
	{
		get
		{
			return this.GetValue(TableUtils.pmColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.pmColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pmSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pmColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm field.
	/// </summary>
	public string pmDefault
	{
		get
		{
			return TableUtils.pmColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.pmi_interval field.
	/// </summary>
	public Int32 pmi_interval
	{
		get
		{
			return this.GetValue(TableUtils.pmi_intervalColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pmi_intervalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pmi_intervalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pmi_intervalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pmi_interval field.
	/// </summary>
	public string pmi_intervalDefault
	{
		get
		{
			return TableUtils.pmi_intervalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.pm_interval field.
	/// </summary>
	public Int32 pm_interval
	{
		get
		{
			return this.GetValue(TableUtils.pm_intervalColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pm_intervalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pm_intervalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pm_intervalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_interval field.
	/// </summary>
	public string pm_intervalDefault
	{
		get
		{
			return TableUtils.pm_intervalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.pm_minutes field.
	/// </summary>
	public Int32 pm_minutes
	{
		get
		{
			return this.GetValue(TableUtils.pm_minutesColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pm_minutesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pm_minutesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pm_minutesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.pm_minutes field.
	/// </summary>
	public string pm_minutesDefault
	{
		get
		{
			return TableUtils.pm_minutesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.electrical field.
	/// </summary>
	public bool electrical
	{
		get
		{
			return this.GetValue(TableUtils.electricalColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.electricalColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool electricalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.electricalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical field.
	/// </summary>
	public string electricalDefault
	{
		get
		{
			return TableUtils.electricalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.electrical_interval field.
	/// </summary>
	public Int32 electrical_interval
	{
		get
		{
			return this.GetValue(TableUtils.electrical_intervalColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.electrical_intervalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool electrical_intervalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.electrical_intervalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.electrical_interval field.
	/// </summary>
	public string electrical_intervalDefault
	{
		get
		{
			return TableUtils.electrical_intervalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_.category_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_.category_id field.
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
