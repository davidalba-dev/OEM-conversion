// This class is "generated" and will be overwritten.
// Your customizations should be made in Repair_order_requestRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Repair_order_requestRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Repair_order_requestTable"></see> class.
/// </remarks>
/// <seealso cref="Repair_order_requestTable"></seealso>
/// <seealso cref="Repair_order_requestRecord"></seealso>
public class BaseRepair_order_requestRecord : PrimaryKeyRecord
{

	public readonly static Repair_order_requestTable TableUtils = Repair_order_requestTable.Instance;

	// Constructors
 
	protected BaseRepair_order_requestRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Repair_order_requestRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Repair_order_requestRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Repair_order_requestRecord_ReadRecord); 
	}

	protected BaseRepair_order_requestRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Repair_order_requestRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Repair_order_requestRecord Repair_order_requestRec = (Repair_order_requestRecord)sender;
        if(Repair_order_requestRec != null && !Repair_order_requestRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Repair_order_requestRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Repair_order_requestRecord Repair_order_requestRec = (Repair_order_requestRecord)sender;
        Validate_Inserting();
        if(Repair_order_requestRec != null && !Repair_order_requestRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Repair_order_requestRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Repair_order_requestRecord Repair_order_requestRec = (Repair_order_requestRecord)sender;
        Validate_Updating();
        if(Repair_order_requestRec != null && !Repair_order_requestRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.repair_order_request_id field.
	/// </summary>
	public ColumnValue Getrepair_order_request_idValue()
	{
		return this.GetValue(TableUtils.repair_order_request_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.repair_order_request_id field.
	/// </summary>
	public Int32 Getrepair_order_request_idFieldValue()
	{
		return this.GetValue(TableUtils.repair_order_request_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.custno field.
	/// </summary>
	public ColumnValue GetcustnoValue()
	{
		return this.GetValue(TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.custno field.
	/// </summary>
	public Int32 GetcustnoFieldValue()
	{
		return this.GetValue(TableUtils.custnoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(string val)
	{
		this.SetString(val, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.custno field.
	/// </summary>
	public void SetcustnoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.custnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.serialno field.
	/// </summary>
	public ColumnValue GetserialnoValue()
	{
		return this.GetValue(TableUtils.serialnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.serialno field.
	/// </summary>
	public string GetserialnoFieldValue()
	{
		return this.GetValue(TableUtils.serialnoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.serialno field.
	/// </summary>
	public void SetserialnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serialnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.serialno field.
	/// </summary>
	public void SetserialnoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serialnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.requestor field.
	/// </summary>
	public ColumnValue GetrequestorValue()
	{
		return this.GetValue(TableUtils.requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.requestor field.
	/// </summary>
	public Int32 GetrequestorFieldValue()
	{
		return this.GetValue(TableUtils.requestorColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.requestor field.
	/// </summary>
	public void SetrequestorFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.requestor field.
	/// </summary>
	public void SetrequestorFieldValue(string val)
	{
		this.SetString(val, TableUtils.requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.requestor field.
	/// </summary>
	public void SetrequestorFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.requestor field.
	/// </summary>
	public void SetrequestorFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.requestor field.
	/// </summary>
	public void SetrequestorFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.requestorColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.corp_requestor field.
	/// </summary>
	public ColumnValue Getcorp_requestorValue()
	{
		return this.GetValue(TableUtils.corp_requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.corp_requestor field.
	/// </summary>
	public Int32 Getcorp_requestorFieldValue()
	{
		return this.GetValue(TableUtils.corp_requestorColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corp_requestor field.
	/// </summary>
	public void Setcorp_requestorFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corp_requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corp_requestor field.
	/// </summary>
	public void Setcorp_requestorFieldValue(string val)
	{
		this.SetString(val, TableUtils.corp_requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corp_requestor field.
	/// </summary>
	public void Setcorp_requestorFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corp_requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corp_requestor field.
	/// </summary>
	public void Setcorp_requestorFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corp_requestorColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corp_requestor field.
	/// </summary>
	public void Setcorp_requestorFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corp_requestorColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.repair_request_notes field.
	/// </summary>
	public ColumnValue Getrepair_request_notesValue()
	{
		return this.GetValue(TableUtils.repair_request_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.repair_request_notes field.
	/// </summary>
	public string Getrepair_request_notesFieldValue()
	{
		return this.GetValue(TableUtils.repair_request_notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repair_request_notes field.
	/// </summary>
	public void Setrepair_request_notesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_request_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repair_request_notes field.
	/// </summary>
	public void Setrepair_request_notesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_request_notesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.urgency field.
	/// </summary>
	public ColumnValue GeturgencyValue()
	{
		return this.GetValue(TableUtils.urgencyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.urgency field.
	/// </summary>
	public string GeturgencyFieldValue()
	{
		return this.GetValue(TableUtils.urgencyColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.urgency field.
	/// </summary>
	public void SeturgencyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.urgencyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.urgency field.
	/// </summary>
	public void SeturgencyFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.urgencyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.clean_status field.
	/// </summary>
	public ColumnValue Getclean_statusValue()
	{
		return this.GetValue(TableUtils.clean_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.clean_status field.
	/// </summary>
	public string Getclean_statusFieldValue()
	{
		return this.GetValue(TableUtils.clean_statusColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.clean_status field.
	/// </summary>
	public void Setclean_statusFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.clean_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.clean_status field.
	/// </summary>
	public void Setclean_statusFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.clean_statusColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.processed field.
	/// </summary>
	public ColumnValue GetprocessedValue()
	{
		return this.GetValue(TableUtils.processedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.processed field.
	/// </summary>
	public bool GetprocessedFieldValue()
	{
		return this.GetValue(TableUtils.processedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed field.
	/// </summary>
	public void SetprocessedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.processedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed field.
	/// </summary>
	public void SetprocessedFieldValue(string val)
	{
		this.SetString(val, TableUtils.processedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed field.
	/// </summary>
	public void SetprocessedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.processedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.processed_by field.
	/// </summary>
	public ColumnValue Getprocessed_byValue()
	{
		return this.GetValue(TableUtils.processed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.processed_by field.
	/// </summary>
	public Int32 Getprocessed_byFieldValue()
	{
		return this.GetValue(TableUtils.processed_byColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_by field.
	/// </summary>
	public void Setprocessed_byFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.processed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_by field.
	/// </summary>
	public void Setprocessed_byFieldValue(string val)
	{
		this.SetString(val, TableUtils.processed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_by field.
	/// </summary>
	public void Setprocessed_byFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.processed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_by field.
	/// </summary>
	public void Setprocessed_byFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.processed_byColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_by field.
	/// </summary>
	public void Setprocessed_byFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.processed_byColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.processed_datetime field.
	/// </summary>
	public ColumnValue Getprocessed_datetimeValue()
	{
		return this.GetValue(TableUtils.processed_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.processed_datetime field.
	/// </summary>
	public DateTime Getprocessed_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.processed_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_datetime field.
	/// </summary>
	public void Setprocessed_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.processed_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_datetime field.
	/// </summary>
	public void Setprocessed_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.processed_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_datetime field.
	/// </summary>
	public void Setprocessed_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.processed_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.new_serialno field.
	/// </summary>
	public ColumnValue Getnew_serialnoValue()
	{
		return this.GetValue(TableUtils.new_serialnoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.new_serialno field.
	/// </summary>
	public string Getnew_serialnoFieldValue()
	{
		return this.GetValue(TableUtils.new_serialnoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.new_serialno field.
	/// </summary>
	public void Setnew_serialnoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.new_serialnoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.new_serialno field.
	/// </summary>
	public void Setnew_serialnoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_serialnoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.make field.
	/// </summary>
	public ColumnValue GetmakeValue()
	{
		return this.GetValue(TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.make field.
	/// </summary>
	public string GetmakeFieldValue()
	{
		return this.GetValue(TableUtils.makeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.make field.
	/// </summary>
	public void SetmakeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.makeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.make field.
	/// </summary>
	public void SetmakeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.makeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.model field.
	/// </summary>
	public ColumnValue GetmodelValue()
	{
		return this.GetValue(TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.model field.
	/// </summary>
	public string GetmodelFieldValue()
	{
		return this.GetValue(TableUtils.modelColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.model field.
	/// </summary>
	public void SetmodelFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.modelColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.model field.
	/// </summary>
	public void SetmodelFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.modelColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.repairorder_type field.
	/// </summary>
	public ColumnValue Getrepairorder_typeValue()
	{
		return this.GetValue(TableUtils.repairorder_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.repairorder_type field.
	/// </summary>
	public Int32 Getrepairorder_typeFieldValue()
	{
		return this.GetValue(TableUtils.repairorder_typeColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repairorder_type field.
	/// </summary>
	public void Setrepairorder_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repairorder_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repairorder_type field.
	/// </summary>
	public void Setrepairorder_typeFieldValue(string val)
	{
		this.SetString(val, TableUtils.repairorder_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repairorder_type field.
	/// </summary>
	public void Setrepairorder_typeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repairorder_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repairorder_type field.
	/// </summary>
	public void Setrepairorder_typeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repairorder_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repairorder_type field.
	/// </summary>
	public void Setrepairorder_typeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repairorder_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.request_method field.
	/// </summary>
	public ColumnValue Getrequest_methodValue()
	{
		return this.GetValue(TableUtils.request_methodColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.request_method field.
	/// </summary>
	public string Getrequest_methodFieldValue()
	{
		return this.GetValue(TableUtils.request_methodColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.request_method field.
	/// </summary>
	public void Setrequest_methodFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.request_methodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.request_method field.
	/// </summary>
	public void Setrequest_methodFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_methodColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.repair_request_po field.
	/// </summary>
	public ColumnValue Getrepair_request_poValue()
	{
		return this.GetValue(TableUtils.repair_request_poColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.repair_request_po field.
	/// </summary>
	public string Getrepair_request_poFieldValue()
	{
		return this.GetValue(TableUtils.repair_request_poColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repair_request_po field.
	/// </summary>
	public void Setrepair_request_poFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.repair_request_poColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repair_request_po field.
	/// </summary>
	public void Setrepair_request_poFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.repair_request_poColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.cust_dept_id field.
	/// </summary>
	public ColumnValue Getcust_dept_idValue()
	{
		return this.GetValue(TableUtils.cust_dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.cust_dept_id field.
	/// </summary>
	public Int32 Getcust_dept_idFieldValue()
	{
		return this.GetValue(TableUtils.cust_dept_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.cust_dept_id field.
	/// </summary>
	public void Setcust_dept_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.cust_dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.cust_dept_id field.
	/// </summary>
	public void Setcust_dept_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.cust_dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.cust_dept_id field.
	/// </summary>
	public void Setcust_dept_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.cust_dept_id field.
	/// </summary>
	public void Setcust_dept_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_dept_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.cust_dept_id field.
	/// </summary>
	public void Setcust_dept_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.cust_dept_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.corporatecontact_id field.
	/// </summary>
	public ColumnValue Getcorporatecontact_idValue()
	{
		return this.GetValue(TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.corporatecontact_id field.
	/// </summary>
	public Int32 Getcorporatecontact_idFieldValue()
	{
		return this.GetValue(TableUtils.corporatecontact_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corporatecontact_id field.
	/// </summary>
	public void Setcorporatecontact_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.corporatecontact_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.corp_name field.
	/// </summary>
	public ColumnValue Getcorp_nameValue()
	{
		return this.GetValue(TableUtils.corp_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.corp_name field.
	/// </summary>
	public string Getcorp_nameFieldValue()
	{
		return this.GetValue(TableUtils.corp_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.request_date field.
	/// </summary>
	public ColumnValue Getrequest_dateValue()
	{
		return this.GetValue(TableUtils.request_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's repair_order_request_.request_date field.
	/// </summary>
	public DateTime Getrequest_dateFieldValue()
	{
		return this.GetValue(TableUtils.request_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.request_date field.
	/// </summary>
	public void Setrequest_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.request_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.request_date field.
	/// </summary>
	public void Setrequest_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.request_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.request_date field.
	/// </summary>
	public void Setrequest_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.request_dateColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.repair_order_request_id field.
	/// </summary>
	public Int32 repair_order_request_id
	{
		get
		{
			return this.GetValue(TableUtils.repair_order_request_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_order_request_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_order_request_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_order_request_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repair_order_request_id field.
	/// </summary>
	public string repair_order_request_idDefault
	{
		get
		{
			return TableUtils.repair_order_request_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.custno field.
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
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.custno field.
	/// </summary>
	public string custnoDefault
	{
		get
		{
			return TableUtils.custnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.serialno field.
	/// </summary>
	public string serialno
	{
		get
		{
			return this.GetValue(TableUtils.serialnoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serialnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serialnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serialnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.serialno field.
	/// </summary>
	public string serialnoDefault
	{
		get
		{
			return TableUtils.serialnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.requestor field.
	/// </summary>
	public Int32 requestor
	{
		get
		{
			return this.GetValue(TableUtils.requestorColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.requestorColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool requestorSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.requestorColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.requestor field.
	/// </summary>
	public string requestorDefault
	{
		get
		{
			return TableUtils.requestorColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.corp_requestor field.
	/// </summary>
	public Int32 corp_requestor
	{
		get
		{
			return this.GetValue(TableUtils.corp_requestorColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corp_requestorColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corp_requestorSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corp_requestorColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corp_requestor field.
	/// </summary>
	public string corp_requestorDefault
	{
		get
		{
			return TableUtils.corp_requestorColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.repair_request_notes field.
	/// </summary>
	public string repair_request_notes
	{
		get
		{
			return this.GetValue(TableUtils.repair_request_notesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_request_notesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_request_notesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_request_notesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repair_request_notes field.
	/// </summary>
	public string repair_request_notesDefault
	{
		get
		{
			return TableUtils.repair_request_notesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.urgency field.
	/// </summary>
	public string urgency
	{
		get
		{
			return this.GetValue(TableUtils.urgencyColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.urgencyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool urgencySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.urgencyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.urgency field.
	/// </summary>
	public string urgencyDefault
	{
		get
		{
			return TableUtils.urgencyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.clean_status field.
	/// </summary>
	public string clean_status
	{
		get
		{
			return this.GetValue(TableUtils.clean_statusColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.clean_statusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool clean_statusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.clean_statusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.clean_status field.
	/// </summary>
	public string clean_statusDefault
	{
		get
		{
			return TableUtils.clean_statusColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.processed field.
	/// </summary>
	public bool processed
	{
		get
		{
			return this.GetValue(TableUtils.processedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.processedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool processedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.processedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed field.
	/// </summary>
	public string processedDefault
	{
		get
		{
			return TableUtils.processedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.processed_by field.
	/// </summary>
	public Int32 processed_by
	{
		get
		{
			return this.GetValue(TableUtils.processed_byColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.processed_byColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool processed_bySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.processed_byColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_by field.
	/// </summary>
	public string processed_byDefault
	{
		get
		{
			return TableUtils.processed_byColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.processed_datetime field.
	/// </summary>
	public DateTime processed_datetime
	{
		get
		{
			return this.GetValue(TableUtils.processed_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.processed_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool processed_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.processed_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.processed_datetime field.
	/// </summary>
	public string processed_datetimeDefault
	{
		get
		{
			return TableUtils.processed_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.new_serialno field.
	/// </summary>
	public string new_serialno
	{
		get
		{
			return this.GetValue(TableUtils.new_serialnoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.new_serialnoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool new_serialnoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.new_serialnoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.new_serialno field.
	/// </summary>
	public string new_serialnoDefault
	{
		get
		{
			return TableUtils.new_serialnoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.make field.
	/// </summary>
	public string make
	{
		get
		{
			return this.GetValue(TableUtils.makeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.makeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool makeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.makeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.make field.
	/// </summary>
	public string makeDefault
	{
		get
		{
			return TableUtils.makeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.model field.
	/// </summary>
	public string model
	{
		get
		{
			return this.GetValue(TableUtils.modelColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.modelColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool modelSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.modelColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.model field.
	/// </summary>
	public string modelDefault
	{
		get
		{
			return TableUtils.modelColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.repairorder_type field.
	/// </summary>
	public Int32 repairorder_type
	{
		get
		{
			return this.GetValue(TableUtils.repairorder_typeColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repairorder_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repairorder_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repairorder_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repairorder_type field.
	/// </summary>
	public string repairorder_typeDefault
	{
		get
		{
			return TableUtils.repairorder_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.request_method field.
	/// </summary>
	public string request_method
	{
		get
		{
			return this.GetValue(TableUtils.request_methodColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.request_methodColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool request_methodSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.request_methodColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.request_method field.
	/// </summary>
	public string request_methodDefault
	{
		get
		{
			return TableUtils.request_methodColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.repair_request_po field.
	/// </summary>
	public string repair_request_po
	{
		get
		{
			return this.GetValue(TableUtils.repair_request_poColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.repair_request_poColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool repair_request_poSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.repair_request_poColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.repair_request_po field.
	/// </summary>
	public string repair_request_poDefault
	{
		get
		{
			return TableUtils.repair_request_poColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.cust_dept_id field.
	/// </summary>
	public Int32 cust_dept_id
	{
		get
		{
			return this.GetValue(TableUtils.cust_dept_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.cust_dept_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool cust_dept_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.cust_dept_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.cust_dept_id field.
	/// </summary>
	public string cust_dept_idDefault
	{
		get
		{
			return TableUtils.cust_dept_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.corporatecontact_id field.
	/// </summary>
	public Int32 corporatecontact_id
	{
		get
		{
			return this.GetValue(TableUtils.corporatecontact_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corporatecontact_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corporatecontact_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corporatecontact_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corporatecontact_id field.
	/// </summary>
	public string corporatecontact_idDefault
	{
		get
		{
			return TableUtils.corporatecontact_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.corp_name field.
	/// </summary>
	public string corp_name
	{
		get
		{
			return this.GetValue(TableUtils.corp_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.corp_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool corp_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.corp_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.corp_name field.
	/// </summary>
	public string corp_nameDefault
	{
		get
		{
			return TableUtils.corp_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's repair_order_request_.request_date field.
	/// </summary>
	public DateTime request_date
	{
		get
		{
			return this.GetValue(TableUtils.request_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.request_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool request_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.request_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's repair_order_request_.request_date field.
	/// </summary>
	public string request_dateDefault
	{
		get
		{
			return TableUtils.request_dateColumn.DefaultValue;
		}
	}


#endregion
}

}
