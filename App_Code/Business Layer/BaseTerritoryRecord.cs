// This class is "generated" and will be overwritten.
// Your customizations should be made in TerritoryRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="TerritoryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="TerritoryTable"></see> class.
/// </remarks>
/// <seealso cref="TerritoryTable"></seealso>
/// <seealso cref="TerritoryRecord"></seealso>
public class BaseTerritoryRecord : PrimaryKeyRecord
{

	public readonly static TerritoryTable TableUtils = TerritoryTable.Instance;

	// Constructors
 
	protected BaseTerritoryRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.TerritoryRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.TerritoryRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.TerritoryRecord_ReadRecord); 
	}

	protected BaseTerritoryRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void TerritoryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                TerritoryRecord TerritoryRec = (TerritoryRecord)sender;
        if(TerritoryRec != null && !TerritoryRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void TerritoryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                TerritoryRecord TerritoryRec = (TerritoryRecord)sender;
        Validate_Inserting();
        if(TerritoryRec != null && !TerritoryRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void TerritoryRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                TerritoryRecord TerritoryRec = (TerritoryRecord)sender;
        Validate_Updating();
        if(TerritoryRec != null && !TerritoryRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's territory_.territory_id field.
	/// </summary>
	public ColumnValue Getterritory_idValue()
	{
		return this.GetValue(TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's territory_.territory_id field.
	/// </summary>
	public Int32 Getterritory_idFieldValue()
	{
		return this.GetValue(TableUtils.territory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's territory_.territory_name field.
	/// </summary>
	public ColumnValue Getterritory_nameValue()
	{
		return this.GetValue(TableUtils.territory_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's territory_.territory_name field.
	/// </summary>
	public string Getterritory_nameFieldValue()
	{
		return this.GetValue(TableUtils.territory_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's territory_.territory_name field.
	/// </summary>
	public void Setterritory_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.territory_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's territory_.territory_name field.
	/// </summary>
	public void Setterritory_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.territory_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's territory_.territory_active field.
	/// </summary>
	public ColumnValue Getterritory_activeValue()
	{
		return this.GetValue(TableUtils.territory_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's territory_.territory_active field.
	/// </summary>
	public bool Getterritory_activeFieldValue()
	{
		return this.GetValue(TableUtils.territory_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's territory_.territory_active field.
	/// </summary>
	public void Setterritory_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.territory_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's territory_.territory_active field.
	/// </summary>
	public void Setterritory_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.territory_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's territory_.territory_active field.
	/// </summary>
	public void Setterritory_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.territory_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's territory_.territory_id field.
	/// </summary>
	public Int32 territory_id
	{
		get
		{
			return this.GetValue(TableUtils.territory_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.territory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool territory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.territory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's territory_.territory_id field.
	/// </summary>
	public string territory_idDefault
	{
		get
		{
			return TableUtils.territory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's territory_.territory_name field.
	/// </summary>
	public string territory_name
	{
		get
		{
			return this.GetValue(TableUtils.territory_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.territory_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool territory_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.territory_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's territory_.territory_name field.
	/// </summary>
	public string territory_nameDefault
	{
		get
		{
			return TableUtils.territory_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's territory_.territory_active field.
	/// </summary>
	public bool territory_active
	{
		get
		{
			return this.GetValue(TableUtils.territory_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.territory_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool territory_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.territory_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's territory_.territory_active field.
	/// </summary>
	public string territory_activeDefault
	{
		get
		{
			return TableUtils.territory_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
