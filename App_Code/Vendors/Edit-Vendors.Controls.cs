
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Vendors.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Vendors
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

  
public class VendorsRecordControl : BaseVendorsRecordControl
{
      
        // The BaseVendorsRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the VendorsRecordControl control on the Edit_Vendors page.
// Do not modify this class. Instead override any method in VendorsRecordControl.
public class BaseVendorsRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseVendorsRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in VendorsRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in VendorsRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.VendProvince.SelectedIndexChanged += VendProvince_SelectedIndexChanged;
            
              this.VendShipVia.SelectedIndexChanged += VendShipVia_SelectedIndexChanged;
            
              this.Vend_active.CheckedChanged += Vend_active_CheckedChanged;
            
              this.vendor_inventory.CheckedChanged += vendor_inventory_CheckedChanged;
            
              this.vendor_repair.CheckedChanged += vendor_repair_CheckedChanged;
            
              this.VendAddress1.TextChanged += VendAddress1_TextChanged;
            
              this.VendAddress2.TextChanged += VendAddress2_TextChanged;
            
              this.VendCity.TextChanged += VendCity_TextChanged;
            
              this.VendEmail.TextChanged += VendEmail_TextChanged;
            
              this.VendFax.TextChanged += VendFax_TextChanged;
            
              this.VendName.TextChanged += VendName_TextChanged;
            
              this.VendPhoneBusiness.TextChanged += VendPhoneBusiness_TextChanged;
            
              this.VendPostalCode.TextChanged += VendPostalCode_TextChanged;
            
              this.VendWebSite.TextChanged += VendWebSite_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Vendors record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = VendorsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "VendorsRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new VendorsRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            VendorsRecord[] recList = VendorsTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = VendorsTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                
                SetVend_active();
                SetVend_activeLabel();
                SetVendAddress1();
                SetVendAddress1Label();
                SetVendAddress2();
                SetVendAddress2Label();
                SetVendCity();
                SetVendCityLabel();
                SetVendEmail();
                SetVendEmailLabel();
                SetVendFax();
                SetVendFaxLabel();
                SetVendName();
                SetVendNameLabel();
                Setvendor_inventory();
                Setvendor_inventoryLabel();
                Setvendor_repair();
                Setvendor_repairLabel();
                SetVendPhoneBusiness();
                SetVendPhoneBusinessLabel();
                SetVendPostalCode();
                SetVendPostalCodeLabel();
                SetVendPrivateNotes();
                SetVendPrivateNotesLabel();
                SetVendProvince();
                SetVendProvinceLabel();
                SetVendShipVia();
                SetVendShipViaLabel();
                SetVendWebSite();
                SetVendWebSiteLabel();

      

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
        
        
        public virtual void SetVend_active()
        {
            
                    
            // Set the Vend_active CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.Vend_active is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Vend_activeSpecified) {
                							
                // If the Vend_active is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.Vend_active.Checked = this.DataSource.Vend_active;
                    				
            } else {
            
                // Vend_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.Vend_active.Checked = VendorsTable.Vend_active.ParseValue(VendorsTable.Vend_active.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetVendAddress1()
        {
            
                    
            // Set the VendAddress1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendAddress1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendAddress1Specified) {
                								
                // If the VendAddress1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendAddress1);
                                
                this.VendAddress1.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendAddress1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendAddress1.Text = VendorsTable.VendAddress1.Format(VendorsTable.VendAddress1.DefaultValue);
            		
            }
            
              this.VendAddress1.TextChanged += VendAddress1_TextChanged;
                               
        }
                
        public virtual void SetVendAddress2()
        {
            
                    
            // Set the VendAddress2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendAddress2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendAddress2Specified) {
                								
                // If the VendAddress2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendAddress2);
                                
                this.VendAddress2.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendAddress2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendAddress2.Text = VendorsTable.VendAddress2.Format(VendorsTable.VendAddress2.DefaultValue);
            		
            }
            
