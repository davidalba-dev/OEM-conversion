// This class is "generated" and will be overwritten.
// Your customizations should be made in Pickup_request_typeRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Pickup_request_typeRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Pickup_request_typeTable"></see> class.
/// </remarks>
/// <seealso cref="Pickup_request_typeTable"></seealso>
/// <seealso cref="Pickup_request_typeRecord"></seealso>
public class BasePickup_request_typeRecord : PrimaryKeyRecord
{

	public readonly static Pickup_request_typeTable TableUtils = Pickup_request_typeTable.Instance;

	// Constructors
 
	protected BasePickup_request_typeRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Pickup_request_typeRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Pickup_request_typeRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Pickup_request_typeRecord_ReadRecord); 
	}

	protected BasePickup_request_typeRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Pickup_request_typeRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Pickup_request_typeRecord Pickup_request_typeRec = (Pickup_request_typeRecord)sender;
        if(Pickup_request_typeRec != null && !Pickup_request_typeRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Pickup_request_typeRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Pickup_request_typeRecord Pickup_request_typeRec = (Pickup_request_typeRecord)sender;
        Validate_Inserting();
        if(Pickup_request_typeRec != null && !Pickup_request_typeRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Pickup_request_typeRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Pickup_request_typeRecord Pickup_request_typeRec = (Pickup_request_typeRecord)sender;
        Validate_Updating();
        if(Pickup_request_typeRec != null && !Pickup_request_typeRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_type_.pickup_request_type_id field.
	/// </summary>
	public ColumnValue Getpickup_request_type_idValue()
	{
		return this.GetValue(TableUtils.pickup_request_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_type_.pickup_request_type_id field.
	/// </summary>
	public Int32 Getpickup_request_type_idFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_type_.pickup_request_type field.
	/// </summary>
	public ColumnValue Getpickup_request_typeValue()
	{
		return this.GetValue(TableUtils.pickup_request_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_type_.pickup_request_type field.
	/// </summary>
	public string Getpickup_request_typeFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_type_.pickup_request_type field.
	/// </summary>
	public void Setpickup_request_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_request_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_type_.pickup_request_type field.
	/// </summary>
	public void Setpickup_request_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_type_.pickup_request_active field.
	/// </summary>
	public ColumnValue Getpickup_request_activeValue()
	{
		return this.GetValue(TableUtils.pickup_request_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's pickup_request_type_.pickup_request_active field.
	/// </summary>
	public bool Getpickup_request_activeFieldValue()
	{
		return this.GetValue(TableUtils.pickup_request_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_type_.pickup_request_active field.
	/// </summary>
	public void Setpickup_request_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.pickup_request_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_type_.pickup_request_active field.
	/// </summary>
	public void Setpickup_request_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.pickup_request_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_type_.pickup_request_active field.
	/// </summary>
	public void Setpickup_request_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.pickup_request_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_type_.pickup_request_type_id field.
	/// </summary>
	public Int32 pickup_request_type_id
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_type_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_request_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_type_.pickup_request_type_id field.
	/// </summary>
	public string pickup_request_type_idDefault
	{
		get
		{
			return TableUtils.pickup_request_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_type_.pickup_request_type field.
	/// </summary>
	public string pickup_request_type
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_typeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.pickup_request_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_type_.pickup_request_type field.
	/// </summary>
	public string pickup_request_typeDefault
	{
		get
		{
			return TableUtils.pickup_request_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's pickup_request_type_.pickup_request_active field.
	/// </summary>
	public bool pickup_request_active
	{
		get
		{
			return this.GetValue(TableUtils.pickup_request_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.pickup_request_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool pickup_request_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.pickup_request_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's pickup_request_type_.pickup_request_active field.
	/// </summary>
	public string pickup_request_activeDefault
	{
		get
		{
			return TableUtils.pickup_request_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
