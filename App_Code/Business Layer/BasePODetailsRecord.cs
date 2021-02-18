// This class is "generated" and will be overwritten.
// Your customizations should be made in PODetailsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="PODetailsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PODetailsTable"></see> class.
/// </remarks>
/// <seealso cref="PODetailsTable"></seealso>
/// <seealso cref="PODetailsRecord"></seealso>
public class BasePODetailsRecord : PrimaryKeyRecord
{

	public readonly static PODetailsTable TableUtils = PODetailsTable.Instance;

	// Constructors
 
	protected BasePODetailsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.PODetailsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.PODetailsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.PODetailsRecord_ReadRecord); 
	}

	protected BasePODetailsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void PODetailsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                PODetailsRecord PODetailsRec = (PODetailsRecord)sender;
        if(PODetailsRec != null && !PODetailsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void PODetailsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                PODetailsRecord PODetailsRec = (PODetailsRecord)sender;
        Validate_Inserting();
        if(PODetailsRec != null && !PODetailsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void PODetailsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                PODetailsRecord PODetailsRec = (PODetailsRecord)sender;
        Validate_Updating();
        if(PODetailsRec != null && !PODetailsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POBuyPrice field.
	/// </summary>
	public ColumnValue GetPOBuyPriceValue()
	{
		return this.GetValue(TableUtils.POBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POBuyPrice field.
	/// </summary>
	public Decimal GetPOBuyPriceFieldValue()
	{
		return this.GetValue(TableUtils.POBuyPriceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POBuyPrice field.
	/// </summary>
	public void SetPOBuyPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POBuyPrice field.
	/// </summary>
	public void SetPOBuyPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.POBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POBuyPrice field.
	/// </summary>
	public void SetPOBuyPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POBuyPrice field.
	/// </summary>
	public void SetPOBuyPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POBuyPrice field.
	/// </summary>
	public void SetPOBuyPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POBuyPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POItemDesc field.
	/// </summary>
	public ColumnValue GetPOItemDescValue()
	{
		return this.GetValue(TableUtils.POItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POItemDesc field.
	/// </summary>
	public string GetPOItemDescFieldValue()
	{
		return this.GetValue(TableUtils.POItemDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POItemDesc field.
	/// </summary>
	public void SetPOItemDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POItemDesc field.
	/// </summary>
	public void SetPOItemDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POItemDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POLocation field.
	/// </summary>
	public ColumnValue GetPOLocationValue()
	{
		return this.GetValue(TableUtils.POLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POLocation field.
	/// </summary>
	public Int32 GetPOLocationFieldValue()
	{
		return this.GetValue(TableUtils.POLocationColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POLocation field.
	/// </summary>
	public void SetPOLocationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POLocation field.
	/// </summary>
	public void SetPOLocationFieldValue(string val)
	{
		this.SetString(val, TableUtils.POLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POLocation field.
	/// </summary>
	public void SetPOLocationFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POLocation field.
	/// </summary>
	public void SetPOLocationFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POLocation field.
	/// </summary>
	public void SetPOLocationFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POLocationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POMake field.
	/// </summary>
	public ColumnValue GetPOMakeValue()
	{
		return this.GetValue(TableUtils.POMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POMake field.
	/// </summary>
	public string GetPOMakeFieldValue()
	{
		return this.GetValue(TableUtils.POMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POMake field.
	/// </summary>
	public void SetPOMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POMake field.
	/// </summary>
	public void SetPOMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POModel field.
	/// </summary>
	public ColumnValue GetPOModelValue()
	{
		return this.GetValue(TableUtils.POModelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POModel field.
	/// </summary>
	public string GetPOModelFieldValue()
	{
		return this.GetValue(TableUtils.POModelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POModel field.
	/// </summary>
	public void SetPOModelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POModelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POModel field.
	/// </summary>
	public void SetPOModelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POModelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.PONo field.
	/// </summary>
	public ColumnValue GetPONoValue()
	{
		return this.GetValue(TableUtils.PONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.PONo field.
	/// </summary>
	public Int32 GetPONoFieldValue()
	{
		return this.GetValue(TableUtils.PONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.PONo field.
	/// </summary>
	public void SetPONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.PONo field.
	/// </summary>
	public void SetPONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.PONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.PONo field.
	/// </summary>
	public void SetPONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.PONo field.
	/// </summary>
	public void SetPONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.PONo field.
	/// </summary>
	public void SetPONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POPartNo field.
	/// </summary>
	public ColumnValue GetPOPartNoValue()
	{
		return this.GetValue(TableUtils.POPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POPartNo field.
	/// </summary>
	public string GetPOPartNoFieldValue()
	{
		return this.GetValue(TableUtils.POPartNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POPartNo field.
	/// </summary>
	public void SetPOPartNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POPartNo field.
	/// </summary>
	public void SetPOPartNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POPartNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POQtyOrdered field.
	/// </summary>
	public ColumnValue GetPOQtyOrderedValue()
	{
		return this.GetValue(TableUtils.POQtyOrderedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POQtyOrdered field.
	/// </summary>
	public Single GetPOQtyOrderedFieldValue()
	{
		return this.GetValue(TableUtils.POQtyOrderedColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyOrdered field.
	/// </summary>
	public void SetPOQtyOrderedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POQtyOrderedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyOrdered field.
	/// </summary>
	public void SetPOQtyOrderedFieldValue(string val)
	{
		this.SetString(val, TableUtils.POQtyOrderedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyOrdered field.
	/// </summary>
	public void SetPOQtyOrderedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POQtyOrderedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyOrdered field.
	/// </summary>
	public void SetPOQtyOrderedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POQtyOrderedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyOrdered field.
	/// </summary>
	public void SetPOQtyOrderedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POQtyOrderedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POQtyReceived field.
	/// </summary>
	public ColumnValue GetPOQtyReceivedValue()
	{
		return this.GetValue(TableUtils.POQtyReceivedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POQtyReceived field.
	/// </summary>
	public Single GetPOQtyReceivedFieldValue()
	{
		return this.GetValue(TableUtils.POQtyReceivedColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyReceived field.
	/// </summary>
	public void SetPOQtyReceivedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POQtyReceivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyReceived field.
	/// </summary>
	public void SetPOQtyReceivedFieldValue(string val)
	{
		this.SetString(val, TableUtils.POQtyReceivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyReceived field.
	/// </summary>
	public void SetPOQtyReceivedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POQtyReceivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyReceived field.
	/// </summary>
	public void SetPOQtyReceivedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POQtyReceivedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyReceived field.
	/// </summary>
	public void SetPOQtyReceivedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POQtyReceivedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POReference field.
	/// </summary>
	public ColumnValue GetPOReferenceValue()
	{
		return this.GetValue(TableUtils.POReferenceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POReference field.
	/// </summary>
	public string GetPOReferenceFieldValue()
	{
		return this.GetValue(TableUtils.POReferenceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POReference field.
	/// </summary>
	public void SetPOReferenceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POReferenceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POReference field.
	/// </summary>
	public void SetPOReferenceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POReferenceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POSort field.
	/// </summary>
	public ColumnValue GetPOSortValue()
	{
		return this.GetValue(TableUtils.POSortColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POSort field.
	/// </summary>
	public Int32 GetPOSortFieldValue()
	{
		return this.GetValue(TableUtils.POSortColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POVendorPartNo field.
	/// </summary>
	public ColumnValue GetPOVendorPartNoValue()
	{
		return this.GetValue(TableUtils.POVendorPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.POVendorPartNo field.
	/// </summary>
	public string GetPOVendorPartNoFieldValue()
	{
		return this.GetValue(TableUtils.POVendorPartNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POVendorPartNo field.
	/// </summary>
	public void SetPOVendorPartNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.POVendorPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POVendorPartNo field.
	/// </summary>
	public void SetPOVendorPartNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.POVendorPartNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.SessionID field.
	/// </summary>
	public ColumnValue GetSessionIDValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.SessionID field.
	/// </summary>
	public Int32 GetSessionIDFieldValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PODetails_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POBuyPrice field.
	/// </summary>
	public Decimal POBuyPrice
	{
		get
		{
			return this.GetValue(TableUtils.POBuyPriceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POBuyPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POBuyPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POBuyPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POBuyPrice field.
	/// </summary>
	public string POBuyPriceDefault
	{
		get
		{
			return TableUtils.POBuyPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POItemDesc field.
	/// </summary>
	public string POItemDesc
	{
		get
		{
			return this.GetValue(TableUtils.POItemDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POItemDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POItemDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POItemDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POItemDesc field.
	/// </summary>
	public string POItemDescDefault
	{
		get
		{
			return TableUtils.POItemDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POLocation field.
	/// </summary>
	public Int32 POLocation
	{
		get
		{
			return this.GetValue(TableUtils.POLocationColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POLocationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POLocationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POLocationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POLocation field.
	/// </summary>
	public string POLocationDefault
	{
		get
		{
			return TableUtils.POLocationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POMake field.
	/// </summary>
	public string POMake
	{
		get
		{
			return this.GetValue(TableUtils.POMakeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POMakeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POMakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POMakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POMake field.
	/// </summary>
	public string POMakeDefault
	{
		get
		{
			return TableUtils.POMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POModel field.
	/// </summary>
	public string POModel
	{
		get
		{
			return this.GetValue(TableUtils.POModelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POModelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POModelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POModelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POModel field.
	/// </summary>
	public string POModelDefault
	{
		get
		{
			return TableUtils.POModelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.PONo field.
	/// </summary>
	public Int32 PONo
	{
		get
		{
			return this.GetValue(TableUtils.PONoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PONoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PONoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PONoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.PONo field.
	/// </summary>
	public string PONoDefault
	{
		get
		{
			return TableUtils.PONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POPartNo field.
	/// </summary>
	public string POPartNo
	{
		get
		{
			return this.GetValue(TableUtils.POPartNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POPartNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POPartNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POPartNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POPartNo field.
	/// </summary>
	public string POPartNoDefault
	{
		get
		{
			return TableUtils.POPartNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POQtyOrdered field.
	/// </summary>
	public Single POQtyOrdered
	{
		get
		{
			return this.GetValue(TableUtils.POQtyOrderedColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POQtyOrderedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POQtyOrderedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POQtyOrderedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyOrdered field.
	/// </summary>
	public string POQtyOrderedDefault
	{
		get
		{
			return TableUtils.POQtyOrderedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POQtyReceived field.
	/// </summary>
	public Single POQtyReceived
	{
		get
		{
			return this.GetValue(TableUtils.POQtyReceivedColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POQtyReceivedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POQtyReceivedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POQtyReceivedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POQtyReceived field.
	/// </summary>
	public string POQtyReceivedDefault
	{
		get
		{
			return TableUtils.POQtyReceivedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POReference field.
	/// </summary>
	public string POReference
	{
		get
		{
			return this.GetValue(TableUtils.POReferenceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POReferenceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POReferenceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POReferenceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POReference field.
	/// </summary>
	public string POReferenceDefault
	{
		get
		{
			return TableUtils.POReferenceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POSort field.
	/// </summary>
	public Int32 POSort
	{
		get
		{
			return this.GetValue(TableUtils.POSortColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POSortColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POSortSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POSortColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POSort field.
	/// </summary>
	public string POSortDefault
	{
		get
		{
			return TableUtils.POSortColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.POVendorPartNo field.
	/// </summary>
	public string POVendorPartNo
	{
		get
		{
			return this.GetValue(TableUtils.POVendorPartNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.POVendorPartNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool POVendorPartNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.POVendorPartNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.POVendorPartNo field.
	/// </summary>
	public string POVendorPartNoDefault
	{
		get
		{
			return TableUtils.POVendorPartNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.SessionID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.SessionID field.
	/// </summary>
	public string SessionIDDefault
	{
		get
		{
			return TableUtils.SessionIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PODetails_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PODetails_.SSMA_TimeStamp field.
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
