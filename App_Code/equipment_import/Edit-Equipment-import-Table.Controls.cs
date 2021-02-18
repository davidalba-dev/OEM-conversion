
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Equipment_import_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Equipment_import_Table
{
  

#region "Section 1: Place your customizations here."

    
public class Equipment_importTableControlRow : BaseEquipment_importTableControlRow
{
      
        // The BaseEquipment_importTableControlRow implements code for a ROW within the
        // the Equipment_importTableControl table.  The BaseEquipment_importTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Equipment_importTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Equipment_importTableControl : BaseEquipment_importTableControl
{
    // The BaseEquipment_importTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Equipment_importTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

public class Equipment_import_batchRecordControl : BaseEquipment_import_batchRecordControl
{
      
        // The BaseEquipment_import_batchRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}
//public class Vw_max_equip_import_batch_idRecordControl1 : BaseVw_max_equip_import_batch_idRecordControl1
//{
//      
//        // The BaseVw_max_equip_import_batch_idRecordControl1 implements the LoadData, DataBind and other
//        // methods to load and display the data in a table control.
//
//        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
//        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
//        
//}
//
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_importTableControlRow control on the Edit_Equipment_import_Table page.
// Do not modify this class. Instead override any method in Equipment_importTableControlRow.
public class BaseEquipment_importTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_importTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_importTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Equipment_importTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
              this.address.TextChanged += address_TextChanged;
            
              this.address_state.TextChanged += address_state_TextChanged;
            
              this.asset_tag.TextChanged += asset_tag_TextChanged;
            
              this.building.TextChanged += building_TextChanged;
            
              this.category.TextChanged += category_TextChanged;
            
              this.city.TextChanged += city_TextChanged;
            
              this.close_time.TextChanged += close_time_TextChanged;
            
              this.comments.TextChanged += comments_TextChanged;
            
              this.contact_first.TextChanged += contact_first_TextChanged;
            
              this.contact_last.TextChanged += contact_last_TextChanged;
            
              this.date_of_next_pm.TextChanged += date_of_next_pm_TextChanged;
            
              this.department.TextChanged += department_TextChanged;
            
              this.equip_import_batch_id.TextChanged += equip_import_batch_id_TextChanged;
            
              this.model.TextChanged += model_TextChanged;
            
              this.open_time.TextChanged += open_time_TextChanged;
            
              this.phone_number.TextChanged += phone_number_TextChanged;
            
              this.pm_frequency.TextChanged += pm_frequency_TextChanged;
            
              this.pm_last_fix_date.TextChanged += pm_last_fix_date_TextChanged;
            
              this.pm_purchase_order.TextChanged += pm_purchase_order_TextChanged;
            
              this.pm_purchase_order1.TextChanged += pm_purchase_order1_TextChanged;
            
              this.po_date.TextChanged += po_date_TextChanged;
            
              this.serial_number.TextChanged += serial_number_TextChanged;
            
              this.serv_rep_parts_po.TextChanged += serv_rep_parts_po_TextChanged;
            
              this.service_tech.TextChanged += service_tech_TextChanged;
            
              this.state.TextChanged += state_TextChanged;
            
              this.status.TextChanged += status_TextChanged;
            
              this.zipcode.TextChanged += zipcode_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_importTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseEquipment_importTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Equipment_importRecord();
            
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
        
                Setaddress();
                Setaddress_state();
                Setasset_tag();
                Setbuilding();
                Setcategory();
                Setcity();
                Setclose_time();
                Setcomments();
                Setcontact_first();
                Setcontact_last();
                Setdate_of_next_pm();
                
                Setdepartment();
                
                Setequip_import_batch_id();
                Setmodel();
                Setopen_time();
                Setphone_number();
                Setpm_frequency();
                Setpm_last_fix_date();
                Setpm_purchase_order();
                Setpm_purchase_order1();
                Setpo_date();
                Setserial_number();
                Setserv_rep_parts_po();
                Setservice_tech();
                Setstate();
                Setstatus();
                Setzipcode();
                SetDeleteRowButton();
              
                SetEditRowButton();
              

      

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
        
        
        public virtual void Setaddress()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.address.ID))
            {
            
                this.address.Text = this.PreviousUIData[this.address.ID].ToString();
              
                return;
            }
            
                    
            // Set the address TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.address is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.addressSpecified) {
                								
                // If the address is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.address);
                                
                this.address.Text = formattedValue;
                   
            } 
            
            else {
            
                // address is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.address.Text = Equipment_importTable.address.Format(Equipment_importTable.address.DefaultValue);
            		
            }
            
              this.address.TextChanged += address_TextChanged;
                               
        }
                
        public virtual void Setaddress_state()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.address_state.ID))
            {
            
                this.address_state.Text = this.PreviousUIData[this.address_state.ID].ToString();
              
                return;
            }
            
                    
            // Set the address_state TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.address_state is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.address_stateSpecified) {
                								
                // If the address_state is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.address_state);
                                
                this.address_state.Text = formattedValue;
                   
            } 
            
            else {
            
                // address_state is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.address_state.Text = Equipment_importTable.address_state.Format(Equipment_importTable.address_state.DefaultValue);
            		
            }
            
              this.address_state.TextChanged += address_state_TextChanged;
                               
        }
                
        public virtual void Setasset_tag()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.asset_tag.ID))
            {
            
                this.asset_tag.Text = this.PreviousUIData[this.asset_tag.ID].ToString();
              
                return;
            }
            
                    
            // Set the asset_tag TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.asset_tag is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.asset_tagSpecified) {
                								
                // If the asset_tag is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.asset_tag);
                                
                this.asset_tag.Text = formattedValue;
                   
            } 
            
            else {
            
                // asset_tag is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.asset_tag.Text = Equipment_importTable.asset_tag.Format(Equipment_importTable.asset_tag.DefaultValue);
            		
            }
            
              this.asset_tag.TextChanged += asset_tag_TextChanged;
                               
        }
                
        public virtual void Setbuilding()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.building.ID))
            {
            
                this.building.Text = this.PreviousUIData[this.building.ID].ToString();
              
                return;
            }
            
                    
            // Set the building TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.building is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.buildingSpecified) {
                								
                // If the building is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.building);
                                
                this.building.Text = formattedValue;
                   
            } 
            
            else {
            
                // building is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.building.Text = Equipment_importTable.building.Format(Equipment_importTable.building.DefaultValue);
            		
            }
            
              this.building.TextChanged += building_TextChanged;
                               
        }
                
        public virtual void Setcategory()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.category.ID))
            {
            
                this.category.Text = this.PreviousUIData[this.category.ID].ToString();
              
                return;
            }
            
                    
            // Set the category TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.category is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.categorySpecified) {
                								
                // If the category is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.category);
                                
                this.category.Text = formattedValue;
                   
            } 
            
            else {
            
                // category is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.category.Text = Equipment_importTable.category.Format(Equipment_importTable.category.DefaultValue);
            		
            }
            
              this.category.TextChanged += category_TextChanged;
                               
        }
                
        public virtual void Setcity()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.city.ID))
            {
            
                this.city.Text = this.PreviousUIData[this.city.ID].ToString();
              
                return;
            }
            
                    
            // Set the city TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.city is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.citySpecified) {
                								
                // If the city is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.city);
                                
                this.city.Text = formattedValue;
                   
            } 
            
            else {
            
                // city is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.city.Text = Equipment_importTable.city.Format(Equipment_importTable.city.DefaultValue);
            		
            }
            
              this.city.TextChanged += city_TextChanged;
                               
        }
                
        public virtual void Setclose_time()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.close_time.ID))
            {
            
                this.close_time.Text = this.PreviousUIData[this.close_time.ID].ToString();
              
                return;
            }
            
                    
            // Set the close_time TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.close_time is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.close_timeSpecified) {
                								
                // If the close_time is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.close_time, @"t");
                                
                this.close_time.Text = formattedValue;
                   
            } 
            
            else {
            
                // close_time is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.close_time.Text = Equipment_importTable.close_time.Format(Equipment_importTable.close_time.DefaultValue, @"t");
            		
            }
            
              this.close_time.TextChanged += close_time_TextChanged;
                               
        }
                
        public virtual void Setcomments()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.comments.ID))
            {
            
                this.comments.Text = this.PreviousUIData[this.comments.ID].ToString();
              
                return;
            }
            
                    
            // Set the comments TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.comments is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.commentsSpecified) {
                								
                // If the comments is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.comments);
                                
                this.comments.Text = formattedValue;
                   
            } 
            
            else {
            
                // comments is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.comments.Text = Equipment_importTable.comments.Format(Equipment_importTable.comments.DefaultValue);
            		
            }
            
              this.comments.TextChanged += comments_TextChanged;
                               
        }
                
        public virtual void Setcontact_first()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.contact_first.ID))
            {
            
                this.contact_first.Text = this.PreviousUIData[this.contact_first.ID].ToString();
              
                return;
            }
            
                    
            // Set the contact_first TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.contact_first is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.contact_firstSpecified) {
                								
                // If the contact_first is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.contact_first);
                                
                this.contact_first.Text = formattedValue;
                   
            } 
            
            else {
            
                // contact_first is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.contact_first.Text = Equipment_importTable.contact_first.Format(Equipment_importTable.contact_first.DefaultValue);
            		
            }
            
              this.contact_first.TextChanged += contact_first_TextChanged;
                               
        }
                
        public virtual void Setcontact_last()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.contact_last.ID))
            {
            
                this.contact_last.Text = this.PreviousUIData[this.contact_last.ID].ToString();
              
                return;
            }
            
                    
            // Set the contact_last TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.contact_last is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.contact_lastSpecified) {
                								
                // If the contact_last is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.contact_last);
                                
                this.contact_last.Text = formattedValue;
                   
            } 
            
            else {
            
                // contact_last is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.contact_last.Text = Equipment_importTable.contact_last.Format(Equipment_importTable.contact_last.DefaultValue);
            		
            }
            
              this.contact_last.TextChanged += contact_last_TextChanged;
                               
        }
                
        public virtual void Setdate_of_next_pm()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.date_of_next_pm.ID))
            {
            
                this.date_of_next_pm.Text = this.PreviousUIData[this.date_of_next_pm.ID].ToString();
              
                return;
            }
            
                    
            // Set the date_of_next_pm TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.date_of_next_pm is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_of_next_pmSpecified) {
                								
                // If the date_of_next_pm is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.date_of_next_pm, @"d");
                                
                this.date_of_next_pm.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_of_next_pm is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_of_next_pm.Text = Equipment_importTable.date_of_next_pm.Format(Equipment_importTable.date_of_next_pm.DefaultValue, @"d");
            		
            }
            
              this.date_of_next_pm.TextChanged += date_of_next_pm_TextChanged;
                               
        }
                
        public virtual void Setdepartment()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.department.ID))
            {
            
                this.department.Text = this.PreviousUIData[this.department.ID].ToString();
              
                return;
            }
            
                    
            // Set the department TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.department is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.departmentSpecified) {
                								
                // If the department is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.department);
                                
                this.department.Text = formattedValue;
                   
            } 
            
            else {
            
                // department is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.department.Text = Equipment_importTable.department.Format(Equipment_importTable.department.DefaultValue);
            		
            }
            
              this.department.TextChanged += department_TextChanged;
                               
        }
                
        public virtual void Setequip_import_batch_id()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.equip_import_batch_id.ID))
            {
            
                this.equip_import_batch_id.Text = this.PreviousUIData[this.equip_import_batch_id.ID].ToString();
              
                return;
            }
            
                    
            // Set the equip_import_batch_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.equip_import_batch_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.equip_import_batch_idSpecified) {
                								
                // If the equip_import_batch_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.equip_import_batch_id.ToString();
                            
                this.equip_import_batch_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // equip_import_batch_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.equip_import_batch_id.Text = Equipment_importTable.equip_import_batch_id.DefaultValue;
            		
            }
            
              this.equip_import_batch_id.TextChanged += equip_import_batch_id_TextChanged;
                               
        }
                
        public virtual void Setmodel()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.model.ID))
            {
            
                this.model.Text = this.PreviousUIData[this.model.ID].ToString();
              
                return;
            }
            
                    
            // Set the model TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.model is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.modelSpecified) {
                								
                // If the model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.model);
                                
                this.model.Text = formattedValue;
                   
            } 
            
            else {
            
                // model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model.Text = Equipment_importTable.model.Format(Equipment_importTable.model.DefaultValue);
            		
            }
            
              this.model.TextChanged += model_TextChanged;
                               
        }
                
        public virtual void Setopen_time()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.open_time.ID))
            {
            
                this.open_time.Text = this.PreviousUIData[this.open_time.ID].ToString();
              
                return;
            }
            
                    
            // Set the open_time TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.open_time is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.open_timeSpecified) {
                								
                // If the open_time is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.open_time, @"t");
                                
                this.open_time.Text = formattedValue;
                   
            } 
            
            else {
            
                // open_time is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.open_time.Text = Equipment_importTable.open_time.Format(Equipment_importTable.open_time.DefaultValue, @"t");
            		
            }
            
              this.open_time.TextChanged += open_time_TextChanged;
                               
        }
                
        public virtual void Setphone_number()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.phone_number.ID))
            {
            
                this.phone_number.Text = this.PreviousUIData[this.phone_number.ID].ToString();
              
                return;
            }
            
                    
            // Set the phone_number TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.phone_number is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.phone_numberSpecified) {
                								
                // If the phone_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.phone_number);
                                
                this.phone_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // phone_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.phone_number.Text = Equipment_importTable.phone_number.Format(Equipment_importTable.phone_number.DefaultValue);
            		
            }
            
              this.phone_number.TextChanged += phone_number_TextChanged;
                               
        }
                
        public virtual void Setpm_frequency()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.pm_frequency.ID))
            {
            
                this.pm_frequency.Text = this.PreviousUIData[this.pm_frequency.ID].ToString();
              
                return;
            }
            
                    
            // Set the pm_frequency TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.pm_frequency is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pm_frequencySpecified) {
                								
                // If the pm_frequency is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.pm_frequency);
                                
                this.pm_frequency.Text = formattedValue;
                   
            } 
            
            else {
            
                // pm_frequency is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pm_frequency.Text = Equipment_importTable.pm_frequency.Format(Equipment_importTable.pm_frequency.DefaultValue);
            		
            }
            
              this.pm_frequency.TextChanged += pm_frequency_TextChanged;
                               
        }
                
        public virtual void Setpm_last_fix_date()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.pm_last_fix_date.ID))
            {
            
                this.pm_last_fix_date.Text = this.PreviousUIData[this.pm_last_fix_date.ID].ToString();
              
                return;
            }
            
                    
            // Set the pm_last_fix_date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.pm_last_fix_date is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pm_last_fix_dateSpecified) {
                								
                // If the pm_last_fix_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.pm_last_fix_date, @"d");
                                
                this.pm_last_fix_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // pm_last_fix_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pm_last_fix_date.Text = Equipment_importTable.pm_last_fix_date.Format(Equipment_importTable.pm_last_fix_date.DefaultValue, @"d");
            		
            }
            
              this.pm_last_fix_date.TextChanged += pm_last_fix_date_TextChanged;
                               
        }
                
        public virtual void Setpm_purchase_order()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.pm_purchase_order.ID))
            {
            
                this.pm_purchase_order.Text = this.PreviousUIData[this.pm_purchase_order.ID].ToString();
              
                return;
            }
            
                    
            // Set the pm_purchase_order TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.pm_purchase_order is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pm_purchase_orderSpecified) {
                								
                // If the pm_purchase_order is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.pm_purchase_order);
                                
                this.pm_purchase_order.Text = formattedValue;
                   
            } 
            
            else {
            
                // pm_purchase_order is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pm_purchase_order.Text = Equipment_importTable.pm_purchase_order.Format(Equipment_importTable.pm_purchase_order.DefaultValue);
            		
            }
            
              this.pm_purchase_order.TextChanged += pm_purchase_order_TextChanged;
                               
        }
                
        public virtual void Setpm_purchase_order1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.pm_purchase_order1.ID))
            {
            
                this.pm_purchase_order1.Text = this.PreviousUIData[this.pm_purchase_order1.ID].ToString();
              
                return;
            }
            
                    
            // Set the pm_purchase_order TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.pm_purchase_order1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.pm_purchase_orderSpecified) {
                								
                // If the pm_purchase_order is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.pm_purchase_order);
                                
                this.pm_purchase_order1.Text = formattedValue;
                   
            } 
            
            else {
            
                // pm_purchase_order is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.pm_purchase_order1.Text = Equipment_importTable.pm_purchase_order.Format(Equipment_importTable.pm_purchase_order.DefaultValue);
            		
            }
            
              this.pm_purchase_order1.TextChanged += pm_purchase_order1_TextChanged;
                               
        }
                
        public virtual void Setpo_date()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.po_date.ID))
            {
            
                this.po_date.Text = this.PreviousUIData[this.po_date.ID].ToString();
              
                return;
            }
            
                    
            // Set the po_date TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.po_date is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.po_dateSpecified) {
                								
                // If the po_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.po_date, @"d");
                                
                this.po_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // po_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.po_date.Text = Equipment_importTable.po_date.Format(Equipment_importTable.po_date.DefaultValue, @"d");
            		
            }
            
              this.po_date.TextChanged += po_date_TextChanged;
                               
        }
                
        public virtual void Setserial_number()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.serial_number.ID))
            {
            
                this.serial_number.Text = this.PreviousUIData[this.serial_number.ID].ToString();
              
                return;
            }
            
                    
            // Set the serial_number TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.serial_number is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.serial_number);
                                
                this.serial_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number.Text = Equipment_importTable.serial_number.Format(Equipment_importTable.serial_number.DefaultValue);
            		
            }
            
              this.serial_number.TextChanged += serial_number_TextChanged;
                               
        }
                
        public virtual void Setserv_rep_parts_po()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.serv_rep_parts_po.ID))
            {
            
                this.serv_rep_parts_po.Text = this.PreviousUIData[this.serv_rep_parts_po.ID].ToString();
              
                return;
            }
            
                    
            // Set the serv_rep_parts_po TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.serv_rep_parts_po is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serv_rep_parts_poSpecified) {
                								
                // If the serv_rep_parts_po is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.serv_rep_parts_po);
                                
                this.serv_rep_parts_po.Text = formattedValue;
                   
            } 
            
            else {
            
                // serv_rep_parts_po is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serv_rep_parts_po.Text = Equipment_importTable.serv_rep_parts_po.Format(Equipment_importTable.serv_rep_parts_po.DefaultValue);
            		
            }
            
              this.serv_rep_parts_po.TextChanged += serv_rep_parts_po_TextChanged;
                               
        }
                
        public virtual void Setservice_tech()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.service_tech.ID))
            {
            
                this.service_tech.Text = this.PreviousUIData[this.service_tech.ID].ToString();
              
                return;
            }
            
                    
            // Set the service_tech TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.service_tech is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.service_techSpecified) {
                								
                // If the service_tech is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.service_tech);
                                
                this.service_tech.Text = formattedValue;
                   
            } 
            
            else {
            
                // service_tech is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.service_tech.Text = Equipment_importTable.service_tech.Format(Equipment_importTable.service_tech.DefaultValue);
            		
            }
            
              this.service_tech.TextChanged += service_tech_TextChanged;
                               
        }
                
        public virtual void Setstate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.state.ID))
            {
            
                this.state.Text = this.PreviousUIData[this.state.ID].ToString();
              
                return;
            }
            
                    
            // Set the state TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.state is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.stateSpecified) {
                								
                // If the state is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.state);
                                
                this.state.Text = formattedValue;
                   
            } 
            
            else {
            
                // state is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.state.Text = Equipment_importTable.state.Format(Equipment_importTable.state.DefaultValue);
            		
            }
            
              this.state.TextChanged += state_TextChanged;
                               
        }
                
        public virtual void Setstatus()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.status.ID))
            {
            
                this.status.Text = this.PreviousUIData[this.status.ID].ToString();
              
                return;
            }
            
                    
            // Set the status TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.status is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.statusSpecified) {
                								
                // If the status is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.status);
                                
                this.status.Text = formattedValue;
                   
            } 
            
            else {
            
                // status is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.status.Text = Equipment_importTable.status.Format(Equipment_importTable.status.DefaultValue);
            		
            }
            
              this.status.TextChanged += status_TextChanged;
                               
        }
                
        public virtual void Setzipcode()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.zipcode.ID))
            {
            
                this.zipcode.Text = this.PreviousUIData[this.zipcode.ID].ToString();
              
                return;
            }
            
                    
            // Set the zipcode TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import record retrieved from the database.
            // this.zipcode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.zipcodeSpecified) {
                								
                // If the zipcode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_importTable.zipcode);
                                
                this.zipcode.Text = formattedValue;
                   
            } 
            
            else {
            
                // zipcode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.zipcode.Text = Equipment_importTable.zipcode.Format(Equipment_importTable.zipcode.DefaultValue);
            		
            }
            
              this.zipcode.TextChanged += zipcode_TextChanged;
                               
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
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((Equipment_importTableControl)MiscUtils.GetParentControlObject(this, "Equipment_importTableControl")).DataChanged = true;
                ((Equipment_importTableControl)MiscUtils.GetParentControlObject(this, "Equipment_importTableControl")).ResetData = true;
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
        
            Getaddress();
            Getaddress_state();
            Getasset_tag();
            Getbuilding();
            Getcategory();
            Getcity();
            Getclose_time();
            Getcomments();
            Getcontact_first();
            Getcontact_last();
            Getdate_of_next_pm();
            Getdepartment();
            Getequip_import_batch_id();
            Getmodel();
            Getopen_time();
            Getphone_number();
            Getpm_frequency();
            Getpm_last_fix_date();
            Getpm_purchase_order();
            Getpm_purchase_order1();
            Getpo_date();
            Getserial_number();
            Getserv_rep_parts_po();
            Getservice_tech();
            Getstate();
            Getstatus();
            Getzipcode();
        }
        
        
        public virtual void Getaddress()
        {
            
            // Retrieve the value entered by the user on the address ASP:TextBox, and
            // save it into the address field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.address.Text, Equipment_importTable.address);							
                          
                      
        }
                
        public virtual void Getaddress_state()
        {
            
            // Retrieve the value entered by the user on the address_state ASP:TextBox, and
            // save it into the address_state field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.address_state.Text, Equipment_importTable.address_state);							
                          
                      
        }
                
        public virtual void Getasset_tag()
        {
            
        }
                
        public virtual void Getbuilding()
        {
            
        }
                
        public virtual void Getcategory()
        {
            
        }
                
        public virtual void Getcity()
        {
            
            // Retrieve the value entered by the user on the city ASP:TextBox, and
            // save it into the city field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.city.Text, Equipment_importTable.city);							
                          
                      
        }
                
        public virtual void Getclose_time()
        {
            
            // Retrieve the value entered by the user on the close_time ASP:TextBox, and
            // save it into the close_time field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.close_time.Text, Equipment_importTable.close_time);							
                          
                      
        }
                
        public virtual void Getcomments()
        {
            
            // Retrieve the value entered by the user on the comments ASP:TextBox, and
            // save it into the comments field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.comments.Text, Equipment_importTable.comments);							
                          
                      
        }
                
        public virtual void Getcontact_first()
        {
            
            // Retrieve the value entered by the user on the contact_first ASP:TextBox, and
            // save it into the contact_first field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.contact_first.Text, Equipment_importTable.contact_first);							
                          
                      
        }
                
        public virtual void Getcontact_last()
        {
            
            // Retrieve the value entered by the user on the contact_last ASP:TextBox, and
            // save it into the contact_last field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.contact_last.Text, Equipment_importTable.contact_last);							
                          
                      
        }
                
        public virtual void Getdate_of_next_pm()
        {
            
            // Retrieve the value entered by the user on the date_of_next_pm ASP:TextBox, and
            // save it into the date_of_next_pm field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.date_of_next_pm.Text, Equipment_importTable.date_of_next_pm);							
                          
                      
        }
                
        public virtual void Getdepartment()
        {
            
        }
                
        public virtual void Getequip_import_batch_id()
        {
            
            // Retrieve the value entered by the user on the equip_import_batch_id ASP:TextBox, and
            // save it into the equip_import_batch_id field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.equip_import_batch_id.Text, Equipment_importTable.equip_import_batch_id);							
                          
                      
        }
                
        public virtual void Getmodel()
        {
            
        }
                
        public virtual void Getopen_time()
        {
            
            // Retrieve the value entered by the user on the open_time ASP:TextBox, and
            // save it into the open_time field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.open_time.Text, Equipment_importTable.open_time);							
                          
                      
        }
                
        public virtual void Getphone_number()
        {
            
            // Retrieve the value entered by the user on the phone_number ASP:TextBox, and
            // save it into the phone_number field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.phone_number.Text, Equipment_importTable.phone_number);							
                          
                      
        }
                
        public virtual void Getpm_frequency()
        {
            
            // Retrieve the value entered by the user on the pm_frequency ASP:TextBox, and
            // save it into the pm_frequency field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pm_frequency.Text, Equipment_importTable.pm_frequency);							
                          
                      
        }
                
        public virtual void Getpm_last_fix_date()
        {
            
        }
                
        public virtual void Getpm_purchase_order()
        {
            
            // Retrieve the value entered by the user on the pm_purchase_order ASP:TextBox, and
            // save it into the pm_purchase_order field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pm_purchase_order.Text, Equipment_importTable.pm_purchase_order);							
                          
                      
        }
                
        public virtual void Getpm_purchase_order1()
        {
            
            // Retrieve the value entered by the user on the pm_purchase_order ASP:TextBox, and
            // save it into the pm_purchase_order field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.pm_purchase_order1.Text, Equipment_importTable.pm_purchase_order);							
                          
                      
        }
                
        public virtual void Getpo_date()
        {
            
        }
                
        public virtual void Getserial_number()
        {
            
        }
                
        public virtual void Getserv_rep_parts_po()
        {
            
            // Retrieve the value entered by the user on the serv_rep_parts_po ASP:TextBox, and
            // save it into the serv_rep_parts_po field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.serv_rep_parts_po.Text, Equipment_importTable.serv_rep_parts_po);							
                          
                      
        }
                
        public virtual void Getservice_tech()
        {
            
            // Retrieve the value entered by the user on the service_tech ASP:TextBox, and
            // save it into the service_tech field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.service_tech.Text, Equipment_importTable.service_tech);							
                          
                      
        }
                
        public virtual void Getstate()
        {
            
        }
                
        public virtual void Getstatus()
        {
            
            // Retrieve the value entered by the user on the status ASP:TextBox, and
            // save it into the status field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.status.Text, Equipment_importTable.status);							
                          
                      
        }
                
        public virtual void Getzipcode()
        {
            
            // Retrieve the value entered by the user on the zipcode ASP:TextBox, and
            // save it into the zipcode field in DataSource DatabaseAYS_OEM%dbo.equipment_import record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.zipcode.Text, Equipment_importTable.zipcode);							
                          
                      
        }
                

      // To customize, override this method in Equipment_importTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_import_batchRecordControl = false;
            hasFiltersEquipment_import_batchRecordControl = hasFiltersEquipment_import_batchRecordControl && false; // suppress warning
      
            bool hasFiltersEquipment_importTableControl = false;
            hasFiltersEquipment_importTableControl = hasFiltersEquipment_importTableControl && false; // suppress warning
      
            return null;
        
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
          Equipment_importTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Equipment_importTableControl)MiscUtils.GetParentControlObject(this, "Equipment_importTableControl")).DataChanged = true;
            ((Equipment_importTableControl)MiscUtils.GetParentControlObject(this, "Equipment_importTableControl")).ResetData = true;
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

        
    
        // Generate set method for buttons
        
        public virtual void SetDeleteRowButton()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        Equipment_importTableControl tc= ((Equipment_importTableControl)MiscUtils.GetParentControlObject(this, "Equipment_importTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((Equipment_importTableControlRow)this);
                    }
                    this.Visible = false;
                    tc.SetFormulaControls();                    
                }
              
            }
      
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../equipment_import/Edit-Equipment-import.aspx?equip_import_id={Equipment_importTableControlRow:FV:equip_import_id}";
            
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
            
            
        
        protected virtual void address_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void address_state_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void asset_tag_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void building_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void category_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void city_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void close_time_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void comments_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void contact_first_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void contact_last_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void date_of_next_pm_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void department_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void equip_import_batch_id_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void model_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void open_time_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void phone_number_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pm_frequency_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pm_last_fix_date_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pm_purchase_order_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void pm_purchase_order1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void po_date_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void serial_number_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void serv_rep_parts_po_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void service_tech_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void state_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void status_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void zipcode_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseEquipment_importTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_importTableControlRow_Rec"] = value;
            }
        }
        
        public Equipment_importRecord DataSource {
            get {
                return (Equipment_importRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox address {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "address");
            }
        }
            
        public System.Web.UI.WebControls.TextBox address_state {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "address_state");
            }
        }
            
        public System.Web.UI.WebControls.TextBox asset_tag {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "asset_tag");
            }
        }
            
        public System.Web.UI.WebControls.TextBox building {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "building");
            }
        }
            
        public System.Web.UI.WebControls.TextBox category {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category");
            }
        }
            
        public System.Web.UI.WebControls.TextBox city {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "city");
            }
        }
            
        public System.Web.UI.WebControls.TextBox close_time {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "close_time");
            }
        }
            
        public System.Web.UI.WebControls.TextBox comments {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "comments");
            }
        }
            
        public System.Web.UI.WebControls.TextBox contact_first {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contact_first");
            }
        }
            
        public System.Web.UI.WebControls.TextBox contact_last {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contact_last");
            }
        }
            
        public System.Web.UI.WebControls.TextBox date_of_next_pm {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_of_next_pm");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox department {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "department");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox equip_import_batch_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equip_import_batch_id");
            }
        }
            
        public System.Web.UI.WebControls.TextBox model {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model");
            }
        }
            
        public System.Web.UI.WebControls.TextBox open_time {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "open_time");
            }
        }
            
        public System.Web.UI.WebControls.TextBox phone_number {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phone_number");
            }
        }
            
        public System.Web.UI.WebControls.TextBox pm_frequency {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_frequency");
            }
        }
            
        public System.Web.UI.WebControls.TextBox pm_last_fix_date {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_last_fix_date");
            }
        }
            
        public System.Web.UI.WebControls.TextBox pm_purchase_order {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_purchase_order");
            }
        }
            
        public System.Web.UI.WebControls.TextBox pm_purchase_order1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_purchase_order1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox po_date {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "po_date");
            }
        }
            
        public System.Web.UI.WebControls.TextBox serial_number {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_number");
            }
        }
            
        public System.Web.UI.WebControls.TextBox serv_rep_parts_po {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serv_rep_parts_po");
            }
        }
            
        public System.Web.UI.WebControls.TextBox service_tech {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "service_tech");
            }
        }
            
        public System.Web.UI.WebControls.TextBox state {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "state");
            }
        }
            
        public System.Web.UI.WebControls.TextBox status {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "status");
            }
        }
            
        public System.Web.UI.WebControls.TextBox zipcode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "zipcode");
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
        Equipment_importRecord rec = null;
             
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
    Equipment_importRecord rec = null;
    
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

        
        public virtual Equipment_importRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_importTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Equipment_importTableControl control on the Edit_Equipment_import_Table page.
