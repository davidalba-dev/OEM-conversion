// This class is "generated" and will be overwritten.
// Your customizations should be made in CountriesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="CountriesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="CountriesTable"></see> class.
/// </remarks>
/// <seealso cref="CountriesTable"></seealso>
/// <seealso cref="CountriesRecord"></seealso>
public class BaseCountriesRecord : PrimaryKeyRecord
{

	public readonly static CountriesTable TableUtils = CountriesTable.Instance;

	// Constructors
 
	protected BaseCountriesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.CountriesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.CountriesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.CountriesRecord_ReadRecord); 
	}

	protected BaseCountriesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void CountriesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                CountriesRecord CountriesRec = (CountriesRecord)sender;
        if(CountriesRec != null && !CountriesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void CountriesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                CountriesRecord CountriesRec = (CountriesRecord)sender;
        Validate_Inserting();
        if(CountriesRec != null && !CountriesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void CountriesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                CountriesRecord CountriesRec = (CountriesRecord)sender;
        Validate_Updating();
        if(CountriesRec != null && !CountriesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Continent field.
	/// </summary>
	public ColumnValue GetContinentValue()
	{
		return this.GetValue(TableUtils.ContinentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Continent field.
	/// </summary>
	public string GetContinentFieldValue()
	{
		return this.GetValue(TableUtils.ContinentColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Continent field.
	/// </summary>
	public void SetContinentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContinentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Continent field.
	/// </summary>
	public void SetContinentFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContinentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Country field.
	/// </summary>
	public ColumnValue GetCountryValue()
	{
		return this.GetValue(TableUtils.CountryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Country field.
	/// </summary>
	public string GetCountryFieldValue()
	{
		return this.GetValue(TableUtils.CountryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Country field.
	/// </summary>
	public void SetCountryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CountryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Country field.
	/// </summary>
	public void SetCountryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Country2 field.
	/// </summary>
	public ColumnValue GetCountry2Value()
	{
		return this.GetValue(TableUtils.Country2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Country2 field.
	/// </summary>
	public string GetCountry2FieldValue()
	{
		return this.GetValue(TableUtils.Country2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Country2 field.
	/// </summary>
	public void SetCountry2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Country2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Country2 field.
	/// </summary>
	public void SetCountry2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Country2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Priority field.
	/// </summary>
	public ColumnValue GetPriorityValue()
	{
		return this.GetValue(TableUtils.PriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Priority field.
	/// </summary>
	public Byte GetPriorityFieldValue()
	{
		return this.GetValue(TableUtils.PriorityColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Priority field.
	/// </summary>
	public void SetPriorityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Priority field.
	/// </summary>
	public void SetPriorityFieldValue(string val)
	{
		this.SetString(val, TableUtils.PriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Priority field.
	/// </summary>
	public void SetPriorityFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Priority field.
	/// </summary>
	public void SetPriorityFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Priority field.
	/// </summary>
	public void SetPriorityFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PriorityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Region field.
	/// </summary>
	public ColumnValue GetRegionValue()
	{
		return this.GetValue(TableUtils.RegionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Region field.
	/// </summary>
	public string GetRegionFieldValue()
	{
		return this.GetValue(TableUtils.RegionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Region field.
	/// </summary>
	public void SetRegionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Region field.
	/// </summary>
	public void SetRegionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Countries_.Continent field.
	/// </summary>
	public string Continent
	{
		get
		{
			return this.GetValue(TableUtils.ContinentColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContinentColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContinentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContinentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Continent field.
	/// </summary>
	public string ContinentDefault
	{
		get
		{
			return TableUtils.ContinentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Countries_.Country field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Country field.
	/// </summary>
	public string CountryDefault
	{
		get
		{
			return TableUtils.CountryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Countries_.Country2 field.
	/// </summary>
	public string Country2
	{
		get
		{
			return this.GetValue(TableUtils.Country2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Country2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Country2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Country2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Country2 field.
	/// </summary>
	public string Country2Default
	{
		get
		{
			return TableUtils.Country2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Countries_.Priority field.
	/// </summary>
	public Byte Priority
	{
		get
		{
			return this.GetValue(TableUtils.PriorityColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PriorityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PrioritySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PriorityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Priority field.
	/// </summary>
	public string PriorityDefault
	{
		get
		{
			return TableUtils.PriorityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Countries_.Region field.
	/// </summary>
	public string Region
	{
		get
		{
			return this.GetValue(TableUtils.RegionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RegionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RegionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RegionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Region field.
	/// </summary>
	public string RegionDefault
	{
		get
		{
			return TableUtils.RegionColumn.DefaultValue;
		}
	}


#endregion
}

}
