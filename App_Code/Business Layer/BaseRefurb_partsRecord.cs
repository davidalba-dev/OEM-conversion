// This class is "generated" and will be overwritten.
// Your customizations should be made in Refurb_partsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Refurb_partsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Refurb_partsTable"></see> class.
/// </remarks>
/// <seealso cref="Refurb_partsTable"></seealso>
/// <seealso cref="Refurb_partsRecord"></seealso>
public class BaseRefurb_partsRecord : PrimaryKeyRecord
{

	public readonly static Refurb_partsTable TableUtils = Refurb_partsTable.Instance;

	// Constructors
 
	protected BaseRefurb_partsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Refurb_partsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Refurb_partsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Refurb_partsRecord_ReadRecord); 
	}

	protected BaseRefurb_partsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Refurb_partsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Refurb_partsRecord Refurb_partsRec = (Refurb_partsRecord)sender;
        if(Refurb_partsRec != null && !Refurb_partsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Refurb_partsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Refurb_partsRecord Refurb_partsRec = (Refurb_partsRecord)sender;
        Validate_Inserting();
        if(Refurb_partsRec != null && !Refurb_partsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Refurb_partsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Refurb_partsRecord Refurb_partsRec = (Refurb_partsRecord)sender;
        Validate_Updating();
        if(Refurb_partsRec != null && !Refurb_partsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_id field.
	/// </summary>
	public ColumnValue Getrefurb_part_idValue()
	{
		return this.GetValue(TableUtils.refurb_part_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_id field.
	/// </summary>
	public Decimal Getrefurb_part_idFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_number field.
	/// </summary>
	public ColumnValue Getrefurb_part_numberValue()
	{
		return this.GetValue(TableUtils.refurb_part_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_number field.
	/// </summary>
	public string Getrefurb_part_numberFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_number field.
	/// </summary>
	public void Setrefurb_part_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_number field.
	/// </summary>
	public void Setrefurb_part_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_name field.
	/// </summary>
	public ColumnValue Getrefurb_part_nameValue()
	{
		return this.GetValue(TableUtils.refurb_part_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_name field.
	/// </summary>
	public string Getrefurb_part_nameFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_name field.
	/// </summary>
	public void Setrefurb_part_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_name field.
	/// </summary>
	public void Setrefurb_part_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_description field.
	/// </summary>
	public ColumnValue Getrefurb_part_descriptionValue()
	{
		return this.GetValue(TableUtils.refurb_part_descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_description field.
	/// </summary>
	public string Getrefurb_part_descriptionFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_descriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_description field.
	/// </summary>
	public void Setrefurb_part_descriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_description field.
	/// </summary>
	public void Setrefurb_part_descriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_descriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_vendor_id field.
	/// </summary>
	public ColumnValue Getrefurb_vendor_idValue()
	{
		return this.GetValue(TableUtils.refurb_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_vendor_id field.
	/// </summary>
	public Decimal Getrefurb_vendor_idFieldValue()
	{
		return this.GetValue(TableUtils.refurb_vendor_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_vendor_id field.
	/// </summary>
	public void Setrefurb_vendor_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_vendor_id field.
	/// </summary>
	public void Setrefurb_vendor_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.refurb_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_vendor_id field.
	/// </summary>
	public void Setrefurb_vendor_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_vendor_id field.
	/// </summary>
	public void Setrefurb_vendor_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_vendor_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_vendor_id field.
	/// </summary>
	public void Setrefurb_vendor_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_vendor_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_cost field.
	/// </summary>
	public ColumnValue Getrefurb_part_costValue()
	{
		return this.GetValue(TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_cost field.
	/// </summary>
	public Decimal Getrefurb_part_costFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_costColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(string val)
	{
		this.SetString(val, TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_costColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_cost field.
	/// </summary>
	public void Setrefurb_part_costFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_costColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_retail field.
	/// </summary>
	public ColumnValue Getrefurb_part_retailValue()
	{
		return this.GetValue(TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_retail field.
	/// </summary>
	public Decimal Getrefurb_part_retailFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_retailColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(string val)
	{
		this.SetString(val, TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_retailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_retail field.
	/// </summary>
	public void Setrefurb_part_retailFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_retailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_active field.
	/// </summary>
	public ColumnValue Getrefurb_part_activeValue()
	{
		return this.GetValue(TableUtils.refurb_part_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.refurb_part_active field.
	/// </summary>
	public bool Getrefurb_part_activeFieldValue()
	{
		return this.GetValue(TableUtils.refurb_part_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_active field.
	/// </summary>
	public void Setrefurb_part_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.refurb_part_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_active field.
	/// </summary>
	public void Setrefurb_part_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.refurb_part_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_active field.
	/// </summary>
	public void Setrefurb_part_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.refurb_part_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.vendno field.
	/// </summary>
	public ColumnValue GetvendnoValue()
	{
		return this.GetValue(TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's refurb_parts_.vendno field.
	/// </summary>
	public Int32 GetvendnoFieldValue()
	{
		return this.GetValue(TableUtils.vendnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.vendno field.
	/// </summary>
	public void SetvendnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.vendnoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_parts_.refurb_part_id field.
	/// </summary>
	public Decimal refurb_part_id
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_id field.
	/// </summary>
	public string refurb_part_idDefault
	{
		get
		{
			return TableUtils.refurb_part_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_parts_.refurb_part_number field.
	/// </summary>
	public string refurb_part_number
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_numberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_numberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_numberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_numberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_number field.
	/// </summary>
	public string refurb_part_numberDefault
	{
		get
		{
			return TableUtils.refurb_part_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_parts_.refurb_part_name field.
	/// </summary>
	public string refurb_part_name
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_name field.
	/// </summary>
	public string refurb_part_nameDefault
	{
		get
		{
			return TableUtils.refurb_part_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_parts_.refurb_part_description field.
	/// </summary>
	public string refurb_part_description
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_descriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_descriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_descriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_descriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_description field.
	/// </summary>
	public string refurb_part_descriptionDefault
	{
		get
		{
			return TableUtils.refurb_part_descriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_parts_.refurb_vendor_id field.
	/// </summary>
	public Decimal refurb_vendor_id
	{
		get
		{
			return this.GetValue(TableUtils.refurb_vendor_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_vendor_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_vendor_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_vendor_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_vendor_id field.
	/// </summary>
	public string refurb_vendor_idDefault
	{
		get
		{
			return TableUtils.refurb_vendor_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_parts_.refurb_part_cost field.
	/// </summary>
	public Decimal refurb_part_cost
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_costColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_costColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_costSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_costColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_cost field.
	/// </summary>
	public string refurb_part_costDefault
	{
		get
		{
			return TableUtils.refurb_part_costColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_parts_.refurb_part_retail field.
	/// </summary>
	public Decimal refurb_part_retail
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_retailColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.refurb_part_retailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_retailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_retailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_retail field.
	/// </summary>
	public string refurb_part_retailDefault
	{
		get
		{
			return TableUtils.refurb_part_retailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_parts_.refurb_part_active field.
	/// </summary>
	public bool refurb_part_active
	{
		get
		{
			return this.GetValue(TableUtils.refurb_part_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.refurb_part_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool refurb_part_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.refurb_part_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.refurb_part_active field.
	/// </summary>
	public string refurb_part_activeDefault
	{
		get
		{
			return TableUtils.refurb_part_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's refurb_parts_.vendno field.
	/// </summary>
	public Int32 vendno
	{
		get
		{
			return this.GetValue(TableUtils.vendnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.vendnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool vendnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.vendnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's refurb_parts_.vendno field.
	/// </summary>
	public string vendnoDefault
	{
		get
		{
			return TableUtils.vendnoColumn.DefaultValue;
		}
	}


#endregion
}

}
