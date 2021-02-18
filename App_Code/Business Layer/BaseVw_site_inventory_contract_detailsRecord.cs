// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_site_inventory_contract_detailsRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_site_inventory_contract_detailsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_site_inventory_contract_detailsView"></see> class.
/// </remarks>
/// <seealso cref="Vw_site_inventory_contract_detailsView"></seealso>
/// <seealso cref="Vw_site_inventory_contract_detailsRecord"></seealso>
public class BaseVw_site_inventory_contract_detailsRecord : KeylessRecord
{

	public readonly static Vw_site_inventory_contract_detailsView TableUtils = Vw_site_inventory_contract_detailsView.Instance;

	// Constructors
 
	protected BaseVw_site_inventory_contract_detailsRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_site_inventory_contract_detailsRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_site_inventory_contract_detailsRecord_InsertingRecord);     
	}

	protected BaseVw_site_inventory_contract_detailsRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_site_inventory_contract_detailsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_site_inventory_contract_detailsRecord Vw_site_inventory_contract_detailsRec = (Vw_site_inventory_contract_detailsRecord)sender;
        if(Vw_site_inventory_contract_detailsRec != null && !Vw_site_inventory_contract_detailsRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_site_inventory_contract_detailsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_site_inventory_contract_detailsRecord Vw_site_inventory_contract_detailsRec = (Vw_site_inventory_contract_detailsRecord)sender;
        Validate_Inserting();
        if(Vw_site_inventory_contract_detailsRec != null && !Vw_site_inventory_contract_detailsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.make field.
	/// </summary>
	public ColumnValue GetmakeValue()
	{
		return this.GetValue(TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.make field.
	/// </summary>
	public string GetmakeFieldValue()
	{
		return this.GetValue(TableUtils.makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.make field.
	/// </summary>
	public void SetmakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.make field.
	/// </summary>
	public void SetmakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.model field.
	/// </summary>
	public ColumnValue GetmodelValue()
	{
		return this.GetValue(TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.model field.
	/// </summary>
	public string GetmodelFieldValue()
	{
		return this.GetValue(TableUtils.modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.model field.
	/// </summary>
	public void SetmodelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.model field.
	/// </summary>
	public void SetmodelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.category field.
	/// </summary>
	public ColumnValue GetcategoryValue()
	{
		return this.GetValue(TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.category field.
	/// </summary>
	public string GetcategoryFieldValue()
	{
		return this.GetValue(TableUtils.categoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.category field.
	/// </summary>
	public void SetcategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.category field.
	/// </summary>
	public void SetcategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.categoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.condition_id field.
	/// </summary>
	public ColumnValue Getcondition_idValue()
	{
		return this.GetValue(TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.condition_id field.
	/// </summary>
	public Int32 Getcondition_idFieldValue()
	{
		return this.GetValue(TableUtils.condition_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.dept_id field.
	/// </summary>
	public ColumnValue Getdept_idValue()
	{
		return this.GetValue(TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.dept_id field.
	/// </summary>
	public Int32 Getdept_idFieldValue()
	{
		return this.GetValue(TableUtils.dept_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.date_added field.
	/// </summary>
	public ColumnValue Getdate_addedValue()
	{
		return this.GetValue(TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.date_added field.
	/// </summary>
	public DateTime Getdate_addedFieldValue()
	{
		return this.GetValue(TableUtils.date_addedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_addedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.date_removed field.
	/// </summary>
	public ColumnValue Getdate_removedValue()
	{
		return this.GetValue(TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.date_removed field.
	/// </summary>
	public string Getdate_removedFieldValue()
	{
		return this.GetValue(TableUtils.date_removedColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_removedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.added_by field.
	/// </summary>
	public ColumnValue Getadded_byValue()
	{
		return this.GetValue(TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.added_by field.
	/// </summary>
	public Int32 Getadded_byFieldValue()
	{
		return this.GetValue(TableUtils.added_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.removed_by field.
	/// </summary>
	public ColumnValue Getremoved_byValue()
	{
		return this.GetValue(TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.removed_by field.
	/// </summary>
	public Int32 Getremoved_byFieldValue()
	{
		return this.GetValue(TableUtils.removed_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.site_inventory_contract_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_contract_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.site_inventory_contract_id field.
	/// </summary>
	public Int32 Getsite_inventory_contract_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.site_inventory_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.site_inventory_id field.
	/// </summary>
	public Int32 Getsite_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.CustContactName field.
	/// </summary>
	public ColumnValue GetCustContactNameValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.CustContactName field.
	/// </summary>
	public string GetCustContactNameFieldValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.contract_number field.
	/// </summary>
	public ColumnValue Getcontract_numberValue()
	{
		return this.GetValue(TableUtils.contract_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.contract_number field.
	/// </summary>
	public string Getcontract_numberFieldValue()
	{
		return this.GetValue(TableUtils.contract_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_number field.
	/// </summary>
	public void Setcontract_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_number field.
	/// </summary>
	public void Setcontract_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.start_date field.
	/// </summary>
	public ColumnValue Getstart_dateValue()
	{
		return this.GetValue(TableUtils.start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.start_date field.
	/// </summary>
	public DateTime Getstart_dateFieldValue()
	{
		return this.GetValue(TableUtils.start_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.start_date field.
	/// </summary>
	public void Setstart_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.start_date field.
	/// </summary>
	public void Setstart_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.start_date field.
	/// </summary>
	public void Setstart_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.start_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.end_date field.
	/// </summary>
	public ColumnValue Getend_dateValue()
	{
		return this.GetValue(TableUtils.end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.end_date field.
	/// </summary>
	public DateTime Getend_dateFieldValue()
	{
		return this.GetValue(TableUtils.end_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.end_date field.
	/// </summary>
	public void Setend_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.end_date field.
	/// </summary>
	public void Setend_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.end_date field.
	/// </summary>
	public void Setend_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.end_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.contract_details field.
	/// </summary>
	public ColumnValue Getcontract_detailsValue()
	{
		return this.GetValue(TableUtils.contract_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.contract_details field.
	/// </summary>
	public string Getcontract_detailsFieldValue()
	{
		return this.GetValue(TableUtils.contract_detailsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_details field.
	/// </summary>
	public void Setcontract_detailsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_details field.
	/// </summary>
	public void Setcontract_detailsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_detailsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.contract_active field.
	/// </summary>
	public ColumnValue Getcontract_activeValue()
	{
		return this.GetValue(TableUtils.contract_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.contract_active field.
	/// </summary>
	public bool Getcontract_activeFieldValue()
	{
		return this.GetValue(TableUtils.contract_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_active field.
	/// </summary>
	public void Setcontract_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_active field.
	/// </summary>
	public void Setcontract_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.contract_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_active field.
	/// </summary>
	public void Setcontract_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.CustName field.
	/// </summary>
	public ColumnValue GetCustNameValue()
	{
		return this.GetValue(TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_contract_details_.CustName field.
	/// </summary>
	public string GetCustNameFieldValue()
	{
		return this.GetValue(TableUtils.CustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.make field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.make field.
	/// </summary>
	public string makeDefault
	{
		get
		{
			return TableUtils.makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.model field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.model field.
	/// </summary>
	public string modelDefault
	{
		get
		{
			return TableUtils.modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.category field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.category field.
	/// </summary>
	public string categoryDefault
	{
		get
		{
			return TableUtils.categoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.condition_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.condition_id field.
	/// </summary>
	public string condition_idDefault
	{
		get
		{
			return TableUtils.condition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.dept_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.dept_id field.
	/// </summary>
	public string dept_idDefault
	{
		get
		{
			return TableUtils.dept_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.date_added field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.date_added field.
	/// </summary>
	public string date_addedDefault
	{
		get
		{
			return TableUtils.date_addedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.date_removed field.
	/// </summary>
	public string date_removed
	{
		get
		{
			return this.GetValue(TableUtils.date_removedColumn).ToString();
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.date_removed field.
	/// </summary>
	public string date_removedDefault
	{
		get
		{
			return TableUtils.date_removedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.added_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.added_by field.
	/// </summary>
	public string added_byDefault
	{
		get
		{
			return TableUtils.added_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.removed_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.removed_by field.
	/// </summary>
	public string removed_byDefault
	{
		get
		{
			return TableUtils.removed_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.site_inventory_contract_id field.
	/// </summary>
	public Int32 site_inventory_contract_id
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_contract_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_contract_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_contract_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_contract_id field.
	/// </summary>
	public string site_inventory_contract_idDefault
	{
		get
		{
			return TableUtils.site_inventory_contract_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.site_inventory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.site_inventory_id field.
	/// </summary>
	public string site_inventory_idDefault
	{
		get
		{
			return TableUtils.site_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.CustContactName field.
	/// </summary>
	public string CustContactName
	{
		get
		{
			return this.GetValue(TableUtils.CustContactNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContactNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContactNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContactNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.CustContactName field.
	/// </summary>
	public string CustContactNameDefault
	{
		get
		{
			return TableUtils.CustContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.contract_number field.
	/// </summary>
	public string contract_number
	{
		get
		{
			return this.GetValue(TableUtils.contract_numberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_numberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_numberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_numberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_number field.
	/// </summary>
	public string contract_numberDefault
	{
		get
		{
			return TableUtils.contract_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.start_date field.
	/// </summary>
	public DateTime start_date
	{
		get
		{
			return this.GetValue(TableUtils.start_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.start_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool start_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.start_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.start_date field.
	/// </summary>
	public string start_dateDefault
	{
		get
		{
			return TableUtils.start_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.end_date field.
	/// </summary>
	public DateTime end_date
	{
		get
		{
			return this.GetValue(TableUtils.end_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.end_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool end_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.end_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.end_date field.
	/// </summary>
	public string end_dateDefault
	{
		get
		{
			return TableUtils.end_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.contract_details field.
	/// </summary>
	public string contract_details
	{
		get
		{
			return this.GetValue(TableUtils.contract_detailsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_detailsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_detailsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_detailsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_details field.
	/// </summary>
	public string contract_detailsDefault
	{
		get
		{
			return TableUtils.contract_detailsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.contract_active field.
	/// </summary>
	public bool contract_active
	{
		get
		{
			return this.GetValue(TableUtils.contract_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.contract_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.contract_active field.
	/// </summary>
	public string contract_activeDefault
	{
		get
		{
			return TableUtils.contract_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_contract_details_.CustName field.
	/// </summary>
	public string CustName
	{
		get
		{
			return this.GetValue(TableUtils.CustNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_contract_details_.CustName field.
	/// </summary>
	public string CustNameDefault
	{
		get
		{
			return TableUtils.CustNameColumn.DefaultValue;
		}
	}


#endregion

}

}
