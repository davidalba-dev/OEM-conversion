// This class is "generated" and will be overwritten.
// Your customizations should be made in ConfigurationRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ConfigurationRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ConfigurationTable"></see> class.
/// </remarks>
/// <seealso cref="ConfigurationTable"></seealso>
/// <seealso cref="ConfigurationRecord"></seealso>
public class BaseConfigurationRecord : PrimaryKeyRecord
{

	public readonly static ConfigurationTable TableUtils = ConfigurationTable.Instance;

	// Constructors
 
	protected BaseConfigurationRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ConfigurationRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ConfigurationRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ConfigurationRecord_ReadRecord); 
	}

	protected BaseConfigurationRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ConfigurationRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ConfigurationRecord ConfigurationRec = (ConfigurationRecord)sender;
        if(ConfigurationRec != null && !ConfigurationRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ConfigurationRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ConfigurationRecord ConfigurationRec = (ConfigurationRecord)sender;
        Validate_Inserting();
        if(ConfigurationRec != null && !ConfigurationRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ConfigurationRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ConfigurationRecord ConfigurationRec = (ConfigurationRecord)sender;
        Validate_Updating();
        if(ConfigurationRec != null && !ConfigurationRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's configuration_.configuration_id field.
	/// </summary>
	public ColumnValue Getconfiguration_idValue()
	{
		return this.GetValue(TableUtils.configuration_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's configuration_.configuration_id field.
	/// </summary>
	public Int32 Getconfiguration_idFieldValue()
	{
		return this.GetValue(TableUtils.configuration_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's configuration_.config_title field.
	/// </summary>
	public ColumnValue Getconfig_titleValue()
	{
		return this.GetValue(TableUtils.config_titleColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's configuration_.config_title field.
	/// </summary>
	public string Getconfig_titleFieldValue()
	{
		return this.GetValue(TableUtils.config_titleColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.config_title field.
	/// </summary>
	public void Setconfig_titleFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.config_titleColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.config_title field.
	/// </summary>
	public void Setconfig_titleFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.config_titleColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's configuration_.config_active field.
	/// </summary>
	public ColumnValue Getconfig_activeValue()
	{
		return this.GetValue(TableUtils.config_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's configuration_.config_active field.
	/// </summary>
	public bool Getconfig_activeFieldValue()
	{
		return this.GetValue(TableUtils.config_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.config_active field.
	/// </summary>
	public void Setconfig_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.config_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.config_active field.
	/// </summary>
	public void Setconfig_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.config_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.config_active field.
	/// </summary>
	public void Setconfig_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.config_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's configuration_.repairorder_notification field.
	/// </summary>
	public ColumnValue Getrepairorder_notificationValue()
	{
		return this.GetValue(TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's configuration_.repairorder_notification field.
	/// </summary>
	public Int32 Getrepairorder_notificationFieldValue()
	{
		return this.GetValue(TableUtils.repairorder_notificationColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(string val)
	{
		this.SetString(val, TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repairorder_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.repairorder_notification field.
	/// </summary>
	public void Setrepairorder_notificationFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repairorder_notificationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's configuration_.configuration_type field.
	/// </summary>
	public ColumnValue Getconfiguration_typeValue()
	{
		return this.GetValue(TableUtils.configuration_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's configuration_.configuration_type field.
	/// </summary>
	public Int32 Getconfiguration_typeFieldValue()
	{
		return this.GetValue(TableUtils.configuration_typeColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.configuration_type field.
	/// </summary>
	public void Setconfiguration_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.configuration_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.configuration_type field.
	/// </summary>
	public void Setconfiguration_typeFieldValue(string val)
	{
		this.SetString(val, TableUtils.configuration_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.configuration_type field.
	/// </summary>
	public void Setconfiguration_typeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.configuration_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.configuration_type field.
	/// </summary>
	public void Setconfiguration_typeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.configuration_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.configuration_type field.
	/// </summary>
	public void Setconfiguration_typeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.configuration_typeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's configuration_.configuration_id field.
	/// </summary>
	public Int32 configuration_id
	{
		get
		{
			return this.GetValue(TableUtils.configuration_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.configuration_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool configuration_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.configuration_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.configuration_id field.
	/// </summary>
	public string configuration_idDefault
	{
		get
		{
			return TableUtils.configuration_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's configuration_.config_title field.
	/// </summary>
	public string config_title
	{
		get
		{
			return this.GetValue(TableUtils.config_titleColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.config_titleColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool config_titleSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.config_titleColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.config_title field.
	/// </summary>
	public string config_titleDefault
	{
		get
		{
			return TableUtils.config_titleColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's configuration_.config_active field.
	/// </summary>
	public bool config_active
	{
		get
		{
			return this.GetValue(TableUtils.config_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.config_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool config_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.config_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.config_active field.
	/// </summary>
	public string config_activeDefault
	{
		get
		{
			return TableUtils.config_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's configuration_.repairorder_notification field.
	/// </summary>
	public Int32 repairorder_notification
	{
		get
		{
			return this.GetValue(TableUtils.repairorder_notificationColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repairorder_notificationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repairorder_notificationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repairorder_notificationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.repairorder_notification field.
	/// </summary>
	public string repairorder_notificationDefault
	{
		get
		{
			return TableUtils.repairorder_notificationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's configuration_.configuration_type field.
	/// </summary>
	public Int32 configuration_type
	{
		get
		{
			return this.GetValue(TableUtils.configuration_typeColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.configuration_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool configuration_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.configuration_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's configuration_.configuration_type field.
	/// </summary>
	public string configuration_typeDefault
	{
		get
		{
			return TableUtils.configuration_typeColumn.DefaultValue;
		}
	}


#endregion
}

}
