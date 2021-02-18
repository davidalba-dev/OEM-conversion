
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_CustomerContacts_Mobile.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_CustomerContacts_Mobile
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
    
    
// Base class for the CustomerContactsRecordControl control on the Show_CustomerContacts_Mobile page.
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
        
              // Show confirmation message on Click
              this.DeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirmOneRecord", "OEMConversion") + "\"));");
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.CancelButton.Click += CancelButton_Click;
                        
                    this.DeleteButton.Click += DeleteButton_Click;
                        
                    this.EditButton.Click += EditButton_Click;
                        
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
                SetCustContactType();
                SetCustContactTypeLabel();
                SetCustNo();
                SetCustNoLabel();
                
                
                SetSessionID();
                SetSessionIDLabel();
                
                SetCancelButton();
              
                SetDeleteButton();
              
                SetEditButton();
              

      

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
        
        
        public virtual void SetCustContactEmail()
        {
            
                    
            // Set the CustContactEmail Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactEmail is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactEmailSpecified) {
                								
                // If the CustContactEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactEmail);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.CustContactEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactEmail.Text = CustomerContactsTable.CustContactEmail.Format(CustomerContactsTable.CustContactEmail.DefaultValue);
            		
            }
            
            // If the CustContactEmail is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactEmail.Text == null ||
                this.CustContactEmail.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactEmail.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactFax()
        {
            
                    
            // Set the CustContactFax Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactFax is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactFaxSpecified) {
                								
                // If the CustContactFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactFax);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.CustContactFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactFax.Text = CustomerContactsTable.CustContactFax.Format(CustomerContactsTable.CustContactFax.DefaultValue);
            		
            }
            
            // If the CustContactFax is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactFax.Text == null ||
                this.CustContactFax.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactFax.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactName()
        {
            
                    
            // Set the CustContactName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactNameSpecified) {
                								
                // If the CustContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.CustContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactName.Text = CustomerContactsTable.CustContactName.Format(CustomerContactsTable.CustContactName.DefaultValue);
            		
            }
            
            // If the CustContactName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactName.Text == null ||
                this.CustContactName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactPhoneBusiness()
        {
            
                    
            // Set the CustContactPhoneBusiness Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactPhoneBusiness is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactPhoneBusinessSpecified) {
                								
                // If the CustContactPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactPhoneBusiness);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.CustContactPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactPhoneBusiness.Text = CustomerContactsTable.CustContactPhoneBusiness.Format(CustomerContactsTable.CustContactPhoneBusiness.DefaultValue);
            		
            }
            
            // If the CustContactPhoneBusiness is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactPhoneBusiness.Text == null ||
                this.CustContactPhoneBusiness.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactPhoneBusiness.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactPhoneMobile()
        {
            
                    
            // Set the CustContactPhoneMobile Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactPhoneMobile is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactPhoneMobileSpecified) {
                								
                // If the CustContactPhoneMobile is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactPhoneMobile);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.CustContactPhoneMobile.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactPhoneMobile is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactPhoneMobile.Text = CustomerContactsTable.CustContactPhoneMobile.Format(CustomerContactsTable.CustContactPhoneMobile.DefaultValue);
            		
            }
            
            // If the CustContactPhoneMobile is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactPhoneMobile.Text == null ||
                this.CustContactPhoneMobile.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactPhoneMobile.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactTitle()
        {
            
                    
            // Set the CustContactTitle Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactTitle is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactTitleSpecified) {
                								
                // If the CustContactTitle is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactTitle);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.CustContactTitle.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactTitle is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactTitle.Text = CustomerContactsTable.CustContactTitle.Format(CustomerContactsTable.CustContactTitle.DefaultValue);
            		
            }
            
            // If the CustContactTitle is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactTitle.Text == null ||
                this.CustContactTitle.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactTitle.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustContactType()
        {
            
                    
            // Set the CustContactType Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustContactType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustContactTypeSpecified) {
                								
                // If the CustContactType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.CustContactType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.CustContactType.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustContactType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustContactType.Text = CustomerContactsTable.CustContactType.Format(CustomerContactsTable.CustContactType.DefaultValue);
            		
            }
            
            // If the CustContactType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustContactType.Text == null ||
                this.CustContactType.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustContactType.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustNo()
        {
            
                    
            // Set the CustNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.CustNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustNoSpecified) {
                								
                // If the CustNo is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = CustomerContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomerContactsTable.CustNo);
               if(_isExpandableNonCompositeForeignKey &&CustomerContactsTable.CustNo.IsApplyDisplayAs)
                                  
                     formattedValue = CustomerContactsTable.GetDFKA(this.DataSource.CustNo.ToString(),CustomerContactsTable.CustNo, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(CustomerContactsTable.CustNo);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.CustNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustNo.Text = CustomerContactsTable.CustNo.Format(CustomerContactsTable.CustNo.DefaultValue);
            		
            }
            
            // If the CustNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustNo.Text == null ||
                this.CustNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSessionID()
        {
            
                    
            // Set the SessionID Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.CustomerContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.CustomerContacts record retrieved from the database.
            // this.SessionID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SessionIDSpecified) {
                								
                // If the SessionID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomerContactsTable.SessionID);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if ( formattedValue != null && (formattedValue.IndexOf("<") < 0  ||  formattedValue.IndexOf(">") < 0) ) {
                  formattedValue = System.Text.RegularExpressions.Regex.Replace(formattedValue, "(<!--(.|\\s)*?-->)+|(<[^>]*>)+|(&[^;&<>]*;)+|[^&<>\\s]{11}", "$&<wbr/>");
                }
              
                this.SessionID.Text = formattedValue;
                   
            } 
            
            else {
            
                // SessionID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SessionID.Text = CustomerContactsTable.SessionID.Format(CustomerContactsTable.SessionID.DefaultValue);
            		
            }
            
            // If the SessionID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SessionID.Text == null ||
                this.SessionID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SessionID.Text = "&nbsp;";
            }
                                     
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
                
        public virtual void SetCustContactTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustNoLabel()
                  {
                  
                        this.CustNoLabel.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void SetSessionIDLabel()
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
        
            GetCustContactEmail();
            GetCustContactFax();
            GetCustContactName();
            GetCustContactPhoneBusiness();
            GetCustContactPhoneMobile();
            GetCustContactTitle();
            GetCustContactType();
            GetCustNo();
            GetSessionID();
        }
        
        
        public virtual void GetCustContactEmail()
        {
            
        }
                
        public virtual void GetCustContactFax()
        {
            
        }
                
        public virtual void GetCustContactName()
        {
            
        }
                
        public virtual void GetCustContactPhoneBusiness()
        {
            
        }
                
        public virtual void GetCustContactPhoneMobile()
        {
            
        }
                
        public virtual void GetCustContactTitle()
        {
            
        }
                
        public virtual void GetCustContactType()
        {
            
        }
                
        public virtual void GetCustNo()
        {
            
        }
                
        public virtual void GetSessionID()
        {
            
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

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["CustomerContacts"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "CustomerContacts"));
            }
            HttpContext.Current.Session["QueryString in Show-CustomerContacts-Mobile"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(CustomerContactsTable.CustContactKey, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(CustomerContactsTable.CustContactKey));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(CustomerContactsTable.CustContactKey, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
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
        
        public virtual void SetCancelButton()                
              
        {
        
   
        }
            
        public virtual void SetDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetEditButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void CancelButton_Click(object sender, ImageClickEventArgs args)
        {
              
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                
          
                // if target is specified meaning that is opened on popup or new window
                if (!string.IsNullOrEmpty(Page.Request["target"]))
                {
                    shouldRedirect = false;
                    AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "ClosePopup", "closePopupPage();", true);                   
                }
      
            } catch (Exception ex) {
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.RedirectBack();
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void DeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
            if (this.GetRecord() == null){
            throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            this.Delete();
            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            }
      this.Page.CommitTransaction(sender);
            string field = "";
            string formula = "";
            string displayFieldName = "";
            string value = "";
            if(value == null) value = ""; // added to remove warning from VS
            string id = ""; 
            if(id == null) id = ""; //added to avoid warning in VS
            
            // retrieve necessary URL parameters
            if (!String.IsNullOrEmpty(Page.Request["Target"]) )
                target = (this.Page as BaseApplicationPage).GetDecryptedURLParameter("Target");
            if (!String.IsNullOrEmpty(Page.Request["IndexField"]))
                field = (this.Page as BaseApplicationPage).GetDecryptedURLParameter("IndexField");
            if (!String.IsNullOrEmpty(Page.Request["Formula"]))
                formula = (this.Page as BaseApplicationPage).GetDecryptedURLParameter("Formula");
            if (!String.IsNullOrEmpty(Page.Request["DFKA"]))
                displayFieldName = (this.Page as BaseApplicationPage).GetDecryptedURLParameter("DFKA");
            
            if (!string.IsNullOrEmpty(target) && !string.IsNullOrEmpty(field))
            {
          

                  if (this != null && this.DataSource != null)
                  {
                        id = this.DataSource.GetValue(this.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(field)).ToString();
                        if (!string.IsNullOrEmpty(formula))
                        {
                            System.Collections.Generic.IDictionary<String, Object> variables = new System.Collections.Generic.Dictionary<String, Object>();
                            variables.Add(this.DataSource.TableAccess.TableDefinition.TableCodeName, this.DataSource);
                            value = EvaluateFormula(formula, this.DataSource, null,variables);
                        }
                        else if (displayFieldName == "") 
                        {
                            value = id;
                        }
                        else
                        {
                            value = this.DataSource.GetValue(this.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(displayFieldName)).ToString();
                        }
                  }
                  if (value == null)
                      value = id;
                  BaseClasses.Utils.MiscUtils.RegisterAddButtonScript(this, target, id, value);
                  shouldRedirect = false;
                
           }
           else if (!string.IsNullOrEmpty(target))
           {
                BaseClasses.Utils.MiscUtils.RegisterAddButtonScript(this, target, null, null);           
                shouldRedirect = false;       
           }
         
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
      this.Page.RedirectBack();
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Shared/ConfigureEditRecord.aspx";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"])) 
                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
        
        public System.Web.UI.WebControls.ImageButton CancelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CancelButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustContactEmail {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustContactFax {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustContactName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustContactPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustContactPhoneMobile {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneMobile");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactPhoneMobileLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactPhoneMobileLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustContactTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactTitle");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactTitleLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactTitleLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustContactType {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactType");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustContactTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustContactTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal SessionID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SessionID");
            }
        }
            
        public System.Web.UI.WebControls.Literal SessionIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SessionIDLabel");
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

  