// This class is "generated" and will be overwritten.
// Your customizations should be made in LedgerInvoicesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="LedgerInvoicesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="LedgerInvoicesTable"></see> class.
/// </remarks>
/// <seealso cref="LedgerInvoicesTable"></seealso>
/// <seealso cref="LedgerInvoicesRecord"></seealso>
public class BaseLedgerInvoicesRecord : PrimaryKeyRecord
{

	public readonly static LedgerInvoicesTable TableUtils = LedgerInvoicesTable.Instance;

	// Constructors
 
	protected BaseLedgerInvoicesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.LedgerInvoicesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.LedgerInvoicesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.LedgerInvoicesRecord_ReadRecord); 
	}

	protected BaseLedgerInvoicesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void LedgerInvoicesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                LedgerInvoicesRecord LedgerInvoicesRec = (LedgerInvoicesRecord)sender;
        if(LedgerInvoicesRec != null && !LedgerInvoicesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void LedgerInvoicesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                LedgerInvoicesRecord LedgerInvoicesRec = (LedgerInvoicesRecord)sender;
        Validate_Inserting();
        if(LedgerInvoicesRec != null && !LedgerInvoicesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void LedgerInvoicesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                LedgerInvoicesRecord LedgerInvoicesRec = (LedgerInvoicesRecord)sender;
        Validate_Updating();
        if(LedgerInvoicesRec != null && !LedgerInvoicesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgBillingNo field.
	/// </summary>
	public ColumnValue GetLdgBillingNoValue()
	{
		return this.GetValue(TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgBillingNo field.
	/// </summary>
	public Int32 GetLdgBillingNoFieldValue()
	{
		return this.GetValue(TableUtils.LdgBillingNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBillingNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgExported field.
	/// </summary>
	public ColumnValue GetLdgExportedValue()
	{
		return this.GetValue(TableUtils.LdgExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgExported field.
	/// </summary>
	public DateTime GetLdgExportedFieldValue()
	{
		return this.GetValue(TableUtils.LdgExportedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExported field.
	/// </summary>
	public void SetLdgExportedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExported field.
	/// </summary>
	public void SetLdgExportedFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExported field.
	/// </summary>
	public void SetLdgExportedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgExportedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgExportInclude field.
	/// </summary>
	public ColumnValue GetLdgExportIncludeValue()
	{
		return this.GetValue(TableUtils.LdgExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgExportInclude field.
	/// </summary>
	public bool GetLdgExportIncludeFieldValue()
	{
		return this.GetValue(TableUtils.LdgExportIncludeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExportInclude field.
	/// </summary>
	public void SetLdgExportIncludeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExportInclude field.
	/// </summary>
	public void SetLdgExportIncludeFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExportInclude field.
	/// </summary>
	public void SetLdgExportIncludeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgExportIncludeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgExportRecordChanged field.
	/// </summary>
	public ColumnValue GetLdgExportRecordChangedValue()
	{
		return this.GetValue(TableUtils.LdgExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgExportRecordChanged field.
	/// </summary>
	public bool GetLdgExportRecordChangedFieldValue()
	{
		return this.GetValue(TableUtils.LdgExportRecordChangedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExportRecordChanged field.
	/// </summary>
	public void SetLdgExportRecordChangedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExportRecordChanged field.
	/// </summary>
	public void SetLdgExportRecordChangedFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExportRecordChanged field.
	/// </summary>
	public void SetLdgExportRecordChangedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgExportRecordChangedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgFormNo field.
	/// </summary>
	public ColumnValue GetLdgFormNoValue()
	{
		return this.GetValue(TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgFormNo field.
	/// </summary>
	public Int32 GetLdgFormNoFieldValue()
	{
		return this.GetValue(TableUtils.LdgFormNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgFormType field.
	/// </summary>
	public ColumnValue GetLdgFormTypeValue()
	{
		return this.GetValue(TableUtils.LdgFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgFormType field.
	/// </summary>
	public string GetLdgFormTypeFieldValue()
	{
		return this.GetValue(TableUtils.LdgFormTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgFormType field.
	/// </summary>
	public void SetLdgFormTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgFormType field.
	/// </summary>
	public void SetLdgFormTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgGrandTotal field.
	/// </summary>
	public ColumnValue GetLdgGrandTotalValue()
	{
		return this.GetValue(TableUtils.LdgGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgGrandTotal field.
	/// </summary>
	public Decimal GetLdgGrandTotalFieldValue()
	{
		return this.GetValue(TableUtils.LdgGrandTotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgGrandTotal field.
	/// </summary>
	public void SetLdgGrandTotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgGrandTotal field.
	/// </summary>
	public void SetLdgGrandTotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgGrandTotal field.
	/// </summary>
	public void SetLdgGrandTotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgGrandTotal field.
	/// </summary>
	public void SetLdgGrandTotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgGrandTotal field.
	/// </summary>
	public void SetLdgGrandTotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgGrandTotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgHandling field.
	/// </summary>
	public ColumnValue GetLdgHandlingValue()
	{
		return this.GetValue(TableUtils.LdgHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgHandling field.
	/// </summary>
	public Decimal GetLdgHandlingFieldValue()
	{
		return this.GetValue(TableUtils.LdgHandlingColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgHandling field.
	/// </summary>
	public void SetLdgHandlingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgHandling field.
	/// </summary>
	public void SetLdgHandlingFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgHandling field.
	/// </summary>
	public void SetLdgHandlingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgHandling field.
	/// </summary>
	public void SetLdgHandlingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgHandling field.
	/// </summary>
	public void SetLdgHandlingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgHandlingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgKey field.
	/// </summary>
	public ColumnValue GetLdgKeyValue()
	{
		return this.GetValue(TableUtils.LdgKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgKey field.
	/// </summary>
	public Int32 GetLdgKeyFieldValue()
	{
		return this.GetValue(TableUtils.LdgKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgLabor field.
	/// </summary>
	public ColumnValue GetLdgLaborValue()
	{
		return this.GetValue(TableUtils.LdgLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgLabor field.
	/// </summary>
	public Decimal GetLdgLaborFieldValue()
	{
		return this.GetValue(TableUtils.LdgLaborColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgLabor field.
	/// </summary>
	public void SetLdgLaborFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgLabor field.
	/// </summary>
	public void SetLdgLaborFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgLabor field.
	/// </summary>
	public void SetLdgLaborFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgLabor field.
	/// </summary>
	public void SetLdgLaborFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgLabor field.
	/// </summary>
	public void SetLdgLaborFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgLaborColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgParts field.
	/// </summary>
	public ColumnValue GetLdgPartsValue()
	{
		return this.GetValue(TableUtils.LdgPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgParts field.
	/// </summary>
	public Decimal GetLdgPartsFieldValue()
	{
		return this.GetValue(TableUtils.LdgPartsColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgParts field.
	/// </summary>
	public void SetLdgPartsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgParts field.
	/// </summary>
	public void SetLdgPartsFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgParts field.
	/// </summary>
	public void SetLdgPartsFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgParts field.
	/// </summary>
	public void SetLdgPartsFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgParts field.
	/// </summary>
	public void SetLdgPartsFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPartsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgRecDate field.
	/// </summary>
	public ColumnValue GetLdgRecDateValue()
	{
		return this.GetValue(TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgRecDate field.
	/// </summary>
	public DateTime GetLdgRecDateFieldValue()
	{
		return this.GetValue(TableUtils.LdgRecDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgRecDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgShipping field.
	/// </summary>
	public ColumnValue GetLdgShippingValue()
	{
		return this.GetValue(TableUtils.LdgShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgShipping field.
	/// </summary>
	public Decimal GetLdgShippingFieldValue()
	{
		return this.GetValue(TableUtils.LdgShippingColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgShipping field.
	/// </summary>
	public void SetLdgShippingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgShipping field.
	/// </summary>
	public void SetLdgShippingFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgShipping field.
	/// </summary>
	public void SetLdgShippingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgShipping field.
	/// </summary>
	public void SetLdgShippingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgShipping field.
	/// </summary>
	public void SetLdgShippingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgShippingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTax1 field.
	/// </summary>
	public ColumnValue GetLdgTax1Value()
	{
		return this.GetValue(TableUtils.LdgTax1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTax1 field.
	/// </summary>
	public Decimal GetLdgTax1FieldValue()
	{
		return this.GetValue(TableUtils.LdgTax1Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax1 field.
	/// </summary>
	public void SetLdgTax1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgTax1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax1 field.
	/// </summary>
	public void SetLdgTax1FieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgTax1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax1 field.
	/// </summary>
	public void SetLdgTax1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTax1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax1 field.
	/// </summary>
	public void SetLdgTax1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTax1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax1 field.
	/// </summary>
	public void SetLdgTax1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTax1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTax2 field.
	/// </summary>
	public ColumnValue GetLdgTax2Value()
	{
		return this.GetValue(TableUtils.LdgTax2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTax2 field.
	/// </summary>
	public Decimal GetLdgTax2FieldValue()
	{
		return this.GetValue(TableUtils.LdgTax2Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax2 field.
	/// </summary>
	public void SetLdgTax2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgTax2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax2 field.
	/// </summary>
	public void SetLdgTax2FieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgTax2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax2 field.
	/// </summary>
	public void SetLdgTax2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTax2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax2 field.
	/// </summary>
	public void SetLdgTax2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTax2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax2 field.
	/// </summary>
	public void SetLdgTax2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTax2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTax3 field.
	/// </summary>
	public ColumnValue GetLdgTax3Value()
	{
		return this.GetValue(TableUtils.LdgTax3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTax3 field.
	/// </summary>
	public Decimal GetLdgTax3FieldValue()
	{
		return this.GetValue(TableUtils.LdgTax3Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax3 field.
	/// </summary>
	public void SetLdgTax3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgTax3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax3 field.
	/// </summary>
	public void SetLdgTax3FieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgTax3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax3 field.
	/// </summary>
	public void SetLdgTax3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTax3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax3 field.
	/// </summary>
	public void SetLdgTax3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTax3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax3 field.
	/// </summary>
	public void SetLdgTax3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTax3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTravel field.
	/// </summary>
	public ColumnValue GetLdgTravelValue()
	{
		return this.GetValue(TableUtils.LdgTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTravel field.
	/// </summary>
	public Decimal GetLdgTravelFieldValue()
	{
		return this.GetValue(TableUtils.LdgTravelColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTravel field.
	/// </summary>
	public void SetLdgTravelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTravel field.
	/// </summary>
	public void SetLdgTravelFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTravel field.
	/// </summary>
	public void SetLdgTravelFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTravel field.
	/// </summary>
	public void SetLdgTravelFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTravel field.
	/// </summary>
	public void SetLdgTravelFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTravelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTrnDate field.
	/// </summary>
	public ColumnValue GetLdgTrnDateValue()
	{
		return this.GetValue(TableUtils.LdgTrnDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.LdgTrnDate field.
	/// </summary>
	public DateTime GetLdgTrnDateFieldValue()
	{
		return this.GetValue(TableUtils.LdgTrnDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTrnDate field.
	/// </summary>
	public void SetLdgTrnDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgTrnDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTrnDate field.
	/// </summary>
	public void SetLdgTrnDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgTrnDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTrnDate field.
	/// </summary>
	public void SetLdgTrnDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTrnDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInvoices_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgBillingNo field.
	/// </summary>
	public Int32 LdgBillingNo
	{
		get
		{
			return this.GetValue(TableUtils.LdgBillingNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgBillingNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgBillingNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgBillingNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgBillingNo field.
	/// </summary>
	public string LdgBillingNoDefault
	{
		get
		{
			return TableUtils.LdgBillingNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgExported field.
	/// </summary>
	public DateTime LdgExported
	{
		get
		{
			return this.GetValue(TableUtils.LdgExportedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgExportedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgExportedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgExportedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExported field.
	/// </summary>
	public string LdgExportedDefault
	{
		get
		{
			return TableUtils.LdgExportedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgExportInclude field.
	/// </summary>
	public bool LdgExportInclude
	{
		get
		{
			return this.GetValue(TableUtils.LdgExportIncludeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.LdgExportIncludeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgExportIncludeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgExportIncludeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExportInclude field.
	/// </summary>
	public string LdgExportIncludeDefault
	{
		get
		{
			return TableUtils.LdgExportIncludeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgExportRecordChanged field.
	/// </summary>
	public bool LdgExportRecordChanged
	{
		get
		{
			return this.GetValue(TableUtils.LdgExportRecordChangedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.LdgExportRecordChangedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgExportRecordChangedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgExportRecordChangedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgExportRecordChanged field.
	/// </summary>
	public string LdgExportRecordChangedDefault
	{
		get
		{
			return TableUtils.LdgExportRecordChangedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgFormNo field.
	/// </summary>
	public Int32 LdgFormNo
	{
		get
		{
			return this.GetValue(TableUtils.LdgFormNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgFormNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgFormNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgFormNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgFormNo field.
	/// </summary>
	public string LdgFormNoDefault
	{
		get
		{
			return TableUtils.LdgFormNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgFormType field.
	/// </summary>
	public string LdgFormType
	{
		get
		{
			return this.GetValue(TableUtils.LdgFormTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgFormTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgFormTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgFormTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgFormType field.
	/// </summary>
	public string LdgFormTypeDefault
	{
		get
		{
			return TableUtils.LdgFormTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgGrandTotal field.
	/// </summary>
	public Decimal LdgGrandTotal
	{
		get
		{
			return this.GetValue(TableUtils.LdgGrandTotalColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgGrandTotalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgGrandTotalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgGrandTotalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgGrandTotal field.
	/// </summary>
	public string LdgGrandTotalDefault
	{
		get
		{
			return TableUtils.LdgGrandTotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgHandling field.
	/// </summary>
	public Decimal LdgHandling
	{
		get
		{
			return this.GetValue(TableUtils.LdgHandlingColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgHandlingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgHandlingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgHandlingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgHandling field.
	/// </summary>
	public string LdgHandlingDefault
	{
		get
		{
			return TableUtils.LdgHandlingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgKey field.
	/// </summary>
	public Int32 LdgKey
	{
		get
		{
			return this.GetValue(TableUtils.LdgKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgKey field.
	/// </summary>
	public string LdgKeyDefault
	{
		get
		{
			return TableUtils.LdgKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgLabor field.
	/// </summary>
	public Decimal LdgLabor
	{
		get
		{
			return this.GetValue(TableUtils.LdgLaborColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgLaborColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgLaborSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgLaborColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgLabor field.
	/// </summary>
	public string LdgLaborDefault
	{
		get
		{
			return TableUtils.LdgLaborColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgParts field.
	/// </summary>
	public Decimal LdgParts
	{
		get
		{
			return this.GetValue(TableUtils.LdgPartsColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgPartsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgPartsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgPartsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgParts field.
	/// </summary>
	public string LdgPartsDefault
	{
		get
		{
			return TableUtils.LdgPartsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgRecDate field.
	/// </summary>
	public DateTime LdgRecDate
	{
		get
		{
			return this.GetValue(TableUtils.LdgRecDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgRecDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgRecDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgRecDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgRecDate field.
	/// </summary>
	public string LdgRecDateDefault
	{
		get
		{
			return TableUtils.LdgRecDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgShipping field.
	/// </summary>
	public Decimal LdgShipping
	{
		get
		{
			return this.GetValue(TableUtils.LdgShippingColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgShippingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgShippingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgShippingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgShipping field.
	/// </summary>
	public string LdgShippingDefault
	{
		get
		{
			return TableUtils.LdgShippingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgTax1 field.
	/// </summary>
	public Decimal LdgTax1
	{
		get
		{
			return this.GetValue(TableUtils.LdgTax1Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgTax1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgTax1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgTax1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax1 field.
	/// </summary>
	public string LdgTax1Default
	{
		get
		{
			return TableUtils.LdgTax1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgTax2 field.
	/// </summary>
	public Decimal LdgTax2
	{
		get
		{
			return this.GetValue(TableUtils.LdgTax2Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgTax2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgTax2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgTax2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax2 field.
	/// </summary>
	public string LdgTax2Default
	{
		get
		{
			return TableUtils.LdgTax2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgTax3 field.
	/// </summary>
	public Decimal LdgTax3
	{
		get
		{
			return this.GetValue(TableUtils.LdgTax3Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgTax3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgTax3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgTax3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTax3 field.
	/// </summary>
	public string LdgTax3Default
	{
		get
		{
			return TableUtils.LdgTax3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgTravel field.
	/// </summary>
	public Decimal LdgTravel
	{
		get
		{
			return this.GetValue(TableUtils.LdgTravelColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgTravelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgTravelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgTravelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTravel field.
	/// </summary>
	public string LdgTravelDefault
	{
		get
		{
			return TableUtils.LdgTravelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.LdgTrnDate field.
	/// </summary>
	public DateTime LdgTrnDate
	{
		get
		{
			return this.GetValue(TableUtils.LdgTrnDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgTrnDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgTrnDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgTrnDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.LdgTrnDate field.
	/// </summary>
	public string LdgTrnDateDefault
	{
		get
		{
			return TableUtils.LdgTrnDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInvoices_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInvoices_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}


#endregion
}

}
