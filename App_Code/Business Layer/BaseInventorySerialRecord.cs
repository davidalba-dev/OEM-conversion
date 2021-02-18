// This class is "generated" and will be overwritten.
// Your customizations should be made in InventorySerialRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="InventorySerialRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="InventorySerialTable"></see> class.
/// </remarks>
/// <seealso cref="InventorySerialTable"></seealso>
/// <seealso cref="InventorySerialRecord"></seealso>
public class BaseInventorySerialRecord : PrimaryKeyRecord
{

	public readonly static InventorySerialTable TableUtils = InventorySerialTable.Instance;

	// Constructors
 
	protected BaseInventorySerialRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.InventorySerialRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.InventorySerialRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.InventorySerialRecord_ReadRecord); 
	}

	protected BaseInventorySerialRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void InventorySerialRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                InventorySerialRecord InventorySerialRec = (InventorySerialRecord)sender;
        if(InventorySerialRec != null && !InventorySerialRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void InventorySerialRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                InventorySerialRecord InventorySerialRec = (InventorySerialRecord)sender;
        Validate_Inserting();
        if(InventorySerialRec != null && !InventorySerialRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void InventorySerialRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                InventorySerialRecord InventorySerialRec = (InventorySerialRecord)sender;
        Validate_Updating();
        if(InventorySerialRec != null && !InventorySerialRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerDetailNo field.
	/// </summary>
	public ColumnValue GetSerDetailNoValue()
	{
		return this.GetValue(TableUtils.SerDetailNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerDetailNo field.
	/// </summary>
	public Int32 GetSerDetailNoFieldValue()
	{
		return this.GetValue(TableUtils.SerDetailNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerDetailNo field.
	/// </summary>
	public void SetSerDetailNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SerDetailNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerDetailNo field.
	/// </summary>
	public void SetSerDetailNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.SerDetailNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerDetailNo field.
	/// </summary>
	public void SetSerDetailNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerDetailNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerDetailNo field.
	/// </summary>
	public void SetSerDetailNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerDetailNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerDetailNo field.
	/// </summary>
	public void SetSerDetailNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerDetailNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerFormNo field.
	/// </summary>
	public ColumnValue GetSerFormNoValue()
	{
		return this.GetValue(TableUtils.SerFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerFormNo field.
	/// </summary>
	public Int32 GetSerFormNoFieldValue()
	{
		return this.GetValue(TableUtils.SerFormNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerFormNo field.
	/// </summary>
	public void SetSerFormNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SerFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerFormNo field.
	/// </summary>
	public void SetSerFormNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.SerFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerFormNo field.
	/// </summary>
	public void SetSerFormNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerFormNo field.
	/// </summary>
	public void SetSerFormNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerFormNo field.
	/// </summary>
	public void SetSerFormNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerFormNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerFormType field.
	/// </summary>
	public ColumnValue GetSerFormTypeValue()
	{
		return this.GetValue(TableUtils.SerFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerFormType field.
	/// </summary>
	public string GetSerFormTypeFieldValue()
	{
		return this.GetValue(TableUtils.SerFormTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerFormType field.
	/// </summary>
	public void SetSerFormTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SerFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerFormType field.
	/// </summary>
	public void SetSerFormTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerFormTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerKey field.
	/// </summary>
	public ColumnValue GetSerKeyValue()
	{
		return this.GetValue(TableUtils.SerKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerKey field.
	/// </summary>
	public Int32 GetSerKeyFieldValue()
	{
		return this.GetValue(TableUtils.SerKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerLocation field.
	/// </summary>
	public ColumnValue GetSerLocationValue()
	{
		return this.GetValue(TableUtils.SerLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerLocation field.
	/// </summary>
	public Int32 GetSerLocationFieldValue()
	{
		return this.GetValue(TableUtils.SerLocationColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerLocation field.
	/// </summary>
	public void SetSerLocationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SerLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerLocation field.
	/// </summary>
	public void SetSerLocationFieldValue(string val)
	{
		this.SetString(val, TableUtils.SerLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerLocation field.
	/// </summary>
	public void SetSerLocationFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerLocation field.
	/// </summary>
	public void SetSerLocationFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerLocation field.
	/// </summary>
	public void SetSerLocationFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerLocationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerPartNo field.
	/// </summary>
	public ColumnValue GetSerPartNoValue()
	{
		return this.GetValue(TableUtils.SerPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerPartNo field.
	/// </summary>
	public string GetSerPartNoFieldValue()
	{
		return this.GetValue(TableUtils.SerPartNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerPartNo field.
	/// </summary>
	public void SetSerPartNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SerPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerPartNo field.
	/// </summary>
	public void SetSerPartNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerPartNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerSerialNo field.
	/// </summary>
	public ColumnValue GetSerSerialNoValue()
	{
		return this.GetValue(TableUtils.SerSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InventorySerial_.SerSerialNo field.
	/// </summary>
	public string GetSerSerialNoFieldValue()
	{
		return this.GetValue(TableUtils.SerSerialNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerSerialNo field.
	/// </summary>
	public void SetSerSerialNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SerSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerSerialNo field.
	/// </summary>
	public void SetSerSerialNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SerSerialNoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's InventorySerial_.SerDetailNo field.
	/// </summary>
	public Int32 SerDetailNo
	{
		get
		{
			return this.GetValue(TableUtils.SerDetailNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SerDetailNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SerDetailNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SerDetailNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerDetailNo field.
	/// </summary>
	public string SerDetailNoDefault
	{
		get
		{
			return TableUtils.SerDetailNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InventorySerial_.SerFormNo field.
	/// </summary>
	public Int32 SerFormNo
	{
		get
		{
			return this.GetValue(TableUtils.SerFormNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SerFormNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SerFormNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SerFormNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerFormNo field.
	/// </summary>
	public string SerFormNoDefault
	{
		get
		{
			return TableUtils.SerFormNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InventorySerial_.SerFormType field.
	/// </summary>
	public string SerFormType
	{
		get
		{
			return this.GetValue(TableUtils.SerFormTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SerFormTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SerFormTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SerFormTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerFormType field.
	/// </summary>
	public string SerFormTypeDefault
	{
		get
		{
			return TableUtils.SerFormTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InventorySerial_.SerKey field.
	/// </summary>
	public Int32 SerKey
	{
		get
		{
			return this.GetValue(TableUtils.SerKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SerKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SerKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SerKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerKey field.
	/// </summary>
	public string SerKeyDefault
	{
		get
		{
			return TableUtils.SerKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InventorySerial_.SerLocation field.
	/// </summary>
	public Int32 SerLocation
	{
		get
		{
			return this.GetValue(TableUtils.SerLocationColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SerLocationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SerLocationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SerLocationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerLocation field.
	/// </summary>
	public string SerLocationDefault
	{
		get
		{
			return TableUtils.SerLocationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InventorySerial_.SerPartNo field.
	/// </summary>
	public string SerPartNo
	{
		get
		{
			return this.GetValue(TableUtils.SerPartNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SerPartNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SerPartNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SerPartNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerPartNo field.
	/// </summary>
	public string SerPartNoDefault
	{
		get
		{
			return TableUtils.SerPartNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InventorySerial_.SerSerialNo field.
	/// </summary>
	public string SerSerialNo
	{
		get
		{
			return this.GetValue(TableUtils.SerSerialNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SerSerialNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SerSerialNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SerSerialNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InventorySerial_.SerSerialNo field.
	/// </summary>
	public string SerSerialNoDefault
	{
		get
		{
			return TableUtils.SerSerialNoColumn.DefaultValue;
		}
	}


#endregion
}

}
