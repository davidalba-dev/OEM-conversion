// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_max_vendornoRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_max_vendornoRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_max_vendornoView"></see> class.
/// </remarks>
/// <seealso cref="Vw_max_vendornoView"></seealso>
/// <seealso cref="Vw_max_vendornoRecord"></seealso>
public class BaseVw_max_vendornoRecord : PrimaryKeyRecord
{

	public readonly static Vw_max_vendornoView TableUtils = Vw_max_vendornoView.Instance;

	// Constructors
 
	protected BaseVw_max_vendornoRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_max_vendornoRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Vw_max_vendornoRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_max_vendornoRecord_ReadRecord); 
	}

	protected BaseVw_max_vendornoRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_max_vendornoRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_max_vendornoRecord Vw_max_vendornoRec = (Vw_max_vendornoRecord)sender;
        if(Vw_max_vendornoRec != null && !Vw_max_vendornoRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_max_vendornoRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_max_vendornoRecord Vw_max_vendornoRec = (Vw_max_vendornoRecord)sender;
        Validate_Inserting();
        if(Vw_max_vendornoRec != null && !Vw_max_vendornoRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Vw_max_vendornoRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Vw_max_vendornoRecord Vw_max_vendornoRec = (Vw_max_vendornoRecord)sender;
        Validate_Updating();
        if(Vw_max_vendornoRec != null && !Vw_max_vendornoRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_max_vendorno_.Expr1 field.
	/// </summary>
	public ColumnValue GetExpr1Value()
	{
		return this.GetValue(TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_max_vendorno_.Expr1 field.
	/// </summary>
	public Int32 GetExpr1FieldValue()
	{
		return this.GetValue(TableUtils.Expr1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_max_vendorno_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_max_vendorno_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(string val)
	{
		this.SetString(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_max_vendorno_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_max_vendorno_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_max_vendorno_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_max_vendorno_.Expr1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_max_vendorno_.Expr1 field.
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
