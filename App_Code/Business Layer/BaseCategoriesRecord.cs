// This class is "generated" and will be overwritten.
// Your customizations should be made in CategoriesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="CategoriesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="CategoriesTable"></see> class.
/// </remarks>
/// <seealso cref="CategoriesTable"></seealso>
/// <seealso cref="CategoriesRecord"></seealso>
public class BaseCategoriesRecord : PrimaryKeyRecord
{

	public readonly static CategoriesTable TableUtils = CategoriesTable.Instance;

	// Constructors
 
	protected BaseCategoriesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.CategoriesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.CategoriesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.CategoriesRecord_ReadRecord); 
	}

	protected BaseCategoriesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void CategoriesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                CategoriesRecord CategoriesRec = (CategoriesRecord)sender;
        if(CategoriesRec != null && !CategoriesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void CategoriesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                CategoriesRecord CategoriesRec = (CategoriesRecord)sender;
        Validate_Inserting();
        if(CategoriesRec != null && !CategoriesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void CategoriesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                CategoriesRecord CategoriesRec = (CategoriesRecord)sender;
        Validate_Updating();
        if(CategoriesRec != null && !CategoriesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's categories_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's categories_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's categories_.category_name field.
	/// </summary>
	public ColumnValue Getcategory_nameValue()
	{
		return this.GetValue(TableUtils.category_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's categories_.category_name field.
	/// </summary>
	public string Getcategory_nameFieldValue()
	{
		return this.GetValue(TableUtils.category_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's categories_.category_name field.
	/// </summary>
	public void Setcategory_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's categories_.category_name field.
	/// </summary>
	public void Setcategory_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's categories_.category_active field.
	/// </summary>
	public ColumnValue Getcategory_activeValue()
	{
		return this.GetValue(TableUtils.category_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's categories_.category_active field.
	/// </summary>
	public bool Getcategory_activeFieldValue()
	{
		return this.GetValue(TableUtils.category_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's categories_.category_active field.
	/// </summary>
	public void Setcategory_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's categories_.category_active field.
	/// </summary>
	public void Setcategory_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.category_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's categories_.category_active field.
	/// </summary>
	public void Setcategory_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's categories_.category_id field.
	/// </summary>
	public Int32 category_id
	{
		get
		{
			return this.GetValue(TableUtils.category_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.category_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool category_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.category_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's categories_.category_id field.
	/// </summary>
	public string category_idDefault
	{
		get
		{
			return TableUtils.category_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's categories_.category_name field.
	/// </summary>
	public string category_name
	{
		get
		{
			return this.GetValue(TableUtils.category_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.category_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool category_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.category_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's categories_.category_name field.
	/// </summary>
	public string category_nameDefault
	{
		get
		{
			return TableUtils.category_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's categories_.category_active field.
	/// </summary>
	public bool category_active
	{
		get
		{
			return this.GetValue(TableUtils.category_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.category_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool category_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.category_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's categories_.category_active field.
	/// </summary>
	public string category_activeDefault
	{
		get
		{
			return TableUtils.category_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
