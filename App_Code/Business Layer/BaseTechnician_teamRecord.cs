// This class is "generated" and will be overwritten.
// Your customizations should be made in Technician_teamRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Technician_teamRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Technician_teamTable"></see> class.
/// </remarks>
/// <seealso cref="Technician_teamTable"></seealso>
/// <seealso cref="Technician_teamRecord"></seealso>
public class BaseTechnician_teamRecord : PrimaryKeyRecord
{

	public readonly static Technician_teamTable TableUtils = Technician_teamTable.Instance;

	// Constructors
 
	protected BaseTechnician_teamRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Technician_teamRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Technician_teamRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Technician_teamRecord_ReadRecord); 
	}

	protected BaseTechnician_teamRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Technician_teamRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Technician_teamRecord Technician_teamRec = (Technician_teamRecord)sender;
        if(Technician_teamRec != null && !Technician_teamRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Technician_teamRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Technician_teamRecord Technician_teamRec = (Technician_teamRecord)sender;
        Validate_Inserting();
        if(Technician_teamRec != null && !Technician_teamRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Technician_teamRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Technician_teamRecord Technician_teamRec = (Technician_teamRecord)sender;
        Validate_Updating();
        if(Technician_teamRec != null && !Technician_teamRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's technician_team_.techncian_team_id field.
	/// </summary>
	public ColumnValue Gettechncian_team_idValue()
	{
		return this.GetValue(TableUtils.techncian_team_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_team_.techncian_team_id field.
	/// </summary>
	public Int32 Gettechncian_team_idFieldValue()
	{
		return this.GetValue(TableUtils.techncian_team_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_team_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_team_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_team_.oem_team_id field.
	/// </summary>
	public ColumnValue Getoem_team_idValue()
	{
		return this.GetValue(TableUtils.oem_team_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_team_.oem_team_id field.
	/// </summary>
	public Int32 Getoem_team_idFieldValue()
	{
		return this.GetValue(TableUtils.oem_team_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.oem_team_id field.
	/// </summary>
	public void Setoem_team_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.oem_team_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.oem_team_id field.
	/// </summary>
	public void Setoem_team_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.oem_team_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.oem_team_id field.
	/// </summary>
	public void Setoem_team_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_team_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.oem_team_id field.
	/// </summary>
	public void Setoem_team_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_team_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.oem_team_id field.
	/// </summary>
	public void Setoem_team_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_team_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's technician_team_.techncian_team_id field.
	/// </summary>
	public Int32 techncian_team_id
	{
		get
		{
			return this.GetValue(TableUtils.techncian_team_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.techncian_team_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool techncian_team_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.techncian_team_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.techncian_team_id field.
	/// </summary>
	public string techncian_team_idDefault
	{
		get
		{
			return TableUtils.techncian_team_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's technician_team_.technician_id field.
	/// </summary>
	public Int32 technician_id
	{
		get
		{
			return this.GetValue(TableUtils.technician_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.technician_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technician_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technician_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's technician_team_.oem_team_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's technician_team_.oem_team_id field.
	/// </summary>
	public string oem_team_idDefault
	{
		get
		{
			return TableUtils.oem_team_idColumn.DefaultValue;
		}
	}


#endregion
}

}
