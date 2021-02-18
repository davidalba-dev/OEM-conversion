// This class is "generated" and will be overwritten.
// Your customizations should be made in ContractRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ContractRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ContractTable"></see> class.
/// </remarks>
/// <seealso cref="ContractTable"></seealso>
/// <seealso cref="ContractRecord"></seealso>
public class BaseContractRecord : PrimaryKeyRecord
{

	public readonly static ContractTable TableUtils = ContractTable.Instance;

	// Constructors
 
	protected BaseContractRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ContractRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ContractRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ContractRecord_ReadRecord); 
	}

	protected BaseContractRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ContractRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ContractRecord ContractRec = (ContractRecord)sender;
        if(ContractRec != null && !ContractRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ContractRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ContractRecord ContractRec = (ContractRecord)sender;
        Validate_Inserting();
        if(ContractRec != null && !ContractRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ContractRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ContractRecord ContractRec = (ContractRecord)sender;
        Validate_Updating();
        if(ContractRec != null && !ContractRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_id field.
	/// </summary>
	public ColumnValue Getcontract_idValue()
	{
		return this.GetValue(TableUtils.contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_id field.
	/// </summary>
	public Int32 Getcontract_idFieldValue()
	{
		return this.GetValue(TableUtils.contract_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_name field.
	/// </summary>
	public ColumnValue Getcontract_nameValue()
	{
		return this.GetValue(TableUtils.contract_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_name field.
	/// </summary>
	public string Getcontract_nameFieldValue()
	{
		return this.GetValue(TableUtils.contract_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_name field.
	/// </summary>
	public void Setcontract_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_name field.
	/// </summary>
	public void Setcontract_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_startdate field.
	/// </summary>
	public ColumnValue Getcontract_startdateValue()
	{
		return this.GetValue(TableUtils.contract_startdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_startdate field.
	/// </summary>
	public DateTime Getcontract_startdateFieldValue()
	{
		return this.GetValue(TableUtils.contract_startdateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_startdate field.
	/// </summary>
	public void Setcontract_startdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_startdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_startdate field.
	/// </summary>
	public void Setcontract_startdateFieldValue(string val)
	{
		this.SetString(val, TableUtils.contract_startdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_startdate field.
	/// </summary>
	public void Setcontract_startdateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_startdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_enddate field.
	/// </summary>
	public ColumnValue Getcontract_enddateValue()
	{
		return this.GetValue(TableUtils.contract_enddateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_enddate field.
	/// </summary>
	public DateTime Getcontract_enddateFieldValue()
	{
		return this.GetValue(TableUtils.contract_enddateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_enddate field.
	/// </summary>
	public void Setcontract_enddateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_enddateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_enddate field.
	/// </summary>
	public void Setcontract_enddateFieldValue(string val)
	{
		this.SetString(val, TableUtils.contract_enddateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_enddate field.
	/// </summary>
	public void Setcontract_enddateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_enddateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_total_amt field.
	/// </summary>
	public ColumnValue Getcontract_total_amtValue()
	{
		return this.GetValue(TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_total_amt field.
	/// </summary>
	public Decimal Getcontract_total_amtFieldValue()
	{
		return this.GetValue(TableUtils.contract_total_amtColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(string val)
	{
		this.SetString(val, TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_total_amtColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_total_amt field.
	/// </summary>
	public void Setcontract_total_amtFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_total_amtColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.corporate_id field.
	/// </summary>
	public ColumnValue Getcorporate_idValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.corporate_id field.
	/// </summary>
	public Int32 Getcorporate_idFieldValue()
	{
		return this.GetValue(TableUtils.corporate_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporate_id field.
	/// </summary>
	public void Setcorporate_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporate_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.corporatecontact_id field.
	/// </summary>
	public ColumnValue Getcorporatecontact_idValue()
	{
		return this.GetValue(TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.corporatecontact_id field.
	/// </summary>
	public Int32 Getcorporatecontact_idFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.custcontactkey field.
	/// </summary>
	public ColumnValue GetcustcontactkeyValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.custcontactkey field.
	/// </summary>
	public Int32 GetcustcontactkeyFieldValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_details field.
	/// </summary>
	public ColumnValue Getcontract_detailsValue()
	{
		return this.GetValue(TableUtils.contract_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.contract_details field.
	/// </summary>
	public string Getcontract_detailsFieldValue()
	{
		return this.GetValue(TableUtils.contract_detailsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_details field.
	/// </summary>
	public void Setcontract_detailsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_detailsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_details field.
	/// </summary>
	public void Setcontract_detailsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_detailsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.created_by field.
	/// </summary>
	public ColumnValue Getcreated_byValue()
	{
		return this.GetValue(TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.created_by field.
	/// </summary>
	public Int32 Getcreated_byFieldValue()
	{
		return this.GetValue(TableUtils.created_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_by field.
	/// </summary>
	public void Setcreated_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.created_datetime field.
	/// </summary>
	public ColumnValue Getcreated_datetimeValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contract_.created_datetime field.
	/// </summary>
	public DateTime Getcreated_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.created_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.created_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_datetime field.
	/// </summary>
	public void Setcreated_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.created_datetimeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.contract_id field.
	/// </summary>
	public Int32 contract_id
	{
		get
		{
			return this.GetValue(TableUtils.contract_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_id field.
	/// </summary>
	public string contract_idDefault
	{
		get
		{
			return TableUtils.contract_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.contract_name field.
	/// </summary>
	public string contract_name
	{
		get
		{
			return this.GetValue(TableUtils.contract_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_name field.
	/// </summary>
	public string contract_nameDefault
	{
		get
		{
			return TableUtils.contract_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.contract_startdate field.
	/// </summary>
	public DateTime contract_startdate
	{
		get
		{
			return this.GetValue(TableUtils.contract_startdateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_startdateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_startdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_startdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_startdate field.
	/// </summary>
	public string contract_startdateDefault
	{
		get
		{
			return TableUtils.contract_startdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.contract_enddate field.
	/// </summary>
	public DateTime contract_enddate
	{
		get
		{
			return this.GetValue(TableUtils.contract_enddateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contract_enddateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contract_enddateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contract_enddateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_enddate field.
	/// </summary>
	public string contract_enddateDefault
	{
		get
		{
			return TableUtils.contract_enddateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.contract_total_amt field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_total_amt field.
	/// </summary>
	public string contract_total_amtDefault
	{
		get
		{
			return TableUtils.contract_total_amtColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.corporate_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporate_id field.
	/// </summary>
	public string corporate_idDefault
	{
		get
		{
			return TableUtils.corporate_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.corporatecontact_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contract_.corporatecontact_id field.
	/// </summary>
	public string corporatecontact_idDefault
	{
		get
		{
			return TableUtils.corporatecontact_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.custcontactkey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contract_.custcontactkey field.
	/// </summary>
	public string custcontactkeyDefault
	{
		get
		{
			return TableUtils.custcontactkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.contract_details field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contract_.contract_details field.
	/// </summary>
	public string contract_detailsDefault
	{
		get
		{
			return TableUtils.contract_detailsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.created_by field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_by field.
	/// </summary>
	public string created_byDefault
	{
		get
		{
			return TableUtils.created_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contract_.created_datetime field.
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
	/// This is a convenience method that allows direct modification of the value of the record's contract_.created_datetime field.
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
