// This class is "generated" and will be overwritten.
// Your customizations should be made in InventoryRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="InventoryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="InventoryTable"></see> class.
/// </remarks>
/// <seealso cref="InventoryTable"></seealso>
/// <seealso cref="InventoryRecord"></seealso>
public class BaseInventoryRecord : PrimaryKeyRecord
{

	public readonly static InventoryTable TableUtils = InventoryTable.Instance;

	// Constructors
 
	protected BaseInventoryRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.InventoryRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.InventoryRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.InventoryRecord_ReadRecord); 
	}

	protected BaseInventoryRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void InventoryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                InventoryRecord InventoryRec = (InventoryRecord)sender;
        if(InventoryRec != null && !InventoryRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void InventoryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                InventoryRecord InventoryRec = (InventoryRecord)sender;
        Validate_Inserting();
        if(InventoryRec != null && !InventoryRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void InventoryRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                InventoryRecord InventoryRec = (InventoryRecord)sender;
        Validate_Updating();
        if(InventoryRec != null && !InventoryRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvAvgBuyPrice field.
	/// </summary>
	public ColumnValue GetInvAvgBuyPriceValue()
	{
		return this.GetValue(TableUtils.InvAvgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvAvgBuyPrice field.
	/// </summary>
	public Decimal GetInvAvgBuyPriceFieldValue()
	{
		return this.GetValue(TableUtils.InvAvgBuyPriceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvAvgBuyPrice field.
	/// </summary>
	public void SetInvAvgBuyPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvAvgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvAvgBuyPrice field.
	/// </summary>
	public void SetInvAvgBuyPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvAvgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvAvgBuyPrice field.
	/// </summary>
	public void SetInvAvgBuyPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvAvgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvAvgBuyPrice field.
	/// </summary>
	public void SetInvAvgBuyPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvAvgBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvAvgBuyPrice field.
	/// </summary>
	public void SetInvAvgBuyPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvAvgBuyPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvBin field.
	/// </summary>
	public ColumnValue GetInvBinValue()
	{
		return this.GetValue(TableUtils.InvBinColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvBin field.
	/// </summary>
	public string GetInvBinFieldValue()
	{
		return this.GetValue(TableUtils.InvBinColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvBin field.
	/// </summary>
	public void SetInvBinFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvBinColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvBin field.
	/// </summary>
	public void SetInvBinFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvBinColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvCategory field.
	/// </summary>
	public ColumnValue GetInvCategoryValue()
	{
		return this.GetValue(TableUtils.InvCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvCategory field.
	/// </summary>
	public string GetInvCategoryFieldValue()
	{
		return this.GetValue(TableUtils.InvCategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvCategory field.
	/// </summary>
	public void SetInvCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvCategory field.
	/// </summary>
	public void SetInvCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvCategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvCustom1 field.
	/// </summary>
	public ColumnValue GetInvCustom1Value()
	{
		return this.GetValue(TableUtils.InvCustom1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvCustom1 field.
	/// </summary>
	public string GetInvCustom1FieldValue()
	{
		return this.GetValue(TableUtils.InvCustom1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvCustom1 field.
	/// </summary>
	public void SetInvCustom1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvCustom1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvCustom1 field.
	/// </summary>
	public void SetInvCustom1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvCustom1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvCustom2 field.
	/// </summary>
	public ColumnValue GetInvCustom2Value()
	{
		return this.GetValue(TableUtils.InvCustom2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvCustom2 field.
	/// </summary>
	public string GetInvCustom2FieldValue()
	{
		return this.GetValue(TableUtils.InvCustom2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvCustom2 field.
	/// </summary>
	public void SetInvCustom2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvCustom2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvCustom2 field.
	/// </summary>
	public void SetInvCustom2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvCustom2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvDateRecordAdded field.
	/// </summary>
	public ColumnValue GetInvDateRecordAddedValue()
	{
		return this.GetValue(TableUtils.InvDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvDateRecordAdded field.
	/// </summary>
	public DateTime GetInvDateRecordAddedFieldValue()
	{
		return this.GetValue(TableUtils.InvDateRecordAddedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvDateRecordAdded field.
	/// </summary>
	public void SetInvDateRecordAddedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvDateRecordAdded field.
	/// </summary>
	public void SetInvDateRecordAddedFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvDateRecordAdded field.
	/// </summary>
	public void SetInvDateRecordAddedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvDateRecordAddedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvDateRecordUpdated field.
	/// </summary>
	public ColumnValue GetInvDateRecordUpdatedValue()
	{
		return this.GetValue(TableUtils.InvDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvDateRecordUpdated field.
	/// </summary>
	public DateTime GetInvDateRecordUpdatedFieldValue()
	{
		return this.GetValue(TableUtils.InvDateRecordUpdatedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvDateRecordUpdated field.
	/// </summary>
	public void SetInvDateRecordUpdatedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvDateRecordUpdated field.
	/// </summary>
	public void SetInvDateRecordUpdatedFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvDateRecordUpdated field.
	/// </summary>
	public void SetInvDateRecordUpdatedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvDateRecordUpdatedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvExportInclude field.
	/// </summary>
	public ColumnValue GetInvExportIncludeValue()
	{
		return this.GetValue(TableUtils.InvExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvExportInclude field.
	/// </summary>
	public bool GetInvExportIncludeFieldValue()
	{
		return this.GetValue(TableUtils.InvExportIncludeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvExportInclude field.
	/// </summary>
	public void SetInvExportIncludeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvExportInclude field.
	/// </summary>
	public void SetInvExportIncludeFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvExportInclude field.
	/// </summary>
	public void SetInvExportIncludeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvExportIncludeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvExportRecordChanged field.
	/// </summary>
	public ColumnValue GetInvExportRecordChangedValue()
	{
		return this.GetValue(TableUtils.InvExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvExportRecordChanged field.
	/// </summary>
	public bool GetInvExportRecordChangedFieldValue()
	{
		return this.GetValue(TableUtils.InvExportRecordChangedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvExportRecordChanged field.
	/// </summary>
	public void SetInvExportRecordChangedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvExportRecordChanged field.
	/// </summary>
	public void SetInvExportRecordChangedFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvExportRecordChanged field.
	/// </summary>
	public void SetInvExportRecordChangedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvExportRecordChangedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvItemDesc field.
	/// </summary>
	public ColumnValue GetInvItemDescValue()
	{
		return this.GetValue(TableUtils.InvItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvItemDesc field.
	/// </summary>
	public string GetInvItemDescFieldValue()
	{
		return this.GetValue(TableUtils.InvItemDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvItemDesc field.
	/// </summary>
	public void SetInvItemDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvItemDesc field.
	/// </summary>
	public void SetInvItemDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvItemDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvKey field.
	/// </summary>
	public ColumnValue GetInvKeyValue()
	{
		return this.GetValue(TableUtils.InvKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvKey field.
	/// </summary>
	public Int32 GetInvKeyFieldValue()
	{
		return this.GetValue(TableUtils.InvKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvLastBuyPrice field.
	/// </summary>
	public ColumnValue GetInvLastBuyPriceValue()
	{
		return this.GetValue(TableUtils.InvLastBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvLastBuyPrice field.
	/// </summary>
	public Decimal GetInvLastBuyPriceFieldValue()
	{
		return this.GetValue(TableUtils.InvLastBuyPriceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLastBuyPrice field.
	/// </summary>
	public void SetInvLastBuyPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvLastBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLastBuyPrice field.
	/// </summary>
	public void SetInvLastBuyPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvLastBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLastBuyPrice field.
	/// </summary>
	public void SetInvLastBuyPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvLastBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLastBuyPrice field.
	/// </summary>
	public void SetInvLastBuyPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvLastBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLastBuyPrice field.
	/// </summary>
	public void SetInvLastBuyPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvLastBuyPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvLocation field.
	/// </summary>
	public ColumnValue GetInvLocationValue()
	{
		return this.GetValue(TableUtils.InvLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvLocation field.
	/// </summary>
	public Int32 GetInvLocationFieldValue()
	{
		return this.GetValue(TableUtils.InvLocationColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLocation field.
	/// </summary>
	public void SetInvLocationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLocation field.
	/// </summary>
	public void SetInvLocationFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLocation field.
	/// </summary>
	public void SetInvLocationFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLocation field.
	/// </summary>
	public void SetInvLocationFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLocation field.
	/// </summary>
	public void SetInvLocationFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvLocationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMake field.
	/// </summary>
	public ColumnValue GetInvMakeValue()
	{
		return this.GetValue(TableUtils.InvMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMake field.
	/// </summary>
	public string GetInvMakeFieldValue()
	{
		return this.GetValue(TableUtils.InvMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMake field.
	/// </summary>
	public void SetInvMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMake field.
	/// </summary>
	public void SetInvMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate0 field.
	/// </summary>
	public ColumnValue GetInvMarkupRate0Value()
	{
		return this.GetValue(TableUtils.InvMarkupRate0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate0 field.
	/// </summary>
	public Single GetInvMarkupRate0FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupRate0Column).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate0 field.
	/// </summary>
	public void SetInvMarkupRate0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupRate0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate0 field.
	/// </summary>
	public void SetInvMarkupRate0FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupRate0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate0 field.
	/// </summary>
	public void SetInvMarkupRate0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate0 field.
	/// </summary>
	public void SetInvMarkupRate0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate0 field.
	/// </summary>
	public void SetInvMarkupRate0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate1 field.
	/// </summary>
	public ColumnValue GetInvMarkupRate1Value()
	{
		return this.GetValue(TableUtils.InvMarkupRate1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate1 field.
	/// </summary>
	public Single GetInvMarkupRate1FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupRate1Column).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate1 field.
	/// </summary>
	public void SetInvMarkupRate1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupRate1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate1 field.
	/// </summary>
	public void SetInvMarkupRate1FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupRate1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate1 field.
	/// </summary>
	public void SetInvMarkupRate1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate1 field.
	/// </summary>
	public void SetInvMarkupRate1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate1 field.
	/// </summary>
	public void SetInvMarkupRate1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate2 field.
	/// </summary>
	public ColumnValue GetInvMarkupRate2Value()
	{
		return this.GetValue(TableUtils.InvMarkupRate2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate2 field.
	/// </summary>
	public Single GetInvMarkupRate2FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupRate2Column).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate2 field.
	/// </summary>
	public void SetInvMarkupRate2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupRate2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate2 field.
	/// </summary>
	public void SetInvMarkupRate2FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupRate2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate2 field.
	/// </summary>
	public void SetInvMarkupRate2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate2 field.
	/// </summary>
	public void SetInvMarkupRate2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate2 field.
	/// </summary>
	public void SetInvMarkupRate2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate3 field.
	/// </summary>
	public ColumnValue GetInvMarkupRate3Value()
	{
		return this.GetValue(TableUtils.InvMarkupRate3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate3 field.
	/// </summary>
	public Single GetInvMarkupRate3FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupRate3Column).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate3 field.
	/// </summary>
	public void SetInvMarkupRate3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupRate3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate3 field.
	/// </summary>
	public void SetInvMarkupRate3FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupRate3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate3 field.
	/// </summary>
	public void SetInvMarkupRate3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate3 field.
	/// </summary>
	public void SetInvMarkupRate3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate3 field.
	/// </summary>
	public void SetInvMarkupRate3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate4 field.
	/// </summary>
	public ColumnValue GetInvMarkupRate4Value()
	{
		return this.GetValue(TableUtils.InvMarkupRate4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupRate4 field.
	/// </summary>
	public Single GetInvMarkupRate4FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupRate4Column).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate4 field.
	/// </summary>
	public void SetInvMarkupRate4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupRate4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate4 field.
	/// </summary>
	public void SetInvMarkupRate4FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupRate4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate4 field.
	/// </summary>
	public void SetInvMarkupRate4FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate4 field.
	/// </summary>
	public void SetInvMarkupRate4FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate4 field.
	/// </summary>
	public void SetInvMarkupRate4FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupRate4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType0 field.
	/// </summary>
	public ColumnValue GetInvMarkupType0Value()
	{
		return this.GetValue(TableUtils.InvMarkupType0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType0 field.
	/// </summary>
	public Byte GetInvMarkupType0FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupType0Column).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType0 field.
	/// </summary>
	public void SetInvMarkupType0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupType0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType0 field.
	/// </summary>
	public void SetInvMarkupType0FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupType0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType0 field.
	/// </summary>
	public void SetInvMarkupType0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType0 field.
	/// </summary>
	public void SetInvMarkupType0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType0 field.
	/// </summary>
	public void SetInvMarkupType0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType1 field.
	/// </summary>
	public ColumnValue GetInvMarkupType1Value()
	{
		return this.GetValue(TableUtils.InvMarkupType1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType1 field.
	/// </summary>
	public Byte GetInvMarkupType1FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupType1Column).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType1 field.
	/// </summary>
	public void SetInvMarkupType1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupType1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType1 field.
	/// </summary>
	public void SetInvMarkupType1FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupType1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType1 field.
	/// </summary>
	public void SetInvMarkupType1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType1 field.
	/// </summary>
	public void SetInvMarkupType1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType1 field.
	/// </summary>
	public void SetInvMarkupType1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType2 field.
	/// </summary>
	public ColumnValue GetInvMarkupType2Value()
	{
		return this.GetValue(TableUtils.InvMarkupType2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType2 field.
	/// </summary>
	public Byte GetInvMarkupType2FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupType2Column).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType2 field.
	/// </summary>
	public void SetInvMarkupType2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupType2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType2 field.
	/// </summary>
	public void SetInvMarkupType2FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupType2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType2 field.
	/// </summary>
	public void SetInvMarkupType2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType2 field.
	/// </summary>
	public void SetInvMarkupType2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType2 field.
	/// </summary>
	public void SetInvMarkupType2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType3 field.
	/// </summary>
	public ColumnValue GetInvMarkupType3Value()
	{
		return this.GetValue(TableUtils.InvMarkupType3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType3 field.
	/// </summary>
	public Byte GetInvMarkupType3FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupType3Column).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType3 field.
	/// </summary>
	public void SetInvMarkupType3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupType3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType3 field.
	/// </summary>
	public void SetInvMarkupType3FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupType3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType3 field.
	/// </summary>
	public void SetInvMarkupType3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType3 field.
	/// </summary>
	public void SetInvMarkupType3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType3 field.
	/// </summary>
	public void SetInvMarkupType3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType4 field.
	/// </summary>
	public ColumnValue GetInvMarkupType4Value()
	{
		return this.GetValue(TableUtils.InvMarkupType4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMarkupType4 field.
	/// </summary>
	public Byte GetInvMarkupType4FieldValue()
	{
		return this.GetValue(TableUtils.InvMarkupType4Column).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType4 field.
	/// </summary>
	public void SetInvMarkupType4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMarkupType4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType4 field.
	/// </summary>
	public void SetInvMarkupType4FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMarkupType4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType4 field.
	/// </summary>
	public void SetInvMarkupType4FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType4 field.
	/// </summary>
	public void SetInvMarkupType4FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType4 field.
	/// </summary>
	public void SetInvMarkupType4FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMarkupType4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMinOrder field.
	/// </summary>
	public ColumnValue GetInvMinOrderValue()
	{
		return this.GetValue(TableUtils.InvMinOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMinOrder field.
	/// </summary>
	public Single GetInvMinOrderFieldValue()
	{
		return this.GetValue(TableUtils.InvMinOrderColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinOrder field.
	/// </summary>
	public void SetInvMinOrderFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMinOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinOrder field.
	/// </summary>
	public void SetInvMinOrderFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMinOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinOrder field.
	/// </summary>
	public void SetInvMinOrderFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMinOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinOrder field.
	/// </summary>
	public void SetInvMinOrderFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMinOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinOrder field.
	/// </summary>
	public void SetInvMinOrderFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMinOrderColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMinRequired field.
	/// </summary>
	public ColumnValue GetInvMinRequiredValue()
	{
		return this.GetValue(TableUtils.InvMinRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvMinRequired field.
	/// </summary>
	public Single GetInvMinRequiredFieldValue()
	{
		return this.GetValue(TableUtils.InvMinRequiredColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinRequired field.
	/// </summary>
	public void SetInvMinRequiredFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvMinRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinRequired field.
	/// </summary>
	public void SetInvMinRequiredFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvMinRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinRequired field.
	/// </summary>
	public void SetInvMinRequiredFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMinRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinRequired field.
	/// </summary>
	public void SetInvMinRequiredFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMinRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinRequired field.
	/// </summary>
	public void SetInvMinRequiredFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvMinRequiredColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvModels field.
	/// </summary>
	public ColumnValue GetInvModelsValue()
	{
		return this.GetValue(TableUtils.InvModelsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvModels field.
	/// </summary>
	public string GetInvModelsFieldValue()
	{
		return this.GetValue(TableUtils.InvModelsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvModels field.
	/// </summary>
	public void SetInvModelsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvModelsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvModels field.
	/// </summary>
	public void SetInvModelsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvModelsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvNonStockItem field.
	/// </summary>
	public ColumnValue GetInvNonStockItemValue()
	{
		return this.GetValue(TableUtils.InvNonStockItemColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvNonStockItem field.
	/// </summary>
	public bool GetInvNonStockItemFieldValue()
	{
		return this.GetValue(TableUtils.InvNonStockItemColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvNonStockItem field.
	/// </summary>
	public void SetInvNonStockItemFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvNonStockItemColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvNonStockItem field.
	/// </summary>
	public void SetInvNonStockItemFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvNonStockItemColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvNonStockItem field.
	/// </summary>
	public void SetInvNonStockItemFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvNonStockItemColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvNotes field.
	/// </summary>
	public ColumnValue GetInvNotesValue()
	{
		return this.GetValue(TableUtils.InvNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvNotes field.
	/// </summary>
	public string GetInvNotesFieldValue()
	{
		return this.GetValue(TableUtils.InvNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvNotes field.
	/// </summary>
	public void SetInvNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvNotes field.
	/// </summary>
	public void SetInvNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvPartNo field.
	/// </summary>
	public ColumnValue GetInvPartNoValue()
	{
		return this.GetValue(TableUtils.InvPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvPartNo field.
	/// </summary>
	public string GetInvPartNoFieldValue()
	{
		return this.GetValue(TableUtils.InvPartNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPartNo field.
	/// </summary>
	public void SetInvPartNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPartNo field.
	/// </summary>
	public void SetInvPartNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvPartNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvPickQuantity field.
	/// </summary>
	public ColumnValue GetInvPickQuantityValue()
	{
		return this.GetValue(TableUtils.InvPickQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvPickQuantity field.
	/// </summary>
	public Single GetInvPickQuantityFieldValue()
	{
		return this.GetValue(TableUtils.InvPickQuantityColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPickQuantity field.
	/// </summary>
	public void SetInvPickQuantityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvPickQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPickQuantity field.
	/// </summary>
	public void SetInvPickQuantityFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvPickQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPickQuantity field.
	/// </summary>
	public void SetInvPickQuantityFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvPickQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPickQuantity field.
	/// </summary>
	public void SetInvPickQuantityFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvPickQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPickQuantity field.
	/// </summary>
	public void SetInvPickQuantityFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvPickQuantityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvPicturePath field.
	/// </summary>
	public ColumnValue GetInvPicturePathValue()
	{
		return this.GetValue(TableUtils.InvPicturePathColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvPicturePath field.
	/// </summary>
	public string GetInvPicturePathFieldValue()
	{
		return this.GetValue(TableUtils.InvPicturePathColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPicturePath field.
	/// </summary>
	public void SetInvPicturePathFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvPicturePathColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPicturePath field.
	/// </summary>
	public void SetInvPicturePathFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvPicturePathColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvPrevBuyPrice field.
	/// </summary>
	public ColumnValue GetInvPrevBuyPriceValue()
	{
		return this.GetValue(TableUtils.InvPrevBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvPrevBuyPrice field.
	/// </summary>
	public Decimal GetInvPrevBuyPriceFieldValue()
	{
		return this.GetValue(TableUtils.InvPrevBuyPriceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPrevBuyPrice field.
	/// </summary>
	public void SetInvPrevBuyPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvPrevBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPrevBuyPrice field.
	/// </summary>
	public void SetInvPrevBuyPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvPrevBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPrevBuyPrice field.
	/// </summary>
	public void SetInvPrevBuyPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvPrevBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPrevBuyPrice field.
	/// </summary>
	public void SetInvPrevBuyPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvPrevBuyPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPrevBuyPrice field.
	/// </summary>
	public void SetInvPrevBuyPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvPrevBuyPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvQuantity field.
	/// </summary>
	public ColumnValue GetInvQuantityValue()
	{
		return this.GetValue(TableUtils.InvQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvQuantity field.
	/// </summary>
	public Single GetInvQuantityFieldValue()
	{
		return this.GetValue(TableUtils.InvQuantityColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvQuantity field.
	/// </summary>
	public void SetInvQuantityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvQuantity field.
	/// </summary>
	public void SetInvQuantityFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvQuantity field.
	/// </summary>
	public void SetInvQuantityFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvQuantity field.
	/// </summary>
	public void SetInvQuantityFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvQuantity field.
	/// </summary>
	public void SetInvQuantityFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvQuantityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReference1 field.
	/// </summary>
	public ColumnValue GetInvReference1Value()
	{
		return this.GetValue(TableUtils.InvReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReference1 field.
	/// </summary>
	public string GetInvReference1FieldValue()
	{
		return this.GetValue(TableUtils.InvReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference1 field.
	/// </summary>
	public void SetInvReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference1 field.
	/// </summary>
	public void SetInvReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReference2 field.
	/// </summary>
	public ColumnValue GetInvReference2Value()
	{
		return this.GetValue(TableUtils.InvReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReference2 field.
	/// </summary>
	public string GetInvReference2FieldValue()
	{
		return this.GetValue(TableUtils.InvReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference2 field.
	/// </summary>
	public void SetInvReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference2 field.
	/// </summary>
	public void SetInvReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReference3 field.
	/// </summary>
	public ColumnValue GetInvReference3Value()
	{
		return this.GetValue(TableUtils.InvReference3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReference3 field.
	/// </summary>
	public string GetInvReference3FieldValue()
	{
		return this.GetValue(TableUtils.InvReference3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference3 field.
	/// </summary>
	public void SetInvReference3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvReference3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference3 field.
	/// </summary>
	public void SetInvReference3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvReference3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReference4 field.
	/// </summary>
	public ColumnValue GetInvReference4Value()
	{
		return this.GetValue(TableUtils.InvReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReference4 field.
	/// </summary>
	public string GetInvReference4FieldValue()
	{
		return this.GetValue(TableUtils.InvReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference4 field.
	/// </summary>
	public void SetInvReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference4 field.
	/// </summary>
	public void SetInvReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReplacement field.
	/// </summary>
	public ColumnValue GetInvReplacementValue()
	{
		return this.GetValue(TableUtils.InvReplacementColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvReplacement field.
	/// </summary>
	public string GetInvReplacementFieldValue()
	{
		return this.GetValue(TableUtils.InvReplacementColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReplacement field.
	/// </summary>
	public void SetInvReplacementFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvReplacementColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReplacement field.
	/// </summary>
	public void SetInvReplacementFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvReplacementColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice0 field.
	/// </summary>
	public ColumnValue GetInvSellPrice0Value()
	{
		return this.GetValue(TableUtils.InvSellPrice0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice0 field.
	/// </summary>
	public Decimal GetInvSellPrice0FieldValue()
	{
		return this.GetValue(TableUtils.InvSellPrice0Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice0 field.
	/// </summary>
	public void SetInvSellPrice0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvSellPrice0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice0 field.
	/// </summary>
	public void SetInvSellPrice0FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvSellPrice0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice0 field.
	/// </summary>
	public void SetInvSellPrice0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice0 field.
	/// </summary>
	public void SetInvSellPrice0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice0 field.
	/// </summary>
	public void SetInvSellPrice0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice1 field.
	/// </summary>
	public ColumnValue GetInvSellPrice1Value()
	{
		return this.GetValue(TableUtils.InvSellPrice1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice1 field.
	/// </summary>
	public Decimal GetInvSellPrice1FieldValue()
	{
		return this.GetValue(TableUtils.InvSellPrice1Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice1 field.
	/// </summary>
	public void SetInvSellPrice1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvSellPrice1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice1 field.
	/// </summary>
	public void SetInvSellPrice1FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvSellPrice1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice1 field.
	/// </summary>
	public void SetInvSellPrice1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice1 field.
	/// </summary>
	public void SetInvSellPrice1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice1 field.
	/// </summary>
	public void SetInvSellPrice1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice2 field.
	/// </summary>
	public ColumnValue GetInvSellPrice2Value()
	{
		return this.GetValue(TableUtils.InvSellPrice2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice2 field.
	/// </summary>
	public Decimal GetInvSellPrice2FieldValue()
	{
		return this.GetValue(TableUtils.InvSellPrice2Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice2 field.
	/// </summary>
	public void SetInvSellPrice2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvSellPrice2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice2 field.
	/// </summary>
	public void SetInvSellPrice2FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvSellPrice2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice2 field.
	/// </summary>
	public void SetInvSellPrice2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice2 field.
	/// </summary>
	public void SetInvSellPrice2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice2 field.
	/// </summary>
	public void SetInvSellPrice2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice3 field.
	/// </summary>
	public ColumnValue GetInvSellPrice3Value()
	{
		return this.GetValue(TableUtils.InvSellPrice3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice3 field.
	/// </summary>
	public Decimal GetInvSellPrice3FieldValue()
	{
		return this.GetValue(TableUtils.InvSellPrice3Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice3 field.
	/// </summary>
	public void SetInvSellPrice3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvSellPrice3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice3 field.
	/// </summary>
	public void SetInvSellPrice3FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvSellPrice3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice3 field.
	/// </summary>
	public void SetInvSellPrice3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice3 field.
	/// </summary>
	public void SetInvSellPrice3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice3 field.
	/// </summary>
	public void SetInvSellPrice3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice4 field.
	/// </summary>
	public ColumnValue GetInvSellPrice4Value()
	{
		return this.GetValue(TableUtils.InvSellPrice4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvSellPrice4 field.
	/// </summary>
	public Decimal GetInvSellPrice4FieldValue()
	{
		return this.GetValue(TableUtils.InvSellPrice4Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice4 field.
	/// </summary>
	public void SetInvSellPrice4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvSellPrice4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice4 field.
	/// </summary>
	public void SetInvSellPrice4FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvSellPrice4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice4 field.
	/// </summary>
	public void SetInvSellPrice4FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice4 field.
	/// </summary>
	public void SetInvSellPrice4FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice4 field.
	/// </summary>
	public void SetInvSellPrice4FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvSellPrice4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvShare field.
	/// </summary>
	public ColumnValue GetInvShareValue()
	{
		return this.GetValue(TableUtils.InvShareColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvShare field.
	/// </summary>
	public bool GetInvShareFieldValue()
	{
		return this.GetValue(TableUtils.InvShareColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvShare field.
	/// </summary>
	public void SetInvShareFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvShareColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvShare field.
	/// </summary>
	public void SetInvShareFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvShareColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvShare field.
	/// </summary>
	public void SetInvShareFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvShareColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvStatus field.
	/// </summary>
	public ColumnValue GetInvStatusValue()
	{
		return this.GetValue(TableUtils.InvStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvStatus field.
	/// </summary>
	public Byte GetInvStatusFieldValue()
	{
		return this.GetValue(TableUtils.InvStatusColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvStatus field.
	/// </summary>
	public void SetInvStatusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvStatus field.
	/// </summary>
	public void SetInvStatusFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvStatus field.
	/// </summary>
	public void SetInvStatusFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvStatus field.
	/// </summary>
	public void SetInvStatusFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvStatus field.
	/// </summary>
	public void SetInvStatusFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvStatusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendNo1 field.
	/// </summary>
	public ColumnValue GetInvVendNo1Value()
	{
		return this.GetValue(TableUtils.InvVendNo1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendNo1 field.
	/// </summary>
	public Int32 GetInvVendNo1FieldValue()
	{
		return this.GetValue(TableUtils.InvVendNo1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo1 field.
	/// </summary>
	public void SetInvVendNo1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvVendNo1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo1 field.
	/// </summary>
	public void SetInvVendNo1FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvVendNo1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo1 field.
	/// </summary>
	public void SetInvVendNo1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendNo1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo1 field.
	/// </summary>
	public void SetInvVendNo1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendNo1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo1 field.
	/// </summary>
	public void SetInvVendNo1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendNo1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendNo2 field.
	/// </summary>
	public ColumnValue GetInvVendNo2Value()
	{
		return this.GetValue(TableUtils.InvVendNo2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendNo2 field.
	/// </summary>
	public Int32 GetInvVendNo2FieldValue()
	{
		return this.GetValue(TableUtils.InvVendNo2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo2 field.
	/// </summary>
	public void SetInvVendNo2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvVendNo2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo2 field.
	/// </summary>
	public void SetInvVendNo2FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvVendNo2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo2 field.
	/// </summary>
	public void SetInvVendNo2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendNo2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo2 field.
	/// </summary>
	public void SetInvVendNo2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendNo2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo2 field.
	/// </summary>
	public void SetInvVendNo2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendNo2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendNo3 field.
	/// </summary>
	public ColumnValue GetInvVendNo3Value()
	{
		return this.GetValue(TableUtils.InvVendNo3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendNo3 field.
	/// </summary>
	public Int32 GetInvVendNo3FieldValue()
	{
		return this.GetValue(TableUtils.InvVendNo3Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo3 field.
	/// </summary>
	public void SetInvVendNo3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvVendNo3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo3 field.
	/// </summary>
	public void SetInvVendNo3FieldValue(string val)
	{
		this.SetString(val, TableUtils.InvVendNo3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo3 field.
	/// </summary>
	public void SetInvVendNo3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendNo3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo3 field.
	/// </summary>
	public void SetInvVendNo3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendNo3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo3 field.
	/// </summary>
	public void SetInvVendNo3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendNo3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendorPartNo1 field.
	/// </summary>
	public ColumnValue GetInvVendorPartNo1Value()
	{
		return this.GetValue(TableUtils.InvVendorPartNo1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendorPartNo1 field.
	/// </summary>
	public string GetInvVendorPartNo1FieldValue()
	{
		return this.GetValue(TableUtils.InvVendorPartNo1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendorPartNo1 field.
	/// </summary>
	public void SetInvVendorPartNo1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvVendorPartNo1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendorPartNo1 field.
	/// </summary>
	public void SetInvVendorPartNo1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendorPartNo1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendorPartNo2 field.
	/// </summary>
	public ColumnValue GetInvVendorPartNo2Value()
	{
		return this.GetValue(TableUtils.InvVendorPartNo2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendorPartNo2 field.
	/// </summary>
	public string GetInvVendorPartNo2FieldValue()
	{
		return this.GetValue(TableUtils.InvVendorPartNo2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendorPartNo2 field.
	/// </summary>
	public void SetInvVendorPartNo2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvVendorPartNo2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendorPartNo2 field.
	/// </summary>
	public void SetInvVendorPartNo2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendorPartNo2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendorPartNo3 field.
	/// </summary>
	public ColumnValue GetInvVendorPartNo3Value()
	{
		return this.GetValue(TableUtils.InvVendorPartNo3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.InvVendorPartNo3 field.
	/// </summary>
	public string GetInvVendorPartNo3FieldValue()
	{
		return this.GetValue(TableUtils.InvVendorPartNo3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendorPartNo3 field.
	/// </summary>
	public void SetInvVendorPartNo3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvVendorPartNo3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendorPartNo3 field.
	/// </summary>
	public void SetInvVendorPartNo3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvVendorPartNo3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.LastExtraction field.
	/// </summary>
	public ColumnValue GetLastExtractionValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.LastExtraction field.
	/// </summary>
	public bool GetLastExtractionFieldValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(string val)
	{
		this.SetString(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastExtractionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.Inventory_active field.
	/// </summary>
	public ColumnValue GetInventory_activeValue()
	{
		return this.GetValue(TableUtils.Inventory_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Inventory_.Inventory_active field.
	/// </summary>
	public bool GetInventory_activeFieldValue()
	{
		return this.GetValue(TableUtils.Inventory_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.Inventory_active field.
	/// </summary>
	public void SetInventory_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Inventory_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.Inventory_active field.
	/// </summary>
	public void SetInventory_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.Inventory_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.Inventory_active field.
	/// </summary>
	public void SetInventory_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Inventory_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvAvgBuyPrice field.
	/// </summary>
	public Decimal InvAvgBuyPrice
	{
		get
		{
			return this.GetValue(TableUtils.InvAvgBuyPriceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvAvgBuyPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvAvgBuyPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvAvgBuyPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvAvgBuyPrice field.
	/// </summary>
	public string InvAvgBuyPriceDefault
	{
		get
		{
			return TableUtils.InvAvgBuyPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvBin field.
	/// </summary>
	public string InvBin
	{
		get
		{
			return this.GetValue(TableUtils.InvBinColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvBinColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvBinSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvBinColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvBin field.
	/// </summary>
	public string InvBinDefault
	{
		get
		{
			return TableUtils.InvBinColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvCategory field.
	/// </summary>
	public string InvCategory
	{
		get
		{
			return this.GetValue(TableUtils.InvCategoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvCategoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvCategorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvCategoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvCategory field.
	/// </summary>
	public string InvCategoryDefault
	{
		get
		{
			return TableUtils.InvCategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvCustom1 field.
	/// </summary>
	public string InvCustom1
	{
		get
		{
			return this.GetValue(TableUtils.InvCustom1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvCustom1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvCustom1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvCustom1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvCustom1 field.
	/// </summary>
	public string InvCustom1Default
	{
		get
		{
			return TableUtils.InvCustom1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvCustom2 field.
	/// </summary>
	public string InvCustom2
	{
		get
		{
			return this.GetValue(TableUtils.InvCustom2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvCustom2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvCustom2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvCustom2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvCustom2 field.
	/// </summary>
	public string InvCustom2Default
	{
		get
		{
			return TableUtils.InvCustom2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvDateRecordAdded field.
	/// </summary>
	public DateTime InvDateRecordAdded
	{
		get
		{
			return this.GetValue(TableUtils.InvDateRecordAddedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvDateRecordAddedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvDateRecordAddedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvDateRecordAddedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvDateRecordAdded field.
	/// </summary>
	public string InvDateRecordAddedDefault
	{
		get
		{
			return TableUtils.InvDateRecordAddedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvDateRecordUpdated field.
	/// </summary>
	public DateTime InvDateRecordUpdated
	{
		get
		{
			return this.GetValue(TableUtils.InvDateRecordUpdatedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvDateRecordUpdatedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvDateRecordUpdatedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvDateRecordUpdatedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvDateRecordUpdated field.
	/// </summary>
	public string InvDateRecordUpdatedDefault
	{
		get
		{
			return TableUtils.InvDateRecordUpdatedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvExportInclude field.
	/// </summary>
	public bool InvExportInclude
	{
		get
		{
			return this.GetValue(TableUtils.InvExportIncludeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.InvExportIncludeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvExportIncludeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvExportIncludeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvExportInclude field.
	/// </summary>
	public string InvExportIncludeDefault
	{
		get
		{
			return TableUtils.InvExportIncludeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvExportRecordChanged field.
	/// </summary>
	public bool InvExportRecordChanged
	{
		get
		{
			return this.GetValue(TableUtils.InvExportRecordChangedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.InvExportRecordChangedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvExportRecordChangedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvExportRecordChangedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvExportRecordChanged field.
	/// </summary>
	public string InvExportRecordChangedDefault
	{
		get
		{
			return TableUtils.InvExportRecordChangedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvItemDesc field.
	/// </summary>
	public string InvItemDesc
	{
		get
		{
			return this.GetValue(TableUtils.InvItemDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvItemDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvItemDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvItemDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvItemDesc field.
	/// </summary>
	public string InvItemDescDefault
	{
		get
		{
			return TableUtils.InvItemDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvKey field.
	/// </summary>
	public Int32 InvKey
	{
		get
		{
			return this.GetValue(TableUtils.InvKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvKey field.
	/// </summary>
	public string InvKeyDefault
	{
		get
		{
			return TableUtils.InvKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvLastBuyPrice field.
	/// </summary>
	public Decimal InvLastBuyPrice
	{
		get
		{
			return this.GetValue(TableUtils.InvLastBuyPriceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvLastBuyPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvLastBuyPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvLastBuyPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLastBuyPrice field.
	/// </summary>
	public string InvLastBuyPriceDefault
	{
		get
		{
			return TableUtils.InvLastBuyPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvLocation field.
	/// </summary>
	public Int32 InvLocation
	{
		get
		{
			return this.GetValue(TableUtils.InvLocationColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvLocationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvLocationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvLocationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvLocation field.
	/// </summary>
	public string InvLocationDefault
	{
		get
		{
			return TableUtils.InvLocationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMake field.
	/// </summary>
	public string InvMake
	{
		get
		{
			return this.GetValue(TableUtils.InvMakeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMakeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMake field.
	/// </summary>
	public string InvMakeDefault
	{
		get
		{
			return TableUtils.InvMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupRate0 field.
	/// </summary>
	public Single InvMarkupRate0
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupRate0Column).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupRate0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupRate0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupRate0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate0 field.
	/// </summary>
	public string InvMarkupRate0Default
	{
		get
		{
			return TableUtils.InvMarkupRate0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupRate1 field.
	/// </summary>
	public Single InvMarkupRate1
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupRate1Column).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupRate1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupRate1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupRate1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate1 field.
	/// </summary>
	public string InvMarkupRate1Default
	{
		get
		{
			return TableUtils.InvMarkupRate1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupRate2 field.
	/// </summary>
	public Single InvMarkupRate2
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupRate2Column).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupRate2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupRate2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupRate2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate2 field.
	/// </summary>
	public string InvMarkupRate2Default
	{
		get
		{
			return TableUtils.InvMarkupRate2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupRate3 field.
	/// </summary>
	public Single InvMarkupRate3
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupRate3Column).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupRate3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupRate3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupRate3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate3 field.
	/// </summary>
	public string InvMarkupRate3Default
	{
		get
		{
			return TableUtils.InvMarkupRate3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupRate4 field.
	/// </summary>
	public Single InvMarkupRate4
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupRate4Column).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupRate4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupRate4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupRate4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupRate4 field.
	/// </summary>
	public string InvMarkupRate4Default
	{
		get
		{
			return TableUtils.InvMarkupRate4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupType0 field.
	/// </summary>
	public Byte InvMarkupType0
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupType0Column).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupType0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupType0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupType0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType0 field.
	/// </summary>
	public string InvMarkupType0Default
	{
		get
		{
			return TableUtils.InvMarkupType0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupType1 field.
	/// </summary>
	public Byte InvMarkupType1
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupType1Column).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupType1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupType1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupType1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType1 field.
	/// </summary>
	public string InvMarkupType1Default
	{
		get
		{
			return TableUtils.InvMarkupType1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupType2 field.
	/// </summary>
	public Byte InvMarkupType2
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupType2Column).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupType2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupType2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupType2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType2 field.
	/// </summary>
	public string InvMarkupType2Default
	{
		get
		{
			return TableUtils.InvMarkupType2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupType3 field.
	/// </summary>
	public Byte InvMarkupType3
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupType3Column).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupType3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupType3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupType3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType3 field.
	/// </summary>
	public string InvMarkupType3Default
	{
		get
		{
			return TableUtils.InvMarkupType3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMarkupType4 field.
	/// </summary>
	public Byte InvMarkupType4
	{
		get
		{
			return this.GetValue(TableUtils.InvMarkupType4Column).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMarkupType4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMarkupType4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMarkupType4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMarkupType4 field.
	/// </summary>
	public string InvMarkupType4Default
	{
		get
		{
			return TableUtils.InvMarkupType4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMinOrder field.
	/// </summary>
	public Single InvMinOrder
	{
		get
		{
			return this.GetValue(TableUtils.InvMinOrderColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMinOrderColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMinOrderSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMinOrderColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinOrder field.
	/// </summary>
	public string InvMinOrderDefault
	{
		get
		{
			return TableUtils.InvMinOrderColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvMinRequired field.
	/// </summary>
	public Single InvMinRequired
	{
		get
		{
			return this.GetValue(TableUtils.InvMinRequiredColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvMinRequiredColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvMinRequiredSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvMinRequiredColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvMinRequired field.
	/// </summary>
	public string InvMinRequiredDefault
	{
		get
		{
			return TableUtils.InvMinRequiredColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvModels field.
	/// </summary>
	public string InvModels
	{
		get
		{
			return this.GetValue(TableUtils.InvModelsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvModelsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvModelsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvModelsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvModels field.
	/// </summary>
	public string InvModelsDefault
	{
		get
		{
			return TableUtils.InvModelsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvNonStockItem field.
	/// </summary>
	public bool InvNonStockItem
	{
		get
		{
			return this.GetValue(TableUtils.InvNonStockItemColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.InvNonStockItemColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvNonStockItemSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvNonStockItemColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvNonStockItem field.
	/// </summary>
	public string InvNonStockItemDefault
	{
		get
		{
			return TableUtils.InvNonStockItemColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvNotes field.
	/// </summary>
	public string InvNotes
	{
		get
		{
			return this.GetValue(TableUtils.InvNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvNotes field.
	/// </summary>
	public string InvNotesDefault
	{
		get
		{
			return TableUtils.InvNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvPartNo field.
	/// </summary>
	public string InvPartNo
	{
		get
		{
			return this.GetValue(TableUtils.InvPartNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvPartNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvPartNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvPartNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPartNo field.
	/// </summary>
	public string InvPartNoDefault
	{
		get
		{
			return TableUtils.InvPartNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvPickQuantity field.
	/// </summary>
	public Single InvPickQuantity
	{
		get
		{
			return this.GetValue(TableUtils.InvPickQuantityColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvPickQuantityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvPickQuantitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvPickQuantityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPickQuantity field.
	/// </summary>
	public string InvPickQuantityDefault
	{
		get
		{
			return TableUtils.InvPickQuantityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvPicturePath field.
	/// </summary>
	public string InvPicturePath
	{
		get
		{
			return this.GetValue(TableUtils.InvPicturePathColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvPicturePathColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvPicturePathSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvPicturePathColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPicturePath field.
	/// </summary>
	public string InvPicturePathDefault
	{
		get
		{
			return TableUtils.InvPicturePathColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvPrevBuyPrice field.
	/// </summary>
	public Decimal InvPrevBuyPrice
	{
		get
		{
			return this.GetValue(TableUtils.InvPrevBuyPriceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvPrevBuyPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvPrevBuyPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvPrevBuyPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvPrevBuyPrice field.
	/// </summary>
	public string InvPrevBuyPriceDefault
	{
		get
		{
			return TableUtils.InvPrevBuyPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvQuantity field.
	/// </summary>
	public Single InvQuantity
	{
		get
		{
			return this.GetValue(TableUtils.InvQuantityColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvQuantityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvQuantitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvQuantityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvQuantity field.
	/// </summary>
	public string InvQuantityDefault
	{
		get
		{
			return TableUtils.InvQuantityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvReference1 field.
	/// </summary>
	public string InvReference1
	{
		get
		{
			return this.GetValue(TableUtils.InvReference1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvReference1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvReference1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvReference1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference1 field.
	/// </summary>
	public string InvReference1Default
	{
		get
		{
			return TableUtils.InvReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvReference2 field.
	/// </summary>
	public string InvReference2
	{
		get
		{
			return this.GetValue(TableUtils.InvReference2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvReference2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvReference2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvReference2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference2 field.
	/// </summary>
	public string InvReference2Default
	{
		get
		{
			return TableUtils.InvReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvReference3 field.
	/// </summary>
	public string InvReference3
	{
		get
		{
			return this.GetValue(TableUtils.InvReference3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvReference3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvReference3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvReference3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference3 field.
	/// </summary>
	public string InvReference3Default
	{
		get
		{
			return TableUtils.InvReference3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvReference4 field.
	/// </summary>
	public string InvReference4
	{
		get
		{
			return this.GetValue(TableUtils.InvReference4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvReference4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvReference4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvReference4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReference4 field.
	/// </summary>
	public string InvReference4Default
	{
		get
		{
			return TableUtils.InvReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvReplacement field.
	/// </summary>
	public string InvReplacement
	{
		get
		{
			return this.GetValue(TableUtils.InvReplacementColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvReplacementColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvReplacementSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvReplacementColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvReplacement field.
	/// </summary>
	public string InvReplacementDefault
	{
		get
		{
			return TableUtils.InvReplacementColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvSellPrice0 field.
	/// </summary>
	public Decimal InvSellPrice0
	{
		get
		{
			return this.GetValue(TableUtils.InvSellPrice0Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvSellPrice0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvSellPrice0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvSellPrice0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice0 field.
	/// </summary>
	public string InvSellPrice0Default
	{
		get
		{
			return TableUtils.InvSellPrice0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvSellPrice1 field.
	/// </summary>
	public Decimal InvSellPrice1
	{
		get
		{
			return this.GetValue(TableUtils.InvSellPrice1Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvSellPrice1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvSellPrice1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvSellPrice1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice1 field.
	/// </summary>
	public string InvSellPrice1Default
	{
		get
		{
			return TableUtils.InvSellPrice1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvSellPrice2 field.
	/// </summary>
	public Decimal InvSellPrice2
	{
		get
		{
			return this.GetValue(TableUtils.InvSellPrice2Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvSellPrice2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvSellPrice2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvSellPrice2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice2 field.
	/// </summary>
	public string InvSellPrice2Default
	{
		get
		{
			return TableUtils.InvSellPrice2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvSellPrice3 field.
	/// </summary>
	public Decimal InvSellPrice3
	{
		get
		{
			return this.GetValue(TableUtils.InvSellPrice3Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvSellPrice3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvSellPrice3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvSellPrice3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice3 field.
	/// </summary>
	public string InvSellPrice3Default
	{
		get
		{
			return TableUtils.InvSellPrice3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvSellPrice4 field.
	/// </summary>
	public Decimal InvSellPrice4
	{
		get
		{
			return this.GetValue(TableUtils.InvSellPrice4Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvSellPrice4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvSellPrice4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvSellPrice4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvSellPrice4 field.
	/// </summary>
	public string InvSellPrice4Default
	{
		get
		{
			return TableUtils.InvSellPrice4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvShare field.
	/// </summary>
	public bool InvShare
	{
		get
		{
			return this.GetValue(TableUtils.InvShareColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.InvShareColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvShareSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvShareColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvShare field.
	/// </summary>
	public string InvShareDefault
	{
		get
		{
			return TableUtils.InvShareColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvStatus field.
	/// </summary>
	public Byte InvStatus
	{
		get
		{
			return this.GetValue(TableUtils.InvStatusColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvStatusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvStatusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvStatusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvStatus field.
	/// </summary>
	public string InvStatusDefault
	{
		get
		{
			return TableUtils.InvStatusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvVendNo1 field.
	/// </summary>
	public Int32 InvVendNo1
	{
		get
		{
			return this.GetValue(TableUtils.InvVendNo1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvVendNo1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvVendNo1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvVendNo1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo1 field.
	/// </summary>
	public string InvVendNo1Default
	{
		get
		{
			return TableUtils.InvVendNo1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvVendNo2 field.
	/// </summary>
	public Int32 InvVendNo2
	{
		get
		{
			return this.GetValue(TableUtils.InvVendNo2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvVendNo2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvVendNo2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvVendNo2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo2 field.
	/// </summary>
	public string InvVendNo2Default
	{
		get
		{
			return TableUtils.InvVendNo2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvVendNo3 field.
	/// </summary>
	public Int32 InvVendNo3
	{
		get
		{
			return this.GetValue(TableUtils.InvVendNo3Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvVendNo3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvVendNo3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvVendNo3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendNo3 field.
	/// </summary>
	public string InvVendNo3Default
	{
		get
		{
			return TableUtils.InvVendNo3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvVendorPartNo1 field.
	/// </summary>
	public string InvVendorPartNo1
	{
		get
		{
			return this.GetValue(TableUtils.InvVendorPartNo1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvVendorPartNo1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvVendorPartNo1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvVendorPartNo1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendorPartNo1 field.
	/// </summary>
	public string InvVendorPartNo1Default
	{
		get
		{
			return TableUtils.InvVendorPartNo1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvVendorPartNo2 field.
	/// </summary>
	public string InvVendorPartNo2
	{
		get
		{
			return this.GetValue(TableUtils.InvVendorPartNo2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvVendorPartNo2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvVendorPartNo2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvVendorPartNo2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendorPartNo2 field.
	/// </summary>
	public string InvVendorPartNo2Default
	{
		get
		{
			return TableUtils.InvVendorPartNo2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.InvVendorPartNo3 field.
	/// </summary>
	public string InvVendorPartNo3
	{
		get
		{
			return this.GetValue(TableUtils.InvVendorPartNo3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvVendorPartNo3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvVendorPartNo3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvVendorPartNo3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.InvVendorPartNo3 field.
	/// </summary>
	public string InvVendorPartNo3Default
	{
		get
		{
			return TableUtils.InvVendorPartNo3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.LastExtraction field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.LastExtraction field.
	/// </summary>
	public string LastExtractionDefault
	{
		get
		{
			return TableUtils.LastExtractionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Inventory_.Inventory_active field.
	/// </summary>
	public bool Inventory_active
	{
		get
		{
			return this.GetValue(TableUtils.Inventory_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Inventory_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Inventory_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Inventory_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Inventory_.Inventory_active field.
	/// </summary>
	public string Inventory_activeDefault
	{
		get
		{
			return TableUtils.Inventory_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
