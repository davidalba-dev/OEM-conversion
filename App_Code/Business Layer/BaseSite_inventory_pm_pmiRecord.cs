// This class is "generated" and will be overwritten.
// Your customizations should be made in Site_inventory_pm_pmiRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Site_inventory_pm_pmiRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Site_inventory_pm_pmiTable"></see> class.
/// </remarks>
/// <seealso cref="Site_inventory_pm_pmiTable"></seealso>
/// <seealso cref="Site_inventory_pm_pmiRecord"></seealso>
public class BaseSite_inventory_pm_pmiRecord : PrimaryKeyRecord
{

	public readonly static Site_inventory_pm_pmiTable TableUtils = Site_inventory_pm_pmiTable.Instance;

	// Constructors
 
	protected BaseSite_inventory_pm_pmiRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Site_inventory_pm_pmiRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Site_inventory_pm_pmiRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Site_inventory_pm_pmiRecord_ReadRecord); 
	}

	protected BaseSite_inventory_pm_pmiRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Site_inventory_pm_pmiRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Site_inventory_pm_pmiRecord Site_inventory_pm_pmiRec = (Site_inventory_pm_pmiRecord)sender;
        if(Site_inventory_pm_pmiRec != null && !Site_inventory_pm_pmiRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Site_inventory_pm_pmiRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Site_inventory_pm_pmiRecord Site_inventory_pm_pmiRec = (Site_inventory_pm_pmiRecord)sender;
        Validate_Inserting();
        if(Site_inventory_pm_pmiRec != null && !Site_inventory_pm_pmiRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Site_inventory_pm_pmiRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Site_inventory_pm_pmiRecord Site_inventory_pm_pmiRec = (Site_inventory_pm_pmiRecord)sender;
        Validate_Updating();
        if(Site_inventory_pm_pmiRec != null && !Site_inventory_pm_pmiRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.site_inventory_pm_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_pm_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_pm_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.site_inventory_pm_id field.
	/// </summary>
	public Int32 Getsite_inventory_pm_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_pm_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.site_inventory_d field.
	/// </summary>
	public ColumnValue Getsite_inventory_dValue()
	{
		return this.GetValue(TableUtils.site_inventory_dColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.site_inventory_d field.
	/// </summary>
	public Int32 Getsite_inventory_dFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_dColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.site_inventory_d field.
	/// </summary>
	public void Setsite_inventory_dFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.site_inventory_d field.
	/// </summary>
	public void Setsite_inventory_dFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.site_inventory_d field.
	/// </summary>
	public void Setsite_inventory_dFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.site_inventory_d field.
	/// </summary>
	public void Setsite_inventory_dFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.site_inventory_d field.
	/// </summary>
	public void Setsite_inventory_dFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_dColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.PMI field.
	/// </summary>
	public ColumnValue GetPMIValue()
	{
		return this.GetValue(TableUtils.PMIColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.PMI field.
	/// </summary>
	public bool GetPMIFieldValue()
	{
		return this.GetValue(TableUtils.PMIColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI field.
	/// </summary>
	public void SetPMIFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PMIColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI field.
	/// </summary>
	public void SetPMIFieldValue(string val)
	{
		this.SetString(val, TableUtils.PMIColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI field.
	/// </summary>
	public void SetPMIFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PMIColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.PM_minutes field.
	/// </summary>
	public ColumnValue GetPM_minutesValue()
	{
		return this.GetValue(TableUtils.PM_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.PM_minutes field.
	/// </summary>
	public Int32 GetPM_minutesFieldValue()
	{
		return this.GetValue(TableUtils.PM_minutesColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_minutes field.
	/// </summary>
	public void SetPM_minutesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PM_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_minutes field.
	/// </summary>
	public void SetPM_minutesFieldValue(string val)
	{
		this.SetString(val, TableUtils.PM_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_minutes field.
	/// </summary>
	public void SetPM_minutesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PM_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_minutes field.
	/// </summary>
	public void SetPM_minutesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PM_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_minutes field.
	/// </summary>
	public void SetPM_minutesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PM_minutesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.PM_Interval field.
	/// </summary>
	public ColumnValue GetPM_IntervalValue()
	{
		return this.GetValue(TableUtils.PM_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.PM_Interval field.
	/// </summary>
	public Int32 GetPM_IntervalFieldValue()
	{
		return this.GetValue(TableUtils.PM_IntervalColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_Interval field.
	/// </summary>
	public void SetPM_IntervalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PM_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_Interval field.
	/// </summary>
	public void SetPM_IntervalFieldValue(string val)
	{
		this.SetString(val, TableUtils.PM_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_Interval field.
	/// </summary>
	public void SetPM_IntervalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PM_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_Interval field.
	/// </summary>
	public void SetPM_IntervalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PM_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_Interval field.
	/// </summary>
	public void SetPM_IntervalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PM_IntervalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.PMI_Interval field.
	/// </summary>
	public ColumnValue GetPMI_IntervalValue()
	{
		return this.GetValue(TableUtils.PMI_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_pm_pmi_.PMI_Interval field.
	/// </summary>
	public Int32 GetPMI_IntervalFieldValue()
	{
		return this.GetValue(TableUtils.PMI_IntervalColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI_Interval field.
	/// </summary>
	public void SetPMI_IntervalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PMI_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI_Interval field.
	/// </summary>
	public void SetPMI_IntervalFieldValue(string val)
	{
		this.SetString(val, TableUtils.PMI_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI_Interval field.
	/// </summary>
	public void SetPMI_IntervalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PMI_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI_Interval field.
	/// </summary>
	public void SetPMI_IntervalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PMI_IntervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI_Interval field.
	/// </summary>
	public void SetPMI_IntervalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PMI_IntervalColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_pm_pmi_.site_inventory_pm_id field.
	/// </summary>
	public Int32 site_inventory_pm_id
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_pm_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_pm_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_pm_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_pm_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.site_inventory_pm_id field.
	/// </summary>
	public string site_inventory_pm_idDefault
	{
		get
		{
			return TableUtils.site_inventory_pm_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_pm_pmi_.site_inventory_d field.
	/// </summary>
	public Int32 site_inventory_d
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_dColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_dColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_dSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_dColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.site_inventory_d field.
	/// </summary>
	public string site_inventory_dDefault
	{
		get
		{
			return TableUtils.site_inventory_dColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_pm_pmi_.PMI field.
	/// </summary>
	public bool PMI
	{
		get
		{
			return this.GetValue(TableUtils.PMIColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PMIColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PMISpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PMIColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI field.
	/// </summary>
	public string PMIDefault
	{
		get
		{
			return TableUtils.PMIColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_pm_pmi_.PM_minutes field.
	/// </summary>
	public Int32 PM_minutes
	{
		get
		{
			return this.GetValue(TableUtils.PM_minutesColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PM_minutesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PM_minutesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PM_minutesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_minutes field.
	/// </summary>
	public string PM_minutesDefault
	{
		get
		{
			return TableUtils.PM_minutesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_pm_pmi_.PM_Interval field.
	/// </summary>
	public Int32 PM_Interval
	{
		get
		{
			return this.GetValue(TableUtils.PM_IntervalColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PM_IntervalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PM_IntervalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PM_IntervalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PM_Interval field.
	/// </summary>
	public string PM_IntervalDefault
	{
		get
		{
			return TableUtils.PM_IntervalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_pm_pmi_.PMI_Interval field.
	/// </summary>
	public Int32 PMI_Interval
	{
		get
		{
			return this.GetValue(TableUtils.PMI_IntervalColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PMI_IntervalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PMI_IntervalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PMI_IntervalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_pm_pmi_.PMI_Interval field.
	/// </summary>
	public string PMI_IntervalDefault
	{
		get
		{
			return TableUtils.PMI_IntervalColumn.DefaultValue;
		}
	}


#endregion
}

}
