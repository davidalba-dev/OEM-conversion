// This class is "generated" and will be overwritten.
// Your customizations should be made in RepairOrdersRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="RepairOrdersRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RepairOrdersTable"></see> class.
/// </remarks>
/// <seealso cref="RepairOrdersTable"></seealso>
/// <seealso cref="RepairOrdersRecord"></seealso>
public class BaseRepairOrdersRecord : PrimaryKeyRecord
{

	public readonly static RepairOrdersTable TableUtils = RepairOrdersTable.Instance;

	// Constructors
 
	protected BaseRepairOrdersRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.RepairOrdersRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.RepairOrdersRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.RepairOrdersRecord_ReadRecord); 
	}

	protected BaseRepairOrdersRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void RepairOrdersRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                RepairOrdersRecord RepairOrdersRec = (RepairOrdersRecord)sender;
        if(RepairOrdersRec != null && !RepairOrdersRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void RepairOrdersRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                RepairOrdersRecord RepairOrdersRec = (RepairOrdersRecord)sender;
        Validate_Inserting();
        if(RepairOrdersRec != null && !RepairOrdersRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void RepairOrdersRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                RepairOrdersRecord RepairOrdersRec = (RepairOrdersRecord)sender;
        Validate_Updating();
        if(RepairOrdersRec != null && !RepairOrdersRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.Link field.
	/// </summary>
	public ColumnValue GetLinkValue()
	{
		return this.GetValue(TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.Link field.
	/// </summary>
	public Byte GetLinkFieldValue()
	{
		return this.GetValue(TableUtils.LinkColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.Link field.
	/// </summary>
	public void SetLinkFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.Link field.
	/// </summary>
	public void SetLinkFieldValue(string val)
	{
		this.SetString(val, TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.Link field.
	/// </summary>
	public void SetLinkFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.Link field.
	/// </summary>
	public void SetLinkFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.Link field.
	/// </summary>
	public void SetLinkFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinkColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory0 field.
	/// </summary>
	public ColumnValue GetROAccessory0Value()
	{
		return this.GetValue(TableUtils.ROAccessory0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory0 field.
	/// </summary>
	public bool GetROAccessory0FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory0Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory0 field.
	/// </summary>
	public void SetROAccessory0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory0 field.
	/// </summary>
	public void SetROAccessory0FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory0 field.
	/// </summary>
	public void SetROAccessory0FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory1 field.
	/// </summary>
	public ColumnValue GetROAccessory1Value()
	{
		return this.GetValue(TableUtils.ROAccessory1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory1 field.
	/// </summary>
	public bool GetROAccessory1FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory1Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory1 field.
	/// </summary>
	public void SetROAccessory1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory1 field.
	/// </summary>
	public void SetROAccessory1FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory1 field.
	/// </summary>
	public void SetROAccessory1FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory10 field.
	/// </summary>
	public ColumnValue GetROAccessory10Value()
	{
		return this.GetValue(TableUtils.ROAccessory10Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory10 field.
	/// </summary>
	public bool GetROAccessory10FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory10Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory10 field.
	/// </summary>
	public void SetROAccessory10FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory10Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory10 field.
	/// </summary>
	public void SetROAccessory10FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory10Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory10 field.
	/// </summary>
	public void SetROAccessory10FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory10Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory11 field.
	/// </summary>
	public ColumnValue GetROAccessory11Value()
	{
		return this.GetValue(TableUtils.ROAccessory11Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory11 field.
	/// </summary>
	public bool GetROAccessory11FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory11Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory11 field.
	/// </summary>
	public void SetROAccessory11FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory11Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory11 field.
	/// </summary>
	public void SetROAccessory11FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory11Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory11 field.
	/// </summary>
	public void SetROAccessory11FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory11Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory12 field.
	/// </summary>
	public ColumnValue GetROAccessory12Value()
	{
		return this.GetValue(TableUtils.ROAccessory12Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory12 field.
	/// </summary>
	public bool GetROAccessory12FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory12Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory12 field.
	/// </summary>
	public void SetROAccessory12FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory12Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory12 field.
	/// </summary>
	public void SetROAccessory12FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory12Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory12 field.
	/// </summary>
	public void SetROAccessory12FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory12Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory13 field.
	/// </summary>
	public ColumnValue GetROAccessory13Value()
	{
		return this.GetValue(TableUtils.ROAccessory13Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory13 field.
	/// </summary>
	public bool GetROAccessory13FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory13Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory13 field.
	/// </summary>
	public void SetROAccessory13FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory13Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory13 field.
	/// </summary>
	public void SetROAccessory13FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory13Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory13 field.
	/// </summary>
	public void SetROAccessory13FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory13Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory14 field.
	/// </summary>
	public ColumnValue GetROAccessory14Value()
	{
		return this.GetValue(TableUtils.ROAccessory14Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory14 field.
	/// </summary>
	public bool GetROAccessory14FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory14Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory14 field.
	/// </summary>
	public void SetROAccessory14FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory14Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory14 field.
	/// </summary>
	public void SetROAccessory14FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory14Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory14 field.
	/// </summary>
	public void SetROAccessory14FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory14Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory15 field.
	/// </summary>
	public ColumnValue GetROAccessory15Value()
	{
		return this.GetValue(TableUtils.ROAccessory15Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory15 field.
	/// </summary>
	public bool GetROAccessory15FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory15Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory15 field.
	/// </summary>
	public void SetROAccessory15FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory15Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory15 field.
	/// </summary>
	public void SetROAccessory15FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory15Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory15 field.
	/// </summary>
	public void SetROAccessory15FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory15Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory2 field.
	/// </summary>
	public ColumnValue GetROAccessory2Value()
	{
		return this.GetValue(TableUtils.ROAccessory2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory2 field.
	/// </summary>
	public bool GetROAccessory2FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory2Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory2 field.
	/// </summary>
	public void SetROAccessory2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory2 field.
	/// </summary>
	public void SetROAccessory2FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory2 field.
	/// </summary>
	public void SetROAccessory2FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory3 field.
	/// </summary>
	public ColumnValue GetROAccessory3Value()
	{
		return this.GetValue(TableUtils.ROAccessory3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory3 field.
	/// </summary>
	public bool GetROAccessory3FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory3Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory3 field.
	/// </summary>
	public void SetROAccessory3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory3 field.
	/// </summary>
	public void SetROAccessory3FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory3 field.
	/// </summary>
	public void SetROAccessory3FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory4 field.
	/// </summary>
	public ColumnValue GetROAccessory4Value()
	{
		return this.GetValue(TableUtils.ROAccessory4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory4 field.
	/// </summary>
	public bool GetROAccessory4FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory4Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory4 field.
	/// </summary>
	public void SetROAccessory4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory4 field.
	/// </summary>
	public void SetROAccessory4FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory4 field.
	/// </summary>
	public void SetROAccessory4FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory5 field.
	/// </summary>
	public ColumnValue GetROAccessory5Value()
	{
		return this.GetValue(TableUtils.ROAccessory5Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory5 field.
	/// </summary>
	public bool GetROAccessory5FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory5Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory5 field.
	/// </summary>
	public void SetROAccessory5FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory5Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory5 field.
	/// </summary>
	public void SetROAccessory5FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory5Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory5 field.
	/// </summary>
	public void SetROAccessory5FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory5Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory6 field.
	/// </summary>
	public ColumnValue GetROAccessory6Value()
	{
		return this.GetValue(TableUtils.ROAccessory6Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory6 field.
	/// </summary>
	public bool GetROAccessory6FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory6Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory6 field.
	/// </summary>
	public void SetROAccessory6FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory6Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory6 field.
	/// </summary>
	public void SetROAccessory6FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory6Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory6 field.
	/// </summary>
	public void SetROAccessory6FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory6Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory7 field.
	/// </summary>
	public ColumnValue GetROAccessory7Value()
	{
		return this.GetValue(TableUtils.ROAccessory7Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory7 field.
	/// </summary>
	public bool GetROAccessory7FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory7Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory7 field.
	/// </summary>
	public void SetROAccessory7FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory7Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory7 field.
	/// </summary>
	public void SetROAccessory7FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory7Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory7 field.
	/// </summary>
	public void SetROAccessory7FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory7Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory8 field.
	/// </summary>
	public ColumnValue GetROAccessory8Value()
	{
		return this.GetValue(TableUtils.ROAccessory8Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory8 field.
	/// </summary>
	public bool GetROAccessory8FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory8Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory8 field.
	/// </summary>
	public void SetROAccessory8FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory8Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory8 field.
	/// </summary>
	public void SetROAccessory8FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory8Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory8 field.
	/// </summary>
	public void SetROAccessory8FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory8Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory9 field.
	/// </summary>
	public ColumnValue GetROAccessory9Value()
	{
		return this.GetValue(TableUtils.ROAccessory9Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAccessory9 field.
	/// </summary>
	public bool GetROAccessory9FieldValue()
	{
		return this.GetValue(TableUtils.ROAccessory9Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory9 field.
	/// </summary>
	public void SetROAccessory9FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAccessory9Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory9 field.
	/// </summary>
	public void SetROAccessory9FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAccessory9Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory9 field.
	/// </summary>
	public void SetROAccessory9FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAccessory9Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAddress1 field.
	/// </summary>
	public ColumnValue GetROAddress1Value()
	{
		return this.GetValue(TableUtils.ROAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAddress1 field.
	/// </summary>
	public string GetROAddress1FieldValue()
	{
		return this.GetValue(TableUtils.ROAddress1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAddress1 field.
	/// </summary>
	public void SetROAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAddress1 field.
	/// </summary>
	public void SetROAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAddress1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAddress2 field.
	/// </summary>
	public ColumnValue GetROAddress2Value()
	{
		return this.GetValue(TableUtils.ROAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAddress2 field.
	/// </summary>
	public string GetROAddress2FieldValue()
	{
		return this.GetValue(TableUtils.ROAddress2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAddress2 field.
	/// </summary>
	public void SetROAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAddress2 field.
	/// </summary>
	public void SetROAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAddress2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAdvertising field.
	/// </summary>
	public ColumnValue GetROAdvertisingValue()
	{
		return this.GetValue(TableUtils.ROAdvertisingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAdvertising field.
	/// </summary>
	public string GetROAdvertisingFieldValue()
	{
		return this.GetValue(TableUtils.ROAdvertisingColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAdvertising field.
	/// </summary>
	public void SetROAdvertisingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAdvertisingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAdvertising field.
	/// </summary>
	public void SetROAdvertisingFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAdvertisingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAmountPaid field.
	/// </summary>
	public ColumnValue GetROAmountPaidValue()
	{
		return this.GetValue(TableUtils.ROAmountPaidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAmountPaid field.
	/// </summary>
	public Decimal GetROAmountPaidFieldValue()
	{
		return this.GetValue(TableUtils.ROAmountPaidColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAmountPaid field.
	/// </summary>
	public void SetROAmountPaidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAmountPaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAmountPaid field.
	/// </summary>
	public void SetROAmountPaidFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAmountPaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAmountPaid field.
	/// </summary>
	public void SetROAmountPaidFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAmountPaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAmountPaid field.
	/// </summary>
	public void SetROAmountPaidFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAmountPaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAmountPaid field.
	/// </summary>
	public void SetROAmountPaidFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAmountPaidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAutoCalc field.
	/// </summary>
	public ColumnValue GetROAutoCalcValue()
	{
		return this.GetValue(TableUtils.ROAutoCalcColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROAutoCalc field.
	/// </summary>
	public bool GetROAutoCalcFieldValue()
	{
		return this.GetValue(TableUtils.ROAutoCalcColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAutoCalc field.
	/// </summary>
	public void SetROAutoCalcFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAutoCalcColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAutoCalc field.
	/// </summary>
	public void SetROAutoCalcFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROAutoCalcColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAutoCalc field.
	/// </summary>
	public void SetROAutoCalcFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAutoCalcColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROBatchID field.
	/// </summary>
	public ColumnValue GetROBatchIDValue()
	{
		return this.GetValue(TableUtils.ROBatchIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROBatchID field.
	/// </summary>
	public string GetROBatchIDFieldValue()
	{
		return this.GetValue(TableUtils.ROBatchIDColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBatchID field.
	/// </summary>
	public void SetROBatchIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROBatchIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBatchID field.
	/// </summary>
	public void SetROBatchIDFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROBatchIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROBillingNo field.
	/// </summary>
	public ColumnValue GetROBillingNoValue()
	{
		return this.GetValue(TableUtils.ROBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROBillingNo field.
	/// </summary>
	public Int32 GetROBillingNoFieldValue()
	{
		return this.GetValue(TableUtils.ROBillingNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBillingNo field.
	/// </summary>
	public void SetROBillingNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBillingNo field.
	/// </summary>
	public void SetROBillingNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBillingNo field.
	/// </summary>
	public void SetROBillingNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBillingNo field.
	/// </summary>
	public void SetROBillingNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROBillingNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBillingNo field.
	/// </summary>
	public void SetROBillingNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROBillingNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROBin field.
	/// </summary>
	public ColumnValue GetROBinValue()
	{
		return this.GetValue(TableUtils.ROBinColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROBin field.
	/// </summary>
	public string GetROBinFieldValue()
	{
		return this.GetValue(TableUtils.ROBinColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBin field.
	/// </summary>
	public void SetROBinFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROBinColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBin field.
	/// </summary>
	public void SetROBinFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROBinColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCategory field.
	/// </summary>
	public ColumnValue GetROCategoryValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCategory field.
	/// </summary>
	public string GetROCategoryFieldValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROChanges field.
	/// </summary>
	public ColumnValue GetROChangesValue()
	{
		return this.GetValue(TableUtils.ROChangesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROChanges field.
	/// </summary>
	public string GetROChangesFieldValue()
	{
		return this.GetValue(TableUtils.ROChangesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROChanges field.
	/// </summary>
	public void SetROChangesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROChangesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROChanges field.
	/// </summary>
	public void SetROChangesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROChangesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCity field.
	/// </summary>
	public ColumnValue GetROCityValue()
	{
		return this.GetValue(TableUtils.ROCityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCity field.
	/// </summary>
	public string GetROCityFieldValue()
	{
		return this.GetValue(TableUtils.ROCityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCity field.
	/// </summary>
	public void SetROCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCity field.
	/// </summary>
	public void SetROCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCondition field.
	/// </summary>
	public ColumnValue GetROConditionValue()
	{
		return this.GetValue(TableUtils.ROConditionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCondition field.
	/// </summary>
	public string GetROConditionFieldValue()
	{
		return this.GetValue(TableUtils.ROConditionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCondition field.
	/// </summary>
	public void SetROConditionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROConditionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCondition field.
	/// </summary>
	public void SetROConditionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROConditionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROContactName field.
	/// </summary>
	public ColumnValue GetROContactNameValue()
	{
		return this.GetValue(TableUtils.ROContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROContactName field.
	/// </summary>
	public string GetROContactNameFieldValue()
	{
		return this.GetValue(TableUtils.ROContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROContactName field.
	/// </summary>
	public void SetROContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROContactName field.
	/// </summary>
	public void SetROContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCountry field.
	/// </summary>
	public ColumnValue GetROCountryValue()
	{
		return this.GetValue(TableUtils.ROCountryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCountry field.
	/// </summary>
	public string GetROCountryFieldValue()
	{
		return this.GetValue(TableUtils.ROCountryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCountry field.
	/// </summary>
	public void SetROCountryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCountryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCountry field.
	/// </summary>
	public void SetROCountryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCountryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustName field.
	/// </summary>
	public ColumnValue GetROCustNameValue()
	{
		return this.GetValue(TableUtils.ROCustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustName field.
	/// </summary>
	public string GetROCustNameFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustName field.
	/// </summary>
	public void SetROCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustName field.
	/// </summary>
	public void SetROCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustNo field.
	/// </summary>
	public ColumnValue GetROCustNoValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustNo field.
	/// </summary>
	public Int32 GetROCustNoFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustom1 field.
	/// </summary>
	public ColumnValue GetROCustom1Value()
	{
		return this.GetValue(TableUtils.ROCustom1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustom1 field.
	/// </summary>
	public string GetROCustom1FieldValue()
	{
		return this.GetValue(TableUtils.ROCustom1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustom1 field.
	/// </summary>
	public void SetROCustom1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustom1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustom1 field.
	/// </summary>
	public void SetROCustom1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustom1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustom2 field.
	/// </summary>
	public ColumnValue GetROCustom2Value()
	{
		return this.GetValue(TableUtils.ROCustom2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustom2 field.
	/// </summary>
	public string GetROCustom2FieldValue()
	{
		return this.GetValue(TableUtils.ROCustom2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustom2 field.
	/// </summary>
	public void SetROCustom2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustom2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustom2 field.
	/// </summary>
	public void SetROCustom2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustom2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustomExported field.
	/// </summary>
	public ColumnValue GetROCustomExportedValue()
	{
		return this.GetValue(TableUtils.ROCustomExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROCustomExported field.
	/// </summary>
	public Byte GetROCustomExportedFieldValue()
	{
		return this.GetValue(TableUtils.ROCustomExportedColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustomExported field.
	/// </summary>
	public void SetROCustomExportedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustomExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustomExported field.
	/// </summary>
	public void SetROCustomExportedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROCustomExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustomExported field.
	/// </summary>
	public void SetROCustomExportedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustomExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustomExported field.
	/// </summary>
	public void SetROCustomExportedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustomExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustomExported field.
	/// </summary>
	public void SetROCustomExportedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustomExportedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODate field.
	/// </summary>
	public ColumnValue GetRODateValue()
	{
		return this.GetValue(TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODate field.
	/// </summary>
	public DateTime GetRODateFieldValue()
	{
		return this.GetValue(TableUtils.RODateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimateApproved field.
	/// </summary>
	public ColumnValue GetRODateEstimateApprovedValue()
	{
		return this.GetValue(TableUtils.RODateEstimateApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimateApproved field.
	/// </summary>
	public DateTime GetRODateEstimateApprovedFieldValue()
	{
		return this.GetValue(TableUtils.RODateEstimateApprovedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateApproved field.
	/// </summary>
	public void SetRODateEstimateApprovedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateEstimateApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateApproved field.
	/// </summary>
	public void SetRODateEstimateApprovedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateEstimateApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateApproved field.
	/// </summary>
	public void SetRODateEstimateApprovedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateEstimateApprovedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimateCompleted field.
	/// </summary>
	public ColumnValue GetRODateEstimateCompletedValue()
	{
		return this.GetValue(TableUtils.RODateEstimateCompletedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimateCompleted field.
	/// </summary>
	public DateTime GetRODateEstimateCompletedFieldValue()
	{
		return this.GetValue(TableUtils.RODateEstimateCompletedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateCompleted field.
	/// </summary>
	public void SetRODateEstimateCompletedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateEstimateCompletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateCompleted field.
	/// </summary>
	public void SetRODateEstimateCompletedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateEstimateCompletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateCompleted field.
	/// </summary>
	public void SetRODateEstimateCompletedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateEstimateCompletedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimatedCompletion field.
	/// </summary>
	public ColumnValue GetRODateEstimatedCompletionValue()
	{
		return this.GetValue(TableUtils.RODateEstimatedCompletionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimatedCompletion field.
	/// </summary>
	public DateTime GetRODateEstimatedCompletionFieldValue()
	{
		return this.GetValue(TableUtils.RODateEstimatedCompletionColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimatedCompletion field.
	/// </summary>
	public void SetRODateEstimatedCompletionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateEstimatedCompletionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimatedCompletion field.
	/// </summary>
	public void SetRODateEstimatedCompletionFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateEstimatedCompletionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimatedCompletion field.
	/// </summary>
	public void SetRODateEstimatedCompletionFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateEstimatedCompletionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimateRefused field.
	/// </summary>
	public ColumnValue GetRODateEstimateRefusedValue()
	{
		return this.GetValue(TableUtils.RODateEstimateRefusedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimateRefused field.
	/// </summary>
	public DateTime GetRODateEstimateRefusedFieldValue()
	{
		return this.GetValue(TableUtils.RODateEstimateRefusedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateRefused field.
	/// </summary>
	public void SetRODateEstimateRefusedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateEstimateRefusedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateRefused field.
	/// </summary>
	public void SetRODateEstimateRefusedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateEstimateRefusedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateRefused field.
	/// </summary>
	public void SetRODateEstimateRefusedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateEstimateRefusedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimateSent field.
	/// </summary>
	public ColumnValue GetRODateEstimateSentValue()
	{
		return this.GetValue(TableUtils.RODateEstimateSentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateEstimateSent field.
	/// </summary>
	public DateTime GetRODateEstimateSentFieldValue()
	{
		return this.GetValue(TableUtils.RODateEstimateSentColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateSent field.
	/// </summary>
	public void SetRODateEstimateSentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateEstimateSentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateSent field.
	/// </summary>
	public void SetRODateEstimateSentFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateEstimateSentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateSent field.
	/// </summary>
	public void SetRODateEstimateSentFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateEstimateSentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODatePaid field.
	/// </summary>
	public ColumnValue GetRODatePaidValue()
	{
		return this.GetValue(TableUtils.RODatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODatePaid field.
	/// </summary>
	public DateTime GetRODatePaidFieldValue()
	{
		return this.GetValue(TableUtils.RODatePaidColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODatePaid field.
	/// </summary>
	public void SetRODatePaidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODatePaid field.
	/// </summary>
	public void SetRODatePaidFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODatePaidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODatePaid field.
	/// </summary>
	public void SetRODatePaidFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODatePaidColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODatePurchased field.
	/// </summary>
	public ColumnValue GetRODatePurchasedValue()
	{
		return this.GetValue(TableUtils.RODatePurchasedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODatePurchased field.
	/// </summary>
	public DateTime GetRODatePurchasedFieldValue()
	{
		return this.GetValue(TableUtils.RODatePurchasedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODatePurchased field.
	/// </summary>
	public void SetRODatePurchasedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODatePurchasedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODatePurchased field.
	/// </summary>
	public void SetRODatePurchasedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODatePurchasedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODatePurchased field.
	/// </summary>
	public void SetRODatePurchasedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODatePurchasedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateReceivedFromVendor field.
	/// </summary>
	public ColumnValue GetRODateReceivedFromVendorValue()
	{
		return this.GetValue(TableUtils.RODateReceivedFromVendorColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateReceivedFromVendor field.
	/// </summary>
	public DateTime GetRODateReceivedFromVendorFieldValue()
	{
		return this.GetValue(TableUtils.RODateReceivedFromVendorColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateReceivedFromVendor field.
	/// </summary>
	public void SetRODateReceivedFromVendorFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateReceivedFromVendorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateReceivedFromVendor field.
	/// </summary>
	public void SetRODateReceivedFromVendorFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateReceivedFromVendorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateReceivedFromVendor field.
	/// </summary>
	public void SetRODateReceivedFromVendorFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateReceivedFromVendorColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateRecordAdded field.
	/// </summary>
	public ColumnValue GetRODateRecordAddedValue()
	{
		return this.GetValue(TableUtils.RODateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateRecordAdded field.
	/// </summary>
	public DateTime GetRODateRecordAddedFieldValue()
	{
		return this.GetValue(TableUtils.RODateRecordAddedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRecordAdded field.
	/// </summary>
	public void SetRODateRecordAddedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRecordAdded field.
	/// </summary>
	public void SetRODateRecordAddedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateRecordAddedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRecordAdded field.
	/// </summary>
	public void SetRODateRecordAddedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateRecordAddedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateRecordUpdated field.
	/// </summary>
	public ColumnValue GetRODateRecordUpdatedValue()
	{
		return this.GetValue(TableUtils.RODateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateRecordUpdated field.
	/// </summary>
	public DateTime GetRODateRecordUpdatedFieldValue()
	{
		return this.GetValue(TableUtils.RODateRecordUpdatedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRecordUpdated field.
	/// </summary>
	public void SetRODateRecordUpdatedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRecordUpdated field.
	/// </summary>
	public void SetRODateRecordUpdatedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRecordUpdated field.
	/// </summary>
	public void SetRODateRecordUpdatedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateRecordUpdatedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateRepairCompleted field.
	/// </summary>
	public ColumnValue GetRODateRepairCompletedValue()
	{
		return this.GetValue(TableUtils.RODateRepairCompletedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateRepairCompleted field.
	/// </summary>
	public DateTime GetRODateRepairCompletedFieldValue()
	{
		return this.GetValue(TableUtils.RODateRepairCompletedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRepairCompleted field.
	/// </summary>
	public void SetRODateRepairCompletedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateRepairCompletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRepairCompleted field.
	/// </summary>
	public void SetRODateRepairCompletedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateRepairCompletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRepairCompleted field.
	/// </summary>
	public void SetRODateRepairCompletedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateRepairCompletedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateRequestedFor field.
	/// </summary>
	public ColumnValue GetRODateRequestedForValue()
	{
		return this.GetValue(TableUtils.RODateRequestedForColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateRequestedFor field.
	/// </summary>
	public DateTime GetRODateRequestedForFieldValue()
	{
		return this.GetValue(TableUtils.RODateRequestedForColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRequestedFor field.
	/// </summary>
	public void SetRODateRequestedForFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateRequestedForColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRequestedFor field.
	/// </summary>
	public void SetRODateRequestedForFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateRequestedForColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRequestedFor field.
	/// </summary>
	public void SetRODateRequestedForFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateRequestedForColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateReturned field.
	/// </summary>
	public ColumnValue GetRODateReturnedValue()
	{
		return this.GetValue(TableUtils.RODateReturnedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateReturned field.
	/// </summary>
	public DateTime GetRODateReturnedFieldValue()
	{
		return this.GetValue(TableUtils.RODateReturnedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateReturned field.
	/// </summary>
	public void SetRODateReturnedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateReturnedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateReturned field.
	/// </summary>
	public void SetRODateReturnedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateReturnedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateReturned field.
	/// </summary>
	public void SetRODateReturnedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateReturnedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateStatusUpdated field.
	/// </summary>
	public ColumnValue GetRODateStatusUpdatedValue()
	{
		return this.GetValue(TableUtils.RODateStatusUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateStatusUpdated field.
	/// </summary>
	public DateTime GetRODateStatusUpdatedFieldValue()
	{
		return this.GetValue(TableUtils.RODateStatusUpdatedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateStatusUpdated field.
	/// </summary>
	public void SetRODateStatusUpdatedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateStatusUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateStatusUpdated field.
	/// </summary>
	public void SetRODateStatusUpdatedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateStatusUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateStatusUpdated field.
	/// </summary>
	public void SetRODateStatusUpdatedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateStatusUpdatedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateSubcontracted field.
	/// </summary>
	public ColumnValue GetRODateSubcontractedValue()
	{
		return this.GetValue(TableUtils.RODateSubcontractedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODateSubcontracted field.
	/// </summary>
	public DateTime GetRODateSubcontractedFieldValue()
	{
		return this.GetValue(TableUtils.RODateSubcontractedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateSubcontracted field.
	/// </summary>
	public void SetRODateSubcontractedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateSubcontractedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateSubcontracted field.
	/// </summary>
	public void SetRODateSubcontractedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateSubcontractedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateSubcontracted field.
	/// </summary>
	public void SetRODateSubcontractedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateSubcontractedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODesc field.
	/// </summary>
	public ColumnValue GetRODescValue()
	{
		return this.GetValue(TableUtils.RODescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODesc field.
	/// </summary>
	public string GetRODescFieldValue()
	{
		return this.GetValue(TableUtils.RODescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODesc field.
	/// </summary>
	public void SetRODescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODesc field.
	/// </summary>
	public void SetRODescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscHandling field.
	/// </summary>
	public ColumnValue GetRODiscHandlingValue()
	{
		return this.GetValue(TableUtils.RODiscHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscHandling field.
	/// </summary>
	public bool GetRODiscHandlingFieldValue()
	{
		return this.GetValue(TableUtils.RODiscHandlingColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscHandling field.
	/// </summary>
	public void SetRODiscHandlingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODiscHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscHandling field.
	/// </summary>
	public void SetRODiscHandlingFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODiscHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscHandling field.
	/// </summary>
	public void SetRODiscHandlingFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscHandlingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscLabor field.
	/// </summary>
	public ColumnValue GetRODiscLaborValue()
	{
		return this.GetValue(TableUtils.RODiscLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscLabor field.
	/// </summary>
	public bool GetRODiscLaborFieldValue()
	{
		return this.GetValue(TableUtils.RODiscLaborColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscLabor field.
	/// </summary>
	public void SetRODiscLaborFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODiscLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscLabor field.
	/// </summary>
	public void SetRODiscLaborFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODiscLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscLabor field.
	/// </summary>
	public void SetRODiscLaborFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscLaborColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscount field.
	/// </summary>
	public ColumnValue GetRODiscountValue()
	{
		return this.GetValue(TableUtils.RODiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscount field.
	/// </summary>
	public Decimal GetRODiscountFieldValue()
	{
		return this.GetValue(TableUtils.RODiscountColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscount field.
	/// </summary>
	public void SetRODiscountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscount field.
	/// </summary>
	public void SetRODiscountFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscount field.
	/// </summary>
	public void SetRODiscountFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscount field.
	/// </summary>
	public void SetRODiscountFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscount field.
	/// </summary>
	public void SetRODiscountFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscountColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscountRate field.
	/// </summary>
	public ColumnValue GetRODiscountRateValue()
	{
		return this.GetValue(TableUtils.RODiscountRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscountRate field.
	/// </summary>
	public Single GetRODiscountRateFieldValue()
	{
		return this.GetValue(TableUtils.RODiscountRateColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscountRate field.
	/// </summary>
	public void SetRODiscountRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODiscountRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscountRate field.
	/// </summary>
	public void SetRODiscountRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODiscountRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscountRate field.
	/// </summary>
	public void SetRODiscountRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscountRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscountRate field.
	/// </summary>
	public void SetRODiscountRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscountRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscountRate field.
	/// </summary>
	public void SetRODiscountRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscountRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscParts field.
	/// </summary>
	public ColumnValue GetRODiscPartsValue()
	{
		return this.GetValue(TableUtils.RODiscPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscParts field.
	/// </summary>
	public bool GetRODiscPartsFieldValue()
	{
		return this.GetValue(TableUtils.RODiscPartsColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscParts field.
	/// </summary>
	public void SetRODiscPartsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODiscPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscParts field.
	/// </summary>
	public void SetRODiscPartsFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODiscPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscParts field.
	/// </summary>
	public void SetRODiscPartsFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscPartsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscShipping field.
	/// </summary>
	public ColumnValue GetRODiscShippingValue()
	{
		return this.GetValue(TableUtils.RODiscShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscShipping field.
	/// </summary>
	public bool GetRODiscShippingFieldValue()
	{
		return this.GetValue(TableUtils.RODiscShippingColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscShipping field.
	/// </summary>
	public void SetRODiscShippingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODiscShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscShipping field.
	/// </summary>
	public void SetRODiscShippingFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODiscShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscShipping field.
	/// </summary>
	public void SetRODiscShippingFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscShippingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscTravel field.
	/// </summary>
	public ColumnValue GetRODiscTravelValue()
	{
		return this.GetValue(TableUtils.RODiscTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODiscTravel field.
	/// </summary>
	public bool GetRODiscTravelFieldValue()
	{
		return this.GetValue(TableUtils.RODiscTravelColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscTravel field.
	/// </summary>
	public void SetRODiscTravelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODiscTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscTravel field.
	/// </summary>
	public void SetRODiscTravelFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODiscTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscTravel field.
	/// </summary>
	public void SetRODiscTravelFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODiscTravelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROEditLock field.
	/// </summary>
	public ColumnValue GetROEditLockValue()
	{
		return this.GetValue(TableUtils.ROEditLockColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROEditLock field.
	/// </summary>
	public Byte GetROEditLockFieldValue()
	{
		return this.GetValue(TableUtils.ROEditLockColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEditLock field.
	/// </summary>
	public void SetROEditLockFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROEditLockColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEditLock field.
	/// </summary>
	public void SetROEditLockFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROEditLockColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEditLock field.
	/// </summary>
	public void SetROEditLockFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROEditLockColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEditLock field.
	/// </summary>
	public void SetROEditLockFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROEditLockColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEditLock field.
	/// </summary>
	public void SetROEditLockFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROEditLockColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROEmail field.
	/// </summary>
	public ColumnValue GetROEmailValue()
	{
		return this.GetValue(TableUtils.ROEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROEmail field.
	/// </summary>
	public string GetROEmailFieldValue()
	{
		return this.GetValue(TableUtils.ROEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEmail field.
	/// </summary>
	public void SetROEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEmail field.
	/// </summary>
	public void SetROEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROEstimatedBy field.
	/// </summary>
	public ColumnValue GetROEstimatedByValue()
	{
		return this.GetValue(TableUtils.ROEstimatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROEstimatedBy field.
	/// </summary>
	public string GetROEstimatedByFieldValue()
	{
		return this.GetValue(TableUtils.ROEstimatedByColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEstimatedBy field.
	/// </summary>
	public void SetROEstimatedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROEstimatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEstimatedBy field.
	/// </summary>
	public void SetROEstimatedByFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROEstimatedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROEstimateRequired field.
	/// </summary>
	public ColumnValue GetROEstimateRequiredValue()
	{
		return this.GetValue(TableUtils.ROEstimateRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROEstimateRequired field.
	/// </summary>
	public Byte GetROEstimateRequiredFieldValue()
	{
		return this.GetValue(TableUtils.ROEstimateRequiredColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEstimateRequired field.
	/// </summary>
	public void SetROEstimateRequiredFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROEstimateRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEstimateRequired field.
	/// </summary>
	public void SetROEstimateRequiredFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROEstimateRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEstimateRequired field.
	/// </summary>
	public void SetROEstimateRequiredFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROEstimateRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEstimateRequired field.
	/// </summary>
	public void SetROEstimateRequiredFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROEstimateRequiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEstimateRequired field.
	/// </summary>
	public void SetROEstimateRequiredFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROEstimateRequiredColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROExported field.
	/// </summary>
	public ColumnValue GetROExportedValue()
	{
		return this.GetValue(TableUtils.ROExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROExported field.
	/// </summary>
	public DateTime GetROExportedFieldValue()
	{
		return this.GetValue(TableUtils.ROExportedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExported field.
	/// </summary>
	public void SetROExportedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExported field.
	/// </summary>
	public void SetROExportedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROExportedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExported field.
	/// </summary>
	public void SetROExportedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROExportedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROExportInclude field.
	/// </summary>
	public ColumnValue GetROExportIncludeValue()
	{
		return this.GetValue(TableUtils.ROExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROExportInclude field.
	/// </summary>
	public bool GetROExportIncludeFieldValue()
	{
		return this.GetValue(TableUtils.ROExportIncludeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportInclude field.
	/// </summary>
	public void SetROExportIncludeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportInclude field.
	/// </summary>
	public void SetROExportIncludeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportInclude field.
	/// </summary>
	public void SetROExportIncludeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROExportIncludeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROExportRecordChanged field.
	/// </summary>
	public ColumnValue GetROExportRecordChangedValue()
	{
		return this.GetValue(TableUtils.ROExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROExportRecordChanged field.
	/// </summary>
	public bool GetROExportRecordChangedFieldValue()
	{
		return this.GetValue(TableUtils.ROExportRecordChangedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportRecordChanged field.
	/// </summary>
	public void SetROExportRecordChangedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportRecordChanged field.
	/// </summary>
	public void SetROExportRecordChangedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportRecordChanged field.
	/// </summary>
	public void SetROExportRecordChangedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROExportRecordChangedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROExportStatusChanged field.
	/// </summary>
	public ColumnValue GetROExportStatusChangedValue()
	{
		return this.GetValue(TableUtils.ROExportStatusChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROExportStatusChanged field.
	/// </summary>
	public bool GetROExportStatusChangedFieldValue()
	{
		return this.GetValue(TableUtils.ROExportStatusChangedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportStatusChanged field.
	/// </summary>
	public void SetROExportStatusChangedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROExportStatusChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportStatusChanged field.
	/// </summary>
	public void SetROExportStatusChangedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROExportStatusChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportStatusChanged field.
	/// </summary>
	public void SetROExportStatusChangedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROExportStatusChangedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROFaultCodes field.
	/// </summary>
	public ColumnValue GetROFaultCodesValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROFaultCodes field.
	/// </summary>
	public string GetROFaultCodesFieldValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROFaultCodesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROFax field.
	/// </summary>
	public ColumnValue GetROFaxValue()
	{
		return this.GetValue(TableUtils.ROFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROFax field.
	/// </summary>
	public string GetROFaxFieldValue()
	{
		return this.GetValue(TableUtils.ROFaxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROFax field.
	/// </summary>
	public void SetROFaxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROFax field.
	/// </summary>
	public void SetROFaxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROFaxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROGrandTotal field.
	/// </summary>
	public ColumnValue GetROGrandTotalValue()
	{
		return this.GetValue(TableUtils.ROGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROGrandTotal field.
	/// </summary>
	public Decimal GetROGrandTotalFieldValue()
	{
		return this.GetValue(TableUtils.ROGrandTotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROGrandTotal field.
	/// </summary>
	public void SetROGrandTotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROGrandTotal field.
	/// </summary>
	public void SetROGrandTotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROGrandTotal field.
	/// </summary>
	public void SetROGrandTotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROGrandTotal field.
	/// </summary>
	public void SetROGrandTotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROGrandTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROGrandTotal field.
	/// </summary>
	public void SetROGrandTotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROGrandTotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROHandling field.
	/// </summary>
	public ColumnValue GetROHandlingValue()
	{
		return this.GetValue(TableUtils.ROHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROHandling field.
	/// </summary>
	public Decimal GetROHandlingFieldValue()
	{
		return this.GetValue(TableUtils.ROHandlingColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandling field.
	/// </summary>
	public void SetROHandlingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandling field.
	/// </summary>
	public void SetROHandlingFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandling field.
	/// </summary>
	public void SetROHandlingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandling field.
	/// </summary>
	public void SetROHandlingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandling field.
	/// </summary>
	public void SetROHandlingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHandlingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROHandlingCost field.
	/// </summary>
	public ColumnValue GetROHandlingCostValue()
	{
		return this.GetValue(TableUtils.ROHandlingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROHandlingCost field.
	/// </summary>
	public Decimal GetROHandlingCostFieldValue()
	{
		return this.GetValue(TableUtils.ROHandlingCostColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandlingCost field.
	/// </summary>
	public void SetROHandlingCostFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROHandlingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandlingCost field.
	/// </summary>
	public void SetROHandlingCostFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROHandlingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandlingCost field.
	/// </summary>
	public void SetROHandlingCostFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHandlingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandlingCost field.
	/// </summary>
	public void SetROHandlingCostFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHandlingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandlingCost field.
	/// </summary>
	public void SetROHandlingCostFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHandlingCostColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROHours field.
	/// </summary>
	public ColumnValue GetROHoursValue()
	{
		return this.GetValue(TableUtils.ROHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROHours field.
	/// </summary>
	public Single GetROHoursFieldValue()
	{
		return this.GetValue(TableUtils.ROHoursColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHours field.
	/// </summary>
	public void SetROHoursFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHours field.
	/// </summary>
	public void SetROHoursFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHours field.
	/// </summary>
	public void SetROHoursFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHours field.
	/// </summary>
	public void SetROHoursFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHoursColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHours field.
	/// </summary>
	public void SetROHoursFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHoursColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROHowApproved field.
	/// </summary>
	public ColumnValue GetROHowApprovedValue()
	{
		return this.GetValue(TableUtils.ROHowApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROHowApproved field.
	/// </summary>
	public string GetROHowApprovedFieldValue()
	{
		return this.GetValue(TableUtils.ROHowApprovedColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHowApproved field.
	/// </summary>
	public void SetROHowApprovedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROHowApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHowApproved field.
	/// </summary>
	public void SetROHowApprovedFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROHowApprovedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROInvDate field.
	/// </summary>
	public ColumnValue GetROInvDateValue()
	{
		return this.GetValue(TableUtils.ROInvDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROInvDate field.
	/// </summary>
	public DateTime GetROInvDateFieldValue()
	{
		return this.GetValue(TableUtils.ROInvDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvDate field.
	/// </summary>
	public void SetROInvDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROInvDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvDate field.
	/// </summary>
	public void SetROInvDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROInvDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvDate field.
	/// </summary>
	public void SetROInvDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROInvDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROInvNo field.
	/// </summary>
	public ColumnValue GetROInvNoValue()
	{
		return this.GetValue(TableUtils.ROInvNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROInvNo field.
	/// </summary>
	public Int32 GetROInvNoFieldValue()
	{
		return this.GetValue(TableUtils.ROInvNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvNo field.
	/// </summary>
	public void SetROInvNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROInvNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvNo field.
	/// </summary>
	public void SetROInvNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROInvNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvNo field.
	/// </summary>
	public void SetROInvNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROInvNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvNo field.
	/// </summary>
	public void SetROInvNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROInvNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvNo field.
	/// </summary>
	public void SetROInvNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROInvNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROLabor field.
	/// </summary>
	public ColumnValue GetROLaborValue()
	{
		return this.GetValue(TableUtils.ROLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROLabor field.
	/// </summary>
	public Decimal GetROLaborFieldValue()
	{
		return this.GetValue(TableUtils.ROLaborColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLabor field.
	/// </summary>
	public void SetROLaborFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLabor field.
	/// </summary>
	public void SetROLaborFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLabor field.
	/// </summary>
	public void SetROLaborFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLabor field.
	/// </summary>
	public void SetROLaborFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLabor field.
	/// </summary>
	public void SetROLaborFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLaborColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROLaborCost field.
	/// </summary>
	public ColumnValue GetROLaborCostValue()
	{
		return this.GetValue(TableUtils.ROLaborCostColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROLaborCost field.
	/// </summary>
	public Decimal GetROLaborCostFieldValue()
	{
		return this.GetValue(TableUtils.ROLaborCostColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLaborCost field.
	/// </summary>
	public void SetROLaborCostFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROLaborCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLaborCost field.
	/// </summary>
	public void SetROLaborCostFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROLaborCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLaborCost field.
	/// </summary>
	public void SetROLaborCostFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLaborCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLaborCost field.
	/// </summary>
	public void SetROLaborCostFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLaborCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLaborCost field.
	/// </summary>
	public void SetROLaborCostFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLaborCostColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROLinkedRONo field.
	/// </summary>
	public ColumnValue GetROLinkedRONoValue()
	{
		return this.GetValue(TableUtils.ROLinkedRONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROLinkedRONo field.
	/// </summary>
	public Int32 GetROLinkedRONoFieldValue()
	{
		return this.GetValue(TableUtils.ROLinkedRONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLinkedRONo field.
	/// </summary>
	public void SetROLinkedRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROLinkedRONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLinkedRONo field.
	/// </summary>
	public void SetROLinkedRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROLinkedRONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLinkedRONo field.
	/// </summary>
	public void SetROLinkedRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLinkedRONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLinkedRONo field.
	/// </summary>
	public void SetROLinkedRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLinkedRONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLinkedRONo field.
	/// </summary>
	public void SetROLinkedRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLinkedRONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROLocationBus field.
	/// </summary>
	public ColumnValue GetROLocationBusValue()
	{
		return this.GetValue(TableUtils.ROLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROLocationBus field.
	/// </summary>
	public Int32 GetROLocationBusFieldValue()
	{
		return this.GetValue(TableUtils.ROLocationBusColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLocationBus field.
	/// </summary>
	public void SetROLocationBusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLocationBus field.
	/// </summary>
	public void SetROLocationBusFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLocationBus field.
	/// </summary>
	public void SetROLocationBusFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLocationBus field.
	/// </summary>
	public void SetROLocationBusFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLocationBusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLocationBus field.
	/// </summary>
	public void SetROLocationBusFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROLocationBusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROMake field.
	/// </summary>
	public ColumnValue GetROMakeValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROMake field.
	/// </summary>
	public string GetROMakeFieldValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROMarkupRate field.
	/// </summary>
	public ColumnValue GetROMarkupRateValue()
	{
		return this.GetValue(TableUtils.ROMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROMarkupRate field.
	/// </summary>
	public Single GetROMarkupRateFieldValue()
	{
		return this.GetValue(TableUtils.ROMarkupRateColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROMarkupRate field.
	/// </summary>
	public void SetROMarkupRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROMarkupRate field.
	/// </summary>
	public void SetROMarkupRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROMarkupRate field.
	/// </summary>
	public void SetROMarkupRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROMarkupRate field.
	/// </summary>
	public void SetROMarkupRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROMarkupRate field.
	/// </summary>
	public void SetROMarkupRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROMarkupRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROModel field.
	/// </summary>
	public ColumnValue GetROModelValue()
	{
		return this.GetValue(TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROModel field.
	/// </summary>
	public string GetROModelFieldValue()
	{
		return this.GetValue(TableUtils.ROModelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROModelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RONo field.
	/// </summary>
	public ColumnValue GetRONoValue()
	{
		return this.GetValue(TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RONo field.
	/// </summary>
	public Int32 GetRONoFieldValue()
	{
		return this.GetValue(TableUtils.RONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROParts field.
	/// </summary>
	public ColumnValue GetROPartsValue()
	{
		return this.GetValue(TableUtils.ROPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROParts field.
	/// </summary>
	public Decimal GetROPartsFieldValue()
	{
		return this.GetValue(TableUtils.ROPartsColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROParts field.
	/// </summary>
	public void SetROPartsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROParts field.
	/// </summary>
	public void SetROPartsFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROParts field.
	/// </summary>
	public void SetROPartsFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROParts field.
	/// </summary>
	public void SetROPartsFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROParts field.
	/// </summary>
	public void SetROPartsFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPartsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPartsCost field.
	/// </summary>
	public ColumnValue GetROPartsCostValue()
	{
		return this.GetValue(TableUtils.ROPartsCostColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPartsCost field.
	/// </summary>
	public Decimal GetROPartsCostFieldValue()
	{
		return this.GetValue(TableUtils.ROPartsCostColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPartsCost field.
	/// </summary>
	public void SetROPartsCostFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPartsCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPartsCost field.
	/// </summary>
	public void SetROPartsCostFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROPartsCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPartsCost field.
	/// </summary>
	public void SetROPartsCostFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPartsCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPartsCost field.
	/// </summary>
	public void SetROPartsCostFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPartsCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPartsCost field.
	/// </summary>
	public void SetROPartsCostFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPartsCostColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPayMethod field.
	/// </summary>
	public ColumnValue GetROPayMethodValue()
	{
		return this.GetValue(TableUtils.ROPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPayMethod field.
	/// </summary>
	public Byte GetROPayMethodFieldValue()
	{
		return this.GetValue(TableUtils.ROPayMethodColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayMethod field.
	/// </summary>
	public void SetROPayMethodFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayMethod field.
	/// </summary>
	public void SetROPayMethodFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayMethod field.
	/// </summary>
	public void SetROPayMethodFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayMethod field.
	/// </summary>
	public void SetROPayMethodFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayMethod field.
	/// </summary>
	public void SetROPayMethodFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPayMethodColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPayTerms field.
	/// </summary>
	public ColumnValue GetROPayTermsValue()
	{
		return this.GetValue(TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPayTerms field.
	/// </summary>
	public Byte GetROPayTermsFieldValue()
	{
		return this.GetValue(TableUtils.ROPayTermsColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPayTermsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPhoneBusiness field.
	/// </summary>
	public ColumnValue GetROPhoneBusinessValue()
	{
		return this.GetValue(TableUtils.ROPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPhoneBusiness field.
	/// </summary>
	public string GetROPhoneBusinessFieldValue()
	{
		return this.GetValue(TableUtils.ROPhoneBusinessColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPhoneBusiness field.
	/// </summary>
	public void SetROPhoneBusinessFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPhoneBusiness field.
	/// </summary>
	public void SetROPhoneBusinessFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPhoneBusinessColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPhoneHome field.
	/// </summary>
	public ColumnValue GetROPhoneHomeValue()
	{
		return this.GetValue(TableUtils.ROPhoneHomeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPhoneHome field.
	/// </summary>
	public string GetROPhoneHomeFieldValue()
	{
		return this.GetValue(TableUtils.ROPhoneHomeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPhoneHome field.
	/// </summary>
	public void SetROPhoneHomeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPhoneHomeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPhoneHome field.
	/// </summary>
	public void SetROPhoneHomeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPhoneHomeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPhoneMobile field.
	/// </summary>
	public ColumnValue GetROPhoneMobileValue()
	{
		return this.GetValue(TableUtils.ROPhoneMobileColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPhoneMobile field.
	/// </summary>
	public string GetROPhoneMobileFieldValue()
	{
		return this.GetValue(TableUtils.ROPhoneMobileColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPhoneMobile field.
	/// </summary>
	public void SetROPhoneMobileFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPhoneMobileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPhoneMobile field.
	/// </summary>
	public void SetROPhoneMobileFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPhoneMobileColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPostalCode field.
	/// </summary>
	public ColumnValue GetROPostalCodeValue()
	{
		return this.GetValue(TableUtils.ROPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPostalCode field.
	/// </summary>
	public string GetROPostalCodeFieldValue()
	{
		return this.GetValue(TableUtils.ROPostalCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPostalCode field.
	/// </summary>
	public void SetROPostalCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPostalCode field.
	/// </summary>
	public void SetROPostalCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPostalCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPreapproved field.
	/// </summary>
	public ColumnValue GetROPreapprovedValue()
	{
		return this.GetValue(TableUtils.ROPreapprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPreapproved field.
	/// </summary>
	public Decimal GetROPreapprovedFieldValue()
	{
		return this.GetValue(TableUtils.ROPreapprovedColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPreapproved field.
	/// </summary>
	public void SetROPreapprovedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPreapprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPreapproved field.
	/// </summary>
	public void SetROPreapprovedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROPreapprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPreapproved field.
	/// </summary>
	public void SetROPreapprovedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPreapprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPreapproved field.
	/// </summary>
	public void SetROPreapprovedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPreapprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPreapproved field.
	/// </summary>
	public void SetROPreapprovedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPreapprovedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPrintNotes field.
	/// </summary>
	public ColumnValue GetROPrintNotesValue()
	{
		return this.GetValue(TableUtils.ROPrintNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPrintNotes field.
	/// </summary>
	public string GetROPrintNotesFieldValue()
	{
		return this.GetValue(TableUtils.ROPrintNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPrintNotes field.
	/// </summary>
	public void SetROPrintNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPrintNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPrintNotes field.
	/// </summary>
	public void SetROPrintNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPrintNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPriority field.
	/// </summary>
	public ColumnValue GetROPriorityValue()
	{
		return this.GetValue(TableUtils.ROPriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPriority field.
	/// </summary>
	public Byte GetROPriorityFieldValue()
	{
		return this.GetValue(TableUtils.ROPriorityColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPriority field.
	/// </summary>
	public void SetROPriorityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPriority field.
	/// </summary>
	public void SetROPriorityFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROPriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPriority field.
	/// </summary>
	public void SetROPriorityFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPriority field.
	/// </summary>
	public void SetROPriorityFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPriorityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPriority field.
	/// </summary>
	public void SetROPriorityFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPriorityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPrivateNotes field.
	/// </summary>
	public ColumnValue GetROPrivateNotesValue()
	{
		return this.GetValue(TableUtils.ROPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPrivateNotes field.
	/// </summary>
	public string GetROPrivateNotesFieldValue()
	{
		return this.GetValue(TableUtils.ROPrivateNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPrivateNotes field.
	/// </summary>
	public void SetROPrivateNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPrivateNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPrivateNotes field.
	/// </summary>
	public void SetROPrivateNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPrivateNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROProblem field.
	/// </summary>
	public ColumnValue GetROProblemValue()
	{
		return this.GetValue(TableUtils.ROProblemColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROProblem field.
	/// </summary>
	public string GetROProblemFieldValue()
	{
		return this.GetValue(TableUtils.ROProblemColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROProblem field.
	/// </summary>
	public void SetROProblemFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROProblemColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROProblem field.
	/// </summary>
	public void SetROProblemFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROProblemColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROProvince field.
	/// </summary>
	public ColumnValue GetROProvinceValue()
	{
		return this.GetValue(TableUtils.ROProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROProvince field.
	/// </summary>
	public string GetROProvinceFieldValue()
	{
		return this.GetValue(TableUtils.ROProvinceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROProvince field.
	/// </summary>
	public void SetROProvinceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROProvince field.
	/// </summary>
	public void SetROProvinceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROProvinceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPurchasedFrom field.
	/// </summary>
	public ColumnValue GetROPurchasedFromValue()
	{
		return this.GetValue(TableUtils.ROPurchasedFromColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROPurchasedFrom field.
	/// </summary>
	public string GetROPurchasedFromFieldValue()
	{
		return this.GetValue(TableUtils.ROPurchasedFromColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPurchasedFrom field.
	/// </summary>
	public void SetROPurchasedFromFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPurchasedFromColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPurchasedFrom field.
	/// </summary>
	public void SetROPurchasedFromFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPurchasedFromColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBAltered field.
	/// </summary>
	public ColumnValue GetROQBAlteredValue()
	{
		return this.GetValue(TableUtils.ROQBAlteredColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBAltered field.
	/// </summary>
	public bool GetROQBAlteredFieldValue()
	{
		return this.GetValue(TableUtils.ROQBAlteredColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBAltered field.
	/// </summary>
	public void SetROQBAlteredFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROQBAlteredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBAltered field.
	/// </summary>
	public void SetROQBAlteredFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROQBAlteredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBAltered field.
	/// </summary>
	public void SetROQBAlteredFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQBAlteredColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBAlteredPay field.
	/// </summary>
	public ColumnValue GetROQBAlteredPayValue()
	{
		return this.GetValue(TableUtils.ROQBAlteredPayColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBAlteredPay field.
	/// </summary>
	public bool GetROQBAlteredPayFieldValue()
	{
		return this.GetValue(TableUtils.ROQBAlteredPayColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBAlteredPay field.
	/// </summary>
	public void SetROQBAlteredPayFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROQBAlteredPayColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBAlteredPay field.
	/// </summary>
	public void SetROQBAlteredPayFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROQBAlteredPayColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBAlteredPay field.
	/// </summary>
	public void SetROQBAlteredPayFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQBAlteredPayColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBInvExcluded field.
	/// </summary>
	public ColumnValue GetROQBInvExcludedValue()
	{
		return this.GetValue(TableUtils.ROQBInvExcludedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBInvExcluded field.
	/// </summary>
	public bool GetROQBInvExcludedFieldValue()
	{
		return this.GetValue(TableUtils.ROQBInvExcludedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBInvExcluded field.
	/// </summary>
	public void SetROQBInvExcludedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROQBInvExcludedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBInvExcluded field.
	/// </summary>
	public void SetROQBInvExcludedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROQBInvExcludedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBInvExcluded field.
	/// </summary>
	public void SetROQBInvExcludedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQBInvExcludedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBInvNo field.
	/// </summary>
	public ColumnValue GetROQBInvNoValue()
	{
		return this.GetValue(TableUtils.ROQBInvNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBInvNo field.
	/// </summary>
	public string GetROQBInvNoFieldValue()
	{
		return this.GetValue(TableUtils.ROQBInvNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBInvNo field.
	/// </summary>
	public void SetROQBInvNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROQBInvNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBInvNo field.
	/// </summary>
	public void SetROQBInvNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQBInvNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBPayDetails field.
	/// </summary>
	public ColumnValue GetROQBPayDetailsValue()
	{
		return this.GetValue(TableUtils.ROQBPayDetailsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBPayDetails field.
	/// </summary>
	public string GetROQBPayDetailsFieldValue()
	{
		return this.GetValue(TableUtils.ROQBPayDetailsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBPayDetails field.
	/// </summary>
	public void SetROQBPayDetailsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROQBPayDetailsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBPayDetails field.
	/// </summary>
	public void SetROQBPayDetailsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQBPayDetailsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBPayExcluded field.
	/// </summary>
	public ColumnValue GetROQBPayExcludedValue()
	{
		return this.GetValue(TableUtils.ROQBPayExcludedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBPayExcluded field.
	/// </summary>
	public bool GetROQBPayExcludedFieldValue()
	{
		return this.GetValue(TableUtils.ROQBPayExcludedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBPayExcluded field.
	/// </summary>
	public void SetROQBPayExcludedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROQBPayExcludedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBPayExcluded field.
	/// </summary>
	public void SetROQBPayExcludedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROQBPayExcludedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBPayExcluded field.
	/// </summary>
	public void SetROQBPayExcludedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQBPayExcludedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBTxnID field.
	/// </summary>
	public ColumnValue GetROQBTxnIDValue()
	{
		return this.GetValue(TableUtils.ROQBTxnIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBTxnID field.
	/// </summary>
	public string GetROQBTxnIDFieldValue()
	{
		return this.GetValue(TableUtils.ROQBTxnIDColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBTxnID field.
	/// </summary>
	public void SetROQBTxnIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROQBTxnIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBTxnID field.
	/// </summary>
	public void SetROQBTxnIDFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQBTxnIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBTxnIDPay field.
	/// </summary>
	public ColumnValue GetROQBTxnIDPayValue()
	{
		return this.GetValue(TableUtils.ROQBTxnIDPayColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROQBTxnIDPay field.
	/// </summary>
	public string GetROQBTxnIDPayFieldValue()
	{
		return this.GetValue(TableUtils.ROQBTxnIDPayColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBTxnIDPay field.
	/// </summary>
	public void SetROQBTxnIDPayFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROQBTxnIDPayColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBTxnIDPay field.
	/// </summary>
	public void SetROQBTxnIDPayFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROQBTxnIDPayColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReceivedBy field.
	/// </summary>
	public ColumnValue GetROReceivedByValue()
	{
		return this.GetValue(TableUtils.ROReceivedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReceivedBy field.
	/// </summary>
	public string GetROReceivedByFieldValue()
	{
		return this.GetValue(TableUtils.ROReceivedByColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReceivedBy field.
	/// </summary>
	public void SetROReceivedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReceivedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReceivedBy field.
	/// </summary>
	public void SetROReceivedByFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReceivedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReEstimate field.
	/// </summary>
	public ColumnValue GetROReEstimateValue()
	{
		return this.GetValue(TableUtils.ROReEstimateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReEstimate field.
	/// </summary>
	public bool GetROReEstimateFieldValue()
	{
		return this.GetValue(TableUtils.ROReEstimateColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReEstimate field.
	/// </summary>
	public void SetROReEstimateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReEstimateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReEstimate field.
	/// </summary>
	public void SetROReEstimateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROReEstimateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReEstimate field.
	/// </summary>
	public void SetROReEstimateFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReEstimateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReference1 field.
	/// </summary>
	public ColumnValue GetROReference1Value()
	{
		return this.GetValue(TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReference1 field.
	/// </summary>
	public string GetROReference1FieldValue()
	{
		return this.GetValue(TableUtils.ROReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReference2 field.
	/// </summary>
	public ColumnValue GetROReference2Value()
	{
		return this.GetValue(TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReference2 field.
	/// </summary>
	public string GetROReference2FieldValue()
	{
		return this.GetValue(TableUtils.ROReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReference3 field.
	/// </summary>
	public ColumnValue GetROReference3Value()
	{
		return this.GetValue(TableUtils.ROReference3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReference3 field.
	/// </summary>
	public string GetROReference3FieldValue()
	{
		return this.GetValue(TableUtils.ROReference3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference3 field.
	/// </summary>
	public void SetROReference3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference3 field.
	/// </summary>
	public void SetROReference3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReference4 field.
	/// </summary>
	public ColumnValue GetROReference4Value()
	{
		return this.GetValue(TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROReference4 field.
	/// </summary>
	public string GetROReference4FieldValue()
	{
		return this.GetValue(TableUtils.ROReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSerialNo field.
	/// </summary>
	public ColumnValue GetROSerialNoValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSerialNo field.
	/// </summary>
	public string GetROSerialNoFieldValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSerialNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROShipping field.
	/// </summary>
	public ColumnValue GetROShippingValue()
	{
		return this.GetValue(TableUtils.ROShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROShipping field.
	/// </summary>
	public Decimal GetROShippingFieldValue()
	{
		return this.GetValue(TableUtils.ROShippingColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShipping field.
	/// </summary>
	public void SetROShippingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShipping field.
	/// </summary>
	public void SetROShippingFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShipping field.
	/// </summary>
	public void SetROShippingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShipping field.
	/// </summary>
	public void SetROShippingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShipping field.
	/// </summary>
	public void SetROShippingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROShippingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROShippingCost field.
	/// </summary>
	public ColumnValue GetROShippingCostValue()
	{
		return this.GetValue(TableUtils.ROShippingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROShippingCost field.
	/// </summary>
	public Decimal GetROShippingCostFieldValue()
	{
		return this.GetValue(TableUtils.ROShippingCostColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShippingCost field.
	/// </summary>
	public void SetROShippingCostFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROShippingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShippingCost field.
	/// </summary>
	public void SetROShippingCostFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROShippingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShippingCost field.
	/// </summary>
	public void SetROShippingCostFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROShippingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShippingCost field.
	/// </summary>
	public void SetROShippingCostFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROShippingCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShippingCost field.
	/// </summary>
	public void SetROShippingCostFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROShippingCostColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROShipVia field.
	/// </summary>
	public ColumnValue GetROShipViaValue()
	{
		return this.GetValue(TableUtils.ROShipViaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROShipVia field.
	/// </summary>
	public string GetROShipViaFieldValue()
	{
		return this.GetValue(TableUtils.ROShipViaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShipVia field.
	/// </summary>
	public void SetROShipViaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROShipViaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShipVia field.
	/// </summary>
	public void SetROShipViaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROShipViaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROStatus field.
	/// </summary>
	public ColumnValue GetROStatusValue()
	{
		return this.GetValue(TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROStatus field.
	/// </summary>
	public Byte GetROStatusFieldValue()
	{
		return this.GetValue(TableUtils.ROStatusColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontracted field.
	/// </summary>
	public ColumnValue GetROSubcontractedValue()
	{
		return this.GetValue(TableUtils.ROSubcontractedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontracted field.
	/// </summary>
	public bool GetROSubcontractedFieldValue()
	{
		return this.GetValue(TableUtils.ROSubcontractedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontracted field.
	/// </summary>
	public void SetROSubcontractedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSubcontractedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontracted field.
	/// </summary>
	public void SetROSubcontractedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROSubcontractedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontracted field.
	/// </summary>
	public void SetROSubcontractedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSubcontractedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontractNotes field.
	/// </summary>
	public ColumnValue GetROSubcontractNotesValue()
	{
		return this.GetValue(TableUtils.ROSubcontractNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontractNotes field.
	/// </summary>
	public string GetROSubcontractNotesFieldValue()
	{
		return this.GetValue(TableUtils.ROSubcontractNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractNotes field.
	/// </summary>
	public void SetROSubcontractNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSubcontractNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractNotes field.
	/// </summary>
	public void SetROSubcontractNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSubcontractNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontractReference1 field.
	/// </summary>
	public ColumnValue GetROSubcontractReference1Value()
	{
		return this.GetValue(TableUtils.ROSubcontractReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontractReference1 field.
	/// </summary>
	public string GetROSubcontractReference1FieldValue()
	{
		return this.GetValue(TableUtils.ROSubcontractReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractReference1 field.
	/// </summary>
	public void SetROSubcontractReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSubcontractReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractReference1 field.
	/// </summary>
	public void SetROSubcontractReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSubcontractReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontractReference2 field.
	/// </summary>
	public ColumnValue GetROSubcontractReference2Value()
	{
		return this.GetValue(TableUtils.ROSubcontractReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontractReference2 field.
	/// </summary>
	public string GetROSubcontractReference2FieldValue()
	{
		return this.GetValue(TableUtils.ROSubcontractReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractReference2 field.
	/// </summary>
	public void SetROSubcontractReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSubcontractReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractReference2 field.
	/// </summary>
	public void SetROSubcontractReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSubcontractReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontractVendNo field.
	/// </summary>
	public ColumnValue GetROSubcontractVendNoValue()
	{
		return this.GetValue(TableUtils.ROSubcontractVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROSubcontractVendNo field.
	/// </summary>
	public Int32 GetROSubcontractVendNoFieldValue()
	{
		return this.GetValue(TableUtils.ROSubcontractVendNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractVendNo field.
	/// </summary>
	public void SetROSubcontractVendNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSubcontractVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractVendNo field.
	/// </summary>
	public void SetROSubcontractVendNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROSubcontractVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractVendNo field.
	/// </summary>
	public void SetROSubcontractVendNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSubcontractVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractVendNo field.
	/// </summary>
	public void SetROSubcontractVendNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSubcontractVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractVendNo field.
	/// </summary>
	public void SetROSubcontractVendNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSubcontractVendNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax1 field.
	/// </summary>
	public ColumnValue GetROTax1Value()
	{
		return this.GetValue(TableUtils.ROTax1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax1 field.
	/// </summary>
	public Decimal GetROTax1FieldValue()
	{
		return this.GetValue(TableUtils.ROTax1Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1 field.
	/// </summary>
	public void SetROTax1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTax1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1 field.
	/// </summary>
	public void SetROTax1FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTax1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1 field.
	/// </summary>
	public void SetROTax1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1 field.
	/// </summary>
	public void SetROTax1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1 field.
	/// </summary>
	public void SetROTax1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax1Rate field.
	/// </summary>
	public ColumnValue GetROTax1RateValue()
	{
		return this.GetValue(TableUtils.ROTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax1Rate field.
	/// </summary>
	public Single GetROTax1RateFieldValue()
	{
		return this.GetValue(TableUtils.ROTax1RateColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rate field.
	/// </summary>
	public void SetROTax1RateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rate field.
	/// </summary>
	public void SetROTax1RateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rate field.
	/// </summary>
	public void SetROTax1RateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rate field.
	/// </summary>
	public void SetROTax1RateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax1RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rate field.
	/// </summary>
	public void SetROTax1RateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax1RateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax1Rules field.
	/// </summary>
	public ColumnValue GetROTax1RulesValue()
	{
		return this.GetValue(TableUtils.ROTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax1Rules field.
	/// </summary>
	public Byte GetROTax1RulesFieldValue()
	{
		return this.GetValue(TableUtils.ROTax1RulesColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rules field.
	/// </summary>
	public void SetROTax1RulesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rules field.
	/// </summary>
	public void SetROTax1RulesFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rules field.
	/// </summary>
	public void SetROTax1RulesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rules field.
	/// </summary>
	public void SetROTax1RulesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax1RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rules field.
	/// </summary>
	public void SetROTax1RulesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax1RulesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax2 field.
	/// </summary>
	public ColumnValue GetROTax2Value()
	{
		return this.GetValue(TableUtils.ROTax2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax2 field.
	/// </summary>
	public Decimal GetROTax2FieldValue()
	{
		return this.GetValue(TableUtils.ROTax2Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2 field.
	/// </summary>
	public void SetROTax2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTax2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2 field.
	/// </summary>
	public void SetROTax2FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTax2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2 field.
	/// </summary>
	public void SetROTax2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2 field.
	/// </summary>
	public void SetROTax2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2 field.
	/// </summary>
	public void SetROTax2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax2Rate field.
	/// </summary>
	public ColumnValue GetROTax2RateValue()
	{
		return this.GetValue(TableUtils.ROTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax2Rate field.
	/// </summary>
	public Single GetROTax2RateFieldValue()
	{
		return this.GetValue(TableUtils.ROTax2RateColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rate field.
	/// </summary>
	public void SetROTax2RateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rate field.
	/// </summary>
	public void SetROTax2RateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rate field.
	/// </summary>
	public void SetROTax2RateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rate field.
	/// </summary>
	public void SetROTax2RateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax2RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rate field.
	/// </summary>
	public void SetROTax2RateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax2RateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax2Rules field.
	/// </summary>
	public ColumnValue GetROTax2RulesValue()
	{
		return this.GetValue(TableUtils.ROTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax2Rules field.
	/// </summary>
	public Byte GetROTax2RulesFieldValue()
	{
		return this.GetValue(TableUtils.ROTax2RulesColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rules field.
	/// </summary>
	public void SetROTax2RulesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rules field.
	/// </summary>
	public void SetROTax2RulesFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rules field.
	/// </summary>
	public void SetROTax2RulesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rules field.
	/// </summary>
	public void SetROTax2RulesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax2RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rules field.
	/// </summary>
	public void SetROTax2RulesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax2RulesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax3 field.
	/// </summary>
	public ColumnValue GetROTax3Value()
	{
		return this.GetValue(TableUtils.ROTax3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax3 field.
	/// </summary>
	public Decimal GetROTax3FieldValue()
	{
		return this.GetValue(TableUtils.ROTax3Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3 field.
	/// </summary>
	public void SetROTax3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTax3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3 field.
	/// </summary>
	public void SetROTax3FieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTax3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3 field.
	/// </summary>
	public void SetROTax3FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3 field.
	/// </summary>
	public void SetROTax3FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3 field.
	/// </summary>
	public void SetROTax3FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax3Rate field.
	/// </summary>
	public ColumnValue GetROTax3RateValue()
	{
		return this.GetValue(TableUtils.ROTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax3Rate field.
	/// </summary>
	public Single GetROTax3RateFieldValue()
	{
		return this.GetValue(TableUtils.ROTax3RateColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rate field.
	/// </summary>
	public void SetROTax3RateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rate field.
	/// </summary>
	public void SetROTax3RateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rate field.
	/// </summary>
	public void SetROTax3RateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rate field.
	/// </summary>
	public void SetROTax3RateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax3RateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rate field.
	/// </summary>
	public void SetROTax3RateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax3RateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax3Rules field.
	/// </summary>
	public ColumnValue GetROTax3RulesValue()
	{
		return this.GetValue(TableUtils.ROTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTax3Rules field.
	/// </summary>
	public Byte GetROTax3RulesFieldValue()
	{
		return this.GetValue(TableUtils.ROTax3RulesColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rules field.
	/// </summary>
	public void SetROTax3RulesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rules field.
	/// </summary>
	public void SetROTax3RulesFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rules field.
	/// </summary>
	public void SetROTax3RulesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rules field.
	/// </summary>
	public void SetROTax3RulesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax3RulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rules field.
	/// </summary>
	public void SetROTax3RulesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTax3RulesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTaxExempt field.
	/// </summary>
	public ColumnValue GetROTaxExemptValue()
	{
		return this.GetValue(TableUtils.ROTaxExemptColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTaxExempt field.
	/// </summary>
	public string GetROTaxExemptFieldValue()
	{
		return this.GetValue(TableUtils.ROTaxExemptColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTaxExempt field.
	/// </summary>
	public void SetROTaxExemptFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTaxExemptColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTaxExempt field.
	/// </summary>
	public void SetROTaxExemptFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTaxExemptColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTechnician field.
	/// </summary>
	public ColumnValue GetROTechnicianValue()
	{
		return this.GetValue(TableUtils.ROTechnicianColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTechnician field.
	/// </summary>
	public string GetROTechnicianFieldValue()
	{
		return this.GetValue(TableUtils.ROTechnicianColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTechnician field.
	/// </summary>
	public void SetROTechnicianFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTechnicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTechnician field.
	/// </summary>
	public void SetROTechnicianFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTechnicianColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTracking field.
	/// </summary>
	public ColumnValue GetROTrackingValue()
	{
		return this.GetValue(TableUtils.ROTrackingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTracking field.
	/// </summary>
	public string GetROTrackingFieldValue()
	{
		return this.GetValue(TableUtils.ROTrackingColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTracking field.
	/// </summary>
	public void SetROTrackingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTrackingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTracking field.
	/// </summary>
	public void SetROTrackingFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTrackingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTravel field.
	/// </summary>
	public ColumnValue GetROTravelValue()
	{
		return this.GetValue(TableUtils.ROTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTravel field.
	/// </summary>
	public Decimal GetROTravelFieldValue()
	{
		return this.GetValue(TableUtils.ROTravelColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravel field.
	/// </summary>
	public void SetROTravelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravel field.
	/// </summary>
	public void SetROTravelFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravel field.
	/// </summary>
	public void SetROTravelFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravel field.
	/// </summary>
	public void SetROTravelFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravel field.
	/// </summary>
	public void SetROTravelFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTravelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTravelCost field.
	/// </summary>
	public ColumnValue GetROTravelCostValue()
	{
		return this.GetValue(TableUtils.ROTravelCostColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROTravelCost field.
	/// </summary>
	public Decimal GetROTravelCostFieldValue()
	{
		return this.GetValue(TableUtils.ROTravelCostColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravelCost field.
	/// </summary>
	public void SetROTravelCostFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTravelCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravelCost field.
	/// </summary>
	public void SetROTravelCostFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROTravelCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravelCost field.
	/// </summary>
	public void SetROTravelCostFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTravelCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravelCost field.
	/// </summary>
	public void SetROTravelCostFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTravelCostColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravelCost field.
	/// </summary>
	public void SetROTravelCostFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTravelCostColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROType field.
	/// </summary>
	public ColumnValue GetROTypeValue()
	{
		return this.GetValue(TableUtils.ROTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROType field.
	/// </summary>
	public string GetROTypeFieldValue()
	{
		return this.GetValue(TableUtils.ROTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROType field.
	/// </summary>
	public void SetROTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROType field.
	/// </summary>
	public void SetROTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROUnderWarranty field.
	/// </summary>
	public ColumnValue GetROUnderWarrantyValue()
	{
		return this.GetValue(TableUtils.ROUnderWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROUnderWarranty field.
	/// </summary>
	public bool GetROUnderWarrantyFieldValue()
	{
		return this.GetValue(TableUtils.ROUnderWarrantyColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROUnderWarranty field.
	/// </summary>
	public void SetROUnderWarrantyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROUnderWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROUnderWarranty field.
	/// </summary>
	public void SetROUnderWarrantyFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROUnderWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROUnderWarranty field.
	/// </summary>
	public void SetROUnderWarrantyFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROUnderWarrantyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROWarranty field.
	/// </summary>
	public ColumnValue GetROWarrantyValue()
	{
		return this.GetValue(TableUtils.ROWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROWarranty field.
	/// </summary>
	public Byte GetROWarrantyFieldValue()
	{
		return this.GetValue(TableUtils.ROWarrantyColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWarranty field.
	/// </summary>
	public void SetROWarrantyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWarranty field.
	/// </summary>
	public void SetROWarrantyFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWarranty field.
	/// </summary>
	public void SetROWarrantyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWarranty field.
	/// </summary>
	public void SetROWarrantyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWarranty field.
	/// </summary>
	public void SetROWarrantyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROWarrantyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROWarrantyPlan field.
	/// </summary>
	public ColumnValue GetROWarrantyPlanValue()
	{
		return this.GetValue(TableUtils.ROWarrantyPlanColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROWarrantyPlan field.
	/// </summary>
	public string GetROWarrantyPlanFieldValue()
	{
		return this.GetValue(TableUtils.ROWarrantyPlanColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWarrantyPlan field.
	/// </summary>
	public void SetROWarrantyPlanFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROWarrantyPlanColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWarrantyPlan field.
	/// </summary>
	public void SetROWarrantyPlanFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROWarrantyPlanColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROWorkDoneNotes field.
	/// </summary>
	public ColumnValue GetROWorkDoneNotesValue()
	{
		return this.GetValue(TableUtils.ROWorkDoneNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROWorkDoneNotes field.
	/// </summary>
	public string GetROWorkDoneNotesFieldValue()
	{
		return this.GetValue(TableUtils.ROWorkDoneNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWorkDoneNotes field.
	/// </summary>
	public void SetROWorkDoneNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROWorkDoneNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWorkDoneNotes field.
	/// </summary>
	public void SetROWorkDoneNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROWorkDoneNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROUnder_Contract field.
	/// </summary>
	public ColumnValue GetROUnder_ContractValue()
	{
		return this.GetValue(TableUtils.ROUnder_ContractColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ROUnder_Contract field.
	/// </summary>
	public bool GetROUnder_ContractFieldValue()
	{
		return this.GetValue(TableUtils.ROUnder_ContractColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROUnder_Contract field.
	/// </summary>
	public void SetROUnder_ContractFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROUnder_ContractColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROUnder_Contract field.
	/// </summary>
	public void SetROUnder_ContractFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROUnder_ContractColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROUnder_Contract field.
	/// </summary>
	public void SetROUnder_ContractFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROUnder_ContractColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.repair_est_notification field.
	/// </summary>
	public ColumnValue Getrepair_est_notificationValue()
	{
		return this.GetValue(TableUtils.repair_est_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.repair_est_notification field.
	/// </summary>
	public DateTime Getrepair_est_notificationFieldValue()
	{
		return this.GetValue(TableUtils.repair_est_notificationColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notification field.
	/// </summary>
	public void Setrepair_est_notificationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_est_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notification field.
	/// </summary>
	public void Setrepair_est_notificationFieldValue(string val)
	{
		this.SetString(val, TableUtils.repair_est_notificationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notification field.
	/// </summary>
	public void Setrepair_est_notificationFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_est_notificationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.repair_est_notify_by field.
	/// </summary>
	public ColumnValue Getrepair_est_notify_byValue()
	{
		return this.GetValue(TableUtils.repair_est_notify_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.repair_est_notify_by field.
	/// </summary>
	public Int32 Getrepair_est_notify_byFieldValue()
	{
		return this.GetValue(TableUtils.repair_est_notify_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notify_by field.
	/// </summary>
	public void Setrepair_est_notify_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_est_notify_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notify_by field.
	/// </summary>
	public void Setrepair_est_notify_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.repair_est_notify_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notify_by field.
	/// </summary>
	public void Setrepair_est_notify_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_est_notify_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notify_by field.
	/// </summary>
	public void Setrepair_est_notify_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_est_notify_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notify_by field.
	/// </summary>
	public void Setrepair_est_notify_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_est_notify_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.repair_est_note field.
	/// </summary>
	public ColumnValue Getrepair_est_noteValue()
	{
		return this.GetValue(TableUtils.repair_est_noteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.repair_est_note field.
	/// </summary>
	public string Getrepair_est_noteFieldValue()
	{
		return this.GetValue(TableUtils.repair_est_noteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_note field.
	/// </summary>
	public void Setrepair_est_noteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_est_noteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_note field.
	/// </summary>
	public void Setrepair_est_noteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_est_noteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.repair_replace field.
	/// </summary>
	public ColumnValue Getrepair_replaceValue()
	{
		return this.GetValue(TableUtils.repair_replaceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.repair_replace field.
	/// </summary>
	public bool Getrepair_replaceFieldValue()
	{
		return this.GetValue(TableUtils.repair_replaceColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_replace field.
	/// </summary>
	public void Setrepair_replaceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_replaceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_replace field.
	/// </summary>
	public void Setrepair_replaceFieldValue(string val)
	{
		this.SetString(val, TableUtils.repair_replaceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_replace field.
	/// </summary>
	public void Setrepair_replaceFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_replaceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODeptIDNew field.
	/// </summary>
	public ColumnValue GetRODeptIDNewValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.RODeptIDNew field.
	/// </summary>
	public Int32 GetRODeptIDNewFieldValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_subtotal field.
	/// </summary>
	public ColumnValue Getro_subtotalValue()
	{
		return this.GetValue(TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_subtotal field.
	/// </summary>
	public Decimal Getro_subtotalFieldValue()
	{
		return this.GetValue(TableUtils.ro_subtotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_grandntotal_nodisc field.
	/// </summary>
	public ColumnValue Getro_grandntotal_nodiscValue()
	{
		return this.GetValue(TableUtils.ro_grandntotal_nodiscColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_grandntotal_nodisc field.
	/// </summary>
	public Decimal Getro_grandntotal_nodiscFieldValue()
	{
		return this.GetValue(TableUtils.ro_grandntotal_nodiscColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_grandtotal_nodisc field.
	/// </summary>
	public ColumnValue Getro_grandtotal_nodiscValue()
	{
		return this.GetValue(TableUtils.ro_grandtotal_nodiscColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_grandtotal_nodisc field.
	/// </summary>
	public Decimal Getro_grandtotal_nodiscFieldValue()
	{
		return this.GetValue(TableUtils.ro_grandtotal_nodiscColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_grandtotal_nodisc field.
	/// </summary>
	public void Setro_grandtotal_nodiscFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ro_grandtotal_nodiscColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_grandtotal_nodisc field.
	/// </summary>
	public void Setro_grandtotal_nodiscFieldValue(string val)
	{
		this.SetString(val, TableUtils.ro_grandtotal_nodiscColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_grandtotal_nodisc field.
	/// </summary>
	public void Setro_grandtotal_nodiscFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_grandtotal_nodiscColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_grandtotal_nodisc field.
	/// </summary>
	public void Setro_grandtotal_nodiscFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_grandtotal_nodiscColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_grandtotal_nodisc field.
	/// </summary>
	public void Setro_grandtotal_nodiscFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_grandtotal_nodiscColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.test field.
	/// </summary>
	public ColumnValue GettestValue()
	{
		return this.GetValue(TableUtils.testColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.test field.
	/// </summary>
	public bool GettestFieldValue()
	{
		return this.GetValue(TableUtils.testColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.test field.
	/// </summary>
	public void SettestFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.testColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.test field.
	/// </summary>
	public void SettestFieldValue(string val)
	{
		this.SetString(val, TableUtils.testColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.test field.
	/// </summary>
	public void SettestFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.testColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_partstotal_calc field.
	/// </summary>
	public ColumnValue Getro_partstotal_calcValue()
	{
		return this.GetValue(TableUtils.ro_partstotal_calcColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_partstotal_calc field.
	/// </summary>
	public Decimal Getro_partstotal_calcFieldValue()
	{
		return this.GetValue(TableUtils.ro_partstotal_calcColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_labortotal_calc field.
	/// </summary>
	public ColumnValue Getro_labortotal_calcValue()
	{
		return this.GetValue(TableUtils.ro_labortotal_calcColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.ro_labortotal_calc field.
	/// </summary>
	public Decimal Getro_labortotal_calcFieldValue()
	{
		return this.GetValue(TableUtils.ro_labortotal_calcColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.new_discountamt field.
	/// </summary>
	public ColumnValue Getnew_discountamtValue()
	{
		return this.GetValue(TableUtils.new_discountamtColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.new_discountamt field.
	/// </summary>
	public Decimal Getnew_discountamtFieldValue()
	{
		return this.GetValue(TableUtils.new_discountamtColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.roDiscountDollar field.
	/// </summary>
	public ColumnValue GetroDiscountDollarValue()
	{
		return this.GetValue(TableUtils.roDiscountDollarColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.roDiscountDollar field.
	/// </summary>
	public Decimal GetroDiscountDollarFieldValue()
	{
		return this.GetValue(TableUtils.roDiscountDollarColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.roDiscountDollar field.
	/// </summary>
	public void SetroDiscountDollarFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.roDiscountDollarColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.roDiscountDollar field.
	/// </summary>
	public void SetroDiscountDollarFieldValue(string val)
	{
		this.SetString(val, TableUtils.roDiscountDollarColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.roDiscountDollar field.
	/// </summary>
	public void SetroDiscountDollarFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.roDiscountDollarColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.roDiscountDollar field.
	/// </summary>
	public void SetroDiscountDollarFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.roDiscountDollarColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.roDiscountDollar field.
	/// </summary>
	public void SetroDiscountDollarFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.roDiscountDollarColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.FaultDesc field.
	/// </summary>
	public ColumnValue GetFaultDescValue()
	{
		return this.GetValue(TableUtils.FaultDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.FaultDesc field.
	/// </summary>
	public string GetFaultDescFieldValue()
	{
		return this.GetValue(TableUtils.FaultDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.corporate_name field.
	/// </summary>
	public ColumnValue Getcorporate_nameValue()
	{
		return this.GetValue(TableUtils.corporate_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.corporate_name field.
	/// </summary>
	public string Getcorporate_nameFieldValue()
	{
		return this.GetValue(TableUtils.corporate_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.SignatureImage field.
	/// </summary>
	public ColumnValue GetSignatureImageValue()
	{
		return this.GetValue(TableUtils.SignatureImageColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.SignatureImage field.
	/// </summary>
	public byte[] GetSignatureImageFieldValue()
	{
		return this.GetValue(TableUtils.SignatureImageColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.SignatureImage field.
	/// </summary>
	public void SetSignatureImageFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SignatureImageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.SignatureImage field.
	/// </summary>
	public void SetSignatureImageFieldValue(string val)
	{
		this.SetString(val, TableUtils.SignatureImageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.SignatureImage field.
	/// </summary>
	public void SetSignatureImageFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SignatureImageColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.signature_datetime field.
	/// </summary>
	public ColumnValue Getsignature_datetimeValue()
	{
		return this.GetValue(TableUtils.signature_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.signature_datetime field.
	/// </summary>
	public DateTime Getsignature_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.signature_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.signature_datetime field.
	/// </summary>
	public void Setsignature_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.signature_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.signature_datetime field.
	/// </summary>
	public void Setsignature_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.signature_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.signature_datetime field.
	/// </summary>
	public void Setsignature_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.signature_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.loaner_required field.
	/// </summary>
	public ColumnValue Getloaner_requiredValue()
	{
		return this.GetValue(TableUtils.loaner_requiredColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.loaner_required field.
	/// </summary>
	public bool Getloaner_requiredFieldValue()
	{
		return this.GetValue(TableUtils.loaner_requiredColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.loaner_required field.
	/// </summary>
	public void Setloaner_requiredFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.loaner_requiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.loaner_required field.
	/// </summary>
	public void Setloaner_requiredFieldValue(string val)
	{
		this.SetString(val, TableUtils.loaner_requiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.loaner_required field.
	/// </summary>
	public void Setloaner_requiredFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.loaner_requiredColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.label_required field.
	/// </summary>
	public ColumnValue Getlabel_requiredValue()
	{
		return this.GetValue(TableUtils.label_requiredColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.label_required field.
	/// </summary>
	public bool Getlabel_requiredFieldValue()
	{
		return this.GetValue(TableUtils.label_requiredColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.label_required field.
	/// </summary>
	public void Setlabel_requiredFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.label_requiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.label_required field.
	/// </summary>
	public void Setlabel_requiredFieldValue(string val)
	{
		this.SetString(val, TableUtils.label_requiredColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.label_required field.
	/// </summary>
	public void Setlabel_requiredFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.label_requiredColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.customer_name field.
	/// </summary>
	public ColumnValue Getcustomer_nameValue()
	{
		return this.GetValue(TableUtils.customer_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.customer_name field.
	/// </summary>
	public string Getcustomer_nameFieldValue()
	{
		return this.GetValue(TableUtils.customer_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.approver_email field.
	/// </summary>
	public ColumnValue Getapprover_emailValue()
	{
		return this.GetValue(TableUtils.approver_emailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.approver_email field.
	/// </summary>
	public string Getapprover_emailFieldValue()
	{
		return this.GetValue(TableUtils.approver_emailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.serial_encrypt field.
	/// </summary>
	public ColumnValue Getserial_encryptValue()
	{
		return this.GetValue(TableUtils.serial_encryptColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.serial_encrypt field.
	/// </summary>
	public string Getserial_encryptFieldValue()
	{
		return this.GetValue(TableUtils.serial_encryptColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.serial_encrypt field.
	/// </summary>
	public void Setserial_encryptFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_encryptColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.serial_encrypt field.
	/// </summary>
	public void Setserial_encryptFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_encryptColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.customer_encrypt field.
	/// </summary>
	public ColumnValue Getcustomer_encryptValue()
	{
		return this.GetValue(TableUtils.customer_encryptColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrders_.customer_encrypt field.
	/// </summary>
	public string Getcustomer_encryptFieldValue()
	{
		return this.GetValue(TableUtils.customer_encryptColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.customer_encrypt field.
	/// </summary>
	public void Setcustomer_encryptFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_encryptColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.customer_encrypt field.
	/// </summary>
	public void Setcustomer_encryptFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_encryptColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.Link field.
	/// </summary>
	public Byte Link
	{
		get
		{
			return this.GetValue(TableUtils.LinkColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LinkColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LinkSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LinkColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.Link field.
	/// </summary>
	public string LinkDefault
	{
		get
		{
			return TableUtils.LinkColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory0 field.
	/// </summary>
	public bool ROAccessory0
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory0Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory0Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory0 field.
	/// </summary>
	public string ROAccessory0Default
	{
		get
		{
			return TableUtils.ROAccessory0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory1 field.
	/// </summary>
	public bool ROAccessory1
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory1Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory1Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory1 field.
	/// </summary>
	public string ROAccessory1Default
	{
		get
		{
			return TableUtils.ROAccessory1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory10 field.
	/// </summary>
	public bool ROAccessory10
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory10Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory10Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory10Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory10Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory10 field.
	/// </summary>
	public string ROAccessory10Default
	{
		get
		{
			return TableUtils.ROAccessory10Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory11 field.
	/// </summary>
	public bool ROAccessory11
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory11Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory11Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory11Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory11Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory11 field.
	/// </summary>
	public string ROAccessory11Default
	{
		get
		{
			return TableUtils.ROAccessory11Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory12 field.
	/// </summary>
	public bool ROAccessory12
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory12Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory12Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory12Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory12Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory12 field.
	/// </summary>
	public string ROAccessory12Default
	{
		get
		{
			return TableUtils.ROAccessory12Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory13 field.
	/// </summary>
	public bool ROAccessory13
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory13Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory13Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory13Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory13Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory13 field.
	/// </summary>
	public string ROAccessory13Default
	{
		get
		{
			return TableUtils.ROAccessory13Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory14 field.
	/// </summary>
	public bool ROAccessory14
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory14Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory14Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory14Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory14Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory14 field.
	/// </summary>
	public string ROAccessory14Default
	{
		get
		{
			return TableUtils.ROAccessory14Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory15 field.
	/// </summary>
	public bool ROAccessory15
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory15Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory15Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory15Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory15Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory15 field.
	/// </summary>
	public string ROAccessory15Default
	{
		get
		{
			return TableUtils.ROAccessory15Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory2 field.
	/// </summary>
	public bool ROAccessory2
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory2Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory2Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory2 field.
	/// </summary>
	public string ROAccessory2Default
	{
		get
		{
			return TableUtils.ROAccessory2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory3 field.
	/// </summary>
	public bool ROAccessory3
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory3Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory3Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory3 field.
	/// </summary>
	public string ROAccessory3Default
	{
		get
		{
			return TableUtils.ROAccessory3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory4 field.
	/// </summary>
	public bool ROAccessory4
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory4Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory4Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory4 field.
	/// </summary>
	public string ROAccessory4Default
	{
		get
		{
			return TableUtils.ROAccessory4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory5 field.
	/// </summary>
	public bool ROAccessory5
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory5Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory5Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory5Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory5Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory5 field.
	/// </summary>
	public string ROAccessory5Default
	{
		get
		{
			return TableUtils.ROAccessory5Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory6 field.
	/// </summary>
	public bool ROAccessory6
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory6Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory6Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory6Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory6Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory6 field.
	/// </summary>
	public string ROAccessory6Default
	{
		get
		{
			return TableUtils.ROAccessory6Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory7 field.
	/// </summary>
	public bool ROAccessory7
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory7Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory7Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory7Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory7Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory7 field.
	/// </summary>
	public string ROAccessory7Default
	{
		get
		{
			return TableUtils.ROAccessory7Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory8 field.
	/// </summary>
	public bool ROAccessory8
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory8Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory8Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory8Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory8Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory8 field.
	/// </summary>
	public string ROAccessory8Default
	{
		get
		{
			return TableUtils.ROAccessory8Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAccessory9 field.
	/// </summary>
	public bool ROAccessory9
	{
		get
		{
			return this.GetValue(TableUtils.ROAccessory9Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAccessory9Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAccessory9Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAccessory9Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAccessory9 field.
	/// </summary>
	public string ROAccessory9Default
	{
		get
		{
			return TableUtils.ROAccessory9Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAddress1 field.
	/// </summary>
	public string ROAddress1
	{
		get
		{
			return this.GetValue(TableUtils.ROAddress1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROAddress1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAddress1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAddress1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAddress1 field.
	/// </summary>
	public string ROAddress1Default
	{
		get
		{
			return TableUtils.ROAddress1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAddress2 field.
	/// </summary>
	public string ROAddress2
	{
		get
		{
			return this.GetValue(TableUtils.ROAddress2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROAddress2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAddress2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAddress2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAddress2 field.
	/// </summary>
	public string ROAddress2Default
	{
		get
		{
			return TableUtils.ROAddress2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAdvertising field.
	/// </summary>
	public string ROAdvertising
	{
		get
		{
			return this.GetValue(TableUtils.ROAdvertisingColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROAdvertisingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAdvertisingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAdvertisingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAdvertising field.
	/// </summary>
	public string ROAdvertisingDefault
	{
		get
		{
			return TableUtils.ROAdvertisingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAmountPaid field.
	/// </summary>
	public Decimal ROAmountPaid
	{
		get
		{
			return this.GetValue(TableUtils.ROAmountPaidColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROAmountPaidColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAmountPaidSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAmountPaidColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAmountPaid field.
	/// </summary>
	public string ROAmountPaidDefault
	{
		get
		{
			return TableUtils.ROAmountPaidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROAutoCalc field.
	/// </summary>
	public bool ROAutoCalc
	{
		get
		{
			return this.GetValue(TableUtils.ROAutoCalcColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROAutoCalcColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROAutoCalcSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROAutoCalcColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROAutoCalc field.
	/// </summary>
	public string ROAutoCalcDefault
	{
		get
		{
			return TableUtils.ROAutoCalcColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROBatchID field.
	/// </summary>
	public string ROBatchID
	{
		get
		{
			return this.GetValue(TableUtils.ROBatchIDColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROBatchIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROBatchIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROBatchIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBatchID field.
	/// </summary>
	public string ROBatchIDDefault
	{
		get
		{
			return TableUtils.ROBatchIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROBillingNo field.
	/// </summary>
	public Int32 ROBillingNo
	{
		get
		{
			return this.GetValue(TableUtils.ROBillingNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROBillingNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROBillingNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROBillingNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBillingNo field.
	/// </summary>
	public string ROBillingNoDefault
	{
		get
		{
			return TableUtils.ROBillingNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROBin field.
	/// </summary>
	public string ROBin
	{
		get
		{
			return this.GetValue(TableUtils.ROBinColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROBinColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROBinSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROBinColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROBin field.
	/// </summary>
	public string ROBinDefault
	{
		get
		{
			return TableUtils.ROBinColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROCategory field.
	/// </summary>
	public string ROCategory
	{
		get
		{
			return this.GetValue(TableUtils.ROCategoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCategoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCategorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCategoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCategory field.
	/// </summary>
	public string ROCategoryDefault
	{
		get
		{
			return TableUtils.ROCategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROChanges field.
	/// </summary>
	public string ROChanges
	{
		get
		{
			return this.GetValue(TableUtils.ROChangesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROChangesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROChangesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROChangesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROChanges field.
	/// </summary>
	public string ROChangesDefault
	{
		get
		{
			return TableUtils.ROChangesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROCity field.
	/// </summary>
	public string ROCity
	{
		get
		{
			return this.GetValue(TableUtils.ROCityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCity field.
	/// </summary>
	public string ROCityDefault
	{
		get
		{
			return TableUtils.ROCityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROCondition field.
	/// </summary>
	public string ROCondition
	{
		get
		{
			return this.GetValue(TableUtils.ROConditionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROConditionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROConditionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROConditionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCondition field.
	/// </summary>
	public string ROConditionDefault
	{
		get
		{
			return TableUtils.ROConditionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROContactName field.
	/// </summary>
	public string ROContactName
	{
		get
		{
			return this.GetValue(TableUtils.ROContactNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROContactNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROContactNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROContactNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROContactName field.
	/// </summary>
	public string ROContactNameDefault
	{
		get
		{
			return TableUtils.ROContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROCountry field.
	/// </summary>
	public string ROCountry
	{
		get
		{
			return this.GetValue(TableUtils.ROCountryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCountryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCountrySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCountryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCountry field.
	/// </summary>
	public string ROCountryDefault
	{
		get
		{
			return TableUtils.ROCountryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROCustName field.
	/// </summary>
	public string ROCustName
	{
		get
		{
			return this.GetValue(TableUtils.ROCustNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCustNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCustNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCustNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustName field.
	/// </summary>
	public string ROCustNameDefault
	{
		get
		{
			return TableUtils.ROCustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROCustNo field.
	/// </summary>
	public Int32 ROCustNo
	{
		get
		{
			return this.GetValue(TableUtils.ROCustNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCustNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCustNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCustNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustNo field.
	/// </summary>
	public string ROCustNoDefault
	{
		get
		{
			return TableUtils.ROCustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROCustom1 field.
	/// </summary>
	public string ROCustom1
	{
		get
		{
			return this.GetValue(TableUtils.ROCustom1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCustom1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCustom1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCustom1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustom1 field.
	/// </summary>
	public string ROCustom1Default
	{
		get
		{
			return TableUtils.ROCustom1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROCustom2 field.
	/// </summary>
	public string ROCustom2
	{
		get
		{
			return this.GetValue(TableUtils.ROCustom2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCustom2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCustom2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCustom2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustom2 field.
	/// </summary>
	public string ROCustom2Default
	{
		get
		{
			return TableUtils.ROCustom2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROCustomExported field.
	/// </summary>
	public Byte ROCustomExported
	{
		get
		{
			return this.GetValue(TableUtils.ROCustomExportedColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROCustomExportedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROCustomExportedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROCustomExportedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROCustomExported field.
	/// </summary>
	public string ROCustomExportedDefault
	{
		get
		{
			return TableUtils.ROCustomExportedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODate field.
	/// </summary>
	public DateTime RODate
	{
		get
		{
			return this.GetValue(TableUtils.RODateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODate field.
	/// </summary>
	public string RODateDefault
	{
		get
		{
			return TableUtils.RODateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateEstimateApproved field.
	/// </summary>
	public DateTime RODateEstimateApproved
	{
		get
		{
			return this.GetValue(TableUtils.RODateEstimateApprovedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateEstimateApprovedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateEstimateApprovedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateEstimateApprovedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateApproved field.
	/// </summary>
	public string RODateEstimateApprovedDefault
	{
		get
		{
			return TableUtils.RODateEstimateApprovedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateEstimateCompleted field.
	/// </summary>
	public DateTime RODateEstimateCompleted
	{
		get
		{
			return this.GetValue(TableUtils.RODateEstimateCompletedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateEstimateCompletedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateEstimateCompletedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateEstimateCompletedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateCompleted field.
	/// </summary>
	public string RODateEstimateCompletedDefault
	{
		get
		{
			return TableUtils.RODateEstimateCompletedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateEstimatedCompletion field.
	/// </summary>
	public DateTime RODateEstimatedCompletion
	{
		get
		{
			return this.GetValue(TableUtils.RODateEstimatedCompletionColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateEstimatedCompletionColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateEstimatedCompletionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateEstimatedCompletionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimatedCompletion field.
	/// </summary>
	public string RODateEstimatedCompletionDefault
	{
		get
		{
			return TableUtils.RODateEstimatedCompletionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateEstimateRefused field.
	/// </summary>
	public DateTime RODateEstimateRefused
	{
		get
		{
			return this.GetValue(TableUtils.RODateEstimateRefusedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateEstimateRefusedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateEstimateRefusedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateEstimateRefusedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateRefused field.
	/// </summary>
	public string RODateEstimateRefusedDefault
	{
		get
		{
			return TableUtils.RODateEstimateRefusedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateEstimateSent field.
	/// </summary>
	public DateTime RODateEstimateSent
	{
		get
		{
			return this.GetValue(TableUtils.RODateEstimateSentColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateEstimateSentColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateEstimateSentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateEstimateSentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateEstimateSent field.
	/// </summary>
	public string RODateEstimateSentDefault
	{
		get
		{
			return TableUtils.RODateEstimateSentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODatePaid field.
	/// </summary>
	public DateTime RODatePaid
	{
		get
		{
			return this.GetValue(TableUtils.RODatePaidColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODatePaidColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODatePaidSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODatePaidColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODatePaid field.
	/// </summary>
	public string RODatePaidDefault
	{
		get
		{
			return TableUtils.RODatePaidColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODatePurchased field.
	/// </summary>
	public DateTime RODatePurchased
	{
		get
		{
			return this.GetValue(TableUtils.RODatePurchasedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODatePurchasedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODatePurchasedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODatePurchasedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODatePurchased field.
	/// </summary>
	public string RODatePurchasedDefault
	{
		get
		{
			return TableUtils.RODatePurchasedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateReceivedFromVendor field.
	/// </summary>
	public DateTime RODateReceivedFromVendor
	{
		get
		{
			return this.GetValue(TableUtils.RODateReceivedFromVendorColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateReceivedFromVendorColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateReceivedFromVendorSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateReceivedFromVendorColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateReceivedFromVendor field.
	/// </summary>
	public string RODateReceivedFromVendorDefault
	{
		get
		{
			return TableUtils.RODateReceivedFromVendorColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateRecordAdded field.
	/// </summary>
	public DateTime RODateRecordAdded
	{
		get
		{
			return this.GetValue(TableUtils.RODateRecordAddedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateRecordAddedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateRecordAddedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateRecordAddedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRecordAdded field.
	/// </summary>
	public string RODateRecordAddedDefault
	{
		get
		{
			return TableUtils.RODateRecordAddedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateRecordUpdated field.
	/// </summary>
	public DateTime RODateRecordUpdated
	{
		get
		{
			return this.GetValue(TableUtils.RODateRecordUpdatedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateRecordUpdatedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateRecordUpdatedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateRecordUpdatedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRecordUpdated field.
	/// </summary>
	public string RODateRecordUpdatedDefault
	{
		get
		{
			return TableUtils.RODateRecordUpdatedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateRepairCompleted field.
	/// </summary>
	public DateTime RODateRepairCompleted
	{
		get
		{
			return this.GetValue(TableUtils.RODateRepairCompletedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateRepairCompletedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateRepairCompletedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateRepairCompletedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRepairCompleted field.
	/// </summary>
	public string RODateRepairCompletedDefault
	{
		get
		{
			return TableUtils.RODateRepairCompletedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateRequestedFor field.
	/// </summary>
	public DateTime RODateRequestedFor
	{
		get
		{
			return this.GetValue(TableUtils.RODateRequestedForColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateRequestedForColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateRequestedForSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateRequestedForColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateRequestedFor field.
	/// </summary>
	public string RODateRequestedForDefault
	{
		get
		{
			return TableUtils.RODateRequestedForColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateReturned field.
	/// </summary>
	public DateTime RODateReturned
	{
		get
		{
			return this.GetValue(TableUtils.RODateReturnedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateReturnedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateReturnedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateReturnedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateReturned field.
	/// </summary>
	public string RODateReturnedDefault
	{
		get
		{
			return TableUtils.RODateReturnedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateStatusUpdated field.
	/// </summary>
	public DateTime RODateStatusUpdated
	{
		get
		{
			return this.GetValue(TableUtils.RODateStatusUpdatedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateStatusUpdatedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateStatusUpdatedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateStatusUpdatedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateStatusUpdated field.
	/// </summary>
	public string RODateStatusUpdatedDefault
	{
		get
		{
			return TableUtils.RODateStatusUpdatedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODateSubcontracted field.
	/// </summary>
	public DateTime RODateSubcontracted
	{
		get
		{
			return this.GetValue(TableUtils.RODateSubcontractedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODateSubcontractedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODateSubcontractedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODateSubcontractedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODateSubcontracted field.
	/// </summary>
	public string RODateSubcontractedDefault
	{
		get
		{
			return TableUtils.RODateSubcontractedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODesc field.
	/// </summary>
	public string RODesc
	{
		get
		{
			return this.GetValue(TableUtils.RODescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODesc field.
	/// </summary>
	public string RODescDefault
	{
		get
		{
			return TableUtils.RODescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODiscHandling field.
	/// </summary>
	public bool RODiscHandling
	{
		get
		{
			return this.GetValue(TableUtils.RODiscHandlingColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.RODiscHandlingColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODiscHandlingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODiscHandlingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscHandling field.
	/// </summary>
	public string RODiscHandlingDefault
	{
		get
		{
			return TableUtils.RODiscHandlingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODiscLabor field.
	/// </summary>
	public bool RODiscLabor
	{
		get
		{
			return this.GetValue(TableUtils.RODiscLaborColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.RODiscLaborColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODiscLaborSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODiscLaborColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscLabor field.
	/// </summary>
	public string RODiscLaborDefault
	{
		get
		{
			return TableUtils.RODiscLaborColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODiscount field.
	/// </summary>
	public Decimal RODiscount
	{
		get
		{
			return this.GetValue(TableUtils.RODiscountColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODiscountColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODiscountSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODiscountColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscount field.
	/// </summary>
	public string RODiscountDefault
	{
		get
		{
			return TableUtils.RODiscountColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODiscountRate field.
	/// </summary>
	public Single RODiscountRate
	{
		get
		{
			return this.GetValue(TableUtils.RODiscountRateColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODiscountRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODiscountRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODiscountRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscountRate field.
	/// </summary>
	public string RODiscountRateDefault
	{
		get
		{
			return TableUtils.RODiscountRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODiscParts field.
	/// </summary>
	public bool RODiscParts
	{
		get
		{
			return this.GetValue(TableUtils.RODiscPartsColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.RODiscPartsColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODiscPartsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODiscPartsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscParts field.
	/// </summary>
	public string RODiscPartsDefault
	{
		get
		{
			return TableUtils.RODiscPartsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODiscShipping field.
	/// </summary>
	public bool RODiscShipping
	{
		get
		{
			return this.GetValue(TableUtils.RODiscShippingColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.RODiscShippingColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODiscShippingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODiscShippingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscShipping field.
	/// </summary>
	public string RODiscShippingDefault
	{
		get
		{
			return TableUtils.RODiscShippingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODiscTravel field.
	/// </summary>
	public bool RODiscTravel
	{
		get
		{
			return this.GetValue(TableUtils.RODiscTravelColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.RODiscTravelColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODiscTravelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODiscTravelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODiscTravel field.
	/// </summary>
	public string RODiscTravelDefault
	{
		get
		{
			return TableUtils.RODiscTravelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROEditLock field.
	/// </summary>
	public Byte ROEditLock
	{
		get
		{
			return this.GetValue(TableUtils.ROEditLockColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROEditLockColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROEditLockSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROEditLockColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEditLock field.
	/// </summary>
	public string ROEditLockDefault
	{
		get
		{
			return TableUtils.ROEditLockColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROEmail field.
	/// </summary>
	public string ROEmail
	{
		get
		{
			return this.GetValue(TableUtils.ROEmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROEmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROEmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROEmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEmail field.
	/// </summary>
	public string ROEmailDefault
	{
		get
		{
			return TableUtils.ROEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROEstimatedBy field.
	/// </summary>
	public string ROEstimatedBy
	{
		get
		{
			return this.GetValue(TableUtils.ROEstimatedByColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROEstimatedByColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROEstimatedBySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROEstimatedByColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEstimatedBy field.
	/// </summary>
	public string ROEstimatedByDefault
	{
		get
		{
			return TableUtils.ROEstimatedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROEstimateRequired field.
	/// </summary>
	public Byte ROEstimateRequired
	{
		get
		{
			return this.GetValue(TableUtils.ROEstimateRequiredColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROEstimateRequiredColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROEstimateRequiredSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROEstimateRequiredColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROEstimateRequired field.
	/// </summary>
	public string ROEstimateRequiredDefault
	{
		get
		{
			return TableUtils.ROEstimateRequiredColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROExported field.
	/// </summary>
	public DateTime ROExported
	{
		get
		{
			return this.GetValue(TableUtils.ROExportedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROExportedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROExportedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROExportedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExported field.
	/// </summary>
	public string ROExportedDefault
	{
		get
		{
			return TableUtils.ROExportedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROExportInclude field.
	/// </summary>
	public bool ROExportInclude
	{
		get
		{
			return this.GetValue(TableUtils.ROExportIncludeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROExportIncludeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROExportIncludeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROExportIncludeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportInclude field.
	/// </summary>
	public string ROExportIncludeDefault
	{
		get
		{
			return TableUtils.ROExportIncludeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROExportRecordChanged field.
	/// </summary>
	public bool ROExportRecordChanged
	{
		get
		{
			return this.GetValue(TableUtils.ROExportRecordChangedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROExportRecordChangedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROExportRecordChangedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROExportRecordChangedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportRecordChanged field.
	/// </summary>
	public string ROExportRecordChangedDefault
	{
		get
		{
			return TableUtils.ROExportRecordChangedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROExportStatusChanged field.
	/// </summary>
	public bool ROExportStatusChanged
	{
		get
		{
			return this.GetValue(TableUtils.ROExportStatusChangedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROExportStatusChangedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROExportStatusChangedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROExportStatusChangedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROExportStatusChanged field.
	/// </summary>
	public string ROExportStatusChangedDefault
	{
		get
		{
			return TableUtils.ROExportStatusChangedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROFaultCodes field.
	/// </summary>
	public string ROFaultCodes
	{
		get
		{
			return this.GetValue(TableUtils.ROFaultCodesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROFaultCodesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROFaultCodesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROFaultCodesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROFaultCodes field.
	/// </summary>
	public string ROFaultCodesDefault
	{
		get
		{
			return TableUtils.ROFaultCodesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROFax field.
	/// </summary>
	public string ROFax
	{
		get
		{
			return this.GetValue(TableUtils.ROFaxColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROFaxColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROFaxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROFaxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROFax field.
	/// </summary>
	public string ROFaxDefault
	{
		get
		{
			return TableUtils.ROFaxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROGrandTotal field.
	/// </summary>
	public Decimal ROGrandTotal
	{
		get
		{
			return this.GetValue(TableUtils.ROGrandTotalColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROGrandTotalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROGrandTotalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROGrandTotalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROGrandTotal field.
	/// </summary>
	public string ROGrandTotalDefault
	{
		get
		{
			return TableUtils.ROGrandTotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROHandling field.
	/// </summary>
	public Decimal ROHandling
	{
		get
		{
			return this.GetValue(TableUtils.ROHandlingColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROHandlingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROHandlingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROHandlingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandling field.
	/// </summary>
	public string ROHandlingDefault
	{
		get
		{
			return TableUtils.ROHandlingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROHandlingCost field.
	/// </summary>
	public Decimal ROHandlingCost
	{
		get
		{
			return this.GetValue(TableUtils.ROHandlingCostColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROHandlingCostColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROHandlingCostSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROHandlingCostColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHandlingCost field.
	/// </summary>
	public string ROHandlingCostDefault
	{
		get
		{
			return TableUtils.ROHandlingCostColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROHours field.
	/// </summary>
	public Single ROHours
	{
		get
		{
			return this.GetValue(TableUtils.ROHoursColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROHoursColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROHoursSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROHoursColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHours field.
	/// </summary>
	public string ROHoursDefault
	{
		get
		{
			return TableUtils.ROHoursColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROHowApproved field.
	/// </summary>
	public string ROHowApproved
	{
		get
		{
			return this.GetValue(TableUtils.ROHowApprovedColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROHowApprovedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROHowApprovedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROHowApprovedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROHowApproved field.
	/// </summary>
	public string ROHowApprovedDefault
	{
		get
		{
			return TableUtils.ROHowApprovedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROInvDate field.
	/// </summary>
	public DateTime ROInvDate
	{
		get
		{
			return this.GetValue(TableUtils.ROInvDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROInvDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROInvDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROInvDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvDate field.
	/// </summary>
	public string ROInvDateDefault
	{
		get
		{
			return TableUtils.ROInvDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROInvNo field.
	/// </summary>
	public Int32 ROInvNo
	{
		get
		{
			return this.GetValue(TableUtils.ROInvNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROInvNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROInvNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROInvNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROInvNo field.
	/// </summary>
	public string ROInvNoDefault
	{
		get
		{
			return TableUtils.ROInvNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROLabor field.
	/// </summary>
	public Decimal ROLabor
	{
		get
		{
			return this.GetValue(TableUtils.ROLaborColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROLaborColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROLaborSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROLaborColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLabor field.
	/// </summary>
	public string ROLaborDefault
	{
		get
		{
			return TableUtils.ROLaborColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROLaborCost field.
	/// </summary>
	public Decimal ROLaborCost
	{
		get
		{
			return this.GetValue(TableUtils.ROLaborCostColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROLaborCostColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROLaborCostSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROLaborCostColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLaborCost field.
	/// </summary>
	public string ROLaborCostDefault
	{
		get
		{
			return TableUtils.ROLaborCostColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROLinkedRONo field.
	/// </summary>
	public Int32 ROLinkedRONo
	{
		get
		{
			return this.GetValue(TableUtils.ROLinkedRONoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROLinkedRONoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROLinkedRONoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROLinkedRONoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLinkedRONo field.
	/// </summary>
	public string ROLinkedRONoDefault
	{
		get
		{
			return TableUtils.ROLinkedRONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROLocationBus field.
	/// </summary>
	public Int32 ROLocationBus
	{
		get
		{
			return this.GetValue(TableUtils.ROLocationBusColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROLocationBusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROLocationBusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROLocationBusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROLocationBus field.
	/// </summary>
	public string ROLocationBusDefault
	{
		get
		{
			return TableUtils.ROLocationBusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROMake field.
	/// </summary>
	public string ROMake
	{
		get
		{
			return this.GetValue(TableUtils.ROMakeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROMakeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROMakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROMakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROMake field.
	/// </summary>
	public string ROMakeDefault
	{
		get
		{
			return TableUtils.ROMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROMarkupRate field.
	/// </summary>
	public Single ROMarkupRate
	{
		get
		{
			return this.GetValue(TableUtils.ROMarkupRateColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROMarkupRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROMarkupRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROMarkupRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROMarkupRate field.
	/// </summary>
	public string ROMarkupRateDefault
	{
		get
		{
			return TableUtils.ROMarkupRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROModel field.
	/// </summary>
	public string ROModel
	{
		get
		{
			return this.GetValue(TableUtils.ROModelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROModelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROModelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROModelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROModel field.
	/// </summary>
	public string ROModelDefault
	{
		get
		{
			return TableUtils.ROModelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RONo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RONo field.
	/// </summary>
	public string RONoDefault
	{
		get
		{
			return TableUtils.RONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROParts field.
	/// </summary>
	public Decimal ROParts
	{
		get
		{
			return this.GetValue(TableUtils.ROPartsColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPartsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPartsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPartsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROParts field.
	/// </summary>
	public string ROPartsDefault
	{
		get
		{
			return TableUtils.ROPartsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPartsCost field.
	/// </summary>
	public Decimal ROPartsCost
	{
		get
		{
			return this.GetValue(TableUtils.ROPartsCostColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPartsCostColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPartsCostSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPartsCostColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPartsCost field.
	/// </summary>
	public string ROPartsCostDefault
	{
		get
		{
			return TableUtils.ROPartsCostColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPayMethod field.
	/// </summary>
	public Byte ROPayMethod
	{
		get
		{
			return this.GetValue(TableUtils.ROPayMethodColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPayMethodColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPayMethodSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPayMethodColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayMethod field.
	/// </summary>
	public string ROPayMethodDefault
	{
		get
		{
			return TableUtils.ROPayMethodColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPayTerms field.
	/// </summary>
	public Byte ROPayTerms
	{
		get
		{
			return this.GetValue(TableUtils.ROPayTermsColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPayTermsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPayTermsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPayTermsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPayTerms field.
	/// </summary>
	public string ROPayTermsDefault
	{
		get
		{
			return TableUtils.ROPayTermsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPhoneBusiness field.
	/// </summary>
	public string ROPhoneBusiness
	{
		get
		{
			return this.GetValue(TableUtils.ROPhoneBusinessColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPhoneBusinessColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPhoneBusinessSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPhoneBusinessColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPhoneBusiness field.
	/// </summary>
	public string ROPhoneBusinessDefault
	{
		get
		{
			return TableUtils.ROPhoneBusinessColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPhoneHome field.
	/// </summary>
	public string ROPhoneHome
	{
		get
		{
			return this.GetValue(TableUtils.ROPhoneHomeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPhoneHomeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPhoneHomeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPhoneHomeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPhoneHome field.
	/// </summary>
	public string ROPhoneHomeDefault
	{
		get
		{
			return TableUtils.ROPhoneHomeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPhoneMobile field.
	/// </summary>
	public string ROPhoneMobile
	{
		get
		{
			return this.GetValue(TableUtils.ROPhoneMobileColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPhoneMobileColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPhoneMobileSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPhoneMobileColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPhoneMobile field.
	/// </summary>
	public string ROPhoneMobileDefault
	{
		get
		{
			return TableUtils.ROPhoneMobileColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPostalCode field.
	/// </summary>
	public string ROPostalCode
	{
		get
		{
			return this.GetValue(TableUtils.ROPostalCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPostalCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPostalCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPostalCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPostalCode field.
	/// </summary>
	public string ROPostalCodeDefault
	{
		get
		{
			return TableUtils.ROPostalCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPreapproved field.
	/// </summary>
	public Decimal ROPreapproved
	{
		get
		{
			return this.GetValue(TableUtils.ROPreapprovedColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPreapprovedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPreapprovedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPreapprovedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPreapproved field.
	/// </summary>
	public string ROPreapprovedDefault
	{
		get
		{
			return TableUtils.ROPreapprovedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPrintNotes field.
	/// </summary>
	public string ROPrintNotes
	{
		get
		{
			return this.GetValue(TableUtils.ROPrintNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPrintNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPrintNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPrintNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPrintNotes field.
	/// </summary>
	public string ROPrintNotesDefault
	{
		get
		{
			return TableUtils.ROPrintNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPriority field.
	/// </summary>
	public Byte ROPriority
	{
		get
		{
			return this.GetValue(TableUtils.ROPriorityColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPriorityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPrioritySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPriorityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPriority field.
	/// </summary>
	public string ROPriorityDefault
	{
		get
		{
			return TableUtils.ROPriorityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPrivateNotes field.
	/// </summary>
	public string ROPrivateNotes
	{
		get
		{
			return this.GetValue(TableUtils.ROPrivateNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPrivateNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPrivateNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPrivateNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPrivateNotes field.
	/// </summary>
	public string ROPrivateNotesDefault
	{
		get
		{
			return TableUtils.ROPrivateNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROProblem field.
	/// </summary>
	public string ROProblem
	{
		get
		{
			return this.GetValue(TableUtils.ROProblemColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROProblemColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROProblemSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROProblemColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROProblem field.
	/// </summary>
	public string ROProblemDefault
	{
		get
		{
			return TableUtils.ROProblemColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROProvince field.
	/// </summary>
	public string ROProvince
	{
		get
		{
			return this.GetValue(TableUtils.ROProvinceColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROProvinceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROProvinceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROProvinceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROProvince field.
	/// </summary>
	public string ROProvinceDefault
	{
		get
		{
			return TableUtils.ROProvinceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROPurchasedFrom field.
	/// </summary>
	public string ROPurchasedFrom
	{
		get
		{
			return this.GetValue(TableUtils.ROPurchasedFromColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROPurchasedFromColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROPurchasedFromSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROPurchasedFromColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROPurchasedFrom field.
	/// </summary>
	public string ROPurchasedFromDefault
	{
		get
		{
			return TableUtils.ROPurchasedFromColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROQBAltered field.
	/// </summary>
	public bool ROQBAltered
	{
		get
		{
			return this.GetValue(TableUtils.ROQBAlteredColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROQBAlteredColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROQBAlteredSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROQBAlteredColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBAltered field.
	/// </summary>
	public string ROQBAlteredDefault
	{
		get
		{
			return TableUtils.ROQBAlteredColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROQBAlteredPay field.
	/// </summary>
	public bool ROQBAlteredPay
	{
		get
		{
			return this.GetValue(TableUtils.ROQBAlteredPayColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROQBAlteredPayColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROQBAlteredPaySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROQBAlteredPayColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBAlteredPay field.
	/// </summary>
	public string ROQBAlteredPayDefault
	{
		get
		{
			return TableUtils.ROQBAlteredPayColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROQBInvExcluded field.
	/// </summary>
	public bool ROQBInvExcluded
	{
		get
		{
			return this.GetValue(TableUtils.ROQBInvExcludedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROQBInvExcludedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROQBInvExcludedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROQBInvExcludedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBInvExcluded field.
	/// </summary>
	public string ROQBInvExcludedDefault
	{
		get
		{
			return TableUtils.ROQBInvExcludedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROQBInvNo field.
	/// </summary>
	public string ROQBInvNo
	{
		get
		{
			return this.GetValue(TableUtils.ROQBInvNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROQBInvNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROQBInvNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROQBInvNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBInvNo field.
	/// </summary>
	public string ROQBInvNoDefault
	{
		get
		{
			return TableUtils.ROQBInvNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROQBPayDetails field.
	/// </summary>
	public string ROQBPayDetails
	{
		get
		{
			return this.GetValue(TableUtils.ROQBPayDetailsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROQBPayDetailsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROQBPayDetailsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROQBPayDetailsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBPayDetails field.
	/// </summary>
	public string ROQBPayDetailsDefault
	{
		get
		{
			return TableUtils.ROQBPayDetailsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROQBPayExcluded field.
	/// </summary>
	public bool ROQBPayExcluded
	{
		get
		{
			return this.GetValue(TableUtils.ROQBPayExcludedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROQBPayExcludedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROQBPayExcludedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROQBPayExcludedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBPayExcluded field.
	/// </summary>
	public string ROQBPayExcludedDefault
	{
		get
		{
			return TableUtils.ROQBPayExcludedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROQBTxnID field.
	/// </summary>
	public string ROQBTxnID
	{
		get
		{
			return this.GetValue(TableUtils.ROQBTxnIDColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROQBTxnIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROQBTxnIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROQBTxnIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBTxnID field.
	/// </summary>
	public string ROQBTxnIDDefault
	{
		get
		{
			return TableUtils.ROQBTxnIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROQBTxnIDPay field.
	/// </summary>
	public string ROQBTxnIDPay
	{
		get
		{
			return this.GetValue(TableUtils.ROQBTxnIDPayColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROQBTxnIDPayColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROQBTxnIDPaySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROQBTxnIDPayColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROQBTxnIDPay field.
	/// </summary>
	public string ROQBTxnIDPayDefault
	{
		get
		{
			return TableUtils.ROQBTxnIDPayColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROReceivedBy field.
	/// </summary>
	public string ROReceivedBy
	{
		get
		{
			return this.GetValue(TableUtils.ROReceivedByColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROReceivedByColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROReceivedBySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROReceivedByColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReceivedBy field.
	/// </summary>
	public string ROReceivedByDefault
	{
		get
		{
			return TableUtils.ROReceivedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROReEstimate field.
	/// </summary>
	public bool ROReEstimate
	{
		get
		{
			return this.GetValue(TableUtils.ROReEstimateColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROReEstimateColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROReEstimateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROReEstimateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReEstimate field.
	/// </summary>
	public string ROReEstimateDefault
	{
		get
		{
			return TableUtils.ROReEstimateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROReference1 field.
	/// </summary>
	public string ROReference1
	{
		get
		{
			return this.GetValue(TableUtils.ROReference1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROReference1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROReference1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROReference1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference1 field.
	/// </summary>
	public string ROReference1Default
	{
		get
		{
			return TableUtils.ROReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROReference2 field.
	/// </summary>
	public string ROReference2
	{
		get
		{
			return this.GetValue(TableUtils.ROReference2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROReference2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROReference2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROReference2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference2 field.
	/// </summary>
	public string ROReference2Default
	{
		get
		{
			return TableUtils.ROReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROReference3 field.
	/// </summary>
	public string ROReference3
	{
		get
		{
			return this.GetValue(TableUtils.ROReference3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROReference3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROReference3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROReference3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference3 field.
	/// </summary>
	public string ROReference3Default
	{
		get
		{
			return TableUtils.ROReference3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROReference4 field.
	/// </summary>
	public string ROReference4
	{
		get
		{
			return this.GetValue(TableUtils.ROReference4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROReference4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROReference4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROReference4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROReference4 field.
	/// </summary>
	public string ROReference4Default
	{
		get
		{
			return TableUtils.ROReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROSerialNo field.
	/// </summary>
	public string ROSerialNo
	{
		get
		{
			return this.GetValue(TableUtils.ROSerialNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSerialNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSerialNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSerialNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSerialNo field.
	/// </summary>
	public string ROSerialNoDefault
	{
		get
		{
			return TableUtils.ROSerialNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROShipping field.
	/// </summary>
	public Decimal ROShipping
	{
		get
		{
			return this.GetValue(TableUtils.ROShippingColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROShippingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROShippingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROShippingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShipping field.
	/// </summary>
	public string ROShippingDefault
	{
		get
		{
			return TableUtils.ROShippingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROShippingCost field.
	/// </summary>
	public Decimal ROShippingCost
	{
		get
		{
			return this.GetValue(TableUtils.ROShippingCostColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROShippingCostColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROShippingCostSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROShippingCostColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShippingCost field.
	/// </summary>
	public string ROShippingCostDefault
	{
		get
		{
			return TableUtils.ROShippingCostColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROShipVia field.
	/// </summary>
	public string ROShipVia
	{
		get
		{
			return this.GetValue(TableUtils.ROShipViaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROShipViaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROShipViaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROShipViaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROShipVia field.
	/// </summary>
	public string ROShipViaDefault
	{
		get
		{
			return TableUtils.ROShipViaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROStatus field.
	/// </summary>
	public Byte ROStatus
	{
		get
		{
			return this.GetValue(TableUtils.ROStatusColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROStatusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROStatusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROStatusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROStatus field.
	/// </summary>
	public string ROStatusDefault
	{
		get
		{
			return TableUtils.ROStatusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROSubcontracted field.
	/// </summary>
	public bool ROSubcontracted
	{
		get
		{
			return this.GetValue(TableUtils.ROSubcontractedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROSubcontractedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSubcontractedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSubcontractedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontracted field.
	/// </summary>
	public string ROSubcontractedDefault
	{
		get
		{
			return TableUtils.ROSubcontractedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROSubcontractNotes field.
	/// </summary>
	public string ROSubcontractNotes
	{
		get
		{
			return this.GetValue(TableUtils.ROSubcontractNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSubcontractNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSubcontractNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSubcontractNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractNotes field.
	/// </summary>
	public string ROSubcontractNotesDefault
	{
		get
		{
			return TableUtils.ROSubcontractNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROSubcontractReference1 field.
	/// </summary>
	public string ROSubcontractReference1
	{
		get
		{
			return this.GetValue(TableUtils.ROSubcontractReference1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSubcontractReference1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSubcontractReference1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSubcontractReference1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractReference1 field.
	/// </summary>
	public string ROSubcontractReference1Default
	{
		get
		{
			return TableUtils.ROSubcontractReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROSubcontractReference2 field.
	/// </summary>
	public string ROSubcontractReference2
	{
		get
		{
			return this.GetValue(TableUtils.ROSubcontractReference2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSubcontractReference2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSubcontractReference2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSubcontractReference2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractReference2 field.
	/// </summary>
	public string ROSubcontractReference2Default
	{
		get
		{
			return TableUtils.ROSubcontractReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROSubcontractVendNo field.
	/// </summary>
	public Int32 ROSubcontractVendNo
	{
		get
		{
			return this.GetValue(TableUtils.ROSubcontractVendNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROSubcontractVendNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROSubcontractVendNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROSubcontractVendNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROSubcontractVendNo field.
	/// </summary>
	public string ROSubcontractVendNoDefault
	{
		get
		{
			return TableUtils.ROSubcontractVendNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTax1 field.
	/// </summary>
	public Decimal ROTax1
	{
		get
		{
			return this.GetValue(TableUtils.ROTax1Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTax1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTax1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTax1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1 field.
	/// </summary>
	public string ROTax1Default
	{
		get
		{
			return TableUtils.ROTax1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTax1Rate field.
	/// </summary>
	public Single ROTax1Rate
	{
		get
		{
			return this.GetValue(TableUtils.ROTax1RateColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTax1RateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTax1RateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTax1RateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rate field.
	/// </summary>
	public string ROTax1RateDefault
	{
		get
		{
			return TableUtils.ROTax1RateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTax1Rules field.
	/// </summary>
	public Byte ROTax1Rules
	{
		get
		{
			return this.GetValue(TableUtils.ROTax1RulesColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTax1RulesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTax1RulesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTax1RulesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax1Rules field.
	/// </summary>
	public string ROTax1RulesDefault
	{
		get
		{
			return TableUtils.ROTax1RulesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTax2 field.
	/// </summary>
	public Decimal ROTax2
	{
		get
		{
			return this.GetValue(TableUtils.ROTax2Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTax2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTax2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTax2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2 field.
	/// </summary>
	public string ROTax2Default
	{
		get
		{
			return TableUtils.ROTax2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTax2Rate field.
	/// </summary>
	public Single ROTax2Rate
	{
		get
		{
			return this.GetValue(TableUtils.ROTax2RateColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTax2RateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTax2RateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTax2RateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rate field.
	/// </summary>
	public string ROTax2RateDefault
	{
		get
		{
			return TableUtils.ROTax2RateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTax2Rules field.
	/// </summary>
	public Byte ROTax2Rules
	{
		get
		{
			return this.GetValue(TableUtils.ROTax2RulesColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTax2RulesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTax2RulesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTax2RulesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax2Rules field.
	/// </summary>
	public string ROTax2RulesDefault
	{
		get
		{
			return TableUtils.ROTax2RulesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTax3 field.
	/// </summary>
	public Decimal ROTax3
	{
		get
		{
			return this.GetValue(TableUtils.ROTax3Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTax3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTax3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTax3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3 field.
	/// </summary>
	public string ROTax3Default
	{
		get
		{
			return TableUtils.ROTax3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTax3Rate field.
	/// </summary>
	public Single ROTax3Rate
	{
		get
		{
			return this.GetValue(TableUtils.ROTax3RateColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTax3RateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTax3RateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTax3RateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rate field.
	/// </summary>
	public string ROTax3RateDefault
	{
		get
		{
			return TableUtils.ROTax3RateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTax3Rules field.
	/// </summary>
	public Byte ROTax3Rules
	{
		get
		{
			return this.GetValue(TableUtils.ROTax3RulesColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTax3RulesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTax3RulesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTax3RulesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTax3Rules field.
	/// </summary>
	public string ROTax3RulesDefault
	{
		get
		{
			return TableUtils.ROTax3RulesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTaxExempt field.
	/// </summary>
	public string ROTaxExempt
	{
		get
		{
			return this.GetValue(TableUtils.ROTaxExemptColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTaxExemptColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTaxExemptSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTaxExemptColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTaxExempt field.
	/// </summary>
	public string ROTaxExemptDefault
	{
		get
		{
			return TableUtils.ROTaxExemptColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTechnician field.
	/// </summary>
	public string ROTechnician
	{
		get
		{
			return this.GetValue(TableUtils.ROTechnicianColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTechnicianColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTechnicianSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTechnicianColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTechnician field.
	/// </summary>
	public string ROTechnicianDefault
	{
		get
		{
			return TableUtils.ROTechnicianColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTracking field.
	/// </summary>
	public string ROTracking
	{
		get
		{
			return this.GetValue(TableUtils.ROTrackingColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTrackingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTrackingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTrackingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTracking field.
	/// </summary>
	public string ROTrackingDefault
	{
		get
		{
			return TableUtils.ROTrackingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTravel field.
	/// </summary>
	public Decimal ROTravel
	{
		get
		{
			return this.GetValue(TableUtils.ROTravelColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTravelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTravelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTravelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravel field.
	/// </summary>
	public string ROTravelDefault
	{
		get
		{
			return TableUtils.ROTravelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROTravelCost field.
	/// </summary>
	public Decimal ROTravelCost
	{
		get
		{
			return this.GetValue(TableUtils.ROTravelCostColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTravelCostColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTravelCostSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTravelCostColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROTravelCost field.
	/// </summary>
	public string ROTravelCostDefault
	{
		get
		{
			return TableUtils.ROTravelCostColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROType field.
	/// </summary>
	public string ROType
	{
		get
		{
			return this.GetValue(TableUtils.ROTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROType field.
	/// </summary>
	public string ROTypeDefault
	{
		get
		{
			return TableUtils.ROTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROUnderWarranty field.
	/// </summary>
	public bool ROUnderWarranty
	{
		get
		{
			return this.GetValue(TableUtils.ROUnderWarrantyColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROUnderWarrantyColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROUnderWarrantySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROUnderWarrantyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROUnderWarranty field.
	/// </summary>
	public string ROUnderWarrantyDefault
	{
		get
		{
			return TableUtils.ROUnderWarrantyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROWarranty field.
	/// </summary>
	public Byte ROWarranty
	{
		get
		{
			return this.GetValue(TableUtils.ROWarrantyColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROWarrantyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROWarrantySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROWarrantyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWarranty field.
	/// </summary>
	public string ROWarrantyDefault
	{
		get
		{
			return TableUtils.ROWarrantyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROWarrantyPlan field.
	/// </summary>
	public string ROWarrantyPlan
	{
		get
		{
			return this.GetValue(TableUtils.ROWarrantyPlanColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROWarrantyPlanColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROWarrantyPlanSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROWarrantyPlanColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWarrantyPlan field.
	/// </summary>
	public string ROWarrantyPlanDefault
	{
		get
		{
			return TableUtils.ROWarrantyPlanColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROWorkDoneNotes field.
	/// </summary>
	public string ROWorkDoneNotes
	{
		get
		{
			return this.GetValue(TableUtils.ROWorkDoneNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROWorkDoneNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROWorkDoneNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROWorkDoneNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROWorkDoneNotes field.
	/// </summary>
	public string ROWorkDoneNotesDefault
	{
		get
		{
			return TableUtils.ROWorkDoneNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ROUnder_Contract field.
	/// </summary>
	public bool ROUnder_Contract
	{
		get
		{
			return this.GetValue(TableUtils.ROUnder_ContractColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ROUnder_ContractColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROUnder_ContractSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROUnder_ContractColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ROUnder_Contract field.
	/// </summary>
	public string ROUnder_ContractDefault
	{
		get
		{
			return TableUtils.ROUnder_ContractColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.repair_est_notification field.
	/// </summary>
	public DateTime repair_est_notification
	{
		get
		{
			return this.GetValue(TableUtils.repair_est_notificationColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_est_notificationColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_est_notificationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_est_notificationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notification field.
	/// </summary>
	public string repair_est_notificationDefault
	{
		get
		{
			return TableUtils.repair_est_notificationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.repair_est_notify_by field.
	/// </summary>
	public Int32 repair_est_notify_by
	{
		get
		{
			return this.GetValue(TableUtils.repair_est_notify_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_est_notify_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_est_notify_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_est_notify_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_notify_by field.
	/// </summary>
	public string repair_est_notify_byDefault
	{
		get
		{
			return TableUtils.repair_est_notify_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.repair_est_note field.
	/// </summary>
	public string repair_est_note
	{
		get
		{
			return this.GetValue(TableUtils.repair_est_noteColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_est_noteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_est_noteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_est_noteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_est_note field.
	/// </summary>
	public string repair_est_noteDefault
	{
		get
		{
			return TableUtils.repair_est_noteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.repair_replace field.
	/// </summary>
	public bool repair_replace
	{
		get
		{
			return this.GetValue(TableUtils.repair_replaceColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.repair_replaceColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_replaceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_replaceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.repair_replace field.
	/// </summary>
	public string repair_replaceDefault
	{
		get
		{
			return TableUtils.repair_replaceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.RODeptIDNew field.
	/// </summary>
	public Int32 RODeptIDNew
	{
		get
		{
			return this.GetValue(TableUtils.RODeptIDNewColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RODeptIDNewColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RODeptIDNewSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RODeptIDNewColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.RODeptIDNew field.
	/// </summary>
	public string RODeptIDNewDefault
	{
		get
		{
			return TableUtils.RODeptIDNewColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ro_subtotal field.
	/// </summary>
	public Decimal ro_subtotal
	{
		get
		{
			return this.GetValue(TableUtils.ro_subtotalColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ro_subtotalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ro_subtotalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ro_subtotalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_subtotal field.
	/// </summary>
	public string ro_subtotalDefault
	{
		get
		{
			return TableUtils.ro_subtotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ro_grandntotal_nodisc field.
	/// </summary>
	public Decimal ro_grandntotal_nodisc
	{
		get
		{
			return this.GetValue(TableUtils.ro_grandntotal_nodiscColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ro_grandntotal_nodiscColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ro_grandntotal_nodiscSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ro_grandntotal_nodiscColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_grandntotal_nodisc field.
	/// </summary>
	public string ro_grandntotal_nodiscDefault
	{
		get
		{
			return TableUtils.ro_grandntotal_nodiscColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ro_grandtotal_nodisc field.
	/// </summary>
	public Decimal ro_grandtotal_nodisc
	{
		get
		{
			return this.GetValue(TableUtils.ro_grandtotal_nodiscColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ro_grandtotal_nodiscColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ro_grandtotal_nodiscSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ro_grandtotal_nodiscColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_grandtotal_nodisc field.
	/// </summary>
	public string ro_grandtotal_nodiscDefault
	{
		get
		{
			return TableUtils.ro_grandtotal_nodiscColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.test field.
	/// </summary>
	public bool test
	{
		get
		{
			return this.GetValue(TableUtils.testColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.testColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool testSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.testColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.test field.
	/// </summary>
	public string testDefault
	{
		get
		{
			return TableUtils.testColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ro_partstotal_calc field.
	/// </summary>
	public Decimal ro_partstotal_calc
	{
		get
		{
			return this.GetValue(TableUtils.ro_partstotal_calcColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ro_partstotal_calcColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ro_partstotal_calcSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ro_partstotal_calcColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_partstotal_calc field.
	/// </summary>
	public string ro_partstotal_calcDefault
	{
		get
		{
			return TableUtils.ro_partstotal_calcColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.ro_labortotal_calc field.
	/// </summary>
	public Decimal ro_labortotal_calc
	{
		get
		{
			return this.GetValue(TableUtils.ro_labortotal_calcColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ro_labortotal_calcColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ro_labortotal_calcSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ro_labortotal_calcColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.ro_labortotal_calc field.
	/// </summary>
	public string ro_labortotal_calcDefault
	{
		get
		{
			return TableUtils.ro_labortotal_calcColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.new_discountamt field.
	/// </summary>
	public Decimal new_discountamt
	{
		get
		{
			return this.GetValue(TableUtils.new_discountamtColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.new_discountamtColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool new_discountamtSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.new_discountamtColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.new_discountamt field.
	/// </summary>
	public string new_discountamtDefault
	{
		get
		{
			return TableUtils.new_discountamtColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.roDiscountDollar field.
	/// </summary>
	public Decimal roDiscountDollar
	{
		get
		{
			return this.GetValue(TableUtils.roDiscountDollarColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.roDiscountDollarColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool roDiscountDollarSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.roDiscountDollarColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.roDiscountDollar field.
	/// </summary>
	public string roDiscountDollarDefault
	{
		get
		{
			return TableUtils.roDiscountDollarColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.FaultDesc field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.FaultDesc field.
	/// </summary>
	public string FaultDescDefault
	{
		get
		{
			return TableUtils.FaultDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.corporate_name field.
	/// </summary>
	public string corporate_name
	{
		get
		{
			return this.GetValue(TableUtils.corporate_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporate_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporate_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporate_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.corporate_name field.
	/// </summary>
	public string corporate_nameDefault
	{
		get
		{
			return TableUtils.corporate_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.SignatureImage field.
	/// </summary>
	public byte[] SignatureImage
	{
		get
		{
			return this.GetValue(TableUtils.SignatureImageColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SignatureImageColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SignatureImageSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SignatureImageColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.SignatureImage field.
	/// </summary>
	public string SignatureImageDefault
	{
		get
		{
			return TableUtils.SignatureImageColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.category_id field.
	/// </summary>
	public Int32 category_id
	{
		get
		{
			return this.GetValue(TableUtils.category_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.category_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool category_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.category_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.category_id field.
	/// </summary>
	public string category_idDefault
	{
		get
		{
			return TableUtils.category_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.signature_datetime field.
	/// </summary>
	public DateTime signature_datetime
	{
		get
		{
			return this.GetValue(TableUtils.signature_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.signature_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool signature_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.signature_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.signature_datetime field.
	/// </summary>
	public string signature_datetimeDefault
	{
		get
		{
			return TableUtils.signature_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.loaner_required field.
	/// </summary>
	public bool loaner_required
	{
		get
		{
			return this.GetValue(TableUtils.loaner_requiredColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.loaner_requiredColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool loaner_requiredSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.loaner_requiredColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.loaner_required field.
	/// </summary>
	public string loaner_requiredDefault
	{
		get
		{
			return TableUtils.loaner_requiredColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.label_required field.
	/// </summary>
	public bool label_required
	{
		get
		{
			return this.GetValue(TableUtils.label_requiredColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.label_requiredColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool label_requiredSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.label_requiredColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.label_required field.
	/// </summary>
	public string label_requiredDefault
	{
		get
		{
			return TableUtils.label_requiredColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.customer_name field.
	/// </summary>
	public string customer_name
	{
		get
		{
			return this.GetValue(TableUtils.customer_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.customer_name field.
	/// </summary>
	public string customer_nameDefault
	{
		get
		{
			return TableUtils.customer_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.approver_email field.
	/// </summary>
	public string approver_email
	{
		get
		{
			return this.GetValue(TableUtils.approver_emailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.approver_emailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool approver_emailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.approver_emailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.approver_email field.
	/// </summary>
	public string approver_emailDefault
	{
		get
		{
			return TableUtils.approver_emailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.serial_encrypt field.
	/// </summary>
	public string serial_encrypt
	{
		get
		{
			return this.GetValue(TableUtils.serial_encryptColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_encryptColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_encryptSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_encryptColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.serial_encrypt field.
	/// </summary>
	public string serial_encryptDefault
	{
		get
		{
			return TableUtils.serial_encryptColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrders_.customer_encrypt field.
	/// </summary>
	public string customer_encrypt
	{
		get
		{
			return this.GetValue(TableUtils.customer_encryptColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.customer_encryptColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool customer_encryptSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.customer_encryptColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrders_.customer_encrypt field.
	/// </summary>
	public string customer_encryptDefault
	{
		get
		{
			return TableUtils.customer_encryptColumn.DefaultValue;
		}
	}


#endregion
}

}
