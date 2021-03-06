﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_ticket_detailsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_ticket_detailsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_ticket_detailsView"></see> class.
/// </remarks>
/// <seealso cref="Vw_ticket_detailsView"></seealso>
/// <seealso cref="Vw_ticket_detailsRecord"></seealso>
public class BaseVw_ticket_detailsRecord : PrimaryKeyRecord
{

	public readonly static Vw_ticket_detailsView TableUtils = Vw_ticket_detailsView.Instance;

	// Constructors
 
	protected BaseVw_ticket_detailsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_ticket_detailsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Vw_ticket_detailsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_ticket_detailsRecord_ReadRecord); 
	}

	protected BaseVw_ticket_detailsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_ticket_detailsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_ticket_detailsRecord Vw_ticket_detailsRec = (Vw_ticket_detailsRecord)sender;
        if(Vw_ticket_detailsRec != null && !Vw_ticket_detailsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_ticket_detailsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_ticket_detailsRecord Vw_ticket_detailsRec = (Vw_ticket_detailsRecord)sender;
        Validate_Inserting();
        if(Vw_ticket_detailsRec != null && !Vw_ticket_detailsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Vw_ticket_detailsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Vw_ticket_detailsRecord Vw_ticket_detailsRec = (Vw_ticket_detailsRecord)sender;
        Validate_Updating();
        if(Vw_ticket_detailsRec != null && !Vw_ticket_detailsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.resource_sch_ticket_id field.
	/// </summary>
	public ColumnValue Getresource_sch_ticket_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.resource_sch_ticket_id field.
	/// </summary>
	public Int32 Getresource_sch_ticket_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.resource_sch_priority_id field.
	/// </summary>
	public ColumnValue Getresource_sch_priority_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_priority_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.resource_sch_priority_id field.
	/// </summary>
	public Int32 Getresource_sch_priority_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_priority_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_priority_id field.
	/// </summary>
	public void Setresource_sch_priority_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_priority_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_priority_id field.
	/// </summary>
	public void Setresource_sch_priority_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_priority_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_priority_id field.
	/// </summary>
	public void Setresource_sch_priority_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_priority_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_priority_id field.
	/// </summary>
	public void Setresource_sch_priority_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_priority_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_priority_id field.
	/// </summary>
	public void Setresource_sch_priority_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_priority_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.custcontactkey field.
	/// </summary>
	public ColumnValue GetcustcontactkeyValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.custcontactkey field.
	/// </summary>
	public Int32 GetcustcontactkeyFieldValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.subject field.
	/// </summary>
	public ColumnValue GetsubjectValue()
	{
		return this.GetValue(TableUtils.subjectColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.subject field.
	/// </summary>
	public string GetsubjectFieldValue()
	{
		return this.GetValue(TableUtils.subjectColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.subject field.
	/// </summary>
	public void SetsubjectFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.subjectColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.subject field.
	/// </summary>
	public void SetsubjectFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.subjectColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ticket_details field.
	/// </summary>
	public ColumnValue Getticket_detailsValue()
	{
		return this.GetValue(TableUtils.ticket_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ticket_details field.
	/// </summary>
	public string Getticket_detailsFieldValue()
	{
		return this.GetValue(TableUtils.ticket_detailsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_details field.
	/// </summary>
	public void Setticket_detailsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ticket_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_details field.
	/// </summary>
	public void Setticket_detailsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_detailsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.scheduled_date field.
	/// </summary>
	public ColumnValue Getscheduled_dateValue()
	{
		return this.GetValue(TableUtils.scheduled_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.scheduled_date field.
	/// </summary>
	public DateTime Getscheduled_dateFieldValue()
	{
		return this.GetValue(TableUtils.scheduled_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.scheduled_date field.
	/// </summary>
	public void Setscheduled_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.scheduled_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.scheduled_date field.
	/// </summary>
	public void Setscheduled_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.scheduled_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.scheduled_date field.
	/// </summary>
	public void Setscheduled_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.scheduled_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.due_date field.
	/// </summary>
	public ColumnValue Getdue_dateValue()
	{
		return this.GetValue(TableUtils.due_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.due_date field.
	/// </summary>
	public DateTime Getdue_dateFieldValue()
	{
		return this.GetValue(TableUtils.due_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.due_date field.
	/// </summary>
	public void Setdue_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.due_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.due_date field.
	/// </summary>
	public void Setdue_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.due_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.due_date field.
	/// </summary>
	public void Setdue_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.due_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.estimated_duration_hours field.
	/// </summary>
	public ColumnValue Getestimated_duration_hoursValue()
	{
		return this.GetValue(TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.estimated_duration_hours field.
	/// </summary>
	public Int32 Getestimated_duration_hoursFieldValue()
	{
		return this.GetValue(TableUtils.estimated_duration_hoursColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(string val)
	{
		this.SetString(val, TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_hoursColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.estimated_duration_minutes field.
	/// </summary>
	public ColumnValue Getestimated_duration_minutesValue()
	{
		return this.GetValue(TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.estimated_duration_minutes field.
	/// </summary>
	public Int32 Getestimated_duration_minutesFieldValue()
	{
		return this.GetValue(TableUtils.estimated_duration_minutesColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(string val)
	{
		this.SetString(val, TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_minutesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.resource_sch_status_id field.
	/// </summary>
	public ColumnValue Getresource_sch_status_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.resource_sch_status_id field.
	/// </summary>
	public Int32 Getresource_sch_status_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_status_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_status_id field.
	/// </summary>
	public void Setresource_sch_status_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_status_id field.
	/// </summary>
	public void Setresource_sch_status_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_status_id field.
	/// </summary>
	public void Setresource_sch_status_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_status_id field.
	/// </summary>
	public void Setresource_sch_status_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_status_id field.
	/// </summary>
	public void Setresource_sch_status_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_status_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.resource_sch_project_id field.
	/// </summary>
	public ColumnValue Getresource_sch_project_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.resource_sch_project_id field.
	/// </summary>
	public Int32 Getresource_sch_project_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_project_id field.
	/// </summary>
	public void Setresource_sch_project_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_project_id field.
	/// </summary>
	public void Setresource_sch_project_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_project_id field.
	/// </summary>
	public void Setresource_sch_project_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_project_id field.
	/// </summary>
	public void Setresource_sch_project_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_project_id field.
	/// </summary>
	public void Setresource_sch_project_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.project_id field.
	/// </summary>
	public ColumnValue Getproject_idValue()
	{
		return this.GetValue(TableUtils.project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.project_id field.
	/// </summary>
	public Int32 Getproject_idFieldValue()
	{
		return this.GetValue(TableUtils.project_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_id field.
	/// </summary>
	public void Setproject_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_id field.
	/// </summary>
	public void Setproject_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_id field.
	/// </summary>
	public void Setproject_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_id field.
	/// </summary>
	public void Setproject_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_id field.
	/// </summary>
	public void Setproject_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ticket_actual_time field.
	/// </summary>
	public ColumnValue Getticket_actual_timeValue()
	{
		return this.GetValue(TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ticket_actual_time field.
	/// </summary>
	public Decimal Getticket_actual_timeFieldValue()
	{
		return this.GetValue(TableUtils.ticket_actual_timeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_actual_timeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ticket_cost field.
	/// </summary>
	public ColumnValue Getticket_costValue()
	{
		return this.GetValue(TableUtils.ticket_costColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ticket_cost field.
	/// </summary>
	public Decimal Getticket_costFieldValue()
	{
		return this.GetValue(TableUtils.ticket_costColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_cost field.
	/// </summary>
	public void Setticket_costFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ticket_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_cost field.
	/// </summary>
	public void Setticket_costFieldValue(string val)
	{
		this.SetString(val, TableUtils.ticket_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_cost field.
	/// </summary>
	public void Setticket_costFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_cost field.
	/// </summary>
	public void Setticket_costFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_cost field.
	/// </summary>
	public void Setticket_costFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_costColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.time_interval_id field.
	/// </summary>
	public ColumnValue Gettime_interval_idValue()
	{
		return this.GetValue(TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.time_interval_id field.
	/// </summary>
	public Int32 Gettime_interval_idFieldValue()
	{
		return this.GetValue(TableUtils.time_interval_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.time_interval_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.rono field.
	/// </summary>
	public ColumnValue GetronoValue()
	{
		return this.GetValue(TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.rono field.
	/// </summary>
	public Int32 GetronoFieldValue()
	{
		return this.GetValue(TableUtils.ronoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.rono field.
	/// </summary>
	public void SetronoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.rono field.
	/// </summary>
	public void SetronoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.rono field.
	/// </summary>
	public void SetronoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.rono field.
	/// </summary>
	public void SetronoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.rono field.
	/// </summary>
	public void SetronoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.contractor_id field.
	/// </summary>
	public ColumnValue Getcontractor_idValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.contractor_id field.
	/// </summary>
	public Int32 Getcontractor_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.contractor_contact_id field.
	/// </summary>
	public ColumnValue Getcontractor_contact_idValue()
	{
		return this.GetValue(TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.contractor_contact_id field.
	/// </summary>
	public Int32 Getcontractor_contact_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_contact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_contact_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.project_role_id field.
	/// </summary>
	public ColumnValue Getproject_role_idValue()
	{
		return this.GetValue(TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.project_role_id field.
	/// </summary>
	public Int32 Getproject_role_idFieldValue()
	{
		return this.GetValue(TableUtils.project_role_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.esthours field.
	/// </summary>
	public ColumnValue GetesthoursValue()
	{
		return this.GetValue(TableUtils.esthoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.esthours field.
	/// </summary>
	public Decimal GetesthoursFieldValue()
	{
		return this.GetValue(TableUtils.esthoursColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.esthours field.
	/// </summary>
	public void SetesthoursFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.esthoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.esthours field.
	/// </summary>
	public void SetesthoursFieldValue(string val)
	{
		this.SetString(val, TableUtils.esthoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.esthours field.
	/// </summary>
	public void SetesthoursFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.esthoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.esthours field.
	/// </summary>
	public void SetesthoursFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.esthoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.esthours field.
	/// </summary>
	public void SetesthoursFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.esthoursColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ROCategory field.
	/// </summary>
	public ColumnValue GetROCategoryValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ROCategory field.
	/// </summary>
	public string GetROCategoryFieldValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ROMake field.
	/// </summary>
	public ColumnValue GetROMakeValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ROMake field.
	/// </summary>
	public string GetROMakeFieldValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ROModel field.
	/// </summary>
	public ColumnValue GetROModelValue()
	{
		return this.GetValue(TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.ROModel field.
	/// </summary>
	public string GetROModelFieldValue()
	{
		return this.GetValue(TableUtils.ROModelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROModelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_ticket_details_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.resource_sch_ticket_id field.
	/// </summary>
	public Int32 resource_sch_ticket_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_ticket_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_ticket_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_ticket_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_ticket_id field.
	/// </summary>
	public string resource_sch_ticket_idDefault
	{
		get
		{
			return TableUtils.resource_sch_ticket_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.technician_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.resource_sch_priority_id field.
	/// </summary>
	public Int32 resource_sch_priority_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_priority_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_priority_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_priority_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_priority_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_priority_id field.
	/// </summary>
	public string resource_sch_priority_idDefault
	{
		get
		{
			return TableUtils.resource_sch_priority_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.custcontactkey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.custcontactkey field.
	/// </summary>
	public string custcontactkeyDefault
	{
		get
		{
			return TableUtils.custcontactkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.subject field.
	/// </summary>
	public string subject
	{
		get
		{
			return this.GetValue(TableUtils.subjectColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.subjectColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool subjectSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.subjectColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.subject field.
	/// </summary>
	public string subjectDefault
	{
		get
		{
			return TableUtils.subjectColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.ticket_details field.
	/// </summary>
	public string ticket_details
	{
		get
		{
			return this.GetValue(TableUtils.ticket_detailsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ticket_detailsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ticket_detailsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ticket_detailsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_details field.
	/// </summary>
	public string ticket_detailsDefault
	{
		get
		{
			return TableUtils.ticket_detailsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.scheduled_date field.
	/// </summary>
	public DateTime scheduled_date
	{
		get
		{
			return this.GetValue(TableUtils.scheduled_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.scheduled_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool scheduled_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.scheduled_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.scheduled_date field.
	/// </summary>
	public string scheduled_dateDefault
	{
		get
		{
			return TableUtils.scheduled_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.due_date field.
	/// </summary>
	public DateTime due_date
	{
		get
		{
			return this.GetValue(TableUtils.due_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.due_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool due_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.due_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.due_date field.
	/// </summary>
	public string due_dateDefault
	{
		get
		{
			return TableUtils.due_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.estimated_duration_hours field.
	/// </summary>
	public Int32 estimated_duration_hours
	{
		get
		{
			return this.GetValue(TableUtils.estimated_duration_hoursColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.estimated_duration_hoursColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool estimated_duration_hoursSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.estimated_duration_hoursColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_hours field.
	/// </summary>
	public string estimated_duration_hoursDefault
	{
		get
		{
			return TableUtils.estimated_duration_hoursColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.estimated_duration_minutes field.
	/// </summary>
	public Int32 estimated_duration_minutes
	{
		get
		{
			return this.GetValue(TableUtils.estimated_duration_minutesColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.estimated_duration_minutesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool estimated_duration_minutesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.estimated_duration_minutesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.estimated_duration_minutes field.
	/// </summary>
	public string estimated_duration_minutesDefault
	{
		get
		{
			return TableUtils.estimated_duration_minutesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.resource_sch_status_id field.
	/// </summary>
	public Int32 resource_sch_status_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_status_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_status_id field.
	/// </summary>
	public string resource_sch_status_idDefault
	{
		get
		{
			return TableUtils.resource_sch_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.resource_sch_project_id field.
	/// </summary>
	public Int32 resource_sch_project_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_project_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_project_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_project_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_project_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.resource_sch_project_id field.
	/// </summary>
	public string resource_sch_project_idDefault
	{
		get
		{
			return TableUtils.resource_sch_project_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.created_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.created_datetime field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.created_datetime field.
	/// </summary>
	public string created_datetimeDefault
	{
		get
		{
			return TableUtils.created_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.project_id field.
	/// </summary>
	public Int32 project_id
	{
		get
		{
			return this.GetValue(TableUtils.project_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_id field.
	/// </summary>
	public string project_idDefault
	{
		get
		{
			return TableUtils.project_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.ticket_actual_time field.
	/// </summary>
	public Decimal ticket_actual_time
	{
		get
		{
			return this.GetValue(TableUtils.ticket_actual_timeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ticket_actual_timeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ticket_actual_timeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ticket_actual_timeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_actual_time field.
	/// </summary>
	public string ticket_actual_timeDefault
	{
		get
		{
			return TableUtils.ticket_actual_timeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.ticket_cost field.
	/// </summary>
	public Decimal ticket_cost
	{
		get
		{
			return this.GetValue(TableUtils.ticket_costColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ticket_costColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ticket_costSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ticket_costColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ticket_cost field.
	/// </summary>
	public string ticket_costDefault
	{
		get
		{
			return TableUtils.ticket_costColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.time_interval_id field.
	/// </summary>
	public Int32 time_interval_id
	{
		get
		{
			return this.GetValue(TableUtils.time_interval_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.time_interval_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool time_interval_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.time_interval_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.time_interval_id field.
	/// </summary>
	public string time_interval_idDefault
	{
		get
		{
			return TableUtils.time_interval_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.rono field.
	/// </summary>
	public Int32 rono
	{
		get
		{
			return this.GetValue(TableUtils.ronoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ronoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ronoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ronoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.rono field.
	/// </summary>
	public string ronoDefault
	{
		get
		{
			return TableUtils.ronoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.contractor_id field.
	/// </summary>
	public Int32 contractor_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_id field.
	/// </summary>
	public string contractor_idDefault
	{
		get
		{
			return TableUtils.contractor_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.contractor_contact_id field.
	/// </summary>
	public Int32 contractor_contact_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_contact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_contact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_contact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_contact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.contractor_contact_id field.
	/// </summary>
	public string contractor_contact_idDefault
	{
		get
		{
			return TableUtils.contractor_contact_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.project_role_id field.
	/// </summary>
	public Int32 project_role_id
	{
		get
		{
			return this.GetValue(TableUtils.project_role_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_role_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_role_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_role_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.project_role_id field.
	/// </summary>
	public string project_role_idDefault
	{
		get
		{
			return TableUtils.project_role_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.esthours field.
	/// </summary>
	public Decimal esthours
	{
		get
		{
			return this.GetValue(TableUtils.esthoursColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.esthoursColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool esthoursSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.esthoursColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.esthours field.
	/// </summary>
	public string esthoursDefault
	{
		get
		{
			return TableUtils.esthoursColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.ROCategory field.
	/// </summary>
	public string ROCategory
	{
		get
		{
			return this.GetValue(TableUtils.ROCategoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCategoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCategorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCategoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ROCategory field.
	/// </summary>
	public string ROCategoryDefault
	{
		get
		{
			return TableUtils.ROCategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.ROMake field.
	/// </summary>
	public string ROMake
	{
		get
		{
			return this.GetValue(TableUtils.ROMakeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROMakeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROMakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROMakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ROMake field.
	/// </summary>
	public string ROMakeDefault
	{
		get
		{
			return TableUtils.ROMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.ROModel field.
	/// </summary>
	public string ROModel
	{
		get
		{
			return this.GetValue(TableUtils.ROModelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROModelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROModelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROModelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.ROModel field.
	/// </summary>
	public string ROModelDefault
	{
		get
		{
			return TableUtils.ROModelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_ticket_details_.category_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_ticket_details_.category_id field.
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
