// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_contractor_skillsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_contractor_skillsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_contractor_skillsView"></see> class.
/// </remarks>
/// <seealso cref="Vw_contractor_skillsView"></seealso>
/// <seealso cref="Vw_contractor_skillsRecord"></seealso>
public class BaseVw_contractor_skillsRecord : PrimaryKeyRecord
{

	public readonly static Vw_contractor_skillsView TableUtils = Vw_contractor_skillsView.Instance;

	// Constructors
 
	protected BaseVw_contractor_skillsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_contractor_skillsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Vw_contractor_skillsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_contractor_skillsRecord_ReadRecord); 
	}

	protected BaseVw_contractor_skillsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_contractor_skillsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_contractor_skillsRecord Vw_contractor_skillsRec = (Vw_contractor_skillsRecord)sender;
        if(Vw_contractor_skillsRec != null && !Vw_contractor_skillsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_contractor_skillsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_contractor_skillsRecord Vw_contractor_skillsRec = (Vw_contractor_skillsRecord)sender;
        Validate_Inserting();
        if(Vw_contractor_skillsRec != null && !Vw_contractor_skillsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Vw_contractor_skillsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Vw_contractor_skillsRecord Vw_contractor_skillsRec = (Vw_contractor_skillsRecord)sender;
        Validate_Updating();
        if(Vw_contractor_skillsRec != null && !Vw_contractor_skillsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.skill_name field.
	/// </summary>
	public ColumnValue Getskill_nameValue()
	{
		return this.GetValue(TableUtils.skill_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.skill_name field.
	/// </summary>
	public string Getskill_nameFieldValue()
	{
		return this.GetValue(TableUtils.skill_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.skill_name field.
	/// </summary>
	public void Setskill_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.skill_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.skill_name field.
	/// </summary>
	public void Setskill_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.skill_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.skill_active field.
	/// </summary>
	public ColumnValue Getskill_activeValue()
	{
		return this.GetValue(TableUtils.skill_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.skill_active field.
	/// </summary>
	public bool Getskill_activeFieldValue()
	{
		return this.GetValue(TableUtils.skill_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.skill_active field.
	/// </summary>
	public void Setskill_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.skill_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.skill_active field.
	/// </summary>
	public void Setskill_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.skill_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.skill_active field.
	/// </summary>
	public void Setskill_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.skill_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.contractor_name field.
	/// </summary>
	public ColumnValue Getcontractor_nameValue()
	{
		return this.GetValue(TableUtils.contractor_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.contractor_name field.
	/// </summary>
	public string Getcontractor_nameFieldValue()
	{
		return this.GetValue(TableUtils.contractor_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_name field.
	/// </summary>
	public void Setcontractor_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_name field.
	/// </summary>
	public void Setcontractor_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.contractor_id field.
	/// </summary>
	public ColumnValue Getcontractor_idValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.contractor_id field.
	/// </summary>
	public Int32 Getcontractor_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_id field.
	/// </summary>
	public void Setcontractor_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.contractor_skill_id field.
	/// </summary>
	public ColumnValue Getcontractor_skill_idValue()
	{
		return this.GetValue(TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.contractor_skill_id field.
	/// </summary>
	public Int32 Getcontractor_skill_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_skill_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_skill_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_id field.
	/// </summary>
	public void Setcontractor_skill_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_skill_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.Expr1 field.
	/// </summary>
	public ColumnValue GetExpr1Value()
	{
		return this.GetValue(TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.Expr1 field.
	/// </summary>
	public Int32 GetExpr1FieldValue()
	{
		return this.GetValue(TableUtils.Expr1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(string val)
	{
		this.SetString(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.contractor_skill_matrix_id field.
	/// </summary>
	public ColumnValue Getcontractor_skill_matrix_idValue()
	{
		return this.GetValue(TableUtils.contractor_skill_matrix_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_contractor_skills_.contractor_skill_matrix_id field.
	/// </summary>
	public Int32 Getcontractor_skill_matrix_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_skill_matrix_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_matrix_id field.
	/// </summary>
	public void Setcontractor_skill_matrix_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_skill_matrix_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_matrix_id field.
	/// </summary>
	public void Setcontractor_skill_matrix_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_skill_matrix_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_matrix_id field.
	/// </summary>
	public void Setcontractor_skill_matrix_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_skill_matrix_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_matrix_id field.
	/// </summary>
	public void Setcontractor_skill_matrix_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_skill_matrix_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_matrix_id field.
	/// </summary>
	public void Setcontractor_skill_matrix_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_skill_matrix_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contractor_skills_.skill_name field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.skill_name field.
	/// </summary>
	public string skill_nameDefault
	{
		get
		{
			return TableUtils.skill_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contractor_skills_.skill_active field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.skill_active field.
	/// </summary>
	public string skill_activeDefault
	{
		get
		{
			return TableUtils.skill_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contractor_skills_.contractor_name field.
	/// </summary>
	public string contractor_name
	{
		get
		{
			return this.GetValue(TableUtils.contractor_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_name field.
	/// </summary>
	public string contractor_nameDefault
	{
		get
		{
			return TableUtils.contractor_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contractor_skills_.contractor_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_id field.
	/// </summary>
	public string contractor_idDefault
	{
		get
		{
			return TableUtils.contractor_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contractor_skills_.contractor_skill_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_id field.
	/// </summary>
	public string contractor_skill_idDefault
	{
		get
		{
			return TableUtils.contractor_skill_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contractor_skills_.Expr1 field.
	/// </summary>
	public Int32 Expr1
	{
		get
		{
			return this.GetValue(TableUtils.Expr1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Expr1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Expr1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Expr1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.Expr1 field.
	/// </summary>
	public string Expr1Default
	{
		get
		{
			return TableUtils.Expr1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_contractor_skills_.contractor_skill_matrix_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_contractor_skills_.contractor_skill_matrix_id field.
	/// </summary>
	public string contractor_skill_matrix_idDefault
	{
		get
		{
			return TableUtils.contractor_skill_matrix_idColumn.DefaultValue;
		}
	}


#endregion
}

}
