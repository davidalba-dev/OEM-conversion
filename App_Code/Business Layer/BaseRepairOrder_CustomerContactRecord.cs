// This class is "generated" and will be overwritten.
// Your customizations should be made in RepairOrder_CustomerContactRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="RepairOrder_CustomerContactRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RepairOrder_CustomerContactView"></see> class.
/// </remarks>
/// <seealso cref="RepairOrder_CustomerContactView"></seealso>
/// <seealso cref="RepairOrder_CustomerContactRecord"></seealso>
public class BaseRepairOrder_CustomerContactRecord : PrimaryKeyRecord
{

	public readonly static RepairOrder_CustomerContactView TableUtils = RepairOrder_CustomerContactView.Instance;

	// Constructors
 
	protected BaseRepairOrder_CustomerContactRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.RepairOrder_CustomerContactRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.RepairOrder_CustomerContactRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.RepairOrder_CustomerContactRecord_ReadRecord); 
	}

	protected BaseRepairOrder_CustomerContactRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void RepairOrder_CustomerContactRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                RepairOrder_CustomerContactRecord RepairOrder_CustomerContactRec = (RepairOrder_CustomerContactRecord)sender;
        if(RepairOrder_CustomerContactRec != null && !RepairOrder_CustomerContactRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void RepairOrder_CustomerContactRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                RepairOrder_CustomerContactRecord RepairOrder_CustomerContactRec = (RepairOrder_CustomerContactRecord)sender;
        Validate_Inserting();
        if(RepairOrder_CustomerContactRec != null && !RepairOrder_CustomerContactRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void RepairOrder_CustomerContactRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                RepairOrder_CustomerContactRecord RepairOrder_CustomerContactRec = (RepairOrder_CustomerContactRecord)sender;
        Validate_Updating();
        if(RepairOrder_CustomerContactRec != null && !RepairOrder_CustomerContactRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.RONo field.
	/// </summary>
	public ColumnValue GetRONoValue()
	{
		return this.GetValue(TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.RONo field.
	/// </summary>
	public Int32 GetRONoFieldValue()
	{
		return this.GetValue(TableUtils.RONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROCategory field.
	/// </summary>
	public ColumnValue GetROCategoryValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROCategory field.
	/// </summary>
	public string GetROCategoryFieldValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROCustName field.
	/// </summary>
	public ColumnValue GetROCustNameValue()
	{
		return this.GetValue(TableUtils.ROCustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROCustName field.
	/// </summary>
	public string GetROCustNameFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCustName field.
	/// </summary>
	public void SetROCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCustName field.
	/// </summary>
	public void SetROCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.RODate field.
	/// </summary>
	public ColumnValue GetRODateValue()
	{
		return this.GetValue(TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.RODate field.
	/// </summary>
	public DateTime GetRODateFieldValue()
	{
		return this.GetValue(TableUtils.RODateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODate field.
	/// </summary>
	public void SetRODateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ro_subtotal field.
	/// </summary>
	public ColumnValue Getro_subtotalValue()
	{
		return this.GetValue(TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ro_subtotal field.
	/// </summary>
	public Decimal Getro_subtotalFieldValue()
	{
		return this.GetValue(TableUtils.ro_subtotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_subtotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ro_subtotal field.
	/// </summary>
	public void Setro_subtotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ro_subtotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROMake field.
	/// </summary>
	public ColumnValue GetROMakeValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROMake field.
	/// </summary>
	public string GetROMakeFieldValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROModel field.
	/// </summary>
	public ColumnValue GetROModelValue()
	{
		return this.GetValue(TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROModel field.
	/// </summary>
	public string GetROModelFieldValue()
	{
		return this.GetValue(TableUtils.ROModelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROModelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROReference1 field.
	/// </summary>
	public ColumnValue GetROReference1Value()
	{
		return this.GetValue(TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROReference1 field.
	/// </summary>
	public string GetROReference1FieldValue()
	{
		return this.GetValue(TableUtils.ROReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROReference2 field.
	/// </summary>
	public ColumnValue GetROReference2Value()
	{
		return this.GetValue(TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROReference2 field.
	/// </summary>
	public string GetROReference2FieldValue()
	{
		return this.GetValue(TableUtils.ROReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROReference4 field.
	/// </summary>
	public ColumnValue GetROReference4Value()
	{
		return this.GetValue(TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROReference4 field.
	/// </summary>
	public string GetROReference4FieldValue()
	{
		return this.GetValue(TableUtils.ROReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROSerialNo field.
	/// </summary>
	public ColumnValue GetROSerialNoValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROSerialNo field.
	/// </summary>
	public string GetROSerialNoFieldValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSerialNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROCustNo field.
	/// </summary>
	public ColumnValue GetROCustNoValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROCustNo field.
	/// </summary>
	public Int32 GetROCustNoFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROStatus field.
	/// </summary>
	public ColumnValue GetROStatusValue()
	{
		return this.GetValue(TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROStatus field.
	/// </summary>
	public Byte GetROStatusFieldValue()
	{
		return this.GetValue(TableUtils.ROStatusColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROStatus field.
	/// </summary>
	public void SetROStatusFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROStatusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.RODeptIDNew field.
	/// </summary>
	public ColumnValue GetRODeptIDNewValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.RODeptIDNew field.
	/// </summary>
	public Int32 GetRODeptIDNewFieldValue()
	{
		return this.GetValue(TableUtils.RODeptIDNewColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(string val)
	{
		this.SetString(val, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODeptIDNew field.
	/// </summary>
	public void SetRODeptIDNewFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODeptIDNewColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.department_name field.
	/// </summary>
	public ColumnValue Getdepartment_nameValue()
	{
		return this.GetValue(TableUtils.department_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.department_name field.
	/// </summary>
	public string Getdepartment_nameFieldValue()
	{
		return this.GetValue(TableUtils.department_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_name field.
	/// </summary>
	public void Setdepartment_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.department_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_name field.
	/// </summary>
	public void Setdepartment_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.department_active field.
	/// </summary>
	public ColumnValue Getdepartment_activeValue()
	{
		return this.GetValue(TableUtils.department_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.department_active field.
	/// </summary>
	public bool Getdepartment_activeFieldValue()
	{
		return this.GetValue(TableUtils.department_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_active field.
	/// </summary>
	public void Setdepartment_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.department_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_active field.
	/// </summary>
	public void Setdepartment_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.department_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_active field.
	/// </summary>
	public void Setdepartment_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.department_id field.
	/// </summary>
	public ColumnValue Getdepartment_idValue()
	{
		return this.GetValue(TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.department_id field.
	/// </summary>
	public Int32 Getdepartment_idFieldValue()
	{
		return this.GetValue(TableUtils.department_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_id field.
	/// </summary>
	public void Setdepartment_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.department_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.StaNumber field.
	/// </summary>
	public ColumnValue GetStaNumberValue()
	{
		return this.GetValue(TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.StaNumber field.
	/// </summary>
	public Byte GetStaNumberFieldValue()
	{
		return this.GetValue(TableUtils.StaNumberColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(string val)
	{
		this.SetString(val, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.StaNumber field.
	/// </summary>
	public void SetStaNumberFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.StaNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.status_customer_caption field.
	/// </summary>
	public ColumnValue Getstatus_customer_captionValue()
	{
		return this.GetValue(TableUtils.status_customer_captionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.status_customer_caption field.
	/// </summary>
	public string Getstatus_customer_captionFieldValue()
	{
		return this.GetValue(TableUtils.status_customer_captionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.status_customer_caption field.
	/// </summary>
	public void Setstatus_customer_captionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.status_customer_captionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.status_customer_caption field.
	/// </summary>
	public void Setstatus_customer_captionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.status_customer_captionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.status_color field.
	/// </summary>
	public ColumnValue Getstatus_colorValue()
	{
		return this.GetValue(TableUtils.status_colorColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.status_color field.
	/// </summary>
	public string Getstatus_colorFieldValue()
	{
		return this.GetValue(TableUtils.status_colorColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.status_color field.
	/// </summary>
	public void Setstatus_colorFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.status_colorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.status_color field.
	/// </summary>
	public void Setstatus_colorFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.status_colorColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROFaultCodes field.
	/// </summary>
	public ColumnValue GetROFaultCodesValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROFaultCodes field.
	/// </summary>
	public string GetROFaultCodesFieldValue()
	{
		return this.GetValue(TableUtils.ROFaultCodesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROFaultCodesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROFaultCodes field.
	/// </summary>
	public void SetROFaultCodesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROFaultCodesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.category_id field.
	/// </summary>
	public ColumnValue Getcategory_idValue()
	{
		return this.GetValue(TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RepairOrder_CustomerContact_.category_id field.
	/// </summary>
	public Int32 Getcategory_idFieldValue()
	{
		return this.GetValue(TableUtils.category_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.category_id field.
	/// </summary>
	public void Setcategory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.category_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.RONo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RONo field.
	/// </summary>
	public string RONoDefault
	{
		get
		{
			return TableUtils.RONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROCategory field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCategory field.
	/// </summary>
	public string ROCategoryDefault
	{
		get
		{
			return TableUtils.ROCategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROCustName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCustName field.
	/// </summary>
	public string ROCustNameDefault
	{
		get
		{
			return TableUtils.ROCustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.RODate field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODate field.
	/// </summary>
	public string RODateDefault
	{
		get
		{
			return TableUtils.RODateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ro_subtotal field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ro_subtotal field.
	/// </summary>
	public string ro_subtotalDefault
	{
		get
		{
			return TableUtils.ro_subtotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROMake field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROMake field.
	/// </summary>
	public string ROMakeDefault
	{
		get
		{
			return TableUtils.ROMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROModel field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROModel field.
	/// </summary>
	public string ROModelDefault
	{
		get
		{
			return TableUtils.ROModelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROReference1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROReference1 field.
	/// </summary>
	public string ROReference1Default
	{
		get
		{
			return TableUtils.ROReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROReference2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROReference2 field.
	/// </summary>
	public string ROReference2Default
	{
		get
		{
			return TableUtils.ROReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROReference4 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROReference4 field.
	/// </summary>
	public string ROReference4Default
	{
		get
		{
			return TableUtils.ROReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROSerialNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROSerialNo field.
	/// </summary>
	public string ROSerialNoDefault
	{
		get
		{
			return TableUtils.ROSerialNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROCustNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROCustNo field.
	/// </summary>
	public string ROCustNoDefault
	{
		get
		{
			return TableUtils.ROCustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROStatus field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROStatus field.
	/// </summary>
	public string ROStatusDefault
	{
		get
		{
			return TableUtils.ROStatusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.RODeptIDNew field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.RODeptIDNew field.
	/// </summary>
	public string RODeptIDNewDefault
	{
		get
		{
			return TableUtils.RODeptIDNewColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.department_name field.
	/// </summary>
	public string department_name
	{
		get
		{
			return this.GetValue(TableUtils.department_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.department_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool department_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.department_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_name field.
	/// </summary>
	public string department_nameDefault
	{
		get
		{
			return TableUtils.department_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.department_active field.
	/// </summary>
	public bool department_active
	{
		get
		{
			return this.GetValue(TableUtils.department_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.department_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool department_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.department_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_active field.
	/// </summary>
	public string department_activeDefault
	{
		get
		{
			return TableUtils.department_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.department_id field.
	/// </summary>
	public Int32 department_id
	{
		get
		{
			return this.GetValue(TableUtils.department_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.department_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool department_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.department_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.department_id field.
	/// </summary>
	public string department_idDefault
	{
		get
		{
			return TableUtils.department_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.StaNumber field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.StaNumber field.
	/// </summary>
	public string StaNumberDefault
	{
		get
		{
			return TableUtils.StaNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.status_customer_caption field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.status_customer_caption field.
	/// </summary>
	public string status_customer_captionDefault
	{
		get
		{
			return TableUtils.status_customer_captionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.status_color field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.status_color field.
	/// </summary>
	public string status_colorDefault
	{
		get
		{
			return TableUtils.status_colorColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.ROFaultCodes field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.ROFaultCodes field.
	/// </summary>
	public string ROFaultCodesDefault
	{
		get
		{
			return TableUtils.ROFaultCodesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RepairOrder_CustomerContact_.category_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RepairOrder_CustomerContact_.category_id field.
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
