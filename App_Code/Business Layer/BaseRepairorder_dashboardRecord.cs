// This class is "generated" and will be overwritten.
// Your customizations should be made in Repairorder_dashboardRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Repairorder_dashboardRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Repairorder_dashboardView"></see> class.
/// </remarks>
/// <seealso cref="Repairorder_dashboardView"></seealso>
/// <seealso cref="Repairorder_dashboardRecord"></seealso>
public class BaseRepairorder_dashboardRecord : PrimaryKeyRecord
{

	public readonly static Repairorder_dashboardView TableUtils = Repairorder_dashboardView.Instance;

	// Constructors
 
	protected BaseRepairorder_dashboardRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Repairorder_dashboardRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Repairorder_dashboardRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Repairorder_dashboardRecord_ReadRecord); 
	}

	protected BaseRepairorder_dashboardRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Repairorder_dashboardRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Repairorder_dashboardRecord Repairorder_dashboardRec = (Repairorder_dashboardRecord)sender;
        if(Repairorder_dashboardRec != null && !Repairorder_dashboardRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Repairorder_dashboardRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Repairorder_dashboardRecord Repairorder_dashboardRec = (Repairorder_dashboardRecord)sender;
        Validate_Inserting();
        if(Repairorder_dashboardRec != null && !Repairorder_dashboardRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Repairorder_dashboardRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Repairorder_dashboardRecord Repairorder_dashboardRec = (Repairorder_dashboardRecord)sender;
        Validate_Updating();
        if(Repairorder_dashboardRec != null && !Repairorder_dashboardRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's repairorder_dashboard_.Expr1 field.
	/// </summary>
	public ColumnValue GetExpr1Value()
	{
		return this.GetValue(TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_dashboard_.Expr1 field.
	/// </summary>
	public Int32 GetExpr1FieldValue()
	{
		return this.GetValue(TableUtils.Expr1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(string val)
	{
		this.SetString(val, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.Expr1 field.
	/// </summary>
	public void SetExpr1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Expr1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_dashboard_.StaCustomCaption field.
	/// </summary>
	public ColumnValue GetStaCustomCaptionValue()
	{
		return this.GetValue(TableUtils.StaCustomCaptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_dashboard_.StaCustomCaption field.
	/// </summary>
	public string GetStaCustomCaptionFieldValue()
	{
		return this.GetValue(TableUtils.StaCustomCaptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.StaCustomCaption field.
	/// </summary>
	public void SetStaCustomCaptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustomCaptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.StaCustomCaption field.
	/// </summary>
	public void SetStaCustomCaptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustomCaptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_dashboard_.StaNumber field.
	/// </summary>
	public ColumnValue GetStaNumberValue()
	{
		return this.GetValue(TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_dashboard_.StaNumber field.
	/// </summary>
	public Byte GetStaNumberFieldValue()
	{
		return this.GetValue(TableUtils.StaNumberColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNumberColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_dashboard_.Expr1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.Expr1 field.
	/// </summary>
	public string Expr1Default
	{
		get
		{
			return TableUtils.Expr1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_dashboard_.StaCustomCaption field.
	/// </summary>
	public string StaCustomCaption
	{
		get
		{
			return this.GetValue(TableUtils.StaCustomCaptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustomCaptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustomCaptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustomCaptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.StaCustomCaption field.
	/// </summary>
	public string StaCustomCaptionDefault
	{
		get
		{
			return TableUtils.StaCustomCaptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_dashboard_.StaNumber field.
	/// </summary>
	public Byte StaNumber
	{
		get
		{
			return this.GetValue(TableUtils.StaNumberColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_dashboard_.StaNumber field.
	/// </summary>
	public string StaNumberDefault
	{
		get
		{
			return TableUtils.StaNumberColumn.DefaultValue;
		}
	}


#endregion
}

}
