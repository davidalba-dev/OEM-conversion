// This class is "generated" and will be overwritten.
// Your customizations should be made in PackagesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="PackagesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PackagesTable"></see> class.
/// </remarks>
/// <seealso cref="PackagesTable"></seealso>
/// <seealso cref="PackagesRecord"></seealso>
public class BasePackagesRecord : PrimaryKeyRecord
{

	public readonly static PackagesTable TableUtils = PackagesTable.Instance;

	// Constructors
 
	protected BasePackagesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.PackagesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.PackagesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.PackagesRecord_ReadRecord); 
	}

	protected BasePackagesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void PackagesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                PackagesRecord PackagesRec = (PackagesRecord)sender;
        if(PackagesRec != null && !PackagesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void PackagesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                PackagesRecord PackagesRec = (PackagesRecord)sender;
        Validate_Inserting();
        if(PackagesRec != null && !PackagesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void PackagesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                PackagesRecord PackagesRec = (PackagesRecord)sender;
        Validate_Updating();
        if(PackagesRec != null && !PackagesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackCode field.
	/// </summary>
	public ColumnValue GetPackCodeValue()
	{
		return this.GetValue(TableUtils.PackCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackCode field.
	/// </summary>
	public string GetPackCodeFieldValue()
	{
		return this.GetValue(TableUtils.PackCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackCode field.
	/// </summary>
	public void SetPackCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackCode field.
	/// </summary>
	public void SetPackCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackCodeGroup field.
	/// </summary>
	public ColumnValue GetPackCodeGroupValue()
	{
		return this.GetValue(TableUtils.PackCodeGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackCodeGroup field.
	/// </summary>
	public string GetPackCodeGroupFieldValue()
	{
		return this.GetValue(TableUtils.PackCodeGroupColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackCodeGroup field.
	/// </summary>
	public void SetPackCodeGroupFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackCodeGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackCodeGroup field.
	/// </summary>
	public void SetPackCodeGroupFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackCodeGroupColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackDateRecordAdded field.
	/// </summary>
	public ColumnValue GetPackDateRecordAddedValue()
	{
		return this.GetValue(TableUtils.PackDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackDateRecordAdded field.
	/// </summary>
	public DateTime GetPackDateRecordAddedFieldValue()
	{
		return this.GetValue(TableUtils.PackDateRecordAddedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDateRecordAdded field.
	/// </summary>
	public void SetPackDateRecordAddedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDateRecordAdded field.
	/// </summary>
	public void SetPackDateRecordAddedFieldValue(string val)
	{
		this.SetString(val, TableUtils.PackDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDateRecordAdded field.
	/// </summary>
	public void SetPackDateRecordAddedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackDateRecordAddedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackDefault field.
	/// </summary>
	public ColumnValue GetPackDefaultValue()
	{
		return this.GetValue(TableUtils.PackDefaultColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackDefault field.
	/// </summary>
	public bool GetPackDefaultFieldValue()
	{
		return this.GetValue(TableUtils.PackDefaultColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDefault field.
	/// </summary>
	public void SetPackDefaultFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackDefaultColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDefault field.
	/// </summary>
	public void SetPackDefaultFieldValue(string val)
	{
		this.SetString(val, TableUtils.PackDefaultColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDefault field.
	/// </summary>
	public void SetPackDefaultFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackDefaultColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackDesc field.
	/// </summary>
	public ColumnValue GetPackDescValue()
	{
		return this.GetValue(TableUtils.PackDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackDesc field.
	/// </summary>
	public string GetPackDescFieldValue()
	{
		return this.GetValue(TableUtils.PackDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDesc field.
	/// </summary>
	public void SetPackDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDesc field.
	/// </summary>
	public void SetPackDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackKey field.
	/// </summary>
	public ColumnValue GetPackKeyValue()
	{
		return this.GetValue(TableUtils.PackKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackKey field.
	/// </summary>
	public Int32 GetPackKeyFieldValue()
	{
		return this.GetValue(TableUtils.PackKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackMake field.
	/// </summary>
	public ColumnValue GetPackMakeValue()
	{
		return this.GetValue(TableUtils.PackMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackMake field.
	/// </summary>
	public string GetPackMakeFieldValue()
	{
		return this.GetValue(TableUtils.PackMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackMake field.
	/// </summary>
	public void SetPackMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackMake field.
	/// </summary>
	public void SetPackMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackModels field.
	/// </summary>
	public ColumnValue GetPackModelsValue()
	{
		return this.GetValue(TableUtils.PackModelsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackModels field.
	/// </summary>
	public string GetPackModelsFieldValue()
	{
		return this.GetValue(TableUtils.PackModelsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackModels field.
	/// </summary>
	public void SetPackModelsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackModelsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackModels field.
	/// </summary>
	public void SetPackModelsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackModelsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackNotes field.
	/// </summary>
	public ColumnValue GetPackNotesValue()
	{
		return this.GetValue(TableUtils.PackNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackNotes field.
	/// </summary>
	public string GetPackNotesFieldValue()
	{
		return this.GetValue(TableUtils.PackNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackNotes field.
	/// </summary>
	public void SetPackNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackNotes field.
	/// </summary>
	public void SetPackNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackReference1 field.
	/// </summary>
	public ColumnValue GetPackReference1Value()
	{
		return this.GetValue(TableUtils.PackReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackReference1 field.
	/// </summary>
	public string GetPackReference1FieldValue()
	{
		return this.GetValue(TableUtils.PackReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference1 field.
	/// </summary>
	public void SetPackReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference1 field.
	/// </summary>
	public void SetPackReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackReference2 field.
	/// </summary>
	public ColumnValue GetPackReference2Value()
	{
		return this.GetValue(TableUtils.PackReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackReference2 field.
	/// </summary>
	public string GetPackReference2FieldValue()
	{
		return this.GetValue(TableUtils.PackReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference2 field.
	/// </summary>
	public void SetPackReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference2 field.
	/// </summary>
	public void SetPackReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackReference3 field.
	/// </summary>
	public ColumnValue GetPackReference3Value()
	{
		return this.GetValue(TableUtils.PackReference3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackReference3 field.
	/// </summary>
	public string GetPackReference3FieldValue()
	{
		return this.GetValue(TableUtils.PackReference3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference3 field.
	/// </summary>
	public void SetPackReference3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackReference3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference3 field.
	/// </summary>
	public void SetPackReference3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackReference3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackReference4 field.
	/// </summary>
	public ColumnValue GetPackReference4Value()
	{
		return this.GetValue(TableUtils.PackReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackReference4 field.
	/// </summary>
	public string GetPackReference4FieldValue()
	{
		return this.GetValue(TableUtils.PackReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference4 field.
	/// </summary>
	public void SetPackReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference4 field.
	/// </summary>
	public void SetPackReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackUpdatePrices field.
	/// </summary>
	public ColumnValue GetPackUpdatePricesValue()
	{
		return this.GetValue(TableUtils.PackUpdatePricesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.PackUpdatePrices field.
	/// </summary>
	public bool GetPackUpdatePricesFieldValue()
	{
		return this.GetValue(TableUtils.PackUpdatePricesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackUpdatePrices field.
	/// </summary>
	public void SetPackUpdatePricesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PackUpdatePricesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackUpdatePrices field.
	/// </summary>
	public void SetPackUpdatePricesFieldValue(string val)
	{
		this.SetString(val, TableUtils.PackUpdatePricesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackUpdatePrices field.
	/// </summary>
	public void SetPackUpdatePricesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PackUpdatePricesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.Pack_active field.
	/// </summary>
	public ColumnValue GetPack_activeValue()
	{
		return this.GetValue(TableUtils.Pack_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Packages_.Pack_active field.
	/// </summary>
	public bool GetPack_activeFieldValue()
	{
		return this.GetValue(TableUtils.Pack_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.Pack_active field.
	/// </summary>
	public void SetPack_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Pack_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.Pack_active field.
	/// </summary>
	public void SetPack_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.Pack_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.Pack_active field.
	/// </summary>
	public void SetPack_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Pack_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackCode field.
	/// </summary>
	public string PackCode
	{
		get
		{
			return this.GetValue(TableUtils.PackCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackCode field.
	/// </summary>
	public string PackCodeDefault
	{
		get
		{
			return TableUtils.PackCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackCodeGroup field.
	/// </summary>
	public string PackCodeGroup
	{
		get
		{
			return this.GetValue(TableUtils.PackCodeGroupColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackCodeGroupColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackCodeGroupSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackCodeGroupColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackCodeGroup field.
	/// </summary>
	public string PackCodeGroupDefault
	{
		get
		{
			return TableUtils.PackCodeGroupColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackDateRecordAdded field.
	/// </summary>
	public DateTime PackDateRecordAdded
	{
		get
		{
			return this.GetValue(TableUtils.PackDateRecordAddedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackDateRecordAddedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackDateRecordAddedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackDateRecordAddedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDateRecordAdded field.
	/// </summary>
	public string PackDateRecordAddedDefault
	{
		get
		{
			return TableUtils.PackDateRecordAddedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackDefault field.
	/// </summary>
	public bool PackDefault
	{
		get
		{
			return this.GetValue(TableUtils.PackDefaultColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PackDefaultColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackDefaultSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackDefaultColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDefault field.
	/// </summary>
	public string PackDefaultDefault
	{
		get
		{
			return TableUtils.PackDefaultColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackDesc field.
	/// </summary>
	public string PackDesc
	{
		get
		{
			return this.GetValue(TableUtils.PackDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackDesc field.
	/// </summary>
	public string PackDescDefault
	{
		get
		{
			return TableUtils.PackDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackKey field.
	/// </summary>
	public Int32 PackKey
	{
		get
		{
			return this.GetValue(TableUtils.PackKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackKey field.
	/// </summary>
	public string PackKeyDefault
	{
		get
		{
			return TableUtils.PackKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackMake field.
	/// </summary>
	public string PackMake
	{
		get
		{
			return this.GetValue(TableUtils.PackMakeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackMakeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackMakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackMakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackMake field.
	/// </summary>
	public string PackMakeDefault
	{
		get
		{
			return TableUtils.PackMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackModels field.
	/// </summary>
	public string PackModels
	{
		get
		{
			return this.GetValue(TableUtils.PackModelsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackModelsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackModelsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackModelsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackModels field.
	/// </summary>
	public string PackModelsDefault
	{
		get
		{
			return TableUtils.PackModelsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackNotes field.
	/// </summary>
	public string PackNotes
	{
		get
		{
			return this.GetValue(TableUtils.PackNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackNotes field.
	/// </summary>
	public string PackNotesDefault
	{
		get
		{
			return TableUtils.PackNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackReference1 field.
	/// </summary>
	public string PackReference1
	{
		get
		{
			return this.GetValue(TableUtils.PackReference1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackReference1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackReference1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackReference1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference1 field.
	/// </summary>
	public string PackReference1Default
	{
		get
		{
			return TableUtils.PackReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackReference2 field.
	/// </summary>
	public string PackReference2
	{
		get
		{
			return this.GetValue(TableUtils.PackReference2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackReference2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackReference2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackReference2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference2 field.
	/// </summary>
	public string PackReference2Default
	{
		get
		{
			return TableUtils.PackReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackReference3 field.
	/// </summary>
	public string PackReference3
	{
		get
		{
			return this.GetValue(TableUtils.PackReference3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackReference3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackReference3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackReference3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference3 field.
	/// </summary>
	public string PackReference3Default
	{
		get
		{
			return TableUtils.PackReference3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackReference4 field.
	/// </summary>
	public string PackReference4
	{
		get
		{
			return this.GetValue(TableUtils.PackReference4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PackReference4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackReference4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackReference4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackReference4 field.
	/// </summary>
	public string PackReference4Default
	{
		get
		{
			return TableUtils.PackReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.PackUpdatePrices field.
	/// </summary>
	public bool PackUpdatePrices
	{
		get
		{
			return this.GetValue(TableUtils.PackUpdatePricesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PackUpdatePricesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PackUpdatePricesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PackUpdatePricesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.PackUpdatePrices field.
	/// </summary>
	public string PackUpdatePricesDefault
	{
		get
		{
			return TableUtils.PackUpdatePricesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] SSMA_TimeStamp
	{
		get
		{
			return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SSMA_TimeStampColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SSMA_TimeStampSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SSMA_TimeStampColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Packages_.Pack_active field.
	/// </summary>
	public bool Pack_active
	{
		get
		{
			return this.GetValue(TableUtils.Pack_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Pack_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Pack_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Pack_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Packages_.Pack_active field.
	/// </summary>
	public string Pack_activeDefault
	{
		get
		{
			return TableUtils.Pack_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
