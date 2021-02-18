// This class is "generated" and will be overwritten.
// Your customizations should be made in Site_inventory_intervalRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Site_inventory_intervalRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Site_inventory_intervalTable"></see> class.
/// </remarks>
/// <seealso cref="Site_inventory_intervalTable"></seealso>
/// <seealso cref="Site_inventory_intervalRecord"></seealso>
public class BaseSite_inventory_intervalRecord : PrimaryKeyRecord
{

	public readonly static Site_inventory_intervalTable TableUtils = Site_inventory_intervalTable.Instance;

	// Constructors
 
	protected BaseSite_inventory_intervalRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Site_inventory_intervalRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Site_inventory_intervalRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Site_inventory_intervalRecord_ReadRecord); 
	}

	protected BaseSite_inventory_intervalRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Site_inventory_intervalRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Site_inventory_intervalRecord Site_inventory_intervalRec = (Site_inventory_intervalRecord)sender;
        if(Site_inventory_intervalRec != null && !Site_inventory_intervalRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Site_inventory_intervalRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Site_inventory_intervalRecord Site_inventory_intervalRec = (Site_inventory_intervalRecord)sender;
        Validate_Inserting();
        if(Site_inventory_intervalRec != null && !Site_inventory_intervalRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Site_inventory_intervalRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Site_inventory_intervalRecord Site_inventory_intervalRec = (Site_inventory_intervalRecord)sender;
        Validate_Updating();
        if(Site_inventory_intervalRec != null && !Site_inventory_intervalRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_interval_.site_inventory_interval_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_interval_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_interval_.site_inventory_interval_id field.
	/// </summary>
	public Int32 Getsite_inventory_interval_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_interval_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_interval_.site_inventory_interval field.
	/// </summary>
	public ColumnValue Getsite_inventory_intervalValue()
	{
		return this.GetValue(TableUtils.site_inventory_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_interval_.site_inventory_interval field.
	/// </summary>
	public string Getsite_inventory_intervalFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_intervalColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_interval_.site_inventory_interval field.
	/// </summary>
	public void Setsite_inventory_intervalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_interval_.site_inventory_interval field.
	/// </summary>
	public void Setsite_inventory_intervalFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_intervalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_interval_.active field.
	/// </summary>
	public ColumnValue GetactiveValue()
	{
		return this.GetValue(TableUtils.activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_interval_.active field.
	/// </summary>
	public bool GetactiveFieldValue()
	{
		return this.GetValue(TableUtils.activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_interval_.active field.
	/// </summary>
	public void SetactiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_interval_.active field.
	/// </summary>
	public void SetactiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_interval_.active field.
	/// </summary>
	public void SetactiveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_interval_.site_inventory_interval_id field.
	/// </summary>
	public Int32 site_inventory_interval_id
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_interval_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_interval_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_interval_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_interval_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_interval_.site_inventory_interval_id field.
	/// </summary>
	public string site_inventory_interval_idDefault
	{
		get
		{
			return TableUtils.site_inventory_interval_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_interval_.site_inventory_interval field.
	/// </summary>
	public string site_inventory_interval
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_intervalColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_intervalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_intervalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_intervalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_interval_.site_inventory_interval field.
	/// </summary>
	public string site_inventory_intervalDefault
	{
		get
		{
			return TableUtils.site_inventory_intervalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_interval_.active field.
	/// </summary>
	public bool active
	{
		get
		{
			return this.GetValue(TableUtils.activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_interval_.active field.
	/// </summary>
	public string activeDefault
	{
		get
		{
			return TableUtils.activeColumn.DefaultValue;
		}
	}


#endregion
}

}
