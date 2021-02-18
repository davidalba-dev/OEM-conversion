// This class is "generated" and will be overwritten.
// Your customizations should be made in RoleRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="RoleRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RoleTable"></see> class.
/// </remarks>
/// <seealso cref="RoleTable"></seealso>
/// <seealso cref="RoleRecord"></seealso>
public class BaseRoleRecord : PrimaryKeyRecord
{

	public readonly static RoleTable TableUtils = RoleTable.Instance;

	// Constructors
 
	protected BaseRoleRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.RoleRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.RoleRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.RoleRecord_ReadRecord); 
	}

	protected BaseRoleRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void RoleRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                RoleRecord RoleRec = (RoleRecord)sender;
        if(RoleRec != null && !RoleRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void RoleRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                RoleRecord RoleRec = (RoleRecord)sender;
        Validate_Inserting();
        if(RoleRec != null && !RoleRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void RoleRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                RoleRecord RoleRec = (RoleRecord)sender;
        Validate_Updating();
        if(RoleRec != null && !RoleRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's role_.role_id field.
	/// </summary>
	public ColumnValue Getrole_idValue()
	{
		return this.GetValue(TableUtils.role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's role_.role_id field.
	/// </summary>
	public Int32 Getrole_idFieldValue()
	{
		return this.GetValue(TableUtils.role_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's role_.role_name field.
	/// </summary>
	public ColumnValue Getrole_nameValue()
	{
		return this.GetValue(TableUtils.role_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's role_.role_name field.
	/// </summary>
	public string Getrole_nameFieldValue()
	{
		return this.GetValue(TableUtils.role_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's role_.role_name field.
	/// </summary>
	public void Setrole_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.role_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's role_.role_name field.
	/// </summary>
	public void Setrole_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.role_nameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's role_.role_id field.
	/// </summary>
	public Int32 role_id
	{
		get
		{
			return this.GetValue(TableUtils.role_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.role_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool role_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.role_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's role_.role_id field.
	/// </summary>
	public string role_idDefault
	{
		get
		{
			return TableUtils.role_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's role_.role_name field.
	/// </summary>
	public string role_name
	{
		get
		{
			return this.GetValue(TableUtils.role_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.role_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool role_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.role_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's role_.role_name field.
	/// </summary>
	public string role_nameDefault
	{
		get
		{
			return TableUtils.role_nameColumn.DefaultValue;
		}
	}


#endregion
}

}
