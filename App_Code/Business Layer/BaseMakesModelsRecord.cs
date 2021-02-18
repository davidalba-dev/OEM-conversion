// This class is "generated" and will be overwritten.
// Your customizations should be made in MakesModelsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="MakesModelsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="MakesModelsTable"></see> class.
/// </remarks>
/// <seealso cref="MakesModelsTable"></seealso>
/// <seealso cref="MakesModelsRecord"></seealso>
public class BaseMakesModelsRecord : PrimaryKeyRecord
{

	public readonly static MakesModelsTable TableUtils = MakesModelsTable.Instance;

	// Constructors
 
	protected BaseMakesModelsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.MakesModelsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.MakesModelsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.MakesModelsRecord_ReadRecord); 
	}

	protected BaseMakesModelsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void MakesModelsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                MakesModelsRecord MakesModelsRec = (MakesModelsRecord)sender;
        if(MakesModelsRec != null && !MakesModelsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void MakesModelsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                MakesModelsRecord MakesModelsRec = (MakesModelsRecord)sender;
        Validate_Inserting();
        if(MakesModelsRec != null && !MakesModelsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void MakesModelsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                MakesModelsRecord MakesModelsRec = (MakesModelsRecord)sender;
        Validate_Updating();
        if(MakesModelsRec != null && !MakesModelsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.Category field.
	/// </summary>
	public ColumnValue GetCategoryValue()
	{
		return this.GetValue(TableUtils.CategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.Category field.
	/// </summary>
	public string GetCategoryFieldValue()
	{
		return this.GetValue(TableUtils.CategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.Category field.
	/// </summary>
	public void SetCategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.Category field.
	/// </summary>
	public void SetCategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.LastExtraction field.
	/// </summary>
	public ColumnValue GetLastExtractionValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.LastExtraction field.
	/// </summary>
	public bool GetLastExtractionFieldValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(string val)
	{
		this.SetString(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastExtractionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.Make field.
	/// </summary>
	public ColumnValue GetMakeValue()
	{
		return this.GetValue(TableUtils.MakeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.Make field.
	/// </summary>
	public string GetMakeFieldValue()
	{
		return this.GetValue(TableUtils.MakeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.Make field.
	/// </summary>
	public void SetMakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MakeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.Make field.
	/// </summary>
	public void SetMakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MakeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.MakKey field.
	/// </summary>
	public ColumnValue GetMakKeyValue()
	{
		return this.GetValue(TableUtils.MakKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.MakKey field.
	/// </summary>
	public string GetMakKeyFieldValue()
	{
		return this.GetValue(TableUtils.MakKeyColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.MakKey field.
	/// </summary>
	public void SetMakKeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MakKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.MakKey field.
	/// </summary>
	public void SetMakKeyFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MakKeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.Model field.
	/// </summary>
	public ColumnValue GetModelValue()
	{
		return this.GetValue(TableUtils.ModelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.Model field.
	/// </summary>
	public string GetModelFieldValue()
	{
		return this.GetValue(TableUtils.ModelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.Model field.
	/// </summary>
	public void SetModelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.Model field.
	/// </summary>
	public void SetModelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelBin field.
	/// </summary>
	public ColumnValue GetModelBinValue()
	{
		return this.GetValue(TableUtils.ModelBinColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelBin field.
	/// </summary>
	public string GetModelBinFieldValue()
	{
		return this.GetValue(TableUtils.ModelBinColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelBin field.
	/// </summary>
	public void SetModelBinFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelBinColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelBin field.
	/// </summary>
	public void SetModelBinFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelBinColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelCopyAttach field.
	/// </summary>
	public ColumnValue GetModelCopyAttachValue()
	{
		return this.GetValue(TableUtils.ModelCopyAttachColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelCopyAttach field.
	/// </summary>
	public bool GetModelCopyAttachFieldValue()
	{
		return this.GetValue(TableUtils.ModelCopyAttachColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelCopyAttach field.
	/// </summary>
	public void SetModelCopyAttachFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelCopyAttachColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelCopyAttach field.
	/// </summary>
	public void SetModelCopyAttachFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelCopyAttachColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelCopyAttach field.
	/// </summary>
	public void SetModelCopyAttachFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelCopyAttachColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelCopyNotes field.
	/// </summary>
	public ColumnValue GetModelCopyNotesValue()
	{
		return this.GetValue(TableUtils.ModelCopyNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelCopyNotes field.
	/// </summary>
	public bool GetModelCopyNotesFieldValue()
	{
		return this.GetValue(TableUtils.ModelCopyNotesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelCopyNotes field.
	/// </summary>
	public void SetModelCopyNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelCopyNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelCopyNotes field.
	/// </summary>
	public void SetModelCopyNotesFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelCopyNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelCopyNotes field.
	/// </summary>
	public void SetModelCopyNotesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelCopyNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelDateRecordUpdated field.
	/// </summary>
	public ColumnValue GetModelDateRecordUpdatedValue()
	{
		return this.GetValue(TableUtils.ModelDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelDateRecordUpdated field.
	/// </summary>
	public DateTime GetModelDateRecordUpdatedFieldValue()
	{
		return this.GetValue(TableUtils.ModelDateRecordUpdatedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelDateRecordUpdated field.
	/// </summary>
	public void SetModelDateRecordUpdatedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelDateRecordUpdated field.
	/// </summary>
	public void SetModelDateRecordUpdatedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelDateRecordUpdatedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelDateRecordUpdated field.
	/// </summary>
	public void SetModelDateRecordUpdatedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelDateRecordUpdatedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelDesc field.
	/// </summary>
	public ColumnValue GetModelDescValue()
	{
		return this.GetValue(TableUtils.ModelDescColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelDesc field.
	/// </summary>
	public string GetModelDescFieldValue()
	{
		return this.GetValue(TableUtils.ModelDescColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelDesc field.
	/// </summary>
	public void SetModelDescFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelDescColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelDesc field.
	/// </summary>
	public void SetModelDescFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelDescColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelExclude field.
	/// </summary>
	public ColumnValue GetModelExcludeValue()
	{
		return this.GetValue(TableUtils.ModelExcludeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelExclude field.
	/// </summary>
	public bool GetModelExcludeFieldValue()
	{
		return this.GetValue(TableUtils.ModelExcludeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExclude field.
	/// </summary>
	public void SetModelExcludeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelExcludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExclude field.
	/// </summary>
	public void SetModelExcludeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelExcludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExclude field.
	/// </summary>
	public void SetModelExcludeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelExcludeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelExportInclude field.
	/// </summary>
	public ColumnValue GetModelExportIncludeValue()
	{
		return this.GetValue(TableUtils.ModelExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelExportInclude field.
	/// </summary>
	public bool GetModelExportIncludeFieldValue()
	{
		return this.GetValue(TableUtils.ModelExportIncludeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExportInclude field.
	/// </summary>
	public void SetModelExportIncludeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExportInclude field.
	/// </summary>
	public void SetModelExportIncludeFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelExportIncludeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExportInclude field.
	/// </summary>
	public void SetModelExportIncludeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelExportIncludeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelExportRecordChanged field.
	/// </summary>
	public ColumnValue GetModelExportRecordChangedValue()
	{
		return this.GetValue(TableUtils.ModelExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelExportRecordChanged field.
	/// </summary>
	public bool GetModelExportRecordChangedFieldValue()
	{
		return this.GetValue(TableUtils.ModelExportRecordChangedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExportRecordChanged field.
	/// </summary>
	public void SetModelExportRecordChangedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExportRecordChanged field.
	/// </summary>
	public void SetModelExportRecordChangedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelExportRecordChangedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExportRecordChanged field.
	/// </summary>
	public void SetModelExportRecordChangedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelExportRecordChangedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelHandling field.
	/// </summary>
	public ColumnValue GetModelHandlingValue()
	{
		return this.GetValue(TableUtils.ModelHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelHandling field.
	/// </summary>
	public Decimal GetModelHandlingFieldValue()
	{
		return this.GetValue(TableUtils.ModelHandlingColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelHandling field.
	/// </summary>
	public void SetModelHandlingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelHandling field.
	/// </summary>
	public void SetModelHandlingFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelHandling field.
	/// </summary>
	public void SetModelHandlingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelHandling field.
	/// </summary>
	public void SetModelHandlingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelHandlingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelHandling field.
	/// </summary>
	public void SetModelHandlingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelHandlingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelIgnoreSerialNoRules field.
	/// </summary>
	public ColumnValue GetModelIgnoreSerialNoRulesValue()
	{
		return this.GetValue(TableUtils.ModelIgnoreSerialNoRulesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelIgnoreSerialNoRules field.
	/// </summary>
	public bool GetModelIgnoreSerialNoRulesFieldValue()
	{
		return this.GetValue(TableUtils.ModelIgnoreSerialNoRulesColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelIgnoreSerialNoRules field.
	/// </summary>
	public void SetModelIgnoreSerialNoRulesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelIgnoreSerialNoRulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelIgnoreSerialNoRules field.
	/// </summary>
	public void SetModelIgnoreSerialNoRulesFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelIgnoreSerialNoRulesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelIgnoreSerialNoRules field.
	/// </summary>
	public void SetModelIgnoreSerialNoRulesFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelIgnoreSerialNoRulesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelLabor field.
	/// </summary>
	public ColumnValue GetModelLaborValue()
	{
		return this.GetValue(TableUtils.ModelLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelLabor field.
	/// </summary>
	public Decimal GetModelLaborFieldValue()
	{
		return this.GetValue(TableUtils.ModelLaborColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelLabor field.
	/// </summary>
	public void SetModelLaborFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelLabor field.
	/// </summary>
	public void SetModelLaborFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelLabor field.
	/// </summary>
	public void SetModelLaborFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelLabor field.
	/// </summary>
	public void SetModelLaborFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelLabor field.
	/// </summary>
	public void SetModelLaborFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelLaborColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelMarkupRate field.
	/// </summary>
	public ColumnValue GetModelMarkupRateValue()
	{
		return this.GetValue(TableUtils.ModelMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelMarkupRate field.
	/// </summary>
	public Single GetModelMarkupRateFieldValue()
	{
		return this.GetValue(TableUtils.ModelMarkupRateColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelMarkupRate field.
	/// </summary>
	public void SetModelMarkupRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelMarkupRate field.
	/// </summary>
	public void SetModelMarkupRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelMarkupRate field.
	/// </summary>
	public void SetModelMarkupRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelMarkupRate field.
	/// </summary>
	public void SetModelMarkupRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelMarkupRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelMarkupRate field.
	/// </summary>
	public void SetModelMarkupRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelMarkupRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelNotes field.
	/// </summary>
	public ColumnValue GetModelNotesValue()
	{
		return this.GetValue(TableUtils.ModelNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelNotes field.
	/// </summary>
	public string GetModelNotesFieldValue()
	{
		return this.GetValue(TableUtils.ModelNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelNotes field.
	/// </summary>
	public void SetModelNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelNotes field.
	/// </summary>
	public void SetModelNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelPackCode field.
	/// </summary>
	public ColumnValue GetModelPackCodeValue()
	{
		return this.GetValue(TableUtils.ModelPackCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelPackCode field.
	/// </summary>
	public string GetModelPackCodeFieldValue()
	{
		return this.GetValue(TableUtils.ModelPackCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelPackCode field.
	/// </summary>
	public void SetModelPackCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelPackCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelPackCode field.
	/// </summary>
	public void SetModelPackCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelPackCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelParts field.
	/// </summary>
	public ColumnValue GetModelPartsValue()
	{
		return this.GetValue(TableUtils.ModelPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelParts field.
	/// </summary>
	public Decimal GetModelPartsFieldValue()
	{
		return this.GetValue(TableUtils.ModelPartsColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelParts field.
	/// </summary>
	public void SetModelPartsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelParts field.
	/// </summary>
	public void SetModelPartsFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelParts field.
	/// </summary>
	public void SetModelPartsFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelParts field.
	/// </summary>
	public void SetModelPartsFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelParts field.
	/// </summary>
	public void SetModelPartsFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelPartsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelPreapproved field.
	/// </summary>
	public ColumnValue GetModelPreapprovedValue()
	{
		return this.GetValue(TableUtils.ModelPreapprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelPreapproved field.
	/// </summary>
	public bool GetModelPreapprovedFieldValue()
	{
		return this.GetValue(TableUtils.ModelPreapprovedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelPreapproved field.
	/// </summary>
	public void SetModelPreapprovedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelPreapprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelPreapproved field.
	/// </summary>
	public void SetModelPreapprovedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelPreapprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelPreapproved field.
	/// </summary>
	public void SetModelPreapprovedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelPreapprovedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReference1 field.
	/// </summary>
	public ColumnValue GetModelReference1Value()
	{
		return this.GetValue(TableUtils.ModelReference1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReference1 field.
	/// </summary>
	public string GetModelReference1FieldValue()
	{
		return this.GetValue(TableUtils.ModelReference1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference1 field.
	/// </summary>
	public void SetModelReference1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelReference1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference1 field.
	/// </summary>
	public void SetModelReference1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReference1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReference2 field.
	/// </summary>
	public ColumnValue GetModelReference2Value()
	{
		return this.GetValue(TableUtils.ModelReference2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReference2 field.
	/// </summary>
	public string GetModelReference2FieldValue()
	{
		return this.GetValue(TableUtils.ModelReference2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference2 field.
	/// </summary>
	public void SetModelReference2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelReference2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference2 field.
	/// </summary>
	public void SetModelReference2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReference2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReference3 field.
	/// </summary>
	public ColumnValue GetModelReference3Value()
	{
		return this.GetValue(TableUtils.ModelReference3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReference3 field.
	/// </summary>
	public string GetModelReference3FieldValue()
	{
		return this.GetValue(TableUtils.ModelReference3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference3 field.
	/// </summary>
	public void SetModelReference3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelReference3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference3 field.
	/// </summary>
	public void SetModelReference3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReference3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReference4 field.
	/// </summary>
	public ColumnValue GetModelReference4Value()
	{
		return this.GetValue(TableUtils.ModelReference4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReference4 field.
	/// </summary>
	public string GetModelReference4FieldValue()
	{
		return this.GetValue(TableUtils.ModelReference4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference4 field.
	/// </summary>
	public void SetModelReference4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelReference4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference4 field.
	/// </summary>
	public void SetModelReference4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReference4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReplaceCostNew field.
	/// </summary>
	public ColumnValue GetModelReplaceCostNewValue()
	{
		return this.GetValue(TableUtils.ModelReplaceCostNewColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReplaceCostNew field.
	/// </summary>
	public Decimal GetModelReplaceCostNewFieldValue()
	{
		return this.GetValue(TableUtils.ModelReplaceCostNewColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostNew field.
	/// </summary>
	public void SetModelReplaceCostNewFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelReplaceCostNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostNew field.
	/// </summary>
	public void SetModelReplaceCostNewFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelReplaceCostNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostNew field.
	/// </summary>
	public void SetModelReplaceCostNewFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReplaceCostNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostNew field.
	/// </summary>
	public void SetModelReplaceCostNewFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReplaceCostNewColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostNew field.
	/// </summary>
	public void SetModelReplaceCostNewFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReplaceCostNewColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReplaceCostRefurbished field.
	/// </summary>
	public ColumnValue GetModelReplaceCostRefurbishedValue()
	{
		return this.GetValue(TableUtils.ModelReplaceCostRefurbishedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelReplaceCostRefurbished field.
	/// </summary>
	public Decimal GetModelReplaceCostRefurbishedFieldValue()
	{
		return this.GetValue(TableUtils.ModelReplaceCostRefurbishedColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostRefurbished field.
	/// </summary>
	public void SetModelReplaceCostRefurbishedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelReplaceCostRefurbishedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostRefurbished field.
	/// </summary>
	public void SetModelReplaceCostRefurbishedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelReplaceCostRefurbishedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostRefurbished field.
	/// </summary>
	public void SetModelReplaceCostRefurbishedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReplaceCostRefurbishedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostRefurbished field.
	/// </summary>
	public void SetModelReplaceCostRefurbishedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReplaceCostRefurbishedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostRefurbished field.
	/// </summary>
	public void SetModelReplaceCostRefurbishedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelReplaceCostRefurbishedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelShipping field.
	/// </summary>
	public ColumnValue GetModelShippingValue()
	{
		return this.GetValue(TableUtils.ModelShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelShipping field.
	/// </summary>
	public Decimal GetModelShippingFieldValue()
	{
		return this.GetValue(TableUtils.ModelShippingColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelShipping field.
	/// </summary>
	public void SetModelShippingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelShipping field.
	/// </summary>
	public void SetModelShippingFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelShipping field.
	/// </summary>
	public void SetModelShippingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelShipping field.
	/// </summary>
	public void SetModelShippingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelShippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelShipping field.
	/// </summary>
	public void SetModelShippingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelShippingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelSubcontractNotes field.
	/// </summary>
	public ColumnValue GetModelSubcontractNotesValue()
	{
		return this.GetValue(TableUtils.ModelSubcontractNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelSubcontractNotes field.
	/// </summary>
	public string GetModelSubcontractNotesFieldValue()
	{
		return this.GetValue(TableUtils.ModelSubcontractNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelSubcontractNotes field.
	/// </summary>
	public void SetModelSubcontractNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelSubcontractNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelSubcontractNotes field.
	/// </summary>
	public void SetModelSubcontractNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelSubcontractNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelTravel field.
	/// </summary>
	public ColumnValue GetModelTravelValue()
	{
		return this.GetValue(TableUtils.ModelTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelTravel field.
	/// </summary>
	public Decimal GetModelTravelFieldValue()
	{
		return this.GetValue(TableUtils.ModelTravelColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelTravel field.
	/// </summary>
	public void SetModelTravelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelTravel field.
	/// </summary>
	public void SetModelTravelFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelTravel field.
	/// </summary>
	public void SetModelTravelFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelTravel field.
	/// </summary>
	public void SetModelTravelFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelTravelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelTravel field.
	/// </summary>
	public void SetModelTravelFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelTravelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelVendNo field.
	/// </summary>
	public ColumnValue GetModelVendNoValue()
	{
		return this.GetValue(TableUtils.ModelVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelVendNo field.
	/// </summary>
	public Int32 GetModelVendNoFieldValue()
	{
		return this.GetValue(TableUtils.ModelVendNoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelVendNo field.
	/// </summary>
	public void SetModelVendNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelVendNo field.
	/// </summary>
	public void SetModelVendNoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelVendNo field.
	/// </summary>
	public void SetModelVendNoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelVendNo field.
	/// </summary>
	public void SetModelVendNoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelVendNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelVendNo field.
	/// </summary>
	public void SetModelVendNoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelVendNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelWarranty field.
	/// </summary>
	public ColumnValue GetModelWarrantyValue()
	{
		return this.GetValue(TableUtils.ModelWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.ModelWarranty field.
	/// </summary>
	public Byte GetModelWarrantyFieldValue()
	{
		return this.GetValue(TableUtils.ModelWarrantyColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelWarranty field.
	/// </summary>
	public void SetModelWarrantyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ModelWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelWarranty field.
	/// </summary>
	public void SetModelWarrantyFieldValue(string val)
	{
		this.SetString(val, TableUtils.ModelWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelWarranty field.
	/// </summary>
	public void SetModelWarrantyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelWarranty field.
	/// </summary>
	public void SetModelWarrantyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelWarrantyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelWarranty field.
	/// </summary>
	public void SetModelWarrantyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ModelWarrantyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.makesmodels_active field.
	/// </summary>
	public ColumnValue Getmakesmodels_activeValue()
	{
		return this.GetValue(TableUtils.makesmodels_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MakesModels_.makesmodels_active field.
	/// </summary>
	public bool Getmakesmodels_activeFieldValue()
	{
		return this.GetValue(TableUtils.makesmodels_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.makesmodels_active field.
	/// </summary>
	public void Setmakesmodels_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.makesmodels_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.makesmodels_active field.
	/// </summary>
	public void Setmakesmodels_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.makesmodels_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.makesmodels_active field.
	/// </summary>
	public void Setmakesmodels_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.makesmodels_activeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.Category field.
	/// </summary>
	public string Category
	{
		get
		{
			return this.GetValue(TableUtils.CategoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CategoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CategorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CategoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.Category field.
	/// </summary>
	public string CategoryDefault
	{
		get
		{
			return TableUtils.CategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.LastExtraction field.
	/// </summary>
	public bool LastExtraction
	{
		get
		{
			return this.GetValue(TableUtils.LastExtractionColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.LastExtractionColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LastExtractionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LastExtractionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.LastExtraction field.
	/// </summary>
	public string LastExtractionDefault
	{
		get
		{
			return TableUtils.LastExtractionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.Make field.
	/// </summary>
	public string Make
	{
		get
		{
			return this.GetValue(TableUtils.MakeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MakeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MakeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MakeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.Make field.
	/// </summary>
	public string MakeDefault
	{
		get
		{
			return TableUtils.MakeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.MakKey field.
	/// </summary>
	public string MakKey
	{
		get
		{
			return this.GetValue(TableUtils.MakKeyColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MakKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MakKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MakKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.MakKey field.
	/// </summary>
	public string MakKeyDefault
	{
		get
		{
			return TableUtils.MakKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.Model field.
	/// </summary>
	public string Model
	{
		get
		{
			return this.GetValue(TableUtils.ModelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.Model field.
	/// </summary>
	public string ModelDefault
	{
		get
		{
			return TableUtils.ModelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelBin field.
	/// </summary>
	public string ModelBin
	{
		get
		{
			return this.GetValue(TableUtils.ModelBinColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelBinColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelBinSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelBinColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelBin field.
	/// </summary>
	public string ModelBinDefault
	{
		get
		{
			return TableUtils.ModelBinColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelCopyAttach field.
	/// </summary>
	public bool ModelCopyAttach
	{
		get
		{
			return this.GetValue(TableUtils.ModelCopyAttachColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ModelCopyAttachColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelCopyAttachSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelCopyAttachColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelCopyAttach field.
	/// </summary>
	public string ModelCopyAttachDefault
	{
		get
		{
			return TableUtils.ModelCopyAttachColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelCopyNotes field.
	/// </summary>
	public bool ModelCopyNotes
	{
		get
		{
			return this.GetValue(TableUtils.ModelCopyNotesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ModelCopyNotesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelCopyNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelCopyNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelCopyNotes field.
	/// </summary>
	public string ModelCopyNotesDefault
	{
		get
		{
			return TableUtils.ModelCopyNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelDateRecordUpdated field.
	/// </summary>
	public DateTime ModelDateRecordUpdated
	{
		get
		{
			return this.GetValue(TableUtils.ModelDateRecordUpdatedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelDateRecordUpdatedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelDateRecordUpdatedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelDateRecordUpdatedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelDateRecordUpdated field.
	/// </summary>
	public string ModelDateRecordUpdatedDefault
	{
		get
		{
			return TableUtils.ModelDateRecordUpdatedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelDesc field.
	/// </summary>
	public string ModelDesc
	{
		get
		{
			return this.GetValue(TableUtils.ModelDescColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelDescColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelDescSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelDescColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelDesc field.
	/// </summary>
	public string ModelDescDefault
	{
		get
		{
			return TableUtils.ModelDescColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelExclude field.
	/// </summary>
	public bool ModelExclude
	{
		get
		{
			return this.GetValue(TableUtils.ModelExcludeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ModelExcludeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelExcludeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelExcludeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExclude field.
	/// </summary>
	public string ModelExcludeDefault
	{
		get
		{
			return TableUtils.ModelExcludeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelExportInclude field.
	/// </summary>
	public bool ModelExportInclude
	{
		get
		{
			return this.GetValue(TableUtils.ModelExportIncludeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ModelExportIncludeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelExportIncludeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelExportIncludeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExportInclude field.
	/// </summary>
	public string ModelExportIncludeDefault
	{
		get
		{
			return TableUtils.ModelExportIncludeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelExportRecordChanged field.
	/// </summary>
	public bool ModelExportRecordChanged
	{
		get
		{
			return this.GetValue(TableUtils.ModelExportRecordChangedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ModelExportRecordChangedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelExportRecordChangedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelExportRecordChangedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelExportRecordChanged field.
	/// </summary>
	public string ModelExportRecordChangedDefault
	{
		get
		{
			return TableUtils.ModelExportRecordChangedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelHandling field.
	/// </summary>
	public Decimal ModelHandling
	{
		get
		{
			return this.GetValue(TableUtils.ModelHandlingColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelHandlingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelHandlingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelHandlingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelHandling field.
	/// </summary>
	public string ModelHandlingDefault
	{
		get
		{
			return TableUtils.ModelHandlingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelIgnoreSerialNoRules field.
	/// </summary>
	public bool ModelIgnoreSerialNoRules
	{
		get
		{
			return this.GetValue(TableUtils.ModelIgnoreSerialNoRulesColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ModelIgnoreSerialNoRulesColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelIgnoreSerialNoRulesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelIgnoreSerialNoRulesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelIgnoreSerialNoRules field.
	/// </summary>
	public string ModelIgnoreSerialNoRulesDefault
	{
		get
		{
			return TableUtils.ModelIgnoreSerialNoRulesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelLabor field.
	/// </summary>
	public Decimal ModelLabor
	{
		get
		{
			return this.GetValue(TableUtils.ModelLaborColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelLaborColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelLaborSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelLaborColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelLabor field.
	/// </summary>
	public string ModelLaborDefault
	{
		get
		{
			return TableUtils.ModelLaborColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelMarkupRate field.
	/// </summary>
	public Single ModelMarkupRate
	{
		get
		{
			return this.GetValue(TableUtils.ModelMarkupRateColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelMarkupRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelMarkupRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelMarkupRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelMarkupRate field.
	/// </summary>
	public string ModelMarkupRateDefault
	{
		get
		{
			return TableUtils.ModelMarkupRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelNotes field.
	/// </summary>
	public string ModelNotes
	{
		get
		{
			return this.GetValue(TableUtils.ModelNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelNotes field.
	/// </summary>
	public string ModelNotesDefault
	{
		get
		{
			return TableUtils.ModelNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelPackCode field.
	/// </summary>
	public string ModelPackCode
	{
		get
		{
			return this.GetValue(TableUtils.ModelPackCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelPackCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelPackCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelPackCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelPackCode field.
	/// </summary>
	public string ModelPackCodeDefault
	{
		get
		{
			return TableUtils.ModelPackCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelParts field.
	/// </summary>
	public Decimal ModelParts
	{
		get
		{
			return this.GetValue(TableUtils.ModelPartsColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelPartsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelPartsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelPartsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelParts field.
	/// </summary>
	public string ModelPartsDefault
	{
		get
		{
			return TableUtils.ModelPartsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelPreapproved field.
	/// </summary>
	public bool ModelPreapproved
	{
		get
		{
			return this.GetValue(TableUtils.ModelPreapprovedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ModelPreapprovedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelPreapprovedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelPreapprovedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelPreapproved field.
	/// </summary>
	public string ModelPreapprovedDefault
	{
		get
		{
			return TableUtils.ModelPreapprovedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelReference1 field.
	/// </summary>
	public string ModelReference1
	{
		get
		{
			return this.GetValue(TableUtils.ModelReference1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelReference1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelReference1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelReference1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference1 field.
	/// </summary>
	public string ModelReference1Default
	{
		get
		{
			return TableUtils.ModelReference1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelReference2 field.
	/// </summary>
	public string ModelReference2
	{
		get
		{
			return this.GetValue(TableUtils.ModelReference2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelReference2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelReference2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelReference2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference2 field.
	/// </summary>
	public string ModelReference2Default
	{
		get
		{
			return TableUtils.ModelReference2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelReference3 field.
	/// </summary>
	public string ModelReference3
	{
		get
		{
			return this.GetValue(TableUtils.ModelReference3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelReference3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelReference3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelReference3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference3 field.
	/// </summary>
	public string ModelReference3Default
	{
		get
		{
			return TableUtils.ModelReference3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelReference4 field.
	/// </summary>
	public string ModelReference4
	{
		get
		{
			return this.GetValue(TableUtils.ModelReference4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelReference4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelReference4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelReference4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReference4 field.
	/// </summary>
	public string ModelReference4Default
	{
		get
		{
			return TableUtils.ModelReference4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelReplaceCostNew field.
	/// </summary>
	public Decimal ModelReplaceCostNew
	{
		get
		{
			return this.GetValue(TableUtils.ModelReplaceCostNewColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelReplaceCostNewColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelReplaceCostNewSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelReplaceCostNewColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostNew field.
	/// </summary>
	public string ModelReplaceCostNewDefault
	{
		get
		{
			return TableUtils.ModelReplaceCostNewColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelReplaceCostRefurbished field.
	/// </summary>
	public Decimal ModelReplaceCostRefurbished
	{
		get
		{
			return this.GetValue(TableUtils.ModelReplaceCostRefurbishedColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelReplaceCostRefurbishedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelReplaceCostRefurbishedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelReplaceCostRefurbishedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelReplaceCostRefurbished field.
	/// </summary>
	public string ModelReplaceCostRefurbishedDefault
	{
		get
		{
			return TableUtils.ModelReplaceCostRefurbishedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelShipping field.
	/// </summary>
	public Decimal ModelShipping
	{
		get
		{
			return this.GetValue(TableUtils.ModelShippingColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelShippingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelShippingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelShippingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelShipping field.
	/// </summary>
	public string ModelShippingDefault
	{
		get
		{
			return TableUtils.ModelShippingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelSubcontractNotes field.
	/// </summary>
	public string ModelSubcontractNotes
	{
		get
		{
			return this.GetValue(TableUtils.ModelSubcontractNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelSubcontractNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelSubcontractNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelSubcontractNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelSubcontractNotes field.
	/// </summary>
	public string ModelSubcontractNotesDefault
	{
		get
		{
			return TableUtils.ModelSubcontractNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelTravel field.
	/// </summary>
	public Decimal ModelTravel
	{
		get
		{
			return this.GetValue(TableUtils.ModelTravelColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelTravelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelTravelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelTravelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelTravel field.
	/// </summary>
	public string ModelTravelDefault
	{
		get
		{
			return TableUtils.ModelTravelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelVendNo field.
	/// </summary>
	public Int32 ModelVendNo
	{
		get
		{
			return this.GetValue(TableUtils.ModelVendNoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelVendNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelVendNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelVendNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelVendNo field.
	/// </summary>
	public string ModelVendNoDefault
	{
		get
		{
			return TableUtils.ModelVendNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.ModelWarranty field.
	/// </summary>
	public Byte ModelWarranty
	{
		get
		{
			return this.GetValue(TableUtils.ModelWarrantyColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ModelWarrantyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ModelWarrantySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ModelWarrantyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.ModelWarranty field.
	/// </summary>
	public string ModelWarrantyDefault
	{
		get
		{
			return TableUtils.ModelWarrantyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MakesModels_.makesmodels_active field.
	/// </summary>
	public bool makesmodels_active
	{
		get
		{
			return this.GetValue(TableUtils.makesmodels_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.makesmodels_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool makesmodels_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.makesmodels_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MakesModels_.makesmodels_active field.
	/// </summary>
	public string makesmodels_activeDefault
	{
		get
		{
			return TableUtils.makesmodels_activeColumn.DefaultValue;
		}
	}


#endregion
}

}
