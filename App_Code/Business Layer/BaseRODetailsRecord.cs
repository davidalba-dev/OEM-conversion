// This class is "generated" and will be overwritten.
// Your customizations should be made in RODetailsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="RODetailsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RODetailsTable"></see> class.
/// </remarks>
/// <seealso cref="RODetailsTable"></seealso>
/// <seealso cref="RODetailsRecord"></seealso>
public class BaseRODetailsRecord : PrimaryKeyRecord
{

	public readonly static RODetailsTable TableUtils = RODetailsTable.Instance;

	// Constructors
 
	protected BaseRODetailsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.RODetailsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.RODetailsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.RODetailsRecord_ReadRecord); 
	}

	protected BaseRODetailsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void RODetailsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                RODetailsRecord RODetailsRec = (RODetailsRecord)sender;
        if(RODetailsRec != null && !RODetailsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void RODetailsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                RODetailsRecord RODetailsRec = (RODetailsRecord)sender;
        Validate_Inserting();
        if(RODetailsRec != null && !RODetailsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void RODetailsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                RODetailsRecord RODetailsRec = (RODetailsRecord)sender;
        Validate_Updating();
        if(RODetailsRec != null && !RODetailsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROItemDesc field.
	/// </summary>
	public ColumnValue GetROItemDescValue()
	{
		return this.GetValue(TableUtils.ROItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROItemDesc field.
	/// </summary>
	public string GetROItemDescFieldValue()
	{
		return this.GetValue(TableUtils.ROItemDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROItemDesc field.
	/// </summary>
	public void SetROItemDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROItemDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROItemDesc field.
	/// </summary>
	public void SetROItemDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROItemDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROLineType field.
	/// </summary>
	public ColumnValue GetROLineTypeValue()
	{
		return this.GetValue(TableUtils.ROLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROLineType field.
	/// </summary>
	public Byte GetROLineTypeFieldValue()
	{
		return this.GetValue(TableUtils.ROLineTypeColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLineType field.
	/// </summary>
	public void SetROLineTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLineType field.
	/// </summary>
	public void SetROLineTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLineType field.
	/// </summary>
	public void SetROLineTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLineType field.
	/// </summary>
	public void SetROLineTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLineTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLineType field.
	/// </summary>
	public void SetROLineTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLineTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROLocation field.
	/// </summary>
	public ColumnValue GetROLocationValue()
	{
		return this.GetValue(TableUtils.ROLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROLocation field.
	/// </summary>
	public Int32 GetROLocationFieldValue()
	{
		return this.GetValue(TableUtils.ROLocationColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLocation field.
	/// </summary>
	public void SetROLocationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLocation field.
	/// </summary>
	public void SetROLocationFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLocation field.
	/// </summary>
	public void SetROLocationFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLocation field.
	/// </summary>
	public void SetROLocationFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLocation field.
	/// </summary>
	public void SetROLocationFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLocationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.RONo field.
	/// </summary>
	public ColumnValue GetRONoValue()
	{
		return this.GetValue(TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.RONo field.
	/// </summary>
	public Int32 GetRONoFieldValue()
	{
		return this.GetValue(TableUtils.RONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROPartNo field.
	/// </summary>
	public ColumnValue GetROPartNoValue()
	{
		return this.GetValue(TableUtils.ROPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROPartNo field.
	/// </summary>
	public string GetROPartNoFieldValue()
	{
		return this.GetValue(TableUtils.ROPartNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROPartNo field.
	/// </summary>
	public void SetROPartNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPartNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROPartNo field.
	/// </summary>
	public void SetROPartNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPartNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROQuantity field.
	/// </summary>
	public ColumnValue GetROQuantityValue()
	{
		return this.GetValue(TableUtils.ROQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROQuantity field.
	/// </summary>
	public Single GetROQuantityFieldValue()
	{
		return this.GetValue(TableUtils.ROQuantityColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROQuantity field.
	/// </summary>
	public void SetROQuantityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROQuantity field.
	/// </summary>
	public void SetROQuantityFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROQuantity field.
	/// </summary>
	public void SetROQuantityFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROQuantity field.
	/// </summary>
	public void SetROQuantityFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQuantityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROQuantity field.
	/// </summary>
	public void SetROQuantityFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQuantityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROSellPrice field.
	/// </summary>
	public ColumnValue GetROSellPriceValue()
	{
		return this.GetValue(TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROSellPrice field.
	/// </summary>
	public Decimal GetROSellPriceFieldValue()
	{
		return this.GetValue(TableUtils.ROSellPriceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSellPriceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROSellPrice field.
	/// </summary>
	public void SetROSellPriceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSellPriceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROSort field.
	/// </summary>
	public ColumnValue GetROSortValue()
	{
		return this.GetValue(TableUtils.ROSortColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROSort field.
	/// </summary>
	public Int32 GetROSortFieldValue()
	{
		return this.GetValue(TableUtils.ROSortColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROStepDate field.
	/// </summary>
	public ColumnValue GetROStepDateValue()
	{
		return this.GetValue(TableUtils.ROStepDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROStepDate field.
	/// </summary>
	public DateTime GetROStepDateFieldValue()
	{
		return this.GetValue(TableUtils.ROStepDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepDate field.
	/// </summary>
	public void SetROStepDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROStepDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepDate field.
	/// </summary>
	public void SetROStepDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROStepDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepDate field.
	/// </summary>
	public void SetROStepDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStepDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROStepDesc field.
	/// </summary>
	public ColumnValue GetROStepDescValue()
	{
		return this.GetValue(TableUtils.ROStepDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROStepDesc field.
	/// </summary>
	public string GetROStepDescFieldValue()
	{
		return this.GetValue(TableUtils.ROStepDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepDesc field.
	/// </summary>
	public void SetROStepDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROStepDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepDesc field.
	/// </summary>
	public void SetROStepDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStepDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROStepHours field.
	/// </summary>
	public ColumnValue GetROStepHoursValue()
	{
		return this.GetValue(TableUtils.ROStepHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROStepHours field.
	/// </summary>
	public Single GetROStepHoursFieldValue()
	{
		return this.GetValue(TableUtils.ROStepHoursColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepHours field.
	/// </summary>
	public void SetROStepHoursFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROStepHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepHours field.
	/// </summary>
	public void SetROStepHoursFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROStepHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepHours field.
	/// </summary>
	public void SetROStepHoursFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStepHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepHours field.
	/// </summary>
	public void SetROStepHoursFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStepHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepHours field.
	/// </summary>
	public void SetROStepHoursFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStepHoursColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROStepTechnician field.
	/// </summary>
	public ColumnValue GetROStepTechnicianValue()
	{
		return this.GetValue(TableUtils.ROStepTechnicianColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ROStepTechnician field.
	/// </summary>
	public string GetROStepTechnicianFieldValue()
	{
		return this.GetValue(TableUtils.ROStepTechnicianColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepTechnician field.
	/// </summary>
	public void SetROStepTechnicianFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROStepTechnicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepTechnician field.
	/// </summary>
	public void SetROStepTechnicianFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStepTechnicianColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.SessionID field.
	/// </summary>
	public ColumnValue GetSessionIDValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.SessionID field.
	/// </summary>
	public Int32 GetSessionIDFieldValue()
	{
		return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.SessionID field.
	/// </summary>
	public void SetSessionIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SessionIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ro_totalprice field.
	/// </summary>
	public ColumnValue Getro_totalpriceValue()
	{
		return this.GetValue(TableUtils.ro_totalpriceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RODetails_.ro_totalprice field.
	/// </summary>
	public Single Getro_totalpriceFieldValue()
	{
		return this.GetValue(TableUtils.ro_totalpriceColumn).ToSingle();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROItemDesc field.
	/// </summary>
	public string ROItemDesc
	{
		get
		{
			return this.GetValue(TableUtils.ROItemDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROItemDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROItemDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROItemDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROItemDesc field.
	/// </summary>
	public string ROItemDescDefault
	{
		get
		{
			return TableUtils.ROItemDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROLineType field.
	/// </summary>
	public Byte ROLineType
	{
		get
		{
			return this.GetValue(TableUtils.ROLineTypeColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROLineTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROLineTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROLineTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLineType field.
	/// </summary>
	public string ROLineTypeDefault
	{
		get
		{
			return TableUtils.ROLineTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROLocation field.
	/// </summary>
	public Int32 ROLocation
	{
		get
		{
			return this.GetValue(TableUtils.ROLocationColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROLocationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROLocationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROLocationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROLocation field.
	/// </summary>
	public string ROLocationDefault
	{
		get
		{
			return TableUtils.ROLocationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.RONo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.RONo field.
	/// </summary>
	public string RONoDefault
	{
		get
		{
			return TableUtils.RONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROPartNo field.
	/// </summary>
	public string ROPartNo
	{
		get
		{
			return this.GetValue(TableUtils.ROPartNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPartNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPartNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPartNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROPartNo field.
	/// </summary>
	public string ROPartNoDefault
	{
		get
		{
			return TableUtils.ROPartNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROQuantity field.
	/// </summary>
	public Single ROQuantity
	{
		get
		{
			return this.GetValue(TableUtils.ROQuantityColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROQuantityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROQuantitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROQuantityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROQuantity field.
	/// </summary>
	public string ROQuantityDefault
	{
		get
		{
			return TableUtils.ROQuantityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROSellPrice field.
	/// </summary>
	public Decimal ROSellPrice
	{
		get
		{
			return this.GetValue(TableUtils.ROSellPriceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSellPriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSellPriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSellPriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROSellPrice field.
	/// </summary>
	public string ROSellPriceDefault
	{
		get
		{
			return TableUtils.ROSellPriceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROSort field.
	/// </summary>
	public Int32 ROSort
	{
		get
		{
			return this.GetValue(TableUtils.ROSortColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSortColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSortSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSortColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROSort field.
	/// </summary>
	public string ROSortDefault
	{
		get
		{
			return TableUtils.ROSortColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROStepDate field.
	/// </summary>
	public DateTime ROStepDate
	{
		get
		{
			return this.GetValue(TableUtils.ROStepDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROStepDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROStepDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROStepDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepDate field.
	/// </summary>
	public string ROStepDateDefault
	{
		get
		{
			return TableUtils.ROStepDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROStepDesc field.
	/// </summary>
	public string ROStepDesc
	{
		get
		{
			return this.GetValue(TableUtils.ROStepDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROStepDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROStepDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROStepDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepDesc field.
	/// </summary>
	public string ROStepDescDefault
	{
		get
		{
			return TableUtils.ROStepDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROStepHours field.
	/// </summary>
	public Single ROStepHours
	{
		get
		{
			return this.GetValue(TableUtils.ROStepHoursColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROStepHoursColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROStepHoursSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROStepHoursColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepHours field.
	/// </summary>
	public string ROStepHoursDefault
	{
		get
		{
			return TableUtils.ROStepHoursColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ROStepTechnician field.
	/// </summary>
	public string ROStepTechnician
	{
		get
		{
			return this.GetValue(TableUtils.ROStepTechnicianColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROStepTechnicianColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROStepTechnicianSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROStepTechnicianColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ROStepTechnician field.
	/// </summary>
	public string ROStepTechnicianDefault
	{
		get
		{
			return TableUtils.ROStepTechnicianColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.SessionID field.
	/// </summary>
	public Int32 SessionID
	{
		get
		{
			return this.GetValue(TableUtils.SessionIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SessionIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SessionIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SessionIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.SessionID field.
	/// </summary>
	public string SessionIDDefault
	{
		get
		{
			return TableUtils.SessionIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RODetails_.ro_totalprice field.
	/// </summary>
	public Single ro_totalprice
	{
		get
		{
			return this.GetValue(TableUtils.ro_totalpriceColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ro_totalpriceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ro_totalpriceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ro_totalpriceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RODetails_.ro_totalprice field.
	/// </summary>
	public string ro_totalpriceDefault
	{
		get
		{
			return TableUtils.ro_totalpriceColumn.DefaultValue;
		}
	}


#endregion
}

}
