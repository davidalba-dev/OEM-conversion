
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_Procurement_request.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_Procurement_request
{
  

#region "Section 1: Place your customizations here."

    
public class Procurement_requestRecordControl : BaseProcurement_requestRecordControl
{
      
        // The BaseProcurement_requestRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Procurement_requestRecordControl control on the Add_Procurement_request page.
// Do not modify this class. Instead override any method in Procurement_requestRecordControl.
public class BaseProcurement_requestRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseProcurement_requestRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Procurement_requestRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Procurement_requestRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.custcontactkey.SelectedIndexChanged += custcontactkey_SelectedIndexChanged;
            
              this.custno.SelectedIndexChanged += custno_SelectedIndexChanged;
            
              this.department_id.SelectedIndexChanged += department_id_SelectedIndexChanged;
            
              this.procurement_status_id.SelectedIndexChanged += procurement_status_id_SelectedIndexChanged;
            
              this.equipment_requested.TextChanged += equipment_requested_TextChanged;
            
              this.new_replace.TextChanged += new_replace_TextChanged;
            
              this.procurement_make.TextChanged += procurement_make_TextChanged;
            
              this.procurement_model.TextChanged += procurement_model_TextChanged;
            
              this.procurement_pref_make.TextChanged += procurement_pref_make_TextChanged;
            
              this.procurement_pref_model.TextChanged += procurement_pref_model_TextChanged;
            
              this.request_datetime.TextChanged += request_datetime_TextChanged;
            
              this.request_status_id.TextChanged += request_status_id_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Procurement_requestTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Procurement_requestRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Procurement_requestRecord[] recList = Procurement_requestTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (Procurement_requestRecord)Procurement_requestRecord.Copy(recList[0], false);
                  
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
        
                Setcustcontactkey();
                Setcustno();
                Setdepartment_id();
                Setdepartment_idLabel();
                Setequipment_requested();
                Setequipment_requestedLabel();
                Setnew_replace();
                Setprocurement_make();
                Setprocurement_makeLabel();
                Setprocurement_model();
                Setprocurement_modelLabel();
                Setprocurement_pref_make();
                Setprocurement_pref_makeLabel();
                Setprocurement_pref_model();
                Setprocurement_pref_modelLabel();
                Setprocurement_status_id();
                Setrequest_datetime();
                Setrequest_status_id();
                

      

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
        
        
        public virtual void Setcustcontactkey()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the custcontactkey DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.custcontactkey is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustcontactkey();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.custcontactkey.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"custcontactkey\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulatecustcontactkeyDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcustno()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh department_id controls
            this.custno.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the custno DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.custno is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustno();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.custno.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"custno\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulatecustnoDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setdepartment_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the department_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.department_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setdepartment_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.department_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"department_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatedepartment_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setequipment_requested()
        {
            
                    
            // Set the equipment_requested TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.equipment_requested is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.equipment_requestedSpecified) {
                								
                // If the equipment_requested is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Procurement_requestTable.equipment_requested);
                                
                this.equipment_requested.Text = formattedValue;
                   
            } 
            
            else {
            
                // equipment_requested is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.equipment_requested.Text = Procurement_requestTable.equipment_requested.Format(Procurement_requestTable.equipment_requested.DefaultValue);
            		
            }
            
              this.equipment_requested.TextChanged += equipment_requested_TextChanged;
                               
        }
                
        public virtual void Setnew_replace()
        {
            
                    
            // Set the new_replace TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.new_replace is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the new_replace is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Procurement_requestTable.new_replace);
                                
                this.new_replace.Text = formattedValue;
                   
            } 
            
            else {
            
                // new_replace is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.new_replace.Text = EvaluateFormula("\"N\"", this.DataSource);
            		
            }
            
              this.new_replace.TextChanged += new_replace_TextChanged;
                               
        }
                
        public virtual void Setprocurement_make()
        {
            
                    
            // Set the procurement_make TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.procurement_make is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.procurement_makeSpecified) {
                								
                // If the procurement_make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Procurement_requestTable.procurement_make);
                                
                this.procurement_make.Text = formattedValue;
                   
            } 
            
            else {
            
                // procurement_make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.procurement_make.Text = Procurement_requestTable.procurement_make.Format(Procurement_requestTable.procurement_make.DefaultValue);
            		
            }
            
              this.procurement_make.TextChanged += procurement_make_TextChanged;
                               
        }
                
        public virtual void Setprocurement_model()
        {
            
                    
            // Set the procurement_model TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.procurement_model is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.procurement_modelSpecified) {
                								
                // If the procurement_model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Procurement_requestTable.procurement_model);
                                
                this.procurement_model.Text = formattedValue;
                   
            } 
            
            else {
            
                // procurement_model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.procurement_model.Text = Procurement_requestTable.procurement_model.Format(Procurement_requestTable.procurement_model.DefaultValue);
            		
            }
            
              this.procurement_model.TextChanged += procurement_model_TextChanged;
                               
        }
                
        public virtual void Setprocurement_pref_make()
        {
            
                    
            // Set the procurement_pref_make TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.procurement_pref_make is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.procurement_pref_makeSpecified) {
                								
                // If the procurement_pref_make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Procurement_requestTable.procurement_pref_make);
                                
                this.procurement_pref_make.Text = formattedValue;
                   
            } 
            
            else {
            
                // procurement_pref_make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.procurement_pref_make.Text = Procurement_requestTable.procurement_pref_make.Format(Procurement_requestTable.procurement_pref_make.DefaultValue);
            		
            }
            
              this.procurement_pref_make.TextChanged += procurement_pref_make_TextChanged;
                               
        }
                
        public virtual void Setprocurement_pref_model()
        {
            
                    
            // Set the procurement_pref_model TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.procurement_pref_model is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.procurement_pref_modelSpecified) {
                								
                // If the procurement_pref_model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Procurement_requestTable.procurement_pref_model);
                                
                this.procurement_pref_model.Text = formattedValue;
                   
            } 
            
            else {
            
                // procurement_pref_model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.procurement_pref_model.Text = Procurement_requestTable.procurement_pref_model.Format(Procurement_requestTable.procurement_pref_model.DefaultValue);
            		
            }
            
              this.procurement_pref_model.TextChanged += procurement_pref_model_TextChanged;
                               
        }
                
        public virtual void Setprocurement_status_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the procurement_status_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.procurement_status_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setprocurement_status_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.procurement_status_id.ToString();
                
            }
            else
            {
                			
                selectedValue = null;
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateprocurement_status_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setrequest_datetime()
        {
            
                    
            // Set the request_datetime TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.request_datetime is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the request_datetime is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Procurement_requestTable.request_datetime, @"g");
                                
                this.request_datetime.Text = formattedValue;
                   
            } 
            
            else {
            
                // request_datetime is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.request_datetime.Text = EvaluateFormula("Now()", this.DataSource, @"g");
            		
            }
            
              this.request_datetime.TextChanged += request_datetime_TextChanged;
                               
        }
                
        public virtual void Setrequest_status_id()
        {
            
                    
            // Set the request_status_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.procurement_request database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.procurement_request record retrieved from the database.
            // this.request_status_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the request_status_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.request_status_id.ToString();
                            
                this.request_status_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // request_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.request_status_id.Text = EvaluateFormula("1", this.DataSource);
            		
            }
            
              this.request_status_id.TextChanged += request_status_id_TextChanged;
                               
        }
                
        public virtual void Setdepartment_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setequipment_requestedLabel()
                  {
                  
                    
        }
                
        public virtual void Setprocurement_makeLabel()
                  {
                  
                        this.procurement_makeLabel.Text = EvaluateFormula("\"Make\"");
                      
                    
        }
                
        public virtual void Setprocurement_modelLabel()
                  {
                  
                        this.procurement_modelLabel.Text = EvaluateFormula("\"Model\"");
                      
                    
        }
                
        public virtual void Setprocurement_pref_makeLabel()
                  {
                  
                        this.procurement_pref_makeLabel.Text = EvaluateFormula("\"Preferred Make\"");
                      
                    
        }
                
        public virtual void Setprocurement_pref_modelLabel()
                  {
                  
                        this.procurement_pref_modelLabel.Text = EvaluateFormula("\"Preferred Model\"");
                      
                    
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
        
            Getcustcontactkey();
            Getcustno();
            Getdepartment_id();
            Getequipment_requested();
            Getnew_replace();
            Getprocurement_make();
            Getprocurement_model();
            Getprocurement_pref_make();
            Getprocurement_pref_model();
            Getprocurement_status_id();
            Getrequest_datetime();
            Getrequest_status_id();
        }
        
        
        public virtual void Getcustcontactkey()
        {
         // Retrieve the value entered by the user on the custcontactkey ASP:DropDownList, and
            // save it into the custcontactkey field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.custcontactkey), Procurement_requestTable.custcontactkey);			
                			 
        }
                
        public virtual void Getcustno()
        {
         // Retrieve the value entered by the user on the custno ASP:DropDownList, and
            // save it into the custno field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.custno), Procurement_requestTable.custno);			
                			 
        }
                
        public virtual void Getdepartment_id()
        {
         // Retrieve the value entered by the user on the department_id ASP:DropDownList, and
            // save it into the department_id field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.department_id), Procurement_requestTable.department_id);			
                			 
        }
                
        public virtual void Getequipment_requested()
        {
            
            // Retrieve the value entered by the user on the equipment_requested ASP:TextBox, and
            // save it into the equipment_requested field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.equipment_requested.Text, Procurement_requestTable.equipment_requested);							
                          
                      
        }
                
        public virtual void Getnew_replace()
        {
            
            // Retrieve the value entered by the user on the new_replace ASP:TextBox, and
            // save it into the new_replace field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.new_replace.Text, Procurement_requestTable.new_replace);							
                          
                      
        }
                
        public virtual void Getprocurement_make()
        {
            
            // Retrieve the value entered by the user on the procurement_make ASP:TextBox, and
            // save it into the procurement_make field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.procurement_make.Text, Procurement_requestTable.procurement_make);							
                          
                      
        }
                
        public virtual void Getprocurement_model()
        {
            
            // Retrieve the value entered by the user on the procurement_model ASP:TextBox, and
            // save it into the procurement_model field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.procurement_model.Text, Procurement_requestTable.procurement_model);							
                          
                      
        }
                
        public virtual void Getprocurement_pref_make()
        {
            
            // Retrieve the value entered by the user on the procurement_pref_make ASP:TextBox, and
            // save it into the procurement_pref_make field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.procurement_pref_make.Text, Procurement_requestTable.procurement_pref_make);							
                          
                      
        }
                
        public virtual void Getprocurement_pref_model()
        {
            
            // Retrieve the value entered by the user on the procurement_pref_model ASP:TextBox, and
            // save it into the procurement_pref_model field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.procurement_pref_model.Text, Procurement_requestTable.procurement_pref_model);							
                          
                      
        }
                
        public virtual void Getprocurement_status_id()
        {
         // Retrieve the value entered by the user on the procurement_status_id ASP:DropDownList, and
            // save it into the procurement_status_id field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.procurement_status_id), Procurement_requestTable.procurement_status_id);			
                			 
        }
                
        public virtual void Getrequest_datetime()
        {
            
            // Retrieve the value entered by the user on the request_datetime ASP:TextBox, and
            // save it into the request_datetime field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.request_datetime.Text, Procurement_requestTable.request_datetime);							
                          
                      
        }
                
        public virtual void Getrequest_status_id()
        {
            
            // Retrieve the value entered by the user on the request_status_id ASP:TextBox, and
            // save it into the request_status_id field in DataSource DatabaseAYS_OEM%dbo.procurement_request record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.request_status_id.Text, Procurement_requestTable.request_status_id);							
                          
                      
        }
                

      // To customize, override this method in Procurement_requestRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersProcurement_requestRecordControl = false;
            hasFiltersProcurement_requestRecordControl = hasFiltersProcurement_requestRecordControl && false; // suppress warning
      
            WhereClause wc;
            Procurement_requestTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Procurement_request"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-Procurement-request"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Procurement_requestTable.procurement_request_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Procurement_requestTable.procurement_request_id));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Procurement_requestTable.procurement_request_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Procurement_requestTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersProcurement_requestRecordControl = false;
            hasFiltersProcurement_requestRecordControl = hasFiltersProcurement_requestRecordControl && false; // suppress warning
      
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
          Procurement_requestTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_custcontactkeyDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.CustomerContacts table.
            // Examples:
            // wc.iAND(CustomerContactsTable.CustContactKey, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomerContactsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContactKey"), new BaseClasses.Data.IdentifierAliasInfo(@"CustomerContacts_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.customer_contact_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_custnoDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Customers table.
            // Examples:
            // wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomersTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.CustNo"), new BaseClasses.Data.IdentifierAliasInfo(@"Customers_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustNo"), new BaseClasses.Data.IdentifierAliasInfo(@"CustomerContacts_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContactKey"), new BaseClasses.Data.IdentifierAliasInfo(@"CustomerContacts_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.customer_contact_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("UserId()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("UserId()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("UserId()", false) == "--PLEASE_SELECT--" || EvaluateFormula("UserId()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_department_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.department table.
            // Examples:
            // wc.iAND(DepartmentTable.department_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(DepartmentTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("Procurement_requestRecordControl.custno.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.DepartmentTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"department_.custno"), EvaluateFormula("Procurement_requestRecordControl.custno.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Procurement_requestRecordControl.custno.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Procurement_requestRecordControl.custno.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_procurement_status_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.procurement_status table.
            // Examples:
            // wc.iAND(Procurement_statusTable.procurement_status_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Procurement_statusTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Procurement_statusTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"procurement_status_.procurement_status_id"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the custcontactkey list.
        protected virtual void PopulatecustcontactkeyDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.custcontactkey.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_custcontactkeyDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_custcontactkeyDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomerContactsTable.CustContactName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the custcontactkeyDropDownList.
            CustomerContactsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = CustomerContactsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (CustomerContactsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.CustContactKeySpecified) 
                        {
                            cvalue = itemValue.CustContactKey.ToString().ToString();
                            if (counter < maxItems && this.custcontactkey.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Procurement_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Procurement_requestTable.custcontactkey);
                                if(_isExpandableNonCompositeForeignKey && Procurement_requestTable.custcontactkey.IsApplyDisplayAs)
                                    fvalue = Procurement_requestTable.GetDFKA(itemValue, Procurement_requestTable.custcontactkey);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(CustomerContactsTable.CustContactKey);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.custcontactkey.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.custcontactkey.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.custcontactkey, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.custcontactkey, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.CustomerContacts.CustContactKey = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CustomerContactsTable.CustContactKey, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CustomerContactsRecord[] rc = CustomerContactsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CustomerContactsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CustContactKeySpecified)
                            cvalue = itemValue.CustContactKey.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Procurement_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Procurement_requestTable.custcontactkey);
                        if(_isExpandableNonCompositeForeignKey && Procurement_requestTable.custcontactkey.IsApplyDisplayAs)
                            fvalue = Procurement_requestTable.GetDFKA(itemValue, Procurement_requestTable.custcontactkey);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CustomerContactsTable.CustContactKey);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.custcontactkey, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the custno list.
        protected virtual void PopulatecustnoDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.custno.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_custnoDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_custnoDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the custnoDropDownList.
            CustomersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = CustomersTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (CustomersRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.CustNoSpecified) 
                        {
                            cvalue = itemValue.CustNo.ToString().ToString();
                            if (counter < maxItems && this.custno.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Procurement_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Procurement_requestTable.custno);
                                if(_isExpandableNonCompositeForeignKey && Procurement_requestTable.custno.IsApplyDisplayAs)
                                    fvalue = Procurement_requestTable.GetDFKA(itemValue, Procurement_requestTable.custno);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(CustomersTable.CustNo);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.custno.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.custno.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.custno, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.custno, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Customers.CustNo = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CustomersTable.CustNo, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CustomersRecord[] rc = CustomersTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CustomersRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CustNoSpecified)
                            cvalue = itemValue.CustNo.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Procurement_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Procurement_requestTable.custno);
                        if(_isExpandableNonCompositeForeignKey && Procurement_requestTable.custno.IsApplyDisplayAs)
                            fvalue = Procurement_requestTable.GetDFKA(itemValue, Procurement_requestTable.custno);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CustomersTable.CustNo);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.custno, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the department_id list.
        protected virtual void Populatedepartment_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.department_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.department_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_department_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_department_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(DepartmentTable.department_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the department_idDropDownList.
            DepartmentRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = DepartmentTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (DepartmentRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.department_idSpecified) 
                        {
                            cvalue = itemValue.department_id.ToString().ToString();
                            if (counter < maxItems && this.department_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Department.department_name", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.department_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.department_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.department_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.department_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.department.department_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(DepartmentTable.department_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    DepartmentRecord[] rc = DepartmentTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        DepartmentRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.department_idSpecified)
                            cvalue = itemValue.department_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Department.department_name", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.department_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the procurement_status_id list.
        protected virtual void Populateprocurement_status_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.procurement_status_id.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_procurement_status_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_procurement_status_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Procurement_statusTable.procurement_status, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the procurement_status_idDropDownList.
            Procurement_statusRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Procurement_statusTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Procurement_statusRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.procurement_status_idSpecified) 
                        {
                            cvalue = itemValue.procurement_status_id.ToString().ToString();
                            if (counter < maxItems && this.procurement_status_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Procurement_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Procurement_requestTable.procurement_status_id);
                                if(_isExpandableNonCompositeForeignKey && Procurement_requestTable.procurement_status_id.IsApplyDisplayAs)
                                    fvalue = Procurement_requestTable.GetDFKA(itemValue, Procurement_requestTable.procurement_status_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Procurement_statusTable.procurement_status_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.procurement_status_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.procurement_status_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.procurement_status_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.procurement_status_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.procurement_status.procurement_status_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Procurement_statusTable.procurement_status_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Procurement_statusRecord[] rc = Procurement_statusTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Procurement_statusRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.procurement_status_idSpecified)
                            cvalue = itemValue.procurement_status_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Procurement_requestTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Procurement_requestTable.procurement_status_id);
                        if(_isExpandableNonCompositeForeignKey && Procurement_requestTable.procurement_status_id.IsApplyDisplayAs)
                            fvalue = Procurement_requestTable.GetDFKA(itemValue, Procurement_requestTable.procurement_status_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Procurement_statusTable.procurement_status_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.procurement_status_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void custcontactkey_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[custcontactkey.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[custcontactkey.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.custcontactkey.Items.Add(new ListItem(displayText, val));
	            this.custcontactkey.SelectedIndex = this.custcontactkey.Items.Count - 1;
	            this.Page.Session.Remove(custcontactkey.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(custcontactkey.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void custno_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[custno.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[custno.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.custno.Items.Add(new ListItem(displayText, val));
	            this.custno.SelectedIndex = this.custno.Items.Count - 1;
	            this.Page.Session.Remove(custno.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(custno.ClientID + "_SelectedDisplayText");
            }
           
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                Setdepartment_id();
                            
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
            
        protected virtual void department_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[department_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[department_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.department_id.Items.Add(new ListItem(displayText, val));
	            this.department_id.SelectedIndex = this.department_id.Items.Count - 1;
	            this.Page.Session.Remove(department_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(department_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void procurement_status_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[procurement_status_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[procurement_status_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.procurement_status_id.Items.Add(new ListItem(displayText, val));
	            this.procurement_status_id.SelectedIndex = this.procurement_status_id.Items.Count - 1;
	            this.Page.Session.Remove(procurement_status_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(procurement_status_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void equipment_requested_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void new_replace_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void procurement_make_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void procurement_model_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void procurement_pref_make_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void procurement_pref_model_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void request_datetime_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void request_status_id_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseProcurement_requestRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseProcurement_requestRecordControl_Rec"] = value;
            }
        }
        
        public Procurement_requestRecord DataSource {
            get {
                return (Procurement_requestRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.DropDownList custcontactkey {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custcontactkey");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList custno {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList department_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "department_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal department_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "department_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox equipment_requested {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_requested");
            }
        }
            
        public System.Web.UI.WebControls.Literal equipment_requestedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_requestedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox new_replace {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "new_replace");
            }
        }
            
        public System.Web.UI.WebControls.TextBox procurement_make {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "procurement_make");
            }
        }
            
        public System.Web.UI.WebControls.Literal procurement_makeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "procurement_makeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox procurement_model {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "procurement_model");
            }
        }
            
        public System.Web.UI.WebControls.Literal procurement_modelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "procurement_modelLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox procurement_pref_make {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "procurement_pref_make");
            }
        }
            
        public System.Web.UI.WebControls.Literal procurement_pref_makeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "procurement_pref_makeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox procurement_pref_model {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "procurement_pref_model");
            }
        }
            
        public System.Web.UI.WebControls.Literal procurement_pref_modelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "procurement_pref_modelLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList procurement_status_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "procurement_status_id");
            }
        }
            
        public System.Web.UI.WebControls.TextBox request_datetime {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_datetime");
            }
        }
            
        public System.Web.UI.WebControls.TextBox request_status_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "request_status_id");
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
        Procurement_requestRecord rec = null;
             
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
    Procurement_requestRecord rec = null;
    
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

        
        public virtual Procurement_requestRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new Procurement_requestRecord();
            
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

  