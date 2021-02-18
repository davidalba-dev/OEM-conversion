// This class is "generated" and will be overwritten.
// Your customizations should be made in RepairOrderHistoryRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="RepairOrderHistoryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RepairOrderHistoryView"></see> class.
/// </remarks>
/// <seealso cref="RepairOrderHistoryView"></seealso>
/// <seealso cref="RepairOrderHistoryRecord"></seealso>
public class BaseRepairOrderHistoryRecord : KeylessRecord
{

	public readonly static RepairOrderHistoryView TableUtils = RepairOrderHistoryView.Instance;

	// Constructors
 
	protected BaseRepairOrderHistoryRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.RepairOrderHistoryRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.RepairOrderHistoryRecord_InsertingRecord);     
	}

	protected BaseRepairOrderHistoryRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void RepairOrderHistoryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                RepairOrderHistoryRecord RepairOrderHistoryRec = (RepairOrderHistoryRecord)sender;
        if(RepairOrderHistoryRec != null && !RepairOrderHistoryRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void RepairOrderHistoryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                RepairOrderHistoryRecord RepairOrderHistoryRec = (RepairOrderHistoryRecord)sender;
        Validate_Inserting();
        if(RepairOrderHistoryRec != null && !RepairOrderHistoryRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROReference2 field.
	/// </summary>
	public ColumnValue GetROReference2Value()
	{
		return this.GetValue(TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROReference2 field.
	/// </summary>
	public string GetROReference2FieldValue()
	{
		return this.GetValue(TableUtils.ROReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROCategory field.
	/// </summary>
	public ColumnValue GetROCategoryValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROCategory field.
	/// </summary>
	public string GetROCategoryFieldValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROCustNo field.
	/// </summary>
	public ColumnValue GetROCustNoValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROCustNo field.
	/// </summary>
	public Int32 GetROCustNoFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROSerialNo field.
	/// </summary>
	public ColumnValue GetROSerialNoValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROSerialNo field.
	/// </summary>
	public string GetROSerialNoFieldValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSerialNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.MakeModel field.
	/// </summary>
	public ColumnValue GetMakeModelValue()
	{
		return this.GetValue(TableUtils.MakeModelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.MakeModel field.
	/// </summary>
	public string GetMakeModelFieldValue()
	{
		return this.GetValue(TableUtils.MakeModelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.MakeModel field.
	/// </summary>
	public void SetMakeModelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MakeModelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.MakeModel field.
	/// </summary>
	public void SetMakeModelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MakeModelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.RODate field.
	/// </summary>
	public ColumnValue GetRODateValue()
	{
		return this.GetValue(TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.RODate field.
	/// </summary>
	public DateTime GetRODateFieldValue()
	{
		return this.GetValue(TableUtils.RODateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.RODateRepairCompleted field.
	/// </summary>
	public ColumnValue GetRODateRepairCompletedValue()
	{
		return this.GetValue(TableUtils.RODateRepairCompletedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.RODateRepairCompleted field.
	/// </summary>
	public DateTime GetRODateRepairCompletedFieldValue()
	{
		return this.GetValue(TableUtils.RODateRepairCompletedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODateRepairCompleted field.
	/// </summary>
	public void SetRODateRepairCompletedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateRepairCompletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODateRepairCompleted field.
	/// </summary>
	public void SetRODateRepairCompletedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateRepairCompletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODateRepairCompleted field.
	/// </summary>
	public void SetRODateRepairCompletedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateRepairCompletedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.RONo field.
	/// </summary>
	public ColumnValue GetRONoValue()
	{
		return this.GetValue(TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.RONo field.
	/// </summary>
	public Int32 GetRONoFieldValue()
	{
		return this.GetValue(TableUtils.RONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROFaultCodes field.
	/// </summary>
	public ColumnValue GetROFaultCodesValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROFaultCodes field.
	/// </summary>
	public string GetROFaultCodesFieldValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROFaultCodesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROWorkDoneNotes field.
	/// </summary>
	public ColumnValue GetROWorkDoneNotesValue()
	{
		return this.GetValue(TableUtils.ROWorkDoneNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROWorkDoneNotes field.
	/// </summary>
	public string GetROWorkDoneNotesFieldValue()
	{
		return this.GetValue(TableUtils.ROWorkDoneNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROWorkDoneNotes field.
	/// </summary>
	public void SetROWorkDoneNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROWorkDoneNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROWorkDoneNotes field.
	/// </summary>
	public void SetROWorkDoneNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROWorkDoneNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROProblem field.
	/// </summary>
	public ColumnValue GetROProblemValue()
	{
		return this.GetValue(TableUtils.ROProblemColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROProblem field.
	/// </summary>
	public string GetROProblemFieldValue()
	{
		return this.GetValue(TableUtils.ROProblemColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROProblem field.
	/// </summary>
	public void SetROProblemFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROProblemColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROProblem field.
	/// </summary>
	public void SetROProblemFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROProblemColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROPartNo field.
	/// </summary>
	public ColumnValue GetROPartNoValue()
	{
		return this.GetValue(TableUtils.ROPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROPartNo field.
	/// </summary>
	public string GetROPartNoFieldValue()
	{
		return this.GetValue(TableUtils.ROPartNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROPartNo field.
	/// </summary>
	public void SetROPartNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROPartNo field.
	/// </summary>
	public void SetROPartNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPartNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ItemDescription field.
	/// </summary>
	public ColumnValue GetItemDescriptionValue()
	{
		return this.GetValue(TableUtils.ItemDescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ItemDescription field.
	/// </summary>
	public string GetItemDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.ItemDescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ItemDescription field.
	/// </summary>
	public void SetItemDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ItemDescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ItemDescription field.
	/// </summary>
	public void SetItemDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ItemDescriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROSellPrice field.
	/// </summary>
	public ColumnValue GetROSellPriceValue()
	{
		return this.GetValue(TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.ROSellPrice field.
	/// </summary>
	public Decimal GetROSellPriceFieldValue()
	{
		return this.GetValue(TableUtils.ROSellPriceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSellPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.DiscountPrice field.
	/// </summary>
	public ColumnValue GetDiscountPriceValue()
	{
		return this.GetValue(TableUtils.DiscountPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.DiscountPrice field.
	/// </summary>
	public Single GetDiscountPriceFieldValue()
	{
		return this.GetValue(TableUtils.DiscountPriceColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.DiscountPrice field.
	/// </summary>
	public void SetDiscountPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DiscountPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.DiscountPrice field.
	/// </summary>
	public void SetDiscountPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.DiscountPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.DiscountPrice field.
	/// </summary>
	public void SetDiscountPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DiscountPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.DiscountPrice field.
	/// </summary>
	public void SetDiscountPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DiscountPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.DiscountPrice field.
	/// </summary>
	public void SetDiscountPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DiscountPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.CustName field.
	/// </summary>
	public ColumnValue GetCustNameValue()
	{
		return this.GetValue(TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.CustName field.
	/// </summary>
	public string GetCustNameFieldValue()
	{
		return this.GetValue(TableUtils.CustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.CustNo field.
	/// </summary>
	public ColumnValue GetCustNoValue()
	{
		return this.GetValue(TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.CustNo field.
	/// </summary>
	public Int32 GetCustNoFieldValue()
	{
		return this.GetValue(TableUtils.CustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.RODeptIDNew field.
	/// </summary>
	public ColumnValue GetRODeptIDNewValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrderHistory_.RODeptIDNew field.
	/// </summary>
	public Int32 GetRODeptIDNewFieldValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ROReference2 field.
	/// </summary>
	public string ROReference2
	{
		get
		{
			return this.GetValue(TableUtils.ROReference2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROReference2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROReference2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROReference2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROReference2 field.
	/// </summary>
	public string ROReference2Default
	{
		get
		{
			return TableUtils.ROReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ROCategory field.
	/// </summary>
	public string ROCategory
	{
		get
		{
			return this.GetValue(TableUtils.ROCategoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCategoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCategorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCategoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROCategory field.
	/// </summary>
	public string ROCategoryDefault
	{
		get
		{
			return TableUtils.ROCategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ROCustNo field.
	/// </summary>
	public Int32 ROCustNo
	{
		get
		{
			return this.GetValue(TableUtils.ROCustNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCustNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCustNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCustNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROCustNo field.
	/// </summary>
	public string ROCustNoDefault
	{
		get
		{
			return TableUtils.ROCustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ROSerialNo field.
	/// </summary>
	public string ROSerialNo
	{
		get
		{
			return this.GetValue(TableUtils.ROSerialNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSerialNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSerialNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSerialNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROSerialNo field.
	/// </summary>
	public string ROSerialNoDefault
	{
		get
		{
			return TableUtils.ROSerialNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.MakeModel field.
	/// </summary>
	public string MakeModel
	{
		get
		{
			return this.GetValue(TableUtils.MakeModelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MakeModelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MakeModelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MakeModelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.MakeModel field.
	/// </summary>
	public string MakeModelDefault
	{
		get
		{
			return TableUtils.MakeModelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.RODate field.
	/// </summary>
	public DateTime RODate
	{
		get
		{
			return this.GetValue(TableUtils.RODateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODate field.
	/// </summary>
	public string RODateDefault
	{
		get
		{
			return TableUtils.RODateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.RODateRepairCompleted field.
	/// </summary>
	public DateTime RODateRepairCompleted
	{
		get
		{
			return this.GetValue(TableUtils.RODateRepairCompletedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateRepairCompletedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateRepairCompletedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateRepairCompletedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODateRepairCompleted field.
	/// </summary>
	public string RODateRepairCompletedDefault
	{
		get
		{
			return TableUtils.RODateRepairCompletedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.RONo field.
	/// </summary>
	public Int32 RONo
	{
		get
		{
			return this.GetValue(TableUtils.RONoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RONoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RONoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RONoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RONo field.
	/// </summary>
	public string RONoDefault
	{
		get
		{
			return TableUtils.RONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ROFaultCodes field.
	/// </summary>
	public string ROFaultCodes
	{
		get
		{
			return this.GetValue(TableUtils.ROFaultCodesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROFaultCodesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROFaultCodesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROFaultCodesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROFaultCodes field.
	/// </summary>
	public string ROFaultCodesDefault
	{
		get
		{
			return TableUtils.ROFaultCodesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ROWorkDoneNotes field.
	/// </summary>
	public string ROWorkDoneNotes
	{
		get
		{
			return this.GetValue(TableUtils.ROWorkDoneNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROWorkDoneNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROWorkDoneNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROWorkDoneNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROWorkDoneNotes field.
	/// </summary>
	public string ROWorkDoneNotesDefault
	{
		get
		{
			return TableUtils.ROWorkDoneNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ROProblem field.
	/// </summary>
	public string ROProblem
	{
		get
		{
			return this.GetValue(TableUtils.ROProblemColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROProblemColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROProblemSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROProblemColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROProblem field.
	/// </summary>
	public string ROProblemDefault
	{
		get
		{
			return TableUtils.ROProblemColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ROPartNo field.
	/// </summary>
	public string ROPartNo
	{
		get
		{
			return this.GetValue(TableUtils.ROPartNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPartNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPartNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPartNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROPartNo field.
	/// </summary>
	public string ROPartNoDefault
	{
		get
		{
			return TableUtils.ROPartNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ItemDescription field.
	/// </summary>
	public string ItemDescription
	{
		get
		{
			return this.GetValue(TableUtils.ItemDescriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ItemDescriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ItemDescriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ItemDescriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ItemDescription field.
	/// </summary>
	public string ItemDescriptionDefault
	{
		get
		{
			return TableUtils.ItemDescriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.ROSellPrice field.
	/// </summary>
	public Decimal ROSellPrice
	{
		get
		{
			return this.GetValue(TableUtils.ROSellPriceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSellPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSellPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSellPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.ROSellPrice field.
	/// </summary>
	public string ROSellPriceDefault
	{
		get
		{
			return TableUtils.ROSellPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.DiscountPrice field.
	/// </summary>
	public Single DiscountPrice
	{
		get
		{
			return this.GetValue(TableUtils.DiscountPriceColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DiscountPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DiscountPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DiscountPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.DiscountPrice field.
	/// </summary>
	public string DiscountPriceDefault
	{
		get
		{
			return TableUtils.DiscountPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.CustName field.
	/// </summary>
	public string CustName
	{
		get
		{
			return this.GetValue(TableUtils.CustNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.CustName field.
	/// </summary>
	public string CustNameDefault
	{
		get
		{
			return TableUtils.CustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.CustNo field.
	/// </summary>
	public Int32 CustNo
	{
		get
		{
			return this.GetValue(TableUtils.CustNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.CustNo field.
	/// </summary>
	public string CustNoDefault
	{
		get
		{
			return TableUtils.CustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrderHistory_.RODeptIDNew field.
	/// </summary>
	public Int32 RODeptIDNew
	{
		get
		{
			return this.GetValue(TableUtils.RODeptIDNewColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODeptIDNewColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODeptIDNewSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODeptIDNewColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrderHistory_.RODeptIDNew field.
	/// </summary>
	public string RODeptIDNewDefault
	{
		get
		{
			return TableUtils.RODeptIDNewColumn.DefaultValue;
		}
	}


#endregion

}

}
