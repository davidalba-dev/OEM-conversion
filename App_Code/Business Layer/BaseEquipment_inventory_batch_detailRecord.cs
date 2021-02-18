// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_inventory_batch_detailRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_inventory_batch_detailRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_inventory_batch_detailTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_inventory_batch_detailTable"></seealso>
/// <seealso cref="Equipment_inventory_batch_detailRecord"></seealso>
public class BaseEquipment_inventory_batch_detailRecord : PrimaryKeyRecord
{

	public readonly static Equipment_inventory_batch_detailTable TableUtils = Equipment_inventory_batch_detailTable.Instance;

	// Constructors
 
	protected BaseEquipment_inventory_batch_detailRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_inventory_batch_detailRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_inventory_batch_detailRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_inventory_batch_detailRecord_ReadRecord); 
	}

	protected BaseEquipment_inventory_batch_detailRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_inventory_batch_detailRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_inventory_batch_detailRecord Equipment_inventory_batch_detailRec = (Equipment_inventory_batch_detailRecord)sender;
        if(Equipment_inventory_batch_detailRec != null && !Equipment_inventory_batch_detailRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_inventory_batch_detailRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_inventory_batch_detailRecord Equipment_inventory_batch_detailRec = (Equipment_inventory_batch_detailRecord)sender;
        Validate_Inserting();
        if(Equipment_inventory_batch_detailRec != null && !Equipment_inventory_batch_detailRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_inventory_batch_detailRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_inventory_batch_detailRecord Equipment_inventory_batch_detailRec = (Equipment_inventory_batch_detailRecord)sender;
        Validate_Updating();
        if(Equipment_inventory_batch_detailRec != null && !Equipment_inventory_batch_detailRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_details_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_batch_details_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_batch_details_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_details_id field.
	/// </summary>
	public Decimal Getequipment_inventory_batch_details_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_batch_details_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_batch_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_id field.
	/// </summary>
	public Decimal Getequipment_inventory_batch_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_batch_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_batch_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.make field.
	/// </summary>
	public ColumnValue GetmakeValue()
	{
		return this.GetValue(TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.make field.
	/// </summary>
	public string GetmakeFieldValue()
	{
		return this.GetValue(TableUtils.makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.make field.
	/// </summary>
	public void SetmakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.make field.
	/// </summary>
	public void SetmakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.model field.
	/// </summary>
	public ColumnValue GetmodelValue()
	{
		return this.GetValue(TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.model field.
	/// </summary>
	public string GetmodelFieldValue()
	{
		return this.GetValue(TableUtils.modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.model field.
	/// </summary>
	public void SetmodelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.model field.
	/// </summary>
	public void SetmodelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.serial_number field.
	/// </summary>
	public ColumnValue Getserial_numberValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.serial_number field.
	/// </summary>
	public string Getserial_numberFieldValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.EIN field.
	/// </summary>
	public ColumnValue GetEINValue()
	{
		return this.GetValue(TableUtils.EINColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.EIN field.
	/// </summary>
	public string GetEINFieldValue()
	{
		return this.GetValue(TableUtils.EINColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.EIN field.
	/// </summary>
	public void SetEINFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EINColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.EIN field.
	/// </summary>
	public void SetEINFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EINColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.purchase_price field.
	/// </summary>
	public ColumnValue Getpurchase_priceValue()
	{
		return this.GetValue(TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.purchase_price field.
	/// </summary>
	public Decimal Getpurchase_priceFieldValue()
	{
		return this.GetValue(TableUtils.purchase_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchase_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.comment field.
	/// </summary>
	public ColumnValue GetcommentValue()
	{
		return this.GetValue(TableUtils.commentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.comment field.
	/// </summary>
	public string GetcommentFieldValue()
	{
		return this.GetValue(TableUtils.commentColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.comment field.
	/// </summary>
	public void SetcommentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.commentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.comment field.
	/// </summary>
	public void SetcommentFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.commentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.accepted field.
	/// </summary>
	public ColumnValue GetacceptedValue()
	{
		return this.GetValue(TableUtils.acceptedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.accepted field.
	/// </summary>
	public bool GetacceptedFieldValue()
	{
		return this.GetValue(TableUtils.acceptedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.accepted field.
	/// </summary>
	public void SetacceptedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.acceptedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.accepted field.
	/// </summary>
	public void SetacceptedFieldValue(string val)
	{
		this.SetString(val, TableUtils.acceptedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.accepted field.
	/// </summary>
	public void SetacceptedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.acceptedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.processed field.
	/// </summary>
	public ColumnValue GetprocessedValue()
	{
		return this.GetValue(TableUtils.processedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.processed field.
	/// </summary>
	public bool GetprocessedFieldValue()
	{
		return this.GetValue(TableUtils.processedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.processed field.
	/// </summary>
	public void SetprocessedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.processedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.processed field.
	/// </summary>
	public void SetprocessedFieldValue(string val)
	{
		this.SetString(val, TableUtils.processedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.processed field.
	/// </summary>
	public void SetprocessedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.processedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.accessories field.
	/// </summary>
	public ColumnValue GetaccessoriesValue()
	{
		return this.GetValue(TableUtils.accessoriesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.accessories field.
	/// </summary>
	public bool GetaccessoriesFieldValue()
	{
		return this.GetValue(TableUtils.accessoriesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.accessories field.
	/// </summary>
	public void SetaccessoriesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.accessoriesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.accessories field.
	/// </summary>
	public void SetaccessoriesFieldValue(string val)
	{
		this.SetString(val, TableUtils.accessoriesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.accessories field.
	/// </summary>
	public void SetaccessoriesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.accessoriesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.phi field.
	/// </summary>
	public ColumnValue GetphiValue()
	{
		return this.GetValue(TableUtils.phiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.phi field.
	/// </summary>
	public bool GetphiFieldValue()
	{
		return this.GetValue(TableUtils.phiColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.phi field.
	/// </summary>
	public void SetphiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.phiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.phi field.
	/// </summary>
	public void SetphiFieldValue(string val)
	{
		this.SetString(val, TableUtils.phiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.phi field.
	/// </summary>
	public void SetphiFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.phiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.condition_id field.
	/// </summary>
	public ColumnValue Getcondition_idValue()
	{
		return this.GetValue(TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.condition_id field.
	/// </summary>
	public string Getcondition_idFieldValue()
	{
		return this.GetValue(TableUtils.condition_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.oem_ein field.
	/// </summary>
	public ColumnValue Getoem_einValue()
	{
		return this.GetValue(TableUtils.oem_einColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.oem_ein field.
	/// </summary>
	public string Getoem_einFieldValue()
	{
		return this.GetValue(TableUtils.oem_einColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.oem_ein field.
	/// </summary>
	public void Setoem_einFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.oem_einColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.oem_ein field.
	/// </summary>
	public void Setoem_einFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_einColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.equipment_inventory_disposition_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_disposition_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.equipment_inventory_disposition_id field.
	/// </summary>
	public Decimal Getequipment_inventory_disposition_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_disposition_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_disposition_id field.
	/// </summary>
	public void Setequipment_inventory_disposition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_disposition_id field.
	/// </summary>
	public void Setequipment_inventory_disposition_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_disposition_id field.
	/// </summary>
	public void Setequipment_inventory_disposition_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_disposition_id field.
	/// </summary>
	public void Setequipment_inventory_disposition_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_disposition_id field.
	/// </summary>
	public void Setequipment_inventory_disposition_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_disposition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.oem_barcode_approve field.
	/// </summary>
	public ColumnValue Getoem_barcode_approveValue()
	{
		return this.GetValue(TableUtils.oem_barcode_approveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.oem_barcode_approve field.
	/// </summary>
	public bool Getoem_barcode_approveFieldValue()
	{
		return this.GetValue(TableUtils.oem_barcode_approveColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.oem_barcode_approve field.
	/// </summary>
	public void Setoem_barcode_approveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.oem_barcode_approveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.oem_barcode_approve field.
	/// </summary>
	public void Setoem_barcode_approveFieldValue(string val)
	{
		this.SetString(val, TableUtils.oem_barcode_approveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.oem_barcode_approve field.
	/// </summary>
	public void Setoem_barcode_approveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_barcode_approveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.last_updated_by field.
	/// </summary>
	public ColumnValue Getlast_updated_byValue()
	{
		return this.GetValue(TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.last_updated_by field.
	/// </summary>
	public Int32 Getlast_updated_byFieldValue()
	{
		return this.GetValue(TableUtils.last_updated_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.last_updated_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.last_updated_datetime field.
	/// </summary>
	public ColumnValue Getlast_updated_datetimeValue()
	{
		return this.GetValue(TableUtils.last_updated_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.last_updated_datetime field.
	/// </summary>
	public DateTime Getlast_updated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.last_updated_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_datetime field.
	/// </summary>
	public void Setlast_updated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.last_updated_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_datetime field.
	/// </summary>
	public void Setlast_updated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.last_updated_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_datetime field.
	/// </summary>
	public void Setlast_updated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.last_updated_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.make_id field.
	/// </summary>
	public ColumnValue Getmake_idValue()
	{
		return this.GetValue(TableUtils.make_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.make_id field.
	/// </summary>
	public string Getmake_idFieldValue()
	{
		return this.GetValue(TableUtils.make_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.make_id field.
	/// </summary>
	public void Setmake_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.make_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.make_id field.
	/// </summary>
	public void Setmake_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.make_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.model_id field.
	/// </summary>
	public ColumnValue Getmodel_idValue()
	{
		return this.GetValue(TableUtils.model_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_batch_detail_.model_id field.
	/// </summary>
	public string Getmodel_idFieldValue()
	{
		return this.GetValue(TableUtils.model_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.model_id field.
	/// </summary>
	public void Setmodel_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.model_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.model_id field.
	/// </summary>
	public void Setmodel_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.model_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_details_id field.
	/// </summary>
	public Decimal equipment_inventory_batch_details_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_batch_details_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_batch_details_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_batch_details_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_batch_details_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_details_id field.
	/// </summary>
	public string equipment_inventory_batch_details_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_batch_details_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_id field.
	/// </summary>
	public Decimal equipment_inventory_batch_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_batch_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_batch_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_batch_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_batch_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_batch_id field.
	/// </summary>
	public string equipment_inventory_batch_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_batch_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.make field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.make field.
	/// </summary>
	public string makeDefault
	{
		get
		{
			return TableUtils.makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.model field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.model field.
	/// </summary>
	public string modelDefault
	{
		get
		{
			return TableUtils.modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.serial_number field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.serial_number field.
	/// </summary>
	public string serial_numberDefault
	{
		get
		{
			return TableUtils.serial_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.EIN field.
	/// </summary>
	public string EIN
	{
		get
		{
			return this.GetValue(TableUtils.EINColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EINColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EINSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EINColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.EIN field.
	/// </summary>
	public string EINDefault
	{
		get
		{
			return TableUtils.EINColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.purchase_price field.
	/// </summary>
	public Decimal purchase_price
	{
		get
		{
			return this.GetValue(TableUtils.purchase_priceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.purchase_priceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool purchase_priceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.purchase_priceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.purchase_price field.
	/// </summary>
	public string purchase_priceDefault
	{
		get
		{
			return TableUtils.purchase_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.comment field.
	/// </summary>
	public string comment
	{
		get
		{
			return this.GetValue(TableUtils.commentColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.commentColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool commentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.commentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.comment field.
	/// </summary>
	public string commentDefault
	{
		get
		{
			return TableUtils.commentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.accepted field.
	/// </summary>
	public bool accepted
	{
		get
		{
			return this.GetValue(TableUtils.acceptedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.acceptedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool acceptedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.acceptedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.accepted field.
	/// </summary>
	public string acceptedDefault
	{
		get
		{
			return TableUtils.acceptedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.processed field.
	/// </summary>
	public bool processed
	{
		get
		{
			return this.GetValue(TableUtils.processedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.processedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool processedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.processedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.processed field.
	/// </summary>
	public string processedDefault
	{
		get
		{
			return TableUtils.processedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.accessories field.
	/// </summary>
	public bool accessories
	{
		get
		{
			return this.GetValue(TableUtils.accessoriesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.accessoriesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool accessoriesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.accessoriesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.accessories field.
	/// </summary>
	public string accessoriesDefault
	{
		get
		{
			return TableUtils.accessoriesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.phi field.
	/// </summary>
	public bool phi
	{
		get
		{
			return this.GetValue(TableUtils.phiColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.phiColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool phiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.phiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.phi field.
	/// </summary>
	public string phiDefault
	{
		get
		{
			return TableUtils.phiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.condition_id field.
	/// </summary>
	public string condition_id
	{
		get
		{
			return this.GetValue(TableUtils.condition_idColumn).ToString();
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.condition_id field.
	/// </summary>
	public string condition_idDefault
	{
		get
		{
			return TableUtils.condition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.oem_ein field.
	/// </summary>
	public string oem_ein
	{
		get
		{
			return this.GetValue(TableUtils.oem_einColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.oem_einColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool oem_einSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.oem_einColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.oem_ein field.
	/// </summary>
	public string oem_einDefault
	{
		get
		{
			return TableUtils.oem_einColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.equipment_inventory_disposition_id field.
	/// </summary>
	public Decimal equipment_inventory_disposition_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_disposition_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_disposition_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_disposition_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_disposition_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.equipment_inventory_disposition_id field.
	/// </summary>
	public string equipment_inventory_disposition_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_disposition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.oem_barcode_approve field.
	/// </summary>
	public bool oem_barcode_approve
	{
		get
		{
			return this.GetValue(TableUtils.oem_barcode_approveColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.oem_barcode_approveColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool oem_barcode_approveSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.oem_barcode_approveColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.oem_barcode_approve field.
	/// </summary>
	public string oem_barcode_approveDefault
	{
		get
		{
			return TableUtils.oem_barcode_approveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.created_by field.
	/// </summary>
	public Int32 created_by
	{
		get
		{
			return this.GetValue(TableUtils.created_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.created_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool created_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.created_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.created_datetime field.
	/// </summary>
	public DateTime created_datetime
	{
		get
		{
			return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.created_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool created_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.created_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.created_datetime field.
	/// </summary>
	public string created_datetimeDefault
	{
		get
		{
			return TableUtils.created_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.last_updated_by field.
	/// </summary>
	public Int32 last_updated_by
	{
		get
		{
			return this.GetValue(TableUtils.last_updated_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.last_updated_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool last_updated_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.last_updated_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_by field.
	/// </summary>
	public string last_updated_byDefault
	{
		get
		{
			return TableUtils.last_updated_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.last_updated_datetime field.
	/// </summary>
	public DateTime last_updated_datetime
	{
		get
		{
			return this.GetValue(TableUtils.last_updated_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.last_updated_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool last_updated_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.last_updated_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.last_updated_datetime field.
	/// </summary>
	public string last_updated_datetimeDefault
	{
		get
		{
			return TableUtils.last_updated_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.make_id field.
	/// </summary>
	public string make_id
	{
		get
		{
			return this.GetValue(TableUtils.make_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.make_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool make_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.make_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.make_id field.
	/// </summary>
	public string make_idDefault
	{
		get
		{
			return TableUtils.make_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_batch_detail_.model_id field.
	/// </summary>
	public string model_id
	{
		get
		{
			return this.GetValue(TableUtils.model_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.model_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool model_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.model_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_batch_detail_.model_id field.
	/// </summary>
	public string model_idDefault
	{
		get
		{
			return TableUtils.model_idColumn.DefaultValue;
		}
	}


#endregion
}

}
