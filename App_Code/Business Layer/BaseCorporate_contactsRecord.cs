// This class is "generated" and will be overwritten.
// Your customizations should be made in Corporate_contactsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Corporate_contactsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Corporate_contactsTable"></see> class.
/// </remarks>
/// <seealso cref="Corporate_contactsTable"></seealso>
/// <seealso cref="Corporate_contactsRecord"></seealso>
public class BaseCorporate_contactsRecord : PrimaryKeyRecord
{

	public readonly static Corporate_contactsTable TableUtils = Corporate_contactsTable.Instance;

	// Constructors
 
	protected BaseCorporate_contactsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Corporate_contactsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Corporate_contactsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Corporate_contactsRecord_ReadRecord); 
	}

	protected BaseCorporate_contactsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Corporate_contactsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Corporate_contactsRecord Corporate_contactsRec = (Corporate_contactsRecord)sender;
        if(Corporate_contactsRec != null && !Corporate_contactsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Corporate_contactsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Corporate_contactsRecord Corporate_contactsRec = (Corporate_contactsRecord)sender;
        Validate_Inserting();
        if(Corporate_contactsRec != null && !Corporate_contactsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Corporate_contactsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Corporate_contactsRecord Corporate_contactsRec = (Corporate_contactsRecord)sender;
        Validate_Updating();
        if(Corporate_contactsRec != null && !Corporate_contactsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.CorporateContact_Id field.
	/// </summary>
	public ColumnValue GetCorporateContact_IdValue()
	{
		return this.GetValue(TableUtils.CorporateContact_IdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.CorporateContact_Id field.
	/// </summary>
	public Int32 GetCorporateContact_IdFieldValue()
	{
		return this.GetValue(TableUtils.CorporateContact_IdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_first field.
	/// </summary>
	public ColumnValue Getcorporatecontact_firstValue()
	{
		return this.GetValue(TableUtils.corporatecontact_firstColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_first field.
	/// </summary>
	public string Getcorporatecontact_firstFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_firstColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_first field.
	/// </summary>
	public void Setcorporatecontact_firstFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_firstColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_first field.
	/// </summary>
	public void Setcorporatecontact_firstFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_firstColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_last field.
	/// </summary>
	public ColumnValue Getcorporatecontact_lastValue()
	{
		return this.GetValue(TableUtils.corporatecontact_lastColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_last field.
	/// </summary>
	public string Getcorporatecontact_lastFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_lastColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_last field.
	/// </summary>
	public void Setcorporatecontact_lastFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_lastColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_last field.
	/// </summary>
	public void Setcorporatecontact_lastFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_lastColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_phone field.
	/// </summary>
	public ColumnValue Getcorporatecontact_phoneValue()
	{
		return this.GetValue(TableUtils.corporatecontact_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_phone field.
	/// </summary>
	public string Getcorporatecontact_phoneFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_phoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_phone field.
	/// </summary>
	public void Setcorporatecontact_phoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_phone field.
	/// </summary>
	public void Setcorporatecontact_phoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_phoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_title field.
	/// </summary>
	public ColumnValue Getcorporatecontact_titleValue()
	{
		return this.GetValue(TableUtils.corporatecontact_titleColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_title field.
	/// </summary>
	public string Getcorporatecontact_titleFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_titleColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_title field.
	/// </summary>
	public void Setcorporatecontact_titleFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_titleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_title field.
	/// </summary>
	public void Setcorporatecontact_titleFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_titleColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_active field.
	/// </summary>
	public ColumnValue Getcorporatecontact_activeValue()
	{
		return this.GetValue(TableUtils.corporatecontact_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_active field.
	/// </summary>
	public bool Getcorporatecontact_activeFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_active field.
	/// </summary>
	public void Setcorporatecontact_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_active field.
	/// </summary>
	public void Setcorporatecontact_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporatecontact_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_active field.
	/// </summary>
	public void Setcorporatecontact_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporate_id field.
	/// </summary>
	public ColumnValue Getcorporate_idValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporate_id field.
	/// </summary>
	public Int32 Getcorporate_idFieldValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_email field.
	/// </summary>
	public ColumnValue Getcorporatecontact_emailValue()
	{
		return this.GetValue(TableUtils.corporatecontact_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's corporate_contacts_.corporatecontact_email field.
	/// </summary>
	public string Getcorporatecontact_emailFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_emailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_email field.
	/// </summary>
	public void Setcorporatecontact_emailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_email field.
	/// </summary>
	public void Setcorporatecontact_emailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_emailColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_contacts_.CorporateContact_Id field.
	/// </summary>
	public Int32 CorporateContact_Id
	{
		get
		{
			return this.GetValue(TableUtils.CorporateContact_IdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CorporateContact_IdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CorporateContact_IdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CorporateContact_IdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.CorporateContact_Id field.
	/// </summary>
	public string CorporateContact_IdDefault
	{
		get
		{
			return TableUtils.CorporateContact_IdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_contacts_.corporatecontact_first field.
	/// </summary>
	public string corporatecontact_first
	{
		get
		{
			return this.GetValue(TableUtils.corporatecontact_firstColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporatecontact_firstColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporatecontact_firstSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporatecontact_firstColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_first field.
	/// </summary>
	public string corporatecontact_firstDefault
	{
		get
		{
			return TableUtils.corporatecontact_firstColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_contacts_.corporatecontact_last field.
	/// </summary>
	public string corporatecontact_last
	{
		get
		{
			return this.GetValue(TableUtils.corporatecontact_lastColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporatecontact_lastColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporatecontact_lastSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporatecontact_lastColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_last field.
	/// </summary>
	public string corporatecontact_lastDefault
	{
		get
		{
			return TableUtils.corporatecontact_lastColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_contacts_.corporatecontact_phone field.
	/// </summary>
	public string corporatecontact_phone
	{
		get
		{
			return this.GetValue(TableUtils.corporatecontact_phoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporatecontact_phoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporatecontact_phoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporatecontact_phoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_phone field.
	/// </summary>
	public string corporatecontact_phoneDefault
	{
		get
		{
			return TableUtils.corporatecontact_phoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_contacts_.corporatecontact_title field.
	/// </summary>
	public string corporatecontact_title
	{
		get
		{
			return this.GetValue(TableUtils.corporatecontact_titleColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporatecontact_titleColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporatecontact_titleSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporatecontact_titleColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_title field.
	/// </summary>
	public string corporatecontact_titleDefault
	{
		get
		{
			return TableUtils.corporatecontact_titleColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_contacts_.corporatecontact_active field.
	/// </summary>
	public bool corporatecontact_active
	{
		get
		{
			return this.GetValue(TableUtils.corporatecontact_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.corporatecontact_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporatecontact_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporatecontact_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_active field.
	/// </summary>
	public string corporatecontact_activeDefault
	{
		get
		{
			return TableUtils.corporatecontact_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_contacts_.corporate_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporate_id field.
	/// </summary>
	public string corporate_idDefault
	{
		get
		{
			return TableUtils.corporate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's corporate_contacts_.corporatecontact_email field.
	/// </summary>
	public string corporatecontact_email
	{
		get
		{
			return this.GetValue(TableUtils.corporatecontact_emailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporatecontact_emailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporatecontact_emailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporatecontact_emailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's corporate_contacts_.corporatecontact_email field.
	/// </summary>
	public string corporatecontact_emailDefault
	{
		get
		{
			return TableUtils.corporatecontact_emailColumn.DefaultValue;
		}
	}


#endregion
}

}
