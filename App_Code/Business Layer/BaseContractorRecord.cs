// This class is "generated" and will be overwritten.
// Your customizations should be made in ContractorRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ContractorRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ContractorTable"></see> class.
/// </remarks>
/// <seealso cref="ContractorTable"></seealso>
/// <seealso cref="ContractorRecord"></seealso>
public class BaseContractorRecord : PrimaryKeyRecord
{

	public readonly static ContractorTable TableUtils = ContractorTable.Instance;

	// Constructors
 
	protected BaseContractorRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ContractorRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ContractorRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ContractorRecord_ReadRecord); 
	}

	protected BaseContractorRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ContractorRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ContractorRecord ContractorRec = (ContractorRecord)sender;
        if(ContractorRec != null && !ContractorRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ContractorRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ContractorRecord ContractorRec = (ContractorRecord)sender;
        Validate_Inserting();
        if(ContractorRec != null && !ContractorRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ContractorRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ContractorRecord ContractorRec = (ContractorRecord)sender;
        Validate_Updating();
        if(ContractorRec != null && !ContractorRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_id field.
	/// </summary>
	public ColumnValue Getcontractor_idValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_id field.
	/// </summary>
	public Int32 Getcontractor_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_name field.
	/// </summary>
	public ColumnValue Getcontractor_nameValue()
	{
		return this.GetValue(TableUtils.contractor_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_name field.
	/// </summary>
	public string Getcontractor_nameFieldValue()
	{
		return this.GetValue(TableUtils.contractor_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_name field.
	/// </summary>
	public void Setcontractor_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_name field.
	/// </summary>
	public void Setcontractor_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_address field.
	/// </summary>
	public ColumnValue Getcontractor_addressValue()
	{
		return this.GetValue(TableUtils.contractor_addressColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_address field.
	/// </summary>
	public string Getcontractor_addressFieldValue()
	{
		return this.GetValue(TableUtils.contractor_addressColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_address field.
	/// </summary>
	public void Setcontractor_addressFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_addressColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_address field.
	/// </summary>
	public void Setcontractor_addressFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_addressColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_address2 field.
	/// </summary>
	public ColumnValue Getcontractor_address2Value()
	{
		return this.GetValue(TableUtils.contractor_address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_address2 field.
	/// </summary>
	public string Getcontractor_address2FieldValue()
	{
		return this.GetValue(TableUtils.contractor_address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_address2 field.
	/// </summary>
	public void Setcontractor_address2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_address2 field.
	/// </summary>
	public void Setcontractor_address2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_city field.
	/// </summary>
	public ColumnValue Getcontractor_cityValue()
	{
		return this.GetValue(TableUtils.contractor_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_city field.
	/// </summary>
	public string Getcontractor_cityFieldValue()
	{
		return this.GetValue(TableUtils.contractor_cityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_city field.
	/// </summary>
	public void Setcontractor_cityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_city field.
	/// </summary>
	public void Setcontractor_cityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_cityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.province_id field.
	/// </summary>
	public ColumnValue Getprovince_idValue()
	{
		return this.GetValue(TableUtils.province_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.province_id field.
	/// </summary>
	public string Getprovince_idFieldValue()
	{
		return this.GetValue(TableUtils.province_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.province_id field.
	/// </summary>
	public void Setprovince_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.province_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.province_id field.
	/// </summary>
	public void Setprovince_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.province_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_zip field.
	/// </summary>
	public ColumnValue Getcontractor_zipValue()
	{
		return this.GetValue(TableUtils.contractor_zipColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_zip field.
	/// </summary>
	public string Getcontractor_zipFieldValue()
	{
		return this.GetValue(TableUtils.contractor_zipColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_zip field.
	/// </summary>
	public void Setcontractor_zipFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_zipColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_zip field.
	/// </summary>
	public void Setcontractor_zipFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_zipColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_phone field.
	/// </summary>
	public ColumnValue Getcontractor_phoneValue()
	{
		return this.GetValue(TableUtils.contractor_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_phone field.
	/// </summary>
	public string Getcontractor_phoneFieldValue()
	{
		return this.GetValue(TableUtils.contractor_phoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_phone field.
	/// </summary>
	public void Setcontractor_phoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_phone field.
	/// </summary>
	public void Setcontractor_phoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_phoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_active field.
	/// </summary>
	public ColumnValue Getcontractor_activeValue()
	{
		return this.GetValue(TableUtils.contractor_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_.contractor_active field.
	/// </summary>
	public bool Getcontractor_activeFieldValue()
	{
		return this.GetValue(TableUtils.contractor_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_active field.
	/// </summary>
	public void Setcontractor_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_active field.
	/// </summary>
	public void Setcontractor_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_active field.
	/// </summary>
	public void Setcontractor_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_.contractor_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_id field.
	/// </summary>
	public string contractor_idDefault
	{
		get
		{
			return TableUtils.contractor_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_.contractor_name field.
	/// </summary>
	public string contractor_name
	{
		get
		{
			return this.GetValue(TableUtils.contractor_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_name field.
	/// </summary>
	public string contractor_nameDefault
	{
		get
		{
			return TableUtils.contractor_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_.contractor_address field.
	/// </summary>
	public string contractor_address
	{
		get
		{
			return this.GetValue(TableUtils.contractor_addressColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_addressColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_addressSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_addressColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_address field.
	/// </summary>
	public string contractor_addressDefault
	{
		get
		{
			return TableUtils.contractor_addressColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_.contractor_address2 field.
	/// </summary>
	public string contractor_address2
	{
		get
		{
			return this.GetValue(TableUtils.contractor_address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_address2 field.
	/// </summary>
	public string contractor_address2Default
	{
		get
		{
			return TableUtils.contractor_address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_.contractor_city field.
	/// </summary>
	public string contractor_city
	{
		get
		{
			return this.GetValue(TableUtils.contractor_cityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_cityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_citySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_cityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_city field.
	/// </summary>
	public string contractor_cityDefault
	{
		get
		{
			return TableUtils.contractor_cityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_.province_id field.
	/// </summary>
	public string province_id
	{
		get
		{
			return this.GetValue(TableUtils.province_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.province_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool province_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.province_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.province_id field.
	/// </summary>
	public string province_idDefault
	{
		get
		{
			return TableUtils.province_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_.contractor_zip field.
	/// </summary>
	public string contractor_zip
	{
		get
		{
			return this.GetValue(TableUtils.contractor_zipColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_zipColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_zipSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_zipColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_zip field.
	/// </summary>
	public string contractor_zipDefault
	{
		get
		{
			return TableUtils.contractor_zipColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_.contractor_phone field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_phone field.
	/// </summary>
	public string contractor_phoneDefault
	{
		get
		{
			return TableUtils.contractor_phoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_.contractor_active field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contractor_.contractor_active field.
	/// </summary>
	public string contractor_activeDefault
	{
		get
		{
			return TableUtils.contractor_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
