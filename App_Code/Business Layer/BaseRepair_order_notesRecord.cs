// This class is "generated" and will be overwritten.
// Your customizations should be made in Repair_order_notesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Repair_order_notesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Repair_order_notesTable"></see> class.
/// </remarks>
/// <seealso cref="Repair_order_notesTable"></seealso>
/// <seealso cref="Repair_order_notesRecord"></seealso>
public class BaseRepair_order_notesRecord : PrimaryKeyRecord
{

	public readonly static Repair_order_notesTable TableUtils = Repair_order_notesTable.Instance;

	// Constructors
 
	protected BaseRepair_order_notesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Repair_order_notesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Repair_order_notesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Repair_order_notesRecord_ReadRecord); 
	}

	protected BaseRepair_order_notesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Repair_order_notesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Repair_order_notesRecord Repair_order_notesRec = (Repair_order_notesRecord)sender;
        if(Repair_order_notesRec != null && !Repair_order_notesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Repair_order_notesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Repair_order_notesRecord Repair_order_notesRec = (Repair_order_notesRecord)sender;
        Validate_Inserting();
        if(Repair_order_notesRec != null && !Repair_order_notesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Repair_order_notesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Repair_order_notesRecord Repair_order_notesRec = (Repair_order_notesRecord)sender;
        Validate_Updating();
        if(Repair_order_notesRec != null && !Repair_order_notesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.repair_order_note_id field.
	/// </summary>
	public ColumnValue Getrepair_order_note_idValue()
	{
		return this.GetValue(TableUtils.repair_order_note_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.repair_order_note_id field.
	/// </summary>
	public Int32 Getrepair_order_note_idFieldValue()
	{
		return this.GetValue(TableUtils.repair_order_note_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.note_date_time field.
	/// </summary>
	public ColumnValue Getnote_date_timeValue()
	{
		return this.GetValue(TableUtils.note_date_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.note_date_time field.
	/// </summary>
	public DateTime Getnote_date_timeFieldValue()
	{
		return this.GetValue(TableUtils.note_date_timeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.note_date_time field.
	/// </summary>
	public void Setnote_date_timeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.note_date_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.note_date_time field.
	/// </summary>
	public void Setnote_date_timeFieldValue(string val)
	{
		this.SetString(val, TableUtils.note_date_timeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.note_date_time field.
	/// </summary>
	public void Setnote_date_timeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.note_date_timeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.repair_order_note field.
	/// </summary>
	public ColumnValue Getrepair_order_noteValue()
	{
		return this.GetValue(TableUtils.repair_order_noteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.repair_order_note field.
	/// </summary>
	public string Getrepair_order_noteFieldValue()
	{
		return this.GetValue(TableUtils.repair_order_noteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.repair_order_note field.
	/// </summary>
	public void Setrepair_order_noteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_order_noteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.repair_order_note field.
	/// </summary>
	public void Setrepair_order_noteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_order_noteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.rono field.
	/// </summary>
	public ColumnValue GetronoValue()
	{
		return this.GetValue(TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_notes_.rono field.
	/// </summary>
	public Int32 GetronoFieldValue()
	{
		return this.GetValue(TableUtils.ronoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.rono field.
	/// </summary>
	public void SetronoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.rono field.
	/// </summary>
	public void SetronoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.rono field.
	/// </summary>
	public void SetronoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.rono field.
	/// </summary>
	public void SetronoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.rono field.
	/// </summary>
	public void SetronoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_notes_.repair_order_note_id field.
	/// </summary>
	public Int32 repair_order_note_id
	{
		get
		{
			return this.GetValue(TableUtils.repair_order_note_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_order_note_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_order_note_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_order_note_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.repair_order_note_id field.
	/// </summary>
	public string repair_order_note_idDefault
	{
		get
		{
			return TableUtils.repair_order_note_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_notes_.created_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_notes_.note_date_time field.
	/// </summary>
	public DateTime note_date_time
	{
		get
		{
			return this.GetValue(TableUtils.note_date_timeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.note_date_timeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool note_date_timeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.note_date_timeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.note_date_time field.
	/// </summary>
	public string note_date_timeDefault
	{
		get
		{
			return TableUtils.note_date_timeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_notes_.repair_order_note field.
	/// </summary>
	public string repair_order_note
	{
		get
		{
			return this.GetValue(TableUtils.repair_order_noteColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_order_noteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_order_noteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_order_noteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.repair_order_note field.
	/// </summary>
	public string repair_order_noteDefault
	{
		get
		{
			return TableUtils.repair_order_noteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_notes_.rono field.
	/// </summary>
	public Int32 rono
	{
		get
		{
			return this.GetValue(TableUtils.ronoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ronoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ronoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ronoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_notes_.rono field.
	/// </summary>
	public string ronoDefault
	{
		get
		{
			return TableUtils.ronoColumn.DefaultValue;
		}
	}


#endregion
}

}
