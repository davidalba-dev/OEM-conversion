// This class is "generated" and will be overwritten.
// Your customizations should be made in Contractor_contactRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Contractor_contactRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Contractor_contactTable"></see> class.
/// </remarks>
/// <seealso cref="Contractor_contactTable"></seealso>
/// <seealso cref="Contractor_contactRecord"></seealso>
public class BaseContractor_contactRecord : PrimaryKeyRecord
{

	public readonly static Contractor_contactTable TableUtils = Contractor_contactTable.Instance;

	// Constructors
 
	protected BaseContractor_contactRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Contractor_contactRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Contractor_contactRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Contractor_contactRecord_ReadRecord); 
	}

	protected BaseContractor_contactRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Contractor_contactRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Contractor_contactRecord Contractor_contactRec = (Contractor_contactRecord)sender;
        if(Contractor_contactRec != null && !Contractor_contactRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Contractor_contactRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Contractor_contactRecord Contractor_contactRec = (Contractor_contactRecord)sender;
        Validate_Inserting();
        if(Contractor_contactRec != null && !Contractor_contactRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Contractor_contactRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Contractor_contactRecord Contractor_contactRec = (Contractor_contactRecord)sender;
        Validate_Updating();
        if(Contractor_contactRec != null && !Contractor_contactRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_contact_id field.
	/// </summary>
	public ColumnValue Getcontractor_contact_idValue()
	{
		return this.GetValue(TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_contact_id field.
	/// </summary>
	public Int32 Getcontractor_contact_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_contact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_first_name field.
	/// </summary>
	public ColumnValue Getcontractor_first_nameValue()
	{
		return this.GetValue(TableUtils.contractor_first_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_first_name field.
	/// </summary>
	public string Getcontractor_first_nameFieldValue()
	{
		return this.GetValue(TableUtils.contractor_first_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_first_name field.
	/// </summary>
	public void Setcontractor_first_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_first_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_first_name field.
	/// </summary>
	public void Setcontractor_first_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_first_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_last_name field.
	/// </summary>
	public ColumnValue Getcontractor_last_nameValue()
	{
		return this.GetValue(TableUtils.contractor_last_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_last_name field.
	/// </summary>
	public string Getcontractor_last_nameFieldValue()
	{
		return this.GetValue(TableUtils.contractor_last_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_last_name field.
	/// </summary>
	public void Setcontractor_last_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_last_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_last_name field.
	/// </summary>
	public void Setcontractor_last_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_last_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_email field.
	/// </summary>
	public ColumnValue Getcontractor_emailValue()
	{
		return this.GetValue(TableUtils.contractor_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_email field.
	/// </summary>
	public string Getcontractor_emailFieldValue()
	{
		return this.GetValue(TableUtils.contractor_emailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_email field.
	/// </summary>
	public void Setcontractor_emailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_email field.
	/// </summary>
	public void Setcontractor_emailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_emailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_phone field.
	/// </summary>
	public ColumnValue Getcontractor_phoneValue()
	{
		return this.GetValue(TableUtils.contractor_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_phone field.
	/// </summary>
	public string Getcontractor_phoneFieldValue()
	{
		return this.GetValue(TableUtils.contractor_phoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_phone field.
	/// </summary>
	public void Setcontractor_phoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_phone field.
	/// </summary>
	public void Setcontractor_phoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_phoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_active field.
	/// </summary>
	public ColumnValue Getcontractor_activeValue()
	{
		return this.GetValue(TableUtils.contractor_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_active field.
	/// </summary>
	public bool Getcontractor_activeFieldValue()
	{
		return this.GetValue(TableUtils.contractor_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_active field.
	/// </summary>
	public void Setcontractor_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_active field.
	/// </summary>
	public void Setcontractor_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_active field.
	/// </summary>
	public void Setcontractor_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_id field.
	/// </summary>
	public ColumnValue Getcontractor_idValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_.contractor_id field.
	/// </summary>
	public Int32 Getcontractor_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_.contractor_contact_id field.
	/// </summary>
	public Int32 contractor_contact_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_contact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_contact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_contact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_contact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_contact_id field.
	/// </summary>
	public string contractor_contact_idDefault
	{
		get
		{
			return TableUtils.contractor_contact_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_.contractor_first_name field.
	/// </summary>
	public string contractor_first_name
	{
		get
		{
			return this.GetValue(TableUtils.contractor_first_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_first_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_first_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_first_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_first_name field.
	/// </summary>
	public string contractor_first_nameDefault
	{
		get
		{
			return TableUtils.contractor_first_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_.contractor_last_name field.
	/// </summary>
	public string contractor_last_name
	{
		get
		{
			return this.GetValue(TableUtils.contractor_last_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_last_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_last_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_last_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_last_name field.
	/// </summary>
	public string contractor_last_nameDefault
	{
		get
		{
			return TableUtils.contractor_last_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_.contractor_email field.
	/// </summary>
	public string contractor_email
	{
		get
		{
			return this.GetValue(TableUtils.contractor_emailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_emailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_emailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_emailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_email field.
	/// </summary>
	public string contractor_emailDefault
	{
		get
		{
			return TableUtils.contractor_emailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_.contractor_phone field.
	/// </summary>
	public string contractor_phone
	{
		get
		{
			return this.GetValue(TableUtils.contractor_phoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_phoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_phoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_phoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_phone field.
	/// </summary>
	public string contractor_phoneDefault
	{
		get
		{
			return TableUtils.contractor_phoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_.contractor_active field.
	/// </summary>
	public bool contractor_active
	{
		get
		{
			return this.GetValue(TableUtils.contractor_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.contractor_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_active field.
	/// </summary>
	public string contractor_activeDefault
	{
		get
		{
			return TableUtils.contractor_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_.contractor_id field.
	/// </summary>
	public Int32 contractor_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_.contractor_id field.
	/// </summary>
	public string contractor_idDefault
	{
		get
		{
			return TableUtils.contractor_idColumn.DefaultValue;
		}
	}


#endregion
}

}
