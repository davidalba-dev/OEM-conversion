// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_device_repair_historyRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_device_repair_historyRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_device_repair_historyView"></see> class.
/// </remarks>
/// <seealso cref="Vw_device_repair_historyView"></seealso>
/// <seealso cref="Vw_device_repair_historyRecord"></seealso>
public class BaseVw_device_repair_historyRecord : PrimaryKeyRecord
{

	public readonly static Vw_device_repair_historyView TableUtils = Vw_device_repair_historyView.Instance;

	// Constructors
 
	protected BaseVw_device_repair_historyRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_device_repair_historyRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Vw_device_repair_historyRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_device_repair_historyRecord_ReadRecord); 
	}

	protected BaseVw_device_repair_historyRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_device_repair_historyRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_device_repair_historyRecord Vw_device_repair_historyRec = (Vw_device_repair_historyRecord)sender;
        if(Vw_device_repair_historyRec != null && !Vw_device_repair_historyRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_device_repair_historyRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_device_repair_historyRecord Vw_device_repair_historyRec = (Vw_device_repair_historyRecord)sender;
        Validate_Inserting();
        if(Vw_device_repair_historyRec != null && !Vw_device_repair_historyRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Vw_device_repair_historyRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Vw_device_repair_historyRecord Vw_device_repair_historyRec = (Vw_device_repair_historyRecord)sender;
        Validate_Updating();
        if(Vw_device_repair_historyRec != null && !Vw_device_repair_historyRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RODate field.
	/// </summary>
	public ColumnValue GetRODateValue()
	{
		return this.GetValue(TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RODate field.
	/// </summary>
	public DateTime GetRODateFieldValue()
	{
		return this.GetValue(TableUtils.RODateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROCustNo field.
	/// </summary>
	public ColumnValue GetROCustNoValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROCustNo field.
	/// </summary>
	public Int32 GetROCustNoFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.CustName field.
	/// </summary>
	public ColumnValue GetCustNameValue()
	{
		return this.GetValue(TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.CustName field.
	/// </summary>
	public string GetCustNameFieldValue()
	{
		return this.GetValue(TableUtils.CustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RONo field.
	/// </summary>
	public ColumnValue GetRONoValue()
	{
		return this.GetValue(TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RONo field.
	/// </summary>
	public Int32 GetRONoFieldValue()
	{
		return this.GetValue(TableUtils.RONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROSerialNo field.
	/// </summary>
	public ColumnValue GetROSerialNoValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROSerialNo field.
	/// </summary>
	public string GetROSerialNoFieldValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSerialNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.customer_name field.
	/// </summary>
	public ColumnValue Getcustomer_nameValue()
	{
		return this.GetValue(TableUtils.customer_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.customer_name field.
	/// </summary>
	public string Getcustomer_nameFieldValue()
	{
		return this.GetValue(TableUtils.customer_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.customer_name field.
	/// </summary>
	public void Setcustomer_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.customer_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.customer_name field.
	/// </summary>
	public void Setcustomer_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.customer_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RODeptIDNew field.
	/// </summary>
	public ColumnValue GetRODeptIDNewValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RODeptIDNew field.
	/// </summary>
	public Int32 GetRODeptIDNewFieldValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROMake field.
	/// </summary>
	public ColumnValue GetROMakeValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROMake field.
	/// </summary>
	public string GetROMakeFieldValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROStatus field.
	/// </summary>
	public ColumnValue GetROStatusValue()
	{
		return this.GetValue(TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROStatus field.
	/// </summary>
	public Byte GetROStatusFieldValue()
	{
		return this.GetValue(TableUtils.ROStatusColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RODateEstimateApproved field.
	/// </summary>
	public ColumnValue GetRODateEstimateApprovedValue()
	{
		return this.GetValue(TableUtils.RODateEstimateApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RODateEstimateApproved field.
	/// </summary>
	public DateTime GetRODateEstimateApprovedFieldValue()
	{
		return this.GetValue(TableUtils.RODateEstimateApprovedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODateEstimateApproved field.
	/// </summary>
	public void SetRODateEstimateApprovedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateEstimateApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODateEstimateApproved field.
	/// </summary>
	public void SetRODateEstimateApprovedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateEstimateApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODateEstimateApproved field.
	/// </summary>
	public void SetRODateEstimateApprovedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateEstimateApprovedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RODateReturned field.
	/// </summary>
	public ColumnValue GetRODateReturnedValue()
	{
		return this.GetValue(TableUtils.RODateReturnedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.RODateReturned field.
	/// </summary>
	public DateTime GetRODateReturnedFieldValue()
	{
		return this.GetValue(TableUtils.RODateReturnedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODateReturned field.
	/// </summary>
	public void SetRODateReturnedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateReturnedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODateReturned field.
	/// </summary>
	public void SetRODateReturnedFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateReturnedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODateReturned field.
	/// </summary>
	public void SetRODateReturnedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateReturnedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROReference4 field.
	/// </summary>
	public ColumnValue GetROReference4Value()
	{
		return this.GetValue(TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROReference4 field.
	/// </summary>
	public string GetROReference4FieldValue()
	{
		return this.GetValue(TableUtils.ROReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROReference1 field.
	/// </summary>
	public ColumnValue GetROReference1Value()
	{
		return this.GetValue(TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROReference1 field.
	/// </summary>
	public string GetROReference1FieldValue()
	{
		return this.GetValue(TableUtils.ROReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ro_subtotal field.
	/// </summary>
	public ColumnValue Getro_subtotalValue()
	{
		return this.GetValue(TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ro_subtotal field.
	/// </summary>
	public Decimal Getro_subtotalFieldValue()
	{
		return this.GetValue(TableUtils.ro_subtotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_subtotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROTechnician field.
	/// </summary>
	public ColumnValue GetROTechnicianValue()
	{
		return this.GetValue(TableUtils.ROTechnicianColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROTechnician field.
	/// </summary>
	public string GetROTechnicianFieldValue()
	{
		return this.GetValue(TableUtils.ROTechnicianColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROTechnician field.
	/// </summary>
	public void SetROTechnicianFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROTechnicianColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROTechnician field.
	/// </summary>
	public void SetROTechnicianFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROTechnicianColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROFaultCodes field.
	/// </summary>
	public ColumnValue GetROFaultCodesValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_device_repair_history_.ROFaultCodes field.
	/// </summary>
	public string GetROFaultCodesFieldValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROFaultCodesColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.RODate field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODate field.
	/// </summary>
	public string RODateDefault
	{
		get
		{
			return TableUtils.RODateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.ROCustNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROCustNo field.
	/// </summary>
	public string ROCustNoDefault
	{
		get
		{
			return TableUtils.ROCustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.CustName field.
	/// </summary>
	public string CustName
	{
		get
		{
			return this.GetValue(TableUtils.CustNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.CustName field.
	/// </summary>
	public string CustNameDefault
	{
		get
		{
			return TableUtils.CustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.RONo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RONo field.
	/// </summary>
	public string RONoDefault
	{
		get
		{
			return TableUtils.RONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.ROSerialNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROSerialNo field.
	/// </summary>
	public string ROSerialNoDefault
	{
		get
		{
			return TableUtils.ROSerialNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.customer_name field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.customer_name field.
	/// </summary>
	public string customer_nameDefault
	{
		get
		{
			return TableUtils.customer_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.RODeptIDNew field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODeptIDNew field.
	/// </summary>
	public string RODeptIDNewDefault
	{
		get
		{
			return TableUtils.RODeptIDNewColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.ROMake field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROMake field.
	/// </summary>
	public string ROMakeDefault
	{
		get
		{
			return TableUtils.ROMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.ROStatus field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROStatus field.
	/// </summary>
	public string ROStatusDefault
	{
		get
		{
			return TableUtils.ROStatusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.RODateEstimateApproved field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODateEstimateApproved field.
	/// </summary>
	public string RODateEstimateApprovedDefault
	{
		get
		{
			return TableUtils.RODateEstimateApprovedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.RODateReturned field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.RODateReturned field.
	/// </summary>
	public string RODateReturnedDefault
	{
		get
		{
			return TableUtils.RODateReturnedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.ROReference4 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROReference4 field.
	/// </summary>
	public string ROReference4Default
	{
		get
		{
			return TableUtils.ROReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.ROReference1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROReference1 field.
	/// </summary>
	public string ROReference1Default
	{
		get
		{
			return TableUtils.ROReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.category_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.category_id field.
	/// </summary>
	public string category_idDefault
	{
		get
		{
			return TableUtils.category_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.ro_subtotal field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ro_subtotal field.
	/// </summary>
	public string ro_subtotalDefault
	{
		get
		{
			return TableUtils.ro_subtotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.ROTechnician field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROTechnician field.
	/// </summary>
	public string ROTechnicianDefault
	{
		get
		{
			return TableUtils.ROTechnicianColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_device_repair_history_.ROFaultCodes field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vw_device_repair_history_.ROFaultCodes field.
	/// </summary>
	public string ROFaultCodesDefault
	{
		get
		{
			return TableUtils.ROFaultCodesColumn.DefaultValue;
		}
	}


#endregion
}

}
