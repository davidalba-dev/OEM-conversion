// This class is "generated" and will be overwritten.
// Your customizations should be made in Contractor_skillsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Contractor_skillsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Contractor_skillsTable"></see> class.
/// </remarks>
/// <seealso cref="Contractor_skillsTable"></seealso>
/// <seealso cref="Contractor_skillsRecord"></seealso>
public class BaseContractor_skillsRecord : PrimaryKeyRecord
{

	public readonly static Contractor_skillsTable TableUtils = Contractor_skillsTable.Instance;

	// Constructors
 
	protected BaseContractor_skillsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Contractor_skillsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Contractor_skillsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Contractor_skillsRecord_ReadRecord); 
	}

	protected BaseContractor_skillsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Contractor_skillsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Contractor_skillsRecord Contractor_skillsRec = (Contractor_skillsRecord)sender;
        if(Contractor_skillsRec != null && !Contractor_skillsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Contractor_skillsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Contractor_skillsRecord Contractor_skillsRec = (Contractor_skillsRecord)sender;
        Validate_Inserting();
        if(Contractor_skillsRec != null && !Contractor_skillsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Contractor_skillsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Contractor_skillsRecord Contractor_skillsRec = (Contractor_skillsRecord)sender;
        Validate_Updating();
        if(Contractor_skillsRec != null && !Contractor_skillsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_.contractor_skill_id field.
	/// </summary>
	public ColumnValue Getcontractor_skill_idValue()
	{
		return this.GetValue(TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_.contractor_skill_id field.
	/// </summary>
	public Int32 Getcontractor_skill_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_skill_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_.skill_name field.
	/// </summary>
	public ColumnValue Getskill_nameValue()
	{
		return this.GetValue(TableUtils.skill_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_.skill_name field.
	/// </summary>
	public string Getskill_nameFieldValue()
	{
		return this.GetValue(TableUtils.skill_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_.skill_name field.
	/// </summary>
	public void Setskill_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.skill_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_.skill_name field.
	/// </summary>
	public void Setskill_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.skill_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_.skill_active field.
	/// </summary>
	public ColumnValue Getskill_activeValue()
	{
		return this.GetValue(TableUtils.skill_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_.skill_active field.
	/// </summary>
	public bool Getskill_activeFieldValue()
	{
		return this.GetValue(TableUtils.skill_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_.skill_active field.
	/// </summary>
	public void Setskill_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.skill_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_.skill_active field.
	/// </summary>
	public void Setskill_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.skill_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_.skill_active field.
	/// </summary>
	public void Setskill_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.skill_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_skills_.contractor_skill_id field.
	/// </summary>
	public Int32 contractor_skill_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_skill_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_skill_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_skill_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_skill_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_.contractor_skill_id field.
	/// </summary>
	public string contractor_skill_idDefault
	{
		get
		{
			return TableUtils.contractor_skill_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_skills_.skill_name field.
	/// </summary>
	public string skill_name
	{
		get
		{
			return this.GetValue(TableUtils.skill_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.skill_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool skill_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.skill_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_.skill_name field.
	/// </summary>
	public string skill_nameDefault
	{
		get
		{
			return TableUtils.skill_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_skills_.skill_active field.
	/// </summary>
	public bool skill_active
	{
		get
		{
			return this.GetValue(TableUtils.skill_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.skill_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool skill_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.skill_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_.skill_active field.
	/// </summary>
	public string skill_activeDefault
	{
		get
		{
			return TableUtils.skill_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
