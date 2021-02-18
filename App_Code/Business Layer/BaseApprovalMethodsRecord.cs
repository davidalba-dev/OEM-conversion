// This class is "generated" and will be overwritten.
// Your customizations should be made in ApprovalMethodsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ApprovalMethodsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ApprovalMethodsTable"></see> class.
/// </remarks>
/// <seealso cref="ApprovalMethodsTable"></seealso>
/// <seealso cref="ApprovalMethodsRecord"></seealso>
public class BaseApprovalMethodsRecord : PrimaryKeyRecord
{

	public readonly static ApprovalMethodsTable TableUtils = ApprovalMethodsTable.Instance;

	// Constructors
 
	protected BaseApprovalMethodsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ApprovalMethodsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ApprovalMethodsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ApprovalMethodsRecord_ReadRecord); 
	}

	protected BaseApprovalMethodsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ApprovalMethodsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ApprovalMethodsRecord ApprovalMethodsRec = (ApprovalMethodsRecord)sender;
        if(ApprovalMethodsRec != null && !ApprovalMethodsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ApprovalMethodsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ApprovalMethodsRecord ApprovalMethodsRec = (ApprovalMethodsRecord)sender;
        Validate_Inserting();
        if(ApprovalMethodsRec != null && !ApprovalMethodsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ApprovalMethodsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ApprovalMethodsRecord ApprovalMethodsRec = (ApprovalMethodsRecord)sender;
        Validate_Updating();
        if(ApprovalMethodsRec != null && !ApprovalMethodsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.ApprovalMethod field.
	/// </summary>
	public ColumnValue GetApprovalMethodValue()
	{
		return this.GetValue(TableUtils.ApprovalMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.ApprovalMethod field.
	/// </summary>
	public string GetApprovalMethodFieldValue()
	{
		return this.GetValue(TableUtils.ApprovalMethodColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.ApprovalMethod field.
	/// </summary>
	public void SetApprovalMethodFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ApprovalMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.ApprovalMethod field.
	/// </summary>
	public void SetApprovalMethodFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ApprovalMethodColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.LastExtraction field.
	/// </summary>
	public ColumnValue GetLastExtractionValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.LastExtraction field.
	/// </summary>
	public bool GetLastExtractionFieldValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(string val)
	{
		this.SetString(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastExtractionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.LockKey field.
	/// </summary>
	public ColumnValue GetLockKeyValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.LockKey field.
	/// </summary>
	public Int32 GetLockKeyFieldValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.Approve_active field.
	/// </summary>
	public ColumnValue GetApprove_activeValue()
	{
		return this.GetValue(TableUtils.Approve_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ApprovalMethods_.Approve_active field.
	/// </summary>
	public bool GetApprove_activeFieldValue()
	{
		return this.GetValue(TableUtils.Approve_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.Approve_active field.
	/// </summary>
	public void SetApprove_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Approve_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.Approve_active field.
	/// </summary>
	public void SetApprove_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.Approve_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.Approve_active field.
	/// </summary>
	public void SetApprove_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Approve_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's ApprovalMethods_.ApprovalMethod field.
	/// </summary>
	public string ApprovalMethod
	{
		get
		{
			return this.GetValue(TableUtils.ApprovalMethodColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ApprovalMethodColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ApprovalMethodSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ApprovalMethodColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.ApprovalMethod field.
	/// </summary>
	public string ApprovalMethodDefault
	{
		get
		{
			return TableUtils.ApprovalMethodColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ApprovalMethods_.LastExtraction field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.LastExtraction field.
	/// </summary>
	public string LastExtractionDefault
	{
		get
		{
			return TableUtils.LastExtractionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ApprovalMethods_.LockKey field.
	/// </summary>
	public Int32 LockKey
	{
		get
		{
			return this.GetValue(TableUtils.LockKeyColumn).ToInt32();
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
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.LockKey field.
	/// </summary>
	public string LockKeyDefault
	{
		get
		{
			return TableUtils.LockKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ApprovalMethods_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ApprovalMethods_.Approve_active field.
	/// </summary>
	public bool Approve_active
	{
		get
		{
			return this.GetValue(TableUtils.Approve_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Approve_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Approve_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Approve_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ApprovalMethods_.Approve_active field.
	/// </summary>
	public string Approve_activeDefault
	{
		get
		{
			return TableUtils.Approve_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
