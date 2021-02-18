// This class is "generated" and will be overwritten.
// Your customizations should be made in CustomersRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="CustomersRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="CustomersTable"></see> class.
/// </remarks>
/// <seealso cref="CustomersTable"></seealso>
/// <seealso cref="CustomersRecord"></seealso>
public class BaseCustomersRecord : PrimaryKeyRecord
{

	public readonly static CustomersTable TableUtils = CustomersTable.Instance;

	// Constructors
 
	protected BaseCustomersRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.CustomersRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.CustomersRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.CustomersRecord_ReadRecord); 
	}

	protected BaseCustomersRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void CustomersRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                CustomersRecord CustomersRec = (CustomersRecord)sender;
        if(CustomersRec != null && !CustomersRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void CustomersRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                CustomersRecord CustomersRec = (CustomersRecord)sender;
        Validate_Inserting();
        if(CustomersRec != null && !CustomersRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void CustomersRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                CustomersRecord CustomersRec = (CustomersRecord)sender;
        Validate_Updating();
        if(CustomersRec != null && !CustomersRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustAddress1 field.
	/// </summary>
	public ColumnValue GetCustAddress1Value()
	{
		return this.GetValue(TableUtils.CustAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustAddress1 field.
	/// </summary>
	public string GetCustAddress1FieldValue()
	{
		return this.GetValue(TableUtils.CustAddress1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAddress1 field.
	/// </summary>
	public void SetCustAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAddress1 field.
	/// </summary>
	public void SetCustAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustAddress1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustAddress2 field.
	/// </summary>
	public ColumnValue GetCustAddress2Value()
	{
		return this.GetValue(TableUtils.CustAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustAddress2 field.
	/// </summary>
	public string GetCustAddress2FieldValue()
	{
		return this.GetValue(TableUtils.CustAddress2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAddress2 field.
	/// </summary>
	public void SetCustAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAddress2 field.
	/// </summary>
	public void SetCustAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustAddress2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustAdvertising field.
	/// </summary>
	public ColumnValue GetCustAdvertisingValue()
	{
		return this.GetValue(TableUtils.CustAdvertisingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustAdvertising field.
	/// </summary>
	public string GetCustAdvertisingFieldValue()
	{
		return this.GetValue(TableUtils.CustAdvertisingColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAdvertising field.
	/// </summary>
	public void SetCustAdvertisingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustAdvertisingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAdvertising field.
	/// </summary>
	public void SetCustAdvertisingFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustAdvertisingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustAllowBilling field.
	/// </summary>
	public ColumnValue GetCustAllowBillingValue()
	{
		return this.GetValue(TableUtils.CustAllowBillingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustAllowBilling field.
	/// </summary>
	public bool GetCustAllowBillingFieldValue()
	{
		return this.GetValue(TableUtils.CustAllowBillingColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAllowBilling field.
	/// </summary>
	public void SetCustAllowBillingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustAllowBillingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAllowBilling field.
	/// </summary>
	public void SetCustAllowBillingFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustAllowBillingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAllowBilling field.
	/// </summary>
	public void SetCustAllowBillingFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustAllowBillingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustBillingNo field.
	/// </summary>
	public ColumnValue GetCustBillingNoValue()
	{
		return this.GetValue(TableUtils.CustBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustBillingNo field.
	/// </summary>
	public Int32 GetCustBillingNoFieldValue()
	{
		return this.GetValue(TableUtils.CustBillingNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustBillingNo field.
	/// </summary>
	public void SetCustBillingNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustBillingNo field.
	/// </summary>
	public void SetCustBillingNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustBillingNo field.
	/// </summary>
	public void SetCustBillingNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustBillingNo field.
	/// </summary>
	public void SetCustBillingNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustBillingNo field.
	/// </summary>
	public void SetCustBillingNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustBillingNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCity field.
	/// </summary>
	public ColumnValue GetCustCityValue()
	{
		return this.GetValue(TableUtils.CustCityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCity field.
	/// </summary>
	public string GetCustCityFieldValue()
	{
		return this.GetValue(TableUtils.CustCityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCity field.
	/// </summary>
	public void SetCustCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCity field.
	/// </summary>
	public void SetCustCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCode field.
	/// </summary>
	public ColumnValue GetCustCodeValue()
	{
		return this.GetValue(TableUtils.CustCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCode field.
	/// </summary>
	public string GetCustCodeFieldValue()
	{
		return this.GetValue(TableUtils.CustCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCode field.
	/// </summary>
	public void SetCustCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCode field.
	/// </summary>
	public void SetCustCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustContactName field.
	/// </summary>
	public ColumnValue GetCustContactNameValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustContactName field.
	/// </summary>
	public string GetCustContactNameFieldValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustContract field.
	/// </summary>
	public ColumnValue GetCustContractValue()
	{
		return this.GetValue(TableUtils.CustContractColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustContract field.
	/// </summary>
	public string GetCustContractFieldValue()
	{
		return this.GetValue(TableUtils.CustContractColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustContract field.
	/// </summary>
	public void SetCustContractFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContractColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustContract field.
	/// </summary>
	public void SetCustContractFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContractColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCopyPrivateNotes field.
	/// </summary>
	public ColumnValue GetCustCopyPrivateNotesValue()
	{
		return this.GetValue(TableUtils.CustCopyPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCopyPrivateNotes field.
	/// </summary>
	public bool GetCustCopyPrivateNotesFieldValue()
	{
		return this.GetValue(TableUtils.CustCopyPrivateNotesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCopyPrivateNotes field.
	/// </summary>
	public void SetCustCopyPrivateNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCopyPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCopyPrivateNotes field.
	/// </summary>
	public void SetCustCopyPrivateNotesFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustCopyPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCopyPrivateNotes field.
	/// </summary>
	public void SetCustCopyPrivateNotesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCopyPrivateNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCopyPublicNotes field.
	/// </summary>
	public ColumnValue GetCustCopyPublicNotesValue()
	{
		return this.GetValue(TableUtils.CustCopyPublicNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCopyPublicNotes field.
	/// </summary>
	public bool GetCustCopyPublicNotesFieldValue()
	{
		return this.GetValue(TableUtils.CustCopyPublicNotesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCopyPublicNotes field.
	/// </summary>
	public void SetCustCopyPublicNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCopyPublicNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCopyPublicNotes field.
	/// </summary>
	public void SetCustCopyPublicNotesFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustCopyPublicNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCopyPublicNotes field.
	/// </summary>
	public void SetCustCopyPublicNotesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCopyPublicNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCountry field.
	/// </summary>
	public ColumnValue GetCustCountryValue()
	{
		return this.GetValue(TableUtils.CustCountryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCountry field.
	/// </summary>
	public string GetCustCountryFieldValue()
	{
		return this.GetValue(TableUtils.CustCountryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCountry field.
	/// </summary>
	public void SetCustCountryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCountryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCountry field.
	/// </summary>
	public void SetCustCountryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCountryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCreditCardName field.
	/// </summary>
	public ColumnValue GetCustCreditCardNameValue()
	{
		return this.GetValue(TableUtils.CustCreditCardNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCreditCardName field.
	/// </summary>
	public string GetCustCreditCardNameFieldValue()
	{
		return this.GetValue(TableUtils.CustCreditCardNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditCardName field.
	/// </summary>
	public void SetCustCreditCardNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCreditCardNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditCardName field.
	/// </summary>
	public void SetCustCreditCardNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCreditCardNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCreditCardNo field.
	/// </summary>
	public ColumnValue GetCustCreditCardNoValue()
	{
		return this.GetValue(TableUtils.CustCreditCardNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCreditCardNo field.
	/// </summary>
	public string GetCustCreditCardNoFieldValue()
	{
		return this.GetValue(TableUtils.CustCreditCardNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditCardNo field.
	/// </summary>
	public void SetCustCreditCardNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCreditCardNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditCardNo field.
	/// </summary>
	public void SetCustCreditCardNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCreditCardNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCreditLimit field.
	/// </summary>
	public ColumnValue GetCustCreditLimitValue()
	{
		return this.GetValue(TableUtils.CustCreditLimitColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCreditLimit field.
	/// </summary>
	public Decimal GetCustCreditLimitFieldValue()
	{
		return this.GetValue(TableUtils.CustCreditLimitColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditLimit field.
	/// </summary>
	public void SetCustCreditLimitFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCreditLimitColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditLimit field.
	/// </summary>
	public void SetCustCreditLimitFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustCreditLimitColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditLimit field.
	/// </summary>
	public void SetCustCreditLimitFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCreditLimitColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditLimit field.
	/// </summary>
	public void SetCustCreditLimitFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCreditLimitColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditLimit field.
	/// </summary>
	public void SetCustCreditLimitFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCreditLimitColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCustom1 field.
	/// </summary>
	public ColumnValue GetCustCustom1Value()
	{
		return this.GetValue(TableUtils.CustCustom1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCustom1 field.
	/// </summary>
	public string GetCustCustom1FieldValue()
	{
		return this.GetValue(TableUtils.CustCustom1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCustom1 field.
	/// </summary>
	public void SetCustCustom1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCustom1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCustom1 field.
	/// </summary>
	public void SetCustCustom1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCustom1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCustom2 field.
	/// </summary>
	public ColumnValue GetCustCustom2Value()
	{
		return this.GetValue(TableUtils.CustCustom2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustCustom2 field.
	/// </summary>
	public string GetCustCustom2FieldValue()
	{
		return this.GetValue(TableUtils.CustCustom2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCustom2 field.
	/// </summary>
	public void SetCustCustom2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCustom2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCustom2 field.
	/// </summary>
	public void SetCustCustom2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCustom2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDateRecordAdded field.
	/// </summary>
	public ColumnValue GetCustDateRecordAddedValue()
	{
		return this.GetValue(TableUtils.CustDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDateRecordAdded field.
	/// </summary>
	public DateTime GetCustDateRecordAddedFieldValue()
	{
		return this.GetValue(TableUtils.CustDateRecordAddedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDateRecordAdded field.
	/// </summary>
	public void SetCustDateRecordAddedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDateRecordAdded field.
	/// </summary>
	public void SetCustDateRecordAddedFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDateRecordAdded field.
	/// </summary>
	public void SetCustDateRecordAddedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDateRecordAddedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDateRecordUpdated field.
	/// </summary>
	public ColumnValue GetCustDateRecordUpdatedValue()
	{
		return this.GetValue(TableUtils.CustDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDateRecordUpdated field.
	/// </summary>
	public DateTime GetCustDateRecordUpdatedFieldValue()
	{
		return this.GetValue(TableUtils.CustDateRecordUpdatedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDateRecordUpdated field.
	/// </summary>
	public void SetCustDateRecordUpdatedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDateRecordUpdated field.
	/// </summary>
	public void SetCustDateRecordUpdatedFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDateRecordUpdated field.
	/// </summary>
	public void SetCustDateRecordUpdatedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDateRecordUpdatedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscHandling field.
	/// </summary>
	public ColumnValue GetCustDiscHandlingValue()
	{
		return this.GetValue(TableUtils.CustDiscHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscHandling field.
	/// </summary>
	public bool GetCustDiscHandlingFieldValue()
	{
		return this.GetValue(TableUtils.CustDiscHandlingColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscHandling field.
	/// </summary>
	public void SetCustDiscHandlingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustDiscHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscHandling field.
	/// </summary>
	public void SetCustDiscHandlingFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustDiscHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscHandling field.
	/// </summary>
	public void SetCustDiscHandlingFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDiscHandlingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscLabor field.
	/// </summary>
	public ColumnValue GetCustDiscLaborValue()
	{
		return this.GetValue(TableUtils.CustDiscLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscLabor field.
	/// </summary>
	public bool GetCustDiscLaborFieldValue()
	{
		return this.GetValue(TableUtils.CustDiscLaborColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscLabor field.
	/// </summary>
	public void SetCustDiscLaborFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustDiscLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscLabor field.
	/// </summary>
	public void SetCustDiscLaborFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustDiscLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscLabor field.
	/// </summary>
	public void SetCustDiscLaborFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDiscLaborColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscount field.
	/// </summary>
	public ColumnValue GetCustDiscountValue()
	{
		return this.GetValue(TableUtils.CustDiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscount field.
	/// </summary>
	public Single GetCustDiscountFieldValue()
	{
		return this.GetValue(TableUtils.CustDiscountColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscount field.
	/// </summary>
	public void SetCustDiscountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustDiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscount field.
	/// </summary>
	public void SetCustDiscountFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustDiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscount field.
	/// </summary>
	public void SetCustDiscountFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscount field.
	/// </summary>
	public void SetCustDiscountFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscount field.
	/// </summary>
	public void SetCustDiscountFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDiscountColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscountNoAutoCalc field.
	/// </summary>
	public ColumnValue GetCustDiscountNoAutoCalcValue()
	{
		return this.GetValue(TableUtils.CustDiscountNoAutoCalcColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscountNoAutoCalc field.
	/// </summary>
	public bool GetCustDiscountNoAutoCalcFieldValue()
	{
		return this.GetValue(TableUtils.CustDiscountNoAutoCalcColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscountNoAutoCalc field.
	/// </summary>
	public void SetCustDiscountNoAutoCalcFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustDiscountNoAutoCalcColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscountNoAutoCalc field.
	/// </summary>
	public void SetCustDiscountNoAutoCalcFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustDiscountNoAutoCalcColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscountNoAutoCalc field.
	/// </summary>
	public void SetCustDiscountNoAutoCalcFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDiscountNoAutoCalcColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscParts field.
	/// </summary>
	public ColumnValue GetCustDiscPartsValue()
	{
		return this.GetValue(TableUtils.CustDiscPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscParts field.
	/// </summary>
	public bool GetCustDiscPartsFieldValue()
	{
		return this.GetValue(TableUtils.CustDiscPartsColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscParts field.
	/// </summary>
	public void SetCustDiscPartsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustDiscPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscParts field.
	/// </summary>
	public void SetCustDiscPartsFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustDiscPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscParts field.
	/// </summary>
	public void SetCustDiscPartsFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDiscPartsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscShipping field.
	/// </summary>
	public ColumnValue GetCustDiscShippingValue()
	{
		return this.GetValue(TableUtils.CustDiscShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscShipping field.
	/// </summary>
	public bool GetCustDiscShippingFieldValue()
	{
		return this.GetValue(TableUtils.CustDiscShippingColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscShipping field.
	/// </summary>
	public void SetCustDiscShippingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustDiscShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscShipping field.
	/// </summary>
	public void SetCustDiscShippingFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustDiscShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscShipping field.
	/// </summary>
	public void SetCustDiscShippingFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDiscShippingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscTravel field.
	/// </summary>
	public ColumnValue GetCustDiscTravelValue()
	{
		return this.GetValue(TableUtils.CustDiscTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustDiscTravel field.
	/// </summary>
	public bool GetCustDiscTravelFieldValue()
	{
		return this.GetValue(TableUtils.CustDiscTravelColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscTravel field.
	/// </summary>
	public void SetCustDiscTravelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustDiscTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscTravel field.
	/// </summary>
	public void SetCustDiscTravelFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustDiscTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscTravel field.
	/// </summary>
	public void SetCustDiscTravelFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustDiscTravelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustEmail field.
	/// </summary>
	public ColumnValue GetCustEmailValue()
	{
		return this.GetValue(TableUtils.CustEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustEmail field.
	/// </summary>
	public string GetCustEmailFieldValue()
	{
		return this.GetValue(TableUtils.CustEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustEmail field.
	/// </summary>
	public void SetCustEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustEmail field.
	/// </summary>
	public void SetCustEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustEmailType field.
	/// </summary>
	public ColumnValue GetCustEmailTypeValue()
	{
		return this.GetValue(TableUtils.CustEmailTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustEmailType field.
	/// </summary>
	public Byte GetCustEmailTypeFieldValue()
	{
		return this.GetValue(TableUtils.CustEmailTypeColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustEmailType field.
	/// </summary>
	public void SetCustEmailTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustEmailTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustEmailType field.
	/// </summary>
	public void SetCustEmailTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustEmailTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustEmailType field.
	/// </summary>
	public void SetCustEmailTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustEmailTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustEmailType field.
	/// </summary>
	public void SetCustEmailTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustEmailTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustEmailType field.
	/// </summary>
	public void SetCustEmailTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustEmailTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustExportInclude field.
	/// </summary>
	public ColumnValue GetCustExportIncludeValue()
	{
		return this.GetValue(TableUtils.CustExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustExportInclude field.
	/// </summary>
	public bool GetCustExportIncludeFieldValue()
	{
		return this.GetValue(TableUtils.CustExportIncludeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustExportInclude field.
	/// </summary>
	public void SetCustExportIncludeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustExportInclude field.
	/// </summary>
	public void SetCustExportIncludeFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustExportInclude field.
	/// </summary>
	public void SetCustExportIncludeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustExportIncludeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustExportRecordChanged field.
	/// </summary>
	public ColumnValue GetCustExportRecordChangedValue()
	{
		return this.GetValue(TableUtils.CustExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustExportRecordChanged field.
	/// </summary>
	public bool GetCustExportRecordChangedFieldValue()
	{
		return this.GetValue(TableUtils.CustExportRecordChangedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustExportRecordChanged field.
	/// </summary>
	public void SetCustExportRecordChangedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustExportRecordChanged field.
	/// </summary>
	public void SetCustExportRecordChangedFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustExportRecordChanged field.
	/// </summary>
	public void SetCustExportRecordChangedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustExportRecordChangedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustFax field.
	/// </summary>
	public ColumnValue GetCustFaxValue()
	{
		return this.GetValue(TableUtils.CustFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustFax field.
	/// </summary>
	public string GetCustFaxFieldValue()
	{
		return this.GetValue(TableUtils.CustFaxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustFax field.
	/// </summary>
	public void SetCustFaxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustFax field.
	/// </summary>
	public void SetCustFaxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustFaxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustForwardBillingNotices field.
	/// </summary>
	public ColumnValue GetCustForwardBillingNoticesValue()
	{
		return this.GetValue(TableUtils.CustForwardBillingNoticesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustForwardBillingNotices field.
	/// </summary>
	public bool GetCustForwardBillingNoticesFieldValue()
	{
		return this.GetValue(TableUtils.CustForwardBillingNoticesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustForwardBillingNotices field.
	/// </summary>
	public void SetCustForwardBillingNoticesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustForwardBillingNoticesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustForwardBillingNotices field.
	/// </summary>
	public void SetCustForwardBillingNoticesFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustForwardBillingNoticesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustForwardBillingNotices field.
	/// </summary>
	public void SetCustForwardBillingNoticesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustForwardBillingNoticesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustInactive field.
	/// </summary>
	public ColumnValue GetCustInactiveValue()
	{
		return this.GetValue(TableUtils.CustInactiveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustInactive field.
	/// </summary>
	public bool GetCustInactiveFieldValue()
	{
		return this.GetValue(TableUtils.CustInactiveColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustInactive field.
	/// </summary>
	public void SetCustInactiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustInactiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustInactive field.
	/// </summary>
	public void SetCustInactiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustInactiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustInactive field.
	/// </summary>
	public void SetCustInactiveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustInactiveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustLanguage field.
	/// </summary>
	public ColumnValue GetCustLanguageValue()
	{
		return this.GetValue(TableUtils.CustLanguageColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustLanguage field.
	/// </summary>
	public string GetCustLanguageFieldValue()
	{
		return this.GetValue(TableUtils.CustLanguageColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustLanguage field.
	/// </summary>
	public void SetCustLanguageFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustLanguageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustLanguage field.
	/// </summary>
	public void SetCustLanguageFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustLanguageColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustLocationBus field.
	/// </summary>
	public ColumnValue GetCustLocationBusValue()
	{
		return this.GetValue(TableUtils.CustLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustLocationBus field.
	/// </summary>
	public Int32 GetCustLocationBusFieldValue()
	{
		return this.GetValue(TableUtils.CustLocationBusColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustLocationBus field.
	/// </summary>
	public void SetCustLocationBusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustLocationBus field.
	/// </summary>
	public void SetCustLocationBusFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustLocationBus field.
	/// </summary>
	public void SetCustLocationBusFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustLocationBus field.
	/// </summary>
	public void SetCustLocationBusFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustLocationBus field.
	/// </summary>
	public void SetCustLocationBusFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustLocationBusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustMarkupLevel field.
	/// </summary>
	public ColumnValue GetCustMarkupLevelValue()
	{
		return this.GetValue(TableUtils.CustMarkupLevelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustMarkupLevel field.
	/// </summary>
	public Byte GetCustMarkupLevelFieldValue()
	{
		return this.GetValue(TableUtils.CustMarkupLevelColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustMarkupLevel field.
	/// </summary>
	public void SetCustMarkupLevelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustMarkupLevelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustMarkupLevel field.
	/// </summary>
	public void SetCustMarkupLevelFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustMarkupLevelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustMarkupLevel field.
	/// </summary>
	public void SetCustMarkupLevelFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustMarkupLevelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustMarkupLevel field.
	/// </summary>
	public void SetCustMarkupLevelFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustMarkupLevelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustMarkupLevel field.
	/// </summary>
	public void SetCustMarkupLevelFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustMarkupLevelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustName field.
	/// </summary>
	public ColumnValue GetCustNameValue()
	{
		return this.GetValue(TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustName field.
	/// </summary>
	public string GetCustNameFieldValue()
	{
		return this.GetValue(TableUtils.CustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustNo field.
	/// </summary>
	public ColumnValue GetCustNoValue()
	{
		return this.GetValue(TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustNo field.
	/// </summary>
	public Int32 GetCustNoFieldValue()
	{
		return this.GetValue(TableUtils.CustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPackCode field.
	/// </summary>
	public ColumnValue GetCustPackCodeValue()
	{
		return this.GetValue(TableUtils.CustPackCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPackCode field.
	/// </summary>
	public string GetCustPackCodeFieldValue()
	{
		return this.GetValue(TableUtils.CustPackCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPackCode field.
	/// </summary>
	public void SetCustPackCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPackCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPackCode field.
	/// </summary>
	public void SetCustPackCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPackCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPackCodeGroup field.
	/// </summary>
	public ColumnValue GetCustPackCodeGroupValue()
	{
		return this.GetValue(TableUtils.CustPackCodeGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPackCodeGroup field.
	/// </summary>
	public string GetCustPackCodeGroupFieldValue()
	{
		return this.GetValue(TableUtils.CustPackCodeGroupColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPackCodeGroup field.
	/// </summary>
	public void SetCustPackCodeGroupFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPackCodeGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPackCodeGroup field.
	/// </summary>
	public void SetCustPackCodeGroupFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPackCodeGroupColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPayMethod field.
	/// </summary>
	public ColumnValue GetCustPayMethodValue()
	{
		return this.GetValue(TableUtils.CustPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPayMethod field.
	/// </summary>
	public Byte GetCustPayMethodFieldValue()
	{
		return this.GetValue(TableUtils.CustPayMethodColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayMethod field.
	/// </summary>
	public void SetCustPayMethodFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayMethod field.
	/// </summary>
	public void SetCustPayMethodFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayMethod field.
	/// </summary>
	public void SetCustPayMethodFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayMethod field.
	/// </summary>
	public void SetCustPayMethodFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayMethod field.
	/// </summary>
	public void SetCustPayMethodFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPayMethodColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPayTerms field.
	/// </summary>
	public ColumnValue GetCustPayTermsValue()
	{
		return this.GetValue(TableUtils.CustPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPayTerms field.
	/// </summary>
	public Byte GetCustPayTermsFieldValue()
	{
		return this.GetValue(TableUtils.CustPayTermsColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayTerms field.
	/// </summary>
	public void SetCustPayTermsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayTerms field.
	/// </summary>
	public void SetCustPayTermsFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayTerms field.
	/// </summary>
	public void SetCustPayTermsFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayTerms field.
	/// </summary>
	public void SetCustPayTermsFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayTerms field.
	/// </summary>
	public void SetCustPayTermsFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPayTermsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPhoneBusiness field.
	/// </summary>
	public ColumnValue GetCustPhoneBusinessValue()
	{
		return this.GetValue(TableUtils.CustPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPhoneBusiness field.
	/// </summary>
	public string GetCustPhoneBusinessFieldValue()
	{
		return this.GetValue(TableUtils.CustPhoneBusinessColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPhoneBusiness field.
	/// </summary>
	public void SetCustPhoneBusinessFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPhoneBusiness field.
	/// </summary>
	public void SetCustPhoneBusinessFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPhoneBusinessColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPhoneHome field.
	/// </summary>
	public ColumnValue GetCustPhoneHomeValue()
	{
		return this.GetValue(TableUtils.CustPhoneHomeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPhoneHome field.
	/// </summary>
	public string GetCustPhoneHomeFieldValue()
	{
		return this.GetValue(TableUtils.CustPhoneHomeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPhoneHome field.
	/// </summary>
	public void SetCustPhoneHomeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPhoneHomeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPhoneHome field.
	/// </summary>
	public void SetCustPhoneHomeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPhoneHomeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPhoneMobile field.
	/// </summary>
	public ColumnValue GetCustPhoneMobileValue()
	{
		return this.GetValue(TableUtils.CustPhoneMobileColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPhoneMobile field.
	/// </summary>
	public string GetCustPhoneMobileFieldValue()
	{
		return this.GetValue(TableUtils.CustPhoneMobileColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPhoneMobile field.
	/// </summary>
	public void SetCustPhoneMobileFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPhoneMobileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPhoneMobile field.
	/// </summary>
	public void SetCustPhoneMobileFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPhoneMobileColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPostalCode field.
	/// </summary>
	public ColumnValue GetCustPostalCodeValue()
	{
		return this.GetValue(TableUtils.CustPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPostalCode field.
	/// </summary>
	public string GetCustPostalCodeFieldValue()
	{
		return this.GetValue(TableUtils.CustPostalCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPostalCode field.
	/// </summary>
	public void SetCustPostalCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPostalCode field.
	/// </summary>
	public void SetCustPostalCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPostalCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPrintBilling field.
	/// </summary>
	public ColumnValue GetCustPrintBillingValue()
	{
		return this.GetValue(TableUtils.CustPrintBillingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPrintBilling field.
	/// </summary>
	public Byte GetCustPrintBillingFieldValue()
	{
		return this.GetValue(TableUtils.CustPrintBillingColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintBilling field.
	/// </summary>
	public void SetCustPrintBillingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPrintBillingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintBilling field.
	/// </summary>
	public void SetCustPrintBillingFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustPrintBillingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintBilling field.
	/// </summary>
	public void SetCustPrintBillingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPrintBillingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintBilling field.
	/// </summary>
	public void SetCustPrintBillingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPrintBillingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintBilling field.
	/// </summary>
	public void SetCustPrintBillingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPrintBillingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPrintNotes field.
	/// </summary>
	public ColumnValue GetCustPrintNotesValue()
	{
		return this.GetValue(TableUtils.CustPrintNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPrintNotes field.
	/// </summary>
	public string GetCustPrintNotesFieldValue()
	{
		return this.GetValue(TableUtils.CustPrintNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintNotes field.
	/// </summary>
	public void SetCustPrintNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPrintNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintNotes field.
	/// </summary>
	public void SetCustPrintNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPrintNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPrintStatements field.
	/// </summary>
	public ColumnValue GetCustPrintStatementsValue()
	{
		return this.GetValue(TableUtils.CustPrintStatementsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPrintStatements field.
	/// </summary>
	public bool GetCustPrintStatementsFieldValue()
	{
		return this.GetValue(TableUtils.CustPrintStatementsColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintStatements field.
	/// </summary>
	public void SetCustPrintStatementsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPrintStatementsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintStatements field.
	/// </summary>
	public void SetCustPrintStatementsFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustPrintStatementsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintStatements field.
	/// </summary>
	public void SetCustPrintStatementsFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPrintStatementsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPrivateNotes field.
	/// </summary>
	public ColumnValue GetCustPrivateNotesValue()
	{
		return this.GetValue(TableUtils.CustPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustPrivateNotes field.
	/// </summary>
	public string GetCustPrivateNotesFieldValue()
	{
		return this.GetValue(TableUtils.CustPrivateNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrivateNotes field.
	/// </summary>
	public void SetCustPrivateNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrivateNotes field.
	/// </summary>
	public void SetCustPrivateNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPrivateNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustProvince field.
	/// </summary>
	public ColumnValue GetCustProvinceValue()
	{
		return this.GetValue(TableUtils.CustProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustProvince field.
	/// </summary>
	public string GetCustProvinceFieldValue()
	{
		return this.GetValue(TableUtils.CustProvinceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustProvince field.
	/// </summary>
	public void SetCustProvinceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustProvince field.
	/// </summary>
	public void SetCustProvinceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustProvinceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustQBAltered field.
	/// </summary>
	public ColumnValue GetCustQBAlteredValue()
	{
		return this.GetValue(TableUtils.CustQBAlteredColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustQBAltered field.
	/// </summary>
	public bool GetCustQBAlteredFieldValue()
	{
		return this.GetValue(TableUtils.CustQBAlteredColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBAltered field.
	/// </summary>
	public void SetCustQBAlteredFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustQBAlteredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBAltered field.
	/// </summary>
	public void SetCustQBAlteredFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustQBAlteredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBAltered field.
	/// </summary>
	public void SetCustQBAlteredFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustQBAlteredColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustQBEditSequence field.
	/// </summary>
	public ColumnValue GetCustQBEditSequenceValue()
	{
		return this.GetValue(TableUtils.CustQBEditSequenceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustQBEditSequence field.
	/// </summary>
	public string GetCustQBEditSequenceFieldValue()
	{
		return this.GetValue(TableUtils.CustQBEditSequenceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBEditSequence field.
	/// </summary>
	public void SetCustQBEditSequenceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustQBEditSequenceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBEditSequence field.
	/// </summary>
	public void SetCustQBEditSequenceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustQBEditSequenceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustQBListID field.
	/// </summary>
	public ColumnValue GetCustQBListIDValue()
	{
		return this.GetValue(TableUtils.CustQBListIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustQBListID field.
	/// </summary>
	public string GetCustQBListIDFieldValue()
	{
		return this.GetValue(TableUtils.CustQBListIDColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBListID field.
	/// </summary>
	public void SetCustQBListIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustQBListIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBListID field.
	/// </summary>
	public void SetCustQBListIDFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustQBListIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustReference1 field.
	/// </summary>
	public ColumnValue GetCustReference1Value()
	{
		return this.GetValue(TableUtils.CustReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustReference1 field.
	/// </summary>
	public string GetCustReference1FieldValue()
	{
		return this.GetValue(TableUtils.CustReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference1 field.
	/// </summary>
	public void SetCustReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference1 field.
	/// </summary>
	public void SetCustReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustReference2 field.
	/// </summary>
	public ColumnValue GetCustReference2Value()
	{
		return this.GetValue(TableUtils.CustReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustReference2 field.
	/// </summary>
	public string GetCustReference2FieldValue()
	{
		return this.GetValue(TableUtils.CustReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference2 field.
	/// </summary>
	public void SetCustReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference2 field.
	/// </summary>
	public void SetCustReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustReference3 field.
	/// </summary>
	public ColumnValue GetCustReference3Value()
	{
		return this.GetValue(TableUtils.CustReference3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustReference3 field.
	/// </summary>
	public string GetCustReference3FieldValue()
	{
		return this.GetValue(TableUtils.CustReference3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference3 field.
	/// </summary>
	public void SetCustReference3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustReference3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference3 field.
	/// </summary>
	public void SetCustReference3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustReference3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustReference4 field.
	/// </summary>
	public ColumnValue GetCustReference4Value()
	{
		return this.GetValue(TableUtils.CustReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustReference4 field.
	/// </summary>
	public string GetCustReference4FieldValue()
	{
		return this.GetValue(TableUtils.CustReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference4 field.
	/// </summary>
	public void SetCustReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference4 field.
	/// </summary>
	public void SetCustReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustServCodeGroup field.
	/// </summary>
	public ColumnValue GetCustServCodeGroupValue()
	{
		return this.GetValue(TableUtils.CustServCodeGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustServCodeGroup field.
	/// </summary>
	public string GetCustServCodeGroupFieldValue()
	{
		return this.GetValue(TableUtils.CustServCodeGroupColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustServCodeGroup field.
	/// </summary>
	public void SetCustServCodeGroupFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustServCodeGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustServCodeGroup field.
	/// </summary>
	public void SetCustServCodeGroupFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustServCodeGroupColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustShipVia field.
	/// </summary>
	public ColumnValue GetCustShipViaValue()
	{
		return this.GetValue(TableUtils.CustShipViaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustShipVia field.
	/// </summary>
	public string GetCustShipViaFieldValue()
	{
		return this.GetValue(TableUtils.CustShipViaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustShipVia field.
	/// </summary>
	public void SetCustShipViaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustShipViaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustShipVia field.
	/// </summary>
	public void SetCustShipViaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustShipViaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustSince field.
	/// </summary>
	public ColumnValue GetCustSinceValue()
	{
		return this.GetValue(TableUtils.CustSinceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustSince field.
	/// </summary>
	public DateTime GetCustSinceFieldValue()
	{
		return this.GetValue(TableUtils.CustSinceColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustSince field.
	/// </summary>
	public void SetCustSinceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustSinceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustSince field.
	/// </summary>
	public void SetCustSinceFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustSinceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustSince field.
	/// </summary>
	public void SetCustSinceFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustSinceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax1Rate field.
	/// </summary>
	public ColumnValue GetCustTax1RateValue()
	{
		return this.GetValue(TableUtils.CustTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax1Rate field.
	/// </summary>
	public Single GetCustTax1RateFieldValue()
	{
		return this.GetValue(TableUtils.CustTax1RateColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rate field.
	/// </summary>
	public void SetCustTax1RateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rate field.
	/// </summary>
	public void SetCustTax1RateFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rate field.
	/// </summary>
	public void SetCustTax1RateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rate field.
	/// </summary>
	public void SetCustTax1RateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rate field.
	/// </summary>
	public void SetCustTax1RateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax1RateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax1Rules field.
	/// </summary>
	public ColumnValue GetCustTax1RulesValue()
	{
		return this.GetValue(TableUtils.CustTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax1Rules field.
	/// </summary>
	public Byte GetCustTax1RulesFieldValue()
	{
		return this.GetValue(TableUtils.CustTax1RulesColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rules field.
	/// </summary>
	public void SetCustTax1RulesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rules field.
	/// </summary>
	public void SetCustTax1RulesFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rules field.
	/// </summary>
	public void SetCustTax1RulesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rules field.
	/// </summary>
	public void SetCustTax1RulesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rules field.
	/// </summary>
	public void SetCustTax1RulesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax1RulesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax2Rate field.
	/// </summary>
	public ColumnValue GetCustTax2RateValue()
	{
		return this.GetValue(TableUtils.CustTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax2Rate field.
	/// </summary>
	public Single GetCustTax2RateFieldValue()
	{
		return this.GetValue(TableUtils.CustTax2RateColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rate field.
	/// </summary>
	public void SetCustTax2RateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rate field.
	/// </summary>
	public void SetCustTax2RateFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rate field.
	/// </summary>
	public void SetCustTax2RateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rate field.
	/// </summary>
	public void SetCustTax2RateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rate field.
	/// </summary>
	public void SetCustTax2RateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax2RateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax2Rules field.
	/// </summary>
	public ColumnValue GetCustTax2RulesValue()
	{
		return this.GetValue(TableUtils.CustTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax2Rules field.
	/// </summary>
	public Byte GetCustTax2RulesFieldValue()
	{
		return this.GetValue(TableUtils.CustTax2RulesColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rules field.
	/// </summary>
	public void SetCustTax2RulesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rules field.
	/// </summary>
	public void SetCustTax2RulesFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rules field.
	/// </summary>
	public void SetCustTax2RulesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rules field.
	/// </summary>
	public void SetCustTax2RulesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rules field.
	/// </summary>
	public void SetCustTax2RulesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax2RulesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax3Rate field.
	/// </summary>
	public ColumnValue GetCustTax3RateValue()
	{
		return this.GetValue(TableUtils.CustTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax3Rate field.
	/// </summary>
	public Single GetCustTax3RateFieldValue()
	{
		return this.GetValue(TableUtils.CustTax3RateColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rate field.
	/// </summary>
	public void SetCustTax3RateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rate field.
	/// </summary>
	public void SetCustTax3RateFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rate field.
	/// </summary>
	public void SetCustTax3RateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rate field.
	/// </summary>
	public void SetCustTax3RateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rate field.
	/// </summary>
	public void SetCustTax3RateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax3RateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax3Rules field.
	/// </summary>
	public ColumnValue GetCustTax3RulesValue()
	{
		return this.GetValue(TableUtils.CustTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTax3Rules field.
	/// </summary>
	public Byte GetCustTax3RulesFieldValue()
	{
		return this.GetValue(TableUtils.CustTax3RulesColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rules field.
	/// </summary>
	public void SetCustTax3RulesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rules field.
	/// </summary>
	public void SetCustTax3RulesFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rules field.
	/// </summary>
	public void SetCustTax3RulesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rules field.
	/// </summary>
	public void SetCustTax3RulesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rules field.
	/// </summary>
	public void SetCustTax3RulesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTax3RulesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTaxExempt field.
	/// </summary>
	public ColumnValue GetCustTaxExemptValue()
	{
		return this.GetValue(TableUtils.CustTaxExemptColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustTaxExempt field.
	/// </summary>
	public bool GetCustTaxExemptFieldValue()
	{
		return this.GetValue(TableUtils.CustTaxExemptColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTaxExempt field.
	/// </summary>
	public void SetCustTaxExemptFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustTaxExemptColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTaxExempt field.
	/// </summary>
	public void SetCustTaxExemptFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustTaxExemptColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTaxExempt field.
	/// </summary>
	public void SetCustTaxExemptFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustTaxExemptColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustWarrantyPlan field.
	/// </summary>
	public ColumnValue GetCustWarrantyPlanValue()
	{
		return this.GetValue(TableUtils.CustWarrantyPlanColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustWarrantyPlan field.
	/// </summary>
	public string GetCustWarrantyPlanFieldValue()
	{
		return this.GetValue(TableUtils.CustWarrantyPlanColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustWarrantyPlan field.
	/// </summary>
	public void SetCustWarrantyPlanFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustWarrantyPlanColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustWarrantyPlan field.
	/// </summary>
	public void SetCustWarrantyPlanFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustWarrantyPlanColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustWebSite field.
	/// </summary>
	public ColumnValue GetCustWebSiteValue()
	{
		return this.GetValue(TableUtils.CustWebSiteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustWebSite field.
	/// </summary>
	public string GetCustWebSiteFieldValue()
	{
		return this.GetValue(TableUtils.CustWebSiteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustWebSite field.
	/// </summary>
	public void SetCustWebSiteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustWebSiteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustWebSite field.
	/// </summary>
	public void SetCustWebSiteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustWebSiteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Link field.
	/// </summary>
	public ColumnValue GetLinkValue()
	{
		return this.GetValue(TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Link field.
	/// </summary>
	public Byte GetLinkFieldValue()
	{
		return this.GetValue(TableUtils.LinkColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Link field.
	/// </summary>
	public void SetLinkFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Link field.
	/// </summary>
	public void SetLinkFieldValue(string val)
	{
		this.SetString(val, TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Link field.
	/// </summary>
	public void SetLinkFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Link field.
	/// </summary>
	public void SetLinkFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Link field.
	/// </summary>
	public void SetLinkFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinkColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_type_id field.
	/// </summary>
	public ColumnValue Getcustomer_type_idValue()
	{
		return this.GetValue(TableUtils.customer_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_type_id field.
	/// </summary>
	public Int32 Getcustomer_type_idFieldValue()
	{
		return this.GetValue(TableUtils.customer_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_type_id field.
	/// </summary>
	public void Setcustomer_type_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_type_id field.
	/// </summary>
	public void Setcustomer_type_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_type_id field.
	/// </summary>
	public void Setcustomer_type_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_type_id field.
	/// </summary>
	public void Setcustomer_type_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_type_id field.
	/// </summary>
	public void Setcustomer_type_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_type_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_active field.
	/// </summary>
	public ColumnValue Getcustomer_activeValue()
	{
		return this.GetValue(TableUtils.customer_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_active field.
	/// </summary>
	public bool Getcustomer_activeFieldValue()
	{
		return this.GetValue(TableUtils.customer_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_active field.
	/// </summary>
	public void Setcustomer_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_active field.
	/// </summary>
	public void Setcustomer_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_active field.
	/// </summary>
	public void Setcustomer_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_mgr_id field.
	/// </summary>
	public ColumnValue Getcustomer_mgr_idValue()
	{
		return this.GetValue(TableUtils.customer_mgr_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_mgr_id field.
	/// </summary>
	public Int32 Getcustomer_mgr_idFieldValue()
	{
		return this.GetValue(TableUtils.customer_mgr_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_mgr_id field.
	/// </summary>
	public void Setcustomer_mgr_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_mgr_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_mgr_id field.
	/// </summary>
	public void Setcustomer_mgr_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_mgr_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_mgr_id field.
	/// </summary>
	public void Setcustomer_mgr_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_mgr_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_mgr_id field.
	/// </summary>
	public void Setcustomer_mgr_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_mgr_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_mgr_id field.
	/// </summary>
	public void Setcustomer_mgr_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_mgr_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_cc_limit field.
	/// </summary>
	public ColumnValue Getcustomer_cc_limitValue()
	{
		return this.GetValue(TableUtils.customer_cc_limitColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_cc_limit field.
	/// </summary>
	public Decimal Getcustomer_cc_limitFieldValue()
	{
		return this.GetValue(TableUtils.customer_cc_limitColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_cc_limit field.
	/// </summary>
	public void Setcustomer_cc_limitFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_cc_limitColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_cc_limit field.
	/// </summary>
	public void Setcustomer_cc_limitFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_cc_limitColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_cc_limit field.
	/// </summary>
	public void Setcustomer_cc_limitFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_cc_limitColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_cc_limit field.
	/// </summary>
	public void Setcustomer_cc_limitFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_cc_limitColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_cc_limit field.
	/// </summary>
	public void Setcustomer_cc_limitFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_cc_limitColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_po_needed field.
	/// </summary>
	public ColumnValue Getcustomer_po_neededValue()
	{
		return this.GetValue(TableUtils.customer_po_neededColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_po_needed field.
	/// </summary>
	public bool Getcustomer_po_neededFieldValue()
	{
		return this.GetValue(TableUtils.customer_po_neededColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_po_needed field.
	/// </summary>
	public void Setcustomer_po_neededFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_po_neededColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_po_needed field.
	/// </summary>
	public void Setcustomer_po_neededFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_po_neededColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_po_needed field.
	/// </summary>
	public void Setcustomer_po_neededFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_po_neededColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_exempt_file field.
	/// </summary>
	public ColumnValue Getcustomer_exempt_fileValue()
	{
		return this.GetValue(TableUtils.customer_exempt_fileColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_exempt_file field.
	/// </summary>
	public byte[] Getcustomer_exempt_fileFieldValue()
	{
		return this.GetValue(TableUtils.customer_exempt_fileColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_exempt_file field.
	/// </summary>
	public void Setcustomer_exempt_fileFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_exempt_fileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_exempt_file field.
	/// </summary>
	public void Setcustomer_exempt_fileFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_exempt_fileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_exempt_file field.
	/// </summary>
	public void Setcustomer_exempt_fileFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_exempt_fileColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_bill_email field.
	/// </summary>
	public ColumnValue Getcustomer_bill_emailValue()
	{
		return this.GetValue(TableUtils.customer_bill_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_bill_email field.
	/// </summary>
	public bool Getcustomer_bill_emailFieldValue()
	{
		return this.GetValue(TableUtils.customer_bill_emailColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_email field.
	/// </summary>
	public void Setcustomer_bill_emailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_bill_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_email field.
	/// </summary>
	public void Setcustomer_bill_emailFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_bill_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_email field.
	/// </summary>
	public void Setcustomer_bill_emailFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_bill_emailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_bill_fax field.
	/// </summary>
	public ColumnValue Getcustomer_bill_faxValue()
	{
		return this.GetValue(TableUtils.customer_bill_faxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_bill_fax field.
	/// </summary>
	public bool Getcustomer_bill_faxFieldValue()
	{
		return this.GetValue(TableUtils.customer_bill_faxColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_fax field.
	/// </summary>
	public void Setcustomer_bill_faxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_bill_faxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_fax field.
	/// </summary>
	public void Setcustomer_bill_faxFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_bill_faxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_fax field.
	/// </summary>
	public void Setcustomer_bill_faxFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_bill_faxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_bill_mail field.
	/// </summary>
	public ColumnValue Getcustomer_bill_mailValue()
	{
		return this.GetValue(TableUtils.customer_bill_mailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_bill_mail field.
	/// </summary>
	public bool Getcustomer_bill_mailFieldValue()
	{
		return this.GetValue(TableUtils.customer_bill_mailColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_mail field.
	/// </summary>
	public void Setcustomer_bill_mailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_bill_mailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_mail field.
	/// </summary>
	public void Setcustomer_bill_mailFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_bill_mailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_mail field.
	/// </summary>
	public void Setcustomer_bill_mailFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_bill_mailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_address1 field.
	/// </summary>
	public ColumnValue Getcust_shipping_address1Value()
	{
		return this.GetValue(TableUtils.cust_shipping_address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_address1 field.
	/// </summary>
	public string Getcust_shipping_address1FieldValue()
	{
		return this.GetValue(TableUtils.cust_shipping_address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_address1 field.
	/// </summary>
	public void Setcust_shipping_address1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_shipping_address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_address1 field.
	/// </summary>
	public void Setcust_shipping_address1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_shipping_address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_address2 field.
	/// </summary>
	public ColumnValue Getcust_shipping_address2Value()
	{
		return this.GetValue(TableUtils.cust_shipping_address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_address2 field.
	/// </summary>
	public string Getcust_shipping_address2FieldValue()
	{
		return this.GetValue(TableUtils.cust_shipping_address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_address2 field.
	/// </summary>
	public void Setcust_shipping_address2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_shipping_address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_address2 field.
	/// </summary>
	public void Setcust_shipping_address2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_shipping_address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_city field.
	/// </summary>
	public ColumnValue Getcust_shipping_cityValue()
	{
		return this.GetValue(TableUtils.cust_shipping_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_city field.
	/// </summary>
	public string Getcust_shipping_cityFieldValue()
	{
		return this.GetValue(TableUtils.cust_shipping_cityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_city field.
	/// </summary>
	public void Setcust_shipping_cityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_shipping_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_city field.
	/// </summary>
	public void Setcust_shipping_cityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_shipping_cityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_province field.
	/// </summary>
	public ColumnValue Getcust_shipping_provinceValue()
	{
		return this.GetValue(TableUtils.cust_shipping_provinceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_province field.
	/// </summary>
	public string Getcust_shipping_provinceFieldValue()
	{
		return this.GetValue(TableUtils.cust_shipping_provinceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_province field.
	/// </summary>
	public void Setcust_shipping_provinceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_shipping_provinceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_province field.
	/// </summary>
	public void Setcust_shipping_provinceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_shipping_provinceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_postalcode field.
	/// </summary>
	public ColumnValue Getcust_shipping_postalcodeValue()
	{
		return this.GetValue(TableUtils.cust_shipping_postalcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_shipping_postalcode field.
	/// </summary>
	public string Getcust_shipping_postalcodeFieldValue()
	{
		return this.GetValue(TableUtils.cust_shipping_postalcodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_postalcode field.
	/// </summary>
	public void Setcust_shipping_postalcodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_shipping_postalcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_postalcode field.
	/// </summary>
	public void Setcust_shipping_postalcodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_shipping_postalcodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_address1 field.
	/// </summary>
	public ColumnValue Getcust_billing_address1Value()
	{
		return this.GetValue(TableUtils.cust_billing_address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_address1 field.
	/// </summary>
	public string Getcust_billing_address1FieldValue()
	{
		return this.GetValue(TableUtils.cust_billing_address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_address1 field.
	/// </summary>
	public void Setcust_billing_address1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_billing_address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_address1 field.
	/// </summary>
	public void Setcust_billing_address1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_billing_address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_address2 field.
	/// </summary>
	public ColumnValue Getcust_billing_address2Value()
	{
		return this.GetValue(TableUtils.cust_billing_address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_address2 field.
	/// </summary>
	public string Getcust_billing_address2FieldValue()
	{
		return this.GetValue(TableUtils.cust_billing_address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_address2 field.
	/// </summary>
	public void Setcust_billing_address2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_billing_address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_address2 field.
	/// </summary>
	public void Setcust_billing_address2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_billing_address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_city field.
	/// </summary>
	public ColumnValue Getcust_billing_cityValue()
	{
		return this.GetValue(TableUtils.cust_billing_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_city field.
	/// </summary>
	public string Getcust_billing_cityFieldValue()
	{
		return this.GetValue(TableUtils.cust_billing_cityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_city field.
	/// </summary>
	public void Setcust_billing_cityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_billing_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_city field.
	/// </summary>
	public void Setcust_billing_cityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_billing_cityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_province field.
	/// </summary>
	public ColumnValue Getcust_billing_provinceValue()
	{
		return this.GetValue(TableUtils.cust_billing_provinceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_province field.
	/// </summary>
	public string Getcust_billing_provinceFieldValue()
	{
		return this.GetValue(TableUtils.cust_billing_provinceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_province field.
	/// </summary>
	public void Setcust_billing_provinceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_billing_provinceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_province field.
	/// </summary>
	public void Setcust_billing_provinceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_billing_provinceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_postalcode field.
	/// </summary>
	public ColumnValue Getcust_billing_postalcodeValue()
	{
		return this.GetValue(TableUtils.cust_billing_postalcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.cust_billing_postalcode field.
	/// </summary>
	public string Getcust_billing_postalcodeFieldValue()
	{
		return this.GetValue(TableUtils.cust_billing_postalcodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_postalcode field.
	/// </summary>
	public void Setcust_billing_postalcodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_billing_postalcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_postalcode field.
	/// </summary>
	public void Setcust_billing_postalcodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_billing_postalcodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.corporate_id field.
	/// </summary>
	public ColumnValue Getcorporate_idValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.corporate_id field.
	/// </summary>
	public Int32 Getcorporate_idFieldValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.territory_id field.
	/// </summary>
	public ColumnValue Getterritory_idValue()
	{
		return this.GetValue(TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.territory_id field.
	/// </summary>
	public Int32 Getterritory_idFieldValue()
	{
		return this.GetValue(TableUtils.territory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.territory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customercontact_primary field.
	/// </summary>
	public ColumnValue Getcustomercontact_primaryValue()
	{
		return this.GetValue(TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customercontact_primary field.
	/// </summary>
	public Int32 Getcustomercontact_primaryFieldValue()
	{
		return this.GetValue(TableUtils.customercontact_primaryColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(string val)
	{
		this.SetString(val, TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_primaryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customercontact_secondary field.
	/// </summary>
	public ColumnValue Getcustomercontact_secondaryValue()
	{
		return this.GetValue(TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customercontact_secondary field.
	/// </summary>
	public Int32 Getcustomercontact_secondaryFieldValue()
	{
		return this.GetValue(TableUtils.customercontact_secondaryColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(string val)
	{
		this.SetString(val, TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_secondaryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_scope field.
	/// </summary>
	public ColumnValue Getcustomer_scopeValue()
	{
		return this.GetValue(TableUtils.customer_scopeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_scope field.
	/// </summary>
	public bool Getcustomer_scopeFieldValue()
	{
		return this.GetValue(TableUtils.customer_scopeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_scope field.
	/// </summary>
	public void Setcustomer_scopeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_scopeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_scope field.
	/// </summary>
	public void Setcustomer_scopeFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_scopeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_scope field.
	/// </summary>
	public void Setcustomer_scopeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_scopeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_inventory field.
	/// </summary>
	public ColumnValue Getcustomer_inventoryValue()
	{
		return this.GetValue(TableUtils.customer_inventoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_inventory field.
	/// </summary>
	public bool Getcustomer_inventoryFieldValue()
	{
		return this.GetValue(TableUtils.customer_inventoryColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_inventory field.
	/// </summary>
	public void Setcustomer_inventoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_inventoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_inventory field.
	/// </summary>
	public void Setcustomer_inventoryFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_inventoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_inventory field.
	/// </summary>
	public void Setcustomer_inventoryFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_inventoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_rental field.
	/// </summary>
	public ColumnValue Getcustomer_rentalValue()
	{
		return this.GetValue(TableUtils.customer_rentalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.customer_rental field.
	/// </summary>
	public bool Getcustomer_rentalFieldValue()
	{
		return this.GetValue(TableUtils.customer_rentalColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_rental field.
	/// </summary>
	public void Setcustomer_rentalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_rentalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_rental field.
	/// </summary>
	public void Setcustomer_rentalFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_rentalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_rental field.
	/// </summary>
	public void Setcustomer_rentalFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_rentalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.repairorder_notification field.
	/// </summary>
	public ColumnValue Getrepairorder_notificationValue()
	{
		return this.GetValue(TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.repairorder_notification field.
	/// </summary>
	public Int32 Getrepairorder_notificationFieldValue()
	{
		return this.GetValue(TableUtils.repairorder_notificationColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(string val)
	{
		this.SetString(val, TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repairorder_notificationColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustAddress1 field.
	/// </summary>
	public string CustAddress1
	{
		get
		{
			return this.GetValue(TableUtils.CustAddress1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustAddress1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustAddress1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustAddress1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAddress1 field.
	/// </summary>
	public string CustAddress1Default
	{
		get
		{
			return TableUtils.CustAddress1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustAddress2 field.
	/// </summary>
	public string CustAddress2
	{
		get
		{
			return this.GetValue(TableUtils.CustAddress2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustAddress2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustAddress2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustAddress2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAddress2 field.
	/// </summary>
	public string CustAddress2Default
	{
		get
		{
			return TableUtils.CustAddress2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustAdvertising field.
	/// </summary>
	public string CustAdvertising
	{
		get
		{
			return this.GetValue(TableUtils.CustAdvertisingColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustAdvertisingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustAdvertisingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustAdvertisingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAdvertising field.
	/// </summary>
	public string CustAdvertisingDefault
	{
		get
		{
			return TableUtils.CustAdvertisingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustAllowBilling field.
	/// </summary>
	public bool CustAllowBilling
	{
		get
		{
			return this.GetValue(TableUtils.CustAllowBillingColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustAllowBillingColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustAllowBillingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustAllowBillingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustAllowBilling field.
	/// </summary>
	public string CustAllowBillingDefault
	{
		get
		{
			return TableUtils.CustAllowBillingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustBillingNo field.
	/// </summary>
	public Int32 CustBillingNo
	{
		get
		{
			return this.GetValue(TableUtils.CustBillingNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustBillingNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustBillingNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustBillingNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustBillingNo field.
	/// </summary>
	public string CustBillingNoDefault
	{
		get
		{
			return TableUtils.CustBillingNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCity field.
	/// </summary>
	public string CustCity
	{
		get
		{
			return this.GetValue(TableUtils.CustCityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustCityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCity field.
	/// </summary>
	public string CustCityDefault
	{
		get
		{
			return TableUtils.CustCityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCode field.
	/// </summary>
	public string CustCode
	{
		get
		{
			return this.GetValue(TableUtils.CustCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCode field.
	/// </summary>
	public string CustCodeDefault
	{
		get
		{
			return TableUtils.CustCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustContactName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustContactName field.
	/// </summary>
	public string CustContactNameDefault
	{
		get
		{
			return TableUtils.CustContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustContract field.
	/// </summary>
	public string CustContract
	{
		get
		{
			return this.GetValue(TableUtils.CustContractColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContractColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContractSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContractColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustContract field.
	/// </summary>
	public string CustContractDefault
	{
		get
		{
			return TableUtils.CustContractColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCopyPrivateNotes field.
	/// </summary>
	public bool CustCopyPrivateNotes
	{
		get
		{
			return this.GetValue(TableUtils.CustCopyPrivateNotesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustCopyPrivateNotesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCopyPrivateNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCopyPrivateNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCopyPrivateNotes field.
	/// </summary>
	public string CustCopyPrivateNotesDefault
	{
		get
		{
			return TableUtils.CustCopyPrivateNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCopyPublicNotes field.
	/// </summary>
	public bool CustCopyPublicNotes
	{
		get
		{
			return this.GetValue(TableUtils.CustCopyPublicNotesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustCopyPublicNotesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCopyPublicNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCopyPublicNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCopyPublicNotes field.
	/// </summary>
	public string CustCopyPublicNotesDefault
	{
		get
		{
			return TableUtils.CustCopyPublicNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCountry field.
	/// </summary>
	public string CustCountry
	{
		get
		{
			return this.GetValue(TableUtils.CustCountryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustCountryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCountrySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCountryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCountry field.
	/// </summary>
	public string CustCountryDefault
	{
		get
		{
			return TableUtils.CustCountryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCreditCardName field.
	/// </summary>
	public string CustCreditCardName
	{
		get
		{
			return this.GetValue(TableUtils.CustCreditCardNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustCreditCardNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCreditCardNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCreditCardNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditCardName field.
	/// </summary>
	public string CustCreditCardNameDefault
	{
		get
		{
			return TableUtils.CustCreditCardNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCreditCardNo field.
	/// </summary>
	public string CustCreditCardNo
	{
		get
		{
			return this.GetValue(TableUtils.CustCreditCardNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustCreditCardNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCreditCardNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCreditCardNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditCardNo field.
	/// </summary>
	public string CustCreditCardNoDefault
	{
		get
		{
			return TableUtils.CustCreditCardNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCreditLimit field.
	/// </summary>
	public Decimal CustCreditLimit
	{
		get
		{
			return this.GetValue(TableUtils.CustCreditLimitColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustCreditLimitColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCreditLimitSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCreditLimitColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCreditLimit field.
	/// </summary>
	public string CustCreditLimitDefault
	{
		get
		{
			return TableUtils.CustCreditLimitColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCustom1 field.
	/// </summary>
	public string CustCustom1
	{
		get
		{
			return this.GetValue(TableUtils.CustCustom1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustCustom1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCustom1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCustom1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCustom1 field.
	/// </summary>
	public string CustCustom1Default
	{
		get
		{
			return TableUtils.CustCustom1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustCustom2 field.
	/// </summary>
	public string CustCustom2
	{
		get
		{
			return this.GetValue(TableUtils.CustCustom2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustCustom2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCustom2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCustom2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustCustom2 field.
	/// </summary>
	public string CustCustom2Default
	{
		get
		{
			return TableUtils.CustCustom2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustDateRecordAdded field.
	/// </summary>
	public DateTime CustDateRecordAdded
	{
		get
		{
			return this.GetValue(TableUtils.CustDateRecordAddedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustDateRecordAddedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustDateRecordAddedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustDateRecordAddedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDateRecordAdded field.
	/// </summary>
	public string CustDateRecordAddedDefault
	{
		get
		{
			return TableUtils.CustDateRecordAddedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustDateRecordUpdated field.
	/// </summary>
	public DateTime CustDateRecordUpdated
	{
		get
		{
			return this.GetValue(TableUtils.CustDateRecordUpdatedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustDateRecordUpdatedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustDateRecordUpdatedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustDateRecordUpdatedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDateRecordUpdated field.
	/// </summary>
	public string CustDateRecordUpdatedDefault
	{
		get
		{
			return TableUtils.CustDateRecordUpdatedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustDiscHandling field.
	/// </summary>
	public bool CustDiscHandling
	{
		get
		{
			return this.GetValue(TableUtils.CustDiscHandlingColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustDiscHandlingColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustDiscHandlingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustDiscHandlingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscHandling field.
	/// </summary>
	public string CustDiscHandlingDefault
	{
		get
		{
			return TableUtils.CustDiscHandlingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustDiscLabor field.
	/// </summary>
	public bool CustDiscLabor
	{
		get
		{
			return this.GetValue(TableUtils.CustDiscLaborColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustDiscLaborColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustDiscLaborSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustDiscLaborColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscLabor field.
	/// </summary>
	public string CustDiscLaborDefault
	{
		get
		{
			return TableUtils.CustDiscLaborColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustDiscount field.
	/// </summary>
	public Single CustDiscount
	{
		get
		{
			return this.GetValue(TableUtils.CustDiscountColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustDiscountColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustDiscountSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustDiscountColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscount field.
	/// </summary>
	public string CustDiscountDefault
	{
		get
		{
			return TableUtils.CustDiscountColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustDiscountNoAutoCalc field.
	/// </summary>
	public bool CustDiscountNoAutoCalc
	{
		get
		{
			return this.GetValue(TableUtils.CustDiscountNoAutoCalcColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustDiscountNoAutoCalcColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustDiscountNoAutoCalcSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustDiscountNoAutoCalcColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscountNoAutoCalc field.
	/// </summary>
	public string CustDiscountNoAutoCalcDefault
	{
		get
		{
			return TableUtils.CustDiscountNoAutoCalcColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustDiscParts field.
	/// </summary>
	public bool CustDiscParts
	{
		get
		{
			return this.GetValue(TableUtils.CustDiscPartsColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustDiscPartsColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustDiscPartsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustDiscPartsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscParts field.
	/// </summary>
	public string CustDiscPartsDefault
	{
		get
		{
			return TableUtils.CustDiscPartsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustDiscShipping field.
	/// </summary>
	public bool CustDiscShipping
	{
		get
		{
			return this.GetValue(TableUtils.CustDiscShippingColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustDiscShippingColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustDiscShippingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustDiscShippingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscShipping field.
	/// </summary>
	public string CustDiscShippingDefault
	{
		get
		{
			return TableUtils.CustDiscShippingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustDiscTravel field.
	/// </summary>
	public bool CustDiscTravel
	{
		get
		{
			return this.GetValue(TableUtils.CustDiscTravelColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustDiscTravelColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustDiscTravelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustDiscTravelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustDiscTravel field.
	/// </summary>
	public string CustDiscTravelDefault
	{
		get
		{
			return TableUtils.CustDiscTravelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustEmail field.
	/// </summary>
	public string CustEmail
	{
		get
		{
			return this.GetValue(TableUtils.CustEmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustEmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustEmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustEmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustEmail field.
	/// </summary>
	public string CustEmailDefault
	{
		get
		{
			return TableUtils.CustEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustEmailType field.
	/// </summary>
	public Byte CustEmailType
	{
		get
		{
			return this.GetValue(TableUtils.CustEmailTypeColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustEmailTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustEmailTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustEmailTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustEmailType field.
	/// </summary>
	public string CustEmailTypeDefault
	{
		get
		{
			return TableUtils.CustEmailTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustExportInclude field.
	/// </summary>
	public bool CustExportInclude
	{
		get
		{
			return this.GetValue(TableUtils.CustExportIncludeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustExportIncludeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustExportIncludeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustExportIncludeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustExportInclude field.
	/// </summary>
	public string CustExportIncludeDefault
	{
		get
		{
			return TableUtils.CustExportIncludeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustExportRecordChanged field.
	/// </summary>
	public bool CustExportRecordChanged
	{
		get
		{
			return this.GetValue(TableUtils.CustExportRecordChangedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustExportRecordChangedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustExportRecordChangedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustExportRecordChangedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustExportRecordChanged field.
	/// </summary>
	public string CustExportRecordChangedDefault
	{
		get
		{
			return TableUtils.CustExportRecordChangedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustFax field.
	/// </summary>
	public string CustFax
	{
		get
		{
			return this.GetValue(TableUtils.CustFaxColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustFaxColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustFaxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustFaxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustFax field.
	/// </summary>
	public string CustFaxDefault
	{
		get
		{
			return TableUtils.CustFaxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustForwardBillingNotices field.
	/// </summary>
	public bool CustForwardBillingNotices
	{
		get
		{
			return this.GetValue(TableUtils.CustForwardBillingNoticesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustForwardBillingNoticesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustForwardBillingNoticesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustForwardBillingNoticesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustForwardBillingNotices field.
	/// </summary>
	public string CustForwardBillingNoticesDefault
	{
		get
		{
			return TableUtils.CustForwardBillingNoticesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustInactive field.
	/// </summary>
	public bool CustInactive
	{
		get
		{
			return this.GetValue(TableUtils.CustInactiveColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustInactiveColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustInactiveSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustInactiveColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustInactive field.
	/// </summary>
	public string CustInactiveDefault
	{
		get
		{
			return TableUtils.CustInactiveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustLanguage field.
	/// </summary>
	public string CustLanguage
	{
		get
		{
			return this.GetValue(TableUtils.CustLanguageColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustLanguageColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustLanguageSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustLanguageColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustLanguage field.
	/// </summary>
	public string CustLanguageDefault
	{
		get
		{
			return TableUtils.CustLanguageColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustLocationBus field.
	/// </summary>
	public Int32 CustLocationBus
	{
		get
		{
			return this.GetValue(TableUtils.CustLocationBusColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustLocationBusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustLocationBusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustLocationBusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustLocationBus field.
	/// </summary>
	public string CustLocationBusDefault
	{
		get
		{
			return TableUtils.CustLocationBusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustMarkupLevel field.
	/// </summary>
	public Byte CustMarkupLevel
	{
		get
		{
			return this.GetValue(TableUtils.CustMarkupLevelColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustMarkupLevelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustMarkupLevelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustMarkupLevelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustMarkupLevel field.
	/// </summary>
	public string CustMarkupLevelDefault
	{
		get
		{
			return TableUtils.CustMarkupLevelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustName field.
	/// </summary>
	public string CustName
	{
		get
		{
			return this.GetValue(TableUtils.CustNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustName field.
	/// </summary>
	public string CustNameDefault
	{
		get
		{
			return TableUtils.CustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustNo field.
	/// </summary>
	public string CustNoDefault
	{
		get
		{
			return TableUtils.CustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPackCode field.
	/// </summary>
	public string CustPackCode
	{
		get
		{
			return this.GetValue(TableUtils.CustPackCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPackCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPackCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPackCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPackCode field.
	/// </summary>
	public string CustPackCodeDefault
	{
		get
		{
			return TableUtils.CustPackCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPackCodeGroup field.
	/// </summary>
	public string CustPackCodeGroup
	{
		get
		{
			return this.GetValue(TableUtils.CustPackCodeGroupColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPackCodeGroupColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPackCodeGroupSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPackCodeGroupColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPackCodeGroup field.
	/// </summary>
	public string CustPackCodeGroupDefault
	{
		get
		{
			return TableUtils.CustPackCodeGroupColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPayMethod field.
	/// </summary>
	public Byte CustPayMethod
	{
		get
		{
			return this.GetValue(TableUtils.CustPayMethodColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPayMethodColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPayMethodSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPayMethodColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayMethod field.
	/// </summary>
	public string CustPayMethodDefault
	{
		get
		{
			return TableUtils.CustPayMethodColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPayTerms field.
	/// </summary>
	public Byte CustPayTerms
	{
		get
		{
			return this.GetValue(TableUtils.CustPayTermsColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPayTermsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPayTermsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPayTermsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPayTerms field.
	/// </summary>
	public string CustPayTermsDefault
	{
		get
		{
			return TableUtils.CustPayTermsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPhoneBusiness field.
	/// </summary>
	public string CustPhoneBusiness
	{
		get
		{
			return this.GetValue(TableUtils.CustPhoneBusinessColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPhoneBusinessColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPhoneBusinessSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPhoneBusinessColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPhoneBusiness field.
	/// </summary>
	public string CustPhoneBusinessDefault
	{
		get
		{
			return TableUtils.CustPhoneBusinessColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPhoneHome field.
	/// </summary>
	public string CustPhoneHome
	{
		get
		{
			return this.GetValue(TableUtils.CustPhoneHomeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPhoneHomeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPhoneHomeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPhoneHomeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPhoneHome field.
	/// </summary>
	public string CustPhoneHomeDefault
	{
		get
		{
			return TableUtils.CustPhoneHomeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPhoneMobile field.
	/// </summary>
	public string CustPhoneMobile
	{
		get
		{
			return this.GetValue(TableUtils.CustPhoneMobileColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPhoneMobileColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPhoneMobileSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPhoneMobileColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPhoneMobile field.
	/// </summary>
	public string CustPhoneMobileDefault
	{
		get
		{
			return TableUtils.CustPhoneMobileColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPostalCode field.
	/// </summary>
	public string CustPostalCode
	{
		get
		{
			return this.GetValue(TableUtils.CustPostalCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPostalCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPostalCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPostalCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPostalCode field.
	/// </summary>
	public string CustPostalCodeDefault
	{
		get
		{
			return TableUtils.CustPostalCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPrintBilling field.
	/// </summary>
	public Byte CustPrintBilling
	{
		get
		{
			return this.GetValue(TableUtils.CustPrintBillingColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPrintBillingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPrintBillingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPrintBillingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintBilling field.
	/// </summary>
	public string CustPrintBillingDefault
	{
		get
		{
			return TableUtils.CustPrintBillingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPrintNotes field.
	/// </summary>
	public string CustPrintNotes
	{
		get
		{
			return this.GetValue(TableUtils.CustPrintNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPrintNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPrintNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPrintNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintNotes field.
	/// </summary>
	public string CustPrintNotesDefault
	{
		get
		{
			return TableUtils.CustPrintNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPrintStatements field.
	/// </summary>
	public bool CustPrintStatements
	{
		get
		{
			return this.GetValue(TableUtils.CustPrintStatementsColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustPrintStatementsColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPrintStatementsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPrintStatementsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrintStatements field.
	/// </summary>
	public string CustPrintStatementsDefault
	{
		get
		{
			return TableUtils.CustPrintStatementsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustPrivateNotes field.
	/// </summary>
	public string CustPrivateNotes
	{
		get
		{
			return this.GetValue(TableUtils.CustPrivateNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustPrivateNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPrivateNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPrivateNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustPrivateNotes field.
	/// </summary>
	public string CustPrivateNotesDefault
	{
		get
		{
			return TableUtils.CustPrivateNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustProvince field.
	/// </summary>
	public string CustProvince
	{
		get
		{
			return this.GetValue(TableUtils.CustProvinceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustProvinceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustProvinceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustProvinceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustProvince field.
	/// </summary>
	public string CustProvinceDefault
	{
		get
		{
			return TableUtils.CustProvinceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustQBAltered field.
	/// </summary>
	public bool CustQBAltered
	{
		get
		{
			return this.GetValue(TableUtils.CustQBAlteredColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustQBAlteredColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustQBAlteredSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustQBAlteredColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBAltered field.
	/// </summary>
	public string CustQBAlteredDefault
	{
		get
		{
			return TableUtils.CustQBAlteredColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustQBEditSequence field.
	/// </summary>
	public string CustQBEditSequence
	{
		get
		{
			return this.GetValue(TableUtils.CustQBEditSequenceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustQBEditSequenceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustQBEditSequenceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustQBEditSequenceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBEditSequence field.
	/// </summary>
	public string CustQBEditSequenceDefault
	{
		get
		{
			return TableUtils.CustQBEditSequenceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustQBListID field.
	/// </summary>
	public string CustQBListID
	{
		get
		{
			return this.GetValue(TableUtils.CustQBListIDColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustQBListIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustQBListIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustQBListIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustQBListID field.
	/// </summary>
	public string CustQBListIDDefault
	{
		get
		{
			return TableUtils.CustQBListIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustReference1 field.
	/// </summary>
	public string CustReference1
	{
		get
		{
			return this.GetValue(TableUtils.CustReference1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustReference1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustReference1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustReference1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference1 field.
	/// </summary>
	public string CustReference1Default
	{
		get
		{
			return TableUtils.CustReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustReference2 field.
	/// </summary>
	public string CustReference2
	{
		get
		{
			return this.GetValue(TableUtils.CustReference2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustReference2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustReference2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustReference2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference2 field.
	/// </summary>
	public string CustReference2Default
	{
		get
		{
			return TableUtils.CustReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustReference3 field.
	/// </summary>
	public string CustReference3
	{
		get
		{
			return this.GetValue(TableUtils.CustReference3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustReference3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustReference3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustReference3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference3 field.
	/// </summary>
	public string CustReference3Default
	{
		get
		{
			return TableUtils.CustReference3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustReference4 field.
	/// </summary>
	public string CustReference4
	{
		get
		{
			return this.GetValue(TableUtils.CustReference4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustReference4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustReference4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustReference4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustReference4 field.
	/// </summary>
	public string CustReference4Default
	{
		get
		{
			return TableUtils.CustReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustServCodeGroup field.
	/// </summary>
	public string CustServCodeGroup
	{
		get
		{
			return this.GetValue(TableUtils.CustServCodeGroupColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustServCodeGroupColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustServCodeGroupSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustServCodeGroupColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustServCodeGroup field.
	/// </summary>
	public string CustServCodeGroupDefault
	{
		get
		{
			return TableUtils.CustServCodeGroupColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustShipVia field.
	/// </summary>
	public string CustShipVia
	{
		get
		{
			return this.GetValue(TableUtils.CustShipViaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustShipViaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustShipViaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustShipViaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustShipVia field.
	/// </summary>
	public string CustShipViaDefault
	{
		get
		{
			return TableUtils.CustShipViaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustSince field.
	/// </summary>
	public DateTime CustSince
	{
		get
		{
			return this.GetValue(TableUtils.CustSinceColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustSinceColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustSinceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustSinceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustSince field.
	/// </summary>
	public string CustSinceDefault
	{
		get
		{
			return TableUtils.CustSinceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustTax1Rate field.
	/// </summary>
	public Single CustTax1Rate
	{
		get
		{
			return this.GetValue(TableUtils.CustTax1RateColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustTax1RateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustTax1RateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustTax1RateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rate field.
	/// </summary>
	public string CustTax1RateDefault
	{
		get
		{
			return TableUtils.CustTax1RateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustTax1Rules field.
	/// </summary>
	public Byte CustTax1Rules
	{
		get
		{
			return this.GetValue(TableUtils.CustTax1RulesColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustTax1RulesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustTax1RulesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustTax1RulesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax1Rules field.
	/// </summary>
	public string CustTax1RulesDefault
	{
		get
		{
			return TableUtils.CustTax1RulesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustTax2Rate field.
	/// </summary>
	public Single CustTax2Rate
	{
		get
		{
			return this.GetValue(TableUtils.CustTax2RateColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustTax2RateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustTax2RateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustTax2RateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rate field.
	/// </summary>
	public string CustTax2RateDefault
	{
		get
		{
			return TableUtils.CustTax2RateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustTax2Rules field.
	/// </summary>
	public Byte CustTax2Rules
	{
		get
		{
			return this.GetValue(TableUtils.CustTax2RulesColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustTax2RulesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustTax2RulesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustTax2RulesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax2Rules field.
	/// </summary>
	public string CustTax2RulesDefault
	{
		get
		{
			return TableUtils.CustTax2RulesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustTax3Rate field.
	/// </summary>
	public Single CustTax3Rate
	{
		get
		{
			return this.GetValue(TableUtils.CustTax3RateColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustTax3RateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustTax3RateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustTax3RateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rate field.
	/// </summary>
	public string CustTax3RateDefault
	{
		get
		{
			return TableUtils.CustTax3RateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustTax3Rules field.
	/// </summary>
	public Byte CustTax3Rules
	{
		get
		{
			return this.GetValue(TableUtils.CustTax3RulesColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustTax3RulesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustTax3RulesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustTax3RulesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTax3Rules field.
	/// </summary>
	public string CustTax3RulesDefault
	{
		get
		{
			return TableUtils.CustTax3RulesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustTaxExempt field.
	/// </summary>
	public bool CustTaxExempt
	{
		get
		{
			return this.GetValue(TableUtils.CustTaxExemptColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustTaxExemptColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustTaxExemptSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustTaxExemptColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustTaxExempt field.
	/// </summary>
	public string CustTaxExemptDefault
	{
		get
		{
			return TableUtils.CustTaxExemptColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustWarrantyPlan field.
	/// </summary>
	public string CustWarrantyPlan
	{
		get
		{
			return this.GetValue(TableUtils.CustWarrantyPlanColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustWarrantyPlanColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustWarrantyPlanSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustWarrantyPlanColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustWarrantyPlan field.
	/// </summary>
	public string CustWarrantyPlanDefault
	{
		get
		{
			return TableUtils.CustWarrantyPlanColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustWebSite field.
	/// </summary>
	public string CustWebSite
	{
		get
		{
			return this.GetValue(TableUtils.CustWebSiteColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustWebSiteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustWebSiteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustWebSiteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustWebSite field.
	/// </summary>
	public string CustWebSiteDefault
	{
		get
		{
			return TableUtils.CustWebSiteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.Link field.
	/// </summary>
	public Byte Link
	{
		get
		{
			return this.GetValue(TableUtils.LinkColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LinkColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LinkSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LinkColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Link field.
	/// </summary>
	public string LinkDefault
	{
		get
		{
			return TableUtils.LinkColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] SSMA_TimeStamp
	{
		get
		{
			return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SSMA_TimeStampColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SSMA_TimeStampSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SSMA_TimeStampColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_type_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_type_id field.
	/// </summary>
	public string customer_type_idDefault
	{
		get
		{
			return TableUtils.customer_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_active field.
	/// </summary>
	public bool customer_active
	{
		get
		{
			return this.GetValue(TableUtils.customer_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_active field.
	/// </summary>
	public string customer_activeDefault
	{
		get
		{
			return TableUtils.customer_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_mgr_id field.
	/// </summary>
	public Int32 customer_mgr_id
	{
		get
		{
			return this.GetValue(TableUtils.customer_mgr_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_mgr_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_mgr_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_mgr_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_mgr_id field.
	/// </summary>
	public string customer_mgr_idDefault
	{
		get
		{
			return TableUtils.customer_mgr_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_cc_limit field.
	/// </summary>
	public Decimal customer_cc_limit
	{
		get
		{
			return this.GetValue(TableUtils.customer_cc_limitColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_cc_limitColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_cc_limitSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_cc_limitColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_cc_limit field.
	/// </summary>
	public string customer_cc_limitDefault
	{
		get
		{
			return TableUtils.customer_cc_limitColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_po_needed field.
	/// </summary>
	public bool customer_po_needed
	{
		get
		{
			return this.GetValue(TableUtils.customer_po_neededColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_po_neededColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_po_neededSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_po_neededColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_po_needed field.
	/// </summary>
	public string customer_po_neededDefault
	{
		get
		{
			return TableUtils.customer_po_neededColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_exempt_file field.
	/// </summary>
	public byte[] customer_exempt_file
	{
		get
		{
			return this.GetValue(TableUtils.customer_exempt_fileColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_exempt_fileColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_exempt_fileSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_exempt_fileColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_exempt_file field.
	/// </summary>
	public string customer_exempt_fileDefault
	{
		get
		{
			return TableUtils.customer_exempt_fileColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_bill_email field.
	/// </summary>
	public bool customer_bill_email
	{
		get
		{
			return this.GetValue(TableUtils.customer_bill_emailColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_bill_emailColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_bill_emailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_bill_emailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_email field.
	/// </summary>
	public string customer_bill_emailDefault
	{
		get
		{
			return TableUtils.customer_bill_emailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_bill_fax field.
	/// </summary>
	public bool customer_bill_fax
	{
		get
		{
			return this.GetValue(TableUtils.customer_bill_faxColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_bill_faxColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_bill_faxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_bill_faxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_fax field.
	/// </summary>
	public string customer_bill_faxDefault
	{
		get
		{
			return TableUtils.customer_bill_faxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_bill_mail field.
	/// </summary>
	public bool customer_bill_mail
	{
		get
		{
			return this.GetValue(TableUtils.customer_bill_mailColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_bill_mailColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_bill_mailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_bill_mailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_bill_mail field.
	/// </summary>
	public string customer_bill_mailDefault
	{
		get
		{
			return TableUtils.customer_bill_mailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_shipping_address1 field.
	/// </summary>
	public string cust_shipping_address1
	{
		get
		{
			return this.GetValue(TableUtils.cust_shipping_address1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_shipping_address1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_shipping_address1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_shipping_address1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_address1 field.
	/// </summary>
	public string cust_shipping_address1Default
	{
		get
		{
			return TableUtils.cust_shipping_address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_shipping_address2 field.
	/// </summary>
	public string cust_shipping_address2
	{
		get
		{
			return this.GetValue(TableUtils.cust_shipping_address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_shipping_address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_shipping_address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_shipping_address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_address2 field.
	/// </summary>
	public string cust_shipping_address2Default
	{
		get
		{
			return TableUtils.cust_shipping_address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_shipping_city field.
	/// </summary>
	public string cust_shipping_city
	{
		get
		{
			return this.GetValue(TableUtils.cust_shipping_cityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_shipping_cityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_shipping_citySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_shipping_cityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_city field.
	/// </summary>
	public string cust_shipping_cityDefault
	{
		get
		{
			return TableUtils.cust_shipping_cityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_shipping_province field.
	/// </summary>
	public string cust_shipping_province
	{
		get
		{
			return this.GetValue(TableUtils.cust_shipping_provinceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_shipping_provinceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_shipping_provinceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_shipping_provinceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_province field.
	/// </summary>
	public string cust_shipping_provinceDefault
	{
		get
		{
			return TableUtils.cust_shipping_provinceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_shipping_postalcode field.
	/// </summary>
	public string cust_shipping_postalcode
	{
		get
		{
			return this.GetValue(TableUtils.cust_shipping_postalcodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_shipping_postalcodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_shipping_postalcodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_shipping_postalcodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_shipping_postalcode field.
	/// </summary>
	public string cust_shipping_postalcodeDefault
	{
		get
		{
			return TableUtils.cust_shipping_postalcodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_billing_address1 field.
	/// </summary>
	public string cust_billing_address1
	{
		get
		{
			return this.GetValue(TableUtils.cust_billing_address1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_billing_address1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_billing_address1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_billing_address1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_address1 field.
	/// </summary>
	public string cust_billing_address1Default
	{
		get
		{
			return TableUtils.cust_billing_address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_billing_address2 field.
	/// </summary>
	public string cust_billing_address2
	{
		get
		{
			return this.GetValue(TableUtils.cust_billing_address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_billing_address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_billing_address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_billing_address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_address2 field.
	/// </summary>
	public string cust_billing_address2Default
	{
		get
		{
			return TableUtils.cust_billing_address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_billing_city field.
	/// </summary>
	public string cust_billing_city
	{
		get
		{
			return this.GetValue(TableUtils.cust_billing_cityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_billing_cityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_billing_citySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_billing_cityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_city field.
	/// </summary>
	public string cust_billing_cityDefault
	{
		get
		{
			return TableUtils.cust_billing_cityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_billing_province field.
	/// </summary>
	public string cust_billing_province
	{
		get
		{
			return this.GetValue(TableUtils.cust_billing_provinceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_billing_provinceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_billing_provinceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_billing_provinceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_province field.
	/// </summary>
	public string cust_billing_provinceDefault
	{
		get
		{
			return TableUtils.cust_billing_provinceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.cust_billing_postalcode field.
	/// </summary>
	public string cust_billing_postalcode
	{
		get
		{
			return this.GetValue(TableUtils.cust_billing_postalcodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_billing_postalcodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_billing_postalcodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_billing_postalcodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.cust_billing_postalcode field.
	/// </summary>
	public string cust_billing_postalcodeDefault
	{
		get
		{
			return TableUtils.cust_billing_postalcodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.corporate_id field.
	/// </summary>
	public Int32 corporate_id
	{
		get
		{
			return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.corporate_id field.
	/// </summary>
	public string corporate_idDefault
	{
		get
		{
			return TableUtils.corporate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.territory_id field.
	/// </summary>
	public Int32 territory_id
	{
		get
		{
			return this.GetValue(TableUtils.territory_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.territory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool territory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.territory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.territory_id field.
	/// </summary>
	public string territory_idDefault
	{
		get
		{
			return TableUtils.territory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customercontact_primary field.
	/// </summary>
	public Int32 customercontact_primary
	{
		get
		{
			return this.GetValue(TableUtils.customercontact_primaryColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customercontact_primaryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customercontact_primarySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customercontact_primaryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_primary field.
	/// </summary>
	public string customercontact_primaryDefault
	{
		get
		{
			return TableUtils.customercontact_primaryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customercontact_secondary field.
	/// </summary>
	public Int32 customercontact_secondary
	{
		get
		{
			return this.GetValue(TableUtils.customercontact_secondaryColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customercontact_secondaryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customercontact_secondarySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customercontact_secondaryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customercontact_secondary field.
	/// </summary>
	public string customercontact_secondaryDefault
	{
		get
		{
			return TableUtils.customercontact_secondaryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_scope field.
	/// </summary>
	public bool customer_scope
	{
		get
		{
			return this.GetValue(TableUtils.customer_scopeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_scopeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_scopeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_scopeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_scope field.
	/// </summary>
	public string customer_scopeDefault
	{
		get
		{
			return TableUtils.customer_scopeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_inventory field.
	/// </summary>
	public bool customer_inventory
	{
		get
		{
			return this.GetValue(TableUtils.customer_inventoryColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_inventoryColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_inventorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_inventoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_inventory field.
	/// </summary>
	public string customer_inventoryDefault
	{
		get
		{
			return TableUtils.customer_inventoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.customer_rental field.
	/// </summary>
	public bool customer_rental
	{
		get
		{
			return this.GetValue(TableUtils.customer_rentalColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.customer_rentalColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_rentalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_rentalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.customer_rental field.
	/// </summary>
	public string customer_rentalDefault
	{
		get
		{
			return TableUtils.customer_rentalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.repairorder_notification field.
	/// </summary>
	public Int32 repairorder_notification
	{
		get
		{
			return this.GetValue(TableUtils.repairorder_notificationColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repairorder_notificationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repairorder_notificationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repairorder_notificationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.repairorder_notification field.
	/// </summary>
	public string repairorder_notificationDefault
	{
		get
		{
			return TableUtils.repairorder_notificationColumn.DefaultValue;
		}
	}


#endregion
}

}
