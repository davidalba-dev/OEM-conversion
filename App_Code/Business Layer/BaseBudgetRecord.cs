// This class is "generated" and will be overwritten.
// Your customizations should be made in BudgetRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="BudgetRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="BudgetTable"></see> class.
/// </remarks>
/// <seealso cref="BudgetTable"></seealso>
/// <seealso cref="BudgetRecord"></seealso>
public class BaseBudgetRecord : PrimaryKeyRecord
{

	public readonly static BudgetTable TableUtils = BudgetTable.Instance;

	// Constructors
 
	protected BaseBudgetRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.BudgetRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.BudgetRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.BudgetRecord_ReadRecord); 
	}

	protected BaseBudgetRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void BudgetRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                BudgetRecord BudgetRec = (BudgetRecord)sender;
        if(BudgetRec != null && !BudgetRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void BudgetRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                BudgetRecord BudgetRec = (BudgetRecord)sender;
        Validate_Inserting();
        if(BudgetRec != null && !BudgetRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void BudgetRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                BudgetRecord BudgetRec = (BudgetRecord)sender;
        Validate_Updating();
        if(BudgetRec != null && !BudgetRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's budget_.budget_id field.
	/// </summary>
	public ColumnValue Getbudget_idValue()
	{
		return this.GetValue(TableUtils.budget_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's budget_.budget_id field.
	/// </summary>
	public Int32 Getbudget_idFieldValue()
	{
		return this.GetValue(TableUtils.budget_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's budget_.budget_amount field.
	/// </summary>
	public ColumnValue Getbudget_amountValue()
	{
		return this.GetValue(TableUtils.budget_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's budget_.budget_amount field.
	/// </summary>
	public Decimal Getbudget_amountFieldValue()
	{
		return this.GetValue(TableUtils.budget_amountColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_amount field.
	/// </summary>
	public void Setbudget_amountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.budget_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_amount field.
	/// </summary>
	public void Setbudget_amountFieldValue(string val)
	{
		this.SetString(val, TableUtils.budget_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_amount field.
	/// </summary>
	public void Setbudget_amountFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.budget_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_amount field.
	/// </summary>
	public void Setbudget_amountFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.budget_amountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_amount field.
	/// </summary>
	public void Setbudget_amountFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.budget_amountColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's budget_.budget_created_by field.
	/// </summary>
	public ColumnValue Getbudget_created_byValue()
	{
		return this.GetValue(TableUtils.budget_created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's budget_.budget_created_by field.
	/// </summary>
	public Int32 Getbudget_created_byFieldValue()
	{
		return this.GetValue(TableUtils.budget_created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_created_by field.
	/// </summary>
	public void Setbudget_created_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.budget_created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_created_by field.
	/// </summary>
	public void Setbudget_created_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.budget_created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_created_by field.
	/// </summary>
	public void Setbudget_created_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.budget_created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_created_by field.
	/// </summary>
	public void Setbudget_created_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.budget_created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_created_by field.
	/// </summary>
	public void Setbudget_created_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.budget_created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's budget_.contract_id field.
	/// </summary>
	public ColumnValue Getcontract_idValue()
	{
		return this.GetValue(TableUtils.contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's budget_.contract_id field.
	/// </summary>
	public Int32 Getcontract_idFieldValue()
	{
		return this.GetValue(TableUtils.contract_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.contract_id field.
	/// </summary>
	public void Setcontract_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.contract_id field.
	/// </summary>
	public void Setcontract_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.contract_id field.
	/// </summary>
	public void Setcontract_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.contract_id field.
	/// </summary>
	public void Setcontract_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.contract_id field.
	/// </summary>
	public void Setcontract_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's budget_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's budget_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's budget_.budget_id field.
	/// </summary>
	public Int32 budget_id
	{
		get
		{
			return this.GetValue(TableUtils.budget_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.budget_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool budget_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.budget_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_id field.
	/// </summary>
	public string budget_idDefault
	{
		get
		{
			return TableUtils.budget_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's budget_.budget_amount field.
	/// </summary>
	public Decimal budget_amount
	{
		get
		{
			return this.GetValue(TableUtils.budget_amountColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.budget_amountColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool budget_amountSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.budget_amountColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_amount field.
	/// </summary>
	public string budget_amountDefault
	{
		get
		{
			return TableUtils.budget_amountColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's budget_.budget_created_by field.
	/// </summary>
	public Int32 budget_created_by
	{
		get
		{
			return this.GetValue(TableUtils.budget_created_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.budget_created_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool budget_created_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.budget_created_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.budget_created_by field.
	/// </summary>
	public string budget_created_byDefault
	{
		get
		{
			return TableUtils.budget_created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's budget_.contract_id field.
	/// </summary>
	public Int32 contract_id
	{
		get
		{
			return this.GetValue(TableUtils.contract_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's budget_.contract_id field.
	/// </summary>
	public string contract_idDefault
	{
		get
		{
			return TableUtils.contract_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's budget_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's budget_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}


#endregion
}

}
