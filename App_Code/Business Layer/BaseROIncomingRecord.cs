// This class is "generated" and will be overwritten.
// Your customizations should be made in ROIncomingRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ROIncomingRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ROIncomingTable"></see> class.
/// </remarks>
/// <seealso cref="ROIncomingTable"></seealso>
/// <seealso cref="ROIncomingRecord"></seealso>
public class BaseROIncomingRecord : PrimaryKeyRecord
{

	public readonly static ROIncomingTable TableUtils = ROIncomingTable.Instance;

	// Constructors
 
	protected BaseROIncomingRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ROIncomingRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ROIncomingRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ROIncomingRecord_ReadRecord); 
	}

	protected BaseROIncomingRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ROIncomingRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ROIncomingRecord ROIncomingRec = (ROIncomingRecord)sender;
        if(ROIncomingRec != null && !ROIncomingRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ROIncomingRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ROIncomingRecord ROIncomingRec = (ROIncomingRecord)sender;
        Validate_Inserting();
        if(ROIncomingRec != null && !ROIncomingRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ROIncomingRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ROIncomingRecord ROIncomingRec = (ROIncomingRecord)sender;
        Validate_Updating();
        if(ROIncomingRec != null && !ROIncomingRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.ROIncoming_id field.
	/// </summary>
	public ColumnValue GetROIncoming_idValue()
	{
		return this.GetValue(TableUtils.ROIncoming_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.ROIncoming_id field.
	/// </summary>
	public Int32 GetROIncoming_idFieldValue()
	{
		return this.GetValue(TableUtils.ROIncoming_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.pass field.
	/// </summary>
	public ColumnValue GetpassValue()
	{
		return this.GetValue(TableUtils.passColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.pass field.
	/// </summary>
	public bool GetpassFieldValue()
	{
		return this.GetValue(TableUtils.passColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.pass field.
	/// </summary>
	public void SetpassFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.passColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.pass field.
	/// </summary>
	public void SetpassFieldValue(string val)
	{
		this.SetString(val, TableUtils.passColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.pass field.
	/// </summary>
	public void SetpassFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.passColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.fail field.
	/// </summary>
	public ColumnValue GetfailValue()
	{
		return this.GetValue(TableUtils.failColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.fail field.
	/// </summary>
	public bool GetfailFieldValue()
	{
		return this.GetValue(TableUtils.failColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.fail field.
	/// </summary>
	public void SetfailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.failColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.fail field.
	/// </summary>
	public void SetfailFieldValue(string val)
	{
		this.SetString(val, TableUtils.failColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.fail field.
	/// </summary>
	public void SetfailFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.failColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.tech_observations field.
	/// </summary>
	public ColumnValue Gettech_observationsValue()
	{
		return this.GetValue(TableUtils.tech_observationsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.tech_observations field.
	/// </summary>
	public string Gettech_observationsFieldValue()
	{
		return this.GetValue(TableUtils.tech_observationsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.tech_observations field.
	/// </summary>
	public void Settech_observationsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.tech_observationsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.tech_observations field.
	/// </summary>
	public void Settech_observationsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.tech_observationsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.incoming_u field.
	/// </summary>
	public ColumnValue Getincoming_uValue()
	{
		return this.GetValue(TableUtils.incoming_uColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.incoming_u field.
	/// </summary>
	public Int32 Getincoming_uFieldValue()
	{
		return this.GetValue(TableUtils.incoming_uColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_u field.
	/// </summary>
	public void Setincoming_uFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.incoming_uColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_u field.
	/// </summary>
	public void Setincoming_uFieldValue(string val)
	{
		this.SetString(val, TableUtils.incoming_uColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_u field.
	/// </summary>
	public void Setincoming_uFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.incoming_uColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_u field.
	/// </summary>
	public void Setincoming_uFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.incoming_uColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_u field.
	/// </summary>
	public void Setincoming_uFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.incoming_uColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.incoming_d field.
	/// </summary>
	public ColumnValue Getincoming_dValue()
	{
		return this.GetValue(TableUtils.incoming_dColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.incoming_d field.
	/// </summary>
	public Int32 Getincoming_dFieldValue()
	{
		return this.GetValue(TableUtils.incoming_dColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_d field.
	/// </summary>
	public void Setincoming_dFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.incoming_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_d field.
	/// </summary>
	public void Setincoming_dFieldValue(string val)
	{
		this.SetString(val, TableUtils.incoming_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_d field.
	/// </summary>
	public void Setincoming_dFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.incoming_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_d field.
	/// </summary>
	public void Setincoming_dFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.incoming_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_d field.
	/// </summary>
	public void Setincoming_dFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.incoming_dColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.in_angulation_l field.
	/// </summary>
	public ColumnValue Getin_angulation_lValue()
	{
		return this.GetValue(TableUtils.in_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.in_angulation_l field.
	/// </summary>
	public Int32 Getin_angulation_lFieldValue()
	{
		return this.GetValue(TableUtils.in_angulation_lColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulation_l field.
	/// </summary>
	public void Setin_angulation_lFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.in_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulation_l field.
	/// </summary>
	public void Setin_angulation_lFieldValue(string val)
	{
		this.SetString(val, TableUtils.in_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulation_l field.
	/// </summary>
	public void Setin_angulation_lFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.in_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulation_l field.
	/// </summary>
	public void Setin_angulation_lFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.in_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulation_l field.
	/// </summary>
	public void Setin_angulation_lFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.in_angulation_lColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.in_angulatoin_r field.
	/// </summary>
	public ColumnValue Getin_angulatoin_rValue()
	{
		return this.GetValue(TableUtils.in_angulatoin_rColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.in_angulatoin_r field.
	/// </summary>
	public Int32 Getin_angulatoin_rFieldValue()
	{
		return this.GetValue(TableUtils.in_angulatoin_rColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulatoin_r field.
	/// </summary>
	public void Setin_angulatoin_rFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.in_angulatoin_rColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulatoin_r field.
	/// </summary>
	public void Setin_angulatoin_rFieldValue(string val)
	{
		this.SetString(val, TableUtils.in_angulatoin_rColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulatoin_r field.
	/// </summary>
	public void Setin_angulatoin_rFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.in_angulatoin_rColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulatoin_r field.
	/// </summary>
	public void Setin_angulatoin_rFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.in_angulatoin_rColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulatoin_r field.
	/// </summary>
	public void Setin_angulatoin_rFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.in_angulatoin_rColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.outgoing_u field.
	/// </summary>
	public ColumnValue Getoutgoing_uValue()
	{
		return this.GetValue(TableUtils.outgoing_uColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.outgoing_u field.
	/// </summary>
	public Int32 Getoutgoing_uFieldValue()
	{
		return this.GetValue(TableUtils.outgoing_uColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_u field.
	/// </summary>
	public void Setoutgoing_uFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.outgoing_uColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_u field.
	/// </summary>
	public void Setoutgoing_uFieldValue(string val)
	{
		this.SetString(val, TableUtils.outgoing_uColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_u field.
	/// </summary>
	public void Setoutgoing_uFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.outgoing_uColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_u field.
	/// </summary>
	public void Setoutgoing_uFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.outgoing_uColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_u field.
	/// </summary>
	public void Setoutgoing_uFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.outgoing_uColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.outgoing_d field.
	/// </summary>
	public ColumnValue Getoutgoing_dValue()
	{
		return this.GetValue(TableUtils.outgoing_dColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.outgoing_d field.
	/// </summary>
	public Int32 Getoutgoing_dFieldValue()
	{
		return this.GetValue(TableUtils.outgoing_dColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_d field.
	/// </summary>
	public void Setoutgoing_dFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.outgoing_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_d field.
	/// </summary>
	public void Setoutgoing_dFieldValue(string val)
	{
		this.SetString(val, TableUtils.outgoing_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_d field.
	/// </summary>
	public void Setoutgoing_dFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.outgoing_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_d field.
	/// </summary>
	public void Setoutgoing_dFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.outgoing_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_d field.
	/// </summary>
	public void Setoutgoing_dFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.outgoing_dColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.out_angulation_l field.
	/// </summary>
	public ColumnValue Getout_angulation_lValue()
	{
		return this.GetValue(TableUtils.out_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.out_angulation_l field.
	/// </summary>
	public Int32 Getout_angulation_lFieldValue()
	{
		return this.GetValue(TableUtils.out_angulation_lColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_l field.
	/// </summary>
	public void Setout_angulation_lFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.out_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_l field.
	/// </summary>
	public void Setout_angulation_lFieldValue(string val)
	{
		this.SetString(val, TableUtils.out_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_l field.
	/// </summary>
	public void Setout_angulation_lFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.out_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_l field.
	/// </summary>
	public void Setout_angulation_lFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.out_angulation_lColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_l field.
	/// </summary>
	public void Setout_angulation_lFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.out_angulation_lColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.out_angulation_d field.
	/// </summary>
	public ColumnValue Getout_angulation_dValue()
	{
		return this.GetValue(TableUtils.out_angulation_dColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.out_angulation_d field.
	/// </summary>
	public Int32 Getout_angulation_dFieldValue()
	{
		return this.GetValue(TableUtils.out_angulation_dColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_d field.
	/// </summary>
	public void Setout_angulation_dFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.out_angulation_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_d field.
	/// </summary>
	public void Setout_angulation_dFieldValue(string val)
	{
		this.SetString(val, TableUtils.out_angulation_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_d field.
	/// </summary>
	public void Setout_angulation_dFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.out_angulation_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_d field.
	/// </summary>
	public void Setout_angulation_dFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.out_angulation_dColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_d field.
	/// </summary>
	public void Setout_angulation_dFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.out_angulation_dColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.rono field.
	/// </summary>
	public ColumnValue GetronoValue()
	{
		return this.GetValue(TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.rono field.
	/// </summary>
	public Int32 GetronoFieldValue()
	{
		return this.GetValue(TableUtils.ronoColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.rono field.
	/// </summary>
	public void SetronoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.rono field.
	/// </summary>
	public void SetronoFieldValue(string val)
	{
		this.SetString(val, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.rono field.
	/// </summary>
	public void SetronoFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.rono field.
	/// </summary>
	public void SetronoFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.rono field.
	/// </summary>
	public void SetronoFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ronoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.technician_id field.
	/// </summary>
	public ColumnValue Gettechnician_idValue()
	{
		return this.GetValue(TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.technician_id field.
	/// </summary>
	public Int32 Gettechnician_idFieldValue()
	{
		return this.GetValue(TableUtils.technician_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.technician_id field.
	/// </summary>
	public void Settechnician_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.technician_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.incoming_datetime field.
	/// </summary>
	public ColumnValue Getincoming_datetimeValue()
	{
		return this.GetValue(TableUtils.incoming_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.incoming_datetime field.
	/// </summary>
	public DateTime Getincoming_datetimeFieldValue()
	{
		return this.GetValue(TableUtils.incoming_datetimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_datetime field.
	/// </summary>
	public void Setincoming_datetimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.incoming_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_datetime field.
	/// </summary>
	public void Setincoming_datetimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.incoming_datetimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_datetime field.
	/// </summary>
	public void Setincoming_datetimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.incoming_datetimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_leaktest field.
	/// </summary>
	public ColumnValue Getcomp_leaktestValue()
	{
		return this.GetValue(TableUtils.comp_leaktestColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_leaktest field.
	/// </summary>
	public Int32 Getcomp_leaktestFieldValue()
	{
		return this.GetValue(TableUtils.comp_leaktestColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_leaktest field.
	/// </summary>
	public void Setcomp_leaktestFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_leaktestColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_leaktest field.
	/// </summary>
	public void Setcomp_leaktestFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_leaktestColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_leaktest field.
	/// </summary>
	public void Setcomp_leaktestFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_leaktestColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_leaktest field.
	/// </summary>
	public void Setcomp_leaktestFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_leaktestColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_leaktest field.
	/// </summary>
	public void Setcomp_leaktestFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_leaktestColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_leaktest_obs field.
	/// </summary>
	public ColumnValue Getcomp_leaktest_obsValue()
	{
		return this.GetValue(TableUtils.comp_leaktest_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_leaktest_obs field.
	/// </summary>
	public string Getcomp_leaktest_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_leaktest_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_leaktest_obs field.
	/// </summary>
	public void Setcomp_leaktest_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_leaktest_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_leaktest_obs field.
	/// </summary>
	public void Setcomp_leaktest_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_leaktest_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_fluidcheck field.
	/// </summary>
	public ColumnValue Getcomp_fluidcheckValue()
	{
		return this.GetValue(TableUtils.comp_fluidcheckColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_fluidcheck field.
	/// </summary>
	public Int32 Getcomp_fluidcheckFieldValue()
	{
		return this.GetValue(TableUtils.comp_fluidcheckColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_fluidcheck field.
	/// </summary>
	public void Setcomp_fluidcheckFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_fluidcheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_fluidcheck field.
	/// </summary>
	public void Setcomp_fluidcheckFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_fluidcheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_fluidcheck field.
	/// </summary>
	public void Setcomp_fluidcheckFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_fluidcheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_fluidcheck field.
	/// </summary>
	public void Setcomp_fluidcheckFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_fluidcheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_fluidcheck field.
	/// </summary>
	public void Setcomp_fluidcheckFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_fluidcheckColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_fluidcheck_obs field.
	/// </summary>
	public ColumnValue Getcomp_fluidcheck_obsValue()
	{
		return this.GetValue(TableUtils.comp_fluidcheck_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_fluidcheck_obs field.
	/// </summary>
	public string Getcomp_fluidcheck_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_fluidcheck_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_fluidcheck_obs field.
	/// </summary>
	public void Setcomp_fluidcheck_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_fluidcheck_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_fluidcheck_obs field.
	/// </summary>
	public void Setcomp_fluidcheck_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_fluidcheck_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_ocular field.
	/// </summary>
	public ColumnValue Getcomp_ocularValue()
	{
		return this.GetValue(TableUtils.comp_ocularColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_ocular field.
	/// </summary>
	public Int32 Getcomp_ocularFieldValue()
	{
		return this.GetValue(TableUtils.comp_ocularColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ocular field.
	/// </summary>
	public void Setcomp_ocularFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_ocularColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ocular field.
	/// </summary>
	public void Setcomp_ocularFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_ocularColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ocular field.
	/// </summary>
	public void Setcomp_ocularFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_ocularColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ocular field.
	/// </summary>
	public void Setcomp_ocularFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_ocularColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ocular field.
	/// </summary>
	public void Setcomp_ocularFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_ocularColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_ocular_obs field.
	/// </summary>
	public ColumnValue Getcomp_ocular_obsValue()
	{
		return this.GetValue(TableUtils.comp_ocular_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_ocular_obs field.
	/// </summary>
	public string Getcomp_ocular_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_ocular_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ocular_obs field.
	/// </summary>
	public void Setcomp_ocular_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_ocular_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ocular_obs field.
	/// </summary>
	public void Setcomp_ocular_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_ocular_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_image field.
	/// </summary>
	public ColumnValue Getcomp_imageValue()
	{
		return this.GetValue(TableUtils.comp_imageColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_image field.
	/// </summary>
	public Int32 Getcomp_imageFieldValue()
	{
		return this.GetValue(TableUtils.comp_imageColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_image field.
	/// </summary>
	public void Setcomp_imageFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_imageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_image field.
	/// </summary>
	public void Setcomp_imageFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_imageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_image field.
	/// </summary>
	public void Setcomp_imageFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_imageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_image field.
	/// </summary>
	public void Setcomp_imageFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_imageColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_image field.
	/// </summary>
	public void Setcomp_imageFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_imageColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_image_obs field.
	/// </summary>
	public ColumnValue Getcomp_image_obsValue()
	{
		return this.GetValue(TableUtils.comp_image_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_image_obs field.
	/// </summary>
	public string Getcomp_image_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_image_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_image_obs field.
	/// </summary>
	public void Setcomp_image_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_image_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_image_obs field.
	/// </summary>
	public void Setcomp_image_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_image_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightout field.
	/// </summary>
	public ColumnValue Getcomp_lightoutValue()
	{
		return this.GetValue(TableUtils.comp_lightoutColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightout field.
	/// </summary>
	public Int32 Getcomp_lightoutFieldValue()
	{
		return this.GetValue(TableUtils.comp_lightoutColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightout field.
	/// </summary>
	public void Setcomp_lightoutFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_lightoutColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightout field.
	/// </summary>
	public void Setcomp_lightoutFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_lightoutColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightout field.
	/// </summary>
	public void Setcomp_lightoutFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightoutColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightout field.
	/// </summary>
	public void Setcomp_lightoutFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightoutColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightout field.
	/// </summary>
	public void Setcomp_lightoutFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightoutColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightout_obs field.
	/// </summary>
	public ColumnValue Getcomp_lightout_obsValue()
	{
		return this.GetValue(TableUtils.comp_lightout_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightout_obs field.
	/// </summary>
	public string Getcomp_lightout_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_lightout_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightout_obs field.
	/// </summary>
	public void Setcomp_lightout_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_lightout_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightout_obs field.
	/// </summary>
	public void Setcomp_lightout_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightout_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_switches field.
	/// </summary>
	public ColumnValue Getcomp_switchesValue()
	{
		return this.GetValue(TableUtils.comp_switchesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_switches field.
	/// </summary>
	public Int32 Getcomp_switchesFieldValue()
	{
		return this.GetValue(TableUtils.comp_switchesColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_switches field.
	/// </summary>
	public void Setcomp_switchesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_switchesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_switches field.
	/// </summary>
	public void Setcomp_switchesFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_switchesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_switches field.
	/// </summary>
	public void Setcomp_switchesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_switchesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_switches field.
	/// </summary>
	public void Setcomp_switchesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_switchesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_switches field.
	/// </summary>
	public void Setcomp_switchesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_switchesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_switches_obs field.
	/// </summary>
	public ColumnValue Getcomp_switches_obsValue()
	{
		return this.GetValue(TableUtils.comp_switches_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_switches_obs field.
	/// </summary>
	public string Getcomp_switches_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_switches_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_switches_obs field.
	/// </summary>
	public void Setcomp_switches_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_switches_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_switches_obs field.
	/// </summary>
	public void Setcomp_switches_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_switches_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_aw field.
	/// </summary>
	public ColumnValue Getcomp_awValue()
	{
		return this.GetValue(TableUtils.comp_awColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_aw field.
	/// </summary>
	public Int32 Getcomp_awFieldValue()
	{
		return this.GetValue(TableUtils.comp_awColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_aw field.
	/// </summary>
	public void Setcomp_awFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_awColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_aw field.
	/// </summary>
	public void Setcomp_awFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_awColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_aw field.
	/// </summary>
	public void Setcomp_awFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_awColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_aw field.
	/// </summary>
	public void Setcomp_awFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_awColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_aw field.
	/// </summary>
	public void Setcomp_awFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_awColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_aw_obs field.
	/// </summary>
	public ColumnValue Getcomp_aw_obsValue()
	{
		return this.GetValue(TableUtils.comp_aw_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_aw_obs field.
	/// </summary>
	public string Getcomp_aw_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_aw_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_aw_obs field.
	/// </summary>
	public void Setcomp_aw_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_aw_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_aw_obs field.
	/// </summary>
	public void Setcomp_aw_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_aw_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_suction field.
	/// </summary>
	public ColumnValue Getcomp_suctionValue()
	{
		return this.GetValue(TableUtils.comp_suctionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_suction field.
	/// </summary>
	public Int32 Getcomp_suctionFieldValue()
	{
		return this.GetValue(TableUtils.comp_suctionColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_suction field.
	/// </summary>
	public void Setcomp_suctionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_suctionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_suction field.
	/// </summary>
	public void Setcomp_suctionFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_suctionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_suction field.
	/// </summary>
	public void Setcomp_suctionFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_suctionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_suction field.
	/// </summary>
	public void Setcomp_suctionFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_suctionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_suction field.
	/// </summary>
	public void Setcomp_suctionFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_suctionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_suction_obs field.
	/// </summary>
	public ColumnValue Getcomp_suction_obsValue()
	{
		return this.GetValue(TableUtils.comp_suction_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_suction_obs field.
	/// </summary>
	public string Getcomp_suction_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_suction_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_suction_obs field.
	/// </summary>
	public void Setcomp_suction_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_suction_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_suction_obs field.
	/// </summary>
	public void Setcomp_suction_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_suction_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_elevation field.
	/// </summary>
	public ColumnValue Getcomp_elevationValue()
	{
		return this.GetValue(TableUtils.comp_elevationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_elevation field.
	/// </summary>
	public Int32 Getcomp_elevationFieldValue()
	{
		return this.GetValue(TableUtils.comp_elevationColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_elevation field.
	/// </summary>
	public void Setcomp_elevationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_elevationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_elevation field.
	/// </summary>
	public void Setcomp_elevationFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_elevationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_elevation field.
	/// </summary>
	public void Setcomp_elevationFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_elevationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_elevation field.
	/// </summary>
	public void Setcomp_elevationFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_elevationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_elevation field.
	/// </summary>
	public void Setcomp_elevationFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_elevationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_elevation_obs field.
	/// </summary>
	public ColumnValue Getcomp_elevation_obsValue()
	{
		return this.GetValue(TableUtils.comp_elevation_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_elevation_obs field.
	/// </summary>
	public string Getcomp_elevation_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_elevation_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_elevation_obs field.
	/// </summary>
	public void Setcomp_elevation_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_elevation_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_elevation_obs field.
	/// </summary>
	public void Setcomp_elevation_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_elevation_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_control field.
	/// </summary>
	public ColumnValue Getcomp_controlValue()
	{
		return this.GetValue(TableUtils.comp_controlColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_control field.
	/// </summary>
	public Int32 Getcomp_controlFieldValue()
	{
		return this.GetValue(TableUtils.comp_controlColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_control field.
	/// </summary>
	public void Setcomp_controlFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_controlColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_control field.
	/// </summary>
	public void Setcomp_controlFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_controlColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_control field.
	/// </summary>
	public void Setcomp_controlFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_controlColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_control field.
	/// </summary>
	public void Setcomp_controlFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_controlColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_control field.
	/// </summary>
	public void Setcomp_controlFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_controlColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_control_obs field.
	/// </summary>
	public ColumnValue Getcomp_control_obsValue()
	{
		return this.GetValue(TableUtils.comp_control_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_control_obs field.
	/// </summary>
	public string Getcomp_control_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_control_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_control_obs field.
	/// </summary>
	public void Setcomp_control_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_control_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_control_obs field.
	/// </summary>
	public void Setcomp_control_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_control_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_biopsy field.
	/// </summary>
	public ColumnValue Getcomp_biopsyValue()
	{
		return this.GetValue(TableUtils.comp_biopsyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_biopsy field.
	/// </summary>
	public Int32 Getcomp_biopsyFieldValue()
	{
		return this.GetValue(TableUtils.comp_biopsyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_biopsy field.
	/// </summary>
	public void Setcomp_biopsyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_biopsyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_biopsy field.
	/// </summary>
	public void Setcomp_biopsyFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_biopsyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_biopsy field.
	/// </summary>
	public void Setcomp_biopsyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_biopsyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_biopsy field.
	/// </summary>
	public void Setcomp_biopsyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_biopsyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_biopsy field.
	/// </summary>
	public void Setcomp_biopsyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_biopsyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_biopsy_obs field.
	/// </summary>
	public ColumnValue Getcomp_biopsy_obsValue()
	{
		return this.GetValue(TableUtils.comp_biopsy_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_biopsy_obs field.
	/// </summary>
	public string Getcomp_biopsy_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_biopsy_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_biopsy_obs field.
	/// </summary>
	public void Setcomp_biopsy_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_biopsy_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_biopsy_obs field.
	/// </summary>
	public void Setcomp_biopsy_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_biopsy_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_bending field.
	/// </summary>
	public ColumnValue Getcomp_bendingValue()
	{
		return this.GetValue(TableUtils.comp_bendingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_bending field.
	/// </summary>
	public Int32 Getcomp_bendingFieldValue()
	{
		return this.GetValue(TableUtils.comp_bendingColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bending field.
	/// </summary>
	public void Setcomp_bendingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_bendingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bending field.
	/// </summary>
	public void Setcomp_bendingFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_bendingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bending field.
	/// </summary>
	public void Setcomp_bendingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bendingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bending field.
	/// </summary>
	public void Setcomp_bendingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bendingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bending field.
	/// </summary>
	public void Setcomp_bendingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bendingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_bending_obs field.
	/// </summary>
	public ColumnValue Getcomp_bending_obsValue()
	{
		return this.GetValue(TableUtils.comp_bending_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_bending_obs field.
	/// </summary>
	public string Getcomp_bending_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_bending_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bending_obs field.
	/// </summary>
	public void Setcomp_bending_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_bending_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bending_obs field.
	/// </summary>
	public void Setcomp_bending_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bending_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_insertion field.
	/// </summary>
	public ColumnValue Getcomp_insertionValue()
	{
		return this.GetValue(TableUtils.comp_insertionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_insertion field.
	/// </summary>
	public Int32 Getcomp_insertionFieldValue()
	{
		return this.GetValue(TableUtils.comp_insertionColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_insertion field.
	/// </summary>
	public void Setcomp_insertionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_insertionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_insertion field.
	/// </summary>
	public void Setcomp_insertionFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_insertionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_insertion field.
	/// </summary>
	public void Setcomp_insertionFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_insertionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_insertion field.
	/// </summary>
	public void Setcomp_insertionFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_insertionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_insertion field.
	/// </summary>
	public void Setcomp_insertionFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_insertionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_insertion_obs field.
	/// </summary>
	public ColumnValue Getcomp_insertion_obsValue()
	{
		return this.GetValue(TableUtils.comp_insertion_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_insertion_obs field.
	/// </summary>
	public string Getcomp_insertion_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_insertion_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_insertion_obs field.
	/// </summary>
	public void Setcomp_insertion_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_insertion_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_insertion_obs field.
	/// </summary>
	public void Setcomp_insertion_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_insertion_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightguide field.
	/// </summary>
	public ColumnValue Getcomp_lightguideValue()
	{
		return this.GetValue(TableUtils.comp_lightguideColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightguide field.
	/// </summary>
	public Int32 Getcomp_lightguideFieldValue()
	{
		return this.GetValue(TableUtils.comp_lightguideColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightguide field.
	/// </summary>
	public void Setcomp_lightguideFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_lightguideColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightguide field.
	/// </summary>
	public void Setcomp_lightguideFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_lightguideColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightguide field.
	/// </summary>
	public void Setcomp_lightguideFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightguideColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightguide field.
	/// </summary>
	public void Setcomp_lightguideFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightguideColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightguide field.
	/// </summary>
	public void Setcomp_lightguideFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightguideColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightguide_obs field.
	/// </summary>
	public ColumnValue Getcomp_lightguide_obsValue()
	{
		return this.GetValue(TableUtils.comp_lightguide_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightguide_obs field.
	/// </summary>
	public string Getcomp_lightguide_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_lightguide_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightguide_obs field.
	/// </summary>
	public void Setcomp_lightguide_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_lightguide_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightguide_obs field.
	/// </summary>
	public void Setcomp_lightguide_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightguide_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lgconn field.
	/// </summary>
	public ColumnValue Getcomp_lgconnValue()
	{
		return this.GetValue(TableUtils.comp_lgconnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lgconn field.
	/// </summary>
	public Int32 Getcomp_lgconnFieldValue()
	{
		return this.GetValue(TableUtils.comp_lgconnColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lgconn field.
	/// </summary>
	public void Setcomp_lgconnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_lgconnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lgconn field.
	/// </summary>
	public void Setcomp_lgconnFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_lgconnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lgconn field.
	/// </summary>
	public void Setcomp_lgconnFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lgconnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lgconn field.
	/// </summary>
	public void Setcomp_lgconnFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lgconnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lgconn field.
	/// </summary>
	public void Setcomp_lgconnFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lgconnColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lgconn_obs field.
	/// </summary>
	public ColumnValue Getcomp_lgconn_obsValue()
	{
		return this.GetValue(TableUtils.comp_lgconn_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lgconn_obs field.
	/// </summary>
	public string Getcomp_lgconn_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_lgconn_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lgconn_obs field.
	/// </summary>
	public void Setcomp_lgconn_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_lgconn_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lgconn_obs field.
	/// </summary>
	public void Setcomp_lgconn_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lgconn_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_boots field.
	/// </summary>
	public ColumnValue Getcomp_bootsValue()
	{
		return this.GetValue(TableUtils.comp_bootsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_boots field.
	/// </summary>
	public Int32 Getcomp_bootsFieldValue()
	{
		return this.GetValue(TableUtils.comp_bootsColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_boots field.
	/// </summary>
	public void Setcomp_bootsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_bootsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_boots field.
	/// </summary>
	public void Setcomp_bootsFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_bootsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_boots field.
	/// </summary>
	public void Setcomp_bootsFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bootsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_boots field.
	/// </summary>
	public void Setcomp_bootsFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bootsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_boots field.
	/// </summary>
	public void Setcomp_bootsFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bootsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_boots_obs field.
	/// </summary>
	public ColumnValue Getcomp_boots_obsValue()
	{
		return this.GetValue(TableUtils.comp_boots_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_boots_obs field.
	/// </summary>
	public string Getcomp_boots_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_boots_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_boots_obs field.
	/// </summary>
	public void Setcomp_boots_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_boots_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_boots_obs field.
	/// </summary>
	public void Setcomp_boots_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_boots_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_controlbody field.
	/// </summary>
	public ColumnValue Getcomp_controlbodyValue()
	{
		return this.GetValue(TableUtils.comp_controlbodyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_controlbody field.
	/// </summary>
	public Int32 Getcomp_controlbodyFieldValue()
	{
		return this.GetValue(TableUtils.comp_controlbodyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_controlbody field.
	/// </summary>
	public void Setcomp_controlbodyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_controlbodyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_controlbody field.
	/// </summary>
	public void Setcomp_controlbodyFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_controlbodyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_controlbody field.
	/// </summary>
	public void Setcomp_controlbodyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_controlbodyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_controlbody field.
	/// </summary>
	public void Setcomp_controlbodyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_controlbodyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_controlbody field.
	/// </summary>
	public void Setcomp_controlbodyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_controlbodyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_controlbody_obs field.
	/// </summary>
	public ColumnValue Getcomp_controlbody_obsValue()
	{
		return this.GetValue(TableUtils.comp_controlbody_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_controlbody_obs field.
	/// </summary>
	public string Getcomp_controlbody_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_controlbody_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_controlbody_obs field.
	/// </summary>
	public void Setcomp_controlbody_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_controlbody_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_controlbody_obs field.
	/// </summary>
	public void Setcomp_controlbody_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_controlbody_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_ccover field.
	/// </summary>
	public ColumnValue Getcomp_ccoverValue()
	{
		return this.GetValue(TableUtils.comp_ccoverColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_ccover field.
	/// </summary>
	public Int32 Getcomp_ccoverFieldValue()
	{
		return this.GetValue(TableUtils.comp_ccoverColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ccover field.
	/// </summary>
	public void Setcomp_ccoverFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_ccoverColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ccover field.
	/// </summary>
	public void Setcomp_ccoverFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_ccoverColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ccover field.
	/// </summary>
	public void Setcomp_ccoverFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_ccoverColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ccover field.
	/// </summary>
	public void Setcomp_ccoverFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_ccoverColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ccover field.
	/// </summary>
	public void Setcomp_ccoverFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_ccoverColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_ccover_obs field.
	/// </summary>
	public ColumnValue Getcomp_ccover_obsValue()
	{
		return this.GetValue(TableUtils.comp_ccover_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_ccover_obs field.
	/// </summary>
	public string Getcomp_ccover_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_ccover_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ccover_obs field.
	/// </summary>
	public void Setcomp_ccover_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_ccover_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ccover_obs field.
	/// </summary>
	public void Setcomp_ccover_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_ccover_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_objective field.
	/// </summary>
	public ColumnValue Getcomp_objectiveValue()
	{
		return this.GetValue(TableUtils.comp_objectiveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_objective field.
	/// </summary>
	public Int32 Getcomp_objectiveFieldValue()
	{
		return this.GetValue(TableUtils.comp_objectiveColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_objective field.
	/// </summary>
	public void Setcomp_objectiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_objectiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_objective field.
	/// </summary>
	public void Setcomp_objectiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_objectiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_objective field.
	/// </summary>
	public void Setcomp_objectiveFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_objectiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_objective field.
	/// </summary>
	public void Setcomp_objectiveFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_objectiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_objective field.
	/// </summary>
	public void Setcomp_objectiveFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_objectiveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_objective_obs field.
	/// </summary>
	public ColumnValue Getcomp_objective_obsValue()
	{
		return this.GetValue(TableUtils.comp_objective_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_objective_obs field.
	/// </summary>
	public string Getcomp_objective_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_objective_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_objective_obs field.
	/// </summary>
	public void Setcomp_objective_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_objective_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_objective_obs field.
	/// </summary>
	public void Setcomp_objective_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_objective_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightlens field.
	/// </summary>
	public ColumnValue Getcomp_lightlensValue()
	{
		return this.GetValue(TableUtils.comp_lightlensColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightlens field.
	/// </summary>
	public Int32 Getcomp_lightlensFieldValue()
	{
		return this.GetValue(TableUtils.comp_lightlensColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightlens field.
	/// </summary>
	public void Setcomp_lightlensFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_lightlensColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightlens field.
	/// </summary>
	public void Setcomp_lightlensFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_lightlensColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightlens field.
	/// </summary>
	public void Setcomp_lightlensFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightlensColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightlens field.
	/// </summary>
	public void Setcomp_lightlensFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightlensColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightlens field.
	/// </summary>
	public void Setcomp_lightlensFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightlensColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightlens_obs field.
	/// </summary>
	public ColumnValue Getcomp_lightlens_obsValue()
	{
		return this.GetValue(TableUtils.comp_lightlens_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_lightlens_obs field.
	/// </summary>
	public string Getcomp_lightlens_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_lightlens_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightlens_obs field.
	/// </summary>
	public void Setcomp_lightlens_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_lightlens_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightlens_obs field.
	/// </summary>
	public void Setcomp_lightlens_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_lightlens_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_bendrubber field.
	/// </summary>
	public ColumnValue Getcomp_bendrubberValue()
	{
		return this.GetValue(TableUtils.comp_bendrubberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_bendrubber field.
	/// </summary>
	public Int32 Getcomp_bendrubberFieldValue()
	{
		return this.GetValue(TableUtils.comp_bendrubberColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bendrubber field.
	/// </summary>
	public void Setcomp_bendrubberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_bendrubberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bendrubber field.
	/// </summary>
	public void Setcomp_bendrubberFieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_bendrubberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bendrubber field.
	/// </summary>
	public void Setcomp_bendrubberFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bendrubberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bendrubber field.
	/// </summary>
	public void Setcomp_bendrubberFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bendrubberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bendrubber field.
	/// </summary>
	public void Setcomp_bendrubberFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bendrubberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_bendrubber_obs field.
	/// </summary>
	public ColumnValue Getcomp_bendrubber_obsValue()
	{
		return this.GetValue(TableUtils.comp_bendrubber_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_bendrubber_obs field.
	/// </summary>
	public string Getcomp_bendrubber_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_bendrubber_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bendrubber_obs field.
	/// </summary>
	public void Setcomp_bendrubber_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_bendrubber_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bendrubber_obs field.
	/// </summary>
	public void Setcomp_bendrubber_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_bendrubber_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other1 field.
	/// </summary>
	public ColumnValue Getcomp_other1Value()
	{
		return this.GetValue(TableUtils.comp_other1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other1 field.
	/// </summary>
	public Int32 Getcomp_other1FieldValue()
	{
		return this.GetValue(TableUtils.comp_other1Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1 field.
	/// </summary>
	public void Setcomp_other1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_other1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1 field.
	/// </summary>
	public void Setcomp_other1FieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_other1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1 field.
	/// </summary>
	public void Setcomp_other1FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1 field.
	/// </summary>
	public void Setcomp_other1FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1 field.
	/// </summary>
	public void Setcomp_other1FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other1_obs field.
	/// </summary>
	public ColumnValue Getcomp_other1_obsValue()
	{
		return this.GetValue(TableUtils.comp_other1_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other1_obs field.
	/// </summary>
	public string Getcomp_other1_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_other1_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1_obs field.
	/// </summary>
	public void Setcomp_other1_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_other1_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1_obs field.
	/// </summary>
	public void Setcomp_other1_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other1_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other2 field.
	/// </summary>
	public ColumnValue Getcomp_other2Value()
	{
		return this.GetValue(TableUtils.comp_other2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other2 field.
	/// </summary>
	public Int32 Getcomp_other2FieldValue()
	{
		return this.GetValue(TableUtils.comp_other2Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2 field.
	/// </summary>
	public void Setcomp_other2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_other2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2 field.
	/// </summary>
	public void Setcomp_other2FieldValue(string val)
	{
		this.SetString(val, TableUtils.comp_other2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2 field.
	/// </summary>
	public void Setcomp_other2FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2 field.
	/// </summary>
	public void Setcomp_other2FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2 field.
	/// </summary>
	public void Setcomp_other2FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other2_obs field.
	/// </summary>
	public ColumnValue Getcomp_other2_obsValue()
	{
		return this.GetValue(TableUtils.comp_other2_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other2_obs field.
	/// </summary>
	public string Getcomp_other2_obsFieldValue()
	{
		return this.GetValue(TableUtils.comp_other2_obsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2_obs field.
	/// </summary>
	public void Setcomp_other2_obsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_other2_obsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2_obs field.
	/// </summary>
	public void Setcomp_other2_obsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other2_obsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other1_name field.
	/// </summary>
	public ColumnValue Getcomp_other1_nameValue()
	{
		return this.GetValue(TableUtils.comp_other1_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other1_name field.
	/// </summary>
	public string Getcomp_other1_nameFieldValue()
	{
		return this.GetValue(TableUtils.comp_other1_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1_name field.
	/// </summary>
	public void Setcomp_other1_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_other1_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1_name field.
	/// </summary>
	public void Setcomp_other1_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other1_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other2_name field.
	/// </summary>
	public ColumnValue Getcomp_other2_nameValue()
	{
		return this.GetValue(TableUtils.comp_other2_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.comp_other2_name field.
	/// </summary>
	public string Getcomp_other2_nameFieldValue()
	{
		return this.GetValue(TableUtils.comp_other2_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2_name field.
	/// </summary>
	public void Setcomp_other2_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.comp_other2_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2_name field.
	/// </summary>
	public void Setcomp_other2_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.comp_other2_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.tech_notes field.
	/// </summary>
	public ColumnValue Gettech_notesValue()
	{
		return this.GetValue(TableUtils.tech_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ROIncoming_.tech_notes field.
	/// </summary>
	public string Gettech_notesFieldValue()
	{
		return this.GetValue(TableUtils.tech_notesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.tech_notes field.
	/// </summary>
	public void Settech_notesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.tech_notesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.tech_notes field.
	/// </summary>
	public void Settech_notesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.tech_notesColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.ROIncoming_id field.
	/// </summary>
	public Int32 ROIncoming_id
	{
		get
		{
			return this.GetValue(TableUtils.ROIncoming_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ROIncoming_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ROIncoming_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ROIncoming_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.ROIncoming_id field.
	/// </summary>
	public string ROIncoming_idDefault
	{
		get
		{
			return TableUtils.ROIncoming_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.pass field.
	/// </summary>
	public bool pass
	{
		get
		{
			return this.GetValue(TableUtils.passColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.passColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool passSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.passColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.pass field.
	/// </summary>
	public string passDefault
	{
		get
		{
			return TableUtils.passColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.fail field.
	/// </summary>
	public bool fail
	{
		get
		{
			return this.GetValue(TableUtils.failColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.failColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool failSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.failColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.fail field.
	/// </summary>
	public string failDefault
	{
		get
		{
			return TableUtils.failColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.tech_observations field.
	/// </summary>
	public string tech_observations
	{
		get
		{
			return this.GetValue(TableUtils.tech_observationsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.tech_observationsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool tech_observationsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.tech_observationsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.tech_observations field.
	/// </summary>
	public string tech_observationsDefault
	{
		get
		{
			return TableUtils.tech_observationsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.incoming_u field.
	/// </summary>
	public Int32 incoming_u
	{
		get
		{
			return this.GetValue(TableUtils.incoming_uColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.incoming_uColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool incoming_uSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.incoming_uColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_u field.
	/// </summary>
	public string incoming_uDefault
	{
		get
		{
			return TableUtils.incoming_uColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.incoming_d field.
	/// </summary>
	public Int32 incoming_d
	{
		get
		{
			return this.GetValue(TableUtils.incoming_dColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.incoming_dColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool incoming_dSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.incoming_dColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_d field.
	/// </summary>
	public string incoming_dDefault
	{
		get
		{
			return TableUtils.incoming_dColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.in_angulation_l field.
	/// </summary>
	public Int32 in_angulation_l
	{
		get
		{
			return this.GetValue(TableUtils.in_angulation_lColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.in_angulation_lColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool in_angulation_lSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.in_angulation_lColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulation_l field.
	/// </summary>
	public string in_angulation_lDefault
	{
		get
		{
			return TableUtils.in_angulation_lColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.in_angulatoin_r field.
	/// </summary>
	public Int32 in_angulatoin_r
	{
		get
		{
			return this.GetValue(TableUtils.in_angulatoin_rColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.in_angulatoin_rColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool in_angulatoin_rSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.in_angulatoin_rColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.in_angulatoin_r field.
	/// </summary>
	public string in_angulatoin_rDefault
	{
		get
		{
			return TableUtils.in_angulatoin_rColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.outgoing_u field.
	/// </summary>
	public Int32 outgoing_u
	{
		get
		{
			return this.GetValue(TableUtils.outgoing_uColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.outgoing_uColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool outgoing_uSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.outgoing_uColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_u field.
	/// </summary>
	public string outgoing_uDefault
	{
		get
		{
			return TableUtils.outgoing_uColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.outgoing_d field.
	/// </summary>
	public Int32 outgoing_d
	{
		get
		{
			return this.GetValue(TableUtils.outgoing_dColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.outgoing_dColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool outgoing_dSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.outgoing_dColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.outgoing_d field.
	/// </summary>
	public string outgoing_dDefault
	{
		get
		{
			return TableUtils.outgoing_dColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.out_angulation_l field.
	/// </summary>
	public Int32 out_angulation_l
	{
		get
		{
			return this.GetValue(TableUtils.out_angulation_lColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.out_angulation_lColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool out_angulation_lSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.out_angulation_lColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_l field.
	/// </summary>
	public string out_angulation_lDefault
	{
		get
		{
			return TableUtils.out_angulation_lColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.out_angulation_d field.
	/// </summary>
	public Int32 out_angulation_d
	{
		get
		{
			return this.GetValue(TableUtils.out_angulation_dColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.out_angulation_dColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool out_angulation_dSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.out_angulation_dColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.out_angulation_d field.
	/// </summary>
	public string out_angulation_dDefault
	{
		get
		{
			return TableUtils.out_angulation_dColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.rono field.
	/// </summary>
	public Int32 rono
	{
		get
		{
			return this.GetValue(TableUtils.ronoColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ronoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ronoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ronoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.rono field.
	/// </summary>
	public string ronoDefault
	{
		get
		{
			return TableUtils.ronoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.technician_id field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.technician_id field.
	/// </summary>
	public string technician_idDefault
	{
		get
		{
			return TableUtils.technician_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.incoming_datetime field.
	/// </summary>
	public DateTime incoming_datetime
	{
		get
		{
			return this.GetValue(TableUtils.incoming_datetimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.incoming_datetimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool incoming_datetimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.incoming_datetimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.incoming_datetime field.
	/// </summary>
	public string incoming_datetimeDefault
	{
		get
		{
			return TableUtils.incoming_datetimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_leaktest field.
	/// </summary>
	public Int32 comp_leaktest
	{
		get
		{
			return this.GetValue(TableUtils.comp_leaktestColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_leaktestColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_leaktestSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_leaktestColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_leaktest field.
	/// </summary>
	public string comp_leaktestDefault
	{
		get
		{
			return TableUtils.comp_leaktestColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_leaktest_obs field.
	/// </summary>
	public string comp_leaktest_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_leaktest_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_leaktest_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_leaktest_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_leaktest_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_leaktest_obs field.
	/// </summary>
	public string comp_leaktest_obsDefault
	{
		get
		{
			return TableUtils.comp_leaktest_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_fluidcheck field.
	/// </summary>
	public Int32 comp_fluidcheck
	{
		get
		{
			return this.GetValue(TableUtils.comp_fluidcheckColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_fluidcheckColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_fluidcheckSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_fluidcheckColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_fluidcheck field.
	/// </summary>
	public string comp_fluidcheckDefault
	{
		get
		{
			return TableUtils.comp_fluidcheckColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_fluidcheck_obs field.
	/// </summary>
	public string comp_fluidcheck_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_fluidcheck_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_fluidcheck_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_fluidcheck_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_fluidcheck_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_fluidcheck_obs field.
	/// </summary>
	public string comp_fluidcheck_obsDefault
	{
		get
		{
			return TableUtils.comp_fluidcheck_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_ocular field.
	/// </summary>
	public Int32 comp_ocular
	{
		get
		{
			return this.GetValue(TableUtils.comp_ocularColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_ocularColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_ocularSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_ocularColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ocular field.
	/// </summary>
	public string comp_ocularDefault
	{
		get
		{
			return TableUtils.comp_ocularColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_ocular_obs field.
	/// </summary>
	public string comp_ocular_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_ocular_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_ocular_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_ocular_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_ocular_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ocular_obs field.
	/// </summary>
	public string comp_ocular_obsDefault
	{
		get
		{
			return TableUtils.comp_ocular_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_image field.
	/// </summary>
	public Int32 comp_image
	{
		get
		{
			return this.GetValue(TableUtils.comp_imageColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_imageColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_imageSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_imageColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_image field.
	/// </summary>
	public string comp_imageDefault
	{
		get
		{
			return TableUtils.comp_imageColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_image_obs field.
	/// </summary>
	public string comp_image_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_image_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_image_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_image_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_image_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_image_obs field.
	/// </summary>
	public string comp_image_obsDefault
	{
		get
		{
			return TableUtils.comp_image_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_lightout field.
	/// </summary>
	public Int32 comp_lightout
	{
		get
		{
			return this.GetValue(TableUtils.comp_lightoutColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_lightoutColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_lightoutSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_lightoutColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightout field.
	/// </summary>
	public string comp_lightoutDefault
	{
		get
		{
			return TableUtils.comp_lightoutColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_lightout_obs field.
	/// </summary>
	public string comp_lightout_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_lightout_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_lightout_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_lightout_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_lightout_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightout_obs field.
	/// </summary>
	public string comp_lightout_obsDefault
	{
		get
		{
			return TableUtils.comp_lightout_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_switches field.
	/// </summary>
	public Int32 comp_switches
	{
		get
		{
			return this.GetValue(TableUtils.comp_switchesColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_switchesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_switchesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_switchesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_switches field.
	/// </summary>
	public string comp_switchesDefault
	{
		get
		{
			return TableUtils.comp_switchesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_switches_obs field.
	/// </summary>
	public string comp_switches_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_switches_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_switches_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_switches_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_switches_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_switches_obs field.
	/// </summary>
	public string comp_switches_obsDefault
	{
		get
		{
			return TableUtils.comp_switches_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_aw field.
	/// </summary>
	public Int32 comp_aw
	{
		get
		{
			return this.GetValue(TableUtils.comp_awColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_awColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_awSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_awColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_aw field.
	/// </summary>
	public string comp_awDefault
	{
		get
		{
			return TableUtils.comp_awColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_aw_obs field.
	/// </summary>
	public string comp_aw_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_aw_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_aw_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_aw_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_aw_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_aw_obs field.
	/// </summary>
	public string comp_aw_obsDefault
	{
		get
		{
			return TableUtils.comp_aw_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_suction field.
	/// </summary>
	public Int32 comp_suction
	{
		get
		{
			return this.GetValue(TableUtils.comp_suctionColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_suctionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_suctionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_suctionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_suction field.
	/// </summary>
	public string comp_suctionDefault
	{
		get
		{
			return TableUtils.comp_suctionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_suction_obs field.
	/// </summary>
	public string comp_suction_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_suction_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_suction_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_suction_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_suction_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_suction_obs field.
	/// </summary>
	public string comp_suction_obsDefault
	{
		get
		{
			return TableUtils.comp_suction_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_elevation field.
	/// </summary>
	public Int32 comp_elevation
	{
		get
		{
			return this.GetValue(TableUtils.comp_elevationColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_elevationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_elevationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_elevationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_elevation field.
	/// </summary>
	public string comp_elevationDefault
	{
		get
		{
			return TableUtils.comp_elevationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_elevation_obs field.
	/// </summary>
	public string comp_elevation_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_elevation_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_elevation_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_elevation_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_elevation_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_elevation_obs field.
	/// </summary>
	public string comp_elevation_obsDefault
	{
		get
		{
			return TableUtils.comp_elevation_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_control field.
	/// </summary>
	public Int32 comp_control
	{
		get
		{
			return this.GetValue(TableUtils.comp_controlColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_controlColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_controlSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_controlColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_control field.
	/// </summary>
	public string comp_controlDefault
	{
		get
		{
			return TableUtils.comp_controlColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_control_obs field.
	/// </summary>
	public string comp_control_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_control_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_control_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_control_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_control_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_control_obs field.
	/// </summary>
	public string comp_control_obsDefault
	{
		get
		{
			return TableUtils.comp_control_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_biopsy field.
	/// </summary>
	public Int32 comp_biopsy
	{
		get
		{
			return this.GetValue(TableUtils.comp_biopsyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_biopsyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_biopsySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_biopsyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_biopsy field.
	/// </summary>
	public string comp_biopsyDefault
	{
		get
		{
			return TableUtils.comp_biopsyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_biopsy_obs field.
	/// </summary>
	public string comp_biopsy_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_biopsy_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_biopsy_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_biopsy_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_biopsy_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_biopsy_obs field.
	/// </summary>
	public string comp_biopsy_obsDefault
	{
		get
		{
			return TableUtils.comp_biopsy_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_bending field.
	/// </summary>
	public Int32 comp_bending
	{
		get
		{
			return this.GetValue(TableUtils.comp_bendingColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_bendingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_bendingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_bendingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bending field.
	/// </summary>
	public string comp_bendingDefault
	{
		get
		{
			return TableUtils.comp_bendingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_bending_obs field.
	/// </summary>
	public string comp_bending_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_bending_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_bending_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_bending_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_bending_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bending_obs field.
	/// </summary>
	public string comp_bending_obsDefault
	{
		get
		{
			return TableUtils.comp_bending_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_insertion field.
	/// </summary>
	public Int32 comp_insertion
	{
		get
		{
			return this.GetValue(TableUtils.comp_insertionColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_insertionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_insertionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_insertionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_insertion field.
	/// </summary>
	public string comp_insertionDefault
	{
		get
		{
			return TableUtils.comp_insertionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_insertion_obs field.
	/// </summary>
	public string comp_insertion_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_insertion_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_insertion_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_insertion_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_insertion_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_insertion_obs field.
	/// </summary>
	public string comp_insertion_obsDefault
	{
		get
		{
			return TableUtils.comp_insertion_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_lightguide field.
	/// </summary>
	public Int32 comp_lightguide
	{
		get
		{
			return this.GetValue(TableUtils.comp_lightguideColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_lightguideColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_lightguideSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_lightguideColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightguide field.
	/// </summary>
	public string comp_lightguideDefault
	{
		get
		{
			return TableUtils.comp_lightguideColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_lightguide_obs field.
	/// </summary>
	public string comp_lightguide_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_lightguide_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_lightguide_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_lightguide_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_lightguide_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightguide_obs field.
	/// </summary>
	public string comp_lightguide_obsDefault
	{
		get
		{
			return TableUtils.comp_lightguide_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_lgconn field.
	/// </summary>
	public Int32 comp_lgconn
	{
		get
		{
			return this.GetValue(TableUtils.comp_lgconnColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_lgconnColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_lgconnSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_lgconnColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lgconn field.
	/// </summary>
	public string comp_lgconnDefault
	{
		get
		{
			return TableUtils.comp_lgconnColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_lgconn_obs field.
	/// </summary>
	public string comp_lgconn_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_lgconn_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_lgconn_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_lgconn_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_lgconn_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lgconn_obs field.
	/// </summary>
	public string comp_lgconn_obsDefault
	{
		get
		{
			return TableUtils.comp_lgconn_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_boots field.
	/// </summary>
	public Int32 comp_boots
	{
		get
		{
			return this.GetValue(TableUtils.comp_bootsColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_bootsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_bootsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_bootsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_boots field.
	/// </summary>
	public string comp_bootsDefault
	{
		get
		{
			return TableUtils.comp_bootsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_boots_obs field.
	/// </summary>
	public string comp_boots_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_boots_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_boots_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_boots_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_boots_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_boots_obs field.
	/// </summary>
	public string comp_boots_obsDefault
	{
		get
		{
			return TableUtils.comp_boots_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_controlbody field.
	/// </summary>
	public Int32 comp_controlbody
	{
		get
		{
			return this.GetValue(TableUtils.comp_controlbodyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_controlbodyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_controlbodySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_controlbodyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_controlbody field.
	/// </summary>
	public string comp_controlbodyDefault
	{
		get
		{
			return TableUtils.comp_controlbodyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_controlbody_obs field.
	/// </summary>
	public string comp_controlbody_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_controlbody_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_controlbody_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_controlbody_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_controlbody_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_controlbody_obs field.
	/// </summary>
	public string comp_controlbody_obsDefault
	{
		get
		{
			return TableUtils.comp_controlbody_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_ccover field.
	/// </summary>
	public Int32 comp_ccover
	{
		get
		{
			return this.GetValue(TableUtils.comp_ccoverColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_ccoverColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_ccoverSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_ccoverColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ccover field.
	/// </summary>
	public string comp_ccoverDefault
	{
		get
		{
			return TableUtils.comp_ccoverColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_ccover_obs field.
	/// </summary>
	public string comp_ccover_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_ccover_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_ccover_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_ccover_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_ccover_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_ccover_obs field.
	/// </summary>
	public string comp_ccover_obsDefault
	{
		get
		{
			return TableUtils.comp_ccover_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_objective field.
	/// </summary>
	public Int32 comp_objective
	{
		get
		{
			return this.GetValue(TableUtils.comp_objectiveColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_objectiveColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_objectiveSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_objectiveColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_objective field.
	/// </summary>
	public string comp_objectiveDefault
	{
		get
		{
			return TableUtils.comp_objectiveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_objective_obs field.
	/// </summary>
	public string comp_objective_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_objective_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_objective_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_objective_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_objective_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_objective_obs field.
	/// </summary>
	public string comp_objective_obsDefault
	{
		get
		{
			return TableUtils.comp_objective_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_lightlens field.
	/// </summary>
	public Int32 comp_lightlens
	{
		get
		{
			return this.GetValue(TableUtils.comp_lightlensColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_lightlensColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_lightlensSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_lightlensColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightlens field.
	/// </summary>
	public string comp_lightlensDefault
	{
		get
		{
			return TableUtils.comp_lightlensColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_lightlens_obs field.
	/// </summary>
	public string comp_lightlens_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_lightlens_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_lightlens_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_lightlens_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_lightlens_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_lightlens_obs field.
	/// </summary>
	public string comp_lightlens_obsDefault
	{
		get
		{
			return TableUtils.comp_lightlens_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_bendrubber field.
	/// </summary>
	public Int32 comp_bendrubber
	{
		get
		{
			return this.GetValue(TableUtils.comp_bendrubberColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_bendrubberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_bendrubberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_bendrubberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bendrubber field.
	/// </summary>
	public string comp_bendrubberDefault
	{
		get
		{
			return TableUtils.comp_bendrubberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_bendrubber_obs field.
	/// </summary>
	public string comp_bendrubber_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_bendrubber_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_bendrubber_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_bendrubber_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_bendrubber_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_bendrubber_obs field.
	/// </summary>
	public string comp_bendrubber_obsDefault
	{
		get
		{
			return TableUtils.comp_bendrubber_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_other1 field.
	/// </summary>
	public Int32 comp_other1
	{
		get
		{
			return this.GetValue(TableUtils.comp_other1Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_other1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_other1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_other1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1 field.
	/// </summary>
	public string comp_other1Default
	{
		get
		{
			return TableUtils.comp_other1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_other1_obs field.
	/// </summary>
	public string comp_other1_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_other1_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_other1_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_other1_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_other1_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1_obs field.
	/// </summary>
	public string comp_other1_obsDefault
	{
		get
		{
			return TableUtils.comp_other1_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_other2 field.
	/// </summary>
	public Int32 comp_other2
	{
		get
		{
			return this.GetValue(TableUtils.comp_other2Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_other2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_other2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_other2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2 field.
	/// </summary>
	public string comp_other2Default
	{
		get
		{
			return TableUtils.comp_other2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_other2_obs field.
	/// </summary>
	public string comp_other2_obs
	{
		get
		{
			return this.GetValue(TableUtils.comp_other2_obsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_other2_obsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_other2_obsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_other2_obsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2_obs field.
	/// </summary>
	public string comp_other2_obsDefault
	{
		get
		{
			return TableUtils.comp_other2_obsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_other1_name field.
	/// </summary>
	public string comp_other1_name
	{
		get
		{
			return this.GetValue(TableUtils.comp_other1_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_other1_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_other1_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_other1_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other1_name field.
	/// </summary>
	public string comp_other1_nameDefault
	{
		get
		{
			return TableUtils.comp_other1_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.comp_other2_name field.
	/// </summary>
	public string comp_other2_name
	{
		get
		{
			return this.GetValue(TableUtils.comp_other2_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.comp_other2_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool comp_other2_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.comp_other2_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.comp_other2_name field.
	/// </summary>
	public string comp_other2_nameDefault
	{
		get
		{
			return TableUtils.comp_other2_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ROIncoming_.tech_notes field.
	/// </summary>
	public string tech_notes
	{
		get
		{
			return this.GetValue(TableUtils.tech_notesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.tech_notesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool tech_notesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.tech_notesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ROIncoming_.tech_notes field.
	/// </summary>
	public string tech_notesDefault
	{
		get
		{
			return TableUtils.tech_notesColumn.DefaultValue;
		}
	}


#endregion
}

}
