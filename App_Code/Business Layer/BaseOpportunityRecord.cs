// This class is "generated" and will be overwritten.
// Your customizations should be made in OpportunityRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="OpportunityRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="OpportunityTable"></see> class.
/// </remarks>
/// <seealso cref="OpportunityTable"></seealso>
/// <seealso cref="OpportunityRecord"></seealso>
public class BaseOpportunityRecord : PrimaryKeyRecord
{

	public readonly static OpportunityTable TableUtils = OpportunityTable.Instance;

	// Constructors
 
	protected BaseOpportunityRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.OpportunityRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.OpportunityRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.OpportunityRecord_ReadRecord); 
	}

	protected BaseOpportunityRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void OpportunityRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                OpportunityRecord OpportunityRec = (OpportunityRecord)sender;
        if(OpportunityRec != null && !OpportunityRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void OpportunityRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                OpportunityRecord OpportunityRec = (OpportunityRecord)sender;
        Validate_Inserting();
        if(OpportunityRec != null && !OpportunityRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void OpportunityRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                OpportunityRecord OpportunityRec = (OpportunityRecord)sender;
        Validate_Updating();
        if(OpportunityRec != null && !OpportunityRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_id field.
	/// </summary>
	public ColumnValue Getopportunity_idValue()
	{
		return this.GetValue(TableUtils.opportunity_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_id field.
	/// </summary>
	public Int32 Getopportunity_idFieldValue()
	{
		return this.GetValue(TableUtils.opportunity_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_name field.
	/// </summary>
	public ColumnValue Getopportunity_nameValue()
	{
		return this.GetValue(TableUtils.opportunity_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_name field.
	/// </summary>
	public string Getopportunity_nameFieldValue()
	{
		return this.GetValue(TableUtils.opportunity_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_name field.
	/// </summary>
	public void Setopportunity_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.opportunity_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_name field.
	/// </summary>
	public void Setopportunity_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.opportunity_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.custcontactkey field.
	/// </summary>
	public ColumnValue GetcustcontactkeyValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.custcontactkey field.
	/// </summary>
	public Int32 GetcustcontactkeyFieldValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_owner field.
	/// </summary>
	public ColumnValue Getopportunity_ownerValue()
	{
		return this.GetValue(TableUtils.opportunity_ownerColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_owner field.
	/// </summary>
	public Int32 Getopportunity_ownerFieldValue()
	{
		return this.GetValue(TableUtils.opportunity_ownerColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_owner field.
	/// </summary>
	public void Setopportunity_ownerFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.opportunity_ownerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_owner field.
	/// </summary>
	public void Setopportunity_ownerFieldValue(string val)
	{
		this.SetString(val, TableUtils.opportunity_ownerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_owner field.
	/// </summary>
	public void Setopportunity_ownerFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.opportunity_ownerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_owner field.
	/// </summary>
	public void Setopportunity_ownerFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.opportunity_ownerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_owner field.
	/// </summary>
	public void Setopportunity_ownerFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.opportunity_ownerColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.stage_id field.
	/// </summary>
	public ColumnValue Getstage_idValue()
	{
		return this.GetValue(TableUtils.stage_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.stage_id field.
	/// </summary>
	public Int32 Getstage_idFieldValue()
	{
		return this.GetValue(TableUtils.stage_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.stage_id field.
	/// </summary>
	public void Setstage_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.stage_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.stage_id field.
	/// </summary>
	public void Setstage_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.stage_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.stage_id field.
	/// </summary>
	public void Setstage_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.stage_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.stage_id field.
	/// </summary>
	public void Setstage_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.stage_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.stage_id field.
	/// </summary>
	public void Setstage_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.stage_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.lead_source_id field.
	/// </summary>
	public ColumnValue Getlead_source_idValue()
	{
		return this.GetValue(TableUtils.lead_source_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.lead_source_id field.
	/// </summary>
	public Int32 Getlead_source_idFieldValue()
	{
		return this.GetValue(TableUtils.lead_source_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.lead_source_id field.
	/// </summary>
	public void Setlead_source_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.lead_source_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.lead_source_id field.
	/// </summary>
	public void Setlead_source_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.lead_source_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.lead_source_id field.
	/// </summary>
	public void Setlead_source_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.lead_source_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.lead_source_id field.
	/// </summary>
	public void Setlead_source_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.lead_source_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.lead_source_id field.
	/// </summary>
	public void Setlead_source_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.lead_source_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_notes field.
	/// </summary>
	public ColumnValue Getopportunity_notesValue()
	{
		return this.GetValue(TableUtils.opportunity_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_notes field.
	/// </summary>
	public string Getopportunity_notesFieldValue()
	{
		return this.GetValue(TableUtils.opportunity_notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_notes field.
	/// </summary>
	public void Setopportunity_notesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.opportunity_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_notes field.
	/// </summary>
	public void Setopportunity_notesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.opportunity_notesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_date field.
	/// </summary>
	public ColumnValue Getopportunity_dateValue()
	{
		return this.GetValue(TableUtils.opportunity_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_date field.
	/// </summary>
	public DateTime Getopportunity_dateFieldValue()
	{
		return this.GetValue(TableUtils.opportunity_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_date field.
	/// </summary>
	public void Setopportunity_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.opportunity_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_date field.
	/// </summary>
	public void Setopportunity_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.opportunity_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_date field.
	/// </summary>
	public void Setopportunity_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.opportunity_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_amount field.
	/// </summary>
	public ColumnValue Getopportunity_amountValue()
	{
		return this.GetValue(TableUtils.opportunity_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.opportunity_amount field.
	/// </summary>
	public Decimal Getopportunity_amountFieldValue()
	{
		return this.GetValue(TableUtils.opportunity_amountColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_amount field.
	/// </summary>
	public void Setopportunity_amountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.opportunity_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_amount field.
	/// </summary>
	public void Setopportunity_amountFieldValue(string val)
	{
		this.SetString(val, TableUtils.opportunity_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_amount field.
	/// </summary>
	public void Setopportunity_amountFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.opportunity_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_amount field.
	/// </summary>
	public void Setopportunity_amountFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.opportunity_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_amount field.
	/// </summary>
	public void Setopportunity_amountFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.opportunity_amountColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.dept_id field.
	/// </summary>
	public ColumnValue Getdept_idValue()
	{
		return this.GetValue(TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.dept_id field.
	/// </summary>
	public Int32 Getdept_idFieldValue()
	{
		return this.GetValue(TableUtils.dept_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.dept_id field.
	/// </summary>
	public void Setdept_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dept_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_1 field.
	/// </summary>
	public ColumnValue Getattachment_1Value()
	{
		return this.GetValue(TableUtils.attachment_1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_1 field.
	/// </summary>
	public byte[] Getattachment_1FieldValue()
	{
		return this.GetValue(TableUtils.attachment_1Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_1 field.
	/// </summary>
	public void Setattachment_1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachment_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_1 field.
	/// </summary>
	public void Setattachment_1FieldValue(string val)
	{
		this.SetString(val, TableUtils.attachment_1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_1 field.
	/// </summary>
	public void Setattachment_1FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachment_1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_2 field.
	/// </summary>
	public ColumnValue Getattachment_2Value()
	{
		return this.GetValue(TableUtils.attachment_2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_2 field.
	/// </summary>
	public byte[] Getattachment_2FieldValue()
	{
		return this.GetValue(TableUtils.attachment_2Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_2 field.
	/// </summary>
	public void Setattachment_2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachment_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_2 field.
	/// </summary>
	public void Setattachment_2FieldValue(string val)
	{
		this.SetString(val, TableUtils.attachment_2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_2 field.
	/// </summary>
	public void Setattachment_2FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachment_2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_3 field.
	/// </summary>
	public ColumnValue Getattachment_3Value()
	{
		return this.GetValue(TableUtils.attachment_3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_3 field.
	/// </summary>
	public byte[] Getattachment_3FieldValue()
	{
		return this.GetValue(TableUtils.attachment_3Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_3 field.
	/// </summary>
	public void Setattachment_3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachment_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_3 field.
	/// </summary>
	public void Setattachment_3FieldValue(string val)
	{
		this.SetString(val, TableUtils.attachment_3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_3 field.
	/// </summary>
	public void Setattachment_3FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachment_3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_4 field.
	/// </summary>
	public ColumnValue Getattachment_4Value()
	{
		return this.GetValue(TableUtils.attachment_4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_4 field.
	/// </summary>
	public byte[] Getattachment_4FieldValue()
	{
		return this.GetValue(TableUtils.attachment_4Column).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_4 field.
	/// </summary>
	public void Setattachment_4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachment_4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_4 field.
	/// </summary>
	public void Setattachment_4FieldValue(string val)
	{
		this.SetString(val, TableUtils.attachment_4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_4 field.
	/// </summary>
	public void Setattachment_4FieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachment_4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_1_filename field.
	/// </summary>
	public ColumnValue Getattachment_1_filenameValue()
	{
		return this.GetValue(TableUtils.attachment_1_filenameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_1_filename field.
	/// </summary>
	public string Getattachment_1_filenameFieldValue()
	{
		return this.GetValue(TableUtils.attachment_1_filenameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_1_filename field.
	/// </summary>
	public void Setattachment_1_filenameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachment_1_filenameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_1_filename field.
	/// </summary>
	public void Setattachment_1_filenameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachment_1_filenameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_2_filename field.
	/// </summary>
	public ColumnValue Getattachment_2_filenameValue()
	{
		return this.GetValue(TableUtils.attachment_2_filenameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_2_filename field.
	/// </summary>
	public string Getattachment_2_filenameFieldValue()
	{
		return this.GetValue(TableUtils.attachment_2_filenameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_2_filename field.
	/// </summary>
	public void Setattachment_2_filenameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachment_2_filenameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_2_filename field.
	/// </summary>
	public void Setattachment_2_filenameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachment_2_filenameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_3_filename field.
	/// </summary>
	public ColumnValue Getattachment_3_filenameValue()
	{
		return this.GetValue(TableUtils.attachment_3_filenameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_3_filename field.
	/// </summary>
	public string Getattachment_3_filenameFieldValue()
	{
		return this.GetValue(TableUtils.attachment_3_filenameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_3_filename field.
	/// </summary>
	public void Setattachment_3_filenameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachment_3_filenameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_3_filename field.
	/// </summary>
	public void Setattachment_3_filenameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachment_3_filenameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_4_filename field.
	/// </summary>
	public ColumnValue Getattachment_4_filenameValue()
	{
		return this.GetValue(TableUtils.attachment_4_filenameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's opportunity_.attachment_4_filename field.
	/// </summary>
	public string Getattachment_4_filenameFieldValue()
	{
		return this.GetValue(TableUtils.attachment_4_filenameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_4_filename field.
	/// </summary>
	public void Setattachment_4_filenameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachment_4_filenameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_4_filename field.
	/// </summary>
	public void Setattachment_4_filenameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachment_4_filenameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.opportunity_id field.
	/// </summary>
	public Int32 opportunity_id
	{
		get
		{
			return this.GetValue(TableUtils.opportunity_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.opportunity_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool opportunity_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.opportunity_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_id field.
	/// </summary>
	public string opportunity_idDefault
	{
		get
		{
			return TableUtils.opportunity_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.opportunity_name field.
	/// </summary>
	public string opportunity_name
	{
		get
		{
			return this.GetValue(TableUtils.opportunity_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.opportunity_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool opportunity_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.opportunity_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_name field.
	/// </summary>
	public string opportunity_nameDefault
	{
		get
		{
			return TableUtils.opportunity_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.custcontactkey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.custcontactkey field.
	/// </summary>
	public string custcontactkeyDefault
	{
		get
		{
			return TableUtils.custcontactkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.opportunity_owner field.
	/// </summary>
	public Int32 opportunity_owner
	{
		get
		{
			return this.GetValue(TableUtils.opportunity_ownerColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.opportunity_ownerColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool opportunity_ownerSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.opportunity_ownerColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_owner field.
	/// </summary>
	public string opportunity_ownerDefault
	{
		get
		{
			return TableUtils.opportunity_ownerColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.stage_id field.
	/// </summary>
	public Int32 stage_id
	{
		get
		{
			return this.GetValue(TableUtils.stage_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.stage_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool stage_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.stage_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.stage_id field.
	/// </summary>
	public string stage_idDefault
	{
		get
		{
			return TableUtils.stage_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.lead_source_id field.
	/// </summary>
	public Int32 lead_source_id
	{
		get
		{
			return this.GetValue(TableUtils.lead_source_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.lead_source_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool lead_source_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.lead_source_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.lead_source_id field.
	/// </summary>
	public string lead_source_idDefault
	{
		get
		{
			return TableUtils.lead_source_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.opportunity_notes field.
	/// </summary>
	public string opportunity_notes
	{
		get
		{
			return this.GetValue(TableUtils.opportunity_notesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.opportunity_notesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool opportunity_notesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.opportunity_notesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_notes field.
	/// </summary>
	public string opportunity_notesDefault
	{
		get
		{
			return TableUtils.opportunity_notesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.opportunity_date field.
	/// </summary>
	public DateTime opportunity_date
	{
		get
		{
			return this.GetValue(TableUtils.opportunity_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.opportunity_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool opportunity_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.opportunity_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_date field.
	/// </summary>
	public string opportunity_dateDefault
	{
		get
		{
			return TableUtils.opportunity_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.opportunity_amount field.
	/// </summary>
	public Decimal opportunity_amount
	{
		get
		{
			return this.GetValue(TableUtils.opportunity_amountColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.opportunity_amountColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool opportunity_amountSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.opportunity_amountColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.opportunity_amount field.
	/// </summary>
	public string opportunity_amountDefault
	{
		get
		{
			return TableUtils.opportunity_amountColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.dept_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.dept_id field.
	/// </summary>
	public string dept_idDefault
	{
		get
		{
			return TableUtils.dept_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.attachment_1 field.
	/// </summary>
	public byte[] attachment_1
	{
		get
		{
			return this.GetValue(TableUtils.attachment_1Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachment_1Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachment_1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachment_1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_1 field.
	/// </summary>
	public string attachment_1Default
	{
		get
		{
			return TableUtils.attachment_1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.attachment_2 field.
	/// </summary>
	public byte[] attachment_2
	{
		get
		{
			return this.GetValue(TableUtils.attachment_2Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachment_2Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachment_2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachment_2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_2 field.
	/// </summary>
	public string attachment_2Default
	{
		get
		{
			return TableUtils.attachment_2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.attachment_3 field.
	/// </summary>
	public byte[] attachment_3
	{
		get
		{
			return this.GetValue(TableUtils.attachment_3Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachment_3Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachment_3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachment_3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_3 field.
	/// </summary>
	public string attachment_3Default
	{
		get
		{
			return TableUtils.attachment_3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.attachment_4 field.
	/// </summary>
	public byte[] attachment_4
	{
		get
		{
			return this.GetValue(TableUtils.attachment_4Column).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachment_4Column);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachment_4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachment_4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_4 field.
	/// </summary>
	public string attachment_4Default
	{
		get
		{
			return TableUtils.attachment_4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.attachment_1_filename field.
	/// </summary>
	public string attachment_1_filename
	{
		get
		{
			return this.GetValue(TableUtils.attachment_1_filenameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachment_1_filenameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachment_1_filenameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachment_1_filenameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_1_filename field.
	/// </summary>
	public string attachment_1_filenameDefault
	{
		get
		{
			return TableUtils.attachment_1_filenameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.attachment_2_filename field.
	/// </summary>
	public string attachment_2_filename
	{
		get
		{
			return this.GetValue(TableUtils.attachment_2_filenameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachment_2_filenameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachment_2_filenameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachment_2_filenameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_2_filename field.
	/// </summary>
	public string attachment_2_filenameDefault
	{
		get
		{
			return TableUtils.attachment_2_filenameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.attachment_3_filename field.
	/// </summary>
	public string attachment_3_filename
	{
		get
		{
			return this.GetValue(TableUtils.attachment_3_filenameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachment_3_filenameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachment_3_filenameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachment_3_filenameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_3_filename field.
	/// </summary>
	public string attachment_3_filenameDefault
	{
		get
		{
			return TableUtils.attachment_3_filenameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's opportunity_.attachment_4_filename field.
	/// </summary>
	public string attachment_4_filename
	{
		get
		{
			return this.GetValue(TableUtils.attachment_4_filenameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachment_4_filenameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachment_4_filenameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachment_4_filenameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's opportunity_.attachment_4_filename field.
	/// </summary>
	public string attachment_4_filenameDefault
	{
		get
		{
			return TableUtils.attachment_4_filenameColumn.DefaultValue;
		}
	}


#endregion
}

}
