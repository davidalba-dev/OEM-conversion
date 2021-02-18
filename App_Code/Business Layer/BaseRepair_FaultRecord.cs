// This class is "generated" and will be overwritten.
// Your customizations should be made in Repair_FaultRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Repair_FaultRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Repair_FaultView"></see> class.
/// </remarks>
/// <seealso cref="Repair_FaultView"></seealso>
/// <seealso cref="Repair_FaultRecord"></seealso>
public class BaseRepair_FaultRecord : PrimaryKeyRecord
{

	public readonly static Repair_FaultView TableUtils = Repair_FaultView.Instance;

	// Constructors
 
	protected BaseRepair_FaultRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Repair_FaultRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Repair_FaultRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Repair_FaultRecord_ReadRecord); 
	}

	protected BaseRepair_FaultRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Repair_FaultRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Repair_FaultRecord Repair_FaultRec = (Repair_FaultRecord)sender;
        if(Repair_FaultRec != null && !Repair_FaultRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Repair_FaultRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Repair_FaultRecord Repair_FaultRec = (Repair_FaultRecord)sender;
        Validate_Inserting();
        if(Repair_FaultRec != null && !Repair_FaultRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Repair_FaultRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Repair_FaultRecord Repair_FaultRec = (Repair_FaultRecord)sender;
        Validate_Updating();
        if(Repair_FaultRec != null && !Repair_FaultRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultCode field.
	/// </summary>
	public ColumnValue GetFaultCodeValue()
	{
		return this.GetValue(TableUtils.FaultCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultCode field.
	/// </summary>
	public string GetFaultCodeFieldValue()
	{
		return this.GetValue(TableUtils.FaultCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultCode field.
	/// </summary>
	public void SetFaultCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FaultCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultCode field.
	/// </summary>
	public void SetFaultCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FaultCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultDesc field.
	/// </summary>
	public ColumnValue GetFaultDescValue()
	{
		return this.GetValue(TableUtils.FaultDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultDesc field.
	/// </summary>
	public string GetFaultDescFieldValue()
	{
		return this.GetValue(TableUtils.FaultDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultDesc field.
	/// </summary>
	public void SetFaultDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FaultDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultDesc field.
	/// </summary>
	public void SetFaultDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FaultDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultCategory field.
	/// </summary>
	public ColumnValue GetFaultCategoryValue()
	{
		return this.GetValue(TableUtils.FaultCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultCategory field.
	/// </summary>
	public string GetFaultCategoryFieldValue()
	{
		return this.GetValue(TableUtils.FaultCategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultCategory field.
	/// </summary>
	public void SetFaultCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FaultCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultCategory field.
	/// </summary>
	public void SetFaultCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FaultCategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultMake field.
	/// </summary>
	public ColumnValue GetFaultMakeValue()
	{
		return this.GetValue(TableUtils.FaultMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultMake field.
	/// </summary>
	public string GetFaultMakeFieldValue()
	{
		return this.GetValue(TableUtils.FaultMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultMake field.
	/// </summary>
	public void SetFaultMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FaultMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultMake field.
	/// </summary>
	public void SetFaultMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FaultMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultResolution field.
	/// </summary>
	public ColumnValue GetFaultResolutionValue()
	{
		return this.GetValue(TableUtils.FaultResolutionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.FaultResolution field.
	/// </summary>
	public string GetFaultResolutionFieldValue()
	{
		return this.GetValue(TableUtils.FaultResolutionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultResolution field.
	/// </summary>
	public void SetFaultResolutionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FaultResolutionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultResolution field.
	/// </summary>
	public void SetFaultResolutionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FaultResolutionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.RONo field.
	/// </summary>
	public ColumnValue GetRONoValue()
	{
		return this.GetValue(TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Repair_Fault_.RONo field.
	/// </summary>
	public Int32 GetRONoFieldValue()
	{
		return this.GetValue(TableUtils.RONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Repair_Fault_.FaultCode field.
	/// </summary>
	public string FaultCode
	{
		get
		{
			return this.GetValue(TableUtils.FaultCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FaultCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FaultCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FaultCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultCode field.
	/// </summary>
	public string FaultCodeDefault
	{
		get
		{
			return TableUtils.FaultCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Repair_Fault_.FaultDesc field.
	/// </summary>
	public string FaultDesc
	{
		get
		{
			return this.GetValue(TableUtils.FaultDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FaultDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FaultDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FaultDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultDesc field.
	/// </summary>
	public string FaultDescDefault
	{
		get
		{
			return TableUtils.FaultDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Repair_Fault_.FaultCategory field.
	/// </summary>
	public string FaultCategory
	{
		get
		{
			return this.GetValue(TableUtils.FaultCategoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FaultCategoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FaultCategorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FaultCategoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultCategory field.
	/// </summary>
	public string FaultCategoryDefault
	{
		get
		{
			return TableUtils.FaultCategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Repair_Fault_.FaultMake field.
	/// </summary>
	public string FaultMake
	{
		get
		{
			return this.GetValue(TableUtils.FaultMakeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FaultMakeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FaultMakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FaultMakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultMake field.
	/// </summary>
	public string FaultMakeDefault
	{
		get
		{
			return TableUtils.FaultMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Repair_Fault_.FaultResolution field.
	/// </summary>
	public string FaultResolution
	{
		get
		{
			return this.GetValue(TableUtils.FaultResolutionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FaultResolutionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FaultResolutionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FaultResolutionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.FaultResolution field.
	/// </summary>
	public string FaultResolutionDefault
	{
		get
		{
			return TableUtils.FaultResolutionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Repair_Fault_.RONo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Repair_Fault_.RONo field.
	/// </summary>
	public string RONoDefault
	{
		get
		{
			return TableUtils.RONoColumn.DefaultValue;
		}
	}


#endregion
}

}
