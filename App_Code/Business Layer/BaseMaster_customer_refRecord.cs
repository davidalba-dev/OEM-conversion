// This class is "generated" and will be overwritten.
// Your customizations should be made in Master_customer_refRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Master_customer_refRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Master_customer_refTable"></see> class.
/// </remarks>
/// <seealso cref="Master_customer_refTable"></seealso>
/// <seealso cref="Master_customer_refRecord"></seealso>
public class BaseMaster_customer_refRecord : PrimaryKeyRecord
{

	public readonly static Master_customer_refTable TableUtils = Master_customer_refTable.Instance;

	// Constructors
 
	protected BaseMaster_customer_refRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Master_customer_refRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Master_customer_refRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Master_customer_refRecord_ReadRecord); 
	}

	protected BaseMaster_customer_refRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Master_customer_refRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Master_customer_refRecord Master_customer_refRec = (Master_customer_refRecord)sender;
        if(Master_customer_refRec != null && !Master_customer_refRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Master_customer_refRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Master_customer_refRecord Master_customer_refRec = (Master_customer_refRecord)sender;
        Validate_Inserting();
        if(Master_customer_refRec != null && !Master_customer_refRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Master_customer_refRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Master_customer_refRecord Master_customer_refRec = (Master_customer_refRecord)sender;
        Validate_Updating();
        if(Master_customer_refRec != null && !Master_customer_refRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.master_customer_id field.
	/// </summary>
	public ColumnValue Getmaster_customer_idValue()
	{
		return this.GetValue(TableUtils.master_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.master_customer_id field.
	/// </summary>
	public Int32 Getmaster_customer_idFieldValue()
	{
		return this.GetValue(TableUtils.master_customer_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.new_custno field.
	/// </summary>
	public ColumnValue Getnew_custnoValue()
	{
		return this.GetValue(TableUtils.new_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.new_custno field.
	/// </summary>
	public Int32 Getnew_custnoFieldValue()
	{
		return this.GetValue(TableUtils.new_custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.new_custno field.
	/// </summary>
	public void Setnew_custnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.new_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.new_custno field.
	/// </summary>
	public void Setnew_custnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.new_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.new_custno field.
	/// </summary>
	public void Setnew_custnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.new_custno field.
	/// </summary>
	public void Setnew_custnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.new_custno field.
	/// </summary>
	public void Setnew_custnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.legacy_custno field.
	/// </summary>
	public ColumnValue Getlegacy_custnoValue()
	{
		return this.GetValue(TableUtils.legacy_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.legacy_custno field.
	/// </summary>
	public Int32 Getlegacy_custnoFieldValue()
	{
		return this.GetValue(TableUtils.legacy_custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.legacy_custno field.
	/// </summary>
	public void Setlegacy_custnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.legacy_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.legacy_custno field.
	/// </summary>
	public void Setlegacy_custnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.legacy_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.legacy_custno field.
	/// </summary>
	public void Setlegacy_custnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.legacy_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.legacy_custno field.
	/// </summary>
	public void Setlegacy_custnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.legacy_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.legacy_custno field.
	/// </summary>
	public void Setlegacy_custnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.legacy_custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's master_customer_ref_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's master_customer_ref_.master_customer_id field.
	/// </summary>
	public Int32 master_customer_id
	{
		get
		{
			return this.GetValue(TableUtils.master_customer_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.master_customer_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool master_customer_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.master_customer_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.master_customer_id field.
	/// </summary>
	public string master_customer_idDefault
	{
		get
		{
			return TableUtils.master_customer_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's master_customer_ref_.new_custno field.
	/// </summary>
	public Int32 new_custno
	{
		get
		{
			return this.GetValue(TableUtils.new_custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.new_custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool new_custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.new_custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.new_custno field.
	/// </summary>
	public string new_custnoDefault
	{
		get
		{
			return TableUtils.new_custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's master_customer_ref_.legacy_custno field.
	/// </summary>
	public Int32 legacy_custno
	{
		get
		{
			return this.GetValue(TableUtils.legacy_custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.legacy_custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool legacy_custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.legacy_custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.legacy_custno field.
	/// </summary>
	public string legacy_custnoDefault
	{
		get
		{
			return TableUtils.legacy_custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's master_customer_ref_.created_by field.
	/// </summary>
	public Int32 created_by
	{
		get
		{
			return this.GetValue(TableUtils.created_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.created_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool created_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.created_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's master_customer_ref_.created_datetime field.
	/// </summary>
	public DateTime created_datetime
	{
		get
		{
			return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.created_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool created_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.created_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's master_customer_ref_.created_datetime field.
	/// </summary>
	public string created_datetimeDefault
	{
		get
		{
			return TableUtils.created_datetimeColumn.DefaultValue;
		}
	}


#endregion
}

}
