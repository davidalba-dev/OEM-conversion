
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_LedgerComm.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_LedgerComm
{
  

#region "Section 1: Place your customizations here."

    
public class LedgerCommRecordControl : BaseLedgerCommRecordControl
{
      
        // The BaseLedgerCommRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the LedgerCommRecordControl control on the Add_LedgerComm page.
// Do not modify this class. Instead override any method in LedgerCommRecordControl.
public class BaseLedgerCommRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseLedgerCommRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in LedgerCommRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in LedgerCommRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.LdgCommType.TextChanged += LdgCommType_TextChanged;
            
              this.LdgFormNo.TextChanged += LdgFormNo_TextChanged;
            
              this.LdgFormType.TextChanged += LdgFormType_TextChanged;
            
              this.LdgRecDate.TextChanged += LdgRecDate_TextChanged;
            
              this.LdgSubject.TextChanged += LdgSubject_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.LedgerComm record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = LedgerCommTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new LedgerCommRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            LedgerCommRecord[] recList = LedgerCommTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (LedgerCommRecord)LedgerCommRecord.Copy(recList[0], false);
                  
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
        
                SetLdgAddress();
                SetLdgAddressLabel();
                SetLdgAttachments();
                SetLdgAttachmentsLabel();
                SetLdgCommType();
                SetLdgCommTypeLabel();
                SetLdgFormNo();
                SetLdgFormNoLabel();
                SetLdgFormType();
                SetLdgFormTypeLabel();
                SetLdgMessage();
                SetLdgMessageLabel();
                SetLdgRecDate();
                SetLdgRecDateLabel();
                SetLdgSubject();
                SetLdgSubjectLabel();
                

      

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
        
        
        public virtual void SetLdgAddress()
        {
            
                    
            // Set the LdgAddress TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerComm database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerComm record retrieved from the database.
            // this.LdgAddress is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgAddressSpecified) {
                								
                // If the LdgAddress is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerCommTable.LdgAddress);
                                                
                this.LdgAddress.Content = formattedValue;
                 
            } 
            
            else {
            
                // LdgAddress is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                    
            this.LdgAddress.Content = LedgerCommTable.LdgAddress.Format(LedgerCommTable.LdgAddress.DefaultValue);
          		
            }
                               
        }
                
        public virtual void SetLdgAttachments()
        {
            
                    
            // Set the LdgAttachments TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerComm database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerComm record retrieved from the database.
            // this.LdgAttachments is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgAttachmentsSpecified) {
                								
                // If the LdgAttachments is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerCommTable.LdgAttachments);
                                                
                this.LdgAttachments.Content = formattedValue;
                 
            } 
            
            else {
            
                // LdgAttachments is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                    
            this.LdgAttachments.Content = LedgerCommTable.LdgAttachments.Format(LedgerCommTable.LdgAttachments.DefaultValue);
          		
            }
                               
        }
                
        public virtual void SetLdgCommType()
        {
            
                    
            // Set the LdgCommType TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerComm database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerComm record retrieved from the database.
            // this.LdgCommType is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgCommTypeSpecified) {
                								
                // If the LdgCommType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerCommTable.LdgCommType);
                                
                this.LdgCommType.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgCommType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgCommType.Text = LedgerCommTable.LdgCommType.Format(LedgerCommTable.LdgCommType.DefaultValue);
            		
            }
            
              this.LdgCommType.TextChanged += LdgCommType_TextChanged;
                               
        }
                
        public virtual void SetLdgFormNo()
        {
            
                    
            // Set the LdgFormNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerComm database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerComm record retrieved from the database.
            // this.LdgFormNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgFormNoSpecified) {
                								
                // If the LdgFormNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerCommTable.LdgFormNo);
                                
                this.LdgFormNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgFormNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgFormNo.Text = LedgerCommTable.LdgFormNo.Format(LedgerCommTable.LdgFormNo.DefaultValue);
            		
            }
            
              this.LdgFormNo.TextChanged += LdgFormNo_TextChanged;
                               
        }
                
        public virtual void SetLdgFormType()
        {
            
                    
            // Set the LdgFormType TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerComm database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerComm record retrieved from the database.
            // this.LdgFormType is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgFormTypeSpecified) {
                								
                // If the LdgFormType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerCommTable.LdgFormType);
                                
                this.LdgFormType.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgFormType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgFormType.Text = LedgerCommTable.LdgFormType.Format(LedgerCommTable.LdgFormType.DefaultValue);
            		
            }
            
              this.LdgFormType.TextChanged += LdgFormType_TextChanged;
                               
        }
                
        public virtual void SetLdgMessage()
        {
            
                    
            // Set the LdgMessage TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerComm database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerComm record retrieved from the database.
            // this.LdgMessage is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgMessageSpecified) {
                								
                // If the LdgMessage is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerCommTable.LdgMessage);
                                                
                this.LdgMessage.Content = formattedValue;
                 
            } 
            
            else {
            
                // LdgMessage is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                    
            this.LdgMessage.Content = LedgerCommTable.LdgMessage.Format(LedgerCommTable.LdgMessage.DefaultValue);
          		
            }
                               
        }
                
        public virtual void SetLdgRecDate()
        {
            
                    
            // Set the LdgRecDate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerComm database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerComm record retrieved from the database.
            // this.LdgRecDate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgRecDateSpecified) {
                								
                // If the LdgRecDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerCommTable.LdgRecDate, @"g");
                                
                this.LdgRecDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgRecDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgRecDate.Text = LedgerCommTable.LdgRecDate.Format(LedgerCommTable.LdgRecDate.DefaultValue, @"g");
            		
            }
            
              this.LdgRecDate.TextChanged += LdgRecDate_TextChanged;
                               
        }
                
        public virtual void SetLdgSubject()
        {
            
                    
            // Set the LdgSubject TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerComm database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerComm record retrieved from the database.
            // this.LdgSubject is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgSubjectSpecified) {
                								
                // If the LdgSubject is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerCommTable.LdgSubject);
                                
                this.LdgSubject.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgSubject is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgSubject.Text = LedgerCommTable.LdgSubject.Format(LedgerCommTable.LdgSubject.DefaultValue);
            		
            }
            
              this.LdgSubject.TextChanged += LdgSubject_TextChanged;
                               
        }
                
        public virtual void SetLdgAddressLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgAttachmentsLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgCommTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgFormNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgFormTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgMessageLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgRecDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgSubjectLabel()
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
        
            GetLdgAddress();
            GetLdgAttachments();
            GetLdgCommType();
            GetLdgFormNo();
            GetLdgFormType();
            GetLdgMessage();
            GetLdgRecDate();
            GetLdgSubject();
        }
        
        
        public virtual void GetLdgAddress()
        {
            
            // Retrieve the value entered by the user on the LdgAddress ASP:TextBox, and
            // save it into the LdgAddress field in DataSource DatabaseAYS_OEM%dbo.LedgerComm record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgAddress.Content, LedgerCommTable.LdgAddress);							
                          
                      
        }
                
        public virtual void GetLdgAttachments()
        {
            
            // Retrieve the value entered by the user on the LdgAttachments ASP:TextBox, and
            // save it into the LdgAttachments field in DataSource DatabaseAYS_OEM%dbo.LedgerComm record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgAttachments.Content, LedgerCommTable.LdgAttachments);							
                          
                      
        }
                
        public virtual void GetLdgCommType()
        {
            
            // Retrieve the value entered by the user on the LdgCommType ASP:TextBox, and
            // save it into the LdgCommType field in DataSource DatabaseAYS_OEM%dbo.LedgerComm record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgCommType.Text, LedgerCommTable.LdgCommType);							
                          
                      
        }
                
        public virtual void GetLdgFormNo()
        {
            
            // Retrieve the value entered by the user on the LdgFormNo ASP:TextBox, and
            // save it into the LdgFormNo field in DataSource DatabaseAYS_OEM%dbo.LedgerComm record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgFormNo.Text, LedgerCommTable.LdgFormNo);							
                          
                      
        }
                
        public virtual void GetLdgFormType()
        {
            
            // Retrieve the value entered by the user on the LdgFormType ASP:TextBox, and
            // save it into the LdgFormType field in DataSource DatabaseAYS_OEM%dbo.LedgerComm record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgFormType.Text, LedgerCommTable.LdgFormType);							
                          
                      
        }
                
        public virtual void GetLdgMessage()
        {
            
            // Retrieve the value entered by the user on the LdgMessage ASP:TextBox, and
            // save it into the LdgMessage field in DataSource DatabaseAYS_OEM%dbo.LedgerComm record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgMessage.Content, LedgerCommTable.LdgMessage);							
                          
                      
        }
                
        public virtual void GetLdgRecDate()
        {
            
            // Retrieve the value entered by the user on the LdgRecDate ASP:TextBox, and
            // save it into the LdgRecDate field in DataSource DatabaseAYS_OEM%dbo.LedgerComm record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgRecDate.Text, LedgerCommTable.LdgRecDate);							
                          
                      
        }
                
        public virtual void GetLdgSubject()
        {
            
            // Retrieve the value entered by the user on the LdgSubject ASP:TextBox, and
            // save it into the LdgSubject field in DataSource DatabaseAYS_OEM%dbo.LedgerComm record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgSubject.Text, LedgerCommTable.LdgSubject);							
                          
                      
        }
                

      // To customize, override this method in LedgerCommRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersLedgerCommRecordControl = false;
            hasFiltersLedgerCommRecordControl = hasFiltersLedgerCommRecordControl && false; // suppress warning
      
            WhereClause wc;
            LedgerCommTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["LedgerComm"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-LedgerComm"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(LedgerCommTable.LdgKey, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(LedgerCommTable.LdgKey));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(LedgerCommTable.LdgKey, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            LedgerCommTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersLedgerCommRecordControl = false;
            hasFiltersLedgerCommRecordControl = hasFiltersLedgerCommRecordControl && false; // suppress warning
      
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
          LedgerCommTable.DeleteRecord(pkValue);
          
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
        
        protected virtual void LdgAddress_TextChanged(object sender, EventArgs args)
        {
                    
                // this event handler is not supported since LdgAddress is an Ajax HTML Editor.
              
              }
            
        protected virtual void LdgAttachments_TextChanged(object sender, EventArgs args)
        {
                    
                // this event handler is not supported since LdgAttachments is an Ajax HTML Editor.
              
              }
            
        protected virtual void LdgCommType_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgFormNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgFormType_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgMessage_TextChanged(object sender, EventArgs args)
        {
                    
                // this event handler is not supported since LdgMessage is an Ajax HTML Editor.
              
              }
            
        protected virtual void LdgRecDate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgSubject_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseLedgerCommRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseLedgerCommRecordControl_Rec"] = value;
            }
        }
        
        public LedgerCommRecord DataSource {
            get {
                return (LedgerCommRecord)(this._DataSource);
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
        
              public AjaxControlToolkit.HTMLEditor.Editor LdgAddress {
              get {
                  return (AjaxControlToolkit.HTMLEditor.Editor)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgAddress");
                  }
              }
          
        public System.Web.UI.WebControls.Literal LdgAddressLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgAddressLabel");
            }
        }
        
              public AjaxControlToolkit.HTMLEditor.Editor LdgAttachments {
              get {
                  return (AjaxControlToolkit.HTMLEditor.Editor)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgAttachments");
                  }
              }
          
        public System.Web.UI.WebControls.Literal LdgAttachmentsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgAttachmentsLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgCommType {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgCommType");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgCommTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgCommTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgFormNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgFormNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgFormType {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormType");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgFormTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormTypeLabel");
            }
        }
        
              public AjaxControlToolkit.HTMLEditor.Editor LdgMessage {
              get {
                  return (AjaxControlToolkit.HTMLEditor.Editor)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgMessage");
                  }
              }
          
        public System.Web.UI.WebControls.Literal LdgMessageLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgMessageLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgRecDate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgRecDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgSubject {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgSubject");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgSubjectLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgSubjectLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
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
        LedgerCommRecord rec = null;
             
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
    LedgerCommRecord rec = null;
    
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

        
        public virtual LedgerCommRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new LedgerCommRecord();
            
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

  