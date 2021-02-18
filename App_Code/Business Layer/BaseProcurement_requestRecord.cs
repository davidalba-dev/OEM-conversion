// This class is "generated" and will be overwritten.
// Your customizations should be made in Procurement_requestRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Procurement_requestRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Procurement_requestTable"></see> class.
/// </remarks>
/// <seealso cref="Procurement_requestTable"></seealso>
/// <seealso cref="Procurement_requestRecord"></seealso>
public class BaseProcurement_requestRecord : PrimaryKeyRecord
{

	public readonly static Procurement_requestTable TableUtils = Procurement_requestTable.Instance;

	// Constructors
 
	protected BaseProcurement_requestRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Procurement_requestRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Procurement_requestRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Procurement_requestRecord_ReadRecord); 
	}

	protected BaseProcurement_requestRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Procurement_requestRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Procurement_requestRecord Procurement_requestRec = (Procurement_requestRecord)sender;
        if(Procurement_requestRec != null && !Procurement_requestRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Procurement_requestRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Procurement_requestRecord Procurement_requestRec = (Procurement_requestRecord)sender;
        Validate_Inserting();
        if(Procurement_requestRec != null && !Procurement_requestRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Procurement_requestRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Procurement_requestRecord Procurement_requestRec = (Procurement_requestRecord)sender;
        Validate_Updating();
        if(Procurement_requestRec != null && !Procurement_requestRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_request_id field.
	/// </summary>
	public ColumnValue Getprocurement_request_idValue()
	{
		return this.GetValue(TableUtils.procurement_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_request_id field.
	/// </summary>
	public Int32 Getprocurement_request_idFieldValue()
	{
		return this.GetValue(TableUtils.procurement_request_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.corporate_id field.
	/// </summary>
	public ColumnValue Getcorporate_idValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.corporate_id field.
	/// </summary>
	public Int32 Getcorporate_idFieldValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.custcontactkey field.
	/// </summary>
	public ColumnValue GetcustcontactkeyValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.custcontactkey field.
	/// </summary>
	public Int32 GetcustcontactkeyFieldValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_make field.
	/// </summary>
	public ColumnValue Getprocurement_makeValue()
	{
		return this.GetValue(TableUtils.procurement_makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_make field.
	/// </summary>
	public string Getprocurement_makeFieldValue()
	{
		return this.GetValue(TableUtils.procurement_makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_make field.
	/// </summary>
	public void Setprocurement_makeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.procurement_makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_make field.
	/// </summary>
	public void Setprocurement_makeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.procurement_makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_model field.
	/// </summary>
	public ColumnValue Getprocurement_modelValue()
	{
		return this.GetValue(TableUtils.procurement_modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_model field.
	/// </summary>
	public string Getprocurement_modelFieldValue()
	{
		return this.GetValue(TableUtils.procurement_modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_model field.
	/// </summary>
	public void Setprocurement_modelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.procurement_modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_model field.
	/// </summary>
	public void Setprocurement_modelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.procurement_modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.department_id field.
	/// </summary>
	public ColumnValue Getdepartment_idValue()
	{
		return this.GetValue(TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.department_id field.
	/// </summary>
	public Int32 Getdepartment_idFieldValue()
	{
		return this.GetValue(TableUtils.department_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_status_id field.
	/// </summary>
	public ColumnValue Getprocurement_status_idValue()
	{
		return this.GetValue(TableUtils.procurement_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_status_id field.
	/// </summary>
	public Int32 Getprocurement_status_idFieldValue()
	{
		return this.GetValue(TableUtils.procurement_status_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_status_id field.
	/// </summary>
	public void Setprocurement_status_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.procurement_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_status_id field.
	/// </summary>
	public void Setprocurement_status_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.procurement_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_status_id field.
	/// </summary>
	public void Setprocurement_status_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.procurement_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_status_id field.
	/// </summary>
	public void Setprocurement_status_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.procurement_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_status_id field.
	/// </summary>
	public void Setprocurement_status_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.procurement_status_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.new_replace field.
	/// </summary>
	public ColumnValue Getnew_replaceValue()
	{
		return this.GetValue(TableUtils.new_replaceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.new_replace field.
	/// </summary>
	public string Getnew_replaceFieldValue()
	{
		return this.GetValue(TableUtils.new_replaceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.new_replace field.
	/// </summary>
	public void Setnew_replaceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.new_replaceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.new_replace field.
	/// </summary>
	public void Setnew_replaceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_replaceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_pref_make field.
	/// </summary>
	public ColumnValue Getprocurement_pref_makeValue()
	{
		return this.GetValue(TableUtils.procurement_pref_makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_pref_make field.
	/// </summary>
	public string Getprocurement_pref_makeFieldValue()
	{
		return this.GetValue(TableUtils.procurement_pref_makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_pref_make field.
	/// </summary>
	public void Setprocurement_pref_makeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.procurement_pref_makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_pref_make field.
	/// </summary>
	public void Setprocurement_pref_makeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.procurement_pref_makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_pref_model field.
	/// </summary>
	public ColumnValue Getprocurement_pref_modelValue()
	{
		return this.GetValue(TableUtils.procurement_pref_modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.procurement_pref_model field.
	/// </summary>
	public string Getprocurement_pref_modelFieldValue()
	{
		return this.GetValue(TableUtils.procurement_pref_modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_pref_model field.
	/// </summary>
	public void Setprocurement_pref_modelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.procurement_pref_modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_pref_model field.
	/// </summary>
	public void Setprocurement_pref_modelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.procurement_pref_modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.age field.
	/// </summary>
	public ColumnValue GetageValue()
	{
		return this.GetValue(TableUtils.ageColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.age field.
	/// </summary>
	public Int32 GetageFieldValue()
	{
		return this.GetValue(TableUtils.ageColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.age field.
	/// </summary>
	public void SetageFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.age field.
	/// </summary>
	public void SetageFieldValue(string val)
	{
		this.SetString(val, TableUtils.ageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.age field.
	/// </summary>
	public void SetageFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.age field.
	/// </summary>
	public void SetageFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.age field.
	/// </summary>
	public void SetageFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ageColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.manufacturer_id field.
	/// </summary>
	public ColumnValue Getmanufacturer_idValue()
	{
		return this.GetValue(TableUtils.manufacturer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.manufacturer_id field.
	/// </summary>
	public Int32 Getmanufacturer_idFieldValue()
	{
		return this.GetValue(TableUtils.manufacturer_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.manufacturer_id field.
	/// </summary>
	public void Setmanufacturer_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.manufacturer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.manufacturer_id field.
	/// </summary>
	public void Setmanufacturer_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.manufacturer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.manufacturer_id field.
	/// </summary>
	public void Setmanufacturer_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.manufacturer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.manufacturer_id field.
	/// </summary>
	public void Setmanufacturer_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.manufacturer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.manufacturer_id field.
	/// </summary>
	public void Setmanufacturer_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.manufacturer_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.manufacturer_other field.
	/// </summary>
	public ColumnValue Getmanufacturer_otherValue()
	{
		return this.GetValue(TableUtils.manufacturer_otherColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.manufacturer_other field.
	/// </summary>
	public string Getmanufacturer_otherFieldValue()
	{
		return this.GetValue(TableUtils.manufacturer_otherColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.manufacturer_other field.
	/// </summary>
	public void Setmanufacturer_otherFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.manufacturer_otherColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.manufacturer_other field.
	/// </summary>
	public void Setmanufacturer_otherFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.manufacturer_otherColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.replacement_make field.
	/// </summary>
	public ColumnValue Getreplacement_makeValue()
	{
		return this.GetValue(TableUtils.replacement_makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.replacement_make field.
	/// </summary>
	public string Getreplacement_makeFieldValue()
	{
		return this.GetValue(TableUtils.replacement_makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_make field.
	/// </summary>
	public void Setreplacement_makeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.replacement_makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_make field.
	/// </summary>
	public void Setreplacement_makeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.replacement_makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.replacement_model field.
	/// </summary>
	public ColumnValue Getreplacement_modelValue()
	{
		return this.GetValue(TableUtils.replacement_modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.replacement_model field.
	/// </summary>
	public string Getreplacement_modelFieldValue()
	{
		return this.GetValue(TableUtils.replacement_modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_model field.
	/// </summary>
	public void Setreplacement_modelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.replacement_modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_model field.
	/// </summary>
	public void Setreplacement_modelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.replacement_modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.budget_approved field.
	/// </summary>
	public ColumnValue Getbudget_approvedValue()
	{
		return this.GetValue(TableUtils.budget_approvedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.budget_approved field.
	/// </summary>
	public Decimal Getbudget_approvedFieldValue()
	{
		return this.GetValue(TableUtils.budget_approvedColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.budget_approved field.
	/// </summary>
	public void Setbudget_approvedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.budget_approvedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.budget_approved field.
	/// </summary>
	public void Setbudget_approvedFieldValue(string val)
	{
		this.SetString(val, TableUtils.budget_approvedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.budget_approved field.
	/// </summary>
	public void Setbudget_approvedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.budget_approvedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.budget_approved field.
	/// </summary>
	public void Setbudget_approvedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.budget_approvedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.budget_approved field.
	/// </summary>
	public void Setbudget_approvedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.budget_approvedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.desired_install_datetime field.
	/// </summary>
	public ColumnValue Getdesired_install_datetimeValue()
	{
		return this.GetValue(TableUtils.desired_install_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.desired_install_datetime field.
	/// </summary>
	public DateTime Getdesired_install_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.desired_install_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.desired_install_datetime field.
	/// </summary>
	public void Setdesired_install_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.desired_install_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.desired_install_datetime field.
	/// </summary>
	public void Setdesired_install_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.desired_install_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.desired_install_datetime field.
	/// </summary>
	public void Setdesired_install_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.desired_install_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.afterhours field.
	/// </summary>
	public ColumnValue GetafterhoursValue()
	{
		return this.GetValue(TableUtils.afterhoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.afterhours field.
	/// </summary>
	public bool GetafterhoursFieldValue()
	{
		return this.GetValue(TableUtils.afterhoursColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.afterhours field.
	/// </summary>
	public void SetafterhoursFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.afterhoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.afterhours field.
	/// </summary>
	public void SetafterhoursFieldValue(string val)
	{
		this.SetString(val, TableUtils.afterhoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.afterhours field.
	/// </summary>
	public void SetafterhoursFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.afterhoursColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.equipment_requested field.
	/// </summary>
	public ColumnValue Getequipment_requestedValue()
	{
		return this.GetValue(TableUtils.equipment_requestedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.equipment_requested field.
	/// </summary>
	public string Getequipment_requestedFieldValue()
	{
		return this.GetValue(TableUtils.equipment_requestedColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.equipment_requested field.
	/// </summary>
	public void Setequipment_requestedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_requestedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.equipment_requested field.
	/// </summary>
	public void Setequipment_requestedFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_requestedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.request_status_id field.
	/// </summary>
	public ColumnValue Getrequest_status_idValue()
	{
		return this.GetValue(TableUtils.request_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.request_status_id field.
	/// </summary>
	public Int32 Getrequest_status_idFieldValue()
	{
		return this.GetValue(TableUtils.request_status_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_status_id field.
	/// </summary>
	public void Setrequest_status_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.request_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_status_id field.
	/// </summary>
	public void Setrequest_status_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.request_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_status_id field.
	/// </summary>
	public void Setrequest_status_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_status_id field.
	/// </summary>
	public void Setrequest_status_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_status_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_status_id field.
	/// </summary>
	public void Setrequest_status_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_status_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.replacement_make_other field.
	/// </summary>
	public ColumnValue Getreplacement_make_otherValue()
	{
		return this.GetValue(TableUtils.replacement_make_otherColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.replacement_make_other field.
	/// </summary>
	public string Getreplacement_make_otherFieldValue()
	{
		return this.GetValue(TableUtils.replacement_make_otherColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_make_other field.
	/// </summary>
	public void Setreplacement_make_otherFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.replacement_make_otherColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_make_other field.
	/// </summary>
	public void Setreplacement_make_otherFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.replacement_make_otherColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.replacement_model_other field.
	/// </summary>
	public ColumnValue Getreplacement_model_otherValue()
	{
		return this.GetValue(TableUtils.replacement_model_otherColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.replacement_model_other field.
	/// </summary>
	public string Getreplacement_model_otherFieldValue()
	{
		return this.GetValue(TableUtils.replacement_model_otherColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_model_other field.
	/// </summary>
	public void Setreplacement_model_otherFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.replacement_model_otherColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_model_other field.
	/// </summary>
	public void Setreplacement_model_otherFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.replacement_model_otherColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.request_datetime field.
	/// </summary>
	public ColumnValue Getrequest_datetimeValue()
	{
		return this.GetValue(TableUtils.request_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_request_.request_datetime field.
	/// </summary>
	public DateTime Getrequest_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.request_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_datetime field.
	/// </summary>
	public void Setrequest_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.request_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_datetime field.
	/// </summary>
	public void Setrequest_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.request_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_datetime field.
	/// </summary>
	public void Setrequest_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_datetimeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.procurement_request_id field.
	/// </summary>
	public Int32 procurement_request_id
	{
		get
		{
			return this.GetValue(TableUtils.procurement_request_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.procurement_request_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_request_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_request_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_request_id field.
	/// </summary>
	public string procurement_request_idDefault
	{
		get
		{
			return TableUtils.procurement_request_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.corporate_id field.
	/// </summary>
	public Int32 corporate_id
	{
		get
		{
			return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.corporate_id field.
	/// </summary>
	public string corporate_idDefault
	{
		get
		{
			return TableUtils.corporate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.custcontactkey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.custcontactkey field.
	/// </summary>
	public string custcontactkeyDefault
	{
		get
		{
			return TableUtils.custcontactkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.category_id field.
	/// </summary>
	public Int32 category_id
	{
		get
		{
			return this.GetValue(TableUtils.category_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.category_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool category_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.category_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.category_id field.
	/// </summary>
	public string category_idDefault
	{
		get
		{
			return TableUtils.category_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.procurement_make field.
	/// </summary>
	public string procurement_make
	{
		get
		{
			return this.GetValue(TableUtils.procurement_makeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.procurement_makeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_makeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_makeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_make field.
	/// </summary>
	public string procurement_makeDefault
	{
		get
		{
			return TableUtils.procurement_makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.procurement_model field.
	/// </summary>
	public string procurement_model
	{
		get
		{
			return this.GetValue(TableUtils.procurement_modelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.procurement_modelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_modelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_modelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_model field.
	/// </summary>
	public string procurement_modelDefault
	{
		get
		{
			return TableUtils.procurement_modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.department_id field.
	/// </summary>
	public Int32 department_id
	{
		get
		{
			return this.GetValue(TableUtils.department_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.department_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool department_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.department_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.department_id field.
	/// </summary>
	public string department_idDefault
	{
		get
		{
			return TableUtils.department_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.procurement_status_id field.
	/// </summary>
	public Int32 procurement_status_id
	{
		get
		{
			return this.GetValue(TableUtils.procurement_status_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.procurement_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_status_id field.
	/// </summary>
	public string procurement_status_idDefault
	{
		get
		{
			return TableUtils.procurement_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.new_replace field.
	/// </summary>
	public string new_replace
	{
		get
		{
			return this.GetValue(TableUtils.new_replaceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.new_replaceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool new_replaceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.new_replaceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.new_replace field.
	/// </summary>
	public string new_replaceDefault
	{
		get
		{
			return TableUtils.new_replaceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.procurement_pref_make field.
	/// </summary>
	public string procurement_pref_make
	{
		get
		{
			return this.GetValue(TableUtils.procurement_pref_makeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.procurement_pref_makeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_pref_makeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_pref_makeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_pref_make field.
	/// </summary>
	public string procurement_pref_makeDefault
	{
		get
		{
			return TableUtils.procurement_pref_makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.procurement_pref_model field.
	/// </summary>
	public string procurement_pref_model
	{
		get
		{
			return this.GetValue(TableUtils.procurement_pref_modelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.procurement_pref_modelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_pref_modelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_pref_modelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.procurement_pref_model field.
	/// </summary>
	public string procurement_pref_modelDefault
	{
		get
		{
			return TableUtils.procurement_pref_modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.age field.
	/// </summary>
	public Int32 age
	{
		get
		{
			return this.GetValue(TableUtils.ageColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ageColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ageSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ageColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.age field.
	/// </summary>
	public string ageDefault
	{
		get
		{
			return TableUtils.ageColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.manufacturer_id field.
	/// </summary>
	public Int32 manufacturer_id
	{
		get
		{
			return this.GetValue(TableUtils.manufacturer_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.manufacturer_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool manufacturer_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.manufacturer_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.manufacturer_id field.
	/// </summary>
	public string manufacturer_idDefault
	{
		get
		{
			return TableUtils.manufacturer_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.manufacturer_other field.
	/// </summary>
	public string manufacturer_other
	{
		get
		{
			return this.GetValue(TableUtils.manufacturer_otherColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.manufacturer_otherColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool manufacturer_otherSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.manufacturer_otherColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.manufacturer_other field.
	/// </summary>
	public string manufacturer_otherDefault
	{
		get
		{
			return TableUtils.manufacturer_otherColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.replacement_make field.
	/// </summary>
	public string replacement_make
	{
		get
		{
			return this.GetValue(TableUtils.replacement_makeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.replacement_makeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool replacement_makeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.replacement_makeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_make field.
	/// </summary>
	public string replacement_makeDefault
	{
		get
		{
			return TableUtils.replacement_makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.replacement_model field.
	/// </summary>
	public string replacement_model
	{
		get
		{
			return this.GetValue(TableUtils.replacement_modelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.replacement_modelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool replacement_modelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.replacement_modelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_model field.
	/// </summary>
	public string replacement_modelDefault
	{
		get
		{
			return TableUtils.replacement_modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.budget_approved field.
	/// </summary>
	public Decimal budget_approved
	{
		get
		{
			return this.GetValue(TableUtils.budget_approvedColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.budget_approvedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool budget_approvedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.budget_approvedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.budget_approved field.
	/// </summary>
	public string budget_approvedDefault
	{
		get
		{
			return TableUtils.budget_approvedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.desired_install_datetime field.
	/// </summary>
	public DateTime desired_install_datetime
	{
		get
		{
			return this.GetValue(TableUtils.desired_install_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.desired_install_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool desired_install_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.desired_install_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.desired_install_datetime field.
	/// </summary>
	public string desired_install_datetimeDefault
	{
		get
		{
			return TableUtils.desired_install_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.afterhours field.
	/// </summary>
	public bool afterhours
	{
		get
		{
			return this.GetValue(TableUtils.afterhoursColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.afterhoursColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool afterhoursSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.afterhoursColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.afterhours field.
	/// </summary>
	public string afterhoursDefault
	{
		get
		{
			return TableUtils.afterhoursColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.equipment_requested field.
	/// </summary>
	public string equipment_requested
	{
		get
		{
			return this.GetValue(TableUtils.equipment_requestedColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_requestedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_requestedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_requestedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.equipment_requested field.
	/// </summary>
	public string equipment_requestedDefault
	{
		get
		{
			return TableUtils.equipment_requestedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.request_status_id field.
	/// </summary>
	public Int32 request_status_id
	{
		get
		{
			return this.GetValue(TableUtils.request_status_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.request_status_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool request_status_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.request_status_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_status_id field.
	/// </summary>
	public string request_status_idDefault
	{
		get
		{
			return TableUtils.request_status_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.replacement_make_other field.
	/// </summary>
	public string replacement_make_other
	{
		get
		{
			return this.GetValue(TableUtils.replacement_make_otherColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.replacement_make_otherColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool replacement_make_otherSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.replacement_make_otherColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_make_other field.
	/// </summary>
	public string replacement_make_otherDefault
	{
		get
		{
			return TableUtils.replacement_make_otherColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.replacement_model_other field.
	/// </summary>
	public string replacement_model_other
	{
		get
		{
			return this.GetValue(TableUtils.replacement_model_otherColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.replacement_model_otherColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool replacement_model_otherSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.replacement_model_otherColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.replacement_model_other field.
	/// </summary>
	public string replacement_model_otherDefault
	{
		get
		{
			return TableUtils.replacement_model_otherColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_request_.request_datetime field.
	/// </summary>
	public DateTime request_datetime
	{
		get
		{
			return this.GetValue(TableUtils.request_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.request_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool request_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.request_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_request_.request_datetime field.
	/// </summary>
	public string request_datetimeDefault
	{
		get
		{
			return TableUtils.request_datetimeColumn.DefaultValue;
		}
	}


#endregion
}

}
