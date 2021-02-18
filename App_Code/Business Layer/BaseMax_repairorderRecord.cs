// This class is "generated" and will be overwritten.
// Your customizations should be made in Max_repairorderRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Max_repairorderRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Max_repairorderView"></see> class.
/// </remarks>
/// <seealso cref="Max_repairorderView"></seealso>
/// <seealso cref="Max_repairorderRecord"></seealso>
public class BaseMax_repairorderRecord : PrimaryKeyRecord
{

	public readonly static Max_repairorderView TableUtils = Max_repairorderView.Instance;

	// Constructors
 
	protected BaseMax_repairorderRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Max_repairorderRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Max_repairorderRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Max_repairorderRecord_ReadRecord); 
	}

	protected BaseMax_repairorderRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Max_repairorderRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Max_repairorderRecord Max_repairorderRec = (Max_repairorderRecord)sender;
        if(Max_repairorderRec != null && !Max_repairorderRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Max_repairorderRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Max_repairorderRecord Max_repairorderRec = (Max_repairorderRecord)sender;
        Validate_Inserting();
        if(Max_repairorderRec != null && !Max_repairorderRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Max_repairorderRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Max_repairorderRecord Max_repairorderRec = (Max_repairorderRecord)sender;
        Validate_Updating();
        if(Max_repairorderRec != null && !Max_repairorderRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's max_repairorder_.OEM field.
	/// </summary>
	public ColumnValue GetOEMValue()
	{
		return this.GetValue(TableUtils.OEMColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's max_repairorder_.OEM field.
	/// </summary>
	public Int32 GetOEMFieldValue()
	{
		return this.GetValue(TableUtils.OEMColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.OEM field.
	/// </summary>
	public void SetOEMFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OEMColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.OEM field.
	/// </summary>
	public void SetOEMFieldValue(string val)
	{
		this.SetString(val, TableUtils.OEMColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.OEM field.
	/// </summary>
	public void SetOEMFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OEMColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.OEM field.
	/// </summary>
	public void SetOEMFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OEMColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.OEM field.
	/// </summary>
	public void SetOEMFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OEMColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's max_repairorder_.Metal field.
	/// </summary>
	public ColumnValue GetMetalValue()
	{
		return this.GetValue(TableUtils.MetalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's max_repairorder_.Metal field.
	/// </summary>
	public Int32 GetMetalFieldValue()
	{
		return this.GetValue(TableUtils.MetalColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.Metal field.
	/// </summary>
	public void SetMetalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MetalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.Metal field.
	/// </summary>
	public void SetMetalFieldValue(string val)
	{
		this.SetString(val, TableUtils.MetalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.Metal field.
	/// </summary>
	public void SetMetalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MetalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.Metal field.
	/// </summary>
	public void SetMetalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MetalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.Metal field.
	/// </summary>
	public void SetMetalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MetalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's max_repairorder_.BIO field.
	/// </summary>
	public ColumnValue GetBIOValue()
	{
		return this.GetValue(TableUtils.BIOColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's max_repairorder_.BIO field.
	/// </summary>
	public Int32 GetBIOFieldValue()
	{
		return this.GetValue(TableUtils.BIOColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.BIO field.
	/// </summary>
	public void SetBIOFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BIOColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.BIO field.
	/// </summary>
	public void SetBIOFieldValue(string val)
	{
		this.SetString(val, TableUtils.BIOColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.BIO field.
	/// </summary>
	public void SetBIOFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BIOColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.BIO field.
	/// </summary>
	public void SetBIOFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BIOColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.BIO field.
	/// </summary>
	public void SetBIOFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BIOColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's max_repairorder_.OEM field.
	/// </summary>
	public Int32 OEM
	{
		get
		{
			return this.GetValue(TableUtils.OEMColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OEMColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OEMSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OEMColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.OEM field.
	/// </summary>
	public string OEMDefault
	{
		get
		{
			return TableUtils.OEMColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's max_repairorder_.Metal field.
	/// </summary>
	public Int32 Metal
	{
		get
		{
			return this.GetValue(TableUtils.MetalColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MetalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MetalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MetalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.Metal field.
	/// </summary>
	public string MetalDefault
	{
		get
		{
			return TableUtils.MetalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's max_repairorder_.BIO field.
	/// </summary>
	public Int32 BIO
	{
		get
		{
			return this.GetValue(TableUtils.BIOColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BIOColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BIOSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BIOColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's max_repairorder_.BIO field.
	/// </summary>
	public string BIODefault
	{
		get
		{
			return TableUtils.BIOColumn.DefaultValue;
		}
	}


#endregion
}

}
