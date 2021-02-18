// This class is "generated" and will be overwritten.
// Your customizations should be made in Time_intervalRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Time_intervalRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Time_intervalTable"></see> class.
/// </remarks>
/// <seealso cref="Time_intervalTable"></seealso>
/// <seealso cref="Time_intervalRecord"></seealso>
public class BaseTime_intervalRecord : PrimaryKeyRecord
{

	public readonly static Time_intervalTable TableUtils = Time_intervalTable.Instance;

	// Constructors
 
	protected BaseTime_intervalRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Time_intervalRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Time_intervalRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Time_intervalRecord_ReadRecord); 
	}

	protected BaseTime_intervalRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Time_intervalRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Time_intervalRecord Time_intervalRec = (Time_intervalRecord)sender;
        if(Time_intervalRec != null && !Time_intervalRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Time_intervalRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Time_intervalRecord Time_intervalRec = (Time_intervalRecord)sender;
        Validate_Inserting();
        if(Time_intervalRec != null && !Time_intervalRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Time_intervalRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Time_intervalRecord Time_intervalRec = (Time_intervalRecord)sender;
        Validate_Updating();
        if(Time_intervalRec != null && !Time_intervalRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's time_interval_.time_interval_id field.
	/// </summary>
	public ColumnValue Gettime_interval_idValue()
	{
		return this.GetValue(TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's time_interval_.time_interval_id field.
	/// </summary>
	public Int32 Gettime_interval_idFieldValue()
	{
		return this.GetValue(TableUtils.time_interval_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's time_interval_.time_interval field.
	/// </summary>
	public ColumnValue Gettime_intervalValue()
	{
		return this.GetValue(TableUtils.time_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's time_interval_.time_interval field.
	/// </summary>
	public string Gettime_intervalFieldValue()
	{
		return this.GetValue(TableUtils.time_intervalColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's time_interval_.time_interval field.
	/// </summary>
	public void Settime_intervalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.time_intervalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's time_interval_.time_interval field.
	/// </summary>
	public void Settime_intervalFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.time_intervalColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's time_interval_.time_interval_id field.
	/// </summary>
	public Int32 time_interval_id
	{
		get
		{
			return this.GetValue(TableUtils.time_interval_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.time_interval_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool time_interval_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.time_interval_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's time_interval_.time_interval_id field.
	/// </summary>
	public string time_interval_idDefault
	{
		get
		{
			return TableUtils.time_interval_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's time_interval_.time_interval field.
	/// </summary>
	public string time_interval
	{
		get
		{
			return this.GetValue(TableUtils.time_intervalColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.time_intervalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool time_intervalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.time_intervalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's time_interval_.time_interval field.
	/// </summary>
	public string time_intervalDefault
	{
		get
		{
			return TableUtils.time_intervalColumn.DefaultValue;
		}
	}


#endregion
}

}
