// This class is "generated" and will be overwritten.
// Your customizations should be made in Max_makemodelRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Max_makemodelRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Max_makemodelView"></see> class.
/// </remarks>
/// <seealso cref="Max_makemodelView"></seealso>
/// <seealso cref="Max_makemodelRecord"></seealso>
public class BaseMax_makemodelRecord : PrimaryKeyRecord
{

	public readonly static Max_makemodelView TableUtils = Max_makemodelView.Instance;

	// Constructors
 
	protected BaseMax_makemodelRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Max_makemodelRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Max_makemodelRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Max_makemodelRecord_ReadRecord); 
	}

	protected BaseMax_makemodelRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Max_makemodelRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Max_makemodelRecord Max_makemodelRec = (Max_makemodelRecord)sender;
        if(Max_makemodelRec != null && !Max_makemodelRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Max_makemodelRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Max_makemodelRecord Max_makemodelRec = (Max_makemodelRecord)sender;
        Validate_Inserting();
        if(Max_makemodelRec != null && !Max_makemodelRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Max_makemodelRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Max_makemodelRecord Max_makemodelRec = (Max_makemodelRecord)sender;
        Validate_Updating();
        if(Max_makemodelRec != null && !Max_makemodelRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's max_makemodel_.Expr1 field.
	/// </summary>
	public ColumnValue GetExpr1Value()
	{
		return this.GetValue(TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's max_makemodel_.Expr1 field.
	/// </summary>
	public Int32 GetExpr1FieldValue()
	{
		return this.GetValue(TableUtils.Expr1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_makemodel_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_makemodel_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(string val)
	{
		this.SetString(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_makemodel_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_makemodel_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_makemodel_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's max_makemodel_.Expr1 field.
	/// </summary>
	public Int32 Expr1
	{
		get
		{
			return this.GetValue(TableUtils.Expr1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Expr1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Expr1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Expr1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_makemodel_.Expr1 field.
	/// </summary>
	public string Expr1Default
	{
		get
		{
			return TableUtils.Expr1Column.DefaultValue;
		}
	}


#endregion
}

}
