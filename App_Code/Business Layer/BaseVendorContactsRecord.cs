// This class is "generated" and will be overwritten.
// Your customizations should be made in VendorContactsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="VendorContactsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="VendorContactsTable"></see> class.
/// </remarks>
/// <seealso cref="VendorContactsTable"></seealso>
/// <seealso cref="VendorContactsRecord"></seealso>
public class BaseVendorContactsRecord : PrimaryKeyRecord
{

	public readonly static VendorContactsTable TableUtils = VendorContactsTable.Instance;

	// Constructors
 
	protected BaseVendorContactsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.VendorContactsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.VendorContactsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.VendorContactsRecord_ReadRecord); 
	}

	protected BaseVendorContactsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void VendorContactsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                VendorContactsRecord VendorContactsRec = (VendorContactsRecord)sender;
        if(VendorContactsRec != null && !VendorContactsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void VendorContactsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                VendorContactsRecord VendorContactsRec = (VendorContactsRecord)sender;
        Validate_Inserting();
        if(VendorContactsRec != null && !VendorContactsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void VendorContactsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                VendorContactsRecord VendorContactsRec = (VendorContactsRecord)sender;
        Validate_Updating();
        if(VendorContactsRec != null && !VendorContactsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.SessionID field.
	/// </summary>
	public ColumnValue GetSessionIDValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.SessionID field.
	/// </summary>
	public Int32 GetSessionIDFieldValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactEmail field.
	/// </summary>
	public ColumnValue GetVendContactEmailValue()
	{
		return this.GetValue(TableUtils.VendContactEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactEmail field.
	/// </summary>
	public string GetVendContactEmailFieldValue()
	{
		return this.GetValue(TableUtils.VendContactEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactEmail field.
	/// </summary>
	public void SetVendContactEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendContactEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactEmail field.
	/// </summary>
	public void SetVendContactEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactFax field.
	/// </summary>
	public ColumnValue GetVendContactFaxValue()
	{
		return this.GetValue(TableUtils.VendContactFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactFax field.
	/// </summary>
	public string GetVendContactFaxFieldValue()
	{
		return this.GetValue(TableUtils.VendContactFaxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactFax field.
	/// </summary>
	public void SetVendContactFaxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendContactFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactFax field.
	/// </summary>
	public void SetVendContactFaxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactFaxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactKey field.
	/// </summary>
	public ColumnValue GetVendContactKeyValue()
	{
		return this.GetValue(TableUtils.VendContactKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactKey field.
	/// </summary>
	public Int32 GetVendContactKeyFieldValue()
	{
		return this.GetValue(TableUtils.VendContactKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactName field.
	/// </summary>
	public ColumnValue GetVendContactNameValue()
	{
		return this.GetValue(TableUtils.VendContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactName field.
	/// </summary>
	public string GetVendContactNameFieldValue()
	{
		return this.GetValue(TableUtils.VendContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactName field.
	/// </summary>
	public void SetVendContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactName field.
	/// </summary>
	public void SetVendContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactPhoneBusiness field.
	/// </summary>
	public ColumnValue GetVendContactPhoneBusinessValue()
	{
		return this.GetValue(TableUtils.VendContactPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactPhoneBusiness field.
	/// </summary>
	public string GetVendContactPhoneBusinessFieldValue()
	{
		return this.GetValue(TableUtils.VendContactPhoneBusinessColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactPhoneBusiness field.
	/// </summary>
	public void SetVendContactPhoneBusinessFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendContactPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactPhoneBusiness field.
	/// </summary>
	public void SetVendContactPhoneBusinessFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactPhoneBusinessColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactPhoneMobile field.
	/// </summary>
	public ColumnValue GetVendContactPhoneMobileValue()
	{
		return this.GetValue(TableUtils.VendContactPhoneMobileColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactPhoneMobile field.
	/// </summary>
	public string GetVendContactPhoneMobileFieldValue()
	{
		return this.GetValue(TableUtils.VendContactPhoneMobileColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactPhoneMobile field.
	/// </summary>
	public void SetVendContactPhoneMobileFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendContactPhoneMobileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactPhoneMobile field.
	/// </summary>
	public void SetVendContactPhoneMobileFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactPhoneMobileColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactTitle field.
	/// </summary>
	public ColumnValue GetVendContactTitleValue()
	{
		return this.GetValue(TableUtils.VendContactTitleColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactTitle field.
	/// </summary>
	public string GetVendContactTitleFieldValue()
	{
		return this.GetValue(TableUtils.VendContactTitleColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactTitle field.
	/// </summary>
	public void SetVendContactTitleFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendContactTitleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactTitle field.
	/// </summary>
	public void SetVendContactTitleFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactTitleColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactType field.
	/// </summary>
	public ColumnValue GetVendContactTypeValue()
	{
		return this.GetValue(TableUtils.VendContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendContactType field.
	/// </summary>
	public Byte GetVendContactTypeFieldValue()
	{
		return this.GetValue(TableUtils.VendContactTypeColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactType field.
	/// </summary>
	public void SetVendContactTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactType field.
	/// </summary>
	public void SetVendContactTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactType field.
	/// </summary>
	public void SetVendContactTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactType field.
	/// </summary>
	public void SetVendContactTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactType field.
	/// </summary>
	public void SetVendContactTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendContactTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendNo field.
	/// </summary>
	public ColumnValue GetVendNoValue()
	{
		return this.GetValue(TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VendorContacts_.VendNo field.
	/// </summary>
	public Int32 GetVendNoFieldValue()
	{
		return this.GetValue(TableUtils.VendNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendNo field.
	/// </summary>
	public void SetVendNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VendNoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.SessionID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.SessionID field.
	/// </summary>
	public string SessionIDDefault
	{
		get
		{
			return TableUtils.SessionIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.VendContactEmail field.
	/// </summary>
	public string VendContactEmail
	{
		get
		{
			return this.GetValue(TableUtils.VendContactEmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendContactEmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendContactEmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendContactEmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactEmail field.
	/// </summary>
	public string VendContactEmailDefault
	{
		get
		{
			return TableUtils.VendContactEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.VendContactFax field.
	/// </summary>
	public string VendContactFax
	{
		get
		{
			return this.GetValue(TableUtils.VendContactFaxColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendContactFaxColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendContactFaxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendContactFaxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactFax field.
	/// </summary>
	public string VendContactFaxDefault
	{
		get
		{
			return TableUtils.VendContactFaxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.VendContactKey field.
	/// </summary>
	public Int32 VendContactKey
	{
		get
		{
			return this.GetValue(TableUtils.VendContactKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendContactKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendContactKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendContactKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactKey field.
	/// </summary>
	public string VendContactKeyDefault
	{
		get
		{
			return TableUtils.VendContactKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.VendContactName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactName field.
	/// </summary>
	public string VendContactNameDefault
	{
		get
		{
			return TableUtils.VendContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.VendContactPhoneBusiness field.
	/// </summary>
	public string VendContactPhoneBusiness
	{
		get
		{
			return this.GetValue(TableUtils.VendContactPhoneBusinessColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendContactPhoneBusinessColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendContactPhoneBusinessSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendContactPhoneBusinessColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactPhoneBusiness field.
	/// </summary>
	public string VendContactPhoneBusinessDefault
	{
		get
		{
			return TableUtils.VendContactPhoneBusinessColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.VendContactPhoneMobile field.
	/// </summary>
	public string VendContactPhoneMobile
	{
		get
		{
			return this.GetValue(TableUtils.VendContactPhoneMobileColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendContactPhoneMobileColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendContactPhoneMobileSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendContactPhoneMobileColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactPhoneMobile field.
	/// </summary>
	public string VendContactPhoneMobileDefault
	{
		get
		{
			return TableUtils.VendContactPhoneMobileColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.VendContactTitle field.
	/// </summary>
	public string VendContactTitle
	{
		get
		{
			return this.GetValue(TableUtils.VendContactTitleColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendContactTitleColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendContactTitleSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendContactTitleColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactTitle field.
	/// </summary>
	public string VendContactTitleDefault
	{
		get
		{
			return TableUtils.VendContactTitleColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.VendContactType field.
	/// </summary>
	public Byte VendContactType
	{
		get
		{
			return this.GetValue(TableUtils.VendContactTypeColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VendContactTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VendContactTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VendContactTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendContactType field.
	/// </summary>
	public string VendContactTypeDefault
	{
		get
		{
			return TableUtils.VendContactTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VendorContacts_.VendNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VendorContacts_.VendNo field.
	/// </summary>
	public string VendNoDefault
	{
		get
		{
			return TableUtils.VendNoColumn.DefaultValue;
		}
	}


#endregion
}

}
