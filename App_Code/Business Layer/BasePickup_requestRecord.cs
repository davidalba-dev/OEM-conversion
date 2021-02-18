// This class is "generated" and will be overwritten.
// Your customizations should be made in Pickup_requestRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Pickup_requestRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Pickup_requestTable"></see> class.
/// </remarks>
/// <seealso cref="Pickup_requestTable"></seealso>
/// <seealso cref="Pickup_requestRecord"></seealso>
public class BasePickup_requestRecord : PrimaryKeyRecord
{

	public readonly static Pickup_requestTable TableUtils = Pickup_requestTable.Instance;

	// Constructors
 
	protected BasePickup_requestRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Pickup_requestRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Pickup_requestRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Pickup_requestRecord_ReadRecord); 
	}

	protected BasePickup_requestRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Pickup_requestRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Pickup_requestRecord Pickup_requestRec = (Pickup_requestRecord)sender;
        if(Pickup_requestRec != null && !Pickup_requestRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Pickup_requestRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Pickup_requestRecord Pickup_requestRec = (Pickup_requestRecord)sender;
        Validate_Inserting();
        if(Pickup_requestRec != null && !Pickup_requestRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Pickup_requestRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Pickup_requestRecord Pickup_requestRec = (Pickup_requestRecord)sender;
        Validate_Updating();
        if(Pickup_requestRec != null && !Pickup_requestRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_request_id field.
	/// </summary>
	public ColumnValue Getpickup_request_idValue()
	{
		return this.GetValue(TableUtils.pickup_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_request_id field.
	/// </summary>
	public Int32 Getpickup_request_idFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_request_type_id field.
	/// </summary>
	public ColumnValue Getpickup_request_type_idValue()
	{
		return this.GetValue(TableUtils.pickup_request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_request_type_id field.
	/// </summary>
	public Int32 Getpickup_request_type_idFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_request_type_id field.
	/// </summary>
	public void Setpickup_request_type_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_request_type_id field.
	/// </summary>
	public void Setpickup_request_type_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_request_type_id field.
	/// </summary>
	public void Setpickup_request_type_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_request_type_id field.
	/// </summary>
	public void Setpickup_request_type_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_request_type_id field.
	/// </summary>
	public void Setpickup_request_type_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_type_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_custno field.
	/// </summary>
	public ColumnValue Getpickup_custnoValue()
	{
		return this.GetValue(TableUtils.pickup_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_custno field.
	/// </summary>
	public Int32 Getpickup_custnoFieldValue()
	{
		return this.GetValue(TableUtils.pickup_custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_custno field.
	/// </summary>
	public void Setpickup_custnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_custno field.
	/// </summary>
	public void Setpickup_custnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_custno field.
	/// </summary>
	public void Setpickup_custnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_custno field.
	/// </summary>
	public void Setpickup_custnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_custno field.
	/// </summary>
	public void Setpickup_custnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_customercontact field.
	/// </summary>
	public ColumnValue Getpickup_customercontactValue()
	{
		return this.GetValue(TableUtils.pickup_customercontactColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_customercontact field.
	/// </summary>
	public Int32 Getpickup_customercontactFieldValue()
	{
		return this.GetValue(TableUtils.pickup_customercontactColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_customercontact field.
	/// </summary>
	public void Setpickup_customercontactFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_customercontactColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_customercontact field.
	/// </summary>
	public void Setpickup_customercontactFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_customercontactColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_customercontact field.
	/// </summary>
	public void Setpickup_customercontactFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_customercontactColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_customercontact field.
	/// </summary>
	public void Setpickup_customercontactFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_customercontactColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_customercontact field.
	/// </summary>
	public void Setpickup_customercontactFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_customercontactColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_address field.
	/// </summary>
	public ColumnValue Getpickup_addressValue()
	{
		return this.GetValue(TableUtils.pickup_addressColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_address field.
	/// </summary>
	public string Getpickup_addressFieldValue()
	{
		return this.GetValue(TableUtils.pickup_addressColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_address field.
	/// </summary>
	public void Setpickup_addressFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_addressColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_address field.
	/// </summary>
	public void Setpickup_addressFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_addressColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_address2 field.
	/// </summary>
	public ColumnValue Getpickup_address2Value()
	{
		return this.GetValue(TableUtils.pickup_address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_address2 field.
	/// </summary>
	public string Getpickup_address2FieldValue()
	{
		return this.GetValue(TableUtils.pickup_address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_address2 field.
	/// </summary>
	public void Setpickup_address2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_address2 field.
	/// </summary>
	public void Setpickup_address2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_city field.
	/// </summary>
	public ColumnValue Getpickup_cityValue()
	{
		return this.GetValue(TableUtils.pickup_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_city field.
	/// </summary>
	public string Getpickup_cityFieldValue()
	{
		return this.GetValue(TableUtils.pickup_cityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_city field.
	/// </summary>
	public void Setpickup_cityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_cityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_city field.
	/// </summary>
	public void Setpickup_cityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_cityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.provname field.
	/// </summary>
	public ColumnValue GetprovnameValue()
	{
		return this.GetValue(TableUtils.provnameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.provname field.
	/// </summary>
	public string GetprovnameFieldValue()
	{
		return this.GetValue(TableUtils.provnameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.provname field.
	/// </summary>
	public void SetprovnameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.provnameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.provname field.
	/// </summary>
	public void SetprovnameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.provnameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_zipcode field.
	/// </summary>
	public ColumnValue Getpickup_zipcodeValue()
	{
		return this.GetValue(TableUtils.pickup_zipcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_zipcode field.
	/// </summary>
	public string Getpickup_zipcodeFieldValue()
	{
		return this.GetValue(TableUtils.pickup_zipcodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_zipcode field.
	/// </summary>
	public void Setpickup_zipcodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_zipcodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_zipcode field.
	/// </summary>
	public void Setpickup_zipcodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_zipcodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_phone field.
	/// </summary>
	public ColumnValue Getpickup_phoneValue()
	{
		return this.GetValue(TableUtils.pickup_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_phone field.
	/// </summary>
	public string Getpickup_phoneFieldValue()
	{
		return this.GetValue(TableUtils.pickup_phoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_phone field.
	/// </summary>
	public void Setpickup_phoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_phoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_phone field.
	/// </summary>
	public void Setpickup_phoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_phoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_datetime field.
	/// </summary>
	public ColumnValue Getpickup_datetimeValue()
	{
		return this.GetValue(TableUtils.pickup_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_datetime field.
	/// </summary>
	public DateTime Getpickup_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.pickup_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_datetime field.
	/// </summary>
	public void Setpickup_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_datetime field.
	/// </summary>
	public void Setpickup_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_datetime field.
	/// </summary>
	public void Setpickup_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_technician field.
	/// </summary>
	public ColumnValue Getpickup_technicianValue()
	{
		return this.GetValue(TableUtils.pickup_technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_technician field.
	/// </summary>
	public Int32 Getpickup_technicianFieldValue()
	{
		return this.GetValue(TableUtils.pickup_technicianColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_technician field.
	/// </summary>
	public void Setpickup_technicianFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_technician field.
	/// </summary>
	public void Setpickup_technicianFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_technician field.
	/// </summary>
	public void Setpickup_technicianFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_technician field.
	/// </summary>
	public void Setpickup_technicianFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_technician field.
	/// </summary>
	public void Setpickup_technicianFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_technicianColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_status_id field.
	/// </summary>
	public ColumnValue Getpickup_status_idValue()
	{
		return this.GetValue(TableUtils.pickup_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_status_id field.
	/// </summary>
	public Int32 Getpickup_status_idFieldValue()
	{
		return this.GetValue(TableUtils.pickup_status_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_status_id field.
	/// </summary>
	public void Setpickup_status_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_status_id field.
	/// </summary>
	public void Setpickup_status_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_status_id field.
	/// </summary>
	public void Setpickup_status_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_status_id field.
	/// </summary>
	public void Setpickup_status_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_status_id field.
	/// </summary>
	public void Setpickup_status_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_status_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_est_hours field.
	/// </summary>
	public ColumnValue Getpickup_est_hoursValue()
	{
		return this.GetValue(TableUtils.pickup_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_est_hours field.
	/// </summary>
	public Int32 Getpickup_est_hoursFieldValue()
	{
		return this.GetValue(TableUtils.pickup_est_hoursColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_hours field.
	/// </summary>
	public void Setpickup_est_hoursFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_hours field.
	/// </summary>
	public void Setpickup_est_hoursFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_hours field.
	/// </summary>
	public void Setpickup_est_hoursFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_hours field.
	/// </summary>
	public void Setpickup_est_hoursFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_est_hoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_hours field.
	/// </summary>
	public void Setpickup_est_hoursFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_est_hoursColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_est_minutes field.
	/// </summary>
	public ColumnValue Getpickup_est_minutesValue()
	{
		return this.GetValue(TableUtils.pickup_est_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.pickup_est_minutes field.
	/// </summary>
	public Int32 Getpickup_est_minutesFieldValue()
	{
		return this.GetValue(TableUtils.pickup_est_minutesColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_minutes field.
	/// </summary>
	public void Setpickup_est_minutesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_est_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_minutes field.
	/// </summary>
	public void Setpickup_est_minutesFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_est_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_minutes field.
	/// </summary>
	public void Setpickup_est_minutesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_est_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_minutes field.
	/// </summary>
	public void Setpickup_est_minutesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_est_minutesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_minutes field.
	/// </summary>
	public void Setpickup_est_minutesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_est_minutesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_request_id field.
	/// </summary>
	public Int32 pickup_request_id
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_request_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_request_id field.
	/// </summary>
	public string pickup_request_idDefault
	{
		get
		{
			return TableUtils.pickup_request_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_request_type_id field.
	/// </summary>
	public Int32 pickup_request_type_id
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_type_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_request_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_request_type_id field.
	/// </summary>
	public string pickup_request_type_idDefault
	{
		get
		{
			return TableUtils.pickup_request_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_custno field.
	/// </summary>
	public Int32 pickup_custno
	{
		get
		{
			return this.GetValue(TableUtils.pickup_custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_custno field.
	/// </summary>
	public string pickup_custnoDefault
	{
		get
		{
			return TableUtils.pickup_custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_customercontact field.
	/// </summary>
	public Int32 pickup_customercontact
	{
		get
		{
			return this.GetValue(TableUtils.pickup_customercontactColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_customercontactColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_customercontactSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_customercontactColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_customercontact field.
	/// </summary>
	public string pickup_customercontactDefault
	{
		get
		{
			return TableUtils.pickup_customercontactColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_address field.
	/// </summary>
	public string pickup_address
	{
		get
		{
			return this.GetValue(TableUtils.pickup_addressColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_addressColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_addressSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_addressColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_address field.
	/// </summary>
	public string pickup_addressDefault
	{
		get
		{
			return TableUtils.pickup_addressColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_address2 field.
	/// </summary>
	public string pickup_address2
	{
		get
		{
			return this.GetValue(TableUtils.pickup_address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_address2 field.
	/// </summary>
	public string pickup_address2Default
	{
		get
		{
			return TableUtils.pickup_address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_city field.
	/// </summary>
	public string pickup_city
	{
		get
		{
			return this.GetValue(TableUtils.pickup_cityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_cityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_citySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_cityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_city field.
	/// </summary>
	public string pickup_cityDefault
	{
		get
		{
			return TableUtils.pickup_cityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.provname field.
	/// </summary>
	public string provname
	{
		get
		{
			return this.GetValue(TableUtils.provnameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.provnameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool provnameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.provnameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.provname field.
	/// </summary>
	public string provnameDefault
	{
		get
		{
			return TableUtils.provnameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_zipcode field.
	/// </summary>
	public string pickup_zipcode
	{
		get
		{
			return this.GetValue(TableUtils.pickup_zipcodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_zipcodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_zipcodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_zipcodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_zipcode field.
	/// </summary>
	public string pickup_zipcodeDefault
	{
		get
		{
			return TableUtils.pickup_zipcodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_phone field.
	/// </summary>
	public string pickup_phone
	{
		get
		{
			return this.GetValue(TableUtils.pickup_phoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_phoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_phoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_phoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_phone field.
	/// </summary>
	public string pickup_phoneDefault
	{
		get
		{
			return TableUtils.pickup_phoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_datetime field.
	/// </summary>
	public DateTime pickup_datetime
	{
		get
		{
			return this.GetValue(TableUtils.pickup_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_datetime field.
	/// </summary>
	public string pickup_datetimeDefault
	{
		get
		{
			return TableUtils.pickup_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_technician field.
	/// </summary>
	public Int32 pickup_technician
	{
		get
		{
			return this.GetValue(TableUtils.pickup_technicianColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_technicianColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_technicianSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_technicianColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_technician field.
	/// </summary>
	public string pickup_technicianDefault
	{
		get
		{
			return TableUtils.pickup_technicianColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_status_id field.
	/// </summary>
	public Int32 pickup_status_id
	{
		get
		{
			return this.GetValue(TableUtils.pickup_status_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_status_id field.
	/// </summary>
	public string pickup_status_idDefault
	{
		get
		{
			return TableUtils.pickup_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_est_hours field.
	/// </summary>
	public Int32 pickup_est_hours
	{
		get
		{
			return this.GetValue(TableUtils.pickup_est_hoursColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_est_hoursColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_est_hoursSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_est_hoursColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_hours field.
	/// </summary>
	public string pickup_est_hoursDefault
	{
		get
		{
			return TableUtils.pickup_est_hoursColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.pickup_est_minutes field.
	/// </summary>
	public Int32 pickup_est_minutes
	{
		get
		{
			return this.GetValue(TableUtils.pickup_est_minutesColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_est_minutesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_est_minutesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_est_minutesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.pickup_est_minutes field.
	/// </summary>
	public string pickup_est_minutesDefault
	{
		get
		{
			return TableUtils.pickup_est_minutesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.created_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_.created_datetime field.
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
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_.created_datetime field.
	/// </summary>
	public string created_datetimeDefault
	{
		get
		{
			return TableUtils.created_datetimeColumn.DefaultValue;
		}
	}


#endregion
}

}
