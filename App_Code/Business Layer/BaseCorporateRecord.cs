// This class is "generated" and will be overwritten.
// Your customizations should be made in CorporateRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="CorporateRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="CorporateTable"></see> class.
/// </remarks>
/// <seealso cref="CorporateTable"></seealso>
/// <seealso cref="CorporateRecord"></seealso>
public class BaseCorporateRecord : PrimaryKeyRecord
{

	public readonly static CorporateTable TableUtils = CorporateTable.Instance;

	// Constructors
 
	protected BaseCorporateRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.CorporateRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.CorporateRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.CorporateRecord_ReadRecord); 
	}

	protected BaseCorporateRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void CorporateRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                CorporateRecord CorporateRec = (CorporateRecord)sender;
        if(CorporateRec != null && !CorporateRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void CorporateRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                CorporateRecord CorporateRec = (CorporateRecord)sender;
        Validate_Inserting();
        if(CorporateRec != null && !CorporateRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void CorporateRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                CorporateRecord CorporateRec = (CorporateRecord)sender;
        Validate_Updating();
        if(CorporateRec != null && !CorporateRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_id field.
	/// </summary>
	public ColumnValue Getcorporate_idValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_id field.
	/// </summary>
	public Int32 Getcorporate_idFieldValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_name field.
	/// </summary>
	public ColumnValue Getcorporate_nameValue()
	{
		return this.GetValue(TableUtils.corporate_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_name field.
	/// </summary>
	public string Getcorporate_nameFieldValue()
	{
		return this.GetValue(TableUtils.corporate_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_name field.
	/// </summary>
	public void Setcorporate_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_name field.
	/// </summary>
	public void Setcorporate_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_address1 field.
	/// </summary>
	public ColumnValue Getcorporate_address1Value()
	{
		return this.GetValue(TableUtils.corporate_address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_address1 field.
	/// </summary>
	public string Getcorporate_address1FieldValue()
	{
		return this.GetValue(TableUtils.corporate_address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_address1 field.
	/// </summary>
	public void Setcorporate_address1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_address1 field.
	/// </summary>
	public void Setcorporate_address1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_address2 field.
	/// </summary>
	public ColumnValue Getcorporate_address2Value()
	{
		return this.GetValue(TableUtils.corporate_address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_address2 field.
	/// </summary>
	public string Getcorporate_address2FieldValue()
	{
		return this.GetValue(TableUtils.corporate_address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_address2 field.
	/// </summary>
	public void Setcorporate_address2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_address2 field.
	/// </summary>
	public void Setcorporate_address2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_city field.
	/// </summary>
	public ColumnValue Getcorporate_cityValue()
	{
		return this.GetValue(TableUtils.corporate_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_city field.
	/// </summary>
	public string Getcorporate_cityFieldValue()
	{
		return this.GetValue(TableUtils.corporate_cityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_city field.
	/// </summary>
	public void Setcorporate_cityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_city field.
	/// </summary>
	public void Setcorporate_cityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_cityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_province_code field.
	/// </summary>
	public ColumnValue Getcorporate_province_codeValue()
	{
		return this.GetValue(TableUtils.corporate_province_codeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_province_code field.
	/// </summary>
	public string Getcorporate_province_codeFieldValue()
	{
		return this.GetValue(TableUtils.corporate_province_codeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_province_code field.
	/// </summary>
	public void Setcorporate_province_codeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_province_codeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_province_code field.
	/// </summary>
	public void Setcorporate_province_codeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_province_codeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_postalcode field.
	/// </summary>
	public ColumnValue Getcorporate_postalcodeValue()
	{
		return this.GetValue(TableUtils.corporate_postalcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_postalcode field.
	/// </summary>
	public string Getcorporate_postalcodeFieldValue()
	{
		return this.GetValue(TableUtils.corporate_postalcodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_postalcode field.
	/// </summary>
	public void Setcorporate_postalcodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_postalcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_postalcode field.
	/// </summary>
	public void Setcorporate_postalcodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_postalcodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_phone field.
	/// </summary>
	public ColumnValue Getcorporate_phoneValue()
	{
		return this.GetValue(TableUtils.corporate_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_phone field.
	/// </summary>
	public string Getcorporate_phoneFieldValue()
	{
		return this.GetValue(TableUtils.corporate_phoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_phone field.
	/// </summary>
	public void Setcorporate_phoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_phone field.
	/// </summary>
	public void Setcorporate_phoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_phoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_fax field.
	/// </summary>
	public ColumnValue Getcorporate_faxValue()
	{
		return this.GetValue(TableUtils.corporate_faxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_fax field.
	/// </summary>
	public string Getcorporate_faxFieldValue()
	{
		return this.GetValue(TableUtils.corporate_faxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_fax field.
	/// </summary>
	public void Setcorporate_faxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_faxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_fax field.
	/// </summary>
	public void Setcorporate_faxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_faxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_active field.
	/// </summary>
	public ColumnValue Getcorporate_activeValue()
	{
		return this.GetValue(TableUtils.corporate_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_active field.
	/// </summary>
	public bool Getcorporate_activeFieldValue()
	{
		return this.GetValue(TableUtils.corporate_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_active field.
	/// </summary>
	public void Setcorporate_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_active field.
	/// </summary>
	public void Setcorporate_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_active field.
	/// </summary>
	public void Setcorporate_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_inventory field.
	/// </summary>
	public ColumnValue Getcorporate_inventoryValue()
	{
		return this.GetValue(TableUtils.corporate_inventoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_inventory field.
	/// </summary>
	public bool Getcorporate_inventoryFieldValue()
	{
		return this.GetValue(TableUtils.corporate_inventoryColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_inventory field.
	/// </summary>
	public void Setcorporate_inventoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_inventoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_inventory field.
	/// </summary>
	public void Setcorporate_inventoryFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_inventoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_inventory field.
	/// </summary>
	public void Setcorporate_inventoryFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_inventoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_scope field.
	/// </summary>
	public ColumnValue Getcorporate_scopeValue()
	{
		return this.GetValue(TableUtils.corporate_scopeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_.corporate_scope field.
	/// </summary>
	public bool Getcorporate_scopeFieldValue()
	{
		return this.GetValue(TableUtils.corporate_scopeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_scope field.
	/// </summary>
	public void Setcorporate_scopeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_scopeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_scope field.
	/// </summary>
	public void Setcorporate_scopeFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_scopeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_scope field.
	/// </summary>
	public void Setcorporate_scopeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_scopeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_id field.
	/// </summary>
	public string corporate_idDefault
	{
		get
		{
			return TableUtils.corporate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_name field.
	/// </summary>
	public string corporate_name
	{
		get
		{
			return this.GetValue(TableUtils.corporate_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_name field.
	/// </summary>
	public string corporate_nameDefault
	{
		get
		{
			return TableUtils.corporate_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_address1 field.
	/// </summary>
	public string corporate_address1
	{
		get
		{
			return this.GetValue(TableUtils.corporate_address1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_address1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_address1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_address1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_address1 field.
	/// </summary>
	public string corporate_address1Default
	{
		get
		{
			return TableUtils.corporate_address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_address2 field.
	/// </summary>
	public string corporate_address2
	{
		get
		{
			return this.GetValue(TableUtils.corporate_address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_address2 field.
	/// </summary>
	public string corporate_address2Default
	{
		get
		{
			return TableUtils.corporate_address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_city field.
	/// </summary>
	public string corporate_city
	{
		get
		{
			return this.GetValue(TableUtils.corporate_cityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_cityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_citySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_cityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_city field.
	/// </summary>
	public string corporate_cityDefault
	{
		get
		{
			return TableUtils.corporate_cityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_province_code field.
	/// </summary>
	public string corporate_province_code
	{
		get
		{
			return this.GetValue(TableUtils.corporate_province_codeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_province_codeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_province_codeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_province_codeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_province_code field.
	/// </summary>
	public string corporate_province_codeDefault
	{
		get
		{
			return TableUtils.corporate_province_codeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_postalcode field.
	/// </summary>
	public string corporate_postalcode
	{
		get
		{
			return this.GetValue(TableUtils.corporate_postalcodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_postalcodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_postalcodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_postalcodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_postalcode field.
	/// </summary>
	public string corporate_postalcodeDefault
	{
		get
		{
			return TableUtils.corporate_postalcodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_phone field.
	/// </summary>
	public string corporate_phone
	{
		get
		{
			return this.GetValue(TableUtils.corporate_phoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_phoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_phoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_phoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_phone field.
	/// </summary>
	public string corporate_phoneDefault
	{
		get
		{
			return TableUtils.corporate_phoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_fax field.
	/// </summary>
	public string corporate_fax
	{
		get
		{
			return this.GetValue(TableUtils.corporate_faxColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_faxColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_faxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_faxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_fax field.
	/// </summary>
	public string corporate_faxDefault
	{
		get
		{
			return TableUtils.corporate_faxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_active field.
	/// </summary>
	public bool corporate_active
	{
		get
		{
			return this.GetValue(TableUtils.corporate_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.corporate_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_active field.
	/// </summary>
	public string corporate_activeDefault
	{
		get
		{
			return TableUtils.corporate_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_inventory field.
	/// </summary>
	public bool corporate_inventory
	{
		get
		{
			return this.GetValue(TableUtils.corporate_inventoryColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.corporate_inventoryColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_inventorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_inventoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_inventory field.
	/// </summary>
	public string corporate_inventoryDefault
	{
		get
		{
			return TableUtils.corporate_inventoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_.corporate_scope field.
	/// </summary>
	public bool corporate_scope
	{
		get
		{
			return this.GetValue(TableUtils.corporate_scopeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.corporate_scopeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_scopeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_scopeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_.corporate_scope field.
	/// </summary>
	public string corporate_scopeDefault
	{
		get
		{
			return TableUtils.corporate_scopeColumn.DefaultValue;
		}
	}


#endregion
}

}
