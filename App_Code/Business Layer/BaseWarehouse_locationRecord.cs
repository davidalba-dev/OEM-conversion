// This class is "generated" and will be overwritten.
// Your customizations should be made in Warehouse_locationRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Warehouse_locationRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Warehouse_locationTable"></see> class.
/// </remarks>
/// <seealso cref="Warehouse_locationTable"></seealso>
/// <seealso cref="Warehouse_locationRecord"></seealso>
public class BaseWarehouse_locationRecord : PrimaryKeyRecord
{

	public readonly static Warehouse_locationTable TableUtils = Warehouse_locationTable.Instance;

	// Constructors
 
	protected BaseWarehouse_locationRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Warehouse_locationRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Warehouse_locationRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Warehouse_locationRecord_ReadRecord); 
	}

	protected BaseWarehouse_locationRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Warehouse_locationRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Warehouse_locationRecord Warehouse_locationRec = (Warehouse_locationRecord)sender;
        if(Warehouse_locationRec != null && !Warehouse_locationRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Warehouse_locationRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Warehouse_locationRecord Warehouse_locationRec = (Warehouse_locationRecord)sender;
        Validate_Inserting();
        if(Warehouse_locationRec != null && !Warehouse_locationRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Warehouse_locationRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Warehouse_locationRecord Warehouse_locationRec = (Warehouse_locationRecord)sender;
        Validate_Updating();
        if(Warehouse_locationRec != null && !Warehouse_locationRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_location_id field.
	/// </summary>
	public ColumnValue Getwarehouse_location_idValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_location_id field.
	/// </summary>
	public Decimal Getwarehouse_location_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_location_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_location field.
	/// </summary>
	public ColumnValue Getwarehouse_locationValue()
	{
		return this.GetValue(TableUtils.warehouse_locationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_location field.
	/// </summary>
	public string Getwarehouse_locationFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_locationColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location field.
	/// </summary>
	public void Setwarehouse_locationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_locationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location field.
	/// </summary>
	public void Setwarehouse_locationFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_locationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_location_active field.
	/// </summary>
	public ColumnValue Getwarehouse_location_activeValue()
	{
		return this.GetValue(TableUtils.warehouse_location_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_location_active field.
	/// </summary>
	public bool Getwarehouse_location_activeFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_location_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location_active field.
	/// </summary>
	public void Setwarehouse_location_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_location_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location_active field.
	/// </summary>
	public void Setwarehouse_location_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_location_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location_active field.
	/// </summary>
	public void Setwarehouse_location_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_location_description field.
	/// </summary>
	public ColumnValue Getwarehouse_location_descriptionValue()
	{
		return this.GetValue(TableUtils.warehouse_location_descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_location_description field.
	/// </summary>
	public string Getwarehouse_location_descriptionFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_location_descriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location_description field.
	/// </summary>
	public void Setwarehouse_location_descriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_location_descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location_description field.
	/// </summary>
	public void Setwarehouse_location_descriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_location_descriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_id field.
	/// </summary>
	public ColumnValue Getwarehouse_idValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's warehouse_location_.warehouse_id field.
	/// </summary>
	public Decimal Getwarehouse_idFieldValue()
	{
		return this.GetValue(TableUtils.warehouse_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_id field.
	/// </summary>
	public void Setwarehouse_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.warehouse_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's warehouse_location_.warehouse_location_id field.
	/// </summary>
	public Decimal warehouse_location_id
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_location_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_location_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_location_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_location_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location_id field.
	/// </summary>
	public string warehouse_location_idDefault
	{
		get
		{
			return TableUtils.warehouse_location_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's warehouse_location_.warehouse_location field.
	/// </summary>
	public string warehouse_location
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_locationColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_locationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_locationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_locationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location field.
	/// </summary>
	public string warehouse_locationDefault
	{
		get
		{
			return TableUtils.warehouse_locationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's warehouse_location_.warehouse_location_active field.
	/// </summary>
	public bool warehouse_location_active
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_location_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.warehouse_location_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_location_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_location_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location_active field.
	/// </summary>
	public string warehouse_location_activeDefault
	{
		get
		{
			return TableUtils.warehouse_location_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's warehouse_location_.warehouse_location_description field.
	/// </summary>
	public string warehouse_location_description
	{
		get
		{
			return this.GetValue(TableUtils.warehouse_location_descriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.warehouse_location_descriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool warehouse_location_descriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.warehouse_location_descriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_location_description field.
	/// </summary>
	public string warehouse_location_descriptionDefault
	{
		get
		{
			return TableUtils.warehouse_location_descriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's warehouse_location_.warehouse_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's warehouse_location_.warehouse_id field.
	/// </summary>
	public string warehouse_idDefault
	{
		get
		{
			return TableUtils.warehouse_idColumn.DefaultValue;
		}
	}


#endregion
}

}
