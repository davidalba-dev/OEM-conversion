// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_loadRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_loadRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_loadTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_loadTable"></seealso>
/// <seealso cref="Equipment_loadRecord"></seealso>
public class BaseEquipment_loadRecord : PrimaryKeyRecord
{

	public readonly static Equipment_loadTable TableUtils = Equipment_loadTable.Instance;

	// Constructors
 
	protected BaseEquipment_loadRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_loadRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_loadRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_loadRecord_ReadRecord); 
	}

	protected BaseEquipment_loadRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_loadRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_loadRecord Equipment_loadRec = (Equipment_loadRecord)sender;
        if(Equipment_loadRec != null && !Equipment_loadRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_loadRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_loadRecord Equipment_loadRec = (Equipment_loadRecord)sender;
        Validate_Inserting();
        if(Equipment_loadRec != null && !Equipment_loadRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_loadRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_loadRecord Equipment_loadRec = (Equipment_loadRecord)sender;
        Validate_Updating();
        if(Equipment_loadRec != null && !Equipment_loadRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.equipment_load_id field.
	/// </summary>
	public ColumnValue Getequipment_load_idValue()
	{
		return this.GetValue(TableUtils.equipment_load_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.equipment_load_id field.
	/// </summary>
	public Int32 Getequipment_load_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_load_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.date_received field.
	/// </summary>
	public ColumnValue Getdate_receivedValue()
	{
		return this.GetValue(TableUtils.date_receivedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.date_received field.
	/// </summary>
	public DateTime Getdate_receivedFieldValue()
	{
		return this.GetValue(TableUtils.date_receivedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.date_received field.
	/// </summary>
	public void Setdate_receivedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_receivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.date_received field.
	/// </summary>
	public void Setdate_receivedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_receivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.date_received field.
	/// </summary>
	public void Setdate_receivedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_receivedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.received_from field.
	/// </summary>
	public ColumnValue Getreceived_fromValue()
	{
		return this.GetValue(TableUtils.received_fromColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.received_from field.
	/// </summary>
	public string Getreceived_fromFieldValue()
	{
		return this.GetValue(TableUtils.received_fromColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.received_from field.
	/// </summary>
	public void Setreceived_fromFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.received_fromColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.received_from field.
	/// </summary>
	public void Setreceived_fromFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_fromColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.make field.
	/// </summary>
	public ColumnValue GetmakeValue()
	{
		return this.GetValue(TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.make field.
	/// </summary>
	public string GetmakeFieldValue()
	{
		return this.GetValue(TableUtils.makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.make field.
	/// </summary>
	public void SetmakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.make field.
	/// </summary>
	public void SetmakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.model field.
	/// </summary>
	public ColumnValue GetmodelValue()
	{
		return this.GetValue(TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.model field.
	/// </summary>
	public string GetmodelFieldValue()
	{
		return this.GetValue(TableUtils.modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.model field.
	/// </summary>
	public void SetmodelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.model field.
	/// </summary>
	public void SetmodelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.makkey field.
	/// </summary>
	public ColumnValue GetmakkeyValue()
	{
		return this.GetValue(TableUtils.makkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.makkey field.
	/// </summary>
	public Int32 GetmakkeyFieldValue()
	{
		return this.GetValue(TableUtils.makkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.serial_number field.
	/// </summary>
	public ColumnValue Getserial_numberValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.serial_number field.
	/// </summary>
	public string Getserial_numberFieldValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.condition field.
	/// </summary>
	public ColumnValue GetconditionValue()
	{
		return this.GetValue(TableUtils.conditionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.condition field.
	/// </summary>
	public string GetconditionFieldValue()
	{
		return this.GetValue(TableUtils.conditionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.condition field.
	/// </summary>
	public void SetconditionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.conditionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.condition field.
	/// </summary>
	public void SetconditionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.conditionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.lockkey field.
	/// </summary>
	public ColumnValue GetlockkeyValue()
	{
		return this.GetValue(TableUtils.lockkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.lockkey field.
	/// </summary>
	public Int32 GetlockkeyFieldValue()
	{
		return this.GetValue(TableUtils.lockkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.purchase field.
	/// </summary>
	public ColumnValue GetpurchaseValue()
	{
		return this.GetValue(TableUtils.purchaseColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.purchase field.
	/// </summary>
	public Decimal GetpurchaseFieldValue()
	{
		return this.GetValue(TableUtils.purchaseColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.purchase field.
	/// </summary>
	public void SetpurchaseFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.purchaseColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.purchase field.
	/// </summary>
	public void SetpurchaseFieldValue(string val)
	{
		this.SetString(val, TableUtils.purchaseColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.purchase field.
	/// </summary>
	public void SetpurchaseFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchaseColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.purchase field.
	/// </summary>
	public void SetpurchaseFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchaseColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.purchase field.
	/// </summary>
	public void SetpurchaseFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchaseColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.disposition field.
	/// </summary>
	public ColumnValue GetdispositionValue()
	{
		return this.GetValue(TableUtils.dispositionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.disposition field.
	/// </summary>
	public string GetdispositionFieldValue()
	{
		return this.GetValue(TableUtils.dispositionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.disposition field.
	/// </summary>
	public void SetdispositionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dispositionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.disposition field.
	/// </summary>
	public void SetdispositionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dispositionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.disposition_Id field.
	/// </summary>
	public ColumnValue Getdisposition_IdValue()
	{
		return this.GetValue(TableUtils.disposition_IdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.disposition_Id field.
	/// </summary>
	public Int32 Getdisposition_IdFieldValue()
	{
		return this.GetValue(TableUtils.disposition_IdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.proposed field.
	/// </summary>
	public ColumnValue GetproposedValue()
	{
		return this.GetValue(TableUtils.proposedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.proposed field.
	/// </summary>
	public Decimal GetproposedFieldValue()
	{
		return this.GetValue(TableUtils.proposedColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.proposed field.
	/// </summary>
	public void SetproposedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.proposedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.proposed field.
	/// </summary>
	public void SetproposedFieldValue(string val)
	{
		this.SetString(val, TableUtils.proposedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.proposed field.
	/// </summary>
	public void SetproposedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.proposed field.
	/// </summary>
	public void SetproposedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.proposed field.
	/// </summary>
	public void SetproposedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.date_sold field.
	/// </summary>
	public ColumnValue Getdate_soldValue()
	{
		return this.GetValue(TableUtils.date_soldColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.date_sold field.
	/// </summary>
	public DateTime Getdate_soldFieldValue()
	{
		return this.GetValue(TableUtils.date_soldColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.date_sold field.
	/// </summary>
	public void Setdate_soldFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_soldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.date_sold field.
	/// </summary>
	public void Setdate_soldFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_soldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.date_sold field.
	/// </summary>
	public void Setdate_soldFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_soldColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.final_sale field.
	/// </summary>
	public ColumnValue Getfinal_saleValue()
	{
		return this.GetValue(TableUtils.final_saleColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.final_sale field.
	/// </summary>
	public Decimal Getfinal_saleFieldValue()
	{
		return this.GetValue(TableUtils.final_saleColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.final_sale field.
	/// </summary>
	public void Setfinal_saleFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.final_saleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.final_sale field.
	/// </summary>
	public void Setfinal_saleFieldValue(string val)
	{
		this.SetString(val, TableUtils.final_saleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.final_sale field.
	/// </summary>
	public void Setfinal_saleFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.final_saleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.final_sale field.
	/// </summary>
	public void Setfinal_saleFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.final_saleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.final_sale field.
	/// </summary>
	public void Setfinal_saleFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.final_saleColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.oem_ein field.
	/// </summary>
	public ColumnValue Getoem_einValue()
	{
		return this.GetValue(TableUtils.oem_einColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.oem_ein field.
	/// </summary>
	public string Getoem_einFieldValue()
	{
		return this.GetValue(TableUtils.oem_einColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.oem_ein field.
	/// </summary>
	public void Setoem_einFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.oem_einColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.oem_ein field.
	/// </summary>
	public void Setoem_einFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_einColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.found field.
	/// </summary>
	public ColumnValue GetfoundValue()
	{
		return this.GetValue(TableUtils.foundColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.found field.
	/// </summary>
	public string GetfoundFieldValue()
	{
		return this.GetValue(TableUtils.foundColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.found field.
	/// </summary>
	public void SetfoundFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.foundColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.found field.
	/// </summary>
	public void SetfoundFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.foundColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.equipment_invoice_adv field.
	/// </summary>
	public ColumnValue Getequipment_invoice_advValue()
	{
		return this.GetValue(TableUtils.equipment_invoice_advColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.equipment_invoice_adv field.
	/// </summary>
	public string Getequipment_invoice_advFieldValue()
	{
		return this.GetValue(TableUtils.equipment_invoice_advColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.equipment_invoice_adv field.
	/// </summary>
	public void Setequipment_invoice_advFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_invoice_advColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.equipment_invoice_adv field.
	/// </summary>
	public void Setequipment_invoice_advFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_invoice_advColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.new_category field.
	/// </summary>
	public ColumnValue Getnew_categoryValue()
	{
		return this.GetValue(TableUtils.new_categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.new_category field.
	/// </summary>
	public string Getnew_categoryFieldValue()
	{
		return this.GetValue(TableUtils.new_categoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.new_category field.
	/// </summary>
	public void Setnew_categoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.new_categoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.new_category field.
	/// </summary>
	public void Setnew_categoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_categoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.dotmed_active field.
	/// </summary>
	public ColumnValue Getdotmed_activeValue()
	{
		return this.GetValue(TableUtils.dotmed_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.dotmed_active field.
	/// </summary>
	public string Getdotmed_activeFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_activeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.dotmed_active field.
	/// </summary>
	public void Setdotmed_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.dotmed_active field.
	/// </summary>
	public void Setdotmed_activeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.warehouse field.
	/// </summary>
	public ColumnValue GetwarehouseValue()
	{
		return this.GetValue(TableUtils.warehouseColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.warehouse field.
	/// </summary>
	public string GetwarehouseFieldValue()
	{
		return this.GetValue(TableUtils.warehouseColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.warehouse field.
	/// </summary>
	public void SetwarehouseFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouseColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.warehouse field.
	/// </summary>
	public void SetwarehouseFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouseColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.warehouse_id field.
	/// </summary>
	public ColumnValue Getwarehouse_idValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.warehouse_id field.
	/// </summary>
	public Int32 Getwarehouse_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.warehouse_location field.
	/// </summary>
	public ColumnValue Getwarehouse_locationValue()
	{
		return this.GetValue(TableUtils.warehouse_locationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.warehouse_location field.
	/// </summary>
	public string Getwarehouse_locationFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_locationColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.warehouse_location field.
	/// </summary>
	public void Setwarehouse_locationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_locationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.warehouse_location field.
	/// </summary>
	public void Setwarehouse_locationFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_locationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.warehouse_location_id field.
	/// </summary>
	public ColumnValue Getwarehouse_location_idValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.warehouse_location_id field.
	/// </summary>
	public Int32 Getwarehouse_location_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.dotmed_id field.
	/// </summary>
	public ColumnValue Getdotmed_idValue()
	{
		return this.GetValue(TableUtils.dotmed_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_load_.dotmed_id field.
	/// </summary>
	public Int32 Getdotmed_idFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_idColumn).ToInt32();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.equipment_load_id field.
	/// </summary>
	public Int32 equipment_load_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_load_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_load_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_load_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_load_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.equipment_load_id field.
	/// </summary>
	public string equipment_load_idDefault
	{
		get
		{
			return TableUtils.equipment_load_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.date_received field.
	/// </summary>
	public DateTime date_received
	{
		get
		{
			return this.GetValue(TableUtils.date_receivedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_receivedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_receivedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_receivedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.date_received field.
	/// </summary>
	public string date_receivedDefault
	{
		get
		{
			return TableUtils.date_receivedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.received_from field.
	/// </summary>
	public string received_from
	{
		get
		{
			return this.GetValue(TableUtils.received_fromColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.received_fromColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool received_fromSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.received_fromColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.received_from field.
	/// </summary>
	public string received_fromDefault
	{
		get
		{
			return TableUtils.received_fromColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.make field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.make field.
	/// </summary>
	public string makeDefault
	{
		get
		{
			return TableUtils.makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.model field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.model field.
	/// </summary>
	public string modelDefault
	{
		get
		{
			return TableUtils.modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.makkey field.
	/// </summary>
	public Int32 makkey
	{
		get
		{
			return this.GetValue(TableUtils.makkeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.makkeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool makkeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.makkeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.makkey field.
	/// </summary>
	public string makkeyDefault
	{
		get
		{
			return TableUtils.makkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.serial_number field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.serial_number field.
	/// </summary>
	public string serial_numberDefault
	{
		get
		{
			return TableUtils.serial_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.condition field.
	/// </summary>
	public string condition
	{
		get
		{
			return this.GetValue(TableUtils.conditionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.conditionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool conditionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.conditionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.condition field.
	/// </summary>
	public string conditionDefault
	{
		get
		{
			return TableUtils.conditionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.lockkey field.
	/// </summary>
	public Int32 lockkey
	{
		get
		{
			return this.GetValue(TableUtils.lockkeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.lockkeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool lockkeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.lockkeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.lockkey field.
	/// </summary>
	public string lockkeyDefault
	{
		get
		{
			return TableUtils.lockkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.purchase field.
	/// </summary>
	public Decimal purchase
	{
		get
		{
			return this.GetValue(TableUtils.purchaseColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.purchaseColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool purchaseSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.purchaseColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.purchase field.
	/// </summary>
	public string purchaseDefault
	{
		get
		{
			return TableUtils.purchaseColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.disposition field.
	/// </summary>
	public string disposition
	{
		get
		{
			return this.GetValue(TableUtils.dispositionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dispositionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dispositionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dispositionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.disposition field.
	/// </summary>
	public string dispositionDefault
	{
		get
		{
			return TableUtils.dispositionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.disposition_Id field.
	/// </summary>
	public Int32 disposition_Id
	{
		get
		{
			return this.GetValue(TableUtils.disposition_IdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.disposition_IdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool disposition_IdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.disposition_IdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.disposition_Id field.
	/// </summary>
	public string disposition_IdDefault
	{
		get
		{
			return TableUtils.disposition_IdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.proposed field.
	/// </summary>
	public Decimal proposed
	{
		get
		{
			return this.GetValue(TableUtils.proposedColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.proposedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool proposedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.proposedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.proposed field.
	/// </summary>
	public string proposedDefault
	{
		get
		{
			return TableUtils.proposedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.date_sold field.
	/// </summary>
	public DateTime date_sold
	{
		get
		{
			return this.GetValue(TableUtils.date_soldColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_soldColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_soldSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_soldColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.date_sold field.
	/// </summary>
	public string date_soldDefault
	{
		get
		{
			return TableUtils.date_soldColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.final_sale field.
	/// </summary>
	public Decimal final_sale
	{
		get
		{
			return this.GetValue(TableUtils.final_saleColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.final_saleColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool final_saleSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.final_saleColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.final_sale field.
	/// </summary>
	public string final_saleDefault
	{
		get
		{
			return TableUtils.final_saleColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.oem_ein field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.oem_ein field.
	/// </summary>
	public string oem_einDefault
	{
		get
		{
			return TableUtils.oem_einColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.found field.
	/// </summary>
	public string found
	{
		get
		{
			return this.GetValue(TableUtils.foundColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.foundColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool foundSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.foundColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.found field.
	/// </summary>
	public string foundDefault
	{
		get
		{
			return TableUtils.foundColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.equipment_invoice_adv field.
	/// </summary>
	public string equipment_invoice_adv
	{
		get
		{
			return this.GetValue(TableUtils.equipment_invoice_advColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_invoice_advColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_invoice_advSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_invoice_advColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.equipment_invoice_adv field.
	/// </summary>
	public string equipment_invoice_advDefault
	{
		get
		{
			return TableUtils.equipment_invoice_advColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.new_category field.
	/// </summary>
	public string new_category
	{
		get
		{
			return this.GetValue(TableUtils.new_categoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.new_categoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool new_categorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.new_categoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.new_category field.
	/// </summary>
	public string new_categoryDefault
	{
		get
		{
			return TableUtils.new_categoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.category_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.category_id field.
	/// </summary>
	public string category_idDefault
	{
		get
		{
			return TableUtils.category_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.dotmed_active field.
	/// </summary>
	public string dotmed_active
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_activeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_activeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.dotmed_active field.
	/// </summary>
	public string dotmed_activeDefault
	{
		get
		{
			return TableUtils.dotmed_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.warehouse field.
	/// </summary>
	public string warehouse
	{
		get
		{
			return this.GetValue(TableUtils.warehouseColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouseColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouseSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouseColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.warehouse field.
	/// </summary>
	public string warehouseDefault
	{
		get
		{
			return TableUtils.warehouseColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.warehouse_id field.
	/// </summary>
	public Int32 warehouse_id
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_idColumn).ToInt32();
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.warehouse_id field.
	/// </summary>
	public string warehouse_idDefault
	{
		get
		{
			return TableUtils.warehouse_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.warehouse_location field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.warehouse_location field.
	/// </summary>
	public string warehouse_locationDefault
	{
		get
		{
			return TableUtils.warehouse_locationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.warehouse_location_id field.
	/// </summary>
	public Int32 warehouse_location_id
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_location_idColumn).ToInt32();
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.warehouse_location_id field.
	/// </summary>
	public string warehouse_location_idDefault
	{
		get
		{
			return TableUtils.warehouse_location_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_load_.dotmed_id field.
	/// </summary>
	public Int32 dotmed_id
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_load_.dotmed_id field.
	/// </summary>
	public string dotmed_idDefault
	{
		get
		{
			return TableUtils.dotmed_idColumn.DefaultValue;
		}
	}


#endregion
}

}
