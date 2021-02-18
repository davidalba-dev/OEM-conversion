// This class is "generated" and will be overwritten.
// Your customizations should be made in Technician_roleRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Technician_roleRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Technician_roleTable"></see> class.
/// </remarks>
/// <seealso cref="Technician_roleTable"></seealso>
/// <seealso cref="Technician_roleRecord"></seealso>
public class BaseTechnician_roleRecord : PrimaryKeyRecord
{

	public readonly static Technician_roleTable TableUtils = Technician_roleTable.Instance;

	// Constructors
 
	protected BaseTechnician_roleRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Technician_roleRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Technician_roleRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Technician_roleRecord_ReadRecord); 
	}

	protected BaseTechnician_roleRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Technician_roleRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Technician_roleRecord Technician_roleRec = (Technician_roleRecord)sender;
        if(Technician_roleRec != null && !Technician_roleRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Technician_roleRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Technician_roleRecord Technician_roleRec = (Technician_roleRecord)sender;
        Validate_Inserting();
        if(Technician_roleRec != null && !Technician_roleRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Technician_roleRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Technician_roleRecord Technician_roleRec = (Technician_roleRecord)sender;
        Validate_Updating();
        if(Technician_roleRec != null && !Technician_roleRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's technician_role_.tech_role_id field.
	/// </summary>
	public ColumnValue Gettech_role_idValue()
	{
		return this.GetValue(TableUtils.tech_role_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_role_.tech_role_id field.
	/// </summary>
	public Decimal Gettech_role_idFieldValue()
	{
		return this.GetValue(TableUtils.tech_role_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_role_.role_name field.
	/// </summary>
	public ColumnValue Getrole_nameValue()
	{
		return this.GetValue(TableUtils.role_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_role_.role_name field.
	/// </summary>
	public string Getrole_nameFieldValue()
	{
		return this.GetValue(TableUtils.role_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_name field.
	/// </summary>
	public void Setrole_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.role_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_name field.
	/// </summary>
	public void Setrole_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.role_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_role_.role_rate field.
	/// </summary>
	public ColumnValue Getrole_rateValue()
	{
		return this.GetValue(TableUtils.role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_role_.role_rate field.
	/// </summary>
	public Decimal Getrole_rateFieldValue()
	{
		return this.GetValue(TableUtils.role_rateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_rate field.
	/// </summary>
	public void Setrole_rateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_rate field.
	/// </summary>
	public void Setrole_rateFieldValue(string val)
	{
		this.SetString(val, TableUtils.role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_rate field.
	/// </summary>
	public void Setrole_rateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_rate field.
	/// </summary>
	public void Setrole_rateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.role_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_rate field.
	/// </summary>
	public void Setrole_rateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.role_rateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_role_.role_active field.
	/// </summary>
	public ColumnValue Getrole_activeValue()
	{
		return this.GetValue(TableUtils.role_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's technician_role_.role_active field.
	/// </summary>
	public bool Getrole_activeFieldValue()
	{
		return this.GetValue(TableUtils.role_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_active field.
	/// </summary>
	public void Setrole_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.role_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_active field.
	/// </summary>
	public void Setrole_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.role_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_active field.
	/// </summary>
	public void Setrole_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.role_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's technician_role_.tech_role_id field.
	/// </summary>
	public Decimal tech_role_id
	{
		get
		{
			return this.GetValue(TableUtils.tech_role_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.tech_role_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool tech_role_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.tech_role_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.tech_role_id field.
	/// </summary>
	public string tech_role_idDefault
	{
		get
		{
			return TableUtils.tech_role_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's technician_role_.role_name field.
	/// </summary>
	public string role_name
	{
		get
		{
			return this.GetValue(TableUtils.role_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.role_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool role_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.role_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_name field.
	/// </summary>
	public string role_nameDefault
	{
		get
		{
			return TableUtils.role_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's technician_role_.role_rate field.
	/// </summary>
	public Decimal role_rate
	{
		get
		{
			return this.GetValue(TableUtils.role_rateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.role_rateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool role_rateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.role_rateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_rate field.
	/// </summary>
	public string role_rateDefault
	{
		get
		{
			return TableUtils.role_rateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's technician_role_.role_active field.
	/// </summary>
	public bool role_active
	{
		get
		{
			return this.GetValue(TableUtils.role_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.role_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool role_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.role_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's technician_role_.role_active field.
	/// </summary>
	public string role_activeDefault
	{
		get
		{
			return TableUtils.role_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
