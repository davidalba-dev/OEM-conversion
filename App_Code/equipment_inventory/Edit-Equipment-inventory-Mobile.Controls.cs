
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Equipment_inventory_Mobile.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Equipment_inventory_Mobile
{
  

#region "Section 1: Place your customizations here."

    
public class Equipment_inventoryRecordControl : BaseEquipment_inventoryRecordControl
{
      
        // The BaseEquipment_inventoryRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_inventoryRecordControl control on the Edit_Equipment_inventory_Mobile page.
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

          
                    this.CancelButton.Click += CancelButton_Click;
                        
              this.condition_id.SelectedIndexChanged += condition_id_SelectedIndexChanged;
            
              this.disposition_id.SelectedIndexChanged += disposition_id_SelectedIndexChanged;
            
              this.received_from_contact_id.SelectedIndexChanged += received_from_contact_id_SelectedIndexChanged;
            
              this.received_from_customer_id.SelectedIndexChanged += received_from_customer_id_SelectedIndexChanged;
            
              this.sale_method_id.SelectedIndexChanged += sale_method_id_SelectedIndexChanged;
            
              this.sold_from_id.SelectedIndexChanged += sold_from_id_SelectedIndexChanged;
            
              this.warehouse_id.SelectedIndexChanged += warehouse_id_SelectedIndexChanged;
            
              this.warehouse_location_id.SelectedIndexChanged += warehouse_location_id_SelectedIndexChanged;
            
              this.equipment_phi.CheckedChanged += equipment_phi_CheckedChanged;
            
              this.require_accessories.CheckedChanged += require_accessories_CheckedChanged;
            
              this.category_id.TextChanged += category_id_TextChanged;
            
              this.cogs.TextChanged += cogs_TextChanged;
            
              this.customer_ein.TextChanged += customer_ein_TextChanged;
            
              this.date_disposed.TextChanged += date_disposed_TextChanged;
            
              this.date_received.TextChanged += date_received_TextChanged;
            
              this.date_sold.TextChanged += date_sold_TextChanged;
            
              this.description.TextChanged += description_TextChanged;
            
              this.doc_num.TextChanged += doc_num_TextChanged;
            
              this.final_sale_price.TextChanged += final_sale_price_TextChanged;
            
              this.inventory_status_id.TextChanged += inventory_status_id_TextChanged;
            
              this.make_id.TextChanged += make_id_TextChanged;
            
              this.model_id.TextChanged += model_id_TextChanged;
            
              this.other_id_num.TextChanged += other_id_num_TextChanged;
            
              this.pd_date.TextChanged += pd_date_TextChanged;
            
              this.proposed_sale_price.TextChanged += proposed_sale_price_TextChanged;
            
              this.purchase_price.TextChanged += purchase_price_TextChanged;
            
              this.repair_notes.TextChanged += repair_notes_TextChanged;
            
              this.serial_number.TextChanged += serial_number_TextChanged;
            
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
        
                
                Setcategory_id();
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
                Setdescription();
                SetdescriptionLabel();
                Setdisposition_id();
                Setdisposition_idLabel();
                Setdoc_num();
                Setdoc_numLabel();
                Setequipment_phi();
                Setequipment_phiLabel();
                Setfinal_sale_price();
                Setfinal_sale_priceLabel();
                Setinventory_status_id();
                Setinventory_status_idLabel();
                Setmake_id();
                Setmake_idLabel();
                Setmodel_id();
                Setmodel_idLabel();
                Setother_id_num();
                Setother_id_numLabel();
                Setpd_date();
                Setpd_dateLabel();
                Setproposed_sale_price();
                Setproposed_sale_priceLabel();
                Setpurchase_price();
                Setpurchase_priceLabel();
                Setreceived_from_contact_id();
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
                
                Setwarehouse_id();
                Setwarehouse_idLabel();
                Setwarehouse_location_id();
                Setwarehouse_location_idLabel();
                SetCancelButton();
              

      

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
        
        
        public virtual void Setcategory_id()
        {
            
                    
            // Set the category_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.category_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.category_idSpecified) {
                								
                // If the category_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.category_id.ToString();
                            
                this.category_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // category_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.category_id.Text = Equipment_inventoryTable.category_id.DefaultValue;
            		
            }
            
              this.category_id.TextChanged += category_id_TextChanged;
                               
        }
                
        public virtual void Setcogs()
        {
            
                    
            // Set the cogs TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.cogs is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.cogsSpecified) {
                								
                // If the cogs is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.cogs, @"C");
                                
                this.cogs.Text = formattedValue;
                   
            } 
            
            else {
            
                // cogs is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.cogs.Text = Equipment_inventoryTable.cogs.Format(Equipment_inventoryTable.cogs.DefaultValue, @"C");
            		
            }
            
              this.cogs.TextChanged += cogs_TextChanged;
                               
        }
                
        public virtual void Setcondition_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the condition_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.condition_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcondition_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.condition_idSpecified)
            {
                            
                // If the condition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.condition_id;
                
            }
            else
            {
                
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventoryTable.condition_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatecondition_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcustomer_ein()
        {
            
                    
            // Set the customer_ein TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.customer_ein is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.customer_einSpecified) {
                								
                // If the customer_ein is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.customer_ein);
                                
                this.customer_ein.Text = formattedValue;
                   
            } 
            
            else {
            
                // customer_ein is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.customer_ein.Text = Equipment_inventoryTable.customer_ein.Format(Equipment_inventoryTable.customer_ein.DefaultValue);
            		
            }
            
              this.customer_ein.TextChanged += customer_ein_TextChanged;
                               
        }
                
        public virtual void Setdate_disposed()
        {
            
                    
            // Set the date_disposed TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.date_disposed is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_disposedSpecified) {
                								
                // If the date_disposed is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.date_disposed, @"d");
                                
                this.date_disposed.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_disposed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_disposed.Text = Equipment_inventoryTable.date_disposed.Format(Equipment_inventoryTable.date_disposed.DefaultValue, @"d");
            		
            }
            
              this.date_disposed.TextChanged += date_disposed_TextChanged;
                               
        }
                
        public virtual void Setdate_received()
        {
            
                    
            // Set the date_received TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.date_received is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_receivedSpecified) {
                								
                // If the date_received is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.date_received, @"d");
                                
                this.date_received.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_received is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_received.Text = Equipment_inventoryTable.date_received.Format(Equipment_inventoryTable.date_received.DefaultValue, @"d");
            		
            }
            
              this.date_received.TextChanged += date_received_TextChanged;
                               
        }
                
        public virtual void Setdate_sold()
        {
            
                    
            // Set the date_sold TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.date_sold is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_soldSpecified) {
                								
                // If the date_sold is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.date_sold, @"d");
                                
                this.date_sold.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_sold is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_sold.Text = Equipment_inventoryTable.date_sold.Format(Equipment_inventoryTable.date_sold.DefaultValue, @"d");
            		
            }
            
              this.date_sold.TextChanged += date_sold_TextChanged;
                               
        }
                
        public virtual void Setdescription()
        {
            
                    
            // Set the description TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.description is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.descriptionSpecified) {
                								
                // If the description is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.description);
                                
                this.description.Text = formattedValue;
                   
            } 
            
            else {
            
                // description is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.description.Text = Equipment_inventoryTable.description.Format(Equipment_inventoryTable.description.DefaultValue);
            		
            }
            
              this.description.TextChanged += description_TextChanged;
                               
        }
                
        public virtual void Setdisposition_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the disposition_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.disposition_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setdisposition_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.disposition_idSpecified)
            {
                            
                // If the disposition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.disposition_id.ToString();
                
            }
            else
            {
                
                // disposition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventoryTable.disposition_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatedisposition_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setdoc_num()
        {
            
                    
            // Set the doc_num TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.doc_num is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.doc_numSpecified) {
                								
                // If the doc_num is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.doc_num);
                                
                this.doc_num.Text = formattedValue;
                   
            } 
            
            else {
            
                // doc_num is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.doc_num.Text = Equipment_inventoryTable.doc_num.Format(Equipment_inventoryTable.doc_num.DefaultValue);
            		
            }
            
              this.doc_num.TextChanged += doc_num_TextChanged;
                               
        }
                
        public virtual void Setequipment_phi()
        {
            
                    
            // Set the equipment_phi CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.equipment_phi is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.equipment_phiSpecified) {
                							
                // If the equipment_phi is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.equipment_phi.Checked = this.DataSource.equipment_phi;
                    				
            } else {
            
                // equipment_phi is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.equipment_phi.Checked = Equipment_inventoryTable.equipment_phi.ParseValue(Equipment_inventoryTable.equipment_phi.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setfinal_sale_price()
        {
            
                    
            // Set the final_sale_price TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.final_sale_price is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.final_sale_priceSpecified) {
                								
                // If the final_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.final_sale_price, @"C");
                                
                this.final_sale_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // final_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.final_sale_price.Text = Equipment_inventoryTable.final_sale_price.Format(Equipment_inventoryTable.final_sale_price.DefaultValue, @"C");
            		
            }
            
              this.final_sale_price.TextChanged += final_sale_price_TextChanged;
                               
        }
                
        public virtual void Setinventory_status_id()
        {
            
                    
            // Set the inventory_status_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.inventory_status_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.inventory_status_idSpecified) {
                								
                // If the inventory_status_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.inventory_status_id);
                                
                this.inventory_status_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // inventory_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.inventory_status_id.Text = Equipment_inventoryTable.inventory_status_id.Format(Equipment_inventoryTable.inventory_status_id.DefaultValue);
            		
            }
            
              this.inventory_status_id.TextChanged += inventory_status_id_TextChanged;
                               
        }
                
        public virtual void Setmake_id()
        {
            
                    
            // Set the make_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.make_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.make_idSpecified) {
                								
                // If the make_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.make_id);
                                
                this.make_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // make_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make_id.Text = Equipment_inventoryTable.make_id.Format(Equipment_inventoryTable.make_id.DefaultValue);
            		
            }
            
              this.make_id.TextChanged += make_id_TextChanged;
                               
        }
                
        public virtual void Setmodel_id()
        {
            
                    
            // Set the model_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.model_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.model_idSpecified) {
                								
                // If the model_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.model_id);
                                
                this.model_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // model_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model_id.Text = Equipment_inventoryTable.model_id.Format(Equipment_inventoryTable.model_id.DefaultValue);
            		
            }
            
              this.model_id.TextChanged += model_id_TextChanged;
                               
        }
                
        public virtual void Setother_id_num()
        {
            
                    
            // Set the other_id_num TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.other_id_num is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.other_id_numSpecified) {
                								
                // If the other_id_num is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.other_id_num);
                                
                this.other_id_num.Text = formattedValue;
                   
            } 
            
            else {
            
                // other_id_num is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.other_id_num.Text = Equipment_inventoryTable.other_id_num.Format(Equipment_inventoryTable.other_id_num.DefaultValue);
            		
            }
            
              this.other_id_num.TextChanged += other_id_num_TextChanged;
                               
        }
                
        public virtual void Setpd_date()
        {
            
                    
            // Set the pd_date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.pd_date is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pd_dateSpecified) {
                								
                // If the pd_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.pd_date, @"d");
                                
                this.pd_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // pd_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pd_date.Text = Equipment_inventoryTable.pd_date.Format(Equipment_inventoryTable.pd_date.DefaultValue, @"d");
            		
            }
            
              this.pd_date.TextChanged += pd_date_TextChanged;
                               
        }
                
        public virtual void Setproposed_sale_price()
        {
            
                    
            // Set the proposed_sale_price TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.proposed_sale_price is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.proposed_sale_priceSpecified) {
                								
                // If the proposed_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.proposed_sale_price, @"C");
                                
                this.proposed_sale_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // proposed_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.proposed_sale_price.Text = Equipment_inventoryTable.proposed_sale_price.Format(Equipment_inventoryTable.proposed_sale_price.DefaultValue, @"C");
            		
            }
            
              this.proposed_sale_price.TextChanged += proposed_sale_price_TextChanged;
                               
        }
                
        public virtual void Setpurchase_price()
        {
            
                    
            // Set the purchase_price TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.purchase_price is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchase_priceSpecified) {
                								
                // If the purchase_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.purchase_price, @"C");
                                
                this.purchase_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase_price.Text = Equipment_inventoryTable.purchase_price.Format(Equipment_inventoryTable.purchase_price.DefaultValue, @"C");
            		
            }
            
              this.purchase_price.TextChanged += purchase_price_TextChanged;
                               
        }
                
        public virtual void Setreceived_from_contact_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the received_from_contact_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.received_from_contact_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setreceived_from_contact_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.received_from_contact_idSpecified)
            {
                            
                // If the received_from_contact_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.received_from_contact_id.ToString();
                
            }
            else
            {
                
                // received_from_contact_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventoryTable.received_from_contact_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatereceived_from_contact_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setreceived_from_customer_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the received_from_customer_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.received_from_customer_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setreceived_from_customer_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.received_from_customer_idSpecified)
            {
                            
                // If the received_from_customer_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.received_from_customer_id.ToString();
                
            }
            else
            {
                
                // received_from_customer_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventoryTable.received_from_customer_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatereceived_from_customer_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setrepair_notes()
        {
            
                    
            // Set the repair_notes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.repair_notes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.repair_notesSpecified) {
                								
                // If the repair_notes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.repair_notes);
                                
                this.repair_notes.Text = formattedValue;
                   
            } 
            
            else {
            
                // repair_notes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.repair_notes.Text = Equipment_inventoryTable.repair_notes.Format(Equipment_inventoryTable.repair_notes.DefaultValue);
            		
            }
            
              this.repair_notes.TextChanged += repair_notes_TextChanged;
                               
        }
                
        public virtual void Setrequire_accessories()
        {
            
                    
            // Set the require_accessories CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.require_accessories is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.require_accessoriesSpecified) {
                							
                // If the require_accessories is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.require_accessories.Checked = this.DataSource.require_accessories;
                    				
            } else {
            
                // require_accessories is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.require_accessories.Checked = Equipment_inventoryTable.require_accessories.ParseValue(Equipment_inventoryTable.require_accessories.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setsale_method_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the sale_method_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.sale_method_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setsale_method_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.sale_method_idSpecified)
            {
                            
                // If the sale_method_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.sale_method_id.ToString();
                
            }
            else
            {
                
                // sale_method_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventoryTable.sale_method_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatesale_method_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setserial_number()
        {
            
                    
            // Set the serial_number TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.serial_number is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.serial_number);
                                
                this.serial_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number.Text = Equipment_inventoryTable.serial_number.Format(Equipment_inventoryTable.serial_number.DefaultValue);
            		
            }
            
              this.serial_number.TextChanged += serial_number_TextChanged;
                               
        }
                
        public virtual void Setsold_from_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the sold_from_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.sold_from_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setsold_from_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.sold_from_idSpecified)
            {
                            
                // If the sold_from_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.sold_from_id.ToString();
                
            }
            else
            {
                
                // sold_from_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventoryTable.sold_from_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatesold_from_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setwarehouse_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the warehouse_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.warehouse_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setwarehouse_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.warehouse_idSpecified)
            {
                            
                // If the warehouse_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.warehouse_id.ToString();
                
            }
            else
            {
                
                // warehouse_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventoryTable.warehouse_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatewarehouse_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setwarehouse_location_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the warehouse_location_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.warehouse_location_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setwarehouse_location_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.warehouse_location_idSpecified)
            {
                            
                // If the warehouse_location_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.warehouse_location_id.ToString();
                
            }
            else
            {
                
                // warehouse_location_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventoryTable.warehouse_location_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatewarehouse_location_idDropDownList(selectedValue, 100);              
                
                  
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
                
        public virtual void SetdescriptionLabel()
                  {
                  
                    
        }
                
        public virtual void Setdisposition_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setdoc_numLabel()
                  {
                  
                    
        }
                
        public virtual void Setequipment_phiLabel()
                  {
                  
                    
        }
                
        public virtual void Setfinal_sale_priceLabel()
                  {
                  
                    
        }
                
        public virtual void Setinventory_status_idLabel()
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
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getcategory_id();
            Getcogs();
            Getcondition_id();
            Getcustomer_ein();
            Getdate_disposed();
            Getdate_received();
            Getdate_sold();
            Getdescription();
            Getdisposition_id();
            Getdoc_num();
            Getequipment_phi();
            Getfinal_sale_price();
            Getinventory_status_id();
            Getmake_id();
            Getmodel_id();
            Getother_id_num();
            Getpd_date();
            Getproposed_sale_price();
            Getpurchase_price();
            Getreceived_from_contact_id();
            Getreceived_from_customer_id();
            Getrepair_notes();
            Getrequire_accessories();
            Getsale_method_id();
            Getserial_number();
            Getsold_from_id();
            Getwarehouse_id();
            Getwarehouse_location_id();
        }
        
        
        public virtual void Getcategory_id()
        {
            
            // Retrieve the value entered by the user on the category_id ASP:TextBox, and
            // save it into the category_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.category_id.Text, Equipment_inventoryTable.category_id);							
                          
                      
        }
                
        public virtual void Getcogs()
        {
            
            // Retrieve the value entered by the user on the cogs ASP:TextBox, and
            // save it into the cogs field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.cogs.Text, Equipment_inventoryTable.cogs);							
                          
                      
        }
                
        public virtual void Getcondition_id()
        {
         // Retrieve the value entered by the user on the condition_id ASP:DropDownList, and
            // save it into the condition_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.condition_id), Equipment_inventoryTable.condition_id);			
                			 
        }
                
        public virtual void Getcustomer_ein()
        {
            
            // Retrieve the value entered by the user on the customer_ein ASP:TextBox, and
            // save it into the customer_ein field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.customer_ein.Text, Equipment_inventoryTable.customer_ein);							
                          
                      
        }
                
        public virtual void Getdate_disposed()
        {
            
            // Retrieve the value entered by the user on the date_disposed ASP:TextBox, and
            // save it into the date_disposed field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.date_disposed.Text, Equipment_inventoryTable.date_disposed);							
                          
                      
        }
                
        public virtual void Getdate_received()
        {
            
            // Retrieve the value entered by the user on the date_received ASP:TextBox, and
            // save it into the date_received field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.date_received.Text, Equipment_inventoryTable.date_received);							
                          
                      
        }
                
        public virtual void Getdate_sold()
        {
            
            // Retrieve the value entered by the user on the date_sold ASP:TextBox, and
            // save it into the date_sold field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.date_sold.Text, Equipment_inventoryTable.date_sold);							
                          
                      
        }
                
        public virtual void Getdescription()
        {
            
            // Retrieve the value entered by the user on the description ASP:TextBox, and
            // save it into the description field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.description.Text, Equipment_inventoryTable.description);							
                          
                      
        }
                
        public virtual void Getdisposition_id()
        {
         // Retrieve the value entered by the user on the disposition_id ASP:DropDownList, and
            // save it into the disposition_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.disposition_id), Equipment_inventoryTable.disposition_id);			
                			 
        }
                
        public virtual void Getdoc_num()
        {
            
            // Retrieve the value entered by the user on the doc_num ASP:TextBox, and
            // save it into the doc_num field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.doc_num.Text, Equipment_inventoryTable.doc_num);							
                          
                      
        }
                
        public virtual void Getequipment_phi()
        {	
        		
            // Retrieve the value entered by the user on the equipment_phi ASP:CheckBox, and
            // save it into the equipment_phi field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.equipment_phi = this.equipment_phi.Checked;						
                    
        }
                
        public virtual void Getfinal_sale_price()
        {
            
            // Retrieve the value entered by the user on the final_sale_price ASP:TextBox, and
            // save it into the final_sale_price field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.final_sale_price.Text, Equipment_inventoryTable.final_sale_price);							
                          
                      
        }
                
        public virtual void Getinventory_status_id()
        {
            
            // Retrieve the value entered by the user on the inventory_status_id ASP:TextBox, and
            // save it into the inventory_status_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.inventory_status_id.Text, Equipment_inventoryTable.inventory_status_id);							
                          
                      
        }
                
        public virtual void Getmake_id()
        {
            
            // Retrieve the value entered by the user on the make_id ASP:TextBox, and
            // save it into the make_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.make_id.Text, Equipment_inventoryTable.make_id);							
                          
                      
        }
                
        public virtual void Getmodel_id()
        {
            
            // Retrieve the value entered by the user on the model_id ASP:TextBox, and
            // save it into the model_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.model_id.Text, Equipment_inventoryTable.model_id);							
                          
                      
        }
                
        public virtual void Getother_id_num()
        {
            
            // Retrieve the value entered by the user on the other_id_num ASP:TextBox, and
            // save it into the other_id_num field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.other_id_num.Text, Equipment_inventoryTable.other_id_num);							
                          
                      
        }
                
        public virtual void Getpd_date()
        {
            
            // Retrieve the value entered by the user on the pd_date ASP:TextBox, and
            // save it into the pd_date field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pd_date.Text, Equipment_inventoryTable.pd_date);							
                          
                      
        }
                
        public virtual void Getproposed_sale_price()
        {
            
            // Retrieve the value entered by the user on the proposed_sale_price ASP:TextBox, and
            // save it into the proposed_sale_price field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.proposed_sale_price.Text, Equipment_inventoryTable.proposed_sale_price);							
                          
                      
        }
                
        public virtual void Getpurchase_price()
        {
            
            // Retrieve the value entered by the user on the purchase_price ASP:TextBox, and
            // save it into the purchase_price field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.purchase_price.Text, Equipment_inventoryTable.purchase_price);							
                          
                      
        }
                
        public virtual void Getreceived_from_contact_id()
        {
         // Retrieve the value entered by the user on the received_from_contact_id ASP:DropDownList, and
            // save it into the received_from_contact_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.received_from_contact_id), Equipment_inventoryTable.received_from_contact_id);			
                			 
        }
                
        public virtual void Getreceived_from_customer_id()
        {
         // Retrieve the value entered by the user on the received_from_customer_id ASP:DropDownList, and
            // save it into the received_from_customer_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.received_from_customer_id), Equipment_inventoryTable.received_from_customer_id);			
                			 
        }
                
        public virtual void Getrepair_notes()
        {
            
            // Retrieve the value entered by the user on the repair_notes ASP:TextBox, and
            // save it into the repair_notes field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.repair_notes.Text, Equipment_inventoryTable.repair_notes);							
                          
                      
        }
                
        public virtual void Getrequire_accessories()
        {	
        		
            // Retrieve the value entered by the user on the require_accessories ASP:CheckBox, and
            // save it into the require_accessories field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.require_accessories = this.require_accessories.Checked;						
                    
        }
                
        public virtual void Getsale_method_id()
        {
         // Retrieve the value entered by the user on the sale_method_id ASP:DropDownList, and
            // save it into the sale_method_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.sale_method_id), Equipment_inventoryTable.sale_method_id);			
                			 
        }
                
        public virtual void Getserial_number()
        {
            
            // Retrieve the value entered by the user on the serial_number ASP:TextBox, and
            // save it into the serial_number field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.serial_number.Text, Equipment_inventoryTable.serial_number);							
                          
                      
        }
                
        public virtual void Getsold_from_id()
        {
         // Retrieve the value entered by the user on the sold_from_id ASP:DropDownList, and
            // save it into the sold_from_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.sold_from_id), Equipment_inventoryTable.sold_from_id);			
                			 
        }
                
        public virtual void Getwarehouse_id()
        {
         // Retrieve the value entered by the user on the warehouse_id ASP:DropDownList, and
            // save it into the warehouse_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.warehouse_id), Equipment_inventoryTable.warehouse_id);			
                			 
        }
                
        public virtual void Getwarehouse_location_id()
        {
         // Retrieve the value entered by the user on the warehouse_location_id ASP:DropDownList, and
            // save it into the warehouse_location_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.warehouse_location_id), Equipment_inventoryTable.warehouse_location_id);			
                			 
        }
                

      // To customize, override this method in Equipment_inventoryRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
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
            HttpContext.Current.Session["QueryString in Edit-Equipment-inventory-Mobile"] = recId;
                  
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
        
        public virtual void SetCancelButton()                
              
        {
        
   
        }
            
        public virtual WhereClause CreateWhereClause_condition_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Conditions table.
            // Examples:
            // wc.iAND(ConditionsTable.Condition, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ConditionsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_disposition_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.equipment_inventory_disposition table.
            // Examples:
            // wc.iAND(Equipment_inventory_dispositionTable.equipment_inventory_disposition_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Equipment_inventory_dispositionTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_received_from_contact_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.CustomerContacts table.
            // Examples:
            // wc.iAND(CustomerContactsTable.CustContactKey, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomerContactsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_received_from_customer_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Customers table.
            // Examples:
            // wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomersTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_sale_method_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.equipment_inventory_sale_method table.
            // Examples:
            // wc.iAND(Equipment_inventory_sale_methodTable.equipment_inventory_sale_method_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Equipment_inventory_sale_methodTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_sold_from_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.equipment_inventory_sale_method table.
            // Examples:
            // wc.iAND(Equipment_inventory_sale_methodTable.eqiupment_inventory_sale_method, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Equipment_inventory_sale_methodTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_warehouse_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.warehouse table.
            // Examples:
            // wc.iAND(WarehouseTable.warehouse_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(WarehouseTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_warehouse_location_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.warehouse_location table.
            // Examples:
            // wc.iAND(Warehouse_locationTable.warehouse_location_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Warehouse_locationTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        // Fill the condition_id list.
        protected virtual void Populatecondition_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.condition_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.condition_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_condition_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_condition_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ConditionsTable.Condition, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the condition_idDropDownList.
            ConditionsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = ConditionsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (ConditionsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ConditionSpecified) 
                        {
                            cvalue = itemValue.Condition.ToString();
                            if (counter < maxItems && this.condition_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.condition_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.condition_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.condition_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(ConditionsTable.Condition);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.condition_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.condition_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.condition_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.condition_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.Conditions.Condition = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ConditionsTable.Condition, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ConditionsRecord[] rc = ConditionsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ConditionsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ConditionSpecified)
                            cvalue = itemValue.Condition.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.condition_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.condition_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.condition_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ConditionsTable.Condition);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.condition_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the disposition_id list.
        protected virtual void Populatedisposition_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.disposition_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.disposition_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_disposition_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_disposition_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Equipment_inventory_dispositionTable.equipment_inventory_disposition, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the disposition_idDropDownList.
            Equipment_inventory_dispositionRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Equipment_inventory_dispositionTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Equipment_inventory_dispositionRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.equipment_inventory_disposition_idSpecified) 
                        {
                            cvalue = itemValue.equipment_inventory_disposition_id.ToString().ToString();
                            if (counter < maxItems && this.disposition_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.disposition_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.disposition_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.disposition_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Equipment_inventory_dispositionTable.equipment_inventory_disposition_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.disposition_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.disposition_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.disposition_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.disposition_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.equipment_inventory_disposition.equipment_inventory_disposition_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Equipment_inventory_dispositionTable.equipment_inventory_disposition_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Equipment_inventory_dispositionRecord[] rc = Equipment_inventory_dispositionTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Equipment_inventory_dispositionRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.equipment_inventory_disposition_idSpecified)
                            cvalue = itemValue.equipment_inventory_disposition_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.disposition_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.disposition_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.disposition_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Equipment_inventory_dispositionTable.equipment_inventory_disposition_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.disposition_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the received_from_contact_id list.
        protected virtual void Populatereceived_from_contact_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.received_from_contact_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.received_from_contact_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_received_from_contact_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_received_from_contact_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomerContactsTable.CustContactName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the received_from_contact_idDropDownList.
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
                            if (counter < maxItems && this.received_from_contact_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_contact_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.received_from_contact_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.received_from_contact_id);
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

                                ListItem dupItem = this.received_from_contact_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.received_from_contact_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.received_from_contact_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.received_from_contact_id, selectedValue))
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
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_contact_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.received_from_contact_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.received_from_contact_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CustomerContactsTable.CustContactKey);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.received_from_contact_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the received_from_customer_id list.
        protected virtual void Populatereceived_from_customer_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.received_from_customer_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.received_from_customer_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_received_from_customer_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_received_from_customer_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the received_from_customer_idDropDownList.
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
                            if (counter < maxItems && this.received_from_customer_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_customer_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.received_from_customer_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.received_from_customer_id);
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

                                ListItem dupItem = this.received_from_customer_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.received_from_customer_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.received_from_customer_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.received_from_customer_id, selectedValue))
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
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_customer_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.received_from_customer_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.received_from_customer_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CustomersTable.CustNo);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.received_from_customer_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the sale_method_id list.
        protected virtual void Populatesale_method_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.sale_method_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.sale_method_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_sale_method_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_sale_method_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Equipment_inventory_sale_methodTable.eqiupment_inventory_sale_method, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the sale_method_idDropDownList.
            Equipment_inventory_sale_methodRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Equipment_inventory_sale_methodTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Equipment_inventory_sale_methodRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.equipment_inventory_sale_method_idSpecified) 
                        {
                            cvalue = itemValue.equipment_inventory_sale_method_id.ToString().ToString();
                            if (counter < maxItems && this.sale_method_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sale_method_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.sale_method_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.sale_method_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Equipment_inventory_sale_methodTable.equipment_inventory_sale_method_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.sale_method_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.sale_method_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.sale_method_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.sale_method_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.equipment_inventory_sale_method.equipment_inventory_sale_method_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Equipment_inventory_sale_methodTable.equipment_inventory_sale_method_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Equipment_inventory_sale_methodRecord[] rc = Equipment_inventory_sale_methodTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Equipment_inventory_sale_methodRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.equipment_inventory_sale_method_idSpecified)
                            cvalue = itemValue.equipment_inventory_sale_method_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sale_method_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.sale_method_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.sale_method_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Equipment_inventory_sale_methodTable.equipment_inventory_sale_method_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.sale_method_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the sold_from_id list.
        protected virtual void Populatesold_from_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.sold_from_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.sold_from_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_sold_from_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_sold_from_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Equipment_inventory_sale_methodTable.equipment_inventory_sale_method_id, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the sold_from_idDropDownList.
            Equipment_inventory_sale_methodRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Equipment_inventory_sale_methodTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Equipment_inventory_sale_methodRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.equipment_inventory_sale_method_idSpecified) 
                        {
                            cvalue = itemValue.equipment_inventory_sale_method_id.ToString().ToString();
                            if (counter < maxItems && this.sold_from_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sold_from_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.sold_from_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.sold_from_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Equipment_inventory_sale_methodTable.eqiupment_inventory_sale_method);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.sold_from_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.sold_from_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.sold_from_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.sold_from_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.equipment_inventory_sale_method.equipment_inventory_sale_method_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Equipment_inventory_sale_methodTable.equipment_inventory_sale_method_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Equipment_inventory_sale_methodRecord[] rc = Equipment_inventory_sale_methodTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Equipment_inventory_sale_methodRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.equipment_inventory_sale_method_idSpecified)
                            cvalue = itemValue.equipment_inventory_sale_method_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sold_from_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.sold_from_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.sold_from_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Equipment_inventory_sale_methodTable.eqiupment_inventory_sale_method);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.sold_from_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the warehouse_id list.
        protected virtual void Populatewarehouse_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.warehouse_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.warehouse_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_warehouse_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_warehouse_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(WarehouseTable.warehouse_name, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the warehouse_idDropDownList.
            WarehouseRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = WarehouseTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (WarehouseRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.warehouse_idSpecified) 
                        {
                            cvalue = itemValue.warehouse_id.ToString().ToString();
                            if (counter < maxItems && this.warehouse_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.warehouse_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.warehouse_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(WarehouseTable.warehouse_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.warehouse_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.warehouse_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.warehouse_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.warehouse_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.warehouse.warehouse_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(WarehouseTable.warehouse_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    WarehouseRecord[] rc = WarehouseTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        WarehouseRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.warehouse_idSpecified)
                            cvalue = itemValue.warehouse_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.warehouse_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.warehouse_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(WarehouseTable.warehouse_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.warehouse_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the warehouse_location_id list.
        protected virtual void Populatewarehouse_location_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.warehouse_location_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.warehouse_location_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_warehouse_location_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_warehouse_location_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Warehouse_locationTable.warehouse_location, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the warehouse_location_idDropDownList.
            Warehouse_locationRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Warehouse_locationTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Warehouse_locationRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.warehouse_location_idSpecified) 
                        {
                            cvalue = itemValue.warehouse_location_id.ToString().ToString();
                            if (counter < maxItems && this.warehouse_location_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_location_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.warehouse_location_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.warehouse_location_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Warehouse_locationTable.warehouse_location_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.warehouse_location_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.warehouse_location_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.warehouse_location_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.warehouse_location_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.warehouse_location.warehouse_location_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Warehouse_locationTable.warehouse_location_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Warehouse_locationRecord[] rc = Warehouse_locationTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Warehouse_locationRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.warehouse_location_idSpecified)
                            cvalue = itemValue.warehouse_location_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_location_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventoryTable.warehouse_location_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventoryTable.GetDFKA(itemValue, Equipment_inventoryTable.warehouse_location_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Warehouse_locationTable.warehouse_location_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.warehouse_location_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
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
            
            
        
        protected virtual void condition_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[condition_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[condition_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.condition_id.Items.Add(new ListItem(displayText, val));
	            this.condition_id.SelectedIndex = this.condition_id.Items.Count - 1;
	            this.Page.Session.Remove(condition_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(condition_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void disposition_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[disposition_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[disposition_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.disposition_id.Items.Add(new ListItem(displayText, val));
	            this.disposition_id.SelectedIndex = this.disposition_id.Items.Count - 1;
	            this.Page.Session.Remove(disposition_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(disposition_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void received_from_contact_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[received_from_contact_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[received_from_contact_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.received_from_contact_id.Items.Add(new ListItem(displayText, val));
	            this.received_from_contact_id.SelectedIndex = this.received_from_contact_id.Items.Count - 1;
	            this.Page.Session.Remove(received_from_contact_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(received_from_contact_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void received_from_customer_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[received_from_customer_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[received_from_customer_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.received_from_customer_id.Items.Add(new ListItem(displayText, val));
	            this.received_from_customer_id.SelectedIndex = this.received_from_customer_id.Items.Count - 1;
	            this.Page.Session.Remove(received_from_customer_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(received_from_customer_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void sale_method_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[sale_method_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[sale_method_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.sale_method_id.Items.Add(new ListItem(displayText, val));
	            this.sale_method_id.SelectedIndex = this.sale_method_id.Items.Count - 1;
	            this.Page.Session.Remove(sale_method_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(sale_method_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void sold_from_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[sold_from_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[sold_from_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.sold_from_id.Items.Add(new ListItem(displayText, val));
	            this.sold_from_id.SelectedIndex = this.sold_from_id.Items.Count - 1;
	            this.Page.Session.Remove(sold_from_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(sold_from_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void warehouse_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[warehouse_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[warehouse_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.warehouse_id.Items.Add(new ListItem(displayText, val));
	            this.warehouse_id.SelectedIndex = this.warehouse_id.Items.Count - 1;
	            this.Page.Session.Remove(warehouse_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(warehouse_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void warehouse_location_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[warehouse_location_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[warehouse_location_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.warehouse_location_id.Items.Add(new ListItem(displayText, val));
	            this.warehouse_location_id.SelectedIndex = this.warehouse_location_id.Items.Count - 1;
	            this.Page.Session.Remove(warehouse_location_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(warehouse_location_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void equipment_phi_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void require_accessories_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void category_id_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void cogs_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void customer_ein_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void date_disposed_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void date_received_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void date_sold_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void description_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void doc_num_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void final_sale_price_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void inventory_status_id_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void make_id_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void model_id_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void other_id_num_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pd_date_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void proposed_sale_price_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void purchase_price_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void repair_notes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void serial_number_TextChanged(object sender, EventArgs args)
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
        
        public System.Web.UI.WebControls.ImageButton CancelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CancelButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox category_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal category_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox cogs {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cogs");
            }
        }
            
        public System.Web.UI.WebControls.Literal cogsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "cogsLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList condition_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal condition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox customer_ein {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_ein");
            }
        }
            
        public System.Web.UI.WebControls.Literal customer_einLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "customer_einLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox date_disposed {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_disposed");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_disposedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_disposedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox date_received {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_received");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_receivedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_receivedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox date_sold {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_sold");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_soldLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_soldLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox description {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "description");
            }
        }
            
        public System.Web.UI.WebControls.Literal descriptionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "descriptionLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList disposition_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal disposition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox doc_num {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "doc_num");
            }
        }
            
        public System.Web.UI.WebControls.Literal doc_numLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "doc_numLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox equipment_phi {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_phi");
            }
        }
            
        public System.Web.UI.WebControls.Literal equipment_phiLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_phiLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox final_sale_price {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_sale_price");
            }
        }
            
        public System.Web.UI.WebControls.Literal final_sale_priceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_sale_priceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox inventory_status_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_status_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal inventory_status_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_status_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox make_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal make_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox model_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal model_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox other_id_num {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "other_id_num");
            }
        }
            
        public System.Web.UI.WebControls.Literal other_id_numLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "other_id_numLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox pd_date {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pd_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal pd_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pd_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox proposed_sale_price {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposed_sale_price");
            }
        }
            
        public System.Web.UI.WebControls.Literal proposed_sale_priceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposed_sale_priceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox purchase_price {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_price");
            }
        }
            
        public System.Web.UI.WebControls.Literal purchase_priceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_priceLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList received_from_contact_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_contact_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal received_from_contact_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_contact_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList received_from_customer_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_customer_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal received_from_customer_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_customer_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox repair_notes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_notes");
            }
        }
            
        public System.Web.UI.WebControls.Literal repair_notesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "repair_notesLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox require_accessories {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "require_accessories");
            }
        }
            
        public System.Web.UI.WebControls.Literal require_accessoriesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "require_accessoriesLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList sale_method_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sale_method_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal sale_method_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sale_method_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox serial_number {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_number");
            }
        }
            
        public System.Web.UI.WebControls.Literal serial_numberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_numberLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList sold_from_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sold_from_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal sold_from_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sold_from_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList warehouse_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList warehouse_location_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_location_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_idLabel");
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

  