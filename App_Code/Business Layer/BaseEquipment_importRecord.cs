// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_importRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_importRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_importTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_importTable"></seealso>
/// <seealso cref="Equipment_importRecord"></seealso>
public class BaseEquipment_importRecord : PrimaryKeyRecord
{

	public readonly static Equipment_importTable TableUtils = Equipment_importTable.Instance;

	// Constructors
 
	protected BaseEquipment_importRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_importRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_importRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_importRecord_ReadRecord); 
	}

	protected BaseEquipment_importRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_importRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_importRecord Equipment_importRec = (Equipment_importRecord)sender;
        if(Equipment_importRec != null && !Equipment_importRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_importRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_importRecord Equipment_importRec = (Equipment_importRecord)sender;
        Validate_Inserting();
        if(Equipment_importRec != null && !Equipment_importRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_importRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_importRecord Equipment_importRec = (Equipment_importRecord)sender;
        Validate_Updating();
        if(Equipment_importRec != null && !Equipment_importRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.equip_import_id field.
	/// </summary>
	public ColumnValue Getequip_import_idValue()
	{
		return this.GetValue(TableUtils.equip_import_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.equip_import_id field.
	/// </summary>
	public Int32 Getequip_import_idFieldValue()
	{
		return this.GetValue(TableUtils.equip_import_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.asset_tag field.
	/// </summary>
	public ColumnValue Getasset_tagValue()
	{
		return this.GetValue(TableUtils.asset_tagColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.asset_tag field.
	/// </summary>
	public string Getasset_tagFieldValue()
	{
		return this.GetValue(TableUtils.asset_tagColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.asset_tag field.
	/// </summary>
	public void Setasset_tagFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.asset_tagColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.asset_tag field.
	/// </summary>
	public void Setasset_tagFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.asset_tagColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.state field.
	/// </summary>
	public ColumnValue GetstateValue()
	{
		return this.GetValue(TableUtils.stateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.state field.
	/// </summary>
	public string GetstateFieldValue()
	{
		return this.GetValue(TableUtils.stateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.state field.
	/// </summary>
	public void SetstateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.stateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.state field.
	/// </summary>
	public void SetstateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.stateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.serial_number field.
	/// </summary>
	public ColumnValue Getserial_numberValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.serial_number field.
	/// </summary>
	public string Getserial_numberFieldValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.model field.
	/// </summary>
	public ColumnValue GetmodelValue()
	{
		return this.GetValue(TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.model field.
	/// </summary>
	public string GetmodelFieldValue()
	{
		return this.GetValue(TableUtils.modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.model field.
	/// </summary>
	public void SetmodelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.model field.
	/// </summary>
	public void SetmodelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.building field.
	/// </summary>
	public ColumnValue GetbuildingValue()
	{
		return this.GetValue(TableUtils.buildingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.building field.
	/// </summary>
	public string GetbuildingFieldValue()
	{
		return this.GetValue(TableUtils.buildingColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.building field.
	/// </summary>
	public void SetbuildingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.buildingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.building field.
	/// </summary>
	public void SetbuildingFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.buildingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.department field.
	/// </summary>
	public ColumnValue GetdepartmentValue()
	{
		return this.GetValue(TableUtils.departmentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.department field.
	/// </summary>
	public string GetdepartmentFieldValue()
	{
		return this.GetValue(TableUtils.departmentColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.department field.
	/// </summary>
	public void SetdepartmentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.departmentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.department field.
	/// </summary>
	public void SetdepartmentFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.departmentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.category field.
	/// </summary>
	public ColumnValue GetcategoryValue()
	{
		return this.GetValue(TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.category field.
	/// </summary>
	public string GetcategoryFieldValue()
	{
		return this.GetValue(TableUtils.categoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.category field.
	/// </summary>
	public void SetcategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.category field.
	/// </summary>
	public void SetcategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.categoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.pm_last_fix_date field.
	/// </summary>
	public ColumnValue Getpm_last_fix_dateValue()
	{
		return this.GetValue(TableUtils.pm_last_fix_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.pm_last_fix_date field.
	/// </summary>
	public DateTime Getpm_last_fix_dateFieldValue()
	{
		return this.GetValue(TableUtils.pm_last_fix_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_last_fix_date field.
	/// </summary>
	public void Setpm_last_fix_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pm_last_fix_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_last_fix_date field.
	/// </summary>
	public void Setpm_last_fix_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.pm_last_fix_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_last_fix_date field.
	/// </summary>
	public void Setpm_last_fix_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_last_fix_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.customer field.
	/// </summary>
	public ColumnValue GetcustomerValue()
	{
		return this.GetValue(TableUtils.customerColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.customer field.
	/// </summary>
	public string GetcustomerFieldValue()
	{
		return this.GetValue(TableUtils.customerColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.customer field.
	/// </summary>
	public void SetcustomerFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.customer field.
	/// </summary>
	public void SetcustomerFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customerColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.equip_import_batch_id field.
	/// </summary>
	public ColumnValue Getequip_import_batch_idValue()
	{
		return this.GetValue(TableUtils.equip_import_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.equip_import_batch_id field.
	/// </summary>
	public Int32 Getequip_import_batch_idFieldValue()
	{
		return this.GetValue(TableUtils.equip_import_batch_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.equip_import_batch_id field.
	/// </summary>
	public void Setequip_import_batch_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equip_import_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.equip_import_batch_id field.
	/// </summary>
	public void Setequip_import_batch_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equip_import_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.equip_import_batch_id field.
	/// </summary>
	public void Setequip_import_batch_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_import_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.equip_import_batch_id field.
	/// </summary>
	public void Setequip_import_batch_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_import_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.equip_import_batch_id field.
	/// </summary>
	public void Setequip_import_batch_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_import_batch_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.comments field.
	/// </summary>
	public ColumnValue GetcommentsValue()
	{
		return this.GetValue(TableUtils.commentsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.comments field.
	/// </summary>
	public string GetcommentsFieldValue()
	{
		return this.GetValue(TableUtils.commentsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.comments field.
	/// </summary>
	public void SetcommentsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.commentsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.comments field.
	/// </summary>
	public void SetcommentsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.commentsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.pm_purchase_order field.
	/// </summary>
	public ColumnValue Getpm_purchase_orderValue()
	{
		return this.GetValue(TableUtils.pm_purchase_orderColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.pm_purchase_order field.
	/// </summary>
	public string Getpm_purchase_orderFieldValue()
	{
		return this.GetValue(TableUtils.pm_purchase_orderColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_purchase_order field.
	/// </summary>
	public void Setpm_purchase_orderFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pm_purchase_orderColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_purchase_order field.
	/// </summary>
	public void Setpm_purchase_orderFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_purchase_orderColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.po_date field.
	/// </summary>
	public ColumnValue Getpo_dateValue()
	{
		return this.GetValue(TableUtils.po_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.po_date field.
	/// </summary>
	public DateTime Getpo_dateFieldValue()
	{
		return this.GetValue(TableUtils.po_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.po_date field.
	/// </summary>
	public void Setpo_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.po_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.po_date field.
	/// </summary>
	public void Setpo_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.po_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.po_date field.
	/// </summary>
	public void Setpo_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.po_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.date_of_next_pm field.
	/// </summary>
	public ColumnValue Getdate_of_next_pmValue()
	{
		return this.GetValue(TableUtils.date_of_next_pmColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.date_of_next_pm field.
	/// </summary>
	public DateTime Getdate_of_next_pmFieldValue()
	{
		return this.GetValue(TableUtils.date_of_next_pmColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.date_of_next_pm field.
	/// </summary>
	public void Setdate_of_next_pmFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_of_next_pmColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.date_of_next_pm field.
	/// </summary>
	public void Setdate_of_next_pmFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_of_next_pmColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.date_of_next_pm field.
	/// </summary>
	public void Setdate_of_next_pmFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_of_next_pmColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.status field.
	/// </summary>
	public ColumnValue GetstatusValue()
	{
		return this.GetValue(TableUtils.statusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.status field.
	/// </summary>
	public string GetstatusFieldValue()
	{
		return this.GetValue(TableUtils.statusColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.status field.
	/// </summary>
	public void SetstatusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.statusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.status field.
	/// </summary>
	public void SetstatusFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.statusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.service_tech field.
	/// </summary>
	public ColumnValue Getservice_techValue()
	{
		return this.GetValue(TableUtils.service_techColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.service_tech field.
	/// </summary>
	public string Getservice_techFieldValue()
	{
		return this.GetValue(TableUtils.service_techColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.service_tech field.
	/// </summary>
	public void Setservice_techFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.service_techColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.service_tech field.
	/// </summary>
	public void Setservice_techFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.service_techColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.pm_frequency field.
	/// </summary>
	public ColumnValue Getpm_frequencyValue()
	{
		return this.GetValue(TableUtils.pm_frequencyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.pm_frequency field.
	/// </summary>
	public Int32 Getpm_frequencyFieldValue()
	{
		return this.GetValue(TableUtils.pm_frequencyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_frequency field.
	/// </summary>
	public void Setpm_frequencyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pm_frequencyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_frequency field.
	/// </summary>
	public void Setpm_frequencyFieldValue(string val)
	{
		this.SetString(val, TableUtils.pm_frequencyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_frequency field.
	/// </summary>
	public void Setpm_frequencyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_frequencyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_frequency field.
	/// </summary>
	public void Setpm_frequencyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_frequencyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_frequency field.
	/// </summary>
	public void Setpm_frequencyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pm_frequencyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.address field.
	/// </summary>
	public ColumnValue GetaddressValue()
	{
		return this.GetValue(TableUtils.addressColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.address field.
	/// </summary>
	public string GetaddressFieldValue()
	{
		return this.GetValue(TableUtils.addressColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.address field.
	/// </summary>
	public void SetaddressFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.addressColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.address field.
	/// </summary>
	public void SetaddressFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.addressColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.city field.
	/// </summary>
	public ColumnValue GetcityValue()
	{
		return this.GetValue(TableUtils.cityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.city field.
	/// </summary>
	public string GetcityFieldValue()
	{
		return this.GetValue(TableUtils.cityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.city field.
	/// </summary>
	public void SetcityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.city field.
	/// </summary>
	public void SetcityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.address_state field.
	/// </summary>
	public ColumnValue Getaddress_stateValue()
	{
		return this.GetValue(TableUtils.address_stateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.address_state field.
	/// </summary>
	public string Getaddress_stateFieldValue()
	{
		return this.GetValue(TableUtils.address_stateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.address_state field.
	/// </summary>
	public void Setaddress_stateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.address_stateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.address_state field.
	/// </summary>
	public void Setaddress_stateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.address_stateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.zipcode field.
	/// </summary>
	public ColumnValue GetzipcodeValue()
	{
		return this.GetValue(TableUtils.zipcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.zipcode field.
	/// </summary>
	public string GetzipcodeFieldValue()
	{
		return this.GetValue(TableUtils.zipcodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.zipcode field.
	/// </summary>
	public void SetzipcodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.zipcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.zipcode field.
	/// </summary>
	public void SetzipcodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.zipcodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.contact_first field.
	/// </summary>
	public ColumnValue Getcontact_firstValue()
	{
		return this.GetValue(TableUtils.contact_firstColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.contact_first field.
	/// </summary>
	public string Getcontact_firstFieldValue()
	{
		return this.GetValue(TableUtils.contact_firstColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.contact_first field.
	/// </summary>
	public void Setcontact_firstFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contact_firstColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.contact_first field.
	/// </summary>
	public void Setcontact_firstFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contact_firstColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.contact_last field.
	/// </summary>
	public ColumnValue Getcontact_lastValue()
	{
		return this.GetValue(TableUtils.contact_lastColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.contact_last field.
	/// </summary>
	public string Getcontact_lastFieldValue()
	{
		return this.GetValue(TableUtils.contact_lastColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.contact_last field.
	/// </summary>
	public void Setcontact_lastFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contact_lastColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.contact_last field.
	/// </summary>
	public void Setcontact_lastFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contact_lastColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.phone_number field.
	/// </summary>
	public ColumnValue Getphone_numberValue()
	{
		return this.GetValue(TableUtils.phone_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.phone_number field.
	/// </summary>
	public string Getphone_numberFieldValue()
	{
		return this.GetValue(TableUtils.phone_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.phone_number field.
	/// </summary>
	public void Setphone_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.phone_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.phone_number field.
	/// </summary>
	public void Setphone_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.phone_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.open_time field.
	/// </summary>
	public ColumnValue Getopen_timeValue()
	{
		return this.GetValue(TableUtils.open_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.open_time field.
	/// </summary>
	public DateTime Getopen_timeFieldValue()
	{
		return this.GetValue(TableUtils.open_timeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.open_time field.
	/// </summary>
	public void Setopen_timeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.open_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.open_time field.
	/// </summary>
	public void Setopen_timeFieldValue(string val)
	{
		this.SetString(val, TableUtils.open_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.open_time field.
	/// </summary>
	public void Setopen_timeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.open_timeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.close_time field.
	/// </summary>
	public ColumnValue Getclose_timeValue()
	{
		return this.GetValue(TableUtils.close_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.close_time field.
	/// </summary>
	public DateTime Getclose_timeFieldValue()
	{
		return this.GetValue(TableUtils.close_timeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.close_time field.
	/// </summary>
	public void Setclose_timeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.close_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.close_time field.
	/// </summary>
	public void Setclose_timeFieldValue(string val)
	{
		this.SetString(val, TableUtils.close_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.close_time field.
	/// </summary>
	public void Setclose_timeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.close_timeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.serv_rep_parts_po field.
	/// </summary>
	public ColumnValue Getserv_rep_parts_poValue()
	{
		return this.GetValue(TableUtils.serv_rep_parts_poColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_.serv_rep_parts_po field.
	/// </summary>
	public string Getserv_rep_parts_poFieldValue()
	{
		return this.GetValue(TableUtils.serv_rep_parts_poColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.serv_rep_parts_po field.
	/// </summary>
	public void Setserv_rep_parts_poFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serv_rep_parts_poColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.serv_rep_parts_po field.
	/// </summary>
	public void Setserv_rep_parts_poFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serv_rep_parts_poColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.equip_import_id field.
	/// </summary>
	public Int32 equip_import_id
	{
		get
		{
			return this.GetValue(TableUtils.equip_import_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_import_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_import_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_import_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.equip_import_id field.
	/// </summary>
	public string equip_import_idDefault
	{
		get
		{
			return TableUtils.equip_import_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.asset_tag field.
	/// </summary>
	public string asset_tag
	{
		get
		{
			return this.GetValue(TableUtils.asset_tagColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.asset_tagColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool asset_tagSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.asset_tagColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.asset_tag field.
	/// </summary>
	public string asset_tagDefault
	{
		get
		{
			return TableUtils.asset_tagColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.state field.
	/// </summary>
	public string state
	{
		get
		{
			return this.GetValue(TableUtils.stateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.stateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool stateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.stateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.state field.
	/// </summary>
	public string stateDefault
	{
		get
		{
			return TableUtils.stateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.serial_number field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.serial_number field.
	/// </summary>
	public string serial_numberDefault
	{
		get
		{
			return TableUtils.serial_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.model field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.model field.
	/// </summary>
	public string modelDefault
	{
		get
		{
			return TableUtils.modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.building field.
	/// </summary>
	public string building
	{
		get
		{
			return this.GetValue(TableUtils.buildingColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.buildingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool buildingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.buildingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.building field.
	/// </summary>
	public string buildingDefault
	{
		get
		{
			return TableUtils.buildingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.department field.
	/// </summary>
	public string department
	{
		get
		{
			return this.GetValue(TableUtils.departmentColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.departmentColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool departmentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.departmentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.department field.
	/// </summary>
	public string departmentDefault
	{
		get
		{
			return TableUtils.departmentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.category field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.category field.
	/// </summary>
	public string categoryDefault
	{
		get
		{
			return TableUtils.categoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.pm_last_fix_date field.
	/// </summary>
	public DateTime pm_last_fix_date
	{
		get
		{
			return this.GetValue(TableUtils.pm_last_fix_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pm_last_fix_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pm_last_fix_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pm_last_fix_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_last_fix_date field.
	/// </summary>
	public string pm_last_fix_dateDefault
	{
		get
		{
			return TableUtils.pm_last_fix_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.customer field.
	/// </summary>
	public string customer
	{
		get
		{
			return this.GetValue(TableUtils.customerColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customerColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customerSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customerColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.customer field.
	/// </summary>
	public string customerDefault
	{
		get
		{
			return TableUtils.customerColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.equip_import_batch_id field.
	/// </summary>
	public Int32 equip_import_batch_id
	{
		get
		{
			return this.GetValue(TableUtils.equip_import_batch_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_import_batch_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_import_batch_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_import_batch_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.equip_import_batch_id field.
	/// </summary>
	public string equip_import_batch_idDefault
	{
		get
		{
			return TableUtils.equip_import_batch_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.comments field.
	/// </summary>
	public string comments
	{
		get
		{
			return this.GetValue(TableUtils.commentsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.commentsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool commentsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.commentsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.comments field.
	/// </summary>
	public string commentsDefault
	{
		get
		{
			return TableUtils.commentsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.pm_purchase_order field.
	/// </summary>
	public string pm_purchase_order
	{
		get
		{
			return this.GetValue(TableUtils.pm_purchase_orderColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pm_purchase_orderColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pm_purchase_orderSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pm_purchase_orderColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_purchase_order field.
	/// </summary>
	public string pm_purchase_orderDefault
	{
		get
		{
			return TableUtils.pm_purchase_orderColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.po_date field.
	/// </summary>
	public DateTime po_date
	{
		get
		{
			return this.GetValue(TableUtils.po_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.po_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool po_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.po_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.po_date field.
	/// </summary>
	public string po_dateDefault
	{
		get
		{
			return TableUtils.po_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.date_of_next_pm field.
	/// </summary>
	public DateTime date_of_next_pm
	{
		get
		{
			return this.GetValue(TableUtils.date_of_next_pmColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_of_next_pmColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_of_next_pmSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_of_next_pmColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.date_of_next_pm field.
	/// </summary>
	public string date_of_next_pmDefault
	{
		get
		{
			return TableUtils.date_of_next_pmColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.status field.
	/// </summary>
	public string status
	{
		get
		{
			return this.GetValue(TableUtils.statusColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.statusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool statusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.statusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.status field.
	/// </summary>
	public string statusDefault
	{
		get
		{
			return TableUtils.statusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.service_tech field.
	/// </summary>
	public string service_tech
	{
		get
		{
			return this.GetValue(TableUtils.service_techColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.service_techColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool service_techSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.service_techColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.service_tech field.
	/// </summary>
	public string service_techDefault
	{
		get
		{
			return TableUtils.service_techColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.pm_frequency field.
	/// </summary>
	public Int32 pm_frequency
	{
		get
		{
			return this.GetValue(TableUtils.pm_frequencyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pm_frequencyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pm_frequencySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pm_frequencyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.pm_frequency field.
	/// </summary>
	public string pm_frequencyDefault
	{
		get
		{
			return TableUtils.pm_frequencyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.address field.
	/// </summary>
	public string address
	{
		get
		{
			return this.GetValue(TableUtils.addressColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.addressColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool addressSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.addressColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.address field.
	/// </summary>
	public string addressDefault
	{
		get
		{
			return TableUtils.addressColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.city field.
	/// </summary>
	public string city
	{
		get
		{
			return this.GetValue(TableUtils.cityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool citySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.city field.
	/// </summary>
	public string cityDefault
	{
		get
		{
			return TableUtils.cityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.address_state field.
	/// </summary>
	public string address_state
	{
		get
		{
			return this.GetValue(TableUtils.address_stateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.address_stateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool address_stateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.address_stateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.address_state field.
	/// </summary>
	public string address_stateDefault
	{
		get
		{
			return TableUtils.address_stateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.zipcode field.
	/// </summary>
	public string zipcode
	{
		get
		{
			return this.GetValue(TableUtils.zipcodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.zipcodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool zipcodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.zipcodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.zipcode field.
	/// </summary>
	public string zipcodeDefault
	{
		get
		{
			return TableUtils.zipcodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.contact_first field.
	/// </summary>
	public string contact_first
	{
		get
		{
			return this.GetValue(TableUtils.contact_firstColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contact_firstColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contact_firstSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contact_firstColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.contact_first field.
	/// </summary>
	public string contact_firstDefault
	{
		get
		{
			return TableUtils.contact_firstColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.contact_last field.
	/// </summary>
	public string contact_last
	{
		get
		{
			return this.GetValue(TableUtils.contact_lastColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contact_lastColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contact_lastSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contact_lastColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.contact_last field.
	/// </summary>
	public string contact_lastDefault
	{
		get
		{
			return TableUtils.contact_lastColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.phone_number field.
	/// </summary>
	public string phone_number
	{
		get
		{
			return this.GetValue(TableUtils.phone_numberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.phone_numberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool phone_numberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.phone_numberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.phone_number field.
	/// </summary>
	public string phone_numberDefault
	{
		get
		{
			return TableUtils.phone_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.open_time field.
	/// </summary>
	public DateTime open_time
	{
		get
		{
			return this.GetValue(TableUtils.open_timeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.open_timeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool open_timeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.open_timeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.open_time field.
	/// </summary>
	public string open_timeDefault
	{
		get
		{
			return TableUtils.open_timeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.close_time field.
	/// </summary>
	public DateTime close_time
	{
		get
		{
			return this.GetValue(TableUtils.close_timeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.close_timeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool close_timeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.close_timeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.close_time field.
	/// </summary>
	public string close_timeDefault
	{
		get
		{
			return TableUtils.close_timeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_.serv_rep_parts_po field.
	/// </summary>
	public string serv_rep_parts_po
	{
		get
		{
			return this.GetValue(TableUtils.serv_rep_parts_poColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serv_rep_parts_poColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serv_rep_parts_poSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serv_rep_parts_poColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_.serv_rep_parts_po field.
	/// </summary>
	public string serv_rep_parts_poDefault
	{
		get
		{
			return TableUtils.serv_rep_parts_poColumn.DefaultValue;
		}
	}


#endregion
}

}
