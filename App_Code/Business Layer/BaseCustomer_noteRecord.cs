// This class is "generated" and will be overwritten.
// Your customizations should be made in Customer_noteRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Customer_noteRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Customer_noteTable"></see> class.
/// </remarks>
/// <seealso cref="Customer_noteTable"></seealso>
/// <seealso cref="Customer_noteRecord"></seealso>
public class BaseCustomer_noteRecord : PrimaryKeyRecord
{

	public readonly static Customer_noteTable TableUtils = Customer_noteTable.Instance;

	// Constructors
 
	protected BaseCustomer_noteRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Customer_noteRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Customer_noteRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Customer_noteRecord_ReadRecord); 
	}

	protected BaseCustomer_noteRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Customer_noteRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Customer_noteRecord Customer_noteRec = (Customer_noteRecord)sender;
        if(Customer_noteRec != null && !Customer_noteRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Customer_noteRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Customer_noteRecord Customer_noteRec = (Customer_noteRecord)sender;
        Validate_Inserting();
        if(Customer_noteRec != null && !Customer_noteRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Customer_noteRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Customer_noteRecord Customer_noteRec = (Customer_noteRecord)sender;
        Validate_Updating();
        if(Customer_noteRec != null && !Customer_noteRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.customer_note_id field.
	/// </summary>
	public ColumnValue Getcustomer_note_idValue()
	{
		return this.GetValue(TableUtils.customer_note_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.customer_note_id field.
	/// </summary>
	public Int32 Getcustomer_note_idFieldValue()
	{
		return this.GetValue(TableUtils.customer_note_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.customer_note field.
	/// </summary>
	public ColumnValue Getcustomer_noteValue()
	{
		return this.GetValue(TableUtils.customer_noteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.customer_note field.
	/// </summary>
	public string Getcustomer_noteFieldValue()
	{
		return this.GetValue(TableUtils.customer_noteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note field.
	/// </summary>
	public void Setcustomer_noteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_noteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note field.
	/// </summary>
	public void Setcustomer_noteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_noteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.customer_note_date field.
	/// </summary>
	public ColumnValue Getcustomer_note_dateValue()
	{
		return this.GetValue(TableUtils.customer_note_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.customer_note_date field.
	/// </summary>
	public DateTime Getcustomer_note_dateFieldValue()
	{
		return this.GetValue(TableUtils.customer_note_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_date field.
	/// </summary>
	public void Setcustomer_note_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_note_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_date field.
	/// </summary>
	public void Setcustomer_note_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_note_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_date field.
	/// </summary>
	public void Setcustomer_note_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_note_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.customer_note_createdby field.
	/// </summary>
	public ColumnValue Getcustomer_note_createdbyValue()
	{
		return this.GetValue(TableUtils.customer_note_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_note_.customer_note_createdby field.
	/// </summary>
	public Int32 Getcustomer_note_createdbyFieldValue()
	{
		return this.GetValue(TableUtils.customer_note_createdbyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_createdby field.
	/// </summary>
	public void Setcustomer_note_createdbyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_note_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_createdby field.
	/// </summary>
	public void Setcustomer_note_createdbyFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_note_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_createdby field.
	/// </summary>
	public void Setcustomer_note_createdbyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_note_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_createdby field.
	/// </summary>
	public void Setcustomer_note_createdbyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_note_createdbyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_createdby field.
	/// </summary>
	public void Setcustomer_note_createdbyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_note_createdbyColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_note_.customer_note_id field.
	/// </summary>
	public Int32 customer_note_id
	{
		get
		{
			return this.GetValue(TableUtils.customer_note_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_note_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_note_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_note_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_id field.
	/// </summary>
	public string customer_note_idDefault
	{
		get
		{
			return TableUtils.customer_note_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_note_.custno field.
	/// </summary>
	public Int32 custno
	{
		get
		{
			return this.GetValue(TableUtils.custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_note_.customer_note field.
	/// </summary>
	public string customer_note
	{
		get
		{
			return this.GetValue(TableUtils.customer_noteColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_noteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_noteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_noteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note field.
	/// </summary>
	public string customer_noteDefault
	{
		get
		{
			return TableUtils.customer_noteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_note_.customer_note_date field.
	/// </summary>
	public DateTime customer_note_date
	{
		get
		{
			return this.GetValue(TableUtils.customer_note_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_note_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_note_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_note_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_date field.
	/// </summary>
	public string customer_note_dateDefault
	{
		get
		{
			return TableUtils.customer_note_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_note_.customer_note_createdby field.
	/// </summary>
	public Int32 customer_note_createdby
	{
		get
		{
			return this.GetValue(TableUtils.customer_note_createdbyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_note_createdbyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_note_createdbySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_note_createdbyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_note_.customer_note_createdby field.
	/// </summary>
	public string customer_note_createdbyDefault
	{
		get
		{
			return TableUtils.customer_note_createdbyColumn.DefaultValue;
		}
	}


#endregion
}

}
