// This class is "generated" and will be overwritten.
// Your customizations should be made in Loaner_historyRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Loaner_historyRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Loaner_historyTable"></see> class.
/// </remarks>
/// <seealso cref="Loaner_historyTable"></seealso>
/// <seealso cref="Loaner_historyRecord"></seealso>
public class BaseLoaner_historyRecord : PrimaryKeyRecord
{

	public readonly static Loaner_historyTable TableUtils = Loaner_historyTable.Instance;

	// Constructors
 
	protected BaseLoaner_historyRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Loaner_historyRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Loaner_historyRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Loaner_historyRecord_ReadRecord); 
	}

	protected BaseLoaner_historyRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Loaner_historyRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Loaner_historyRecord Loaner_historyRec = (Loaner_historyRecord)sender;
        if(Loaner_historyRec != null && !Loaner_historyRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Loaner_historyRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Loaner_historyRecord Loaner_historyRec = (Loaner_historyRecord)sender;
        Validate_Inserting();
        if(Loaner_historyRec != null && !Loaner_historyRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Loaner_historyRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Loaner_historyRecord Loaner_historyRec = (Loaner_historyRecord)sender;
        Validate_Updating();
        if(Loaner_historyRec != null && !Loaner_historyRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.loaner_id field.
	/// </summary>
	public ColumnValue Getloaner_idValue()
	{
		return this.GetValue(TableUtils.loaner_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.loaner_id field.
	/// </summary>
	public Decimal Getloaner_idFieldValue()
	{
		return this.GetValue(TableUtils.loaner_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.inventory_id field.
	/// </summary>
	public ColumnValue Getinventory_idValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.inventory_id field.
	/// </summary>
	public Decimal Getinventory_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.custcontactkey field.
	/// </summary>
	public ColumnValue GetcustcontactkeyValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.custcontactkey field.
	/// </summary>
	public Int32 GetcustcontactkeyFieldValue()
	{
		return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custcontactkey field.
	/// </summary>
	public void SetcustcontactkeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custcontactkeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.date_out field.
	/// </summary>
	public ColumnValue Getdate_outValue()
	{
		return this.GetValue(TableUtils.date_outColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.date_out field.
	/// </summary>
	public DateTime Getdate_outFieldValue()
	{
		return this.GetValue(TableUtils.date_outColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.date_out field.
	/// </summary>
	public void Setdate_outFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_outColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.date_out field.
	/// </summary>
	public void Setdate_outFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_outColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.date_out field.
	/// </summary>
	public void Setdate_outFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_outColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.technician_out field.
	/// </summary>
	public ColumnValue Gettechnician_outValue()
	{
		return this.GetValue(TableUtils.technician_outColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.technician_out field.
	/// </summary>
	public Int32 Gettechnician_outFieldValue()
	{
		return this.GetValue(TableUtils.technician_outColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_out field.
	/// </summary>
	public void Settechnician_outFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_outColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_out field.
	/// </summary>
	public void Settechnician_outFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_outColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_out field.
	/// </summary>
	public void Settechnician_outFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_outColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_out field.
	/// </summary>
	public void Settechnician_outFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_outColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_out field.
	/// </summary>
	public void Settechnician_outFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_outColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.date_in field.
	/// </summary>
	public ColumnValue Getdate_inValue()
	{
		return this.GetValue(TableUtils.date_inColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.date_in field.
	/// </summary>
	public DateTime Getdate_inFieldValue()
	{
		return this.GetValue(TableUtils.date_inColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.date_in field.
	/// </summary>
	public void Setdate_inFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.date_inColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.date_in field.
	/// </summary>
	public void Setdate_inFieldValue(string val)
	{
		this.SetString(val, TableUtils.date_inColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.date_in field.
	/// </summary>
	public void Setdate_inFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.date_inColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.technician_in field.
	/// </summary>
	public ColumnValue Gettechnician_inValue()
	{
		return this.GetValue(TableUtils.technician_inColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.technician_in field.
	/// </summary>
	public Int32 Gettechnician_inFieldValue()
	{
		return this.GetValue(TableUtils.technician_inColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_in field.
	/// </summary>
	public void Settechnician_inFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_inColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_in field.
	/// </summary>
	public void Settechnician_inFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_inColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_in field.
	/// </summary>
	public void Settechnician_inFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_inColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_in field.
	/// </summary>
	public void Settechnician_inFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_inColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_in field.
	/// </summary>
	public void Settechnician_inFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_inColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.rono field.
	/// </summary>
	public ColumnValue GetronoValue()
	{
		return this.GetValue(TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's loaner_history_.rono field.
	/// </summary>
	public Int32 GetronoFieldValue()
	{
		return this.GetValue(TableUtils.ronoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.rono field.
	/// </summary>
	public void SetronoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.rono field.
	/// </summary>
	public void SetronoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.rono field.
	/// </summary>
	public void SetronoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.rono field.
	/// </summary>
	public void SetronoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.rono field.
	/// </summary>
	public void SetronoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_history_.loaner_id field.
	/// </summary>
	public Decimal loaner_id
	{
		get
		{
			return this.GetValue(TableUtils.loaner_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.loaner_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.loaner_id field.
	/// </summary>
	public string loaner_idDefault
	{
		get
		{
			return TableUtils.loaner_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_history_.inventory_id field.
	/// </summary>
	public Decimal inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.inventory_id field.
	/// </summary>
	public string inventory_idDefault
	{
		get
		{
			return TableUtils.inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_history_.custno field.
	/// </summary>
	public Int32 custno
	{
		get
		{
			return this.GetValue(TableUtils.custnoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_history_.custcontactkey field.
	/// </summary>
	public Int32 custcontactkey
	{
		get
		{
			return this.GetValue(TableUtils.custcontactkeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.custcontactkeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool custcontactkeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.custcontactkeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.custcontactkey field.
	/// </summary>
	public string custcontactkeyDefault
	{
		get
		{
			return TableUtils.custcontactkeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_history_.date_out field.
	/// </summary>
	public DateTime date_out
	{
		get
		{
			return this.GetValue(TableUtils.date_outColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_outColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_outSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_outColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.date_out field.
	/// </summary>
	public string date_outDefault
	{
		get
		{
			return TableUtils.date_outColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_history_.technician_out field.
	/// </summary>
	public Int32 technician_out
	{
		get
		{
			return this.GetValue(TableUtils.technician_outColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.technician_outColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technician_outSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technician_outColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_out field.
	/// </summary>
	public string technician_outDefault
	{
		get
		{
			return TableUtils.technician_outColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_history_.date_in field.
	/// </summary>
	public DateTime date_in
	{
		get
		{
			return this.GetValue(TableUtils.date_inColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.date_inColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool date_inSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.date_inColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.date_in field.
	/// </summary>
	public string date_inDefault
	{
		get
		{
			return TableUtils.date_inColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_history_.technician_in field.
	/// </summary>
	public Int32 technician_in
	{
		get
		{
			return this.GetValue(TableUtils.technician_inColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.technician_inColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technician_inSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technician_inColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.technician_in field.
	/// </summary>
	public string technician_inDefault
	{
		get
		{
			return TableUtils.technician_inColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's loaner_history_.rono field.
	/// </summary>
	public Int32 rono
	{
		get
		{
			return this.GetValue(TableUtils.ronoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ronoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ronoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ronoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's loaner_history_.rono field.
	/// </summary>
	public string ronoDefault
	{
		get
		{
			return TableUtils.ronoColumn.DefaultValue;
		}
	}


#endregion
}

}
