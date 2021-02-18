// This class is "generated" and will be overwritten.
// Your customizations should be made in Contractor_skills_matrixRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Contractor_skills_matrixRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Contractor_skills_matrixTable"></see> class.
/// </remarks>
/// <seealso cref="Contractor_skills_matrixTable"></seealso>
/// <seealso cref="Contractor_skills_matrixRecord"></seealso>
public class BaseContractor_skills_matrixRecord : PrimaryKeyRecord
{

	public readonly static Contractor_skills_matrixTable TableUtils = Contractor_skills_matrixTable.Instance;

	// Constructors
 
	protected BaseContractor_skills_matrixRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Contractor_skills_matrixRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Contractor_skills_matrixRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Contractor_skills_matrixRecord_ReadRecord); 
	}

	protected BaseContractor_skills_matrixRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Contractor_skills_matrixRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Contractor_skills_matrixRecord Contractor_skills_matrixRec = (Contractor_skills_matrixRecord)sender;
        if(Contractor_skills_matrixRec != null && !Contractor_skills_matrixRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Contractor_skills_matrixRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Contractor_skills_matrixRecord Contractor_skills_matrixRec = (Contractor_skills_matrixRecord)sender;
        Validate_Inserting();
        if(Contractor_skills_matrixRec != null && !Contractor_skills_matrixRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Contractor_skills_matrixRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Contractor_skills_matrixRecord Contractor_skills_matrixRec = (Contractor_skills_matrixRecord)sender;
        Validate_Updating();
        if(Contractor_skills_matrixRec != null && !Contractor_skills_matrixRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_matrix_.contractor_skill_matrix_id field.
	/// </summary>
	public ColumnValue Getcontractor_skill_matrix_idValue()
	{
		return this.GetValue(TableUtils.contractor_skill_matrix_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_matrix_.contractor_skill_matrix_id field.
	/// </summary>
	public Int32 Getcontractor_skill_matrix_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_skill_matrix_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_matrix_.contractor_skill_id field.
	/// </summary>
	public ColumnValue Getcontractor_skill_idValue()
	{
		return this.GetValue(TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_matrix_.contractor_skill_id field.
	/// </summary>
	public Int32 Getcontractor_skill_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_skill_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_skill_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_matrix_.contractor_id field.
	/// </summary>
	public ColumnValue Getcontractor_idValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_skills_matrix_.contractor_id field.
	/// </summary>
	public Int32 Getcontractor_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_skills_matrix_.contractor_skill_matrix_id field.
	/// </summary>
	public Int32 contractor_skill_matrix_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_skill_matrix_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_skill_matrix_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_skill_matrix_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_skill_matrix_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_skill_matrix_id field.
	/// </summary>
	public string contractor_skill_matrix_idDefault
	{
		get
		{
			return TableUtils.contractor_skill_matrix_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_skills_matrix_.contractor_skill_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_skill_id field.
	/// </summary>
	public string contractor_skill_idDefault
	{
		get
		{
			return TableUtils.contractor_skill_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_skills_matrix_.contractor_id field.
	/// </summary>
	public Int32 contractor_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_skills_matrix_.contractor_id field.
	/// </summary>
	public string contractor_idDefault
	{
		get
		{
			return TableUtils.contractor_idColumn.DefaultValue;
		}
	}


#endregion
}

}
