
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_VendorContacts.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_VendorContacts
{
  

#region "Section 1: Place your customizations here."

    
public class VendorContactsRecordControl : BaseVendorContactsRecordControl
{
      
        // The BaseVendorContactsRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the VendorContactsRecordControl control on the Edit_VendorContacts page.
// Do not modify this class. Instead override any method in VendorContactsRecordControl.
public class BaseVendorContactsRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseVendorContactsRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in VendorContactsRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in VendorContactsRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.SessionID.TextChanged += SessionID_TextChanged;
            
              this.VendContactEmail.TextChanged += VendContactEmail_TextChanged;
            
              this.VendContactFax.TextChanged += VendContactFax_TextChanged;
            
              this.VendContactName.TextChanged += VendContactName_TextChanged;
            
              this.VendContactPhoneBusiness.TextChanged += VendContactPhoneBusiness_TextChanged;
            
              this.VendContactPhoneMobile.TextChanged += VendContactPhoneMobile_TextChanged;
            
              this.VendContactTitle.TextChanged += VendContactTitle_TextChanged;
            
              this.VendContactType.TextChanged += VendContactType_TextChanged;
            
              this.VendNo.TextChanged += VendNo_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = VendorContactsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "VendorContactsRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new VendorContactsRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            VendorContactsRecord[] recList = VendorContactsTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = VendorContactsTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetSessionID();
                SetSessionIDLabel();
                
                SetVendContactEmail();
                SetVendContactEmailLabel();
                SetVendContactFax();
                SetVendContactFaxLabel();
                SetVendContactName();
                SetVendContactNameLabel();
                SetVendContactPhoneBusiness();
                SetVendContactPhoneBusinessLabel();
                SetVendContactPhoneMobile();
                SetVendContactPhoneMobileLabel();
                SetVendContactTitle();
                SetVendContactTitleLabel();
                SetVendContactType();
                SetVendContactTypeLabel();
                SetVendNo();
                SetVendNoLabel();

      

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
        
        
        public virtual void SetSessionID()
        {
            
                    
            // Set the SessionID TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.VendorContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.VendorContacts record retrieved from the database.
            // this.SessionID is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SessionIDSpecified) {
                								
                // If the SessionID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorContactsTable.SessionID);
                                
                this.SessionID.Text = formattedValue;
                   
            } 
            
            else {
            
                // SessionID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SessionID.Text = VendorContactsTable.SessionID.Format(VendorContactsTable.SessionID.DefaultValue);
            		
            }
            
              this.SessionID.TextChanged += SessionID_TextChanged;
                               
        }
                
        public virtual void SetVendContactEmail()
        {
            
                    
            // Set the VendContactEmail TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.VendorContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.VendorContacts record retrieved from the database.
            // this.VendContactEmail is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendContactEmailSpecified) {
                								
                // If the VendContactEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorContactsTable.VendContactEmail);
                                
                this.VendContactEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendContactEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendContactEmail.Text = VendorContactsTable.VendContactEmail.Format(VendorContactsTable.VendContactEmail.DefaultValue);
            		
            }
            
              this.VendContactEmail.TextChanged += VendContactEmail_TextChanged;
                               
        }
                
        public virtual void SetVendContactFax()
        {
            
                    
            // Set the VendContactFax TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.VendorContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.VendorContacts record retrieved from the database.
            // this.VendContactFax is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendContactFaxSpecified) {
                								
                // If the VendContactFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorContactsTable.VendContactFax);
                                
                this.VendContactFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendContactFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendContactFax.Text = VendorContactsTable.VendContactFax.Format(VendorContactsTable.VendContactFax.DefaultValue);
            		
            }
            
              this.VendContactFax.TextChanged += VendContactFax_TextChanged;
                               
        }
                
        public virtual void SetVendContactName()
        {
            
                    
            // Set the VendContactName TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.VendorContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.VendorContacts record retrieved from the database.
            // this.VendContactName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendContactNameSpecified) {
                								
                // If the VendContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorContactsTable.VendContactName);
                                
                this.VendContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendContactName.Text = VendorContactsTable.VendContactName.Format(VendorContactsTable.VendContactName.DefaultValue);
            		
            }
            
              this.VendContactName.TextChanged += VendContactName_TextChanged;
                               
        }
                
        public virtual void SetVendContactPhoneBusiness()
        {
            
                    
            // Set the VendContactPhoneBusiness TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.VendorContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.VendorContacts record retrieved from the database.
            // this.VendContactPhoneBusiness is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendContactPhoneBusinessSpecified) {
                								
                // If the VendContactPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorContactsTable.VendContactPhoneBusiness);
                                
                this.VendContactPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendContactPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendContactPhoneBusiness.Text = VendorContactsTable.VendContactPhoneBusiness.Format(VendorContactsTable.VendContactPhoneBusiness.DefaultValue);
            		
            }
            
              this.VendContactPhoneBusiness.TextChanged += VendContactPhoneBusiness_TextChanged;
                               
        }
                
        public virtual void SetVendContactPhoneMobile()
        {
            
                    
            // Set the VendContactPhoneMobile TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.VendorContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.VendorContacts record retrieved from the database.
            // this.VendContactPhoneMobile is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendContactPhoneMobileSpecified) {
                								
                // If the VendContactPhoneMobile is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorContactsTable.VendContactPhoneMobile);
                                
                this.VendContactPhoneMobile.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendContactPhoneMobile is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendContactPhoneMobile.Text = VendorContactsTable.VendContactPhoneMobile.Format(VendorContactsTable.VendContactPhoneMobile.DefaultValue);
            		
            }
            
              this.VendContactPhoneMobile.TextChanged += VendContactPhoneMobile_TextChanged;
                               
        }
                
        public virtual void SetVendContactTitle()
        {
            
                    
            // Set the VendContactTitle TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.VendorContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.VendorContacts record retrieved from the database.
            // this.VendContactTitle is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendContactTitleSpecified) {
                								
                // If the VendContactTitle is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorContactsTable.VendContactTitle);
                                
                this.VendContactTitle.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendContactTitle is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendContactTitle.Text = VendorContactsTable.VendContactTitle.Format(VendorContactsTable.VendContactTitle.DefaultValue);
            		
            }
            
              this.VendContactTitle.TextChanged += VendContactTitle_TextChanged;
                               
        }
                
        public virtual void SetVendContactType()
        {
            
                    
            // Set the VendContactType TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.VendorContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.VendorContacts record retrieved from the database.
            // this.VendContactType is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendContactTypeSpecified) {
                								
                // If the VendContactType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorContactsTable.VendContactType);
                                
                this.VendContactType.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendContactType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendContactType.Text = VendorContactsTable.VendContactType.Format(VendorContactsTable.VendContactType.DefaultValue);
            		
            }
            
              this.VendContactType.TextChanged += VendContactType_TextChanged;
                               
        }
                
        public virtual void SetVendNo()
        {
            
                    
            // Set the VendNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.VendorContacts database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.VendorContacts record retrieved from the database.
            // this.VendNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendNoSpecified) {
                								
                // If the VendNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorContactsTable.VendNo);
                                
                this.VendNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendNo.Text = VendorContactsTable.VendNo.Format(VendorContactsTable.VendNo.DefaultValue);
            		
            }
            
              this.VendNo.TextChanged += VendNo_TextChanged;
                               
        }
                
        public virtual void SetSessionIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendContactEmailLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendContactFaxLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendContactNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendContactPhoneBusinessLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendContactPhoneMobileLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendContactTitleLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendContactTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendNoLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "VendorContactsRecordControlPanel");
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
        
            GetSessionID();
            GetVendContactEmail();
            GetVendContactFax();
            GetVendContactName();
            GetVendContactPhoneBusiness();
            GetVendContactPhoneMobile();
            GetVendContactTitle();
            GetVendContactType();
            GetVendNo();
        }
        
        
        public virtual void GetSessionID()
        {
            
            // Retrieve the value entered by the user on the SessionID ASP:TextBox, and
            // save it into the SessionID field in DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.SessionID.Text, VendorContactsTable.SessionID);							
                          
                      
        }
                
        public virtual void GetVendContactEmail()
        {
            
            // Retrieve the value entered by the user on the VendContactEmail ASP:TextBox, and
            // save it into the VendContactEmail field in DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendContactEmail.Text, VendorContactsTable.VendContactEmail);							
                          
                      
        }
                
        public virtual void GetVendContactFax()
        {
            
            // Retrieve the value entered by the user on the VendContactFax ASP:TextBox, and
            // save it into the VendContactFax field in DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendContactFax.Text, VendorContactsTable.VendContactFax);							
                          
                      
        }
                
        public virtual void GetVendContactName()
        {
            
            // Retrieve the value entered by the user on the VendContactName ASP:TextBox, and
            // save it into the VendContactName field in DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendContactName.Text, VendorContactsTable.VendContactName);							
                          
                      
        }
                
        public virtual void GetVendContactPhoneBusiness()
        {
            
            // Retrieve the value entered by the user on the VendContactPhoneBusiness ASP:TextBox, and
            // save it into the VendContactPhoneBusiness field in DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendContactPhoneBusiness.Text, VendorContactsTable.VendContactPhoneBusiness);							
                          
                      
        }
                
        public virtual void GetVendContactPhoneMobile()
        {
            
            // Retrieve the value entered by the user on the VendContactPhoneMobile ASP:TextBox, and
            // save it into the VendContactPhoneMobile field in DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendContactPhoneMobile.Text, VendorContactsTable.VendContactPhoneMobile);							
                          
                      
        }
                
        public virtual void GetVendContactTitle()
        {
            
            // Retrieve the value entered by the user on the VendContactTitle ASP:TextBox, and
            // save it into the VendContactTitle field in DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendContactTitle.Text, VendorContactsTable.VendContactTitle);							
                          
                      
        }
                
        public virtual void GetVendContactType()
        {
            
            // Retrieve the value entered by the user on the VendContactType ASP:TextBox, and
            // save it into the VendContactType field in DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendContactType.Text, VendorContactsTable.VendContactType);							
                          
                      
        }
                
        public virtual void GetVendNo()
        {
            
            // Retrieve the value entered by the user on the VendNo ASP:TextBox, and
            // save it into the VendNo field in DataSource DatabaseAYS_OEM%dbo.VendorContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendNo.Text, VendorContactsTable.VendNo);							
                          
                      
        }
                

      // To customize, override this method in VendorContactsRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersVendorContactsRecordControl = false;
            hasFiltersVendorContactsRecordControl = hasFiltersVendorContactsRecordControl && false; // suppress warning
      
            WhereClause wc;
            VendorContactsTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["VendorContacts"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "VendorContacts"));
            }
            HttpContext.Current.Session["QueryString in Edit-VendorContacts"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(VendorContactsTable.VendContactKey, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(VendorContactsTable.VendContactKey));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(VendorContactsTable.VendContactKey, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            VendorContactsTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersVendorContactsRecordControl = false;
            hasFiltersVendorContactsRecordControl = hasFiltersVendorContactsRecordControl && false; // suppress warning
      
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
          VendorContactsTable.DeleteRecord(pkValue);
          
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
        
        protected virtual void SessionID_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendContactEmail_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendContactFax_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendContactName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendContactPhoneBusiness_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendContactPhoneMobile_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendContactTitle_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendContactType_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendNo_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseVendorContactsRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseVendorContactsRecordControl_Rec"] = value;
            }
        }
        
        public VendorContactsRecord DataSource {
            get {
                return (VendorContactsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox SessionID {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SessionID");
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
        
        public System.Web.UI.WebControls.TextBox VendContactEmail {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendContactEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendContactFax {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendContactFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendContactName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendContactPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendContactPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendContactPhoneMobile {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactPhoneMobile");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendContactPhoneMobileLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactPhoneMobileLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendContactTitle {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactTitle");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendContactTitleLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactTitleLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendContactType {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactType");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendContactTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendContactTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendNoLabel");
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
        VendorContactsRecord rec = null;
             
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
    VendorContactsRecord rec = null;
    
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

        
        public virtual VendorContactsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return VendorContactsTable.GetRecord(this.RecordUniqueId, true);
              
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

  