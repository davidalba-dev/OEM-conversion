// This class is "generated" and will be overwritten.
// Your customizations should be made in Vw_dotmedRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="Vw_dotmedRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Vw_dotmedView"></see> class.
/// </remarks>
/// <seealso cref="Vw_dotmedView"></seealso>
/// <seealso cref="Vw_dotmedRecord"></seealso>
public class BaseVw_dotmedRecord : PrimaryKeyRecord
{

	public readonly static Vw_dotmedView TableUtils = Vw_dotmedView.Instance;

	// Constructors
 
	protected BaseVw_dotmedRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Vw_dotmedRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Vw_dotmedRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Vw_dotmedRecord_ReadRecord); 
	}

	protected BaseVw_dotmedRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Vw_dotmedRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Vw_dotmedRecord Vw_dotmedRec = (Vw_dotmedRecord)sender;
        if(Vw_dotmedRec != null && !Vw_dotmedRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Vw_dotmedRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Vw_dotmedRecord Vw_dotmedRec = (Vw_dotmedRecord)sender;
        Validate_Inserting();
        if(Vw_dotmedRec != null && !Vw_dotmedRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Vw_dotmedRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Vw_dotmedRecord Vw_dotmedRec = (Vw_dotmedRecord)sender;
        Validate_Updating();
        if(Vw_dotmedRec != null && !Vw_dotmedRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.new_category_id field.
	/// </summary>
	public ColumnValue Getnew_category_idValue()
	{
		return this.GetValue(TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.new_category_id field.
	/// </summary>
	public Decimal Getnew_category_idFieldValue()
	{
		return this.GetValue(TableUtils.new_category_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_category_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.new_category_id field.
	/// </summary>
	public void Setnew_category_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.new_category_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.model_id field.
	/// </summary>
	public ColumnValue Getmodel_idValue()
	{
		return this.GetValue(TableUtils.model_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.model_id field.
	/// </summary>
	public string Getmodel_idFieldValue()
	{
		return this.GetValue(TableUtils.model_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.model_id field.
	/// </summary>
	public void Setmodel_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.model_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.model_id field.
	/// </summary>
	public void Setmodel_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.model_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.make_id field.
	/// </summary>
	public ColumnValue Getmake_idValue()
	{
		return this.GetValue(TableUtils.make_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.make_id field.
	/// </summary>
	public string Getmake_idFieldValue()
	{
		return this.GetValue(TableUtils.make_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.make_id field.
	/// </summary>
	public void Setmake_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.make_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.make_id field.
	/// </summary>
	public void Setmake_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.make_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_part_mfg field.
	/// </summary>
	public ColumnValue Getdotmed_part_mfgValue()
	{
		return this.GetValue(TableUtils.dotmed_part_mfgColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_part_mfg field.
	/// </summary>
	public string Getdotmed_part_mfgFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_part_mfgColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_part_mfg field.
	/// </summary>
	public void Setdotmed_part_mfgFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_part_mfgColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_part_mfg field.
	/// </summary>
	public void Setdotmed_part_mfgFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_part_mfgColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.description field.
	/// </summary>
	public ColumnValue GetdescriptionValue()
	{
		return this.GetValue(TableUtils.descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.description field.
	/// </summary>
	public string GetdescriptionFieldValue()
	{
		return this.GetValue(TableUtils.descriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.description field.
	/// </summary>
	public void SetdescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.descriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.description field.
	/// </summary>
	public void SetdescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.descriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_part_num field.
	/// </summary>
	public ColumnValue Getdotmed_part_numValue()
	{
		return this.GetValue(TableUtils.dotmed_part_numColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_part_num field.
	/// </summary>
	public string Getdotmed_part_numFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_part_numColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_part_num field.
	/// </summary>
	public void Setdotmed_part_numFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_part_numColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_part_num field.
	/// </summary>
	public void Setdotmed_part_numFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_part_numColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_part_name field.
	/// </summary>
	public ColumnValue Getdotmed_part_nameValue()
	{
		return this.GetValue(TableUtils.dotmed_part_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_part_name field.
	/// </summary>
	public string Getdotmed_part_nameFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_part_nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_part_name field.
	/// </summary>
	public void Setdotmed_part_nameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_part_nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_part_name field.
	/// </summary>
	public void Setdotmed_part_nameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_part_nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.condition_id field.
	/// </summary>
	public ColumnValue Getcondition_idValue()
	{
		return this.GetValue(TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.condition_id field.
	/// </summary>
	public string Getcondition_idFieldValue()
	{
		return this.GetValue(TableUtils.condition_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.condition_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.condition_id field.
	/// </summary>
	public void Setcondition_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.condition_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_listing_type field.
	/// </summary>
	public ColumnValue Getdotmed_listing_typeValue()
	{
		return this.GetValue(TableUtils.dotmed_listing_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_listing_type field.
	/// </summary>
	public string Getdotmed_listing_typeFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_listing_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_listing_type field.
	/// </summary>
	public void Setdotmed_listing_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_listing_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_listing_type field.
	/// </summary>
	public void Setdotmed_listing_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_listing_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_request_type field.
	/// </summary>
	public ColumnValue Getdotmed_request_typeValue()
	{
		return this.GetValue(TableUtils.dotmed_request_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_request_type field.
	/// </summary>
	public string Getdotmed_request_typeFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_request_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_request_type field.
	/// </summary>
	public void Setdotmed_request_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_request_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_request_type field.
	/// </summary>
	public void Setdotmed_request_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_request_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.proposed_sale_price field.
	/// </summary>
	public ColumnValue Getproposed_sale_priceValue()
	{
		return this.GetValue(TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.proposed_sale_price field.
	/// </summary>
	public Decimal Getproposed_sale_priceFieldValue()
	{
		return this.GetValue(TableUtils.proposed_sale_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.proposed_sale_price field.
	/// </summary>
	public void Setproposed_sale_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_d2d_price field.
	/// </summary>
	public ColumnValue Getdotmed_d2d_priceValue()
	{
		return this.GetValue(TableUtils.dotmed_d2d_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_d2d_price field.
	/// </summary>
	public Decimal Getdotmed_d2d_priceFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_d2d_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_d2d_price field.
	/// </summary>
	public void Setdotmed_d2d_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_d2d_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_d2d_price field.
	/// </summary>
	public void Setdotmed_d2d_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_d2d_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_d2d_price field.
	/// </summary>
	public void Setdotmed_d2d_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_d2d_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_d2d_price field.
	/// </summary>
	public void Setdotmed_d2d_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_d2d_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_d2d_price field.
	/// </summary>
	public void Setdotmed_d2d_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_d2d_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_vts_price field.
	/// </summary>
	public ColumnValue Getdotmed_vts_priceValue()
	{
		return this.GetValue(TableUtils.dotmed_vts_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_vts_price field.
	/// </summary>
	public Decimal Getdotmed_vts_priceFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_vts_priceColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_vts_price field.
	/// </summary>
	public void Setdotmed_vts_priceFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_vts_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_vts_price field.
	/// </summary>
	public void Setdotmed_vts_priceFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_vts_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_vts_price field.
	/// </summary>
	public void Setdotmed_vts_priceFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_vts_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_vts_price field.
	/// </summary>
	public void Setdotmed_vts_priceFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_vts_priceColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_vts_price field.
	/// </summary>
	public void Setdotmed_vts_priceFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_vts_priceColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_currency field.
	/// </summary>
	public ColumnValue Getdotmed_currencyValue()
	{
		return this.GetValue(TableUtils.dotmed_currencyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_currency field.
	/// </summary>
	public Decimal Getdotmed_currencyFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_currencyColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_currency field.
	/// </summary>
	public void Setdotmed_currencyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_currencyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_currency field.
	/// </summary>
	public void Setdotmed_currencyFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_currencyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_currency field.
	/// </summary>
	public void Setdotmed_currencyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_currencyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_currency field.
	/// </summary>
	public void Setdotmed_currencyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_currencyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_currency field.
	/// </summary>
	public void Setdotmed_currencyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_currencyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_qty field.
	/// </summary>
	public ColumnValue Getdotmed_qtyValue()
	{
		return this.GetValue(TableUtils.dotmed_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_qty field.
	/// </summary>
	public Int32 Getdotmed_qtyFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_qtyColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_qty field.
	/// </summary>
	public void Setdotmed_qtyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_qty field.
	/// </summary>
	public void Setdotmed_qtyFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_qty field.
	/// </summary>
	public void Setdotmed_qtyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_qty field.
	/// </summary>
	public void Setdotmed_qtyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_qtyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_qty field.
	/// </summary>
	public void Setdotmed_qtyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_qtyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_paypal field.
	/// </summary>
	public ColumnValue Getdotmed_paypalValue()
	{
		return this.GetValue(TableUtils.dotmed_paypalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_paypal field.
	/// </summary>
	public bool Getdotmed_paypalFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_paypalColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal field.
	/// </summary>
	public void Setdotmed_paypalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_paypalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal field.
	/// </summary>
	public void Setdotmed_paypalFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_paypalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal field.
	/// </summary>
	public void Setdotmed_paypalFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_paypalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_paypal_shipping field.
	/// </summary>
	public ColumnValue Getdotmed_paypal_shippingValue()
	{
		return this.GetValue(TableUtils.dotmed_paypal_shippingColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_paypal_shipping field.
	/// </summary>
	public Decimal Getdotmed_paypal_shippingFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_paypal_shippingColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal_shipping field.
	/// </summary>
	public void Setdotmed_paypal_shippingFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_paypal_shippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal_shipping field.
	/// </summary>
	public void Setdotmed_paypal_shippingFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_paypal_shippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal_shipping field.
	/// </summary>
	public void Setdotmed_paypal_shippingFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_paypal_shippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal_shipping field.
	/// </summary>
	public void Setdotmed_paypal_shippingFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_paypal_shippingColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal_shipping field.
	/// </summary>
	public void Setdotmed_paypal_shippingFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_paypal_shippingColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_make_offer field.
	/// </summary>
	public ColumnValue Getdotmed_make_offerValue()
	{
		return this.GetValue(TableUtils.dotmed_make_offerColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_make_offer field.
	/// </summary>
	public bool Getdotmed_make_offerFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_make_offerColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_make_offer field.
	/// </summary>
	public void Setdotmed_make_offerFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_make_offerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_make_offer field.
	/// </summary>
	public void Setdotmed_make_offerFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_make_offerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_make_offer field.
	/// </summary>
	public void Setdotmed_make_offerFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_make_offerColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_auto_accept field.
	/// </summary>
	public ColumnValue Getdotmed_auto_acceptValue()
	{
		return this.GetValue(TableUtils.dotmed_auto_acceptColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_auto_accept field.
	/// </summary>
	public bool Getdotmed_auto_acceptFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_auto_acceptColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_auto_accept field.
	/// </summary>
	public void Setdotmed_auto_acceptFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_auto_acceptColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_auto_accept field.
	/// </summary>
	public void Setdotmed_auto_acceptFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_auto_acceptColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_auto_accept field.
	/// </summary>
	public void Setdotmed_auto_acceptFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_auto_acceptColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_auto_reject field.
	/// </summary>
	public ColumnValue Getdotmed_auto_rejectValue()
	{
		return this.GetValue(TableUtils.dotmed_auto_rejectColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_auto_reject field.
	/// </summary>
	public bool Getdotmed_auto_rejectFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_auto_rejectColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_auto_reject field.
	/// </summary>
	public void Setdotmed_auto_rejectFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_auto_rejectColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_auto_reject field.
	/// </summary>
	public void Setdotmed_auto_rejectFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_auto_rejectColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_auto_reject field.
	/// </summary>
	public void Setdotmed_auto_rejectFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_auto_rejectColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_weight field.
	/// </summary>
	public ColumnValue Getdotmed_weightValue()
	{
		return this.GetValue(TableUtils.dotmed_weightColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_weight field.
	/// </summary>
	public Decimal Getdotmed_weightFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_weightColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_weight field.
	/// </summary>
	public void Setdotmed_weightFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_weightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_weight field.
	/// </summary>
	public void Setdotmed_weightFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_weightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_weight field.
	/// </summary>
	public void Setdotmed_weightFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_weightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_weight field.
	/// </summary>
	public void Setdotmed_weightFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_weightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_weight field.
	/// </summary>
	public void Setdotmed_weightFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_weightColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_weight_units field.
	/// </summary>
	public ColumnValue Getdotmed_weight_unitsValue()
	{
		return this.GetValue(TableUtils.dotmed_weight_unitsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_weight_units field.
	/// </summary>
	public string Getdotmed_weight_unitsFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_weight_unitsColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_weight_units field.
	/// </summary>
	public void Setdotmed_weight_unitsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_weight_unitsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_weight_units field.
	/// </summary>
	public void Setdotmed_weight_unitsFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_weight_unitsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_height field.
	/// </summary>
	public ColumnValue Getdotmed_heightValue()
	{
		return this.GetValue(TableUtils.dotmed_heightColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_height field.
	/// </summary>
	public Decimal Getdotmed_heightFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_heightColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_height field.
	/// </summary>
	public void Setdotmed_heightFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_heightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_height field.
	/// </summary>
	public void Setdotmed_heightFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_heightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_height field.
	/// </summary>
	public void Setdotmed_heightFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_heightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_height field.
	/// </summary>
	public void Setdotmed_heightFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_heightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_height field.
	/// </summary>
	public void Setdotmed_heightFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_heightColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_width field.
	/// </summary>
	public ColumnValue Getdotmed_widthValue()
	{
		return this.GetValue(TableUtils.dotmed_widthColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_width field.
	/// </summary>
	public Decimal Getdotmed_widthFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_widthColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_width field.
	/// </summary>
	public void Setdotmed_widthFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_widthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_width field.
	/// </summary>
	public void Setdotmed_widthFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_widthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_width field.
	/// </summary>
	public void Setdotmed_widthFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_widthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_width field.
	/// </summary>
	public void Setdotmed_widthFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_widthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_width field.
	/// </summary>
	public void Setdotmed_widthFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_widthColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_depth field.
	/// </summary>
	public ColumnValue Getdotmed_depthValue()
	{
		return this.GetValue(TableUtils.dotmed_depthColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_depth field.
	/// </summary>
	public Decimal Getdotmed_depthFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_depthColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_depth field.
	/// </summary>
	public void Setdotmed_depthFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_depthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_depth field.
	/// </summary>
	public void Setdotmed_depthFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_depthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_depth field.
	/// </summary>
	public void Setdotmed_depthFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_depthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_depth field.
	/// </summary>
	public void Setdotmed_depthFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_depthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_depth field.
	/// </summary>
	public void Setdotmed_depthFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_depthColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_will_rent field.
	/// </summary>
	public ColumnValue Getdotmed_will_rentValue()
	{
		return this.GetValue(TableUtils.dotmed_will_rentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_will_rent field.
	/// </summary>
	public bool Getdotmed_will_rentFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_will_rentColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_will_rent field.
	/// </summary>
	public void Setdotmed_will_rentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_will_rentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_will_rent field.
	/// </summary>
	public void Setdotmed_will_rentFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_will_rentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_will_rent field.
	/// </summary>
	public void Setdotmed_will_rentFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_will_rentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_avail_parts field.
	/// </summary>
	public ColumnValue Getdotmed_avail_partsValue()
	{
		return this.GetValue(TableUtils.dotmed_avail_partsColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_avail_parts field.
	/// </summary>
	public bool Getdotmed_avail_partsFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_avail_partsColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_avail_parts field.
	/// </summary>
	public void Setdotmed_avail_partsFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_avail_partsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_avail_parts field.
	/// </summary>
	public void Setdotmed_avail_partsFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_avail_partsColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_avail_parts field.
	/// </summary>
	public void Setdotmed_avail_partsFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_avail_partsColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_in_stock field.
	/// </summary>
	public ColumnValue Getdotmed_in_stockValue()
	{
		return this.GetValue(TableUtils.dotmed_in_stockColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_in_stock field.
	/// </summary>
	public bool Getdotmed_in_stockFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_in_stockColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_in_stock field.
	/// </summary>
	public void Setdotmed_in_stockFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_in_stockColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_in_stock field.
	/// </summary>
	public void Setdotmed_in_stockFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_in_stockColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_in_stock field.
	/// </summary>
	public void Setdotmed_in_stockFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_in_stockColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_item_id field.
	/// </summary>
	public ColumnValue Getdotmed_item_idValue()
	{
		return this.GetValue(TableUtils.dotmed_item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_item_id field.
	/// </summary>
	public string Getdotmed_item_idFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_item_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_item_id field.
	/// </summary>
	public void Setdotmed_item_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_item_id field.
	/// </summary>
	public void Setdotmed_item_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_item_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.inventory_id field.
	/// </summary>
	public ColumnValue Getinventory_idValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.inventory_id field.
	/// </summary>
	public Decimal Getinventory_idFieldValue()
	{
		return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.inventory_id field.
	/// </summary>
	public void Setinventory_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.inventory_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_item_id_type field.
	/// </summary>
	public ColumnValue Getdotmed_item_id_typeValue()
	{
		return this.GetValue(TableUtils.dotmed_item_id_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_item_id_type field.
	/// </summary>
	public string Getdotmed_item_id_typeFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_item_id_typeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_item_id_type field.
	/// </summary>
	public void Setdotmed_item_id_typeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_item_id_typeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_item_id_type field.
	/// </summary>
	public void Setdotmed_item_id_typeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_item_id_typeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_your_item_id field.
	/// </summary>
	public ColumnValue Getdotmed_your_item_idValue()
	{
		return this.GetValue(TableUtils.dotmed_your_item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_your_item_id field.
	/// </summary>
	public Decimal Getdotmed_your_item_idFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_your_item_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_your_item_id field.
	/// </summary>
	public void Setdotmed_your_item_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_your_item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_your_item_id field.
	/// </summary>
	public void Setdotmed_your_item_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_your_item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_your_item_id field.
	/// </summary>
	public void Setdotmed_your_item_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_your_item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_your_item_id field.
	/// </summary>
	public void Setdotmed_your_item_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_your_item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_your_item_id field.
	/// </summary>
	public void Setdotmed_your_item_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_your_item_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_youtube_url field.
	/// </summary>
	public ColumnValue Getdotmed_youtube_urlValue()
	{
		return this.GetValue(TableUtils.dotmed_youtube_urlColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_youtube_url field.
	/// </summary>
	public string Getdotmed_youtube_urlFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_youtube_urlColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_youtube_url field.
	/// </summary>
	public void Setdotmed_youtube_urlFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_youtube_urlColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_youtube_url field.
	/// </summary>
	public void Setdotmed_youtube_urlFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_youtube_urlColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_video_url field.
	/// </summary>
	public ColumnValue Getdotmed_video_urlValue()
	{
		return this.GetValue(TableUtils.dotmed_video_urlColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_video_url field.
	/// </summary>
	public string Getdotmed_video_urlFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_video_urlColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_video_url field.
	/// </summary>
	public void Setdotmed_video_urlFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_video_urlColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_video_url field.
	/// </summary>
	public void Setdotmed_video_urlFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_video_urlColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_listing_id field.
	/// </summary>
	public ColumnValue Getdotmed_listing_idValue()
	{
		return this.GetValue(TableUtils.dotmed_listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_listing_id field.
	/// </summary>
	public Int32 Getdotmed_listing_idFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_listing_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_listing_id field.
	/// </summary>
	public void Setdotmed_listing_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_listing_id field.
	/// </summary>
	public void Setdotmed_listing_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_listing_id field.
	/// </summary>
	public void Setdotmed_listing_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_listing_id field.
	/// </summary>
	public void Setdotmed_listing_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_listing_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_listing_id field.
	/// </summary>
	public void Setdotmed_listing_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_listing_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_delete field.
	/// </summary>
	public ColumnValue Getdotmed_deleteValue()
	{
		return this.GetValue(TableUtils.dotmed_deleteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_delete field.
	/// </summary>
	public string Getdotmed_deleteFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_deleteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_delete field.
	/// </summary>
	public void Setdotmed_deleteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_deleteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_delete field.
	/// </summary>
	public void Setdotmed_deleteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_deleteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name1 field.
	/// </summary>
	public ColumnValue Getdotmed_spec_name1Value()
	{
		return this.GetValue(TableUtils.dotmed_spec_name1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name1 field.
	/// </summary>
	public string Getdotmed_spec_name1FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_spec_name1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name1 field.
	/// </summary>
	public void Setdotmed_spec_name1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_spec_name1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name1 field.
	/// </summary>
	public void Setdotmed_spec_name1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_spec_name1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value1 field.
	/// </summary>
	public ColumnValue Getdotmed_spec_value1Value()
	{
		return this.GetValue(TableUtils.dotmed_spec_value1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value1 field.
	/// </summary>
	public string Getdotmed_spec_value1FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_spec_value1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value1 field.
	/// </summary>
	public void Setdotmed_spec_value1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_spec_value1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value1 field.
	/// </summary>
	public void Setdotmed_spec_value1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_spec_value1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name2 field.
	/// </summary>
	public ColumnValue Getdotmed_spec_name2Value()
	{
		return this.GetValue(TableUtils.dotmed_spec_name2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name2 field.
	/// </summary>
	public string Getdotmed_spec_name2FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_spec_name2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name2 field.
	/// </summary>
	public void Setdotmed_spec_name2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_spec_name2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name2 field.
	/// </summary>
	public void Setdotmed_spec_name2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_spec_name2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value2 field.
	/// </summary>
	public ColumnValue Getdotmed_spec_value2Value()
	{
		return this.GetValue(TableUtils.dotmed_spec_value2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value2 field.
	/// </summary>
	public string Getdotmed_spec_value2FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_spec_value2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value2 field.
	/// </summary>
	public void Setdotmed_spec_value2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_spec_value2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value2 field.
	/// </summary>
	public void Setdotmed_spec_value2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_spec_value2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name3 field.
	/// </summary>
	public ColumnValue Getdotmed_spec_name3Value()
	{
		return this.GetValue(TableUtils.dotmed_spec_name3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name3 field.
	/// </summary>
	public string Getdotmed_spec_name3FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_spec_name3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name3 field.
	/// </summary>
	public void Setdotmed_spec_name3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_spec_name3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name3 field.
	/// </summary>
	public void Setdotmed_spec_name3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_spec_name3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value3 field.
	/// </summary>
	public ColumnValue Getdotmed_spec_value3Value()
	{
		return this.GetValue(TableUtils.dotmed_spec_value3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value3 field.
	/// </summary>
	public string Getdotmed_spec_value3FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_spec_value3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value3 field.
	/// </summary>
	public void Setdotmed_spec_value3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_spec_value3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value3 field.
	/// </summary>
	public void Setdotmed_spec_value3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_spec_value3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name4 field.
	/// </summary>
	public ColumnValue Getdotmed_spec_name4Value()
	{
		return this.GetValue(TableUtils.dotmed_spec_name4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name4 field.
	/// </summary>
	public string Getdotmed_spec_name4FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_spec_name4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name4 field.
	/// </summary>
	public void Setdotmed_spec_name4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_spec_name4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name4 field.
	/// </summary>
	public void Setdotmed_spec_name4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_spec_name4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value4 field.
	/// </summary>
	public ColumnValue Getdotmed_spec_value4Value()
	{
		return this.GetValue(TableUtils.dotmed_spec_value4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value4 field.
	/// </summary>
	public string Getdotmed_spec_value4FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_spec_value4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value4 field.
	/// </summary>
	public void Setdotmed_spec_value4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_spec_value4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value4 field.
	/// </summary>
	public void Setdotmed_spec_value4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_spec_value4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image1 field.
	/// </summary>
	public ColumnValue Getdotmed_image1Value()
	{
		return this.GetValue(TableUtils.dotmed_image1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image1 field.
	/// </summary>
	public string Getdotmed_image1FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image1 field.
	/// </summary>
	public void Setdotmed_image1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image1 field.
	/// </summary>
	public void Setdotmed_image1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image2 field.
	/// </summary>
	public ColumnValue Getdotmed_image2Value()
	{
		return this.GetValue(TableUtils.dotmed_image2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image2 field.
	/// </summary>
	public string Getdotmed_image2FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image2 field.
	/// </summary>
	public void Setdotmed_image2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image2 field.
	/// </summary>
	public void Setdotmed_image2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image3 field.
	/// </summary>
	public ColumnValue Getdotmed_image3Value()
	{
		return this.GetValue(TableUtils.dotmed_image3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image3 field.
	/// </summary>
	public string Getdotmed_image3FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image3 field.
	/// </summary>
	public void Setdotmed_image3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image3 field.
	/// </summary>
	public void Setdotmed_image3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image4 field.
	/// </summary>
	public ColumnValue Getdotmed_image4Value()
	{
		return this.GetValue(TableUtils.dotmed_image4Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image4 field.
	/// </summary>
	public string Getdotmed_image4FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image4Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image4 field.
	/// </summary>
	public void Setdotmed_image4FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image4Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image4 field.
	/// </summary>
	public void Setdotmed_image4FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image4Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image5 field.
	/// </summary>
	public ColumnValue Getdotmed_image5Value()
	{
		return this.GetValue(TableUtils.dotmed_image5Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image5 field.
	/// </summary>
	public string Getdotmed_image5FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image5Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image5 field.
	/// </summary>
	public void Setdotmed_image5FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image5Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image5 field.
	/// </summary>
	public void Setdotmed_image5FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image5Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image6 field.
	/// </summary>
	public ColumnValue Getdotmed_image6Value()
	{
		return this.GetValue(TableUtils.dotmed_image6Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image6 field.
	/// </summary>
	public string Getdotmed_image6FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image6Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image6 field.
	/// </summary>
	public void Setdotmed_image6FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image6Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image6 field.
	/// </summary>
	public void Setdotmed_image6FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image6Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image7 field.
	/// </summary>
	public ColumnValue Getdotmed_image7Value()
	{
		return this.GetValue(TableUtils.dotmed_image7Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image7 field.
	/// </summary>
	public string Getdotmed_image7FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image7Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image7 field.
	/// </summary>
	public void Setdotmed_image7FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image7Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image7 field.
	/// </summary>
	public void Setdotmed_image7FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image7Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image8 field.
	/// </summary>
	public ColumnValue Getdotmed_image8Value()
	{
		return this.GetValue(TableUtils.dotmed_image8Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image8 field.
	/// </summary>
	public string Getdotmed_image8FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image8Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image8 field.
	/// </summary>
	public void Setdotmed_image8FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image8Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image8 field.
	/// </summary>
	public void Setdotmed_image8FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image8Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image9 field.
	/// </summary>
	public ColumnValue Getdotmed_image9Value()
	{
		return this.GetValue(TableUtils.dotmed_image9Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image9 field.
	/// </summary>
	public string Getdotmed_image9FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image9Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image9 field.
	/// </summary>
	public void Setdotmed_image9FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image9Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image9 field.
	/// </summary>
	public void Setdotmed_image9FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image9Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image10 field.
	/// </summary>
	public ColumnValue Getdotmed_image10Value()
	{
		return this.GetValue(TableUtils.dotmed_image10Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image10 field.
	/// </summary>
	public string Getdotmed_image10FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image10Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image10 field.
	/// </summary>
	public void Setdotmed_image10FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image10Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image10 field.
	/// </summary>
	public void Setdotmed_image10FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image10Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image11 field.
	/// </summary>
	public ColumnValue Getdotmed_image11Value()
	{
		return this.GetValue(TableUtils.dotmed_image11Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image11 field.
	/// </summary>
	public string Getdotmed_image11FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image11Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image11 field.
	/// </summary>
	public void Setdotmed_image11FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image11Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image11 field.
	/// </summary>
	public void Setdotmed_image11FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image11Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image12 field.
	/// </summary>
	public ColumnValue Getdotmed_image12Value()
	{
		return this.GetValue(TableUtils.dotmed_image12Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image12 field.
	/// </summary>
	public string Getdotmed_image12FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image12Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image12 field.
	/// </summary>
	public void Setdotmed_image12FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image12Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image12 field.
	/// </summary>
	public void Setdotmed_image12FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image12Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image13 field.
	/// </summary>
	public ColumnValue Getdotmed_image13Value()
	{
		return this.GetValue(TableUtils.dotmed_image13Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image13 field.
	/// </summary>
	public string Getdotmed_image13FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image13Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image13 field.
	/// </summary>
	public void Setdotmed_image13FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image13Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image13 field.
	/// </summary>
	public void Setdotmed_image13FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image13Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image14 field.
	/// </summary>
	public ColumnValue Getdotmed_image14Value()
	{
		return this.GetValue(TableUtils.dotmed_image14Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image14 field.
	/// </summary>
	public string Getdotmed_image14FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image14Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image14 field.
	/// </summary>
	public void Setdotmed_image14FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image14Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image14 field.
	/// </summary>
	public void Setdotmed_image14FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image14Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image15 field.
	/// </summary>
	public ColumnValue Getdotmed_image15Value()
	{
		return this.GetValue(TableUtils.dotmed_image15Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image15 field.
	/// </summary>
	public string Getdotmed_image15FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image15Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image15 field.
	/// </summary>
	public void Setdotmed_image15FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image15Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image15 field.
	/// </summary>
	public void Setdotmed_image15FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image15Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image16 field.
	/// </summary>
	public ColumnValue Getdotmed_image16Value()
	{
		return this.GetValue(TableUtils.dotmed_image16Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image16 field.
	/// </summary>
	public string Getdotmed_image16FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image16Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image16 field.
	/// </summary>
	public void Setdotmed_image16FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image16Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image16 field.
	/// </summary>
	public void Setdotmed_image16FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image16Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image17 field.
	/// </summary>
	public ColumnValue Getdotmed_image17Value()
	{
		return this.GetValue(TableUtils.dotmed_image17Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image17 field.
	/// </summary>
	public string Getdotmed_image17FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image17Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image17 field.
	/// </summary>
	public void Setdotmed_image17FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image17Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image17 field.
	/// </summary>
	public void Setdotmed_image17FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image17Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image18 field.
	/// </summary>
	public ColumnValue Getdotmed_image18Value()
	{
		return this.GetValue(TableUtils.dotmed_image18Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image18 field.
	/// </summary>
	public string Getdotmed_image18FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image18Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image18 field.
	/// </summary>
	public void Setdotmed_image18FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image18Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image18 field.
	/// </summary>
	public void Setdotmed_image18FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image18Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image19 field.
	/// </summary>
	public ColumnValue Getdotmed_image19Value()
	{
		return this.GetValue(TableUtils.dotmed_image19Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image19 field.
	/// </summary>
	public string Getdotmed_image19FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image19Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image19 field.
	/// </summary>
	public void Setdotmed_image19FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image19Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image19 field.
	/// </summary>
	public void Setdotmed_image19FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image19Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image20 field.
	/// </summary>
	public ColumnValue Getdotmed_image20Value()
	{
		return this.GetValue(TableUtils.dotmed_image20Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_image20 field.
	/// </summary>
	public string Getdotmed_image20FieldValue()
	{
		return this.GetValue(TableUtils.dotmed_image20Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image20 field.
	/// </summary>
	public void Setdotmed_image20FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_image20Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image20 field.
	/// </summary>
	public void Setdotmed_image20FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_image20Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.equipment_inventory_dotmed_id field.
	/// </summary>
	public ColumnValue Getequipment_inventory_dotmed_idValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_dotmed_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.equipment_inventory_dotmed_id field.
	/// </summary>
	public Decimal Getequipment_inventory_dotmed_idFieldValue()
	{
		return this.GetValue(TableUtils.equipment_inventory_dotmed_idColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.equipment_inventory_dotmed_id field.
	/// </summary>
	public void Setequipment_inventory_dotmed_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.equipment_inventory_dotmed_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.equipment_inventory_dotmed_id field.
	/// </summary>
	public void Setequipment_inventory_dotmed_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.equipment_inventory_dotmed_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.equipment_inventory_dotmed_id field.
	/// </summary>
	public void Setequipment_inventory_dotmed_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_dotmed_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.equipment_inventory_dotmed_id field.
	/// </summary>
	public void Setequipment_inventory_dotmed_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_dotmed_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.equipment_inventory_dotmed_id field.
	/// </summary>
	public void Setequipment_inventory_dotmed_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.equipment_inventory_dotmed_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_processed field.
	/// </summary>
	public ColumnValue Getdotmed_processedValue()
	{
		return this.GetValue(TableUtils.dotmed_processedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_processed field.
	/// </summary>
	public bool Getdotmed_processedFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_processedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_processed field.
	/// </summary>
	public void Setdotmed_processedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_processedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_processed field.
	/// </summary>
	public void Setdotmed_processedFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_processedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_processed field.
	/// </summary>
	public void Setdotmed_processedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_processedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_oem_item_id field.
	/// </summary>
	public ColumnValue Getdotmed_oem_item_idValue()
	{
		return this.GetValue(TableUtils.dotmed_oem_item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_oem_item_id field.
	/// </summary>
	public string Getdotmed_oem_item_idFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_oem_item_idColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_oem_item_id field.
	/// </summary>
	public void Setdotmed_oem_item_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_oem_item_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_oem_item_id field.
	/// </summary>
	public void Setdotmed_oem_item_idFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_oem_item_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_active field.
	/// </summary>
	public ColumnValue Getdotmed_activeValue()
	{
		return this.GetValue(TableUtils.dotmed_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_active field.
	/// </summary>
	public bool Getdotmed_activeFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_activeColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_active field.
	/// </summary>
	public void Setdotmed_activeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_active field.
	/// </summary>
	public void Setdotmed_activeFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_activeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_active field.
	/// </summary>
	public void Setdotmed_activeFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_activeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_delete_date field.
	/// </summary>
	public ColumnValue Getdotmed_delete_dateValue()
	{
		return this.GetValue(TableUtils.dotmed_delete_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.dotmed_delete_date field.
	/// </summary>
	public DateTime Getdotmed_delete_dateFieldValue()
	{
		return this.GetValue(TableUtils.dotmed_delete_dateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_delete_date field.
	/// </summary>
	public void Setdotmed_delete_dateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.dotmed_delete_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_delete_date field.
	/// </summary>
	public void Setdotmed_delete_dateFieldValue(string val)
	{
		this.SetString(val, TableUtils.dotmed_delete_dateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_delete_date field.
	/// </summary>
	public void Setdotmed_delete_dateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.dotmed_delete_dateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.serial_number field.
	/// </summary>
	public ColumnValue Getserial_numberValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.serial_number field.
	/// </summary>
	public string Getserial_numberFieldValue()
	{
		return this.GetValue(TableUtils.serial_numberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.serial_numberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.serial_number field.
	/// </summary>
	public void Setserial_numberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.serial_numberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.oem_ein field.
	/// </summary>
	public ColumnValue Getoem_einValue()
	{
		return this.GetValue(TableUtils.oem_einColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vw_dotmed_.oem_ein field.
	/// </summary>
	public string Getoem_einFieldValue()
	{
		return this.GetValue(TableUtils.oem_einColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.oem_ein field.
	/// </summary>
	public void Setoem_einFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.oem_einColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.oem_ein field.
	/// </summary>
	public void Setoem_einFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.oem_einColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.new_category_id field.
	/// </summary>
	public Decimal new_category_id
	{
		get
		{
			return this.GetValue(TableUtils.new_category_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.new_category_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool new_category_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.new_category_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.new_category_id field.
	/// </summary>
	public string new_category_idDefault
	{
		get
		{
			return TableUtils.new_category_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.model_id field.
	/// </summary>
	public string model_id
	{
		get
		{
			return this.GetValue(TableUtils.model_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.model_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool model_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.model_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.model_id field.
	/// </summary>
	public string model_idDefault
	{
		get
		{
			return TableUtils.model_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.make_id field.
	/// </summary>
	public string make_id
	{
		get
		{
			return this.GetValue(TableUtils.make_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.make_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool make_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.make_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.make_id field.
	/// </summary>
	public string make_idDefault
	{
		get
		{
			return TableUtils.make_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_part_mfg field.
	/// </summary>
	public string dotmed_part_mfg
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_part_mfgColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_part_mfgColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_part_mfgSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_part_mfgColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_part_mfg field.
	/// </summary>
	public string dotmed_part_mfgDefault
	{
		get
		{
			return TableUtils.dotmed_part_mfgColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.description field.
	/// </summary>
	public string description
	{
		get
		{
			return this.GetValue(TableUtils.descriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.descriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool descriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.descriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.description field.
	/// </summary>
	public string descriptionDefault
	{
		get
		{
			return TableUtils.descriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_part_num field.
	/// </summary>
	public string dotmed_part_num
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_part_numColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_part_numColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_part_numSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_part_numColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_part_num field.
	/// </summary>
	public string dotmed_part_numDefault
	{
		get
		{
			return TableUtils.dotmed_part_numColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_part_name field.
	/// </summary>
	public string dotmed_part_name
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_part_nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_part_nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_part_nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_part_nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_part_name field.
	/// </summary>
	public string dotmed_part_nameDefault
	{
		get
		{
			return TableUtils.dotmed_part_nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.condition_id field.
	/// </summary>
	public string condition_id
	{
		get
		{
			return this.GetValue(TableUtils.condition_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.condition_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool condition_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.condition_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.condition_id field.
	/// </summary>
	public string condition_idDefault
	{
		get
		{
			return TableUtils.condition_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_listing_type field.
	/// </summary>
	public string dotmed_listing_type
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_listing_typeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_listing_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_listing_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_listing_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_listing_type field.
	/// </summary>
	public string dotmed_listing_typeDefault
	{
		get
		{
			return TableUtils.dotmed_listing_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_request_type field.
	/// </summary>
	public string dotmed_request_type
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_request_typeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_request_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_request_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_request_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_request_type field.
	/// </summary>
	public string dotmed_request_typeDefault
	{
		get
		{
			return TableUtils.dotmed_request_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.proposed_sale_price field.
	/// </summary>
	public Decimal proposed_sale_price
	{
		get
		{
			return this.GetValue(TableUtils.proposed_sale_priceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.proposed_sale_priceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool proposed_sale_priceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.proposed_sale_priceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.proposed_sale_price field.
	/// </summary>
	public string proposed_sale_priceDefault
	{
		get
		{
			return TableUtils.proposed_sale_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_d2d_price field.
	/// </summary>
	public Decimal dotmed_d2d_price
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_d2d_priceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_d2d_priceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_d2d_priceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_d2d_priceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_d2d_price field.
	/// </summary>
	public string dotmed_d2d_priceDefault
	{
		get
		{
			return TableUtils.dotmed_d2d_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_vts_price field.
	/// </summary>
	public Decimal dotmed_vts_price
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_vts_priceColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_vts_priceColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_vts_priceSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_vts_priceColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_vts_price field.
	/// </summary>
	public string dotmed_vts_priceDefault
	{
		get
		{
			return TableUtils.dotmed_vts_priceColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_currency field.
	/// </summary>
	public Decimal dotmed_currency
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_currencyColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_currencyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_currencySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_currencyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_currency field.
	/// </summary>
	public string dotmed_currencyDefault
	{
		get
		{
			return TableUtils.dotmed_currencyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_qty field.
	/// </summary>
	public Int32 dotmed_qty
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_qtyColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_qtyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_qtySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_qtyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_qty field.
	/// </summary>
	public string dotmed_qtyDefault
	{
		get
		{
			return TableUtils.dotmed_qtyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_paypal field.
	/// </summary>
	public bool dotmed_paypal
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_paypalColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.dotmed_paypalColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_paypalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_paypalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal field.
	/// </summary>
	public string dotmed_paypalDefault
	{
		get
		{
			return TableUtils.dotmed_paypalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_paypal_shipping field.
	/// </summary>
	public Decimal dotmed_paypal_shipping
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_paypal_shippingColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_paypal_shippingColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_paypal_shippingSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_paypal_shippingColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_paypal_shipping field.
	/// </summary>
	public string dotmed_paypal_shippingDefault
	{
		get
		{
			return TableUtils.dotmed_paypal_shippingColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_make_offer field.
	/// </summary>
	public bool dotmed_make_offer
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_make_offerColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.dotmed_make_offerColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_make_offerSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_make_offerColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_make_offer field.
	/// </summary>
	public string dotmed_make_offerDefault
	{
		get
		{
			return TableUtils.dotmed_make_offerColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_auto_accept field.
	/// </summary>
	public bool dotmed_auto_accept
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_auto_acceptColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.dotmed_auto_acceptColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_auto_acceptSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_auto_acceptColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_auto_accept field.
	/// </summary>
	public string dotmed_auto_acceptDefault
	{
		get
		{
			return TableUtils.dotmed_auto_acceptColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_auto_reject field.
	/// </summary>
	public bool dotmed_auto_reject
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_auto_rejectColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.dotmed_auto_rejectColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_auto_rejectSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_auto_rejectColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_auto_reject field.
	/// </summary>
	public string dotmed_auto_rejectDefault
	{
		get
		{
			return TableUtils.dotmed_auto_rejectColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_weight field.
	/// </summary>
	public Decimal dotmed_weight
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_weightColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_weightColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_weightSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_weightColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_weight field.
	/// </summary>
	public string dotmed_weightDefault
	{
		get
		{
			return TableUtils.dotmed_weightColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_weight_units field.
	/// </summary>
	public string dotmed_weight_units
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_weight_unitsColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_weight_unitsColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_weight_unitsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_weight_unitsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_weight_units field.
	/// </summary>
	public string dotmed_weight_unitsDefault
	{
		get
		{
			return TableUtils.dotmed_weight_unitsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_height field.
	/// </summary>
	public Decimal dotmed_height
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_heightColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_heightColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_heightSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_heightColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_height field.
	/// </summary>
	public string dotmed_heightDefault
	{
		get
		{
			return TableUtils.dotmed_heightColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_width field.
	/// </summary>
	public Decimal dotmed_width
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_widthColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_widthColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_widthSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_widthColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_width field.
	/// </summary>
	public string dotmed_widthDefault
	{
		get
		{
			return TableUtils.dotmed_widthColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_depth field.
	/// </summary>
	public Decimal dotmed_depth
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_depthColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_depthColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_depthSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_depthColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_depth field.
	/// </summary>
	public string dotmed_depthDefault
	{
		get
		{
			return TableUtils.dotmed_depthColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_will_rent field.
	/// </summary>
	public bool dotmed_will_rent
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_will_rentColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.dotmed_will_rentColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_will_rentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_will_rentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_will_rent field.
	/// </summary>
	public string dotmed_will_rentDefault
	{
		get
		{
			return TableUtils.dotmed_will_rentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_avail_parts field.
	/// </summary>
	public bool dotmed_avail_parts
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_avail_partsColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.dotmed_avail_partsColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_avail_partsSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_avail_partsColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_avail_parts field.
	/// </summary>
	public string dotmed_avail_partsDefault
	{
		get
		{
			return TableUtils.dotmed_avail_partsColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_in_stock field.
	/// </summary>
	public bool dotmed_in_stock
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_in_stockColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.dotmed_in_stockColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_in_stockSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_in_stockColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_in_stock field.
	/// </summary>
	public string dotmed_in_stockDefault
	{
		get
		{
			return TableUtils.dotmed_in_stockColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_item_id field.
	/// </summary>
	public string dotmed_item_id
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_item_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_item_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_item_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_item_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_item_id field.
	/// </summary>
	public string dotmed_item_idDefault
	{
		get
		{
			return TableUtils.dotmed_item_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.inventory_id field.
	/// </summary>
	public Decimal inventory_id
	{
		get
		{
			return this.GetValue(TableUtils.inventory_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.inventory_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool inventory_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.inventory_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.inventory_id field.
	/// </summary>
	public string inventory_idDefault
	{
		get
		{
			return TableUtils.inventory_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_item_id_type field.
	/// </summary>
	public string dotmed_item_id_type
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_item_id_typeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_item_id_typeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_item_id_typeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_item_id_typeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_item_id_type field.
	/// </summary>
	public string dotmed_item_id_typeDefault
	{
		get
		{
			return TableUtils.dotmed_item_id_typeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_your_item_id field.
	/// </summary>
	public Decimal dotmed_your_item_id
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_your_item_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_your_item_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_your_item_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_your_item_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_your_item_id field.
	/// </summary>
	public string dotmed_your_item_idDefault
	{
		get
		{
			return TableUtils.dotmed_your_item_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_youtube_url field.
	/// </summary>
	public string dotmed_youtube_url
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_youtube_urlColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_youtube_urlColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_youtube_urlSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_youtube_urlColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_youtube_url field.
	/// </summary>
	public string dotmed_youtube_urlDefault
	{
		get
		{
			return TableUtils.dotmed_youtube_urlColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_video_url field.
	/// </summary>
	public string dotmed_video_url
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_video_urlColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_video_urlColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_video_urlSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_video_urlColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_video_url field.
	/// </summary>
	public string dotmed_video_urlDefault
	{
		get
		{
			return TableUtils.dotmed_video_urlColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_listing_id field.
	/// </summary>
	public Int32 dotmed_listing_id
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_listing_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_listing_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_listing_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_listing_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_listing_id field.
	/// </summary>
	public string dotmed_listing_idDefault
	{
		get
		{
			return TableUtils.dotmed_listing_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_delete field.
	/// </summary>
	public string dotmed_delete
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_deleteColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_deleteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_deleteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_deleteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_delete field.
	/// </summary>
	public string dotmed_deleteDefault
	{
		get
		{
			return TableUtils.dotmed_deleteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name1 field.
	/// </summary>
	public string dotmed_spec_name1
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_spec_name1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_spec_name1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_spec_name1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_spec_name1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name1 field.
	/// </summary>
	public string dotmed_spec_name1Default
	{
		get
		{
			return TableUtils.dotmed_spec_name1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value1 field.
	/// </summary>
	public string dotmed_spec_value1
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_spec_value1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_spec_value1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_spec_value1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_spec_value1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value1 field.
	/// </summary>
	public string dotmed_spec_value1Default
	{
		get
		{
			return TableUtils.dotmed_spec_value1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name2 field.
	/// </summary>
	public string dotmed_spec_name2
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_spec_name2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_spec_name2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_spec_name2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_spec_name2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name2 field.
	/// </summary>
	public string dotmed_spec_name2Default
	{
		get
		{
			return TableUtils.dotmed_spec_name2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value2 field.
	/// </summary>
	public string dotmed_spec_value2
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_spec_value2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_spec_value2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_spec_value2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_spec_value2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value2 field.
	/// </summary>
	public string dotmed_spec_value2Default
	{
		get
		{
			return TableUtils.dotmed_spec_value2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name3 field.
	/// </summary>
	public string dotmed_spec_name3
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_spec_name3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_spec_name3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_spec_name3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_spec_name3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name3 field.
	/// </summary>
	public string dotmed_spec_name3Default
	{
		get
		{
			return TableUtils.dotmed_spec_name3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value3 field.
	/// </summary>
	public string dotmed_spec_value3
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_spec_value3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_spec_value3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_spec_value3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_spec_value3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value3 field.
	/// </summary>
	public string dotmed_spec_value3Default
	{
		get
		{
			return TableUtils.dotmed_spec_value3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_name4 field.
	/// </summary>
	public string dotmed_spec_name4
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_spec_name4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_spec_name4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_spec_name4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_spec_name4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_name4 field.
	/// </summary>
	public string dotmed_spec_name4Default
	{
		get
		{
			return TableUtils.dotmed_spec_name4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_spec_value4 field.
	/// </summary>
	public string dotmed_spec_value4
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_spec_value4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_spec_value4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_spec_value4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_spec_value4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_spec_value4 field.
	/// </summary>
	public string dotmed_spec_value4Default
	{
		get
		{
			return TableUtils.dotmed_spec_value4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image1 field.
	/// </summary>
	public string dotmed_image1
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image1 field.
	/// </summary>
	public string dotmed_image1Default
	{
		get
		{
			return TableUtils.dotmed_image1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image2 field.
	/// </summary>
	public string dotmed_image2
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image2 field.
	/// </summary>
	public string dotmed_image2Default
	{
		get
		{
			return TableUtils.dotmed_image2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image3 field.
	/// </summary>
	public string dotmed_image3
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image3 field.
	/// </summary>
	public string dotmed_image3Default
	{
		get
		{
			return TableUtils.dotmed_image3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image4 field.
	/// </summary>
	public string dotmed_image4
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image4Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image4Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image4Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image4Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image4 field.
	/// </summary>
	public string dotmed_image4Default
	{
		get
		{
			return TableUtils.dotmed_image4Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image5 field.
	/// </summary>
	public string dotmed_image5
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image5Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image5Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image5Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image5Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image5 field.
	/// </summary>
	public string dotmed_image5Default
	{
		get
		{
			return TableUtils.dotmed_image5Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image6 field.
	/// </summary>
	public string dotmed_image6
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image6Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image6Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image6Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image6Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image6 field.
	/// </summary>
	public string dotmed_image6Default
	{
		get
		{
			return TableUtils.dotmed_image6Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image7 field.
	/// </summary>
	public string dotmed_image7
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image7Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image7Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image7Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image7Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image7 field.
	/// </summary>
	public string dotmed_image7Default
	{
		get
		{
			return TableUtils.dotmed_image7Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image8 field.
	/// </summary>
	public string dotmed_image8
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image8Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image8Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image8Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image8Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image8 field.
	/// </summary>
	public string dotmed_image8Default
	{
		get
		{
			return TableUtils.dotmed_image8Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image9 field.
	/// </summary>
	public string dotmed_image9
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image9Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image9Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image9Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image9Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image9 field.
	/// </summary>
	public string dotmed_image9Default
	{
		get
		{
			return TableUtils.dotmed_image9Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image10 field.
	/// </summary>
	public string dotmed_image10
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image10Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image10Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image10Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image10Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image10 field.
	/// </summary>
	public string dotmed_image10Default
	{
		get
		{
			return TableUtils.dotmed_image10Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image11 field.
	/// </summary>
	public string dotmed_image11
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image11Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image11Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image11Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image11Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image11 field.
	/// </summary>
	public string dotmed_image11Default
	{
		get
		{
			return TableUtils.dotmed_image11Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image12 field.
	/// </summary>
	public string dotmed_image12
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image12Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image12Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image12Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image12Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image12 field.
	/// </summary>
	public string dotmed_image12Default
	{
		get
		{
			return TableUtils.dotmed_image12Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image13 field.
	/// </summary>
	public string dotmed_image13
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image13Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image13Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image13Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image13Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image13 field.
	/// </summary>
	public string dotmed_image13Default
	{
		get
		{
			return TableUtils.dotmed_image13Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image14 field.
	/// </summary>
	public string dotmed_image14
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image14Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image14Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image14Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image14Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image14 field.
	/// </summary>
	public string dotmed_image14Default
	{
		get
		{
			return TableUtils.dotmed_image14Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image15 field.
	/// </summary>
	public string dotmed_image15
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image15Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image15Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image15Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image15Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image15 field.
	/// </summary>
	public string dotmed_image15Default
	{
		get
		{
			return TableUtils.dotmed_image15Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image16 field.
	/// </summary>
	public string dotmed_image16
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image16Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image16Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image16Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image16Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image16 field.
	/// </summary>
	public string dotmed_image16Default
	{
		get
		{
			return TableUtils.dotmed_image16Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image17 field.
	/// </summary>
	public string dotmed_image17
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image17Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image17Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image17Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image17Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image17 field.
	/// </summary>
	public string dotmed_image17Default
	{
		get
		{
			return TableUtils.dotmed_image17Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image18 field.
	/// </summary>
	public string dotmed_image18
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image18Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image18Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image18Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image18Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image18 field.
	/// </summary>
	public string dotmed_image18Default
	{
		get
		{
			return TableUtils.dotmed_image18Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image19 field.
	/// </summary>
	public string dotmed_image19
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image19Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image19Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image19Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image19Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image19 field.
	/// </summary>
	public string dotmed_image19Default
	{
		get
		{
			return TableUtils.dotmed_image19Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_image20 field.
	/// </summary>
	public string dotmed_image20
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_image20Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_image20Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_image20Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_image20Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_image20 field.
	/// </summary>
	public string dotmed_image20Default
	{
		get
		{
			return TableUtils.dotmed_image20Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.equipment_inventory_dotmed_id field.
	/// </summary>
	public Decimal equipment_inventory_dotmed_id
	{
		get
		{
			return this.GetValue(TableUtils.equipment_inventory_dotmed_idColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.equipment_inventory_dotmed_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool equipment_inventory_dotmed_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.equipment_inventory_dotmed_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.equipment_inventory_dotmed_id field.
	/// </summary>
	public string equipment_inventory_dotmed_idDefault
	{
		get
		{
			return TableUtils.equipment_inventory_dotmed_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_processed field.
	/// </summary>
	public bool dotmed_processed
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_processedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.dotmed_processedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_processedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_processedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_processed field.
	/// </summary>
	public string dotmed_processedDefault
	{
		get
		{
			return TableUtils.dotmed_processedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_oem_item_id field.
	/// </summary>
	public string dotmed_oem_item_id
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_oem_item_idColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_oem_item_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_oem_item_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_oem_item_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_oem_item_id field.
	/// </summary>
	public string dotmed_oem_item_idDefault
	{
		get
		{
			return TableUtils.dotmed_oem_item_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_active field.
	/// </summary>
	public bool dotmed_active
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_activeColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.dotmed_activeColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_activeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_activeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_active field.
	/// </summary>
	public string dotmed_activeDefault
	{
		get
		{
			return TableUtils.dotmed_activeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.dotmed_delete_date field.
	/// </summary>
	public DateTime dotmed_delete_date
	{
		get
		{
			return this.GetValue(TableUtils.dotmed_delete_dateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.dotmed_delete_dateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool dotmed_delete_dateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.dotmed_delete_dateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.dotmed_delete_date field.
	/// </summary>
	public string dotmed_delete_dateDefault
	{
		get
		{
			return TableUtils.dotmed_delete_dateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.serial_number field.
	/// </summary>
	public string serial_number
	{
		get
		{
			return this.GetValue(TableUtils.serial_numberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.serial_numberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool serial_numberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.serial_numberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.serial_number field.
	/// </summary>
	public string serial_numberDefault
	{
		get
		{
			return TableUtils.serial_numberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vw_dotmed_.oem_ein field.
	/// </summary>
	public string oem_ein
	{
		get
		{
			return this.GetValue(TableUtils.oem_einColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.oem_einColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool oem_einSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.oem_einColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vw_dotmed_.oem_ein field.
	/// </summary>
	public string oem_einDefault
	{
		get
		{
			return TableUtils.oem_einColumn.DefaultValue;
		}
	}


#endregion
}

}
