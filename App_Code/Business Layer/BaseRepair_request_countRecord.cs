// This class is "generated" and will be overwritten.
// Your customizations should be made in Repair_request_countRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Repair_request_countRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Repair_request_countView"></see> class.
/// </remarks>
/// <seealso cref="Repair_request_countView"></seealso>
/// <seealso cref="Repair_request_countRecord"></seealso>
public class BaseRepair_request_countRecord : KeylessRecord
{

	public readonly static Repair_request_countView TableUtils = Repair_request_countView.Instance;

	// Constructors
 
	protected BaseRepair_request_countRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Repair_request_countRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Repair_request_countRecord_InsertingRecord);     
	}

	protected BaseRepair_request_countRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Repair_request_countRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Repair_request_countRecord Repair_request_countRec = (Repair_request_countRecord)sender;
        if(Repair_request_countRec != null && !Repair_request_countRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Repair_request_countRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Repair_request_countRecord Repair_request_countRec = (Repair_request_countRecord)sender;
        Validate_Inserting();
        if(Repair_request_countRec != null && !Repair_request_countRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's repair_request_count_.repair_request_count field.
	/// </summary>
	public ColumnValue Getrepair_request_countValue()
	{
		return this.GetValue(TableUtils.repair_request_countColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_request_count_.repair_request_count field.
	/// </summary>
	public Int32 Getrepair_request_countFieldValue()
	{
		return this.GetValue(TableUtils.repair_request_countColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_request_count_.repair_request_count field.
	/// </summary>
	public void Setrepair_request_countFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_request_countColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_request_count_.repair_request_count field.
	/// </summary>
	public void Setrepair_request_countFieldValue(string val)
	{
		this.SetString(val, TableUtils.repair_request_countColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_request_count_.repair_request_count field.
	/// </summary>
	public void Setrepair_request_countFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_request_countColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_request_count_.repair_request_count field.
	/// </summary>
	public void Setrepair_request_countFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_request_countColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_request_count_.repair_request_count field.
	/// </summary>
	public void Setrepair_request_countFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_request_countColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_request_count_.repair_request_count field.
	/// </summary>
	public Int32 repair_request_count
	{
		get
		{
			return this.GetValue(TableUtils.repair_request_countColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_request_countColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_request_countSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_request_countColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_request_count_.repair_request_count field.
	/// </summary>
	public string repair_request_countDefault
	{
		get
		{
			return TableUtils.repair_request_countColumn.DefaultValue;
		}
	}


#endregion

}

}