// Do not modify this class. Instead override any method in Equipment_importTableControl.
public class BaseEquipment_importTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseEquipment_importTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                
                  if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                  {
                  initialVal = "";
                  }
                
                if  (this.InSession(this.SortControl)) 				
                    initialVal = this.GetFromSession(this.SortControl);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SortControl.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.SortControl.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.asset_tagFilter)) 				
                    initialVal = this.GetFromSession(this.asset_tagFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"asset_tag\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] asset_tagFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in asset_tagFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.asset_tagFilter.Items.Add(item);
                            this.asset_tagFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.asset_tagFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Equipment_importTable.equip_import_id, OrderByItem.OrderDir.Asc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "100"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination.FirstPage.Click += Pagination_FirstPage_Click;
                        
                    this.Pagination.LastPage.Click += Pagination_LastPage_Click;
                        
                    this.Pagination.NextPage.Click += Pagination_NextPage_Click;
                        
                    this.Pagination.PageSizeButton.Click += Pagination_PageSizeButton_Click;
                        
                    this.Pagination.PreviousPage.Click += Pagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.addressLabel.Click += addressLabel_Click;
            
              this.asset_tagLabel.Click += asset_tagLabel_Click;
            
              this.buildingLabel.Click += buildingLabel_Click;
            
              this.categoryLabel.Click += categoryLabel_Click;
            
              this.close_timeLabel.Click += close_timeLabel_Click;
            
              this.commentsLabel.Click += commentsLabel_Click;
            
              this.contact_firstLabel.Click += contact_firstLabel_Click;
            
              this.contact_lastLabel.Click += contact_lastLabel_Click;
            
              this.date_of_next_pmLabel.Click += date_of_next_pmLabel_Click;
            
              this.departmentLabel.Click += departmentLabel_Click;
            
              this.modelLabel.Click += modelLabel_Click;
            
              this.open_timeLabel.Click += open_timeLabel_Click;
            
              this.phone_numberLabel.Click += phone_numberLabel_Click;
            
              this.pm_frequencyLabel.Click += pm_frequencyLabel_Click;
            
              this.pm_last_fix_dateLabel.Click += pm_last_fix_dateLabel_Click;
            
              this.pm_purchase_orderLabel.Click += pm_purchase_orderLabel_Click;
            
              this.po_dateLabel.Click += po_dateLabel_Click;
            
              this.serial_numberLabel.Click += serial_numberLabel_Click;
            
              this.serv_rep_parts_poLabel.Click += serv_rep_parts_poLabel_Click;
            
              this.service_techLabel.Click += service_techLabel_Click;
            
              this.stateLabel.Click += stateLabel_Click;
            
              this.statusLabel.Click += statusLabel_Click;
            
            // Setup the button events.
          
                    this.AddButton.Click += AddButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
            
              this.asset_tagFilter.SelectedIndexChanged += asset_tagFilter_SelectedIndexChanged;                  
                        
        
         //' Setup events for others
               
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(OEMConversion.Business.Equipment_importRecord);
                      this.DataSource = (Equipment_importRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (Equipment_importTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Equipment_importRecord);
                    this.DataSource = (Equipment_importRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual Equipment_importRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Equipment_importTable.Column1, true);          
            // selCols.Add(Equipment_importTable.Column2, true);          
            // selCols.Add(Equipment_importTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Equipment_importTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Equipment_importTable databaseTable = new Equipment_importTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Equipment_importRecord)) as Equipment_importRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Equipment_importTable.Column1, true);          
            // selCols.Add(Equipment_importTable.Column2, true);          
            // selCols.Add(Equipment_importTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Equipment_importTable.GetRecordCount(join, where);
            else
            {
                Equipment_importTable databaseTable = new Equipment_importTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
          
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_importTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Equipment_importTableControlRow recControl = (Equipment_importTableControlRow)(repItem.FindControl("Equipment_importTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                SetaddressLabel();
                Setasset_tagFilter();
                Setasset_tagLabel();
                Setasset_tagLabel1();
                SetbuildingLabel();
                SetcategoryLabel();
                Setclose_timeLabel();
                SetcommentsLabel();
                Setcontact_firstLabel();
                Setcontact_lastLabel();
                Setdate_of_next_pmLabel();
                SetdepartmentLabel();
                
                
                SetLabel();
                SetmodelLabel();
                Setopen_timeLabel();
                
                Setphone_numberLabel();
                Setpm_frequencyLabel();
                Setpm_last_fix_dateLabel();
                Setpm_purchase_orderLabel();
                Setpm_purchase_orderLabel1();
                Setpo_dateLabel();
                Setserial_numberLabel();
                Setserv_rep_parts_poLabel();
                Setservice_techLabel();
                SetSortByLabel();
                SetSortControl();
                SetstateLabel();
                SetstatusLabel();
                
                SetAddButton();
              
                SetActionsButton();
              
                SetFilterButton();
              
                SetFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Equipment_importTable.equip_import_batch_id, this.DataSource);
        }
        

        public virtual void RegisterPostback()
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


            
            this.asset_tagFilter.ClearSelection();
            
            this.SortControl.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Equipment_importTable.equip_import_id, OrderByItem.OrderDir.Asc);
                 
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination.CurrentPage.Text = "0";
            }
            this.Pagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for Equipment_importTableControl pagination.
        
            this.Pagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (Equipment_importTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (Equipment_importTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            Equipment_importTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
          
            if (MiscUtils.IsValueSelected(this.asset_tagFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.asset_tagFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.asset_tagFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(Equipment_importTable.asset_tag, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_importTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String asset_tagFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "asset_tagFilter_Ajax"];
            if (MiscUtils.IsValueSelected(asset_tagFilterSelectedValue)) {

              
        if (asset_tagFilterSelectedValue != null){
                        string[] asset_tagFilteritemListFromSession = asset_tagFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in asset_tagFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(Equipment_importTable.asset_tag, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      

            return wc;
        }

        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("URL(\"equip_import_batch_id\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Equipment_importTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"equipment_import_.equip_import_batch_id"), EvaluateFormula("URL(\"equip_import_batch_id\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"equip_import_batch_id\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"equip_import_batch_id\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
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
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_importTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Equipment_importTableControlRow recControl = (Equipment_importTableControlRow)(repItem.FindControl("Equipment_importTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Equipment_importRecord rec = new Equipment_importRecord();
        
                        if (recControl.address.Text != "") {
                            rec.Parse(recControl.address.Text, Equipment_importTable.address);
                  }
                
                        if (recControl.address_state.Text != "") {
                            rec.Parse(recControl.address_state.Text, Equipment_importTable.address_state);
                  }
                
                        if (recControl.asset_tag.Text != "") {
                            rec.Parse(recControl.asset_tag.Text, Equipment_importTable.asset_tag);
                  }
                
                        if (recControl.building.Text != "") {
                            rec.Parse(recControl.building.Text, Equipment_importTable.building);
                  }
                
                        if (recControl.category.Text != "") {
                            rec.Parse(recControl.category.Text, Equipment_importTable.category);
                  }
                
                        if (recControl.city.Text != "") {
                            rec.Parse(recControl.city.Text, Equipment_importTable.city);
                  }
                
                        if (recControl.close_time.Text != "") {
                            rec.Parse(recControl.close_time.Text, Equipment_importTable.close_time);
                  }
                
                        if (recControl.comments.Text != "") {
                            rec.Parse(recControl.comments.Text, Equipment_importTable.comments);
                  }
                
                        if (recControl.contact_first.Text != "") {
                            rec.Parse(recControl.contact_first.Text, Equipment_importTable.contact_first);
                  }
                
                        if (recControl.contact_last.Text != "") {
                            rec.Parse(recControl.contact_last.Text, Equipment_importTable.contact_last);
                  }
                
                        if (recControl.date_of_next_pm.Text != "") {
                            rec.Parse(recControl.date_of_next_pm.Text, Equipment_importTable.date_of_next_pm);
                  }
                
                        if (recControl.department.Text != "") {
                            rec.Parse(recControl.department.Text, Equipment_importTable.department);
                  }
                
                        if (recControl.equip_import_batch_id.Text != "") {
                            rec.Parse(recControl.equip_import_batch_id.Text, Equipment_importTable.equip_import_batch_id);
                  }
                
                        if (recControl.model.Text != "") {
                            rec.Parse(recControl.model.Text, Equipment_importTable.model);
                  }
                
                        if (recControl.open_time.Text != "") {
                            rec.Parse(recControl.open_time.Text, Equipment_importTable.open_time);
                  }
                
                        if (recControl.phone_number.Text != "") {
                            rec.Parse(recControl.phone_number.Text, Equipment_importTable.phone_number);
                  }
                
                        if (recControl.pm_frequency.Text != "") {
                            rec.Parse(recControl.pm_frequency.Text, Equipment_importTable.pm_frequency);
                  }
                
                        if (recControl.pm_last_fix_date.Text != "") {
                            rec.Parse(recControl.pm_last_fix_date.Text, Equipment_importTable.pm_last_fix_date);
                  }
                
                        if (recControl.pm_purchase_order.Text != "") {
                            rec.Parse(recControl.pm_purchase_order.Text, Equipment_importTable.pm_purchase_order);
                  }
                
                        if (recControl.pm_purchase_order1.Text != "") {
                            rec.Parse(recControl.pm_purchase_order1.Text, Equipment_importTable.pm_purchase_order);
                  }
                
                        if (recControl.po_date.Text != "") {
                            rec.Parse(recControl.po_date.Text, Equipment_importTable.po_date);
                  }
                
                        if (recControl.serial_number.Text != "") {
                            rec.Parse(recControl.serial_number.Text, Equipment_importTable.serial_number);
                  }
                
                        if (recControl.serv_rep_parts_po.Text != "") {
                            rec.Parse(recControl.serv_rep_parts_po.Text, Equipment_importTable.serv_rep_parts_po);
                  }
                
                        if (recControl.service_tech.Text != "") {
                            rec.Parse(recControl.service_tech.Text, Equipment_importTable.service_tech);
                  }
                
                        if (recControl.state.Text != "") {
                            rec.Parse(recControl.state.Text, Equipment_importTable.state);
                  }
                
                        if (recControl.status.Text != "") {
                            rec.Parse(recControl.status.Text, Equipment_importTable.status);
                  }
                
                        if (recControl.zipcode.Text != "") {
                            rec.Parse(recControl.zipcode.Text, Equipment_importTable.zipcode);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Equipment_importRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Equipment_importRecord);
                this.DataSource = (Equipment_importRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Equipment_importTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Equipment_importTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetaddressLabel()
                  {
                  
                    
        }
                
        public virtual void Setasset_tagLabel()
                  {
                  
                    
        }
                
        public virtual void Setasset_tagLabel1()
                  {
                  
                    
        }
                
        public virtual void SetbuildingLabel()
                  {
                  
                    
        }
                
        public virtual void SetcategoryLabel()
                  {
                  
                    
        }
                
        public virtual void Setclose_timeLabel()
                  {
                  
                    
        }
                
        public virtual void SetcommentsLabel()
                  {
                  
                    
        }
                
        public virtual void Setcontact_firstLabel()
                  {
                  
                        this.contact_firstLabel.Text = EvaluateFormula("\"First\"");
                      
                    
        }
                
        public virtual void Setcontact_lastLabel()
                  {
                  
                        this.contact_lastLabel.Text = EvaluateFormula("\"Last\"");
                      
                    
        }
                
        public virtual void Setdate_of_next_pmLabel()
                  {
                  
                        this.date_of_next_pmLabel.Text = EvaluateFormula("\"Date of next PM\"");
                      
                    
        }
                
        public virtual void SetdepartmentLabel()
                  {
                  
                    
        }
                
        public virtual void SetLabel()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel()
                  {
                  
                    
        }
                
        public virtual void Setopen_timeLabel()
                  {
                  
                    
        }
                
        public virtual void Setphone_numberLabel()
                  {
                  
                        this.phone_numberLabel.Text = EvaluateFormula("\"Phone\"");
                      
                    
        }
                
        public virtual void Setpm_frequencyLabel()
                  {
                  
                        this.pm_frequencyLabel.Text = EvaluateFormula("\"PM Frequency\"");
                      
                    
        }
                
        public virtual void Setpm_last_fix_dateLabel()
                  {
                  
                    
        }
                
        public virtual void Setpm_purchase_orderLabel()
                  {
                  
                        this.pm_purchase_orderLabel.Text = EvaluateFormula("\"PO#\"");
                      
                    
        }
                
        public virtual void Setpm_purchase_orderLabel1()
                  {
                  
                        this.pm_purchase_orderLabel1.Text = EvaluateFormula("\"PO#\"");
                      
                    
        }
                
        public virtual void Setpo_dateLabel()
                  {
                  
                    
        }
                
        public virtual void Setserial_numberLabel()
                  {
                  
                    
        }
                
        public virtual void Setserv_rep_parts_poLabel()
                  {
                  
                        this.serv_rep_parts_poLabel.Text = EvaluateFormula("\"Serv/Rep Parts PO\"");
                      
                    
        }
                
        public virtual void Setservice_techLabel()
                  {
                  
                        this.service_techLabel.Text = EvaluateFormula("\"Technician\"");
                      
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetstateLabel()
                  {
                  
                    
        }
                
        public virtual void SetstatusLabel()
                  {
                  
                    
        }
                
        public virtual void SetSortControl()
        {
            
                this.PopulateSortControl(MiscUtils.GetSelectedValue(this.SortControl,  GetFromSession(this.SortControl)), 500);					
                    

        }
            
        public virtual void Setasset_tagFilter()
        {
            
            ArrayList asset_tagFilterselectedFilterItemList = new ArrayList();
            string asset_tagFilteritemsString = null;
            if (this.InSession(this.asset_tagFilter))
                asset_tagFilteritemsString = this.GetFromSession(this.asset_tagFilter);
            
            if (asset_tagFilteritemsString != null)
            {
                string[] asset_tagFilteritemListFromSession = asset_tagFilteritemsString.Split(',');
                foreach (string item in asset_tagFilteritemListFromSession)
                {
                    asset_tagFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.Populateasset_tagFilter(MiscUtils.GetSelectedValueList(this.asset_tagFilter, asset_tagFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../equipment_import/Equipment-import-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.asset_tagFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("asset_tag")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.asset_tagFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(asset_tagFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for SortControl.
                
        protected virtual void PopulateSortControl(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Asset Tag {Txt:Ascending}"), "asset_tag Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Asset Tag {Txt:Descending}"), "asset_tag Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Building {Txt:Ascending}"), "building Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Building {Txt:Descending}"), "building Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Ascending}"), "category Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Descending}"), "category Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer {Txt:Ascending}"), "customer Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer {Txt:Descending}"), "customer Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Department {Txt:Ascending}"), "department Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Department {Txt:Descending}"), "department Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Import Batch {Txt:Ascending}"), "equip_import_batch_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Import Batch {Txt:Descending}"), "equip_import_batch_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Ascending}"), "model Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Descending}"), "model Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Fix Date {Txt:Ascending}"), "pm_last_fix_date Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Fix Date {Txt:Descending}"), "pm_last_fix_date Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Ascending}"), "serial_number Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Descending}"), "serial_number Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("State {Txt:Ascending}"), "state Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("State {Txt:Descending}"), "state Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Frequency {Txt:Ascending}"), "pm_frequency Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Frequency {Txt:Descending}"), "pm_frequency Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Open Time {Txt:Ascending}"), "open_time Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Open Time {Txt:Descending}"), "open_time Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("PO Date {Txt:Ascending}"), "po_date Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("PO Date {Txt:Descending}"), "po_date Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Close Time {Txt:Ascending}"), "close_time Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Close Time {Txt:Descending}"), "close_time Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Status {Txt:Ascending}"), "status Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Status {Txt:Descending}"), "status Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address {Txt:Ascending}"), "address Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address {Txt:Descending}"), "address Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Service Tech {Txt:Ascending}"), "service_tech Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Service Tech {Txt:Descending}"), "service_tech Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact Last {Txt:Ascending}"), "contact_last Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact Last {Txt:Descending}"), "contact_last Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Phone Number {Txt:Ascending}"), "phone_number Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Phone Number {Txt:Descending}"), "phone_number Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("ZIP Code {Txt:Ascending}"), "zipcode Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("ZIP Code {Txt:Descending}"), "zipcode Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("City {Txt:Ascending}"), "city Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("City {Txt:Descending}"), "city Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serv Representative Parts PO {Txt:Ascending}"), "serv_rep_parts_po Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serv Representative Parts PO {Txt:Descending}"), "serv_rep_parts_po Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact First {Txt:Ascending}"), "contact_first Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Contact First {Txt:Descending}"), "contact_first Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address State {Txt:Ascending}"), "address_state Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Address State {Txt:Descending}"), "address_state Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Purchase Order {Txt:Ascending}"), "pm_purchase_order Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Purchase Order {Txt:Descending}"), "pm_purchase_order Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Of Next PM {Txt:Ascending}"), "date_of_next_pm Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Of Next PM {Txt:Descending}"), "date_of_next_pm Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Comments {Txt:Ascending}"), "comments Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Comments {Txt:Descending}"), "comments Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.SortControl, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.SortControl.SelectedValue != null && this.SortControl.Items.FindByValue(this.SortControl.SelectedValue) == null)
                this.SortControl.SelectedValue = null;
              
        }
            
        // Get the filters' data for asset_tagFilter.
                
        protected virtual void Populateasset_tagFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_asset_tagFilter();            
            this.asset_tagFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_asset_tagFilter function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Equipment_importTable.asset_tag, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Equipment_importTable.GetValues(Equipment_importTable.asset_tag, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Equipment_importTable.asset_tag.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Equipment_importTable.asset_tag.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.asset_tagFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.asset_tagFilter.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.asset_tagFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.asset_tagFilter.Items.Count == 0)
                this.asset_tagFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.asset_tagFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_asset_tagFilter()
        {
            // Create a where clause for the filter asset_tagFilter.
            // This function is called by the Populate method to load the items 
            // in the asset_tagFilterQuickSelector
        
            ArrayList asset_tagFilterselectedFilterItemList = new ArrayList();
            string asset_tagFilteritemsString = null;
            if (this.InSession(this.asset_tagFilter))
                asset_tagFilteritemsString = this.GetFromSession(this.asset_tagFilter);
            
            if (asset_tagFilteritemsString != null)
            {
                string[] asset_tagFilteritemListFromSession = asset_tagFilteritemsString.Split(',');
                foreach (string item in asset_tagFilteritemListFromSession)
                {
                    asset_tagFilterselectedFilterItemList.Add(item);
                }
            }
              
            asset_tagFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.asset_tagFilter, asset_tagFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (asset_tagFilterselectedFilterItemList == null || asset_tagFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in asset_tagFilterselectedFilterItemList)
                {
            
      
   
                    wc.iOR(Equipment_importTable.asset_tag, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
                }
            }
            return wc;
        
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
                    bool added = (this.AddNewRecord > 0);
                    this.LoadData();
                    this.DataBind();					
                    
                    if (added) this.SetFocusToAddedRow();
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            protected virtual void SetFocusToAddedRow()
            {
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("Equipment_importTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Equipment_importTableControlRow recControl = (Equipment_importTableControlRow)repItem.FindControl("Equipment_importTableControlRow");
                if(recControl.IsNewRecord) {
                    foreach (Control field in recControl.Controls) {
                    if (field.Visible && this.Page.IsControlEditable(field, false)) {
                        //set focus on the first editable field in the new row
                        field.Focus();
                        UpdatePanel updPan = (UpdatePanel)this.Page.FindControlRecursively("UpdatePanel1");
                        if (updPan != null) updPan.Update();
                        return;
                        }
                    }
                    return;
                }
            }
        }
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
            ArrayList asset_tagFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.asset_tagFilter, null);
            string asset_tagFilterSessionString = "";
            if (asset_tagFilterselectedFilterItemList != null){
                foreach (string item in asset_tagFilterselectedFilterItemList){
                    asset_tagFilterSessionString = String.Concat(asset_tagFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.asset_tagFilter, asset_tagFilterSessionString);
                  
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
            ArrayList asset_tagFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.asset_tagFilter, null);
            string asset_tagFilterSessionString = "";
            if (asset_tagFilterselectedFilterItemList != null){
                foreach (string item in asset_tagFilterselectedFilterItemList){
                    asset_tagFilterSessionString = String.Concat(asset_tagFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("asset_tagFilter_Ajax", asset_tagFilterSessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.asset_tagFilter);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["Equipment_importTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["Equipment_importTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetAddButton()                
              
        {
        
   
        }
            
        public virtual void SetActionsButton()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(asset_tagFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        
        public virtual void addressLabel_Click(object sender, EventArgs args)
        {
            //Sorts by address when clicked.
              
            // Get previous sorting state for address.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.address);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for address.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.address, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by address, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void asset_tagLabel_Click(object sender, EventArgs args)
        {
            //Sorts by asset_tag when clicked.
              
            // Get previous sorting state for asset_tag.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.asset_tag);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for asset_tag.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.asset_tag, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by asset_tag, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void buildingLabel_Click(object sender, EventArgs args)
        {
            //Sorts by building when clicked.
              
            // Get previous sorting state for building.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.building);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for building.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.building, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by building, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void categoryLabel_Click(object sender, EventArgs args)
        {
            //Sorts by category when clicked.
              
            // Get previous sorting state for category.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.category);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for category.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.category, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by category, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void close_timeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by close_time when clicked.
              
            // Get previous sorting state for close_time.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.close_time);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for close_time.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.close_time, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by close_time, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void commentsLabel_Click(object sender, EventArgs args)
        {
            //Sorts by comments when clicked.
              
            // Get previous sorting state for comments.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.comments);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for comments.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.comments, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by comments, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void contact_firstLabel_Click(object sender, EventArgs args)
        {
            //Sorts by contact_first when clicked.
              
            // Get previous sorting state for contact_first.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.contact_first);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for contact_first.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.contact_first, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by contact_first, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void contact_lastLabel_Click(object sender, EventArgs args)
        {
            //Sorts by contact_last when clicked.
              
            // Get previous sorting state for contact_last.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.contact_last);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for contact_last.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.contact_last, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by contact_last, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void date_of_next_pmLabel_Click(object sender, EventArgs args)
        {
            //Sorts by date_of_next_pm when clicked.
              
            // Get previous sorting state for date_of_next_pm.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.date_of_next_pm);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for date_of_next_pm.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.date_of_next_pm, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by date_of_next_pm, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void departmentLabel_Click(object sender, EventArgs args)
        {
            //Sorts by department when clicked.
              
            // Get previous sorting state for department.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.department);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for department.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.department, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by department, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void modelLabel_Click(object sender, EventArgs args)
        {
            //Sorts by model when clicked.
              
            // Get previous sorting state for model.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.model);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for model.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.model, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by model, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void open_timeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by open_time when clicked.
              
            // Get previous sorting state for open_time.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.open_time);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for open_time.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.open_time, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by open_time, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void phone_numberLabel_Click(object sender, EventArgs args)
        {
            //Sorts by phone_number when clicked.
              
            // Get previous sorting state for phone_number.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.phone_number);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for phone_number.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.phone_number, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by phone_number, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pm_frequencyLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pm_frequency when clicked.
              
            // Get previous sorting state for pm_frequency.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.pm_frequency);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pm_frequency.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.pm_frequency, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pm_frequency, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pm_last_fix_dateLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pm_last_fix_date when clicked.
              
            // Get previous sorting state for pm_last_fix_date.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.pm_last_fix_date);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pm_last_fix_date.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.pm_last_fix_date, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pm_last_fix_date, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void pm_purchase_orderLabel_Click(object sender, EventArgs args)
        {
            //Sorts by pm_purchase_order when clicked.
              
            // Get previous sorting state for pm_purchase_order.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.pm_purchase_order);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for pm_purchase_order.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.pm_purchase_order, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by pm_purchase_order, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void po_dateLabel_Click(object sender, EventArgs args)
        {
            //Sorts by po_date when clicked.
              
            // Get previous sorting state for po_date.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.po_date);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for po_date.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.po_date, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by po_date, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void serial_numberLabel_Click(object sender, EventArgs args)
        {
            //Sorts by serial_number when clicked.
              
            // Get previous sorting state for serial_number.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.serial_number);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for serial_number.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.serial_number, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by serial_number, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void serv_rep_parts_poLabel_Click(object sender, EventArgs args)
        {
            //Sorts by serv_rep_parts_po when clicked.
              
            // Get previous sorting state for serv_rep_parts_po.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.serv_rep_parts_po);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for serv_rep_parts_po.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.serv_rep_parts_po, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by serv_rep_parts_po, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void service_techLabel_Click(object sender, EventArgs args)
        {
            //Sorts by service_tech when clicked.
              
            // Get previous sorting state for service_tech.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.service_tech);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for service_tech.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.service_tech, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by service_tech, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void stateLabel_Click(object sender, EventArgs args)
        {
            //Sorts by state when clicked.
              
            // Get previous sorting state for state.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.state);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for state.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.state, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by state, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void statusLabel_Click(object sender, EventArgs args)
        {
            //Sorts by status when clicked.
              
            // Get previous sorting state for status.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.status);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for status.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_importTable.status, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by status, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void AddButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../equipment_import/Add-Equipment-import.aspx?equip_import_batch_id={Equipment_import_batchRecordControl:FV:equip_import_batch_id}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
            
            
        
        // event handler for Button
        public virtual void ActionsButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FilterButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FiltersButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for OrderSort
        protected virtual void SortControl_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.SortControl.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Equipment_importTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Equipment_importTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Equipment_importTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Equipment_importTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Equipment_importTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Equipment_importTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void asset_tagFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = Equipment_importTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  Equipment_importRecord[] DataSource {
             
            get {
                return (Equipment_importRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow ActionsButton {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActionsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton AddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AddButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton addressLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "addressLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector asset_tagFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "asset_tagFilter");
            }
        }              
        
        public System.Web.UI.WebControls.LinkButton asset_tagLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "asset_tagLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal asset_tagLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "asset_tagLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton buildingLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "buildingLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton categoryLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "categoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton close_timeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "close_timeLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton commentsLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "commentsLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton contact_firstLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contact_firstLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton contact_lastLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "contact_lastLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton date_of_next_pmLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_of_next_pmLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton departmentLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "departmentLabel");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton");
            }
        }
        
        public OEMConversion.UI.IThemeButtonWithArrow FiltersButton {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FiltersButton");
            }
        }
        
        public System.Web.UI.WebControls.Label Label {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Label");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton modelLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton open_timeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "open_timeLabel");
            }
        }
        
        public OEMConversion.UI.IPaginationModern Pagination {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton phone_numberLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phone_numberLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pm_frequencyLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_frequencyLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pm_last_fix_dateLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_last_fix_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton pm_purchase_orderLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_purchase_orderLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal pm_purchase_orderLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "pm_purchase_orderLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton po_dateLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "po_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton serial_numberLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_numberLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton serv_rep_parts_poLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serv_rep_parts_poLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton service_techLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "service_techLabel");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList SortControl {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortControl");
          }
          }
        
        public System.Web.UI.WebControls.LinkButton stateLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "stateLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton statusLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "statusLabel");
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
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                Equipment_importTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_importRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                Equipment_importTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_importRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual Equipment_importTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Equipment_importTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Equipment_importTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Equipment_import_Table.Equipment_importTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Equipment_importTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Equipment_importTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual Equipment_importTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Equipment_importTableControlRow");
	          List<Equipment_importTableControlRow> list = new List<Equipment_importTableControlRow>();
	          foreach (Equipment_importTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  
// Base class for the Equipment_import_batchRecordControl control on the Edit_Equipment_import_Table page.
// Do not modify this class. Instead override any method in Equipment_import_batchRecordControl.
public class BaseEquipment_import_batchRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_import_batchRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_import_batchRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Equipment_import_batchRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.custno.SelectedIndexChanged += custno_SelectedIndexChanged;                  
                
              this.batch_date_created.TextChanged += batch_date_created_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_import_batch record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_import_batchTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_import_batchRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Equipment_import_batchRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Equipment_import_batchRecord[] recList = Equipment_import_batchTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Equipment_import_batchTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                Setbatch_date_created();
                Setcustno();

      

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
        
        
        public virtual void Setbatch_date_created()
        {
            
                    
            // Set the batch_date_created TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import_batch database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import_batch record retrieved from the database.
            // this.batch_date_created is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.batch_date_createdSpecified) {
                								
                // If the batch_date_created is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_import_batchTable.batch_date_created, @"d");
                                
                this.batch_date_created.Text = formattedValue;
                   
            } 
            
            else {
            
                // batch_date_created is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.batch_date_created.Text = Equipment_import_batchTable.batch_date_created.Format(Equipment_import_batchTable.batch_date_created.DefaultValue, @"d");
            		
            }
            
              this.batch_date_created.TextChanged += batch_date_created_TextChanged;
                               
        }
                
        public virtual void Setcustno()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the custno QuickSelector on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_import_batch database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_import_batch record retrieved from the database.
            // this.custno is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustno();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.custnoSpecified)
            {
                            
                // If the custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.custno.ToString();
                
            }
            else
            {
                
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_import_batchTable.custno.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.custno, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.custno.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
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
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_import_batchTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_import_batchTable.custno);
                        if(_isExpandableNonCompositeForeignKey && Equipment_import_batchTable.custno.IsApplyDisplayAs)
                            fvalue = Equipment_import_batchTable.GetDFKA(itemValue, Equipment_import_batchTable.custno);
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
                        
              string url = this.ModifyRedirectUrl("../Customers/Customers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.custno.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Customers.CustName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustNo")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.custno.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(custno.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_import_batchRecordControlPanel");
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
        
            Getbatch_date_created();
            Getcustno();
        }
        
        
        public virtual void Getbatch_date_created()
        {
            
            // Retrieve the value entered by the user on the batch_date_created ASP:TextBox, and
            // save it into the batch_date_created field in DataSource DatabaseAYS_OEM%dbo.equipment_import_batch record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.batch_date_created.Text, Equipment_import_batchTable.batch_date_created);							
                          
                      
        }
                
        public virtual void Getcustno()
        {
         // Retrieve the value entered by the user on the custno ASP:QuickSelector, and
            // save it into the custno field in DataSource DatabaseAYS_OEM%dbo.equipment_import_batch record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.custno), Equipment_import_batchTable.custno);			
                			 
        }
                

      // To customize, override this method in Equipment_import_batchRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_import_batchRecordControl = false;
            hasFiltersEquipment_import_batchRecordControl = hasFiltersEquipment_import_batchRecordControl && false; // suppress warning
      
            bool hasFiltersEquipment_importTableControl = false;
            hasFiltersEquipment_importTableControl = hasFiltersEquipment_importTableControl && false; // suppress warning
      
            WhereClause wc;
            Equipment_import_batchTable.Instance.InnerFilter = null;
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
            
            if (EvaluateFormula("URL(\"equip_import_batch_id\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Equipment_import_batchTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"equipment_import_batch_.equip_import_batch_id"), EvaluateFormula("URL(\"equip_import_batch_id\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"equip_import_batch_id\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"equip_import_batch_id\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_import_batchTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEquipment_import_batchRecordControl = false;
            hasFiltersEquipment_import_batchRecordControl = hasFiltersEquipment_import_batchRecordControl && false; // suppress warning
      
            bool hasFiltersEquipment_importTableControl = false;
            hasFiltersEquipment_importTableControl = hasFiltersEquipment_importTableControl && false; // suppress warning
      
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
          Equipment_import_batchTable.DeleteRecord(pkValue);
          
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
        
        protected virtual void custno_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void batch_date_created_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseEquipment_import_batchRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_import_batchRecordControl_Rec"] = value;
            }
        }
        
        public Equipment_import_batchRecord DataSource {
            get {
                return (Equipment_import_batchRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox batch_date_created {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "batch_date_created");
            }
        }
            
        public BaseClasses.Web.UI.WebControls.QuickSelector custno {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
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
        Equipment_import_batchRecord rec = null;
             
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
    Equipment_import_batchRecord rec = null;
    
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

        
        public virtual Equipment_import_batchRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_import_batchTable.GetRecord(this.RecordUniqueId, true);
              
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

  