// This class is "generated" and will be overwritten.
// Your customizations should be made in LedgerInventoryRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="LedgerInventoryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="LedgerInventoryTable"></see> class.
/// </remarks>
/// <seealso cref="LedgerInventoryTable"></seealso>
/// <seealso cref="LedgerInventoryRecord"></seealso>
public class BaseLedgerInventoryRecord : PrimaryKeyRecord
{

	public readonly static LedgerInventoryTable TableUtils = LedgerInventoryTable.Instance;

	// Constructors
 
	protected BaseLedgerInventoryRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.LedgerInventoryRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.LedgerInventoryRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.LedgerInventoryRecord_ReadRecord); 
	}

	protected BaseLedgerInventoryRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void LedgerInventoryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                LedgerInventoryRecord LedgerInventoryRec = (LedgerInventoryRecord)sender;
        if(LedgerInventoryRec != null && !LedgerInventoryRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void LedgerInventoryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                LedgerInventoryRecord LedgerInventoryRec = (LedgerInventoryRecord)sender;
        Validate_Inserting();
        if(LedgerInventoryRec != null && !LedgerInventoryRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void LedgerInventoryRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                LedgerInventoryRecord LedgerInventoryRec = (LedgerInventoryRecord)sender;
        Validate_Updating();
        if(LedgerInventoryRec != null && !LedgerInventoryRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgBin field.
	/// </summary>
	public ColumnValue GetLdgBinValue()
	{
		return this.GetValue(TableUtils.LdgBinColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgBin field.
	/// </summary>
	public string GetLdgBinFieldValue()
	{
		return this.GetValue(TableUtils.LdgBinColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgBin field.
	/// </summary>
	public void SetLdgBinFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgBinColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgBin field.
	/// </summary>
	public void SetLdgBinFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBinColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgBuyPrice field.
	/// </summary>
	public ColumnValue GetLdgBuyPriceValue()
	{
		return this.GetValue(TableUtils.LdgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgBuyPrice field.
	/// </summary>
	public Decimal GetLdgBuyPriceFieldValue()
	{
		return this.GetValue(TableUtils.LdgBuyPriceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgBuyPrice field.
	/// </summary>
	public void SetLdgBuyPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgBuyPrice field.
	/// </summary>
	public void SetLdgBuyPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgBuyPrice field.
	/// </summary>
	public void SetLdgBuyPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgBuyPrice field.
	/// </summary>
	public void SetLdgBuyPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgBuyPrice field.
	/// </summary>
	public void SetLdgBuyPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgBuyPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgExported field.
	/// </summary>
	public ColumnValue GetLdgExportedValue()
	{
		return this.GetValue(TableUtils.LdgExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgExported field.
	/// </summary>
	public DateTime GetLdgExportedFieldValue()
	{
		return this.GetValue(TableUtils.LdgExportedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExported field.
	/// </summary>
	public void SetLdgExportedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExported field.
	/// </summary>
	public void SetLdgExportedFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExported field.
	/// </summary>
	public void SetLdgExportedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgExportedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgExportInclude field.
	/// </summary>
	public ColumnValue GetLdgExportIncludeValue()
	{
		return this.GetValue(TableUtils.LdgExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgExportInclude field.
	/// </summary>
	public bool GetLdgExportIncludeFieldValue()
	{
		return this.GetValue(TableUtils.LdgExportIncludeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExportInclude field.
	/// </summary>
	public void SetLdgExportIncludeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExportInclude field.
	/// </summary>
	public void SetLdgExportIncludeFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExportInclude field.
	/// </summary>
	public void SetLdgExportIncludeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgExportIncludeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgExportRecordChanged field.
	/// </summary>
	public ColumnValue GetLdgExportRecordChangedValue()
	{
		return this.GetValue(TableUtils.LdgExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgExportRecordChanged field.
	/// </summary>
	public bool GetLdgExportRecordChangedFieldValue()
	{
		return this.GetValue(TableUtils.LdgExportRecordChangedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExportRecordChanged field.
	/// </summary>
	public void SetLdgExportRecordChangedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExportRecordChanged field.
	/// </summary>
	public void SetLdgExportRecordChangedFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExportRecordChanged field.
	/// </summary>
	public void SetLdgExportRecordChangedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgExportRecordChangedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgFormNo field.
	/// </summary>
	public ColumnValue GetLdgFormNoValue()
	{
		return this.GetValue(TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgFormNo field.
	/// </summary>
	public Int32 GetLdgFormNoFieldValue()
	{
		return this.GetValue(TableUtils.LdgFormNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgFormType field.
	/// </summary>
	public ColumnValue GetLdgFormTypeValue()
	{
		return this.GetValue(TableUtils.LdgFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgFormType field.
	/// </summary>
	public string GetLdgFormTypeFieldValue()
	{
		return this.GetValue(TableUtils.LdgFormTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgFormType field.
	/// </summary>
	public void SetLdgFormTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgFormType field.
	/// </summary>
	public void SetLdgFormTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgKey field.
	/// </summary>
	public ColumnValue GetLdgKeyValue()
	{
		return this.GetValue(TableUtils.LdgKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgKey field.
	/// </summary>
	public Int32 GetLdgKeyFieldValue()
	{
		return this.GetValue(TableUtils.LdgKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgLocation field.
	/// </summary>
	public ColumnValue GetLdgLocationValue()
	{
		return this.GetValue(TableUtils.LdgLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgLocation field.
	/// </summary>
	public Int32 GetLdgLocationFieldValue()
	{
		return this.GetValue(TableUtils.LdgLocationColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgLocation field.
	/// </summary>
	public void SetLdgLocationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgLocation field.
	/// </summary>
	public void SetLdgLocationFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgLocation field.
	/// </summary>
	public void SetLdgLocationFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgLocation field.
	/// </summary>
	public void SetLdgLocationFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgLocation field.
	/// </summary>
	public void SetLdgLocationFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgLocationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgPartNo field.
	/// </summary>
	public ColumnValue GetLdgPartNoValue()
	{
		return this.GetValue(TableUtils.LdgPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgPartNo field.
	/// </summary>
	public string GetLdgPartNoFieldValue()
	{
		return this.GetValue(TableUtils.LdgPartNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgPartNo field.
	/// </summary>
	public void SetLdgPartNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgPartNo field.
	/// </summary>
	public void SetLdgPartNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgPartNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgQuantity field.
	/// </summary>
	public ColumnValue GetLdgQuantityValue()
	{
		return this.GetValue(TableUtils.LdgQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgQuantity field.
	/// </summary>
	public Single GetLdgQuantityFieldValue()
	{
		return this.GetValue(TableUtils.LdgQuantityColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgQuantity field.
	/// </summary>
	public void SetLdgQuantityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgQuantity field.
	/// </summary>
	public void SetLdgQuantityFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgQuantity field.
	/// </summary>
	public void SetLdgQuantityFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgQuantity field.
	/// </summary>
	public void SetLdgQuantityFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgQuantity field.
	/// </summary>
	public void SetLdgQuantityFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgQuantityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgRecDate field.
	/// </summary>
	public ColumnValue GetLdgRecDateValue()
	{
		return this.GetValue(TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgRecDate field.
	/// </summary>
	public DateTime GetLdgRecDateFieldValue()
	{
		return this.GetValue(TableUtils.LdgRecDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgRecDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgReference field.
	/// </summary>
	public ColumnValue GetLdgReferenceValue()
	{
		return this.GetValue(TableUtils.LdgReferenceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgReference field.
	/// </summary>
	public string GetLdgReferenceFieldValue()
	{
		return this.GetValue(TableUtils.LdgReferenceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgReference field.
	/// </summary>
	public void SetLdgReferenceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgReferenceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgReference field.
	/// </summary>
	public void SetLdgReferenceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgReferenceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgSellPrice field.
	/// </summary>
	public ColumnValue GetLdgSellPriceValue()
	{
		return this.GetValue(TableUtils.LdgSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgSellPrice field.
	/// </summary>
	public Decimal GetLdgSellPriceFieldValue()
	{
		return this.GetValue(TableUtils.LdgSellPriceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgSellPrice field.
	/// </summary>
	public void SetLdgSellPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgSellPrice field.
	/// </summary>
	public void SetLdgSellPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgSellPrice field.
	/// </summary>
	public void SetLdgSellPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgSellPrice field.
	/// </summary>
	public void SetLdgSellPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgSellPrice field.
	/// </summary>
	public void SetLdgSellPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgSellPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgSerialNo field.
	/// </summary>
	public ColumnValue GetLdgSerialNoValue()
	{
		return this.GetValue(TableUtils.LdgSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgSerialNo field.
	/// </summary>
	public string GetLdgSerialNoFieldValue()
	{
		return this.GetValue(TableUtils.LdgSerialNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgSerialNo field.
	/// </summary>
	public void SetLdgSerialNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgSerialNo field.
	/// </summary>
	public void SetLdgSerialNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgSerialNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgTrnDate field.
	/// </summary>
	public ColumnValue GetLdgTrnDateValue()
	{
		return this.GetValue(TableUtils.LdgTrnDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgTrnDate field.
	/// </summary>
	public DateTime GetLdgTrnDateFieldValue()
	{
		return this.GetValue(TableUtils.LdgTrnDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgTrnDate field.
	/// </summary>
	public void SetLdgTrnDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgTrnDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgTrnDate field.
	/// </summary>
	public void SetLdgTrnDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgTrnDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgTrnDate field.
	/// </summary>
	public void SetLdgTrnDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgTrnDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgUser field.
	/// </summary>
	public ColumnValue GetLdgUserValue()
	{
		return this.GetValue(TableUtils.LdgUserColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.LdgUser field.
	/// </summary>
	public string GetLdgUserFieldValue()
	{
		return this.GetValue(TableUtils.LdgUserColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgUser field.
	/// </summary>
	public void SetLdgUserFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgUserColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgUser field.
	/// </summary>
	public void SetLdgUserFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgUserColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerInventory_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgBin field.
	/// </summary>
	public string LdgBin
	{
		get
		{
			return this.GetValue(TableUtils.LdgBinColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgBinColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgBinSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgBinColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgBin field.
	/// </summary>
	public string LdgBinDefault
	{
		get
		{
			return TableUtils.LdgBinColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgBuyPrice field.
	/// </summary>
	public Decimal LdgBuyPrice
	{
		get
		{
			return this.GetValue(TableUtils.LdgBuyPriceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgBuyPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgBuyPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgBuyPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgBuyPrice field.
	/// </summary>
	public string LdgBuyPriceDefault
	{
		get
		{
			return TableUtils.LdgBuyPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgExported field.
	/// </summary>
	public DateTime LdgExported
	{
		get
		{
			return this.GetValue(TableUtils.LdgExportedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgExportedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgExportedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgExportedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExported field.
	/// </summary>
	public string LdgExportedDefault
	{
		get
		{
			return TableUtils.LdgExportedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgExportInclude field.
	/// </summary>
	public bool LdgExportInclude
	{
		get
		{
			return this.GetValue(TableUtils.LdgExportIncludeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.LdgExportIncludeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgExportIncludeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgExportIncludeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExportInclude field.
	/// </summary>
	public string LdgExportIncludeDefault
	{
		get
		{
			return TableUtils.LdgExportIncludeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgExportRecordChanged field.
	/// </summary>
	public bool LdgExportRecordChanged
	{
		get
		{
			return this.GetValue(TableUtils.LdgExportRecordChangedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.LdgExportRecordChangedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgExportRecordChangedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgExportRecordChangedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgExportRecordChanged field.
	/// </summary>
	public string LdgExportRecordChangedDefault
	{
		get
		{
			return TableUtils.LdgExportRecordChangedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgFormNo field.
	/// </summary>
	public Int32 LdgFormNo
	{
		get
		{
			return this.GetValue(TableUtils.LdgFormNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgFormNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgFormNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgFormNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgFormNo field.
	/// </summary>
	public string LdgFormNoDefault
	{
		get
		{
			return TableUtils.LdgFormNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgFormType field.
	/// </summary>
	public string LdgFormType
	{
		get
		{
			return this.GetValue(TableUtils.LdgFormTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgFormTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgFormTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgFormTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgFormType field.
	/// </summary>
	public string LdgFormTypeDefault
	{
		get
		{
			return TableUtils.LdgFormTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgKey field.
	/// </summary>
	public Int32 LdgKey
	{
		get
		{
			return this.GetValue(TableUtils.LdgKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgKey field.
	/// </summary>
	public string LdgKeyDefault
	{
		get
		{
			return TableUtils.LdgKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgLocation field.
	/// </summary>
	public Int32 LdgLocation
	{
		get
		{
			return this.GetValue(TableUtils.LdgLocationColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgLocationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgLocationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgLocationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgLocation field.
	/// </summary>
	public string LdgLocationDefault
	{
		get
		{
			return TableUtils.LdgLocationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgPartNo field.
	/// </summary>
	public string LdgPartNo
	{
		get
		{
			return this.GetValue(TableUtils.LdgPartNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgPartNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgPartNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgPartNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgPartNo field.
	/// </summary>
	public string LdgPartNoDefault
	{
		get
		{
			return TableUtils.LdgPartNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgQuantity field.
	/// </summary>
	public Single LdgQuantity
	{
		get
		{
			return this.GetValue(TableUtils.LdgQuantityColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgQuantityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgQuantitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgQuantityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgQuantity field.
	/// </summary>
	public string LdgQuantityDefault
	{
		get
		{
			return TableUtils.LdgQuantityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgRecDate field.
	/// </summary>
	public DateTime LdgRecDate
	{
		get
		{
			return this.GetValue(TableUtils.LdgRecDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgRecDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgRecDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgRecDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgRecDate field.
	/// </summary>
	public string LdgRecDateDefault
	{
		get
		{
			return TableUtils.LdgRecDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgReference field.
	/// </summary>
	public string LdgReference
	{
		get
		{
			return this.GetValue(TableUtils.LdgReferenceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgReferenceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgReferenceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgReferenceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgReference field.
	/// </summary>
	public string LdgReferenceDefault
	{
		get
		{
			return TableUtils.LdgReferenceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgSellPrice field.
	/// </summary>
	public Decimal LdgSellPrice
	{
		get
		{
			return this.GetValue(TableUtils.LdgSellPriceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgSellPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgSellPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgSellPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgSellPrice field.
	/// </summary>
	public string LdgSellPriceDefault
	{
		get
		{
			return TableUtils.LdgSellPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgSerialNo field.
	/// </summary>
	public string LdgSerialNo
	{
		get
		{
			return this.GetValue(TableUtils.LdgSerialNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgSerialNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgSerialNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgSerialNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgSerialNo field.
	/// </summary>
	public string LdgSerialNoDefault
	{
		get
		{
			return TableUtils.LdgSerialNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgTrnDate field.
	/// </summary>
	public DateTime LdgTrnDate
	{
		get
		{
			return this.GetValue(TableUtils.LdgTrnDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgTrnDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgTrnDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgTrnDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgTrnDate field.
	/// </summary>
	public string LdgTrnDateDefault
	{
		get
		{
			return TableUtils.LdgTrnDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.LdgUser field.
	/// </summary>
	public string LdgUser
	{
		get
		{
			return this.GetValue(TableUtils.LdgUserColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgUserColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgUserSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgUserColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.LdgUser field.
	/// </summary>
	public string LdgUserDefault
	{
		get
		{
			return TableUtils.LdgUserColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerInventory_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerInventory_.SSMA_TimeStamp field.
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
