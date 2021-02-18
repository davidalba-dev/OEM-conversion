// This class is "generated" and will be overwritten.
// Your customizations should be made in Loaner_typeRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Loaner_typeRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Loaner_typeTable"></see> class.
/// </remarks>
/// <seealso cref="Loaner_typeTable"></seealso>
/// <seealso cref="Loaner_typeRecord"></seealso>
public class BaseLoaner_typeRecord : PrimaryKeyRecord
{

	public readonly static Loaner_typeTable TableUtils = Loaner_typeTable.Instance;

	// Constructors
 
	protected BaseLoaner_typeRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Loaner_typeRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Loaner_typeRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Loaner_typeRecord_ReadRecord); 
	}

	protected BaseLoaner_typeRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Loaner_typeRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Loaner_typeRecord Loaner_typeRec = (Loaner_typeRecord)sender;
        if(Loaner_typeRec != null && !Loaner_typeRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Loaner_typeRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Loaner_typeRecord Loaner_typeRec = (Loaner_typeRecord)sender;
        Validate_Inserting();
        if(Loaner_typeRec != null && !Loaner_typeRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Loaner_typeRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Loaner_typeRecord Loaner_typeRec = (Loaner_typeRecord)sender;
        Validate_Updating();
        if(Loaner_typeRec != null && !Loaner_typeRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's loaner_type_.loaner_type_id field.
	/// </summary>
	public ColumnValue Getloaner_type_idValue()
	{
		return this.GetValue(TableUtils.loaner_type_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_type_.loaner_type_id field.
	/// </summary>
	public Int32 Getloaner_type_idFieldValue()
	{
		return this.GetValue(TableUtils.loaner_type_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_type_.loaner_type field.
	/// </summary>
	public ColumnValue Getloaner_typeValue()
	{
		return this.GetValue(TableUtils.loaner_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_type_.loaner_type field.
	/// </summary>
	public string Getloaner_typeFieldValue()
	{
		return this.GetValue(TableUtils.loaner_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_type_.loaner_type field.
	/// </summary>
	public void Setloaner_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_type_.loaner_type field.
	/// </summary>
	public void Setloaner_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_type_.loaner_type_active field.
	/// </summary>
	public ColumnValue Getloaner_type_activeValue()
	{
		return this.GetValue(TableUtils.loaner_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_type_.loaner_type_active field.
	/// </summary>
	public bool Getloaner_type_activeFieldValue()
	{
		return this.GetValue(TableUtils.loaner_type_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_type_.loaner_type_active field.
	/// </summary>
	public void Setloaner_type_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_type_.loaner_type_active field.
	/// </summary>
	public void Setloaner_type_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_type_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_type_.loaner_type_active field.
	/// </summary>
	public void Setloaner_type_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_type_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_type_.loaner_type_id field.
	/// </summary>
	public Int32 loaner_type_id
	{
		get
		{
			return this.GetValue(TableUtils.loaner_type_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_type_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_type_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_type_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_type_.loaner_type_id field.
	/// </summary>
	public string loaner_type_idDefault
	{
		get
		{
			return TableUtils.loaner_type_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_type_.loaner_type field.
	/// </summary>
	public string loaner_type
	{
		get
		{
			return this.GetValue(TableUtils.loaner_typeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_type_.loaner_type field.
	/// </summary>
	public string loaner_typeDefault
	{
		get
		{
			return TableUtils.loaner_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_type_.loaner_type_active field.
	/// </summary>
	public bool loaner_type_active
	{
		get
		{
			return this.GetValue(TableUtils.loaner_type_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.loaner_type_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_type_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_type_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_type_.loaner_type_active field.
	/// </summary>
	public string loaner_type_activeDefault
	{
		get
		{
			return TableUtils.loaner_type_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
