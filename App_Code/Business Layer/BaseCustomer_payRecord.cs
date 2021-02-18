// This class is "generated" and will be overwritten.
// Your customizations should be made in Customer_payRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Customer_payRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Customer_payTable"></see> class.
/// </remarks>
/// <seealso cref="Customer_payTable"></seealso>
/// <seealso cref="Customer_payRecord"></seealso>
public class BaseCustomer_payRecord : PrimaryKeyRecord
{

	public readonly static Customer_payTable TableUtils = Customer_payTable.Instance;

	// Constructors
 
	protected BaseCustomer_payRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Customer_payRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Customer_payRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Customer_payRecord_ReadRecord); 
	}

	protected BaseCustomer_payRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Customer_payRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Customer_payRecord Customer_payRec = (Customer_payRecord)sender;
        if(Customer_payRec != null && !Customer_payRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Customer_payRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Customer_payRecord Customer_payRec = (Customer_payRecord)sender;
        Validate_Inserting();
        if(Customer_payRec != null && !Customer_payRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Customer_payRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Customer_payRecord Customer_payRec = (Customer_payRecord)sender;
        Validate_Updating();
        if(Customer_payRec != null && !Customer_payRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's customer_pay_.customer_pay_id field.
	/// </summary>
	public ColumnValue Getcustomer_pay_idValue()
	{
		return this.GetValue(TableUtils.customer_pay_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_pay_.customer_pay_id field.
	/// </summary>
	public Int32 Getcustomer_pay_idFieldValue()
	{
		return this.GetValue(TableUtils.customer_pay_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_pay_.payment_id field.
	/// </summary>
	public ColumnValue Getpayment_idValue()
	{
		return this.GetValue(TableUtils.payment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_pay_.payment_id field.
	/// </summary>
	public Int32 Getpayment_idFieldValue()
	{
		return this.GetValue(TableUtils.payment_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.payment_id field.
	/// </summary>
	public void Setpayment_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.payment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.payment_id field.
	/// </summary>
	public void Setpayment_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.payment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.payment_id field.
	/// </summary>
	public void Setpayment_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.payment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.payment_id field.
	/// </summary>
	public void Setpayment_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.payment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.payment_id field.
	/// </summary>
	public void Setpayment_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.payment_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_pay_.customer_id field.
	/// </summary>
	public ColumnValue Getcustomer_idValue()
	{
		return this.GetValue(TableUtils.customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_pay_.customer_id field.
	/// </summary>
	public Int32 Getcustomer_idFieldValue()
	{
		return this.GetValue(TableUtils.customer_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_id field.
	/// </summary>
	public void Setcustomer_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_id field.
	/// </summary>
	public void Setcustomer_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_id field.
	/// </summary>
	public void Setcustomer_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_id field.
	/// </summary>
	public void Setcustomer_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_id field.
	/// </summary>
	public void Setcustomer_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_pay_.customer_pay_active field.
	/// </summary>
	public ColumnValue Getcustomer_pay_activeValue()
	{
		return this.GetValue(TableUtils.customer_pay_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customer_pay_.customer_pay_active field.
	/// </summary>
	public bool Getcustomer_pay_activeFieldValue()
	{
		return this.GetValue(TableUtils.customer_pay_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_pay_active field.
	/// </summary>
	public void Setcustomer_pay_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_pay_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_pay_active field.
	/// </summary>
	public void Setcustomer_pay_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_pay_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_pay_active field.
	/// </summary>
	public void Setcustomer_pay_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_pay_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_pay_.customer_pay_id field.
	/// </summary>
	public Int32 customer_pay_id
	{
		get
		{
			return this.GetValue(TableUtils.customer_pay_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_pay_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_pay_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_pay_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_pay_id field.
	/// </summary>
	public string customer_pay_idDefault
	{
		get
		{
			return TableUtils.customer_pay_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_pay_.payment_id field.
	/// </summary>
	public Int32 payment_id
	{
		get
		{
			return this.GetValue(TableUtils.payment_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.payment_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool payment_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.payment_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.payment_id field.
	/// </summary>
	public string payment_idDefault
	{
		get
		{
			return TableUtils.payment_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_pay_.customer_id field.
	/// </summary>
	public Int32 customer_id
	{
		get
		{
			return this.GetValue(TableUtils.customer_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_id field.
	/// </summary>
	public string customer_idDefault
	{
		get
		{
			return TableUtils.customer_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customer_pay_.customer_pay_active field.
	/// </summary>
	public bool customer_pay_active
	{
		get
		{
			return this.GetValue(TableUtils.customer_pay_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_pay_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_pay_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_pay_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customer_pay_.customer_pay_active field.
	/// </summary>
	public string customer_pay_activeDefault
	{
		get
		{
			return TableUtils.customer_pay_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
