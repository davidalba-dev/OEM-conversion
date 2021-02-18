// This class is "generated" and will be overwritten.
// Your customizations should be made in Refurb_part_vendorRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Refurb_part_vendorRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Refurb_part_vendorTable"></see> class.
/// </remarks>
/// <seealso cref="Refurb_part_vendorTable"></seealso>
/// <seealso cref="Refurb_part_vendorRecord"></seealso>
public class BaseRefurb_part_vendorRecord : PrimaryKeyRecord
{

	public readonly static Refurb_part_vendorTable TableUtils = Refurb_part_vendorTable.Instance;

	// Constructors
 
	protected BaseRefurb_part_vendorRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Refurb_part_vendorRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Refurb_part_vendorRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Refurb_part_vendorRecord_ReadRecord); 
	}

	protected BaseRefurb_part_vendorRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Refurb_part_vendorRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Refurb_part_vendorRecord Refurb_part_vendorRec = (Refurb_part_vendorRecord)sender;
        if(Refurb_part_vendorRec != null && !Refurb_part_vendorRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Refurb_part_vendorRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Refurb_part_vendorRecord Refurb_part_vendorRec = (Refurb_part_vendorRecord)sender;
        Validate_Inserting();
        if(Refurb_part_vendorRec != null && !Refurb_part_vendorRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Refurb_part_vendorRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Refurb_part_vendorRecord Refurb_part_vendorRec = (Refurb_part_vendorRecord)sender;
        Validate_Updating();
        if(Refurb_part_vendorRec != null && !Refurb_part_vendorRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_id field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_idValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_id field.
	/// </summary>
	public Decimal Getrefurb_part_vendor_idFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_name field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_nameValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_name field.
	/// </summary>
	public string Getrefurb_part_vendor_nameFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_name field.
	/// </summary>
	public void Setrefurb_part_vendor_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_name field.
	/// </summary>
	public void Setrefurb_part_vendor_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_address1 field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_address1Value()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_address1 field.
	/// </summary>
	public string Getrefurb_part_vendor_address1FieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_address1 field.
	/// </summary>
	public void Setrefurb_part_vendor_address1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_address1 field.
	/// </summary>
	public void Setrefurb_part_vendor_address1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_address2 field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_address2Value()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_address2 field.
	/// </summary>
	public string Getrefurb_part_vendor_address2FieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_address2 field.
	/// </summary>
	public void Setrefurb_part_vendor_address2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_address2 field.
	/// </summary>
	public void Setrefurb_part_vendor_address2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_city field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_cityValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_city field.
	/// </summary>
	public string Getrefurb_part_vendor_cityFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_cityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_city field.
	/// </summary>
	public void Setrefurb_part_vendor_cityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_city field.
	/// </summary>
	public void Setrefurb_part_vendor_cityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_cityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_state_id field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_state_idValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_state_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_state_id field.
	/// </summary>
	public string Getrefurb_part_vendor_state_idFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_state_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_state_id field.
	/// </summary>
	public void Setrefurb_part_vendor_state_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_state_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_state_id field.
	/// </summary>
	public void Setrefurb_part_vendor_state_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_state_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_zip field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_zipValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_zipColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_zip field.
	/// </summary>
	public string Getrefurb_part_vendor_zipFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_zipColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_zip field.
	/// </summary>
	public void Setrefurb_part_vendor_zipFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_zipColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_zip field.
	/// </summary>
	public void Setrefurb_part_vendor_zipFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_zipColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_phone field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_phoneValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_phone field.
	/// </summary>
	public string Getrefurb_part_vendor_phoneFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_phoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_phone field.
	/// </summary>
	public void Setrefurb_part_vendor_phoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_phone field.
	/// </summary>
	public void Setrefurb_part_vendor_phoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_phoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_web field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_webValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_webColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_web field.
	/// </summary>
	public string Getrefurb_part_vendor_webFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_webColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_web field.
	/// </summary>
	public void Setrefurb_part_vendor_webFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_webColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_web field.
	/// </summary>
	public void Setrefurb_part_vendor_webFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_webColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_active field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_activeValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_active field.
	/// </summary>
	public bool Getrefurb_part_vendor_activeFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_active field.
	/// </summary>
	public void Setrefurb_part_vendor_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_active field.
	/// </summary>
	public void Setrefurb_part_vendor_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.refurb_part_vendor_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_active field.
	/// </summary>
	public void Setrefurb_part_vendor_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_email field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_emailValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_email field.
	/// </summary>
	public string Getrefurb_part_vendor_emailFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_emailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_email field.
	/// </summary>
	public void Setrefurb_part_vendor_emailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_email field.
	/// </summary>
	public void Setrefurb_part_vendor_emailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_emailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_fax field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_faxValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_faxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_fax field.
	/// </summary>
	public string Getrefurb_part_vendor_faxFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_faxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_fax field.
	/// </summary>
	public void Setrefurb_part_vendor_faxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_faxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_fax field.
	/// </summary>
	public void Setrefurb_part_vendor_faxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_faxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_notes field.
	/// </summary>
	public ColumnValue Getrefurb_part_vendor_notesValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_notes field.
	/// </summary>
	public string Getrefurb_part_vendor_notesFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_vendor_notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_notes field.
	/// </summary>
	public void Setrefurb_part_vendor_notesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_vendor_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_notes field.
	/// </summary>
	public void Setrefurb_part_vendor_notesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_vendor_notesColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_id field.
	/// </summary>
	public Decimal refurb_part_vendor_id
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_id field.
	/// </summary>
	public string refurb_part_vendor_idDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_name field.
	/// </summary>
	public string refurb_part_vendor_name
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_name field.
	/// </summary>
	public string refurb_part_vendor_nameDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_address1 field.
	/// </summary>
	public string refurb_part_vendor_address1
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_address1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_address1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_address1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_address1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_address1 field.
	/// </summary>
	public string refurb_part_vendor_address1Default
	{
		get
		{
			return TableUtils.refurb_part_vendor_address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_address2 field.
	/// </summary>
	public string refurb_part_vendor_address2
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_address2 field.
	/// </summary>
	public string refurb_part_vendor_address2Default
	{
		get
		{
			return TableUtils.refurb_part_vendor_address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_city field.
	/// </summary>
	public string refurb_part_vendor_city
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_cityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_cityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_citySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_cityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_city field.
	/// </summary>
	public string refurb_part_vendor_cityDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_cityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_state_id field.
	/// </summary>
	public string refurb_part_vendor_state_id
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_state_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_state_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_state_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_state_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_state_id field.
	/// </summary>
	public string refurb_part_vendor_state_idDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_state_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_zip field.
	/// </summary>
	public string refurb_part_vendor_zip
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_zipColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_zipColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_zipSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_zipColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_zip field.
	/// </summary>
	public string refurb_part_vendor_zipDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_zipColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_phone field.
	/// </summary>
	public string refurb_part_vendor_phone
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_phoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_phoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_phoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_phoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_phone field.
	/// </summary>
	public string refurb_part_vendor_phoneDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_phoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_web field.
	/// </summary>
	public string refurb_part_vendor_web
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_webColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_webColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_webSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_webColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_web field.
	/// </summary>
	public string refurb_part_vendor_webDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_webColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_active field.
	/// </summary>
	public bool refurb_part_vendor_active
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.refurb_part_vendor_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_active field.
	/// </summary>
	public string refurb_part_vendor_activeDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_email field.
	/// </summary>
	public string refurb_part_vendor_email
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_emailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_emailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_emailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_emailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_email field.
	/// </summary>
	public string refurb_part_vendor_emailDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_emailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_fax field.
	/// </summary>
	public string refurb_part_vendor_fax
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_faxColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_faxColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_faxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_faxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_fax field.
	/// </summary>
	public string refurb_part_vendor_faxDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_faxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_part_vendor_.refurb_part_vendor_notes field.
	/// </summary>
	public string refurb_part_vendor_notes
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_vendor_notesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_vendor_notesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_vendor_notesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_vendor_notesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_part_vendor_.refurb_part_vendor_notes field.
	/// </summary>
	public string refurb_part_vendor_notesDefault
	{
		get
		{
			return TableUtils.refurb_part_vendor_notesColumn.DefaultValue;
		}
	}


#endregion
}

}
