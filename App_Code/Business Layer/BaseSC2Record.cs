// This class is "generated" and will be overwritten.
// Your customizations should be made in SC2Record.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="SC2Record"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="SC2Table"></see> class.
/// </remarks>
/// <seealso cref="SC2Table"></seealso>
/// <seealso cref="SC2Record"></seealso>
public class BaseSC2Record : PrimaryKeyRecord
{

	public readonly static SC2Table TableUtils = SC2Table.Instance;

	// Constructors
 
	protected BaseSC2Record() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.SC2Record_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.SC2Record_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.SC2Record_ReadRecord); 
	}

	protected BaseSC2Record(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void SC2Record_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                SC2Record SC2Rec = (SC2Record)sender;
        if(SC2Rec != null && !SC2Rec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void SC2Record_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                SC2Record SC2Rec = (SC2Record)sender;
        Validate_Inserting();
        if(SC2Rec != null && !SC2Rec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void SC2Record_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                SC2Record SC2Rec = (SC2Record)sender;
        Validate_Updating();
        if(SC2Rec != null && !SC2Rec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServCategory field.
	/// </summary>
	public ColumnValue GetServCategoryValue()
	{
		return this.GetValue(TableUtils.ServCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServCategory field.
	/// </summary>
	public string GetServCategoryFieldValue()
	{
		return this.GetValue(TableUtils.ServCategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCategory field.
	/// </summary>
	public void SetServCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCategory field.
	/// </summary>
	public void SetServCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServCategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServCharge field.
	/// </summary>
	public ColumnValue GetServChargeValue()
	{
		return this.GetValue(TableUtils.ServChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServCharge field.
	/// </summary>
	public Decimal GetServChargeFieldValue()
	{
		return this.GetValue(TableUtils.ServChargeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCharge field.
	/// </summary>
	public void SetServChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCharge field.
	/// </summary>
	public void SetServChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ServChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCharge field.
	/// </summary>
	public void SetServChargeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCharge field.
	/// </summary>
	public void SetServChargeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCharge field.
	/// </summary>
	public void SetServChargeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServChargeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServCode field.
	/// </summary>
	public ColumnValue GetServCodeValue()
	{
		return this.GetValue(TableUtils.ServCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServCode field.
	/// </summary>
	public string GetServCodeFieldValue()
	{
		return this.GetValue(TableUtils.ServCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCode field.
	/// </summary>
	public void SetServCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCode field.
	/// </summary>
	public void SetServCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServCodeGroup field.
	/// </summary>
	public ColumnValue GetServCodeGroupValue()
	{
		return this.GetValue(TableUtils.ServCodeGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServCodeGroup field.
	/// </summary>
	public string GetServCodeGroupFieldValue()
	{
		return this.GetValue(TableUtils.ServCodeGroupColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCodeGroup field.
	/// </summary>
	public void SetServCodeGroupFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServCodeGroupColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCodeGroup field.
	/// </summary>
	public void SetServCodeGroupFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServCodeGroupColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServDateRecordAdded field.
	/// </summary>
	public ColumnValue GetServDateRecordAddedValue()
	{
		return this.GetValue(TableUtils.ServDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServDateRecordAdded field.
	/// </summary>
	public DateTime GetServDateRecordAddedFieldValue()
	{
		return this.GetValue(TableUtils.ServDateRecordAddedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDateRecordAdded field.
	/// </summary>
	public void SetServDateRecordAddedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDateRecordAdded field.
	/// </summary>
	public void SetServDateRecordAddedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ServDateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDateRecordAdded field.
	/// </summary>
	public void SetServDateRecordAddedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServDateRecordAddedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServDefault field.
	/// </summary>
	public ColumnValue GetServDefaultValue()
	{
		return this.GetValue(TableUtils.ServDefaultColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServDefault field.
	/// </summary>
	public bool GetServDefaultFieldValue()
	{
		return this.GetValue(TableUtils.ServDefaultColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDefault field.
	/// </summary>
	public void SetServDefaultFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServDefaultColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDefault field.
	/// </summary>
	public void SetServDefaultFieldValue(string val)
	{
		this.SetString(val, TableUtils.ServDefaultColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDefault field.
	/// </summary>
	public void SetServDefaultFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServDefaultColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServDesc field.
	/// </summary>
	public ColumnValue GetServDescValue()
	{
		return this.GetValue(TableUtils.ServDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServDesc field.
	/// </summary>
	public string GetServDescFieldValue()
	{
		return this.GetValue(TableUtils.ServDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDesc field.
	/// </summary>
	public void SetServDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDesc field.
	/// </summary>
	public void SetServDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServDropdown field.
	/// </summary>
	public ColumnValue GetServDropdownValue()
	{
		return this.GetValue(TableUtils.ServDropdownColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServDropdown field.
	/// </summary>
	public string GetServDropdownFieldValue()
	{
		return this.GetValue(TableUtils.ServDropdownColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDropdown field.
	/// </summary>
	public void SetServDropdownFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServDropdownColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDropdown field.
	/// </summary>
	public void SetServDropdownFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServDropdownColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServKey field.
	/// </summary>
	public ColumnValue GetServKeyValue()
	{
		return this.GetValue(TableUtils.ServKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServKey field.
	/// </summary>
	public Int32 GetServKeyFieldValue()
	{
		return this.GetValue(TableUtils.ServKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServNotes field.
	/// </summary>
	public ColumnValue GetServNotesValue()
	{
		return this.GetValue(TableUtils.ServNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServNotes field.
	/// </summary>
	public string GetServNotesFieldValue()
	{
		return this.GetValue(TableUtils.ServNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServNotes field.
	/// </summary>
	public void SetServNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServNotes field.
	/// </summary>
	public void SetServNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServQBItemCode field.
	/// </summary>
	public ColumnValue GetServQBItemCodeValue()
	{
		return this.GetValue(TableUtils.ServQBItemCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServQBItemCode field.
	/// </summary>
	public string GetServQBItemCodeFieldValue()
	{
		return this.GetValue(TableUtils.ServQBItemCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServQBItemCode field.
	/// </summary>
	public void SetServQBItemCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServQBItemCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServQBItemCode field.
	/// </summary>
	public void SetServQBItemCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServQBItemCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServReference1 field.
	/// </summary>
	public ColumnValue GetServReference1Value()
	{
		return this.GetValue(TableUtils.ServReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServReference1 field.
	/// </summary>
	public string GetServReference1FieldValue()
	{
		return this.GetValue(TableUtils.ServReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference1 field.
	/// </summary>
	public void SetServReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference1 field.
	/// </summary>
	public void SetServReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServReference2 field.
	/// </summary>
	public ColumnValue GetServReference2Value()
	{
		return this.GetValue(TableUtils.ServReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServReference2 field.
	/// </summary>
	public string GetServReference2FieldValue()
	{
		return this.GetValue(TableUtils.ServReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference2 field.
	/// </summary>
	public void SetServReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference2 field.
	/// </summary>
	public void SetServReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServReference3 field.
	/// </summary>
	public ColumnValue GetServReference3Value()
	{
		return this.GetValue(TableUtils.ServReference3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServReference3 field.
	/// </summary>
	public string GetServReference3FieldValue()
	{
		return this.GetValue(TableUtils.ServReference3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference3 field.
	/// </summary>
	public void SetServReference3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServReference3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference3 field.
	/// </summary>
	public void SetServReference3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServReference3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServReference4 field.
	/// </summary>
	public ColumnValue GetServReference4Value()
	{
		return this.GetValue(TableUtils.ServReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServReference4 field.
	/// </summary>
	public string GetServReference4FieldValue()
	{
		return this.GetValue(TableUtils.ServReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference4 field.
	/// </summary>
	public void SetServReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference4 field.
	/// </summary>
	public void SetServReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServRepairStep field.
	/// </summary>
	public ColumnValue GetServRepairStepValue()
	{
		return this.GetValue(TableUtils.ServRepairStepColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServRepairStep field.
	/// </summary>
	public string GetServRepairStepFieldValue()
	{
		return this.GetValue(TableUtils.ServRepairStepColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServRepairStep field.
	/// </summary>
	public void SetServRepairStepFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServRepairStepColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServRepairStep field.
	/// </summary>
	public void SetServRepairStepFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServRepairStepColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServType field.
	/// </summary>
	public ColumnValue GetServTypeValue()
	{
		return this.GetValue(TableUtils.ServTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.ServType field.
	/// </summary>
	public Byte GetServTypeFieldValue()
	{
		return this.GetValue(TableUtils.ServTypeColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServType field.
	/// </summary>
	public void SetServTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServType field.
	/// </summary>
	public void SetServTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ServTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServType field.
	/// </summary>
	public void SetServTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServType field.
	/// </summary>
	public void SetServTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServType field.
	/// </summary>
	public void SetServTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.Service_active field.
	/// </summary>
	public ColumnValue GetService_activeValue()
	{
		return this.GetValue(TableUtils.Service_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's SC2_.Service_active field.
	/// </summary>
	public bool GetService_activeFieldValue()
	{
		return this.GetValue(TableUtils.Service_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.Service_active field.
	/// </summary>
	public void SetService_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Service_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.Service_active field.
	/// </summary>
	public void SetService_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.Service_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.Service_active field.
	/// </summary>
	public void SetService_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Service_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServCategory field.
	/// </summary>
	public string ServCategory
	{
		get
		{
			return this.GetValue(TableUtils.ServCategoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServCategoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServCategorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServCategoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCategory field.
	/// </summary>
	public string ServCategoryDefault
	{
		get
		{
			return TableUtils.ServCategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServCharge field.
	/// </summary>
	public Decimal ServCharge
	{
		get
		{
			return this.GetValue(TableUtils.ServChargeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServChargeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCharge field.
	/// </summary>
	public string ServChargeDefault
	{
		get
		{
			return TableUtils.ServChargeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServCode field.
	/// </summary>
	public string ServCode
	{
		get
		{
			return this.GetValue(TableUtils.ServCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCode field.
	/// </summary>
	public string ServCodeDefault
	{
		get
		{
			return TableUtils.ServCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServCodeGroup field.
	/// </summary>
	public string ServCodeGroup
	{
		get
		{
			return this.GetValue(TableUtils.ServCodeGroupColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServCodeGroupColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServCodeGroupSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServCodeGroupColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServCodeGroup field.
	/// </summary>
	public string ServCodeGroupDefault
	{
		get
		{
			return TableUtils.ServCodeGroupColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServDateRecordAdded field.
	/// </summary>
	public DateTime ServDateRecordAdded
	{
		get
		{
			return this.GetValue(TableUtils.ServDateRecordAddedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServDateRecordAddedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServDateRecordAddedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServDateRecordAddedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDateRecordAdded field.
	/// </summary>
	public string ServDateRecordAddedDefault
	{
		get
		{
			return TableUtils.ServDateRecordAddedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServDefault field.
	/// </summary>
	public bool ServDefault
	{
		get
		{
			return this.GetValue(TableUtils.ServDefaultColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ServDefaultColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServDefaultSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServDefaultColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDefault field.
	/// </summary>
	public string ServDefaultDefault
	{
		get
		{
			return TableUtils.ServDefaultColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServDesc field.
	/// </summary>
	public string ServDesc
	{
		get
		{
			return this.GetValue(TableUtils.ServDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDesc field.
	/// </summary>
	public string ServDescDefault
	{
		get
		{
			return TableUtils.ServDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServDropdown field.
	/// </summary>
	public string ServDropdown
	{
		get
		{
			return this.GetValue(TableUtils.ServDropdownColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServDropdownColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServDropdownSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServDropdownColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServDropdown field.
	/// </summary>
	public string ServDropdownDefault
	{
		get
		{
			return TableUtils.ServDropdownColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServKey field.
	/// </summary>
	public Int32 ServKey
	{
		get
		{
			return this.GetValue(TableUtils.ServKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServKey field.
	/// </summary>
	public string ServKeyDefault
	{
		get
		{
			return TableUtils.ServKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServNotes field.
	/// </summary>
	public string ServNotes
	{
		get
		{
			return this.GetValue(TableUtils.ServNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServNotes field.
	/// </summary>
	public string ServNotesDefault
	{
		get
		{
			return TableUtils.ServNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServQBItemCode field.
	/// </summary>
	public string ServQBItemCode
	{
		get
		{
			return this.GetValue(TableUtils.ServQBItemCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServQBItemCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServQBItemCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServQBItemCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServQBItemCode field.
	/// </summary>
	public string ServQBItemCodeDefault
	{
		get
		{
			return TableUtils.ServQBItemCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServReference1 field.
	/// </summary>
	public string ServReference1
	{
		get
		{
			return this.GetValue(TableUtils.ServReference1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServReference1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServReference1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServReference1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference1 field.
	/// </summary>
	public string ServReference1Default
	{
		get
		{
			return TableUtils.ServReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServReference2 field.
	/// </summary>
	public string ServReference2
	{
		get
		{
			return this.GetValue(TableUtils.ServReference2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServReference2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServReference2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServReference2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference2 field.
	/// </summary>
	public string ServReference2Default
	{
		get
		{
			return TableUtils.ServReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServReference3 field.
	/// </summary>
	public string ServReference3
	{
		get
		{
			return this.GetValue(TableUtils.ServReference3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServReference3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServReference3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServReference3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference3 field.
	/// </summary>
	public string ServReference3Default
	{
		get
		{
			return TableUtils.ServReference3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServReference4 field.
	/// </summary>
	public string ServReference4
	{
		get
		{
			return this.GetValue(TableUtils.ServReference4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServReference4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServReference4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServReference4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServReference4 field.
	/// </summary>
	public string ServReference4Default
	{
		get
		{
			return TableUtils.ServReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServRepairStep field.
	/// </summary>
	public string ServRepairStep
	{
		get
		{
			return this.GetValue(TableUtils.ServRepairStepColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServRepairStepColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServRepairStepSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServRepairStepColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServRepairStep field.
	/// </summary>
	public string ServRepairStepDefault
	{
		get
		{
			return TableUtils.ServRepairStepColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.ServType field.
	/// </summary>
	public Byte ServType
	{
		get
		{
			return this.GetValue(TableUtils.ServTypeColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.ServType field.
	/// </summary>
	public string ServTypeDefault
	{
		get
		{
			return TableUtils.ServTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's SC2_.Service_active field.
	/// </summary>
	public bool Service_active
	{
		get
		{
			return this.GetValue(TableUtils.Service_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Service_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Service_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Service_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's SC2_.Service_active field.
	/// </summary>
	public string Service_activeDefault
	{
		get
		{
			return TableUtils.Service_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
