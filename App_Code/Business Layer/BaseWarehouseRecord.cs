// This class is "generated" and will be overwritten.
// Your customizations should be made in WarehouseRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="WarehouseRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="WarehouseTable"></see> class.
/// </remarks>
/// <seealso cref="WarehouseTable"></seealso>
/// <seealso cref="WarehouseRecord"></seealso>
public class BaseWarehouseRecord : PrimaryKeyRecord
{

	public readonly static WarehouseTable TableUtils = WarehouseTable.Instance;

	// Constructors
 
	protected BaseWarehouseRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.WarehouseRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.WarehouseRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.WarehouseRecord_ReadRecord); 
	}

	protected BaseWarehouseRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void WarehouseRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                WarehouseRecord WarehouseRec = (WarehouseRecord)sender;
        if(WarehouseRec != null && !WarehouseRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void WarehouseRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                WarehouseRecord WarehouseRec = (WarehouseRecord)sender;
        Validate_Inserting();
        if(WarehouseRec != null && !WarehouseRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void WarehouseRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                WarehouseRecord WarehouseRec = (WarehouseRecord)sender;
        Validate_Updating();
        if(WarehouseRec != null && !WarehouseRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's warehouse_.warehouse_id field.
	/// </summary>
	public ColumnValue Getwarehouse_idValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_.warehouse_id field.
	/// </summary>
	public Decimal Getwarehouse_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_.warehouse_name field.
	/// </summary>
	public ColumnValue Getwarehouse_nameValue()
	{
		return this.GetValue(TableUtils.warehouse_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_.warehouse_name field.
	/// </summary>
	public string Getwarehouse_nameFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_name field.
	/// </summary>
	public void Setwarehouse_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_name field.
	/// </summary>
	public void Setwarehouse_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_.warehouse_active field.
	/// </summary>
	public ColumnValue Getwarehouse_activeValue()
	{
		return this.GetValue(TableUtils.warehouse_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_.warehouse_active field.
	/// </summary>
	public bool Getwarehouse_activeFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_active field.
	/// </summary>
	public void Setwarehouse_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_active field.
	/// </summary>
	public void Setwarehouse_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_active field.
	/// </summary>
	public void Setwarehouse_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_.warehouse_customer_id field.
	/// </summary>
	public ColumnValue Getwarehouse_customer_idValue()
	{
		return this.GetValue(TableUtils.warehouse_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_.warehouse_customer_id field.
	/// </summary>
	public Int32 Getwarehouse_customer_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_customer_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_customer_id field.
	/// </summary>
	public void Setwarehouse_customer_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_customer_id field.
	/// </summary>
	public void Setwarehouse_customer_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_customer_id field.
	/// </summary>
	public void Setwarehouse_customer_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_customer_id field.
	/// </summary>
	public void Setwarehouse_customer_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_customer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_customer_id field.
	/// </summary>
	public void Setwarehouse_customer_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_customer_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's warehouse_.warehouse_id field.
	/// </summary>
	public Decimal warehouse_id
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_id field.
	/// </summary>
	public string warehouse_idDefault
	{
		get
		{
			return TableUtils.warehouse_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's warehouse_.warehouse_name field.
	/// </summary>
	public string warehouse_name
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_name field.
	/// </summary>
	public string warehouse_nameDefault
	{
		get
		{
			return TableUtils.warehouse_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's warehouse_.warehouse_active field.
	/// </summary>
	public bool warehouse_active
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.warehouse_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_active field.
	/// </summary>
	public string warehouse_activeDefault
	{
		get
		{
			return TableUtils.warehouse_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's warehouse_.warehouse_customer_id field.
	/// </summary>
	public Int32 warehouse_customer_id
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_customer_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_customer_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_customer_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_customer_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_.warehouse_customer_id field.
	/// </summary>
	public string warehouse_customer_idDefault
	{
		get
		{
			return TableUtils.warehouse_customer_idColumn.DefaultValue;
		}
	}


#endregion
}

}
