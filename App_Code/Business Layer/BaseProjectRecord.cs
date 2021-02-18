// This class is "generated" and will be overwritten.
// Your customizations should be made in ProjectRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ProjectRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ProjectTable"></see> class.
/// </remarks>
/// <seealso cref="ProjectTable"></seealso>
/// <seealso cref="ProjectRecord"></seealso>
public class BaseProjectRecord : PrimaryKeyRecord
{

	public readonly static ProjectTable TableUtils = ProjectTable.Instance;

	// Constructors
 
	protected BaseProjectRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ProjectRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ProjectRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ProjectRecord_ReadRecord); 
	}

	protected BaseProjectRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ProjectRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ProjectRecord ProjectRec = (ProjectRecord)sender;
        if(ProjectRec != null && !ProjectRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ProjectRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ProjectRecord ProjectRec = (ProjectRecord)sender;
        Validate_Inserting();
        if(ProjectRec != null && !ProjectRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ProjectRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ProjectRecord ProjectRec = (ProjectRecord)sender;
        Validate_Updating();
        if(ProjectRec != null && !ProjectRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's project_.project_id field.
	/// </summary>
	public ColumnValue Getproject_idValue()
	{
		return this.GetValue(TableUtils.project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_id field.
	/// </summary>
	public Int32 Getproject_idFieldValue()
	{
		return this.GetValue(TableUtils.project_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_name field.
	/// </summary>
	public ColumnValue Getproject_nameValue()
	{
		return this.GetValue(TableUtils.project_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_name field.
	/// </summary>
	public string Getproject_nameFieldValue()
	{
		return this.GetValue(TableUtils.project_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_name field.
	/// </summary>
	public void Setproject_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_name field.
	/// </summary>
	public void Setproject_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_companyid field.
	/// </summary>
	public ColumnValue Getproject_companyidValue()
	{
		return this.GetValue(TableUtils.project_companyidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_companyid field.
	/// </summary>
	public Int32 Getproject_companyidFieldValue()
	{
		return this.GetValue(TableUtils.project_companyidColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_companyid field.
	/// </summary>
	public void Setproject_companyidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_companyidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_companyid field.
	/// </summary>
	public void Setproject_companyidFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_companyidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_companyid field.
	/// </summary>
	public void Setproject_companyidFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_companyidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_companyid field.
	/// </summary>
	public void Setproject_companyidFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_companyidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_companyid field.
	/// </summary>
	public void Setproject_companyidFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_companyidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_poc field.
	/// </summary>
	public ColumnValue Getproject_pocValue()
	{
		return this.GetValue(TableUtils.project_pocColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_poc field.
	/// </summary>
	public Int32 Getproject_pocFieldValue()
	{
		return this.GetValue(TableUtils.project_pocColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_poc field.
	/// </summary>
	public void Setproject_pocFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_pocColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_poc field.
	/// </summary>
	public void Setproject_pocFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_pocColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_poc field.
	/// </summary>
	public void Setproject_pocFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_pocColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_poc field.
	/// </summary>
	public void Setproject_pocFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_pocColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_poc field.
	/// </summary>
	public void Setproject_pocFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_pocColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_startdate field.
	/// </summary>
	public ColumnValue Getproject_startdateValue()
	{
		return this.GetValue(TableUtils.project_startdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_startdate field.
	/// </summary>
	public DateTime Getproject_startdateFieldValue()
	{
		return this.GetValue(TableUtils.project_startdateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_startdate field.
	/// </summary>
	public void Setproject_startdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_startdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_startdate field.
	/// </summary>
	public void Setproject_startdateFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_startdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_startdate field.
	/// </summary>
	public void Setproject_startdateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_startdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_enddate field.
	/// </summary>
	public ColumnValue Getproject_enddateValue()
	{
		return this.GetValue(TableUtils.project_enddateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_enddate field.
	/// </summary>
	public DateTime Getproject_enddateFieldValue()
	{
		return this.GetValue(TableUtils.project_enddateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_enddate field.
	/// </summary>
	public void Setproject_enddateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_enddateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_enddate field.
	/// </summary>
	public void Setproject_enddateFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_enddateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_enddate field.
	/// </summary>
	public void Setproject_enddateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_enddateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_description field.
	/// </summary>
	public ColumnValue Getproject_descriptionValue()
	{
		return this.GetValue(TableUtils.project_descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_description field.
	/// </summary>
	public string Getproject_descriptionFieldValue()
	{
		return this.GetValue(TableUtils.project_descriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_description field.
	/// </summary>
	public void Setproject_descriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_description field.
	/// </summary>
	public void Setproject_descriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_descriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_status_id field.
	/// </summary>
	public ColumnValue Getproject_status_idValue()
	{
		return this.GetValue(TableUtils.project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_status_id field.
	/// </summary>
	public Int32 Getproject_status_idFieldValue()
	{
		return this.GetValue(TableUtils.project_status_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_status_id field.
	/// </summary>
	public void Setproject_status_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_status_id field.
	/// </summary>
	public void Setproject_status_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_status_id field.
	/// </summary>
	public void Setproject_status_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_status_id field.
	/// </summary>
	public void Setproject_status_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_status_id field.
	/// </summary>
	public void Setproject_status_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_status_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_type_id field.
	/// </summary>
	public ColumnValue Getproject_type_idValue()
	{
		return this.GetValue(TableUtils.project_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_type_id field.
	/// </summary>
	public Int32 Getproject_type_idFieldValue()
	{
		return this.GetValue(TableUtils.project_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_type_id field.
	/// </summary>
	public void Setproject_type_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_type_id field.
	/// </summary>
	public void Setproject_type_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_type_id field.
	/// </summary>
	public void Setproject_type_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_type_id field.
	/// </summary>
	public void Setproject_type_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_type_id field.
	/// </summary>
	public void Setproject_type_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_type_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_budget field.
	/// </summary>
	public ColumnValue Getproject_budgetValue()
	{
		return this.GetValue(TableUtils.project_budgetColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_budget field.
	/// </summary>
	public Decimal Getproject_budgetFieldValue()
	{
		return this.GetValue(TableUtils.project_budgetColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_budget field.
	/// </summary>
	public void Setproject_budgetFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_budgetColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_budget field.
	/// </summary>
	public void Setproject_budgetFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_budgetColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_budget field.
	/// </summary>
	public void Setproject_budgetFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_budgetColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_budget field.
	/// </summary>
	public void Setproject_budgetFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_budgetColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_budget field.
	/// </summary>
	public void Setproject_budgetFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_budgetColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_actual field.
	/// </summary>
	public ColumnValue Getproject_actualValue()
	{
		return this.GetValue(TableUtils.project_actualColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_actual field.
	/// </summary>
	public Decimal Getproject_actualFieldValue()
	{
		return this.GetValue(TableUtils.project_actualColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_actual field.
	/// </summary>
	public void Setproject_actualFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_actualColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_actual field.
	/// </summary>
	public void Setproject_actualFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_actualColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_actual field.
	/// </summary>
	public void Setproject_actualFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_actualColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_actual field.
	/// </summary>
	public void Setproject_actualFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_actualColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_actual field.
	/// </summary>
	public void Setproject_actualFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_actualColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_est_hours field.
	/// </summary>
	public ColumnValue Getproject_est_hoursValue()
	{
		return this.GetValue(TableUtils.project_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_est_hours field.
	/// </summary>
	public Int32 Getproject_est_hoursFieldValue()
	{
		return this.GetValue(TableUtils.project_est_hoursColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_est_hours field.
	/// </summary>
	public void Setproject_est_hoursFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_est_hours field.
	/// </summary>
	public void Setproject_est_hoursFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_est_hours field.
	/// </summary>
	public void Setproject_est_hoursFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_est_hours field.
	/// </summary>
	public void Setproject_est_hoursFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_est_hours field.
	/// </summary>
	public void Setproject_est_hoursFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_est_hoursColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.createdby field.
	/// </summary>
	public ColumnValue GetcreatedbyValue()
	{
		return this.GetValue(TableUtils.createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.createdby field.
	/// </summary>
	public Int32 GetcreatedbyFieldValue()
	{
		return this.GetValue(TableUtils.createdbyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.createdby field.
	/// </summary>
	public void SetcreatedbyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.createdby field.
	/// </summary>
	public void SetcreatedbyFieldValue(string val)
	{
		this.SetString(val, TableUtils.createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.createdby field.
	/// </summary>
	public void SetcreatedbyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.createdby field.
	/// </summary>
	public void SetcreatedbyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.createdby field.
	/// </summary>
	public void SetcreatedbyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.createdbyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_actual_time field.
	/// </summary>
	public ColumnValue Getproject_actual_timeValue()
	{
		return this.GetValue(TableUtils.project_actual_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_actual_time field.
	/// </summary>
	public Decimal Getproject_actual_timeFieldValue()
	{
		return this.GetValue(TableUtils.project_actual_timeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_time_left field.
	/// </summary>
	public ColumnValue Getproject_time_leftValue()
	{
		return this.GetValue(TableUtils.project_time_leftColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_time_left field.
	/// </summary>
	public Int32 Getproject_time_leftFieldValue()
	{
		return this.GetValue(TableUtils.project_time_leftColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_percent_copmlete field.
	/// </summary>
	public ColumnValue Getproject_percent_copmleteValue()
	{
		return this.GetValue(TableUtils.project_percent_copmleteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_percent_copmlete field.
	/// </summary>
	public Int32 Getproject_percent_copmleteFieldValue()
	{
		return this.GetValue(TableUtils.project_percent_copmleteColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_cost field.
	/// </summary>
	public ColumnValue Getproject_costValue()
	{
		return this.GetValue(TableUtils.project_costColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_cost field.
	/// </summary>
	public Decimal Getproject_costFieldValue()
	{
		return this.GetValue(TableUtils.project_costColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.travel_cost field.
	/// </summary>
	public ColumnValue Gettravel_costValue()
	{
		return this.GetValue(TableUtils.travel_costColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.travel_cost field.
	/// </summary>
	public Decimal Gettravel_costFieldValue()
	{
		return this.GetValue(TableUtils.travel_costColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.travel_cost field.
	/// </summary>
	public void Settravel_costFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.travel_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.travel_cost field.
	/// </summary>
	public void Settravel_costFieldValue(string val)
	{
		this.SetString(val, TableUtils.travel_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.travel_cost field.
	/// </summary>
	public void Settravel_costFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.travel_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.travel_cost field.
	/// </summary>
	public void Settravel_costFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.travel_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.travel_cost field.
	/// </summary>
	public void Settravel_costFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.travel_costColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_po_number field.
	/// </summary>
	public ColumnValue Getproject_po_numberValue()
	{
		return this.GetValue(TableUtils.project_po_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_po_number field.
	/// </summary>
	public string Getproject_po_numberFieldValue()
	{
		return this.GetValue(TableUtils.project_po_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_po_number field.
	/// </summary>
	public void Setproject_po_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_po_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_po_number field.
	/// </summary>
	public void Setproject_po_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_po_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_flat_fee field.
	/// </summary>
	public ColumnValue Getproject_flat_feeValue()
	{
		return this.GetValue(TableUtils.project_flat_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_.project_flat_fee field.
	/// </summary>
	public Decimal Getproject_flat_feeFieldValue()
	{
		return this.GetValue(TableUtils.project_flat_feeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_flat_fee field.
	/// </summary>
	public void Setproject_flat_feeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_flat_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_flat_fee field.
	/// </summary>
	public void Setproject_flat_feeFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_flat_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_flat_fee field.
	/// </summary>
	public void Setproject_flat_feeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_flat_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_flat_fee field.
	/// </summary>
	public void Setproject_flat_feeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_flat_feeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_flat_fee field.
	/// </summary>
	public void Setproject_flat_feeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_flat_feeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_id field.
	/// </summary>
	public string project_idDefault
	{
		get
		{
			return TableUtils.project_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_name field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_name field.
	/// </summary>
	public string project_nameDefault
	{
		get
		{
			return TableUtils.project_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_companyid field.
	/// </summary>
	public Int32 project_companyid
	{
		get
		{
			return this.GetValue(TableUtils.project_companyidColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_companyidColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_companyidSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_companyidColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_companyid field.
	/// </summary>
	public string project_companyidDefault
	{
		get
		{
			return TableUtils.project_companyidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_poc field.
	/// </summary>
	public Int32 project_poc
	{
		get
		{
			return this.GetValue(TableUtils.project_pocColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_pocColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_pocSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_pocColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_poc field.
	/// </summary>
	public string project_pocDefault
	{
		get
		{
			return TableUtils.project_pocColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_startdate field.
	/// </summary>
	public DateTime project_startdate
	{
		get
		{
			return this.GetValue(TableUtils.project_startdateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_startdateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_startdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_startdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_startdate field.
	/// </summary>
	public string project_startdateDefault
	{
		get
		{
			return TableUtils.project_startdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_enddate field.
	/// </summary>
	public DateTime project_enddate
	{
		get
		{
			return this.GetValue(TableUtils.project_enddateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_enddateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_enddateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_enddateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_enddate field.
	/// </summary>
	public string project_enddateDefault
	{
		get
		{
			return TableUtils.project_enddateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_description field.
	/// </summary>
	public string project_description
	{
		get
		{
			return this.GetValue(TableUtils.project_descriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_descriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_descriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_descriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_description field.
	/// </summary>
	public string project_descriptionDefault
	{
		get
		{
			return TableUtils.project_descriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_status_id field.
	/// </summary>
	public Int32 project_status_id
	{
		get
		{
			return this.GetValue(TableUtils.project_status_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_status_id field.
	/// </summary>
	public string project_status_idDefault
	{
		get
		{
			return TableUtils.project_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_type_id field.
	/// </summary>
	public Int32 project_type_id
	{
		get
		{
			return this.GetValue(TableUtils.project_type_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_type_id field.
	/// </summary>
	public string project_type_idDefault
	{
		get
		{
			return TableUtils.project_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_budget field.
	/// </summary>
	public Decimal project_budget
	{
		get
		{
			return this.GetValue(TableUtils.project_budgetColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_budgetColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_budgetSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_budgetColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_budget field.
	/// </summary>
	public string project_budgetDefault
	{
		get
		{
			return TableUtils.project_budgetColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_actual field.
	/// </summary>
	public Decimal project_actual
	{
		get
		{
			return this.GetValue(TableUtils.project_actualColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_actualColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_actualSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_actualColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_actual field.
	/// </summary>
	public string project_actualDefault
	{
		get
		{
			return TableUtils.project_actualColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_est_hours field.
	/// </summary>
	public Int32 project_est_hours
	{
		get
		{
			return this.GetValue(TableUtils.project_est_hoursColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_est_hoursColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_est_hoursSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_est_hoursColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_est_hours field.
	/// </summary>
	public string project_est_hoursDefault
	{
		get
		{
			return TableUtils.project_est_hoursColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.createdby field.
	/// </summary>
	public Int32 createdby
	{
		get
		{
			return this.GetValue(TableUtils.createdbyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.createdbyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool createdbySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.createdbyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.createdby field.
	/// </summary>
	public string createdbyDefault
	{
		get
		{
			return TableUtils.createdbyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.created_datetime field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_.created_datetime field.
	/// </summary>
	public string created_datetimeDefault
	{
		get
		{
			return TableUtils.created_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_actual_time field.
	/// </summary>
	public Decimal project_actual_time
	{
		get
		{
			return this.GetValue(TableUtils.project_actual_timeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_actual_timeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_actual_timeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_actual_timeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_actual_time field.
	/// </summary>
	public string project_actual_timeDefault
	{
		get
		{
			return TableUtils.project_actual_timeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_time_left field.
	/// </summary>
	public Int32 project_time_left
	{
		get
		{
			return this.GetValue(TableUtils.project_time_leftColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_time_leftColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_time_leftSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_time_leftColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_time_left field.
	/// </summary>
	public string project_time_leftDefault
	{
		get
		{
			return TableUtils.project_time_leftColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_percent_copmlete field.
	/// </summary>
	public Int32 project_percent_copmlete
	{
		get
		{
			return this.GetValue(TableUtils.project_percent_copmleteColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_percent_copmleteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_percent_copmleteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_percent_copmleteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_percent_copmlete field.
	/// </summary>
	public string project_percent_copmleteDefault
	{
		get
		{
			return TableUtils.project_percent_copmleteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_cost field.
	/// </summary>
	public Decimal project_cost
	{
		get
		{
			return this.GetValue(TableUtils.project_costColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_costColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_costSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_costColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_cost field.
	/// </summary>
	public string project_costDefault
	{
		get
		{
			return TableUtils.project_costColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.travel_cost field.
	/// </summary>
	public Decimal travel_cost
	{
		get
		{
			return this.GetValue(TableUtils.travel_costColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.travel_costColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool travel_costSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.travel_costColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.travel_cost field.
	/// </summary>
	public string travel_costDefault
	{
		get
		{
			return TableUtils.travel_costColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_po_number field.
	/// </summary>
	public string project_po_number
	{
		get
		{
			return this.GetValue(TableUtils.project_po_numberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_po_numberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_po_numberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_po_numberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_po_number field.
	/// </summary>
	public string project_po_numberDefault
	{
		get
		{
			return TableUtils.project_po_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_.project_flat_fee field.
	/// </summary>
	public Decimal project_flat_fee
	{
		get
		{
			return this.GetValue(TableUtils.project_flat_feeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_flat_feeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_flat_feeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_flat_feeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_.project_flat_fee field.
	/// </summary>
	public string project_flat_feeDefault
	{
		get
		{
			return TableUtils.project_flat_feeColumn.DefaultValue;
		}
	}


#endregion
}

}
