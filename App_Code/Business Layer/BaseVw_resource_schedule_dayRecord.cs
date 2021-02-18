// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_resource_schedule_dayRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_resource_schedule_dayRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_resource_schedule_dayView"></see> class.
/// </remarks>
/// <seealso cref="Vw_resource_schedule_dayView"></seealso>
/// <seealso cref="Vw_resource_schedule_dayRecord"></seealso>
public class BaseVw_resource_schedule_dayRecord : PrimaryKeyRecord
{

	public readonly static Vw_resource_schedule_dayView TableUtils = Vw_resource_schedule_dayView.Instance;

	// Constructors
 
	protected BaseVw_resource_schedule_dayRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_resource_schedule_dayRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Vw_resource_schedule_dayRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_resource_schedule_dayRecord_ReadRecord); 
	}

	protected BaseVw_resource_schedule_dayRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_resource_schedule_dayRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_resource_schedule_dayRecord Vw_resource_schedule_dayRec = (Vw_resource_schedule_dayRecord)sender;
        if(Vw_resource_schedule_dayRec != null && !Vw_resource_schedule_dayRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_resource_schedule_dayRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_resource_schedule_dayRecord Vw_resource_schedule_dayRec = (Vw_resource_schedule_dayRecord)sender;
        Validate_Inserting();
        if(Vw_resource_schedule_dayRec != null && !Vw_resource_schedule_dayRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Vw_resource_schedule_dayRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Vw_resource_schedule_dayRecord Vw_resource_schedule_dayRec = (Vw_resource_schedule_dayRecord)sender;
        Validate_Updating();
        if(Vw_resource_schedule_dayRec != null && !Vw_resource_schedule_dayRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.resource_sch_ticket_id field.
	/// </summary>
	public ColumnValue Getresource_sch_ticket_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.resource_sch_ticket_id field.
	/// </summary>
	public Int32 Getresource_sch_ticket_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.resource_sch_priority field.
	/// </summary>
	public ColumnValue Getresource_sch_priorityValue()
	{
		return this.GetValue(TableUtils.resource_sch_priorityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.resource_sch_priority field.
	/// </summary>
	public string Getresource_sch_priorityFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_priorityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_priority field.
	/// </summary>
	public void Setresource_sch_priorityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_priorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_priority field.
	/// </summary>
	public void Setresource_sch_priorityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_priorityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.resource_sch_status field.
	/// </summary>
	public ColumnValue Getresource_sch_statusValue()
	{
		return this.GetValue(TableUtils.resource_sch_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.resource_sch_status field.
	/// </summary>
	public string Getresource_sch_statusFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_statusColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_status field.
	/// </summary>
	public void Setresource_sch_statusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_status field.
	/// </summary>
	public void Setresource_sch_statusFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_statusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.subject field.
	/// </summary>
	public ColumnValue GetsubjectValue()
	{
		return this.GetValue(TableUtils.subjectColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.subject field.
	/// </summary>
	public string GetsubjectFieldValue()
	{
		return this.GetValue(TableUtils.subjectColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.subject field.
	/// </summary>
	public void SetsubjectFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.subjectColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.subject field.
	/// </summary>
	public void SetsubjectFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.subjectColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.ticket_details field.
	/// </summary>
	public ColumnValue Getticket_detailsValue()
	{
		return this.GetValue(TableUtils.ticket_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.ticket_details field.
	/// </summary>
	public string Getticket_detailsFieldValue()
	{
		return this.GetValue(TableUtils.ticket_detailsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.ticket_details field.
	/// </summary>
	public void Setticket_detailsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ticket_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.ticket_details field.
	/// </summary>
	public void Setticket_detailsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_detailsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.scheduled_date field.
	/// </summary>
	public ColumnValue Getscheduled_dateValue()
	{
		return this.GetValue(TableUtils.scheduled_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.scheduled_date field.
	/// </summary>
	public DateTime Getscheduled_dateFieldValue()
	{
		return this.GetValue(TableUtils.scheduled_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.scheduled_date field.
	/// </summary>
	public void Setscheduled_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.scheduled_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.scheduled_date field.
	/// </summary>
	public void Setscheduled_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.scheduled_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.scheduled_date field.
	/// </summary>
	public void Setscheduled_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.scheduled_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.due_date field.
	/// </summary>
	public ColumnValue Getdue_dateValue()
	{
		return this.GetValue(TableUtils.due_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.due_date field.
	/// </summary>
	public DateTime Getdue_dateFieldValue()
	{
		return this.GetValue(TableUtils.due_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.due_date field.
	/// </summary>
	public void Setdue_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.due_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.due_date field.
	/// </summary>
	public void Setdue_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.due_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.due_date field.
	/// </summary>
	public void Setdue_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.due_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.estimated_duration_hours field.
	/// </summary>
	public ColumnValue Getestimated_duration_hoursValue()
	{
		return this.GetValue(TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.estimated_duration_hours field.
	/// </summary>
	public Int32 Getestimated_duration_hoursFieldValue()
	{
		return this.GetValue(TableUtils.estimated_duration_hoursColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(string val)
	{
		this.SetString(val, TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_hours field.
	/// </summary>
	public void Setestimated_duration_hoursFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_hoursColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.estimated_duration_minutes field.
	/// </summary>
	public ColumnValue Getestimated_duration_minutesValue()
	{
		return this.GetValue(TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.estimated_duration_minutes field.
	/// </summary>
	public Int32 Getestimated_duration_minutesFieldValue()
	{
		return this.GetValue(TableUtils.estimated_duration_minutesColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(string val)
	{
		this.SetString(val, TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_minutes field.
	/// </summary>
	public void Setestimated_duration_minutesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.estimated_duration_minutesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.ticket_actual_time field.
	/// </summary>
	public ColumnValue Getticket_actual_timeValue()
	{
		return this.GetValue(TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.ticket_actual_time field.
	/// </summary>
	public Decimal Getticket_actual_timeFieldValue()
	{
		return this.GetValue(TableUtils.ticket_actual_timeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.ticket_actual_time field.
	/// </summary>
	public void Setticket_actual_timeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ticket_actual_timeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.TechName field.
	/// </summary>
	public ColumnValue GetTechNameValue()
	{
		return this.GetValue(TableUtils.TechNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.TechName field.
	/// </summary>
	public string GetTechNameFieldValue()
	{
		return this.GetValue(TableUtils.TechNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.TechName field.
	/// </summary>
	public void SetTechNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.TechName field.
	/// </summary>
	public void SetTechNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.project_name field.
	/// </summary>
	public ColumnValue Getproject_nameValue()
	{
		return this.GetValue(TableUtils.project_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.project_name field.
	/// </summary>
	public string Getproject_nameFieldValue()
	{
		return this.GetValue(TableUtils.project_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.project_name field.
	/// </summary>
	public void Setproject_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.project_name field.
	/// </summary>
	public void Setproject_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.CustName field.
	/// </summary>
	public ColumnValue GetCustNameValue()
	{
		return this.GetValue(TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.CustName field.
	/// </summary>
	public string GetCustNameFieldValue()
	{
		return this.GetValue(TableUtils.CustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_resource_schedule_day_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.resource_sch_ticket_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_ticket_id field.
	/// </summary>
	public string resource_sch_ticket_idDefault
	{
		get
		{
			return TableUtils.resource_sch_ticket_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.resource_sch_priority field.
	/// </summary>
	public string resource_sch_priority
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_priorityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_priorityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_prioritySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_priorityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_priority field.
	/// </summary>
	public string resource_sch_priorityDefault
	{
		get
		{
			return TableUtils.resource_sch_priorityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.resource_sch_status field.
	/// </summary>
	public string resource_sch_status
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_statusColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_statusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_statusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_statusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.resource_sch_status field.
	/// </summary>
	public string resource_sch_statusDefault
	{
		get
		{
			return TableUtils.resource_sch_statusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.subject field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.subject field.
	/// </summary>
	public string subjectDefault
	{
		get
		{
			return TableUtils.subjectColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.ticket_details field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.ticket_details field.
	/// </summary>
	public string ticket_detailsDefault
	{
		get
		{
			return TableUtils.ticket_detailsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.scheduled_date field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.scheduled_date field.
	/// </summary>
	public string scheduled_dateDefault
	{
		get
		{
			return TableUtils.scheduled_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.due_date field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.due_date field.
	/// </summary>
	public string due_dateDefault
	{
		get
		{
			return TableUtils.due_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.estimated_duration_hours field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_hours field.
	/// </summary>
	public string estimated_duration_hoursDefault
	{
		get
		{
			return TableUtils.estimated_duration_hoursColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.estimated_duration_minutes field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.estimated_duration_minutes field.
	/// </summary>
	public string estimated_duration_minutesDefault
	{
		get
		{
			return TableUtils.estimated_duration_minutesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.ticket_actual_time field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.ticket_actual_time field.
	/// </summary>
	public string ticket_actual_timeDefault
	{
		get
		{
			return TableUtils.ticket_actual_timeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.TechName field.
	/// </summary>
	public string TechName
	{
		get
		{
			return this.GetValue(TableUtils.TechNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.TechName field.
	/// </summary>
	public string TechNameDefault
	{
		get
		{
			return TableUtils.TechNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.project_name field.
	/// </summary>
	public string project_name
	{
		get
		{
			return this.GetValue(TableUtils.project_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.project_name field.
	/// </summary>
	public string project_nameDefault
	{
		get
		{
			return TableUtils.project_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.CustName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.CustName field.
	/// </summary>
	public string CustNameDefault
	{
		get
		{
			return TableUtils.CustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_resource_schedule_day_.technician_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_resource_schedule_day_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}


#endregion
}

}
