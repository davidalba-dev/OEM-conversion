// This class is "generated" and will be overwritten.
// Your customizations should be made in Repairorder_reportRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Repairorder_reportRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Repairorder_reportView"></see> class.
/// </remarks>
/// <seealso cref="Repairorder_reportView"></seealso>
/// <seealso cref="Repairorder_reportRecord"></seealso>
public class BaseRepairorder_reportRecord : KeylessRecord
{

	public readonly static Repairorder_reportView TableUtils = Repairorder_reportView.Instance;

	// Constructors
 
	protected BaseRepairorder_reportRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Repairorder_reportRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Repairorder_reportRecord_InsertingRecord);     
	}

	protected BaseRepairorder_reportRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Repairorder_reportRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Repairorder_reportRecord Repairorder_reportRec = (Repairorder_reportRecord)sender;
        if(Repairorder_reportRec != null && !Repairorder_reportRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Repairorder_reportRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Repairorder_reportRecord Repairorder_reportRec = (Repairorder_reportRecord)sender;
        Validate_Inserting();
        if(Repairorder_reportRec != null && !Repairorder_reportRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROAddress1 field.
	/// </summary>
	public ColumnValue GetROAddress1Value()
	{
		return this.GetValue(TableUtils.ROAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROAddress1 field.
	/// </summary>
	public string GetROAddress1FieldValue()
	{
		return this.GetValue(TableUtils.ROAddress1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROAddress1 field.
	/// </summary>
	public void SetROAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAddress1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROAddress1 field.
	/// </summary>
	public void SetROAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAddress1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROAddress2 field.
	/// </summary>
	public ColumnValue GetROAddress2Value()
	{
		return this.GetValue(TableUtils.ROAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROAddress2 field.
	/// </summary>
	public string GetROAddress2FieldValue()
	{
		return this.GetValue(TableUtils.ROAddress2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROAddress2 field.
	/// </summary>
	public void SetROAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROAddress2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROAddress2 field.
	/// </summary>
	public void SetROAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROAddress2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROCity field.
	/// </summary>
	public ColumnValue GetROCityValue()
	{
		return this.GetValue(TableUtils.ROCityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROCity field.
	/// </summary>
	public string GetROCityFieldValue()
	{
		return this.GetValue(TableUtils.ROCityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCity field.
	/// </summary>
	public void SetROCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCity field.
	/// </summary>
	public void SetROCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROCategory field.
	/// </summary>
	public ColumnValue GetROCategoryValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROCategory field.
	/// </summary>
	public string GetROCategoryFieldValue()
	{
		return this.GetValue(TableUtils.ROCategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCategory field.
	/// </summary>
	public void SetROCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROContactName field.
	/// </summary>
	public ColumnValue GetROContactNameValue()
	{
		return this.GetValue(TableUtils.ROContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROContactName field.
	/// </summary>
	public string GetROContactNameFieldValue()
	{
		return this.GetValue(TableUtils.ROContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROContactName field.
	/// </summary>
	public void SetROContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROContactName field.
	/// </summary>
	public void SetROContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROCustName field.
	/// </summary>
	public ColumnValue GetROCustNameValue()
	{
		return this.GetValue(TableUtils.ROCustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROCustName field.
	/// </summary>
	public string GetROCustNameFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCustName field.
	/// </summary>
	public void SetROCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCustName field.
	/// </summary>
	public void SetROCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROCustNo field.
	/// </summary>
	public ColumnValue GetROCustNoValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROCustNo field.
	/// </summary>
	public Int32 GetROCustNoFieldValue()
	{
		return this.GetValue(TableUtils.ROCustNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCustNo field.
	/// </summary>
	public void SetROCustNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROCustNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.RODesc field.
	/// </summary>
	public ColumnValue GetRODescValue()
	{
		return this.GetValue(TableUtils.RODescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.RODesc field.
	/// </summary>
	public string GetRODescFieldValue()
	{
		return this.GetValue(TableUtils.RODescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.RODesc field.
	/// </summary>
	public void SetRODescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RODescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.RODesc field.
	/// </summary>
	public void SetRODescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RODescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROEmail field.
	/// </summary>
	public ColumnValue GetROEmailValue()
	{
		return this.GetValue(TableUtils.ROEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROEmail field.
	/// </summary>
	public string GetROEmailFieldValue()
	{
		return this.GetValue(TableUtils.ROEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROEmail field.
	/// </summary>
	public void SetROEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROEmail field.
	/// </summary>
	public void SetROEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROFax field.
	/// </summary>
	public ColumnValue GetROFaxValue()
	{
		return this.GetValue(TableUtils.ROFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROFax field.
	/// </summary>
	public string GetROFaxFieldValue()
	{
		return this.GetValue(TableUtils.ROFaxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROFax field.
	/// </summary>
	public void SetROFaxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROFax field.
	/// </summary>
	public void SetROFaxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROFaxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROMake field.
	/// </summary>
	public ColumnValue GetROMakeValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROMake field.
	/// </summary>
	public string GetROMakeFieldValue()
	{
		return this.GetValue(TableUtils.ROMakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROMakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROMake field.
	/// </summary>
	public void SetROMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROMakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROModel field.
	/// </summary>
	public ColumnValue GetROModelValue()
	{
		return this.GetValue(TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROModel field.
	/// </summary>
	public string GetROModelFieldValue()
	{
		return this.GetValue(TableUtils.ROModelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROModelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROModel field.
	/// </summary>
	public void SetROModelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROModelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.RONo field.
	/// </summary>
	public ColumnValue GetRONoValue()
	{
		return this.GetValue(TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.RONo field.
	/// </summary>
	public Int32 GetRONoFieldValue()
	{
		return this.GetValue(TableUtils.RONoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(string val)
	{
		this.SetString(val, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.RONo field.
	/// </summary>
	public void SetRONoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RONoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROPayTerms field.
	/// </summary>
	public ColumnValue GetROPayTermsValue()
	{
		return this.GetValue(TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROPayTerms field.
	/// </summary>
	public Byte GetROPayTermsFieldValue()
	{
		return this.GetValue(TableUtils.ROPayTermsColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(string val)
	{
		this.SetString(val, TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPayTermsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPayTerms field.
	/// </summary>
	public void SetROPayTermsFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPayTermsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROPhoneBusiness field.
	/// </summary>
	public ColumnValue GetROPhoneBusinessValue()
	{
		return this.GetValue(TableUtils.ROPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROPhoneBusiness field.
	/// </summary>
	public string GetROPhoneBusinessFieldValue()
	{
		return this.GetValue(TableUtils.ROPhoneBusinessColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPhoneBusiness field.
	/// </summary>
	public void SetROPhoneBusinessFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPhoneBusinessColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPhoneBusiness field.
	/// </summary>
	public void SetROPhoneBusinessFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPhoneBusinessColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROPostalCode field.
	/// </summary>
	public ColumnValue GetROPostalCodeValue()
	{
		return this.GetValue(TableUtils.ROPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROPostalCode field.
	/// </summary>
	public string GetROPostalCodeFieldValue()
	{
		return this.GetValue(TableUtils.ROPostalCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPostalCode field.
	/// </summary>
	public void SetROPostalCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROPostalCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPostalCode field.
	/// </summary>
	public void SetROPostalCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROPostalCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROProblem field.
	/// </summary>
	public ColumnValue GetROProblemValue()
	{
		return this.GetValue(TableUtils.ROProblemColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROProblem field.
	/// </summary>
	public string GetROProblemFieldValue()
	{
		return this.GetValue(TableUtils.ROProblemColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROProblem field.
	/// </summary>
	public void SetROProblemFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROProblemColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROProblem field.
	/// </summary>
	public void SetROProblemFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROProblemColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROProvince field.
	/// </summary>
	public ColumnValue GetROProvinceValue()
	{
		return this.GetValue(TableUtils.ROProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROProvince field.
	/// </summary>
	public string GetROProvinceFieldValue()
	{
		return this.GetValue(TableUtils.ROProvinceColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROProvince field.
	/// </summary>
	public void SetROProvinceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROProvinceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROProvince field.
	/// </summary>
	public void SetROProvinceFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROProvinceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROReference1 field.
	/// </summary>
	public ColumnValue GetROReference1Value()
	{
		return this.GetValue(TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROReference1 field.
	/// </summary>
	public string GetROReference1FieldValue()
	{
		return this.GetValue(TableUtils.ROReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROReference1 field.
	/// </summary>
	public void SetROReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROReference2 field.
	/// </summary>
	public ColumnValue GetROReference2Value()
	{
		return this.GetValue(TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROReference2 field.
	/// </summary>
	public string GetROReference2FieldValue()
	{
		return this.GetValue(TableUtils.ROReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROReference2 field.
	/// </summary>
	public void SetROReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROReference4 field.
	/// </summary>
	public ColumnValue GetROReference4Value()
	{
		return this.GetValue(TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROReference4 field.
	/// </summary>
	public string GetROReference4FieldValue()
	{
		return this.GetValue(TableUtils.ROReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROReference4 field.
	/// </summary>
	public void SetROReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROSerialNo field.
	/// </summary>
	public ColumnValue GetROSerialNoValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.ROSerialNo field.
	/// </summary>
	public string GetROSerialNoFieldValue()
	{
		return this.GetValue(TableUtils.ROSerialNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ROSerialNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROSerialNo field.
	/// </summary>
	public void SetROSerialNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ROSerialNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.CustName field.
	/// </summary>
	public ColumnValue GetCustNameValue()
	{
		return this.GetValue(TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repairorder_report_.CustName field.
	/// </summary>
	public string GetCustNameFieldValue()
	{
		return this.GetValue(TableUtils.CustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.CustName field.
	/// </summary>
	public void SetCustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustNameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROAddress1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROAddress1 field.
	/// </summary>
	public string ROAddress1Default
	{
		get
		{
			return TableUtils.ROAddress1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROAddress2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROAddress2 field.
	/// </summary>
	public string ROAddress2Default
	{
		get
		{
			return TableUtils.ROAddress2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROCity field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCity field.
	/// </summary>
	public string ROCityDefault
	{
		get
		{
			return TableUtils.ROCityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROCategory field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCategory field.
	/// </summary>
	public string ROCategoryDefault
	{
		get
		{
			return TableUtils.ROCategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROContactName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROContactName field.
	/// </summary>
	public string ROContactNameDefault
	{
		get
		{
			return TableUtils.ROContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROCustName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCustName field.
	/// </summary>
	public string ROCustNameDefault
	{
		get
		{
			return TableUtils.ROCustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROCustNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROCustNo field.
	/// </summary>
	public string ROCustNoDefault
	{
		get
		{
			return TableUtils.ROCustNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.RODesc field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.RODesc field.
	/// </summary>
	public string RODescDefault
	{
		get
		{
			return TableUtils.RODescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROEmail field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROEmail field.
	/// </summary>
	public string ROEmailDefault
	{
		get
		{
			return TableUtils.ROEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROFax field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROFax field.
	/// </summary>
	public string ROFaxDefault
	{
		get
		{
			return TableUtils.ROFaxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROMake field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROMake field.
	/// </summary>
	public string ROMakeDefault
	{
		get
		{
			return TableUtils.ROMakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROModel field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROModel field.
	/// </summary>
	public string ROModelDefault
	{
		get
		{
			return TableUtils.ROModelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.RONo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.RONo field.
	/// </summary>
	public string RONoDefault
	{
		get
		{
			return TableUtils.RONoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROPayTerms field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPayTerms field.
	/// </summary>
	public string ROPayTermsDefault
	{
		get
		{
			return TableUtils.ROPayTermsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROPhoneBusiness field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPhoneBusiness field.
	/// </summary>
	public string ROPhoneBusinessDefault
	{
		get
		{
			return TableUtils.ROPhoneBusinessColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROPostalCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROPostalCode field.
	/// </summary>
	public string ROPostalCodeDefault
	{
		get
		{
			return TableUtils.ROPostalCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROProblem field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROProblem field.
	/// </summary>
	public string ROProblemDefault
	{
		get
		{
			return TableUtils.ROProblemColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROProvince field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROProvince field.
	/// </summary>
	public string ROProvinceDefault
	{
		get
		{
			return TableUtils.ROProvinceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROReference1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROReference1 field.
	/// </summary>
	public string ROReference1Default
	{
		get
		{
			return TableUtils.ROReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROReference2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROReference2 field.
	/// </summary>
	public string ROReference2Default
	{
		get
		{
			return TableUtils.ROReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROReference4 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROReference4 field.
	/// </summary>
	public string ROReference4Default
	{
		get
		{
			return TableUtils.ROReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.ROSerialNo field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.ROSerialNo field.
	/// </summary>
	public string ROSerialNoDefault
	{
		get
		{
			return TableUtils.ROSerialNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repairorder_report_.CustName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repairorder_report_.CustName field.
	/// </summary>
	public string CustNameDefault
	{
		get
		{
			return TableUtils.CustNameColumn.DefaultValue;
		}
	}


#endregion

}

}
