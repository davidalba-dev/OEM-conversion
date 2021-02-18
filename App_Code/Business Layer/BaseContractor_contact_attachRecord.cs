// This class is "generated" and will be overwritten.
// Your customizations should be made in Contractor_contact_attachRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Contractor_contact_attachRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Contractor_contact_attachTable"></see> class.
/// </remarks>
/// <seealso cref="Contractor_contact_attachTable"></seealso>
/// <seealso cref="Contractor_contact_attachRecord"></seealso>
public class BaseContractor_contact_attachRecord : PrimaryKeyRecord
{

	public readonly static Contractor_contact_attachTable TableUtils = Contractor_contact_attachTable.Instance;

	// Constructors
 
	protected BaseContractor_contact_attachRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Contractor_contact_attachRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Contractor_contact_attachRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Contractor_contact_attachRecord_ReadRecord); 
	}

	protected BaseContractor_contact_attachRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Contractor_contact_attachRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Contractor_contact_attachRecord Contractor_contact_attachRec = (Contractor_contact_attachRecord)sender;
        if(Contractor_contact_attachRec != null && !Contractor_contact_attachRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Contractor_contact_attachRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Contractor_contact_attachRecord Contractor_contact_attachRec = (Contractor_contact_attachRecord)sender;
        Validate_Inserting();
        if(Contractor_contact_attachRec != null && !Contractor_contact_attachRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Contractor_contact_attachRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Contractor_contact_attachRecord Contractor_contact_attachRec = (Contractor_contact_attachRecord)sender;
        Validate_Updating();
        if(Contractor_contact_attachRec != null && !Contractor_contact_attachRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_attach_.contractor_contact_attach_id field.
	/// </summary>
	public ColumnValue Getcontractor_contact_attach_idValue()
	{
		return this.GetValue(TableUtils.contractor_contact_attach_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_attach_.contractor_contact_attach_id field.
	/// </summary>
	public Int32 Getcontractor_contact_attach_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_contact_attach_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_attach_.attachment_name field.
	/// </summary>
	public ColumnValue Getattachment_nameValue()
	{
		return this.GetValue(TableUtils.attachment_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_attach_.attachment_name field.
	/// </summary>
	public string Getattachment_nameFieldValue()
	{
		return this.GetValue(TableUtils.attachment_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.attachment_name field.
	/// </summary>
	public void Setattachment_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachment_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.attachment_name field.
	/// </summary>
	public void Setattachment_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachment_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_attach_.attachment field.
	/// </summary>
	public ColumnValue GetattachmentValue()
	{
		return this.GetValue(TableUtils.attachmentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_attach_.attachment field.
	/// </summary>
	public byte[] GetattachmentFieldValue()
	{
		return this.GetValue(TableUtils.attachmentColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.attachment field.
	/// </summary>
	public void SetattachmentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.attachmentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.attachment field.
	/// </summary>
	public void SetattachmentFieldValue(string val)
	{
		this.SetString(val, TableUtils.attachmentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.attachment field.
	/// </summary>
	public void SetattachmentFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.attachmentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_attach_.contractor_contact_id field.
	/// </summary>
	public ColumnValue Getcontractor_contact_idValue()
	{
		return this.GetValue(TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's contractor_contact_attach_.contractor_contact_id field.
	/// </summary>
	public Int32 Getcontractor_contact_idFieldValue()
	{
		return this.GetValue(TableUtils.contractor_contact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_contact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.contractor_contact_id field.
	/// </summary>
	public void Setcontractor_contact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.contractor_contact_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_attach_.contractor_contact_attach_id field.
	/// </summary>
	public Int32 contractor_contact_attach_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_contact_attach_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_contact_attach_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_contact_attach_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_contact_attach_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.contractor_contact_attach_id field.
	/// </summary>
	public string contractor_contact_attach_idDefault
	{
		get
		{
			return TableUtils.contractor_contact_attach_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_attach_.attachment_name field.
	/// </summary>
	public string attachment_name
	{
		get
		{
			return this.GetValue(TableUtils.attachment_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachment_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachment_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachment_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.attachment_name field.
	/// </summary>
	public string attachment_nameDefault
	{
		get
		{
			return TableUtils.attachment_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_attach_.attachment field.
	/// </summary>
	public byte[] attachment
	{
		get
		{
			return this.GetValue(TableUtils.attachmentColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.attachmentColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool attachmentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.attachmentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.attachment field.
	/// </summary>
	public string attachmentDefault
	{
		get
		{
			return TableUtils.attachmentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's contractor_contact_attach_.contractor_contact_id field.
	/// </summary>
	public Int32 contractor_contact_id
	{
		get
		{
			return this.GetValue(TableUtils.contractor_contact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.contractor_contact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool contractor_contact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.contractor_contact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's contractor_contact_attach_.contractor_contact_id field.
	/// </summary>
	public string contractor_contact_idDefault
	{
		get
		{
			return TableUtils.contractor_contact_idColumn.DefaultValue;
		}
	}


#endregion
}

}
