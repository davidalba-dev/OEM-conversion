// This class is "generated" and will be overwritten.
// Your customizations should be made in Site_inventory_contractRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Site_inventory_contractRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Site_inventory_contractTable"></see> class.
/// </remarks>
/// <seealso cref="Site_inventory_contractTable"></seealso>
/// <seealso cref="Site_inventory_contractRecord"></seealso>
public class BaseSite_inventory_contractRecord : PrimaryKeyRecord
{

	public readonly static Site_inventory_contractTable TableUtils = Site_inventory_contractTable.Instance;

	// Constructors
 
	protected BaseSite_inventory_contractRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Site_inventory_contractRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Site_inventory_contractRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Site_inventory_contractRecord_ReadRecord); 
	}

	protected BaseSite_inventory_contractRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Site_inventory_contractRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Site_inventory_contractRecord Site_inventory_contractRec = (Site_inventory_contractRecord)sender;
        if(Site_inventory_contractRec != null && !Site_inventory_contractRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Site_inventory_contractRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Site_inventory_contractRecord Site_inventory_contractRec = (Site_inventory_contractRecord)sender;
        Validate_Inserting();
        if(Site_inventory_contractRec != null && !Site_inventory_contractRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Site_inventory_contractRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Site_inventory_contractRecord Site_inventory_contractRec = (Site_inventory_contractRecord)sender;
        Validate_Updating();
        if(Site_inventory_contractRec != null && !Site_inventory_contractRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.site_inventory_contract_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_contract_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.site_inventory_contract_id field.
	/// </summary>
	public Int32 Getsite_inventory_contract_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.start_date field.
	/// </summary>
	public ColumnValue Getstart_dateValue()
	{
		return this.GetValue(TableUtils.start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.start_date field.
	/// </summary>
	public DateTime Getstart_dateFieldValue()
	{
		return this.GetValue(TableUtils.start_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.start_date field.
	/// </summary>
	public void Setstart_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.start_date field.
	/// </summary>
	public void Setstart_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.start_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.start_date field.
	/// </summary>
	public void Setstart_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.start_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.end_date field.
	/// </summary>
	public ColumnValue Getend_dateValue()
	{
		return this.GetValue(TableUtils.end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.end_date field.
	/// </summary>
	public DateTime Getend_dateFieldValue()
	{
		return this.GetValue(TableUtils.end_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.end_date field.
	/// </summary>
	public void Setend_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.end_date field.
	/// </summary>
	public void Setend_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.end_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.end_date field.
	/// </summary>
	public void Setend_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.end_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.contract_number field.
	/// </summary>
	public ColumnValue Getcontract_numberValue()
	{
		return this.GetValue(TableUtils.contract_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.contract_number field.
	/// </summary>
	public string Getcontract_numberFieldValue()
	{
		return this.GetValue(TableUtils.contract_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_number field.
	/// </summary>
	public void Setcontract_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_number field.
	/// </summary>
	public void Setcontract_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.custcontactkey field.
	/// </summary>
	public ColumnValue GetcustcontactkeyValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.custcontactkey field.
	/// </summary>
	public Int32 GetcustcontactkeyFieldValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.contract_details field.
	/// </summary>
	public ColumnValue Getcontract_detailsValue()
	{
		return this.GetValue(TableUtils.contract_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.contract_details field.
	/// </summary>
	public string Getcontract_detailsFieldValue()
	{
		return this.GetValue(TableUtils.contract_detailsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_details field.
	/// </summary>
	public void Setcontract_detailsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_details field.
	/// </summary>
	public void Setcontract_detailsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_detailsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.contract_active field.
	/// </summary>
	public ColumnValue Getcontract_activeValue()
	{
		return this.GetValue(TableUtils.contract_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.contract_active field.
	/// </summary>
	public bool Getcontract_activeFieldValue()
	{
		return this.GetValue(TableUtils.contract_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_active field.
	/// </summary>
	public void Setcontract_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_active field.
	/// </summary>
	public void Setcontract_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.contract_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_active field.
	/// </summary>
	public void Setcontract_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.corporate_id field.
	/// </summary>
	public ColumnValue Getcorporate_idValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.corporate_id field.
	/// </summary>
	public Int32 Getcorporate_idFieldValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.corporatecontact_id field.
	/// </summary>
	public ColumnValue Getcorporatecontact_idValue()
	{
		return this.GetValue(TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.corporatecontact_id field.
	/// </summary>
	public Int32 Getcorporatecontact_idFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.contract_total_amt field.
	/// </summary>
	public ColumnValue Getcontract_total_amtValue()
	{
		return this.GetValue(TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's site_inventory_contract_.contract_total_amt field.
	/// </summary>
	public Decimal Getcontract_total_amtFieldValue()
	{
		return this.GetValue(TableUtils.contract_total_amtColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(string val)
	{
		this.SetString(val, TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_total_amtColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.site_inventory_contract_id field.
	/// </summary>
	public Int32 site_inventory_contract_id
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_contract_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_contract_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_contract_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.site_inventory_contract_id field.
	/// </summary>
	public string site_inventory_contract_idDefault
	{
		get
		{
			return TableUtils.site_inventory_contract_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.start_date field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.start_date field.
	/// </summary>
	public string start_dateDefault
	{
		get
		{
			return TableUtils.start_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.end_date field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.end_date field.
	/// </summary>
	public string end_dateDefault
	{
		get
		{
			return TableUtils.end_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.contract_number field.
	/// </summary>
	public string contract_number
	{
		get
		{
			return this.GetValue(TableUtils.contract_numberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_numberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_numberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_numberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_number field.
	/// </summary>
	public string contract_numberDefault
	{
		get
		{
			return TableUtils.contract_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.custcontactkey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custcontactkey field.
	/// </summary>
	public string custcontactkeyDefault
	{
		get
		{
			return TableUtils.custcontactkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.contract_details field.
	/// </summary>
	public string contract_details
	{
		get
		{
			return this.GetValue(TableUtils.contract_detailsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_detailsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_detailsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_detailsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_details field.
	/// </summary>
	public string contract_detailsDefault
	{
		get
		{
			return TableUtils.contract_detailsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.contract_active field.
	/// </summary>
	public bool contract_active
	{
		get
		{
			return this.GetValue(TableUtils.contract_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.contract_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_active field.
	/// </summary>
	public string contract_activeDefault
	{
		get
		{
			return TableUtils.contract_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.corporate_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporate_id field.
	/// </summary>
	public string corporate_idDefault
	{
		get
		{
			return TableUtils.corporate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.corporatecontact_id field.
	/// </summary>
	public Int32 corporatecontact_id
	{
		get
		{
			return this.GetValue(TableUtils.corporatecontact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporatecontact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporatecontact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporatecontact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.corporatecontact_id field.
	/// </summary>
	public string corporatecontact_idDefault
	{
		get
		{
			return TableUtils.corporatecontact_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.created_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.created_datetime field.
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
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.created_datetime field.
	/// </summary>
	public string created_datetimeDefault
	{
		get
		{
			return TableUtils.created_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's site_inventory_contract_.contract_total_amt field.
	/// </summary>
	public Decimal contract_total_amt
	{
		get
		{
			return this.GetValue(TableUtils.contract_total_amtColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_total_amtColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_total_amtSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_total_amtColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's site_inventory_contract_.contract_total_amt field.
	/// </summary>
	public string contract_total_amtDefault
	{
		get
		{
			return TableUtils.contract_total_amtColumn.DefaultValue;
		}
	}


#endregion
}

}
