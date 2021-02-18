// This class is "generated" and will be overwritten.
// Your customizations should be made in Project_role_rateRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Project_role_rateRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Project_role_rateTable"></see> class.
/// </remarks>
/// <seealso cref="Project_role_rateTable"></seealso>
/// <seealso cref="Project_role_rateRecord"></seealso>
public class BaseProject_role_rateRecord : PrimaryKeyRecord
{

	public readonly static Project_role_rateTable TableUtils = Project_role_rateTable.Instance;

	// Constructors
 
	protected BaseProject_role_rateRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Project_role_rateRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Project_role_rateRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Project_role_rateRecord_ReadRecord); 
	}

	protected BaseProject_role_rateRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Project_role_rateRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Project_role_rateRecord Project_role_rateRec = (Project_role_rateRecord)sender;
        if(Project_role_rateRec != null && !Project_role_rateRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Project_role_rateRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Project_role_rateRecord Project_role_rateRec = (Project_role_rateRecord)sender;
        Validate_Inserting();
        if(Project_role_rateRec != null && !Project_role_rateRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Project_role_rateRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Project_role_rateRecord Project_role_rateRec = (Project_role_rateRecord)sender;
        Validate_Updating();
        if(Project_role_rateRec != null && !Project_role_rateRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_rate_id field.
	/// </summary>
	public ColumnValue Getproject_role_rate_idValue()
	{
		return this.GetValue(TableUtils.project_role_rate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_rate_id field.
	/// </summary>
	public Int32 Getproject_role_rate_idFieldValue()
	{
		return this.GetValue(TableUtils.project_role_rate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_id field.
	/// </summary>
	public ColumnValue Getproject_role_idValue()
	{
		return this.GetValue(TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_id field.
	/// </summary>
	public Int32 Getproject_role_idFieldValue()
	{
		return this.GetValue(TableUtils.project_role_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_id field.
	/// </summary>
	public void Setproject_role_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_rate field.
	/// </summary>
	public ColumnValue Getproject_role_rateValue()
	{
		return this.GetValue(TableUtils.project_role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_rate field.
	/// </summary>
	public Decimal Getproject_role_rateFieldValue()
	{
		return this.GetValue(TableUtils.project_role_rateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate field.
	/// </summary>
	public void Setproject_role_rateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate field.
	/// </summary>
	public void Setproject_role_rateFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate field.
	/// </summary>
	public void Setproject_role_rateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate field.
	/// </summary>
	public void Setproject_role_rateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate field.
	/// </summary>
	public void Setproject_role_rateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_rateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_rate_startdate field.
	/// </summary>
	public ColumnValue Getproject_role_rate_startdateValue()
	{
		return this.GetValue(TableUtils.project_role_rate_startdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_rate_startdate field.
	/// </summary>
	public DateTime Getproject_role_rate_startdateFieldValue()
	{
		return this.GetValue(TableUtils.project_role_rate_startdateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate_startdate field.
	/// </summary>
	public void Setproject_role_rate_startdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_role_rate_startdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate_startdate field.
	/// </summary>
	public void Setproject_role_rate_startdateFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_role_rate_startdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate_startdate field.
	/// </summary>
	public void Setproject_role_rate_startdateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_rate_startdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_rate_enddate field.
	/// </summary>
	public ColumnValue Getproject_role_rate_enddateValue()
	{
		return this.GetValue(TableUtils.project_role_rate_enddateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.project_role_rate_enddate field.
	/// </summary>
	public DateTime Getproject_role_rate_enddateFieldValue()
	{
		return this.GetValue(TableUtils.project_role_rate_enddateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate_enddate field.
	/// </summary>
	public void Setproject_role_rate_enddateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_role_rate_enddateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate_enddate field.
	/// </summary>
	public void Setproject_role_rate_enddateFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_role_rate_enddateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate_enddate field.
	/// </summary>
	public void Setproject_role_rate_enddateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_rate_enddateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_rate_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_rate_.project_role_rate_id field.
	/// </summary>
	public Int32 project_role_rate_id
	{
		get
		{
			return this.GetValue(TableUtils.project_role_rate_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_role_rate_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_role_rate_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_role_rate_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate_id field.
	/// </summary>
	public string project_role_rate_idDefault
	{
		get
		{
			return TableUtils.project_role_rate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_rate_.project_role_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_id field.
	/// </summary>
	public string project_role_idDefault
	{
		get
		{
			return TableUtils.project_role_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_rate_.project_role_rate field.
	/// </summary>
	public Decimal project_role_rate
	{
		get
		{
			return this.GetValue(TableUtils.project_role_rateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_role_rateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_role_rateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_role_rateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate field.
	/// </summary>
	public string project_role_rateDefault
	{
		get
		{
			return TableUtils.project_role_rateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_rate_.project_role_rate_startdate field.
	/// </summary>
	public DateTime project_role_rate_startdate
	{
		get
		{
			return this.GetValue(TableUtils.project_role_rate_startdateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_role_rate_startdateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_role_rate_startdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_role_rate_startdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate_startdate field.
	/// </summary>
	public string project_role_rate_startdateDefault
	{
		get
		{
			return TableUtils.project_role_rate_startdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_rate_.project_role_rate_enddate field.
	/// </summary>
	public DateTime project_role_rate_enddate
	{
		get
		{
			return this.GetValue(TableUtils.project_role_rate_enddateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_role_rate_enddateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_role_rate_enddateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_role_rate_enddateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.project_role_rate_enddate field.
	/// </summary>
	public string project_role_rate_enddateDefault
	{
		get
		{
			return TableUtils.project_role_rate_enddateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_rate_.created_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_rate_.created_datetime field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_role_rate_.created_datetime field.
	/// </summary>
	public string created_datetimeDefault
	{
		get
		{
			return TableUtils.created_datetimeColumn.DefaultValue;
		}
	}


#endregion
}

}
