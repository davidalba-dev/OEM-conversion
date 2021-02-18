// This class is "generated" and will be overwritten.
// Your customizations should be made in LedgerPaymentsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="LedgerPaymentsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="LedgerPaymentsTable"></see> class.
/// </remarks>
/// <seealso cref="LedgerPaymentsTable"></seealso>
/// <seealso cref="LedgerPaymentsRecord"></seealso>
public class BaseLedgerPaymentsRecord : PrimaryKeyRecord
{

	public readonly static LedgerPaymentsTable TableUtils = LedgerPaymentsTable.Instance;

	// Constructors
 
	protected BaseLedgerPaymentsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.LedgerPaymentsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.LedgerPaymentsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.LedgerPaymentsRecord_ReadRecord); 
	}

	protected BaseLedgerPaymentsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void LedgerPaymentsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                LedgerPaymentsRecord LedgerPaymentsRec = (LedgerPaymentsRecord)sender;
        if(LedgerPaymentsRec != null && !LedgerPaymentsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void LedgerPaymentsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                LedgerPaymentsRecord LedgerPaymentsRec = (LedgerPaymentsRecord)sender;
        Validate_Inserting();
        if(LedgerPaymentsRec != null && !LedgerPaymentsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void LedgerPaymentsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                LedgerPaymentsRecord LedgerPaymentsRec = (LedgerPaymentsRecord)sender;
        Validate_Updating();
        if(LedgerPaymentsRec != null && !LedgerPaymentsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgBillingNo field.
	/// </summary>
	public ColumnValue GetLdgBillingNoValue()
	{
		return this.GetValue(TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgBillingNo field.
	/// </summary>
	public Int32 GetLdgBillingNoFieldValue()
	{
		return this.GetValue(TableUtils.LdgBillingNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgBillingNo field.
	/// </summary>
	public void SetLdgBillingNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBillingNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgExported field.
	/// </summary>
	public ColumnValue GetLdgExportedValue()
	{
		return this.GetValue(TableUtils.LdgExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgExported field.
	/// </summary>
	public DateTime GetLdgExportedFieldValue()
	{
		return this.GetValue(TableUtils.LdgExportedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExported field.
	/// </summary>
	public void SetLdgExportedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExported field.
	/// </summary>
	public void SetLdgExportedFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExported field.
	/// </summary>
	public void SetLdgExportedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgExportedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgExportInclude field.
	/// </summary>
	public ColumnValue GetLdgExportIncludeValue()
	{
		return this.GetValue(TableUtils.LdgExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgExportInclude field.
	/// </summary>
	public bool GetLdgExportIncludeFieldValue()
	{
		return this.GetValue(TableUtils.LdgExportIncludeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExportInclude field.
	/// </summary>
	public void SetLdgExportIncludeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExportInclude field.
	/// </summary>
	public void SetLdgExportIncludeFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExportInclude field.
	/// </summary>
	public void SetLdgExportIncludeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgExportIncludeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgExportRecordChanged field.
	/// </summary>
	public ColumnValue GetLdgExportRecordChangedValue()
	{
		return this.GetValue(TableUtils.LdgExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgExportRecordChanged field.
	/// </summary>
	public bool GetLdgExportRecordChangedFieldValue()
	{
		return this.GetValue(TableUtils.LdgExportRecordChangedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExportRecordChanged field.
	/// </summary>
	public void SetLdgExportRecordChangedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExportRecordChanged field.
	/// </summary>
	public void SetLdgExportRecordChangedFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExportRecordChanged field.
	/// </summary>
	public void SetLdgExportRecordChangedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgExportRecordChangedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgFormNo field.
	/// </summary>
	public ColumnValue GetLdgFormNoValue()
	{
		return this.GetValue(TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgFormNo field.
	/// </summary>
	public Int32 GetLdgFormNoFieldValue()
	{
		return this.GetValue(TableUtils.LdgFormNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgFormType field.
	/// </summary>
	public ColumnValue GetLdgFormTypeValue()
	{
		return this.GetValue(TableUtils.LdgFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgFormType field.
	/// </summary>
	public string GetLdgFormTypeFieldValue()
	{
		return this.GetValue(TableUtils.LdgFormTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgFormType field.
	/// </summary>
	public void SetLdgFormTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgFormType field.
	/// </summary>
	public void SetLdgFormTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgKey field.
	/// </summary>
	public ColumnValue GetLdgKeyValue()
	{
		return this.GetValue(TableUtils.LdgKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgKey field.
	/// </summary>
	public Int32 GetLdgKeyFieldValue()
	{
		return this.GetValue(TableUtils.LdgKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgPayment field.
	/// </summary>
	public ColumnValue GetLdgPaymentValue()
	{
		return this.GetValue(TableUtils.LdgPaymentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgPayment field.
	/// </summary>
	public Decimal GetLdgPaymentFieldValue()
	{
		return this.GetValue(TableUtils.LdgPaymentColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayment field.
	/// </summary>
	public void SetLdgPaymentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgPaymentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayment field.
	/// </summary>
	public void SetLdgPaymentFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgPaymentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayment field.
	/// </summary>
	public void SetLdgPaymentFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPaymentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayment field.
	/// </summary>
	public void SetLdgPaymentFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPaymentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayment field.
	/// </summary>
	public void SetLdgPaymentFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPaymentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgPayMethod field.
	/// </summary>
	public ColumnValue GetLdgPayMethodValue()
	{
		return this.GetValue(TableUtils.LdgPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgPayMethod field.
	/// </summary>
	public Byte GetLdgPayMethodFieldValue()
	{
		return this.GetValue(TableUtils.LdgPayMethodColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayMethod field.
	/// </summary>
	public void SetLdgPayMethodFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayMethod field.
	/// </summary>
	public void SetLdgPayMethodFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayMethod field.
	/// </summary>
	public void SetLdgPayMethodFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayMethod field.
	/// </summary>
	public void SetLdgPayMethodFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayMethod field.
	/// </summary>
	public void SetLdgPayMethodFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPayMethodColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgQBInvoiceLinked field.
	/// </summary>
	public ColumnValue GetLdgQBInvoiceLinkedValue()
	{
		return this.GetValue(TableUtils.LdgQBInvoiceLinkedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgQBInvoiceLinked field.
	/// </summary>
	public bool GetLdgQBInvoiceLinkedFieldValue()
	{
		return this.GetValue(TableUtils.LdgQBInvoiceLinkedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgQBInvoiceLinked field.
	/// </summary>
	public void SetLdgQBInvoiceLinkedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgQBInvoiceLinkedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgQBInvoiceLinked field.
	/// </summary>
	public void SetLdgQBInvoiceLinkedFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgQBInvoiceLinkedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgQBInvoiceLinked field.
	/// </summary>
	public void SetLdgQBInvoiceLinkedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgQBInvoiceLinkedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgQBTxnIDPay field.
	/// </summary>
	public ColumnValue GetLdgQBTxnIDPayValue()
	{
		return this.GetValue(TableUtils.LdgQBTxnIDPayColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgQBTxnIDPay field.
	/// </summary>
	public string GetLdgQBTxnIDPayFieldValue()
	{
		return this.GetValue(TableUtils.LdgQBTxnIDPayColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgQBTxnIDPay field.
	/// </summary>
	public void SetLdgQBTxnIDPayFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgQBTxnIDPayColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgQBTxnIDPay field.
	/// </summary>
	public void SetLdgQBTxnIDPayFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgQBTxnIDPayColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgRecDate field.
	/// </summary>
	public ColumnValue GetLdgRecDateValue()
	{
		return this.GetValue(TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgRecDate field.
	/// </summary>
	public DateTime GetLdgRecDateFieldValue()
	{
		return this.GetValue(TableUtils.LdgRecDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgRecDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgReference field.
	/// </summary>
	public ColumnValue GetLdgReferenceValue()
	{
		return this.GetValue(TableUtils.LdgReferenceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgReference field.
	/// </summary>
	public string GetLdgReferenceFieldValue()
	{
		return this.GetValue(TableUtils.LdgReferenceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgReference field.
	/// </summary>
	public void SetLdgReferenceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgReferenceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgReference field.
	/// </summary>
	public void SetLdgReferenceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgReferenceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgTrnDate field.
	/// </summary>
	public ColumnValue GetLdgTrnDateValue()
	{
		return this.GetValue(TableUtils.LdgTrnDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.LdgTrnDate field.
	/// </summary>
	public DateTime GetLdgTrnDateFieldValue()
	{
		return this.GetValue(TableUtils.LdgTrnDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgTrnDate field.
	/// </summary>
	public void SetLdgTrnDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgTrnDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgTrnDate field.
	/// </summary>
	public void SetLdgTrnDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgTrnDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgTrnDate field.
	/// </summary>
	public void SetLdgTrnDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTrnDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerPayments_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgBillingNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgBillingNo field.
	/// </summary>
	public string LdgBillingNoDefault
	{
		get
		{
			return TableUtils.LdgBillingNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgExported field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExported field.
	/// </summary>
	public string LdgExportedDefault
	{
		get
		{
			return TableUtils.LdgExportedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgExportInclude field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExportInclude field.
	/// </summary>
	public string LdgExportIncludeDefault
	{
		get
		{
			return TableUtils.LdgExportIncludeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgExportRecordChanged field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgExportRecordChanged field.
	/// </summary>
	public string LdgExportRecordChangedDefault
	{
		get
		{
			return TableUtils.LdgExportRecordChangedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgFormNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgFormNo field.
	/// </summary>
	public string LdgFormNoDefault
	{
		get
		{
			return TableUtils.LdgFormNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgFormType field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgFormType field.
	/// </summary>
	public string LdgFormTypeDefault
	{
		get
		{
			return TableUtils.LdgFormTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgKey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgKey field.
	/// </summary>
	public string LdgKeyDefault
	{
		get
		{
			return TableUtils.LdgKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgPayment field.
	/// </summary>
	public Decimal LdgPayment
	{
		get
		{
			return this.GetValue(TableUtils.LdgPaymentColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgPaymentColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgPaymentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgPaymentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayment field.
	/// </summary>
	public string LdgPaymentDefault
	{
		get
		{
			return TableUtils.LdgPaymentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgPayMethod field.
	/// </summary>
	public Byte LdgPayMethod
	{
		get
		{
			return this.GetValue(TableUtils.LdgPayMethodColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgPayMethodColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgPayMethodSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgPayMethodColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgPayMethod field.
	/// </summary>
	public string LdgPayMethodDefault
	{
		get
		{
			return TableUtils.LdgPayMethodColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgQBInvoiceLinked field.
	/// </summary>
	public bool LdgQBInvoiceLinked
	{
		get
		{
			return this.GetValue(TableUtils.LdgQBInvoiceLinkedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.LdgQBInvoiceLinkedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgQBInvoiceLinkedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgQBInvoiceLinkedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgQBInvoiceLinked field.
	/// </summary>
	public string LdgQBInvoiceLinkedDefault
	{
		get
		{
			return TableUtils.LdgQBInvoiceLinkedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgQBTxnIDPay field.
	/// </summary>
	public string LdgQBTxnIDPay
	{
		get
		{
			return this.GetValue(TableUtils.LdgQBTxnIDPayColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgQBTxnIDPayColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgQBTxnIDPaySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgQBTxnIDPayColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgQBTxnIDPay field.
	/// </summary>
	public string LdgQBTxnIDPayDefault
	{
		get
		{
			return TableUtils.LdgQBTxnIDPayColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgRecDate field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgRecDate field.
	/// </summary>
	public string LdgRecDateDefault
	{
		get
		{
			return TableUtils.LdgRecDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgReference field.
	/// </summary>
	public string LdgReference
	{
		get
		{
			return this.GetValue(TableUtils.LdgReferenceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgReferenceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgReferenceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgReferenceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgReference field.
	/// </summary>
	public string LdgReferenceDefault
	{
		get
		{
			return TableUtils.LdgReferenceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.LdgTrnDate field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.LdgTrnDate field.
	/// </summary>
	public string LdgTrnDateDefault
	{
		get
		{
			return TableUtils.LdgTrnDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerPayments_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerPayments_.SSMA_TimeStamp field.
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
