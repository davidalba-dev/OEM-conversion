// This class is "generated" and will be overwritten.
// Your customizations should be made in Payment_methodRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Payment_methodRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Payment_methodTable"></see> class.
/// </remarks>
/// <seealso cref="Payment_methodTable"></seealso>
/// <seealso cref="Payment_methodRecord"></seealso>
public class BasePayment_methodRecord : PrimaryKeyRecord
{

	public readonly static Payment_methodTable TableUtils = Payment_methodTable.Instance;

	// Constructors
 
	protected BasePayment_methodRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Payment_methodRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Payment_methodRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Payment_methodRecord_ReadRecord); 
	}

	protected BasePayment_methodRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Payment_methodRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Payment_methodRecord Payment_methodRec = (Payment_methodRecord)sender;
        if(Payment_methodRec != null && !Payment_methodRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Payment_methodRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Payment_methodRecord Payment_methodRec = (Payment_methodRecord)sender;
        Validate_Inserting();
        if(Payment_methodRec != null && !Payment_methodRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Payment_methodRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Payment_methodRecord Payment_methodRec = (Payment_methodRecord)sender;
        Validate_Updating();
        if(Payment_methodRec != null && !Payment_methodRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's payment_method_.payment_method_id field.
	/// </summary>
	public ColumnValue Getpayment_method_idValue()
	{
		return this.GetValue(TableUtils.payment_method_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's payment_method_.payment_method_id field.
	/// </summary>
	public Int32 Getpayment_method_idFieldValue()
	{
		return this.GetValue(TableUtils.payment_method_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's payment_method_.payment_method field.
	/// </summary>
	public ColumnValue Getpayment_methodValue()
	{
		return this.GetValue(TableUtils.payment_methodColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's payment_method_.payment_method field.
	/// </summary>
	public string Getpayment_methodFieldValue()
	{
		return this.GetValue(TableUtils.payment_methodColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's payment_method_.payment_method field.
	/// </summary>
	public void Setpayment_methodFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.payment_methodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's payment_method_.payment_method field.
	/// </summary>
	public void Setpayment_methodFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.payment_methodColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's payment_method_.payment_active field.
	/// </summary>
	public ColumnValue Getpayment_activeValue()
	{
		return this.GetValue(TableUtils.payment_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's payment_method_.payment_active field.
	/// </summary>
	public bool Getpayment_activeFieldValue()
	{
		return this.GetValue(TableUtils.payment_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's payment_method_.payment_active field.
	/// </summary>
	public void Setpayment_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.payment_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's payment_method_.payment_active field.
	/// </summary>
	public void Setpayment_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.payment_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's payment_method_.payment_active field.
	/// </summary>
	public void Setpayment_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.payment_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's payment_method_.payment_method_id field.
	/// </summary>
	public Int32 payment_method_id
	{
		get
		{
			return this.GetValue(TableUtils.payment_method_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.payment_method_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool payment_method_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.payment_method_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's payment_method_.payment_method_id field.
	/// </summary>
	public string payment_method_idDefault
	{
		get
		{
			return TableUtils.payment_method_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's payment_method_.payment_method field.
	/// </summary>
	public string payment_method
	{
		get
		{
			return this.GetValue(TableUtils.payment_methodColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.payment_methodColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool payment_methodSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.payment_methodColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's payment_method_.payment_method field.
	/// </summary>
	public string payment_methodDefault
	{
		get
		{
			return TableUtils.payment_methodColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's payment_method_.payment_active field.
	/// </summary>
	public bool payment_active
	{
		get
		{
			return this.GetValue(TableUtils.payment_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.payment_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool payment_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.payment_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's payment_method_.payment_active field.
	/// </summary>
	public string payment_activeDefault
	{
		get
		{
			return TableUtils.payment_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
