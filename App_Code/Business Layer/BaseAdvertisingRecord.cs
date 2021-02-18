// This class is "generated" and will be overwritten.
// Your customizations should be made in AdvertisingRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="AdvertisingRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AdvertisingTable"></see> class.
/// </remarks>
/// <seealso cref="AdvertisingTable"></seealso>
/// <seealso cref="AdvertisingRecord"></seealso>
public class BaseAdvertisingRecord : PrimaryKeyRecord
{

	public readonly static AdvertisingTable TableUtils = AdvertisingTable.Instance;

	// Constructors
 
	protected BaseAdvertisingRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.AdvertisingRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.AdvertisingRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.AdvertisingRecord_ReadRecord); 
	}

	protected BaseAdvertisingRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void AdvertisingRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                AdvertisingRecord AdvertisingRec = (AdvertisingRecord)sender;
        if(AdvertisingRec != null && !AdvertisingRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void AdvertisingRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                AdvertisingRecord AdvertisingRec = (AdvertisingRecord)sender;
        Validate_Inserting();
        if(AdvertisingRec != null && !AdvertisingRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void AdvertisingRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                AdvertisingRecord AdvertisingRec = (AdvertisingRecord)sender;
        Validate_Updating();
        if(AdvertisingRec != null && !AdvertisingRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.Advertising field.
	/// </summary>
	public ColumnValue GetAdvertisingValue()
	{
		return this.GetValue(TableUtils.AdvertisingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.Advertising field.
	/// </summary>
	public string GetAdvertisingFieldValue()
	{
		return this.GetValue(TableUtils.AdvertisingColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.Advertising field.
	/// </summary>
	public void SetAdvertisingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdvertisingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.Advertising field.
	/// </summary>
	public void SetAdvertisingFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdvertisingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.LastExtraction field.
	/// </summary>
	public ColumnValue GetLastExtractionValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.LastExtraction field.
	/// </summary>
	public bool GetLastExtractionFieldValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(string val)
	{
		this.SetString(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastExtractionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.LockKey field.
	/// </summary>
	public ColumnValue GetLockKeyValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.LockKey field.
	/// </summary>
	public Int32 GetLockKeyFieldValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.Advertising_active field.
	/// </summary>
	public ColumnValue GetAdvertising_activeValue()
	{
		return this.GetValue(TableUtils.Advertising_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Advertising_.Advertising_active field.
	/// </summary>
	public bool GetAdvertising_activeFieldValue()
	{
		return this.GetValue(TableUtils.Advertising_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.Advertising_active field.
	/// </summary>
	public void SetAdvertising_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Advertising_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.Advertising_active field.
	/// </summary>
	public void SetAdvertising_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.Advertising_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.Advertising_active field.
	/// </summary>
	public void SetAdvertising_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Advertising_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Advertising_.Advertising field.
	/// </summary>
	public string Advertising
	{
		get
		{
			return this.GetValue(TableUtils.AdvertisingColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AdvertisingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AdvertisingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AdvertisingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.Advertising field.
	/// </summary>
	public string AdvertisingDefault
	{
		get
		{
			return TableUtils.AdvertisingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Advertising_.LastExtraction field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.LastExtraction field.
	/// </summary>
	public string LastExtractionDefault
	{
		get
		{
			return TableUtils.LastExtractionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Advertising_.LockKey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.LockKey field.
	/// </summary>
	public string LockKeyDefault
	{
		get
		{
			return TableUtils.LockKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Advertising_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Advertising_.Advertising_active field.
	/// </summary>
	public bool Advertising_active
	{
		get
		{
			return this.GetValue(TableUtils.Advertising_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Advertising_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Advertising_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Advertising_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Advertising_.Advertising_active field.
	/// </summary>
	public string Advertising_activeDefault
	{
		get
		{
			return TableUtils.Advertising_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
