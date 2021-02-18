// This class is "generated" and will be overwritten.
// Your customizations should be made in Pickup_request_commentRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Pickup_request_commentRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Pickup_request_commentTable"></see> class.
/// </remarks>
/// <seealso cref="Pickup_request_commentTable"></seealso>
/// <seealso cref="Pickup_request_commentRecord"></seealso>
public class BasePickup_request_commentRecord : PrimaryKeyRecord
{

	public readonly static Pickup_request_commentTable TableUtils = Pickup_request_commentTable.Instance;

	// Constructors
 
	protected BasePickup_request_commentRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Pickup_request_commentRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Pickup_request_commentRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Pickup_request_commentRecord_ReadRecord); 
	}

	protected BasePickup_request_commentRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Pickup_request_commentRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Pickup_request_commentRecord Pickup_request_commentRec = (Pickup_request_commentRecord)sender;
        if(Pickup_request_commentRec != null && !Pickup_request_commentRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Pickup_request_commentRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Pickup_request_commentRecord Pickup_request_commentRec = (Pickup_request_commentRecord)sender;
        Validate_Inserting();
        if(Pickup_request_commentRec != null && !Pickup_request_commentRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Pickup_request_commentRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Pickup_request_commentRecord Pickup_request_commentRec = (Pickup_request_commentRecord)sender;
        Validate_Updating();
        if(Pickup_request_commentRec != null && !Pickup_request_commentRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment_id field.
	/// </summary>
	public ColumnValue Getpickup_request_comment_idValue()
	{
		return this.GetValue(TableUtils.pickup_request_comment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment_id field.
	/// </summary>
	public Int32 Getpickup_request_comment_idFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_comment_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment field.
	/// </summary>
	public ColumnValue Getpickup_request_commentValue()
	{
		return this.GetValue(TableUtils.pickup_request_commentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment field.
	/// </summary>
	public string Getpickup_request_commentFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_commentColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment field.
	/// </summary>
	public void Setpickup_request_commentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_request_commentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment field.
	/// </summary>
	public void Setpickup_request_commentFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_commentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_private field.
	/// </summary>
	public ColumnValue Getpickup_request_privateValue()
	{
		return this.GetValue(TableUtils.pickup_request_privateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_private field.
	/// </summary>
	public bool Getpickup_request_privateFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_privateColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_private field.
	/// </summary>
	public void Setpickup_request_privateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_request_privateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_private field.
	/// </summary>
	public void Setpickup_request_privateFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_request_privateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_private field.
	/// </summary>
	public void Setpickup_request_privateFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_privateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment_datetime field.
	/// </summary>
	public ColumnValue Getpickup_request_comment_datetimeValue()
	{
		return this.GetValue(TableUtils.pickup_request_comment_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment_datetime field.
	/// </summary>
	public DateTime Getpickup_request_comment_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_comment_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_datetime field.
	/// </summary>
	public void Setpickup_request_comment_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_request_comment_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_datetime field.
	/// </summary>
	public void Setpickup_request_comment_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_request_comment_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_datetime field.
	/// </summary>
	public void Setpickup_request_comment_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_comment_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment_createdby field.
	/// </summary>
	public ColumnValue Getpickup_request_comment_createdbyValue()
	{
		return this.GetValue(TableUtils.pickup_request_comment_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment_createdby field.
	/// </summary>
	public Int32 Getpickup_request_comment_createdbyFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_comment_createdbyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_createdby field.
	/// </summary>
	public void Setpickup_request_comment_createdbyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_request_comment_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_createdby field.
	/// </summary>
	public void Setpickup_request_comment_createdbyFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_request_comment_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_createdby field.
	/// </summary>
	public void Setpickup_request_comment_createdbyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_comment_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_createdby field.
	/// </summary>
	public void Setpickup_request_comment_createdbyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_comment_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_createdby field.
	/// </summary>
	public void Setpickup_request_comment_createdbyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_comment_createdbyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_id field.
	/// </summary>
	public ColumnValue Getpickup_request_idValue()
	{
		return this.GetValue(TableUtils.pickup_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_comment_.pickup_request_id field.
	/// </summary>
	public Int32 Getpickup_request_idFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_id field.
	/// </summary>
	public void Setpickup_request_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_id field.
	/// </summary>
	public void Setpickup_request_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_id field.
	/// </summary>
	public void Setpickup_request_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_id field.
	/// </summary>
	public void Setpickup_request_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_id field.
	/// </summary>
	public void Setpickup_request_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment_id field.
	/// </summary>
	public Int32 pickup_request_comment_id
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_comment_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_request_comment_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_comment_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_comment_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_id field.
	/// </summary>
	public string pickup_request_comment_idDefault
	{
		get
		{
			return TableUtils.pickup_request_comment_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment field.
	/// </summary>
	public string pickup_request_comment
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_commentColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_request_commentColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_commentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_commentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment field.
	/// </summary>
	public string pickup_request_commentDefault
	{
		get
		{
			return TableUtils.pickup_request_commentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_comment_.pickup_request_private field.
	/// </summary>
	public bool pickup_request_private
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_privateColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.pickup_request_privateColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_privateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_privateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_private field.
	/// </summary>
	public string pickup_request_privateDefault
	{
		get
		{
			return TableUtils.pickup_request_privateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment_datetime field.
	/// </summary>
	public DateTime pickup_request_comment_datetime
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_comment_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_request_comment_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_comment_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_comment_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_datetime field.
	/// </summary>
	public string pickup_request_comment_datetimeDefault
	{
		get
		{
			return TableUtils.pickup_request_comment_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_comment_.pickup_request_comment_createdby field.
	/// </summary>
	public Int32 pickup_request_comment_createdby
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_comment_createdbyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_request_comment_createdbyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_comment_createdbySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_comment_createdbyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_comment_createdby field.
	/// </summary>
	public string pickup_request_comment_createdbyDefault
	{
		get
		{
			return TableUtils.pickup_request_comment_createdbyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_comment_.pickup_request_id field.
	/// </summary>
	public Int32 pickup_request_id
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_request_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_comment_.pickup_request_id field.
	/// </summary>
	public string pickup_request_idDefault
	{
		get
		{
			return TableUtils.pickup_request_idColumn.DefaultValue;
		}
	}


#endregion
}

}
