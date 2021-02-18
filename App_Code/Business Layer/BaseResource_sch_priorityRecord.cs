// This class is "generated" and will be overwritten.
// Your customizations should be made in Resource_sch_priorityRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Resource_sch_priorityRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Resource_sch_priorityTable"></see> class.
/// </remarks>
/// <seealso cref="Resource_sch_priorityTable"></seealso>
/// <seealso cref="Resource_sch_priorityRecord"></seealso>
public class BaseResource_sch_priorityRecord : PrimaryKeyRecord
{

	public readonly static Resource_sch_priorityTable TableUtils = Resource_sch_priorityTable.Instance;

	// Constructors
 
	protected BaseResource_sch_priorityRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Resource_sch_priorityRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Resource_sch_priorityRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Resource_sch_priorityRecord_ReadRecord); 
	}

	protected BaseResource_sch_priorityRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Resource_sch_priorityRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Resource_sch_priorityRecord Resource_sch_priorityRec = (Resource_sch_priorityRecord)sender;
        if(Resource_sch_priorityRec != null && !Resource_sch_priorityRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Resource_sch_priorityRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Resource_sch_priorityRecord Resource_sch_priorityRec = (Resource_sch_priorityRecord)sender;
        Validate_Inserting();
        if(Resource_sch_priorityRec != null && !Resource_sch_priorityRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Resource_sch_priorityRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Resource_sch_priorityRecord Resource_sch_priorityRec = (Resource_sch_priorityRecord)sender;
        Validate_Updating();
        if(Resource_sch_priorityRec != null && !Resource_sch_priorityRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_priority_.resource_sch_priority_id field.
	/// </summary>
	public ColumnValue Getresource_sch_priority_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_priority_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_priority_.resource_sch_priority_id field.
	/// </summary>
	public Int32 Getresource_sch_priority_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_priority_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_priority_.resource_sch_priority field.
	/// </summary>
	public ColumnValue Getresource_sch_priorityValue()
	{
		return this.GetValue(TableUtils.resource_sch_priorityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_priority_.resource_sch_priority field.
	/// </summary>
	public string Getresource_sch_priorityFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_priorityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_priority_.resource_sch_priority field.
	/// </summary>
	public void Setresource_sch_priorityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_priorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_priority_.resource_sch_priority field.
	/// </summary>
	public void Setresource_sch_priorityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_priorityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_priority_.resource_sch_priority_active field.
	/// </summary>
	public ColumnValue Getresource_sch_priority_activeValue()
	{
		return this.GetValue(TableUtils.resource_sch_priority_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_priority_.resource_sch_priority_active field.
	/// </summary>
	public bool Getresource_sch_priority_activeFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_priority_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_priority_.resource_sch_priority_active field.
	/// </summary>
	public void Setresource_sch_priority_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_priority_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_priority_.resource_sch_priority_active field.
	/// </summary>
	public void Setresource_sch_priority_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_priority_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_priority_.resource_sch_priority_active field.
	/// </summary>
	public void Setresource_sch_priority_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_priority_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_priority_.resource_sch_priority_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_priority_.resource_sch_priority_id field.
	/// </summary>
	public string resource_sch_priority_idDefault
	{
		get
		{
			return TableUtils.resource_sch_priority_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_priority_.resource_sch_priority field.
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
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_priority_.resource_sch_priority field.
	/// </summary>
	public string resource_sch_priorityDefault
	{
		get
		{
			return TableUtils.resource_sch_priorityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_priority_.resource_sch_priority_active field.
	/// </summary>
	public bool resource_sch_priority_active
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_priority_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.resource_sch_priority_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_priority_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_priority_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_priority_.resource_sch_priority_active field.
	/// </summary>
	public string resource_sch_priority_activeDefault
	{
		get
		{
			return TableUtils.resource_sch_priority_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
