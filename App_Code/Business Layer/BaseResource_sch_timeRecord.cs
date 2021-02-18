// This class is "generated" and will be overwritten.
// Your customizations should be made in Resource_sch_timeRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Resource_sch_timeRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Resource_sch_timeTable"></see> class.
/// </remarks>
/// <seealso cref="Resource_sch_timeTable"></seealso>
/// <seealso cref="Resource_sch_timeRecord"></seealso>
public class BaseResource_sch_timeRecord : PrimaryKeyRecord
{

	public readonly static Resource_sch_timeTable TableUtils = Resource_sch_timeTable.Instance;

	// Constructors
 
	protected BaseResource_sch_timeRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Resource_sch_timeRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Resource_sch_timeRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Resource_sch_timeRecord_ReadRecord); 
	}

	protected BaseResource_sch_timeRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Resource_sch_timeRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Resource_sch_timeRecord Resource_sch_timeRec = (Resource_sch_timeRecord)sender;
        if(Resource_sch_timeRec != null && !Resource_sch_timeRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Resource_sch_timeRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Resource_sch_timeRecord Resource_sch_timeRec = (Resource_sch_timeRecord)sender;
        Validate_Inserting();
        if(Resource_sch_timeRec != null && !Resource_sch_timeRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Resource_sch_timeRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Resource_sch_timeRecord Resource_sch_timeRec = (Resource_sch_timeRecord)sender;
        Validate_Updating();
        if(Resource_sch_timeRec != null && !Resource_sch_timeRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_id field.
	/// </summary>
	public ColumnValue Getresource_sch_time_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_time_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_id field.
	/// </summary>
	public Int32 Getresource_sch_time_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_time_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_technician_id field.
	/// </summary>
	public ColumnValue Getresource_sch_technician_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_technician_id field.
	/// </summary>
	public Int32 Getresource_sch_technician_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_technician_id field.
	/// </summary>
	public void Setresource_sch_technician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_technician_id field.
	/// </summary>
	public void Setresource_sch_technician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_technician_id field.
	/// </summary>
	public void Setresource_sch_technician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_technician_id field.
	/// </summary>
	public void Setresource_sch_technician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_technician_id field.
	/// </summary>
	public void Setresource_sch_technician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_hours field.
	/// </summary>
	public ColumnValue Getresource_sch_time_hoursValue()
	{
		return this.GetValue(TableUtils.resource_sch_time_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_hours field.
	/// </summary>
	public Int32 Getresource_sch_time_hoursFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_time_hoursColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_hours field.
	/// </summary>
	public void Setresource_sch_time_hoursFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_time_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_hours field.
	/// </summary>
	public void Setresource_sch_time_hoursFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_time_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_hours field.
	/// </summary>
	public void Setresource_sch_time_hoursFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_time_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_hours field.
	/// </summary>
	public void Setresource_sch_time_hoursFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_time_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_hours field.
	/// </summary>
	public void Setresource_sch_time_hoursFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_time_hoursColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_ticket_id field.
	/// </summary>
	public ColumnValue Getresource_sch_ticket_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_ticket_id field.
	/// </summary>
	public Int32 Getresource_sch_ticket_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_date field.
	/// </summary>
	public ColumnValue Getresource_sch_time_dateValue()
	{
		return this.GetValue(TableUtils.resource_sch_time_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_date field.
	/// </summary>
	public DateTime Getresource_sch_time_dateFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_time_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_date field.
	/// </summary>
	public void Setresource_sch_time_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_time_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_date field.
	/// </summary>
	public void Setresource_sch_time_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_time_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_date field.
	/// </summary>
	public void Setresource_sch_time_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_time_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.time_interval_id field.
	/// </summary>
	public ColumnValue Gettime_interval_idValue()
	{
		return this.GetValue(TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.time_interval_id field.
	/// </summary>
	public Int32 Gettime_interval_idFieldValue()
	{
		return this.GetValue(TableUtils.time_interval_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.time_interval_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.time_interval_id field.
	/// </summary>
	public void Settime_interval_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.time_interval_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_min field.
	/// </summary>
	public ColumnValue Getresource_sch_time_minValue()
	{
		return this.GetValue(TableUtils.resource_sch_time_minColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_min field.
	/// </summary>
	public Int32 Getresource_sch_time_minFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_time_minColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.timeentryweek field.
	/// </summary>
	public ColumnValue GettimeentryweekValue()
	{
		return this.GetValue(TableUtils.timeentryweekColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.timeentryweek field.
	/// </summary>
	public Int32 GettimeentryweekFieldValue()
	{
		return this.GetValue(TableUtils.timeentryweekColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.timeentryyear field.
	/// </summary>
	public ColumnValue GettimeentryyearValue()
	{
		return this.GetValue(TableUtils.timeentryyearColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.timeentryyear field.
	/// </summary>
	public Int32 GettimeentryyearFieldValue()
	{
		return this.GetValue(TableUtils.timeentryyearColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.timehours field.
	/// </summary>
	public ColumnValue GettimehoursValue()
	{
		return this.GetValue(TableUtils.timehoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_time_.timehours field.
	/// </summary>
	public Decimal GettimehoursFieldValue()
	{
		return this.GetValue(TableUtils.timehoursColumn).ToDecimal();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_id field.
	/// </summary>
	public Int32 resource_sch_time_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_time_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_time_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_time_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_time_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_id field.
	/// </summary>
	public string resource_sch_time_idDefault
	{
		get
		{
			return TableUtils.resource_sch_time_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.resource_sch_technician_id field.
	/// </summary>
	public Int32 resource_sch_technician_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_technician_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_technician_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_technician_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_technician_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_technician_id field.
	/// </summary>
	public string resource_sch_technician_idDefault
	{
		get
		{
			return TableUtils.resource_sch_technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_hours field.
	/// </summary>
	public Int32 resource_sch_time_hours
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_time_hoursColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_time_hoursColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_time_hoursSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_time_hoursColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_hours field.
	/// </summary>
	public string resource_sch_time_hoursDefault
	{
		get
		{
			return TableUtils.resource_sch_time_hoursColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.resource_sch_ticket_id field.
	/// </summary>
	public Int32 resource_sch_ticket_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_ticket_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_ticket_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_ticket_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_ticket_id field.
	/// </summary>
	public string resource_sch_ticket_idDefault
	{
		get
		{
			return TableUtils.resource_sch_ticket_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_date field.
	/// </summary>
	public DateTime resource_sch_time_date
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_time_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_time_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_time_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_time_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_date field.
	/// </summary>
	public string resource_sch_time_dateDefault
	{
		get
		{
			return TableUtils.resource_sch_time_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.time_interval_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.time_interval_id field.
	/// </summary>
	public string time_interval_idDefault
	{
		get
		{
			return TableUtils.time_interval_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.resource_sch_time_min field.
	/// </summary>
	public Int32 resource_sch_time_min
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_time_minColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_time_minColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_time_minSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_time_minColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.resource_sch_time_min field.
	/// </summary>
	public string resource_sch_time_minDefault
	{
		get
		{
			return TableUtils.resource_sch_time_minColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.timeentryweek field.
	/// </summary>
	public Int32 timeentryweek
	{
		get
		{
			return this.GetValue(TableUtils.timeentryweekColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.timeentryweekColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool timeentryweekSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.timeentryweekColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.timeentryweek field.
	/// </summary>
	public string timeentryweekDefault
	{
		get
		{
			return TableUtils.timeentryweekColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.timeentryyear field.
	/// </summary>
	public Int32 timeentryyear
	{
		get
		{
			return this.GetValue(TableUtils.timeentryyearColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.timeentryyearColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool timeentryyearSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.timeentryyearColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.timeentryyear field.
	/// </summary>
	public string timeentryyearDefault
	{
		get
		{
			return TableUtils.timeentryyearColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_time_.timehours field.
	/// </summary>
	public Decimal timehours
	{
		get
		{
			return this.GetValue(TableUtils.timehoursColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.timehoursColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool timehoursSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.timehoursColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_time_.timehours field.
	/// </summary>
	public string timehoursDefault
	{
		get
		{
			return TableUtils.timehoursColumn.DefaultValue;
		}
	}


#endregion
}

}
