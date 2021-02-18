// This class is "generated" and will be overwritten.
// Your customizations should be made in VendorsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="VendorsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="VendorsTable"></see> class.
/// </remarks>
/// <seealso cref="VendorsTable"></seealso>
/// <seealso cref="VendorsRecord"></seealso>
public class BaseVendorsRecord : PrimaryKeyRecord
{

	public readonly static VendorsTable TableUtils = VendorsTable.Instance;

	// Constructors
 
	protected BaseVendorsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.VendorsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.VendorsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.VendorsRecord_ReadRecord); 
	}

	protected BaseVendorsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void VendorsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                VendorsRecord VendorsRec = (VendorsRecord)sender;
        if(VendorsRec != null && !VendorsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void VendorsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                VendorsRecord VendorsRec = (VendorsRecord)sender;
        Validate_Inserting();
        if(VendorsRec != null && !VendorsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void VendorsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                VendorsRecord VendorsRec = (VendorsRecord)sender;
        Validate_Updating();
        if(VendorsRec != null && !VendorsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendAccount field.
	/// </summary>
	public ColumnValue GetVendAccountValue()
	{
		return this.GetValue(TableUtils.VendAccountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendAccount field.
	/// </summary>
	public string GetVendAccountFieldValue()
	{
		return this.GetValue(TableUtils.VendAccountColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendAccount field.
	/// </summary>
	public void SetVendAccountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendAccountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendAccount field.
	/// </summary>
	public void SetVendAccountFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendAccountColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendAddress1 field.
	/// </summary>
	public ColumnValue GetVendAddress1Value()
	{
		return this.GetValue(TableUtils.VendAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendAddress1 field.
	/// </summary>
	public string GetVendAddress1FieldValue()
	{
		return this.GetValue(TableUtils.VendAddress1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendAddress1 field.
	/// </summary>
	public void SetVendAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendAddress1 field.
	/// </summary>
	public void SetVendAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendAddress1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendAddress2 field.
	/// </summary>
	public ColumnValue GetVendAddress2Value()
	{
		return this.GetValue(TableUtils.VendAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendAddress2 field.
	/// </summary>
	public string GetVendAddress2FieldValue()
	{
		return this.GetValue(TableUtils.VendAddress2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendAddress2 field.
	/// </summary>
	public void SetVendAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendAddress2 field.
	/// </summary>
	public void SetVendAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendAddress2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendBackorderDays field.
	/// </summary>
	public ColumnValue GetVendBackorderDaysValue()
	{
		return this.GetValue(TableUtils.VendBackorderDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendBackorderDays field.
	/// </summary>
	public Byte GetVendBackorderDaysFieldValue()
	{
		return this.GetValue(TableUtils.VendBackorderDaysColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendBackorderDays field.
	/// </summary>
	public void SetVendBackorderDaysFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendBackorderDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendBackorderDays field.
	/// </summary>
	public void SetVendBackorderDaysFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendBackorderDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendBackorderDays field.
	/// </summary>
	public void SetVendBackorderDaysFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendBackorderDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendBackorderDays field.
	/// </summary>
	public void SetVendBackorderDaysFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendBackorderDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendBackorderDays field.
	/// </summary>
	public void SetVendBackorderDaysFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendBackorderDaysColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCity field.
	/// </summary>
	public ColumnValue GetVendCityValue()
	{
		return this.GetValue(TableUtils.VendCityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCity field.
	/// </summary>
	public string GetVendCityFieldValue()
	{
		return this.GetValue(TableUtils.VendCityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCity field.
	/// </summary>
	public void SetVendCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendCityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCity field.
	/// </summary>
	public void SetVendCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendCityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCode field.
	/// </summary>
	public ColumnValue GetVendCodeValue()
	{
		return this.GetValue(TableUtils.VendCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCode field.
	/// </summary>
	public string GetVendCodeFieldValue()
	{
		return this.GetValue(TableUtils.VendCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCode field.
	/// </summary>
	public void SetVendCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCode field.
	/// </summary>
	public void SetVendCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendContactName field.
	/// </summary>
	public ColumnValue GetVendContactNameValue()
	{
		return this.GetValue(TableUtils.VendContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendContactName field.
	/// </summary>
	public string GetVendContactNameFieldValue()
	{
		return this.GetValue(TableUtils.VendContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendContactName field.
	/// </summary>
	public void SetVendContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendContactName field.
	/// </summary>
	public void SetVendContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCopyPrivateNotes field.
	/// </summary>
	public ColumnValue GetVendCopyPrivateNotesValue()
	{
		return this.GetValue(TableUtils.VendCopyPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCopyPrivateNotes field.
	/// </summary>
	public bool GetVendCopyPrivateNotesFieldValue()
	{
		return this.GetValue(TableUtils.VendCopyPrivateNotesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCopyPrivateNotes field.
	/// </summary>
	public void SetVendCopyPrivateNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendCopyPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCopyPrivateNotes field.
	/// </summary>
	public void SetVendCopyPrivateNotesFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendCopyPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCopyPrivateNotes field.
	/// </summary>
	public void SetVendCopyPrivateNotesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendCopyPrivateNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCopyPublicNotes field.
	/// </summary>
	public ColumnValue GetVendCopyPublicNotesValue()
	{
		return this.GetValue(TableUtils.VendCopyPublicNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCopyPublicNotes field.
	/// </summary>
	public bool GetVendCopyPublicNotesFieldValue()
	{
		return this.GetValue(TableUtils.VendCopyPublicNotesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCopyPublicNotes field.
	/// </summary>
	public void SetVendCopyPublicNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendCopyPublicNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCopyPublicNotes field.
	/// </summary>
	public void SetVendCopyPublicNotesFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendCopyPublicNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCopyPublicNotes field.
	/// </summary>
	public void SetVendCopyPublicNotesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendCopyPublicNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCountry field.
	/// </summary>
	public ColumnValue GetVendCountryValue()
	{
		return this.GetValue(TableUtils.VendCountryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendCountry field.
	/// </summary>
	public string GetVendCountryFieldValue()
	{
		return this.GetValue(TableUtils.VendCountryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCountry field.
	/// </summary>
	public void SetVendCountryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendCountryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCountry field.
	/// </summary>
	public void SetVendCountryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendCountryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendDateRecordAdded field.
	/// </summary>
	public ColumnValue GetVendDateRecordAddedValue()
	{
		return this.GetValue(TableUtils.VendDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendDateRecordAdded field.
	/// </summary>
	public DateTime GetVendDateRecordAddedFieldValue()
	{
		return this.GetValue(TableUtils.VendDateRecordAddedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDateRecordAdded field.
	/// </summary>
	public void SetVendDateRecordAddedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDateRecordAdded field.
	/// </summary>
	public void SetVendDateRecordAddedFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDateRecordAdded field.
	/// </summary>
	public void SetVendDateRecordAddedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendDateRecordAddedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendDateRecordUpdated field.
	/// </summary>
	public ColumnValue GetVendDateRecordUpdatedValue()
	{
		return this.GetValue(TableUtils.VendDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendDateRecordUpdated field.
	/// </summary>
	public DateTime GetVendDateRecordUpdatedFieldValue()
	{
		return this.GetValue(TableUtils.VendDateRecordUpdatedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDateRecordUpdated field.
	/// </summary>
	public void SetVendDateRecordUpdatedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDateRecordUpdated field.
	/// </summary>
	public void SetVendDateRecordUpdatedFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDateRecordUpdated field.
	/// </summary>
	public void SetVendDateRecordUpdatedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendDateRecordUpdatedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendDefaultMake field.
	/// </summary>
	public ColumnValue GetVendDefaultMakeValue()
	{
		return this.GetValue(TableUtils.VendDefaultMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendDefaultMake field.
	/// </summary>
	public string GetVendDefaultMakeFieldValue()
	{
		return this.GetValue(TableUtils.VendDefaultMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDefaultMake field.
	/// </summary>
	public void SetVendDefaultMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendDefaultMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDefaultMake field.
	/// </summary>
	public void SetVendDefaultMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendDefaultMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendEmail field.
	/// </summary>
	public ColumnValue GetVendEmailValue()
	{
		return this.GetValue(TableUtils.VendEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendEmail field.
	/// </summary>
	public string GetVendEmailFieldValue()
	{
		return this.GetValue(TableUtils.VendEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendEmail field.
	/// </summary>
	public void SetVendEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendEmail field.
	/// </summary>
	public void SetVendEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendExportInclude field.
	/// </summary>
	public ColumnValue GetVendExportIncludeValue()
	{
		return this.GetValue(TableUtils.VendExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendExportInclude field.
	/// </summary>
	public bool GetVendExportIncludeFieldValue()
	{
		return this.GetValue(TableUtils.VendExportIncludeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendExportInclude field.
	/// </summary>
	public void SetVendExportIncludeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendExportInclude field.
	/// </summary>
	public void SetVendExportIncludeFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendExportInclude field.
	/// </summary>
	public void SetVendExportIncludeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendExportIncludeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendExportRecordChanged field.
	/// </summary>
	public ColumnValue GetVendExportRecordChangedValue()
	{
		return this.GetValue(TableUtils.VendExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendExportRecordChanged field.
	/// </summary>
	public bool GetVendExportRecordChangedFieldValue()
	{
		return this.GetValue(TableUtils.VendExportRecordChangedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendExportRecordChanged field.
	/// </summary>
	public void SetVendExportRecordChangedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendExportRecordChanged field.
	/// </summary>
	public void SetVendExportRecordChangedFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendExportRecordChanged field.
	/// </summary>
	public void SetVendExportRecordChangedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendExportRecordChangedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendFax field.
	/// </summary>
	public ColumnValue GetVendFaxValue()
	{
		return this.GetValue(TableUtils.VendFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendFax field.
	/// </summary>
	public string GetVendFaxFieldValue()
	{
		return this.GetValue(TableUtils.VendFaxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendFax field.
	/// </summary>
	public void SetVendFaxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendFax field.
	/// </summary>
	public void SetVendFaxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendFaxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendInactive field.
	/// </summary>
	public ColumnValue GetVendInactiveValue()
	{
		return this.GetValue(TableUtils.VendInactiveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendInactive field.
	/// </summary>
	public bool GetVendInactiveFieldValue()
	{
		return this.GetValue(TableUtils.VendInactiveColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendInactive field.
	/// </summary>
	public void SetVendInactiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendInactiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendInactive field.
	/// </summary>
	public void SetVendInactiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendInactiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendInactive field.
	/// </summary>
	public void SetVendInactiveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendInactiveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendLanguage field.
	/// </summary>
	public ColumnValue GetVendLanguageValue()
	{
		return this.GetValue(TableUtils.VendLanguageColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendLanguage field.
	/// </summary>
	public string GetVendLanguageFieldValue()
	{
		return this.GetValue(TableUtils.VendLanguageColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendLanguage field.
	/// </summary>
	public void SetVendLanguageFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendLanguageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendLanguage field.
	/// </summary>
	public void SetVendLanguageFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendLanguageColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendLocationBus field.
	/// </summary>
	public ColumnValue GetVendLocationBusValue()
	{
		return this.GetValue(TableUtils.VendLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendLocationBus field.
	/// </summary>
	public Int32 GetVendLocationBusFieldValue()
	{
		return this.GetValue(TableUtils.VendLocationBusColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendLocationBus field.
	/// </summary>
	public void SetVendLocationBusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendLocationBus field.
	/// </summary>
	public void SetVendLocationBusFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendLocationBus field.
	/// </summary>
	public void SetVendLocationBusFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendLocationBus field.
	/// </summary>
	public void SetVendLocationBusFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendLocationBus field.
	/// </summary>
	public void SetVendLocationBusFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendLocationBusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendName field.
	/// </summary>
	public ColumnValue GetVendNameValue()
	{
		return this.GetValue(TableUtils.VendNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendName field.
	/// </summary>
	public string GetVendNameFieldValue()
	{
		return this.GetValue(TableUtils.VendNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendName field.
	/// </summary>
	public void SetVendNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendName field.
	/// </summary>
	public void SetVendNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendNo field.
	/// </summary>
	public ColumnValue GetVendNoValue()
	{
		return this.GetValue(TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendNo field.
	/// </summary>
	public Int32 GetVendNoFieldValue()
	{
		return this.GetValue(TableUtils.VendNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPackCode field.
	/// </summary>
	public ColumnValue GetVendPackCodeValue()
	{
		return this.GetValue(TableUtils.VendPackCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPackCode field.
	/// </summary>
	public string GetVendPackCodeFieldValue()
	{
		return this.GetValue(TableUtils.VendPackCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPackCode field.
	/// </summary>
	public void SetVendPackCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendPackCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPackCode field.
	/// </summary>
	public void SetVendPackCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendPackCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPhoneBusiness field.
	/// </summary>
	public ColumnValue GetVendPhoneBusinessValue()
	{
		return this.GetValue(TableUtils.VendPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPhoneBusiness field.
	/// </summary>
	public string GetVendPhoneBusinessFieldValue()
	{
		return this.GetValue(TableUtils.VendPhoneBusinessColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPhoneBusiness field.
	/// </summary>
	public void SetVendPhoneBusinessFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPhoneBusiness field.
	/// </summary>
	public void SetVendPhoneBusinessFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendPhoneBusinessColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPhoneTollFree field.
	/// </summary>
	public ColumnValue GetVendPhoneTollFreeValue()
	{
		return this.GetValue(TableUtils.VendPhoneTollFreeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPhoneTollFree field.
	/// </summary>
	public string GetVendPhoneTollFreeFieldValue()
	{
		return this.GetValue(TableUtils.VendPhoneTollFreeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPhoneTollFree field.
	/// </summary>
	public void SetVendPhoneTollFreeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendPhoneTollFreeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPhoneTollFree field.
	/// </summary>
	public void SetVendPhoneTollFreeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendPhoneTollFreeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPostalCode field.
	/// </summary>
	public ColumnValue GetVendPostalCodeValue()
	{
		return this.GetValue(TableUtils.VendPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPostalCode field.
	/// </summary>
	public string GetVendPostalCodeFieldValue()
	{
		return this.GetValue(TableUtils.VendPostalCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPostalCode field.
	/// </summary>
	public void SetVendPostalCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPostalCode field.
	/// </summary>
	public void SetVendPostalCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendPostalCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPrintNotes field.
	/// </summary>
	public ColumnValue GetVendPrintNotesValue()
	{
		return this.GetValue(TableUtils.VendPrintNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPrintNotes field.
	/// </summary>
	public string GetVendPrintNotesFieldValue()
	{
		return this.GetValue(TableUtils.VendPrintNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPrintNotes field.
	/// </summary>
	public void SetVendPrintNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendPrintNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPrintNotes field.
	/// </summary>
	public void SetVendPrintNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendPrintNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPrivateNotes field.
	/// </summary>
	public ColumnValue GetVendPrivateNotesValue()
	{
		return this.GetValue(TableUtils.VendPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPrivateNotes field.
	/// </summary>
	public string GetVendPrivateNotesFieldValue()
	{
		return this.GetValue(TableUtils.VendPrivateNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPrivateNotes field.
	/// </summary>
	public void SetVendPrivateNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPrivateNotes field.
	/// </summary>
	public void SetVendPrivateNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendPrivateNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendProvince field.
	/// </summary>
	public ColumnValue GetVendProvinceValue()
	{
		return this.GetValue(TableUtils.VendProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendProvince field.
	/// </summary>
	public string GetVendProvinceFieldValue()
	{
		return this.GetValue(TableUtils.VendProvinceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendProvince field.
	/// </summary>
	public void SetVendProvinceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendProvince field.
	/// </summary>
	public void SetVendProvinceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendProvinceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPurchases field.
	/// </summary>
	public ColumnValue GetVendPurchasesValue()
	{
		return this.GetValue(TableUtils.VendPurchasesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendPurchases field.
	/// </summary>
	public bool GetVendPurchasesFieldValue()
	{
		return this.GetValue(TableUtils.VendPurchasesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPurchases field.
	/// </summary>
	public void SetVendPurchasesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendPurchasesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPurchases field.
	/// </summary>
	public void SetVendPurchasesFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendPurchasesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPurchases field.
	/// </summary>
	public void SetVendPurchasesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendPurchasesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendQBAltered field.
	/// </summary>
	public ColumnValue GetVendQBAlteredValue()
	{
		return this.GetValue(TableUtils.VendQBAlteredColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendQBAltered field.
	/// </summary>
	public bool GetVendQBAlteredFieldValue()
	{
		return this.GetValue(TableUtils.VendQBAlteredColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBAltered field.
	/// </summary>
	public void SetVendQBAlteredFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendQBAlteredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBAltered field.
	/// </summary>
	public void SetVendQBAlteredFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendQBAlteredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBAltered field.
	/// </summary>
	public void SetVendQBAlteredFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendQBAlteredColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendQBEditSequence field.
	/// </summary>
	public ColumnValue GetVendQBEditSequenceValue()
	{
		return this.GetValue(TableUtils.VendQBEditSequenceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendQBEditSequence field.
	/// </summary>
	public string GetVendQBEditSequenceFieldValue()
	{
		return this.GetValue(TableUtils.VendQBEditSequenceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBEditSequence field.
	/// </summary>
	public void SetVendQBEditSequenceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendQBEditSequenceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBEditSequence field.
	/// </summary>
	public void SetVendQBEditSequenceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendQBEditSequenceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendQBListID field.
	/// </summary>
	public ColumnValue GetVendQBListIDValue()
	{
		return this.GetValue(TableUtils.VendQBListIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendQBListID field.
	/// </summary>
	public string GetVendQBListIDFieldValue()
	{
		return this.GetValue(TableUtils.VendQBListIDColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBListID field.
	/// </summary>
	public void SetVendQBListIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendQBListIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBListID field.
	/// </summary>
	public void SetVendQBListIDFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendQBListIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendReference1 field.
	/// </summary>
	public ColumnValue GetVendReference1Value()
	{
		return this.GetValue(TableUtils.VendReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendReference1 field.
	/// </summary>
	public string GetVendReference1FieldValue()
	{
		return this.GetValue(TableUtils.VendReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference1 field.
	/// </summary>
	public void SetVendReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference1 field.
	/// </summary>
	public void SetVendReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendReference2 field.
	/// </summary>
	public ColumnValue GetVendReference2Value()
	{
		return this.GetValue(TableUtils.VendReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendReference2 field.
	/// </summary>
	public string GetVendReference2FieldValue()
	{
		return this.GetValue(TableUtils.VendReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference2 field.
	/// </summary>
	public void SetVendReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference2 field.
	/// </summary>
	public void SetVendReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendReference3 field.
	/// </summary>
	public ColumnValue GetVendReference3Value()
	{
		return this.GetValue(TableUtils.VendReference3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendReference3 field.
	/// </summary>
	public string GetVendReference3FieldValue()
	{
		return this.GetValue(TableUtils.VendReference3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference3 field.
	/// </summary>
	public void SetVendReference3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendReference3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference3 field.
	/// </summary>
	public void SetVendReference3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendReference3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendReference4 field.
	/// </summary>
	public ColumnValue GetVendReference4Value()
	{
		return this.GetValue(TableUtils.VendReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendReference4 field.
	/// </summary>
	public string GetVendReference4FieldValue()
	{
		return this.GetValue(TableUtils.VendReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference4 field.
	/// </summary>
	public void SetVendReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference4 field.
	/// </summary>
	public void SetVendReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendShipVia field.
	/// </summary>
	public ColumnValue GetVendShipViaValue()
	{
		return this.GetValue(TableUtils.VendShipViaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendShipVia field.
	/// </summary>
	public string GetVendShipViaFieldValue()
	{
		return this.GetValue(TableUtils.VendShipViaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendShipVia field.
	/// </summary>
	public void SetVendShipViaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendShipViaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendShipVia field.
	/// </summary>
	public void SetVendShipViaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendShipViaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendSingleMake field.
	/// </summary>
	public ColumnValue GetVendSingleMakeValue()
	{
		return this.GetValue(TableUtils.VendSingleMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendSingleMake field.
	/// </summary>
	public bool GetVendSingleMakeFieldValue()
	{
		return this.GetValue(TableUtils.VendSingleMakeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendSingleMake field.
	/// </summary>
	public void SetVendSingleMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendSingleMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendSingleMake field.
	/// </summary>
	public void SetVendSingleMakeFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendSingleMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendSingleMake field.
	/// </summary>
	public void SetVendSingleMakeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendSingleMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendSubcontracts field.
	/// </summary>
	public ColumnValue GetVendSubcontractsValue()
	{
		return this.GetValue(TableUtils.VendSubcontractsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendSubcontracts field.
	/// </summary>
	public bool GetVendSubcontractsFieldValue()
	{
		return this.GetValue(TableUtils.VendSubcontractsColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendSubcontracts field.
	/// </summary>
	public void SetVendSubcontractsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendSubcontractsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendSubcontracts field.
	/// </summary>
	public void SetVendSubcontractsFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendSubcontractsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendSubcontracts field.
	/// </summary>
	public void SetVendSubcontractsFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendSubcontractsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendWebSite field.
	/// </summary>
	public ColumnValue GetVendWebSiteValue()
	{
		return this.GetValue(TableUtils.VendWebSiteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.VendWebSite field.
	/// </summary>
	public string GetVendWebSiteFieldValue()
	{
		return this.GetValue(TableUtils.VendWebSiteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendWebSite field.
	/// </summary>
	public void SetVendWebSiteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendWebSiteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendWebSite field.
	/// </summary>
	public void SetVendWebSiteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendWebSiteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.Vend_active field.
	/// </summary>
	public ColumnValue GetVend_activeValue()
	{
		return this.GetValue(TableUtils.Vend_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.Vend_active field.
	/// </summary>
	public bool GetVend_activeFieldValue()
	{
		return this.GetValue(TableUtils.Vend_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.Vend_active field.
	/// </summary>
	public void SetVend_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Vend_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.Vend_active field.
	/// </summary>
	public void SetVend_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.Vend_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.Vend_active field.
	/// </summary>
	public void SetVend_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Vend_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.vendor_inventory field.
	/// </summary>
	public ColumnValue Getvendor_inventoryValue()
	{
		return this.GetValue(TableUtils.vendor_inventoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.vendor_inventory field.
	/// </summary>
	public bool Getvendor_inventoryFieldValue()
	{
		return this.GetValue(TableUtils.vendor_inventoryColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.vendor_inventory field.
	/// </summary>
	public void Setvendor_inventoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.vendor_inventoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.vendor_inventory field.
	/// </summary>
	public void Setvendor_inventoryFieldValue(string val)
	{
		this.SetString(val, TableUtils.vendor_inventoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.vendor_inventory field.
	/// </summary>
	public void Setvendor_inventoryFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendor_inventoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.vendor_repair field.
	/// </summary>
	public ColumnValue Getvendor_repairValue()
	{
		return this.GetValue(TableUtils.vendor_repairColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Vendors_.vendor_repair field.
	/// </summary>
	public bool Getvendor_repairFieldValue()
	{
		return this.GetValue(TableUtils.vendor_repairColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.vendor_repair field.
	/// </summary>
	public void Setvendor_repairFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.vendor_repairColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.vendor_repair field.
	/// </summary>
	public void Setvendor_repairFieldValue(string val)
	{
		this.SetString(val, TableUtils.vendor_repairColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.vendor_repair field.
	/// </summary>
	public void Setvendor_repairFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendor_repairColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendAccount field.
	/// </summary>
	public string VendAccount
	{
		get
		{
			return this.GetValue(TableUtils.VendAccountColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendAccountColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendAccountSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendAccountColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendAccount field.
	/// </summary>
	public string VendAccountDefault
	{
		get
		{
			return TableUtils.VendAccountColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendAddress1 field.
	/// </summary>
	public string VendAddress1
	{
		get
		{
			return this.GetValue(TableUtils.VendAddress1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendAddress1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendAddress1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendAddress1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendAddress1 field.
	/// </summary>
	public string VendAddress1Default
	{
		get
		{
			return TableUtils.VendAddress1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendAddress2 field.
	/// </summary>
	public string VendAddress2
	{
		get
		{
			return this.GetValue(TableUtils.VendAddress2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendAddress2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendAddress2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendAddress2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendAddress2 field.
	/// </summary>
	public string VendAddress2Default
	{
		get
		{
			return TableUtils.VendAddress2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendBackorderDays field.
	/// </summary>
	public Byte VendBackorderDays
	{
		get
		{
			return this.GetValue(TableUtils.VendBackorderDaysColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendBackorderDaysColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendBackorderDaysSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendBackorderDaysColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendBackorderDays field.
	/// </summary>
	public string VendBackorderDaysDefault
	{
		get
		{
			return TableUtils.VendBackorderDaysColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendCity field.
	/// </summary>
	public string VendCity
	{
		get
		{
			return this.GetValue(TableUtils.VendCityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendCityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendCitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendCityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCity field.
	/// </summary>
	public string VendCityDefault
	{
		get
		{
			return TableUtils.VendCityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendCode field.
	/// </summary>
	public string VendCode
	{
		get
		{
			return this.GetValue(TableUtils.VendCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCode field.
	/// </summary>
	public string VendCodeDefault
	{
		get
		{
			return TableUtils.VendCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendContactName field.
	/// </summary>
	public string VendContactName
	{
		get
		{
			return this.GetValue(TableUtils.VendContactNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendContactNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendContactNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendContactNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendContactName field.
	/// </summary>
	public string VendContactNameDefault
	{
		get
		{
			return TableUtils.VendContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendCopyPrivateNotes field.
	/// </summary>
	public bool VendCopyPrivateNotes
	{
		get
		{
			return this.GetValue(TableUtils.VendCopyPrivateNotesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VendCopyPrivateNotesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendCopyPrivateNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendCopyPrivateNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCopyPrivateNotes field.
	/// </summary>
	public string VendCopyPrivateNotesDefault
	{
		get
		{
			return TableUtils.VendCopyPrivateNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendCopyPublicNotes field.
	/// </summary>
	public bool VendCopyPublicNotes
	{
		get
		{
			return this.GetValue(TableUtils.VendCopyPublicNotesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VendCopyPublicNotesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendCopyPublicNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendCopyPublicNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCopyPublicNotes field.
	/// </summary>
	public string VendCopyPublicNotesDefault
	{
		get
		{
			return TableUtils.VendCopyPublicNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendCountry field.
	/// </summary>
	public string VendCountry
	{
		get
		{
			return this.GetValue(TableUtils.VendCountryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendCountryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendCountrySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendCountryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendCountry field.
	/// </summary>
	public string VendCountryDefault
	{
		get
		{
			return TableUtils.VendCountryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendDateRecordAdded field.
	/// </summary>
	public DateTime VendDateRecordAdded
	{
		get
		{
			return this.GetValue(TableUtils.VendDateRecordAddedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendDateRecordAddedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendDateRecordAddedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendDateRecordAddedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDateRecordAdded field.
	/// </summary>
	public string VendDateRecordAddedDefault
	{
		get
		{
			return TableUtils.VendDateRecordAddedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendDateRecordUpdated field.
	/// </summary>
	public DateTime VendDateRecordUpdated
	{
		get
		{
			return this.GetValue(TableUtils.VendDateRecordUpdatedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendDateRecordUpdatedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendDateRecordUpdatedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendDateRecordUpdatedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDateRecordUpdated field.
	/// </summary>
	public string VendDateRecordUpdatedDefault
	{
		get
		{
			return TableUtils.VendDateRecordUpdatedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendDefaultMake field.
	/// </summary>
	public string VendDefaultMake
	{
		get
		{
			return this.GetValue(TableUtils.VendDefaultMakeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendDefaultMakeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendDefaultMakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendDefaultMakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendDefaultMake field.
	/// </summary>
	public string VendDefaultMakeDefault
	{
		get
		{
			return TableUtils.VendDefaultMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendEmail field.
	/// </summary>
	public string VendEmail
	{
		get
		{
			return this.GetValue(TableUtils.VendEmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendEmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendEmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendEmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendEmail field.
	/// </summary>
	public string VendEmailDefault
	{
		get
		{
			return TableUtils.VendEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendExportInclude field.
	/// </summary>
	public bool VendExportInclude
	{
		get
		{
			return this.GetValue(TableUtils.VendExportIncludeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VendExportIncludeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendExportIncludeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendExportIncludeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendExportInclude field.
	/// </summary>
	public string VendExportIncludeDefault
	{
		get
		{
			return TableUtils.VendExportIncludeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendExportRecordChanged field.
	/// </summary>
	public bool VendExportRecordChanged
	{
		get
		{
			return this.GetValue(TableUtils.VendExportRecordChangedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VendExportRecordChangedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendExportRecordChangedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendExportRecordChangedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendExportRecordChanged field.
	/// </summary>
	public string VendExportRecordChangedDefault
	{
		get
		{
			return TableUtils.VendExportRecordChangedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendFax field.
	/// </summary>
	public string VendFax
	{
		get
		{
			return this.GetValue(TableUtils.VendFaxColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendFaxColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendFaxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendFaxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendFax field.
	/// </summary>
	public string VendFaxDefault
	{
		get
		{
			return TableUtils.VendFaxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendInactive field.
	/// </summary>
	public bool VendInactive
	{
		get
		{
			return this.GetValue(TableUtils.VendInactiveColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VendInactiveColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendInactiveSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendInactiveColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendInactive field.
	/// </summary>
	public string VendInactiveDefault
	{
		get
		{
			return TableUtils.VendInactiveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendLanguage field.
	/// </summary>
	public string VendLanguage
	{
		get
		{
			return this.GetValue(TableUtils.VendLanguageColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendLanguageColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendLanguageSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendLanguageColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendLanguage field.
	/// </summary>
	public string VendLanguageDefault
	{
		get
		{
			return TableUtils.VendLanguageColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendLocationBus field.
	/// </summary>
	public Int32 VendLocationBus
	{
		get
		{
			return this.GetValue(TableUtils.VendLocationBusColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendLocationBusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendLocationBusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendLocationBusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendLocationBus field.
	/// </summary>
	public string VendLocationBusDefault
	{
		get
		{
			return TableUtils.VendLocationBusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendName field.
	/// </summary>
	public string VendName
	{
		get
		{
			return this.GetValue(TableUtils.VendNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendName field.
	/// </summary>
	public string VendNameDefault
	{
		get
		{
			return TableUtils.VendNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendNo field.
	/// </summary>
	public Int32 VendNo
	{
		get
		{
			return this.GetValue(TableUtils.VendNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendNo field.
	/// </summary>
	public string VendNoDefault
	{
		get
		{
			return TableUtils.VendNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendPackCode field.
	/// </summary>
	public string VendPackCode
	{
		get
		{
			return this.GetValue(TableUtils.VendPackCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendPackCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendPackCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendPackCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPackCode field.
	/// </summary>
	public string VendPackCodeDefault
	{
		get
		{
			return TableUtils.VendPackCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendPhoneBusiness field.
	/// </summary>
	public string VendPhoneBusiness
	{
		get
		{
			return this.GetValue(TableUtils.VendPhoneBusinessColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendPhoneBusinessColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendPhoneBusinessSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendPhoneBusinessColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPhoneBusiness field.
	/// </summary>
	public string VendPhoneBusinessDefault
	{
		get
		{
			return TableUtils.VendPhoneBusinessColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendPhoneTollFree field.
	/// </summary>
	public string VendPhoneTollFree
	{
		get
		{
			return this.GetValue(TableUtils.VendPhoneTollFreeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendPhoneTollFreeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendPhoneTollFreeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendPhoneTollFreeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPhoneTollFree field.
	/// </summary>
	public string VendPhoneTollFreeDefault
	{
		get
		{
			return TableUtils.VendPhoneTollFreeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendPostalCode field.
	/// </summary>
	public string VendPostalCode
	{
		get
		{
			return this.GetValue(TableUtils.VendPostalCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendPostalCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendPostalCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendPostalCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPostalCode field.
	/// </summary>
	public string VendPostalCodeDefault
	{
		get
		{
			return TableUtils.VendPostalCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendPrintNotes field.
	/// </summary>
	public string VendPrintNotes
	{
		get
		{
			return this.GetValue(TableUtils.VendPrintNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendPrintNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendPrintNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendPrintNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPrintNotes field.
	/// </summary>
	public string VendPrintNotesDefault
	{
		get
		{
			return TableUtils.VendPrintNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendPrivateNotes field.
	/// </summary>
	public string VendPrivateNotes
	{
		get
		{
			return this.GetValue(TableUtils.VendPrivateNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendPrivateNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendPrivateNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendPrivateNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPrivateNotes field.
	/// </summary>
	public string VendPrivateNotesDefault
	{
		get
		{
			return TableUtils.VendPrivateNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendProvince field.
	/// </summary>
	public string VendProvince
	{
		get
		{
			return this.GetValue(TableUtils.VendProvinceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendProvinceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendProvinceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendProvinceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendProvince field.
	/// </summary>
	public string VendProvinceDefault
	{
		get
		{
			return TableUtils.VendProvinceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendPurchases field.
	/// </summary>
	public bool VendPurchases
	{
		get
		{
			return this.GetValue(TableUtils.VendPurchasesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VendPurchasesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendPurchasesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendPurchasesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendPurchases field.
	/// </summary>
	public string VendPurchasesDefault
	{
		get
		{
			return TableUtils.VendPurchasesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendQBAltered field.
	/// </summary>
	public bool VendQBAltered
	{
		get
		{
			return this.GetValue(TableUtils.VendQBAlteredColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VendQBAlteredColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendQBAlteredSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendQBAlteredColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBAltered field.
	/// </summary>
	public string VendQBAlteredDefault
	{
		get
		{
			return TableUtils.VendQBAlteredColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendQBEditSequence field.
	/// </summary>
	public string VendQBEditSequence
	{
		get
		{
			return this.GetValue(TableUtils.VendQBEditSequenceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendQBEditSequenceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendQBEditSequenceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendQBEditSequenceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBEditSequence field.
	/// </summary>
	public string VendQBEditSequenceDefault
	{
		get
		{
			return TableUtils.VendQBEditSequenceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendQBListID field.
	/// </summary>
	public string VendQBListID
	{
		get
		{
			return this.GetValue(TableUtils.VendQBListIDColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendQBListIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendQBListIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendQBListIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendQBListID field.
	/// </summary>
	public string VendQBListIDDefault
	{
		get
		{
			return TableUtils.VendQBListIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendReference1 field.
	/// </summary>
	public string VendReference1
	{
		get
		{
			return this.GetValue(TableUtils.VendReference1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendReference1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendReference1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendReference1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference1 field.
	/// </summary>
	public string VendReference1Default
	{
		get
		{
			return TableUtils.VendReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendReference2 field.
	/// </summary>
	public string VendReference2
	{
		get
		{
			return this.GetValue(TableUtils.VendReference2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendReference2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendReference2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendReference2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference2 field.
	/// </summary>
	public string VendReference2Default
	{
		get
		{
			return TableUtils.VendReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendReference3 field.
	/// </summary>
	public string VendReference3
	{
		get
		{
			return this.GetValue(TableUtils.VendReference3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendReference3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendReference3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendReference3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference3 field.
	/// </summary>
	public string VendReference3Default
	{
		get
		{
			return TableUtils.VendReference3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendReference4 field.
	/// </summary>
	public string VendReference4
	{
		get
		{
			return this.GetValue(TableUtils.VendReference4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendReference4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendReference4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendReference4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendReference4 field.
	/// </summary>
	public string VendReference4Default
	{
		get
		{
			return TableUtils.VendReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendShipVia field.
	/// </summary>
	public string VendShipVia
	{
		get
		{
			return this.GetValue(TableUtils.VendShipViaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendShipViaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendShipViaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendShipViaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendShipVia field.
	/// </summary>
	public string VendShipViaDefault
	{
		get
		{
			return TableUtils.VendShipViaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendSingleMake field.
	/// </summary>
	public bool VendSingleMake
	{
		get
		{
			return this.GetValue(TableUtils.VendSingleMakeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VendSingleMakeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendSingleMakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendSingleMakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendSingleMake field.
	/// </summary>
	public string VendSingleMakeDefault
	{
		get
		{
			return TableUtils.VendSingleMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendSubcontracts field.
	/// </summary>
	public bool VendSubcontracts
	{
		get
		{
			return this.GetValue(TableUtils.VendSubcontractsColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VendSubcontractsColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendSubcontractsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendSubcontractsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendSubcontracts field.
	/// </summary>
	public string VendSubcontractsDefault
	{
		get
		{
			return TableUtils.VendSubcontractsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.VendWebSite field.
	/// </summary>
	public string VendWebSite
	{
		get
		{
			return this.GetValue(TableUtils.VendWebSiteColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendWebSiteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendWebSiteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendWebSiteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.VendWebSite field.
	/// </summary>
	public string VendWebSiteDefault
	{
		get
		{
			return TableUtils.VendWebSiteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.Vend_active field.
	/// </summary>
	public bool Vend_active
	{
		get
		{
			return this.GetValue(TableUtils.Vend_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Vend_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Vend_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Vend_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.Vend_active field.
	/// </summary>
	public string Vend_activeDefault
	{
		get
		{
			return TableUtils.Vend_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.vendor_inventory field.
	/// </summary>
	public bool vendor_inventory
	{
		get
		{
			return this.GetValue(TableUtils.vendor_inventoryColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.vendor_inventoryColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool vendor_inventorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.vendor_inventoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.vendor_inventory field.
	/// </summary>
	public string vendor_inventoryDefault
	{
		get
		{
			return TableUtils.vendor_inventoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Vendors_.vendor_repair field.
	/// </summary>
	public bool vendor_repair
	{
		get
		{
			return this.GetValue(TableUtils.vendor_repairColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.vendor_repairColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool vendor_repairSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.vendor_repairColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Vendors_.vendor_repair field.
	/// </summary>
	public string vendor_repairDefault
	{
		get
		{
			return TableUtils.vendor_repairColumn.DefaultValue;
		}
	}


#endregion
}

}
