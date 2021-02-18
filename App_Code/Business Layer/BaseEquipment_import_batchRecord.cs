// This class is "generated" and will be overwritten.
// Your customizations should be made in Equipment_import_batchRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Equipment_import_batchRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Equipment_import_batchTable"></see> class.
/// </remarks>
/// <seealso cref="Equipment_import_batchTable"></seealso>
/// <seealso cref="Equipment_import_batchRecord"></seealso>
public class BaseEquipment_import_batchRecord : PrimaryKeyRecord
{

	public readonly static Equipment_import_batchTable TableUtils = Equipment_import_batchTable.Instance;

	// Constructors
 
	protected BaseEquipment_import_batchRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Equipment_import_batchRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Equipment_import_batchRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Equipment_import_batchRecord_ReadRecord); 
	}

	protected BaseEquipment_import_batchRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Equipment_import_batchRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Equipment_import_batchRecord Equipment_import_batchRec = (Equipment_import_batchRecord)sender;
        if(Equipment_import_batchRec != null && !Equipment_import_batchRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Equipment_import_batchRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Equipment_import_batchRecord Equipment_import_batchRec = (Equipment_import_batchRecord)sender;
        Validate_Inserting();
        if(Equipment_import_batchRec != null && !Equipment_import_batchRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Equipment_import_batchRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Equipment_import_batchRecord Equipment_import_batchRec = (Equipment_import_batchRecord)sender;
        Validate_Updating();
        if(Equipment_import_batchRec != null && !Equipment_import_batchRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_batch_.equip_import_batch_id field.
	/// </summary>
	public ColumnValue Getequip_import_batch_idValue()
	{
		return this.GetValue(TableUtils.equip_import_batch_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_batch_.equip_import_batch_id field.
	/// </summary>
	public Int32 Getequip_import_batch_idFieldValue()
	{
		return this.GetValue(TableUtils.equip_import_batch_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_batch_.batch_date_created field.
	/// </summary>
	public ColumnValue Getbatch_date_createdValue()
	{
		return this.GetValue(TableUtils.batch_date_createdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_batch_.batch_date_created field.
	/// </summary>
	public DateTime Getbatch_date_createdFieldValue()
	{
		return this.GetValue(TableUtils.batch_date_createdColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.batch_date_created field.
	/// </summary>
	public void Setbatch_date_createdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.batch_date_createdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.batch_date_created field.
	/// </summary>
	public void Setbatch_date_createdFieldValue(string val)
	{
		this.SetString(val, TableUtils.batch_date_createdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.batch_date_created field.
	/// </summary>
	public void Setbatch_date_createdFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.batch_date_createdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_batch_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_batch_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_batch_.technician field.
	/// </summary>
	public ColumnValue GettechnicianValue()
	{
		return this.GetValue(TableUtils.technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's equipment_import_batch_.technician field.
	/// </summary>
	public Int32 GettechnicianFieldValue()
	{
		return this.GetValue(TableUtils.technicianColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.technician field.
	/// </summary>
	public void SettechnicianFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.technician field.
	/// </summary>
	public void SettechnicianFieldValue(string val)
	{
		this.SetString(val, TableUtils.technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.technician field.
	/// </summary>
	public void SettechnicianFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.technician field.
	/// </summary>
	public void SettechnicianFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.technician field.
	/// </summary>
	public void SettechnicianFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technicianColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_batch_.equip_import_batch_id field.
	/// </summary>
	public Int32 equip_import_batch_id
	{
		get
		{
			return this.GetValue(TableUtils.equip_import_batch_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equip_import_batch_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equip_import_batch_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equip_import_batch_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.equip_import_batch_id field.
	/// </summary>
	public string equip_import_batch_idDefault
	{
		get
		{
			return TableUtils.equip_import_batch_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_batch_.batch_date_created field.
	/// </summary>
	public DateTime batch_date_created
	{
		get
		{
			return this.GetValue(TableUtils.batch_date_createdColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.batch_date_createdColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool batch_date_createdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.batch_date_createdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.batch_date_created field.
	/// </summary>
	public string batch_date_createdDefault
	{
		get
		{
			return TableUtils.batch_date_createdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_batch_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's equipment_import_batch_.technician field.
	/// </summary>
	public Int32 technician
	{
		get
		{
			return this.GetValue(TableUtils.technicianColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.technicianColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technicianSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technicianColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's equipment_import_batch_.technician field.
	/// </summary>
	public string technicianDefault
	{
		get
		{
			return TableUtils.technicianColumn.DefaultValue;
		}
	}


#endregion
}

}
