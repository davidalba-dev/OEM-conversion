// This class is "generated" and will be overwritten.
// Your customizations should be made in TechniciansRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="TechniciansRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="TechniciansTable"></see> class.
/// </remarks>
/// <seealso cref="TechniciansTable"></seealso>
/// <seealso cref="TechniciansRecord"></seealso>
public class BaseTechniciansRecord : PrimaryKeyRecord
{

	public readonly static TechniciansTable TableUtils = TechniciansTable.Instance;

	// Constructors
 
	protected BaseTechniciansRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.TechniciansRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.TechniciansRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.TechniciansRecord_ReadRecord); 
	}

	protected BaseTechniciansRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void TechniciansRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                TechniciansRecord TechniciansRec = (TechniciansRecord)sender;
        if(TechniciansRec != null && !TechniciansRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void TechniciansRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                TechniciansRecord TechniciansRec = (TechniciansRecord)sender;
        Validate_Inserting();
        if(TechniciansRec != null && !TechniciansRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void TechniciansRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                TechniciansRecord TechniciansRec = (TechniciansRecord)sender;
        Validate_Updating();
        if(TechniciansRec != null && !TechniciansRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.LastExtraction field.
	/// </summary>
	public ColumnValue GetLastExtractionValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.LastExtraction field.
	/// </summary>
	public bool GetLastExtractionFieldValue()
	{
		return this.GetValue(TableUtils.LastExtractionColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(string val)
	{
		this.SetString(val, TableUtils.LastExtractionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LastExtraction field.
	/// </summary>
	public void SetLastExtractionFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastExtractionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.LockKey field.
	/// </summary>
	public ColumnValue GetLockKeyValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.LockKey field.
	/// </summary>
	public Int32 GetLockKeyFieldValue()
	{
		return this.GetValue(TableUtils.LockKeyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LockKey field.
	/// </summary>
	public void SetLockKeyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LockKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LockKey field.
	/// </summary>
	public void SetLockKeyFieldValue(string val)
	{
		this.SetString(val, TableUtils.LockKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LockKey field.
	/// </summary>
	public void SetLockKeyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LockKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LockKey field.
	/// </summary>
	public void SetLockKeyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LockKeyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LockKey field.
	/// </summary>
	public void SetLockKeyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LockKeyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechCommLabor field.
	/// </summary>
	public ColumnValue GetTechCommLaborValue()
	{
		return this.GetValue(TableUtils.TechCommLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechCommLabor field.
	/// </summary>
	public Single GetTechCommLaborFieldValue()
	{
		return this.GetValue(TableUtils.TechCommLaborColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommLabor field.
	/// </summary>
	public void SetTechCommLaborFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechCommLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommLabor field.
	/// </summary>
	public void SetTechCommLaborFieldValue(string val)
	{
		this.SetString(val, TableUtils.TechCommLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommLabor field.
	/// </summary>
	public void SetTechCommLaborFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechCommLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommLabor field.
	/// </summary>
	public void SetTechCommLaborFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechCommLaborColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommLabor field.
	/// </summary>
	public void SetTechCommLaborFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechCommLaborColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechCommParts field.
	/// </summary>
	public ColumnValue GetTechCommPartsValue()
	{
		return this.GetValue(TableUtils.TechCommPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechCommParts field.
	/// </summary>
	public Single GetTechCommPartsFieldValue()
	{
		return this.GetValue(TableUtils.TechCommPartsColumn).ToSingle();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommParts field.
	/// </summary>
	public void SetTechCommPartsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechCommPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommParts field.
	/// </summary>
	public void SetTechCommPartsFieldValue(string val)
	{
		this.SetString(val, TableUtils.TechCommPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommParts field.
	/// </summary>
	public void SetTechCommPartsFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechCommPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommParts field.
	/// </summary>
	public void SetTechCommPartsFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechCommPartsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommParts field.
	/// </summary>
	public void SetTechCommPartsFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechCommPartsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechEmail field.
	/// </summary>
	public ColumnValue GetTechEmailValue()
	{
		return this.GetValue(TableUtils.TechEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechEmail field.
	/// </summary>
	public string GetTechEmailFieldValue()
	{
		return this.GetValue(TableUtils.TechEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechEmail field.
	/// </summary>
	public void SetTechEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechEmail field.
	/// </summary>
	public void SetTechEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechFax field.
	/// </summary>
	public ColumnValue GetTechFaxValue()
	{
		return this.GetValue(TableUtils.TechFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechFax field.
	/// </summary>
	public string GetTechFaxFieldValue()
	{
		return this.GetValue(TableUtils.TechFaxColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechFax field.
	/// </summary>
	public void SetTechFaxFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechFaxColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechFax field.
	/// </summary>
	public void SetTechFaxFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechFaxColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechFlatRate field.
	/// </summary>
	public ColumnValue GetTechFlatRateValue()
	{
		return this.GetValue(TableUtils.TechFlatRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechFlatRate field.
	/// </summary>
	public Decimal GetTechFlatRateFieldValue()
	{
		return this.GetValue(TableUtils.TechFlatRateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechFlatRate field.
	/// </summary>
	public void SetTechFlatRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechFlatRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechFlatRate field.
	/// </summary>
	public void SetTechFlatRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.TechFlatRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechFlatRate field.
	/// </summary>
	public void SetTechFlatRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechFlatRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechFlatRate field.
	/// </summary>
	public void SetTechFlatRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechFlatRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechFlatRate field.
	/// </summary>
	public void SetTechFlatRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechFlatRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechHourlyRate field.
	/// </summary>
	public ColumnValue GetTechHourlyRateValue()
	{
		return this.GetValue(TableUtils.TechHourlyRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechHourlyRate field.
	/// </summary>
	public Decimal GetTechHourlyRateFieldValue()
	{
		return this.GetValue(TableUtils.TechHourlyRateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechHourlyRate field.
	/// </summary>
	public void SetTechHourlyRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechHourlyRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechHourlyRate field.
	/// </summary>
	public void SetTechHourlyRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.TechHourlyRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechHourlyRate field.
	/// </summary>
	public void SetTechHourlyRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechHourlyRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechHourlyRate field.
	/// </summary>
	public void SetTechHourlyRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechHourlyRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechHourlyRate field.
	/// </summary>
	public void SetTechHourlyRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechHourlyRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechInitials field.
	/// </summary>
	public ColumnValue GetTechInitialsValue()
	{
		return this.GetValue(TableUtils.TechInitialsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechInitials field.
	/// </summary>
	public string GetTechInitialsFieldValue()
	{
		return this.GetValue(TableUtils.TechInitialsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechInitials field.
	/// </summary>
	public void SetTechInitialsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechInitialsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechInitials field.
	/// </summary>
	public void SetTechInitialsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechInitialsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechMobilePhone field.
	/// </summary>
	public ColumnValue GetTechMobilePhoneValue()
	{
		return this.GetValue(TableUtils.TechMobilePhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechMobilePhone field.
	/// </summary>
	public string GetTechMobilePhoneFieldValue()
	{
		return this.GetValue(TableUtils.TechMobilePhoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechMobilePhone field.
	/// </summary>
	public void SetTechMobilePhoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechMobilePhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechMobilePhone field.
	/// </summary>
	public void SetTechMobilePhoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechMobilePhoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechName field.
	/// </summary>
	public ColumnValue GetTechNameValue()
	{
		return this.GetValue(TableUtils.TechNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechName field.
	/// </summary>
	public string GetTechNameFieldValue()
	{
		return this.GetValue(TableUtils.TechNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechName field.
	/// </summary>
	public void SetTechNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechName field.
	/// </summary>
	public void SetTechNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechPayMethod field.
	/// </summary>
	public ColumnValue GetTechPayMethodValue()
	{
		return this.GetValue(TableUtils.TechPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.TechPayMethod field.
	/// </summary>
	public Byte GetTechPayMethodFieldValue()
	{
		return this.GetValue(TableUtils.TechPayMethodColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechPayMethod field.
	/// </summary>
	public void SetTechPayMethodFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TechPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechPayMethod field.
	/// </summary>
	public void SetTechPayMethodFieldValue(string val)
	{
		this.SetString(val, TableUtils.TechPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechPayMethod field.
	/// </summary>
	public void SetTechPayMethodFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechPayMethod field.
	/// </summary>
	public void SetTechPayMethodFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechPayMethodColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechPayMethod field.
	/// </summary>
	public void SetTechPayMethodFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TechPayMethodColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.SSMA_TimeStamp field.
	/// </summary>
	public ColumnValue GetSSMA_TimeStampValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.SSMA_TimeStamp field.
	/// </summary>
	public byte[] GetSSMA_TimeStampFieldValue()
	{
		return this.GetValue(TableUtils.SSMA_TimeStampColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.technician_active field.
	/// </summary>
	public ColumnValue Gettechnician_activeValue()
	{
		return this.GetValue(TableUtils.technician_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.technician_active field.
	/// </summary>
	public bool Gettechnician_activeFieldValue()
	{
		return this.GetValue(TableUtils.technician_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.technician_active field.
	/// </summary>
	public void Settechnician_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.technician_active field.
	/// </summary>
	public void Settechnician_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.technician_active field.
	/// </summary>
	public void Settechnician_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.technician_login_status field.
	/// </summary>
	public ColumnValue Gettechnician_login_statusValue()
	{
		return this.GetValue(TableUtils.technician_login_statusColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Technicians_.technician_login_status field.
	/// </summary>
	public string Gettechnician_login_statusFieldValue()
	{
		return this.GetValue(TableUtils.technician_login_statusColumn).ToString();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.LastExtraction field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LastExtraction field.
	/// </summary>
	public string LastExtractionDefault
	{
		get
		{
			return TableUtils.LastExtractionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.LockKey field.
	/// </summary>
	public Int32 LockKey
	{
		get
		{
			return this.GetValue(TableUtils.LockKeyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LockKeyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LockKeySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LockKeyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.LockKey field.
	/// </summary>
	public string LockKeyDefault
	{
		get
		{
			return TableUtils.LockKeyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechCommLabor field.
	/// </summary>
	public Single TechCommLabor
	{
		get
		{
			return this.GetValue(TableUtils.TechCommLaborColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechCommLaborColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechCommLaborSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechCommLaborColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommLabor field.
	/// </summary>
	public string TechCommLaborDefault
	{
		get
		{
			return TableUtils.TechCommLaborColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechCommParts field.
	/// </summary>
	public Single TechCommParts
	{
		get
		{
			return this.GetValue(TableUtils.TechCommPartsColumn).ToSingle();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechCommPartsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechCommPartsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechCommPartsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechCommParts field.
	/// </summary>
	public string TechCommPartsDefault
	{
		get
		{
			return TableUtils.TechCommPartsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechEmail field.
	/// </summary>
	public string TechEmail
	{
		get
		{
			return this.GetValue(TableUtils.TechEmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechEmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechEmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechEmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechEmail field.
	/// </summary>
	public string TechEmailDefault
	{
		get
		{
			return TableUtils.TechEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechFax field.
	/// </summary>
	public string TechFax
	{
		get
		{
			return this.GetValue(TableUtils.TechFaxColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechFaxColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechFaxSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechFaxColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechFax field.
	/// </summary>
	public string TechFaxDefault
	{
		get
		{
			return TableUtils.TechFaxColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechFlatRate field.
	/// </summary>
	public Decimal TechFlatRate
	{
		get
		{
			return this.GetValue(TableUtils.TechFlatRateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechFlatRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechFlatRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechFlatRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechFlatRate field.
	/// </summary>
	public string TechFlatRateDefault
	{
		get
		{
			return TableUtils.TechFlatRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechHourlyRate field.
	/// </summary>
	public Decimal TechHourlyRate
	{
		get
		{
			return this.GetValue(TableUtils.TechHourlyRateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechHourlyRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechHourlyRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechHourlyRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechHourlyRate field.
	/// </summary>
	public string TechHourlyRateDefault
	{
		get
		{
			return TableUtils.TechHourlyRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechInitials field.
	/// </summary>
	public string TechInitials
	{
		get
		{
			return this.GetValue(TableUtils.TechInitialsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechInitialsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechInitialsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechInitialsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechInitials field.
	/// </summary>
	public string TechInitialsDefault
	{
		get
		{
			return TableUtils.TechInitialsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechMobilePhone field.
	/// </summary>
	public string TechMobilePhone
	{
		get
		{
			return this.GetValue(TableUtils.TechMobilePhoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechMobilePhoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechMobilePhoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechMobilePhoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechMobilePhone field.
	/// </summary>
	public string TechMobilePhoneDefault
	{
		get
		{
			return TableUtils.TechMobilePhoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechName field.
	/// </summary>
	public string TechName
	{
		get
		{
			return this.GetValue(TableUtils.TechNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechName field.
	/// </summary>
	public string TechNameDefault
	{
		get
		{
			return TableUtils.TechNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.TechPayMethod field.
	/// </summary>
	public Byte TechPayMethod
	{
		get
		{
			return this.GetValue(TableUtils.TechPayMethodColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TechPayMethodColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TechPayMethodSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TechPayMethodColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.TechPayMethod field.
	/// </summary>
	public string TechPayMethodDefault
	{
		get
		{
			return TableUtils.TechPayMethodColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.SSMA_TimeStamp field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.SSMA_TimeStamp field.
	/// </summary>
	public string SSMA_TimeStampDefault
	{
		get
		{
			return TableUtils.SSMA_TimeStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.technician_id field.
	/// </summary>
	public Int32 technician_id
	{
		get
		{
			return this.GetValue(TableUtils.technician_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.technician_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technician_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technician_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.technician_active field.
	/// </summary>
	public bool technician_active
	{
		get
		{
			return this.GetValue(TableUtils.technician_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.technician_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technician_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technician_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.technician_active field.
	/// </summary>
	public string technician_activeDefault
	{
		get
		{
			return TableUtils.technician_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Technicians_.technician_login_status field.
	/// </summary>
	public string technician_login_status
	{
		get
		{
			return this.GetValue(TableUtils.technician_login_statusColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.technician_login_statusColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool technician_login_statusSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.technician_login_statusColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Technicians_.technician_login_status field.
	/// </summary>
	public string technician_login_statusDefault
	{
		get
		{
			return TableUtils.technician_login_statusColumn.DefaultValue;
		}
	}


#endregion
}

}
