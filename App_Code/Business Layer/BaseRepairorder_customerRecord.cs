// This class is "generated" and will be overwritten.
// Your customizations should be made in Repairorder_customerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Repairorder_customerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Repairorder_customerView"></see> class.
/// </remarks>
/// <seealso cref="Repairorder_customerView"></seealso>
/// <seealso cref="Repairorder_customerRecord"></seealso>
public class BaseRepairorder_customerRecord : PrimaryKeyRecord
{

	public readonly static Repairorder_customerView TableUtils = Repairorder_customerView.Instance;

	// Constructors
 
	protected BaseRepairorder_customerRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Repairorder_customerRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Repairorder_customerRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Repairorder_customerRecord_ReadRecord); 
	}

	protected BaseRepairorder_customerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Repairorder_customerRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Repairorder_customerRecord Repairorder_customerRec = (Repairorder_customerRecord)sender;
        if(Repairorder_customerRec != null && !Repairorder_customerRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Repairorder_customerRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Repairorder_customerRecord Repairorder_customerRec = (Repairorder_customerRecord)sender;
        Validate_Inserting();
        if(Repairorder_customerRec != null && !Repairorder_customerRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Repairorder_customerRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Repairorder_customerRecord Repairorder_customerRec = (Repairorder_customerRecord)sender;
        Validate_Updating();
        if(Repairorder_customerRec != null && !Repairorder_customerRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.RONo field.
	/// </summary>
	public ColumnValue GetRONoValue()
	{
		return this.GetValue(TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.RONo field.
	/// </summary>
	public Int32 GetRONoFieldValue()
	{
		return this.GetValue(TableUtils.RONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROCategory field.
	/// </summary>
	public ColumnValue GetROCategoryValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROCategory field.
	/// </summary>
	public string GetROCategoryFieldValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROCustName field.
	/// </summary>
	public ColumnValue GetROCustNameValue()
	{
		return this.GetValue(TableUtils.ROCustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROCustName field.
	/// </summary>
	public string GetROCustNameFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCustName field.
	/// </summary>
	public void SetROCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCustName field.
	/// </summary>
	public void SetROCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.RODate field.
	/// </summary>
	public ColumnValue GetRODateValue()
	{
		return this.GetValue(TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.RODate field.
	/// </summary>
	public DateTime GetRODateFieldValue()
	{
		return this.GetValue(TableUtils.RODateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ro_subtotal field.
	/// </summary>
	public ColumnValue Getro_subtotalValue()
	{
		return this.GetValue(TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ro_subtotal field.
	/// </summary>
	public Decimal Getro_subtotalFieldValue()
	{
		return this.GetValue(TableUtils.ro_subtotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_subtotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROMake field.
	/// </summary>
	public ColumnValue GetROMakeValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROMake field.
	/// </summary>
	public string GetROMakeFieldValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROModel field.
	/// </summary>
	public ColumnValue GetROModelValue()
	{
		return this.GetValue(TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROModel field.
	/// </summary>
	public string GetROModelFieldValue()
	{
		return this.GetValue(TableUtils.ROModelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROModelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROReference1 field.
	/// </summary>
	public ColumnValue GetROReference1Value()
	{
		return this.GetValue(TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROReference1 field.
	/// </summary>
	public string GetROReference1FieldValue()
	{
		return this.GetValue(TableUtils.ROReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROReference2 field.
	/// </summary>
	public ColumnValue GetROReference2Value()
	{
		return this.GetValue(TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROReference2 field.
	/// </summary>
	public string GetROReference2FieldValue()
	{
		return this.GetValue(TableUtils.ROReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROReference4 field.
	/// </summary>
	public ColumnValue GetROReference4Value()
	{
		return this.GetValue(TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROReference4 field.
	/// </summary>
	public string GetROReference4FieldValue()
	{
		return this.GetValue(TableUtils.ROReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROSerialNo field.
	/// </summary>
	public ColumnValue GetROSerialNoValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROSerialNo field.
	/// </summary>
	public string GetROSerialNoFieldValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSerialNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROCustNo field.
	/// </summary>
	public ColumnValue GetROCustNoValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROCustNo field.
	/// </summary>
	public Int32 GetROCustNoFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROStatus field.
	/// </summary>
	public ColumnValue GetROStatusValue()
	{
		return this.GetValue(TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROStatus field.
	/// </summary>
	public Byte GetROStatusFieldValue()
	{
		return this.GetValue(TableUtils.ROStatusColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.RODeptIDNew field.
	/// </summary>
	public ColumnValue GetRODeptIDNewValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.RODeptIDNew field.
	/// </summary>
	public Int32 GetRODeptIDNewFieldValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROFaultCodes field.
	/// </summary>
	public ColumnValue GetROFaultCodesValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.ROFaultCodes field.
	/// </summary>
	public string GetROFaultCodesFieldValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROFaultCodesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.CustName field.
	/// </summary>
	public ColumnValue GetCustNameValue()
	{
		return this.GetValue(TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.CustName field.
	/// </summary>
	public string GetCustNameFieldValue()
	{
		return this.GetValue(TableUtils.CustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.CustNo field.
	/// </summary>
	public ColumnValue GetCustNoValue()
	{
		return this.GetValue(TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.CustNo field.
	/// </summary>
	public Int32 GetCustNoFieldValue()
	{
		return this.GetValue(TableUtils.CustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.CustNo field.
	/// </summary>
	public void SetCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.status_active field.
	/// </summary>
	public ColumnValue Getstatus_activeValue()
	{
		return this.GetValue(TableUtils.status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.status_active field.
	/// </summary>
	public bool Getstatus_activeFieldValue()
	{
		return this.GetValue(TableUtils.status_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_active field.
	/// </summary>
	public void Setstatus_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_active field.
	/// </summary>
	public void Setstatus_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.status_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_active field.
	/// </summary>
	public void Setstatus_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.status_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.status_color field.
	/// </summary>
	public ColumnValue Getstatus_colorValue()
	{
		return this.GetValue(TableUtils.status_colorColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.status_color field.
	/// </summary>
	public string Getstatus_colorFieldValue()
	{
		return this.GetValue(TableUtils.status_colorColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_color field.
	/// </summary>
	public void Setstatus_colorFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.status_colorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_color field.
	/// </summary>
	public void Setstatus_colorFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.status_colorColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.status_customer_caption field.
	/// </summary>
	public ColumnValue Getstatus_customer_captionValue()
	{
		return this.GetValue(TableUtils.status_customer_captionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.status_customer_caption field.
	/// </summary>
	public string Getstatus_customer_captionFieldValue()
	{
		return this.GetValue(TableUtils.status_customer_captionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_customer_caption field.
	/// </summary>
	public void Setstatus_customer_captionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.status_customer_captionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_customer_caption field.
	/// </summary>
	public void Setstatus_customer_captionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.status_customer_captionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_customer_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.RONo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RONo field.
	/// </summary>
	public string RONoDefault
	{
		get
		{
			return TableUtils.RONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROCategory field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCategory field.
	/// </summary>
	public string ROCategoryDefault
	{
		get
		{
			return TableUtils.ROCategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROCustName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCustName field.
	/// </summary>
	public string ROCustNameDefault
	{
		get
		{
			return TableUtils.ROCustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.RODate field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODate field.
	/// </summary>
	public string RODateDefault
	{
		get
		{
			return TableUtils.RODateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ro_subtotal field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ro_subtotal field.
	/// </summary>
	public string ro_subtotalDefault
	{
		get
		{
			return TableUtils.ro_subtotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROMake field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROMake field.
	/// </summary>
	public string ROMakeDefault
	{
		get
		{
			return TableUtils.ROMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROModel field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROModel field.
	/// </summary>
	public string ROModelDefault
	{
		get
		{
			return TableUtils.ROModelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROReference1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROReference1 field.
	/// </summary>
	public string ROReference1Default
	{
		get
		{
			return TableUtils.ROReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROReference2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROReference2 field.
	/// </summary>
	public string ROReference2Default
	{
		get
		{
			return TableUtils.ROReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROReference4 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROReference4 field.
	/// </summary>
	public string ROReference4Default
	{
		get
		{
			return TableUtils.ROReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROSerialNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROSerialNo field.
	/// </summary>
	public string ROSerialNoDefault
	{
		get
		{
			return TableUtils.ROSerialNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROCustNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROCustNo field.
	/// </summary>
	public string ROCustNoDefault
	{
		get
		{
			return TableUtils.ROCustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROStatus field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROStatus field.
	/// </summary>
	public string ROStatusDefault
	{
		get
		{
			return TableUtils.ROStatusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.RODeptIDNew field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.RODeptIDNew field.
	/// </summary>
	public string RODeptIDNewDefault
	{
		get
		{
			return TableUtils.RODeptIDNewColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.ROFaultCodes field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.ROFaultCodes field.
	/// </summary>
	public string ROFaultCodesDefault
	{
		get
		{
			return TableUtils.ROFaultCodesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.CustName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.CustName field.
	/// </summary>
	public string CustNameDefault
	{
		get
		{
			return TableUtils.CustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.CustNo field.
	/// </summary>
	public Int32 CustNo
	{
		get
		{
			return this.GetValue(TableUtils.CustNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.CustNo field.
	/// </summary>
	public string CustNoDefault
	{
		get
		{
			return TableUtils.CustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.status_active field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_active field.
	/// </summary>
	public string status_activeDefault
	{
		get
		{
			return TableUtils.status_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.status_color field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_color field.
	/// </summary>
	public string status_colorDefault
	{
		get
		{
			return TableUtils.status_colorColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.status_customer_caption field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.status_customer_caption field.
	/// </summary>
	public string status_customer_captionDefault
	{
		get
		{
			return TableUtils.status_customer_captionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_customer_.category_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_customer_.category_id field.
	/// </summary>
	public string category_idDefault
	{
		get
		{
			return TableUtils.category_idColumn.DefaultValue;
		}
	}


#endregion
}

}
