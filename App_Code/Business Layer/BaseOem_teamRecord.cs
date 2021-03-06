﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in Oem_teamRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Oem_teamRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Oem_teamTable"></see> class.
/// </remarks>
/// <seealso cref="Oem_teamTable"></seealso>
/// <seealso cref="Oem_teamRecord"></seealso>
public class BaseOem_teamRecord : PrimaryKeyRecord
{

	public readonly static Oem_teamTable TableUtils = Oem_teamTable.Instance;

	// Constructors
 
	protected BaseOem_teamRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Oem_teamRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Oem_teamRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Oem_teamRecord_ReadRecord); 
	}

	protected BaseOem_teamRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Oem_teamRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Oem_teamRecord Oem_teamRec = (Oem_teamRecord)sender;
        if(Oem_teamRec != null && !Oem_teamRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Oem_teamRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Oem_teamRecord Oem_teamRec = (Oem_teamRecord)sender;
        Validate_Inserting();
        if(Oem_teamRec != null && !Oem_teamRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Oem_teamRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Oem_teamRecord Oem_teamRec = (Oem_teamRecord)sender;
        Validate_Updating();
        if(Oem_teamRec != null && !Oem_teamRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's oem_team_.oem_team_id field.
	/// </summary>
	public ColumnValue Getoem_team_idValue()
	{
		return this.GetValue(TableUtils.oem_team_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's oem_team_.oem_team_id field.
	/// </summary>
	public Int32 Getoem_team_idFieldValue()
	{
		return this.GetValue(TableUtils.oem_team_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's oem_team_.oem_team_name field.
	/// </summary>
	public ColumnValue Getoem_team_nameValue()
	{
		return this.GetValue(TableUtils.oem_team_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's oem_team_.oem_team_name field.
	/// </summary>
	public string Getoem_team_nameFieldValue()
	{
		return this.GetValue(TableUtils.oem_team_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's oem_team_.oem_team_name field.
	/// </summary>
	public void Setoem_team_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.oem_team_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's oem_team_.oem_team_name field.
	/// </summary>
	public void Setoem_team_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_team_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's oem_team_.oem_team_active field.
	/// </summary>
	public ColumnValue Getoem_team_activeValue()
	{
		return this.GetValue(TableUtils.oem_team_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's oem_team_.oem_team_active field.
	/// </summary>
	public bool Getoem_team_activeFieldValue()
	{
		return this.GetValue(TableUtils.oem_team_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's oem_team_.oem_team_active field.
	/// </summary>
	public void Setoem_team_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.oem_team_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's oem_team_.oem_team_active field.
	/// </summary>
	public void Setoem_team_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.oem_team_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's oem_team_.oem_team_active field.
	/// </summary>
	public void Setoem_team_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_team_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's oem_team_.oem_team_id field.
	/// </summary>
	public Int32 oem_team_id
	{
		get
		{
			return this.GetValue(TableUtils.oem_team_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.oem_team_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool oem_team_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.oem_team_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's oem_team_.oem_team_id field.
	/// </summary>
	public string oem_team_idDefault
	{
		get
		{
			return TableUtils.oem_team_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's oem_team_.oem_team_name field.
	/// </summary>
	public string oem_team_name
	{
		get
		{
			return this.GetValue(TableUtils.oem_team_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.oem_team_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool oem_team_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.oem_team_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's oem_team_.oem_team_name field.
	/// </summary>
	public string oem_team_nameDefault
	{
		get
		{
			return TableUtils.oem_team_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's oem_team_.oem_team_active field.
	/// </summary>
	public bool oem_team_active
	{
		get
		{
			return this.GetValue(TableUtils.oem_team_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.oem_team_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool oem_team_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.oem_team_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's oem_team_.oem_team_active field.
	/// </summary>
	public string oem_team_activeDefault
	{
		get
		{
			return TableUtils.oem_team_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
