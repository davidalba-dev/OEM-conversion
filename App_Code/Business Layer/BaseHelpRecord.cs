// This class is "generated" and will be overwritten.
// Your customizations should be made in HelpRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="HelpRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="HelpTable"></see> class.
/// </remarks>
/// <seealso cref="HelpTable"></seealso>
/// <seealso cref="HelpRecord"></seealso>
public class BaseHelpRecord : PrimaryKeyRecord
{

	public readonly static HelpTable TableUtils = HelpTable.Instance;

	// Constructors
 
	protected BaseHelpRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.HelpRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.HelpRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.HelpRecord_ReadRecord); 
	}

	protected BaseHelpRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void HelpRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                HelpRecord HelpRec = (HelpRecord)sender;
        if(HelpRec != null && !HelpRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void HelpRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                HelpRecord HelpRec = (HelpRecord)sender;
        Validate_Inserting();
        if(HelpRec != null && !HelpRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void HelpRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                HelpRecord HelpRec = (HelpRecord)sender;
        Validate_Updating();
        if(HelpRec != null && !HelpRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Help_.help_id field.
	/// </summary>
	public ColumnValue Gethelp_idValue()
	{
		return this.GetValue(TableUtils.help_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Help_.help_id field.
	/// </summary>
	public Decimal Gethelp_idFieldValue()
	{
		return this.GetValue(TableUtils.help_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Help_.Help Title field.
	/// </summary>
	public ColumnValue GetHelp_TitleValue()
	{
		return this.GetValue(TableUtils.Help_TitleColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Help_.Help Title field.
	/// </summary>
	public string GetHelp_TitleFieldValue()
	{
		return this.GetValue(TableUtils.Help_TitleColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Help_.Help Title field.
	/// </summary>
	public void SetHelp_TitleFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Help_TitleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Help_.Help Title field.
	/// </summary>
	public void SetHelp_TitleFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Help_TitleColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Help_.help_file field.
	/// </summary>
	public ColumnValue Gethelp_fileValue()
	{
		return this.GetValue(TableUtils.help_fileColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Help_.help_file field.
	/// </summary>
	public byte[] Gethelp_fileFieldValue()
	{
		return this.GetValue(TableUtils.help_fileColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Help_.help_file field.
	/// </summary>
	public void Sethelp_fileFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.help_fileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Help_.help_file field.
	/// </summary>
	public void Sethelp_fileFieldValue(string val)
	{
		this.SetString(val, TableUtils.help_fileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Help_.help_file field.
	/// </summary>
	public void Sethelp_fileFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.help_fileColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Help_.help_id field.
	/// </summary>
	public Decimal help_id
	{
		get
		{
			return this.GetValue(TableUtils.help_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.help_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool help_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.help_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Help_.help_id field.
	/// </summary>
	public string help_idDefault
	{
		get
		{
			return TableUtils.help_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Help_.Help Title field.
	/// </summary>
	public string Help_Title
	{
		get
		{
			return this.GetValue(TableUtils.Help_TitleColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Help_TitleColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Help_TitleSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Help_TitleColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Help_.Help Title field.
	/// </summary>
	public string Help_TitleDefault
	{
		get
		{
			return TableUtils.Help_TitleColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Help_.help_file field.
	/// </summary>
	public byte[] help_file
	{
		get
		{
			return this.GetValue(TableUtils.help_fileColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.help_fileColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool help_fileSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.help_fileColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Help_.help_file field.
	/// </summary>
	public string help_fileDefault
	{
		get
		{
			return TableUtils.help_fileColumn.DefaultValue;
		}
	}


#endregion
}

}
