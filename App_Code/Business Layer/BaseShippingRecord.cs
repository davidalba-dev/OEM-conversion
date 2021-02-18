// This class is "generated" and will be overwritten.
// Your customizations should be made in ShippingRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ShippingRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ShippingTable"></see> class.
/// </remarks>
/// <seealso cref="ShippingTable"></seealso>
/// <seealso cref="ShippingRecord"></seealso>
public class BaseShippingRecord : PrimaryKeyRecord
{

	public readonly static ShippingTable TableUtils = ShippingTable.Instance;

	// Constructors
 
	protected BaseShippingRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ShippingRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ShippingRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ShippingRecord_ReadRecord); 
	}

	protected BaseShippingRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ShippingRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ShippingRecord ShippingRec = (ShippingRecord)sender;
        if(ShippingRec != null && !ShippingRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ShippingRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ShippingRecord ShippingRec = (ShippingRecord)sender;
        Validate_Inserting();
        if(ShippingRec != null && !ShippingRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ShippingRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ShippingRecord ShippingRec = (ShippingRecord)sender;
        Validate_Updating();
        if(ShippingRec != null && !ShippingRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.LastExtraction field.
	/// </summary>
	public ColumnValue GetLastExtractionValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.LastExtraction field.
	/// </summary>
	public bool GetLastExtractionFieldValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(string val)
	{
		this.SetString(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastExtractionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.LockKey field.
	/// </summary>
	public ColumnValue GetLockKeyValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.LockKey field.
	/// </summary>
	public Int32 GetLockKeyFieldValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.ShipCharge field.
	/// </summary>
	public ColumnValue GetShipChargeValue()
	{
		return this.GetValue(TableUtils.ShipChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.ShipCharge field.
	/// </summary>
	public bool GetShipChargeFieldValue()
	{
		return this.GetValue(TableUtils.ShipChargeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipCharge field.
	/// </summary>
	public void SetShipChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ShipChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipCharge field.
	/// </summary>
	public void SetShipChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ShipChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipCharge field.
	/// </summary>
	public void SetShipChargeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ShipChargeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.ShipTracking field.
	/// </summary>
	public ColumnValue GetShipTrackingValue()
	{
		return this.GetValue(TableUtils.ShipTrackingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.ShipTracking field.
	/// </summary>
	public Byte GetShipTrackingFieldValue()
	{
		return this.GetValue(TableUtils.ShipTrackingColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipTracking field.
	/// </summary>
	public void SetShipTrackingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ShipTrackingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipTracking field.
	/// </summary>
	public void SetShipTrackingFieldValue(string val)
	{
		this.SetString(val, TableUtils.ShipTrackingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipTracking field.
	/// </summary>
	public void SetShipTrackingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ShipTrackingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipTracking field.
	/// </summary>
	public void SetShipTrackingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ShipTrackingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipTracking field.
	/// </summary>
	public void SetShipTrackingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ShipTrackingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.ShipVia field.
	/// </summary>
	public ColumnValue GetShipViaValue()
	{
		return this.GetValue(TableUtils.ShipViaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.ShipVia field.
	/// </summary>
	public string GetShipViaFieldValue()
	{
		return this.GetValue(TableUtils.ShipViaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipVia field.
	/// </summary>
	public void SetShipViaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ShipViaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipVia field.
	/// </summary>
	public void SetShipViaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ShipViaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.shipping_active field.
	/// </summary>
	public ColumnValue Getshipping_activeValue()
	{
		return this.GetValue(TableUtils.shipping_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Shipping_.shipping_active field.
	/// </summary>
	public bool Getshipping_activeFieldValue()
	{
		return this.GetValue(TableUtils.shipping_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.shipping_active field.
	/// </summary>
	public void Setshipping_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.shipping_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.shipping_active field.
	/// </summary>
	public void Setshipping_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.shipping_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.shipping_active field.
	/// </summary>
	public void Setshipping_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.shipping_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Shipping_.LastExtraction field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.LastExtraction field.
	/// </summary>
	public string LastExtractionDefault
	{
		get
		{
			return TableUtils.LastExtractionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Shipping_.LockKey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.LockKey field.
	/// </summary>
	public string LockKeyDefault
	{
		get
		{
			return TableUtils.LockKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Shipping_.ShipCharge field.
	/// </summary>
	public bool ShipCharge
	{
		get
		{
			return this.GetValue(TableUtils.ShipChargeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ShipChargeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ShipChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ShipChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipCharge field.
	/// </summary>
	public string ShipChargeDefault
	{
		get
		{
			return TableUtils.ShipChargeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Shipping_.ShipTracking field.
	/// </summary>
	public Byte ShipTracking
	{
		get
		{
			return this.GetValue(TableUtils.ShipTrackingColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ShipTrackingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ShipTrackingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ShipTrackingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipTracking field.
	/// </summary>
	public string ShipTrackingDefault
	{
		get
		{
			return TableUtils.ShipTrackingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Shipping_.ShipVia field.
	/// </summary>
	public string ShipVia
	{
		get
		{
			return this.GetValue(TableUtils.ShipViaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ShipViaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ShipViaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ShipViaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.ShipVia field.
	/// </summary>
	public string ShipViaDefault
	{
		get
		{
			return TableUtils.ShipViaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Shipping_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Shipping_.shipping_active field.
	/// </summary>
	public bool shipping_active
	{
		get
		{
			return this.GetValue(TableUtils.shipping_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.shipping_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool shipping_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.shipping_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Shipping_.shipping_active field.
	/// </summary>
	public string shipping_activeDefault
	{
		get
		{
			return TableUtils.shipping_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
