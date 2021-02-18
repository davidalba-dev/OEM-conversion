// This class is "generated" and will be overwritten.
// Your customizations should be made in Lead_sourceRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Lead_sourceRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Lead_sourceTable"></see> class.
/// </remarks>
/// <seealso cref="Lead_sourceTable"></seealso>
/// <seealso cref="Lead_sourceRecord"></seealso>
public class BaseLead_sourceRecord : PrimaryKeyRecord
{

	public readonly static Lead_sourceTable TableUtils = Lead_sourceTable.Instance;

	// Constructors
 
	protected BaseLead_sourceRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Lead_sourceRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Lead_sourceRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Lead_sourceRecord_ReadRecord); 
	}

	protected BaseLead_sourceRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Lead_sourceRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Lead_sourceRecord Lead_sourceRec = (Lead_sourceRecord)sender;
        if(Lead_sourceRec != null && !Lead_sourceRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Lead_sourceRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Lead_sourceRecord Lead_sourceRec = (Lead_sourceRecord)sender;
        Validate_Inserting();
        if(Lead_sourceRec != null && !Lead_sourceRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Lead_sourceRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Lead_sourceRecord Lead_sourceRec = (Lead_sourceRecord)sender;
        Validate_Updating();
        if(Lead_sourceRec != null && !Lead_sourceRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's lead_source_.lead_source_id field.
	/// </summary>
	public ColumnValue Getlead_source_idValue()
	{
		return this.GetValue(TableUtils.lead_source_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's lead_source_.lead_source_id field.
	/// </summary>
	public Int32 Getlead_source_idFieldValue()
	{
		return this.GetValue(TableUtils.lead_source_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's lead_source_.lead_source field.
	/// </summary>
	public ColumnValue Getlead_sourceValue()
	{
		return this.GetValue(TableUtils.lead_sourceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's lead_source_.lead_source field.
	/// </summary>
	public string Getlead_sourceFieldValue()
	{
		return this.GetValue(TableUtils.lead_sourceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's lead_source_.lead_source field.
	/// </summary>
	public void Setlead_sourceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.lead_sourceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's lead_source_.lead_source field.
	/// </summary>
	public void Setlead_sourceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.lead_sourceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's lead_source_.lead_source_active field.
	/// </summary>
	public ColumnValue Getlead_source_activeValue()
	{
		return this.GetValue(TableUtils.lead_source_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's lead_source_.lead_source_active field.
	/// </summary>
	public bool Getlead_source_activeFieldValue()
	{
		return this.GetValue(TableUtils.lead_source_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's lead_source_.lead_source_active field.
	/// </summary>
	public void Setlead_source_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.lead_source_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's lead_source_.lead_source_active field.
	/// </summary>
	public void Setlead_source_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.lead_source_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's lead_source_.lead_source_active field.
	/// </summary>
	public void Setlead_source_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.lead_source_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's lead_source_.lead_source_id field.
	/// </summary>
	public Int32 lead_source_id
	{
		get
		{
			return this.GetValue(TableUtils.lead_source_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.lead_source_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool lead_source_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.lead_source_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's lead_source_.lead_source_id field.
	/// </summary>
	public string lead_source_idDefault
	{
		get
		{
			return TableUtils.lead_source_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's lead_source_.lead_source field.
	/// </summary>
	public string lead_source
	{
		get
		{
			return this.GetValue(TableUtils.lead_sourceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.lead_sourceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool lead_sourceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.lead_sourceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's lead_source_.lead_source field.
	/// </summary>
	public string lead_sourceDefault
	{
		get
		{
			return TableUtils.lead_sourceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's lead_source_.lead_source_active field.
	/// </summary>
	public bool lead_source_active
	{
		get
		{
			return this.GetValue(TableUtils.lead_source_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.lead_source_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool lead_source_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.lead_source_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's lead_source_.lead_source_active field.
	/// </summary>
	public string lead_source_activeDefault
	{
		get
		{
			return TableUtils.lead_source_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
