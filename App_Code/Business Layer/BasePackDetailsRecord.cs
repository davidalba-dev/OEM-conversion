// This class is "generated" and will be overwritten.
// Your customizations should be made in PackDetailsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="PackDetailsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PackDetailsTable"></see> class.
/// </remarks>
/// <seealso cref="PackDetailsTable"></seealso>
/// <seealso cref="PackDetailsRecord"></seealso>
public class BasePackDetailsRecord : PrimaryKeyRecord
{

	public readonly static PackDetailsTable TableUtils = PackDetailsTable.Instance;

	// Constructors
 
	protected BasePackDetailsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.PackDetailsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.PackDetailsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.PackDetailsRecord_ReadRecord); 
	}

	protected BasePackDetailsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void PackDetailsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                PackDetailsRecord PackDetailsRec = (PackDetailsRecord)sender;
        if(PackDetailsRec != null && !PackDetailsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void PackDetailsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                PackDetailsRecord PackDetailsRec = (PackDetailsRecord)sender;
        Validate_Inserting();
        if(PackDetailsRec != null && !PackDetailsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void PackDetailsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                PackDetailsRecord PackDetailsRec = (PackDetailsRecord)sender;
        Validate_Updating();
        if(PackDetailsRec != null && !PackDetailsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackItemDesc field.
	/// </summary>
	public ColumnValue GetPackItemDescValue()
	{
		return this.GetValue(TableUtils.PackItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackItemDesc field.
	/// </summary>
	public string GetPackItemDescFieldValue()
	{
		return this.GetValue(TableUtils.PackItemDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackItemDesc field.
	/// </summary>
	public void SetPackItemDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackItemDesc field.
	/// </summary>
	public void SetPackItemDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackItemDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackKey field.
	/// </summary>
	public ColumnValue GetPackKeyValue()
	{
		return this.GetValue(TableUtils.PackKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackKey field.
	/// </summary>
	public Int32 GetPackKeyFieldValue()
	{
		return this.GetValue(TableUtils.PackKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackKey field.
	/// </summary>
	public void SetPackKeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackKey field.
	/// </summary>
	public void SetPackKeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.PackKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackKey field.
	/// </summary>
	public void SetPackKeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackKey field.
	/// </summary>
	public void SetPackKeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackKey field.
	/// </summary>
	public void SetPackKeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackKeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackLineType field.
	/// </summary>
	public ColumnValue GetPackLineTypeValue()
	{
		return this.GetValue(TableUtils.PackLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackLineType field.
	/// </summary>
	public Byte GetPackLineTypeFieldValue()
	{
		return this.GetValue(TableUtils.PackLineTypeColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackLineType field.
	/// </summary>
	public void SetPackLineTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackLineType field.
	/// </summary>
	public void SetPackLineTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.PackLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackLineType field.
	/// </summary>
	public void SetPackLineTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackLineType field.
	/// </summary>
	public void SetPackLineTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackLineType field.
	/// </summary>
	public void SetPackLineTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackLineTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackPartNo field.
	/// </summary>
	public ColumnValue GetPackPartNoValue()
	{
		return this.GetValue(TableUtils.PackPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackPartNo field.
	/// </summary>
	public string GetPackPartNoFieldValue()
	{
		return this.GetValue(TableUtils.PackPartNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackPartNo field.
	/// </summary>
	public void SetPackPartNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackPartNo field.
	/// </summary>
	public void SetPackPartNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackPartNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackQuantity field.
	/// </summary>
	public ColumnValue GetPackQuantityValue()
	{
		return this.GetValue(TableUtils.PackQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackQuantity field.
	/// </summary>
	public Single GetPackQuantityFieldValue()
	{
		return this.GetValue(TableUtils.PackQuantityColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackQuantity field.
	/// </summary>
	public void SetPackQuantityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackQuantity field.
	/// </summary>
	public void SetPackQuantityFieldValue(string val)
	{
		this.SetString(val, TableUtils.PackQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackQuantity field.
	/// </summary>
	public void SetPackQuantityFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackQuantity field.
	/// </summary>
	public void SetPackQuantityFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackQuantity field.
	/// </summary>
	public void SetPackQuantityFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackQuantityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackSellPrice field.
	/// </summary>
	public ColumnValue GetPackSellPriceValue()
	{
		return this.GetValue(TableUtils.PackSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackSellPrice field.
	/// </summary>
	public Decimal GetPackSellPriceFieldValue()
	{
		return this.GetValue(TableUtils.PackSellPriceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackSellPrice field.
	/// </summary>
	public void SetPackSellPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackSellPrice field.
	/// </summary>
	public void SetPackSellPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.PackSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackSellPrice field.
	/// </summary>
	public void SetPackSellPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackSellPrice field.
	/// </summary>
	public void SetPackSellPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackSellPrice field.
	/// </summary>
	public void SetPackSellPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackSellPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackSort field.
	/// </summary>
	public ColumnValue GetPackSortValue()
	{
		return this.GetValue(TableUtils.PackSortColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.PackSort field.
	/// </summary>
	public Int32 GetPackSortFieldValue()
	{
		return this.GetValue(TableUtils.PackSortColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.SessionID field.
	/// </summary>
	public ColumnValue GetSessionIDValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.SessionID field.
	/// </summary>
	public Int32 GetSessionIDFieldValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PackDetails_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PackDetails_.PackItemDesc field.
	/// </summary>
	public string PackItemDesc
	{
		get
		{
			return this.GetValue(TableUtils.PackItemDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackItemDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackItemDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackItemDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackItemDesc field.
	/// </summary>
	public string PackItemDescDefault
	{
		get
		{
			return TableUtils.PackItemDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PackDetails_.PackKey field.
	/// </summary>
	public Int32 PackKey
	{
		get
		{
			return this.GetValue(TableUtils.PackKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackKey field.
	/// </summary>
	public string PackKeyDefault
	{
		get
		{
			return TableUtils.PackKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PackDetails_.PackLineType field.
	/// </summary>
	public Byte PackLineType
	{
		get
		{
			return this.GetValue(TableUtils.PackLineTypeColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackLineTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackLineTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackLineTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackLineType field.
	/// </summary>
	public string PackLineTypeDefault
	{
		get
		{
			return TableUtils.PackLineTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PackDetails_.PackPartNo field.
	/// </summary>
	public string PackPartNo
	{
		get
		{
			return this.GetValue(TableUtils.PackPartNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackPartNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackPartNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackPartNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackPartNo field.
	/// </summary>
	public string PackPartNoDefault
	{
		get
		{
			return TableUtils.PackPartNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PackDetails_.PackQuantity field.
	/// </summary>
	public Single PackQuantity
	{
		get
		{
			return this.GetValue(TableUtils.PackQuantityColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackQuantityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackQuantitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackQuantityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackQuantity field.
	/// </summary>
	public string PackQuantityDefault
	{
		get
		{
			return TableUtils.PackQuantityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PackDetails_.PackSellPrice field.
	/// </summary>
	public Decimal PackSellPrice
	{
		get
		{
			return this.GetValue(TableUtils.PackSellPriceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackSellPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackSellPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackSellPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackSellPrice field.
	/// </summary>
	public string PackSellPriceDefault
	{
		get
		{
			return TableUtils.PackSellPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PackDetails_.PackSort field.
	/// </summary>
	public Int32 PackSort
	{
		get
		{
			return this.GetValue(TableUtils.PackSortColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackSortColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackSortSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackSortColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.PackSort field.
	/// </summary>
	public string PackSortDefault
	{
		get
		{
			return TableUtils.PackSortColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PackDetails_.SessionID field.
	/// </summary>
	public Int32 SessionID
	{
		get
		{
			return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SessionIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SessionIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SessionIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.SessionID field.
	/// </summary>
	public string SessionIDDefault
	{
		get
		{
			return TableUtils.SessionIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PackDetails_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PackDetails_.SSMA_TimeStamp field.
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
