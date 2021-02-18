// This class is "generated" and will be overwritten.
// Your customizations should be made in Request_typeRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Request_typeRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Request_typeTable"></see> class.
/// </remarks>
/// <seealso cref="Request_typeTable"></seealso>
/// <seealso cref="Request_typeRecord"></seealso>
public class BaseRequest_typeRecord : PrimaryKeyRecord
{

	public readonly static Request_typeTable TableUtils = Request_typeTable.Instance;

	// Constructors
 
	protected BaseRequest_typeRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Request_typeRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Request_typeRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Request_typeRecord_ReadRecord); 
	}

	protected BaseRequest_typeRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Request_typeRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Request_typeRecord Request_typeRec = (Request_typeRecord)sender;
        if(Request_typeRec != null && !Request_typeRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Request_typeRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Request_typeRecord Request_typeRec = (Request_typeRecord)sender;
        Validate_Inserting();
        if(Request_typeRec != null && !Request_typeRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Request_typeRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Request_typeRecord Request_typeRec = (Request_typeRecord)sender;
        Validate_Updating();
        if(Request_typeRec != null && !Request_typeRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's request_type_.request_type_id field.
	/// </summary>
	public ColumnValue Getrequest_type_idValue()
	{
		return this.GetValue(TableUtils.request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's request_type_.request_type_id field.
	/// </summary>
	public Int32 Getrequest_type_idFieldValue()
	{
		return this.GetValue(TableUtils.request_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's request_type_.request_type field.
	/// </summary>
	public ColumnValue Getrequest_typeValue()
	{
		return this.GetValue(TableUtils.request_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's request_type_.request_type field.
	/// </summary>
	public string Getrequest_typeFieldValue()
	{
		return this.GetValue(TableUtils.request_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's request_type_.request_type field.
	/// </summary>
	public void Setrequest_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.request_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's request_type_.request_type field.
	/// </summary>
	public void Setrequest_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's request_type_.request_active field.
	/// </summary>
	public ColumnValue Getrequest_activeValue()
	{
		return this.GetValue(TableUtils.request_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's request_type_.request_active field.
	/// </summary>
	public bool Getrequest_activeFieldValue()
	{
		return this.GetValue(TableUtils.request_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's request_type_.request_active field.
	/// </summary>
	public void Setrequest_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.request_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's request_type_.request_active field.
	/// </summary>
	public void Setrequest_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.request_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's request_type_.request_active field.
	/// </summary>
	public void Setrequest_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's request_type_.request_type_id field.
	/// </summary>
	public Int32 request_type_id
	{
		get
		{
			return this.GetValue(TableUtils.request_type_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.request_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool request_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.request_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's request_type_.request_type_id field.
	/// </summary>
	public string request_type_idDefault
	{
		get
		{
			return TableUtils.request_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's request_type_.request_type field.
	/// </summary>
	public string request_type
	{
		get
		{
			return this.GetValue(TableUtils.request_typeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.request_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool request_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.request_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's request_type_.request_type field.
	/// </summary>
	public string request_typeDefault
	{
		get
		{
			return TableUtils.request_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's request_type_.request_active field.
	/// </summary>
	public bool request_active
	{
		get
		{
			return this.GetValue(TableUtils.request_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.request_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool request_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.request_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's request_type_.request_active field.
	/// </summary>
	public string request_activeDefault
	{
		get
		{
			return TableUtils.request_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
