// This class is "generated" and will be overwritten.
// Your customizations should be made in StatusesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="StatusesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="StatusesTable"></see> class.
/// </remarks>
/// <seealso cref="StatusesTable"></seealso>
/// <seealso cref="StatusesRecord"></seealso>
public class BaseStatusesRecord : PrimaryKeyRecord
{

	public readonly static StatusesTable TableUtils = StatusesTable.Instance;

	// Constructors
 
	protected BaseStatusesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.StatusesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.StatusesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.StatusesRecord_ReadRecord); 
	}

	protected BaseStatusesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void StatusesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                StatusesRecord StatusesRec = (StatusesRecord)sender;
        if(StatusesRec != null && !StatusesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void StatusesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                StatusesRecord StatusesRec = (StatusesRecord)sender;
        Validate_Inserting();
        if(StatusesRec != null && !StatusesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void StatusesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                StatusesRecord StatusesRec = (StatusesRecord)sender;
        Validate_Updating();
        if(StatusesRec != null && !StatusesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaColor field.
	/// </summary>
	public ColumnValue GetStaColorValue()
	{
		return this.GetValue(TableUtils.StaColorColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaColor field.
	/// </summary>
	public Int32 GetStaColorFieldValue()
	{
		return this.GetValue(TableUtils.StaColorColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaColor field.
	/// </summary>
	public void SetStaColorFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaColorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaColor field.
	/// </summary>
	public void SetStaColorFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaColorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaColor field.
	/// </summary>
	public void SetStaColorFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaColorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaColor field.
	/// </summary>
	public void SetStaColorFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaColorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaColor field.
	/// </summary>
	public void SetStaColorFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaColorColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomEmailAdd field.
	/// </summary>
	public ColumnValue GetStaCustCustomEmailAddValue()
	{
		return this.GetValue(TableUtils.StaCustCustomEmailAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomEmailAdd field.
	/// </summary>
	public string GetStaCustCustomEmailAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomEmailAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailAdd field.
	/// </summary>
	public void SetStaCustCustomEmailAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomEmailAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailAdd field.
	/// </summary>
	public void SetStaCustCustomEmailAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomEmailAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomEmailEdit field.
	/// </summary>
	public ColumnValue GetStaCustCustomEmailEditValue()
	{
		return this.GetValue(TableUtils.StaCustCustomEmailEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomEmailEdit field.
	/// </summary>
	public string GetStaCustCustomEmailEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomEmailEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailEdit field.
	/// </summary>
	public void SetStaCustCustomEmailEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomEmailEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailEdit field.
	/// </summary>
	public void SetStaCustCustomEmailEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomEmailEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomEmailImport field.
	/// </summary>
	public ColumnValue GetStaCustCustomEmailImportValue()
	{
		return this.GetValue(TableUtils.StaCustCustomEmailImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomEmailImport field.
	/// </summary>
	public string GetStaCustCustomEmailImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomEmailImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailImport field.
	/// </summary>
	public void SetStaCustCustomEmailImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomEmailImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailImport field.
	/// </summary>
	public void SetStaCustCustomEmailImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomEmailImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomEmailImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustCustomEmailImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustCustomEmailImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomEmailImportUpdate field.
	/// </summary>
	public string GetStaCustCustomEmailImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomEmailImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailImportUpdate field.
	/// </summary>
	public void SetStaCustCustomEmailImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomEmailImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailImportUpdate field.
	/// </summary>
	public void SetStaCustCustomEmailImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomEmailImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomFaxAdd field.
	/// </summary>
	public ColumnValue GetStaCustCustomFaxAddValue()
	{
		return this.GetValue(TableUtils.StaCustCustomFaxAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomFaxAdd field.
	/// </summary>
	public string GetStaCustCustomFaxAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomFaxAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxAdd field.
	/// </summary>
	public void SetStaCustCustomFaxAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomFaxAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxAdd field.
	/// </summary>
	public void SetStaCustCustomFaxAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomFaxAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomFaxEdit field.
	/// </summary>
	public ColumnValue GetStaCustCustomFaxEditValue()
	{
		return this.GetValue(TableUtils.StaCustCustomFaxEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomFaxEdit field.
	/// </summary>
	public string GetStaCustCustomFaxEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomFaxEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxEdit field.
	/// </summary>
	public void SetStaCustCustomFaxEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomFaxEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxEdit field.
	/// </summary>
	public void SetStaCustCustomFaxEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomFaxEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomFaxImport field.
	/// </summary>
	public ColumnValue GetStaCustCustomFaxImportValue()
	{
		return this.GetValue(TableUtils.StaCustCustomFaxImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomFaxImport field.
	/// </summary>
	public string GetStaCustCustomFaxImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomFaxImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxImport field.
	/// </summary>
	public void SetStaCustCustomFaxImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomFaxImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxImport field.
	/// </summary>
	public void SetStaCustCustomFaxImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomFaxImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomFaxImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustCustomFaxImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustCustomFaxImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomFaxImportUpdate field.
	/// </summary>
	public string GetStaCustCustomFaxImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomFaxImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxImportUpdate field.
	/// </summary>
	public void SetStaCustCustomFaxImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomFaxImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxImportUpdate field.
	/// </summary>
	public void SetStaCustCustomFaxImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomFaxImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomSMSAdd field.
	/// </summary>
	public ColumnValue GetStaCustCustomSMSAddValue()
	{
		return this.GetValue(TableUtils.StaCustCustomSMSAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomSMSAdd field.
	/// </summary>
	public string GetStaCustCustomSMSAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomSMSAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSAdd field.
	/// </summary>
	public void SetStaCustCustomSMSAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomSMSAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSAdd field.
	/// </summary>
	public void SetStaCustCustomSMSAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomSMSAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomSMSEdit field.
	/// </summary>
	public ColumnValue GetStaCustCustomSMSEditValue()
	{
		return this.GetValue(TableUtils.StaCustCustomSMSEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomSMSEdit field.
	/// </summary>
	public string GetStaCustCustomSMSEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomSMSEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSEdit field.
	/// </summary>
	public void SetStaCustCustomSMSEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomSMSEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSEdit field.
	/// </summary>
	public void SetStaCustCustomSMSEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomSMSEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomSMSImport field.
	/// </summary>
	public ColumnValue GetStaCustCustomSMSImportValue()
	{
		return this.GetValue(TableUtils.StaCustCustomSMSImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomSMSImport field.
	/// </summary>
	public string GetStaCustCustomSMSImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomSMSImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSImport field.
	/// </summary>
	public void SetStaCustCustomSMSImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomSMSImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSImport field.
	/// </summary>
	public void SetStaCustCustomSMSImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomSMSImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomSMSImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustCustomSMSImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustCustomSMSImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustCustomSMSImportUpdate field.
	/// </summary>
	public string GetStaCustCustomSMSImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustCustomSMSImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSImportUpdate field.
	/// </summary>
	public void SetStaCustCustomSMSImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustCustomSMSImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSImportUpdate field.
	/// </summary>
	public void SetStaCustCustomSMSImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustCustomSMSImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailBCCAdd field.
	/// </summary>
	public ColumnValue GetStaCustEmailBCCAddValue()
	{
		return this.GetValue(TableUtils.StaCustEmailBCCAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailBCCAdd field.
	/// </summary>
	public string GetStaCustEmailBCCAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailBCCAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCAdd field.
	/// </summary>
	public void SetStaCustEmailBCCAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailBCCAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCAdd field.
	/// </summary>
	public void SetStaCustEmailBCCAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailBCCAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailBCCEdit field.
	/// </summary>
	public ColumnValue GetStaCustEmailBCCEditValue()
	{
		return this.GetValue(TableUtils.StaCustEmailBCCEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailBCCEdit field.
	/// </summary>
	public string GetStaCustEmailBCCEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailBCCEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCEdit field.
	/// </summary>
	public void SetStaCustEmailBCCEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailBCCEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCEdit field.
	/// </summary>
	public void SetStaCustEmailBCCEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailBCCEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailBCCImport field.
	/// </summary>
	public ColumnValue GetStaCustEmailBCCImportValue()
	{
		return this.GetValue(TableUtils.StaCustEmailBCCImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailBCCImport field.
	/// </summary>
	public string GetStaCustEmailBCCImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailBCCImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCImport field.
	/// </summary>
	public void SetStaCustEmailBCCImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailBCCImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCImport field.
	/// </summary>
	public void SetStaCustEmailBCCImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailBCCImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailBCCImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustEmailBCCImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustEmailBCCImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailBCCImportUpdate field.
	/// </summary>
	public string GetStaCustEmailBCCImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailBCCImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCImportUpdate field.
	/// </summary>
	public void SetStaCustEmailBCCImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailBCCImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCImportUpdate field.
	/// </summary>
	public void SetStaCustEmailBCCImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailBCCImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailCCAdd field.
	/// </summary>
	public ColumnValue GetStaCustEmailCCAddValue()
	{
		return this.GetValue(TableUtils.StaCustEmailCCAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailCCAdd field.
	/// </summary>
	public string GetStaCustEmailCCAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailCCAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCAdd field.
	/// </summary>
	public void SetStaCustEmailCCAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailCCAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCAdd field.
	/// </summary>
	public void SetStaCustEmailCCAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailCCAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailCCEdit field.
	/// </summary>
	public ColumnValue GetStaCustEmailCCEditValue()
	{
		return this.GetValue(TableUtils.StaCustEmailCCEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailCCEdit field.
	/// </summary>
	public string GetStaCustEmailCCEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailCCEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCEdit field.
	/// </summary>
	public void SetStaCustEmailCCEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailCCEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCEdit field.
	/// </summary>
	public void SetStaCustEmailCCEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailCCEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailCCImport field.
	/// </summary>
	public ColumnValue GetStaCustEmailCCImportValue()
	{
		return this.GetValue(TableUtils.StaCustEmailCCImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailCCImport field.
	/// </summary>
	public string GetStaCustEmailCCImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailCCImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCImport field.
	/// </summary>
	public void SetStaCustEmailCCImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailCCImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCImport field.
	/// </summary>
	public void SetStaCustEmailCCImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailCCImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailCCImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustEmailCCImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustEmailCCImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailCCImportUpdate field.
	/// </summary>
	public string GetStaCustEmailCCImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailCCImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCImportUpdate field.
	/// </summary>
	public void SetStaCustEmailCCImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailCCImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCImportUpdate field.
	/// </summary>
	public void SetStaCustEmailCCImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailCCImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailFormsAdd field.
	/// </summary>
	public ColumnValue GetStaCustEmailFormsAddValue()
	{
		return this.GetValue(TableUtils.StaCustEmailFormsAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailFormsAdd field.
	/// </summary>
	public string GetStaCustEmailFormsAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailFormsAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsAdd field.
	/// </summary>
	public void SetStaCustEmailFormsAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailFormsAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsAdd field.
	/// </summary>
	public void SetStaCustEmailFormsAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailFormsAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailFormsEdit field.
	/// </summary>
	public ColumnValue GetStaCustEmailFormsEditValue()
	{
		return this.GetValue(TableUtils.StaCustEmailFormsEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailFormsEdit field.
	/// </summary>
	public string GetStaCustEmailFormsEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailFormsEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsEdit field.
	/// </summary>
	public void SetStaCustEmailFormsEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailFormsEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsEdit field.
	/// </summary>
	public void SetStaCustEmailFormsEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailFormsEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailFormsImport field.
	/// </summary>
	public ColumnValue GetStaCustEmailFormsImportValue()
	{
		return this.GetValue(TableUtils.StaCustEmailFormsImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailFormsImport field.
	/// </summary>
	public string GetStaCustEmailFormsImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailFormsImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsImport field.
	/// </summary>
	public void SetStaCustEmailFormsImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailFormsImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsImport field.
	/// </summary>
	public void SetStaCustEmailFormsImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailFormsImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailFormsImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustEmailFormsImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustEmailFormsImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailFormsImportUpdate field.
	/// </summary>
	public string GetStaCustEmailFormsImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailFormsImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsImportUpdate field.
	/// </summary>
	public void SetStaCustEmailFormsImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailFormsImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsImportUpdate field.
	/// </summary>
	public void SetStaCustEmailFormsImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailFormsImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailToAdd field.
	/// </summary>
	public ColumnValue GetStaCustEmailToAddValue()
	{
		return this.GetValue(TableUtils.StaCustEmailToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailToAdd field.
	/// </summary>
	public string GetStaCustEmailToAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailToAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToAdd field.
	/// </summary>
	public void SetStaCustEmailToAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToAdd field.
	/// </summary>
	public void SetStaCustEmailToAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailToAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailToEdit field.
	/// </summary>
	public ColumnValue GetStaCustEmailToEditValue()
	{
		return this.GetValue(TableUtils.StaCustEmailToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailToEdit field.
	/// </summary>
	public string GetStaCustEmailToEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailToEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToEdit field.
	/// </summary>
	public void SetStaCustEmailToEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToEdit field.
	/// </summary>
	public void SetStaCustEmailToEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailToEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailToImport field.
	/// </summary>
	public ColumnValue GetStaCustEmailToImportValue()
	{
		return this.GetValue(TableUtils.StaCustEmailToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailToImport field.
	/// </summary>
	public string GetStaCustEmailToImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailToImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToImport field.
	/// </summary>
	public void SetStaCustEmailToImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToImport field.
	/// </summary>
	public void SetStaCustEmailToImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailToImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailToImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustEmailToImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustEmailToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustEmailToImportUpdate field.
	/// </summary>
	public string GetStaCustEmailToImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustEmailToImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToImportUpdate field.
	/// </summary>
	public void SetStaCustEmailToImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustEmailToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToImportUpdate field.
	/// </summary>
	public void SetStaCustEmailToImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustEmailToImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxFormsAdd field.
	/// </summary>
	public ColumnValue GetStaCustFaxFormsAddValue()
	{
		return this.GetValue(TableUtils.StaCustFaxFormsAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxFormsAdd field.
	/// </summary>
	public string GetStaCustFaxFormsAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxFormsAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsAdd field.
	/// </summary>
	public void SetStaCustFaxFormsAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxFormsAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsAdd field.
	/// </summary>
	public void SetStaCustFaxFormsAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxFormsAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxFormsEdit field.
	/// </summary>
	public ColumnValue GetStaCustFaxFormsEditValue()
	{
		return this.GetValue(TableUtils.StaCustFaxFormsEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxFormsEdit field.
	/// </summary>
	public string GetStaCustFaxFormsEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxFormsEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsEdit field.
	/// </summary>
	public void SetStaCustFaxFormsEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxFormsEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsEdit field.
	/// </summary>
	public void SetStaCustFaxFormsEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxFormsEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxFormsImport field.
	/// </summary>
	public ColumnValue GetStaCustFaxFormsImportValue()
	{
		return this.GetValue(TableUtils.StaCustFaxFormsImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxFormsImport field.
	/// </summary>
	public string GetStaCustFaxFormsImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxFormsImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsImport field.
	/// </summary>
	public void SetStaCustFaxFormsImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxFormsImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsImport field.
	/// </summary>
	public void SetStaCustFaxFormsImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxFormsImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxFormsImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustFaxFormsImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustFaxFormsImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxFormsImportUpdate field.
	/// </summary>
	public string GetStaCustFaxFormsImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxFormsImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsImportUpdate field.
	/// </summary>
	public void SetStaCustFaxFormsImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxFormsImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsImportUpdate field.
	/// </summary>
	public void SetStaCustFaxFormsImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxFormsImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeAdd field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeAddValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeAdd field.
	/// </summary>
	public string GetStaCustFaxNoticeAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeAdd field.
	/// </summary>
	public void SetStaCustFaxNoticeAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeAdd field.
	/// </summary>
	public void SetStaCustFaxNoticeAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeAddF field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeAddFValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeAddFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeAddF field.
	/// </summary>
	public string GetStaCustFaxNoticeAddFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeAddFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeAddF field.
	/// </summary>
	public void SetStaCustFaxNoticeAddFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeAddFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeAddF field.
	/// </summary>
	public void SetStaCustFaxNoticeAddFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeAddFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeAddS field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeAddSValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeAddSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeAddS field.
	/// </summary>
	public string GetStaCustFaxNoticeAddSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeAddSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeAddS field.
	/// </summary>
	public void SetStaCustFaxNoticeAddSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeAddSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeAddS field.
	/// </summary>
	public void SetStaCustFaxNoticeAddSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeAddSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeEdit field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeEditValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeEdit field.
	/// </summary>
	public string GetStaCustFaxNoticeEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeEdit field.
	/// </summary>
	public void SetStaCustFaxNoticeEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeEdit field.
	/// </summary>
	public void SetStaCustFaxNoticeEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeEditF field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeEditFValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeEditFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeEditF field.
	/// </summary>
	public string GetStaCustFaxNoticeEditFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeEditFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeEditF field.
	/// </summary>
	public void SetStaCustFaxNoticeEditFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeEditFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeEditF field.
	/// </summary>
	public void SetStaCustFaxNoticeEditFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeEditFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeEditS field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeEditSValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeEditSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeEditS field.
	/// </summary>
	public string GetStaCustFaxNoticeEditSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeEditSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeEditS field.
	/// </summary>
	public void SetStaCustFaxNoticeEditSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeEditSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeEditS field.
	/// </summary>
	public void SetStaCustFaxNoticeEditSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeEditSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeForwardOnly field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeForwardOnlyValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeForwardOnly field.
	/// </summary>
	public bool GetStaCustFaxNoticeForwardOnlyFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeForwardOnlyColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeForwardOnly field.
	/// </summary>
	public void SetStaCustFaxNoticeForwardOnlyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeForwardOnly field.
	/// </summary>
	public void SetStaCustFaxNoticeForwardOnlyFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaCustFaxNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeForwardOnly field.
	/// </summary>
	public void SetStaCustFaxNoticeForwardOnlyFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeForwardOnlyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImport field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeImportValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImport field.
	/// </summary>
	public string GetStaCustFaxNoticeImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImport field.
	/// </summary>
	public void SetStaCustFaxNoticeImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImport field.
	/// </summary>
	public void SetStaCustFaxNoticeImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportF field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeImportFValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportF field.
	/// </summary>
	public string GetStaCustFaxNoticeImportFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportF field.
	/// </summary>
	public void SetStaCustFaxNoticeImportFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeImportFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportF field.
	/// </summary>
	public void SetStaCustFaxNoticeImportFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeImportFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportS field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeImportSValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportS field.
	/// </summary>
	public string GetStaCustFaxNoticeImportSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportS field.
	/// </summary>
	public void SetStaCustFaxNoticeImportSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeImportSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportS field.
	/// </summary>
	public void SetStaCustFaxNoticeImportSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeImportSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportUpdate field.
	/// </summary>
	public string GetStaCustFaxNoticeImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportUpdate field.
	/// </summary>
	public void SetStaCustFaxNoticeImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportUpdate field.
	/// </summary>
	public void SetStaCustFaxNoticeImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportUpdateF field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeImportUpdateFValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportUpdateF field.
	/// </summary>
	public string GetStaCustFaxNoticeImportUpdateFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportUpdateF field.
	/// </summary>
	public void SetStaCustFaxNoticeImportUpdateFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeImportUpdateFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportUpdateF field.
	/// </summary>
	public void SetStaCustFaxNoticeImportUpdateFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeImportUpdateFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportUpdateS field.
	/// </summary>
	public ColumnValue GetStaCustFaxNoticeImportUpdateSValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportUpdateS field.
	/// </summary>
	public string GetStaCustFaxNoticeImportUpdateSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportUpdateS field.
	/// </summary>
	public void SetStaCustFaxNoticeImportUpdateSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxNoticeImportUpdateSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportUpdateS field.
	/// </summary>
	public void SetStaCustFaxNoticeImportUpdateSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxNoticeImportUpdateSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxToAdd field.
	/// </summary>
	public ColumnValue GetStaCustFaxToAddValue()
	{
		return this.GetValue(TableUtils.StaCustFaxToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxToAdd field.
	/// </summary>
	public string GetStaCustFaxToAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxToAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToAdd field.
	/// </summary>
	public void SetStaCustFaxToAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToAdd field.
	/// </summary>
	public void SetStaCustFaxToAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxToAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxToEdit field.
	/// </summary>
	public ColumnValue GetStaCustFaxToEditValue()
	{
		return this.GetValue(TableUtils.StaCustFaxToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxToEdit field.
	/// </summary>
	public string GetStaCustFaxToEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxToEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToEdit field.
	/// </summary>
	public void SetStaCustFaxToEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToEdit field.
	/// </summary>
	public void SetStaCustFaxToEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxToEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxToImport field.
	/// </summary>
	public ColumnValue GetStaCustFaxToImportValue()
	{
		return this.GetValue(TableUtils.StaCustFaxToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxToImport field.
	/// </summary>
	public string GetStaCustFaxToImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxToImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToImport field.
	/// </summary>
	public void SetStaCustFaxToImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToImport field.
	/// </summary>
	public void SetStaCustFaxToImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxToImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxToImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustFaxToImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustFaxToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustFaxToImportUpdate field.
	/// </summary>
	public string GetStaCustFaxToImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustFaxToImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToImportUpdate field.
	/// </summary>
	public void SetStaCustFaxToImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustFaxToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToImportUpdate field.
	/// </summary>
	public void SetStaCustFaxToImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustFaxToImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeAdd field.
	/// </summary>
	public ColumnValue GetStaCustNoticeAddValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeAdd field.
	/// </summary>
	public string GetStaCustNoticeAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeAdd field.
	/// </summary>
	public void SetStaCustNoticeAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeAdd field.
	/// </summary>
	public void SetStaCustNoticeAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeAddF field.
	/// </summary>
	public ColumnValue GetStaCustNoticeAddFValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeAddFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeAddF field.
	/// </summary>
	public string GetStaCustNoticeAddFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeAddFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeAddF field.
	/// </summary>
	public void SetStaCustNoticeAddFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeAddFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeAddF field.
	/// </summary>
	public void SetStaCustNoticeAddFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeAddFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeAddS field.
	/// </summary>
	public ColumnValue GetStaCustNoticeAddSValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeAddSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeAddS field.
	/// </summary>
	public string GetStaCustNoticeAddSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeAddSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeAddS field.
	/// </summary>
	public void SetStaCustNoticeAddSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeAddSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeAddS field.
	/// </summary>
	public void SetStaCustNoticeAddSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeAddSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeEdit field.
	/// </summary>
	public ColumnValue GetStaCustNoticeEditValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeEdit field.
	/// </summary>
	public string GetStaCustNoticeEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeEdit field.
	/// </summary>
	public void SetStaCustNoticeEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeEdit field.
	/// </summary>
	public void SetStaCustNoticeEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeEditF field.
	/// </summary>
	public ColumnValue GetStaCustNoticeEditFValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeEditFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeEditF field.
	/// </summary>
	public string GetStaCustNoticeEditFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeEditFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeEditF field.
	/// </summary>
	public void SetStaCustNoticeEditFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeEditFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeEditF field.
	/// </summary>
	public void SetStaCustNoticeEditFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeEditFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeEditS field.
	/// </summary>
	public ColumnValue GetStaCustNoticeEditSValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeEditSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeEditS field.
	/// </summary>
	public string GetStaCustNoticeEditSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeEditSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeEditS field.
	/// </summary>
	public void SetStaCustNoticeEditSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeEditSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeEditS field.
	/// </summary>
	public void SetStaCustNoticeEditSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeEditSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeForwardOnly field.
	/// </summary>
	public ColumnValue GetStaCustNoticeForwardOnlyValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeForwardOnly field.
	/// </summary>
	public bool GetStaCustNoticeForwardOnlyFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeForwardOnlyColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeForwardOnly field.
	/// </summary>
	public void SetStaCustNoticeForwardOnlyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeForwardOnly field.
	/// </summary>
	public void SetStaCustNoticeForwardOnlyFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaCustNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeForwardOnly field.
	/// </summary>
	public void SetStaCustNoticeForwardOnlyFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeForwardOnlyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImport field.
	/// </summary>
	public ColumnValue GetStaCustNoticeImportValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImport field.
	/// </summary>
	public string GetStaCustNoticeImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImport field.
	/// </summary>
	public void SetStaCustNoticeImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImport field.
	/// </summary>
	public void SetStaCustNoticeImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportF field.
	/// </summary>
	public ColumnValue GetStaCustNoticeImportFValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportF field.
	/// </summary>
	public string GetStaCustNoticeImportFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportF field.
	/// </summary>
	public void SetStaCustNoticeImportFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeImportFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportF field.
	/// </summary>
	public void SetStaCustNoticeImportFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeImportFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportS field.
	/// </summary>
	public ColumnValue GetStaCustNoticeImportSValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportS field.
	/// </summary>
	public string GetStaCustNoticeImportSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportS field.
	/// </summary>
	public void SetStaCustNoticeImportSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeImportSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportS field.
	/// </summary>
	public void SetStaCustNoticeImportSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeImportSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustNoticeImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportUpdate field.
	/// </summary>
	public string GetStaCustNoticeImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportUpdate field.
	/// </summary>
	public void SetStaCustNoticeImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportUpdate field.
	/// </summary>
	public void SetStaCustNoticeImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportUpdateF field.
	/// </summary>
	public ColumnValue GetStaCustNoticeImportUpdateFValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportUpdateFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportUpdateF field.
	/// </summary>
	public string GetStaCustNoticeImportUpdateFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportUpdateFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportUpdateF field.
	/// </summary>
	public void SetStaCustNoticeImportUpdateFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeImportUpdateFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportUpdateF field.
	/// </summary>
	public void SetStaCustNoticeImportUpdateFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeImportUpdateFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportUpdateS field.
	/// </summary>
	public ColumnValue GetStaCustNoticeImportUpdateSValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportUpdateSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustNoticeImportUpdateS field.
	/// </summary>
	public string GetStaCustNoticeImportUpdateSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustNoticeImportUpdateSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportUpdateS field.
	/// </summary>
	public void SetStaCustNoticeImportUpdateSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustNoticeImportUpdateSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportUpdateS field.
	/// </summary>
	public void SetStaCustNoticeImportUpdateSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustNoticeImportUpdateSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustomCaption field.
	/// </summary>
	public ColumnValue GetStaCustomCaptionValue()
	{
		return this.GetValue(TableUtils.StaCustomCaptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustomCaption field.
	/// </summary>
	public string GetStaCustomCaptionFieldValue()
	{
		return this.GetValue(TableUtils.StaCustomCaptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustomCaption field.
	/// </summary>
	public void SetStaCustomCaptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustomCaptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustomCaption field.
	/// </summary>
	public void SetStaCustomCaptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustomCaptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeAdd field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeAddValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeAdd field.
	/// </summary>
	public string GetStaCustSMSNoticeAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeAdd field.
	/// </summary>
	public void SetStaCustSMSNoticeAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeAdd field.
	/// </summary>
	public void SetStaCustSMSNoticeAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeAddF field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeAddFValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeAddFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeAddF field.
	/// </summary>
	public string GetStaCustSMSNoticeAddFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeAddFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeAddF field.
	/// </summary>
	public void SetStaCustSMSNoticeAddFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeAddFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeAddF field.
	/// </summary>
	public void SetStaCustSMSNoticeAddFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeAddFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeAddS field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeAddSValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeAddSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeAddS field.
	/// </summary>
	public string GetStaCustSMSNoticeAddSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeAddSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeAddS field.
	/// </summary>
	public void SetStaCustSMSNoticeAddSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeAddSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeAddS field.
	/// </summary>
	public void SetStaCustSMSNoticeAddSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeAddSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeEdit field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeEditValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeEdit field.
	/// </summary>
	public string GetStaCustSMSNoticeEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeEdit field.
	/// </summary>
	public void SetStaCustSMSNoticeEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeEdit field.
	/// </summary>
	public void SetStaCustSMSNoticeEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeEditF field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeEditFValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeEditFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeEditF field.
	/// </summary>
	public string GetStaCustSMSNoticeEditFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeEditFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeEditF field.
	/// </summary>
	public void SetStaCustSMSNoticeEditFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeEditFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeEditF field.
	/// </summary>
	public void SetStaCustSMSNoticeEditFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeEditFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeEditS field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeEditSValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeEditSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeEditS field.
	/// </summary>
	public string GetStaCustSMSNoticeEditSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeEditSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeEditS field.
	/// </summary>
	public void SetStaCustSMSNoticeEditSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeEditSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeEditS field.
	/// </summary>
	public void SetStaCustSMSNoticeEditSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeEditSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeForwardOnly field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeForwardOnlyValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeForwardOnly field.
	/// </summary>
	public bool GetStaCustSMSNoticeForwardOnlyFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeForwardOnlyColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeForwardOnly field.
	/// </summary>
	public void SetStaCustSMSNoticeForwardOnlyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeForwardOnly field.
	/// </summary>
	public void SetStaCustSMSNoticeForwardOnlyFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaCustSMSNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeForwardOnly field.
	/// </summary>
	public void SetStaCustSMSNoticeForwardOnlyFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeForwardOnlyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImport field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeImportValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImport field.
	/// </summary>
	public string GetStaCustSMSNoticeImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImport field.
	/// </summary>
	public void SetStaCustSMSNoticeImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImport field.
	/// </summary>
	public void SetStaCustSMSNoticeImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportF field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeImportFValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportF field.
	/// </summary>
	public string GetStaCustSMSNoticeImportFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportF field.
	/// </summary>
	public void SetStaCustSMSNoticeImportFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeImportFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportF field.
	/// </summary>
	public void SetStaCustSMSNoticeImportFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeImportFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportS field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeImportSValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportS field.
	/// </summary>
	public string GetStaCustSMSNoticeImportSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportS field.
	/// </summary>
	public void SetStaCustSMSNoticeImportSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeImportSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportS field.
	/// </summary>
	public void SetStaCustSMSNoticeImportSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeImportSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportUpdate field.
	/// </summary>
	public string GetStaCustSMSNoticeImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportUpdate field.
	/// </summary>
	public void SetStaCustSMSNoticeImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportUpdate field.
	/// </summary>
	public void SetStaCustSMSNoticeImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportUpdateF field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeImportUpdateFValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportUpdateF field.
	/// </summary>
	public string GetStaCustSMSNoticeImportUpdateFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportUpdateF field.
	/// </summary>
	public void SetStaCustSMSNoticeImportUpdateFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeImportUpdateFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportUpdateF field.
	/// </summary>
	public void SetStaCustSMSNoticeImportUpdateFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeImportUpdateFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportUpdateS field.
	/// </summary>
	public ColumnValue GetStaCustSMSNoticeImportUpdateSValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportUpdateS field.
	/// </summary>
	public string GetStaCustSMSNoticeImportUpdateSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportUpdateS field.
	/// </summary>
	public void SetStaCustSMSNoticeImportUpdateSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSNoticeImportUpdateSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportUpdateS field.
	/// </summary>
	public void SetStaCustSMSNoticeImportUpdateSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSNoticeImportUpdateSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSToAdd field.
	/// </summary>
	public ColumnValue GetStaCustSMSToAddValue()
	{
		return this.GetValue(TableUtils.StaCustSMSToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSToAdd field.
	/// </summary>
	public string GetStaCustSMSToAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSToAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToAdd field.
	/// </summary>
	public void SetStaCustSMSToAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToAdd field.
	/// </summary>
	public void SetStaCustSMSToAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSToAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSToEdit field.
	/// </summary>
	public ColumnValue GetStaCustSMSToEditValue()
	{
		return this.GetValue(TableUtils.StaCustSMSToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSToEdit field.
	/// </summary>
	public string GetStaCustSMSToEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSToEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToEdit field.
	/// </summary>
	public void SetStaCustSMSToEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToEdit field.
	/// </summary>
	public void SetStaCustSMSToEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSToEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSToImport field.
	/// </summary>
	public ColumnValue GetStaCustSMSToImportValue()
	{
		return this.GetValue(TableUtils.StaCustSMSToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSToImport field.
	/// </summary>
	public string GetStaCustSMSToImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSToImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToImport field.
	/// </summary>
	public void SetStaCustSMSToImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToImport field.
	/// </summary>
	public void SetStaCustSMSToImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSToImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSToImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustSMSToImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustSMSToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSMSToImportUpdate field.
	/// </summary>
	public string GetStaCustSMSToImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSMSToImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToImportUpdate field.
	/// </summary>
	public void SetStaCustSMSToImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSMSToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToImportUpdate field.
	/// </summary>
	public void SetStaCustSMSToImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSMSToImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectAdd field.
	/// </summary>
	public ColumnValue GetStaCustSubjectAddValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectAdd field.
	/// </summary>
	public string GetStaCustSubjectAddFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectAdd field.
	/// </summary>
	public void SetStaCustSubjectAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectAdd field.
	/// </summary>
	public void SetStaCustSubjectAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectAddF field.
	/// </summary>
	public ColumnValue GetStaCustSubjectAddFValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectAddFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectAddF field.
	/// </summary>
	public string GetStaCustSubjectAddFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectAddFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectAddF field.
	/// </summary>
	public void SetStaCustSubjectAddFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectAddFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectAddF field.
	/// </summary>
	public void SetStaCustSubjectAddFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectAddFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectAddS field.
	/// </summary>
	public ColumnValue GetStaCustSubjectAddSValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectAddSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectAddS field.
	/// </summary>
	public string GetStaCustSubjectAddSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectAddSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectAddS field.
	/// </summary>
	public void SetStaCustSubjectAddSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectAddSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectAddS field.
	/// </summary>
	public void SetStaCustSubjectAddSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectAddSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectEdit field.
	/// </summary>
	public ColumnValue GetStaCustSubjectEditValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectEdit field.
	/// </summary>
	public string GetStaCustSubjectEditFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectEdit field.
	/// </summary>
	public void SetStaCustSubjectEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectEdit field.
	/// </summary>
	public void SetStaCustSubjectEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectEditF field.
	/// </summary>
	public ColumnValue GetStaCustSubjectEditFValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectEditFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectEditF field.
	/// </summary>
	public string GetStaCustSubjectEditFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectEditFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectEditF field.
	/// </summary>
	public void SetStaCustSubjectEditFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectEditFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectEditF field.
	/// </summary>
	public void SetStaCustSubjectEditFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectEditFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectEditS field.
	/// </summary>
	public ColumnValue GetStaCustSubjectEditSValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectEditSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectEditS field.
	/// </summary>
	public string GetStaCustSubjectEditSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectEditSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectEditS field.
	/// </summary>
	public void SetStaCustSubjectEditSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectEditSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectEditS field.
	/// </summary>
	public void SetStaCustSubjectEditSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectEditSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImport field.
	/// </summary>
	public ColumnValue GetStaCustSubjectImportValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImport field.
	/// </summary>
	public string GetStaCustSubjectImportFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImport field.
	/// </summary>
	public void SetStaCustSubjectImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImport field.
	/// </summary>
	public void SetStaCustSubjectImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportF field.
	/// </summary>
	public ColumnValue GetStaCustSubjectImportFValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportF field.
	/// </summary>
	public string GetStaCustSubjectImportFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportF field.
	/// </summary>
	public void SetStaCustSubjectImportFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectImportFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportF field.
	/// </summary>
	public void SetStaCustSubjectImportFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectImportFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportS field.
	/// </summary>
	public ColumnValue GetStaCustSubjectImportSValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportS field.
	/// </summary>
	public string GetStaCustSubjectImportSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportS field.
	/// </summary>
	public void SetStaCustSubjectImportSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectImportSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportS field.
	/// </summary>
	public void SetStaCustSubjectImportSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectImportSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportUpdate field.
	/// </summary>
	public ColumnValue GetStaCustSubjectImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportUpdate field.
	/// </summary>
	public string GetStaCustSubjectImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportUpdate field.
	/// </summary>
	public void SetStaCustSubjectImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportUpdate field.
	/// </summary>
	public void SetStaCustSubjectImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportUpdateF field.
	/// </summary>
	public ColumnValue GetStaCustSubjectImportUpdateFValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportUpdateFColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportUpdateF field.
	/// </summary>
	public string GetStaCustSubjectImportUpdateFFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportUpdateFColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportUpdateF field.
	/// </summary>
	public void SetStaCustSubjectImportUpdateFFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectImportUpdateFColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportUpdateF field.
	/// </summary>
	public void SetStaCustSubjectImportUpdateFFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectImportUpdateFColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportUpdateS field.
	/// </summary>
	public ColumnValue GetStaCustSubjectImportUpdateSValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportUpdateSColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaCustSubjectImportUpdateS field.
	/// </summary>
	public string GetStaCustSubjectImportUpdateSFieldValue()
	{
		return this.GetValue(TableUtils.StaCustSubjectImportUpdateSColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportUpdateS field.
	/// </summary>
	public void SetStaCustSubjectImportUpdateSFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaCustSubjectImportUpdateSColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportUpdateS field.
	/// </summary>
	public void SetStaCustSubjectImportUpdateSFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaCustSubjectImportUpdateSColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaEnabled field.
	/// </summary>
	public ColumnValue GetStaEnabledValue()
	{
		return this.GetValue(TableUtils.StaEnabledColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaEnabled field.
	/// </summary>
	public bool GetStaEnabledFieldValue()
	{
		return this.GetValue(TableUtils.StaEnabledColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEnabled field.
	/// </summary>
	public void SetStaEnabledFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaEnabledColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEnabled field.
	/// </summary>
	public void SetStaEnabledFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaEnabledColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEnabled field.
	/// </summary>
	public void SetStaEnabledFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaEnabledColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaEquivalent field.
	/// </summary>
	public ColumnValue GetStaEquivalentValue()
	{
		return this.GetValue(TableUtils.StaEquivalentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaEquivalent field.
	/// </summary>
	public Byte GetStaEquivalentFieldValue()
	{
		return this.GetValue(TableUtils.StaEquivalentColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEquivalent field.
	/// </summary>
	public void SetStaEquivalentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaEquivalentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEquivalent field.
	/// </summary>
	public void SetStaEquivalentFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaEquivalentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEquivalent field.
	/// </summary>
	public void SetStaEquivalentFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaEquivalentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEquivalent field.
	/// </summary>
	public void SetStaEquivalentFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaEquivalentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEquivalent field.
	/// </summary>
	public void SetStaEquivalentFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaEquivalentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaLetter field.
	/// </summary>
	public ColumnValue GetStaLetterValue()
	{
		return this.GetValue(TableUtils.StaLetterColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaLetter field.
	/// </summary>
	public string GetStaLetterFieldValue()
	{
		return this.GetValue(TableUtils.StaLetterColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaLetter field.
	/// </summary>
	public void SetStaLetterFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaLetterColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaLetter field.
	/// </summary>
	public void SetStaLetterFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaLetterColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaNextStatus field.
	/// </summary>
	public ColumnValue GetStaNextStatusValue()
	{
		return this.GetValue(TableUtils.StaNextStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaNextStatus field.
	/// </summary>
	public string GetStaNextStatusFieldValue()
	{
		return this.GetValue(TableUtils.StaNextStatusColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaNextStatus field.
	/// </summary>
	public void SetStaNextStatusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaNextStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaNextStatus field.
	/// </summary>
	public void SetStaNextStatusFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNextStatusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaNumber field.
	/// </summary>
	public ColumnValue GetStaNumberValue()
	{
		return this.GetValue(TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaNumber field.
	/// </summary>
	public Byte GetStaNumberFieldValue()
	{
		return this.GetValue(TableUtils.StaNumberColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaOrder field.
	/// </summary>
	public ColumnValue GetStaOrderValue()
	{
		return this.GetValue(TableUtils.StaOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaOrder field.
	/// </summary>
	public Byte GetStaOrderFieldValue()
	{
		return this.GetValue(TableUtils.StaOrderColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaOrder field.
	/// </summary>
	public void SetStaOrderFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaOrder field.
	/// </summary>
	public void SetStaOrderFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaOrder field.
	/// </summary>
	public void SetStaOrderFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaOrder field.
	/// </summary>
	public void SetStaOrderFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaOrderColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaOrder field.
	/// </summary>
	public void SetStaOrderFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaOrderColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaOrigCaption field.
	/// </summary>
	public ColumnValue GetStaOrigCaptionValue()
	{
		return this.GetValue(TableUtils.StaOrigCaptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaOrigCaption field.
	/// </summary>
	public string GetStaOrigCaptionFieldValue()
	{
		return this.GetValue(TableUtils.StaOrigCaptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaOrigCaption field.
	/// </summary>
	public void SetStaOrigCaptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaOrigCaptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaOrigCaption field.
	/// </summary>
	public void SetStaOrigCaptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaOrigCaptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintFormsAdd field.
	/// </summary>
	public ColumnValue GetStaPrintFormsAddValue()
	{
		return this.GetValue(TableUtils.StaPrintFormsAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintFormsAdd field.
	/// </summary>
	public string GetStaPrintFormsAddFieldValue()
	{
		return this.GetValue(TableUtils.StaPrintFormsAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsAdd field.
	/// </summary>
	public void SetStaPrintFormsAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaPrintFormsAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsAdd field.
	/// </summary>
	public void SetStaPrintFormsAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaPrintFormsAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintFormsEdit field.
	/// </summary>
	public ColumnValue GetStaPrintFormsEditValue()
	{
		return this.GetValue(TableUtils.StaPrintFormsEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintFormsEdit field.
	/// </summary>
	public string GetStaPrintFormsEditFieldValue()
	{
		return this.GetValue(TableUtils.StaPrintFormsEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsEdit field.
	/// </summary>
	public void SetStaPrintFormsEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaPrintFormsEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsEdit field.
	/// </summary>
	public void SetStaPrintFormsEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaPrintFormsEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintFormsImport field.
	/// </summary>
	public ColumnValue GetStaPrintFormsImportValue()
	{
		return this.GetValue(TableUtils.StaPrintFormsImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintFormsImport field.
	/// </summary>
	public string GetStaPrintFormsImportFieldValue()
	{
		return this.GetValue(TableUtils.StaPrintFormsImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsImport field.
	/// </summary>
	public void SetStaPrintFormsImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaPrintFormsImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsImport field.
	/// </summary>
	public void SetStaPrintFormsImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaPrintFormsImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintFormsImportUpdate field.
	/// </summary>
	public ColumnValue GetStaPrintFormsImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaPrintFormsImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintFormsImportUpdate field.
	/// </summary>
	public string GetStaPrintFormsImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaPrintFormsImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsImportUpdate field.
	/// </summary>
	public void SetStaPrintFormsImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaPrintFormsImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsImportUpdate field.
	/// </summary>
	public void SetStaPrintFormsImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaPrintFormsImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintForwardOnly field.
	/// </summary>
	public ColumnValue GetStaPrintForwardOnlyValue()
	{
		return this.GetValue(TableUtils.StaPrintForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPrintForwardOnly field.
	/// </summary>
	public bool GetStaPrintForwardOnlyFieldValue()
	{
		return this.GetValue(TableUtils.StaPrintForwardOnlyColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintForwardOnly field.
	/// </summary>
	public void SetStaPrintForwardOnlyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaPrintForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintForwardOnly field.
	/// </summary>
	public void SetStaPrintForwardOnlyFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaPrintForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintForwardOnly field.
	/// </summary>
	public void SetStaPrintForwardOnlyFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaPrintForwardOnlyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPublishedCaption field.
	/// </summary>
	public ColumnValue GetStaPublishedCaptionValue()
	{
		return this.GetValue(TableUtils.StaPublishedCaptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaPublishedCaption field.
	/// </summary>
	public string GetStaPublishedCaptionFieldValue()
	{
		return this.GetValue(TableUtils.StaPublishedCaptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPublishedCaption field.
	/// </summary>
	public void SetStaPublishedCaptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaPublishedCaptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPublishedCaption field.
	/// </summary>
	public void SetStaPublishedCaptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaPublishedCaptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaRepeatDays field.
	/// </summary>
	public ColumnValue GetStaRepeatDaysValue()
	{
		return this.GetValue(TableUtils.StaRepeatDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaRepeatDays field.
	/// </summary>
	public Byte GetStaRepeatDaysFieldValue()
	{
		return this.GetValue(TableUtils.StaRepeatDaysColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRepeatDays field.
	/// </summary>
	public void SetStaRepeatDaysFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaRepeatDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRepeatDays field.
	/// </summary>
	public void SetStaRepeatDaysFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaRepeatDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRepeatDays field.
	/// </summary>
	public void SetStaRepeatDaysFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaRepeatDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRepeatDays field.
	/// </summary>
	public void SetStaRepeatDaysFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaRepeatDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRepeatDays field.
	/// </summary>
	public void SetStaRepeatDaysFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaRepeatDaysColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaRetail field.
	/// </summary>
	public ColumnValue GetStaRetailValue()
	{
		return this.GetValue(TableUtils.StaRetailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaRetail field.
	/// </summary>
	public bool GetStaRetailFieldValue()
	{
		return this.GetValue(TableUtils.StaRetailColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRetail field.
	/// </summary>
	public void SetStaRetailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaRetailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRetail field.
	/// </summary>
	public void SetStaRetailFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaRetailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRetail field.
	/// </summary>
	public void SetStaRetailFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaRetailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomEmailAdd field.
	/// </summary>
	public ColumnValue GetStaTechCustomEmailAddValue()
	{
		return this.GetValue(TableUtils.StaTechCustomEmailAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomEmailAdd field.
	/// </summary>
	public string GetStaTechCustomEmailAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechCustomEmailAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailAdd field.
	/// </summary>
	public void SetStaTechCustomEmailAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechCustomEmailAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailAdd field.
	/// </summary>
	public void SetStaTechCustomEmailAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechCustomEmailAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomEmailEdit field.
	/// </summary>
	public ColumnValue GetStaTechCustomEmailEditValue()
	{
		return this.GetValue(TableUtils.StaTechCustomEmailEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomEmailEdit field.
	/// </summary>
	public string GetStaTechCustomEmailEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechCustomEmailEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailEdit field.
	/// </summary>
	public void SetStaTechCustomEmailEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechCustomEmailEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailEdit field.
	/// </summary>
	public void SetStaTechCustomEmailEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechCustomEmailEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomEmailImport field.
	/// </summary>
	public ColumnValue GetStaTechCustomEmailImportValue()
	{
		return this.GetValue(TableUtils.StaTechCustomEmailImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomEmailImport field.
	/// </summary>
	public string GetStaTechCustomEmailImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechCustomEmailImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailImport field.
	/// </summary>
	public void SetStaTechCustomEmailImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechCustomEmailImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailImport field.
	/// </summary>
	public void SetStaTechCustomEmailImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechCustomEmailImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomEmailImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechCustomEmailImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechCustomEmailImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomEmailImportUpdate field.
	/// </summary>
	public string GetStaTechCustomEmailImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechCustomEmailImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailImportUpdate field.
	/// </summary>
	public void SetStaTechCustomEmailImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechCustomEmailImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailImportUpdate field.
	/// </summary>
	public void SetStaTechCustomEmailImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechCustomEmailImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomSMSAdd field.
	/// </summary>
	public ColumnValue GetStaTechCustomSMSAddValue()
	{
		return this.GetValue(TableUtils.StaTechCustomSMSAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomSMSAdd field.
	/// </summary>
	public string GetStaTechCustomSMSAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechCustomSMSAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSAdd field.
	/// </summary>
	public void SetStaTechCustomSMSAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechCustomSMSAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSAdd field.
	/// </summary>
	public void SetStaTechCustomSMSAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechCustomSMSAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomSMSEdit field.
	/// </summary>
	public ColumnValue GetStaTechCustomSMSEditValue()
	{
		return this.GetValue(TableUtils.StaTechCustomSMSEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomSMSEdit field.
	/// </summary>
	public string GetStaTechCustomSMSEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechCustomSMSEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSEdit field.
	/// </summary>
	public void SetStaTechCustomSMSEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechCustomSMSEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSEdit field.
	/// </summary>
	public void SetStaTechCustomSMSEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechCustomSMSEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomSMSImport field.
	/// </summary>
	public ColumnValue GetStaTechCustomSMSImportValue()
	{
		return this.GetValue(TableUtils.StaTechCustomSMSImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomSMSImport field.
	/// </summary>
	public string GetStaTechCustomSMSImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechCustomSMSImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSImport field.
	/// </summary>
	public void SetStaTechCustomSMSImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechCustomSMSImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSImport field.
	/// </summary>
	public void SetStaTechCustomSMSImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechCustomSMSImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomSMSImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechCustomSMSImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechCustomSMSImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechCustomSMSImportUpdate field.
	/// </summary>
	public string GetStaTechCustomSMSImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechCustomSMSImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSImportUpdate field.
	/// </summary>
	public void SetStaTechCustomSMSImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechCustomSMSImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSImportUpdate field.
	/// </summary>
	public void SetStaTechCustomSMSImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechCustomSMSImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailBCCAdd field.
	/// </summary>
	public ColumnValue GetStaTechEmailBCCAddValue()
	{
		return this.GetValue(TableUtils.StaTechEmailBCCAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailBCCAdd field.
	/// </summary>
	public string GetStaTechEmailBCCAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailBCCAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCAdd field.
	/// </summary>
	public void SetStaTechEmailBCCAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailBCCAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCAdd field.
	/// </summary>
	public void SetStaTechEmailBCCAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailBCCAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailBCCEdit field.
	/// </summary>
	public ColumnValue GetStaTechEmailBCCEditValue()
	{
		return this.GetValue(TableUtils.StaTechEmailBCCEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailBCCEdit field.
	/// </summary>
	public string GetStaTechEmailBCCEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailBCCEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCEdit field.
	/// </summary>
	public void SetStaTechEmailBCCEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailBCCEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCEdit field.
	/// </summary>
	public void SetStaTechEmailBCCEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailBCCEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailBCCImport field.
	/// </summary>
	public ColumnValue GetStaTechEmailBCCImportValue()
	{
		return this.GetValue(TableUtils.StaTechEmailBCCImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailBCCImport field.
	/// </summary>
	public string GetStaTechEmailBCCImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailBCCImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCImport field.
	/// </summary>
	public void SetStaTechEmailBCCImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailBCCImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCImport field.
	/// </summary>
	public void SetStaTechEmailBCCImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailBCCImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailBCCImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechEmailBCCImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechEmailBCCImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailBCCImportUpdate field.
	/// </summary>
	public string GetStaTechEmailBCCImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailBCCImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCImportUpdate field.
	/// </summary>
	public void SetStaTechEmailBCCImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailBCCImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCImportUpdate field.
	/// </summary>
	public void SetStaTechEmailBCCImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailBCCImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailCCAdd field.
	/// </summary>
	public ColumnValue GetStaTechEmailCCAddValue()
	{
		return this.GetValue(TableUtils.StaTechEmailCCAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailCCAdd field.
	/// </summary>
	public string GetStaTechEmailCCAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailCCAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCAdd field.
	/// </summary>
	public void SetStaTechEmailCCAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailCCAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCAdd field.
	/// </summary>
	public void SetStaTechEmailCCAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailCCAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailCCEdit field.
	/// </summary>
	public ColumnValue GetStaTechEmailCCEditValue()
	{
		return this.GetValue(TableUtils.StaTechEmailCCEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailCCEdit field.
	/// </summary>
	public string GetStaTechEmailCCEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailCCEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCEdit field.
	/// </summary>
	public void SetStaTechEmailCCEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailCCEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCEdit field.
	/// </summary>
	public void SetStaTechEmailCCEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailCCEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailCCImport field.
	/// </summary>
	public ColumnValue GetStaTechEmailCCImportValue()
	{
		return this.GetValue(TableUtils.StaTechEmailCCImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailCCImport field.
	/// </summary>
	public string GetStaTechEmailCCImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailCCImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCImport field.
	/// </summary>
	public void SetStaTechEmailCCImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailCCImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCImport field.
	/// </summary>
	public void SetStaTechEmailCCImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailCCImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailCCImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechEmailCCImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechEmailCCImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailCCImportUpdate field.
	/// </summary>
	public string GetStaTechEmailCCImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailCCImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCImportUpdate field.
	/// </summary>
	public void SetStaTechEmailCCImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailCCImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCImportUpdate field.
	/// </summary>
	public void SetStaTechEmailCCImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailCCImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailFormsAdd field.
	/// </summary>
	public ColumnValue GetStaTechEmailFormsAddValue()
	{
		return this.GetValue(TableUtils.StaTechEmailFormsAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailFormsAdd field.
	/// </summary>
	public string GetStaTechEmailFormsAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailFormsAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsAdd field.
	/// </summary>
	public void SetStaTechEmailFormsAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailFormsAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsAdd field.
	/// </summary>
	public void SetStaTechEmailFormsAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailFormsAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailFormsEdit field.
	/// </summary>
	public ColumnValue GetStaTechEmailFormsEditValue()
	{
		return this.GetValue(TableUtils.StaTechEmailFormsEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailFormsEdit field.
	/// </summary>
	public string GetStaTechEmailFormsEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailFormsEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsEdit field.
	/// </summary>
	public void SetStaTechEmailFormsEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailFormsEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsEdit field.
	/// </summary>
	public void SetStaTechEmailFormsEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailFormsEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailFormsImport field.
	/// </summary>
	public ColumnValue GetStaTechEmailFormsImportValue()
	{
		return this.GetValue(TableUtils.StaTechEmailFormsImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailFormsImport field.
	/// </summary>
	public string GetStaTechEmailFormsImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailFormsImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsImport field.
	/// </summary>
	public void SetStaTechEmailFormsImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailFormsImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsImport field.
	/// </summary>
	public void SetStaTechEmailFormsImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailFormsImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailFormsImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechEmailFormsImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechEmailFormsImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailFormsImportUpdate field.
	/// </summary>
	public string GetStaTechEmailFormsImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailFormsImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsImportUpdate field.
	/// </summary>
	public void SetStaTechEmailFormsImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailFormsImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsImportUpdate field.
	/// </summary>
	public void SetStaTechEmailFormsImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailFormsImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailToAdd field.
	/// </summary>
	public ColumnValue GetStaTechEmailToAddValue()
	{
		return this.GetValue(TableUtils.StaTechEmailToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailToAdd field.
	/// </summary>
	public string GetStaTechEmailToAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailToAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToAdd field.
	/// </summary>
	public void SetStaTechEmailToAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToAdd field.
	/// </summary>
	public void SetStaTechEmailToAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailToAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailToEdit field.
	/// </summary>
	public ColumnValue GetStaTechEmailToEditValue()
	{
		return this.GetValue(TableUtils.StaTechEmailToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailToEdit field.
	/// </summary>
	public string GetStaTechEmailToEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailToEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToEdit field.
	/// </summary>
	public void SetStaTechEmailToEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToEdit field.
	/// </summary>
	public void SetStaTechEmailToEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailToEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailToImport field.
	/// </summary>
	public ColumnValue GetStaTechEmailToImportValue()
	{
		return this.GetValue(TableUtils.StaTechEmailToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailToImport field.
	/// </summary>
	public string GetStaTechEmailToImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailToImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToImport field.
	/// </summary>
	public void SetStaTechEmailToImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToImport field.
	/// </summary>
	public void SetStaTechEmailToImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailToImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailToImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechEmailToImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechEmailToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechEmailToImportUpdate field.
	/// </summary>
	public string GetStaTechEmailToImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechEmailToImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToImportUpdate field.
	/// </summary>
	public void SetStaTechEmailToImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechEmailToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToImportUpdate field.
	/// </summary>
	public void SetStaTechEmailToImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechEmailToImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeAdd field.
	/// </summary>
	public ColumnValue GetStaTechNoticeAddValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeAdd field.
	/// </summary>
	public string GetStaTechNoticeAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeAdd field.
	/// </summary>
	public void SetStaTechNoticeAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeAdd field.
	/// </summary>
	public void SetStaTechNoticeAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechNoticeAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeEdit field.
	/// </summary>
	public ColumnValue GetStaTechNoticeEditValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeEdit field.
	/// </summary>
	public string GetStaTechNoticeEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeEdit field.
	/// </summary>
	public void SetStaTechNoticeEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeEdit field.
	/// </summary>
	public void SetStaTechNoticeEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechNoticeEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeForwardOnly field.
	/// </summary>
	public ColumnValue GetStaTechNoticeForwardOnlyValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeForwardOnly field.
	/// </summary>
	public bool GetStaTechNoticeForwardOnlyFieldValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeForwardOnlyColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeForwardOnly field.
	/// </summary>
	public void SetStaTechNoticeForwardOnlyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeForwardOnly field.
	/// </summary>
	public void SetStaTechNoticeForwardOnlyFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaTechNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeForwardOnly field.
	/// </summary>
	public void SetStaTechNoticeForwardOnlyFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechNoticeForwardOnlyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeImport field.
	/// </summary>
	public ColumnValue GetStaTechNoticeImportValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeImport field.
	/// </summary>
	public string GetStaTechNoticeImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeImport field.
	/// </summary>
	public void SetStaTechNoticeImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeImport field.
	/// </summary>
	public void SetStaTechNoticeImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechNoticeImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechNoticeImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechNoticeImportUpdate field.
	/// </summary>
	public string GetStaTechNoticeImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechNoticeImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeImportUpdate field.
	/// </summary>
	public void SetStaTechNoticeImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeImportUpdate field.
	/// </summary>
	public void SetStaTechNoticeImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechNoticeImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeAdd field.
	/// </summary>
	public ColumnValue GetStaTechSMSNoticeAddValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeAdd field.
	/// </summary>
	public string GetStaTechSMSNoticeAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeAdd field.
	/// </summary>
	public void SetStaTechSMSNoticeAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSMSNoticeAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeAdd field.
	/// </summary>
	public void SetStaTechSMSNoticeAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSMSNoticeAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeEdit field.
	/// </summary>
	public ColumnValue GetStaTechSMSNoticeEditValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeEdit field.
	/// </summary>
	public string GetStaTechSMSNoticeEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeEdit field.
	/// </summary>
	public void SetStaTechSMSNoticeEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSMSNoticeEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeEdit field.
	/// </summary>
	public void SetStaTechSMSNoticeEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSMSNoticeEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeForwardOnly field.
	/// </summary>
	public ColumnValue GetStaTechSMSNoticeForwardOnlyValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeForwardOnly field.
	/// </summary>
	public bool GetStaTechSMSNoticeForwardOnlyFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeForwardOnlyColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeForwardOnly field.
	/// </summary>
	public void SetStaTechSMSNoticeForwardOnlyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSMSNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeForwardOnly field.
	/// </summary>
	public void SetStaTechSMSNoticeForwardOnlyFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaTechSMSNoticeForwardOnlyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeForwardOnly field.
	/// </summary>
	public void SetStaTechSMSNoticeForwardOnlyFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSMSNoticeForwardOnlyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeImport field.
	/// </summary>
	public ColumnValue GetStaTechSMSNoticeImportValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeImport field.
	/// </summary>
	public string GetStaTechSMSNoticeImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeImport field.
	/// </summary>
	public void SetStaTechSMSNoticeImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSMSNoticeImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeImport field.
	/// </summary>
	public void SetStaTechSMSNoticeImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSMSNoticeImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechSMSNoticeImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeImportUpdate field.
	/// </summary>
	public string GetStaTechSMSNoticeImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSMSNoticeImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeImportUpdate field.
	/// </summary>
	public void SetStaTechSMSNoticeImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSMSNoticeImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeImportUpdate field.
	/// </summary>
	public void SetStaTechSMSNoticeImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSMSNoticeImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSToAdd field.
	/// </summary>
	public ColumnValue GetStaTechSMSToAddValue()
	{
		return this.GetValue(TableUtils.StaTechSMSToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSToAdd field.
	/// </summary>
	public string GetStaTechSMSToAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSMSToAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToAdd field.
	/// </summary>
	public void SetStaTechSMSToAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSMSToAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToAdd field.
	/// </summary>
	public void SetStaTechSMSToAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSMSToAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSToEdit field.
	/// </summary>
	public ColumnValue GetStaTechSMSToEditValue()
	{
		return this.GetValue(TableUtils.StaTechSMSToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSToEdit field.
	/// </summary>
	public string GetStaTechSMSToEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSMSToEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToEdit field.
	/// </summary>
	public void SetStaTechSMSToEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSMSToEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToEdit field.
	/// </summary>
	public void SetStaTechSMSToEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSMSToEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSToImport field.
	/// </summary>
	public ColumnValue GetStaTechSMSToImportValue()
	{
		return this.GetValue(TableUtils.StaTechSMSToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSToImport field.
	/// </summary>
	public string GetStaTechSMSToImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSMSToImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToImport field.
	/// </summary>
	public void SetStaTechSMSToImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSMSToImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToImport field.
	/// </summary>
	public void SetStaTechSMSToImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSMSToImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSToImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechSMSToImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechSMSToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSMSToImportUpdate field.
	/// </summary>
	public string GetStaTechSMSToImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSMSToImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToImportUpdate field.
	/// </summary>
	public void SetStaTechSMSToImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSMSToImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToImportUpdate field.
	/// </summary>
	public void SetStaTechSMSToImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSMSToImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSubjectAdd field.
	/// </summary>
	public ColumnValue GetStaTechSubjectAddValue()
	{
		return this.GetValue(TableUtils.StaTechSubjectAddColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSubjectAdd field.
	/// </summary>
	public string GetStaTechSubjectAddFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSubjectAddColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectAdd field.
	/// </summary>
	public void SetStaTechSubjectAddFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSubjectAddColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectAdd field.
	/// </summary>
	public void SetStaTechSubjectAddFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSubjectAddColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSubjectEdit field.
	/// </summary>
	public ColumnValue GetStaTechSubjectEditValue()
	{
		return this.GetValue(TableUtils.StaTechSubjectEditColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSubjectEdit field.
	/// </summary>
	public string GetStaTechSubjectEditFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSubjectEditColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectEdit field.
	/// </summary>
	public void SetStaTechSubjectEditFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSubjectEditColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectEdit field.
	/// </summary>
	public void SetStaTechSubjectEditFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSubjectEditColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSubjectImport field.
	/// </summary>
	public ColumnValue GetStaTechSubjectImportValue()
	{
		return this.GetValue(TableUtils.StaTechSubjectImportColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSubjectImport field.
	/// </summary>
	public string GetStaTechSubjectImportFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSubjectImportColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectImport field.
	/// </summary>
	public void SetStaTechSubjectImportFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSubjectImportColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectImport field.
	/// </summary>
	public void SetStaTechSubjectImportFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSubjectImportColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSubjectImportUpdate field.
	/// </summary>
	public ColumnValue GetStaTechSubjectImportUpdateValue()
	{
		return this.GetValue(TableUtils.StaTechSubjectImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.StaTechSubjectImportUpdate field.
	/// </summary>
	public string GetStaTechSubjectImportUpdateFieldValue()
	{
		return this.GetValue(TableUtils.StaTechSubjectImportUpdateColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectImportUpdate field.
	/// </summary>
	public void SetStaTechSubjectImportUpdateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaTechSubjectImportUpdateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectImportUpdate field.
	/// </summary>
	public void SetStaTechSubjectImportUpdateFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaTechSubjectImportUpdateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.status_active field.
	/// </summary>
	public ColumnValue Getstatus_activeValue()
	{
		return this.GetValue(TableUtils.status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.status_active field.
	/// </summary>
	public bool Getstatus_activeFieldValue()
	{
		return this.GetValue(TableUtils.status_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_active field.
	/// </summary>
	public void Setstatus_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_active field.
	/// </summary>
	public void Setstatus_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_active field.
	/// </summary>
	public void Setstatus_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.status_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.status_color field.
	/// </summary>
	public ColumnValue Getstatus_colorValue()
	{
		return this.GetValue(TableUtils.status_colorColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.status_color field.
	/// </summary>
	public string Getstatus_colorFieldValue()
	{
		return this.GetValue(TableUtils.status_colorColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_color field.
	/// </summary>
	public void Setstatus_colorFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.status_colorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_color field.
	/// </summary>
	public void Setstatus_colorFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.status_colorColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.status_customer_caption field.
	/// </summary>
	public ColumnValue Getstatus_customer_captionValue()
	{
		return this.GetValue(TableUtils.status_customer_captionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.status_customer_caption field.
	/// </summary>
	public string Getstatus_customer_captionFieldValue()
	{
		return this.GetValue(TableUtils.status_customer_captionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_customer_caption field.
	/// </summary>
	public void Setstatus_customer_captionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.status_customer_captionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_customer_caption field.
	/// </summary>
	public void Setstatus_customer_captionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.status_customer_captionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.historyro_active field.
	/// </summary>
	public ColumnValue Gethistoryro_activeValue()
	{
		return this.GetValue(TableUtils.historyro_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Statuses_.historyro_active field.
	/// </summary>
	public bool Gethistoryro_activeFieldValue()
	{
		return this.GetValue(TableUtils.historyro_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.historyro_active field.
	/// </summary>
	public void Sethistoryro_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.historyro_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.historyro_active field.
	/// </summary>
	public void Sethistoryro_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.historyro_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.historyro_active field.
	/// </summary>
	public void Sethistoryro_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.historyro_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaColor field.
	/// </summary>
	public Int32 StaColor
	{
		get
		{
			return this.GetValue(TableUtils.StaColorColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaColorColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaColorSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaColorColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaColor field.
	/// </summary>
	public string StaColorDefault
	{
		get
		{
			return TableUtils.StaColorColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomEmailAdd field.
	/// </summary>
	public string StaCustCustomEmailAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomEmailAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomEmailAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomEmailAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomEmailAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailAdd field.
	/// </summary>
	public string StaCustCustomEmailAddDefault
	{
		get
		{
			return TableUtils.StaCustCustomEmailAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomEmailEdit field.
	/// </summary>
	public string StaCustCustomEmailEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomEmailEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomEmailEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomEmailEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomEmailEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailEdit field.
	/// </summary>
	public string StaCustCustomEmailEditDefault
	{
		get
		{
			return TableUtils.StaCustCustomEmailEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomEmailImport field.
	/// </summary>
	public string StaCustCustomEmailImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomEmailImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomEmailImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomEmailImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomEmailImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailImport field.
	/// </summary>
	public string StaCustCustomEmailImportDefault
	{
		get
		{
			return TableUtils.StaCustCustomEmailImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomEmailImportUpdate field.
	/// </summary>
	public string StaCustCustomEmailImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomEmailImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomEmailImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomEmailImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomEmailImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomEmailImportUpdate field.
	/// </summary>
	public string StaCustCustomEmailImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustCustomEmailImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomFaxAdd field.
	/// </summary>
	public string StaCustCustomFaxAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomFaxAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomFaxAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomFaxAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomFaxAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxAdd field.
	/// </summary>
	public string StaCustCustomFaxAddDefault
	{
		get
		{
			return TableUtils.StaCustCustomFaxAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomFaxEdit field.
	/// </summary>
	public string StaCustCustomFaxEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomFaxEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomFaxEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomFaxEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomFaxEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxEdit field.
	/// </summary>
	public string StaCustCustomFaxEditDefault
	{
		get
		{
			return TableUtils.StaCustCustomFaxEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomFaxImport field.
	/// </summary>
	public string StaCustCustomFaxImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomFaxImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomFaxImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomFaxImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomFaxImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxImport field.
	/// </summary>
	public string StaCustCustomFaxImportDefault
	{
		get
		{
			return TableUtils.StaCustCustomFaxImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomFaxImportUpdate field.
	/// </summary>
	public string StaCustCustomFaxImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomFaxImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomFaxImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomFaxImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomFaxImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomFaxImportUpdate field.
	/// </summary>
	public string StaCustCustomFaxImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustCustomFaxImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomSMSAdd field.
	/// </summary>
	public string StaCustCustomSMSAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomSMSAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomSMSAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomSMSAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomSMSAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSAdd field.
	/// </summary>
	public string StaCustCustomSMSAddDefault
	{
		get
		{
			return TableUtils.StaCustCustomSMSAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomSMSEdit field.
	/// </summary>
	public string StaCustCustomSMSEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomSMSEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomSMSEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomSMSEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomSMSEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSEdit field.
	/// </summary>
	public string StaCustCustomSMSEditDefault
	{
		get
		{
			return TableUtils.StaCustCustomSMSEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomSMSImport field.
	/// </summary>
	public string StaCustCustomSMSImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomSMSImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomSMSImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomSMSImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomSMSImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSImport field.
	/// </summary>
	public string StaCustCustomSMSImportDefault
	{
		get
		{
			return TableUtils.StaCustCustomSMSImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustCustomSMSImportUpdate field.
	/// </summary>
	public string StaCustCustomSMSImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustCustomSMSImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustCustomSMSImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustCustomSMSImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustCustomSMSImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustCustomSMSImportUpdate field.
	/// </summary>
	public string StaCustCustomSMSImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustCustomSMSImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailBCCAdd field.
	/// </summary>
	public string StaCustEmailBCCAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailBCCAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailBCCAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailBCCAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailBCCAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCAdd field.
	/// </summary>
	public string StaCustEmailBCCAddDefault
	{
		get
		{
			return TableUtils.StaCustEmailBCCAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailBCCEdit field.
	/// </summary>
	public string StaCustEmailBCCEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailBCCEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailBCCEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailBCCEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailBCCEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCEdit field.
	/// </summary>
	public string StaCustEmailBCCEditDefault
	{
		get
		{
			return TableUtils.StaCustEmailBCCEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailBCCImport field.
	/// </summary>
	public string StaCustEmailBCCImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailBCCImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailBCCImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailBCCImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailBCCImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCImport field.
	/// </summary>
	public string StaCustEmailBCCImportDefault
	{
		get
		{
			return TableUtils.StaCustEmailBCCImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailBCCImportUpdate field.
	/// </summary>
	public string StaCustEmailBCCImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailBCCImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailBCCImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailBCCImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailBCCImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailBCCImportUpdate field.
	/// </summary>
	public string StaCustEmailBCCImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustEmailBCCImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailCCAdd field.
	/// </summary>
	public string StaCustEmailCCAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailCCAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailCCAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailCCAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailCCAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCAdd field.
	/// </summary>
	public string StaCustEmailCCAddDefault
	{
		get
		{
			return TableUtils.StaCustEmailCCAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailCCEdit field.
	/// </summary>
	public string StaCustEmailCCEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailCCEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailCCEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailCCEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailCCEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCEdit field.
	/// </summary>
	public string StaCustEmailCCEditDefault
	{
		get
		{
			return TableUtils.StaCustEmailCCEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailCCImport field.
	/// </summary>
	public string StaCustEmailCCImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailCCImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailCCImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailCCImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailCCImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCImport field.
	/// </summary>
	public string StaCustEmailCCImportDefault
	{
		get
		{
			return TableUtils.StaCustEmailCCImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailCCImportUpdate field.
	/// </summary>
	public string StaCustEmailCCImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailCCImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailCCImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailCCImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailCCImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailCCImportUpdate field.
	/// </summary>
	public string StaCustEmailCCImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustEmailCCImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailFormsAdd field.
	/// </summary>
	public string StaCustEmailFormsAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailFormsAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailFormsAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailFormsAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailFormsAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsAdd field.
	/// </summary>
	public string StaCustEmailFormsAddDefault
	{
		get
		{
			return TableUtils.StaCustEmailFormsAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailFormsEdit field.
	/// </summary>
	public string StaCustEmailFormsEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailFormsEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailFormsEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailFormsEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailFormsEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsEdit field.
	/// </summary>
	public string StaCustEmailFormsEditDefault
	{
		get
		{
			return TableUtils.StaCustEmailFormsEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailFormsImport field.
	/// </summary>
	public string StaCustEmailFormsImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailFormsImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailFormsImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailFormsImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailFormsImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsImport field.
	/// </summary>
	public string StaCustEmailFormsImportDefault
	{
		get
		{
			return TableUtils.StaCustEmailFormsImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailFormsImportUpdate field.
	/// </summary>
	public string StaCustEmailFormsImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailFormsImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailFormsImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailFormsImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailFormsImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailFormsImportUpdate field.
	/// </summary>
	public string StaCustEmailFormsImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustEmailFormsImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailToAdd field.
	/// </summary>
	public string StaCustEmailToAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailToAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailToAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailToAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailToAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToAdd field.
	/// </summary>
	public string StaCustEmailToAddDefault
	{
		get
		{
			return TableUtils.StaCustEmailToAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailToEdit field.
	/// </summary>
	public string StaCustEmailToEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailToEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailToEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailToEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailToEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToEdit field.
	/// </summary>
	public string StaCustEmailToEditDefault
	{
		get
		{
			return TableUtils.StaCustEmailToEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailToImport field.
	/// </summary>
	public string StaCustEmailToImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailToImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailToImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailToImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailToImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToImport field.
	/// </summary>
	public string StaCustEmailToImportDefault
	{
		get
		{
			return TableUtils.StaCustEmailToImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustEmailToImportUpdate field.
	/// </summary>
	public string StaCustEmailToImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustEmailToImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustEmailToImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustEmailToImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustEmailToImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustEmailToImportUpdate field.
	/// </summary>
	public string StaCustEmailToImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustEmailToImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxFormsAdd field.
	/// </summary>
	public string StaCustFaxFormsAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxFormsAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxFormsAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxFormsAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxFormsAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsAdd field.
	/// </summary>
	public string StaCustFaxFormsAddDefault
	{
		get
		{
			return TableUtils.StaCustFaxFormsAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxFormsEdit field.
	/// </summary>
	public string StaCustFaxFormsEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxFormsEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxFormsEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxFormsEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxFormsEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsEdit field.
	/// </summary>
	public string StaCustFaxFormsEditDefault
	{
		get
		{
			return TableUtils.StaCustFaxFormsEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxFormsImport field.
	/// </summary>
	public string StaCustFaxFormsImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxFormsImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxFormsImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxFormsImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxFormsImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsImport field.
	/// </summary>
	public string StaCustFaxFormsImportDefault
	{
		get
		{
			return TableUtils.StaCustFaxFormsImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxFormsImportUpdate field.
	/// </summary>
	public string StaCustFaxFormsImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxFormsImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxFormsImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxFormsImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxFormsImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxFormsImportUpdate field.
	/// </summary>
	public string StaCustFaxFormsImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustFaxFormsImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeAdd field.
	/// </summary>
	public string StaCustFaxNoticeAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeAdd field.
	/// </summary>
	public string StaCustFaxNoticeAddDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeAddF field.
	/// </summary>
	public string StaCustFaxNoticeAddF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeAddFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeAddFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeAddFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeAddFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeAddF field.
	/// </summary>
	public string StaCustFaxNoticeAddFDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeAddFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeAddS field.
	/// </summary>
	public string StaCustFaxNoticeAddS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeAddSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeAddSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeAddSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeAddSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeAddS field.
	/// </summary>
	public string StaCustFaxNoticeAddSDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeAddSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeEdit field.
	/// </summary>
	public string StaCustFaxNoticeEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeEdit field.
	/// </summary>
	public string StaCustFaxNoticeEditDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeEditF field.
	/// </summary>
	public string StaCustFaxNoticeEditF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeEditFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeEditFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeEditFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeEditFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeEditF field.
	/// </summary>
	public string StaCustFaxNoticeEditFDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeEditFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeEditS field.
	/// </summary>
	public string StaCustFaxNoticeEditS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeEditSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeEditSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeEditSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeEditSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeEditS field.
	/// </summary>
	public string StaCustFaxNoticeEditSDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeEditSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeForwardOnly field.
	/// </summary>
	public bool StaCustFaxNoticeForwardOnly
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeForwardOnlyColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.StaCustFaxNoticeForwardOnlyColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeForwardOnlySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeForwardOnlyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeForwardOnly field.
	/// </summary>
	public string StaCustFaxNoticeForwardOnlyDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeForwardOnlyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImport field.
	/// </summary>
	public string StaCustFaxNoticeImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImport field.
	/// </summary>
	public string StaCustFaxNoticeImportDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportF field.
	/// </summary>
	public string StaCustFaxNoticeImportF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeImportFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeImportFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeImportFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeImportFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportF field.
	/// </summary>
	public string StaCustFaxNoticeImportFDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeImportFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportS field.
	/// </summary>
	public string StaCustFaxNoticeImportS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeImportSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeImportSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeImportSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeImportSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportS field.
	/// </summary>
	public string StaCustFaxNoticeImportSDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeImportSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportUpdate field.
	/// </summary>
	public string StaCustFaxNoticeImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportUpdate field.
	/// </summary>
	public string StaCustFaxNoticeImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportUpdateF field.
	/// </summary>
	public string StaCustFaxNoticeImportUpdateF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeImportUpdateFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeImportUpdateFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportUpdateF field.
	/// </summary>
	public string StaCustFaxNoticeImportUpdateFDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeImportUpdateFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxNoticeImportUpdateS field.
	/// </summary>
	public string StaCustFaxNoticeImportUpdateS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxNoticeImportUpdateSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxNoticeImportUpdateSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxNoticeImportUpdateSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxNoticeImportUpdateS field.
	/// </summary>
	public string StaCustFaxNoticeImportUpdateSDefault
	{
		get
		{
			return TableUtils.StaCustFaxNoticeImportUpdateSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxToAdd field.
	/// </summary>
	public string StaCustFaxToAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxToAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxToAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxToAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxToAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToAdd field.
	/// </summary>
	public string StaCustFaxToAddDefault
	{
		get
		{
			return TableUtils.StaCustFaxToAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxToEdit field.
	/// </summary>
	public string StaCustFaxToEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxToEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxToEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxToEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxToEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToEdit field.
	/// </summary>
	public string StaCustFaxToEditDefault
	{
		get
		{
			return TableUtils.StaCustFaxToEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxToImport field.
	/// </summary>
	public string StaCustFaxToImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxToImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxToImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxToImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxToImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToImport field.
	/// </summary>
	public string StaCustFaxToImportDefault
	{
		get
		{
			return TableUtils.StaCustFaxToImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustFaxToImportUpdate field.
	/// </summary>
	public string StaCustFaxToImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustFaxToImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustFaxToImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustFaxToImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustFaxToImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustFaxToImportUpdate field.
	/// </summary>
	public string StaCustFaxToImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustFaxToImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeAdd field.
	/// </summary>
	public string StaCustNoticeAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeAdd field.
	/// </summary>
	public string StaCustNoticeAddDefault
	{
		get
		{
			return TableUtils.StaCustNoticeAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeAddF field.
	/// </summary>
	public string StaCustNoticeAddF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeAddFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeAddFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeAddFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeAddFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeAddF field.
	/// </summary>
	public string StaCustNoticeAddFDefault
	{
		get
		{
			return TableUtils.StaCustNoticeAddFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeAddS field.
	/// </summary>
	public string StaCustNoticeAddS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeAddSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeAddSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeAddSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeAddSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeAddS field.
	/// </summary>
	public string StaCustNoticeAddSDefault
	{
		get
		{
			return TableUtils.StaCustNoticeAddSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeEdit field.
	/// </summary>
	public string StaCustNoticeEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeEdit field.
	/// </summary>
	public string StaCustNoticeEditDefault
	{
		get
		{
			return TableUtils.StaCustNoticeEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeEditF field.
	/// </summary>
	public string StaCustNoticeEditF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeEditFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeEditFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeEditFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeEditFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeEditF field.
	/// </summary>
	public string StaCustNoticeEditFDefault
	{
		get
		{
			return TableUtils.StaCustNoticeEditFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeEditS field.
	/// </summary>
	public string StaCustNoticeEditS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeEditSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeEditSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeEditSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeEditSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeEditS field.
	/// </summary>
	public string StaCustNoticeEditSDefault
	{
		get
		{
			return TableUtils.StaCustNoticeEditSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeForwardOnly field.
	/// </summary>
	public bool StaCustNoticeForwardOnly
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeForwardOnlyColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.StaCustNoticeForwardOnlyColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeForwardOnlySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeForwardOnlyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeForwardOnly field.
	/// </summary>
	public string StaCustNoticeForwardOnlyDefault
	{
		get
		{
			return TableUtils.StaCustNoticeForwardOnlyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeImport field.
	/// </summary>
	public string StaCustNoticeImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImport field.
	/// </summary>
	public string StaCustNoticeImportDefault
	{
		get
		{
			return TableUtils.StaCustNoticeImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeImportF field.
	/// </summary>
	public string StaCustNoticeImportF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeImportFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeImportFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeImportFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeImportFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportF field.
	/// </summary>
	public string StaCustNoticeImportFDefault
	{
		get
		{
			return TableUtils.StaCustNoticeImportFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeImportS field.
	/// </summary>
	public string StaCustNoticeImportS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeImportSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeImportSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeImportSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeImportSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportS field.
	/// </summary>
	public string StaCustNoticeImportSDefault
	{
		get
		{
			return TableUtils.StaCustNoticeImportSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeImportUpdate field.
	/// </summary>
	public string StaCustNoticeImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportUpdate field.
	/// </summary>
	public string StaCustNoticeImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustNoticeImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeImportUpdateF field.
	/// </summary>
	public string StaCustNoticeImportUpdateF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeImportUpdateFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeImportUpdateFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeImportUpdateFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeImportUpdateFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportUpdateF field.
	/// </summary>
	public string StaCustNoticeImportUpdateFDefault
	{
		get
		{
			return TableUtils.StaCustNoticeImportUpdateFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustNoticeImportUpdateS field.
	/// </summary>
	public string StaCustNoticeImportUpdateS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustNoticeImportUpdateSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustNoticeImportUpdateSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustNoticeImportUpdateSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustNoticeImportUpdateSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustNoticeImportUpdateS field.
	/// </summary>
	public string StaCustNoticeImportUpdateSDefault
	{
		get
		{
			return TableUtils.StaCustNoticeImportUpdateSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustomCaption field.
	/// </summary>
	public string StaCustomCaption
	{
		get
		{
			return this.GetValue(TableUtils.StaCustomCaptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustomCaptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustomCaptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustomCaptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustomCaption field.
	/// </summary>
	public string StaCustomCaptionDefault
	{
		get
		{
			return TableUtils.StaCustomCaptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeAdd field.
	/// </summary>
	public string StaCustSMSNoticeAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeAdd field.
	/// </summary>
	public string StaCustSMSNoticeAddDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeAddF field.
	/// </summary>
	public string StaCustSMSNoticeAddF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeAddFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeAddFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeAddFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeAddFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeAddF field.
	/// </summary>
	public string StaCustSMSNoticeAddFDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeAddFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeAddS field.
	/// </summary>
	public string StaCustSMSNoticeAddS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeAddSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeAddSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeAddSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeAddSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeAddS field.
	/// </summary>
	public string StaCustSMSNoticeAddSDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeAddSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeEdit field.
	/// </summary>
	public string StaCustSMSNoticeEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeEdit field.
	/// </summary>
	public string StaCustSMSNoticeEditDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeEditF field.
	/// </summary>
	public string StaCustSMSNoticeEditF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeEditFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeEditFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeEditFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeEditFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeEditF field.
	/// </summary>
	public string StaCustSMSNoticeEditFDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeEditFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeEditS field.
	/// </summary>
	public string StaCustSMSNoticeEditS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeEditSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeEditSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeEditSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeEditSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeEditS field.
	/// </summary>
	public string StaCustSMSNoticeEditSDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeEditSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeForwardOnly field.
	/// </summary>
	public bool StaCustSMSNoticeForwardOnly
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeForwardOnlyColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.StaCustSMSNoticeForwardOnlyColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeForwardOnlySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeForwardOnlyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeForwardOnly field.
	/// </summary>
	public string StaCustSMSNoticeForwardOnlyDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeForwardOnlyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImport field.
	/// </summary>
	public string StaCustSMSNoticeImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImport field.
	/// </summary>
	public string StaCustSMSNoticeImportDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportF field.
	/// </summary>
	public string StaCustSMSNoticeImportF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeImportFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeImportFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeImportFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeImportFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportF field.
	/// </summary>
	public string StaCustSMSNoticeImportFDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeImportFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportS field.
	/// </summary>
	public string StaCustSMSNoticeImportS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeImportSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeImportSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeImportSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeImportSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportS field.
	/// </summary>
	public string StaCustSMSNoticeImportSDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeImportSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportUpdate field.
	/// </summary>
	public string StaCustSMSNoticeImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportUpdate field.
	/// </summary>
	public string StaCustSMSNoticeImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportUpdateF field.
	/// </summary>
	public string StaCustSMSNoticeImportUpdateF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeImportUpdateFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeImportUpdateFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportUpdateF field.
	/// </summary>
	public string StaCustSMSNoticeImportUpdateFDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeImportUpdateFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSNoticeImportUpdateS field.
	/// </summary>
	public string StaCustSMSNoticeImportUpdateS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSNoticeImportUpdateSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSNoticeImportUpdateSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSNoticeImportUpdateSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSNoticeImportUpdateS field.
	/// </summary>
	public string StaCustSMSNoticeImportUpdateSDefault
	{
		get
		{
			return TableUtils.StaCustSMSNoticeImportUpdateSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSToAdd field.
	/// </summary>
	public string StaCustSMSToAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSToAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSToAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSToAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSToAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToAdd field.
	/// </summary>
	public string StaCustSMSToAddDefault
	{
		get
		{
			return TableUtils.StaCustSMSToAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSToEdit field.
	/// </summary>
	public string StaCustSMSToEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSToEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSToEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSToEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSToEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToEdit field.
	/// </summary>
	public string StaCustSMSToEditDefault
	{
		get
		{
			return TableUtils.StaCustSMSToEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSToImport field.
	/// </summary>
	public string StaCustSMSToImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSToImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSToImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSToImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSToImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToImport field.
	/// </summary>
	public string StaCustSMSToImportDefault
	{
		get
		{
			return TableUtils.StaCustSMSToImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSMSToImportUpdate field.
	/// </summary>
	public string StaCustSMSToImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSMSToImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSMSToImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSMSToImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSMSToImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSMSToImportUpdate field.
	/// </summary>
	public string StaCustSMSToImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustSMSToImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectAdd field.
	/// </summary>
	public string StaCustSubjectAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectAdd field.
	/// </summary>
	public string StaCustSubjectAddDefault
	{
		get
		{
			return TableUtils.StaCustSubjectAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectAddF field.
	/// </summary>
	public string StaCustSubjectAddF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectAddFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectAddFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectAddFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectAddFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectAddF field.
	/// </summary>
	public string StaCustSubjectAddFDefault
	{
		get
		{
			return TableUtils.StaCustSubjectAddFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectAddS field.
	/// </summary>
	public string StaCustSubjectAddS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectAddSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectAddSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectAddSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectAddSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectAddS field.
	/// </summary>
	public string StaCustSubjectAddSDefault
	{
		get
		{
			return TableUtils.StaCustSubjectAddSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectEdit field.
	/// </summary>
	public string StaCustSubjectEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectEdit field.
	/// </summary>
	public string StaCustSubjectEditDefault
	{
		get
		{
			return TableUtils.StaCustSubjectEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectEditF field.
	/// </summary>
	public string StaCustSubjectEditF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectEditFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectEditFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectEditFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectEditFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectEditF field.
	/// </summary>
	public string StaCustSubjectEditFDefault
	{
		get
		{
			return TableUtils.StaCustSubjectEditFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectEditS field.
	/// </summary>
	public string StaCustSubjectEditS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectEditSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectEditSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectEditSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectEditSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectEditS field.
	/// </summary>
	public string StaCustSubjectEditSDefault
	{
		get
		{
			return TableUtils.StaCustSubjectEditSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectImport field.
	/// </summary>
	public string StaCustSubjectImport
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImport field.
	/// </summary>
	public string StaCustSubjectImportDefault
	{
		get
		{
			return TableUtils.StaCustSubjectImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectImportF field.
	/// </summary>
	public string StaCustSubjectImportF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectImportFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectImportFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectImportFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectImportFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportF field.
	/// </summary>
	public string StaCustSubjectImportFDefault
	{
		get
		{
			return TableUtils.StaCustSubjectImportFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectImportS field.
	/// </summary>
	public string StaCustSubjectImportS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectImportSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectImportSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectImportSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectImportSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportS field.
	/// </summary>
	public string StaCustSubjectImportSDefault
	{
		get
		{
			return TableUtils.StaCustSubjectImportSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectImportUpdate field.
	/// </summary>
	public string StaCustSubjectImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportUpdate field.
	/// </summary>
	public string StaCustSubjectImportUpdateDefault
	{
		get
		{
			return TableUtils.StaCustSubjectImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectImportUpdateF field.
	/// </summary>
	public string StaCustSubjectImportUpdateF
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectImportUpdateFColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectImportUpdateFColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectImportUpdateFSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectImportUpdateFColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportUpdateF field.
	/// </summary>
	public string StaCustSubjectImportUpdateFDefault
	{
		get
		{
			return TableUtils.StaCustSubjectImportUpdateFColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaCustSubjectImportUpdateS field.
	/// </summary>
	public string StaCustSubjectImportUpdateS
	{
		get
		{
			return this.GetValue(TableUtils.StaCustSubjectImportUpdateSColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaCustSubjectImportUpdateSColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaCustSubjectImportUpdateSSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaCustSubjectImportUpdateSColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaCustSubjectImportUpdateS field.
	/// </summary>
	public string StaCustSubjectImportUpdateSDefault
	{
		get
		{
			return TableUtils.StaCustSubjectImportUpdateSColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaEnabled field.
	/// </summary>
	public bool StaEnabled
	{
		get
		{
			return this.GetValue(TableUtils.StaEnabledColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.StaEnabledColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaEnabledSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaEnabledColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEnabled field.
	/// </summary>
	public string StaEnabledDefault
	{
		get
		{
			return TableUtils.StaEnabledColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaEquivalent field.
	/// </summary>
	public Byte StaEquivalent
	{
		get
		{
			return this.GetValue(TableUtils.StaEquivalentColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaEquivalentColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaEquivalentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaEquivalentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaEquivalent field.
	/// </summary>
	public string StaEquivalentDefault
	{
		get
		{
			return TableUtils.StaEquivalentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaLetter field.
	/// </summary>
	public string StaLetter
	{
		get
		{
			return this.GetValue(TableUtils.StaLetterColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaLetterColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaLetterSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaLetterColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaLetter field.
	/// </summary>
	public string StaLetterDefault
	{
		get
		{
			return TableUtils.StaLetterColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaNextStatus field.
	/// </summary>
	public string StaNextStatus
	{
		get
		{
			return this.GetValue(TableUtils.StaNextStatusColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaNextStatusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaNextStatusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaNextStatusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaNextStatus field.
	/// </summary>
	public string StaNextStatusDefault
	{
		get
		{
			return TableUtils.StaNextStatusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaNumber field.
	/// </summary>
	public Byte StaNumber
	{
		get
		{
			return this.GetValue(TableUtils.StaNumberColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaNumber field.
	/// </summary>
	public string StaNumberDefault
	{
		get
		{
			return TableUtils.StaNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaOrder field.
	/// </summary>
	public Byte StaOrder
	{
		get
		{
			return this.GetValue(TableUtils.StaOrderColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaOrderColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaOrderSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaOrderColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaOrder field.
	/// </summary>
	public string StaOrderDefault
	{
		get
		{
			return TableUtils.StaOrderColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaOrigCaption field.
	/// </summary>
	public string StaOrigCaption
	{
		get
		{
			return this.GetValue(TableUtils.StaOrigCaptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaOrigCaptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaOrigCaptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaOrigCaptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaOrigCaption field.
	/// </summary>
	public string StaOrigCaptionDefault
	{
		get
		{
			return TableUtils.StaOrigCaptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaPrintFormsAdd field.
	/// </summary>
	public string StaPrintFormsAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaPrintFormsAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaPrintFormsAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaPrintFormsAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaPrintFormsAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsAdd field.
	/// </summary>
	public string StaPrintFormsAddDefault
	{
		get
		{
			return TableUtils.StaPrintFormsAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaPrintFormsEdit field.
	/// </summary>
	public string StaPrintFormsEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaPrintFormsEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaPrintFormsEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaPrintFormsEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaPrintFormsEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsEdit field.
	/// </summary>
	public string StaPrintFormsEditDefault
	{
		get
		{
			return TableUtils.StaPrintFormsEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaPrintFormsImport field.
	/// </summary>
	public string StaPrintFormsImport
	{
		get
		{
			return this.GetValue(TableUtils.StaPrintFormsImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaPrintFormsImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaPrintFormsImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaPrintFormsImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsImport field.
	/// </summary>
	public string StaPrintFormsImportDefault
	{
		get
		{
			return TableUtils.StaPrintFormsImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaPrintFormsImportUpdate field.
	/// </summary>
	public string StaPrintFormsImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaPrintFormsImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaPrintFormsImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaPrintFormsImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaPrintFormsImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintFormsImportUpdate field.
	/// </summary>
	public string StaPrintFormsImportUpdateDefault
	{
		get
		{
			return TableUtils.StaPrintFormsImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaPrintForwardOnly field.
	/// </summary>
	public bool StaPrintForwardOnly
	{
		get
		{
			return this.GetValue(TableUtils.StaPrintForwardOnlyColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.StaPrintForwardOnlyColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaPrintForwardOnlySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaPrintForwardOnlyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPrintForwardOnly field.
	/// </summary>
	public string StaPrintForwardOnlyDefault
	{
		get
		{
			return TableUtils.StaPrintForwardOnlyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaPublishedCaption field.
	/// </summary>
	public string StaPublishedCaption
	{
		get
		{
			return this.GetValue(TableUtils.StaPublishedCaptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaPublishedCaptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaPublishedCaptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaPublishedCaptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaPublishedCaption field.
	/// </summary>
	public string StaPublishedCaptionDefault
	{
		get
		{
			return TableUtils.StaPublishedCaptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaRepeatDays field.
	/// </summary>
	public Byte StaRepeatDays
	{
		get
		{
			return this.GetValue(TableUtils.StaRepeatDaysColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaRepeatDaysColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaRepeatDaysSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaRepeatDaysColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRepeatDays field.
	/// </summary>
	public string StaRepeatDaysDefault
	{
		get
		{
			return TableUtils.StaRepeatDaysColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaRetail field.
	/// </summary>
	public bool StaRetail
	{
		get
		{
			return this.GetValue(TableUtils.StaRetailColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.StaRetailColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaRetailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaRetailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaRetail field.
	/// </summary>
	public string StaRetailDefault
	{
		get
		{
			return TableUtils.StaRetailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechCustomEmailAdd field.
	/// </summary>
	public string StaTechCustomEmailAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechCustomEmailAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechCustomEmailAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechCustomEmailAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechCustomEmailAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailAdd field.
	/// </summary>
	public string StaTechCustomEmailAddDefault
	{
		get
		{
			return TableUtils.StaTechCustomEmailAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechCustomEmailEdit field.
	/// </summary>
	public string StaTechCustomEmailEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechCustomEmailEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechCustomEmailEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechCustomEmailEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechCustomEmailEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailEdit field.
	/// </summary>
	public string StaTechCustomEmailEditDefault
	{
		get
		{
			return TableUtils.StaTechCustomEmailEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechCustomEmailImport field.
	/// </summary>
	public string StaTechCustomEmailImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechCustomEmailImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechCustomEmailImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechCustomEmailImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechCustomEmailImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailImport field.
	/// </summary>
	public string StaTechCustomEmailImportDefault
	{
		get
		{
			return TableUtils.StaTechCustomEmailImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechCustomEmailImportUpdate field.
	/// </summary>
	public string StaTechCustomEmailImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechCustomEmailImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechCustomEmailImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechCustomEmailImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechCustomEmailImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomEmailImportUpdate field.
	/// </summary>
	public string StaTechCustomEmailImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechCustomEmailImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechCustomSMSAdd field.
	/// </summary>
	public string StaTechCustomSMSAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechCustomSMSAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechCustomSMSAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechCustomSMSAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechCustomSMSAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSAdd field.
	/// </summary>
	public string StaTechCustomSMSAddDefault
	{
		get
		{
			return TableUtils.StaTechCustomSMSAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechCustomSMSEdit field.
	/// </summary>
	public string StaTechCustomSMSEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechCustomSMSEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechCustomSMSEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechCustomSMSEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechCustomSMSEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSEdit field.
	/// </summary>
	public string StaTechCustomSMSEditDefault
	{
		get
		{
			return TableUtils.StaTechCustomSMSEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechCustomSMSImport field.
	/// </summary>
	public string StaTechCustomSMSImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechCustomSMSImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechCustomSMSImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechCustomSMSImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechCustomSMSImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSImport field.
	/// </summary>
	public string StaTechCustomSMSImportDefault
	{
		get
		{
			return TableUtils.StaTechCustomSMSImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechCustomSMSImportUpdate field.
	/// </summary>
	public string StaTechCustomSMSImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechCustomSMSImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechCustomSMSImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechCustomSMSImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechCustomSMSImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechCustomSMSImportUpdate field.
	/// </summary>
	public string StaTechCustomSMSImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechCustomSMSImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailBCCAdd field.
	/// </summary>
	public string StaTechEmailBCCAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailBCCAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailBCCAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailBCCAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailBCCAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCAdd field.
	/// </summary>
	public string StaTechEmailBCCAddDefault
	{
		get
		{
			return TableUtils.StaTechEmailBCCAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailBCCEdit field.
	/// </summary>
	public string StaTechEmailBCCEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailBCCEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailBCCEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailBCCEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailBCCEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCEdit field.
	/// </summary>
	public string StaTechEmailBCCEditDefault
	{
		get
		{
			return TableUtils.StaTechEmailBCCEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailBCCImport field.
	/// </summary>
	public string StaTechEmailBCCImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailBCCImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailBCCImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailBCCImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailBCCImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCImport field.
	/// </summary>
	public string StaTechEmailBCCImportDefault
	{
		get
		{
			return TableUtils.StaTechEmailBCCImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailBCCImportUpdate field.
	/// </summary>
	public string StaTechEmailBCCImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailBCCImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailBCCImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailBCCImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailBCCImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailBCCImportUpdate field.
	/// </summary>
	public string StaTechEmailBCCImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechEmailBCCImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailCCAdd field.
	/// </summary>
	public string StaTechEmailCCAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailCCAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailCCAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailCCAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailCCAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCAdd field.
	/// </summary>
	public string StaTechEmailCCAddDefault
	{
		get
		{
			return TableUtils.StaTechEmailCCAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailCCEdit field.
	/// </summary>
	public string StaTechEmailCCEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailCCEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailCCEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailCCEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailCCEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCEdit field.
	/// </summary>
	public string StaTechEmailCCEditDefault
	{
		get
		{
			return TableUtils.StaTechEmailCCEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailCCImport field.
	/// </summary>
	public string StaTechEmailCCImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailCCImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailCCImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailCCImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailCCImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCImport field.
	/// </summary>
	public string StaTechEmailCCImportDefault
	{
		get
		{
			return TableUtils.StaTechEmailCCImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailCCImportUpdate field.
	/// </summary>
	public string StaTechEmailCCImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailCCImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailCCImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailCCImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailCCImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailCCImportUpdate field.
	/// </summary>
	public string StaTechEmailCCImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechEmailCCImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailFormsAdd field.
	/// </summary>
	public string StaTechEmailFormsAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailFormsAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailFormsAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailFormsAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailFormsAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsAdd field.
	/// </summary>
	public string StaTechEmailFormsAddDefault
	{
		get
		{
			return TableUtils.StaTechEmailFormsAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailFormsEdit field.
	/// </summary>
	public string StaTechEmailFormsEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailFormsEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailFormsEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailFormsEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailFormsEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsEdit field.
	/// </summary>
	public string StaTechEmailFormsEditDefault
	{
		get
		{
			return TableUtils.StaTechEmailFormsEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailFormsImport field.
	/// </summary>
	public string StaTechEmailFormsImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailFormsImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailFormsImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailFormsImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailFormsImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsImport field.
	/// </summary>
	public string StaTechEmailFormsImportDefault
	{
		get
		{
			return TableUtils.StaTechEmailFormsImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailFormsImportUpdate field.
	/// </summary>
	public string StaTechEmailFormsImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailFormsImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailFormsImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailFormsImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailFormsImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailFormsImportUpdate field.
	/// </summary>
	public string StaTechEmailFormsImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechEmailFormsImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailToAdd field.
	/// </summary>
	public string StaTechEmailToAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailToAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailToAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailToAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailToAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToAdd field.
	/// </summary>
	public string StaTechEmailToAddDefault
	{
		get
		{
			return TableUtils.StaTechEmailToAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailToEdit field.
	/// </summary>
	public string StaTechEmailToEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailToEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailToEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailToEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailToEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToEdit field.
	/// </summary>
	public string StaTechEmailToEditDefault
	{
		get
		{
			return TableUtils.StaTechEmailToEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailToImport field.
	/// </summary>
	public string StaTechEmailToImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailToImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailToImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailToImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailToImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToImport field.
	/// </summary>
	public string StaTechEmailToImportDefault
	{
		get
		{
			return TableUtils.StaTechEmailToImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechEmailToImportUpdate field.
	/// </summary>
	public string StaTechEmailToImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechEmailToImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechEmailToImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechEmailToImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechEmailToImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechEmailToImportUpdate field.
	/// </summary>
	public string StaTechEmailToImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechEmailToImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechNoticeAdd field.
	/// </summary>
	public string StaTechNoticeAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechNoticeAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechNoticeAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechNoticeAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechNoticeAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeAdd field.
	/// </summary>
	public string StaTechNoticeAddDefault
	{
		get
		{
			return TableUtils.StaTechNoticeAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechNoticeEdit field.
	/// </summary>
	public string StaTechNoticeEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechNoticeEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechNoticeEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechNoticeEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechNoticeEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeEdit field.
	/// </summary>
	public string StaTechNoticeEditDefault
	{
		get
		{
			return TableUtils.StaTechNoticeEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechNoticeForwardOnly field.
	/// </summary>
	public bool StaTechNoticeForwardOnly
	{
		get
		{
			return this.GetValue(TableUtils.StaTechNoticeForwardOnlyColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.StaTechNoticeForwardOnlyColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechNoticeForwardOnlySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechNoticeForwardOnlyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeForwardOnly field.
	/// </summary>
	public string StaTechNoticeForwardOnlyDefault
	{
		get
		{
			return TableUtils.StaTechNoticeForwardOnlyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechNoticeImport field.
	/// </summary>
	public string StaTechNoticeImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechNoticeImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechNoticeImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechNoticeImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechNoticeImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeImport field.
	/// </summary>
	public string StaTechNoticeImportDefault
	{
		get
		{
			return TableUtils.StaTechNoticeImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechNoticeImportUpdate field.
	/// </summary>
	public string StaTechNoticeImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechNoticeImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechNoticeImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechNoticeImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechNoticeImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechNoticeImportUpdate field.
	/// </summary>
	public string StaTechNoticeImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechNoticeImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeAdd field.
	/// </summary>
	public string StaTechSMSNoticeAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSMSNoticeAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSMSNoticeAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSMSNoticeAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSMSNoticeAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeAdd field.
	/// </summary>
	public string StaTechSMSNoticeAddDefault
	{
		get
		{
			return TableUtils.StaTechSMSNoticeAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeEdit field.
	/// </summary>
	public string StaTechSMSNoticeEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSMSNoticeEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSMSNoticeEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSMSNoticeEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSMSNoticeEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeEdit field.
	/// </summary>
	public string StaTechSMSNoticeEditDefault
	{
		get
		{
			return TableUtils.StaTechSMSNoticeEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeForwardOnly field.
	/// </summary>
	public bool StaTechSMSNoticeForwardOnly
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSMSNoticeForwardOnlyColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.StaTechSMSNoticeForwardOnlyColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSMSNoticeForwardOnlySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSMSNoticeForwardOnlyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeForwardOnly field.
	/// </summary>
	public string StaTechSMSNoticeForwardOnlyDefault
	{
		get
		{
			return TableUtils.StaTechSMSNoticeForwardOnlyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeImport field.
	/// </summary>
	public string StaTechSMSNoticeImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSMSNoticeImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSMSNoticeImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSMSNoticeImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSMSNoticeImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeImport field.
	/// </summary>
	public string StaTechSMSNoticeImportDefault
	{
		get
		{
			return TableUtils.StaTechSMSNoticeImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSMSNoticeImportUpdate field.
	/// </summary>
	public string StaTechSMSNoticeImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSMSNoticeImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSMSNoticeImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSMSNoticeImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSMSNoticeImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSNoticeImportUpdate field.
	/// </summary>
	public string StaTechSMSNoticeImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechSMSNoticeImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSMSToAdd field.
	/// </summary>
	public string StaTechSMSToAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSMSToAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSMSToAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSMSToAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSMSToAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToAdd field.
	/// </summary>
	public string StaTechSMSToAddDefault
	{
		get
		{
			return TableUtils.StaTechSMSToAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSMSToEdit field.
	/// </summary>
	public string StaTechSMSToEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSMSToEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSMSToEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSMSToEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSMSToEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToEdit field.
	/// </summary>
	public string StaTechSMSToEditDefault
	{
		get
		{
			return TableUtils.StaTechSMSToEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSMSToImport field.
	/// </summary>
	public string StaTechSMSToImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSMSToImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSMSToImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSMSToImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSMSToImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToImport field.
	/// </summary>
	public string StaTechSMSToImportDefault
	{
		get
		{
			return TableUtils.StaTechSMSToImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSMSToImportUpdate field.
	/// </summary>
	public string StaTechSMSToImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSMSToImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSMSToImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSMSToImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSMSToImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSMSToImportUpdate field.
	/// </summary>
	public string StaTechSMSToImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechSMSToImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSubjectAdd field.
	/// </summary>
	public string StaTechSubjectAdd
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSubjectAddColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSubjectAddColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSubjectAddSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSubjectAddColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectAdd field.
	/// </summary>
	public string StaTechSubjectAddDefault
	{
		get
		{
			return TableUtils.StaTechSubjectAddColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSubjectEdit field.
	/// </summary>
	public string StaTechSubjectEdit
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSubjectEditColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSubjectEditColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSubjectEditSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSubjectEditColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectEdit field.
	/// </summary>
	public string StaTechSubjectEditDefault
	{
		get
		{
			return TableUtils.StaTechSubjectEditColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSubjectImport field.
	/// </summary>
	public string StaTechSubjectImport
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSubjectImportColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSubjectImportColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSubjectImportSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSubjectImportColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectImport field.
	/// </summary>
	public string StaTechSubjectImportDefault
	{
		get
		{
			return TableUtils.StaTechSubjectImportColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.StaTechSubjectImportUpdate field.
	/// </summary>
	public string StaTechSubjectImportUpdate
	{
		get
		{
			return this.GetValue(TableUtils.StaTechSubjectImportUpdateColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StaTechSubjectImportUpdateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StaTechSubjectImportUpdateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StaTechSubjectImportUpdateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.StaTechSubjectImportUpdate field.
	/// </summary>
	public string StaTechSubjectImportUpdateDefault
	{
		get
		{
			return TableUtils.StaTechSubjectImportUpdateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.status_active field.
	/// </summary>
	public bool status_active
	{
		get
		{
			return this.GetValue(TableUtils.status_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.status_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool status_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.status_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_active field.
	/// </summary>
	public string status_activeDefault
	{
		get
		{
			return TableUtils.status_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.status_color field.
	/// </summary>
	public string status_color
	{
		get
		{
			return this.GetValue(TableUtils.status_colorColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.status_colorColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool status_colorSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.status_colorColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_color field.
	/// </summary>
	public string status_colorDefault
	{
		get
		{
			return TableUtils.status_colorColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.status_customer_caption field.
	/// </summary>
	public string status_customer_caption
	{
		get
		{
			return this.GetValue(TableUtils.status_customer_captionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.status_customer_captionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool status_customer_captionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.status_customer_captionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.status_customer_caption field.
	/// </summary>
	public string status_customer_captionDefault
	{
		get
		{
			return TableUtils.status_customer_captionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Statuses_.historyro_active field.
	/// </summary>
	public bool historyro_active
	{
		get
		{
			return this.GetValue(TableUtils.historyro_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.historyro_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool historyro_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.historyro_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Statuses_.historyro_active field.
	/// </summary>
	public string historyro_activeDefault
	{
		get
		{
			return TableUtils.historyro_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
