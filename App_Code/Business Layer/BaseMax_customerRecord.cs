// This class is "generated" and will be overwritten.
// Your customizations should be made in Max_customerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Max_customerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Max_customerView"></see> class.
/// </remarks>
/// <seealso cref="Max_customerView"></seealso>
/// <seealso cref="Max_customerRecord"></seealso>
public class BaseMax_customerRecord : PrimaryKeyRecord
{

	public readonly static Max_customerView TableUtils = Max_customerView.Instance;

	// Constructors
 
	protected BaseMax_customerRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Max_customerRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Max_customerRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Max_customerRecord_ReadRecord); 
	}

	protected BaseMax_customerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Max_customerRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Max_customerRecord Max_customerRec = (Max_customerRecord)sender;
        if(Max_customerRec != null && !Max_customerRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Max_customerRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Max_customerRecord Max_customerRec = (Max_customerRecord)sender;
        Validate_Inserting();
        if(Max_customerRec != null && !Max_customerRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Max_customerRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Max_customerRecord Max_customerRec = (Max_customerRecord)sender;
        Validate_Updating();
        if(Max_customerRec != null && !Max_customerRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's max_customer_.Expr field.
	/// </summary>
	public ColumnValue GetExprValue()
	{
		return this.GetValue(TableUtils.ExprColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's max_customer_.Expr field.
	/// </summary>
	public Int32 GetExprFieldValue()
	{
		return this.GetValue(TableUtils.ExprColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_customer_.Expr field.
	/// </summary>
	public void SetExprFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ExprColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_customer_.Expr field.
	/// </summary>
	public void SetExprFieldValue(string val)
	{
		this.SetString(val, TableUtils.ExprColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_customer_.Expr field.
	/// </summary>
	public void SetExprFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ExprColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_customer_.Expr field.
	/// </summary>
	public void SetExprFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ExprColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_customer_.Expr field.
	/// </summary>
	public void SetExprFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ExprColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's max_customer_.Expr field.
	/// </summary>
	public Int32 Expr
	{
		get
		{
			return this.GetValue(TableUtils.ExprColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ExprColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ExprSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ExprColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_customer_.Expr field.
	/// </summary>
	public string ExprDefault
	{
		get
		{
			return TableUtils.ExprColumn.DefaultValue;
		}
	}


#endregion
}

}
