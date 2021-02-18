// This class is "generated" and will be overwritten.
// Your customizations should be made in Loaner_requestRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Loaner_requestRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Loaner_requestTable"></see> class.
/// </remarks>
/// <seealso cref="Loaner_requestTable"></seealso>
/// <seealso cref="Loaner_requestRecord"></seealso>
public class BaseLoaner_requestRecord : PrimaryKeyRecord
{

	public readonly static Loaner_requestTable TableUtils = Loaner_requestTable.Instance;

	// Constructors
 
	protected BaseLoaner_requestRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Loaner_requestRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Loaner_requestRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Loaner_requestRecord_ReadRecord); 
	}

	protected BaseLoaner_requestRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Loaner_requestRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Loaner_requestRecord Loaner_requestRec = (Loaner_requestRecord)sender;
        if(Loaner_requestRec != null && !Loaner_requestRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Loaner_requestRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Loaner_requestRecord Loaner_requestRec = (Loaner_requestRecord)sender;
        Validate_Inserting();
        if(Loaner_requestRec != null && !Loaner_requestRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Loaner_requestRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Loaner_requestRecord Loaner_requestRec = (Loaner_requestRecord)sender;
        Validate_Updating();
        if(Loaner_requestRec != null && !Loaner_requestRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_request_id field.
	/// </summary>
	public ColumnValue Getloaner_request_idValue()
	{
		return this.GetValue(TableUtils.loaner_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_request_id field.
	/// </summary>
	public Int32 Getloaner_request_idFieldValue()
	{
		return this.GetValue(TableUtils.loaner_request_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_start_date field.
	/// </summary>
	public ColumnValue Getloaner_start_dateValue()
	{
		return this.GetValue(TableUtils.loaner_start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_start_date field.
	/// </summary>
	public DateTime Getloaner_start_dateFieldValue()
	{
		return this.GetValue(TableUtils.loaner_start_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_start_date field.
	/// </summary>
	public void Setloaner_start_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_start_date field.
	/// </summary>
	public void Setloaner_start_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_start_date field.
	/// </summary>
	public void Setloaner_start_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_start_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_end_date field.
	/// </summary>
	public ColumnValue Getloaner_end_dateValue()
	{
		return this.GetValue(TableUtils.loaner_end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_end_date field.
	/// </summary>
	public DateTime Getloaner_end_dateFieldValue()
	{
		return this.GetValue(TableUtils.loaner_end_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_end_date field.
	/// </summary>
	public void Setloaner_end_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_end_date field.
	/// </summary>
	public void Setloaner_end_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_end_date field.
	/// </summary>
	public void Setloaner_end_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_end_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.custcontactkey field.
	/// </summary>
	public ColumnValue GetcustcontactkeyValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.custcontactkey field.
	/// </summary>
	public Int32 GetcustcontactkeyFieldValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_inventory_id field.
	/// </summary>
	public ColumnValue Getloaner_inventory_idValue()
	{
		return this.GetValue(TableUtils.loaner_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_inventory_id field.
	/// </summary>
	public Int32 Getloaner_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.loaner_inventory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_inventory_id field.
	/// </summary>
	public void Setloaner_inventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_inventory_id field.
	/// </summary>
	public void Setloaner_inventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_inventory_id field.
	/// </summary>
	public void Setloaner_inventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_inventory_id field.
	/// </summary>
	public void Setloaner_inventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_inventory_id field.
	/// </summary>
	public void Setloaner_inventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_status_id field.
	/// </summary>
	public ColumnValue Getloaner_status_idValue()
	{
		return this.GetValue(TableUtils.loaner_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_status_id field.
	/// </summary>
	public Int32 Getloaner_status_idFieldValue()
	{
		return this.GetValue(TableUtils.loaner_status_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_status_id field.
	/// </summary>
	public void Setloaner_status_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_status_id field.
	/// </summary>
	public void Setloaner_status_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_status_id field.
	/// </summary>
	public void Setloaner_status_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_status_id field.
	/// </summary>
	public void Setloaner_status_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_status_id field.
	/// </summary>
	public void Setloaner_status_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_status_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_rate field.
	/// </summary>
	public ColumnValue Getloaner_rateValue()
	{
		return this.GetValue(TableUtils.loaner_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_rate field.
	/// </summary>
	public Decimal Getloaner_rateFieldValue()
	{
		return this.GetValue(TableUtils.loaner_rateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_rate field.
	/// </summary>
	public void Setloaner_rateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_rate field.
	/// </summary>
	public void Setloaner_rateFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_rate field.
	/// </summary>
	public void Setloaner_rateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_rate field.
	/// </summary>
	public void Setloaner_rateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_rateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_rate field.
	/// </summary>
	public void Setloaner_rateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_rateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_type_id field.
	/// </summary>
	public ColumnValue Getloaner_type_idValue()
	{
		return this.GetValue(TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_type_id field.
	/// </summary>
	public Int32 Getloaner_type_idFieldValue()
	{
		return this.GetValue(TableUtils.loaner_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_type_id field.
	/// </summary>
	public void Setloaner_type_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_type_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.no_charge field.
	/// </summary>
	public ColumnValue Getno_chargeValue()
	{
		return this.GetValue(TableUtils.no_chargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.no_charge field.
	/// </summary>
	public bool Getno_chargeFieldValue()
	{
		return this.GetValue(TableUtils.no_chargeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.no_charge field.
	/// </summary>
	public void Setno_chargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.no_chargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.no_charge field.
	/// </summary>
	public void Setno_chargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.no_chargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.no_charge field.
	/// </summary>
	public void Setno_chargeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.no_chargeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_return_date field.
	/// </summary>
	public ColumnValue Getloaner_return_dateValue()
	{
		return this.GetValue(TableUtils.loaner_return_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_return_date field.
	/// </summary>
	public DateTime Getloaner_return_dateFieldValue()
	{
		return this.GetValue(TableUtils.loaner_return_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_return_date field.
	/// </summary>
	public void Setloaner_return_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_return_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_return_date field.
	/// </summary>
	public void Setloaner_return_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_return_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_return_date field.
	/// </summary>
	public void Setloaner_return_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_return_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_returned_to field.
	/// </summary>
	public ColumnValue Getloaner_returned_toValue()
	{
		return this.GetValue(TableUtils.loaner_returned_toColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.loaner_returned_to field.
	/// </summary>
	public Int32 Getloaner_returned_toFieldValue()
	{
		return this.GetValue(TableUtils.loaner_returned_toColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_returned_to field.
	/// </summary>
	public void Setloaner_returned_toFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_returned_toColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_returned_to field.
	/// </summary>
	public void Setloaner_returned_toFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_returned_toColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_returned_to field.
	/// </summary>
	public void Setloaner_returned_toFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_returned_toColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_returned_to field.
	/// </summary>
	public void Setloaner_returned_toFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_returned_toColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_returned_to field.
	/// </summary>
	public void Setloaner_returned_toFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_returned_toColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.request_type_id field.
	/// </summary>
	public ColumnValue Getrequest_type_idValue()
	{
		return this.GetValue(TableUtils.request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.request_type_id field.
	/// </summary>
	public Int32 Getrequest_type_idFieldValue()
	{
		return this.GetValue(TableUtils.request_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.request_type_id field.
	/// </summary>
	public void Setrequest_type_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.request_type_id field.
	/// </summary>
	public void Setrequest_type_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.request_type_id field.
	/// </summary>
	public void Setrequest_type_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.request_type_id field.
	/// </summary>
	public void Setrequest_type_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.request_type_id field.
	/// </summary>
	public void Setrequest_type_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_type_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.delivered_by field.
	/// </summary>
	public ColumnValue Getdelivered_byValue()
	{
		return this.GetValue(TableUtils.delivered_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.delivered_by field.
	/// </summary>
	public Int32 Getdelivered_byFieldValue()
	{
		return this.GetValue(TableUtils.delivered_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.delivered_by field.
	/// </summary>
	public void Setdelivered_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.delivered_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.delivered_by field.
	/// </summary>
	public void Setdelivered_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.delivered_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.delivered_by field.
	/// </summary>
	public void Setdelivered_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.delivered_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.delivered_by field.
	/// </summary>
	public void Setdelivered_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.delivered_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.delivered_by field.
	/// </summary>
	public void Setdelivered_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.delivered_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.rono field.
	/// </summary>
	public ColumnValue GetronoValue()
	{
		return this.GetValue(TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_request_.rono field.
	/// </summary>
	public Int32 GetronoFieldValue()
	{
		return this.GetValue(TableUtils.ronoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.rono field.
	/// </summary>
	public void SetronoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.rono field.
	/// </summary>
	public void SetronoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.rono field.
	/// </summary>
	public void SetronoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.rono field.
	/// </summary>
	public void SetronoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.rono field.
	/// </summary>
	public void SetronoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.loaner_request_id field.
	/// </summary>
	public Int32 loaner_request_id
	{
		get
		{
			return this.GetValue(TableUtils.loaner_request_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_request_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_request_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_request_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_request_id field.
	/// </summary>
	public string loaner_request_idDefault
	{
		get
		{
			return TableUtils.loaner_request_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.loaner_start_date field.
	/// </summary>
	public DateTime loaner_start_date
	{
		get
		{
			return this.GetValue(TableUtils.loaner_start_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_start_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_start_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_start_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_start_date field.
	/// </summary>
	public string loaner_start_dateDefault
	{
		get
		{
			return TableUtils.loaner_start_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.loaner_end_date field.
	/// </summary>
	public DateTime loaner_end_date
	{
		get
		{
			return this.GetValue(TableUtils.loaner_end_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_end_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_end_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_end_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_end_date field.
	/// </summary>
	public string loaner_end_dateDefault
	{
		get
		{
			return TableUtils.loaner_end_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.custcontactkey field.
	/// </summary>
	public Int32 custcontactkey
	{
		get
		{
			return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custcontactkeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custcontactkeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custcontactkeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.custcontactkey field.
	/// </summary>
	public string custcontactkeyDefault
	{
		get
		{
			return TableUtils.custcontactkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.loaner_inventory_id field.
	/// </summary>
	public Int32 loaner_inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.loaner_inventory_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_inventory_id field.
	/// </summary>
	public string loaner_inventory_idDefault
	{
		get
		{
			return TableUtils.loaner_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.loaner_status_id field.
	/// </summary>
	public Int32 loaner_status_id
	{
		get
		{
			return this.GetValue(TableUtils.loaner_status_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_status_id field.
	/// </summary>
	public string loaner_status_idDefault
	{
		get
		{
			return TableUtils.loaner_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.loaner_rate field.
	/// </summary>
	public Decimal loaner_rate
	{
		get
		{
			return this.GetValue(TableUtils.loaner_rateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_rateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_rateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_rateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_rate field.
	/// </summary>
	public string loaner_rateDefault
	{
		get
		{
			return TableUtils.loaner_rateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.loaner_type_id field.
	/// </summary>
	public Int32 loaner_type_id
	{
		get
		{
			return this.GetValue(TableUtils.loaner_type_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_type_id field.
	/// </summary>
	public string loaner_type_idDefault
	{
		get
		{
			return TableUtils.loaner_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.created_by field.
	/// </summary>
	public Int32 created_by
	{
		get
		{
			return this.GetValue(TableUtils.created_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.created_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool created_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.created_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.created_datetime field.
	/// </summary>
	public DateTime created_datetime
	{
		get
		{
			return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.created_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool created_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.created_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.created_datetime field.
	/// </summary>
	public string created_datetimeDefault
	{
		get
		{
			return TableUtils.created_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.no_charge field.
	/// </summary>
	public bool no_charge
	{
		get
		{
			return this.GetValue(TableUtils.no_chargeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.no_chargeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool no_chargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.no_chargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.no_charge field.
	/// </summary>
	public string no_chargeDefault
	{
		get
		{
			return TableUtils.no_chargeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.loaner_return_date field.
	/// </summary>
	public DateTime loaner_return_date
	{
		get
		{
			return this.GetValue(TableUtils.loaner_return_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_return_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_return_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_return_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_return_date field.
	/// </summary>
	public string loaner_return_dateDefault
	{
		get
		{
			return TableUtils.loaner_return_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.loaner_returned_to field.
	/// </summary>
	public Int32 loaner_returned_to
	{
		get
		{
			return this.GetValue(TableUtils.loaner_returned_toColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_returned_toColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_returned_toSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_returned_toColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.loaner_returned_to field.
	/// </summary>
	public string loaner_returned_toDefault
	{
		get
		{
			return TableUtils.loaner_returned_toColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.request_type_id field.
	/// </summary>
	public Int32 request_type_id
	{
		get
		{
			return this.GetValue(TableUtils.request_type_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.request_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool request_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.request_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.request_type_id field.
	/// </summary>
	public string request_type_idDefault
	{
		get
		{
			return TableUtils.request_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.delivered_by field.
	/// </summary>
	public Int32 delivered_by
	{
		get
		{
			return this.GetValue(TableUtils.delivered_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.delivered_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool delivered_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.delivered_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.delivered_by field.
	/// </summary>
	public string delivered_byDefault
	{
		get
		{
			return TableUtils.delivered_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_request_.rono field.
	/// </summary>
	public Int32 rono
	{
		get
		{
			return this.GetValue(TableUtils.ronoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ronoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ronoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ronoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_request_.rono field.
	/// </summary>
	public string ronoDefault
	{
		get
		{
			return TableUtils.ronoColumn.DefaultValue;
		}
	}


#endregion
}

}
