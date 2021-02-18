
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_CustomerContacts_NoLogin.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_CustomerContacts_NoLogin
{
  

#region "Section 1: Place your customizations here."

    
public class CustomerContactsRecordControl : BaseCustomerContactsRecordControl
{
      
        // The BaseCustomerContactsRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the CustomerContactsRecordControl control on the Edit_CustomerContacts_NoLogin page.
// Do not modify this class. Instead override any method in CustomerContactsRecordControl.
public class BaseCustomerContactsRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseCustomerContactsRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in CustomerContactsRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in CustomerContactsRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.Button.Button.Click += Button_Click;
                        
              this.CustContact_active.CheckedChanged += CustContact_active_CheckedChanged;
            
              this.CustContact_AP.CheckedChanged += CustContact_AP_CheckedChanged;
            
              this.CustContact_QS.CheckedChanged += CustContact_QS_CheckedChanged;
            
              this.CustPrimary.CheckedChanged += CustPrimary_CheckedChanged;
            
              this.CustSecondary.CheckedChanged += CustSecondary_CheckedChanged;
            
              this.CustContactEmail.TextChanged += CustContactEmail_TextChanged;
            
              this.CustContactFax.TextChanged += CustContactFax_TextChanged;
            
              this.CustContactName.TextChanged += CustContactName_TextChanged;
            
              this.CustContactPhoneBusiness.TextChanged += CustContactPhoneBusiness_TextChanged;
            
              this.CustContactPhoneMobile.TextChanged += CustContactPhoneMobile_TextChanged;
            
              this.CustContactTitle.TextChanged += CustContactTitle_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = CustomerContactsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CustomerContactsRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new CustomerContactsRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            CustomerContactsRecord[] recList = CustomerContactsTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = CustomerContactsTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                
                SetCustContact_active();
                SetCustContact_activeLabel();
                SetCustContact_AP();
                SetCustContact_APLabel();
                SetCustContact_QS();
                SetCustContact_QSLabel();
                SetCustContactEmail();
                SetCustContactEmailLabel();
                SetCustContactFax();
                SetCustContactFaxLabel();
                SetCustContactName();
                SetCustContactNameLabel();
                SetCustContactPhoneBusiness();
                SetCustContactPhoneBusinessLabel();
                SetCustContactPhoneMobile();
                SetCustContactPhoneMobileLabel();
                SetCustContactTitle();
                SetCustContactTitleLabel();
                SetCustPrimary();
                SetCustPrimaryLabel();
                SetCustSecondary();
                SetCustSecondaryLabel();
                
                SetButton();
              

      

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
        
        
        public virtual void SetCustContact_active()
        {
            
                    
            // Set the CustContact_active CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContact_active is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContact_activeSpecified) {
                							
                // If the CustContact_active is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustContact_active.Checked = this.DataSource.CustContact_active;
                    				
            } else {
            
                // CustContact_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustContact_active.Checked = CustomerContactsTable.CustContact_active.ParseValue(CustomerContactsTable.CustContact_active.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustContact_AP()
        {
            
                    
            // Set the CustContact_AP CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContact_AP is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContact_APSpecified) {
                							
                // If the CustContact_AP is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustContact_AP.Checked = this.DataSource.CustContact_AP;
                    				
            } else {
            
                // CustContact_AP is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustContact_AP.Checked = CustomerContactsTable.CustContact_AP.ParseValue(CustomerContactsTable.CustContact_AP.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustContact_QS()
        {
            
                    
            // Set the CustContact_QS CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContact_QS is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContact_QSSpecified) {
                							
                // If the CustContact_QS is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustContact_QS.Checked = this.DataSource.CustContact_QS;
                    				
            } else {
            
                // CustContact_QS is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustContact_QS.Checked = CustomerContactsTable.CustContact_QS.ParseValue(CustomerContactsTable.CustContact_QS.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustContactEmail()
        {
            
                    
            // Set the CustContactEmail TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactEmail is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactEmailSpecified) {
                								
                // If the CustContactEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactEmail);
                                
                this.CustContactEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactEmail.Text = CustomerContactsTable.CustContactEmail.Format(CustomerContactsTable.CustContactEmail.DefaultValue);
            		
            }
            
              this.CustContactEmail.TextChanged += CustContactEmail_TextChanged;
                               
        }
                
        public virtual void SetCustContactFax()
        {
            
                    
            // Set the CustContactFax TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactFax is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactFaxSpecified) {
                								
                // If the CustContactFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactFax);
                                
                this.CustContactFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactFax.Text = CustomerContactsTable.CustContactFax.Format(CustomerContactsTable.CustContactFax.DefaultValue);
            		
            }
            
              this.CustContactFax.TextChanged += CustContactFax_TextChanged;
                               
        }
                
        public virtual void SetCustContactName()
        {
            
                    
            // Set the CustContactName TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactNameSpecified) {
                								
                // If the CustContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactName);
                                
                this.CustContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactName.Text = CustomerContactsTable.CustContactName.Format(CustomerContactsTable.CustContactName.DefaultValue);
            		
            }
            
              this.CustContactName.TextChanged += CustContactName_TextChanged;
                               
        }
                
        public virtual void SetCustContactPhoneBusiness()
        {
            
                    
            // Set the CustContactPhoneBusiness TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactPhoneBusiness is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactPhoneBusinessSpecified) {
                								
                // If the CustContactPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactPhoneBusiness);
                                
                this.CustContactPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactPhoneBusiness.Text = CustomerContactsTable.CustContactPhoneBusiness.Format(CustomerContactsTable.CustContactPhoneBusiness.DefaultValue);
            		
            }
            
              this.CustContactPhoneBusiness.TextChanged += CustContactPhoneBusiness_TextChanged;
                               
        }
                
        public virtual void SetCustContactPhoneMobile()
        {
            
                    
            // Set the CustContactPhoneMobile TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactPhoneMobile is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactPhoneMobileSpecified) {
                								
                // If the CustContactPhoneMobile is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactPhoneMobile);
                                
                this.CustContactPhoneMobile.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactPhoneMobile is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactPhoneMobile.Text = CustomerContactsTable.CustContactPhoneMobile.Format(CustomerContactsTable.CustContactPhoneMobile.DefaultValue);
            		
            }
            
              this.CustContactPhoneMobile.TextChanged += CustContactPhoneMobile_TextChanged;
                               
        }
                
        public virtual void SetCustContactTitle()
        {
            
                    
            // Set the CustContactTitle TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactTitle is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactTitleSpecified) {
                								
                // If the CustContactTitle is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactTitle);
                                
                this.CustContactTitle.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactTitle is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactTitle.Text = CustomerContactsTable.CustContactTitle.Format(CustomerContactsTable.CustContactTitle.DefaultValue);
            		
            }
            
              this.CustContactTitle.TextChanged += CustContactTitle_TextChanged;
                               
        }
                
        public virtual void SetCustPrimary()
        {
            
                    
            // Set the CustPrimary CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustPrimary is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPrimarySpecified) {
                							
                // If the CustPrimary is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustPrimary.Checked = this.DataSource.CustPrimary;
                    				
            } else {
            
                // CustPrimary is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustPrimary.Checked = CustomerContactsTable.CustPrimary.ParseValue(CustomerContactsTable.CustPrimary.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustSecondary()
        {
            
                    
            // Set the CustSecondary CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustSecondary is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustSecondarySpecified) {
                							
                // If the CustSecondary is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.CustSecondary.Checked = this.DataSource.CustSecondary;
                    				
            } else {
            
                // CustSecondary is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.CustSecondary.Checked = CustomerContactsTable.CustSecondary.ParseValue(CustomerContactsTable.CustSecondary.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetCustContact_activeLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.CustContact_activeLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetCustContact_APLabel()
                  {
                  
                        this.CustContact_APLabel.Text = EvaluateFormula("\"Receives Invoices\"");
                      
                    
        }
                
        public virtual void SetCustContact_QSLabel()
                  {
                  
                        this.CustContact_QSLabel.Text = EvaluateFormula("\"Receives Estimates\"");
                      
                    
        }
                
        public virtual void SetCustContactEmailLabel()
                  {
                  
                        this.CustContactEmailLabel.Text = EvaluateFormula("\"Email\"");
                      
                    
        }
                
        public virtual void SetCustContactFaxLabel()
                  {
                  
                        this.CustContactFaxLabel.Text = EvaluateFormula("\"Contact Fax\"");
                      
                    
        }
                
        public virtual void SetCustContactNameLabel()
                  {
                  
                        this.CustContactNameLabel.Text = EvaluateFormula("\"Contact Name\"");
                      
                    
        }
                
        public virtual void SetCustContactPhoneBusinessLabel()
                  {
                  
                        this.CustContactPhoneBusinessLabel.Text = EvaluateFormula("\"Phone\"");
                      
                    
        }
                
        public virtual void SetCustContactPhoneMobileLabel()
                  {
                  
                        this.CustContactPhoneMobileLabel.Text = EvaluateFormula("\"Mobile\"");
                      
                    
        }
                
        public virtual void SetCustContactTitleLabel()
                  {
                  
                        this.CustContactTitleLabel.Text = EvaluateFormula("\"Title\"");
                      
                    
        }
                
        public virtual void SetCustPrimaryLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustSecondaryLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CustomerContactsRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
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
        
            GetCustContact_active();
            GetCustContact_AP();
            GetCustContact_QS();
            GetCustContactEmail();
            GetCustContactFax();
            GetCustContactName();
            GetCustContactPhoneBusiness();
            GetCustContactPhoneMobile();
            GetCustContactTitle();
            GetCustPrimary();
            GetCustSecondary();
        }
        
        
        public virtual void GetCustContact_active()
        {	
        		
            // Retrieve the value entered by the user on the CustContact_active ASP:CheckBox, and
            // save it into the CustContact_active field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustContact_active = this.CustContact_active.Checked;						
                    
        }
                
        public virtual void GetCustContact_AP()
        {	
        		
            // Retrieve the value entered by the user on the CustContact_AP ASP:CheckBox, and
            // save it into the CustContact_AP field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustContact_AP = this.CustContact_AP.Checked;						
                    
        }
                
        public virtual void GetCustContact_QS()
        {	
        		
            // Retrieve the value entered by the user on the CustContact_QS ASP:CheckBox, and
            // save it into the CustContact_QS field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustContact_QS = this.CustContact_QS.Checked;						
                    
        }
                
        public virtual void GetCustContactEmail()
        {
            
            // Retrieve the value entered by the user on the CustContactEmail ASP:TextBox, and
            // save it into the CustContactEmail field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustContactEmail.Text, CustomerContactsTable.CustContactEmail);							
                          
                      
        }
                
        public virtual void GetCustContactFax()
        {
            
            // Retrieve the value entered by the user on the CustContactFax ASP:TextBox, and
            // save it into the CustContactFax field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustContactFax.Text, CustomerContactsTable.CustContactFax);							
                          
                      
        }
                
        public virtual void GetCustContactName()
        {
            
            // Retrieve the value entered by the user on the CustContactName ASP:TextBox, and
            // save it into the CustContactName field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustContactName.Text, CustomerContactsTable.CustContactName);							
                          
                      
        }
                
        public virtual void GetCustContactPhoneBusiness()
        {
            
            // Retrieve the value entered by the user on the CustContactPhoneBusiness ASP:TextBox, and
            // save it into the CustContactPhoneBusiness field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustContactPhoneBusiness.Text, CustomerContactsTable.CustContactPhoneBusiness);							
                          
                      
        }
                
        public virtual void GetCustContactPhoneMobile()
        {
            
            // Retrieve the value entered by the user on the CustContactPhoneMobile ASP:TextBox, and
            // save it into the CustContactPhoneMobile field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustContactPhoneMobile.Text, CustomerContactsTable.CustContactPhoneMobile);							
                          
                      
        }
                
        public virtual void GetCustContactTitle()
        {
            
            // Retrieve the value entered by the user on the CustContactTitle ASP:TextBox, and
            // save it into the CustContactTitle field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustContactTitle.Text, CustomerContactsTable.CustContactTitle);							
                          
                      
        }
                
        public virtual void GetCustPrimary()
        {	
        		
            // Retrieve the value entered by the user on the CustPrimary ASP:CheckBox, and
            // save it into the CustPrimary field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustPrimary = this.CustPrimary.Checked;						
                    
        }
                
        public virtual void GetCustSecondary()
        {	
        		
            // Retrieve the value entered by the user on the CustSecondary ASP:CheckBox, and
            // save it into the CustSecondary field in DataSource DatabaseAYS_OEM%dbo.CustomerContacts record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.CustSecondary = this.CustSecondary.Checked;						
                    
        }
                

      // To customize, override this method in CustomerContactsRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCustomerContactsRecordControl = false;
            hasFiltersCustomerContactsRecordControl = hasFiltersCustomerContactsRecordControl && false; // suppress warning
      
            WhereClause wc;
            CustomerContactsTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Get the static clause defined at design time on the Record Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            return wc;
          
        }
        
        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("URL(\"CustomerContacts\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomerContactsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"CustomerContacts_.CustContactKey"), EvaluateFormula("URL(\"CustomerContacts\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"CustomerContacts\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"CustomerContacts\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            CustomerContactsTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersCustomerContactsRecordControl = false;
            hasFiltersCustomerContactsRecordControl = hasFiltersCustomerContactsRecordControl && false; // suppress warning
      
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
          CustomerContactsTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetButton()                
              
        {
        
   
        }
            
        // event handler for Button
        public virtual void Button_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../login/Add-Login-Customer.aspx?CustomerNo={CustomerContactsRecordControl:FV:CustNo}&customer_contact_id={CustomerContactsRecordControl:PK}&customercontact_email={CustomerContactsRecordControl:FV:CustContactEmail}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        protected virtual void CustContact_active_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustContact_AP_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustContact_QS_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustPrimary_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustSecondary_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustContactEmail_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustContactFax_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustContactName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustContactPhoneBusiness_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustContactPhoneMobile_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustContactTitle_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseCustomerContactsRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseCustomerContactsRecordControl_Rec"] = value;
            }
        }
        
        public CustomerContactsRecord DataSource {
            get {
                return (CustomerContactsRecord)(this._DataSource);
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
        
        public OEMConversion.UI.IThemeButton Button {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustContact_active {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContact_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustContact_AP {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_AP");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContact_APLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_APLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustContact_QS {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_QS");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContact_QSLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContact_QSLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustContactEmail {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustContactFax {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustContactName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustContactPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustContactPhoneMobile {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneMobile");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactPhoneMobileLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneMobileLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustContactTitle {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactTitle");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactTitleLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactTitleLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustPrimary {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrimary");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPrimaryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPrimaryLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox CustSecondary {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustSecondary");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustSecondaryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustSecondaryLabel");
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
        CustomerContactsRecord rec = null;
             
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
    CustomerContactsRecord rec = null;
    
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

        
        public virtual CustomerContactsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return CustomerContactsTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "OEMConversion"));
                
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

  