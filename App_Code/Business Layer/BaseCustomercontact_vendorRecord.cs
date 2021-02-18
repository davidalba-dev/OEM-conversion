// This class is "generated" and will be overwritten.
// Your customizations should be made in Customercontact_vendorRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Customercontact_vendorRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Customercontact_vendorTable"></see> class.
/// </remarks>
/// <seealso cref="Customercontact_vendorTable"></seealso>
/// <seealso cref="Customercontact_vendorRecord"></seealso>
public class BaseCustomercontact_vendorRecord : PrimaryKeyRecord
{

	public readonly static Customercontact_vendorTable TableUtils = Customercontact_vendorTable.Instance;

	// Constructors
 
	protected BaseCustomercontact_vendorRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Customercontact_vendorRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Customercontact_vendorRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Customercontact_vendorRecord_ReadRecord); 
	}

	protected BaseCustomercontact_vendorRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Customercontact_vendorRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Customercontact_vendorRecord Customercontact_vendorRec = (Customercontact_vendorRecord)sender;
        if(Customercontact_vendorRec != null && !Customercontact_vendorRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Customercontact_vendorRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Customercontact_vendorRecord Customercontact_vendorRec = (Customercontact_vendorRecord)sender;
        Validate_Inserting();
        if(Customercontact_vendorRec != null && !Customercontact_vendorRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Customercontact_vendorRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Customercontact_vendorRecord Customercontact_vendorRec = (Customercontact_vendorRecord)sender;
        Validate_Updating();
        if(Customercontact_vendorRec != null && !Customercontact_vendorRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's customercontact_vendor_.customercontact_vendor_id field.
	/// </summary>
	public ColumnValue Getcustomercontact_vendor_idValue()
	{
		return this.GetValue(TableUtils.customercontact_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customercontact_vendor_.customercontact_vendor_id field.
	/// </summary>
	public Int32 Getcustomercontact_vendor_idFieldValue()
	{
		return this.GetValue(TableUtils.customercontact_vendor_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customercontact_vendor_.custcontactkey field.
	/// </summary>
	public ColumnValue GetcustcontactkeyValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customercontact_vendor_.custcontactkey field.
	/// </summary>
	public Int32 GetcustcontactkeyFieldValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customercontact_vendor_.vendno field.
	/// </summary>
	public ColumnValue GetvendnoValue()
	{
		return this.GetValue(TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's customercontact_vendor_.vendno field.
	/// </summary>
	public Int32 GetvendnoFieldValue()
	{
		return this.GetValue(TableUtils.vendnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendnoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's customercontact_vendor_.customercontact_vendor_id field.
	/// </summary>
	public Int32 customercontact_vendor_id
	{
		get
		{
			return this.GetValue(TableUtils.customercontact_vendor_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customercontact_vendor_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customercontact_vendor_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customercontact_vendor_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.customercontact_vendor_id field.
	/// </summary>
	public string customercontact_vendor_idDefault
	{
		get
		{
			return TableUtils.customercontact_vendor_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customercontact_vendor_.custcontactkey field.
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
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.custcontactkey field.
	/// </summary>
	public string custcontactkeyDefault
	{
		get
		{
			return TableUtils.custcontactkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's customercontact_vendor_.vendno field.
	/// </summary>
	public Int32 vendno
	{
		get
		{
			return this.GetValue(TableUtils.vendnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.vendnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool vendnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.vendnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's customercontact_vendor_.vendno field.
	/// </summary>
	public string vendnoDefault
	{
		get
		{
			return TableUtils.vendnoColumn.DefaultValue;
		}
	}


#endregion
}

}
