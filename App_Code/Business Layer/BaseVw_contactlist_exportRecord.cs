// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_contactlist_exportRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_contactlist_exportRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_contactlist_exportView"></see> class.
/// </remarks>
/// <seealso cref="Vw_contactlist_exportView"></seealso>
/// <seealso cref="Vw_contactlist_exportRecord"></seealso>
public class BaseVw_contactlist_exportRecord : KeylessRecord
{

	public readonly static Vw_contactlist_exportView TableUtils = Vw_contactlist_exportView.Instance;

	// Constructors
 
	protected BaseVw_contactlist_exportRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_contactlist_exportRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_contactlist_exportRecord_InsertingRecord);     
	}

	protected BaseVw_contactlist_exportRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_contactlist_exportRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_contactlist_exportRecord Vw_contactlist_exportRec = (Vw_contactlist_exportRecord)sender;
        if(Vw_contactlist_exportRec != null && !Vw_contactlist_exportRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_contactlist_exportRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_contactlist_exportRecord Vw_contactlist_exportRec = (Vw_contactlist_exportRecord)sender;
        Validate_Inserting();
        if(Vw_contactlist_exportRec != null && !Vw_contactlist_exportRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactName field.
	/// </summary>
	public ColumnValue GetCustContactNameValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactName field.
	/// </summary>
	public string GetCustContactNameFieldValue()
	{
		return this.GetValue(TableUtils.CustContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactName field.
	/// </summary>
	public void SetCustContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactTitle field.
	/// </summary>
	public ColumnValue GetCustContactTitleValue()
	{
		return this.GetValue(TableUtils.CustContactTitleColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactTitle field.
	/// </summary>
	public string GetCustContactTitleFieldValue()
	{
		return this.GetValue(TableUtils.CustContactTitleColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactTitle field.
	/// </summary>
	public void SetCustContactTitleFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactTitleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactTitle field.
	/// </summary>
	public void SetCustContactTitleFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactTitleColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactPhoneBusiness field.
	/// </summary>
	public ColumnValue GetCustContactPhoneBusinessValue()
	{
		return this.GetValue(TableUtils.CustContactPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactPhoneBusiness field.
	/// </summary>
	public string GetCustContactPhoneBusinessFieldValue()
	{
		return this.GetValue(TableUtils.CustContactPhoneBusinessColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactPhoneBusiness field.
	/// </summary>
	public void SetCustContactPhoneBusinessFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactPhoneBusiness field.
	/// </summary>
	public void SetCustContactPhoneBusinessFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactPhoneBusinessColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactPhoneMobile field.
	/// </summary>
	public ColumnValue GetCustContactPhoneMobileValue()
	{
		return this.GetValue(TableUtils.CustContactPhoneMobileColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactPhoneMobile field.
	/// </summary>
	public string GetCustContactPhoneMobileFieldValue()
	{
		return this.GetValue(TableUtils.CustContactPhoneMobileColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactPhoneMobile field.
	/// </summary>
	public void SetCustContactPhoneMobileFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactPhoneMobileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactPhoneMobile field.
	/// </summary>
	public void SetCustContactPhoneMobileFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactPhoneMobileColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactEmail field.
	/// </summary>
	public ColumnValue GetCustContactEmailValue()
	{
		return this.GetValue(TableUtils.CustContactEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactEmail field.
	/// </summary>
	public string GetCustContactEmailFieldValue()
	{
		return this.GetValue(TableUtils.CustContactEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactEmail field.
	/// </summary>
	public void SetCustContactEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactEmail field.
	/// </summary>
	public void SetCustContactEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustName field.
	/// </summary>
	public ColumnValue GetCustNameValue()
	{
		return this.GetValue(TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustName field.
	/// </summary>
	public string GetCustNameFieldValue()
	{
		return this.GetValue(TableUtils.CustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustAddress1 field.
	/// </summary>
	public ColumnValue GetCustAddress1Value()
	{
		return this.GetValue(TableUtils.CustAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustAddress1 field.
	/// </summary>
	public string GetCustAddress1FieldValue()
	{
		return this.GetValue(TableUtils.CustAddress1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustAddress1 field.
	/// </summary>
	public void SetCustAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustAddress1 field.
	/// </summary>
	public void SetCustAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustAddress1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustAddress2 field.
	/// </summary>
	public ColumnValue GetCustAddress2Value()
	{
		return this.GetValue(TableUtils.CustAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustAddress2 field.
	/// </summary>
	public string GetCustAddress2FieldValue()
	{
		return this.GetValue(TableUtils.CustAddress2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustAddress2 field.
	/// </summary>
	public void SetCustAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustAddress2 field.
	/// </summary>
	public void SetCustAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustAddress2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustCity field.
	/// </summary>
	public ColumnValue GetCustCityValue()
	{
		return this.GetValue(TableUtils.CustCityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustCity field.
	/// </summary>
	public string GetCustCityFieldValue()
	{
		return this.GetValue(TableUtils.CustCityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCity field.
	/// </summary>
	public void SetCustCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCity field.
	/// </summary>
	public void SetCustCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustProvince field.
	/// </summary>
	public ColumnValue GetCustProvinceValue()
	{
		return this.GetValue(TableUtils.CustProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustProvince field.
	/// </summary>
	public string GetCustProvinceFieldValue()
	{
		return this.GetValue(TableUtils.CustProvinceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustProvince field.
	/// </summary>
	public void SetCustProvinceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustProvince field.
	/// </summary>
	public void SetCustProvinceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustProvinceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustPostalCode field.
	/// </summary>
	public ColumnValue GetCustPostalCodeValue()
	{
		return this.GetValue(TableUtils.CustPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustPostalCode field.
	/// </summary>
	public string GetCustPostalCodeFieldValue()
	{
		return this.GetValue(TableUtils.CustPostalCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPostalCode field.
	/// </summary>
	public void SetCustPostalCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPostalCode field.
	/// </summary>
	public void SetCustPostalCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPostalCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustPhoneBusiness field.
	/// </summary>
	public ColumnValue GetCustPhoneBusinessValue()
	{
		return this.GetValue(TableUtils.CustPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustPhoneBusiness field.
	/// </summary>
	public string GetCustPhoneBusinessFieldValue()
	{
		return this.GetValue(TableUtils.CustPhoneBusinessColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPhoneBusiness field.
	/// </summary>
	public void SetCustPhoneBusinessFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPhoneBusiness field.
	/// </summary>
	public void SetCustPhoneBusinessFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPhoneBusinessColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustWebSite field.
	/// </summary>
	public ColumnValue GetCustWebSiteValue()
	{
		return this.GetValue(TableUtils.CustWebSiteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustWebSite field.
	/// </summary>
	public string GetCustWebSiteFieldValue()
	{
		return this.GetValue(TableUtils.CustWebSiteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustWebSite field.
	/// </summary>
	public void SetCustWebSiteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustWebSiteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustWebSite field.
	/// </summary>
	public void SetCustWebSiteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustWebSiteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactType field.
	/// </summary>
	public ColumnValue GetCustContactTypeValue()
	{
		return this.GetValue(TableUtils.CustContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactType field.
	/// </summary>
	public Byte GetCustContactTypeFieldValue()
	{
		return this.GetValue(TableUtils.CustContactTypeColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactType field.
	/// </summary>
	public void SetCustContactTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactType field.
	/// </summary>
	public void SetCustContactTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactType field.
	/// </summary>
	public void SetCustContactTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactType field.
	/// </summary>
	public void SetCustContactTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactType field.
	/// </summary>
	public void SetCustContactTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.customer_active field.
	/// </summary>
	public ColumnValue Getcustomer_activeValue()
	{
		return this.GetValue(TableUtils.customer_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.customer_active field.
	/// </summary>
	public bool Getcustomer_activeFieldValue()
	{
		return this.GetValue(TableUtils.customer_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_active field.
	/// </summary>
	public void Setcustomer_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_active field.
	/// </summary>
	public void Setcustomer_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_active field.
	/// </summary>
	public void Setcustomer_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustFax field.
	/// </summary>
	public ColumnValue GetCustFaxValue()
	{
		return this.GetValue(TableUtils.CustFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustFax field.
	/// </summary>
	public string GetCustFaxFieldValue()
	{
		return this.GetValue(TableUtils.CustFaxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustFax field.
	/// </summary>
	public void SetCustFaxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustFax field.
	/// </summary>
	public void SetCustFaxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustFaxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.Expr1 field.
	/// </summary>
	public ColumnValue GetExpr1Value()
	{
		return this.GetValue(TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.Expr1 field.
	/// </summary>
	public Int32 GetExpr1FieldValue()
	{
		return this.GetValue(TableUtils.Expr1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(string val)
	{
		this.SetString(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.customer_type field.
	/// </summary>
	public ColumnValue Getcustomer_typeValue()
	{
		return this.GetValue(TableUtils.customer_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.customer_type field.
	/// </summary>
	public string Getcustomer_typeFieldValue()
	{
		return this.GetValue(TableUtils.customer_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_type field.
	/// </summary>
	public void Setcustomer_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_type field.
	/// </summary>
	public void Setcustomer_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.customer_bill_email field.
	/// </summary>
	public ColumnValue Getcustomer_bill_emailValue()
	{
		return this.GetValue(TableUtils.customer_bill_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.customer_bill_email field.
	/// </summary>
	public bool Getcustomer_bill_emailFieldValue()
	{
		return this.GetValue(TableUtils.customer_bill_emailColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_bill_email field.
	/// </summary>
	public void Setcustomer_bill_emailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_bill_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_bill_email field.
	/// </summary>
	public void Setcustomer_bill_emailFieldValue(string val)
	{
		this.SetString(val, TableUtils.customer_bill_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_bill_email field.
	/// </summary>
	public void Setcustomer_bill_emailFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_bill_emailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactFax field.
	/// </summary>
	public ColumnValue GetCustContactFaxValue()
	{
		return this.GetValue(TableUtils.CustContactFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactFax field.
	/// </summary>
	public string GetCustContactFaxFieldValue()
	{
		return this.GetValue(TableUtils.CustContactFaxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactFax field.
	/// </summary>
	public void SetCustContactFaxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactFax field.
	/// </summary>
	public void SetCustContactFaxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactFaxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactKey field.
	/// </summary>
	public ColumnValue GetCustContactKeyValue()
	{
		return this.GetValue(TableUtils.CustContactKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContactKey field.
	/// </summary>
	public Int32 GetCustContactKeyFieldValue()
	{
		return this.GetValue(TableUtils.CustContactKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactKey field.
	/// </summary>
	public void SetCustContactKeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContactKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactKey field.
	/// </summary>
	public void SetCustContactKeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustContactKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactKey field.
	/// </summary>
	public void SetCustContactKeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactKey field.
	/// </summary>
	public void SetCustContactKeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactKey field.
	/// </summary>
	public void SetCustContactKeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContactKeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustCode field.
	/// </summary>
	public ColumnValue GetCustCodeValue()
	{
		return this.GetValue(TableUtils.CustCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustCode field.
	/// </summary>
	public string GetCustCodeFieldValue()
	{
		return this.GetValue(TableUtils.CustCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCode field.
	/// </summary>
	public void SetCustCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCode field.
	/// </summary>
	public void SetCustCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustNo field.
	/// </summary>
	public ColumnValue GetCustNoValue()
	{
		return this.GetValue(TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustNo field.
	/// </summary>
	public Int32 GetCustNoFieldValue()
	{
		return this.GetValue(TableUtils.CustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.SessionID field.
	/// </summary>
	public ColumnValue GetSessionIDValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.SessionID field.
	/// </summary>
	public Int32 GetSessionIDFieldValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustCreatedBy field.
	/// </summary>
	public ColumnValue GetCustCreatedByValue()
	{
		return this.GetValue(TableUtils.CustCreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustCreatedBy field.
	/// </summary>
	public Int32 GetCustCreatedByFieldValue()
	{
		return this.GetValue(TableUtils.CustCreatedByColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCreatedBy field.
	/// </summary>
	public void SetCustCreatedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustCreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCreatedBy field.
	/// </summary>
	public void SetCustCreatedByFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustCreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCreatedBy field.
	/// </summary>
	public void SetCustCreatedByFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCreatedBy field.
	/// </summary>
	public void SetCustCreatedByFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCreatedBy field.
	/// </summary>
	public void SetCustCreatedByFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustCreatedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContact_active field.
	/// </summary>
	public ColumnValue GetCustContact_activeValue()
	{
		return this.GetValue(TableUtils.CustContact_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContact_active field.
	/// </summary>
	public bool GetCustContact_activeFieldValue()
	{
		return this.GetValue(TableUtils.CustContact_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_active field.
	/// </summary>
	public void SetCustContact_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContact_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_active field.
	/// </summary>
	public void SetCustContact_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustContact_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_active field.
	/// </summary>
	public void SetCustContact_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContact_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContact_AP field.
	/// </summary>
	public ColumnValue GetCustContact_APValue()
	{
		return this.GetValue(TableUtils.CustContact_APColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContact_AP field.
	/// </summary>
	public bool GetCustContact_APFieldValue()
	{
		return this.GetValue(TableUtils.CustContact_APColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_AP field.
	/// </summary>
	public void SetCustContact_APFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContact_APColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_AP field.
	/// </summary>
	public void SetCustContact_APFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustContact_APColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_AP field.
	/// </summary>
	public void SetCustContact_APFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContact_APColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContact_QS field.
	/// </summary>
	public ColumnValue GetCustContact_QSValue()
	{
		return this.GetValue(TableUtils.CustContact_QSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustContact_QS field.
	/// </summary>
	public bool GetCustContact_QSFieldValue()
	{
		return this.GetValue(TableUtils.CustContact_QSColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_QS field.
	/// </summary>
	public void SetCustContact_QSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustContact_QSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_QS field.
	/// </summary>
	public void SetCustContact_QSFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustContact_QSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_QS field.
	/// </summary>
	public void SetCustContact_QSFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustContact_QSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.isActive field.
	/// </summary>
	public ColumnValue GetisActiveValue()
	{
		return this.GetValue(TableUtils.isActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.isActive field.
	/// </summary>
	public bool GetisActiveFieldValue()
	{
		return this.GetValue(TableUtils.isActiveColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.isActive field.
	/// </summary>
	public void SetisActiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.isActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.isActive field.
	/// </summary>
	public void SetisActiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.isActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.isActive field.
	/// </summary>
	public void SetisActiveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.isActiveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustPrimary field.
	/// </summary>
	public ColumnValue GetCustPrimaryValue()
	{
		return this.GetValue(TableUtils.CustPrimaryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustPrimary field.
	/// </summary>
	public bool GetCustPrimaryFieldValue()
	{
		return this.GetValue(TableUtils.CustPrimaryColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPrimary field.
	/// </summary>
	public void SetCustPrimaryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustPrimaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPrimary field.
	/// </summary>
	public void SetCustPrimaryFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustPrimaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPrimary field.
	/// </summary>
	public void SetCustPrimaryFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustPrimaryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustSecondary field.
	/// </summary>
	public ColumnValue GetCustSecondaryValue()
	{
		return this.GetValue(TableUtils.CustSecondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contactlist_export_.CustSecondary field.
	/// </summary>
	public bool GetCustSecondaryFieldValue()
	{
		return this.GetValue(TableUtils.CustSecondaryColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustSecondary field.
	/// </summary>
	public void SetCustSecondaryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustSecondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustSecondary field.
	/// </summary>
	public void SetCustSecondaryFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustSecondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustSecondary field.
	/// </summary>
	public void SetCustSecondaryFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustSecondaryColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContactName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactName field.
	/// </summary>
	public string CustContactNameDefault
	{
		get
		{
			return TableUtils.CustContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContactTitle field.
	/// </summary>
	public string CustContactTitle
	{
		get
		{
			return this.GetValue(TableUtils.CustContactTitleColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContactTitleColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContactTitleSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContactTitleColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactTitle field.
	/// </summary>
	public string CustContactTitleDefault
	{
		get
		{
			return TableUtils.CustContactTitleColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContactPhoneBusiness field.
	/// </summary>
	public string CustContactPhoneBusiness
	{
		get
		{
			return this.GetValue(TableUtils.CustContactPhoneBusinessColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContactPhoneBusinessColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContactPhoneBusinessSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContactPhoneBusinessColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactPhoneBusiness field.
	/// </summary>
	public string CustContactPhoneBusinessDefault
	{
		get
		{
			return TableUtils.CustContactPhoneBusinessColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContactPhoneMobile field.
	/// </summary>
	public string CustContactPhoneMobile
	{
		get
		{
			return this.GetValue(TableUtils.CustContactPhoneMobileColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContactPhoneMobileColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContactPhoneMobileSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContactPhoneMobileColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactPhoneMobile field.
	/// </summary>
	public string CustContactPhoneMobileDefault
	{
		get
		{
			return TableUtils.CustContactPhoneMobileColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContactEmail field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactEmail field.
	/// </summary>
	public string CustContactEmailDefault
	{
		get
		{
			return TableUtils.CustContactEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustName field.
	/// </summary>
	public string CustNameDefault
	{
		get
		{
			return TableUtils.CustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustAddress1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustAddress1 field.
	/// </summary>
	public string CustAddress1Default
	{
		get
		{
			return TableUtils.CustAddress1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustAddress2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustAddress2 field.
	/// </summary>
	public string CustAddress2Default
	{
		get
		{
			return TableUtils.CustAddress2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustCity field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCity field.
	/// </summary>
	public string CustCityDefault
	{
		get
		{
			return TableUtils.CustCityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustProvince field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustProvince field.
	/// </summary>
	public string CustProvinceDefault
	{
		get
		{
			return TableUtils.CustProvinceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustPostalCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPostalCode field.
	/// </summary>
	public string CustPostalCodeDefault
	{
		get
		{
			return TableUtils.CustPostalCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustPhoneBusiness field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPhoneBusiness field.
	/// </summary>
	public string CustPhoneBusinessDefault
	{
		get
		{
			return TableUtils.CustPhoneBusinessColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustWebSite field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustWebSite field.
	/// </summary>
	public string CustWebSiteDefault
	{
		get
		{
			return TableUtils.CustWebSiteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContactType field.
	/// </summary>
	public Byte CustContactType
	{
		get
		{
			return this.GetValue(TableUtils.CustContactTypeColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContactTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContactTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContactTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactType field.
	/// </summary>
	public string CustContactTypeDefault
	{
		get
		{
			return TableUtils.CustContactTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.customer_active field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_active field.
	/// </summary>
	public string customer_activeDefault
	{
		get
		{
			return TableUtils.customer_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustFax field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustFax field.
	/// </summary>
	public string CustFaxDefault
	{
		get
		{
			return TableUtils.CustFaxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.Expr1 field.
	/// </summary>
	public Int32 Expr1
	{
		get
		{
			return this.GetValue(TableUtils.Expr1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Expr1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Expr1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Expr1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.Expr1 field.
	/// </summary>
	public string Expr1Default
	{
		get
		{
			return TableUtils.Expr1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.customer_type field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_type field.
	/// </summary>
	public string customer_typeDefault
	{
		get
		{
			return TableUtils.customer_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.customer_bill_email field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.customer_bill_email field.
	/// </summary>
	public string customer_bill_emailDefault
	{
		get
		{
			return TableUtils.customer_bill_emailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContactFax field.
	/// </summary>
	public string CustContactFax
	{
		get
		{
			return this.GetValue(TableUtils.CustContactFaxColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustContactFaxColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContactFaxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContactFaxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactFax field.
	/// </summary>
	public string CustContactFaxDefault
	{
		get
		{
			return TableUtils.CustContactFaxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContactKey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContactKey field.
	/// </summary>
	public string CustContactKeyDefault
	{
		get
		{
			return TableUtils.CustContactKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCode field.
	/// </summary>
	public string CustCodeDefault
	{
		get
		{
			return TableUtils.CustCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustNo field.
	/// </summary>
	public string CustNoDefault
	{
		get
		{
			return TableUtils.CustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.SessionID field.
	/// </summary>
	public Int32 SessionID
	{
		get
		{
			return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SessionIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SessionIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SessionIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.SessionID field.
	/// </summary>
	public string SessionIDDefault
	{
		get
		{
			return TableUtils.SessionIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustCreatedBy field.
	/// </summary>
	public Int32 CustCreatedBy
	{
		get
		{
			return this.GetValue(TableUtils.CustCreatedByColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustCreatedByColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustCreatedBySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustCreatedByColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustCreatedBy field.
	/// </summary>
	public string CustCreatedByDefault
	{
		get
		{
			return TableUtils.CustCreatedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContact_active field.
	/// </summary>
	public bool CustContact_active
	{
		get
		{
			return this.GetValue(TableUtils.CustContact_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustContact_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContact_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContact_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_active field.
	/// </summary>
	public string CustContact_activeDefault
	{
		get
		{
			return TableUtils.CustContact_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContact_AP field.
	/// </summary>
	public bool CustContact_AP
	{
		get
		{
			return this.GetValue(TableUtils.CustContact_APColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustContact_APColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContact_APSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContact_APColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_AP field.
	/// </summary>
	public string CustContact_APDefault
	{
		get
		{
			return TableUtils.CustContact_APColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustContact_QS field.
	/// </summary>
	public bool CustContact_QS
	{
		get
		{
			return this.GetValue(TableUtils.CustContact_QSColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustContact_QSColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustContact_QSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustContact_QSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustContact_QS field.
	/// </summary>
	public string CustContact_QSDefault
	{
		get
		{
			return TableUtils.CustContact_QSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.isActive field.
	/// </summary>
	public bool isActive
	{
		get
		{
			return this.GetValue(TableUtils.isActiveColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.isActiveColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool isActiveSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.isActiveColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.isActive field.
	/// </summary>
	public string isActiveDefault
	{
		get
		{
			return TableUtils.isActiveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustPrimary field.
	/// </summary>
	public bool CustPrimary
	{
		get
		{
			return this.GetValue(TableUtils.CustPrimaryColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustPrimaryColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustPrimarySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustPrimaryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustPrimary field.
	/// </summary>
	public string CustPrimaryDefault
	{
		get
		{
			return TableUtils.CustPrimaryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contactlist_export_.CustSecondary field.
	/// </summary>
	public bool CustSecondary
	{
		get
		{
			return this.GetValue(TableUtils.CustSecondaryColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CustSecondaryColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustSecondarySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustSecondaryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contactlist_export_.CustSecondary field.
	/// </summary>
	public string CustSecondaryDefault
	{
		get
		{
			return TableUtils.CustSecondaryColumn.DefaultValue;
		}
	}


#endregion

}

}
