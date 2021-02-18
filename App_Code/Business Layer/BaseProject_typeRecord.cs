// This class is "generated" and will be overwritten.
// Your customizations should be made in Project_typeRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Project_typeRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Project_typeTable"></see> class.
/// </remarks>
/// <seealso cref="Project_typeTable"></seealso>
/// <seealso cref="Project_typeRecord"></seealso>
public class BaseProject_typeRecord : PrimaryKeyRecord
{

	public readonly static Project_typeTable TableUtils = Project_typeTable.Instance;

	// Constructors
 
	protected BaseProject_typeRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Project_typeRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Project_typeRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Project_typeRecord_ReadRecord); 
	}

	protected BaseProject_typeRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Project_typeRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Project_typeRecord Project_typeRec = (Project_typeRecord)sender;
        if(Project_typeRec != null && !Project_typeRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Project_typeRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Project_typeRecord Project_typeRec = (Project_typeRecord)sender;
        Validate_Inserting();
        if(Project_typeRec != null && !Project_typeRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Project_typeRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Project_typeRecord Project_typeRec = (Project_typeRecord)sender;
        Validate_Updating();
        if(Project_typeRec != null && !Project_typeRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's project_type_.project_type_id field.
	/// </summary>
	public ColumnValue Getproject_type_idValue()
	{
		return this.GetValue(TableUtils.project_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_type_.project_type_id field.
	/// </summary>
	public Int32 Getproject_type_idFieldValue()
	{
		return this.GetValue(TableUtils.project_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_type_.project_type field.
	/// </summary>
	public ColumnValue Getproject_typeValue()
	{
		return this.GetValue(TableUtils.project_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_type_.project_type field.
	/// </summary>
	public string Getproject_typeFieldValue()
	{
		return this.GetValue(TableUtils.project_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_type_.project_type field.
	/// </summary>
	public void Setproject_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_type_.project_type field.
	/// </summary>
	public void Setproject_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_type_.project_type_active field.
	/// </summary>
	public ColumnValue Getproject_type_activeValue()
	{
		return this.GetValue(TableUtils.project_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's project_type_.project_type_active field.
	/// </summary>
	public bool Getproject_type_activeFieldValue()
	{
		return this.GetValue(TableUtils.project_type_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_type_.project_type_active field.
	/// </summary>
	public void Setproject_type_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.project_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_type_.project_type_active field.
	/// </summary>
	public void Setproject_type_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.project_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_type_.project_type_active field.
	/// </summary>
	public void Setproject_type_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.project_type_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_type_.project_type_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's project_type_.project_type_id field.
	/// </summary>
	public string project_type_idDefault
	{
		get
		{
			return TableUtils.project_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_type_.project_type field.
	/// </summary>
	public string project_type
	{
		get
		{
			return this.GetValue(TableUtils.project_typeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.project_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_type_.project_type field.
	/// </summary>
	public string project_typeDefault
	{
		get
		{
			return TableUtils.project_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's project_type_.project_type_active field.
	/// </summary>
	public bool project_type_active
	{
		get
		{
			return this.GetValue(TableUtils.project_type_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.project_type_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool project_type_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.project_type_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's project_type_.project_type_active field.
	/// </summary>
	public string project_type_activeDefault
	{
		get
		{
			return TableUtils.project_type_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
