// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_inventory_commentRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_inventory_commentRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_inventory_commentTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_inventory_commentTable"></seealso>
/// <seealso cref="Equipment_inventory_commentRecord"></seealso>
public class BaseEquipment_inventory_commentRecord : PrimaryKeyRecord
{

	public readonly static Equipment_inventory_commentTable TableUtils = Equipment_inventory_commentTable.Instance;

	// Constructors
 
	protected BaseEquipment_inventory_commentRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_inventory_commentRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_inventory_commentRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_inventory_commentRecord_ReadRecord); 
	}

	protected BaseEquipment_inventory_commentRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_inventory_commentRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_inventory_commentRecord Equipment_inventory_commentRec = (Equipment_inventory_commentRecord)sender;
        if(Equipment_inventory_commentRec != null && !Equipment_inventory_commentRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_inventory_commentRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_inventory_commentRecord Equipment_inventory_commentRec = (Equipment_inventory_commentRecord)sender;
        Validate_Inserting();
        if(Equipment_inventory_commentRec != null && !Equipment_inventory_commentRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_inventory_commentRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_inventory_commentRecord Equipment_inventory_commentRec = (Equipment_inventory_commentRecord)sender;
        Validate_Updating();
        if(Equipment_inventory_commentRec != null && !Equipment_inventory_commentRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.equipment_inventory_comment_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_comment_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_comment_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.equipment_inventory_comment_id field.
	/// </summary>
	public Decimal Getequipment_inventory_comment_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_comment_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.equipment_inventory_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.equipment_inventory_id field.
	/// </summary>
	public Decimal Getequipment_inventory_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_id field.
	/// </summary>
	public void Setequipment_inventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_id field.
	/// </summary>
	public void Setequipment_inventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_id field.
	/// </summary>
	public void Setequipment_inventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_id field.
	/// </summary>
	public void Setequipment_inventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_id field.
	/// </summary>
	public void Setequipment_inventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.equipment_inventory_comment field.
	/// </summary>
	public ColumnValue Getequipment_inventory_commentValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_commentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.equipment_inventory_comment field.
	/// </summary>
	public string Getequipment_inventory_commentFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_commentColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_comment field.
	/// </summary>
	public void Setequipment_inventory_commentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_commentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_comment field.
	/// </summary>
	public void Setequipment_inventory_commentFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_commentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.comment_datetime field.
	/// </summary>
	public ColumnValue Getcomment_datetimeValue()
	{
		return this.GetValue(TableUtils.comment_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_inventory_comment_.comment_datetime field.
	/// </summary>
	public DateTime Getcomment_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.comment_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.comment_datetime field.
	/// </summary>
	public void Setcomment_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comment_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.comment_datetime field.
	/// </summary>
	public void Setcomment_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.comment_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.comment_datetime field.
	/// </summary>
	public void Setcomment_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comment_datetimeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_comment_.equipment_inventory_comment_id field.
	/// </summary>
	public Decimal equipment_inventory_comment_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_comment_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_comment_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_comment_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_comment_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_comment_id field.
	/// </summary>
	public string equipment_inventory_comment_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_comment_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_comment_.equipment_inventory_id field.
	/// </summary>
	public Decimal equipment_inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_id field.
	/// </summary>
	public string equipment_inventory_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_comment_.equipment_inventory_comment field.
	/// </summary>
	public string equipment_inventory_comment
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_commentColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_commentColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_commentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_commentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.equipment_inventory_comment field.
	/// </summary>
	public string equipment_inventory_commentDefault
	{
		get
		{
			return TableUtils.equipment_inventory_commentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_comment_.technician_id field.
	/// </summary>
	public Int32 technician_id
	{
		get
		{
			return this.GetValue(TableUtils.technician_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.technician_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technician_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technician_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_inventory_comment_.comment_datetime field.
	/// </summary>
	public DateTime comment_datetime
	{
		get
		{
			return this.GetValue(TableUtils.comment_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comment_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comment_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comment_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_inventory_comment_.comment_datetime field.
	/// </summary>
	public string comment_datetimeDefault
	{
		get
		{
			return TableUtils.comment_datetimeColumn.DefaultValue;
		}
	}


#endregion
}

}
