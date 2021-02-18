// This class is "generated" and will be overwritten.
// Your customizations should be made in CalendarRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="CalendarRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="CalendarTable"></see> class.
/// </remarks>
/// <seealso cref="CalendarTable"></seealso>
/// <seealso cref="CalendarRecord"></seealso>
public class BaseCalendarRecord : PrimaryKeyRecord
{

	public readonly static CalendarTable TableUtils = CalendarTable.Instance;

	// Constructors
 
	protected BaseCalendarRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.CalendarRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.CalendarRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.CalendarRecord_ReadRecord); 
	}

	protected BaseCalendarRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void CalendarRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                CalendarRecord CalendarRec = (CalendarRecord)sender;
        if(CalendarRec != null && !CalendarRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void CalendarRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                CalendarRecord CalendarRec = (CalendarRecord)sender;
        Validate_Inserting();
        if(CalendarRec != null && !CalendarRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void CalendarRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                CalendarRecord CalendarRec = (CalendarRecord)sender;
        Validate_Updating();
        if(CalendarRec != null && !CalendarRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's calendar_.calendar_id field.
	/// </summary>
	public ColumnValue Getcalendar_idValue()
	{
		return this.GetValue(TableUtils.calendar_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.calendar_id field.
	/// </summary>
	public Int32 Getcalendar_idFieldValue()
	{
		return this.GetValue(TableUtils.calendar_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.calendar_date field.
	/// </summary>
	public ColumnValue Getcalendar_dateValue()
	{
		return this.GetValue(TableUtils.calendar_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.calendar_date field.
	/// </summary>
	public DateTime Getcalendar_dateFieldValue()
	{
		return this.GetValue(TableUtils.calendar_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.calendar_date field.
	/// </summary>
	public void Setcalendar_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.calendar_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.calendar_date field.
	/// </summary>
	public void Setcalendar_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.calendar_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.calendar_date field.
	/// </summary>
	public void Setcalendar_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.calendar_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.date_week field.
	/// </summary>
	public ColumnValue Getdate_weekValue()
	{
		return this.GetValue(TableUtils.date_weekColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.date_week field.
	/// </summary>
	public Int32 Getdate_weekFieldValue()
	{
		return this.GetValue(TableUtils.date_weekColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.date_year field.
	/// </summary>
	public ColumnValue Getdate_yearValue()
	{
		return this.GetValue(TableUtils.date_yearColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.date_year field.
	/// </summary>
	public Int32 Getdate_yearFieldValue()
	{
		return this.GetValue(TableUtils.date_yearColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.week_next field.
	/// </summary>
	public ColumnValue Getweek_nextValue()
	{
		return this.GetValue(TableUtils.week_nextColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.week_next field.
	/// </summary>
	public Int32 Getweek_nextFieldValue()
	{
		return this.GetValue(TableUtils.week_nextColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.week_previous field.
	/// </summary>
	public ColumnValue Getweek_previousValue()
	{
		return this.GetValue(TableUtils.week_previousColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.week_previous field.
	/// </summary>
	public Int32 Getweek_previousFieldValue()
	{
		return this.GetValue(TableUtils.week_previousColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.year_next field.
	/// </summary>
	public ColumnValue Getyear_nextValue()
	{
		return this.GetValue(TableUtils.year_nextColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.year_next field.
	/// </summary>
	public string Getyear_nextFieldValue()
	{
		return this.GetValue(TableUtils.year_nextColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.year_next field.
	/// </summary>
	public void Setyear_nextFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.year_nextColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.year_next field.
	/// </summary>
	public void Setyear_nextFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.year_nextColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.year_previous field.
	/// </summary>
	public ColumnValue Getyear_previousValue()
	{
		return this.GetValue(TableUtils.year_previousColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's calendar_.year_previous field.
	/// </summary>
	public string Getyear_previousFieldValue()
	{
		return this.GetValue(TableUtils.year_previousColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.year_previous field.
	/// </summary>
	public void Setyear_previousFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.year_previousColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.year_previous field.
	/// </summary>
	public void Setyear_previousFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.year_previousColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's calendar_.calendar_id field.
	/// </summary>
	public Int32 calendar_id
	{
		get
		{
			return this.GetValue(TableUtils.calendar_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.calendar_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool calendar_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.calendar_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.calendar_id field.
	/// </summary>
	public string calendar_idDefault
	{
		get
		{
			return TableUtils.calendar_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's calendar_.calendar_date field.
	/// </summary>
	public DateTime calendar_date
	{
		get
		{
			return this.GetValue(TableUtils.calendar_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.calendar_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool calendar_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.calendar_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.calendar_date field.
	/// </summary>
	public string calendar_dateDefault
	{
		get
		{
			return TableUtils.calendar_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's calendar_.date_week field.
	/// </summary>
	public Int32 date_week
	{
		get
		{
			return this.GetValue(TableUtils.date_weekColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_weekColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_weekSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_weekColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.date_week field.
	/// </summary>
	public string date_weekDefault
	{
		get
		{
			return TableUtils.date_weekColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's calendar_.date_year field.
	/// </summary>
	public Int32 date_year
	{
		get
		{
			return this.GetValue(TableUtils.date_yearColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_yearColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_yearSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_yearColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.date_year field.
	/// </summary>
	public string date_yearDefault
	{
		get
		{
			return TableUtils.date_yearColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's calendar_.week_next field.
	/// </summary>
	public Int32 week_next
	{
		get
		{
			return this.GetValue(TableUtils.week_nextColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.week_nextColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool week_nextSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.week_nextColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.week_next field.
	/// </summary>
	public string week_nextDefault
	{
		get
		{
			return TableUtils.week_nextColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's calendar_.week_previous field.
	/// </summary>
	public Int32 week_previous
	{
		get
		{
			return this.GetValue(TableUtils.week_previousColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.week_previousColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool week_previousSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.week_previousColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.week_previous field.
	/// </summary>
	public string week_previousDefault
	{
		get
		{
			return TableUtils.week_previousColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's calendar_.year_next field.
	/// </summary>
	public string year_next
	{
		get
		{
			return this.GetValue(TableUtils.year_nextColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.year_nextColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool year_nextSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.year_nextColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.year_next field.
	/// </summary>
	public string year_nextDefault
	{
		get
		{
			return TableUtils.year_nextColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's calendar_.year_previous field.
	/// </summary>
	public string year_previous
	{
		get
		{
			return this.GetValue(TableUtils.year_previousColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.year_previousColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool year_previousSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.year_previousColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's calendar_.year_previous field.
	/// </summary>
	public string year_previousDefault
	{
		get
		{
			return TableUtils.year_previousColumn.DefaultValue;
		}
	}


#endregion
}

}
