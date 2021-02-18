
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_Customers.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_Customers
{
  

#region "Section 1: Place your customizations here."

    
//public class RepairOrdersTableControlRow : BaseRepairOrdersTableControlRow
//{
//      
//        // The BaseRepairOrdersTableControlRow implements code for a ROW within the
//        // the RepairOrdersTableControl table.  The BaseRepairOrdersTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of RepairOrdersTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class RepairOrdersTableControl : BaseRepairOrdersTableControl
//{
//    // The BaseRepairOrdersTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The RepairOrdersTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//

  
public class CustomersRecordControl : BaseCustomersRecordControl
{
      
        // The BaseCustomersRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

//public class Max_customerRecordControl : BaseMax_customerRecordControl
//{
//      
//        // The BaseMax_customerRecordControl implements the LoadData, DataBind and other
//        // methods to load and display the data in a table control.
//
//        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
//        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
//        
//}
//
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the CustomersRecordControl control on the Add_Customers page.
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

          
              this.corporate_id.SelectedIndexChanged += corporate_id_SelectedIndexChanged;
            
              this.customer_type_id.SelectedIndexChanged += customer_type_id_SelectedIndexChanged;
            
              this.CustPayTerms.SelectedIndexChanged += CustPayTerms_SelectedIndexChanged;
            
              this.CustProvince.SelectedIndexChanged += CustProvince_SelectedIndexChanged;
            
              this.territory_id.SelectedIndexChanged += territory_id_SelectedIndexChanged;
            
              this.customer_bill_email.CheckedChanged += customer_bill_email_CheckedChanged;
            
              this.customer_bill_fax.CheckedChanged += customer_bill_fax_CheckedChanged;
            
              this.customer_bill_mail.CheckedChanged += customer_bill_mail_CheckedChanged;
            
              this.customer_inventory.CheckedChanged += customer_inventory_CheckedChanged;
            
              this.customer_po_needed.CheckedChanged += customer_po_needed_CheckedChanged;
            
              this.customer_rental.CheckedChanged += customer_rental_CheckedChanged;
            
              this.customer_scope.CheckedChanged += customer_scope_CheckedChanged;
            
              this.CustAddress1.TextChanged += CustAddress1_TextChanged;
            
              this.CustAddress2.TextChanged += CustAddress2_TextChanged;
            
              this.CustCity.TextChanged += CustCity_TextChanged;
            
              this.CustEmail.TextChanged += CustEmail_TextChanged;
            
              this.CustFax.TextChanged += CustFax_TextChanged;
            
              this.CustName.TextChanged += CustName_TextChanged;
            
              this.CustNo.TextChanged += CustNo_TextChanged;
            
              this.customer_cc_limit.TextChanged += customer_cc_limit_TextChanged;
            
              this.CustPhoneBusiness.TextChanged += CustPhoneBusiness_TextChanged;
            
              this.CustPostalCode.TextChanged += CustPostalCode_TextChanged;
            
              this.CustWebSite.TextChanged += CustWebSite_TextChanged;
            
              this.repairorder_notification.TextChanged += repairorder_notification_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Customers record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = CustomersTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new CustomersRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            CustomersRecord[] recList = CustomersTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (CustomersRecord)CustomersRecord.Copy(recList[0], false);
                  
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
                SetCustEmail();
                SetCustEmailLabel();
                SetCustFax();
                SetCustFaxLabel();
                SetCustName();
                SetCustNameLabel();
                SetCustNo();
                Setcustomer_bill_email();
                Setcustomer_bill_emailLabel();
                Setcustomer_bill_fax();
                Setcustomer_bill_faxLabel();
                Setcustomer_bill_mail();
                Setcustomer_bill_mailLabel();
                Setcustomer_cc_limit();
                Setcustomer_cc_limitLabel();
                Setcustomer_inventory();
                Setcustomer_inventoryLabel();
                Setcustomer_po_needed();
                Setcustomer_po_neededLabel();
                Setcustomer_rental();
                Setcustomer_rentalLabel();
                Setcustomer_scope();
                Setcustomer_scopeLabel();
                Setcustomer_type_id();
                Setcustomer_type_idLabel();
                SetCustPayTerms();
                SetCustPayTermsLabel();
                SetCustPhoneBusiness();
                SetCustPhoneBusinessLabel();
                SetCustPostalCode();
                SetCustPostalCodeLabel();
                SetCustProvince();
                SetCustProvinceLabel();
                SetCustWebSite();
                SetCustWebSiteLabel();
                Setrepairorder_notification();
                Setrepairorder_notificationLabel();
                Setterritory_id();
                Setterritory_idLabel();
                

      

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
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the corporate_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
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
                
        public virtual void SetCustAddress1()
        {
            
                    
            // Set the CustAddress1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAddress1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress1Specified) {
                								
                // If the CustAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustAddress1);
                                
                this.CustAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress1.Text = CustomersTable.CustAddress1.Format(CustomersTable.CustAddress1.DefaultValue);
            		
            }
            
              this.CustAddress1.TextChanged += CustAddress1_TextChanged;
                               
        }
                
        public virtual void SetCustAddress2()
        {
            
                    
            // Set the CustAddress2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustAddress2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustAddress2Specified) {
                								
                // If the CustAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustAddress2);
                                
                this.CustAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustAddress2.Text = CustomersTable.CustAddress2.Format(CustomersTable.CustAddress2.DefaultValue);
            		
            }
            
              this.CustAddress2.TextChanged += CustAddress2_TextChanged;
                               
        }
                
        public virtual void SetCustCity()
        {
            
                    
            // Set the CustCity TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustCity is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustCitySpecified) {
                								
                // If the CustCity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustCity);
                                
                this.CustCity.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustCity.Text = CustomersTable.CustCity.Format(CustomersTable.CustCity.DefaultValue);
            		
            }
            
              this.CustCity.TextChanged += CustCity_TextChanged;
                               
        }
                
        public virtual void SetCustEmail()
        {
            
                    
            // Set the CustEmail TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustEmail is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustEmailSpecified) {
                								
                // If the CustEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustEmail);
                                
                this.CustEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustEmail.Text = CustomersTable.CustEmail.Format(CustomersTable.CustEmail.DefaultValue);
            		
            }
            
              this.CustEmail.TextChanged += CustEmail_TextChanged;
                               
        }
                
        public virtual void SetCustFax()
        {
            
                    
            // Set the CustFax TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustFax is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustFaxSpecified) {
                								
                // If the CustFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustFax);
                                
                this.CustFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustFax.Text = CustomersTable.CustFax.Format(CustomersTable.CustFax.DefaultValue);
            		
            }
            
              this.CustFax.TextChanged += CustFax_TextChanged;
                               
        }
                
        public virtual void SetCustName()
        {
            
                    
            // Set the CustName TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustNameSpecified) {
                								
                // If the CustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustName);
                                
                this.CustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustName.Text = CustomersTable.CustName.Format(CustomersTable.CustName.DefaultValue);
            		
            }
            
              this.CustName.TextChanged += CustName_TextChanged;
                               
        }
                
        public virtual void SetCustNo()
        {
            
                    
            // Set the CustNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the CustNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustNo);
                                
                this.CustNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustNo.Text = EvaluateFormula("URL(\"CustomerNO\")", this.DataSource);
            		
            }
            
              this.CustNo.TextChanged += CustNo_TextChanged;
                               
        }
                
        public virtual void Setcustomer_bill_email()
        {
            
                    
            // Set the customer_bill_email CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_bill_email is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_bill_emailSpecified) {
                							
                // If the customer_bill_email is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_bill_email.Checked = this.DataSource.customer_bill_email;
                    				
            } else {
            
                // customer_bill_email is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_bill_email.Checked = CustomersTable.customer_bill_email.ParseValue(CustomersTable.customer_bill_email.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_bill_fax()
        {
            
                    
            // Set the customer_bill_fax CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_bill_fax is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_bill_faxSpecified) {
                							
                // If the customer_bill_fax is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_bill_fax.Checked = this.DataSource.customer_bill_fax;
                    				
            } else {
            
                // customer_bill_fax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_bill_fax.Checked = CustomersTable.customer_bill_fax.ParseValue(CustomersTable.customer_bill_fax.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_bill_mail()
        {
            
                    
            // Set the customer_bill_mail CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_bill_mail is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_bill_mailSpecified) {
                							
                // If the customer_bill_mail is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_bill_mail.Checked = this.DataSource.customer_bill_mail;
                    				
            } else {
            
                // customer_bill_mail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_bill_mail.Checked = CustomersTable.customer_bill_mail.ParseValue(CustomersTable.customer_bill_mail.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_cc_limit()
        {
            
                    
            // Set the customer_cc_limit TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_cc_limit is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_cc_limitSpecified) {
                								
                // If the customer_cc_limit is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.customer_cc_limit, @"C");
                                
                this.customer_cc_limit.Text = formattedValue;
                   
            } 
            
            else {
            
                // customer_cc_limit is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.customer_cc_limit.Text = CustomersTable.customer_cc_limit.Format(CustomersTable.customer_cc_limit.DefaultValue, @"C");
            		
            }
            
              this.customer_cc_limit.TextChanged += customer_cc_limit_TextChanged;
                               
        }
                
        public virtual void Setcustomer_inventory()
        {
            
                    
            // Set the customer_inventory CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_inventory is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_inventorySpecified) {
                							
                // If the customer_inventory is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_inventory.Checked = this.DataSource.customer_inventory;
                    				
            } else {
            
                // customer_inventory is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_inventory.Checked = CustomersTable.customer_inventory.ParseValue(CustomersTable.customer_inventory.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_po_needed()
        {
            
                    
            // Set the customer_po_needed CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_po_needed is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_po_neededSpecified) {
                							
                // If the customer_po_needed is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_po_needed.Checked = this.DataSource.customer_po_needed;
                    				
            } else {
            
                // customer_po_needed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_po_needed.Checked = CustomersTable.customer_po_needed.ParseValue(CustomersTable.customer_po_needed.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_rental()
        {
            
                    
            // Set the customer_rental CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_rental is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_rentalSpecified) {
                							
                // If the customer_rental is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_rental.Checked = this.DataSource.customer_rental;
                    				
            } else {
            
                // customer_rental is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_rental.Checked = CustomersTable.customer_rental.ParseValue(CustomersTable.customer_rental.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_scope()
        {
            
                    
            // Set the customer_scope CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_scope is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_scopeSpecified) {
                							
                // If the customer_scope is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.customer_scope.Checked = this.DataSource.customer_scope;
                    				
            } else {
            
                // customer_scope is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.customer_scope.Checked = CustomersTable.customer_scope.ParseValue(CustomersTable.customer_scope.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setcustomer_type_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the customer_type_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.customer_type_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustomer_type_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.customer_type_idSpecified)
            {
                            
                // If the customer_type_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.customer_type_id.ToString();
                
            }
            else
            {
                
                // customer_type_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.customer_type_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatecustomer_type_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetCustPayTerms()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the CustPayTerms DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPayTerms is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetCustPayTerms();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.CustPayTermsSpecified)
            {
                            
                // If the CustPayTerms is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.CustPayTerms.ToString();
                
            }
            else
            {
                
                // CustPayTerms is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.CustPayTerms.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateCustPayTermsDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetCustPhoneBusiness()
        {
            
                    
            // Set the CustPhoneBusiness TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPhoneBusiness is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPhoneBusinessSpecified) {
                								
                // If the CustPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPhoneBusiness);
                                
                this.CustPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPhoneBusiness.Text = CustomersTable.CustPhoneBusiness.Format(CustomersTable.CustPhoneBusiness.DefaultValue);
            		
            }
            
              this.CustPhoneBusiness.TextChanged += CustPhoneBusiness_TextChanged;
                               
        }
                
        public virtual void SetCustPostalCode()
        {
            
                    
            // Set the CustPostalCode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustPostalCode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustPostalCodeSpecified) {
                								
                // If the CustPostalCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustPostalCode);
                                
                this.CustPostalCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustPostalCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustPostalCode.Text = CustomersTable.CustPostalCode.Format(CustomersTable.CustPostalCode.DefaultValue);
            		
            }
            
              this.CustPostalCode.TextChanged += CustPostalCode_TextChanged;
                               
        }
                
        public virtual void SetCustProvince()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the CustProvince DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustProvince is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetCustProvince();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.CustProvinceSpecified)
            {
                            
                // If the CustProvince is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.CustProvince;
                
            }
            else
            {
                
                // CustProvince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = CustomersTable.CustProvince.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateCustProvinceDropDownList(selectedValue, 150);              
                
                  
        }
                
        public virtual void SetCustWebSite()
        {
            
                    
            // Set the CustWebSite TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.CustWebSite is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustWebSiteSpecified) {
                								
                // If the CustWebSite is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.CustWebSite);
                                
                this.CustWebSite.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustWebSite is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustWebSite.Text = CustomersTable.CustWebSite.Format(CustomersTable.CustWebSite.DefaultValue);
            		
            }
            
              this.CustWebSite.TextChanged += CustWebSite_TextChanged;
                               
        }
                
        public virtual void Setrepairorder_notification()
        {
            
                    
            // Set the repairorder_notification TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.repairorder_notification is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.repairorder_notificationSpecified) {
                								
                // If the repairorder_notification is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CustomersTable.repairorder_notification);
                                
                this.repairorder_notification.Text = formattedValue;
                   
            } 
            
            else {
            
                // repairorder_notification is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.repairorder_notification.Text = CustomersTable.repairorder_notification.Format(CustomersTable.repairorder_notification.DefaultValue);
            		
            }
            
              this.repairorder_notification.TextChanged += repairorder_notification_TextChanged;
                               
        }
                
        public virtual void Setterritory_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the territory_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Customers database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Customers record retrieved from the database.
            // this.territory_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setterritory_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.territory_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"territory_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateterritory_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcorporate_idLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.corporate_idLabel.Text = "Some value";
                    
                    
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
                
        public virtual void SetCustEmailLabel()
                  {
                  
                        this.CustEmailLabel.Text = EvaluateFormula("\"Billing Email\"");
                      
                    
        }
                
        public virtual void SetCustFaxLabel()
                  {
                  
                        this.CustFaxLabel.Text = EvaluateFormula("\"Fax\"");
                      
                    
        }
                
        public virtual void SetCustNameLabel()
                  {
                  
                        this.CustNameLabel.Text = EvaluateFormula("\"Facility Name\"");
                      
                    
        }
                
        public virtual void Setcustomer_bill_emailLabel()
                  {
                  
                        this.customer_bill_emailLabel.Text = EvaluateFormula("\"Bill Email\"");
                      
                    
        }
                
        public virtual void Setcustomer_bill_faxLabel()
                  {
                  
                        this.customer_bill_faxLabel.Text = EvaluateFormula("\"Bill Fax\"");
                      
                    
        }
                
        public virtual void Setcustomer_bill_mailLabel()
                  {
                  
                        this.customer_bill_mailLabel.Text = EvaluateFormula("\"Bill Mail\"");
                      
                    
        }
                
        public virtual void Setcustomer_cc_limitLabel()
                  {
                  
                        this.customer_cc_limitLabel.Text = EvaluateFormula("\"Credit Card Limit\"");
                      
                    
        }
                
        public virtual void Setcustomer_inventoryLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.customer_inventoryLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setcustomer_po_neededLabel()
                  {
                  
                        this.customer_po_neededLabel.Text = EvaluateFormula("\"PO Needed\"");
                      
                    
        }
                
        public virtual void Setcustomer_rentalLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.customer_rentalLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setcustomer_scopeLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.customer_scopeLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setcustomer_type_idLabel()
                  {
                  
                        this.customer_type_idLabel.Text = EvaluateFormula("\"Facility Type\"");
                      
                    
        }
                
        public virtual void SetCustPayTermsLabel()
                  {
                  
                        this.CustPayTermsLabel.Text = EvaluateFormula("\"Pay Terms\"");
                      
                    
        }
                
        public virtual void SetCustPhoneBusinessLabel()
                  {
                  
                        this.CustPhoneBusinessLabel.Text = EvaluateFormula("\"Phone Business\"");
                      
                    
        }
                
        public virtual void SetCustPostalCodeLabel()
                  {
                  
                        this.CustPostalCodeLabel.Text = EvaluateFormula("\"Zip Code\"");
                      
                    
        }
                
        public virtual void SetCustProvinceLabel()
                  {
                  
                        this.CustProvinceLabel.Text = EvaluateFormula("\"State\"");
                      
                    
        }
                
        public virtual void SetCustWebSiteLabel()
                  {
                  
                    
        }
                
        public virtual void Setrepairorder_notificationLabel()
                  {
                  
                    
        }
                
        public virtual void Setterritory_idLabel()
                  {
                  
                        this.territory_idLabel.Text = EvaluateFormula("\"Terr.\"");
                      
                    
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
        
            Getcorporate_id();
            GetCustAddress1();
            GetCustAddress2();
            GetCustCity();
            GetCustEmail();
            GetCustFax();
            GetCustName();
            GetCustNo();
            Getcustomer_bill_email();
            Getcustomer_bill_fax();
            Getcustomer_bill_mail();
            Getcustomer_cc_limit();
            Getcustomer_inventory();
            Getcustomer_po_needed();
            Getcustomer_rental();
            Getcustomer_scope();
            Getcustomer_type_id();
            GetCustPayTerms();
            GetCustPhoneBusiness();
            GetCustPostalCode();
            GetCustProvince();
            GetCustWebSite();
            Getrepairorder_notification();
            Getterritory_id();
        }
        
        
        public virtual void Getcorporate_id()
        {
         // Retrieve the value entered by the user on the corporate_id ASP:DropDownList, and
            // save it into the corporate_id field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.corporate_id), CustomersTable.corporate_id);			
                			 
        }
                
        public virtual void GetCustAddress1()
        {
            
            // Retrieve the value entered by the user on the CustAddress1 ASP:TextBox, and
            // save it into the CustAddress1 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustAddress1.Text, CustomersTable.CustAddress1);							
                          
                      
        }
                
        public virtual void GetCustAddress2()
        {
            
            // Retrieve the value entered by the user on the CustAddress2 ASP:TextBox, and
            // save it into the CustAddress2 field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustAddress2.Text, CustomersTable.CustAddress2);							
                          
                      
        }
                
        public virtual void GetCustCity()
        {
            
            // Retrieve the value entered by the user on the CustCity ASP:TextBox, and
            // save it into the CustCity field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustCity.Text, CustomersTable.CustCity);							
                          
                      
        }
                
        public virtual void GetCustEmail()
        {
            
            // Retrieve the value entered by the user on the CustEmail ASP:TextBox, and
            // save it into the CustEmail field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustEmail.Text, CustomersTable.CustEmail);							
                          
                      
        }
                
        public virtual void GetCustFax()
        {
            
            // Retrieve the value entered by the user on the CustFax ASP:TextBox, and
            // save it into the CustFax field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustFax.Text, CustomersTable.CustFax);							
                          
                      
        }
                
        public virtual void GetCustName()
        {
            
            // Retrieve the value entered by the user on the CustName ASP:TextBox, and
            // save it into the CustName field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustName.Text, CustomersTable.CustName);							
                          
                      
        }
                
        public virtual void GetCustNo()
        {
            
            // Retrieve the value entered by the user on the CustNo ASP:TextBox, and
            // save it into the CustNo field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustNo.Text, CustomersTable.CustNo);							
                          
                      
        }
                
        public virtual void Getcustomer_bill_email()
        {	
        		
            // Retrieve the value entered by the user on the customer_bill_email ASP:CheckBox, and
            // save it into the customer_bill_email field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_bill_email = this.customer_bill_email.Checked;						
                    
        }
                
        public virtual void Getcustomer_bill_fax()
        {	
        		
            // Retrieve the value entered by the user on the customer_bill_fax ASP:CheckBox, and
            // save it into the customer_bill_fax field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_bill_fax = this.customer_bill_fax.Checked;						
                    
        }
                
        public virtual void Getcustomer_bill_mail()
        {	
        		
            // Retrieve the value entered by the user on the customer_bill_mail ASP:CheckBox, and
            // save it into the customer_bill_mail field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_bill_mail = this.customer_bill_mail.Checked;						
                    
        }
                
        public virtual void Getcustomer_cc_limit()
        {
            
            // Retrieve the value entered by the user on the customer_cc_limit ASP:TextBox, and
            // save it into the customer_cc_limit field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.customer_cc_limit.Text, CustomersTable.customer_cc_limit);							
                          
                      
        }
                
        public virtual void Getcustomer_inventory()
        {	
        		
            // Retrieve the value entered by the user on the customer_inventory ASP:CheckBox, and
            // save it into the customer_inventory field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_inventory = this.customer_inventory.Checked;						
                    
        }
                
        public virtual void Getcustomer_po_needed()
        {	
        		
            // Retrieve the value entered by the user on the customer_po_needed ASP:CheckBox, and
            // save it into the customer_po_needed field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_po_needed = this.customer_po_needed.Checked;						
                    
        }
                
        public virtual void Getcustomer_rental()
        {	
        		
            // Retrieve the value entered by the user on the customer_rental ASP:CheckBox, and
            // save it into the customer_rental field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_rental = this.customer_rental.Checked;						
                    
        }
                
        public virtual void Getcustomer_scope()
        {	
        		
            // Retrieve the value entered by the user on the customer_scope ASP:CheckBox, and
            // save it into the customer_scope field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.customer_scope = this.customer_scope.Checked;						
                    
        }
                
        public virtual void Getcustomer_type_id()
        {
         // Retrieve the value entered by the user on the customer_type_id ASP:DropDownList, and
            // save it into the customer_type_id field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.customer_type_id), CustomersTable.customer_type_id);			
                			 
        }
                
        public virtual void GetCustPayTerms()
        {
         // Retrieve the value entered by the user on the CustPayTerms ASP:DropDownList, and
            // save it into the CustPayTerms field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.CustPayTerms), CustomersTable.CustPayTerms);			
                			 
        }
                
        public virtual void GetCustPhoneBusiness()
        {
            
            // Retrieve the value entered by the user on the CustPhoneBusiness ASP:TextBox, and
            // save it into the CustPhoneBusiness field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPhoneBusiness.Text, CustomersTable.CustPhoneBusiness);							
                          
                      
        }
                
        public virtual void GetCustPostalCode()
        {
            
            // Retrieve the value entered by the user on the CustPostalCode ASP:TextBox, and
            // save it into the CustPostalCode field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustPostalCode.Text, CustomersTable.CustPostalCode);							
                          
                      
        }
                
        public virtual void GetCustProvince()
        {
         // Retrieve the value entered by the user on the CustProvince ASP:DropDownList, and
            // save it into the CustProvince field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.CustProvince), CustomersTable.CustProvince);			
                			 
        }
                
        public virtual void GetCustWebSite()
        {
            
            // Retrieve the value entered by the user on the CustWebSite ASP:TextBox, and
            // save it into the CustWebSite field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustWebSite.Text, CustomersTable.CustWebSite);							
                          
                      
        }
                
        public virtual void Getrepairorder_notification()
        {
            
            // Retrieve the value entered by the user on the repairorder_notification ASP:TextBox, and
            // save it into the repairorder_notification field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.repairorder_notification.Text, CustomersTable.repairorder_notification);							
                          
                      
        }
                
        public virtual void Getterritory_id()
        {
         // Retrieve the value entered by the user on the territory_id ASP:DropDownList, and
            // save it into the territory_id field in DataSource DatabaseAYS_OEM%dbo.Customers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.territory_id), CustomersTable.territory_id);			
                			 
        }
                

      // To customize, override this method in CustomersRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
            WhereClause wc;
            CustomersTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Customers"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-Customers"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(CustomersTable.CustNo));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            CustomersTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersCustomersRecordControl = false;
            hasFiltersCustomersRecordControl = hasFiltersCustomersRecordControl && false; // suppress warning
      
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
        
        public virtual WhereClause CreateWhereClause_customer_type_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.customer_type table.
            // Examples:
            // wc.iAND(Customer_typeTable.customer_type_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Customer_typeTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Customer_typeTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"customer_type_.customer_type_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_CustPayTermsDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_CustProvinceDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Provinces table.
            // Examples:
            // wc.iAND(ProvincesTable.ProvCode, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ProvincesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ProvincesTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Provinces_.Prov_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_territory_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.territory table.
            // Examples:
            // wc.iAND(TerritoryTable.territory_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(TerritoryTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.TerritoryTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"territory_.territory_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

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
                  
        // Fill the customer_type_id list.
        protected virtual void Populatecustomer_type_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.customer_type_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.customer_type_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_customer_type_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_customer_type_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Customer_typeTable.customer_type, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the customer_type_idDropDownList.
            Customer_typeRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Customer_typeTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Customer_typeRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.customer_type_idSpecified) 
                        {
                            cvalue = itemValue.customer_type_id.ToString().ToString();
                            if (counter < maxItems && this.customer_type_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Customer_type.customer_type", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.customer_type_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.customer_type_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.customer_type_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.customer_type_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.customer_type.customer_type_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Customer_typeTable.customer_type_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Customer_typeRecord[] rc = Customer_typeTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Customer_typeRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.customer_type_idSpecified)
                            cvalue = itemValue.customer_type_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Customer_type.customer_type", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.customer_type_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the CustPayTerms list.
        protected virtual void PopulateCustPayTermsDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.CustPayTerms.Items.Clear();
            
            // 1. Setup the static list items        
            
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("COD"), "0"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("5 Days"), "1"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("10 Days"), "2"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("15 Days"), "3"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("20 Days"), "4"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("25 Days"), "5"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("30 Days"), "6"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("35 Days"), "7"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("40 Days"), "8"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("45 Days"), "9"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("50 Days"), "10"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("55 Days"), "11"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("60 Days"), "12"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("65 Days"), "13"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("70 Days"), "14"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("75 Days"), "15"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("80 Days"), "16"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("85 Days"), "17"));
              
                this.CustPayTerms.Items.Add(new ListItem(this.Page.ExpandResourceValue("90 Days"), "18"));
              		  
            // Skip step 2 and 3 because no need to load data from database and insert data
            
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.CustPayTerms, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.CustPayTerms, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.CustPayTerms, CustomersTable.CustPayTerms.Format(selectedValue)))
            {
                string fvalue = CustomersTable.CustPayTerms.Format(selectedValue);
                if (fvalue == null || fvalue.Trim() == "") fvalue = selectedValue;
                MiscUtils.ResetSelectedItem(this.CustPayTerms, new ListItem(fvalue, selectedValue));
            }
                    
        }
                  
        // Fill the CustProvince list.
        protected virtual void PopulateCustProvinceDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.CustProvince.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.CustProvince.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CustProvinceDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_CustProvinceDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ProvincesTable.ProvCode, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the CustProvinceDropDownList.
            ProvincesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = ProvincesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (ProvincesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ProvCodeSpecified) 
                        {
                            cvalue = itemValue.ProvCode.ToString();
                            if (counter < maxItems && this.CustProvince.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("=Provinces.ProvName", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.CustProvince.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.CustProvince.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.CustProvince, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.CustProvince, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Provinces.ProvCode = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ProvincesTable.ProvCode, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ProvincesRecord[] rc = ProvincesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ProvincesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ProvCodeSpecified)
                            cvalue = itemValue.ProvCode.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("=Provinces.ProvName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.CustProvince, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the territory_id list.
        protected virtual void Populateterritory_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.territory_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.territory_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_territory_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_territory_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(TerritoryTable.territory_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the territory_idDropDownList.
            TerritoryRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = TerritoryTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (TerritoryRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.territory_idSpecified) 
                        {
                            cvalue = itemValue.territory_id.ToString().ToString();
                            if (counter < maxItems && this.territory_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Territory.territory_name", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.territory_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.territory_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.territory_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.territory_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.territory.territory_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(TerritoryTable.territory_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    TerritoryRecord[] rc = TerritoryTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        TerritoryRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.territory_idSpecified)
                            cvalue = itemValue.territory_id.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Territory.territory_name", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.territory_id, new ListItem(fvalue, cvalue));                      
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
           						
        }
            
        protected virtual void customer_type_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[customer_type_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[customer_type_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.customer_type_id.Items.Add(new ListItem(displayText, val));
	            this.customer_type_id.SelectedIndex = this.customer_type_id.Items.Count - 1;
	            this.Page.Session.Remove(customer_type_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(customer_type_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void CustPayTerms_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[CustPayTerms.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[CustPayTerms.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.CustPayTerms.Items.Add(new ListItem(displayText, val));
	            this.CustPayTerms.SelectedIndex = this.CustPayTerms.Items.Count - 1;
	            this.Page.Session.Remove(CustPayTerms.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(CustPayTerms.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void CustProvince_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[CustProvince.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[CustProvince.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.CustProvince.Items.Add(new ListItem(displayText, val));
	            this.CustProvince.SelectedIndex = this.CustProvince.Items.Count - 1;
	            this.Page.Session.Remove(CustProvince.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(CustProvince.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void territory_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[territory_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[territory_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.territory_id.Items.Add(new ListItem(displayText, val));
	            this.territory_id.SelectedIndex = this.territory_id.Items.Count - 1;
	            this.Page.Session.Remove(territory_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(territory_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void customer_bill_email_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_bill_fax_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_bill_mail_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_inventory_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_po_needed_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_rental_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void customer_scope_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void CustAddress1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustAddress2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustCity_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustEmail_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustFax_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void customer_cc_limit_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPhoneBusiness_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustPostalCode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustWebSite_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void repairorder_notification_TextChanged(object sender, EventArgs args)
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
        
        public System.Web.UI.WebControls.TextBox CustAddress1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustAddress1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustAddress2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustAddress2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustAddress2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustCity {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCity");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustCityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustCityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustEmail {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustFax {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustNo");
            }
        }
            
        public System.Web.UI.WebControls.CheckBox customer_bill_email {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_email");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_bill_emailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_emailLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_bill_fax {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_fax");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_bill_faxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_faxLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_bill_mail {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_mail");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_bill_mailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_bill_mailLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox customer_cc_limit {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_cc_limit");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_cc_limitLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_cc_limitLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_inventory {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_inventory");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_inventoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_inventoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_po_needed {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_po_needed");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_po_neededLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_po_neededLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_rental {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_rental");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_rentalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_rentalLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox customer_scope {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_scope");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_scopeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_scopeLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList customer_type_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_type_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_type_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_type_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList CustPayTerms {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPayTerms");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPayTermsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPayTermsLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustPostalCode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPostalCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustPostalCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustPostalCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList CustProvince {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustProvince");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustProvinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustProvinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustWebSite {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustWebSite");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustWebSiteLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustWebSiteLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox repairorder_notification {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repairorder_notification");
            }
        }
            
        public System.Web.UI.WebControls.Literal repairorder_notificationLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repairorder_notificationLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList territory_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "territory_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal territory_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "territory_idLabel");
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
            
            return new CustomersRecord();
            
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

  