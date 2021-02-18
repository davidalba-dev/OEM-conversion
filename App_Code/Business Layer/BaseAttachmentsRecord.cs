// This class is "generated" and will be overwritten.
// Your customizations should be made in AttachmentsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="AttachmentsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AttachmentsTable"></see> class.
/// </remarks>
/// <seealso cref="AttachmentsTable"></seealso>
/// <seealso cref="AttachmentsRecord"></seealso>
public class BaseAttachmentsRecord : PrimaryKeyRecord
{

	public readonly static AttachmentsTable TableUtils = AttachmentsTable.Instance;

	// Constructors
 
	protected BaseAttachmentsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.AttachmentsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.AttachmentsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.AttachmentsRecord_ReadRecord); 
	}

	protected BaseAttachmentsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void AttachmentsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                AttachmentsRecord AttachmentsRec = (AttachmentsRecord)sender;
        if(AttachmentsRec != null && !AttachmentsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void AttachmentsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                AttachmentsRecord AttachmentsRec = (AttachmentsRecord)sender;
        Validate_Inserting();
        if(AttachmentsRec != null && !AttachmentsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void AttachmentsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                AttachmentsRecord AttachmentsRec = (AttachmentsRecord)sender;
        Validate_Updating();
        if(AttachmentsRec != null && !AttachmentsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttData field.
	/// </summary>
	public ColumnValue GetAttDataValue()
	{
		return this.GetValue(TableUtils.AttDataColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttData field.
	/// </summary>
	public string GetAttDataFieldValue()
	{
		return this.GetValue(TableUtils.AttDataColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttData field.
	/// </summary>
	public void SetAttDataFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AttDataColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttData field.
	/// </summary>
	public void SetAttDataFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttDataColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttFilename field.
	/// </summary>
	public ColumnValue GetAttFilenameValue()
	{
		return this.GetValue(TableUtils.AttFilenameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttFilename field.
	/// </summary>
	public string GetAttFilenameFieldValue()
	{
		return this.GetValue(TableUtils.AttFilenameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttFilename field.
	/// </summary>
	public void SetAttFilenameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AttFilenameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttFilename field.
	/// </summary>
	public void SetAttFilenameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttFilenameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttKey field.
	/// </summary>
	public ColumnValue GetAttKeyValue()
	{
		return this.GetValue(TableUtils.AttKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttKey field.
	/// </summary>
	public Int32 GetAttKeyFieldValue()
	{
		return this.GetValue(TableUtils.AttKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttPrint field.
	/// </summary>
	public ColumnValue GetAttPrintValue()
	{
		return this.GetValue(TableUtils.AttPrintColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttPrint field.
	/// </summary>
	public bool GetAttPrintFieldValue()
	{
		return this.GetValue(TableUtils.AttPrintColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttPrint field.
	/// </summary>
	public void SetAttPrintFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AttPrintColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttPrint field.
	/// </summary>
	public void SetAttPrintFieldValue(string val)
	{
		this.SetString(val, TableUtils.AttPrintColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttPrint field.
	/// </summary>
	public void SetAttPrintFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttPrintColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttRecKey field.
	/// </summary>
	public ColumnValue GetAttRecKeyValue()
	{
		return this.GetValue(TableUtils.AttRecKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttRecKey field.
	/// </summary>
	public Int32 GetAttRecKeyFieldValue()
	{
		return this.GetValue(TableUtils.AttRecKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttRecKey field.
	/// </summary>
	public void SetAttRecKeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AttRecKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttRecKey field.
	/// </summary>
	public void SetAttRecKeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.AttRecKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttRecKey field.
	/// </summary>
	public void SetAttRecKeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttRecKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttRecKey field.
	/// </summary>
	public void SetAttRecKeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttRecKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttRecKey field.
	/// </summary>
	public void SetAttRecKeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttRecKeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttTable field.
	/// </summary>
	public ColumnValue GetAttTableValue()
	{
		return this.GetValue(TableUtils.AttTableColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttTable field.
	/// </summary>
	public string GetAttTableFieldValue()
	{
		return this.GetValue(TableUtils.AttTableColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttTable field.
	/// </summary>
	public void SetAttTableFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AttTableColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttTable field.
	/// </summary>
	public void SetAttTableFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttTableColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttType field.
	/// </summary>
	public ColumnValue GetAttTypeValue()
	{
		return this.GetValue(TableUtils.AttTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.AttType field.
	/// </summary>
	public Byte GetAttTypeFieldValue()
	{
		return this.GetValue(TableUtils.AttTypeColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttType field.
	/// </summary>
	public void SetAttTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AttTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttType field.
	/// </summary>
	public void SetAttTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.AttTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttType field.
	/// </summary>
	public void SetAttTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttType field.
	/// </summary>
	public void SetAttTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttType field.
	/// </summary>
	public void SetAttTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AttTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Attachments_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Attachments_.AttData field.
	/// </summary>
	public string AttData
	{
		get
		{
			return this.GetValue(TableUtils.AttDataColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AttDataColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AttDataSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AttDataColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttData field.
	/// </summary>
	public string AttDataDefault
	{
		get
		{
			return TableUtils.AttDataColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Attachments_.AttFilename field.
	/// </summary>
	public string AttFilename
	{
		get
		{
			return this.GetValue(TableUtils.AttFilenameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AttFilenameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AttFilenameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AttFilenameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttFilename field.
	/// </summary>
	public string AttFilenameDefault
	{
		get
		{
			return TableUtils.AttFilenameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Attachments_.AttKey field.
	/// </summary>
	public Int32 AttKey
	{
		get
		{
			return this.GetValue(TableUtils.AttKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AttKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AttKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AttKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttKey field.
	/// </summary>
	public string AttKeyDefault
	{
		get
		{
			return TableUtils.AttKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Attachments_.AttPrint field.
	/// </summary>
	public bool AttPrint
	{
		get
		{
			return this.GetValue(TableUtils.AttPrintColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.AttPrintColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AttPrintSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AttPrintColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttPrint field.
	/// </summary>
	public string AttPrintDefault
	{
		get
		{
			return TableUtils.AttPrintColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Attachments_.AttRecKey field.
	/// </summary>
	public Int32 AttRecKey
	{
		get
		{
			return this.GetValue(TableUtils.AttRecKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AttRecKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AttRecKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AttRecKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttRecKey field.
	/// </summary>
	public string AttRecKeyDefault
	{
		get
		{
			return TableUtils.AttRecKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Attachments_.AttTable field.
	/// </summary>
	public string AttTable
	{
		get
		{
			return this.GetValue(TableUtils.AttTableColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AttTableColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AttTableSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AttTableColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttTable field.
	/// </summary>
	public string AttTableDefault
	{
		get
		{
			return TableUtils.AttTableColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Attachments_.AttType field.
	/// </summary>
	public Byte AttType
	{
		get
		{
			return this.GetValue(TableUtils.AttTypeColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AttTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AttTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AttTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.AttType field.
	/// </summary>
	public string AttTypeDefault
	{
		get
		{
			return TableUtils.AttTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Attachments_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Attachments_.SSMA_TimeStamp field.
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
