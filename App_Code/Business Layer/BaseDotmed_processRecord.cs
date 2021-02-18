// This class is "generated" and will be overwritten.
// Your customizations should be made in Dotmed_processRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Dotmed_processRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Dotmed_processTable"></see> class.
/// </remarks>
/// <seealso cref="Dotmed_processTable"></seealso>
/// <seealso cref="Dotmed_processRecord"></seealso>
public class BaseDotmed_processRecord : PrimaryKeyRecord
{

	public readonly static Dotmed_processTable TableUtils = Dotmed_processTable.Instance;

	// Constructors
 
	protected BaseDotmed_processRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Dotmed_processRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Dotmed_processRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Dotmed_processRecord_ReadRecord); 
	}

	protected BaseDotmed_processRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Dotmed_processRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Dotmed_processRecord Dotmed_processRec = (Dotmed_processRecord)sender;
        if(Dotmed_processRec != null && !Dotmed_processRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Dotmed_processRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Dotmed_processRecord Dotmed_processRec = (Dotmed_processRecord)sender;
        Validate_Inserting();
        if(Dotmed_processRec != null && !Dotmed_processRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Dotmed_processRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Dotmed_processRecord Dotmed_processRec = (Dotmed_processRecord)sender;
        Validate_Updating();
        if(Dotmed_processRec != null && !Dotmed_processRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's dotmed_process_.dotmed_process_id field.
	/// </summary>
	public ColumnValue Getdotmed_process_idValue()
	{
		return this.GetValue(TableUtils.dotmed_process_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's dotmed_process_.dotmed_process_id field.
	/// </summary>
	public Decimal Getdotmed_process_idFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_process_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's dotmed_process_.listing_id field.
	/// </summary>
	public ColumnValue Getlisting_idValue()
	{
		return this.GetValue(TableUtils.listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's dotmed_process_.listing_id field.
	/// </summary>
	public Decimal Getlisting_idFieldValue()
	{
		return this.GetValue(TableUtils.listing_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.listing_id field.
	/// </summary>
	public void Setlisting_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.listing_id field.
	/// </summary>
	public void Setlisting_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.listing_id field.
	/// </summary>
	public void Setlisting_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.listing_id field.
	/// </summary>
	public void Setlisting_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.listing_id field.
	/// </summary>
	public void Setlisting_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.listing_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's dotmed_process_.item_id field.
	/// </summary>
	public ColumnValue Getitem_idValue()
	{
		return this.GetValue(TableUtils.item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's dotmed_process_.item_id field.
	/// </summary>
	public Decimal Getitem_idFieldValue()
	{
		return this.GetValue(TableUtils.item_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.item_id field.
	/// </summary>
	public void Setitem_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.item_id field.
	/// </summary>
	public void Setitem_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.item_id field.
	/// </summary>
	public void Setitem_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.item_id field.
	/// </summary>
	public void Setitem_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.item_id field.
	/// </summary>
	public void Setitem_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.item_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's dotmed_process_.dotmed_process_id field.
	/// </summary>
	public Decimal dotmed_process_id
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_process_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_process_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_process_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_process_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.dotmed_process_id field.
	/// </summary>
	public string dotmed_process_idDefault
	{
		get
		{
			return TableUtils.dotmed_process_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's dotmed_process_.listing_id field.
	/// </summary>
	public Decimal listing_id
	{
		get
		{
			return this.GetValue(TableUtils.listing_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.listing_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool listing_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.listing_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.listing_id field.
	/// </summary>
	public string listing_idDefault
	{
		get
		{
			return TableUtils.listing_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's dotmed_process_.item_id field.
	/// </summary>
	public Decimal item_id
	{
		get
		{
			return this.GetValue(TableUtils.item_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.item_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool item_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.item_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's dotmed_process_.item_id field.
	/// </summary>
	public string item_idDefault
	{
		get
		{
			return TableUtils.item_idColumn.DefaultValue;
		}
	}


#endregion
}

}
