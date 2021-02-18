// This class is "generated" and will be overwritten.
// Your customizations should be made in Customer_typeRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Customer_typeRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Customer_typeTable"></see> class.
/// </remarks>
/// <seealso cref="Customer_typeTable"></seealso>
/// <seealso cref="Customer_typeRecord"></seealso>
public class BaseCustomer_typeRecord : PrimaryKeyRecord
{

	public readonly static Customer_typeTable TableUtils = Customer_typeTable.Instance;

	// Constructors
 
	protected BaseCustomer_typeRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Customer_typeRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Customer_typeRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Customer_typeRecord_ReadRecord); 
	}

	protected BaseCustomer_typeRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Customer_typeRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Customer_typeRecord Customer_typeRec = (Customer_typeRecord)sender;
        if(Customer_typeRec != null && !Customer_typeRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Customer_typeRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Customer_typeRecord Customer_typeRec = (Customer_typeRecord)sender;
        Validate_Inserting();
        if(Customer_typeRec != null && !Customer_typeRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Customer_typeRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Customer_typeRecord Customer_typeRec = (Customer_typeRecord)sender;
        Validate_Updating();
        if(Customer_typeRec != null && !Customer_typeRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's customer_type_.customer_type_id field.
	/// </summary>
	public ColumnValue Getcustomer_type_idValue()
	{
		return this.GetValue(TableUtils.customer_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_type_.customer_type_id field.
	/// </summary>
	public Int32 Getcustomer_type_idFieldValue()
	{
		return this.GetValue(TableUtils.customer_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_type_.customer_type field.
	/// </summary>
	public ColumnValue Getcustomer_typeValue()
	{
		return this.GetValue(TableUtils.customer_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_type_.customer_type field.
	/// </summary>
	public string Getcustomer_typeFieldValue()
	{
		return this.GetValue(TableUtils.customer_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_type_.customer_type field.
	/// </summary>
	public void Setcustomer_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_type_.customer_type field.
	/// </summary>
	public void Setcustomer_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_type_.customer_type_active field.
	/// </summary>
	public ColumnValue Getcustomer_type_activeValue()
	{
		return this.GetValue(TableUtils.customer_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_type_.customer_type_active field.
	/// </summary>
	public bool Getcustomer_type_activeFieldValue()
	{
		return this.GetValue(TableUtils.customer_type_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_type_.customer_type_active field.
	/// </summary>
	public void Setcustomer_type_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_type_.customer_type_active field.
	/// </summary>
	public void Setcustomer_type_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_type_.customer_type_active field.
	/// </summary>
	public void Setcustomer_type_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_type_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_type_.customer_type_id field.
	/// </summary>
	public Int32 customer_type_id
	{
		get
		{
			return this.GetValue(TableUtils.customer_type_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_type_.customer_type_id field.
	/// </summary>
	public string customer_type_idDefault
	{
		get
		{
			return TableUtils.customer_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_type_.customer_type field.
	/// </summary>
	public string customer_type
	{
		get
		{
			return this.GetValue(TableUtils.customer_typeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_type_.customer_type field.
	/// </summary>
	public string customer_typeDefault
	{
		get
		{
			return TableUtils.customer_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_type_.customer_type_active field.
	/// </summary>
	public bool customer_type_active
	{
		get
		{
			return this.GetValue(TableUtils.customer_type_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_type_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_type_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_type_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_type_.customer_type_active field.
	/// </summary>
	public string customer_type_activeDefault
	{
		get
		{
			return TableUtils.customer_type_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
