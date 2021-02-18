// This class is "generated" and will be overwritten.
// Your customizations should be made in DepartmentRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="DepartmentRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="DepartmentTable"></see> class.
/// </remarks>
/// <seealso cref="DepartmentTable"></seealso>
/// <seealso cref="DepartmentRecord"></seealso>
public class BaseDepartmentRecord : PrimaryKeyRecord
{

	public readonly static DepartmentTable TableUtils = DepartmentTable.Instance;

	// Constructors
 
	protected BaseDepartmentRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.DepartmentRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.DepartmentRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.DepartmentRecord_ReadRecord); 
	}

	protected BaseDepartmentRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void DepartmentRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                DepartmentRecord DepartmentRec = (DepartmentRecord)sender;
        if(DepartmentRec != null && !DepartmentRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void DepartmentRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                DepartmentRecord DepartmentRec = (DepartmentRecord)sender;
        Validate_Inserting();
        if(DepartmentRec != null && !DepartmentRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void DepartmentRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                DepartmentRecord DepartmentRec = (DepartmentRecord)sender;
        Validate_Updating();
        if(DepartmentRec != null && !DepartmentRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's department_.department_id field.
	/// </summary>
	public ColumnValue Getdepartment_idValue()
	{
		return this.GetValue(TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.department_id field.
	/// </summary>
	public Int32 Getdepartment_idFieldValue()
	{
		return this.GetValue(TableUtils.department_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.department_name field.
	/// </summary>
	public ColumnValue Getdepartment_nameValue()
	{
		return this.GetValue(TableUtils.department_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.department_name field.
	/// </summary>
	public string Getdepartment_nameFieldValue()
	{
		return this.GetValue(TableUtils.department_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.department_name field.
	/// </summary>
	public void Setdepartment_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.department_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.department_name field.
	/// </summary>
	public void Setdepartment_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.department_active field.
	/// </summary>
	public ColumnValue Getdepartment_activeValue()
	{
		return this.GetValue(TableUtils.department_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.department_active field.
	/// </summary>
	public bool Getdepartment_activeFieldValue()
	{
		return this.GetValue(TableUtils.department_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.department_active field.
	/// </summary>
	public void Setdepartment_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.department_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.department_active field.
	/// </summary>
	public void Setdepartment_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.department_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.department_active field.
	/// </summary>
	public void Setdepartment_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.customercontact_primary field.
	/// </summary>
	public ColumnValue Getcustomercontact_primaryValue()
	{
		return this.GetValue(TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.customercontact_primary field.
	/// </summary>
	public Int32 Getcustomercontact_primaryFieldValue()
	{
		return this.GetValue(TableUtils.customercontact_primaryColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(string val)
	{
		this.SetString(val, TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_primaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_primary field.
	/// </summary>
	public void Setcustomercontact_primaryFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_primaryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.customercontact_secondary field.
	/// </summary>
	public ColumnValue Getcustomercontact_secondaryValue()
	{
		return this.GetValue(TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.customercontact_secondary field.
	/// </summary>
	public Int32 Getcustomercontact_secondaryFieldValue()
	{
		return this.GetValue(TableUtils.customercontact_secondaryColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(string val)
	{
		this.SetString(val, TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_secondaryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_secondary field.
	/// </summary>
	public void Setcustomercontact_secondaryFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customercontact_secondaryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.customercontact_primary_phone field.
	/// </summary>
	public ColumnValue Getcustomercontact_primary_phoneValue()
	{
		return this.GetValue(TableUtils.customercontact_primary_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.customercontact_primary_phone field.
	/// </summary>
	public string Getcustomercontact_primary_phoneFieldValue()
	{
		return this.GetValue(TableUtils.customercontact_primary_phoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.customercontact_secondary_phone field.
	/// </summary>
	public ColumnValue Getcustomercontact_secondary_phoneValue()
	{
		return this.GetValue(TableUtils.customercontact_secondary_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's department_.customercontact_secondary_phone field.
	/// </summary>
	public string Getcustomercontact_secondary_phoneFieldValue()
	{
		return this.GetValue(TableUtils.customercontact_secondary_phoneColumn).ToString();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's department_.department_id field.
	/// </summary>
	public Int32 department_id
	{
		get
		{
			return this.GetValue(TableUtils.department_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.department_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool department_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.department_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.department_id field.
	/// </summary>
	public string department_idDefault
	{
		get
		{
			return TableUtils.department_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's department_.custno field.
	/// </summary>
	public Int32 custno
	{
		get
		{
			return this.GetValue(TableUtils.custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's department_.department_name field.
	/// </summary>
	public string department_name
	{
		get
		{
			return this.GetValue(TableUtils.department_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.department_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool department_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.department_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.department_name field.
	/// </summary>
	public string department_nameDefault
	{
		get
		{
			return TableUtils.department_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's department_.department_active field.
	/// </summary>
	public bool department_active
	{
		get
		{
			return this.GetValue(TableUtils.department_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.department_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool department_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.department_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.department_active field.
	/// </summary>
	public string department_activeDefault
	{
		get
		{
			return TableUtils.department_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's department_.customercontact_primary field.
	/// </summary>
	public Int32 customercontact_primary
	{
		get
		{
			return this.GetValue(TableUtils.customercontact_primaryColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customercontact_primaryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customercontact_primarySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customercontact_primaryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_primary field.
	/// </summary>
	public string customercontact_primaryDefault
	{
		get
		{
			return TableUtils.customercontact_primaryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's department_.customercontact_secondary field.
	/// </summary>
	public Int32 customercontact_secondary
	{
		get
		{
			return this.GetValue(TableUtils.customercontact_secondaryColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customercontact_secondaryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customercontact_secondarySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customercontact_secondaryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_secondary field.
	/// </summary>
	public string customercontact_secondaryDefault
	{
		get
		{
			return TableUtils.customercontact_secondaryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's department_.customercontact_primary_phone field.
	/// </summary>
	public string customercontact_primary_phone
	{
		get
		{
			return this.GetValue(TableUtils.customercontact_primary_phoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customercontact_primary_phoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customercontact_primary_phoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customercontact_primary_phoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_primary_phone field.
	/// </summary>
	public string customercontact_primary_phoneDefault
	{
		get
		{
			return TableUtils.customercontact_primary_phoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's department_.customercontact_secondary_phone field.
	/// </summary>
	public string customercontact_secondary_phone
	{
		get
		{
			return this.GetValue(TableUtils.customercontact_secondary_phoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customercontact_secondary_phoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customercontact_secondary_phoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customercontact_secondary_phoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's department_.customercontact_secondary_phone field.
	/// </summary>
	public string customercontact_secondary_phoneDefault
	{
		get
		{
			return TableUtils.customercontact_secondary_phoneColumn.DefaultValue;
		}
	}


#endregion
}

}
