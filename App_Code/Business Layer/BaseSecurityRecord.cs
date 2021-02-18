// This class is "generated" and will be overwritten.
// Your customizations should be made in SecurityRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="SecurityRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="SecurityTable"></see> class.
/// </remarks>
/// <seealso cref="SecurityTable"></seealso>
/// <seealso cref="SecurityRecord"></seealso>
public class BaseSecurityRecord : PrimaryKeyRecord
{

	public readonly static SecurityTable TableUtils = SecurityTable.Instance;

	// Constructors
 
	protected BaseSecurityRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.SecurityRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.SecurityRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.SecurityRecord_ReadRecord); 
	}

	protected BaseSecurityRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void SecurityRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                SecurityRecord SecurityRec = (SecurityRecord)sender;
        if(SecurityRec != null && !SecurityRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void SecurityRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                SecurityRecord SecurityRec = (SecurityRecord)sender;
        Validate_Inserting();
        if(SecurityRec != null && !SecurityRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void SecurityRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                SecurityRecord SecurityRec = (SecurityRecord)sender;
        Validate_Updating();
        if(SecurityRec != null && !SecurityRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's security_.security_id field.
	/// </summary>
	public ColumnValue Getsecurity_idValue()
	{
		return this.GetValue(TableUtils.security_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's security_.security_id field.
	/// </summary>
	public Int32 Getsecurity_idFieldValue()
	{
		return this.GetValue(TableUtils.security_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's security_.corporate_id field.
	/// </summary>
	public ColumnValue Getcorporate_idValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's security_.corporate_id field.
	/// </summary>
	public Int32 Getcorporate_idFieldValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's security_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's security_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's security_.deptid field.
	/// </summary>
	public ColumnValue GetdeptidValue()
	{
		return this.GetValue(TableUtils.deptidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's security_.deptid field.
	/// </summary>
	public Int32 GetdeptidFieldValue()
	{
		return this.GetValue(TableUtils.deptidColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.deptid field.
	/// </summary>
	public void SetdeptidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.deptidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.deptid field.
	/// </summary>
	public void SetdeptidFieldValue(string val)
	{
		this.SetString(val, TableUtils.deptidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.deptid field.
	/// </summary>
	public void SetdeptidFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.deptidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.deptid field.
	/// </summary>
	public void SetdeptidFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.deptidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.deptid field.
	/// </summary>
	public void SetdeptidFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.deptidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's security_.contact_id field.
	/// </summary>
	public ColumnValue Getcontact_idValue()
	{
		return this.GetValue(TableUtils.contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's security_.contact_id field.
	/// </summary>
	public Int32 Getcontact_idFieldValue()
	{
		return this.GetValue(TableUtils.contact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.contact_id field.
	/// </summary>
	public void Setcontact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.contact_id field.
	/// </summary>
	public void Setcontact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.contact_id field.
	/// </summary>
	public void Setcontact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.contact_id field.
	/// </summary>
	public void Setcontact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.contact_id field.
	/// </summary>
	public void Setcontact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contact_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's security_.security_id field.
	/// </summary>
	public Int32 security_id
	{
		get
		{
			return this.GetValue(TableUtils.security_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.security_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool security_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.security_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.security_id field.
	/// </summary>
	public string security_idDefault
	{
		get
		{
			return TableUtils.security_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's security_.corporate_id field.
	/// </summary>
	public Int32 corporate_id
	{
		get
		{
			return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.corporate_id field.
	/// </summary>
	public string corporate_idDefault
	{
		get
		{
			return TableUtils.corporate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's security_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's security_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's security_.deptid field.
	/// </summary>
	public Int32 deptid
	{
		get
		{
			return this.GetValue(TableUtils.deptidColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.deptidColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool deptidSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.deptidColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.deptid field.
	/// </summary>
	public string deptidDefault
	{
		get
		{
			return TableUtils.deptidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's security_.contact_id field.
	/// </summary>
	public Int32 contact_id
	{
		get
		{
			return this.GetValue(TableUtils.contact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's security_.contact_id field.
	/// </summary>
	public string contact_idDefault
	{
		get
		{
			return TableUtils.contact_idColumn.DefaultValue;
		}
	}


#endregion
}

}
