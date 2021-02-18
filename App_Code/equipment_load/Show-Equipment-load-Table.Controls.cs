
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Equipment_load_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Equipment_load_Table
{
  

#region "Section 1: Place your customizations here."

    
public class Equipment_loadTableControlRow : BaseEquipment_loadTableControlRow
{
      
        // The BaseEquipment_loadTableControlRow implements code for a ROW within the
        // the Equipment_loadTableControl table.  The BaseEquipment_loadTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Equipment_loadTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Equipment_loadTableControl : BaseEquipment_loadTableControl
{
    // The BaseEquipment_loadTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Equipment_loadTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_loadTableControlRow control on the Show_Equipment_load_Table page.
// Do not modify this class. Instead override any method in Equipment_loadTableControlRow.
public class BaseEquipment_loadTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_loadTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_loadTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Equipment_loadTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_load record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_loadTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseEquipment_loadTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Equipment_loadRecord();
            
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
                Setcondition();
                SetconditionLabel();
                Setcustno();
                Setdate_received();
                Setdate_receivedLabel();
                Setdate_sold();
                Setdate_soldLabel();
                
                Setdisposition();
                Setdisposition_Id();
                SetdispositionLabel();
                Setdotmed_active();
                Setdotmed_id();
                
                Setequipment_invoice_adv();
                Setequipment_invoice_advLabel();
                Setfinal_sale();
                Setfinal_saleLabel();
                Setfound();
                SetfoundLabel();
                Setlockkey();
                Setmake();
                SetmakeLabel();
                Setmodel();
                SetmodelLabel();
                Setnew_category();
                Setnew_category1();
                Setnew_categoryLabel();
                Setoem_ein();
                Setoem_einLabel();
                Setproposed();
                SetproposedLabel();
                Setpurchase();
                SetpurchaseLabel();
                Setreceived_from();
                Setreceived_fromLabel();
                Setserial_number();
                Setserial_numberLabel();
                Setwarehouse();
                Setwarehouse_id();
                Setwarehouse_location();
                Setwarehouse_location_id();
                Setwarehouse_locationLabel();
                SetwarehouseLabel();
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
        
        
        public virtual void Setcategory_id()
        {
            
                    
            // Set the category_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.category_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.category_idSpecified) {
                								
                // If the category_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.category_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.category_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // category_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.category_id.Text = Equipment_loadTable.category_id.Format(Equipment_loadTable.category_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setcondition()
        {
            
                    
            // Set the condition Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.condition is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.conditionSpecified) {
                								
                // If the condition is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.condition);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.condition.Text = formattedValue;
                   
            } 
            
            else {
            
                // condition is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.condition.Text = Equipment_loadTable.condition.Format(Equipment_loadTable.condition.DefaultValue);
            		
            }
            
            // If the condition is NULL or blank, then use the value specified  
            // on Properties.
            if (this.condition.Text == null ||
                this.condition.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.condition.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcustno()
        {
            
                    
            // Set the custno Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.custno is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.custnoSpecified) {
                								
                // If the custno is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.custno);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.custno.Text = formattedValue;
                   
            } 
            
            else {
            
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custno.Text = Equipment_loadTable.custno.Format(Equipment_loadTable.custno.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setdate_received()
        {
            
                    
            // Set the date_received Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.date_received is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_receivedSpecified) {
                								
                // If the date_received is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.date_received, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_received.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_received is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_received.Text = Equipment_loadTable.date_received.Format(Equipment_loadTable.date_received.DefaultValue, @"d");
            		
            }
            
            // If the date_received is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_received.Text == null ||
                this.date_received.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_received.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdate_sold()
        {
            
                    
            // Set the date_sold Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.date_sold is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_soldSpecified) {
                								
                // If the date_sold is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.date_sold, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_sold.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_sold is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_sold.Text = Equipment_loadTable.date_sold.Format(Equipment_loadTable.date_sold.DefaultValue, @"d");
            		
            }
            
            // If the date_sold is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_sold.Text == null ||
                this.date_sold.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_sold.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdisposition()
        {
              
            if (this.DataSource != null && this.DataSource.dispositionSpecified) {
              
                  this.disposition.Text = Page.GetResourceValue("Txt:OpenFile", "OEMConversion");
                  
                  this.disposition.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" +
                        
                                this.Page.Encrypt("Equipment_load") +
                                "&Field=" + this.Page.Encrypt("disposition") +
                                "&Record=" + this.Page.Encrypt(HttpUtility.UrlEncode(this.DataSource.GetID().ToString())) +
                      
                          "','','left=100,top=50,width=400,height=300,resizable, scrollbars=1');return false;";
                        
                this.disposition.Visible = true;
            }
            else {
                this.disposition.Visible = false;	
            }
               
        }
                
        public virtual void Setdisposition_Id()
        {
            
                    
            // Set the disposition_Id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.disposition_Id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.disposition_IdSpecified) {
                								
                // If the disposition_Id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.disposition_Id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.disposition_Id.Text = formattedValue;
                   
            } 
            
            else {
            
                // disposition_Id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.disposition_Id.Text = Equipment_loadTable.disposition_Id.Format(Equipment_loadTable.disposition_Id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setdotmed_active()
        {
            
                    
            // Set the dotmed_active Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.dotmed_active is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_activeSpecified) {
                								
                // If the dotmed_active is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.dotmed_active);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_active.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_active.Text = Equipment_loadTable.dotmed_active.Format(Equipment_loadTable.dotmed_active.DefaultValue);
            		
            }
            
            // If the dotmed_active is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_active.Text == null ||
                this.dotmed_active.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_active.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_id()
        {
            
                    
            // Set the dotmed_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.dotmed_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_idSpecified) {
                								
                // If the dotmed_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.dotmed_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_id.Text = Equipment_loadTable.dotmed_id.Format(Equipment_loadTable.dotmed_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setequipment_invoice_adv()
        {
            
                    
            // Set the equipment_invoice_adv Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.equipment_invoice_adv is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.equipment_invoice_advSpecified) {
                								
                // If the equipment_invoice_adv is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.equipment_invoice_adv);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.equipment_invoice_adv.Text = formattedValue;
                   
            } 
            
            else {
            
                // equipment_invoice_adv is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.equipment_invoice_adv.Text = Equipment_loadTable.equipment_invoice_adv.Format(Equipment_loadTable.equipment_invoice_adv.DefaultValue);
            		
            }
            
            // If the equipment_invoice_adv is NULL or blank, then use the value specified  
            // on Properties.
            if (this.equipment_invoice_adv.Text == null ||
                this.equipment_invoice_adv.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.equipment_invoice_adv.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setfinal_sale()
        {
            
                    
            // Set the final_sale Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.final_sale is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.final_saleSpecified) {
                								
                // If the final_sale is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.final_sale, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.final_sale.Text = formattedValue;
                   
            } 
            
            else {
            
                // final_sale is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.final_sale.Text = Equipment_loadTable.final_sale.Format(Equipment_loadTable.final_sale.DefaultValue, @"C");
            		
            }
            
            // If the final_sale is NULL or blank, then use the value specified  
            // on Properties.
            if (this.final_sale.Text == null ||
                this.final_sale.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.final_sale.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setfound()
        {
            
                    
            // Set the found Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.found is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.foundSpecified) {
                								
                // If the found is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.found);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.found.Text = formattedValue;
                   
            } 
            
            else {
            
                // found is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.found.Text = Equipment_loadTable.found.Format(Equipment_loadTable.found.DefaultValue);
            		
            }
            
            // If the found is NULL or blank, then use the value specified  
            // on Properties.
            if (this.found.Text == null ||
                this.found.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.found.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setlockkey()
        {
            
                    
            // Set the lockkey Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.lockkey is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.lockkeySpecified) {
                								
                // If the lockkey is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.lockkey);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.lockkey.Text = formattedValue;
                   
            } 
            
            else {
            
                // lockkey is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.lockkey.Text = Equipment_loadTable.lockkey.Format(Equipment_loadTable.lockkey.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setmake()
        {
            
                    
            // Set the make Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.make is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.makeSpecified) {
                								
                // If the make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.make);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.make.Text = formattedValue;
                   
            } 
            
            else {
            
                // make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make.Text = Equipment_loadTable.make.Format(Equipment_loadTable.make.DefaultValue);
            		
            }
            
            // If the make is NULL or blank, then use the value specified  
            // on Properties.
            if (this.make.Text == null ||
                this.make.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.make.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setmodel()
        {
            
                    
            // Set the model Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.model is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.modelSpecified) {
                								
                // If the model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.model);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.model.Text = formattedValue;
                   
            } 
            
            else {
            
                // model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model.Text = Equipment_loadTable.model.Format(Equipment_loadTable.model.DefaultValue);
            		
            }
            
            // If the model is NULL or blank, then use the value specified  
            // on Properties.
            if (this.model.Text == null ||
                this.model.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.model.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setnew_category()
        {
            
                    
            // Set the new_category Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.new_category is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.new_categorySpecified) {
                								
                // If the new_category is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.new_category);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.new_category.Text = formattedValue;
                   
            } 
            
            else {
            
                // new_category is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.new_category.Text = Equipment_loadTable.new_category.Format(Equipment_loadTable.new_category.DefaultValue);
            		
            }
            
            // If the new_category is NULL or blank, then use the value specified  
            // on Properties.
            if (this.new_category.Text == null ||
                this.new_category.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.new_category.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setnew_category1()
        {
            
                    
            // Set the new_category Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.new_category1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.new_categorySpecified) {
                								
                // If the new_category is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.new_category);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.new_category1.Text = formattedValue;
                   
            } 
            
            else {
            
                // new_category is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.new_category1.Text = Equipment_loadTable.new_category.Format(Equipment_loadTable.new_category.DefaultValue);
            		
            }
            
            // If the new_category is NULL or blank, then use the value specified  
            // on Properties.
            if (this.new_category1.Text == null ||
                this.new_category1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.new_category1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setoem_ein()
        {
            
                    
            // Set the oem_ein Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.oem_ein is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.oem_einSpecified) {
                								
                // If the oem_ein is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.oem_ein);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.oem_ein.Text = formattedValue;
                   
            } 
            
            else {
            
                // oem_ein is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.oem_ein.Text = Equipment_loadTable.oem_ein.Format(Equipment_loadTable.oem_ein.DefaultValue);
            		
            }
            
            // If the oem_ein is NULL or blank, then use the value specified  
            // on Properties.
            if (this.oem_ein.Text == null ||
                this.oem_ein.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.oem_ein.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproposed()
        {
            
                    
            // Set the proposed Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.proposed is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.proposedSpecified) {
                								
                // If the proposed is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.proposed, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.proposed.Text = formattedValue;
                   
            } 
            
            else {
            
                // proposed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.proposed.Text = Equipment_loadTable.proposed.Format(Equipment_loadTable.proposed.DefaultValue, @"C");
            		
            }
            
            // If the proposed is NULL or blank, then use the value specified  
            // on Properties.
            if (this.proposed.Text == null ||
                this.proposed.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.proposed.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpurchase()
        {
            
                    
            // Set the purchase Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.purchase is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchaseSpecified) {
                								
                // If the purchase is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.purchase, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.purchase.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase.Text = Equipment_loadTable.purchase.Format(Equipment_loadTable.purchase.DefaultValue, @"C");
            		
            }
            
            // If the purchase is NULL or blank, then use the value specified  
            // on Properties.
            if (this.purchase.Text == null ||
                this.purchase.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.purchase.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setreceived_from()
        {
            
                    
            // Set the received_from Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.received_from is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.received_fromSpecified) {
                								
                // If the received_from is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.received_from);
                                
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
                        String name = HttpUtility.HtmlEncode(Equipment_loadTable.received_from.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Equipment_loadTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"received_from\\\", \\\"received_from\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.received_from.Text = formattedValue;
                   
            } 
            
            else {
            
                // received_from is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.received_from.Text = Equipment_loadTable.received_from.Format(Equipment_loadTable.received_from.DefaultValue);
            		
            }
            
            // If the received_from is NULL or blank, then use the value specified  
            // on Properties.
            if (this.received_from.Text == null ||
                this.received_from.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.received_from.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setserial_number()
        {
            
                    
            // Set the serial_number Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.serial_number is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.serial_number);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number.Text = Equipment_loadTable.serial_number.Format(Equipment_loadTable.serial_number.DefaultValue);
            		
            }
            
            // If the serial_number is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serial_number.Text == null ||
                this.serial_number.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serial_number.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setwarehouse()
        {
            
                    
            // Set the warehouse Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.warehouse is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouseSpecified) {
                								
                // If the warehouse is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.warehouse);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse.Text = Equipment_loadTable.warehouse.Format(Equipment_loadTable.warehouse.DefaultValue);
            		
            }
            
            // If the warehouse is NULL or blank, then use the value specified  
            // on Properties.
            if (this.warehouse.Text == null ||
                this.warehouse.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.warehouse.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setwarehouse_id()
        {
            
                    
            // Set the warehouse_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.warehouse_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouse_idSpecified) {
                								
                // If the warehouse_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.warehouse_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse_id.Text = Equipment_loadTable.warehouse_id.Format(Equipment_loadTable.warehouse_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setwarehouse_location()
        {
            
                    
            // Set the warehouse_location Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.warehouse_location is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouse_locationSpecified) {
                								
                // If the warehouse_location is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.warehouse_location);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse_location.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse_location is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse_location.Text = Equipment_loadTable.warehouse_location.Format(Equipment_loadTable.warehouse_location.DefaultValue);
            		
            }
            
            // If the warehouse_location is NULL or blank, then use the value specified  
            // on Properties.
            if (this.warehouse_location.Text == null ||
                this.warehouse_location.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.warehouse_location.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setwarehouse_location_id()
        {
            
                    
            // Set the warehouse_location_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_load database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_load record retrieved from the database.
            // this.warehouse_location_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouse_location_idSpecified) {
                								
                // If the warehouse_location_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_loadTable.warehouse_location_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse_location_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse_location_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse_location_id.Text = Equipment_loadTable.warehouse_location_id.Format(Equipment_loadTable.warehouse_location_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetconditionLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_receivedLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_soldLabel()
                  {
                  
                    
        }
                
        public virtual void SetdispositionLabel()
                  {
                  
                    
        }
                
        public virtual void Setequipment_invoice_advLabel()
                  {
                  
                    
        }
                
        public virtual void Setfinal_saleLabel()
                  {
                  
                    
        }
                
        public virtual void SetfoundLabel()
                  {
                  
                    
        }
                
        public virtual void SetmakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel()
                  {
                  
                    
        }
                
        public virtual void Setnew_categoryLabel()
                  {
                  
                    
        }
                
        public virtual void Setoem_einLabel()
                  {
                  
                    
        }
                
        public virtual void SetproposedLabel()
                  {
                  
                    
        }
                
        public virtual void SetpurchaseLabel()
                  {
                  
                    
        }
                
        public virtual void Setreceived_fromLabel()
                  {
                  
                    
        }
                
        public virtual void Setserial_numberLabel()
                  {
                  
                    
        }
                
        public virtual void Setwarehouse_locationLabel()
                  {
                  
                    
        }
                
        public virtual void SetwarehouseLabel()
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
                ((Equipment_loadTableControl)MiscUtils.GetParentControlObject(this, "Equipment_loadTableControl")).DataChanged = true;
                ((Equipment_loadTableControl)MiscUtils.GetParentControlObject(this, "Equipment_loadTableControl")).ResetData = true;
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
            Getcondition();
            Getcustno();
            Getdate_received();
            Getdate_sold();
            Getdisposition_Id();
            Getdotmed_active();
            Getdotmed_id();
            Getequipment_invoice_adv();
            Getfinal_sale();
            Getfound();
            Getlockkey();
            Getmake();
            Getmodel();
            Getnew_category();
            Getnew_category1();
            Getoem_ein();
            Getproposed();
            Getpurchase();
            Getreceived_from();
            Getserial_number();
            Getwarehouse();
            Getwarehouse_id();
            Getwarehouse_location();
            Getwarehouse_location_id();
        }
        
        
        public virtual void Getcategory_id()
        {
            
        }
                
        public virtual void Getcondition()
        {
            
        }
                
        public virtual void Getcustno()
        {
            
        }
                
        public virtual void Getdate_received()
        {
            
        }
                
        public virtual void Getdate_sold()
        {
            
        }
                
        public virtual void Getdisposition_Id()
        {
            
        }
                
        public virtual void Getdotmed_active()
        {
            
        }
                
        public virtual void Getdotmed_id()
        {
            
        }
                
        public virtual void Getequipment_invoice_adv()
        {
            
        }
                
        public virtual void Getfinal_sale()
        {
            
        }
                
        public virtual void Getfound()
        {
            
        }
                
        public virtual void Getlockkey()
        {
            
        }
                
        public virtual void Getmake()
        {
            
        }
                
        public virtual void Getmodel()
        {
            
        }
                
        public virtual void Getnew_category()
        {
            
        }
                
        public virtual void Getnew_category1()
        {
            
        }
                
        public virtual void Getoem_ein()
        {
            
        }
                
        public virtual void Getproposed()
        {
            
        }
                
        public virtual void Getpurchase()
        {
            
        }
                
        public virtual void Getreceived_from()
        {
            
        }
                
        public virtual void Getserial_number()
        {
            
        }
                
        public virtual void Getwarehouse()
        {
            
        }
                
        public virtual void Getwarehouse_id()
        {
            
        }
                
        public virtual void Getwarehouse_location()
        {
            
        }
                
        public virtual void Getwarehouse_location_id()
        {
            
        }
                

      // To customize, override this method in Equipment_loadTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_loadTableControl = false;
            hasFiltersEquipment_loadTableControl = hasFiltersEquipment_loadTableControl && false; // suppress warning
      
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
          Equipment_loadTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Equipment_loadTableControl)MiscUtils.GetParentControlObject(this, "Equipment_loadTableControl")).DataChanged = true;
            ((Equipment_loadTableControl)MiscUtils.GetParentControlObject(this, "Equipment_loadTableControl")).ResetData = true;
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
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
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
                return (string)this.ViewState["BaseEquipment_loadTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_loadTableControlRow_Rec"] = value;
            }
        }
        
        public Equipment_loadRecord DataSource {
            get {
                return (Equipment_loadRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal category_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal condition {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition");
            }
        }
            
        public System.Web.UI.WebControls.Literal conditionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "conditionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal custno {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
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
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton disposition {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition");
            }
        }
            
        public System.Web.UI.WebControls.Literal disposition_Id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition_Id");
            }
        }
            
        public System.Web.UI.WebControls.Literal dispositionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dispositionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal dotmed_active {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_active");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_id");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal equipment_invoice_adv {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_invoice_adv");
            }
        }
            
        public System.Web.UI.WebControls.Literal equipment_invoice_advLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_invoice_advLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal final_sale {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_sale");
            }
        }
            
        public System.Web.UI.WebControls.Literal final_saleLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_saleLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal found {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "found");
            }
        }
            
        public System.Web.UI.WebControls.Literal foundLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "foundLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal lockkey {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "lockkey");
            }
        }
            
        public System.Web.UI.WebControls.Literal make {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make");
            }
        }
            
        public System.Web.UI.WebControls.Literal makeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal model {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model");
            }
        }
            
        public System.Web.UI.WebControls.Literal modelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal new_category {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "new_category");
            }
        }
            
        public System.Web.UI.WebControls.Literal new_category1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "new_category1");
            }
        }
            
        public System.Web.UI.WebControls.Literal new_categoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "new_categoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal oem_ein {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_ein");
            }
        }
            
        public System.Web.UI.WebControls.Literal oem_einLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_einLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal proposed {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposed");
            }
        }
            
        public System.Web.UI.WebControls.Literal proposedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal purchase {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase");
            }
        }
            
        public System.Web.UI.WebControls.Literal purchaseLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchaseLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal received_from {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from");
            }
        }
            
        public System.Web.UI.WebControls.Literal received_fromLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_fromLabel");
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
        
        public System.Web.UI.WebControls.Literal warehouse {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_location {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_location_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_locationLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_locationLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal warehouseLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouseLabel");
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
        Equipment_loadRecord rec = null;
             
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
    Equipment_loadRecord rec = null;
    
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

        
        public virtual Equipment_loadRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_loadTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Equipment_loadTableControl control on the Show_Equipment_load_Table page.
// Do not modify this class. Instead override any method in Equipment_loadTableControl.
public class BaseEquipment_loadTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseEquipment_loadTableControl()
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
                if  (this.InSession(this.received_fromFilter)) 				
                    initialVal = this.GetFromSession(this.received_fromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"received_from\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] received_fromFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in received_fromFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.received_fromFilter.Items.Add(item);
                            this.received_fromFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.received_fromFilter.Items)
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
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
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
        
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ImportButton.Click += ImportButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
            
              this.received_fromFilter.SelectedIndexChanged += received_fromFilter_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.Equipment_loadRecord);
                      this.DataSource = (Equipment_loadRecord[])(alist.ToArray(myrec));
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
                    foreach (Equipment_loadTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Equipment_loadRecord);
                    this.DataSource = (Equipment_loadRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Equipment_loadRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Equipment_loadTable.Column1, true);          
            // selCols.Add(Equipment_loadTable.Column2, true);          
            // selCols.Add(Equipment_loadTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Equipment_loadTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Equipment_loadTable databaseTable = new Equipment_loadTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Equipment_loadRecord)) as Equipment_loadRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Equipment_loadTable.Column1, true);          
            // selCols.Add(Equipment_loadTable.Column2, true);          
            // selCols.Add(Equipment_loadTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Equipment_loadTable.GetRecordCount(join, where);
            else
            {
                Equipment_loadTable databaseTable = new Equipment_loadTable();
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
               

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_loadTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Equipment_loadTableControlRow recControl = (Equipment_loadTableControlRow)(repItem.FindControl("Equipment_loadTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                
                
                Setreceived_fromFilter();
                Setreceived_fromLabel1();
                
                SetSortByLabel();
                SetSortControl();
                
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetResetButton();
              
                SetWordButton();
              
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

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton.Attributes.Remove("onClick");
      
    }
  

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton"));
                                
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


            
            this.received_fromFilter.ClearSelection();
            
            this.SortControl.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
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
    
            // Bind the buttons for Equipment_loadTableControl pagination.
        
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
              
            foreach (Equipment_loadTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Equipment_loadTableControlRow recCtl in this.GetRecordControls()){
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
            Equipment_loadTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.received_fromFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.received_fromFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.received_fromFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(Equipment_loadTable.received_from, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_loadTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String received_fromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "received_fromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(received_fromFilterSelectedValue)) {

              
        if (received_fromFilterSelectedValue != null){
                        string[] received_fromFilteritemListFromSession = received_fromFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in received_fromFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(Equipment_loadTable.received_from, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      

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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_loadTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Equipment_loadTableControlRow recControl = (Equipment_loadTableControlRow)(repItem.FindControl("Equipment_loadTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Equipment_loadRecord rec = new Equipment_loadRecord();
        
                        if (recControl.category_id.Text != "") {
                            rec.Parse(recControl.category_id.Text, Equipment_loadTable.category_id);
                  }
                
                        if (recControl.condition.Text != "") {
                            rec.Parse(recControl.condition.Text, Equipment_loadTable.condition);
                  }
                
                        if (recControl.custno.Text != "") {
                            rec.Parse(recControl.custno.Text, Equipment_loadTable.custno);
                  }
                
                        if (recControl.date_received.Text != "") {
                            rec.Parse(recControl.date_received.Text, Equipment_loadTable.date_received);
                  }
                
                        if (recControl.date_sold.Text != "") {
                            rec.Parse(recControl.date_sold.Text, Equipment_loadTable.date_sold);
                  }
                
                        if (recControl.disposition.Text != "") {
                            rec.Parse(recControl.disposition.Text, Equipment_loadTable.disposition);
                  }
                
                        if (recControl.disposition_Id.Text != "") {
                            rec.Parse(recControl.disposition_Id.Text, Equipment_loadTable.disposition_Id);
                  }
                
                        if (recControl.dotmed_active.Text != "") {
                            rec.Parse(recControl.dotmed_active.Text, Equipment_loadTable.dotmed_active);
                  }
                
                        if (recControl.dotmed_id.Text != "") {
                            rec.Parse(recControl.dotmed_id.Text, Equipment_loadTable.dotmed_id);
                  }
                
                        if (recControl.equipment_invoice_adv.Text != "") {
                            rec.Parse(recControl.equipment_invoice_adv.Text, Equipment_loadTable.equipment_invoice_adv);
                  }
                
                        if (recControl.final_sale.Text != "") {
                            rec.Parse(recControl.final_sale.Text, Equipment_loadTable.final_sale);
                  }
                
                        if (recControl.found.Text != "") {
                            rec.Parse(recControl.found.Text, Equipment_loadTable.found);
                  }
                
                        if (recControl.lockkey.Text != "") {
                            rec.Parse(recControl.lockkey.Text, Equipment_loadTable.lockkey);
                  }
                
                        if (recControl.make.Text != "") {
                            rec.Parse(recControl.make.Text, Equipment_loadTable.make);
                  }
                
                        if (recControl.model.Text != "") {
                            rec.Parse(recControl.model.Text, Equipment_loadTable.model);
                  }
                
                        if (recControl.new_category.Text != "") {
                            rec.Parse(recControl.new_category.Text, Equipment_loadTable.new_category);
                  }
                
                        if (recControl.new_category1.Text != "") {
                            rec.Parse(recControl.new_category1.Text, Equipment_loadTable.new_category);
                  }
                
                        if (recControl.oem_ein.Text != "") {
                            rec.Parse(recControl.oem_ein.Text, Equipment_loadTable.oem_ein);
                  }
                
                        if (recControl.proposed.Text != "") {
                            rec.Parse(recControl.proposed.Text, Equipment_loadTable.proposed);
                  }
                
                        if (recControl.purchase.Text != "") {
                            rec.Parse(recControl.purchase.Text, Equipment_loadTable.purchase);
                  }
                
                        if (recControl.received_from.Text != "") {
                            rec.Parse(recControl.received_from.Text, Equipment_loadTable.received_from);
                  }
                
                        if (recControl.serial_number.Text != "") {
                            rec.Parse(recControl.serial_number.Text, Equipment_loadTable.serial_number);
                  }
                
                        if (recControl.warehouse.Text != "") {
                            rec.Parse(recControl.warehouse.Text, Equipment_loadTable.warehouse);
                  }
                
                        if (recControl.warehouse_id.Text != "") {
                            rec.Parse(recControl.warehouse_id.Text, Equipment_loadTable.warehouse_id);
                  }
                
                        if (recControl.warehouse_location.Text != "") {
                            rec.Parse(recControl.warehouse_location.Text, Equipment_loadTable.warehouse_location);
                  }
                
                        if (recControl.warehouse_location_id.Text != "") {
                            rec.Parse(recControl.warehouse_location_id.Text, Equipment_loadTable.warehouse_location_id);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Equipment_loadRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Equipment_loadRecord);
                this.DataSource = (Equipment_loadRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Equipment_loadTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Equipment_loadTableControlRow rec)            
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
        
        public virtual void Setreceived_fromLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetSortControl()
        {
            
                this.PopulateSortControl(MiscUtils.GetSelectedValue(this.SortControl,  GetFromSession(this.SortControl)), 500);					
                    

        }
            
        public virtual void Setreceived_fromFilter()
        {
            
            ArrayList received_fromFilterselectedFilterItemList = new ArrayList();
            string received_fromFilteritemsString = null;
            if (this.InSession(this.received_fromFilter))
                received_fromFilteritemsString = this.GetFromSession(this.received_fromFilter);
            
            if (received_fromFilteritemsString != null)
            {
                string[] received_fromFilteritemListFromSession = received_fromFilteritemsString.Split(',');
                foreach (string item in received_fromFilteritemListFromSession)
                {
                    received_fromFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.Populatereceived_fromFilter(MiscUtils.GetSelectedValueList(this.received_fromFilter, received_fromFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../equipment_load/Equipment-load-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.received_fromFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("received_from")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.received_fromFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(received_fromFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for SortControl.
                
        protected virtual void PopulateSortControl(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Ascending}"), "condition Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Descending}"), "condition Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Received {Txt:Ascending}"), "date_received Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Received {Txt:Descending}"), "date_received Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Sold {Txt:Ascending}"), "date_sold Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Sold {Txt:Descending}"), "date_sold Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice ADV {Txt:Ascending}"), "equipment_invoice_adv Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice ADV {Txt:Descending}"), "equipment_invoice_adv Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Final Sale {Txt:Ascending}"), "final_sale Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Final Sale {Txt:Descending}"), "final_sale Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Ascending}"), "make Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Descending}"), "make Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Ascending}"), "model Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Descending}"), "model Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Proposed {Txt:Ascending}"), "proposed Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Proposed {Txt:Descending}"), "proposed Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Received From {Txt:Ascending}"), "received_from Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Received From {Txt:Descending}"), "received_from Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse Location {Txt:Ascending}"), "warehouse_location_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse Location {Txt:Descending}"), "warehouse_location_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Ascending}"), "category_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Category {Txt:Descending}"), "category_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custno {Txt:Ascending}"), "custno Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custno {Txt:Descending}"), "custno Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Lock Key {Txt:Ascending}"), "lockkey Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Lock Key {Txt:Descending}"), "lockkey Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("MAK Key {Txt:Ascending}"), "makkey Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("MAK Key {Txt:Descending}"), "makkey Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse {Txt:Ascending}"), "warehouse_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse {Txt:Descending}"), "warehouse_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Dotmed {Txt:Ascending}"), "dotmed_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Dotmed {Txt:Descending}"), "dotmed_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Disposition Id {Txt:Ascending}"), "disposition_Id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Disposition Id {Txt:Descending}"), "disposition_Id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Dotmed Active {Txt:Ascending}"), "dotmed_active Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Dotmed Active {Txt:Descending}"), "dotmed_active Desc"));
              
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
            
        // Get the filters' data for received_fromFilter.
                
        protected virtual void Populatereceived_fromFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_received_fromFilter();            
            this.received_fromFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_received_fromFilter function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Equipment_loadTable.received_from, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Equipment_loadTable.GetValues(Equipment_loadTable.received_from, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Equipment_loadTable.received_from.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Equipment_loadTable.received_from.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.received_fromFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.received_fromFilter.Items.Add(newItem);

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
            
            
            this.received_fromFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.received_fromFilter.Items.Count == 0)
                this.received_fromFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.received_fromFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_received_fromFilter()
        {
            // Create a where clause for the filter received_fromFilter.
            // This function is called by the Populate method to load the items 
            // in the received_fromFilterQuickSelector
        
            ArrayList received_fromFilterselectedFilterItemList = new ArrayList();
            string received_fromFilteritemsString = null;
            if (this.InSession(this.received_fromFilter))
                received_fromFilteritemsString = this.GetFromSession(this.received_fromFilter);
            
            if (received_fromFilteritemsString != null)
            {
                string[] received_fromFilteritemListFromSession = received_fromFilteritemsString.Split(',');
                foreach (string item in received_fromFilteritemListFromSession)
                {
                    received_fromFilterselectedFilterItemList.Add(item);
                }
            }
              
            received_fromFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.received_fromFilter, received_fromFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (received_fromFilterselectedFilterItemList == null || received_fromFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in received_fromFilterselectedFilterItemList)
                {
            
      
   
                    wc.iOR(Equipment_loadTable.received_from, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
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
            // Save filter controls to values to session.
        
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
            ArrayList received_fromFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.received_fromFilter, null);
            string received_fromFilterSessionString = "";
            if (received_fromFilterselectedFilterItemList != null){
                foreach (string item in received_fromFilterselectedFilterItemList){
                    received_fromFilterSessionString = String.Concat(received_fromFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.received_fromFilter, received_fromFilterSessionString);
                  
            
                    
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
                  
            ArrayList received_fromFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.received_fromFilter, null);
            string received_fromFilterSessionString = "";
            if (received_fromFilterselectedFilterItemList != null){
                foreach (string item in received_fromFilterselectedFilterItemList){
                    received_fromFilterSessionString = String.Concat(received_fromFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("received_fromFilter_Ajax", received_fromFilterSessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.received_fromFilter);
            
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

            string orderByStr = (string)ViewState["Equipment_loadTableControl_OrderBy"];
          
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
                this.ViewState["Equipment_loadTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetImportButton()                
              
        {
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=Equipment_load" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Equipment_loadTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Equipment_loadTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
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
    
      
            if (MiscUtils.IsValueSelected(received_fromFilter))
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
        

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void ExcelButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            
            // To customize the columns or the format, override this function in Section 1 of the page
            // and modify it to your liking.
            // Build the where clause based on the current filter and search criteria
            // Create the Order By clause based on the user's current sorting preference.
            
                WhereClause wc = null;
                wc = CreateWhereClause();
                OrderBy orderBy = null;
              
                orderBy = CreateOrderBy();
              
              bool done = false;
              object val = "";
              CompoundFilter join = CreateCompoundJoinFilter();
              
              // Read pageSize records at a time and write out the Excel file.
              int totalRowsReturned = 0;


              this.TotalRecords = Equipment_loadTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Equipment_loadTable.date_received,
             Equipment_loadTable.received_from,
             Equipment_loadTable.custno,
             Equipment_loadTable.make,
             Equipment_loadTable.model,
             Equipment_loadTable.serial_number,
             Equipment_loadTable.condition,
             Equipment_loadTable.lockkey,
             Equipment_loadTable.purchase,
             Equipment_loadTable.disposition,
             Equipment_loadTable.disposition_Id,
             Equipment_loadTable.proposed,
             Equipment_loadTable.date_sold,
             Equipment_loadTable.final_sale,
             Equipment_loadTable.oem_ein,
             Equipment_loadTable.found,
             Equipment_loadTable.equipment_invoice_adv,
             Equipment_loadTable.new_category,
             Equipment_loadTable.category_id,
             Equipment_loadTable.dotmed_active,
             Equipment_loadTable.warehouse,
             Equipment_loadTable.warehouse_id,
             Equipment_loadTable.warehouse_location,
             Equipment_loadTable.warehouse_location_id,
             Equipment_loadTable.dotmed_id,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Equipment_loadTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Equipment_loadTable.Instance, wc, orderBy, columns,join);

                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = dataForCSV.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in dataForCSV.ColumnList)
                {
                if (col == null)
                continue;

                if (!dataForCSV.IncludeInExport(col))
                continue;

                val = rec.GetValue(col).ToString();
                exportData.WriteColumnData(val, dataForCSV.IsString(col));
                }
                exportData.WriteNewRow();
                }

                //  If we already are below the pageSize, then we are done.
                if (totalRowsReturned < exportData.pageSize)
                {
                done = true;
                }
                }
                exportData.FinishExport(this.Page.Response);
              
              }
              else
              {
              // Create an instance of the ExportDataToExcel class with the table class, where clause and order by.
              ExportDataToExcel excelReport = new ExportDataToExcel(Equipment_loadTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Equipment_loadTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.date_received, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.received_from, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.custno, "0"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.make, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.model, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.serial_number, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.condition, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.lockkey, "0"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.purchase, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.disposition, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.disposition_Id, "0"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.proposed, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.date_sold, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.final_sale, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.oem_ein, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.found, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.equipment_invoice_adv, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.new_category, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.category_id, "0"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.dotmed_active, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.warehouse, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.warehouse_id, "0"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.warehouse_location, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.warehouse_location_id, "0"));
             data.ColumnList.Add(new ExcelColumn(Equipment_loadTable.dotmed_id, "0"));


              //  First write out the Column Headers
              foreach (ExcelColumn col in data.ColumnList)
              {
              width = excelReport.GetExcelCellWidth(col);
              if (data.IncludeInExport(col))
              {
              excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col));
              columnCounter++;
              }
              }
              
              while (!done)
              {
              ArrayList recList = data.GetRows(excelReport.pageSize);

              if (recList == null)
              {
              break;
              }
              totalRowsReturned = recList.Count;

              foreach (BaseRecord rec in recList)
              {
              excelReport.AddRowToExcelBook();
              columnCounter = 0;
              foreach (ExcelColumn col in data.ColumnList)
              {
              if (!data.IncludeInExport(col))
              continue;

              Boolean _isExpandableNonCompositeForeignKey = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn);
              if (_isExpandableNonCompositeForeignKey && col.DisplayColumn.IsApplyDisplayAs)
              {
                val = Equipment_loadTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
                if (String.IsNullOrEmpty(val as string))
                {
                  val = rec.Format(col.DisplayColumn);
                }
              }
              else
                val = excelReport.GetValueForExcelExport(col, rec);
              
              excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat);

              columnCounter++;
              }
              }

              // If we already are below the pageSize, then we are done.
              if (totalRowsReturned < excelReport.pageSize)
              {
              done = true;
              }
              }
              excelReport.SaveExcelBook(this.Page.Response);
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
        public virtual void ImportButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
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
        public virtual void NewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Equipment_loadTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Equipment_loadTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-Equipment-load-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "equipment_load";
                // If Show-Equipment-load-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Equipment_loadTable.date_received.Name, ReportEnum.Align.Left, "${date_received}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_loadTable.received_from.Name, ReportEnum.Align.Left, "${received_from}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.custno.Name, ReportEnum.Align.Right, "${custno}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.make.Name, ReportEnum.Align.Left, "${make}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.model.Name, ReportEnum.Align.Left, "${model}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.condition.Name, ReportEnum.Align.Left, "${condition}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.lockkey.Name, ReportEnum.Align.Right, "${lockkey}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.purchase.Name, ReportEnum.Align.Right, "${purchase}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_loadTable.disposition.Name, ReportEnum.Align.Left, "${disposition}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.disposition_Id.Name, ReportEnum.Align.Right, "${disposition_Id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.proposed.Name, ReportEnum.Align.Right, "${proposed}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_loadTable.date_sold.Name, ReportEnum.Align.Left, "${date_sold}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_loadTable.final_sale.Name, ReportEnum.Align.Right, "${final_sale}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_loadTable.oem_ein.Name, ReportEnum.Align.Left, "${oem_ein}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.found.Name, ReportEnum.Align.Left, "${found}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.equipment_invoice_adv.Name, ReportEnum.Align.Left, "${equipment_invoice_adv}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.new_category.Name, ReportEnum.Align.Left, "${new_category}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.category_id.Name, ReportEnum.Align.Right, "${category_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.dotmed_active.Name, ReportEnum.Align.Left, "${dotmed_active}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.warehouse.Name, ReportEnum.Align.Left, "${warehouse}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.warehouse_id.Name, ReportEnum.Align.Right, "${warehouse_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.warehouse_location.Name, ReportEnum.Align.Left, "${warehouse_location}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.warehouse_location_id.Name, ReportEnum.Align.Right, "${warehouse_location_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.dotmed_id.Name, ReportEnum.Align.Right, "${dotmed_id}", ReportEnum.Align.Right, 15);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Equipment_loadTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Equipment_loadTable.GetRecordCount(joinFilter,whereClause);
                Equipment_loadRecord[] records = null;
                
                do
                {
                    
                    records = Equipment_loadTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Equipment_loadRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${date_received}", record.Format(Equipment_loadTable.date_received), ReportEnum.Align.Left, 300);
                             report.AddData("${received_from}", record.Format(Equipment_loadTable.received_from), ReportEnum.Align.Left, 300);
                             report.AddData("${custno}", record.Format(Equipment_loadTable.custno), ReportEnum.Align.Right, 300);
                             report.AddData("${make}", record.Format(Equipment_loadTable.make), ReportEnum.Align.Left, 300);
                             report.AddData("${model}", record.Format(Equipment_loadTable.model), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Equipment_loadTable.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${condition}", record.Format(Equipment_loadTable.condition), ReportEnum.Align.Left, 300);
                             report.AddData("${lockkey}", record.Format(Equipment_loadTable.lockkey), ReportEnum.Align.Right, 300);
                             report.AddData("${purchase}", record.Format(Equipment_loadTable.purchase), ReportEnum.Align.Right, 300);
                             report.AddData("${disposition}", record.Format(Equipment_loadTable.disposition), ReportEnum.Align.Left);
                             report.AddData("${disposition_Id}", record.Format(Equipment_loadTable.disposition_Id), ReportEnum.Align.Right, 300);
                             report.AddData("${proposed}", record.Format(Equipment_loadTable.proposed), ReportEnum.Align.Right, 300);
                             report.AddData("${date_sold}", record.Format(Equipment_loadTable.date_sold), ReportEnum.Align.Left, 300);
                             report.AddData("${final_sale}", record.Format(Equipment_loadTable.final_sale), ReportEnum.Align.Right, 300);
                             report.AddData("${oem_ein}", record.Format(Equipment_loadTable.oem_ein), ReportEnum.Align.Left, 300);
                             report.AddData("${found}", record.Format(Equipment_loadTable.found), ReportEnum.Align.Left, 300);
                             report.AddData("${equipment_invoice_adv}", record.Format(Equipment_loadTable.equipment_invoice_adv), ReportEnum.Align.Left, 300);
                             report.AddData("${new_category}", record.Format(Equipment_loadTable.new_category), ReportEnum.Align.Left, 300);
                             report.AddData("${category_id}", record.Format(Equipment_loadTable.category_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_active}", record.Format(Equipment_loadTable.dotmed_active), ReportEnum.Align.Left, 300);
                             report.AddData("${warehouse}", record.Format(Equipment_loadTable.warehouse), ReportEnum.Align.Left, 300);
                             report.AddData("${warehouse_id}", record.Format(Equipment_loadTable.warehouse_id), ReportEnum.Align.Right, 300);
                             report.AddData("${warehouse_location}", record.Format(Equipment_loadTable.warehouse_location), ReportEnum.Align.Left, 300);
                             report.AddData("${warehouse_location_id}", record.Format(Equipment_loadTable.warehouse_location_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_id}", record.Format(Equipment_loadTable.dotmed_id), ReportEnum.Align.Right, 300);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                	
                
                report.Close();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true);
            
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
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.received_fromFilter.ClearSelection();
            
           
            this.SortControl.ClearSelection();
          
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
                  
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
                
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-Equipment-load-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "equipment_load";
                // If Show-Equipment-load-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Equipment_loadTable.date_received.Name, ReportEnum.Align.Left, "${date_received}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_loadTable.received_from.Name, ReportEnum.Align.Left, "${received_from}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.custno.Name, ReportEnum.Align.Right, "${custno}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.make.Name, ReportEnum.Align.Left, "${make}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.model.Name, ReportEnum.Align.Left, "${model}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.condition.Name, ReportEnum.Align.Left, "${condition}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.lockkey.Name, ReportEnum.Align.Right, "${lockkey}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.purchase.Name, ReportEnum.Align.Right, "${purchase}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_loadTable.disposition.Name, ReportEnum.Align.Left, "${disposition}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.disposition_Id.Name, ReportEnum.Align.Right, "${disposition_Id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.proposed.Name, ReportEnum.Align.Right, "${proposed}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_loadTable.date_sold.Name, ReportEnum.Align.Left, "${date_sold}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_loadTable.final_sale.Name, ReportEnum.Align.Right, "${final_sale}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_loadTable.oem_ein.Name, ReportEnum.Align.Left, "${oem_ein}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.found.Name, ReportEnum.Align.Left, "${found}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.equipment_invoice_adv.Name, ReportEnum.Align.Left, "${equipment_invoice_adv}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.new_category.Name, ReportEnum.Align.Left, "${new_category}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.category_id.Name, ReportEnum.Align.Right, "${category_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.dotmed_active.Name, ReportEnum.Align.Left, "${dotmed_active}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.warehouse.Name, ReportEnum.Align.Left, "${warehouse}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.warehouse_id.Name, ReportEnum.Align.Right, "${warehouse_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.warehouse_location.Name, ReportEnum.Align.Left, "${warehouse_location}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_loadTable.warehouse_location_id.Name, ReportEnum.Align.Right, "${warehouse_location_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Equipment_loadTable.dotmed_id.Name, ReportEnum.Align.Right, "${dotmed_id}", ReportEnum.Align.Right, 15);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Equipment_loadTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Equipment_loadTable.GetColumnList();
                Equipment_loadRecord[] records = null;
                do
                {
                    records = Equipment_loadTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Equipment_loadRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${date_received}", record.Format(Equipment_loadTable.date_received), ReportEnum.Align.Left, 300);
                             report.AddData("${received_from}", record.Format(Equipment_loadTable.received_from), ReportEnum.Align.Left, 300);
                             report.AddData("${custno}", record.Format(Equipment_loadTable.custno), ReportEnum.Align.Right, 300);
                             report.AddData("${make}", record.Format(Equipment_loadTable.make), ReportEnum.Align.Left, 300);
                             report.AddData("${model}", record.Format(Equipment_loadTable.model), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Equipment_loadTable.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${condition}", record.Format(Equipment_loadTable.condition), ReportEnum.Align.Left, 300);
                             report.AddData("${lockkey}", record.Format(Equipment_loadTable.lockkey), ReportEnum.Align.Right, 300);
                             report.AddData("${purchase}", record.Format(Equipment_loadTable.purchase), ReportEnum.Align.Right, 300);
                             report.AddData("${disposition}", record.Format(Equipment_loadTable.disposition), ReportEnum.Align.Left);
                             report.AddData("${disposition_Id}", record.Format(Equipment_loadTable.disposition_Id), ReportEnum.Align.Right, 300);
                             report.AddData("${proposed}", record.Format(Equipment_loadTable.proposed), ReportEnum.Align.Right, 300);
                             report.AddData("${date_sold}", record.Format(Equipment_loadTable.date_sold), ReportEnum.Align.Left, 300);
                             report.AddData("${final_sale}", record.Format(Equipment_loadTable.final_sale), ReportEnum.Align.Right, 300);
                             report.AddData("${oem_ein}", record.Format(Equipment_loadTable.oem_ein), ReportEnum.Align.Left, 300);
                             report.AddData("${found}", record.Format(Equipment_loadTable.found), ReportEnum.Align.Left, 300);
                             report.AddData("${equipment_invoice_adv}", record.Format(Equipment_loadTable.equipment_invoice_adv), ReportEnum.Align.Left, 300);
                             report.AddData("${new_category}", record.Format(Equipment_loadTable.new_category), ReportEnum.Align.Left, 300);
                             report.AddData("${category_id}", record.Format(Equipment_loadTable.category_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_active}", record.Format(Equipment_loadTable.dotmed_active), ReportEnum.Align.Left, 300);
                             report.AddData("${warehouse}", record.Format(Equipment_loadTable.warehouse), ReportEnum.Align.Left, 300);
                             report.AddData("${warehouse_id}", record.Format(Equipment_loadTable.warehouse_id), ReportEnum.Align.Right, 300);
                             report.AddData("${warehouse_location}", record.Format(Equipment_loadTable.warehouse_location), ReportEnum.Align.Left, 300);
                             report.AddData("${warehouse_location_id}", record.Format(Equipment_loadTable.warehouse_location_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_id}", record.Format(Equipment_loadTable.dotmed_id), ReportEnum.Align.Right, 300);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                report.save();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true);
          
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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Equipment_loadTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Equipment_loadTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Equipment_loadTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Equipment_loadTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Equipment_loadTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Equipment_loadTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void received_fromFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Equipment_loadTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Equipment_loadRecord[] DataSource {
             
            get {
                return (Equipment_loadRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
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
        
        public System.Web.UI.WebControls.ImageButton ImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton");
            }
        }
        
        public OEMConversion.UI.IPaginationModern Pagination {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector received_fromFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_fromFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal received_fromLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_fromLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
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
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton WordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton");
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
                Equipment_loadTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_loadRecord rec = null;
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
                Equipment_loadTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_loadRecord rec = null;
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
          
        public virtual Equipment_loadTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Equipment_loadTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Equipment_loadTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Equipment_load_Table.Equipment_loadTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Equipment_loadTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Equipment_loadTableControlRow recCtl in recordList)
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

        public virtual Equipment_loadTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Equipment_loadTableControlRow");
	          List<Equipment_loadTableControlRow> list = new List<Equipment_loadTableControlRow>();
	          foreach (Equipment_loadTableControlRow recCtrl in recCtrls) {
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
  

#endregion
    
  
}

  