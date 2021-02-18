
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Equipment_inventory.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Equipment_inventory
{
  

#region "Section 1: Place your customizations here."

    
public class CustomersRecordControl : BaseCustomersRecordControl
{
      
        // The BaseCustomersRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  
public class Equipment_inventoryRecordControl : BaseEquipment_inventoryRecordControl
{
      
        // The BaseEquipment_inventoryRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the CustomersRecordControl control on the Show_Equipment_inventory page.
// Do not modify this class. Instead override any method in CustomersRecordControl.
public class BaseCustomersRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseCustomersRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in CustomersRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in CustomersRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Customers record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CustomersRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new CustomersRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            CustomersRecord[] recList = CustomersTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = CustomersTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                Setcorporate_id();
                Setcorporate_idLabel();
                SetCustAddress1();
                SetCustAddress1Label();
                SetCustAddress2();
                SetCustAddress2Label();
                SetCustCity();
                SetCustCityLabel();
                SetCustCode();
                SetCustCodeLabel();
                SetCustName();
                SetCustNameLabel();
                SetCustNo();
                SetCustNoLabel();
                Setcustomer_active();
                Setcustomer_activeLabel();
                SetCustPhoneBusiness();
                SetCustPhoneBusinessLabel();

      

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
        
        
        public virtual void Setcorporate_id()
        {
            
                    
            // Set the corporate_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.corporate_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.corporate_idSpecified) {
                								
                // If the corporate_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = CustomersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CustomersTable.corporate_id);
               if(_isExpandableNonCompositeForeignKey &&CustomersTable.corporate_id.IsApplyDisplayAs)
                                  
                     formattedValue = CustomersTable.GetDFKA(this.DataSource.corporate_id.ToString(),CustomersTable.corporate_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(CustomersTable.corporate_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.corporate_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // corporate_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.corporate_id.Text = CustomersTable.corporate_id.Format(CustomersTable.corporate_id.DefaultValue);
            		
            }
            
            // If the corporate_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.corporate_id.Text == null ||
                this.corporate_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.corporate_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustAddress1()
        {
            
                    
            // Set the CustAddress1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAddress1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress1Specified) {
                								
                // If the CustAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustAddress1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress1.Text = CustomersTable.CustAddress1.Format(CustomersTable.CustAddress1.DefaultValue);
            		
            }
            
            // If the CustAddress1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustAddress1.Text == null ||
                this.CustAddress1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustAddress1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustAddress2()
        {
            
                    
            // Set the CustAddress2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAddress2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress2Specified) {
                								
                // If the CustAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustAddress2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress2.Text = CustomersTable.CustAddress2.Format(CustomersTable.CustAddress2.DefaultValue);
            		
            }
            
            // If the CustAddress2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustAddress2.Text == null ||
                this.CustAddress2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustAddress2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustCity()
        {
            
                    
            // Set the CustCity Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCity is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCitySpecified) {
                								
                // If the CustCity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCity);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustCity.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCity.Text = CustomersTable.CustCity.Format(CustomersTable.CustCity.DefaultValue);
            		
            }
            
            // If the CustCity is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustCity.Text == null ||
                this.CustCity.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustCity.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustCode()
        {
            
                    
            // Set the CustCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCodeSpecified) {
                								
                // If the CustCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCode.Text = CustomersTable.CustCode.Format(CustomersTable.CustCode.DefaultValue);
            		
            }
            
            // If the CustCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustCode.Text == null ||
                this.CustCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustName()
        {
            
                    
            // Set the CustName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustNameSpecified) {
                								
                // If the CustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustName.Text = CustomersTable.CustName.Format(CustomersTable.CustName.DefaultValue);
            		
            }
            
            // If the CustName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustName.Text == null ||
                this.CustName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustNo()
        {
            
                    
            // Set the CustNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustNoSpecified) {
                								
                // If the CustNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustNo.Text = CustomersTable.CustNo.Format(CustomersTable.CustNo.DefaultValue);
            		
            }
            
            // If the CustNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustNo.Text == null ||
                this.CustNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcustomer_active()
        {
            
                    
            // Set the customer_active Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_active is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_activeSpecified) {
                								
                // If the customer_active is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.customer_active);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.customer_active.Text = formattedValue;
                   
            } 
            
            else {
            
                // customer_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.customer_active.Text = CustomersTable.customer_active.Format(CustomersTable.customer_active.DefaultValue);
            		
            }
            
            // If the customer_active is NULL or blank, then use the value specified  
            // on Properties.
            if (this.customer_active.Text == null ||
                this.customer_active.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.customer_active.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustPhoneBusiness()
        {
            
                    
            // Set the CustPhoneBusiness Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPhoneBusiness is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPhoneBusinessSpecified) {
                								
                // If the CustPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPhoneBusiness);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPhoneBusiness.Text = CustomersTable.CustPhoneBusiness.Format(CustomersTable.CustPhoneBusiness.DefaultValue);
            		
            }
            
            // If the CustPhoneBusiness is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustPhoneBusiness.Text == null ||
                this.CustPhoneBusiness.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustPhoneBusiness.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcorporate_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustAddress1Label()
                  {
                  
                        this.CustAddress1Label.Text = EvaluateFormula("\"Address\"");
                      
                    
        }
                
        public virtual void SetCustAddress2Label()
                  {
                  
                        this.CustAddress2Label.Text = EvaluateFormula("\"Address 2\"");
                      
                    
        }
                
        public virtual void SetCustCityLabel()
                  {
                  
                        this.CustCityLabel.Text = EvaluateFormula("\"City\"");
                      
                    
        }
                
        public virtual void SetCustCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustNameLabel()
                  {
                  
                        this.CustNameLabel.Text = EvaluateFormula("\"Facility Name\"");
                      
                    
        }
                
        public virtual void SetCustNoLabel()
                  {
                  
                        this.CustNoLabel.Text = EvaluateFormula("\"Facility #\"");
                      
                    
        }
                
        public virtual void Setcustomer_activeLabel()
                  {
                  
                        this.customer_activeLabel.Text = EvaluateFormula("\"Active\"");
                      
                    
        }
                
        public virtual void SetCustPhoneBusinessLabel()
                  {
                  
                        this.CustPhoneBusinessLabel.Text = EvaluateFormula("\"Phone Business\"");
                      
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "CustomersRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
            }
          Equipment_inventoryRecordControl parentCtrl;
      
            parentCtrl = (Equipment_inventoryRecordControl)this.Page.FindControlRecursively("Equipment_inventoryRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.CustNo = parentCtrl.DataSource.received_from_customer_id;
        
          
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
        
            Getcorporate_id();
            GetCustAddress1();
            GetCustAddress2();
            GetCustCity();
            GetCustCode();
            GetCustName();
            GetCustNo();
            Getcustomer_active();
            GetCustPhoneBusiness();
        }
        
        
        public virtual void Getcorporate_id()
        {
            
        }
                
        public virtual void GetCustAddress1()
        {
            
        }
                
        public virtual void GetCustAddress2()
        {
            
        }
                
        public virtual void GetCustCity()
        {
            
        }
                
        public virtual void GetCustCode()
        {
            
        }
                
        public virtual void GetCustName()
        {
            
        }
                
        public virtual void GetCustNo()
        {
            
        }
                
        public virtual void Getcustomer_active()
        {
            
        }
                
        public virtual void GetCustPhoneBusiness()
        {
            
        }
                

      // To customize, override this method in CustomersRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventoryRecordControl = false;
            hasFiltersEquipment_inventoryRecordControl = hasFiltersEquipment_inventoryRecordControl && false; // suppress warning
      
            WhereClause wc;
            CustomersTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
      KeyValue selectedRecordKeyValue = new KeyValue();
    OEMConversion.UI.Controls.Show_Equipment_inventory.Equipment_inventoryRecordControl equipment_inventoryRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "Equipment_inventoryRecordControl") as OEMConversion.UI.Controls.Show_Equipment_inventory.Equipment_inventoryRecordControl);
          
              if (equipment_inventoryRecordControlObj != null && equipment_inventoryRecordControlObj.GetRecord() != null && equipment_inventoryRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, equipment_inventoryRecordControlObj.GetRecord().received_from_customer_id.ToString());
              selectedRecordKeyValue.AddElement(CustomersTable.CustNo.InternalName, equipment_inventoryRecordControlObj.GetRecord().received_from_customer_id.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["CustomersRecordControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            CustomersTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventoryRecordControl = false;
            hasFiltersEquipment_inventoryRecordControl = hasFiltersEquipment_inventoryRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInEquipment_inventoryRecordControl = HttpContext.Current.Session["CustomersRecordControlWhereClause"] as string;
      
      if (selectedRecordInEquipment_inventoryRecordControl != null && KeyValue.IsXmlKey(selectedRecordInEquipment_inventoryRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInEquipment_inventoryRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(CustomersTable.CustNo))
      {
      wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(CustomersTable.CustNo).ToString());
      }
    
      }
    
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
          CustomersTable.DeleteRecord(pkValue);
          
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
                return (string)this.ViewState["BaseCustomersRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseCustomersRecordControl_Rec"] = value;
            }
        }
        
        public CustomersRecord DataSource {
            get {
                return (CustomersRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal corporate_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal corporate_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "corporate_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustAddress1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustAddress1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustAddress2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustAddress2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustCity {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCity");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCityLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNameLabel");
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
        
        public System.Web.UI.WebControls.Literal customer_active {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneBusinessLabel");
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
        CustomersRecord rec = null;
             
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
    CustomersRecord rec = null;
    
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

        
        public virtual CustomersRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return CustomersTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the Equipment_inventoryRecordControl control on the Show_Equipment_inventory page.
// Do not modify this class. Instead override any method in Equipment_inventoryRecordControl.
public class BaseEquipment_inventoryRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_inventoryRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_inventoryRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Equipment_inventoryRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.DialogEditButton.Click += DialogEditButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_inventoryTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_inventoryRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Equipment_inventoryRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Equipment_inventoryRecord[] recList = Equipment_inventoryTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Equipment_inventoryTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                Setcategory_idLabel();
                Setcogs();
                SetcogsLabel();
                Setcondition_id();
                Setcondition_idLabel();
                Setcustomer_ein();
                Setcustomer_einLabel();
                Setdate_disposed();
                Setdate_disposedLabel();
                Setdate_received();
                Setdate_receivedLabel();
                Setdate_sold();
                Setdate_soldLabel();
                Setdatetime_added();
                Setdatetime_addedLabel();
                Setdescription();
                SetdescriptionLabel();
                
                Setdisposition_id();
                Setdisposition_idLabel();
                Setdoc_num();
                Setdoc_numLabel();
                Setequipment_inventory_pic();
                Setequipment_inventory_pic1Label();
                Setequipment_inventory_pic2Label();
                Setequipment_inventory_pic3Label();
                Setequipment_inventory_pic4();
                Setequipment_inventory_pic5();
                Setequipment_phi();
                Setequipment_phiLabel();
                Setfinal_sale_price();
                Setfinal_sale_priceLabel();
                Setmake_id();
                Setmake_idLabel();
                Setmodel_id();
                Setmodel_idLabel();
                Setnew_category_id();
                Setother_id_num();
                Setother_id_numLabel();
                Setpd_date();
                Setpd_dateLabel();
                Setproposed_sale_price();
                Setproposed_sale_priceLabel();
                Setpurchase_price();
                Setpurchase_priceLabel();
                Setreceived_from_contact_idLabel();
                Setreceived_from_customer_id();
                Setreceived_from_customer_idLabel();
                Setrepair_notes();
                Setrepair_notesLabel();
                Setrequire_accessories();
                Setrequire_accessoriesLabel();
                Setsale_method_id();
                Setsale_method_idLabel();
                Setserial_number();
                Setserial_numberLabel();
                Setsold_from_id();
                Setsold_from_idLabel();
                Settechnician_id();
                Settechnician_idLabel1();
                
                Setwarehouse_id();
                Setwarehouse_idLabel();
                Setwarehouse_location_idLabel();
                Setreceived_from_contact_id();
                Setwarehouse_location_id();
                SetDialogEditButton();
              

      

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
            CustomersRecordControl recCustomersRecordControl = (CustomersRecordControl)(MiscUtils.FindControlRecursively(this.Page, "CustomersRecordControl"));
                  
        this.Page.SetControl("CustomersRecordControl");
        
        }
        
        
        public virtual void Setcogs()
        {
            
                    
            // Set the cogs Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.cogs is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cogsSpecified) {
                								
                // If the cogs is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.cogs, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.cogs.Text = formattedValue;
                   
            } 
            
            else {
            
                // cogs is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cogs.Text = Equipment_inventoryTable.cogs.Format(Equipment_inventoryTable.cogs.DefaultValue, @"C");
            		
            }
                               
        }
                
        public virtual void Setcondition_id()
        {
            
                    
            // Set the condition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.condition_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the condition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.condition_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.condition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.condition_id.ToString(),Equipment_inventoryTable.condition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.condition_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.condition_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.condition_id.Text = EvaluateFormula("URL(\"condition_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setcustomer_ein()
        {
            
                    
            // Set the customer_ein Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.customer_ein is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_einSpecified) {
                								
                // If the customer_ein is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.customer_ein);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.customer_ein.Text = formattedValue;
                   
            } 
            
            else {
            
                // customer_ein is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.customer_ein.Text = Equipment_inventoryTable.customer_ein.Format(Equipment_inventoryTable.customer_ein.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setdate_disposed()
        {
            
                    
            // Set the date_disposed Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.date_disposed is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_disposedSpecified) {
                								
                // If the date_disposed is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.date_disposed, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_disposed.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_disposed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_disposed.Text = Equipment_inventoryTable.date_disposed.Format(Equipment_inventoryTable.date_disposed.DefaultValue, @"d");
            		
            }
                               
        }
                
        public virtual void Setdate_received()
        {
            
                    
            // Set the date_received Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.date_received is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_receivedSpecified) {
                								
                // If the date_received is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.date_received, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_received.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_received is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_received.Text = Equipment_inventoryTable.date_received.Format(Equipment_inventoryTable.date_received.DefaultValue, @"d");
            		
            }
                               
        }
                
        public virtual void Setdate_sold()
        {
            
                    
            // Set the date_sold Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.date_sold is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_soldSpecified) {
                								
                // If the date_sold is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.date_sold, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_sold.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_sold is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_sold.Text = Equipment_inventoryTable.date_sold.Format(Equipment_inventoryTable.date_sold.DefaultValue, @"d");
            		
            }
                               
        }
                
        public virtual void Setdatetime_added()
        {
            
                    
            // Set the datetime_added Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.datetime_added is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.datetime_addedSpecified) {
                								
                // If the datetime_added is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.datetime_added, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.datetime_added.Text = formattedValue;
                   
            } 
            
            else {
            
                // datetime_added is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.datetime_added.Text = Equipment_inventoryTable.datetime_added.Format(Equipment_inventoryTable.datetime_added.DefaultValue, @"g");
            		
            }
                               
        }
                
        public virtual void Setdescription()
        {
            
                    
            // Set the description Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.description is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.descriptionSpecified) {
                								
                // If the description is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.description);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(Equipment_inventoryTable.description.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Equipment_inventoryTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"description\\\", \\\"description\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                    }
                }
                
                this.description.Text = formattedValue;
                   
            } 
            
            else {
            
                // description is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.description.Text = Equipment_inventoryTable.description.Format(Equipment_inventoryTable.description.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setdisposition_id()
        {
            
                    
            // Set the disposition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.disposition_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the disposition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.disposition_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.disposition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.disposition_id.ToString(),Equipment_inventoryTable.disposition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.disposition_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.disposition_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // disposition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.disposition_id.Text = EvaluateFormula("URL(\"disposition_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setdoc_num()
        {
            
                    
            // Set the doc_num Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.doc_num is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.doc_numSpecified) {
                								
                // If the doc_num is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.doc_num);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.doc_num.Text = formattedValue;
                   
            } 
            
            else {
            
                // doc_num is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.doc_num.Text = Equipment_inventoryTable.doc_num.Format(Equipment_inventoryTable.doc_num.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setequipment_inventory_pic()
        {
            // Set the equipment_inventory_pic1 Image on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.equipment_inventory_pic is the ASP:Image on the webpage.

            if (this.DataSource != null && this.DataSource.equipment_inventory_pic1Specified) {
                // If the equipment_inventory_pic1 is non-NULL, then format the value.
                // The Format method will use the Display Format
                  String name = HttpUtility.HtmlEncode(Equipment_inventoryTable.equipment_inventory_pic1.Name);

                  if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                      name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                  }

                  this.equipment_inventory_pic.Attributes.Add("onclick", "gPersist=true;");
                  this.equipment_inventory_pic.Attributes.Add("onmouseout","detailRolloverPopupClose();");
                  this.equipment_inventory_pic.Attributes.Add("onmouseover","SaveMousePosition(event);delayRolloverPopup(\"PageMethods.GetImage(\\\"" + "NULL" +
                  "\\\", \\\"" + this.Page.Encrypt("Equipment_inventory") +
                  "\\\", \\\"" + this.Page.Encrypt(HttpUtility.UrlEncode(this.DataSource.GetID().ToString())) + 
                  "\\\", \\\"" + this.Page.Encrypt("equipment_inventory_pic1") + "\\\", \\\"" + NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length))+ "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", false, 200," +
                  " 300, true, PopupDisplayWindowCallBackWith20);\", 500);");
                        
                // Shrunk image size specified by ImagePercentSize on Properties.
                this.equipment_inventory_pic.ImageUrl = this.DataSource.FormatImageUrl(Equipment_inventoryTable.equipment_inventory_pic1, this.Page.Encrypt("Equipment_inventory"), this.Page.Encrypt("equipment_inventory_pic1"), this.Page.Encrypt(this.DataSource.GetID().ToXmlString()), 100);
                            
                this.equipment_inventory_pic.Visible = true;
                                    
            } 
            else {
                // equipment_inventory_pic1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                this.equipment_inventory_pic.Visible = false;
            }
                     
        }
                
        public virtual void Setequipment_inventory_pic4()
        {
            // Set the equipment_inventory_pic2 Image on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.equipment_inventory_pic4 is the ASP:Image on the webpage.

            if (this.DataSource != null && this.DataSource.equipment_inventory_pic2Specified) {
                // If the equipment_inventory_pic2 is non-NULL, then format the value.
                // The Format method will use the Display Format
                  String name = HttpUtility.HtmlEncode(Equipment_inventoryTable.equipment_inventory_pic2.Name);

                  if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                      name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                  }

                  this.equipment_inventory_pic4.Attributes.Add("onclick", "gPersist=true;");
                  this.equipment_inventory_pic4.Attributes.Add("onmouseout","detailRolloverPopupClose();");
                  this.equipment_inventory_pic4.Attributes.Add("onmouseover","SaveMousePosition(event);delayRolloverPopup(\"PageMethods.GetImage(\\\"" + "NULL" +
                  "\\\", \\\"" + this.Page.Encrypt("Equipment_inventory") +
                  "\\\", \\\"" + this.Page.Encrypt(HttpUtility.UrlEncode(this.DataSource.GetID().ToString())) + 
                  "\\\", \\\"" + this.Page.Encrypt("equipment_inventory_pic2") + "\\\", \\\"" + NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length))+ "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", false, 200," +
                  " 300, true, PopupDisplayWindowCallBackWith20);\", 500);");
                        
                // Shrunk image size specified by ImagePercentSize on Properties.
                this.equipment_inventory_pic4.ImageUrl = this.DataSource.FormatImageUrl(Equipment_inventoryTable.equipment_inventory_pic2, this.Page.Encrypt("Equipment_inventory"), this.Page.Encrypt("equipment_inventory_pic2"), this.Page.Encrypt(this.DataSource.GetID().ToXmlString()), (int)(150),(int)(150),100);
                            
                this.equipment_inventory_pic4.Visible = true;
                                    
            } 
            else {
                // equipment_inventory_pic2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                this.equipment_inventory_pic4.Visible = false;
            }
                     
        }
                
        public virtual void Setequipment_inventory_pic5()
        {
            // Set the equipment_inventory_pic3 Image on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.equipment_inventory_pic5 is the ASP:Image on the webpage.

            if (this.DataSource != null && this.DataSource.equipment_inventory_pic3Specified) {
                // If the equipment_inventory_pic3 is non-NULL, then format the value.
                // The Format method will use the Display Format
                  String name = HttpUtility.HtmlEncode(Equipment_inventoryTable.equipment_inventory_pic3.Name);

                  if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                      name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                  }

                  this.equipment_inventory_pic5.Attributes.Add("onclick", "gPersist=true;");
                  this.equipment_inventory_pic5.Attributes.Add("onmouseout","detailRolloverPopupClose();");
                  this.equipment_inventory_pic5.Attributes.Add("onmouseover","SaveMousePosition(event);delayRolloverPopup(\"PageMethods.GetImage(\\\"" + "NULL" +
                  "\\\", \\\"" + this.Page.Encrypt("Equipment_inventory") +
                  "\\\", \\\"" + this.Page.Encrypt(HttpUtility.UrlEncode(this.DataSource.GetID().ToString())) + 
                  "\\\", \\\"" + this.Page.Encrypt("equipment_inventory_pic3") + "\\\", \\\"" + NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length))+ "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", false, 200," +
                  " 300, true, PopupDisplayWindowCallBackWith20);\", 500);");
                        
                // Shrunk image size specified by ImagePercentSize on Properties.
                this.equipment_inventory_pic5.ImageUrl = this.DataSource.FormatImageUrl(Equipment_inventoryTable.equipment_inventory_pic3, this.Page.Encrypt("Equipment_inventory"), this.Page.Encrypt("equipment_inventory_pic3"), this.Page.Encrypt(this.DataSource.GetID().ToXmlString()), 100);
                            
                this.equipment_inventory_pic5.Visible = true;
                                    
            } 
            else {
                // equipment_inventory_pic3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                this.equipment_inventory_pic5.Visible = false;
            }
                     
        }
                
        public virtual void Setequipment_phi()
        {
            
                    
            // Set the equipment_phi Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.equipment_phi is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.equipment_phiSpecified) {
                								
                // If the equipment_phi is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.equipment_phi);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.equipment_phi.Text = formattedValue;
                   
            } 
            
            else {
            
                // equipment_phi is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.equipment_phi.Text = Equipment_inventoryTable.equipment_phi.Format(Equipment_inventoryTable.equipment_phi.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setfinal_sale_price()
        {
            
                    
            // Set the final_sale_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.final_sale_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.final_sale_priceSpecified) {
                								
                // If the final_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.final_sale_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.final_sale_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // final_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.final_sale_price.Text = Equipment_inventoryTable.final_sale_price.Format(Equipment_inventoryTable.final_sale_price.DefaultValue, @"C");
            		
            }
                               
        }
                
        public virtual void Setmake_id()
        {
            
                    
            // Set the make_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.make_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.make_idSpecified) {
                								
                // If the make_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.make_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.make_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // make_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make_id.Text = Equipment_inventoryTable.make_id.Format(Equipment_inventoryTable.make_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setmodel_id()
        {
            
                    
            // Set the model_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.model_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.model_idSpecified) {
                								
                // If the model_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.model_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.model_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // model_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model_id.Text = Equipment_inventoryTable.model_id.Format(Equipment_inventoryTable.model_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setnew_category_id()
        {
            
                    
            // Set the new_category_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.new_category_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.new_category_idSpecified) {
                								
                // If the new_category_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.new_category_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.new_category_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.new_category_id.ToString(),Equipment_inventoryTable.new_category_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.new_category_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.new_category_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // new_category_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.new_category_id.Text = Equipment_inventoryTable.new_category_id.Format(Equipment_inventoryTable.new_category_id.DefaultValue);
            		
            }
            
            // If the new_category_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.new_category_id.Text == null ||
                this.new_category_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.new_category_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setother_id_num()
        {
            
                    
            // Set the other_id_num Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.other_id_num is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.other_id_numSpecified) {
                								
                // If the other_id_num is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.other_id_num);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.other_id_num.Text = formattedValue;
                   
            } 
            
            else {
            
                // other_id_num is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.other_id_num.Text = Equipment_inventoryTable.other_id_num.Format(Equipment_inventoryTable.other_id_num.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setpd_date()
        {
            
                    
            // Set the pd_date Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.pd_date is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pd_dateSpecified) {
                								
                // If the pd_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.pd_date, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.pd_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // pd_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pd_date.Text = Equipment_inventoryTable.pd_date.Format(Equipment_inventoryTable.pd_date.DefaultValue, @"d");
            		
            }
                               
        }
                
        public virtual void Setproposed_sale_price()
        {
            
                    
            // Set the proposed_sale_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.proposed_sale_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.proposed_sale_priceSpecified) {
                								
                // If the proposed_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.proposed_sale_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.proposed_sale_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // proposed_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.proposed_sale_price.Text = Equipment_inventoryTable.proposed_sale_price.Format(Equipment_inventoryTable.proposed_sale_price.DefaultValue, @"C");
            		
            }
                               
        }
                
        public virtual void Setpurchase_price()
        {
            
                    
            // Set the purchase_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.purchase_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchase_priceSpecified) {
                								
                // If the purchase_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.purchase_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.purchase_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase_price.Text = Equipment_inventoryTable.purchase_price.Format(Equipment_inventoryTable.purchase_price.DefaultValue, @"C");
            		
            }
                               
        }
                
        public virtual void Setreceived_from_customer_id()
        {
            
                    
            // Set the received_from_customer_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.received_from_customer_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the received_from_customer_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_customer_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.received_from_customer_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.received_from_customer_id.ToString(),Equipment_inventoryTable.received_from_customer_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.received_from_customer_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.received_from_customer_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // received_from_customer_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.received_from_customer_id.Text = EvaluateFormula("URL(\"received_from_customer_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setrepair_notes()
        {
            
                    
            // Set the repair_notes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.repair_notes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.repair_notesSpecified) {
                								
                // If the repair_notes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.repair_notes);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(Equipment_inventoryTable.repair_notes.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Equipment_inventoryTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"repair_notes\\\", \\\"repair_notes\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                    }
                }
                
                this.repair_notes.Text = formattedValue;
                   
            } 
            
            else {
            
                // repair_notes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.repair_notes.Text = Equipment_inventoryTable.repair_notes.Format(Equipment_inventoryTable.repair_notes.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setrequire_accessories()
        {
            
                    
            // Set the require_accessories Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.require_accessories is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.require_accessoriesSpecified) {
                								
                // If the require_accessories is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.require_accessories);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.require_accessories.Text = formattedValue;
                   
            } 
            
            else {
            
                // require_accessories is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.require_accessories.Text = Equipment_inventoryTable.require_accessories.Format(Equipment_inventoryTable.require_accessories.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setsale_method_id()
        {
            
                    
            // Set the sale_method_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.sale_method_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the sale_method_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sale_method_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.sale_method_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.sale_method_id.ToString(),Equipment_inventoryTable.sale_method_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.sale_method_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.sale_method_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // sale_method_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.sale_method_id.Text = EvaluateFormula("URL(\"sale_method_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setserial_number()
        {
            
                    
            // Set the serial_number Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.serial_number is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.serial_number);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number.Text = Equipment_inventoryTable.serial_number.Format(Equipment_inventoryTable.serial_number.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setsold_from_id()
        {
            
                    
            // Set the sold_from_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.sold_from_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the sold_from_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sold_from_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.sold_from_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.sold_from_id.ToString(),Equipment_inventoryTable.sold_from_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.sold_from_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.sold_from_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // sold_from_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.sold_from_id.Text = EvaluateFormula("URL(\"sold_from_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Settechnician_id()
        {
            
                    
            // Set the technician_id Label on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.technician_id is the ASP:Label on the webpage.
                  
            if (this.DataSource != null && this.DataSource.technician_idSpecified) {
                								
                // If the technician_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.technician_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.technician_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.technician_id.ToString(),Equipment_inventoryTable.technician_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.technician_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.technician_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // technician_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.technician_id.Text = Equipment_inventoryTable.technician_id.Format(Equipment_inventoryTable.technician_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setwarehouse_id()
        {
            
                    
            // Set the warehouse_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.warehouse_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the warehouse_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.warehouse_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.warehouse_id.ToString(),Equipment_inventoryTable.warehouse_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.warehouse_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse_id.Text = EvaluateFormula("URL(\"warehouse_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setreceived_from_contact_id()
        {
            
                    
            // Set the received_from_contact_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.received_from_contact_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the received_from_contact_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_contact_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.received_from_contact_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.received_from_contact_id.ToString(),Equipment_inventoryTable.received_from_contact_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.received_from_contact_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.received_from_contact_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // received_from_contact_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.received_from_contact_id.Text = EvaluateFormula("URL(\"received_from_contact_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setwarehouse_location_id()
        {
            
                    
            // Set the warehouse_location_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.warehouse_location_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the warehouse_location_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_location_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.warehouse_location_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.warehouse_location_id.ToString(),Equipment_inventoryTable.warehouse_location_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.warehouse_location_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse_location_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse_location_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse_location_id.Text = EvaluateFormula("URL(\"warehouse_location_id\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Setcategory_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetcogsLabel()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setcustomer_einLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_disposedLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_receivedLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_soldLabel()
                  {
                  
                    
        }
                
        public virtual void Setdatetime_addedLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.datetime_addedLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetdescriptionLabel()
                  {
                  
                    
        }
                
        public virtual void Setdisposition_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setdoc_numLabel()
                  {
                  
                    
        }
                
        public virtual void Setequipment_inventory_pic1Label()
                  {
                  
                        this.equipment_inventory_pic1Label.Text = EvaluateFormula("\"Equip. Pic-1\"");
                      
                    
        }
                
        public virtual void Setequipment_inventory_pic2Label()
                  {
                  
                        this.equipment_inventory_pic2Label.Text = EvaluateFormula("\"Equip. Pic-2\"");
                      
                    
        }
                
        public virtual void Setequipment_inventory_pic3Label()
                  {
                  
                        this.equipment_inventory_pic3Label.Text = EvaluateFormula("\"Equip. Pic-3\"");
                      
                    
        }
                
        public virtual void Setequipment_phiLabel()
                  {
                  
                    
        }
                
        public virtual void Setfinal_sale_priceLabel()
                  {
                  
                    
        }
                
        public virtual void Setmake_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setmodel_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setother_id_numLabel()
                  {
                  
                        this.other_id_numLabel.Text = EvaluateFormula("\"Cust. Asset#\"");
                      
                    
        }
                
        public virtual void Setpd_dateLabel()
                  {
                  
                    
        }
                
        public virtual void Setproposed_sale_priceLabel()
                  {
                  
                    
        }
                
        public virtual void Setpurchase_priceLabel()
                  {
                  
                    
        }
                
        public virtual void Setreceived_from_contact_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setreceived_from_customer_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setrepair_notesLabel()
                  {
                  
                    
        }
                
        public virtual void Setrequire_accessoriesLabel()
                  {
                  
                    
        }
                
        public virtual void Setsale_method_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setserial_numberLabel()
                  {
                  
                    
        }
                
        public virtual void Setsold_from_idLabel()
                  {
                  
                    
        }
                
        public virtual void Settechnician_idLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.technician_idLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void Setwarehouse_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setwarehouse_location_idLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_inventoryRecordControlPanel");
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
          CustomersRecordControl recCustomersRecordControl = (CustomersRecordControl)(MiscUtils.FindControlRecursively(this.Page, "CustomersRecordControl"));
        recCustomersRecordControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getcogs();
            Getcondition_id();
            Getcustomer_ein();
            Getdate_disposed();
            Getdate_received();
            Getdate_sold();
            Getdatetime_added();
            Getdescription();
            Getdisposition_id();
            Getdoc_num();
            Getequipment_phi();
            Getfinal_sale_price();
            Getmake_id();
            Getmodel_id();
            Getnew_category_id();
            Getother_id_num();
            Getpd_date();
            Getproposed_sale_price();
            Getpurchase_price();
            Getreceived_from_customer_id();
            Getrepair_notes();
            Getrequire_accessories();
            Getsale_method_id();
            Getserial_number();
            Getsold_from_id();
            Gettechnician_id();
            Getwarehouse_id();
            Getreceived_from_contact_id();
            Getwarehouse_location_id();
        }
        
        
        public virtual void Getcogs()
        {
            
        }
                
        public virtual void Getcondition_id()
        {
            
        }
                
        public virtual void Getcustomer_ein()
        {
            
        }
                
        public virtual void Getdate_disposed()
        {
            
        }
                
        public virtual void Getdate_received()
        {
            
        }
                
        public virtual void Getdate_sold()
        {
            
        }
                
        public virtual void Getdatetime_added()
        {
            
        }
                
        public virtual void Getdescription()
        {
            
        }
                
        public virtual void Getdisposition_id()
        {
            
        }
                
        public virtual void Getdoc_num()
        {
            
        }
                
        public virtual void Getequipment_phi()
        {
            
        }
                
        public virtual void Getfinal_sale_price()
        {
            
        }
                
        public virtual void Getmake_id()
        {
            
        }
                
        public virtual void Getmodel_id()
        {
            
        }
                
        public virtual void Getnew_category_id()
        {
            
        }
                
        public virtual void Getother_id_num()
        {
            
        }
                
        public virtual void Getpd_date()
        {
            
        }
                
        public virtual void Getproposed_sale_price()
        {
            
        }
                
        public virtual void Getpurchase_price()
        {
            
        }
                
        public virtual void Getreceived_from_customer_id()
        {
            
        }
                
        public virtual void Getrepair_notes()
        {
            
        }
                
        public virtual void Getrequire_accessories()
        {
            
        }
                
        public virtual void Getsale_method_id()
        {
            
        }
                
        public virtual void Getserial_number()
        {
            
        }
                
        public virtual void Getsold_from_id()
        {
            
        }
                
        public virtual void Gettechnician_id()
        {
            
        }
                
        public virtual void Getwarehouse_id()
        {
            
        }
                
        public virtual void Getreceived_from_contact_id()
        {
            
        }
                
        public virtual void Getwarehouse_location_id()
        {
            
        }
                

      // To customize, override this method in Equipment_inventoryRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventoryRecordControl = false;
            hasFiltersEquipment_inventoryRecordControl = hasFiltersEquipment_inventoryRecordControl && false; // suppress warning
      
            WhereClause wc;
            Equipment_inventoryTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Equipment_inventory"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Equipment_inventory"));
            }
            HttpContext.Current.Session["QueryString in Show-Equipment-inventory"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Equipment_inventoryTable.inventory_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Equipment_inventoryTable.inventory_id));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Equipment_inventoryTable.inventory_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_inventoryTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventoryRecordControl = false;
            hasFiltersEquipment_inventoryRecordControl = hasFiltersEquipment_inventoryRecordControl && false; // suppress warning
      
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
          Equipment_inventoryTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetDialogEditButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DialogEditButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../equipment_inventory/Edit-Equipment-inventory.aspx?Equipment_inventory={PK}";
            
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
                return (string)this.ViewState["BaseEquipment_inventoryRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_inventoryRecordControl_Rec"] = value;
            }
        }
        
        public Equipment_inventoryRecord DataSource {
            get {
                return (Equipment_inventoryRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal category_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal cogs {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cogs");
            }
        }
            
        public System.Web.UI.WebControls.Literal cogsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cogsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal condition_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal condition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal customer_ein {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_ein");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_einLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_einLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_disposed {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_disposed");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_disposedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_disposedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_received {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_received");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_receivedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_receivedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_sold {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_sold");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_soldLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_soldLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal datetime_added {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "datetime_added");
            }
        }
            
        public System.Web.UI.WebControls.Literal datetime_addedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "datetime_addedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal description {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "description");
            }
        }
            
        public System.Web.UI.WebControls.Literal descriptionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "descriptionLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DialogEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DialogEditButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal disposition_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal disposition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal doc_num {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "doc_num");
            }
        }
            
        public System.Web.UI.WebControls.Literal doc_numLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "doc_numLabel");
            }
        }
        
        public System.Web.UI.WebControls.Image equipment_inventory_pic {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_pic");
            }
        }
            
        public System.Web.UI.WebControls.Literal equipment_inventory_pic1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_pic1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal equipment_inventory_pic2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_pic2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal equipment_inventory_pic3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_pic3Label");
            }
        }
        
        public System.Web.UI.WebControls.Image equipment_inventory_pic4 {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_pic4");
            }
        }
            
        public System.Web.UI.WebControls.Image equipment_inventory_pic5 {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_pic5");
            }
        }
            
        public System.Web.UI.WebControls.Literal equipment_phi {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_phi");
            }
        }
            
        public System.Web.UI.WebControls.Literal equipment_phiLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_phiLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal final_sale_price {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_sale_price");
            }
        }
            
        public System.Web.UI.WebControls.Literal final_sale_priceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_sale_priceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal make_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal make_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal model_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal model_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal new_category_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "new_category_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal other_id_num {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "other_id_num");
            }
        }
            
        public System.Web.UI.WebControls.Literal other_id_numLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "other_id_numLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pd_date {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pd_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal pd_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pd_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal proposed_sale_price {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposed_sale_price");
            }
        }
            
        public System.Web.UI.WebControls.Literal proposed_sale_priceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposed_sale_priceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal purchase_price {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_price");
            }
        }
            
        public System.Web.UI.WebControls.Literal purchase_priceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_priceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal received_from_contact_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_contact_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal received_from_customer_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_customer_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal received_from_customer_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_customer_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal repair_notes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_notes");
            }
        }
            
        public System.Web.UI.WebControls.Literal repair_notesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_notesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal require_accessories {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "require_accessories");
            }
        }
            
        public System.Web.UI.WebControls.Literal require_accessoriesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "require_accessoriesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal sale_method_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sale_method_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal sale_method_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sale_method_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_number {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_number");
            }
        }
            
        public System.Web.UI.WebControls.Literal serial_numberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_numberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal sold_from_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sold_from_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal sold_from_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sold_from_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Label technician_id {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal technician_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.Literal warehouse_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal warehouse_location_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal received_from_contact_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_contact_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_location_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_id");
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
        Equipment_inventoryRecord rec = null;
             
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
    Equipment_inventoryRecord rec = null;
    
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

        
        public virtual Equipment_inventoryRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_inventoryTable.GetRecord(this.RecordUniqueId, true);
              
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

  