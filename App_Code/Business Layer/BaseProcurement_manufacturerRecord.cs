// This class is "generated" and will be overwritten.
// Your customizations should be made in Procurement_manufacturerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Procurement_manufacturerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Procurement_manufacturerTable"></see> class.
/// </remarks>
/// <seealso cref="Procurement_manufacturerTable"></seealso>
/// <seealso cref="Procurement_manufacturerRecord"></seealso>
public class BaseProcurement_manufacturerRecord : PrimaryKeyRecord
{

	public readonly static Procurement_manufacturerTable TableUtils = Procurement_manufacturerTable.Instance;

	// Constructors
 
	protected BaseProcurement_manufacturerRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Procurement_manufacturerRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Procurement_manufacturerRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Procurement_manufacturerRecord_ReadRecord); 
	}

	protected BaseProcurement_manufacturerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Procurement_manufacturerRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Procurement_manufacturerRecord Procurement_manufacturerRec = (Procurement_manufacturerRecord)sender;
        if(Procurement_manufacturerRec != null && !Procurement_manufacturerRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Procurement_manufacturerRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Procurement_manufacturerRecord Procurement_manufacturerRec = (Procurement_manufacturerRecord)sender;
        Validate_Inserting();
        if(Procurement_manufacturerRec != null && !Procurement_manufacturerRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Procurement_manufacturerRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Procurement_manufacturerRecord Procurement_manufacturerRec = (Procurement_manufacturerRecord)sender;
        Validate_Updating();
        if(Procurement_manufacturerRec != null && !Procurement_manufacturerRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's procurement_manufacturer_.procurement_manufacturer_id field.
	/// </summary>
	public ColumnValue Getprocurement_manufacturer_idValue()
	{
		return this.GetValue(TableUtils.procurement_manufacturer_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_manufacturer_.procurement_manufacturer_id field.
	/// </summary>
	public Int32 Getprocurement_manufacturer_idFieldValue()
	{
		return this.GetValue(TableUtils.procurement_manufacturer_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_manufacturer_.manufacturer_name field.
	/// </summary>
	public ColumnValue Getmanufacturer_nameValue()
	{
		return this.GetValue(TableUtils.manufacturer_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_manufacturer_.manufacturer_name field.
	/// </summary>
	public string Getmanufacturer_nameFieldValue()
	{
		return this.GetValue(TableUtils.manufacturer_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_manufacturer_.manufacturer_name field.
	/// </summary>
	public void Setmanufacturer_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.manufacturer_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_manufacturer_.manufacturer_name field.
	/// </summary>
	public void Setmanufacturer_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.manufacturer_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_manufacturer_.manufacturer_active field.
	/// </summary>
	public ColumnValue Getmanufacturer_activeValue()
	{
		return this.GetValue(TableUtils.manufacturer_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's procurement_manufacturer_.manufacturer_active field.
	/// </summary>
	public bool Getmanufacturer_activeFieldValue()
	{
		return this.GetValue(TableUtils.manufacturer_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_manufacturer_.manufacturer_active field.
	/// </summary>
	public void Setmanufacturer_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.manufacturer_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_manufacturer_.manufacturer_active field.
	/// </summary>
	public void Setmanufacturer_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.manufacturer_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_manufacturer_.manufacturer_active field.
	/// </summary>
	public void Setmanufacturer_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.manufacturer_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_manufacturer_.procurement_manufacturer_id field.
	/// </summary>
	public Int32 procurement_manufacturer_id
	{
		get
		{
			return this.GetValue(TableUtils.procurement_manufacturer_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.procurement_manufacturer_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool procurement_manufacturer_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.procurement_manufacturer_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_manufacturer_.procurement_manufacturer_id field.
	/// </summary>
	public string procurement_manufacturer_idDefault
	{
		get
		{
			return TableUtils.procurement_manufacturer_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_manufacturer_.manufacturer_name field.
	/// </summary>
	public string manufacturer_name
	{
		get
		{
			return this.GetValue(TableUtils.manufacturer_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.manufacturer_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool manufacturer_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.manufacturer_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_manufacturer_.manufacturer_name field.
	/// </summary>
	public string manufacturer_nameDefault
	{
		get
		{
			return TableUtils.manufacturer_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's procurement_manufacturer_.manufacturer_active field.
	/// </summary>
	public bool manufacturer_active
	{
		get
		{
			return this.GetValue(TableUtils.manufacturer_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.manufacturer_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool manufacturer_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.manufacturer_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's procurement_manufacturer_.manufacturer_active field.
	/// </summary>
	public string manufacturer_activeDefault
	{
		get
		{
			return TableUtils.manufacturer_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
