// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_inventoryRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Web;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;


namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_inventoryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_inventoryTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_inventoryTable"></seealso>
/// <seealso cref="Equipment_inventoryRecord"></seealso>
public class BaseEquipment_inventoryRecord : PrimaryKeyRecord
{

	public readonly static Equipment_inventoryTable TableUtils = Equipment_inventoryTable.Instance;

	// Constructors
 
	protected BaseEquipment_inventoryRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_inventoryRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_inventoryRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_inventoryRecord_ReadRecord); 
	}

	protected BaseEquipment_inventoryRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_inventoryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_inventoryRecord Equipment_inventoryRec = (Equipment_inventoryRecord)sender;
        if(Equipment_inventoryRec != null && !Equipment_inventoryRec.IsReadOnly ){
               
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_inventoryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_inventoryRecord Equipment_inventoryRec = (Equipment_inventoryRecord)sender;
        Validate_Inserting();
       if(Equipment_inventoryRec != null && !Equipment_inventoryRec.IsReadOnly ){
              }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_inventoryRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_inventoryRecord Equipment_inventoryRec = (Equipment_inventoryRecord)sender;
        Validate_Updating();
        if(Equipment_inventoryRec != null && !Equipment_inventoryRec.IsReadOnly ){
                HttpContext.Current.Session["inventoryID"] = Equipment_inventoryRec.inventory_id;



            }
    
    }

   //Evaluates Validate when->Inserting formulas specified at the data access layer
	protected virtual void Validate_Inserting()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";
            if (formula == "") formula = "";


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
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.inventory_id field.
	/// </summary>
	public ColumnValue Getinventory_idValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.inventory_id field.
	/// </summary>
	public Decimal Getinventory_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.date_received field.
	/// </summary>
	public ColumnValue Getdate_receivedValue()
	{
		return this.GetValue(TableUtils.date_receivedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.date_received field.
	/// </summary>
	public DateTime Getdate_receivedFieldValue()
	{
		return this.GetValue(TableUtils.date_receivedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_received field.
	/// </summary>
	public void Setdate_receivedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_receivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_received field.
	/// </summary>
	public void Setdate_receivedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_receivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_received field.
	/// </summary>
	public void Setdate_receivedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_receivedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.received_from_customer_id field.
	/// </summary>
	public ColumnValue Getreceived_from_customer_idValue()
	{
		return this.GetValue(TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.received_from_customer_id field.
	/// </summary>
	public Int32 Getreceived_from_customer_idFieldValue()
	{
		return this.GetValue(TableUtils.received_from_customer_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_customer_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.received_from_contact_id field.
	/// </summary>
	public ColumnValue Getreceived_from_contact_idValue()
	{
		return this.GetValue(TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.received_from_contact_id field.
	/// </summary>
	public Int32 Getreceived_from_contact_idFieldValue()
	{
		return this.GetValue(TableUtils.received_from_contact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_contact_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.make_id field.
	/// </summary>
	public ColumnValue Getmake_idValue()
	{
		return this.GetValue(TableUtils.make_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.make_id field.
	/// </summary>
	public string Getmake_idFieldValue()
	{
		return this.GetValue(TableUtils.make_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.make_id field.
	/// </summary>
	public void Setmake_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.make_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.make_id field.
	/// </summary>
	public void Setmake_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.make_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.model_id field.
	/// </summary>
	public ColumnValue Getmodel_idValue()
	{
		return this.GetValue(TableUtils.model_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.model_id field.
	/// </summary>
	public string Getmodel_idFieldValue()
	{
		return this.GetValue(TableUtils.model_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.model_id field.
	/// </summary>
	public void Setmodel_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.model_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.model_id field.
	/// </summary>
	public void Setmodel_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.model_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.serial_number field.
	/// </summary>
	public ColumnValue Getserial_numberValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.serial_number field.
	/// </summary>
	public string Getserial_numberFieldValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.customer_ein field.
	/// </summary>
	public ColumnValue Getcustomer_einValue()
	{
		return this.GetValue(TableUtils.customer_einColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.customer_ein field.
	/// </summary>
	public string Getcustomer_einFieldValue()
	{
		return this.GetValue(TableUtils.customer_einColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.customer_ein field.
	/// </summary>
	public void Setcustomer_einFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_einColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.customer_ein field.
	/// </summary>
	public void Setcustomer_einFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_einColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.other_id_num field.
	/// </summary>
	public ColumnValue Getother_id_numValue()
	{
		return this.GetValue(TableUtils.other_id_numColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.other_id_num field.
	/// </summary>
	public string Getother_id_numFieldValue()
	{
		return this.GetValue(TableUtils.other_id_numColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.other_id_num field.
	/// </summary>
	public void Setother_id_numFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.other_id_numColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.other_id_num field.
	/// </summary>
	public void Setother_id_numFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.other_id_numColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.description field.
	/// </summary>
	public ColumnValue GetdescriptionValue()
	{
		return this.GetValue(TableUtils.descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.description field.
	/// </summary>
	public string GetdescriptionFieldValue()
	{
		return this.GetValue(TableUtils.descriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.description field.
	/// </summary>
	public void SetdescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.description field.
	/// </summary>
	public void SetdescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.descriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.category_id field.
	/// </summary>
	public string Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.repair_notes field.
	/// </summary>
	public ColumnValue Getrepair_notesValue()
	{
		return this.GetValue(TableUtils.repair_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.repair_notes field.
	/// </summary>
	public string Getrepair_notesFieldValue()
	{
		return this.GetValue(TableUtils.repair_notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.repair_notes field.
	/// </summary>
	public void Setrepair_notesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.repair_notes field.
	/// </summary>
	public void Setrepair_notesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_notesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.condition_id field.
	/// </summary>
	public ColumnValue Getcondition_idValue()
	{
		return this.GetValue(TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.condition_id field.
	/// </summary>
	public string Getcondition_idFieldValue()
	{
		return this.GetValue(TableUtils.condition_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.require_accessories field.
	/// </summary>
	public ColumnValue Getrequire_accessoriesValue()
	{
		return this.GetValue(TableUtils.require_accessoriesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.require_accessories field.
	/// </summary>
	public bool Getrequire_accessoriesFieldValue()
	{
		return this.GetValue(TableUtils.require_accessoriesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.require_accessories field.
	/// </summary>
	public void Setrequire_accessoriesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.require_accessoriesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.require_accessories field.
	/// </summary>
	public void Setrequire_accessoriesFieldValue(string val)
	{
		this.SetString(val, TableUtils.require_accessoriesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.require_accessories field.
	/// </summary>
	public void Setrequire_accessoriesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.require_accessoriesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_phi field.
	/// </summary>
	public ColumnValue Getequipment_phiValue()
	{
		return this.GetValue(TableUtils.equipment_phiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_phi field.
	/// </summary>
	public bool Getequipment_phiFieldValue()
	{
		return this.GetValue(TableUtils.equipment_phiColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_phi field.
	/// </summary>
	public void Setequipment_phiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_phiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_phi field.
	/// </summary>
	public void Setequipment_phiFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_phiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_phi field.
	/// </summary>
	public void Setequipment_phiFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_phiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.purchase_price field.
	/// </summary>
	public ColumnValue Getpurchase_priceValue()
	{
		return this.GetValue(TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.purchase_price field.
	/// </summary>
	public Decimal Getpurchase_priceFieldValue()
	{
		return this.GetValue(TableUtils.purchase_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchase_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.pd_date field.
	/// </summary>
	public ColumnValue Getpd_dateValue()
	{
		return this.GetValue(TableUtils.pd_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.pd_date field.
	/// </summary>
	public DateTime Getpd_dateFieldValue()
	{
		return this.GetValue(TableUtils.pd_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.pd_date field.
	/// </summary>
	public void Setpd_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pd_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.pd_date field.
	/// </summary>
	public void Setpd_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.pd_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.pd_date field.
	/// </summary>
	public void Setpd_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pd_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.doc_num field.
	/// </summary>
	public ColumnValue Getdoc_numValue()
	{
		return this.GetValue(TableUtils.doc_numColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.doc_num field.
	/// </summary>
	public string Getdoc_numFieldValue()
	{
		return this.GetValue(TableUtils.doc_numColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.doc_num field.
	/// </summary>
	public void Setdoc_numFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.doc_numColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.doc_num field.
	/// </summary>
	public void Setdoc_numFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.doc_numColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.disposition_id field.
	/// </summary>
	public ColumnValue Getdisposition_idValue()
	{
		return this.GetValue(TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.disposition_id field.
	/// </summary>
	public Decimal Getdisposition_idFieldValue()
	{
		return this.GetValue(TableUtils.disposition_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.disposition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.sale_method_id field.
	/// </summary>
	public ColumnValue Getsale_method_idValue()
	{
		return this.GetValue(TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.sale_method_id field.
	/// </summary>
	public Decimal Getsale_method_idFieldValue()
	{
		return this.GetValue(TableUtils.sale_method_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sale_method_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.proposed_sale_price field.
	/// </summary>
	public ColumnValue Getproposed_sale_priceValue()
	{
		return this.GetValue(TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.proposed_sale_price field.
	/// </summary>
	public Decimal Getproposed_sale_priceFieldValue()
	{
		return this.GetValue(TableUtils.proposed_sale_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.date_sold field.
	/// </summary>
	public ColumnValue Getdate_soldValue()
	{
		return this.GetValue(TableUtils.date_soldColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.date_sold field.
	/// </summary>
	public DateTime Getdate_soldFieldValue()
	{
		return this.GetValue(TableUtils.date_soldColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_sold field.
	/// </summary>
	public void Setdate_soldFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_soldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_sold field.
	/// </summary>
	public void Setdate_soldFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_soldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_sold field.
	/// </summary>
	public void Setdate_soldFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_soldColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.date_disposed field.
	/// </summary>
	public ColumnValue Getdate_disposedValue()
	{
		return this.GetValue(TableUtils.date_disposedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.date_disposed field.
	/// </summary>
	public DateTime Getdate_disposedFieldValue()
	{
		return this.GetValue(TableUtils.date_disposedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_disposed field.
	/// </summary>
	public void Setdate_disposedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_disposedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_disposed field.
	/// </summary>
	public void Setdate_disposedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_disposedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_disposed field.
	/// </summary>
	public void Setdate_disposedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_disposedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.sold_from_id field.
	/// </summary>
	public ColumnValue Getsold_from_idValue()
	{
		return this.GetValue(TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.sold_from_id field.
	/// </summary>
	public Decimal Getsold_from_idFieldValue()
	{
		return this.GetValue(TableUtils.sold_from_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sold_from_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.final_sale_price field.
	/// </summary>
	public ColumnValue Getfinal_sale_priceValue()
	{
		return this.GetValue(TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.final_sale_price field.
	/// </summary>
	public Decimal Getfinal_sale_priceFieldValue()
	{
		return this.GetValue(TableUtils.final_sale_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.final_sale_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.warehouse_id field.
	/// </summary>
	public ColumnValue Getwarehouse_idValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.warehouse_id field.
	/// </summary>
	public Decimal Getwarehouse_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.warehouse_location_id field.
	/// </summary>
	public ColumnValue Getwarehouse_location_idValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.warehouse_location_id field.
	/// </summary>
	public Decimal Getwarehouse_location_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.cogs field.
	/// </summary>
	public ColumnValue GetcogsValue()
	{
		return this.GetValue(TableUtils.cogsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.cogs field.
	/// </summary>
	public Decimal GetcogsFieldValue()
	{
		return this.GetValue(TableUtils.cogsColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.inventory_status_id field.
	/// </summary>
	public ColumnValue Getinventory_status_idValue()
	{
		return this.GetValue(TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.inventory_status_id field.
	/// </summary>
	public Decimal Getinventory_status_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_status_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_status_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic1Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic1FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic1Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public void Setequipment_inventory_pic1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public void Setequipment_inventory_pic1FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public void Setequipment_inventory_pic1FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic2Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic2FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic2Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public void Setequipment_inventory_pic2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public void Setequipment_inventory_pic2FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public void Setequipment_inventory_pic2FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic3Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic3FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic3Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public void Setequipment_inventory_pic3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public void Setequipment_inventory_pic3FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public void Setequipment_inventory_pic3FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.datetime_added field.
	/// </summary>
	public ColumnValue Getdatetime_addedValue()
	{
		return this.GetValue(TableUtils.datetime_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.datetime_added field.
	/// </summary>
	public DateTime Getdatetime_addedFieldValue()
	{
		return this.GetValue(TableUtils.datetime_addedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.datetime_added field.
	/// </summary>
	public void Setdatetime_addedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.datetime_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.datetime_added field.
	/// </summary>
	public void Setdatetime_addedFieldValue(string val)
	{
		this.SetString(val, TableUtils.datetime_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.datetime_added field.
	/// </summary>
	public void Setdatetime_addedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.datetime_addedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_type_id field.
	/// </summary>
	public ColumnValue Getequipment_type_idValue()
	{
		return this.GetValue(TableUtils.equipment_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_type_id field.
	/// </summary>
	public Decimal Getequipment_type_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_type_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_type_id field.
	/// </summary>
	public void Setequipment_type_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_type_id field.
	/// </summary>
	public void Setequipment_type_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_type_id field.
	/// </summary>
	public void Setequipment_type_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_type_id field.
	/// </summary>
	public void Setequipment_type_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_type_id field.
	/// </summary>
	public void Setequipment_type_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_type_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_cost field.
	/// </summary>
	public ColumnValue Getshipping_costValue()
	{
		return this.GetValue(TableUtils.shipping_costColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_cost field.
	/// </summary>
	public Decimal Getshipping_costFieldValue()
	{
		return this.GetValue(TableUtils.shipping_costColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_cost field.
	/// </summary>
	public void Setshipping_costFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.shipping_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_cost field.
	/// </summary>
	public void Setshipping_costFieldValue(string val)
	{
		this.SetString(val, TableUtils.shipping_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_cost field.
	/// </summary>
	public void Setshipping_costFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_cost field.
	/// </summary>
	public void Setshipping_costFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_cost field.
	/// </summary>
	public void Setshipping_costFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_costColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_invoice field.
	/// </summary>
	public ColumnValue Getshipping_invoiceValue()
	{
		return this.GetValue(TableUtils.shipping_invoiceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_invoice field.
	/// </summary>
	public string Getshipping_invoiceFieldValue()
	{
		return this.GetValue(TableUtils.shipping_invoiceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_invoice field.
	/// </summary>
	public void Setshipping_invoiceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.shipping_invoiceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_invoice field.
	/// </summary>
	public void Setshipping_invoiceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_invoiceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.oem_ein field.
	/// </summary>
	public ColumnValue Getoem_einValue()
	{
		return this.GetValue(TableUtils.oem_einColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.oem_ein field.
	/// </summary>
	public string Getoem_einFieldValue()
	{
		return this.GetValue(TableUtils.oem_einColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.oem_ein field.
	/// </summary>
	public void Setoem_einFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.oem_einColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.oem_ein field.
	/// </summary>
	public void Setoem_einFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_einColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.wire_fee field.
	/// </summary>
	public ColumnValue Getwire_feeValue()
	{
		return this.GetValue(TableUtils.wire_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.wire_fee field.
	/// </summary>
	public Decimal Getwire_feeFieldValue()
	{
		return this.GetValue(TableUtils.wire_feeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.wire_fee field.
	/// </summary>
	public void Setwire_feeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.wire_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.wire_fee field.
	/// </summary>
	public void Setwire_feeFieldValue(string val)
	{
		this.SetString(val, TableUtils.wire_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.wire_fee field.
	/// </summary>
	public void Setwire_feeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.wire_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.wire_fee field.
	/// </summary>
	public void Setwire_feeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.wire_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.wire_fee field.
	/// </summary>
	public void Setwire_feeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.wire_feeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.ebay_fee field.
	/// </summary>
	public ColumnValue Getebay_feeValue()
	{
		return this.GetValue(TableUtils.ebay_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.ebay_fee field.
	/// </summary>
	public Decimal Getebay_feeFieldValue()
	{
		return this.GetValue(TableUtils.ebay_feeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.ebay_fee field.
	/// </summary>
	public void Setebay_feeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ebay_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.ebay_fee field.
	/// </summary>
	public void Setebay_feeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ebay_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.ebay_fee field.
	/// </summary>
	public void Setebay_feeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ebay_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.ebay_fee field.
	/// </summary>
	public void Setebay_feeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ebay_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.ebay_fee field.
	/// </summary>
	public void Setebay_feeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ebay_feeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.paypal_fee field.
	/// </summary>
	public ColumnValue Getpaypal_feeValue()
	{
		return this.GetValue(TableUtils.paypal_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.paypal_fee field.
	/// </summary>
	public Decimal Getpaypal_feeFieldValue()
	{
		return this.GetValue(TableUtils.paypal_feeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.paypal_fee field.
	/// </summary>
	public void Setpaypal_feeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.paypal_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.paypal_fee field.
	/// </summary>
	public void Setpaypal_feeFieldValue(string val)
	{
		this.SetString(val, TableUtils.paypal_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.paypal_fee field.
	/// </summary>
	public void Setpaypal_feeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.paypal_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.paypal_fee field.
	/// </summary>
	public void Setpaypal_feeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.paypal_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.paypal_fee field.
	/// </summary>
	public void Setpaypal_feeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.paypal_feeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.credit_card_fee field.
	/// </summary>
	public ColumnValue Getcredit_card_feeValue()
	{
		return this.GetValue(TableUtils.credit_card_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.credit_card_fee field.
	/// </summary>
	public Decimal Getcredit_card_feeFieldValue()
	{
		return this.GetValue(TableUtils.credit_card_feeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.credit_card_fee field.
	/// </summary>
	public void Setcredit_card_feeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.credit_card_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.credit_card_fee field.
	/// </summary>
	public void Setcredit_card_feeFieldValue(string val)
	{
		this.SetString(val, TableUtils.credit_card_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.credit_card_fee field.
	/// </summary>
	public void Setcredit_card_feeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.credit_card_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.credit_card_fee field.
	/// </summary>
	public void Setcredit_card_feeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.credit_card_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.credit_card_fee field.
	/// </summary>
	public void Setcredit_card_feeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.credit_card_feeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equip_inv_ad_cat_id_1 field.
	/// </summary>
	public ColumnValue Getequip_inv_ad_cat_id_1Value()
	{
		return this.GetValue(TableUtils.equip_inv_ad_cat_id_1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equip_inv_ad_cat_id_1 field.
	/// </summary>
	public Decimal Getequip_inv_ad_cat_id_1FieldValue()
	{
		return this.GetValue(TableUtils.equip_inv_ad_cat_id_1Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_1 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equip_inv_ad_cat_id_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_1 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_1FieldValue(string val)
	{
		this.SetString(val, TableUtils.equip_inv_ad_cat_id_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_1 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_1 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_1 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equip_inv_ad_cat_id_2 field.
	/// </summary>
	public ColumnValue Getequip_inv_ad_cat_id_2Value()
	{
		return this.GetValue(TableUtils.equip_inv_ad_cat_id_2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equip_inv_ad_cat_id_2 field.
	/// </summary>
	public Decimal Getequip_inv_ad_cat_id_2FieldValue()
	{
		return this.GetValue(TableUtils.equip_inv_ad_cat_id_2Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_2 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equip_inv_ad_cat_id_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_2 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_2FieldValue(string val)
	{
		this.SetString(val, TableUtils.equip_inv_ad_cat_id_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_2 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_2 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_2 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equip_inv_ad_cat_id_3 field.
	/// </summary>
	public ColumnValue Getequip_inv_ad_cat_id_3Value()
	{
		return this.GetValue(TableUtils.equip_inv_ad_cat_id_3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equip_inv_ad_cat_id_3 field.
	/// </summary>
	public Decimal Getequip_inv_ad_cat_id_3FieldValue()
	{
		return this.GetValue(TableUtils.equip_inv_ad_cat_id_3Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_3 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equip_inv_ad_cat_id_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_3 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_3FieldValue(string val)
	{
		this.SetString(val, TableUtils.equip_inv_ad_cat_id_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_3 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_3 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_3 field.
	/// </summary>
	public void Setequip_inv_ad_cat_id_3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.profit field.
	/// </summary>
	public ColumnValue GetprofitValue()
	{
		return this.GetValue(TableUtils.profitColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.profit field.
	/// </summary>
	public Decimal GetprofitFieldValue()
	{
		return this.GetValue(TableUtils.profitColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_tracking field.
	/// </summary>
	public ColumnValue Getshipping_trackingValue()
	{
		return this.GetValue(TableUtils.shipping_trackingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_tracking field.
	/// </summary>
	public string Getshipping_trackingFieldValue()
	{
		return this.GetValue(TableUtils.shipping_trackingColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_tracking field.
	/// </summary>
	public void Setshipping_trackingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.shipping_trackingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_tracking field.
	/// </summary>
	public void Setshipping_trackingFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_trackingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.other_fee field.
	/// </summary>
	public ColumnValue Getother_feeValue()
	{
		return this.GetValue(TableUtils.other_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.other_fee field.
	/// </summary>
	public Decimal Getother_feeFieldValue()
	{
		return this.GetValue(TableUtils.other_feeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.other_fee field.
	/// </summary>
	public void Setother_feeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.other_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.other_fee field.
	/// </summary>
	public void Setother_feeFieldValue(string val)
	{
		this.SetString(val, TableUtils.other_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.other_fee field.
	/// </summary>
	public void Setother_feeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.other_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.other_fee field.
	/// </summary>
	public void Setother_feeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.other_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.other_fee field.
	/// </summary>
	public void Setother_feeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.other_feeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_retail field.
	/// </summary>
	public ColumnValue Getshipping_retailValue()
	{
		return this.GetValue(TableUtils.shipping_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_retail field.
	/// </summary>
	public Decimal Getshipping_retailFieldValue()
	{
		return this.GetValue(TableUtils.shipping_retailColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_retail field.
	/// </summary>
	public void Setshipping_retailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.shipping_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_retail field.
	/// </summary>
	public void Setshipping_retailFieldValue(string val)
	{
		this.SetString(val, TableUtils.shipping_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_retail field.
	/// </summary>
	public void Setshipping_retailFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_retail field.
	/// </summary>
	public void Setshipping_retailFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_retail field.
	/// </summary>
	public void Setshipping_retailFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_retailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipvia field.
	/// </summary>
	public ColumnValue GetshipviaValue()
	{
		return this.GetValue(TableUtils.shipviaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipvia field.
	/// </summary>
	public string GetshipviaFieldValue()
	{
		return this.GetValue(TableUtils.shipviaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipvia field.
	/// </summary>
	public void SetshipviaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.shipviaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipvia field.
	/// </summary>
	public void SetshipviaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipviaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_date field.
	/// </summary>
	public ColumnValue Getshipping_dateValue()
	{
		return this.GetValue(TableUtils.shipping_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.shipping_date field.
	/// </summary>
	public DateTime Getshipping_dateFieldValue()
	{
		return this.GetValue(TableUtils.shipping_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_date field.
	/// </summary>
	public void Setshipping_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.shipping_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_date field.
	/// </summary>
	public void Setshipping_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.shipping_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_date field.
	/// </summary>
	public void Setshipping_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.customer_purchased field.
	/// </summary>
	public ColumnValue Getcustomer_purchasedValue()
	{
		return this.GetValue(TableUtils.customer_purchasedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.customer_purchased field.
	/// </summary>
	public Int32 Getcustomer_purchasedFieldValue()
	{
		return this.GetValue(TableUtils.customer_purchasedColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.customer_purchased field.
	/// </summary>
	public void Setcustomer_purchasedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_purchasedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.customer_purchased field.
	/// </summary>
	public void Setcustomer_purchasedFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_purchasedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.customer_purchased field.
	/// </summary>
	public void Setcustomer_purchasedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_purchasedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.customer_purchased field.
	/// </summary>
	public void Setcustomer_purchasedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_purchasedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.customer_purchased field.
	/// </summary>
	public void Setcustomer_purchasedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_purchasedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.vendno field.
	/// </summary>
	public ColumnValue GetvendnoValue()
	{
		return this.GetValue(TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.vendno field.
	/// </summary>
	public Int32 GetvendnoFieldValue()
	{
		return this.GetValue(TableUtils.vendnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_batch_details_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_batch_details_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_batch_details_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_batch_details_id field.
	/// </summary>
	public Decimal Getequipment_inventory_batch_details_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_batch_details_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_details_id field.
	/// </summary>
	public void Setequipment_inventory_batch_details_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_batch_details_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_details_id field.
	/// </summary>
	public void Setequipment_inventory_batch_details_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_batch_details_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_details_id field.
	/// </summary>
	public void Setequipment_inventory_batch_details_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_batch_details_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_details_id field.
	/// </summary>
	public void Setequipment_inventory_batch_details_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_batch_details_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_details_id field.
	/// </summary>
	public void Setequipment_inventory_batch_details_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_batch_details_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_batch_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_batch_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_batch_id field.
	/// </summary>
	public Decimal Getequipment_inventory_batch_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_batch_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_id field.
	/// </summary>
	public void Setequipment_inventory_batch_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_batch_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.new_category_id field.
	/// </summary>
	public ColumnValue Getnew_category_idValue()
	{
		return this.GetValue(TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.new_category_id field.
	/// </summary>
	public Int32 Getnew_category_idFieldValue()
	{
		return this.GetValue(TableUtils.new_category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_category_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic4 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic4Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic4 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic4FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic4Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic4 field.
	/// </summary>
	public void Setequipment_inventory_pic4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic4 field.
	/// </summary>
	public void Setequipment_inventory_pic4FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic4 field.
	/// </summary>
	public void Setequipment_inventory_pic4FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic5 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic5Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic5Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic5 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic5FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic5Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic5 field.
	/// </summary>
	public void Setequipment_inventory_pic5FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic5Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic5 field.
	/// </summary>
	public void Setequipment_inventory_pic5FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic5Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic5 field.
	/// </summary>
	public void Setequipment_inventory_pic5FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic5Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic6 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic6Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic6Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic6 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic6FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic6Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic6 field.
	/// </summary>
	public void Setequipment_inventory_pic6FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic6Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic6 field.
	/// </summary>
	public void Setequipment_inventory_pic6FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic6Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic6 field.
	/// </summary>
	public void Setequipment_inventory_pic6FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic6Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic7 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic7Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic7Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic7 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic7FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic7Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic7 field.
	/// </summary>
	public void Setequipment_inventory_pic7FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic7Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic7 field.
	/// </summary>
	public void Setequipment_inventory_pic7FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic7Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic7 field.
	/// </summary>
	public void Setequipment_inventory_pic7FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic7Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic8 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic8Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic8Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic8 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic8FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic8Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic8 field.
	/// </summary>
	public void Setequipment_inventory_pic8FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic8Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic8 field.
	/// </summary>
	public void Setequipment_inventory_pic8FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic8Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic8 field.
	/// </summary>
	public void Setequipment_inventory_pic8FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic8Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic9 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic9Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic9Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic9 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic9FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic9Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic9 field.
	/// </summary>
	public void Setequipment_inventory_pic9FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic9Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic9 field.
	/// </summary>
	public void Setequipment_inventory_pic9FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic9Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic9 field.
	/// </summary>
	public void Setequipment_inventory_pic9FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic9Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic10 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic10Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic10Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic10 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic10FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic10Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic10 field.
	/// </summary>
	public void Setequipment_inventory_pic10FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic10Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic10 field.
	/// </summary>
	public void Setequipment_inventory_pic10FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic10Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic10 field.
	/// </summary>
	public void Setequipment_inventory_pic10FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic10Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.sold_by field.
	/// </summary>
	public ColumnValue Getsold_byValue()
	{
		return this.GetValue(TableUtils.sold_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.sold_by field.
	/// </summary>
	public Int32 Getsold_byFieldValue()
	{
		return this.GetValue(TableUtils.sold_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_by field.
	/// </summary>
	public void Setsold_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.sold_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_by field.
	/// </summary>
	public void Setsold_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.sold_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_by field.
	/// </summary>
	public void Setsold_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sold_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_by field.
	/// </summary>
	public void Setsold_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sold_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_by field.
	/// </summary>
	public void Setsold_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sold_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_qty field.
	/// </summary>
	public ColumnValue Getequipment_qtyValue()
	{
		return this.GetValue(TableUtils.equipment_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_qty field.
	/// </summary>
	public Int32 Getequipment_qtyFieldValue()
	{
		return this.GetValue(TableUtils.equipment_qtyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_qty field.
	/// </summary>
	public void Setequipment_qtyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_qty field.
	/// </summary>
	public void Setequipment_qtyFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_qty field.
	/// </summary>
	public void Setequipment_qtyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_qty field.
	/// </summary>
	public void Setequipment_qtyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_qty field.
	/// </summary>
	public void Setequipment_qtyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_qtyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic1_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic1_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic1_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic1_name field.
	/// </summary>
	public string Getequipment_inventory_pic1_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic1_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic1_name field.
	/// </summary>
	public void Setequipment_inventory_pic1_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic1_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic1_name field.
	/// </summary>
	public void Setequipment_inventory_pic1_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic1_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic2_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic2_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic2_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic2_name field.
	/// </summary>
	public string Getequipment_inventory_pic2_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic2_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic2_name field.
	/// </summary>
	public void Setequipment_inventory_pic2_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic2_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic2_name field.
	/// </summary>
	public void Setequipment_inventory_pic2_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic2_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic3_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic3_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic3_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic3_name field.
	/// </summary>
	public string Getequipment_inventory_pic3_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic3_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic3_name field.
	/// </summary>
	public void Setequipment_inventory_pic3_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic3_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic3_name field.
	/// </summary>
	public void Setequipment_inventory_pic3_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic3_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic4_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic4_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic4_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic4_name field.
	/// </summary>
	public string Getequipment_inventory_pic4_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic4_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic4_name field.
	/// </summary>
	public void Setequipment_inventory_pic4_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic4_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic4_name field.
	/// </summary>
	public void Setequipment_inventory_pic4_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic4_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic5_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic5_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic5_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic5_name field.
	/// </summary>
	public string Getequipment_inventory_pic5_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic5_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic5_name field.
	/// </summary>
	public void Setequipment_inventory_pic5_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic5_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic5_name field.
	/// </summary>
	public void Setequipment_inventory_pic5_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic5_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic6_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic6_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic6_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic6_name field.
	/// </summary>
	public string Getequipment_inventory_pic6_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic6_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic6_name field.
	/// </summary>
	public void Setequipment_inventory_pic6_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic6_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic6_name field.
	/// </summary>
	public void Setequipment_inventory_pic6_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic6_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic7_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic7_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic7_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic7_name field.
	/// </summary>
	public string Getequipment_inventory_pic7_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic7_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic7_name field.
	/// </summary>
	public void Setequipment_inventory_pic7_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic7_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic7_name field.
	/// </summary>
	public void Setequipment_inventory_pic7_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic7_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic8_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic8_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic8_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic8_name field.
	/// </summary>
	public string Getequipment_inventory_pic8_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic8_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic8_name field.
	/// </summary>
	public void Setequipment_inventory_pic8_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic8_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic8_name field.
	/// </summary>
	public void Setequipment_inventory_pic8_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic8_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic9_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic9_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic9_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic9_name field.
	/// </summary>
	public string Getequipment_inventory_pic9_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic9_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic9_name field.
	/// </summary>
	public void Setequipment_inventory_pic9_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic9_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic9_name field.
	/// </summary>
	public void Setequipment_inventory_pic9_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic9_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic10_name field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic10_nameValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic10_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic10_name field.
	/// </summary>
	public string Getequipment_inventory_pic10_nameFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic10_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic10_name field.
	/// </summary>
	public void Setequipment_inventory_pic10_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic10_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic10_name field.
	/// </summary>
	public void Setequipment_inventory_pic10_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic10_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.encoded_inventory_id field.
	/// </summary>
	public ColumnValue Getencoded_inventory_idValue()
	{
		return this.GetValue(TableUtils.encoded_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.encoded_inventory_id field.
	/// </summary>
	public string Getencoded_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.encoded_inventory_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.encoded_inventory_id field.
	/// </summary>
	public void Setencoded_inventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.encoded_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.encoded_inventory_id field.
	/// </summary>
	public void Setencoded_inventory_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.encoded_inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.last_updated_by field.
	/// </summary>
	public ColumnValue Getlast_updated_byValue()
	{
		return this.GetValue(TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.last_updated_by field.
	/// </summary>
	public Int32 Getlast_updated_byFieldValue()
	{
		return this.GetValue(TableUtils.last_updated_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.last_updated_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.last_updated_by field.
	/// </summary>
	public void Setlast_updated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.last_updated_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_dotmed_it field.
	/// </summary>
	public ColumnValue Getequipment_dotmed_itValue()
	{
		return this.GetValue(TableUtils.equipment_dotmed_itColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_dotmed_it field.
	/// </summary>
	public Int32 Getequipment_dotmed_itFieldValue()
	{
		return this.GetValue(TableUtils.equipment_dotmed_itColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_dotmed_it field.
	/// </summary>
	public void Setequipment_dotmed_itFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_dotmed_itColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_dotmed_it field.
	/// </summary>
	public void Setequipment_dotmed_itFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_dotmed_itColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_dotmed_it field.
	/// </summary>
	public void Setequipment_dotmed_itFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_dotmed_itColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_dotmed_it field.
	/// </summary>
	public void Setequipment_dotmed_itFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_dotmed_itColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_dotmed_it field.
	/// </summary>
	public void Setequipment_dotmed_itFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_dotmed_itColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_old field.
	/// </summary>
	public ColumnValue Getequipment_inventory_oldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_oldColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_old field.
	/// </summary>
	public Int32 Getequipment_inventory_oldFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_oldColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_old field.
	/// </summary>
	public void Setequipment_inventory_oldFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_oldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_old field.
	/// </summary>
	public void Setequipment_inventory_oldFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_oldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_old field.
	/// </summary>
	public void Setequipment_inventory_oldFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_oldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_old field.
	/// </summary>
	public void Setequipment_inventory_oldFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_oldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_old field.
	/// </summary>
	public void Setequipment_inventory_oldFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_oldColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.old_inventory_id field.
	/// </summary>
	public ColumnValue Getold_inventory_idValue()
	{
		return this.GetValue(TableUtils.old_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.old_inventory_id field.
	/// </summary>
	public Int32 Getold_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.old_inventory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.dotmed_active field.
	/// </summary>
	public ColumnValue Getdotmed_activeValue()
	{
		return this.GetValue(TableUtils.dotmed_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_.dotmed_active field.
	/// </summary>
	public string Getdotmed_activeFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_activeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.dotmed_active field.
	/// </summary>
	public void Setdotmed_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.dotmed_active field.
	/// </summary>
	public void Setdotmed_activeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.inventory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.inventory_id field.
	/// </summary>
	public string inventory_idDefault
	{
		get
		{
			return TableUtils.inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.date_received field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_received field.
	/// </summary>
	public string date_receivedDefault
	{
		get
		{
			return TableUtils.date_receivedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.received_from_customer_id field.
	/// </summary>
	public Int32 received_from_customer_id
	{
		get
		{
			return this.GetValue(TableUtils.received_from_customer_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.received_from_customer_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool received_from_customer_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.received_from_customer_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_customer_id field.
	/// </summary>
	public string received_from_customer_idDefault
	{
		get
		{
			return TableUtils.received_from_customer_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.received_from_contact_id field.
	/// </summary>
	public Int32 received_from_contact_id
	{
		get
		{
			return this.GetValue(TableUtils.received_from_contact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.received_from_contact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool received_from_contact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.received_from_contact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.received_from_contact_id field.
	/// </summary>
	public string received_from_contact_idDefault
	{
		get
		{
			return TableUtils.received_from_contact_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.make_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.make_id field.
	/// </summary>
	public string make_idDefault
	{
		get
		{
			return TableUtils.make_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.model_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.model_id field.
	/// </summary>
	public string model_idDefault
	{
		get
		{
			return TableUtils.model_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.serial_number field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.serial_number field.
	/// </summary>
	public string serial_numberDefault
	{
		get
		{
			return TableUtils.serial_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.customer_ein field.
	/// </summary>
	public string customer_ein
	{
		get
		{
			return this.GetValue(TableUtils.customer_einColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_einColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_einSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_einColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.customer_ein field.
	/// </summary>
	public string customer_einDefault
	{
		get
		{
			return TableUtils.customer_einColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.other_id_num field.
	/// </summary>
	public string other_id_num
	{
		get
		{
			return this.GetValue(TableUtils.other_id_numColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.other_id_numColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool other_id_numSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.other_id_numColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.other_id_num field.
	/// </summary>
	public string other_id_numDefault
	{
		get
		{
			return TableUtils.other_id_numColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.description field.
	/// </summary>
	public string description
	{
		get
		{
			return this.GetValue(TableUtils.descriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.descriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool descriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.descriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.description field.
	/// </summary>
	public string descriptionDefault
	{
		get
		{
			return TableUtils.descriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.category_id field.
	/// </summary>
	public string category_id
	{
		get
		{
			return this.GetValue(TableUtils.category_idColumn).ToString();
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.category_id field.
	/// </summary>
	public string category_idDefault
	{
		get
		{
			return TableUtils.category_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.repair_notes field.
	/// </summary>
	public string repair_notes
	{
		get
		{
			return this.GetValue(TableUtils.repair_notesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_notesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_notesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_notesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.repair_notes field.
	/// </summary>
	public string repair_notesDefault
	{
		get
		{
			return TableUtils.repair_notesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.condition_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.condition_id field.
	/// </summary>
	public string condition_idDefault
	{
		get
		{
			return TableUtils.condition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.require_accessories field.
	/// </summary>
	public bool require_accessories
	{
		get
		{
			return this.GetValue(TableUtils.require_accessoriesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.require_accessoriesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool require_accessoriesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.require_accessoriesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.require_accessories field.
	/// </summary>
	public string require_accessoriesDefault
	{
		get
		{
			return TableUtils.require_accessoriesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_phi field.
	/// </summary>
	public bool equipment_phi
	{
		get
		{
			return this.GetValue(TableUtils.equipment_phiColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.equipment_phiColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_phiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_phiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_phi field.
	/// </summary>
	public string equipment_phiDefault
	{
		get
		{
			return TableUtils.equipment_phiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.purchase_price field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.purchase_price field.
	/// </summary>
	public string purchase_priceDefault
	{
		get
		{
			return TableUtils.purchase_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.pd_date field.
	/// </summary>
	public DateTime pd_date
	{
		get
		{
			return this.GetValue(TableUtils.pd_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pd_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pd_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pd_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.pd_date field.
	/// </summary>
	public string pd_dateDefault
	{
		get
		{
			return TableUtils.pd_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.doc_num field.
	/// </summary>
	public string doc_num
	{
		get
		{
			return this.GetValue(TableUtils.doc_numColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.doc_numColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool doc_numSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.doc_numColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.doc_num field.
	/// </summary>
	public string doc_numDefault
	{
		get
		{
			return TableUtils.doc_numColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.disposition_id field.
	/// </summary>
	public Decimal disposition_id
	{
		get
		{
			return this.GetValue(TableUtils.disposition_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.disposition_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool disposition_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.disposition_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.disposition_id field.
	/// </summary>
	public string disposition_idDefault
	{
		get
		{
			return TableUtils.disposition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.sale_method_id field.
	/// </summary>
	public Decimal sale_method_id
	{
		get
		{
			return this.GetValue(TableUtils.sale_method_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.sale_method_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool sale_method_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.sale_method_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sale_method_id field.
	/// </summary>
	public string sale_method_idDefault
	{
		get
		{
			return TableUtils.sale_method_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.proposed_sale_price field.
	/// </summary>
	public Decimal proposed_sale_price
	{
		get
		{
			return this.GetValue(TableUtils.proposed_sale_priceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool proposed_sale_priceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.proposed_sale_priceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.proposed_sale_price field.
	/// </summary>
	public string proposed_sale_priceDefault
	{
		get
		{
			return TableUtils.proposed_sale_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.date_sold field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_sold field.
	/// </summary>
	public string date_soldDefault
	{
		get
		{
			return TableUtils.date_soldColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.date_disposed field.
	/// </summary>
	public DateTime date_disposed
	{
		get
		{
			return this.GetValue(TableUtils.date_disposedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_disposedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_disposedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_disposedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.date_disposed field.
	/// </summary>
	public string date_disposedDefault
	{
		get
		{
			return TableUtils.date_disposedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.sold_from_id field.
	/// </summary>
	public Decimal sold_from_id
	{
		get
		{
			return this.GetValue(TableUtils.sold_from_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.sold_from_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool sold_from_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.sold_from_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_from_id field.
	/// </summary>
	public string sold_from_idDefault
	{
		get
		{
			return TableUtils.sold_from_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.final_sale_price field.
	/// </summary>
	public Decimal final_sale_price
	{
		get
		{
			return this.GetValue(TableUtils.final_sale_priceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.final_sale_priceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool final_sale_priceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.final_sale_priceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.final_sale_price field.
	/// </summary>
	public string final_sale_priceDefault
	{
		get
		{
			return TableUtils.final_sale_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.warehouse_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_id field.
	/// </summary>
	public string warehouse_idDefault
	{
		get
		{
			return TableUtils.warehouse_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.warehouse_location_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.warehouse_location_id field.
	/// </summary>
	public string warehouse_location_idDefault
	{
		get
		{
			return TableUtils.warehouse_location_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.cogs field.
	/// </summary>
	public Decimal cogs
	{
		get
		{
			return this.GetValue(TableUtils.cogsColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cogsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cogsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cogsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.cogs field.
	/// </summary>
	public string cogsDefault
	{
		get
		{
			return TableUtils.cogsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.inventory_status_id field.
	/// </summary>
	public Decimal inventory_status_id
	{
		get
		{
			return this.GetValue(TableUtils.inventory_status_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.inventory_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool inventory_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.inventory_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.inventory_status_id field.
	/// </summary>
	public string inventory_status_idDefault
	{
		get
		{
			return TableUtils.inventory_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public byte[] equipment_inventory_pic1
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic1Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic1Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public string equipment_inventory_pic1Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public byte[] equipment_inventory_pic2
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic2Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic2Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public string equipment_inventory_pic2Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public byte[] equipment_inventory_pic3
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic3Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic3Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public string equipment_inventory_pic3Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.technician_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.datetime_added field.
	/// </summary>
	public DateTime datetime_added
	{
		get
		{
			return this.GetValue(TableUtils.datetime_addedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.datetime_addedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool datetime_addedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.datetime_addedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.datetime_added field.
	/// </summary>
	public string datetime_addedDefault
	{
		get
		{
			return TableUtils.datetime_addedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_type_id field.
	/// </summary>
	public Decimal equipment_type_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_type_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_type_id field.
	/// </summary>
	public string equipment_type_idDefault
	{
		get
		{
			return TableUtils.equipment_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.shipping_cost field.
	/// </summary>
	public Decimal shipping_cost
	{
		get
		{
			return this.GetValue(TableUtils.shipping_costColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.shipping_costColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool shipping_costSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.shipping_costColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_cost field.
	/// </summary>
	public string shipping_costDefault
	{
		get
		{
			return TableUtils.shipping_costColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.shipping_invoice field.
	/// </summary>
	public string shipping_invoice
	{
		get
		{
			return this.GetValue(TableUtils.shipping_invoiceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.shipping_invoiceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool shipping_invoiceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.shipping_invoiceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_invoice field.
	/// </summary>
	public string shipping_invoiceDefault
	{
		get
		{
			return TableUtils.shipping_invoiceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.oem_ein field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.oem_ein field.
	/// </summary>
	public string oem_einDefault
	{
		get
		{
			return TableUtils.oem_einColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.wire_fee field.
	/// </summary>
	public Decimal wire_fee
	{
		get
		{
			return this.GetValue(TableUtils.wire_feeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.wire_feeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool wire_feeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.wire_feeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.wire_fee field.
	/// </summary>
	public string wire_feeDefault
	{
		get
		{
			return TableUtils.wire_feeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.ebay_fee field.
	/// </summary>
	public Decimal ebay_fee
	{
		get
		{
			return this.GetValue(TableUtils.ebay_feeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ebay_feeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ebay_feeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ebay_feeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.ebay_fee field.
	/// </summary>
	public string ebay_feeDefault
	{
		get
		{
			return TableUtils.ebay_feeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.paypal_fee field.
	/// </summary>
	public Decimal paypal_fee
	{
		get
		{
			return this.GetValue(TableUtils.paypal_feeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.paypal_feeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool paypal_feeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.paypal_feeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.paypal_fee field.
	/// </summary>
	public string paypal_feeDefault
	{
		get
		{
			return TableUtils.paypal_feeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.credit_card_fee field.
	/// </summary>
	public Decimal credit_card_fee
	{
		get
		{
			return this.GetValue(TableUtils.credit_card_feeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.credit_card_feeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool credit_card_feeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.credit_card_feeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.credit_card_fee field.
	/// </summary>
	public string credit_card_feeDefault
	{
		get
		{
			return TableUtils.credit_card_feeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equip_inv_ad_cat_id_1 field.
	/// </summary>
	public Decimal equip_inv_ad_cat_id_1
	{
		get
		{
			return this.GetValue(TableUtils.equip_inv_ad_cat_id_1Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_inv_ad_cat_id_1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_inv_ad_cat_id_1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_1 field.
	/// </summary>
	public string equip_inv_ad_cat_id_1Default
	{
		get
		{
			return TableUtils.equip_inv_ad_cat_id_1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equip_inv_ad_cat_id_2 field.
	/// </summary>
	public Decimal equip_inv_ad_cat_id_2
	{
		get
		{
			return this.GetValue(TableUtils.equip_inv_ad_cat_id_2Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_inv_ad_cat_id_2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_inv_ad_cat_id_2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_2 field.
	/// </summary>
	public string equip_inv_ad_cat_id_2Default
	{
		get
		{
			return TableUtils.equip_inv_ad_cat_id_2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equip_inv_ad_cat_id_3 field.
	/// </summary>
	public Decimal equip_inv_ad_cat_id_3
	{
		get
		{
			return this.GetValue(TableUtils.equip_inv_ad_cat_id_3Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_inv_ad_cat_id_3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_inv_ad_cat_id_3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_inv_ad_cat_id_3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equip_inv_ad_cat_id_3 field.
	/// </summary>
	public string equip_inv_ad_cat_id_3Default
	{
		get
		{
			return TableUtils.equip_inv_ad_cat_id_3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.profit field.
	/// </summary>
	public Decimal profit
	{
		get
		{
			return this.GetValue(TableUtils.profitColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.profitColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool profitSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.profitColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.profit field.
	/// </summary>
	public string profitDefault
	{
		get
		{
			return TableUtils.profitColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.shipping_tracking field.
	/// </summary>
	public string shipping_tracking
	{
		get
		{
			return this.GetValue(TableUtils.shipping_trackingColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.shipping_trackingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool shipping_trackingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.shipping_trackingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_tracking field.
	/// </summary>
	public string shipping_trackingDefault
	{
		get
		{
			return TableUtils.shipping_trackingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.other_fee field.
	/// </summary>
	public Decimal other_fee
	{
		get
		{
			return this.GetValue(TableUtils.other_feeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.other_feeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool other_feeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.other_feeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.other_fee field.
	/// </summary>
	public string other_feeDefault
	{
		get
		{
			return TableUtils.other_feeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.shipping_retail field.
	/// </summary>
	public Decimal shipping_retail
	{
		get
		{
			return this.GetValue(TableUtils.shipping_retailColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.shipping_retailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool shipping_retailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.shipping_retailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_retail field.
	/// </summary>
	public string shipping_retailDefault
	{
		get
		{
			return TableUtils.shipping_retailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.shipvia field.
	/// </summary>
	public string shipvia
	{
		get
		{
			return this.GetValue(TableUtils.shipviaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.shipviaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool shipviaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.shipviaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipvia field.
	/// </summary>
	public string shipviaDefault
	{
		get
		{
			return TableUtils.shipviaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.shipping_date field.
	/// </summary>
	public DateTime shipping_date
	{
		get
		{
			return this.GetValue(TableUtils.shipping_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.shipping_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool shipping_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.shipping_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.shipping_date field.
	/// </summary>
	public string shipping_dateDefault
	{
		get
		{
			return TableUtils.shipping_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.customer_purchased field.
	/// </summary>
	public Int32 customer_purchased
	{
		get
		{
			return this.GetValue(TableUtils.customer_purchasedColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_purchasedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_purchasedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_purchasedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.customer_purchased field.
	/// </summary>
	public string customer_purchasedDefault
	{
		get
		{
			return TableUtils.customer_purchasedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.vendno field.
	/// </summary>
	public Int32 vendno
	{
		get
		{
			return this.GetValue(TableUtils.vendnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.vendnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool vendnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.vendnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.vendno field.
	/// </summary>
	public string vendnoDefault
	{
		get
		{
			return TableUtils.vendnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_batch_details_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_details_id field.
	/// </summary>
	public string equipment_inventory_batch_details_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_batch_details_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_batch_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_batch_id field.
	/// </summary>
	public string equipment_inventory_batch_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_batch_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.new_category_id field.
	/// </summary>
	public Int32 new_category_id
	{
		get
		{
			return this.GetValue(TableUtils.new_category_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.new_category_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool new_category_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.new_category_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.new_category_id field.
	/// </summary>
	public string new_category_idDefault
	{
		get
		{
			return TableUtils.new_category_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic4 field.
	/// </summary>
	public byte[] equipment_inventory_pic4
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic4Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic4Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic4 field.
	/// </summary>
	public string equipment_inventory_pic4Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic5 field.
	/// </summary>
	public byte[] equipment_inventory_pic5
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic5Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic5Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic5Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic5Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic5 field.
	/// </summary>
	public string equipment_inventory_pic5Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic5Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic6 field.
	/// </summary>
	public byte[] equipment_inventory_pic6
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic6Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic6Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic6Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic6Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic6 field.
	/// </summary>
	public string equipment_inventory_pic6Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic6Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic7 field.
	/// </summary>
	public byte[] equipment_inventory_pic7
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic7Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic7Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic7Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic7Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic7 field.
	/// </summary>
	public string equipment_inventory_pic7Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic7Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic8 field.
	/// </summary>
	public byte[] equipment_inventory_pic8
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic8Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic8Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic8Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic8Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic8 field.
	/// </summary>
	public string equipment_inventory_pic8Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic8Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic9 field.
	/// </summary>
	public byte[] equipment_inventory_pic9
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic9Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic9Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic9Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic9Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic9 field.
	/// </summary>
	public string equipment_inventory_pic9Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic9Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic10 field.
	/// </summary>
	public byte[] equipment_inventory_pic10
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic10Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic10Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic10Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic10Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic10 field.
	/// </summary>
	public string equipment_inventory_pic10Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic10Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.sold_by field.
	/// </summary>
	public Int32 sold_by
	{
		get
		{
			return this.GetValue(TableUtils.sold_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.sold_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool sold_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.sold_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.sold_by field.
	/// </summary>
	public string sold_byDefault
	{
		get
		{
			return TableUtils.sold_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_qty field.
	/// </summary>
	public Int32 equipment_qty
	{
		get
		{
			return this.GetValue(TableUtils.equipment_qtyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_qtyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_qtySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_qtyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_qty field.
	/// </summary>
	public string equipment_qtyDefault
	{
		get
		{
			return TableUtils.equipment_qtyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic1_name field.
	/// </summary>
	public string equipment_inventory_pic1_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic1_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic1_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic1_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic1_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic1_name field.
	/// </summary>
	public string equipment_inventory_pic1_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic1_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic2_name field.
	/// </summary>
	public string equipment_inventory_pic2_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic2_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic2_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic2_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic2_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic2_name field.
	/// </summary>
	public string equipment_inventory_pic2_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic2_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic3_name field.
	/// </summary>
	public string equipment_inventory_pic3_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic3_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic3_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic3_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic3_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic3_name field.
	/// </summary>
	public string equipment_inventory_pic3_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic3_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic4_name field.
	/// </summary>
	public string equipment_inventory_pic4_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic4_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic4_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic4_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic4_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic4_name field.
	/// </summary>
	public string equipment_inventory_pic4_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic4_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic5_name field.
	/// </summary>
	public string equipment_inventory_pic5_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic5_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic5_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic5_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic5_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic5_name field.
	/// </summary>
	public string equipment_inventory_pic5_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic5_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic6_name field.
	/// </summary>
	public string equipment_inventory_pic6_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic6_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic6_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic6_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic6_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic6_name field.
	/// </summary>
	public string equipment_inventory_pic6_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic6_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic7_name field.
	/// </summary>
	public string equipment_inventory_pic7_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic7_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic7_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic7_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic7_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic7_name field.
	/// </summary>
	public string equipment_inventory_pic7_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic7_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic8_name field.
	/// </summary>
	public string equipment_inventory_pic8_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic8_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic8_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic8_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic8_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic8_name field.
	/// </summary>
	public string equipment_inventory_pic8_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic8_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic9_name field.
	/// </summary>
	public string equipment_inventory_pic9_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic9_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic9_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic9_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic9_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic9_name field.
	/// </summary>
	public string equipment_inventory_pic9_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic9_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_pic10_name field.
	/// </summary>
	public string equipment_inventory_pic10_name
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_pic10_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_pic10_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_pic10_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_pic10_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_pic10_name field.
	/// </summary>
	public string equipment_inventory_pic10_nameDefault
	{
		get
		{
			return TableUtils.equipment_inventory_pic10_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.encoded_inventory_id field.
	/// </summary>
	public string encoded_inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.encoded_inventory_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.encoded_inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool encoded_inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.encoded_inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.encoded_inventory_id field.
	/// </summary>
	public string encoded_inventory_idDefault
	{
		get
		{
			return TableUtils.encoded_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.last_updated_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.last_updated_by field.
	/// </summary>
	public string last_updated_byDefault
	{
		get
		{
			return TableUtils.last_updated_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_dotmed_it field.
	/// </summary>
	public Int32 equipment_dotmed_it
	{
		get
		{
			return this.GetValue(TableUtils.equipment_dotmed_itColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_dotmed_itColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_dotmed_itSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_dotmed_itColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_dotmed_it field.
	/// </summary>
	public string equipment_dotmed_itDefault
	{
		get
		{
			return TableUtils.equipment_dotmed_itColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.equipment_inventory_old field.
	/// </summary>
	public Int32 equipment_inventory_old
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_oldColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_oldColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_oldSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_oldColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.equipment_inventory_old field.
	/// </summary>
	public string equipment_inventory_oldDefault
	{
		get
		{
			return TableUtils.equipment_inventory_oldColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.old_inventory_id field.
	/// </summary>
	public Int32 old_inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.old_inventory_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.old_inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool old_inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.old_inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.old_inventory_id field.
	/// </summary>
	public string old_inventory_idDefault
	{
		get
		{
			return TableUtils.old_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_.dotmed_active field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_.dotmed_active field.
	/// </summary>
	public string dotmed_activeDefault
	{
		get
		{
			return TableUtils.dotmed_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
