// This class is "generated" and will be overwritten.
// Your customizations should be made in Resource_sch_ticket_imgRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Resource_sch_ticket_imgRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Resource_sch_ticket_imgTable"></see> class.
/// </remarks>
/// <seealso cref="Resource_sch_ticket_imgTable"></seealso>
/// <seealso cref="Resource_sch_ticket_imgRecord"></seealso>
public class BaseResource_sch_ticket_imgRecord : PrimaryKeyRecord
{

	public readonly static Resource_sch_ticket_imgTable TableUtils = Resource_sch_ticket_imgTable.Instance;

	// Constructors
 
	protected BaseResource_sch_ticket_imgRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Resource_sch_ticket_imgRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Resource_sch_ticket_imgRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Resource_sch_ticket_imgRecord_ReadRecord); 
	}

	protected BaseResource_sch_ticket_imgRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Resource_sch_ticket_imgRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Resource_sch_ticket_imgRecord Resource_sch_ticket_imgRec = (Resource_sch_ticket_imgRecord)sender;
        if(Resource_sch_ticket_imgRec != null && !Resource_sch_ticket_imgRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Resource_sch_ticket_imgRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Resource_sch_ticket_imgRecord Resource_sch_ticket_imgRec = (Resource_sch_ticket_imgRecord)sender;
        Validate_Inserting();
        if(Resource_sch_ticket_imgRec != null && !Resource_sch_ticket_imgRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Resource_sch_ticket_imgRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Resource_sch_ticket_imgRecord Resource_sch_ticket_imgRec = (Resource_sch_ticket_imgRecord)sender;
        Validate_Updating();
        if(Resource_sch_ticket_imgRec != null && !Resource_sch_ticket_imgRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img_id field.
	/// </summary>
	public ColumnValue Getresource_sch_ticket_img_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_img_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img_id field.
	/// </summary>
	public Int32 Getresource_sch_ticket_img_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_img_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img field.
	/// </summary>
	public ColumnValue Getresource_sch_ticket_imgValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_imgColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img field.
	/// </summary>
	public byte[] Getresource_sch_ticket_imgFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_imgColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img field.
	/// </summary>
	public void Setresource_sch_ticket_imgFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_ticket_imgColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img field.
	/// </summary>
	public void Setresource_sch_ticket_imgFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_ticket_imgColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img field.
	/// </summary>
	public void Setresource_sch_ticket_imgFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_imgColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_ticket_img_.resource_sch_ticket_id field.
	/// </summary>
	public ColumnValue Getresource_sch_ticket_idValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's resource_sch_ticket_img_.resource_sch_ticket_id field.
	/// </summary>
	public Int32 Getresource_sch_ticket_idFieldValue()
	{
		return this.GetValue(TableUtils.resource_sch_ticket_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_id field.
	/// </summary>
	public void Setresource_sch_ticket_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img_id field.
	/// </summary>
	public Int32 resource_sch_ticket_img_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_ticket_img_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_ticket_img_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_ticket_img_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_ticket_img_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img_id field.
	/// </summary>
	public string resource_sch_ticket_img_idDefault
	{
		get
		{
			return TableUtils.resource_sch_ticket_img_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img field.
	/// </summary>
	public byte[] resource_sch_ticket_img
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_ticket_imgColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_ticket_imgColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_ticket_imgSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_ticket_imgColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_img field.
	/// </summary>
	public string resource_sch_ticket_imgDefault
	{
		get
		{
			return TableUtils.resource_sch_ticket_imgColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's resource_sch_ticket_img_.resource_sch_ticket_id field.
	/// </summary>
	public Int32 resource_sch_ticket_id
	{
		get
		{
			return this.GetValue(TableUtils.resource_sch_ticket_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.resource_sch_ticket_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool resource_sch_ticket_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.resource_sch_ticket_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's resource_sch_ticket_img_.resource_sch_ticket_id field.
	/// </summary>
	public string resource_sch_ticket_idDefault
	{
		get
		{
			return TableUtils.resource_sch_ticket_idColumn.DefaultValue;
		}
	}


#endregion
}

}
