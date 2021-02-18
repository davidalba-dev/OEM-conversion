// This class is "generated" and will be overwritten.
// Your customizations should be made in ProvincesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ProvincesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ProvincesTable"></see> class.
/// </remarks>
/// <seealso cref="ProvincesTable"></seealso>
/// <seealso cref="ProvincesRecord"></seealso>
public class BaseProvincesRecord : PrimaryKeyRecord
{

	public readonly static ProvincesTable TableUtils = ProvincesTable.Instance;

	// Constructors
 
	protected BaseProvincesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ProvincesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ProvincesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ProvincesRecord_ReadRecord); 
	}

	protected BaseProvincesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ProvincesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ProvincesRecord ProvincesRec = (ProvincesRecord)sender;
        if(ProvincesRec != null && !ProvincesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ProvincesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ProvincesRecord ProvincesRec = (ProvincesRecord)sender;
        Validate_Inserting();
        if(ProvincesRec != null && !ProvincesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ProvincesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ProvincesRecord ProvincesRec = (ProvincesRecord)sender;
        Validate_Updating();
        if(ProvincesRec != null && !ProvincesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.Country field.
	/// </summary>
	public ColumnValue GetCountryValue()
	{
		return this.GetValue(TableUtils.CountryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.Country field.
	/// </summary>
	public string GetCountryFieldValue()
	{
		return this.GetValue(TableUtils.CountryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.Country field.
	/// </summary>
	public void SetCountryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CountryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.Country field.
	/// </summary>
	public void SetCountryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.GeoGroup field.
	/// </summary>
	public ColumnValue GetGeoGroupValue()
	{
		return this.GetValue(TableUtils.GeoGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.GeoGroup field.
	/// </summary>
	public string GetGeoGroupFieldValue()
	{
		return this.GetValue(TableUtils.GeoGroupColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.GeoGroup field.
	/// </summary>
	public void SetGeoGroupFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GeoGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.GeoGroup field.
	/// </summary>
	public void SetGeoGroupFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GeoGroupColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.ProvCode field.
	/// </summary>
	public ColumnValue GetProvCodeValue()
	{
		return this.GetValue(TableUtils.ProvCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.ProvCode field.
	/// </summary>
	public string GetProvCodeFieldValue()
	{
		return this.GetValue(TableUtils.ProvCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.ProvCode field.
	/// </summary>
	public void SetProvCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProvCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.ProvCode field.
	/// </summary>
	public void SetProvCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProvCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.ProvCodeDisplay field.
	/// </summary>
	public ColumnValue GetProvCodeDisplayValue()
	{
		return this.GetValue(TableUtils.ProvCodeDisplayColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.ProvCodeDisplay field.
	/// </summary>
	public string GetProvCodeDisplayFieldValue()
	{
		return this.GetValue(TableUtils.ProvCodeDisplayColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.ProvCodeDisplay field.
	/// </summary>
	public void SetProvCodeDisplayFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProvCodeDisplayColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.ProvCodeDisplay field.
	/// </summary>
	public void SetProvCodeDisplayFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProvCodeDisplayColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.ProvName field.
	/// </summary>
	public ColumnValue GetProvNameValue()
	{
		return this.GetValue(TableUtils.ProvNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.ProvName field.
	/// </summary>
	public string GetProvNameFieldValue()
	{
		return this.GetValue(TableUtils.ProvNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.ProvName field.
	/// </summary>
	public void SetProvNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProvNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.ProvName field.
	/// </summary>
	public void SetProvNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProvNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.Prov_active field.
	/// </summary>
	public ColumnValue GetProv_activeValue()
	{
		return this.GetValue(TableUtils.Prov_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Provinces_.Prov_active field.
	/// </summary>
	public bool GetProv_activeFieldValue()
	{
		return this.GetValue(TableUtils.Prov_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.Prov_active field.
	/// </summary>
	public void SetProv_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Prov_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.Prov_active field.
	/// </summary>
	public void SetProv_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.Prov_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.Prov_active field.
	/// </summary>
	public void SetProv_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Prov_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Provinces_.Country field.
	/// </summary>
	public string Country
	{
		get
		{
			return this.GetValue(TableUtils.CountryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CountryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CountrySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CountryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.Country field.
	/// </summary>
	public string CountryDefault
	{
		get
		{
			return TableUtils.CountryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Provinces_.GeoGroup field.
	/// </summary>
	public string GeoGroup
	{
		get
		{
			return this.GetValue(TableUtils.GeoGroupColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GeoGroupColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GeoGroupSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GeoGroupColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.GeoGroup field.
	/// </summary>
	public string GeoGroupDefault
	{
		get
		{
			return TableUtils.GeoGroupColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Provinces_.ProvCode field.
	/// </summary>
	public string ProvCode
	{
		get
		{
			return this.GetValue(TableUtils.ProvCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProvCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProvCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProvCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.ProvCode field.
	/// </summary>
	public string ProvCodeDefault
	{
		get
		{
			return TableUtils.ProvCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Provinces_.ProvCodeDisplay field.
	/// </summary>
	public string ProvCodeDisplay
	{
		get
		{
			return this.GetValue(TableUtils.ProvCodeDisplayColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProvCodeDisplayColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProvCodeDisplaySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProvCodeDisplayColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.ProvCodeDisplay field.
	/// </summary>
	public string ProvCodeDisplayDefault
	{
		get
		{
			return TableUtils.ProvCodeDisplayColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Provinces_.ProvName field.
	/// </summary>
	public string ProvName
	{
		get
		{
			return this.GetValue(TableUtils.ProvNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProvNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProvNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProvNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.ProvName field.
	/// </summary>
	public string ProvNameDefault
	{
		get
		{
			return TableUtils.ProvNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Provinces_.Prov_active field.
	/// </summary>
	public bool Prov_active
	{
		get
		{
			return this.GetValue(TableUtils.Prov_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Prov_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Prov_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Prov_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Provinces_.Prov_active field.
	/// </summary>
	public string Prov_activeDefault
	{
		get
		{
			return TableUtils.Prov_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
