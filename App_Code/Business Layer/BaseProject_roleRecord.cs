// This class is "generated" and will be overwritten.
// Your customizations should be made in Project_roleRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Project_roleRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Project_roleTable"></see> class.
/// </remarks>
/// <seealso cref="Project_roleTable"></seealso>
/// <seealso cref="Project_roleRecord"></seealso>
public class BaseProject_roleRecord : PrimaryKeyRecord
{

	public readonly static Project_roleTable TableUtils = Project_roleTable.Instance;

	// Constructors
 
	protected BaseProject_roleRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Project_roleRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Project_roleRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Project_roleRecord_ReadRecord); 
	}

	protected BaseProject_roleRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Project_roleRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Project_roleRecord Project_roleRec = (Project_roleRecord)sender;
        if(Project_roleRec != null && !Project_roleRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Project_roleRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Project_roleRecord Project_roleRec = (Project_roleRecord)sender;
        Validate_Inserting();
        if(Project_roleRec != null && !Project_roleRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Project_roleRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Project_roleRecord Project_roleRec = (Project_roleRecord)sender;
        Validate_Updating();
        if(Project_roleRec != null && !Project_roleRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's project_role_.project_role_id field.
	/// </summary>
	public ColumnValue Getproject_role_idValue()
	{
		return this.GetValue(TableUtils.project_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_.project_role_id field.
	/// </summary>
	public Int32 Getproject_role_idFieldValue()
	{
		return this.GetValue(TableUtils.project_role_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_.project_role field.
	/// </summary>
	public ColumnValue Getproject_roleValue()
	{
		return this.GetValue(TableUtils.project_roleColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_.project_role field.
	/// </summary>
	public string Getproject_roleFieldValue()
	{
		return this.GetValue(TableUtils.project_roleColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.project_role field.
	/// </summary>
	public void Setproject_roleFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_roleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.project_role field.
	/// </summary>
	public void Setproject_roleFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_roleColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_.project_role_active field.
	/// </summary>
	public ColumnValue Getproject_role_activeValue()
	{
		return this.GetValue(TableUtils.project_role_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_.project_role_active field.
	/// </summary>
	public bool Getproject_role_activeFieldValue()
	{
		return this.GetValue(TableUtils.project_role_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.project_role_active field.
	/// </summary>
	public void Setproject_role_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_role_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.project_role_active field.
	/// </summary>
	public void Setproject_role_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_role_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.project_role_active field.
	/// </summary>
	public void Setproject_role_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_role_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_role_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_.project_role_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.project_role_id field.
	/// </summary>
	public string project_role_idDefault
	{
		get
		{
			return TableUtils.project_role_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_.project_role field.
	/// </summary>
	public string project_role
	{
		get
		{
			return this.GetValue(TableUtils.project_roleColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_roleColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_roleSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_roleColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.project_role field.
	/// </summary>
	public string project_roleDefault
	{
		get
		{
			return TableUtils.project_roleColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_.project_role_active field.
	/// </summary>
	public bool project_role_active
	{
		get
		{
			return this.GetValue(TableUtils.project_role_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.project_role_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_role_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_role_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.project_role_active field.
	/// </summary>
	public string project_role_activeDefault
	{
		get
		{
			return TableUtils.project_role_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_.created_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_role_.created_datetime field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_role_.created_datetime field.
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
