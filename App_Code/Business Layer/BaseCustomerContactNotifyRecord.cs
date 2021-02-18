// This class is "generated" and will be overwritten.
// Your customizations should be made in CustomerContactNotifyRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="CustomerContactNotifyRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="CustomerContactNotifyView"></see> class.
/// </remarks>
/// <seealso cref="CustomerContactNotifyView"></seealso>
/// <seealso cref="CustomerContactNotifyRecord"></seealso>
public class BaseCustomerContactNotifyRecord : PrimaryKeyRecord
{

	public readonly static CustomerContactNotifyView TableUtils = CustomerContactNotifyView.Instance;

	// Constructors
 
	protected BaseCustomerContactNotifyRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.CustomerContactNotifyRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.CustomerContactNotifyRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.CustomerContactNotifyRecord_ReadRecord); 
	}

	protected BaseCustomerContactNotifyRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void CustomerContactNotifyRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                CustomerContactNotifyRecord CustomerContactNotifyRec = (CustomerContactNotifyRecord)sender;
        if(CustomerContactNotifyRec != null && !CustomerContactNotifyRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void CustomerContactNotifyRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                CustomerContactNotifyRecord CustomerContactNotifyRec = (CustomerContactNotifyRecord)sender;
        Validate_Inserting();
        if(CustomerContactNotifyRec != null && !CustomerContactNotifyRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void CustomerContactNotifyRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                CustomerContactNotifyRecord CustomerContactNotifyRec = (CustomerContactNotifyRecord)sender;
        Validate_Updating();
        if(CustomerContactNotifyRec != null && !CustomerContactNotifyRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's CustomerContactNotify_.CustContactName field.
	/// </summary>
	public ColumnValue GetCustContactNameValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's CustomerContactNotify_.CustContactName field.
	/// </summary>
	public string GetCustContactNameFieldValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's CustomerContactNotify_.CustContactKey field.
	/// </summary>
	public ColumnValue GetCustContactKeyValue()
	{
		return this.GetValue(TableUtils.CustContactKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's CustomerContactNotify_.CustContactKey field.
	/// </summary>
	public Int32 GetCustContactKeyFieldValue()
	{
		return this.GetValue(TableUtils.CustContactKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's CustomerContactNotify_.CustContactEmail field.
	/// </summary>
	public ColumnValue GetCustContactEmailValue()
	{
		return this.GetValue(TableUtils.CustContactEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's CustomerContactNotify_.CustContactEmail field.
	/// </summary>
	public string GetCustContactEmailFieldValue()
	{
		return this.GetValue(TableUtils.CustContactEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustContactEmail field.
	/// </summary>
	public void SetCustContactEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustContactEmail field.
	/// </summary>
	public void SetCustContactEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's CustomerContactNotify_.CustNo field.
	/// </summary>
	public ColumnValue GetCustNoValue()
	{
		return this.GetValue(TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's CustomerContactNotify_.CustNo field.
	/// </summary>
	public Int32 GetCustNoFieldValue()
	{
		return this.GetValue(TableUtils.CustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's CustomerContactNotify_.CustContactName field.
	/// </summary>
	public string CustContactName
	{
		get
		{
			return this.GetValue(TableUtils.CustContactNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContactNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContactNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContactNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustContactName field.
	/// </summary>
	public string CustContactNameDefault
	{
		get
		{
			return TableUtils.CustContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's CustomerContactNotify_.CustContactKey field.
	/// </summary>
	public Int32 CustContactKey
	{
		get
		{
			return this.GetValue(TableUtils.CustContactKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContactKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContactKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContactKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustContactKey field.
	/// </summary>
	public string CustContactKeyDefault
	{
		get
		{
			return TableUtils.CustContactKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's CustomerContactNotify_.CustContactEmail field.
	/// </summary>
	public string CustContactEmail
	{
		get
		{
			return this.GetValue(TableUtils.CustContactEmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContactEmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContactEmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContactEmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustContactEmail field.
	/// </summary>
	public string CustContactEmailDefault
	{
		get
		{
			return TableUtils.CustContactEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's CustomerContactNotify_.CustNo field.
	/// </summary>
	public Int32 CustNo
	{
		get
		{
			return this.GetValue(TableUtils.CustNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's CustomerContactNotify_.CustNo field.
	/// </summary>
	public string CustNoDefault
	{
		get
		{
			return TableUtils.CustNoColumn.DefaultValue;
		}
	}


#endregion
}

}
