// This class is "generated" and will be overwritten.
// Your customizations should be made in Resource_sch_projectRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Resource_sch_projectRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Resource_sch_projectTable"></see> class.
/// </remarks>
/// <seealso cref="Resource_sch_projectTable"></seealso>
/// <seealso cref="Resource_sch_projectRecord"></seealso>
public class BaseResource_sch_projectRecord : PrimaryKeyRecord
{

	public readonly static Resource_sch_projectTable TableUtils = Resource_sch_projectTable.Instance;

	// Constructors
 
	protected BaseResource_sch_projectRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Resource_sch_projectRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Resource_sch_projectRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Resource_sch_projectRecord_ReadRecord); 
	}

	protected BaseResource_sch_projectRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Resource_sch_projectRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Resource_sch_projectRecord Resource_sch_projectRec = (Resource_sch_projectRecord)sender;
        if(Resource_sch_projectRec != null && !Resource_sch_projectRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Resource_sch_projectRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Resource_sch_projectRecord Resource_sch_projectRec = (Resource_sch_projectRecord)sender;
        Validate_Inserting();
        if(Resource_sch_projectRec != null && !Resource_sch_projectRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Resource_sch_projectRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Resource_sch_projectRecord Resource_sch_projectRec = (Resource_sch_projectRecord)sender;
        Validate_Updating();
        if(Resource_sch_projectRec != null && !Resource_sch_projectRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_id field.
	/// </summary>
	public ColumnValue Getresource_sch_project_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_id field.
	/// </summary>
	public Int32 Getresource_sch_project_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_name field.
	/// </summary>
	public ColumnValue Getresource_sch_project_nameValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_name field.
	/// </summary>
	public string Getresource_sch_project_nameFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_name field.
	/// </summary>
	public void Setresource_sch_project_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_project_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_name field.
	/// </summary>
	public void Setresource_sch_project_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_custno field.
	/// </summary>
	public ColumnValue Getresource_sch_project_custnoValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_custno field.
	/// </summary>
	public Int32 Getresource_sch_project_custnoFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_custno field.
	/// </summary>
	public void Setresource_sch_project_custnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_project_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_custno field.
	/// </summary>
	public void Setresource_sch_project_custnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_project_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_custno field.
	/// </summary>
	public void Setresource_sch_project_custnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_custno field.
	/// </summary>
	public void Setresource_sch_project_custnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_custno field.
	/// </summary>
	public void Setresource_sch_project_custnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_active field.
	/// </summary>
	public ColumnValue Getresource_sch_project_activeValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_active field.
	/// </summary>
	public bool Getresource_sch_project_activeFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_active field.
	/// </summary>
	public void Setresource_sch_project_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_project_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_active field.
	/// </summary>
	public void Setresource_sch_project_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_project_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_active field.
	/// </summary>
	public void Setresource_sch_project_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_status_id field.
	/// </summary>
	public ColumnValue Getresource_sch_project_status_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_status_id field.
	/// </summary>
	public Int32 Getresource_sch_project_status_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_status_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_status_id field.
	/// </summary>
	public void Setresource_sch_project_status_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_status_id field.
	/// </summary>
	public void Setresource_sch_project_status_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_status_id field.
	/// </summary>
	public void Setresource_sch_project_status_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_status_id field.
	/// </summary>
	public void Setresource_sch_project_status_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_status_id field.
	/// </summary>
	public void Setresource_sch_project_status_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_status_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_id field.
	/// </summary>
	public string resource_sch_project_idDefault
	{
		get
		{
			return TableUtils.resource_sch_project_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_name field.
	/// </summary>
	public string resource_sch_project_name
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_project_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_project_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_project_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_project_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_name field.
	/// </summary>
	public string resource_sch_project_nameDefault
	{
		get
		{
			return TableUtils.resource_sch_project_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_custno field.
	/// </summary>
	public Int32 resource_sch_project_custno
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_project_custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_project_custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_project_custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_project_custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_custno field.
	/// </summary>
	public string resource_sch_project_custnoDefault
	{
		get
		{
			return TableUtils.resource_sch_project_custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_active field.
	/// </summary>
	public bool resource_sch_project_active
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_project_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.resource_sch_project_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_project_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_project_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_active field.
	/// </summary>
	public string resource_sch_project_activeDefault
	{
		get
		{
			return TableUtils.resource_sch_project_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_.resource_sch_project_status_id field.
	/// </summary>
	public Int32 resource_sch_project_status_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_project_status_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_project_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_project_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_project_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.resource_sch_project_status_id field.
	/// </summary>
	public string resource_sch_project_status_idDefault
	{
		get
		{
			return TableUtils.resource_sch_project_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_.created_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_.created_datetime field.
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
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_.created_datetime field.
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
