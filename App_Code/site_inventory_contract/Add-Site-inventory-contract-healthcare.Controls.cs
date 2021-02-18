
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_Site_inventory_contract_healthcare.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"    

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using ReportTools.ReportCreator;
using ReportTools.Shared;

        
using OEMConversion.Business;
using OEMConversion.Data;
using OEMConversion.UI;
using OEMConversion;
		

#endregion

  
namespace OEMConversion.UI.Controls.Add_Site_inventory_contract_healthcare
{
  

#region "Section 1: Place your customizations here."

    
public class Site_inventory_contractRecordControl : BaseSite_inventory_contractRecordControl
{
      
        // The BaseSite_inventory_contractRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Site_inventory_contractRecordControl control on the Add_Site_inventory_contract_healthcare page.
// Do not modify this class. Instead override any method in Site_inventory_contractRecordControl.
public class BaseSite_inventory_contractRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseSite_inventory_contractRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Site_inventory_contractRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Site_inventory_contractRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.corporate_id.SelectedIndexChanged += corporate_id_SelectedIndexChanged;
            
              this.corporatecontact_id.SelectedIndexChanged += corporatecontact_id_SelectedIndexChanged;
            
              this.created_by.SelectedIndexChanged += created_by_SelectedIndexChanged;
            
              this.contract_active.CheckedChanged += contract_active_CheckedChanged;
            
              this.contract_details.TextChanged += contract_details_TextChanged;
            
              this.contract_number.TextChanged += contract_number_TextChanged;
            
              this.contract_total_amt.TextChanged += contract_total_amt_TextChanged;
            
              this.created_datetime.TextChanged += created_datetime_TextChanged;
            
              this.end_date.TextChanged += end_date_TextChanged;
            
              this.start_date.TextChanged += start_date_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Site_inventory_contractTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Site_inventory_contractRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Site_inventory_contractRecord[] recList = Site_inventory_contractTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (Site_inventory_contractRecord)Site_inventory_contractRecord.Copy(recList[0], false);
                  
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                Setcontract_active();
                Setcontract_activeLabel();
                Setcontract_details();
                Setcontract_detailsLabel();
                Setcontract_number();
                Setcontract_numberLabel();
                Setcontract_total_amt();
                Setcontract_total_amtLabel();
                Setcorporate_id();
                Setcorporate_idLabel();
                Setcorporatecontact_id();
                Setcorporatecontact_idLabel();
                Setcreated_by();
                Setcreated_datetime();
                Setend_date();
                Setend_dateLabel();
                Setstart_date();
                Setstart_dateLabel();
                

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void Setcontract_active()
        {
            
                    
            // Set the contract_active CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.contract_active is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.contract_activeSpecified) {
                							
                // If the contract_active is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.contract_active.Checked = this.DataSource.contract_active;
                    				
            } else {
            
                // contract_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.contract_active.Checked = Site_inventory_contractTable.contract_active.ParseValue(Site_inventory_contractTable.contract_active.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcontract_details()
        {
            
                    
            // Set the contract_details TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.contract_details is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.contract_detailsSpecified) {
                								
                // If the contract_details is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contractTable.contract_details);
                                
                this.contract_details.Text = formattedValue;
                   
            } 
            
            else {
            
                // contract_details is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.contract_details.Text = Site_inventory_contractTable.contract_details.Format(Site_inventory_contractTable.contract_details.DefaultValue);
            		
            }
            
              this.contract_details.TextChanged += contract_details_TextChanged;
                               
        }
                
        public virtual void Setcontract_number()
        {
            
                    
            // Set the contract_number TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.contract_number is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.contract_numberSpecified) {
                								
                // If the contract_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contractTable.contract_number);
                                
                this.contract_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // contract_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.contract_number.Text = Site_inventory_contractTable.contract_number.Format(Site_inventory_contractTable.contract_number.DefaultValue);
            		
            }
            
              this.contract_number.TextChanged += contract_number_TextChanged;
                               
        }
                
        public virtual void Setcontract_total_amt()
        {
            
                    
            // Set the contract_total_amt TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.contract_total_amt is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.contract_total_amtSpecified) {
                								
                // If the contract_total_amt is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contractTable.contract_total_amt, @"C");
                                
                this.contract_total_amt.Text = formattedValue;
                   
            } 
            
