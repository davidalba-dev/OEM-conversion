// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_site_inventory_customerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_site_inventory_customerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_site_inventory_customerView"></see> class.
/// </remarks>
/// <seealso cref="Vw_site_inventory_customerView"></seealso>
/// <seealso cref="Vw_site_inventory_customerRecord"></seealso>
public class BaseVw_site_inventory_customerRecord : PrimaryKeyRecord
{

	public readonly static Vw_site_inventory_customerView TableUtils = Vw_site_inventory_customerView.Instance;

	// Constructors
 
	protected BaseVw_site_inventory_customerRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_site_inventory_customerRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Vw_site_inventory_customerRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_site_inventory_customerRecord_ReadRecord); 
	}

	protected BaseVw_site_inventory_customerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_site_inventory_customerRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_site_inventory_customerRecord Vw_site_inventory_customerRec = (Vw_site_inventory_customerRecord)sender;
        if(Vw_site_inventory_customerRec != null && !Vw_site_inventory_customerRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_site_inventory_customerRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_site_inventory_customerRecord Vw_site_inventory_customerRec = (Vw_site_inventory_customerRecord)sender;
        Validate_Inserting();
        if(Vw_site_inventory_customerRec != null && !Vw_site_inventory_customerRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Vw_site_inventory_customerRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Vw_site_inventory_customerRecord Vw_site_inventory_customerRec = (Vw_site_inventory_customerRecord)sender;
        Validate_Updating();
        if(Vw_site_inventory_customerRec != null && !Vw_site_inventory_customerRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_customer_.site_inventory_contract_id field.
	/// </summary>
	public ColumnValue Getsite_inventory_contract_idValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_customer_.site_inventory_contract_id field.
	/// </summary>
	public Int32 Getsite_inventory_contract_idFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_contract_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_contract_id field.
	/// </summary>
	public void Setsite_inventory_contract_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_contract_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_customer_.contract_number field.
	/// </summary>
	public ColumnValue Getcontract_numberValue()
	{
		return this.GetValue(TableUtils.contract_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_customer_.contract_number field.
	/// </summary>
	public string Getcontract_numberFieldValue()
	{
		return this.GetValue(TableUtils.contract_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.contract_number field.
	/// </summary>
	public void Setcontract_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contract_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.contract_number field.
	/// </summary>
	public void Setcontract_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contract_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_customer_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_customer_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_customer_.site_inventory_custno field.
	/// </summary>
	public ColumnValue Getsite_inventory_custnoValue()
	{
		return this.GetValue(TableUtils.site_inventory_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_site_inventory_customer_.site_inventory_custno field.
	/// </summary>
	public Int32 Getsite_inventory_custnoFieldValue()
	{
		return this.GetValue(TableUtils.site_inventory_custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_custno field.
	/// </summary>
	public void Setsite_inventory_custnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.site_inventory_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_custno field.
	/// </summary>
	public void Setsite_inventory_custnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.site_inventory_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_custno field.
	/// </summary>
	public void Setsite_inventory_custnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_custno field.
	/// </summary>
	public void Setsite_inventory_custnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_custno field.
	/// </summary>
	public void Setsite_inventory_custnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.site_inventory_custnoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_customer_.site_inventory_contract_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_contract_id field.
	/// </summary>
	public string site_inventory_contract_idDefault
	{
		get
		{
			return TableUtils.site_inventory_contract_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_customer_.contract_number field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.contract_number field.
	/// </summary>
	public string contract_numberDefault
	{
		get
		{
			return TableUtils.contract_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_customer_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_site_inventory_customer_.site_inventory_custno field.
	/// </summary>
	public Int32 site_inventory_custno
	{
		get
		{
			return this.GetValue(TableUtils.site_inventory_custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.site_inventory_custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool site_inventory_custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.site_inventory_custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_site_inventory_customer_.site_inventory_custno field.
	/// </summary>
	public string site_inventory_custnoDefault
	{
		get
		{
			return TableUtils.site_inventory_custnoColumn.DefaultValue;
		}
	}


#endregion
}

}
