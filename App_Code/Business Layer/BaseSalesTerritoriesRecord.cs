// This class is "generated" and will be overwritten.
// Your customizations should be made in SalesTerritoriesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="SalesTerritoriesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="SalesTerritoriesTable"></see> class.
/// </remarks>
/// <seealso cref="SalesTerritoriesTable"></seealso>
/// <seealso cref="SalesTerritoriesRecord"></seealso>
public class BaseSalesTerritoriesRecord : PrimaryKeyRecord
{

	public readonly static SalesTerritoriesTable TableUtils = SalesTerritoriesTable.Instance;

	// Constructors
 
	protected BaseSalesTerritoriesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.SalesTerritoriesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.SalesTerritoriesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.SalesTerritoriesRecord_ReadRecord); 
	}

	protected BaseSalesTerritoriesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void SalesTerritoriesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                SalesTerritoriesRecord SalesTerritoriesRec = (SalesTerritoriesRecord)sender;
        if(SalesTerritoriesRec != null && !SalesTerritoriesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void SalesTerritoriesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                SalesTerritoriesRecord SalesTerritoriesRec = (SalesTerritoriesRecord)sender;
        Validate_Inserting();
        if(SalesTerritoriesRec != null && !SalesTerritoriesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void SalesTerritoriesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                SalesTerritoriesRecord SalesTerritoriesRec = (SalesTerritoriesRecord)sender;
        Validate_Updating();
        if(SalesTerritoriesRec != null && !SalesTerritoriesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's SalesTerritories_.sales_territories_id field.
	/// </summary>
	public ColumnValue Getsales_territories_idValue()
	{
		return this.GetValue(TableUtils.sales_territories_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SalesTerritories_.sales_territories_id field.
	/// </summary>
	public Int32 Getsales_territories_idFieldValue()
	{
		return this.GetValue(TableUtils.sales_territories_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SalesTerritories_.territory_id field.
	/// </summary>
	public ColumnValue Getterritory_idValue()
	{
		return this.GetValue(TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SalesTerritories_.territory_id field.
	/// </summary>
	public Int32 Getterritory_idFieldValue()
	{
		return this.GetValue(TableUtils.territory_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.territory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.territory_id field.
	/// </summary>
	public void Setterritory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.territory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SalesTerritories_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SalesTerritories_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's SalesTerritories_.sales_territories_id field.
	/// </summary>
	public Int32 sales_territories_id
	{
		get
		{
			return this.GetValue(TableUtils.sales_territories_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.sales_territories_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool sales_territories_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.sales_territories_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.sales_territories_id field.
	/// </summary>
	public string sales_territories_idDefault
	{
		get
		{
			return TableUtils.sales_territories_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SalesTerritories_.territory_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.territory_id field.
	/// </summary>
	public string territory_idDefault
	{
		get
		{
			return TableUtils.territory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SalesTerritories_.technician_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's SalesTerritories_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}


#endregion
}

}
