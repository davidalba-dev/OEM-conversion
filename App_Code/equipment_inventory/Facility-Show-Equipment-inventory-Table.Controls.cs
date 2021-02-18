
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Facility_Show_Equipment_inventory_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Facility_Show_Equipment_inventory_Table
{
  

#region "Section 1: Place your customizations here."

    
//public class Equipment_inventoryTableControlRow : BaseEquipment_inventoryTableControlRow
//{
//      
//        // The BaseEquipment_inventoryTableControlRow implements code for a ROW within the
//        // the Equipment_inventoryTableControl table.  The BaseEquipment_inventoryTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of Equipment_inventoryTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class Equipment_inventoryTableControl : BaseEquipment_inventoryTableControl
//{
//    // The BaseEquipment_inventoryTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The Equipment_inventoryTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//

  

public class Vw_customer_equip_inventoryTableControl : BaseVw_customer_equip_inventoryTableControl
{
    // The BaseVw_customer_equip_inventoryTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Vw_customer_equip_inventoryTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}
public class Vw_customer_equip_inventoryTableControlRow : BaseVw_customer_equip_inventoryTableControlRow
{
      
        // The BaseVw_customer_equip_inventoryTableControlRow implements code for a ROW within the
        // the Vw_customer_equip_inventoryTableControl table.  The BaseVw_customer_equip_inventoryTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Vw_customer_equip_inventoryTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
public class Vw_customer_equip_inventoryTableControl1 : BaseVw_customer_equip_inventoryTableControl1
{
    // The BaseVw_customer_equip_inventoryTableControl1 class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Vw_customer_equip_inventoryTableControl1Row class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}
public class Vw_customer_equip_inventoryTableControl1Row : BaseVw_customer_equip_inventoryTableControl1Row
{
      
        // The BaseVw_customer_equip_inventoryTableControl1Row implements code for a ROW within the
        // the Vw_customer_equip_inventoryTableControl1 table.  The BaseVw_customer_equip_inventoryTableControl1Row implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Vw_customer_equip_inventoryTableControl1.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Vw_customer_equip_inventoryTableControlRow control on the Facility_Show_Equipment_inventory_Table page.
// Do not modify this class. Instead override any method in Vw_customer_equip_inventoryTableControlRow.
public class BaseVw_customer_equip_inventoryTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseVw_customer_equip_inventoryTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Vw_customer_equip_inventoryTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Vw_customer_equip_inventoryTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Vw_customer_equip_inventoryView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseVw_customer_equip_inventoryTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Vw_customer_equip_inventoryRecord();
            
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
                Setcondition_id();
                Setdate_received();
                Setdate_receivedLabel();
                Setdate_sold();
                Setdate_soldLabel();
                Setdisposition_id();
                Setequipment_inventory_pic1();
                Setfinal_sale_price();
                Setfinal_sale_priceLabel();
                Setmake_id();
                Setmake_idLabel1();
                Setmodel_id();
                Setmodel_idLabel();
                Setnew_category_id();
                Setproposed_sale_price();
                Setproposed_sale_priceLabel();
                Setpurchase_price();
                Setpurchase_priceLabel();
                Setsale_method_id();
                Setserial_number();
                
                Setwarehouse_id();
                Setwarehouse_idLabel();
                Setwarehouse_location_id();
                Setwarehouse_location_idLabel();
                SetViewRowButton();
              

      

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
        
        
        public virtual void Setcondition_id()
        {
            
                    
            // Set the condition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.condition_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.condition_idSpecified) {
                								
                // If the condition_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.condition_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.condition_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.condition_id.Text = Vw_customer_equip_inventoryView.condition_id.Format(Vw_customer_equip_inventoryView.condition_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setdate_received()
        {
            
                    
            // Set the date_received Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.date_received is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_receivedSpecified) {
                								
                // If the date_received is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.date_received, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_received.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_received is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_received.Text = Vw_customer_equip_inventoryView.date_received.Format(Vw_customer_equip_inventoryView.date_received.DefaultValue, @"d");
            		
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
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.date_sold is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_soldSpecified) {
                								
                // If the date_sold is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.date_sold, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_sold.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_sold is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_sold.Text = Vw_customer_equip_inventoryView.date_sold.Format(Vw_customer_equip_inventoryView.date_sold.DefaultValue, @"d");
            		
            }
            
            // If the date_sold is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_sold.Text == null ||
                this.date_sold.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_sold.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdisposition_id()
        {
            
                    
            // Set the disposition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.disposition_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.disposition_idSpecified) {
                								
                // If the disposition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.disposition_id);
               if(_isExpandableNonCompositeForeignKey &&Vw_customer_equip_inventoryView.disposition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Vw_customer_equip_inventoryView.GetDFKA(this.DataSource.disposition_id.ToString(),Vw_customer_equip_inventoryView.disposition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.disposition_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.disposition_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // disposition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.disposition_id.Text = Vw_customer_equip_inventoryView.disposition_id.Format(Vw_customer_equip_inventoryView.disposition_id.DefaultValue);
            		
            }
            
            // If the disposition_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.disposition_id.Text == null ||
                this.disposition_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.disposition_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setequipment_inventory_pic1()
        {
            // Set the equipment_inventory_pic1 Image on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.equipment_inventory_pic1 is the ASP:Image on the webpage.

            if (this.DataSource != null && this.DataSource.equipment_inventory_pic1Specified) {
                // If the equipment_inventory_pic1 is non-NULL, then format the value.
                // The Format method will use the Display Format
                  String name = HttpUtility.HtmlEncode(Vw_customer_equip_inventoryView.equipment_inventory_pic1.Name);

                  if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                      name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                  }

                  this.equipment_inventory_pic1.Attributes.Add("onclick", "gPersist=true;");
                  this.equipment_inventory_pic1.Attributes.Add("onmouseout","detailRolloverPopupClose();");
                  this.equipment_inventory_pic1.Attributes.Add("onmouseover","SaveMousePosition(event);delayRolloverPopup(\"PageMethods.GetImage(\\\"" + "NULL" +
                  "\\\", \\\"" + this.Page.Encrypt("Vw_customer_equip_inventory") +
                  "\\\", \\\"" + this.Page.Encrypt(HttpUtility.UrlEncode(this.DataSource.GetID().ToString())) + 
                  "\\\", \\\"" + this.Page.Encrypt("equipment_inventory_pic1") + "\\\", \\\"" + NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length))+ "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", false, 600," +
                  " 800, true, PopupDisplayWindowCallBackWith20);\", 500);");
                        
                // Shrunk image size specified by ImagePercentSize on Properties.
                this.equipment_inventory_pic1.ImageUrl = this.DataSource.FormatImageUrl(Vw_customer_equip_inventoryView.equipment_inventory_pic1, this.Page.Encrypt("Vw_customer_equip_inventory"), this.Page.Encrypt("equipment_inventory_pic1"), this.Page.Encrypt(this.DataSource.GetID().ToXmlString()), 25);
                            
                this.equipment_inventory_pic1.Visible = true;
                                    
            } 
            else {
                // equipment_inventory_pic1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                this.equipment_inventory_pic1.Visible = false;
            }
                     
        }
                
        public virtual void Setfinal_sale_price()
        {
            
                    
            // Set the final_sale_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.final_sale_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.final_sale_priceSpecified) {
                								
                // If the final_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.final_sale_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.final_sale_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // final_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.final_sale_price.Text = Vw_customer_equip_inventoryView.final_sale_price.Format(Vw_customer_equip_inventoryView.final_sale_price.DefaultValue, @"C");
            		
            }
            
            // If the final_sale_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.final_sale_price.Text == null ||
                this.final_sale_price.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.final_sale_price.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setmake_id()
        {
            
                    
            // Set the make_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.make_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.make_idSpecified) {
                								
                // If the make_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.make_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.make_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // make_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make_id.Text = Vw_customer_equip_inventoryView.make_id.Format(Vw_customer_equip_inventoryView.make_id.DefaultValue);
            		
            }
            
            // If the make_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.make_id.Text == null ||
                this.make_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.make_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setmodel_id()
        {
            
                    
            // Set the model_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.model_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.model_idSpecified) {
                								
                // If the model_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.model_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.model_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // model_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model_id.Text = Vw_customer_equip_inventoryView.model_id.Format(Vw_customer_equip_inventoryView.model_id.DefaultValue);
            		
            }
            
            // If the model_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.model_id.Text == null ||
                this.model_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.model_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setnew_category_id()
        {
            
                    
            // Set the new_category_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.new_category_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.new_category_idSpecified) {
                								
                // If the new_category_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.new_category_id);
               if(_isExpandableNonCompositeForeignKey &&Vw_customer_equip_inventoryView.new_category_id.IsApplyDisplayAs)
                                  
                     formattedValue = Vw_customer_equip_inventoryView.GetDFKA(this.DataSource.new_category_id.ToString(),Vw_customer_equip_inventoryView.new_category_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.new_category_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.new_category_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // new_category_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.new_category_id.Text = Vw_customer_equip_inventoryView.new_category_id.Format(Vw_customer_equip_inventoryView.new_category_id.DefaultValue);
            		
            }
            
            // If the new_category_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.new_category_id.Text == null ||
                this.new_category_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.new_category_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproposed_sale_price()
        {
            
                    
            // Set the proposed_sale_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.proposed_sale_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.proposed_sale_priceSpecified) {
                								
                // If the proposed_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.proposed_sale_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.proposed_sale_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // proposed_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.proposed_sale_price.Text = Vw_customer_equip_inventoryView.proposed_sale_price.Format(Vw_customer_equip_inventoryView.proposed_sale_price.DefaultValue, @"C");
            		
            }
            
            // If the proposed_sale_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.proposed_sale_price.Text == null ||
                this.proposed_sale_price.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.proposed_sale_price.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpurchase_price()
        {
            
                    
            // Set the purchase_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.purchase_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchase_priceSpecified) {
                								
                // If the purchase_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.purchase_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.purchase_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase_price.Text = Vw_customer_equip_inventoryView.purchase_price.Format(Vw_customer_equip_inventoryView.purchase_price.DefaultValue, @"C");
            		
            }
            
            // If the purchase_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.purchase_price.Text == null ||
                this.purchase_price.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.purchase_price.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setsale_method_id()
        {
            
                    
            // Set the sale_method_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.sale_method_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.sale_method_idSpecified) {
                								
                // If the sale_method_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.sale_method_id);
               if(_isExpandableNonCompositeForeignKey &&Vw_customer_equip_inventoryView.sale_method_id.IsApplyDisplayAs)
                                  
                     formattedValue = Vw_customer_equip_inventoryView.GetDFKA(this.DataSource.sale_method_id.ToString(),Vw_customer_equip_inventoryView.sale_method_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.sale_method_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.sale_method_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // sale_method_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.sale_method_id.Text = Vw_customer_equip_inventoryView.sale_method_id.Format(Vw_customer_equip_inventoryView.sale_method_id.DefaultValue);
            		
            }
            
            // If the sale_method_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.sale_method_id.Text == null ||
                this.sale_method_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.sale_method_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setserial_number()
        {
            
                    
            // Set the serial_number Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.serial_number is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.serial_number);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number.Text = Vw_customer_equip_inventoryView.serial_number.Format(Vw_customer_equip_inventoryView.serial_number.DefaultValue);
            		
            }
            
            // If the serial_number is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serial_number.Text == null ||
                this.serial_number.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serial_number.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setwarehouse_id()
        {
            
                    
            // Set the warehouse_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.warehouse_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouse_idSpecified) {
                								
                // If the warehouse_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_id);
               if(_isExpandableNonCompositeForeignKey &&Vw_customer_equip_inventoryView.warehouse_id.IsApplyDisplayAs)
                                  
                     formattedValue = Vw_customer_equip_inventoryView.GetDFKA(this.DataSource.warehouse_id.ToString(),Vw_customer_equip_inventoryView.warehouse_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.warehouse_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse_id.Text = Vw_customer_equip_inventoryView.warehouse_id.Format(Vw_customer_equip_inventoryView.warehouse_id.DefaultValue);
            		
            }
            
            // If the warehouse_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.warehouse_id.Text == null ||
                this.warehouse_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.warehouse_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setwarehouse_location_id()
        {
            
                    
            // Set the warehouse_location_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.warehouse_location_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouse_location_idSpecified) {
                								
                // If the warehouse_location_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_location_id);
               if(_isExpandableNonCompositeForeignKey &&Vw_customer_equip_inventoryView.warehouse_location_id.IsApplyDisplayAs)
                                  
                     formattedValue = Vw_customer_equip_inventoryView.GetDFKA(this.DataSource.warehouse_location_id.ToString(),Vw_customer_equip_inventoryView.warehouse_location_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.warehouse_location_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse_location_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse_location_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse_location_id.Text = Vw_customer_equip_inventoryView.warehouse_location_id.Format(Vw_customer_equip_inventoryView.warehouse_location_id.DefaultValue);
            		
            }
            
            // If the warehouse_location_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.warehouse_location_id.Text == null ||
                this.warehouse_location_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.warehouse_location_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcategory_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_receivedLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_soldLabel()
                  {
                  
                    
        }
                
        public virtual void Setfinal_sale_priceLabel()
                  {
                  
                    
        }
                
        public virtual void Setmake_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setmodel_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setproposed_sale_priceLabel()
                  {
                  
                    
        }
                
        public virtual void Setpurchase_priceLabel()
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
                ((Vw_customer_equip_inventoryTableControl)MiscUtils.GetParentControlObject(this, "Vw_customer_equip_inventoryTableControl")).DataChanged = true;
                ((Vw_customer_equip_inventoryTableControl)MiscUtils.GetParentControlObject(this, "Vw_customer_equip_inventoryTableControl")).ResetData = true;
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
        
            Getcondition_id();
            Getdate_received();
            Getdate_sold();
            Getdisposition_id();
            Getfinal_sale_price();
            Getmake_id();
            Getmodel_id();
            Getnew_category_id();
            Getproposed_sale_price();
            Getpurchase_price();
            Getsale_method_id();
            Getserial_number();
            Getwarehouse_id();
            Getwarehouse_location_id();
        }
        
        
        public virtual void Getcondition_id()
        {
            
        }
                
        public virtual void Getdate_received()
        {
            
        }
                
        public virtual void Getdate_sold()
        {
            
        }
                
        public virtual void Getdisposition_id()
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
                
        public virtual void Getproposed_sale_price()
        {
            
        }
                
        public virtual void Getpurchase_price()
        {
            
        }
                
        public virtual void Getsale_method_id()
        {
            
        }
                
        public virtual void Getserial_number()
        {
            
        }
                
        public virtual void Getwarehouse_id()
        {
            
        }
                
        public virtual void Getwarehouse_location_id()
        {
            
        }
                

      // To customize, override this method in Vw_customer_equip_inventoryTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersVw_customer_equip_inventoryTableControl = false;
            hasFiltersVw_customer_equip_inventoryTableControl = hasFiltersVw_customer_equip_inventoryTableControl && false; // suppress warning
      
            bool hasFiltersVw_customer_equip_inventoryTableControl1 = false;
            hasFiltersVw_customer_equip_inventoryTableControl1 = hasFiltersVw_customer_equip_inventoryTableControl1 && false; // suppress warning
      
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
          Vw_customer_equip_inventoryView.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Vw_customer_equip_inventoryTableControl)MiscUtils.GetParentControlObject(this, "Vw_customer_equip_inventoryTableControl")).DataChanged = true;
            ((Vw_customer_equip_inventoryTableControl)MiscUtils.GetParentControlObject(this, "Vw_customer_equip_inventoryTableControl")).ResetData = true;
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
        
        public virtual void SetViewRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void ViewRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../equipment_inventory/Facility-Show-Equipment-inventory.aspx?equipment_id={Vw_customer_equip_inventoryTableControlRow:PK}";
            
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
                return (string)this.ViewState["BaseVw_customer_equip_inventoryTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseVw_customer_equip_inventoryTableControlRow_Rec"] = value;
            }
        }
        
        public Vw_customer_equip_inventoryRecord DataSource {
            get {
                return (Vw_customer_equip_inventoryRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal category_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal condition_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id");
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
        
        public System.Web.UI.WebControls.Literal disposition_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition_id");
            }
        }
            
        public System.Web.UI.WebControls.Image equipment_inventory_pic1 {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_pic1");
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
            
        public System.Web.UI.WebControls.Literal make_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idLabel1");
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
        
        public System.Web.UI.WebControls.Literal sale_method_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sale_method_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal serial_number {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_number");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton ViewRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ViewRowButton");
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
        
        public System.Web.UI.WebControls.Literal warehouse_location_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_id");
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
        Vw_customer_equip_inventoryRecord rec = null;
             
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
    Vw_customer_equip_inventoryRecord rec = null;
    
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

        
        public virtual Vw_customer_equip_inventoryRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Vw_customer_equip_inventoryView.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Vw_customer_equip_inventoryTableControl control on the Facility_Show_Equipment_inventory_Table page.
// Do not modify this class. Instead override any method in Vw_customer_equip_inventoryTableControl.
public class BaseVw_customer_equip_inventoryTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseVw_customer_equip_inventoryTableControl()
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
                if  (this.InSession(this.category_idFilter1)) 				
                    initialVal = this.GetFromSession(this.category_idFilter1);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"category_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.category_idFilter1.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.category_idFilter1.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.make_idFilter1)) 				
                    initialVal = this.GetFromSession(this.make_idFilter1);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"make_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.make_idFilter1.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.make_idFilter1.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.model_idFilter1)) 				
                    initialVal = this.GetFromSession(this.model_idFilter1);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"model_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.model_idFilter1.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.model_idFilter1.SelectedValue = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Vw_customer_equip_inventoryView.date_received, OrderByItem.OrderDir.Desc);
              
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
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.category_idFilter1.SelectedIndexChanged += new EventHandler(category_idFilter1_SelectedIndexChanged);
            
            this.make_idFilter1.SelectedIndexChanged += new EventHandler(make_idFilter1_SelectedIndexChanged);
            
            this.model_idFilter1.SelectedIndexChanged += new EventHandler(model_idFilter1_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.Vw_customer_equip_inventoryRecord);
                      this.DataSource = (Vw_customer_equip_inventoryRecord[])(alist.ToArray(myrec));
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
                    foreach (Vw_customer_equip_inventoryTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Vw_customer_equip_inventoryRecord);
                    this.DataSource = (Vw_customer_equip_inventoryRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Vw_customer_equip_inventoryRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Vw_customer_equip_inventoryView.Column1, true);          
            // selCols.Add(Vw_customer_equip_inventoryView.Column2, true);          
            // selCols.Add(Vw_customer_equip_inventoryView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Vw_customer_equip_inventoryView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Vw_customer_equip_inventoryView databaseTable = new Vw_customer_equip_inventoryView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Vw_customer_equip_inventoryRecord)) as Vw_customer_equip_inventoryRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Vw_customer_equip_inventoryView.Column1, true);          
            // selCols.Add(Vw_customer_equip_inventoryView.Column2, true);          
            // selCols.Add(Vw_customer_equip_inventoryView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Vw_customer_equip_inventoryView.GetRecordCount(join, where);
            else
            {
                Vw_customer_equip_inventoryView databaseTable = new Vw_customer_equip_inventoryView();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vw_customer_equip_inventoryTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Vw_customer_equip_inventoryTableControlRow recControl = (Vw_customer_equip_inventoryTableControlRow)(repItem.FindControl("Vw_customer_equip_inventoryTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                Setcategory_idFilter1();
                Setcategory_idLabel3();
                Setcondition_idLabel();
                Setdate_receivedLabel1();
                Setdisposition_idLabel();
                
                
                
                Setfinal_sale_priceLabel1();
                Setmake_idFilter1();
                Setmake_idLabel();
                Setmake_idLabel5();
                Setmodel_idFilter1();
                Setmodel_idLabel3();
                
                
                
                Setsale_method_idLabel();
                Setserial_numberLabel();
                
                Setwarehouse_location_idLabel2();
                
                SetExcelButton();
              
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
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Vw_customer_equip_inventoryView.disposition_id, this.DataSource);
            this.Page.PregetDfkaRecords(Vw_customer_equip_inventoryView.new_category_id, this.DataSource);
            this.Page.PregetDfkaRecords(Vw_customer_equip_inventoryView.sale_method_id, this.DataSource);
            this.Page.PregetDfkaRecords(Vw_customer_equip_inventoryView.warehouse_id, this.DataSource);
            this.Page.PregetDfkaRecords(Vw_customer_equip_inventoryView.warehouse_location_id, this.DataSource);
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


            
            this.category_idFilter1.ClearSelection();
            
            this.make_idFilter1.ClearSelection();
            
            this.model_idFilter1.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Vw_customer_equip_inventoryView.date_received, OrderByItem.OrderDir.Desc);
                 
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
    
            // Bind the buttons for Vw_customer_equip_inventoryTableControl pagination.
        
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
              
            foreach (Vw_customer_equip_inventoryTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Vw_customer_equip_inventoryTableControlRow recCtl in this.GetRecordControls()){
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
            Vw_customer_equip_inventoryView.Instance.InnerFilter = null;
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
          
            if (MiscUtils.IsValueSelected(this.category_idFilter1)) {
                        
                wc.iAND(Vw_customer_equip_inventoryView.category_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.category_idFilter1, this.GetFromSession(this.category_idFilter1)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.make_idFilter1)) {
                        
                wc.iAND(Vw_customer_equip_inventoryView.make_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.make_idFilter1, this.GetFromSession(this.make_idFilter1)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.model_idFilter1)) {
                        
                wc.iAND(Vw_customer_equip_inventoryView.model_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.model_idFilter1, this.GetFromSession(this.model_idFilter1)), false, false);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Vw_customer_equip_inventoryView.Instance.InnerFilter = null;
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
          
      String category_idFilter1SelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "category_idFilter1_Ajax"];
            if (MiscUtils.IsValueSelected(category_idFilter1SelectedValue)) {

              
                wc.iAND(Vw_customer_equip_inventoryView.category_id, BaseFilter.ComparisonOperator.EqualsTo, category_idFilter1SelectedValue, false, false);
                      
      }
                      
      String make_idFilter1SelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "make_idFilter1_Ajax"];
            if (MiscUtils.IsValueSelected(make_idFilter1SelectedValue)) {

              
                wc.iAND(Vw_customer_equip_inventoryView.make_id, BaseFilter.ComparisonOperator.EqualsTo, make_idFilter1SelectedValue, false, false);
                      
      }
                      
      String model_idFilter1SelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "model_idFilter1_Ajax"];
            if (MiscUtils.IsValueSelected(model_idFilter1SelectedValue)) {

              
                wc.iAND(Vw_customer_equip_inventoryView.model_id, BaseFilter.ComparisonOperator.EqualsTo, model_idFilter1SelectedValue, false, false);
                      
      }
                      

            return wc;
        }

        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Vw_customer_equip_inventoryView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"vw_customer_equip_inventory_.CustNo"), new BaseClasses.Data.IdentifierAliasInfo(@"vw_customer_equip_inventory_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.custno"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("USERID()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("USERID()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("USERID()", false) == "--PLEASE_SELECT--" || EvaluateFormula("USERID()", false) == "--ANY--") whereClause.RunQuery = false;

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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vw_customer_equip_inventoryTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Vw_customer_equip_inventoryTableControlRow recControl = (Vw_customer_equip_inventoryTableControlRow)(repItem.FindControl("Vw_customer_equip_inventoryTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Vw_customer_equip_inventoryRecord rec = new Vw_customer_equip_inventoryRecord();
        
                        if (recControl.condition_id.Text != "") {
                            rec.Parse(recControl.condition_id.Text, Vw_customer_equip_inventoryView.condition_id);
                  }
                
                        if (recControl.date_received.Text != "") {
                            rec.Parse(recControl.date_received.Text, Vw_customer_equip_inventoryView.date_received);
                  }
                
                        if (recControl.date_sold.Text != "") {
                            rec.Parse(recControl.date_sold.Text, Vw_customer_equip_inventoryView.date_sold);
                  }
                
                        if (recControl.disposition_id.Text != "") {
                            rec.Parse(recControl.disposition_id.Text, Vw_customer_equip_inventoryView.disposition_id);
                  }
                
                        if (recControl.final_sale_price.Text != "") {
                            rec.Parse(recControl.final_sale_price.Text, Vw_customer_equip_inventoryView.final_sale_price);
                  }
                
                        if (recControl.make_id.Text != "") {
                            rec.Parse(recControl.make_id.Text, Vw_customer_equip_inventoryView.make_id);
                  }
                
                        if (recControl.model_id.Text != "") {
                            rec.Parse(recControl.model_id.Text, Vw_customer_equip_inventoryView.model_id);
                  }
                
                        if (recControl.new_category_id.Text != "") {
                            rec.Parse(recControl.new_category_id.Text, Vw_customer_equip_inventoryView.new_category_id);
                  }
                
                        if (recControl.proposed_sale_price.Text != "") {
                            rec.Parse(recControl.proposed_sale_price.Text, Vw_customer_equip_inventoryView.proposed_sale_price);
                  }
                
                        if (recControl.purchase_price.Text != "") {
                            rec.Parse(recControl.purchase_price.Text, Vw_customer_equip_inventoryView.purchase_price);
                  }
                
                        if (recControl.sale_method_id.Text != "") {
                            rec.Parse(recControl.sale_method_id.Text, Vw_customer_equip_inventoryView.sale_method_id);
                  }
                
                        if (recControl.serial_number.Text != "") {
                            rec.Parse(recControl.serial_number.Text, Vw_customer_equip_inventoryView.serial_number);
                  }
                
                        if (recControl.warehouse_id.Text != "") {
                            rec.Parse(recControl.warehouse_id.Text, Vw_customer_equip_inventoryView.warehouse_id);
                  }
                
                        if (recControl.warehouse_location_id.Text != "") {
                            rec.Parse(recControl.warehouse_location_id.Text, Vw_customer_equip_inventoryView.warehouse_location_id);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Vw_customer_equip_inventoryRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Vw_customer_equip_inventoryRecord);
                this.DataSource = (Vw_customer_equip_inventoryRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Vw_customer_equip_inventoryTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Vw_customer_equip_inventoryTableControlRow rec)            
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
        
        public virtual void Setcategory_idLabel3()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setdate_receivedLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.date_receivedLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void Setdisposition_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setfinal_sale_priceLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.final_sale_priceLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void Setmake_idLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.make_idLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setmake_idLabel5()
                  {
                  
                    
        }
                
        public virtual void Setmodel_idLabel3()
                  {
                  
                    
        }
                
        public virtual void Setsale_method_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setserial_numberLabel()
                  {
                  
                    
        }
                
        public virtual void Setwarehouse_location_idLabel2()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.warehouse_location_idLabel2.Text = "Some value";
                    
                    
        }
                
        public virtual void Setcategory_idFilter1()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh make_idFilter1,model_idFilter1 controls
            this.category_idFilter1.AutoPostBack = true;
            
            this.Populatecategory_idFilter1(MiscUtils.GetSelectedValue(this.category_idFilter1,  GetFromSession(this.category_idFilter1)), 500);					
                                     
        }
            
        public virtual void Setmake_idFilter1()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh model_idFilter1 controls
            this.make_idFilter1.AutoPostBack = true;
            
            this.Populatemake_idFilter1(MiscUtils.GetSelectedValue(this.make_idFilter1,  GetFromSession(this.make_idFilter1)), 500);					
                                     
        }
            
        public virtual void Setmodel_idFilter1()
        {
            
            this.Populatemodel_idFilter1(MiscUtils.GetSelectedValue(this.model_idFilter1,  GetFromSession(this.model_idFilter1)), 500);					
                                     
        }
            
        // Get the filters' data for category_idFilter1.
                
        protected virtual void Populatecategory_idFilter1(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.category_idFilter1.Items.Clear();
            WhereClause wc = this.CreateWhereClause_category_idFilter1();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_category_idFilter1 function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.category_idFilter1.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Vw_customer_equip_inventoryView.category_id, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Vw_customer_equip_inventoryRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Vw_customer_equip_inventoryView.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Vw_customer_equip_inventoryRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.category_idSpecified) 
                        {
                            cvalue = itemValue.category_id.ToString();
                            if (counter < maxItems && this.category_idFilter1.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("category_id", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.category_idFilter1.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.category_idFilter1.Items.Add(newItem);

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
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.category_idFilter1, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.category_idFilter1.SelectedValue != null && this.category_idFilter1.Items.FindByValue(this.category_idFilter1.SelectedValue) == null)
                this.category_idFilter1.SelectedValue = null;
                           
        }
            
        // Get the filters' data for make_idFilter1.
                
        protected virtual void Populatemake_idFilter1(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.make_idFilter1.Items.Clear();
            WhereClause wc = this.CreateWhereClause_make_idFilter1();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_make_idFilter1 function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.make_idFilter1.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Vw_customer_equip_inventoryView.make_id, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Vw_customer_equip_inventoryRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Vw_customer_equip_inventoryView.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Vw_customer_equip_inventoryRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.make_idSpecified) 
                        {
                            cvalue = itemValue.make_id.ToString();
                            if (counter < maxItems && this.make_idFilter1.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("make_id", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.make_idFilter1.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.make_idFilter1.Items.Add(newItem);

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
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.make_idFilter1, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.make_idFilter1.SelectedValue != null && this.make_idFilter1.Items.FindByValue(this.make_idFilter1.SelectedValue) == null)
                this.make_idFilter1.SelectedValue = null;
                           
        }
            
        // Get the filters' data for model_idFilter1.
                
        protected virtual void Populatemodel_idFilter1(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.model_idFilter1.Items.Clear();
            WhereClause wc = this.CreateWhereClause_model_idFilter1();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_model_idFilter1 function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.model_idFilter1.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Vw_customer_equip_inventoryView.model_id, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Vw_customer_equip_inventoryRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Vw_customer_equip_inventoryView.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Vw_customer_equip_inventoryRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.model_idSpecified) 
                        {
                            cvalue = itemValue.model_id.ToString();
                            if (counter < maxItems && this.model_idFilter1.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("model_id", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.model_idFilter1.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.model_idFilter1.Items.Add(newItem);

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
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.model_idFilter1, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.model_idFilter1.SelectedValue != null && this.model_idFilter1.Items.FindByValue(this.model_idFilter1.SelectedValue) == null)
                this.model_idFilter1.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_category_idFilter1()
        {
            // Create a where clause for the filter category_idFilter1.
            // This function is called by the Populate method to load the items 
            // in the category_idFilter1DropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Vw_customer_equip_inventoryView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"vw_customer_equip_inventory_.CustNo"), new BaseClasses.Data.IdentifierAliasInfo(@"vw_customer_equip_inventory_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.custno"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("USERID()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("USERID()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("USERID()", false) == "--PLEASE_SELECT--" || EvaluateFormula("USERID()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_make_idFilter1()
        {
            // Create a where clause for the filter make_idFilter1.
            // This function is called by the Populate method to load the items 
            // in the make_idFilter1DropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("Vw_customer_equip_inventoryTableControl.category_idFilter1.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Vw_customer_equip_inventoryView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"vw_customer_equip_inventory_.category_id"), EvaluateFormula("Vw_customer_equip_inventoryTableControl.category_idFilter1.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Vw_customer_equip_inventoryTableControl.category_idFilter1.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Vw_customer_equip_inventoryTableControl.category_idFilter1.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_model_idFilter1()
        {
            // Create a where clause for the filter model_idFilter1.
            // This function is called by the Populate method to load the items 
            // in the model_idFilter1DropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("Vw_customer_equip_inventoryTableControl.make_idFilter1.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Vw_customer_equip_inventoryView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"vw_customer_equip_inventory_.make_id"), EvaluateFormula("Vw_customer_equip_inventoryTableControl.make_idFilter1.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Vw_customer_equip_inventoryTableControl.make_idFilter1.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Vw_customer_equip_inventoryTableControl.make_idFilter1.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
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
        
            this.SaveToSession(this.category_idFilter1, this.category_idFilter1.SelectedValue);
                  
            this.SaveToSession(this.make_idFilter1, this.make_idFilter1.SelectedValue);
                  
            this.SaveToSession(this.model_idFilter1, this.model_idFilter1.SelectedValue);
                  
            
                    
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
          
      this.SaveToSession("category_idFilter1_Ajax", this.category_idFilter1.SelectedValue);
              
      this.SaveToSession("make_idFilter1_Ajax", this.make_idFilter1.SelectedValue);
              
      this.SaveToSession("model_idFilter1_Ajax", this.model_idFilter1.SelectedValue);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.category_idFilter1);
            this.RemoveFromSession(this.make_idFilter1);
            this.RemoveFromSession(this.model_idFilter1);
            
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

            string orderByStr = (string)ViewState["Vw_customer_equip_inventoryTableControl_OrderBy"];
          
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
                this.ViewState["Vw_customer_equip_inventoryTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
    
      
            if (MiscUtils.IsValueSelected(category_idFilter1))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(make_idFilter1))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(model_idFilter1))
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


              this.TotalRecords = Vw_customer_equip_inventoryView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Vw_customer_equip_inventoryView.date_received,
             Vw_customer_equip_inventoryView.make_id,
             Vw_customer_equip_inventoryView.model_id,
             Vw_customer_equip_inventoryView.serial_number,
             Vw_customer_equip_inventoryView.condition_id,
             Vw_customer_equip_inventoryView.purchase_price,
             Vw_customer_equip_inventoryView.disposition_id,
             Vw_customer_equip_inventoryView.sale_method_id,
             Vw_customer_equip_inventoryView.proposed_sale_price,
             Vw_customer_equip_inventoryView.date_sold,
             Vw_customer_equip_inventoryView.final_sale_price,
             Vw_customer_equip_inventoryView.warehouse_id,
             Vw_customer_equip_inventoryView.warehouse_location_id,
             Vw_customer_equip_inventoryView.new_category_id,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Vw_customer_equip_inventoryView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Vw_customer_equip_inventoryView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Vw_customer_equip_inventoryView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Vw_customer_equip_inventoryView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.date_received, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.make_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.model_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.serial_number, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.condition_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.purchase_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.disposition_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.sale_method_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.proposed_sale_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.date_sold, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.final_sale_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.warehouse_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.warehouse_location_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.new_category_id, "Default"));


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
                val = Vw_customer_equip_inventoryView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Facility-Show-Equipment-inventory-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_customer_equip_inventory";
                // If Facility-Show-Equipment-inventory-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Vw_customer_equip_inventoryView.date_received.Name, ReportEnum.Align.Left, "${date_received}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.make_id.Name, ReportEnum.Align.Left, "${make_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.model_id.Name, ReportEnum.Align.Left, "${model_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.purchase_price.Name, ReportEnum.Align.Right, "${purchase_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.disposition_id.Name, ReportEnum.Align.Left, "${disposition_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.sale_method_id.Name, ReportEnum.Align.Left, "${sale_method_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.proposed_sale_price.Name, ReportEnum.Align.Right, "${proposed_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.date_sold.Name, ReportEnum.Align.Left, "${date_sold}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.final_sale_price.Name, ReportEnum.Align.Right, "${final_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.warehouse_id.Name, ReportEnum.Align.Left, "${warehouse_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.warehouse_location_id.Name, ReportEnum.Align.Left, "${warehouse_location_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.new_category_id.Name, ReportEnum.Align.Left, "${new_category_id}", ReportEnum.Align.Left, 30);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Vw_customer_equip_inventoryView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Vw_customer_equip_inventoryView.GetRecordCount(joinFilter,whereClause);
                Vw_customer_equip_inventoryRecord[] records = null;
                
                do
                {
                    
                    records = Vw_customer_equip_inventoryView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Vw_customer_equip_inventoryRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${date_received}", record.Format(Vw_customer_equip_inventoryView.date_received), ReportEnum.Align.Left, 300);
                             report.AddData("${make_id}", record.Format(Vw_customer_equip_inventoryView.make_id), ReportEnum.Align.Left, 300);
                             report.AddData("${model_id}", record.Format(Vw_customer_equip_inventoryView.model_id), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Vw_customer_equip_inventoryView.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${condition_id}", record.Format(Vw_customer_equip_inventoryView.condition_id), ReportEnum.Align.Left, 300);
                             report.AddData("${purchase_price}", record.Format(Vw_customer_equip_inventoryView.purchase_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.disposition_id)){
                                 report.AddData("${disposition_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.disposition_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.disposition_id.ToString(), Vw_customer_equip_inventoryView.disposition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.disposition_id.IsApplyDisplayAs){
                                     report.AddData("${disposition_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${disposition_id}", record.Format(Vw_customer_equip_inventoryView.disposition_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.sale_method_id)){
                                 report.AddData("${sale_method_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.sale_method_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.sale_method_id.ToString(), Vw_customer_equip_inventoryView.sale_method_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.sale_method_id.IsApplyDisplayAs){
                                     report.AddData("${sale_method_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${sale_method_id}", record.Format(Vw_customer_equip_inventoryView.sale_method_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${proposed_sale_price}", record.Format(Vw_customer_equip_inventoryView.proposed_sale_price), ReportEnum.Align.Right, 300);
                             report.AddData("${date_sold}", record.Format(Vw_customer_equip_inventoryView.date_sold), ReportEnum.Align.Left, 300);
                             report.AddData("${final_sale_price}", record.Format(Vw_customer_equip_inventoryView.final_sale_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_id)){
                                 report.AddData("${warehouse_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.warehouse_id.ToString(), Vw_customer_equip_inventoryView.warehouse_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.warehouse_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_id}", record.Format(Vw_customer_equip_inventoryView.warehouse_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_location_id)){
                                 report.AddData("${warehouse_location_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_location_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.warehouse_location_id.ToString(), Vw_customer_equip_inventoryView.warehouse_location_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.warehouse_location_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_location_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_location_id}", record.Format(Vw_customer_equip_inventoryView.warehouse_location_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.new_category_id)){
                                 report.AddData("${new_category_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.new_category_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.new_category_id.ToString(), Vw_customer_equip_inventoryView.new_category_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.new_category_id.IsApplyDisplayAs){
                                     report.AddData("${new_category_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${new_category_id}", record.Format(Vw_customer_equip_inventoryView.new_category_id), ReportEnum.Align.Left, 300);
                                 }
                             }

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
                
              this.category_idFilter1.ClearSelection();
            
              this.make_idFilter1.ClearSelection();
            
              this.model_idFilter1.ClearSelection();
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(Vw_customer_equip_inventoryView.date_received, OrderByItem.OrderDir.Desc);          
                      
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

                report.SpecificReportFileName = Page.Server.MapPath("Facility-Show-Equipment-inventory-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_customer_equip_inventory";
                // If Facility-Show-Equipment-inventory-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Vw_customer_equip_inventoryView.date_received.Name, ReportEnum.Align.Left, "${date_received}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.make_id.Name, ReportEnum.Align.Left, "${make_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.model_id.Name, ReportEnum.Align.Left, "${model_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.purchase_price.Name, ReportEnum.Align.Right, "${purchase_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.disposition_id.Name, ReportEnum.Align.Left, "${disposition_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.sale_method_id.Name, ReportEnum.Align.Left, "${sale_method_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.proposed_sale_price.Name, ReportEnum.Align.Right, "${proposed_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.date_sold.Name, ReportEnum.Align.Left, "${date_sold}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.final_sale_price.Name, ReportEnum.Align.Right, "${final_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.warehouse_id.Name, ReportEnum.Align.Left, "${warehouse_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.warehouse_location_id.Name, ReportEnum.Align.Left, "${warehouse_location_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.new_category_id.Name, ReportEnum.Align.Left, "${new_category_id}", ReportEnum.Align.Left, 30);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Vw_customer_equip_inventoryView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Vw_customer_equip_inventoryView.GetColumnList();
                Vw_customer_equip_inventoryRecord[] records = null;
                do
                {
                    records = Vw_customer_equip_inventoryView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Vw_customer_equip_inventoryRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${date_received}", record.Format(Vw_customer_equip_inventoryView.date_received), ReportEnum.Align.Left, 300);
                             report.AddData("${make_id}", record.Format(Vw_customer_equip_inventoryView.make_id), ReportEnum.Align.Left, 300);
                             report.AddData("${model_id}", record.Format(Vw_customer_equip_inventoryView.model_id), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Vw_customer_equip_inventoryView.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${condition_id}", record.Format(Vw_customer_equip_inventoryView.condition_id), ReportEnum.Align.Left, 300);
                             report.AddData("${purchase_price}", record.Format(Vw_customer_equip_inventoryView.purchase_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.disposition_id)){
                                 report.AddData("${disposition_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.disposition_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.disposition_id.ToString(), Vw_customer_equip_inventoryView.disposition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.disposition_id.IsApplyDisplayAs){
                                     report.AddData("${disposition_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${disposition_id}", record.Format(Vw_customer_equip_inventoryView.disposition_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.sale_method_id)){
                                 report.AddData("${sale_method_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.sale_method_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.sale_method_id.ToString(), Vw_customer_equip_inventoryView.sale_method_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.sale_method_id.IsApplyDisplayAs){
                                     report.AddData("${sale_method_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${sale_method_id}", record.Format(Vw_customer_equip_inventoryView.sale_method_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${proposed_sale_price}", record.Format(Vw_customer_equip_inventoryView.proposed_sale_price), ReportEnum.Align.Right, 300);
                             report.AddData("${date_sold}", record.Format(Vw_customer_equip_inventoryView.date_sold), ReportEnum.Align.Left, 300);
                             report.AddData("${final_sale_price}", record.Format(Vw_customer_equip_inventoryView.final_sale_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_id)){
                                 report.AddData("${warehouse_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.warehouse_id.ToString(), Vw_customer_equip_inventoryView.warehouse_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.warehouse_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_id}", record.Format(Vw_customer_equip_inventoryView.warehouse_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_location_id)){
                                 report.AddData("${warehouse_location_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_location_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.warehouse_location_id.ToString(), Vw_customer_equip_inventoryView.warehouse_location_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.warehouse_location_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_location_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_location_id}", record.Format(Vw_customer_equip_inventoryView.warehouse_location_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.new_category_id)){
                                 report.AddData("${new_category_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.new_category_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.new_category_id.ToString(), Vw_customer_equip_inventoryView.new_category_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.new_category_id.IsApplyDisplayAs){
                                     report.AddData("${new_category_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${new_category_id}", record.Format(Vw_customer_equip_inventoryView.new_category_id), ReportEnum.Align.Left, 300);
                                 }
                             }

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
        
        // event handler for FieldFilter
        protected virtual void category_idFilter1_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           
                Setmake_idFilter1();
                Setmodel_idFilter1();				
        }
            
        // event handler for FieldFilter
        protected virtual void make_idFilter1_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           
                Setmodel_idFilter1();				
        }
            
        // event handler for FieldFilter
        protected virtual void model_idFilter1_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Vw_customer_equip_inventoryView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Vw_customer_equip_inventoryRecord[] DataSource {
             
            get {
                return (Vw_customer_equip_inventoryRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.DropDownList category_idFilter1 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idFilter1");
            }
        }
        
        public System.Web.UI.WebControls.Literal category_idLabel3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idLabel3");
            }
        }
        
        public System.Web.UI.WebControls.Literal condition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_receivedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_receivedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal disposition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition_idLabel");
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
        
        public System.Web.UI.WebControls.Literal final_sale_priceLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_sale_priceLabel1");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList make_idFilter1 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idFilter1");
            }
        }
        
        public System.Web.UI.WebControls.Literal make_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal make_idLabel5 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idLabel5");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList model_idFilter1 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_idFilter1");
            }
        }
        
        public System.Web.UI.WebControls.Literal model_idLabel3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_idLabel3");
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
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal sale_method_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sale_method_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_numberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_numberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.Literal warehouse_location_idLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_idLabel2");
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
                Vw_customer_equip_inventoryTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Vw_customer_equip_inventoryRecord rec = null;
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
                Vw_customer_equip_inventoryTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Vw_customer_equip_inventoryRecord rec = null;
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
          
        public virtual Vw_customer_equip_inventoryTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Vw_customer_equip_inventoryTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Vw_customer_equip_inventoryTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Facility_Show_Equipment_inventory_Table.Vw_customer_equip_inventoryTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Vw_customer_equip_inventoryTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Vw_customer_equip_inventoryTableControlRow recCtl in recordList)
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

        public virtual Vw_customer_equip_inventoryTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Vw_customer_equip_inventoryTableControlRow");
	          List<Vw_customer_equip_inventoryTableControlRow> list = new List<Vw_customer_equip_inventoryTableControlRow>();
	          foreach (Vw_customer_equip_inventoryTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the Vw_customer_equip_inventoryTableControl1Row control on the Facility_Show_Equipment_inventory_Table page.
// Do not modify this class. Instead override any method in Vw_customer_equip_inventoryTableControl1Row.
public class BaseVw_customer_equip_inventoryTableControl1Row : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseVw_customer_equip_inventoryTableControl1Row()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Vw_customer_equip_inventoryTableControl1Row.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Vw_customer_equip_inventoryTableControl1Row.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.ViewRowButton1.Click += ViewRowButton1_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Vw_customer_equip_inventoryView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseVw_customer_equip_inventoryTableControl1 when the data for the entire
            // table is loaded.
            
            this.DataSource = new Vw_customer_equip_inventoryRecord();
            
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
        
                Setcategory_id1();
                Setcategory_idLabel1();
                Setcondition_id1();
                SetCustName();
                Setdate_received1();
                Setdate_receivedLabel3();
                Setdate_sold1();
                Setdate_soldLabel1();
                Setdisposition_id1();
                
                Setfinal_sale_price1();
                Setfinal_sale_priceLabel3();
                Setmake_id1();
                Setmake_idLabel3();
                Setmodel_id1();
                Setmodel_idLabel1();
                Setproposed_sale_price1();
                Setproposed_sale_priceLabel1();
                Setpurchase_price1();
                Setpurchase_priceLabel1();
                Setsale_method_id1();
                Setserial_number1();
                
                Setwarehouse_id1();
                Setwarehouse_idLabel3();
                Setwarehouse_location_id1();
                Setwarehouse_location_idLabel5();
                SetViewRowButton1();
              

      

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
        
        
        public virtual void Setcategory_id1()
        {
            
                    
            // Set the category_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.category_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.category_idSpecified) {
                								
                // If the category_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.category_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.category_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // category_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.category_id1.Text = Vw_customer_equip_inventoryView.category_id.Format(Vw_customer_equip_inventoryView.category_id.DefaultValue);
            		
            }
            
            // If the category_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.category_id1.Text == null ||
                this.category_id1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.category_id1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcondition_id1()
        {
            
                    
            // Set the condition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.condition_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.condition_idSpecified) {
                								
                // If the condition_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.condition_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.condition_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.condition_id1.Text = Vw_customer_equip_inventoryView.condition_id.Format(Vw_customer_equip_inventoryView.condition_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetCustName()
        {
            
                    
            // Set the CustName Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.CustName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustNameSpecified) {
                								
                // If the CustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.CustName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustName.Text = Vw_customer_equip_inventoryView.CustName.Format(Vw_customer_equip_inventoryView.CustName.DefaultValue);
            		
            }
            
            // If the CustName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustName.Text == null ||
                this.CustName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdate_received1()
        {
            
                    
            // Set the date_received Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.date_received1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_receivedSpecified) {
                								
                // If the date_received is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.date_received, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_received1.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_received is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_received1.Text = Vw_customer_equip_inventoryView.date_received.Format(Vw_customer_equip_inventoryView.date_received.DefaultValue, @"d");
            		
            }
            
            // If the date_received is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_received1.Text == null ||
                this.date_received1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_received1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdate_sold1()
        {
            
                    
            // Set the date_sold Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.date_sold1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.date_soldSpecified) {
                								
                // If the date_sold is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.date_sold, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.date_sold1.Text = formattedValue;
                   
            } 
            
            else {
            
                // date_sold is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.date_sold1.Text = Vw_customer_equip_inventoryView.date_sold.Format(Vw_customer_equip_inventoryView.date_sold.DefaultValue, @"d");
            		
            }
            
            // If the date_sold is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_sold1.Text == null ||
                this.date_sold1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_sold1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdisposition_id1()
        {
            
                    
            // Set the disposition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.disposition_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.disposition_idSpecified) {
                								
                // If the disposition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.disposition_id);
               if(_isExpandableNonCompositeForeignKey &&Vw_customer_equip_inventoryView.disposition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Vw_customer_equip_inventoryView.GetDFKA(this.DataSource.disposition_id.ToString(),Vw_customer_equip_inventoryView.disposition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.disposition_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.disposition_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // disposition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.disposition_id1.Text = Vw_customer_equip_inventoryView.disposition_id.Format(Vw_customer_equip_inventoryView.disposition_id.DefaultValue);
            		
            }
            
            // If the disposition_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.disposition_id1.Text == null ||
                this.disposition_id1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.disposition_id1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setfinal_sale_price1()
        {
            
                    
            // Set the final_sale_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.final_sale_price1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.final_sale_priceSpecified) {
                								
                // If the final_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.final_sale_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.final_sale_price1.Text = formattedValue;
                   
            } 
            
            else {
            
                // final_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.final_sale_price1.Text = Vw_customer_equip_inventoryView.final_sale_price.Format(Vw_customer_equip_inventoryView.final_sale_price.DefaultValue, @"C");
            		
            }
            
            // If the final_sale_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.final_sale_price1.Text == null ||
                this.final_sale_price1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.final_sale_price1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setmake_id1()
        {
            
                    
            // Set the make_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.make_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.make_idSpecified) {
                								
                // If the make_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.make_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.make_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // make_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make_id1.Text = Vw_customer_equip_inventoryView.make_id.Format(Vw_customer_equip_inventoryView.make_id.DefaultValue);
            		
            }
            
            // If the make_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.make_id1.Text == null ||
                this.make_id1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.make_id1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setmodel_id1()
        {
            
                    
            // Set the model_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.model_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.model_idSpecified) {
                								
                // If the model_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.model_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.model_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // model_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model_id1.Text = Vw_customer_equip_inventoryView.model_id.Format(Vw_customer_equip_inventoryView.model_id.DefaultValue);
            		
            }
            
            // If the model_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.model_id1.Text == null ||
                this.model_id1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.model_id1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproposed_sale_price1()
        {
            
                    
            // Set the proposed_sale_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.proposed_sale_price1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.proposed_sale_priceSpecified) {
                								
                // If the proposed_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.proposed_sale_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.proposed_sale_price1.Text = formattedValue;
                   
            } 
            
            else {
            
                // proposed_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.proposed_sale_price1.Text = Vw_customer_equip_inventoryView.proposed_sale_price.Format(Vw_customer_equip_inventoryView.proposed_sale_price.DefaultValue, @"C");
            		
            }
            
            // If the proposed_sale_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.proposed_sale_price1.Text == null ||
                this.proposed_sale_price1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.proposed_sale_price1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpurchase_price1()
        {
            
                    
            // Set the purchase_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.purchase_price1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchase_priceSpecified) {
                								
                // If the purchase_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.purchase_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.purchase_price1.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase_price1.Text = Vw_customer_equip_inventoryView.purchase_price.Format(Vw_customer_equip_inventoryView.purchase_price.DefaultValue, @"C");
            		
            }
            
            // If the purchase_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.purchase_price1.Text == null ||
                this.purchase_price1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.purchase_price1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setsale_method_id1()
        {
            
                    
            // Set the sale_method_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.sale_method_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.sale_method_idSpecified) {
                								
                // If the sale_method_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.sale_method_id);
               if(_isExpandableNonCompositeForeignKey &&Vw_customer_equip_inventoryView.sale_method_id.IsApplyDisplayAs)
                                  
                     formattedValue = Vw_customer_equip_inventoryView.GetDFKA(this.DataSource.sale_method_id.ToString(),Vw_customer_equip_inventoryView.sale_method_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.sale_method_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.sale_method_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // sale_method_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.sale_method_id1.Text = Vw_customer_equip_inventoryView.sale_method_id.Format(Vw_customer_equip_inventoryView.sale_method_id.DefaultValue);
            		
            }
            
            // If the sale_method_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.sale_method_id1.Text == null ||
                this.sale_method_id1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.sale_method_id1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setserial_number1()
        {
            
                    
            // Set the serial_number Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.serial_number1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.serial_number);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_number1.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number1.Text = Vw_customer_equip_inventoryView.serial_number.Format(Vw_customer_equip_inventoryView.serial_number.DefaultValue);
            		
            }
            
            // If the serial_number is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serial_number1.Text == null ||
                this.serial_number1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serial_number1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setwarehouse_id1()
        {
            
                    
            // Set the warehouse_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.warehouse_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouse_idSpecified) {
                								
                // If the warehouse_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_id);
               if(_isExpandableNonCompositeForeignKey &&Vw_customer_equip_inventoryView.warehouse_id.IsApplyDisplayAs)
                                  
                     formattedValue = Vw_customer_equip_inventoryView.GetDFKA(this.DataSource.warehouse_id.ToString(),Vw_customer_equip_inventoryView.warehouse_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.warehouse_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse_id1.Text = Vw_customer_equip_inventoryView.warehouse_id.Format(Vw_customer_equip_inventoryView.warehouse_id.DefaultValue);
            		
            }
            
            // If the warehouse_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.warehouse_id1.Text == null ||
                this.warehouse_id1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.warehouse_id1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setwarehouse_location_id1()
        {
            
                    
            // Set the warehouse_location_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_customer_equip_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_customer_equip_inventory record retrieved from the database.
            // this.warehouse_location_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouse_location_idSpecified) {
                								
                // If the warehouse_location_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_location_id);
               if(_isExpandableNonCompositeForeignKey &&Vw_customer_equip_inventoryView.warehouse_location_id.IsApplyDisplayAs)
                                  
                     formattedValue = Vw_customer_equip_inventoryView.GetDFKA(this.DataSource.warehouse_location_id.ToString(),Vw_customer_equip_inventoryView.warehouse_location_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Vw_customer_equip_inventoryView.warehouse_location_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.warehouse_location_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // warehouse_location_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.warehouse_location_id1.Text = Vw_customer_equip_inventoryView.warehouse_location_id.Format(Vw_customer_equip_inventoryView.warehouse_location_id.DefaultValue);
            		
            }
            
            // If the warehouse_location_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.warehouse_location_id1.Text == null ||
                this.warehouse_location_id1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.warehouse_location_id1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcategory_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setdate_receivedLabel3()
                  {
                  
                    
        }
                
        public virtual void Setdate_soldLabel1()
                  {
                  
                    
        }
                
        public virtual void Setfinal_sale_priceLabel3()
                  {
                  
                    
        }
                
        public virtual void Setmake_idLabel3()
                  {
                  
                    
        }
                
        public virtual void Setmodel_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setproposed_sale_priceLabel1()
                  {
                  
                    
        }
                
        public virtual void Setpurchase_priceLabel1()
                  {
                  
                    
        }
                
        public virtual void Setwarehouse_idLabel3()
                  {
                  
                    
        }
                
        public virtual void Setwarehouse_location_idLabel5()
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
                ((Vw_customer_equip_inventoryTableControl1)MiscUtils.GetParentControlObject(this, "Vw_customer_equip_inventoryTableControl1")).DataChanged = true;
                ((Vw_customer_equip_inventoryTableControl1)MiscUtils.GetParentControlObject(this, "Vw_customer_equip_inventoryTableControl1")).ResetData = true;
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
        
            Getcategory_id1();
            Getcondition_id1();
            GetCustName();
            Getdate_received1();
            Getdate_sold1();
            Getdisposition_id1();
            Getfinal_sale_price1();
            Getmake_id1();
            Getmodel_id1();
            Getproposed_sale_price1();
            Getpurchase_price1();
            Getsale_method_id1();
            Getserial_number1();
            Getwarehouse_id1();
            Getwarehouse_location_id1();
        }
        
        
        public virtual void Getcategory_id1()
        {
            
        }
                
        public virtual void Getcondition_id1()
        {
            
        }
                
        public virtual void GetCustName()
        {
            
        }
                
        public virtual void Getdate_received1()
        {
            
        }
                
        public virtual void Getdate_sold1()
        {
            
        }
                
        public virtual void Getdisposition_id1()
        {
            
        }
                
        public virtual void Getfinal_sale_price1()
        {
            
        }
                
        public virtual void Getmake_id1()
        {
            
        }
                
        public virtual void Getmodel_id1()
        {
            
        }
                
        public virtual void Getproposed_sale_price1()
        {
            
        }
                
        public virtual void Getpurchase_price1()
        {
            
        }
                
        public virtual void Getsale_method_id1()
        {
            
        }
                
        public virtual void Getserial_number1()
        {
            
        }
                
        public virtual void Getwarehouse_id1()
        {
            
        }
                
        public virtual void Getwarehouse_location_id1()
        {
            
        }
                

      // To customize, override this method in Vw_customer_equip_inventoryTableControl1Row.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersVw_customer_equip_inventoryTableControl = false;
            hasFiltersVw_customer_equip_inventoryTableControl = hasFiltersVw_customer_equip_inventoryTableControl && false; // suppress warning
      
            bool hasFiltersVw_customer_equip_inventoryTableControl1 = false;
            hasFiltersVw_customer_equip_inventoryTableControl1 = hasFiltersVw_customer_equip_inventoryTableControl1 && false; // suppress warning
      
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
          Vw_customer_equip_inventoryView.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Vw_customer_equip_inventoryTableControl1)MiscUtils.GetParentControlObject(this, "Vw_customer_equip_inventoryTableControl1")).DataChanged = true;
            ((Vw_customer_equip_inventoryTableControl1)MiscUtils.GetParentControlObject(this, "Vw_customer_equip_inventoryTableControl1")).ResetData = true;
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
        
        public virtual void SetViewRowButton1()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void ViewRowButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../equipment_inventory/Facility-Show-Equipment-inventory.aspx?equipment_id={Vw_customer_equip_inventoryTableControl1Row:PK}";
            
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
                return (string)this.ViewState["BaseVw_customer_equip_inventoryTableControl1Row_Rec"];
            }
            set {
                this.ViewState["BaseVw_customer_equip_inventoryTableControl1Row_Rec"] = value;
            }
        }
        
        public Vw_customer_equip_inventoryRecord DataSource {
            get {
                return (Vw_customer_equip_inventoryRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal category_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal category_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal condition_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_received1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_received1");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_receivedLabel3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_receivedLabel3");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_sold1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_sold1");
            }
        }
            
        public System.Web.UI.WebControls.Literal date_soldLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_soldLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal disposition_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition_id1");
            }
        }
            
        public System.Web.UI.WebControls.Image equipment_inventory_pic {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_pic");
            }
        }
            
        public System.Web.UI.WebControls.Literal final_sale_price1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_sale_price1");
            }
        }
            
        public System.Web.UI.WebControls.Literal final_sale_priceLabel3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_sale_priceLabel3");
            }
        }
        
        public System.Web.UI.WebControls.Literal make_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal make_idLabel3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idLabel3");
            }
        }
        
        public System.Web.UI.WebControls.Literal model_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal model_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal proposed_sale_price1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposed_sale_price1");
            }
        }
            
        public System.Web.UI.WebControls.Literal proposed_sale_priceLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposed_sale_priceLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal purchase_price1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_price1");
            }
        }
            
        public System.Web.UI.WebControls.Literal purchase_priceLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_priceLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal sale_method_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sale_method_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal serial_number1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_number1");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton ViewRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ViewRowButton1");
            }
        }
        
        public System.Web.UI.WebControls.Literal warehouse_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_idLabel3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_idLabel3");
            }
        }
        
        public System.Web.UI.WebControls.Literal warehouse_location_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal warehouse_location_idLabel5 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_idLabel5");
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
        Vw_customer_equip_inventoryRecord rec = null;
             
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
    Vw_customer_equip_inventoryRecord rec = null;
    
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

        
        public virtual Vw_customer_equip_inventoryRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Vw_customer_equip_inventoryView.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Vw_customer_equip_inventoryTableControl1 control on the Facility_Show_Equipment_inventory_Table page.
// Do not modify this class. Instead override any method in Vw_customer_equip_inventoryTableControl1.
public class BaseVw_customer_equip_inventoryTableControl1 : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseVw_customer_equip_inventoryTableControl1()
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
                if  (this.InSession(this.category_idFilter)) 				
                    initialVal = this.GetFromSession(this.category_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"category_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.category_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.category_idFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.make_idFilter)) 				
                    initialVal = this.GetFromSession(this.make_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"make_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.make_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.make_idFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.model_idFilter)) 				
                    initialVal = this.GetFromSession(this.model_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"model_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.model_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.model_idFilter.SelectedValue = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Vw_customer_equip_inventoryView.date_received, OrderByItem.OrderDir.Desc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination1.FirstPage.Click += Pagination1_FirstPage_Click;
                        
                    this.Pagination1.LastPage.Click += Pagination1_LastPage_Click;
                        
                    this.Pagination1.NextPage.Click += Pagination1_NextPage_Click;
                        
                    this.Pagination1.PageSizeButton.Click += Pagination1_PageSizeButton_Click;
                        
                    this.Pagination1.PreviousPage.Click += Pagination1_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.ExcelButton1.Click += ExcelButton1_Click;
                        
                    this.PDFButton1.Click += PDFButton1_Click;
                        
                    this.ResetButton1.Click += ResetButton1_Click;
                        
                    this.WordButton1.Click += WordButton1_Click;
                        
                    this.ActionsButton1.Button.Click += ActionsButton1_Click;
                        
                    this.FilterButton1.Button.Click += FilterButton1_Click;
                        
                    this.FiltersButton1.Button.Click += FiltersButton1_Click;
                        
            this.category_idFilter.SelectedIndexChanged += new EventHandler(category_idFilter_SelectedIndexChanged);
            
            this.make_idFilter.SelectedIndexChanged += new EventHandler(make_idFilter_SelectedIndexChanged);
            
            this.model_idFilter.SelectedIndexChanged += new EventHandler(model_idFilter_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(OEMConversion.Business.Vw_customer_equip_inventoryRecord);
                      this.DataSource = (Vw_customer_equip_inventoryRecord[])(alist.ToArray(myrec));
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
                    foreach (Vw_customer_equip_inventoryTableControl1Row rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Vw_customer_equip_inventoryRecord);
                    this.DataSource = (Vw_customer_equip_inventoryRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Vw_customer_equip_inventoryRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Vw_customer_equip_inventoryView.Column1, true);          
            // selCols.Add(Vw_customer_equip_inventoryView.Column2, true);          
            // selCols.Add(Vw_customer_equip_inventoryView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Vw_customer_equip_inventoryView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Vw_customer_equip_inventoryView databaseTable = new Vw_customer_equip_inventoryView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Vw_customer_equip_inventoryRecord)) as Vw_customer_equip_inventoryRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Vw_customer_equip_inventoryView.Column1, true);          
            // selCols.Add(Vw_customer_equip_inventoryView.Column2, true);          
            // selCols.Add(Vw_customer_equip_inventoryView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Vw_customer_equip_inventoryView.GetRecordCount(join, where);
            else
            {
                Vw_customer_equip_inventoryView databaseTable = new Vw_customer_equip_inventoryView();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vw_customer_equip_inventoryTableControl1Repeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Vw_customer_equip_inventoryTableControl1Row recControl = (Vw_customer_equip_inventoryTableControl1Row)(repItem.FindControl("Vw_customer_equip_inventoryTableControl1Row"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                Setcategory_idFilter();
                Setcategory_idLabel2();
                Setcondition_idLabel1();
                Setdate_receivedLabel2();
                Setdisposition_idLabel1();
                
                
                
                Setfinal_sale_priceLabel2();
                Setmake_idFilter();
                Setmake_idLabel2();
                Setmake_idLabel4();
                Setmodel_idFilter();
                Setmodel_idLabel2();
                
                
                Setreceived_from_customer_idLabel1();
                
                Setsale_method_idLabel1();
                Setserial_numberLabel1();
                
                Setwarehouse_location_idLabel4();
                
                SetExcelButton1();
              
                SetPDFButton1();
              
                SetResetButton1();
              
                SetWordButton1();
              
                SetActionsButton1();
              
                SetFilterButton1();
              
                SetFiltersButton1();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFiltersButton1();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton1.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton1.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Vw_customer_equip_inventoryView.disposition_id, this.DataSource);
            this.Page.PregetDfkaRecords(Vw_customer_equip_inventoryView.sale_method_id, this.DataSource);
            this.Page.PregetDfkaRecords(Vw_customer_equip_inventoryView.warehouse_id, this.DataSource);
            this.Page.PregetDfkaRecords(Vw_customer_equip_inventoryView.warehouse_location_id, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton1"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton1"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton1"));
                                
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


            
            this.category_idFilter.ClearSelection();
            
            this.make_idFilter.ClearSelection();
            
            this.model_idFilter.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Vw_customer_equip_inventoryView.date_received, OrderByItem.OrderDir.Desc);
                 
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
                this.Pagination1.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination1.CurrentPage.Text = "0";
            }
            this.Pagination1.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for Vw_customer_equip_inventoryTableControl1 pagination.
        
            this.Pagination1.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination1.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination1.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination1.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination1.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination1.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination1.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination1.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (Vw_customer_equip_inventoryTableControl1Row recCtl in this.GetRecordControls())
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
            foreach (Vw_customer_equip_inventoryTableControl1Row recCtl in this.GetRecordControls()){
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
            Vw_customer_equip_inventoryView.Instance.InnerFilter = null;
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
          
            if (MiscUtils.IsValueSelected(this.category_idFilter)) {
                        
                wc.iAND(Vw_customer_equip_inventoryView.category_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.category_idFilter, this.GetFromSession(this.category_idFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.make_idFilter)) {
                        
                wc.iAND(Vw_customer_equip_inventoryView.make_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.make_idFilter, this.GetFromSession(this.make_idFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.model_idFilter)) {
                        
                wc.iAND(Vw_customer_equip_inventoryView.model_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.model_idFilter, this.GetFromSession(this.model_idFilter)), false, false);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Vw_customer_equip_inventoryView.Instance.InnerFilter = null;
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
          
      String category_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "category_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(category_idFilterSelectedValue)) {

              
                wc.iAND(Vw_customer_equip_inventoryView.category_id, BaseFilter.ComparisonOperator.EqualsTo, category_idFilterSelectedValue, false, false);
                      
      }
                      
      String make_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "make_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(make_idFilterSelectedValue)) {

              
                wc.iAND(Vw_customer_equip_inventoryView.make_id, BaseFilter.ComparisonOperator.EqualsTo, make_idFilterSelectedValue, false, false);
                      
      }
                      
      String model_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "model_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(model_idFilterSelectedValue)) {

              
                wc.iAND(Vw_customer_equip_inventoryView.model_id, BaseFilter.ComparisonOperator.EqualsTo, model_idFilterSelectedValue, false, false);
                      
      }
                      

            return wc;
        }

        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Vw_customer_equip_inventoryView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"vw_customer_equip_inventory_.corporate_id"), new BaseClasses.Data.IdentifierAliasInfo(@"vw_customer_equip_inventory_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.corporate_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("USERID()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("USERID()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("USERID()", false) == "--PLEASE_SELECT--" || EvaluateFormula("USERID()", false) == "--ANY--") whereClause.RunQuery = false;

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
        
            if (this.Pagination1.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination1.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vw_customer_equip_inventoryTableControl1Repeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Vw_customer_equip_inventoryTableControl1Row recControl = (Vw_customer_equip_inventoryTableControl1Row)(repItem.FindControl("Vw_customer_equip_inventoryTableControl1Row"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Vw_customer_equip_inventoryRecord rec = new Vw_customer_equip_inventoryRecord();
        
                        if (recControl.category_id1.Text != "") {
                            rec.Parse(recControl.category_id1.Text, Vw_customer_equip_inventoryView.category_id);
                  }
                
                        if (recControl.condition_id1.Text != "") {
                            rec.Parse(recControl.condition_id1.Text, Vw_customer_equip_inventoryView.condition_id);
                  }
                
                        if (recControl.CustName.Text != "") {
                            rec.Parse(recControl.CustName.Text, Vw_customer_equip_inventoryView.CustName);
                  }
                
                        if (recControl.date_received1.Text != "") {
                            rec.Parse(recControl.date_received1.Text, Vw_customer_equip_inventoryView.date_received);
                  }
                
                        if (recControl.date_sold1.Text != "") {
                            rec.Parse(recControl.date_sold1.Text, Vw_customer_equip_inventoryView.date_sold);
                  }
                
                        if (recControl.disposition_id1.Text != "") {
                            rec.Parse(recControl.disposition_id1.Text, Vw_customer_equip_inventoryView.disposition_id);
                  }
                
                        if (recControl.final_sale_price1.Text != "") {
                            rec.Parse(recControl.final_sale_price1.Text, Vw_customer_equip_inventoryView.final_sale_price);
                  }
                
                        if (recControl.make_id1.Text != "") {
                            rec.Parse(recControl.make_id1.Text, Vw_customer_equip_inventoryView.make_id);
                  }
                
                        if (recControl.model_id1.Text != "") {
                            rec.Parse(recControl.model_id1.Text, Vw_customer_equip_inventoryView.model_id);
                  }
                
                        if (recControl.proposed_sale_price1.Text != "") {
                            rec.Parse(recControl.proposed_sale_price1.Text, Vw_customer_equip_inventoryView.proposed_sale_price);
                  }
                
                        if (recControl.purchase_price1.Text != "") {
                            rec.Parse(recControl.purchase_price1.Text, Vw_customer_equip_inventoryView.purchase_price);
                  }
                
                        if (recControl.sale_method_id1.Text != "") {
                            rec.Parse(recControl.sale_method_id1.Text, Vw_customer_equip_inventoryView.sale_method_id);
                  }
                
                        if (recControl.serial_number1.Text != "") {
                            rec.Parse(recControl.serial_number1.Text, Vw_customer_equip_inventoryView.serial_number);
                  }
                
                        if (recControl.warehouse_id1.Text != "") {
                            rec.Parse(recControl.warehouse_id1.Text, Vw_customer_equip_inventoryView.warehouse_id);
                  }
                
                        if (recControl.warehouse_location_id1.Text != "") {
                            rec.Parse(recControl.warehouse_location_id1.Text, Vw_customer_equip_inventoryView.warehouse_location_id);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Vw_customer_equip_inventoryRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Vw_customer_equip_inventoryRecord);
                this.DataSource = (Vw_customer_equip_inventoryRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Vw_customer_equip_inventoryTableControl1Row rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Vw_customer_equip_inventoryTableControl1Row rec)            
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
        
        public virtual void Setcategory_idLabel2()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setdate_receivedLabel2()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.date_receivedLabel2.Text = "Some value";
                    
                    
        }
                
        public virtual void Setdisposition_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setfinal_sale_priceLabel2()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.final_sale_priceLabel2.Text = "Some value";
                    
                    
        }
                
        public virtual void Setmake_idLabel2()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.make_idLabel2.Text = "Some value";
                    
                    
        }
                
        public virtual void Setmake_idLabel4()
                  {
                  
                    
        }
                
        public virtual void Setmodel_idLabel2()
                  {
                  
                    
        }
                
        public virtual void Setreceived_from_customer_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setsale_method_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setserial_numberLabel1()
                  {
                  
                    
        }
                
        public virtual void Setwarehouse_location_idLabel4()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.warehouse_location_idLabel4.Text = "Some value";
                    
                    
        }
                
        public virtual void Setcategory_idFilter()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh make_idFilter,model_idFilter controls
            this.category_idFilter.AutoPostBack = true;
            
            this.Populatecategory_idFilter(MiscUtils.GetSelectedValue(this.category_idFilter,  GetFromSession(this.category_idFilter)), 500);					
                                     
        }
            
        public virtual void Setmake_idFilter()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh model_idFilter controls
            this.make_idFilter.AutoPostBack = true;
            
            this.Populatemake_idFilter(MiscUtils.GetSelectedValue(this.make_idFilter,  GetFromSession(this.make_idFilter)), 500);					
                                     
        }
            
        public virtual void Setmodel_idFilter()
        {
            
            this.Populatemodel_idFilter(MiscUtils.GetSelectedValue(this.model_idFilter,  GetFromSession(this.model_idFilter)), 500);					
                                     
        }
            
        // Get the filters' data for category_idFilter.
                
        protected virtual void Populatecategory_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.category_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_category_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_category_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.category_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Vw_customer_equip_inventoryView.category_id, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Vw_customer_equip_inventoryRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Vw_customer_equip_inventoryView.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Vw_customer_equip_inventoryRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.category_idSpecified) 
                        {
                            cvalue = itemValue.category_id.ToString();
                            if (counter < maxItems && this.category_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("category_id", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.category_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.category_idFilter.Items.Add(newItem);

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
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.category_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.category_idFilter.SelectedValue != null && this.category_idFilter.Items.FindByValue(this.category_idFilter.SelectedValue) == null)
                this.category_idFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for make_idFilter.
                
        protected virtual void Populatemake_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.make_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_make_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_make_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.make_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Vw_customer_equip_inventoryView.make_id, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Vw_customer_equip_inventoryRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Vw_customer_equip_inventoryView.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Vw_customer_equip_inventoryRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.make_idSpecified) 
                        {
                            cvalue = itemValue.make_id.ToString();
                            if (counter < maxItems && this.make_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("make_id", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.make_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.make_idFilter.Items.Add(newItem);

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
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.make_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.make_idFilter.SelectedValue != null && this.make_idFilter.Items.FindByValue(this.make_idFilter.SelectedValue) == null)
                this.make_idFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for model_idFilter.
                
        protected virtual void Populatemodel_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.model_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_model_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_model_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.model_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Vw_customer_equip_inventoryView.model_id, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Vw_customer_equip_inventoryRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = Vw_customer_equip_inventoryView.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (Vw_customer_equip_inventoryRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.model_idSpecified) 
                        {
                            cvalue = itemValue.model_id.ToString();
                            if (counter < maxItems && this.model_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("model_id", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.model_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.model_idFilter.Items.Add(newItem);

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
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.model_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.model_idFilter.SelectedValue != null && this.model_idFilter.Items.FindByValue(this.model_idFilter.SelectedValue) == null)
                this.model_idFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_category_idFilter()
        {
            // Create a where clause for the filter category_idFilter.
            // This function is called by the Populate method to load the items 
            // in the category_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnJoinFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Vw_customer_equip_inventoryView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"vw_customer_equip_inventory_.corporate_id"), new BaseClasses.Data.IdentifierAliasInfo(@"vw_customer_equip_inventory_", null), BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.corporate_id"), new BaseClasses.Data.IdentifierAliasInfo(@"login_", null),  BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("USERID()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.LoginTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"login_.login_id"), EvaluateFormula("USERID()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("USERID()", false) == "--PLEASE_SELECT--" || EvaluateFormula("USERID()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_make_idFilter()
        {
            // Create a where clause for the filter make_idFilter.
            // This function is called by the Populate method to load the items 
            // in the make_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("Vw_customer_equip_inventoryTableControl1.category_idFilter.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Vw_customer_equip_inventoryView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"vw_customer_equip_inventory_.category_id"), EvaluateFormula("Vw_customer_equip_inventoryTableControl1.category_idFilter.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Vw_customer_equip_inventoryTableControl1.category_idFilter.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Vw_customer_equip_inventoryTableControl1.category_idFilter.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_model_idFilter()
        {
            // Create a where clause for the filter model_idFilter.
            // This function is called by the Populate method to load the items 
            // in the model_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("Vw_customer_equip_inventoryTableControl1.make_idFilter.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Vw_customer_equip_inventoryView, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"vw_customer_equip_inventory_.make_id"), EvaluateFormula("Vw_customer_equip_inventoryTableControl1.make_idFilter.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("Vw_customer_equip_inventoryTableControl1.make_idFilter.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Vw_customer_equip_inventoryTableControl1.make_idFilter.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
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
        
            this.SaveToSession(this.category_idFilter, this.category_idFilter.SelectedValue);
                  
            this.SaveToSession(this.make_idFilter, this.make_idFilter.SelectedValue);
                  
            this.SaveToSession(this.model_idFilter, this.model_idFilter.SelectedValue);
                  
            
                    
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
          
      this.SaveToSession("category_idFilter_Ajax", this.category_idFilter.SelectedValue);
              
      this.SaveToSession("make_idFilter_Ajax", this.make_idFilter.SelectedValue);
              
      this.SaveToSession("model_idFilter_Ajax", this.model_idFilter.SelectedValue);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.category_idFilter);
            this.RemoveFromSession(this.make_idFilter);
            this.RemoveFromSession(this.model_idFilter);
            
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

            string orderByStr = (string)ViewState["Vw_customer_equip_inventoryTableControl1_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination1");
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
                this.ViewState["Vw_customer_equip_inventoryTableControl1_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton1()                
              
        {
        
   
        }
            
        public virtual void SetPDFButton1()                
              
        {
        
   
        }
            
        public virtual void SetResetButton1()                
              
        {
        
   
        }
            
        public virtual void SetWordButton1()                
              
        {
        
   
        }
            
        public virtual void SetActionsButton1()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton1()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton1()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton1 = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton1"));
         themeButtonFiltersButton1.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(category_idFilter))
                themeButtonFiltersButton1.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(make_idFilter))
                themeButtonFiltersButton1.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(model_idFilter))
                themeButtonFiltersButton1.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination1_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination1_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination1_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination1_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination1.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination1.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination1_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void ExcelButton1_Click(object sender, ImageClickEventArgs args)
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


              this.TotalRecords = Vw_customer_equip_inventoryView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Vw_customer_equip_inventoryView.date_received,
             Vw_customer_equip_inventoryView.make_id,
             Vw_customer_equip_inventoryView.model_id,
             Vw_customer_equip_inventoryView.serial_number,
             Vw_customer_equip_inventoryView.category_id,
             Vw_customer_equip_inventoryView.condition_id,
             Vw_customer_equip_inventoryView.purchase_price,
             Vw_customer_equip_inventoryView.disposition_id,
             Vw_customer_equip_inventoryView.sale_method_id,
             Vw_customer_equip_inventoryView.proposed_sale_price,
             Vw_customer_equip_inventoryView.date_sold,
             Vw_customer_equip_inventoryView.final_sale_price,
             Vw_customer_equip_inventoryView.warehouse_id,
             Vw_customer_equip_inventoryView.warehouse_location_id,
             Vw_customer_equip_inventoryView.CustName,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Vw_customer_equip_inventoryView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Vw_customer_equip_inventoryView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Vw_customer_equip_inventoryView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Vw_customer_equip_inventoryView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.date_received, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.make_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.model_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.serial_number, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.category_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.condition_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.purchase_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.disposition_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.sale_method_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.proposed_sale_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.date_sold, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.final_sale_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.warehouse_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.warehouse_location_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_customer_equip_inventoryView.CustName, "Default"));


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
                val = Vw_customer_equip_inventoryView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void PDFButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Facility-Show-Equipment-inventory-Table.PDFButton1.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_customer_equip_inventory";
                // If Facility-Show-Equipment-inventory-Table.PDFButton1.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Vw_customer_equip_inventoryView.date_received.Name, ReportEnum.Align.Left, "${date_received}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.make_id.Name, ReportEnum.Align.Left, "${make_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.model_id.Name, ReportEnum.Align.Left, "${model_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.category_id.Name, ReportEnum.Align.Left, "${category_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_customer_equip_inventoryView.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.purchase_price.Name, ReportEnum.Align.Right, "${purchase_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.disposition_id.Name, ReportEnum.Align.Left, "${disposition_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.sale_method_id.Name, ReportEnum.Align.Left, "${sale_method_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.proposed_sale_price.Name, ReportEnum.Align.Right, "${proposed_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.date_sold.Name, ReportEnum.Align.Left, "${date_sold}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.final_sale_price.Name, ReportEnum.Align.Right, "${final_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.warehouse_id.Name, ReportEnum.Align.Left, "${warehouse_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.warehouse_location_id.Name, ReportEnum.Align.Left, "${warehouse_location_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.CustName.Name, ReportEnum.Align.Left, "${CustName}", ReportEnum.Align.Left, 28);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Vw_customer_equip_inventoryView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Vw_customer_equip_inventoryView.GetRecordCount(joinFilter,whereClause);
                Vw_customer_equip_inventoryRecord[] records = null;
                
                do
                {
                    
                    records = Vw_customer_equip_inventoryView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Vw_customer_equip_inventoryRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${date_received}", record.Format(Vw_customer_equip_inventoryView.date_received), ReportEnum.Align.Left, 300);
                             report.AddData("${make_id}", record.Format(Vw_customer_equip_inventoryView.make_id), ReportEnum.Align.Left, 300);
                             report.AddData("${model_id}", record.Format(Vw_customer_equip_inventoryView.model_id), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Vw_customer_equip_inventoryView.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${category_id}", record.Format(Vw_customer_equip_inventoryView.category_id), ReportEnum.Align.Left, 300);
                             report.AddData("${condition_id}", record.Format(Vw_customer_equip_inventoryView.condition_id), ReportEnum.Align.Left, 300);
                             report.AddData("${purchase_price}", record.Format(Vw_customer_equip_inventoryView.purchase_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.disposition_id)){
                                 report.AddData("${disposition_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.disposition_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.disposition_id.ToString(), Vw_customer_equip_inventoryView.disposition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.disposition_id.IsApplyDisplayAs){
                                     report.AddData("${disposition_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${disposition_id}", record.Format(Vw_customer_equip_inventoryView.disposition_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.sale_method_id)){
                                 report.AddData("${sale_method_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.sale_method_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.sale_method_id.ToString(), Vw_customer_equip_inventoryView.sale_method_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.sale_method_id.IsApplyDisplayAs){
                                     report.AddData("${sale_method_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${sale_method_id}", record.Format(Vw_customer_equip_inventoryView.sale_method_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${proposed_sale_price}", record.Format(Vw_customer_equip_inventoryView.proposed_sale_price), ReportEnum.Align.Right, 300);
                             report.AddData("${date_sold}", record.Format(Vw_customer_equip_inventoryView.date_sold), ReportEnum.Align.Left, 300);
                             report.AddData("${final_sale_price}", record.Format(Vw_customer_equip_inventoryView.final_sale_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_id)){
                                 report.AddData("${warehouse_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.warehouse_id.ToString(), Vw_customer_equip_inventoryView.warehouse_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.warehouse_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_id}", record.Format(Vw_customer_equip_inventoryView.warehouse_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_location_id)){
                                 report.AddData("${warehouse_location_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_location_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.warehouse_location_id.ToString(), Vw_customer_equip_inventoryView.warehouse_location_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.warehouse_location_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_location_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_location_id}", record.Format(Vw_customer_equip_inventoryView.warehouse_location_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${CustName}", record.Format(Vw_customer_equip_inventoryView.CustName), ReportEnum.Align.Left, 300);

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
        public virtual void ResetButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.category_idFilter.ClearSelection();
            
              this.make_idFilter.ClearSelection();
            
              this.model_idFilter.ClearSelection();
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(Vw_customer_equip_inventoryView.date_received, OrderByItem.OrderDir.Desc);          
                      
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
        public virtual void WordButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Facility-Show-Equipment-inventory-Table.WordButton1.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_customer_equip_inventory";
                // If Facility-Show-Equipment-inventory-Table.WordButton1.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Vw_customer_equip_inventoryView.date_received.Name, ReportEnum.Align.Left, "${date_received}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.make_id.Name, ReportEnum.Align.Left, "${make_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.model_id.Name, ReportEnum.Align.Left, "${model_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.category_id.Name, ReportEnum.Align.Left, "${category_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_customer_equip_inventoryView.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.purchase_price.Name, ReportEnum.Align.Right, "${purchase_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.disposition_id.Name, ReportEnum.Align.Left, "${disposition_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.sale_method_id.Name, ReportEnum.Align.Left, "${sale_method_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.proposed_sale_price.Name, ReportEnum.Align.Right, "${proposed_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.date_sold.Name, ReportEnum.Align.Left, "${date_sold}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.final_sale_price.Name, ReportEnum.Align.Right, "${final_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_customer_equip_inventoryView.warehouse_id.Name, ReportEnum.Align.Left, "${warehouse_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.warehouse_location_id.Name, ReportEnum.Align.Left, "${warehouse_location_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_customer_equip_inventoryView.CustName.Name, ReportEnum.Align.Left, "${CustName}", ReportEnum.Align.Left, 28);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Vw_customer_equip_inventoryView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Vw_customer_equip_inventoryView.GetColumnList();
                Vw_customer_equip_inventoryRecord[] records = null;
                do
                {
                    records = Vw_customer_equip_inventoryView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Vw_customer_equip_inventoryRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${date_received}", record.Format(Vw_customer_equip_inventoryView.date_received), ReportEnum.Align.Left, 300);
                             report.AddData("${make_id}", record.Format(Vw_customer_equip_inventoryView.make_id), ReportEnum.Align.Left, 300);
                             report.AddData("${model_id}", record.Format(Vw_customer_equip_inventoryView.model_id), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Vw_customer_equip_inventoryView.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${category_id}", record.Format(Vw_customer_equip_inventoryView.category_id), ReportEnum.Align.Left, 300);
                             report.AddData("${condition_id}", record.Format(Vw_customer_equip_inventoryView.condition_id), ReportEnum.Align.Left, 300);
                             report.AddData("${purchase_price}", record.Format(Vw_customer_equip_inventoryView.purchase_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.disposition_id)){
                                 report.AddData("${disposition_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.disposition_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.disposition_id.ToString(), Vw_customer_equip_inventoryView.disposition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.disposition_id.IsApplyDisplayAs){
                                     report.AddData("${disposition_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${disposition_id}", record.Format(Vw_customer_equip_inventoryView.disposition_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.sale_method_id)){
                                 report.AddData("${sale_method_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.sale_method_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.sale_method_id.ToString(), Vw_customer_equip_inventoryView.sale_method_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.sale_method_id.IsApplyDisplayAs){
                                     report.AddData("${sale_method_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${sale_method_id}", record.Format(Vw_customer_equip_inventoryView.sale_method_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${proposed_sale_price}", record.Format(Vw_customer_equip_inventoryView.proposed_sale_price), ReportEnum.Align.Right, 300);
                             report.AddData("${date_sold}", record.Format(Vw_customer_equip_inventoryView.date_sold), ReportEnum.Align.Left, 300);
                             report.AddData("${final_sale_price}", record.Format(Vw_customer_equip_inventoryView.final_sale_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_id)){
                                 report.AddData("${warehouse_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.warehouse_id.ToString(), Vw_customer_equip_inventoryView.warehouse_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.warehouse_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_id}", record.Format(Vw_customer_equip_inventoryView.warehouse_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_location_id)){
                                 report.AddData("${warehouse_location_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Vw_customer_equip_inventoryView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Vw_customer_equip_inventoryView.warehouse_location_id);
                                 _DFKA = Vw_customer_equip_inventoryView.GetDFKA(record.warehouse_location_id.ToString(), Vw_customer_equip_inventoryView.warehouse_location_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Vw_customer_equip_inventoryView.warehouse_location_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_location_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_location_id}", record.Format(Vw_customer_equip_inventoryView.warehouse_location_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${CustName}", record.Format(Vw_customer_equip_inventoryView.CustName), ReportEnum.Align.Left, 300);

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
        public virtual void ActionsButton1_Click(object sender, EventArgs args)
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
        public virtual void FilterButton1_Click(object sender, EventArgs args)
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
        public virtual void FiltersButton1_Click(object sender, EventArgs args)
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
        
        // event handler for FieldFilter
        protected virtual void category_idFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           
                Setmake_idFilter();
                Setmodel_idFilter();				
        }
            
        // event handler for FieldFilter
        protected virtual void make_idFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           
                Setmodel_idFilter();				
        }
            
        // event handler for FieldFilter
        protected virtual void model_idFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Vw_customer_equip_inventoryView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Vw_customer_equip_inventoryRecord[] DataSource {
             
            get {
                return (Vw_customer_equip_inventoryRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public OEMConversion.UI.IThemeButtonWithArrow ActionsButton1 {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActionsButton1");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList category_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal category_idLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "category_idLabel2");
            }
        }
        
        public System.Web.UI.WebControls.Literal condition_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal date_receivedLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "date_receivedLabel2");
            }
        }
        
        public System.Web.UI.WebControls.Literal disposition_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "disposition_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton1");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton1 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton1");
            }
        }
        
        public OEMConversion.UI.IThemeButtonWithArrow FiltersButton1 {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FiltersButton1");
            }
        }
        
        public System.Web.UI.WebControls.Literal final_sale_priceLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "final_sale_priceLabel2");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList make_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal make_idLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idLabel2");
            }
        }
        
        public System.Web.UI.WebControls.Literal make_idLabel4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idLabel4");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList model_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal model_idLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_idLabel2");
            }
        }
        
        public OEMConversion.UI.IPaginationModern Pagination1 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton1");
            }
        }
        
        public System.Web.UI.WebControls.Literal received_from_customer_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_customer_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton1");
            }
        }
        
        public System.Web.UI.WebControls.Literal sale_method_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "sale_method_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_numberLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_numberLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title1");
            }
        }
        
        public System.Web.UI.WebControls.Literal warehouse_location_idLabel4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "warehouse_location_idLabel4");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton WordButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton1");
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
                Vw_customer_equip_inventoryTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Vw_customer_equip_inventoryRecord rec = null;
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
                Vw_customer_equip_inventoryTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Vw_customer_equip_inventoryRecord rec = null;
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
          
        public virtual Vw_customer_equip_inventoryTableControl1Row GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Vw_customer_equip_inventoryTableControl1Row[] GetSelectedRecordControls()
        {
        
            return (Vw_customer_equip_inventoryTableControl1Row[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Facility_Show_Equipment_inventory_Table.Vw_customer_equip_inventoryTableControl1Row")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Vw_customer_equip_inventoryTableControl1Row[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Vw_customer_equip_inventoryTableControl1Row recCtl in recordList)
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

        public virtual Vw_customer_equip_inventoryTableControl1Row[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Vw_customer_equip_inventoryTableControl1Row");
	          List<Vw_customer_equip_inventoryTableControl1Row> list = new List<Vw_customer_equip_inventoryTableControl1Row>();
	          foreach (Vw_customer_equip_inventoryTableControl1Row recCtrl in recCtrls) {
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

  