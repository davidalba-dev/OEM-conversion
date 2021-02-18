// This class is "generated" and will be overwritten.
// Your customizations should be made in WarrantyPlansRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="WarrantyPlansRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="WarrantyPlansTable"></see> class.
/// </remarks>
/// <seealso cref="WarrantyPlansTable"></seealso>
/// <seealso cref="WarrantyPlansRecord"></seealso>
public class BaseWarrantyPlansRecord : PrimaryKeyRecord
{

	public readonly static WarrantyPlansTable TableUtils = WarrantyPlansTable.Instance;

	// Constructors
 
	protected BaseWarrantyPlansRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.WarrantyPlansRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.WarrantyPlansRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.WarrantyPlansRecord_ReadRecord); 
	}

	protected BaseWarrantyPlansRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void WarrantyPlansRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                WarrantyPlansRecord WarrantyPlansRec = (WarrantyPlansRecord)sender;
        if(WarrantyPlansRec != null && !WarrantyPlansRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void WarrantyPlansRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                WarrantyPlansRecord WarrantyPlansRec = (WarrantyPlansRecord)sender;
        Validate_Inserting();
        if(WarrantyPlansRec != null && !WarrantyPlansRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void WarrantyPlansRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                WarrantyPlansRecord WarrantyPlansRec = (WarrantyPlansRecord)sender;
        Validate_Updating();
        if(WarrantyPlansRec != null && !WarrantyPlansRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.LastExtraction field.
	/// </summary>
	public ColumnValue GetLastExtractionValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.LastExtraction field.
	/// </summary>
	public bool GetLastExtractionFieldValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(string val)
	{
		this.SetString(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastExtractionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.LockKey field.
	/// </summary>
	public ColumnValue GetLockKeyValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.LockKey field.
	/// </summary>
	public Byte GetLockKeyFieldValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.PlanBillingNo field.
	/// </summary>
	public ColumnValue GetPlanBillingNoValue()
	{
		return this.GetValue(TableUtils.PlanBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.PlanBillingNo field.
	/// </summary>
	public Int32 GetPlanBillingNoFieldValue()
	{
		return this.GetValue(TableUtils.PlanBillingNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanBillingNo field.
	/// </summary>
	public void SetPlanBillingNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PlanBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanBillingNo field.
	/// </summary>
	public void SetPlanBillingNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.PlanBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanBillingNo field.
	/// </summary>
	public void SetPlanBillingNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlanBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanBillingNo field.
	/// </summary>
	public void SetPlanBillingNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlanBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanBillingNo field.
	/// </summary>
	public void SetPlanBillingNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlanBillingNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.PlanDesc field.
	/// </summary>
	public ColumnValue GetPlanDescValue()
	{
		return this.GetValue(TableUtils.PlanDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.PlanDesc field.
	/// </summary>
	public string GetPlanDescFieldValue()
	{
		return this.GetValue(TableUtils.PlanDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanDesc field.
	/// </summary>
	public void SetPlanDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PlanDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanDesc field.
	/// </summary>
	public void SetPlanDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlanDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.PlanName field.
	/// </summary>
	public ColumnValue GetPlanNameValue()
	{
		return this.GetValue(TableUtils.PlanNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.PlanName field.
	/// </summary>
	public string GetPlanNameFieldValue()
	{
		return this.GetValue(TableUtils.PlanNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanName field.
	/// </summary>
	public void SetPlanNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PlanNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanName field.
	/// </summary>
	public void SetPlanNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlanNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.PlanWarranty field.
	/// </summary>
	public ColumnValue GetPlanWarrantyValue()
	{
		return this.GetValue(TableUtils.PlanWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.PlanWarranty field.
	/// </summary>
	public Byte GetPlanWarrantyFieldValue()
	{
		return this.GetValue(TableUtils.PlanWarrantyColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanWarranty field.
	/// </summary>
	public void SetPlanWarrantyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PlanWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanWarranty field.
	/// </summary>
	public void SetPlanWarrantyFieldValue(string val)
	{
		this.SetString(val, TableUtils.PlanWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanWarranty field.
	/// </summary>
	public void SetPlanWarrantyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlanWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanWarranty field.
	/// </summary>
	public void SetPlanWarrantyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlanWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanWarranty field.
	/// </summary>
	public void SetPlanWarrantyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PlanWarrantyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WarrantyPlans_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's WarrantyPlans_.LastExtraction field.
	/// </summary>
	public bool LastExtraction
	{
		get
		{
			return this.GetValue(TableUtils.LastExtractionColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.LastExtractionColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LastExtractionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LastExtractionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.LastExtraction field.
	/// </summary>
	public string LastExtractionDefault
	{
		get
		{
			return TableUtils.LastExtractionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's WarrantyPlans_.LockKey field.
	/// </summary>
	public Byte LockKey
	{
		get
		{
			return this.GetValue(TableUtils.LockKeyColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LockKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LockKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LockKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.LockKey field.
	/// </summary>
	public string LockKeyDefault
	{
		get
		{
			return TableUtils.LockKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's WarrantyPlans_.PlanBillingNo field.
	/// </summary>
	public Int32 PlanBillingNo
	{
		get
		{
			return this.GetValue(TableUtils.PlanBillingNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PlanBillingNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PlanBillingNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PlanBillingNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanBillingNo field.
	/// </summary>
	public string PlanBillingNoDefault
	{
		get
		{
			return TableUtils.PlanBillingNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's WarrantyPlans_.PlanDesc field.
	/// </summary>
	public string PlanDesc
	{
		get
		{
			return this.GetValue(TableUtils.PlanDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PlanDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PlanDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PlanDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanDesc field.
	/// </summary>
	public string PlanDescDefault
	{
		get
		{
			return TableUtils.PlanDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's WarrantyPlans_.PlanName field.
	/// </summary>
	public string PlanName
	{
		get
		{
			return this.GetValue(TableUtils.PlanNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PlanNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PlanNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PlanNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanName field.
	/// </summary>
	public string PlanNameDefault
	{
		get
		{
			return TableUtils.PlanNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's WarrantyPlans_.PlanWarranty field.
	/// </summary>
	public Byte PlanWarranty
	{
		get
		{
			return this.GetValue(TableUtils.PlanWarrantyColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PlanWarrantyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PlanWarrantySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PlanWarrantyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.PlanWarranty field.
	/// </summary>
	public string PlanWarrantyDefault
	{
		get
		{
			return TableUtils.PlanWarrantyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's WarrantyPlans_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] SSMA_TimeStamp
	{
		get
		{
			return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SSMA_TimeStampColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SSMA_TimeStampSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SSMA_TimeStampColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WarrantyPlans_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}


#endregion
}

}
