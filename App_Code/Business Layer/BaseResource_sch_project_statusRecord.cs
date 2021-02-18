// This class is "generated" and will be overwritten.
// Your customizations should be made in Resource_sch_project_statusRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Resource_sch_project_statusRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Resource_sch_project_statusTable"></see> class.
/// </remarks>
/// <seealso cref="Resource_sch_project_statusTable"></seealso>
/// <seealso cref="Resource_sch_project_statusRecord"></seealso>
public class BaseResource_sch_project_statusRecord : PrimaryKeyRecord
{

	public readonly static Resource_sch_project_statusTable TableUtils = Resource_sch_project_statusTable.Instance;

	// Constructors
 
	protected BaseResource_sch_project_statusRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Resource_sch_project_statusRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Resource_sch_project_statusRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Resource_sch_project_statusRecord_ReadRecord); 
	}

	protected BaseResource_sch_project_statusRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Resource_sch_project_statusRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Resource_sch_project_statusRecord Resource_sch_project_statusRec = (Resource_sch_project_statusRecord)sender;
        if(Resource_sch_project_statusRec != null && !Resource_sch_project_statusRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Resource_sch_project_statusRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Resource_sch_project_statusRecord Resource_sch_project_statusRec = (Resource_sch_project_statusRecord)sender;
        Validate_Inserting();
        if(Resource_sch_project_statusRec != null && !Resource_sch_project_statusRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Resource_sch_project_statusRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Resource_sch_project_statusRecord Resource_sch_project_statusRec = (Resource_sch_project_statusRecord)sender;
        Validate_Updating();
        if(Resource_sch_project_statusRec != null && !Resource_sch_project_statusRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_status_.resource_sch_project_status_id field.
	/// </summary>
	public ColumnValue Getresource_sch_project_status_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_status_.resource_sch_project_status_id field.
	/// </summary>
	public Int32 Getresource_sch_project_status_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_status_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_status_.resource_sch_project_status field.
	/// </summary>
	public ColumnValue Getresource_sch_project_statusValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_status_.resource_sch_project_status field.
	/// </summary>
	public string Getresource_sch_project_statusFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_statusColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_status_.resource_sch_project_status field.
	/// </summary>
	public void Setresource_sch_project_statusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_project_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_status_.resource_sch_project_status field.
	/// </summary>
	public void Setresource_sch_project_statusFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_statusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_status_.resource_sch_project_status_active field.
	/// </summary>
	public ColumnValue Getresource_sch_project_status_activeValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_project_status_.resource_sch_project_status_active field.
	/// </summary>
	public bool Getresource_sch_project_status_activeFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_project_status_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_status_.resource_sch_project_status_active field.
	/// </summary>
	public void Setresource_sch_project_status_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_project_status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_status_.resource_sch_project_status_active field.
	/// </summary>
	public void Setresource_sch_project_status_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_project_status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_status_.resource_sch_project_status_active field.
	/// </summary>
	public void Setresource_sch_project_status_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_project_status_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_status_.resource_sch_project_status_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_status_.resource_sch_project_status_id field.
	/// </summary>
	public string resource_sch_project_status_idDefault
	{
		get
		{
			return TableUtils.resource_sch_project_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_status_.resource_sch_project_status field.
	/// </summary>
	public string resource_sch_project_status
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_project_statusColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_project_statusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_project_statusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_project_statusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_status_.resource_sch_project_status field.
	/// </summary>
	public string resource_sch_project_statusDefault
	{
		get
		{
			return TableUtils.resource_sch_project_statusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_project_status_.resource_sch_project_status_active field.
	/// </summary>
	public bool resource_sch_project_status_active
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_project_status_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.resource_sch_project_status_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_project_status_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_project_status_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_project_status_.resource_sch_project_status_active field.
	/// </summary>
	public string resource_sch_project_status_activeDefault
	{
		get
		{
			return TableUtils.resource_sch_project_status_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
