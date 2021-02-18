// This class is "generated" and will be overwritten.
// Your customizations should be made in LedgerCommRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="LedgerCommRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="LedgerCommTable"></see> class.
/// </remarks>
/// <seealso cref="LedgerCommTable"></seealso>
/// <seealso cref="LedgerCommRecord"></seealso>
public class BaseLedgerCommRecord : PrimaryKeyRecord
{

	public readonly static LedgerCommTable TableUtils = LedgerCommTable.Instance;

	// Constructors
 
	protected BaseLedgerCommRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.LedgerCommRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.LedgerCommRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.LedgerCommRecord_ReadRecord); 
	}

	protected BaseLedgerCommRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void LedgerCommRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                LedgerCommRecord LedgerCommRec = (LedgerCommRecord)sender;
        if(LedgerCommRec != null && !LedgerCommRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void LedgerCommRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                LedgerCommRecord LedgerCommRec = (LedgerCommRecord)sender;
        Validate_Inserting();
        if(LedgerCommRec != null && !LedgerCommRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void LedgerCommRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                LedgerCommRecord LedgerCommRec = (LedgerCommRecord)sender;
        Validate_Updating();
        if(LedgerCommRec != null && !LedgerCommRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgAddress field.
	/// </summary>
	public ColumnValue GetLdgAddressValue()
	{
		return this.GetValue(TableUtils.LdgAddressColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgAddress field.
	/// </summary>
	public string GetLdgAddressFieldValue()
	{
		return this.GetValue(TableUtils.LdgAddressColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgAddress field.
	/// </summary>
	public void SetLdgAddressFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgAddressColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgAddress field.
	/// </summary>
	public void SetLdgAddressFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgAddressColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgAttachments field.
	/// </summary>
	public ColumnValue GetLdgAttachmentsValue()
	{
		return this.GetValue(TableUtils.LdgAttachmentsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgAttachments field.
	/// </summary>
	public string GetLdgAttachmentsFieldValue()
	{
		return this.GetValue(TableUtils.LdgAttachmentsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgAttachments field.
	/// </summary>
	public void SetLdgAttachmentsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgAttachmentsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgAttachments field.
	/// </summary>
	public void SetLdgAttachmentsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgAttachmentsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgCommType field.
	/// </summary>
	public ColumnValue GetLdgCommTypeValue()
	{
		return this.GetValue(TableUtils.LdgCommTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgCommType field.
	/// </summary>
	public Byte GetLdgCommTypeFieldValue()
	{
		return this.GetValue(TableUtils.LdgCommTypeColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgCommType field.
	/// </summary>
	public void SetLdgCommTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgCommTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgCommType field.
	/// </summary>
	public void SetLdgCommTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgCommTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgCommType field.
	/// </summary>
	public void SetLdgCommTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgCommTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgCommType field.
	/// </summary>
	public void SetLdgCommTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgCommTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgCommType field.
	/// </summary>
	public void SetLdgCommTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgCommTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgFormNo field.
	/// </summary>
	public ColumnValue GetLdgFormNoValue()
	{
		return this.GetValue(TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgFormNo field.
	/// </summary>
	public Int32 GetLdgFormNoFieldValue()
	{
		return this.GetValue(TableUtils.LdgFormNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgFormNo field.
	/// </summary>
	public void SetLdgFormNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgFormType field.
	/// </summary>
	public ColumnValue GetLdgFormTypeValue()
	{
		return this.GetValue(TableUtils.LdgFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgFormType field.
	/// </summary>
	public string GetLdgFormTypeFieldValue()
	{
		return this.GetValue(TableUtils.LdgFormTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgFormType field.
	/// </summary>
	public void SetLdgFormTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgFormTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgFormType field.
	/// </summary>
	public void SetLdgFormTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgFormTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgKey field.
	/// </summary>
	public ColumnValue GetLdgKeyValue()
	{
		return this.GetValue(TableUtils.LdgKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgKey field.
	/// </summary>
	public Int32 GetLdgKeyFieldValue()
	{
		return this.GetValue(TableUtils.LdgKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgMessage field.
	/// </summary>
	public ColumnValue GetLdgMessageValue()
	{
		return this.GetValue(TableUtils.LdgMessageColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgMessage field.
	/// </summary>
	public string GetLdgMessageFieldValue()
	{
		return this.GetValue(TableUtils.LdgMessageColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgMessage field.
	/// </summary>
	public void SetLdgMessageFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgMessageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgMessage field.
	/// </summary>
	public void SetLdgMessageFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgMessageColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgRecDate field.
	/// </summary>
	public ColumnValue GetLdgRecDateValue()
	{
		return this.GetValue(TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgRecDate field.
	/// </summary>
	public DateTime GetLdgRecDateFieldValue()
	{
		return this.GetValue(TableUtils.LdgRecDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.LdgRecDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgRecDate field.
	/// </summary>
	public void SetLdgRecDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgRecDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgSubject field.
	/// </summary>
	public ColumnValue GetLdgSubjectValue()
	{
		return this.GetValue(TableUtils.LdgSubjectColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.LdgSubject field.
	/// </summary>
	public string GetLdgSubjectFieldValue()
	{
		return this.GetValue(TableUtils.LdgSubjectColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgSubject field.
	/// </summary>
	public void SetLdgSubjectFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LdgSubjectColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgSubject field.
	/// </summary>
	public void SetLdgSubjectFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LdgSubjectColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LedgerComm_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.LdgAddress field.
	/// </summary>
	public string LdgAddress
	{
		get
		{
			return this.GetValue(TableUtils.LdgAddressColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgAddressColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgAddressSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgAddressColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgAddress field.
	/// </summary>
	public string LdgAddressDefault
	{
		get
		{
			return TableUtils.LdgAddressColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.LdgAttachments field.
	/// </summary>
	public string LdgAttachments
	{
		get
		{
			return this.GetValue(TableUtils.LdgAttachmentsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgAttachmentsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgAttachmentsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgAttachmentsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgAttachments field.
	/// </summary>
	public string LdgAttachmentsDefault
	{
		get
		{
			return TableUtils.LdgAttachmentsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.LdgCommType field.
	/// </summary>
	public Byte LdgCommType
	{
		get
		{
			return this.GetValue(TableUtils.LdgCommTypeColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgCommTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgCommTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgCommTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgCommType field.
	/// </summary>
	public string LdgCommTypeDefault
	{
		get
		{
			return TableUtils.LdgCommTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.LdgFormNo field.
	/// </summary>
	public Int32 LdgFormNo
	{
		get
		{
			return this.GetValue(TableUtils.LdgFormNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgFormNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgFormNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgFormNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgFormNo field.
	/// </summary>
	public string LdgFormNoDefault
	{
		get
		{
			return TableUtils.LdgFormNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.LdgFormType field.
	/// </summary>
	public string LdgFormType
	{
		get
		{
			return this.GetValue(TableUtils.LdgFormTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgFormTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgFormTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgFormTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgFormType field.
	/// </summary>
	public string LdgFormTypeDefault
	{
		get
		{
			return TableUtils.LdgFormTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.LdgKey field.
	/// </summary>
	public Int32 LdgKey
	{
		get
		{
			return this.GetValue(TableUtils.LdgKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgKey field.
	/// </summary>
	public string LdgKeyDefault
	{
		get
		{
			return TableUtils.LdgKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.LdgMessage field.
	/// </summary>
	public string LdgMessage
	{
		get
		{
			return this.GetValue(TableUtils.LdgMessageColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgMessageColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgMessageSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgMessageColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgMessage field.
	/// </summary>
	public string LdgMessageDefault
	{
		get
		{
			return TableUtils.LdgMessageColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.LdgRecDate field.
	/// </summary>
	public DateTime LdgRecDate
	{
		get
		{
			return this.GetValue(TableUtils.LdgRecDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgRecDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgRecDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgRecDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgRecDate field.
	/// </summary>
	public string LdgRecDateDefault
	{
		get
		{
			return TableUtils.LdgRecDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.LdgSubject field.
	/// </summary>
	public string LdgSubject
	{
		get
		{
			return this.GetValue(TableUtils.LdgSubjectColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LdgSubjectColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LdgSubjectSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LdgSubjectColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.LdgSubject field.
	/// </summary>
	public string LdgSubjectDefault
	{
		get
		{
			return TableUtils.LdgSubjectColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LedgerComm_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LedgerComm_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}


#endregion
}

}
