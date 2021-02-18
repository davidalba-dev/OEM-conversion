// This class is "generated" and will be overwritten.
// Your customizations should be made in Site_inventory_contract_historyRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Site_inventory_contract_historyRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Site_inventory_contract_historyTable"></see> class.
/// </remarks>
/// <seealso cref="Site_inventory_contract_historyTable"></seealso>
/// <seealso cref="Site_inventory_contract_historyRecord"></seealso>
public class BaseSite_inventory_contract_historyRecord : PrimaryKeyRecord
{

	public readonly static Site_inventory_contract_historyTable TableUtils = Site_inventory_contract_historyTable.Instance;

	// Constructors
 
	protected BaseSite_inventory_contract_historyRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Site_inventory_contract_historyRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Site_inventory_contract_historyRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Site_inventory_contract_historyRecord_ReadRecord); 
	}

	protected BaseSite_inventory_contract_historyRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Site_inventory_contract_historyRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Site_inventory_contract_historyRecord Site_inventory_contract_historyRec = (Site_inventory_contract_historyRecord)sender;
        if(Site_inventory_contract_historyRec != null && !Site_inventory_contract_historyRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Site_inventory_contract_historyRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Site_inventory_contract_historyRecord Site_inventory_contract_historyRec = (Site_inventory_contract_historyRecord)sender;
        Validate_Inserting();
        if(Site_inventory_contract_historyRec != null && !Site_inventory_contract_historyRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Site_inventory_contract_historyRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Site_inventory_contract_historyRecord Site_inventory_contract_historyRec = (Site_inventory_contract_historyRecord)sender;
        Validate_Updating();
        if(Site_inventory_contract_historyRec != null && !Site_inventory_contract_historyRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.site_inventory_contract_history_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_contract_history_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_history_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.site_inventory_contract_history_id field.
	/// </summary>
	public Int32 Getsite_inventory_contract_history_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_history_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.site_inventory_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.site_inventory_id field.
	/// </summary>
	public Int32 Getsite_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_id field.
	/// </summary>
	public void Setsite_inventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.site_inventory_contract_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_contract_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.site_inventory_contract_id field.
	/// </summary>
	public Int32 Getsite_inventory_contract_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.date_added field.
	/// </summary>
	public ColumnValue Getdate_addedValue()
	{
		return this.GetValue(TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.date_added field.
	/// </summary>
	public DateTime Getdate_addedFieldValue()
	{
		return this.GetValue(TableUtils.date_addedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_addedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.date_added field.
	/// </summary>
	public void Setdate_addedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_addedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.date_removed field.
	/// </summary>
	public ColumnValue Getdate_removedValue()
	{
		return this.GetValue(TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.date_removed field.
	/// </summary>
	public DateTime Getdate_removedFieldValue()
	{
		return this.GetValue(TableUtils.date_removedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_removedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.date_removed field.
	/// </summary>
	public void Setdate_removedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_removedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.added_by field.
	/// </summary>
	public ColumnValue Getadded_byValue()
	{
		return this.GetValue(TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.added_by field.
	/// </summary>
	public Int32 Getadded_byFieldValue()
	{
		return this.GetValue(TableUtils.added_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.added_by field.
	/// </summary>
	public void Setadded_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.added_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.removed_by field.
	/// </summary>
	public ColumnValue Getremoved_byValue()
	{
		return this.GetValue(TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_history_.removed_by field.
	/// </summary>
	public Int32 Getremoved_byFieldValue()
	{
		return this.GetValue(TableUtils.removed_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.removed_by field.
	/// </summary>
	public void Setremoved_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.removed_byColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_history_.site_inventory_contract_history_id field.
	/// </summary>
	public Int32 site_inventory_contract_history_id
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_contract_history_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_contract_history_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_contract_history_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_contract_history_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_contract_history_id field.
	/// </summary>
	public string site_inventory_contract_history_idDefault
	{
		get
		{
			return TableUtils.site_inventory_contract_history_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_history_.site_inventory_id field.
	/// </summary>
	public Int32 site_inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_id field.
	/// </summary>
	public string site_inventory_idDefault
	{
		get
		{
			return TableUtils.site_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_history_.site_inventory_contract_id field.
	/// </summary>
	public Int32 site_inventory_contract_id
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_contract_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_contract_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_contract_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.site_inventory_contract_id field.
	/// </summary>
	public string site_inventory_contract_idDefault
	{
		get
		{
			return TableUtils.site_inventory_contract_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_history_.date_added field.
	/// </summary>
	public DateTime date_added
	{
		get
		{
			return this.GetValue(TableUtils.date_addedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_addedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_addedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_addedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.date_added field.
	/// </summary>
	public string date_addedDefault
	{
		get
		{
			return TableUtils.date_addedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_history_.date_removed field.
	/// </summary>
	public DateTime date_removed
	{
		get
		{
			return this.GetValue(TableUtils.date_removedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_removedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_removedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_removedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.date_removed field.
	/// </summary>
	public string date_removedDefault
	{
		get
		{
			return TableUtils.date_removedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_history_.added_by field.
	/// </summary>
	public Int32 added_by
	{
		get
		{
			return this.GetValue(TableUtils.added_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.added_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool added_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.added_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.added_by field.
	/// </summary>
	public string added_byDefault
	{
		get
		{
			return TableUtils.added_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_history_.removed_by field.
	/// </summary>
	public Int32 removed_by
	{
		get
		{
			return this.GetValue(TableUtils.removed_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.removed_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool removed_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.removed_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_history_.removed_by field.
	/// </summary>
	public string removed_byDefault
	{
		get
		{
			return TableUtils.removed_byColumn.DefaultValue;
		}
	}


#endregion
}

}