            else {
            
                // contract_total_amt is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.contract_total_amt.Text = Site_inventory_contractTable.contract_total_amt.Format(Site_inventory_contractTable.contract_total_amt.DefaultValue, @"C");
            		
            }
            
              this.contract_total_amt.TextChanged += contract_total_amt_TextChanged;
                               
        }
                
        public virtual void Setcorporate_id()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh corporatecontact_id controls
            this.corporate_id.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the corporate_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.corporate_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcorporate_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.corporate_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"corporate_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatecorporate_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcorporatecontact_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the corporatecontact_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.corporatecontact_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcorporatecontact_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.corporatecontact_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"corporatecontact_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatecorporatecontact_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcreated_by()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the created_by DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.created_by is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcreated_by();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.created_by.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"created_by\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatecreated_byDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcreated_datetime()
        {
            
                    
            // Set the created_datetime TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.created_datetime is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the created_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contractTable.created_datetime, @"g");
                                
                this.created_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // created_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.created_datetime.Text = EvaluateFormula("Now()", this.DataSource, @"g");
            		
            }
            
              this.created_datetime.TextChanged += created_datetime_TextChanged;
                               
        }
                
        public virtual void Setend_date()
        {
            
                    
            // Set the end_date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.end_date is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.end_dateSpecified) {
                								
                // If the end_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contractTable.end_date, @"d");
                                
                this.end_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // end_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.end_date.Text = Site_inventory_contractTable.end_date.Format(Site_inventory_contractTable.end_date.DefaultValue, @"d");
            		
            }
            
              this.end_date.TextChanged += end_date_TextChanged;
                               
        }
                
        public virtual void Setstart_date()
        {
            
                    
            // Set the start_date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.site_inventory_contract database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.site_inventory_contract record retrieved from the database.
            // this.start_date is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.start_dateSpecified) {
                								
                // If the start_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Site_inventory_contractTable.start_date, @"d");
                                
                this.start_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // start_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.start_date.Text = Site_inventory_contractTable.start_date.Format(Site_inventory_contractTable.start_date.DefaultValue, @"d");
            		
            }
            
              this.start_date.TextChanged += start_date_TextChanged;
                               
        }
                
        public virtual void Setcontract_activeLabel()
                  {
                  
                        this.contract_activeLabel.Text = EvaluateFormula("\"Active\"");
                      
                    
        }
                
        public virtual void Setcontract_detailsLabel()
                  {
                  
                    
        }
                
        public virtual void Setcontract_numberLabel()
                  {
                  
                    
        }
                
        public virtual void Setcontract_total_amtLabel()
                  {
                  
                    
        }
                
        public virtual void Setcorporate_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setcorporatecontact_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setend_dateLabel()
                  {
                  
                    
        }
                
        public virtual void Setstart_dateLabel()
                  {
                  
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      
        public virtual void ResetControl()
        {
          
        }
        

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "OEMConversion"));
                }
            }
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getcontract_active();
            Getcontract_details();
            Getcontract_number();
            Getcontract_total_amt();
            Getcorporate_id();
            Getcorporatecontact_id();
            Getcreated_by();
            Getcreated_datetime();
            Getend_date();
            Getstart_date();
        }
        
        
        public virtual void Getcontract_active()
        {	
        		
            // Retrieve the value entered by the user on the contract_active ASP:CheckBox, and
            // save it into the contract_active field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.contract_active = this.contract_active.Checked;						
                    
        }
                
        public virtual void Getcontract_details()
        {
            
            // Retrieve the value entered by the user on the contract_details ASP:TextBox, and
            // save it into the contract_details field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.contract_details.Text, Site_inventory_contractTable.contract_details);							
                          
                      
        }
                
        public virtual void Getcontract_number()
        {
            
            // Retrieve the value entered by the user on the contract_number ASP:TextBox, and
            // save it into the contract_number field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.contract_number.Text, Site_inventory_contractTable.contract_number);							
                          
                      
        }
                
        public virtual void Getcontract_total_amt()
        {
            
            // Retrieve the value entered by the user on the contract_total_amt ASP:TextBox, and
            // save it into the contract_total_amt field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.contract_total_amt.Text, Site_inventory_contractTable.contract_total_amt);							
                          
                      
        }
                
        public virtual void Getcorporate_id()
        {
         // Retrieve the value entered by the user on the corporate_id ASP:DropDownList, and
            // save it into the corporate_id field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.corporate_id), Site_inventory_contractTable.corporate_id);			
                			 
        }
                
        public virtual void Getcorporatecontact_id()
        {
         // Retrieve the value entered by the user on the corporatecontact_id ASP:DropDownList, and
            // save it into the corporatecontact_id field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.corporatecontact_id), Site_inventory_contractTable.corporatecontact_id);			
                			 
        }
                
        public virtual void Getcreated_by()
        {
         // Retrieve the value entered by the user on the created_by ASP:DropDownList, and
            // save it into the created_by field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.created_by), Site_inventory_contractTable.created_by);			
                			 
        }
                
        public virtual void Getcreated_datetime()
        {
            
            // Retrieve the value entered by the user on the created_datetime ASP:TextBox, and
            // save it into the created_datetime field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.created_datetime.Text, Site_inventory_contractTable.created_datetime);							
                          
                      
        }
                
        public virtual void Getend_date()
        {
            
            // Retrieve the value entered by the user on the end_date ASP:TextBox, and
            // save it into the end_date field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.end_date.Text, Site_inventory_contractTable.end_date);							
                          
                      
        }
                
        public virtual void Getstart_date()
        {
            
            // Retrieve the value entered by the user on the start_date ASP:TextBox, and
            // save it into the start_date field in DataSource DatabaseAYS_OEM%dbo.site_inventory_contract record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.start_date.Text, Site_inventory_contractTable.start_date);							
                          
                      
        }
                

      // To customize, override this method in Site_inventory_contractRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersSite_inventory_contractRecordControl = false;
            hasFiltersSite_inventory_contractRecordControl = hasFiltersSite_inventory_contractRecordControl && false; // suppress warning
      
            WhereClause wc;
            Site_inventory_contractTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Site_inventory_contract"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-Site-inventory-contract-healthcare"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Site_inventory_contractTable.site_inventory_contract_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Site_inventory_contractTable.site_inventory_contract_id));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Site_inventory_contractTable.site_inventory_contract_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Site_inventory_contractTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersSite_inventory_contractRecordControl = false;
            hasFiltersSite_inventory_contractRecordControl = hasFiltersSite_inventory_contractRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
                
            return wc;
        }

        
        
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }                                              
        
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          Site_inventory_contractTable.DeleteRecord(pkValue);
          
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
    
        // Generate set method for buttons
        
        public virtual WhereClause CreateWhereClause_corporate_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.corporate table.
            // Examples:
            // wc.iAND(CorporateTable.corporate_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CorporateTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CorporateTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"corporate_.corporate_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_corporatecontact_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.corporate_contacts table.
            // Examples:
            // wc.iAND(Corporate_contactsTable.corporatecontact_title, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Corporate_contactsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Corporate_contactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"corporate_contacts_.corporatecontact_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("Site_inventory_contractRecordControl.corporate_id.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Corporate_contactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"corporate_contacts_.corporate_id"), EvaluateFormula("Site_inventory_contractRecordControl.corporate_id.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("Site_inventory_contractRecordControl.corporate_id.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Site_inventory_contractRecordControl.corporate_id.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_created_byDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Technicians table.
            // Examples:
            // wc.iAND(TechniciansTable.TechName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(TechniciansTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TechniciansTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Technicians_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"Technicians_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.technician_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the corporate_id list.
        protected virtual void Populatecorporate_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.corporate_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.corporate_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_corporate_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_corporate_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CorporateTable.corporate_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the corporate_idDropDownList.
            CorporateRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = CorporateTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (CorporateRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.corporate_idSpecified) 
                        {
                            cvalue = itemValue.corporate_id.ToString().ToString();
                            if (counter < maxItems && this.corporate_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Corporate.corporate_name", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.corporate_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.corporate_id.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.corporate_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.corporate_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.corporate.corporate_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CorporateTable.corporate_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CorporateRecord[] rc = CorporateTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CorporateRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.corporate_idSpecified)
                            cvalue = itemValue.corporate_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Corporate.corporate_name", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.corporate_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the corporatecontact_id list.
        protected virtual void Populatecorporatecontact_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.corporatecontact_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.corporatecontact_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_corporatecontact_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_corporatecontact_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Corporate_contactsTable.corporatecontact_first, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the corporatecontact_idDropDownList.
            Corporate_contactsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Corporate_contactsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Corporate_contactsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.CorporateContact_IdSpecified) 
                        {
                            cvalue = itemValue.CorporateContact_Id.ToString().ToString();
                            if (counter < maxItems && this.corporatecontact_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=Corporate_contacts.corporatecontact_first + \" \" + Corporate_contacts.corporatecontact_last", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.corporatecontact_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.corporatecontact_id.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.corporatecontact_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.corporatecontact_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.corporate_contacts.CorporateContact_Id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Corporate_contactsTable.CorporateContact_Id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Corporate_contactsRecord[] rc = Corporate_contactsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Corporate_contactsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CorporateContact_IdSpecified)
                            cvalue = itemValue.CorporateContact_Id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("=Corporate_contacts.corporatecontact_first + \" \" + Corporate_contacts.corporatecontact_last", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.corporatecontact_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the created_by list.
        protected virtual void Populatecreated_byDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.created_by.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_created_byDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_created_byDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TechniciansTable.TechName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the created_byDropDownList.
            TechniciansRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = TechniciansTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (TechniciansRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.technician_idSpecified) 
                        {
                            cvalue = itemValue.technician_id.ToString().ToString();
                            if (counter < maxItems && this.created_by.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Technicians.TechName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.created_by.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.created_by.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.created_by, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.created_by, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Technicians.technician_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TechniciansTable.technician_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    TechniciansRecord[] rc = TechniciansTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        TechniciansRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.technician_idSpecified)
                            cvalue = itemValue.technician_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Technicians.TechName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.created_by, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void corporate_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[corporate_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[corporate_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.corporate_id.Items.Add(new ListItem(displayText, val));
	            this.corporate_id.SelectedIndex = this.corporate_id.Items.Count - 1;
	            this.Page.Session.Remove(corporate_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(corporate_id.ClientID + "_SelectedDisplayText");
            }
           
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                Setcorporatecontact_id();
                            
                    this.Page.CommitTransaction(sender);
                }
                catch
                {
                    // Upon error, rollback the transaction
                    this.Page.RollBackTransaction(sender);
                }
                finally
                {
                    DbUtils.EndTransaction();
                }
    
                        						
        }
            
        protected virtual void corporatecontact_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[corporatecontact_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[corporatecontact_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.corporatecontact_id.Items.Add(new ListItem(displayText, val));
	            this.corporatecontact_id.SelectedIndex = this.corporatecontact_id.Items.Count - 1;
	            this.Page.Session.Remove(corporatecontact_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(corporatecontact_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void created_by_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[created_by.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[created_by.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.created_by.Items.Add(new ListItem(displayText, val));
	            this.created_by.SelectedIndex = this.created_by.Items.Count - 1;
	            this.Page.Session.Remove(created_by.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(created_by.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void contract_active_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void contract_details_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void contract_number_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void contract_total_amt_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void created_datetime_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void end_date_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void start_date_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseSite_inventory_contractRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseSite_inventory_contractRecordControl_Rec"] = value;
            }
        }
        
        public Site_inventory_contractRecord DataSource {
            get {
                return (Site_inventory_contractRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private int _PageSize;
        public int PageSize {
          get {
            return this._PageSize;
          }
          set {
            this._PageSize = value;
          }
        }
      
        private int _TotalRecords;
        public int TotalRecords {
          get {
            return (this._TotalRecords);
          }
          set {
            if (this.PageSize > 0) {
              this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
            }
            this._TotalRecords = value;
          }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.CheckBox contract_active {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contract_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal contract_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contract_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox contract_details {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contract_details");
            }
        }
            
        public System.Web.UI.WebControls.Literal contract_detailsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contract_detailsLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox contract_number {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contract_number");
            }
        }
            
        public System.Web.UI.WebControls.Literal contract_numberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contract_numberLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox contract_total_amt {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contract_total_amt");
            }
        }
            
        public System.Web.UI.WebControls.Literal contract_total_amtLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contract_total_amtLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList corporate_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList corporatecontact_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporatecontact_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporatecontact_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList created_by {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "created_by");
            }
        }
            
        public System.Web.UI.WebControls.TextBox created_datetime {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "created_datetime");
            }
        }
            
        public System.Web.UI.WebControls.TextBox end_date {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "end_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal end_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "end_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox start_date {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "start_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal start_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "start_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        Site_inventory_contractRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OEMConversion"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    Site_inventory_contractRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "OEMConversion"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual Site_inventory_contractRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new Site_inventory_contractRecord();
            
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  

#endregion
    
  
}

  