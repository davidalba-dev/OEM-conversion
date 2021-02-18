// This class is "generated" and will be overwritten.
// Your customizations should be made in ROAccessoriesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ROAccessoriesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ROAccessoriesTable"></see> class.
/// </remarks>
/// <seealso cref="ROAccessoriesTable"></seealso>
/// <seealso cref="ROAccessoriesRecord"></seealso>
public class BaseROAccessoriesRecord : PrimaryKeyRecord
{

	public readonly static ROAccessoriesTable TableUtils = ROAccessoriesTable.Instance;

	// Constructors
 
	protected BaseROAccessoriesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ROAccessoriesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ROAccessoriesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ROAccessoriesRecord_ReadRecord); 
	}

	protected BaseROAccessoriesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ROAccessoriesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ROAccessoriesRecord ROAccessoriesRec = (ROAccessoriesRecord)sender;
        if(ROAccessoriesRec != null && !ROAccessoriesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ROAccessoriesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ROAccessoriesRecord ROAccessoriesRec = (ROAccessoriesRecord)sender;
        Validate_Inserting();
        if(ROAccessoriesRec != null && !ROAccessoriesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ROAccessoriesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ROAccessoriesRecord ROAccessoriesRec = (ROAccessoriesRecord)sender;
        Validate_Updating();
        if(ROAccessoriesRec != null && !ROAccessoriesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.AccItemDesc field.
	/// </summary>
	public ColumnValue GetAccItemDescValue()
	{
		return this.GetValue(TableUtils.AccItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.AccItemDesc field.
	/// </summary>
	public string GetAccItemDescFieldValue()
	{
		return this.GetValue(TableUtils.AccItemDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccItemDesc field.
	/// </summary>
	public void SetAccItemDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AccItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccItemDesc field.
	/// </summary>
	public void SetAccItemDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AccItemDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.AccMake field.
	/// </summary>
	public ColumnValue GetAccMakeValue()
	{
		return this.GetValue(TableUtils.AccMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.AccMake field.
	/// </summary>
	public string GetAccMakeFieldValue()
	{
		return this.GetValue(TableUtils.AccMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccMake field.
	/// </summary>
	public void SetAccMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AccMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccMake field.
	/// </summary>
	public void SetAccMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AccMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.AccModel field.
	/// </summary>
	public ColumnValue GetAccModelValue()
	{
		return this.GetValue(TableUtils.AccModelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.AccModel field.
	/// </summary>
	public string GetAccModelFieldValue()
	{
		return this.GetValue(TableUtils.AccModelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccModel field.
	/// </summary>
	public void SetAccModelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AccModelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccModel field.
	/// </summary>
	public void SetAccModelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AccModelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.AccSerialNo field.
	/// </summary>
	public ColumnValue GetAccSerialNoValue()
	{
		return this.GetValue(TableUtils.AccSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.AccSerialNo field.
	/// </summary>
	public string GetAccSerialNoFieldValue()
	{
		return this.GetValue(TableUtils.AccSerialNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccSerialNo field.
	/// </summary>
	public void SetAccSerialNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AccSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccSerialNo field.
	/// </summary>
	public void SetAccSerialNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AccSerialNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.RONo field.
	/// </summary>
	public ColumnValue GetRONoValue()
	{
		return this.GetValue(TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.RONo field.
	/// </summary>
	public Int32 GetRONoFieldValue()
	{
		return this.GetValue(TableUtils.RONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.ROSort field.
	/// </summary>
	public ColumnValue GetROSortValue()
	{
		return this.GetValue(TableUtils.ROSortColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.ROSort field.
	/// </summary>
	public Int32 GetROSortFieldValue()
	{
		return this.GetValue(TableUtils.ROSortColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.SessionID field.
	/// </summary>
	public ColumnValue GetSessionIDValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROAccessories_.SessionID field.
	/// </summary>
	public Int32 GetSessionIDFieldValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROAccessories_.AccItemDesc field.
	/// </summary>
	public string AccItemDesc
	{
		get
		{
			return this.GetValue(TableUtils.AccItemDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AccItemDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AccItemDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AccItemDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccItemDesc field.
	/// </summary>
	public string AccItemDescDefault
	{
		get
		{
			return TableUtils.AccItemDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROAccessories_.AccMake field.
	/// </summary>
	public string AccMake
	{
		get
		{
			return this.GetValue(TableUtils.AccMakeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AccMakeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AccMakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AccMakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccMake field.
	/// </summary>
	public string AccMakeDefault
	{
		get
		{
			return TableUtils.AccMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROAccessories_.AccModel field.
	/// </summary>
	public string AccModel
	{
		get
		{
			return this.GetValue(TableUtils.AccModelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AccModelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AccModelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AccModelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccModel field.
	/// </summary>
	public string AccModelDefault
	{
		get
		{
			return TableUtils.AccModelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROAccessories_.AccSerialNo field.
	/// </summary>
	public string AccSerialNo
	{
		get
		{
			return this.GetValue(TableUtils.AccSerialNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AccSerialNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AccSerialNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AccSerialNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.AccSerialNo field.
	/// </summary>
	public string AccSerialNoDefault
	{
		get
		{
			return TableUtils.AccSerialNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROAccessories_.RONo field.
	/// </summary>
	public Int32 RONo
	{
		get
		{
			return this.GetValue(TableUtils.RONoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RONoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RONoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RONoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.RONo field.
	/// </summary>
	public string RONoDefault
	{
		get
		{
			return TableUtils.RONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROAccessories_.ROSort field.
	/// </summary>
	public Int32 ROSort
	{
		get
		{
			return this.GetValue(TableUtils.ROSortColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSortColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSortSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSortColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.ROSort field.
	/// </summary>
	public string ROSortDefault
	{
		get
		{
			return TableUtils.ROSortColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROAccessories_.SessionID field.
	/// </summary>
	public Int32 SessionID
	{
		get
		{
			return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SessionIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SessionIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SessionIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROAccessories_.SessionID field.
	/// </summary>
	public string SessionIDDefault
	{
		get
		{
			return TableUtils.SessionIDColumn.DefaultValue;
		}
	}


#endregion
}

}
