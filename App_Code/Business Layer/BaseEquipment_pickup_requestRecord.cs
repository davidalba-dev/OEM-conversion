// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_pickup_requestRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_pickup_requestRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_pickup_requestTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_pickup_requestTable"></seealso>
/// <seealso cref="Equipment_pickup_requestRecord"></seealso>
public class BaseEquipment_pickup_requestRecord : PrimaryKeyRecord
{

	public readonly static Equipment_pickup_requestTable TableUtils = Equipment_pickup_requestTable.Instance;

	// Constructors
 
	protected BaseEquipment_pickup_requestRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_pickup_requestRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_pickup_requestRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_pickup_requestRecord_ReadRecord); 
	}

	protected BaseEquipment_pickup_requestRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_pickup_requestRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_pickup_requestRecord Equipment_pickup_requestRec = (Equipment_pickup_requestRecord)sender;
        if(Equipment_pickup_requestRec != null && !Equipment_pickup_requestRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_pickup_requestRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_pickup_requestRecord Equipment_pickup_requestRec = (Equipment_pickup_requestRecord)sender;
        Validate_Inserting();
        if(Equipment_pickup_requestRec != null && !Equipment_pickup_requestRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_pickup_requestRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_pickup_requestRecord Equipment_pickup_requestRec = (Equipment_pickup_requestRecord)sender;
        Validate_Updating();
        if(Equipment_pickup_requestRec != null && !Equipment_pickup_requestRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.equipment_pickup_request_id field.
	/// </summary>
	public ColumnValue Getequipment_pickup_request_idValue()
	{
		return this.GetValue(TableUtils.equipment_pickup_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.equipment_pickup_request_id field.
	/// </summary>
	public Decimal Getequipment_pickup_request_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_pickup_request_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.custcontactkey field.
	/// </summary>
	public ColumnValue GetcustcontactkeyValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.custcontactkey field.
	/// </summary>
	public Int32 GetcustcontactkeyFieldValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_address1 field.
	/// </summary>
	public ColumnValue Getpickup_address1Value()
	{
		return this.GetValue(TableUtils.pickup_address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_address1 field.
	/// </summary>
	public string Getpickup_address1FieldValue()
	{
		return this.GetValue(TableUtils.pickup_address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_address1 field.
	/// </summary>
	public void Setpickup_address1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_address1 field.
	/// </summary>
	public void Setpickup_address1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_address2 field.
	/// </summary>
	public ColumnValue Getpickup_address2Value()
	{
		return this.GetValue(TableUtils.pickup_address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_address2 field.
	/// </summary>
	public string Getpickup_address2FieldValue()
	{
		return this.GetValue(TableUtils.pickup_address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_address2 field.
	/// </summary>
	public void Setpickup_address2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_address2 field.
	/// </summary>
	public void Setpickup_address2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_city field.
	/// </summary>
	public ColumnValue Getpickup_cityValue()
	{
		return this.GetValue(TableUtils.pickup_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_city field.
	/// </summary>
	public string Getpickup_cityFieldValue()
	{
		return this.GetValue(TableUtils.pickup_cityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_city field.
	/// </summary>
	public void Setpickup_cityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_city field.
	/// </summary>
	public void Setpickup_cityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_cityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_state field.
	/// </summary>
	public ColumnValue Getpickup_stateValue()
	{
		return this.GetValue(TableUtils.pickup_stateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_state field.
	/// </summary>
	public string Getpickup_stateFieldValue()
	{
		return this.GetValue(TableUtils.pickup_stateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_state field.
	/// </summary>
	public void Setpickup_stateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_stateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_state field.
	/// </summary>
	public void Setpickup_stateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_stateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_zip field.
	/// </summary>
	public ColumnValue Getpickup_zipValue()
	{
		return this.GetValue(TableUtils.pickup_zipColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_zip field.
	/// </summary>
	public string Getpickup_zipFieldValue()
	{
		return this.GetValue(TableUtils.pickup_zipColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_zip field.
	/// </summary>
	public void Setpickup_zipFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_zipColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_zip field.
	/// </summary>
	public void Setpickup_zipFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_zipColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_instructions field.
	/// </summary>
	public ColumnValue Getpickup_instructionsValue()
	{
		return this.GetValue(TableUtils.pickup_instructionsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_instructions field.
	/// </summary>
	public string Getpickup_instructionsFieldValue()
	{
		return this.GetValue(TableUtils.pickup_instructionsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_instructions field.
	/// </summary>
	public void Setpickup_instructionsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_instructionsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_instructions field.
	/// </summary>
	public void Setpickup_instructionsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_instructionsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickkup_date field.
	/// </summary>
	public ColumnValue Getpickkup_dateValue()
	{
		return this.GetValue(TableUtils.pickkup_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickkup_date field.
	/// </summary>
	public DateTime Getpickkup_dateFieldValue()
	{
		return this.GetValue(TableUtils.pickkup_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickkup_date field.
	/// </summary>
	public void Setpickkup_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickkup_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickkup_date field.
	/// </summary>
	public void Setpickkup_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickkup_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickkup_date field.
	/// </summary>
	public void Setpickkup_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickkup_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_time field.
	/// </summary>
	public ColumnValue Getpickup_timeValue()
	{
		return this.GetValue(TableUtils.pickup_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.pickup_time field.
	/// </summary>
	public DateTime Getpickup_timeFieldValue()
	{
		return this.GetValue(TableUtils.pickup_timeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_time field.
	/// </summary>
	public void Setpickup_timeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_time field.
	/// </summary>
	public void Setpickup_timeFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_time field.
	/// </summary>
	public void Setpickup_timeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_timeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.poc_phone field.
	/// </summary>
	public ColumnValue Getpoc_phoneValue()
	{
		return this.GetValue(TableUtils.poc_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.poc_phone field.
	/// </summary>
	public string Getpoc_phoneFieldValue()
	{
		return this.GetValue(TableUtils.poc_phoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.poc_phone field.
	/// </summary>
	public void Setpoc_phoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.poc_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.poc_phone field.
	/// </summary>
	public void Setpoc_phoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.poc_phoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.poc_phone_ext field.
	/// </summary>
	public ColumnValue Getpoc_phone_extValue()
	{
		return this.GetValue(TableUtils.poc_phone_extColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.poc_phone_ext field.
	/// </summary>
	public string Getpoc_phone_extFieldValue()
	{
		return this.GetValue(TableUtils.poc_phone_extColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.poc_phone_ext field.
	/// </summary>
	public void Setpoc_phone_extFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.poc_phone_extColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.poc_phone_ext field.
	/// </summary>
	public void Setpoc_phone_extFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.poc_phone_extColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.processed field.
	/// </summary>
	public ColumnValue GetprocessedValue()
	{
		return this.GetValue(TableUtils.processedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.processed field.
	/// </summary>
	public bool GetprocessedFieldValue()
	{
		return this.GetValue(TableUtils.processedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.processed field.
	/// </summary>
	public void SetprocessedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.processedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.processed field.
	/// </summary>
	public void SetprocessedFieldValue(string val)
	{
		this.SetString(val, TableUtils.processedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.processed field.
	/// </summary>
	public void SetprocessedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.processedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.inventory_id field.
	/// </summary>
	public ColumnValue Getinventory_idValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.inventory_id field.
	/// </summary>
	public Decimal Getinventory_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.picked_up_by field.
	/// </summary>
	public ColumnValue Getpicked_up_byValue()
	{
		return this.GetValue(TableUtils.picked_up_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.picked_up_by field.
	/// </summary>
	public Int32 Getpicked_up_byFieldValue()
	{
		return this.GetValue(TableUtils.picked_up_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_by field.
	/// </summary>
	public void Setpicked_up_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.picked_up_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_by field.
	/// </summary>
	public void Setpicked_up_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.picked_up_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_by field.
	/// </summary>
	public void Setpicked_up_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.picked_up_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_by field.
	/// </summary>
	public void Setpicked_up_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.picked_up_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_by field.
	/// </summary>
	public void Setpicked_up_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.picked_up_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.picked_up_datetime field.
	/// </summary>
	public ColumnValue Getpicked_up_datetimeValue()
	{
		return this.GetValue(TableUtils.picked_up_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.picked_up_datetime field.
	/// </summary>
	public DateTime Getpicked_up_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.picked_up_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_datetime field.
	/// </summary>
	public void Setpicked_up_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.picked_up_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_datetime field.
	/// </summary>
	public void Setpicked_up_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.picked_up_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_datetime field.
	/// </summary>
	public void Setpicked_up_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.picked_up_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.picked_up_from field.
	/// </summary>
	public ColumnValue Getpicked_up_fromValue()
	{
		return this.GetValue(TableUtils.picked_up_fromColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_pickup_request_.picked_up_from field.
	/// </summary>
	public string Getpicked_up_fromFieldValue()
	{
		return this.GetValue(TableUtils.picked_up_fromColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_from field.
	/// </summary>
	public void Setpicked_up_fromFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.picked_up_fromColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_from field.
	/// </summary>
	public void Setpicked_up_fromFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.picked_up_fromColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.equipment_pickup_request_id field.
	/// </summary>
	public Decimal equipment_pickup_request_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_pickup_request_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_pickup_request_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_pickup_request_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_pickup_request_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.equipment_pickup_request_id field.
	/// </summary>
	public string equipment_pickup_request_idDefault
	{
		get
		{
			return TableUtils.equipment_pickup_request_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.custcontactkey field.
	/// </summary>
	public Int32 custcontactkey
	{
		get
		{
			return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custcontactkeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custcontactkeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custcontactkeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.custcontactkey field.
	/// </summary>
	public string custcontactkeyDefault
	{
		get
		{
			return TableUtils.custcontactkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.pickup_address1 field.
	/// </summary>
	public string pickup_address1
	{
		get
		{
			return this.GetValue(TableUtils.pickup_address1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_address1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_address1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_address1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_address1 field.
	/// </summary>
	public string pickup_address1Default
	{
		get
		{
			return TableUtils.pickup_address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.pickup_address2 field.
	/// </summary>
	public string pickup_address2
	{
		get
		{
			return this.GetValue(TableUtils.pickup_address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_address2 field.
	/// </summary>
	public string pickup_address2Default
	{
		get
		{
			return TableUtils.pickup_address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.pickup_city field.
	/// </summary>
	public string pickup_city
	{
		get
		{
			return this.GetValue(TableUtils.pickup_cityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_cityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_citySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_cityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_city field.
	/// </summary>
	public string pickup_cityDefault
	{
		get
		{
			return TableUtils.pickup_cityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.pickup_state field.
	/// </summary>
	public string pickup_state
	{
		get
		{
			return this.GetValue(TableUtils.pickup_stateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_stateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_stateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_stateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_state field.
	/// </summary>
	public string pickup_stateDefault
	{
		get
		{
			return TableUtils.pickup_stateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.pickup_zip field.
	/// </summary>
	public string pickup_zip
	{
		get
		{
			return this.GetValue(TableUtils.pickup_zipColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_zipColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_zipSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_zipColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_zip field.
	/// </summary>
	public string pickup_zipDefault
	{
		get
		{
			return TableUtils.pickup_zipColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.pickup_instructions field.
	/// </summary>
	public string pickup_instructions
	{
		get
		{
			return this.GetValue(TableUtils.pickup_instructionsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_instructionsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_instructionsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_instructionsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_instructions field.
	/// </summary>
	public string pickup_instructionsDefault
	{
		get
		{
			return TableUtils.pickup_instructionsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.pickkup_date field.
	/// </summary>
	public DateTime pickkup_date
	{
		get
		{
			return this.GetValue(TableUtils.pickkup_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickkup_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickkup_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickkup_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickkup_date field.
	/// </summary>
	public string pickkup_dateDefault
	{
		get
		{
			return TableUtils.pickkup_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.pickup_time field.
	/// </summary>
	public DateTime pickup_time
	{
		get
		{
			return this.GetValue(TableUtils.pickup_timeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_timeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_timeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_timeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.pickup_time field.
	/// </summary>
	public string pickup_timeDefault
	{
		get
		{
			return TableUtils.pickup_timeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.poc_phone field.
	/// </summary>
	public string poc_phone
	{
		get
		{
			return this.GetValue(TableUtils.poc_phoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.poc_phoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool poc_phoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.poc_phoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.poc_phone field.
	/// </summary>
	public string poc_phoneDefault
	{
		get
		{
			return TableUtils.poc_phoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.poc_phone_ext field.
	/// </summary>
	public string poc_phone_ext
	{
		get
		{
			return this.GetValue(TableUtils.poc_phone_extColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.poc_phone_extColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool poc_phone_extSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.poc_phone_extColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.poc_phone_ext field.
	/// </summary>
	public string poc_phone_extDefault
	{
		get
		{
			return TableUtils.poc_phone_extColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.processed field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.processed field.
	/// </summary>
	public string processedDefault
	{
		get
		{
			return TableUtils.processedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.technician_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.inventory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.inventory_id field.
	/// </summary>
	public string inventory_idDefault
	{
		get
		{
			return TableUtils.inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.picked_up_by field.
	/// </summary>
	public Int32 picked_up_by
	{
		get
		{
			return this.GetValue(TableUtils.picked_up_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.picked_up_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool picked_up_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.picked_up_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_by field.
	/// </summary>
	public string picked_up_byDefault
	{
		get
		{
			return TableUtils.picked_up_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.picked_up_datetime field.
	/// </summary>
	public DateTime picked_up_datetime
	{
		get
		{
			return this.GetValue(TableUtils.picked_up_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.picked_up_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool picked_up_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.picked_up_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_datetime field.
	/// </summary>
	public string picked_up_datetimeDefault
	{
		get
		{
			return TableUtils.picked_up_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_pickup_request_.picked_up_from field.
	/// </summary>
	public string picked_up_from
	{
		get
		{
			return this.GetValue(TableUtils.picked_up_fromColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.picked_up_fromColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool picked_up_fromSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.picked_up_fromColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_pickup_request_.picked_up_from field.
	/// </summary>
	public string picked_up_fromDefault
	{
		get
		{
			return TableUtils.picked_up_fromColumn.DefaultValue;
		}
	}


#endregion
}

}
