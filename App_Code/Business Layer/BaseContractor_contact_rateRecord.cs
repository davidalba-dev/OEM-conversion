// This class is "generated" and will be overwritten.
// Your customizations should be made in Contractor_contact_rateRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Contractor_contact_rateRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Contractor_contact_rateTable"></see> class.
/// </remarks>
/// <seealso cref="Contractor_contact_rateTable"></seealso>
/// <seealso cref="Contractor_contact_rateRecord"></seealso>
public class BaseContractor_contact_rateRecord : PrimaryKeyRecord
{

	public readonly static Contractor_contact_rateTable TableUtils = Contractor_contact_rateTable.Instance;

	// Constructors
 
	protected BaseContractor_contact_rateRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Contractor_contact_rateRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Contractor_contact_rateRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Contractor_contact_rateRecord_ReadRecord); 
	}

	protected BaseContractor_contact_rateRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Contractor_contact_rateRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Contractor_contact_rateRecord Contractor_contact_rateRec = (Contractor_contact_rateRecord)sender;
        if(Contractor_contact_rateRec != null && !Contractor_contact_rateRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Contractor_contact_rateRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Contractor_contact_rateRecord Contractor_contact_rateRec = (Contractor_contact_rateRecord)sender;
        Validate_Inserting();
        if(Contractor_contact_rateRec != null && !Contractor_contact_rateRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Contractor_contact_rateRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Contractor_contact_rateRecord Contractor_contact_rateRec = (Contractor_contact_rateRecord)sender;
        Validate_Updating();
        if(Contractor_contact_rateRec != null && !Contractor_contact_rateRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.contractor_contact_rate_id field.
	/// </summary>
	public ColumnValue Getcontractor_contact_rate_idValue()
	{
		return this.GetValue(TableUtils.contractor_contact_rate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.contractor_contact_rate_id field.
	/// </summary>
	public Int32 Getcontractor_contact_rate_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_contact_rate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.contractor_contact_id field.
	/// </summary>
	public ColumnValue Getcontractor_contact_idValue()
	{
		return this.GetValue(TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.contractor_contact_id field.
	/// </summary>
	public Int32 Getcontractor_contact_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_contact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_contact_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.start_date field.
	/// </summary>
	public ColumnValue Getstart_dateValue()
	{
		return this.GetValue(TableUtils.start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.start_date field.
	/// </summary>
	public DateTime Getstart_dateFieldValue()
	{
		return this.GetValue(TableUtils.start_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.start_date field.
	/// </summary>
	public void Setstart_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.start_date field.
	/// </summary>
	public void Setstart_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.start_date field.
	/// </summary>
	public void Setstart_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.start_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.end_date field.
	/// </summary>
	public ColumnValue Getend_dateValue()
	{
		return this.GetValue(TableUtils.end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.end_date field.
	/// </summary>
	public DateTime Getend_dateFieldValue()
	{
		return this.GetValue(TableUtils.end_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.end_date field.
	/// </summary>
	public void Setend_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.end_date field.
	/// </summary>
	public void Setend_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.end_date field.
	/// </summary>
	public void Setend_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.end_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.rate field.
	/// </summary>
	public ColumnValue GetrateValue()
	{
		return this.GetValue(TableUtils.rateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_rate_.rate field.
	/// </summary>
	public Decimal GetrateFieldValue()
	{
		return this.GetValue(TableUtils.rateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.rate field.
	/// </summary>
	public void SetrateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.rate field.
	/// </summary>
	public void SetrateFieldValue(string val)
	{
		this.SetString(val, TableUtils.rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.rate field.
	/// </summary>
	public void SetrateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.rate field.
	/// </summary>
	public void SetrateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.rate field.
	/// </summary>
	public void SetrateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.rateColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_rate_.contractor_contact_rate_id field.
	/// </summary>
	public Int32 contractor_contact_rate_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_contact_rate_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_contact_rate_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_contact_rate_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_contact_rate_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.contractor_contact_rate_id field.
	/// </summary>
	public string contractor_contact_rate_idDefault
	{
		get
		{
			return TableUtils.contractor_contact_rate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_rate_.contractor_contact_id field.
	/// </summary>
	public Int32 contractor_contact_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_contact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_contact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_contact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_contact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.contractor_contact_id field.
	/// </summary>
	public string contractor_contact_idDefault
	{
		get
		{
			return TableUtils.contractor_contact_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_rate_.start_date field.
	/// </summary>
	public DateTime start_date
	{
		get
		{
			return this.GetValue(TableUtils.start_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.start_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool start_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.start_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.start_date field.
	/// </summary>
	public string start_dateDefault
	{
		get
		{
			return TableUtils.start_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_rate_.end_date field.
	/// </summary>
	public DateTime end_date
	{
		get
		{
			return this.GetValue(TableUtils.end_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.end_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool end_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.end_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.end_date field.
	/// </summary>
	public string end_dateDefault
	{
		get
		{
			return TableUtils.end_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_rate_.rate field.
	/// </summary>
	public Decimal rate
	{
		get
		{
			return this.GetValue(TableUtils.rateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.rateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool rateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.rateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_rate_.rate field.
	/// </summary>
	public string rateDefault
	{
		get
		{
			return TableUtils.rateColumn.DefaultValue;
		}
	}


#endregion
}

}
