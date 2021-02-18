// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_customer_equip_inventoryRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_customer_equip_inventoryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_customer_equip_inventoryView"></see> class.
/// </remarks>
/// <seealso cref="Vw_customer_equip_inventoryView"></seealso>
/// <seealso cref="Vw_customer_equip_inventoryRecord"></seealso>
public class BaseVw_customer_equip_inventoryRecord : PrimaryKeyRecord
{

	public readonly static Vw_customer_equip_inventoryView TableUtils = Vw_customer_equip_inventoryView.Instance;

	// Constructors
 
	protected BaseVw_customer_equip_inventoryRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_customer_equip_inventoryRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Vw_customer_equip_inventoryRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_customer_equip_inventoryRecord_ReadRecord); 
	}

	protected BaseVw_customer_equip_inventoryRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_customer_equip_inventoryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_customer_equip_inventoryRecord Vw_customer_equip_inventoryRec = (Vw_customer_equip_inventoryRecord)sender;
        if(Vw_customer_equip_inventoryRec != null && !Vw_customer_equip_inventoryRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_customer_equip_inventoryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_customer_equip_inventoryRecord Vw_customer_equip_inventoryRec = (Vw_customer_equip_inventoryRecord)sender;
        Validate_Inserting();
        if(Vw_customer_equip_inventoryRec != null && !Vw_customer_equip_inventoryRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Vw_customer_equip_inventoryRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Vw_customer_equip_inventoryRecord Vw_customer_equip_inventoryRec = (Vw_customer_equip_inventoryRecord)sender;
        Validate_Updating();
        if(Vw_customer_equip_inventoryRec != null && !Vw_customer_equip_inventoryRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.inventory_id field.
	/// </summary>
	public ColumnValue Getinventory_idValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.inventory_id field.
	/// </summary>
	public Decimal Getinventory_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.date_received field.
	/// </summary>
	public ColumnValue Getdate_receivedValue()
	{
		return this.GetValue(TableUtils.date_receivedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.date_received field.
	/// </summary>
	public DateTime Getdate_receivedFieldValue()
	{
		return this.GetValue(TableUtils.date_receivedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_received field.
	/// </summary>
	public void Setdate_receivedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_receivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_received field.
	/// </summary>
	public void Setdate_receivedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_receivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_received field.
	/// </summary>
	public void Setdate_receivedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_receivedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.received_from_customer_id field.
	/// </summary>
	public ColumnValue Getreceived_from_customer_idValue()
	{
		return this.GetValue(TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.received_from_customer_id field.
	/// </summary>
	public Int32 Getreceived_from_customer_idFieldValue()
	{
		return this.GetValue(TableUtils.received_from_customer_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_customer_id field.
	/// </summary>
	public void Setreceived_from_customer_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_customer_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.received_from_contact_id field.
	/// </summary>
	public ColumnValue Getreceived_from_contact_idValue()
	{
		return this.GetValue(TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.received_from_contact_id field.
	/// </summary>
	public Int32 Getreceived_from_contact_idFieldValue()
	{
		return this.GetValue(TableUtils.received_from_contact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_contact_id field.
	/// </summary>
	public void Setreceived_from_contact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.received_from_contact_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.make_id field.
	/// </summary>
	public ColumnValue Getmake_idValue()
	{
		return this.GetValue(TableUtils.make_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.make_id field.
	/// </summary>
	public string Getmake_idFieldValue()
	{
		return this.GetValue(TableUtils.make_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.make_id field.
	/// </summary>
	public void Setmake_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.make_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.make_id field.
	/// </summary>
	public void Setmake_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.make_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.model_id field.
	/// </summary>
	public ColumnValue Getmodel_idValue()
	{
		return this.GetValue(TableUtils.model_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.model_id field.
	/// </summary>
	public string Getmodel_idFieldValue()
	{
		return this.GetValue(TableUtils.model_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.model_id field.
	/// </summary>
	public void Setmodel_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.model_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.model_id field.
	/// </summary>
	public void Setmodel_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.model_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.serial_number field.
	/// </summary>
	public ColumnValue Getserial_numberValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.serial_number field.
	/// </summary>
	public string Getserial_numberFieldValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.customer_ein field.
	/// </summary>
	public ColumnValue Getcustomer_einValue()
	{
		return this.GetValue(TableUtils.customer_einColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.customer_ein field.
	/// </summary>
	public string Getcustomer_einFieldValue()
	{
		return this.GetValue(TableUtils.customer_einColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.customer_ein field.
	/// </summary>
	public void Setcustomer_einFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_einColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.customer_ein field.
	/// </summary>
	public void Setcustomer_einFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_einColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.other_id_num field.
	/// </summary>
	public ColumnValue Getother_id_numValue()
	{
		return this.GetValue(TableUtils.other_id_numColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.other_id_num field.
	/// </summary>
	public string Getother_id_numFieldValue()
	{
		return this.GetValue(TableUtils.other_id_numColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.other_id_num field.
	/// </summary>
	public void Setother_id_numFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.other_id_numColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.other_id_num field.
	/// </summary>
	public void Setother_id_numFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.other_id_numColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.description field.
	/// </summary>
	public ColumnValue GetdescriptionValue()
	{
		return this.GetValue(TableUtils.descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.description field.
	/// </summary>
	public string GetdescriptionFieldValue()
	{
		return this.GetValue(TableUtils.descriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.description field.
	/// </summary>
	public void SetdescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.description field.
	/// </summary>
	public void SetdescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.descriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.category_id field.
	/// </summary>
	public string Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.repair_notes field.
	/// </summary>
	public ColumnValue Getrepair_notesValue()
	{
		return this.GetValue(TableUtils.repair_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.repair_notes field.
	/// </summary>
	public string Getrepair_notesFieldValue()
	{
		return this.GetValue(TableUtils.repair_notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.repair_notes field.
	/// </summary>
	public void Setrepair_notesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.repair_notes field.
	/// </summary>
	public void Setrepair_notesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_notesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.condition_id field.
	/// </summary>
	public ColumnValue Getcondition_idValue()
	{
		return this.GetValue(TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.condition_id field.
	/// </summary>
	public string Getcondition_idFieldValue()
	{
		return this.GetValue(TableUtils.condition_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.require_accessories field.
	/// </summary>
	public ColumnValue Getrequire_accessoriesValue()
	{
		return this.GetValue(TableUtils.require_accessoriesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.require_accessories field.
	/// </summary>
	public bool Getrequire_accessoriesFieldValue()
	{
		return this.GetValue(TableUtils.require_accessoriesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.require_accessories field.
	/// </summary>
	public void Setrequire_accessoriesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.require_accessoriesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.require_accessories field.
	/// </summary>
	public void Setrequire_accessoriesFieldValue(string val)
	{
		this.SetString(val, TableUtils.require_accessoriesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.require_accessories field.
	/// </summary>
	public void Setrequire_accessoriesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.require_accessoriesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_phi field.
	/// </summary>
	public ColumnValue Getequipment_phiValue()
	{
		return this.GetValue(TableUtils.equipment_phiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_phi field.
	/// </summary>
	public bool Getequipment_phiFieldValue()
	{
		return this.GetValue(TableUtils.equipment_phiColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_phi field.
	/// </summary>
	public void Setequipment_phiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_phiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_phi field.
	/// </summary>
	public void Setequipment_phiFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_phiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_phi field.
	/// </summary>
	public void Setequipment_phiFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_phiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.purchase_price field.
	/// </summary>
	public ColumnValue Getpurchase_priceValue()
	{
		return this.GetValue(TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.purchase_price field.
	/// </summary>
	public Decimal Getpurchase_priceFieldValue()
	{
		return this.GetValue(TableUtils.purchase_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchase_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.purchase_price field.
	/// </summary>
	public void Setpurchase_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.purchase_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.pd_date field.
	/// </summary>
	public ColumnValue Getpd_dateValue()
	{
		return this.GetValue(TableUtils.pd_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.pd_date field.
	/// </summary>
	public DateTime Getpd_dateFieldValue()
	{
		return this.GetValue(TableUtils.pd_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.pd_date field.
	/// </summary>
	public void Setpd_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pd_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.pd_date field.
	/// </summary>
	public void Setpd_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.pd_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.pd_date field.
	/// </summary>
	public void Setpd_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pd_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.doc_num field.
	/// </summary>
	public ColumnValue Getdoc_numValue()
	{
		return this.GetValue(TableUtils.doc_numColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.doc_num field.
	/// </summary>
	public string Getdoc_numFieldValue()
	{
		return this.GetValue(TableUtils.doc_numColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.doc_num field.
	/// </summary>
	public void Setdoc_numFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.doc_numColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.doc_num field.
	/// </summary>
	public void Setdoc_numFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.doc_numColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.disposition_id field.
	/// </summary>
	public ColumnValue Getdisposition_idValue()
	{
		return this.GetValue(TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.disposition_id field.
	/// </summary>
	public Decimal Getdisposition_idFieldValue()
	{
		return this.GetValue(TableUtils.disposition_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.disposition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.disposition_id field.
	/// </summary>
	public void Setdisposition_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.disposition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.sale_method_id field.
	/// </summary>
	public ColumnValue Getsale_method_idValue()
	{
		return this.GetValue(TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.sale_method_id field.
	/// </summary>
	public Decimal Getsale_method_idFieldValue()
	{
		return this.GetValue(TableUtils.sale_method_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sale_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sale_method_id field.
	/// </summary>
	public void Setsale_method_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sale_method_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.proposed_sale_price field.
	/// </summary>
	public ColumnValue Getproposed_sale_priceValue()
	{
		return this.GetValue(TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.proposed_sale_price field.
	/// </summary>
	public Decimal Getproposed_sale_priceFieldValue()
	{
		return this.GetValue(TableUtils.proposed_sale_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.date_sold field.
	/// </summary>
	public ColumnValue Getdate_soldValue()
	{
		return this.GetValue(TableUtils.date_soldColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.date_sold field.
	/// </summary>
	public DateTime Getdate_soldFieldValue()
	{
		return this.GetValue(TableUtils.date_soldColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_sold field.
	/// </summary>
	public void Setdate_soldFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_soldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_sold field.
	/// </summary>
	public void Setdate_soldFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_soldColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_sold field.
	/// </summary>
	public void Setdate_soldFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_soldColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.date_disposed field.
	/// </summary>
	public ColumnValue Getdate_disposedValue()
	{
		return this.GetValue(TableUtils.date_disposedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.date_disposed field.
	/// </summary>
	public DateTime Getdate_disposedFieldValue()
	{
		return this.GetValue(TableUtils.date_disposedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_disposed field.
	/// </summary>
	public void Setdate_disposedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_disposedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_disposed field.
	/// </summary>
	public void Setdate_disposedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_disposedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_disposed field.
	/// </summary>
	public void Setdate_disposedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_disposedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.sold_from_id field.
	/// </summary>
	public ColumnValue Getsold_from_idValue()
	{
		return this.GetValue(TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.sold_from_id field.
	/// </summary>
	public Decimal Getsold_from_idFieldValue()
	{
		return this.GetValue(TableUtils.sold_from_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sold_from_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sold_from_id field.
	/// </summary>
	public void Setsold_from_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.sold_from_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.final_sale_price field.
	/// </summary>
	public ColumnValue Getfinal_sale_priceValue()
	{
		return this.GetValue(TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.final_sale_price field.
	/// </summary>
	public Decimal Getfinal_sale_priceFieldValue()
	{
		return this.GetValue(TableUtils.final_sale_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.final_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.final_sale_price field.
	/// </summary>
	public void Setfinal_sale_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.final_sale_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.warehouse_id field.
	/// </summary>
	public ColumnValue Getwarehouse_idValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.warehouse_id field.
	/// </summary>
	public Decimal Getwarehouse_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.warehouse_location_id field.
	/// </summary>
	public ColumnValue Getwarehouse_location_idValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.warehouse_location_id field.
	/// </summary>
	public Decimal Getwarehouse_location_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_location_id field.
	/// </summary>
	public void Setwarehouse_location_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.cogs field.
	/// </summary>
	public ColumnValue GetcogsValue()
	{
		return this.GetValue(TableUtils.cogsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.cogs field.
	/// </summary>
	public Decimal GetcogsFieldValue()
	{
		return this.GetValue(TableUtils.cogsColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.cogs field.
	/// </summary>
	public void SetcogsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cogsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.cogs field.
	/// </summary>
	public void SetcogsFieldValue(string val)
	{
		this.SetString(val, TableUtils.cogsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.cogs field.
	/// </summary>
	public void SetcogsFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cogsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.cogs field.
	/// </summary>
	public void SetcogsFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cogsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.cogs field.
	/// </summary>
	public void SetcogsFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cogsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.inventory_status_id field.
	/// </summary>
	public ColumnValue Getinventory_status_idValue()
	{
		return this.GetValue(TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.inventory_status_id field.
	/// </summary>
	public Decimal Getinventory_status_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_status_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_status_id field.
	/// </summary>
	public void Setinventory_status_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_status_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic1Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic1FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic1Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public void Setequipment_inventory_pic1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public void Setequipment_inventory_pic1FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public void Setequipment_inventory_pic1FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic2Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic2FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic2Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public void Setequipment_inventory_pic2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public void Setequipment_inventory_pic2FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public void Setequipment_inventory_pic2FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public ColumnValue Getequipment_inventory_pic3Value()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public byte[] Getequipment_inventory_pic3FieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_pic3Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public void Setequipment_inventory_pic3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_pic3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public void Setequipment_inventory_pic3FieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_pic3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public void Setequipment_inventory_pic3FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_pic3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.datetime_added field.
	/// </summary>
	public ColumnValue Getdatetime_addedValue()
	{
		return this.GetValue(TableUtils.datetime_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.datetime_added field.
	/// </summary>
	public DateTime Getdatetime_addedFieldValue()
	{
		return this.GetValue(TableUtils.datetime_addedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.datetime_added field.
	/// </summary>
	public void Setdatetime_addedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.datetime_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.datetime_added field.
	/// </summary>
	public void Setdatetime_addedFieldValue(string val)
	{
		this.SetString(val, TableUtils.datetime_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.datetime_added field.
	/// </summary>
	public void Setdatetime_addedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.datetime_addedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.CustNo field.
	/// </summary>
	public ColumnValue GetCustNoValue()
	{
		return this.GetValue(TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.CustNo field.
	/// </summary>
	public Int32 GetCustNoFieldValue()
	{
		return this.GetValue(TableUtils.CustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.corporate_id field.
	/// </summary>
	public ColumnValue Getcorporate_idValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.corporate_id field.
	/// </summary>
	public Int32 Getcorporate_idFieldValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.corporate_name field.
	/// </summary>
	public ColumnValue Getcorporate_nameValue()
	{
		return this.GetValue(TableUtils.corporate_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.corporate_name field.
	/// </summary>
	public string Getcorporate_nameFieldValue()
	{
		return this.GetValue(TableUtils.corporate_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.corporate_name field.
	/// </summary>
	public void Setcorporate_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.corporate_name field.
	/// </summary>
	public void Setcorporate_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.CustName field.
	/// </summary>
	public ColumnValue GetCustNameValue()
	{
		return this.GetValue(TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.CustName field.
	/// </summary>
	public string GetCustNameFieldValue()
	{
		return this.GetValue(TableUtils.CustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.CustContactName field.
	/// </summary>
	public ColumnValue GetCustContactNameValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.CustContactName field.
	/// </summary>
	public string GetCustContactNameFieldValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.new_category_id field.
	/// </summary>
	public ColumnValue Getnew_category_idValue()
	{
		return this.GetValue(TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_customer_equip_inventory_.new_category_id field.
	/// </summary>
	public Decimal Getnew_category_idFieldValue()
	{
		return this.GetValue(TableUtils.new_category_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_category_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.inventory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_id field.
	/// </summary>
	public string inventory_idDefault
	{
		get
		{
			return TableUtils.inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.date_received field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_received field.
	/// </summary>
	public string date_receivedDefault
	{
		get
		{
			return TableUtils.date_receivedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.received_from_customer_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_customer_id field.
	/// </summary>
	public string received_from_customer_idDefault
	{
		get
		{
			return TableUtils.received_from_customer_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.received_from_contact_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.received_from_contact_id field.
	/// </summary>
	public string received_from_contact_idDefault
	{
		get
		{
			return TableUtils.received_from_contact_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.make_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.make_id field.
	/// </summary>
	public string make_idDefault
	{
		get
		{
			return TableUtils.make_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.model_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.model_id field.
	/// </summary>
	public string model_idDefault
	{
		get
		{
			return TableUtils.model_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.serial_number field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.serial_number field.
	/// </summary>
	public string serial_numberDefault
	{
		get
		{
			return TableUtils.serial_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.customer_ein field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.customer_ein field.
	/// </summary>
	public string customer_einDefault
	{
		get
		{
			return TableUtils.customer_einColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.other_id_num field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.other_id_num field.
	/// </summary>
	public string other_id_numDefault
	{
		get
		{
			return TableUtils.other_id_numColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.description field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.description field.
	/// </summary>
	public string descriptionDefault
	{
		get
		{
			return TableUtils.descriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.category_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.category_id field.
	/// </summary>
	public string category_idDefault
	{
		get
		{
			return TableUtils.category_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.repair_notes field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.repair_notes field.
	/// </summary>
	public string repair_notesDefault
	{
		get
		{
			return TableUtils.repair_notesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.condition_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.condition_id field.
	/// </summary>
	public string condition_idDefault
	{
		get
		{
			return TableUtils.condition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.require_accessories field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.require_accessories field.
	/// </summary>
	public string require_accessoriesDefault
	{
		get
		{
			return TableUtils.require_accessoriesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_phi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_phi field.
	/// </summary>
	public string equipment_phiDefault
	{
		get
		{
			return TableUtils.equipment_phiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.purchase_price field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.purchase_price field.
	/// </summary>
	public string purchase_priceDefault
	{
		get
		{
			return TableUtils.purchase_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.pd_date field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.pd_date field.
	/// </summary>
	public string pd_dateDefault
	{
		get
		{
			return TableUtils.pd_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.doc_num field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.doc_num field.
	/// </summary>
	public string doc_numDefault
	{
		get
		{
			return TableUtils.doc_numColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.disposition_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.disposition_id field.
	/// </summary>
	public string disposition_idDefault
	{
		get
		{
			return TableUtils.disposition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.sale_method_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sale_method_id field.
	/// </summary>
	public string sale_method_idDefault
	{
		get
		{
			return TableUtils.sale_method_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.proposed_sale_price field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.proposed_sale_price field.
	/// </summary>
	public string proposed_sale_priceDefault
	{
		get
		{
			return TableUtils.proposed_sale_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.date_sold field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_sold field.
	/// </summary>
	public string date_soldDefault
	{
		get
		{
			return TableUtils.date_soldColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.date_disposed field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.date_disposed field.
	/// </summary>
	public string date_disposedDefault
	{
		get
		{
			return TableUtils.date_disposedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.sold_from_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.sold_from_id field.
	/// </summary>
	public string sold_from_idDefault
	{
		get
		{
			return TableUtils.sold_from_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.final_sale_price field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.final_sale_price field.
	/// </summary>
	public string final_sale_priceDefault
	{
		get
		{
			return TableUtils.final_sale_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.warehouse_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_id field.
	/// </summary>
	public string warehouse_idDefault
	{
		get
		{
			return TableUtils.warehouse_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.warehouse_location_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.warehouse_location_id field.
	/// </summary>
	public string warehouse_location_idDefault
	{
		get
		{
			return TableUtils.warehouse_location_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.cogs field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.cogs field.
	/// </summary>
	public string cogsDefault
	{
		get
		{
			return TableUtils.cogsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.inventory_status_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.inventory_status_id field.
	/// </summary>
	public string inventory_status_idDefault
	{
		get
		{
			return TableUtils.inventory_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic1 field.
	/// </summary>
	public string equipment_inventory_pic1Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic2 field.
	/// </summary>
	public string equipment_inventory_pic2Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.equipment_inventory_pic3 field.
	/// </summary>
	public string equipment_inventory_pic3Default
	{
		get
		{
			return TableUtils.equipment_inventory_pic3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.technician_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.datetime_added field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.datetime_added field.
	/// </summary>
	public string datetime_addedDefault
	{
		get
		{
			return TableUtils.datetime_addedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.CustNo field.
	/// </summary>
	public Int32 CustNo
	{
		get
		{
			return this.GetValue(TableUtils.CustNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustNo field.
	/// </summary>
	public string CustNoDefault
	{
		get
		{
			return TableUtils.CustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.corporate_id field.
	/// </summary>
	public Int32 corporate_id
	{
		get
		{
			return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.corporate_id field.
	/// </summary>
	public string corporate_idDefault
	{
		get
		{
			return TableUtils.corporate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.corporate_name field.
	/// </summary>
	public string corporate_name
	{
		get
		{
			return this.GetValue(TableUtils.corporate_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.corporate_name field.
	/// </summary>
	public string corporate_nameDefault
	{
		get
		{
			return TableUtils.corporate_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.CustName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustName field.
	/// </summary>
	public string CustNameDefault
	{
		get
		{
			return TableUtils.CustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.CustContactName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.CustContactName field.
	/// </summary>
	public string CustContactNameDefault
	{
		get
		{
			return TableUtils.CustContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_customer_equip_inventory_.new_category_id field.
	/// </summary>
	public Decimal new_category_id
	{
		get
		{
			return this.GetValue(TableUtils.new_category_idColumn).ToDecimal();
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_customer_equip_inventory_.new_category_id field.
	/// </summary>
	public string new_category_idDefault
	{
		get
		{
			return TableUtils.new_category_idColumn.DefaultValue;
		}
	}


#endregion
}

}