              this.VendAddress2.TextChanged += VendAddress2_TextChanged;
                               
        }
                
        public virtual void SetVendCity()
        {
            
                    
            // Set the VendCity TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendCity is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendCitySpecified) {
                								
                // If the VendCity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendCity);
                                
                this.VendCity.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendCity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendCity.Text = VendorsTable.VendCity.Format(VendorsTable.VendCity.DefaultValue);
            		
            }
            
              this.VendCity.TextChanged += VendCity_TextChanged;
                               
        }
                
        public virtual void SetVendEmail()
        {
            
                    
            // Set the VendEmail TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendEmail is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendEmailSpecified) {
                								
                // If the VendEmail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendEmail);
                                
                this.VendEmail.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendEmail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendEmail.Text = VendorsTable.VendEmail.Format(VendorsTable.VendEmail.DefaultValue);
            		
            }
            
              this.VendEmail.TextChanged += VendEmail_TextChanged;
                               
        }
                
        public virtual void SetVendFax()
        {
            
                    
            // Set the VendFax TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendFax is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendFaxSpecified) {
                								
                // If the VendFax is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendFax);
                                
                this.VendFax.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendFax is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendFax.Text = VendorsTable.VendFax.Format(VendorsTable.VendFax.DefaultValue);
            		
            }
            
              this.VendFax.TextChanged += VendFax_TextChanged;
                               
        }
                
        public virtual void SetVendName()
        {
            
                    
            // Set the VendName TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendNameSpecified) {
                								
                // If the VendName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendName);
                                
                this.VendName.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendName.Text = VendorsTable.VendName.Format(VendorsTable.VendName.DefaultValue);
            		
            }
            
              this.VendName.TextChanged += VendName_TextChanged;
                               
        }
                
        public virtual void Setvendor_inventory()
        {
            
                    
            // Set the vendor_inventory CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.vendor_inventory is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.vendor_inventorySpecified) {
                							
                // If the vendor_inventory is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.vendor_inventory.Checked = this.DataSource.vendor_inventory;
                    				
            } else {
            
                // vendor_inventory is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.vendor_inventory.Checked = VendorsTable.vendor_inventory.ParseValue(VendorsTable.vendor_inventory.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setvendor_repair()
        {
            
                    
            // Set the vendor_repair CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.vendor_repair is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.vendor_repairSpecified) {
                							
                // If the vendor_repair is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.vendor_repair.Checked = this.DataSource.vendor_repair;
                    				
            } else {
            
                // vendor_repair is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.vendor_repair.Checked = VendorsTable.vendor_repair.ParseValue(VendorsTable.vendor_repair.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetVendPhoneBusiness()
        {
            
                    
            // Set the VendPhoneBusiness TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPhoneBusiness is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPhoneBusinessSpecified) {
                								
                // If the VendPhoneBusiness is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPhoneBusiness);
                                
                this.VendPhoneBusiness.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendPhoneBusiness is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendPhoneBusiness.Text = VendorsTable.VendPhoneBusiness.Format(VendorsTable.VendPhoneBusiness.DefaultValue);
            		
            }
            
              this.VendPhoneBusiness.TextChanged += VendPhoneBusiness_TextChanged;
                               
        }
                
        public virtual void SetVendPostalCode()
        {
            
                    
            // Set the VendPostalCode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPostalCode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPostalCodeSpecified) {
                								
                // If the VendPostalCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPostalCode);
                                
                this.VendPostalCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendPostalCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendPostalCode.Text = VendorsTable.VendPostalCode.Format(VendorsTable.VendPostalCode.DefaultValue);
            		
            }
            
              this.VendPostalCode.TextChanged += VendPostalCode_TextChanged;
                               
        }
                
        public virtual void SetVendPrivateNotes()
        {
            
                    
            // Set the VendPrivateNotes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendPrivateNotes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendPrivateNotesSpecified) {
                								
                // If the VendPrivateNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendPrivateNotes);
                                                
                this.VendPrivateNotes.Content = formattedValue;
                 
            } 
            
            else {
            
                // VendPrivateNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                    
            this.VendPrivateNotes.Content = VendorsTable.VendPrivateNotes.Format(VendorsTable.VendPrivateNotes.DefaultValue);
          		
            }
                               
        }
                
        public virtual void SetVendProvince()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the VendProvince DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendProvince is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetVendProvince();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.VendProvinceSpecified)
            {
                            
                // If the VendProvince is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.VendProvince;
                
            }
            else
            {
                
                // VendProvince is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = VendorsTable.VendProvince.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateVendProvinceDropDownList(selectedValue, 200);              
                
                  
        }
                
        public virtual void SetVendShipVia()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the VendShipVia DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendShipVia is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetVendShipVia();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.VendShipViaSpecified)
            {
                            
                // If the VendShipVia is non-NULL, then format the value.
                // The Format method will use the Display Format
                selectedValue = this.DataSource.VendShipVia;
                
            }
            else
            {
                
                // VendShipVia is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = VendorsTable.VendShipVia.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateVendShipViaDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetVendWebSite()
        {
            
                    
            // Set the VendWebSite TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Vendors database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Vendors record retrieved from the database.
            // this.VendWebSite is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VendWebSiteSpecified) {
                								
                // If the VendWebSite is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VendorsTable.VendWebSite);
                                
                this.VendWebSite.Text = formattedValue;
                   
            } 
            
            else {
            
                // VendWebSite is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VendWebSite.Text = VendorsTable.VendWebSite.Format(VendorsTable.VendWebSite.DefaultValue);
            		
            }
            
              this.VendWebSite.TextChanged += VendWebSite_TextChanged;
                               
        }
                
        public virtual void SetVend_activeLabel()
                  {
                  
                        this.Vend_activeLabel.Text = EvaluateFormula("\"Active\"");
                      
                    
        }
                
        public virtual void SetVendAddress1Label()
                  {
                  
                        this.VendAddress1Label.Text = EvaluateFormula("\"Address\"");
                      
                    
        }
                
        public virtual void SetVendAddress2Label()
                  {
                  
                        this.VendAddress2Label.Text = EvaluateFormula("\"Address 2\"");
                      
                    
        }
                
        public virtual void SetVendCityLabel()
                  {
                  
                        this.VendCityLabel.Text = EvaluateFormula("\"City\"");
                      
                    
        }
                
        public virtual void SetVendEmailLabel()
                  {
                  
                        this.VendEmailLabel.Text = EvaluateFormula("\"Email\"");
                      
                    
        }
                
        public virtual void SetVendFaxLabel()
                  {
                  
                        this.VendFaxLabel.Text = EvaluateFormula("\"Fax\"");
                      
                    
        }
                
        public virtual void SetVendNameLabel()
                  {
                  
                        this.VendNameLabel.Text = EvaluateFormula("\"Vendor Name\"");
                      
                    
        }
                
        public virtual void Setvendor_inventoryLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.vendor_inventoryLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setvendor_repairLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.vendor_repairLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetVendPhoneBusinessLabel()
                  {
                  
                        this.VendPhoneBusinessLabel.Text = EvaluateFormula("\"Phone Business\"");
                      
                    
        }
                
        public virtual void SetVendPostalCodeLabel()
                  {
                  
                        this.VendPostalCodeLabel.Text = EvaluateFormula("\"Zip Code\"");
                      
                    
        }
                
        public virtual void SetVendPrivateNotesLabel()
                  {
                  
                    
        }
                
        public virtual void SetVendProvinceLabel()
                  {
                  
                        this.VendProvinceLabel.Text = EvaluateFormula("\"State\"");
                      
                    
        }
                
        public virtual void SetVendShipViaLabel()
                  {
                  
                        this.VendShipViaLabel.Text = EvaluateFormula("\"Ship Via\"");
                      
                    
        }
                
        public virtual void SetVendWebSiteLabel()
                  {
                  
                        this.VendWebSiteLabel.Text = EvaluateFormula("\"Website\"");
                      
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "VendorsRecordControlPanel");
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
        
            GetVend_active();
            GetVendAddress1();
            GetVendAddress2();
            GetVendCity();
            GetVendEmail();
            GetVendFax();
            GetVendName();
            Getvendor_inventory();
            Getvendor_repair();
            GetVendPhoneBusiness();
            GetVendPostalCode();
            GetVendPrivateNotes();
            GetVendProvince();
            GetVendShipVia();
            GetVendWebSite();
        }
        
        
        public virtual void GetVend_active()
        {	
        		
            // Retrieve the value entered by the user on the Vend_active ASP:CheckBox, and
            // save it into the Vend_active field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Vend_active = this.Vend_active.Checked;						
                    
        }
                
        public virtual void GetVendAddress1()
        {
            
            // Retrieve the value entered by the user on the VendAddress1 ASP:TextBox, and
            // save it into the VendAddress1 field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendAddress1.Text, VendorsTable.VendAddress1);							
                          
                      
        }
                
        public virtual void GetVendAddress2()
        {
            
            // Retrieve the value entered by the user on the VendAddress2 ASP:TextBox, and
            // save it into the VendAddress2 field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendAddress2.Text, VendorsTable.VendAddress2);							
                          
                      
        }
                
        public virtual void GetVendCity()
        {
            
            // Retrieve the value entered by the user on the VendCity ASP:TextBox, and
            // save it into the VendCity field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendCity.Text, VendorsTable.VendCity);							
                          
                      
        }
                
        public virtual void GetVendEmail()
        {
            
            // Retrieve the value entered by the user on the VendEmail ASP:TextBox, and
            // save it into the VendEmail field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendEmail.Text, VendorsTable.VendEmail);							
                          
                      
        }
                
        public virtual void GetVendFax()
        {
            
            // Retrieve the value entered by the user on the VendFax ASP:TextBox, and
            // save it into the VendFax field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendFax.Text, VendorsTable.VendFax);							
                          
                      
        }
                
        public virtual void GetVendName()
        {
            
            // Retrieve the value entered by the user on the VendName ASP:TextBox, and
            // save it into the VendName field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendName.Text, VendorsTable.VendName);							
                          
                      
        }
                
        public virtual void Getvendor_inventory()
        {	
        		
            // Retrieve the value entered by the user on the vendor_inventory ASP:CheckBox, and
            // save it into the vendor_inventory field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.vendor_inventory = this.vendor_inventory.Checked;						
                    
        }
                
        public virtual void Getvendor_repair()
        {	
        		
            // Retrieve the value entered by the user on the vendor_repair ASP:CheckBox, and
            // save it into the vendor_repair field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.vendor_repair = this.vendor_repair.Checked;						
                    
        }
                
        public virtual void GetVendPhoneBusiness()
        {
            
            // Retrieve the value entered by the user on the VendPhoneBusiness ASP:TextBox, and
            // save it into the VendPhoneBusiness field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendPhoneBusiness.Text, VendorsTable.VendPhoneBusiness);							
                          
                      
        }
                
        public virtual void GetVendPostalCode()
        {
            
            // Retrieve the value entered by the user on the VendPostalCode ASP:TextBox, and
            // save it into the VendPostalCode field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendPostalCode.Text, VendorsTable.VendPostalCode);							
                          
                      
        }
                
        public virtual void GetVendPrivateNotes()
        {
            
            // Retrieve the value entered by the user on the VendPrivateNotes ASP:TextBox, and
            // save it into the VendPrivateNotes field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendPrivateNotes.Content, VendorsTable.VendPrivateNotes);							
                          
                      
        }
                
        public virtual void GetVendProvince()
        {
         // Retrieve the value entered by the user on the VendProvince ASP:DropDownList, and
            // save it into the VendProvince field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.VendProvince), VendorsTable.VendProvince);			
                			 
        }
                
        public virtual void GetVendShipVia()
        {
         // Retrieve the value entered by the user on the VendShipVia ASP:DropDownList, and
            // save it into the VendShipVia field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.VendShipVia), VendorsTable.VendShipVia);			
                			 
        }
                
        public virtual void GetVendWebSite()
        {
            
            // Retrieve the value entered by the user on the VendWebSite ASP:TextBox, and
            // save it into the VendWebSite field in DataSource DatabaseAYS_OEM%dbo.Vendors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VendWebSite.Text, VendorsTable.VendWebSite);							
                          
                      
        }
                

      // To customize, override this method in VendorsRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersVendorsRecordControl = false;
            hasFiltersVendorsRecordControl = hasFiltersVendorsRecordControl && false; // suppress warning
      
            WhereClause wc;
            VendorsTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Vendors"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Vendors"));
            }
            HttpContext.Current.Session["QueryString in Edit-Vendors"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(VendorsTable.VendNo, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(VendorsTable.VendNo));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(VendorsTable.VendNo, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            VendorsTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersVendorsRecordControl = false;
            hasFiltersVendorsRecordControl = hasFiltersVendorsRecordControl && false; // suppress warning
      
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
          VendorsTable.DeleteRecord(pkValue);
          
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
        
        public virtual WhereClause CreateWhereClause_VendProvinceDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Provinces table.
            // Examples:
            // wc.iAND(ProvincesTable.ProvName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ProvincesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ProvincesTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Provinces_.Prov_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_VendShipViaDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        // Fill the VendProvince list.
        protected virtual void PopulateVendProvinceDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.VendProvince.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.VendProvince.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_VendProvinceDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_VendProvinceDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ProvincesTable.ProvName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the VendProvinceDropDownList.
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
                        if (itemValue.ProvNameSpecified) 
                        {
                            cvalue = itemValue.ProvName.ToString();
                            if (counter < maxItems && this.VendProvince.Items.FindByValue(cvalue) == null)
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

                                ListItem dupItem = this.VendProvince.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.VendProvince.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.VendProvince, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.VendProvince, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Provinces.ProvName = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ProvincesTable.ProvName, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
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
                        if (itemValue.ProvNameSpecified)
                            cvalue = itemValue.ProvName.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("=Provinces.ProvName", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.VendProvince, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the VendShipVia list.
        protected virtual void PopulateVendShipViaDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.VendShipVia.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.VendShipVia.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_VendShipViaDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_VendShipViaDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ShippingTable.ShipVia, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the VendShipViaDropDownList.
            ShippingRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = ShippingTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (ShippingRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ShipViaSpecified) 
                        {
                            cvalue = itemValue.ShipVia.ToString();
                            if (counter < maxItems && this.VendShipVia.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("ShipVia", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.VendShipVia.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.VendShipVia.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.VendShipVia, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.VendShipVia, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Shipping.ShipVia = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ShippingTable.ShipVia, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ShippingRecord[] rc = ShippingTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ShippingRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ShipViaSpecified)
                            cvalue = itemValue.ShipVia.ToString(); 
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("ShipVia", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.VendShipVia, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void VendProvince_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[VendProvince.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[VendProvince.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.VendProvince.Items.Add(new ListItem(displayText, val));
	            this.VendProvince.SelectedIndex = this.VendProvince.Items.Count - 1;
	            this.Page.Session.Remove(VendProvince.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(VendProvince.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void VendShipVia_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[VendShipVia.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[VendShipVia.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.VendShipVia.Items.Add(new ListItem(displayText, val));
	            this.VendShipVia.SelectedIndex = this.VendShipVia.Items.Count - 1;
	            this.Page.Session.Remove(VendShipVia.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(VendShipVia.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void Vend_active_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void vendor_inventory_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void vendor_repair_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void VendAddress1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendAddress2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendCity_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendEmail_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendFax_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendPhoneBusiness_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendPostalCode_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VendPrivateNotes_TextChanged(object sender, EventArgs args)
        {
                    
                // this event handler is not supported since VendPrivateNotes is an Ajax HTML Editor.
              
              }
            
        protected virtual void VendWebSite_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseVendorsRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseVendorsRecordControl_Rec"] = value;
            }
        }
        
        public VendorsRecord DataSource {
            get {
                return (VendorsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox Vend_active {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vend_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal Vend_activeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vend_activeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendAddress1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAddress1");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendAddress1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAddress1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendAddress2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAddress2");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendAddress2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendAddress2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendCity {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCity");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendCityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendCityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendEmail {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendEmail");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendEmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendEmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendFax {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendFax");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendFaxLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendFaxLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendName");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox vendor_inventory {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "vendor_inventory");
            }
        }
            
        public System.Web.UI.WebControls.Literal vendor_inventoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "vendor_inventoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox vendor_repair {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "vendor_repair");
            }
        }
            
        public System.Web.UI.WebControls.Literal vendor_repairLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "vendor_repairLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendPhoneBusiness {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPhoneBusiness");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendPhoneBusinessLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPhoneBusinessLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendPostalCode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPostalCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendPostalCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPostalCodeLabel");
            }
        }
        
              public AjaxControlToolkit.HTMLEditor.Editor VendPrivateNotes {
              get {
                  return (AjaxControlToolkit.HTMLEditor.Editor)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPrivateNotes");
                  }
              }
          
        public System.Web.UI.WebControls.Literal VendPrivateNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendPrivateNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList VendProvince {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendProvince");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendProvinceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendProvinceLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList VendShipVia {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendShipVia");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendShipViaLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendShipViaLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VendWebSite {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendWebSite");
            }
        }
            
        public System.Web.UI.WebControls.Literal VendWebSiteLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VendWebSiteLabel");
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
        VendorsRecord rec = null;
             
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
    VendorsRecord rec = null;
    
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

        
        public virtual VendorsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return VendorsTable.GetRecord(this.RecordUniqueId, true);
              
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

  