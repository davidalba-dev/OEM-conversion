
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Equipment_inventory_Table1.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Equipment_inventory_Table1
{
  

#region "Section 1: Place your customizations here."

    
public class Equipment_inventoryTableControlRow : BaseEquipment_inventoryTableControlRow
{
      
        // The BaseEquipment_inventoryTableControlRow implements code for a ROW within the
        // the Equipment_inventoryTableControl table.  The BaseEquipment_inventoryTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Equipment_inventoryTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Equipment_inventoryTableControl : BaseEquipment_inventoryTableControl
{
    // The BaseEquipment_inventoryTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Equipment_inventoryTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_inventoryTableControlRow control on the Show_Equipment_inventory_Table1 page.
// Do not modify this class. Instead override any method in Equipment_inventoryTableControlRow.
public class BaseEquipment_inventoryTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_inventoryTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_inventoryTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Equipment_inventoryTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.condition_id.Click += condition_id_Click;
                        
                    this.received_from_contact_id.Click += received_from_contact_id_Click;
                        
                    this.received_from_customer_id.Click += received_from_customer_id_Click;
                        
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
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseEquipment_inventoryTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Equipment_inventoryRecord();
            
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
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.category_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.category_idSpecified) {
                								
                // If the category_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.category_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.category_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.category_id.ToString(),Equipment_inventoryTable.category_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.category_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.category_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // category_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.category_id.Text = Equipment_inventoryTable.category_id.Format(Equipment_inventoryTable.category_id.DefaultValue);
            		
            }
            
            // If the category_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.category_id.Text == null ||
                this.category_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.category_id.Text = "&nbsp;";
            }
                                     
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
            
            // If the cogs is NULL or blank, then use the value specified  
            // on Properties.
            if (this.cogs.Text == null ||
                this.cogs.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.cogs.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcondition_id()
        {
            
                    
            // Set the condition_id LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.condition_id is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.condition_idSpecified) {
                								
                // If the condition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.condition_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.condition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.condition_id.ToString(),Equipment_inventoryTable.condition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.condition_id);
                                  
                                
                this.condition_id.Text = formattedValue;
                
                  this.condition_id.ToolTip = "Go to " + this.condition_id.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.condition_id.Text = Equipment_inventoryTable.condition_id.Format(Equipment_inventoryTable.condition_id.DefaultValue);
            		
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
            
            // If the customer_ein is NULL or blank, then use the value specified  
            // on Properties.
            if (this.customer_ein.Text == null ||
                this.customer_ein.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.customer_ein.Text = "&nbsp;";
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
            
            // If the date_disposed is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_disposed.Text == null ||
                this.date_disposed.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_disposed.Text = "&nbsp;";
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
            
            // If the date_sold is NULL or blank, then use the value specified  
            // on Properties.
            if (this.date_sold.Text == null ||
                this.date_sold.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.date_sold.Text = "&nbsp;";
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
            
            // If the description is NULL or blank, then use the value specified  
            // on Properties.
            if (this.description.Text == null ||
                this.description.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.description.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdisposition_id()
        {
            
                    
            // Set the disposition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.disposition_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.disposition_idSpecified) {
                								
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
        
              this.disposition_id.Text = Equipment_inventoryTable.disposition_id.Format(Equipment_inventoryTable.disposition_id.DefaultValue);
            		
            }
            
            // If the disposition_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.disposition_id.Text == null ||
                this.disposition_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.disposition_id.Text = "&nbsp;";
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
            
            // If the doc_num is NULL or blank, then use the value specified  
            // on Properties.
            if (this.doc_num.Text == null ||
                this.doc_num.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.doc_num.Text = "&nbsp;";
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
            
            // If the equipment_phi is NULL or blank, then use the value specified  
            // on Properties.
            if (this.equipment_phi.Text == null ||
                this.equipment_phi.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.equipment_phi.Text = "&nbsp;";
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
            
            // If the final_sale_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.final_sale_price.Text == null ||
                this.final_sale_price.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.final_sale_price.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setinventory_status_id()
        {
            
                    
            // Set the inventory_status_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.inventory_status_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.inventory_status_idSpecified) {
                								
                // If the inventory_status_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventoryTable.inventory_status_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.inventory_status_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // inventory_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.inventory_status_id.Text = Equipment_inventoryTable.inventory_status_id.Format(Equipment_inventoryTable.inventory_status_id.DefaultValue);
            		
            }
            
            // If the inventory_status_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.inventory_status_id.Text == null ||
                this.inventory_status_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.inventory_status_id.Text = "&nbsp;";
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
            
            // If the model_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.model_id.Text == null ||
                this.model_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.model_id.Text = "&nbsp;";
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
            
            // If the other_id_num is NULL or blank, then use the value specified  
            // on Properties.
            if (this.other_id_num.Text == null ||
                this.other_id_num.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.other_id_num.Text = "&nbsp;";
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
            
            // If the pd_date is NULL or blank, then use the value specified  
            // on Properties.
            if (this.pd_date.Text == null ||
                this.pd_date.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.pd_date.Text = "&nbsp;";
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
            
            // If the purchase_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.purchase_price.Text == null ||
                this.purchase_price.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.purchase_price.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setreceived_from_contact_id()
        {
            
                    
            // Set the received_from_contact_id LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.received_from_contact_id is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.received_from_contact_idSpecified) {
                								
                // If the received_from_contact_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_contact_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.received_from_contact_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.received_from_contact_id.ToString(),Equipment_inventoryTable.received_from_contact_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.received_from_contact_id);
                                  
                                
                this.received_from_contact_id.Text = formattedValue;
                
                  this.received_from_contact_id.ToolTip = "Go to " + this.received_from_contact_id.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // received_from_contact_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.received_from_contact_id.Text = Equipment_inventoryTable.received_from_contact_id.Format(Equipment_inventoryTable.received_from_contact_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setreceived_from_customer_id()
        {
            
                    
            // Set the received_from_customer_id LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.received_from_customer_id is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.received_from_customer_idSpecified) {
                								
                // If the received_from_customer_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_customer_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventoryTable.received_from_customer_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventoryTable.GetDFKA(this.DataSource.received_from_customer_id.ToString(),Equipment_inventoryTable.received_from_customer_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventoryTable.received_from_customer_id);
                                  
                                
                this.received_from_customer_id.Text = formattedValue;
                
                  this.received_from_customer_id.ToolTip = "Go to " + this.received_from_customer_id.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // received_from_customer_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.received_from_customer_id.Text = Equipment_inventoryTable.received_from_customer_id.Format(Equipment_inventoryTable.received_from_customer_id.DefaultValue);
            		
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
            
            // If the repair_notes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.repair_notes.Text == null ||
                this.repair_notes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.repair_notes.Text = "&nbsp;";
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
            
            // If the require_accessories is NULL or blank, then use the value specified  
            // on Properties.
            if (this.require_accessories.Text == null ||
                this.require_accessories.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.require_accessories.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setsale_method_id()
        {
            
                    
            // Set the sale_method_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.sale_method_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.sale_method_idSpecified) {
                								
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
        
              this.sale_method_id.Text = Equipment_inventoryTable.sale_method_id.Format(Equipment_inventoryTable.sale_method_id.DefaultValue);
            		
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
            
            // If the serial_number is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serial_number.Text == null ||
                this.serial_number.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serial_number.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setsold_from_id()
        {
            
                    
            // Set the sold_from_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.sold_from_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.sold_from_idSpecified) {
                								
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
        
              this.sold_from_id.Text = Equipment_inventoryTable.sold_from_id.Format(Equipment_inventoryTable.sold_from_id.DefaultValue);
            		
            }
            
            // If the sold_from_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.sold_from_id.Text == null ||
                this.sold_from_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.sold_from_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setwarehouse_id()
        {
            
                    
            // Set the warehouse_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.warehouse_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouse_idSpecified) {
                								
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
        
              this.warehouse_id.Text = Equipment_inventoryTable.warehouse_id.Format(Equipment_inventoryTable.warehouse_id.DefaultValue);
            		
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
            // DatabaseAYS_OEM%dbo.equipment_inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory record retrieved from the database.
            // this.warehouse_location_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.warehouse_location_idSpecified) {
                								
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
        
              this.warehouse_location_id.Text = Equipment_inventoryTable.warehouse_location_id.Format(Equipment_inventoryTable.warehouse_location_id.DefaultValue);
            		
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
                ((Equipment_inventoryTableControl)MiscUtils.GetParentControlObject(this, "Equipment_inventoryTableControl")).DataChanged = true;
                ((Equipment_inventoryTableControl)MiscUtils.GetParentControlObject(this, "Equipment_inventoryTableControl")).ResetData = true;
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
                
        public virtual void Getinventory_status_id()
        {
            
        }
                
        public virtual void Getmake_id()
        {
            
        }
                
        public virtual void Getmodel_id()
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
                
        public virtual void Getreceived_from_contact_id()
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
                
        public virtual void Getwarehouse_id()
        {
            
        }
                
        public virtual void Getwarehouse_location_id()
        {
            
        }
                

      // To customize, override this method in Equipment_inventoryTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_inventoryTableControl = false;
            hasFiltersEquipment_inventoryTableControl = hasFiltersEquipment_inventoryTableControl && false; // suppress warning
      
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
          Equipment_inventoryTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Equipment_inventoryTableControl)MiscUtils.GetParentControlObject(this, "Equipment_inventoryTableControl")).DataChanged = true;
            ((Equipment_inventoryTableControl)MiscUtils.GetParentControlObject(this, "Equipment_inventoryTableControl")).ResetData = true;
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
            
            
        
        // event handler for LinkButton
        public virtual void condition_id_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Conditions/Show-Conditions.aspx?Conditions={Equipment_inventoryTableControlRow:FK:FK_equipment_inventory_Conditions}";
            
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
            
            
        
        // event handler for LinkButton
        public virtual void received_from_contact_id_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../CustomerContacts/Show-CustomerContacts.aspx?CustomerContacts={Equipment_inventoryTableControlRow:FK:FK_equipment_inventory_CustomerContacts}";
            
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
            
            
        
        // event handler for LinkButton
        public virtual void received_from_customer_id_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Show-Customers.aspx?Customers={Equipment_inventoryTableControlRow:FK:FK_equipment_inventory_Customers}";
            
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
                return (string)this.ViewState["BaseEquipment_inventoryTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_inventoryTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.LinkButton condition_id {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id");
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
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
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
        
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
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
        
        public System.Web.UI.WebControls.Literal inventory_status_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_status_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal inventory_status_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_status_idLabel");
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
        
        public System.Web.UI.WebControls.LinkButton received_from_contact_id {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_contact_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal received_from_contact_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_contact_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton received_from_customer_id {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "received_from_customer_id");
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

  
// Base class for the Equipment_inventoryTableControl control on the Show_Equipment_inventory_Table1 page.
// Do not modify this class. Instead override any method in Equipment_inventoryTableControl.
public class BaseEquipment_inventoryTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseEquipment_inventoryTableControl()
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
                if  (this.InSession(this.inventory_status_idFromFilter)) 				
                    initialVal = this.GetFromSession(this.inventory_status_idFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"inventory_status_idFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.inventory_status_idFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.inventory_status_idToFilter)) 				
                    initialVal = this.GetFromSession(this.inventory_status_idToFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"inventory_status_idTo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.inventory_status_idToFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.SearchText)) 				
                    initialVal = this.GetFromSession(this.SearchText);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SearchText.Text = initialVal;
                            
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
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                                
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "SearchTextSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + SearchText.ClientID + "\");", true);
             
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
                      Type myrec = typeof(OEMConversion.Business.Equipment_inventoryRecord);
                      this.DataSource = (Equipment_inventoryRecord[])(alist.ToArray(myrec));
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
                    foreach (Equipment_inventoryTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Equipment_inventoryRecord);
                    this.DataSource = (Equipment_inventoryRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Equipment_inventoryRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Equipment_inventoryTable.Column1, true);          
            // selCols.Add(Equipment_inventoryTable.Column2, true);          
            // selCols.Add(Equipment_inventoryTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Equipment_inventoryTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Equipment_inventoryTable databaseTable = new Equipment_inventoryTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Equipment_inventoryRecord)) as Equipment_inventoryRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Equipment_inventoryTable.Column1, true);          
            // selCols.Add(Equipment_inventoryTable.Column2, true);          
            // selCols.Add(Equipment_inventoryTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Equipment_inventoryTable.GetRecordCount(join, where);
            else
            {
                Equipment_inventoryTable databaseTable = new Equipment_inventoryTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventoryTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Equipment_inventoryTableControlRow recControl = (Equipment_inventoryTableControlRow)(repItem.FindControl("Equipment_inventoryTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                Setinventory_status_idLabel1();
                
                
                
                
                
                
                
                SetSearchText();
                
                
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetResetButton();
              
                SetSearchButton();
              
                SetWordButton();
              
                SetActionsButton();
              
                SetFilterButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
                    
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
          
            this.Page.PregetDfkaRecords(Equipment_inventoryTable.category_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventoryTable.condition_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventoryTable.disposition_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventoryTable.received_from_contact_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventoryTable.received_from_customer_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventoryTable.sale_method_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventoryTable.sold_from_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventoryTable.warehouse_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventoryTable.warehouse_location_id, this.DataSource);
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


            
            this.inventory_status_idFromFilter.Text = "";
            
            this.inventory_status_idToFilter.Text = "";
            
            this.SearchText.Text = "";
            
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
    
            // Bind the buttons for Equipment_inventoryTableControl pagination.
        
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
              
            foreach (Equipment_inventoryTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Equipment_inventoryTableControlRow recCtl in this.GetRecordControls()){
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
            Equipment_inventoryTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.inventory_status_idFromFilter)) {
                        
                wc.iAND(Equipment_inventoryTable.inventory_status_id, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(this.inventory_status_idFromFilter, this.GetFromSession(this.inventory_status_idFromFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.inventory_status_idToFilter)) {
                        
                wc.iAND(Equipment_inventoryTable.inventory_status_id, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(this.inventory_status_idToFilter, this.GetFromSession(this.inventory_status_idToFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.SearchText)) {
                if (this.SearchText.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.SearchText.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.SearchText.Text.StartsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(3,this.SearchText.Text.Length-3);
                  }
                  if (this.SearchText.Text.EndsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(0,this.SearchText.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.SearchText.Text.Length - 1;
                      while (!Char.IsWhiteSpace(SearchText.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.SearchText.Text = this.SearchText.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.SearchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(Equipment_inventoryTable.oem_ein, true);
      
      cols.Add(Equipment_inventoryTable.serial_number, true);
      
      cols.Add(Equipment_inventoryTable.description, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                  
            bool bAnyFiltersChanged = false;
            
            if (MiscUtils.IsValueSelected(this.inventory_status_idFromFilter) || this.InSession(this.inventory_status_idFromFilter)){
                bAnyFiltersChanged = true;
                }
            
            if (MiscUtils.IsValueSelected(this.inventory_status_idToFilter) || this.InSession(this.inventory_status_idToFilter)){
                bAnyFiltersChanged = true;
                }
            
            if (MiscUtils.IsValueSelected(this.SearchText) || this.InSession(this.SearchText)){
                bAnyFiltersChanged = true;
                }
            
            if (!bAnyFiltersChanged) {
                wc.RunQuery = false;
            }
             
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_inventoryTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String inventory_status_idFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "inventory_status_idFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(inventory_status_idFromFilterSelectedValue)) {

              
                wc.iAND(Equipment_inventoryTable.inventory_status_id, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, inventory_status_idFromFilterSelectedValue, false, false);
                      
      }
                      
      String inventory_status_idToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "inventory_status_idToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(inventory_status_idToFilterSelectedValue)) {

              
                wc.iAND(Equipment_inventoryTable.inventory_status_id, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, inventory_status_idToFilterSelectedValue, false, false);
                      
      }
                      
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "SearchText") {
                String formatedSearchText = searchText;
                // strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (searchText.StartsWith("...")) {
                    formatedSearchText = searchText.Substring(3,searchText.Length-3);
                }
                if (searchText.EndsWith("...")) {
                    formatedSearchText = searchText.Substring(0,searchText.Length-3);
                }
                // After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim();
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(searchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
                    if (StringUtils.InvariantLCase(AutoTypeAheadSearch).Equals("wordsstartingwithsearchstring")) {
                
        ColumnList cols = new ColumnList();
      
      cols.Add(Equipment_inventoryTable.oem_ein, true);
      
      cols.Add(Equipment_inventoryTable.serial_number, true);
      
      cols.Add(Equipment_inventoryTable.description, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(Equipment_inventoryTable.oem_ein, true);
      
      cols.Add(Equipment_inventoryTable.serial_number, true);
      
      cols.Add(Equipment_inventoryTable.description, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
      }
    
                    } 
                    wc.iAND(search);
                  
                }
            }
                  

            return wc;
        }

        
        public virtual string[] GetAutoCompletionList_SearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            OEMConversion.Business.Equipment_inventoryRecord[] recordList  = Equipment_inventoryTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (Equipment_inventoryRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(Equipment_inventoryTable.oem_ein);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Equipment_inventoryTable.oem_ein.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Equipment_inventoryTable.oem_ein.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(Equipment_inventoryTable.serial_number);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Equipment_inventoryTable.serial_number.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Equipment_inventoryTable.serial_number.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(Equipment_inventoryTable.description);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Equipment_inventoryTable.description.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Equipment_inventoryTable.description.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
                      
            }
              
            resultList.Sort();
            string[] result = new string[resultList.Count];
            Array.Copy(resultList.ToArray(), result, resultList.Count);
            return result;
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventoryTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Equipment_inventoryTableControlRow recControl = (Equipment_inventoryTableControlRow)(repItem.FindControl("Equipment_inventoryTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Equipment_inventoryRecord rec = new Equipment_inventoryRecord();
        
                        if (recControl.category_id.Text != "") {
                            rec.Parse(recControl.category_id.Text, Equipment_inventoryTable.category_id);
                  }
                
                        if (recControl.cogs.Text != "") {
                            rec.Parse(recControl.cogs.Text, Equipment_inventoryTable.cogs);
                  }
                
                        if (recControl.condition_id.Text != "") {
                            rec.Parse(recControl.condition_id.Text, Equipment_inventoryTable.condition_id);
                  }
                
                        if (recControl.customer_ein.Text != "") {
                            rec.Parse(recControl.customer_ein.Text, Equipment_inventoryTable.customer_ein);
                  }
                
                        if (recControl.date_disposed.Text != "") {
                            rec.Parse(recControl.date_disposed.Text, Equipment_inventoryTable.date_disposed);
                  }
                
                        if (recControl.date_received.Text != "") {
                            rec.Parse(recControl.date_received.Text, Equipment_inventoryTable.date_received);
                  }
                
                        if (recControl.date_sold.Text != "") {
                            rec.Parse(recControl.date_sold.Text, Equipment_inventoryTable.date_sold);
                  }
                
                        if (recControl.description.Text != "") {
                            rec.Parse(recControl.description.Text, Equipment_inventoryTable.description);
                  }
                
                        if (recControl.disposition_id.Text != "") {
                            rec.Parse(recControl.disposition_id.Text, Equipment_inventoryTable.disposition_id);
                  }
                
                        if (recControl.doc_num.Text != "") {
                            rec.Parse(recControl.doc_num.Text, Equipment_inventoryTable.doc_num);
                  }
                
                        if (recControl.equipment_phi.Text != "") {
                            rec.Parse(recControl.equipment_phi.Text, Equipment_inventoryTable.equipment_phi);
                  }
                
                        if (recControl.final_sale_price.Text != "") {
                            rec.Parse(recControl.final_sale_price.Text, Equipment_inventoryTable.final_sale_price);
                  }
                
                        if (recControl.inventory_status_id.Text != "") {
                            rec.Parse(recControl.inventory_status_id.Text, Equipment_inventoryTable.inventory_status_id);
                  }
                
                        if (recControl.make_id.Text != "") {
                            rec.Parse(recControl.make_id.Text, Equipment_inventoryTable.make_id);
                  }
                
                        if (recControl.model_id.Text != "") {
                            rec.Parse(recControl.model_id.Text, Equipment_inventoryTable.model_id);
                  }
                
                        if (recControl.other_id_num.Text != "") {
                            rec.Parse(recControl.other_id_num.Text, Equipment_inventoryTable.other_id_num);
                  }
                
                        if (recControl.pd_date.Text != "") {
                            rec.Parse(recControl.pd_date.Text, Equipment_inventoryTable.pd_date);
                  }
                
                        if (recControl.proposed_sale_price.Text != "") {
                            rec.Parse(recControl.proposed_sale_price.Text, Equipment_inventoryTable.proposed_sale_price);
                  }
                
                        if (recControl.purchase_price.Text != "") {
                            rec.Parse(recControl.purchase_price.Text, Equipment_inventoryTable.purchase_price);
                  }
                
                        if (recControl.received_from_contact_id.Text != "") {
                            rec.Parse(recControl.received_from_contact_id.Text, Equipment_inventoryTable.received_from_contact_id);
                  }
                
                        if (recControl.received_from_customer_id.Text != "") {
                            rec.Parse(recControl.received_from_customer_id.Text, Equipment_inventoryTable.received_from_customer_id);
                  }
                
                        if (recControl.repair_notes.Text != "") {
                            rec.Parse(recControl.repair_notes.Text, Equipment_inventoryTable.repair_notes);
                  }
                
                        if (recControl.require_accessories.Text != "") {
                            rec.Parse(recControl.require_accessories.Text, Equipment_inventoryTable.require_accessories);
                  }
                
                        if (recControl.sale_method_id.Text != "") {
                            rec.Parse(recControl.sale_method_id.Text, Equipment_inventoryTable.sale_method_id);
                  }
                
                        if (recControl.serial_number.Text != "") {
                            rec.Parse(recControl.serial_number.Text, Equipment_inventoryTable.serial_number);
                  }
                
                        if (recControl.sold_from_id.Text != "") {
                            rec.Parse(recControl.sold_from_id.Text, Equipment_inventoryTable.sold_from_id);
                  }
                
                        if (recControl.warehouse_id.Text != "") {
                            rec.Parse(recControl.warehouse_id.Text, Equipment_inventoryTable.warehouse_id);
                  }
                
                        if (recControl.warehouse_location_id.Text != "") {
                            rec.Parse(recControl.warehouse_location_id.Text, Equipment_inventoryTable.warehouse_location_id);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Equipment_inventoryRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Equipment_inventoryRecord);
                this.DataSource = (Equipment_inventoryRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Equipment_inventoryTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Equipment_inventoryTableControlRow rec)            
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
        
        public virtual void Setinventory_status_idLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
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
        
            this.SaveToSession(this.inventory_status_idFromFilter, this.inventory_status_idFromFilter.Text);
                  
            this.SaveToSession(this.inventory_status_idToFilter, this.inventory_status_idToFilter.Text);
                  
            this.SaveToSession(this.SearchText, this.SearchText.Text);
                  
            
                    
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
          
      this.SaveToSession("inventory_status_idFromFilter_Ajax", this.inventory_status_idFromFilter.Text);
              
      this.SaveToSession("inventory_status_idToFilter_Ajax", this.inventory_status_idToFilter.Text);
              
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.inventory_status_idFromFilter);
            this.RemoveFromSession(this.inventory_status_idToFilter);
            this.RemoveFromSession(this.SearchText);
            
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

            string orderByStr = (string)ViewState["Equipment_inventoryTableControl_OrderBy"];
          
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
                this.ViewState["Equipment_inventoryTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=Equipment_inventory" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../equipment_inventory/Add-Equipment-inventory.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Equipment_inventoryTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Equipment_inventoryTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
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
            
        public virtual void SetSearchButton()                
              
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


              this.TotalRecords = Equipment_inventoryTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Equipment_inventoryTable.date_received,
             Equipment_inventoryTable.received_from_customer_id,
             Equipment_inventoryTable.received_from_contact_id,
             Equipment_inventoryTable.make_id,
             Equipment_inventoryTable.model_id,
             Equipment_inventoryTable.serial_number,
             Equipment_inventoryTable.customer_ein,
             Equipment_inventoryTable.other_id_num,
             Equipment_inventoryTable.description,
             Equipment_inventoryTable.category_id,
             Equipment_inventoryTable.repair_notes,
             Equipment_inventoryTable.condition_id,
             Equipment_inventoryTable.require_accessories,
             Equipment_inventoryTable.equipment_phi,
             Equipment_inventoryTable.purchase_price,
             Equipment_inventoryTable.pd_date,
             Equipment_inventoryTable.doc_num,
             Equipment_inventoryTable.disposition_id,
             Equipment_inventoryTable.sale_method_id,
             Equipment_inventoryTable.proposed_sale_price,
             Equipment_inventoryTable.date_sold,
             Equipment_inventoryTable.date_disposed,
             Equipment_inventoryTable.sold_from_id,
             Equipment_inventoryTable.final_sale_price,
             Equipment_inventoryTable.warehouse_id,
             Equipment_inventoryTable.warehouse_location_id,
             Equipment_inventoryTable.cogs,
             Equipment_inventoryTable.inventory_status_id,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Equipment_inventoryTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Equipment_inventoryTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Equipment_inventoryTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Equipment_inventoryTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.date_received, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.received_from_customer_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.received_from_contact_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.make_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.model_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.serial_number, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.customer_ein, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.other_id_num, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.description, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.category_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.repair_notes, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.condition_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.require_accessories, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.equipment_phi, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.purchase_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.pd_date, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.doc_num, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.disposition_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.sale_method_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.proposed_sale_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.date_sold, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.date_disposed, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.sold_from_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.final_sale_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.warehouse_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.warehouse_location_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.cogs, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventoryTable.inventory_status_id, "Standard"));


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
                val = Equipment_inventoryTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
            
            string url = @"../equipment_inventory/Add-Equipment-inventory.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Equipment_inventoryTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Equipment_inventoryTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-Equipment-inventory-Table1.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "equipment_inventory";
                // If Show-Equipment-inventory-Table1.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Equipment_inventoryTable.date_received.Name, ReportEnum.Align.Left, "${date_received}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.received_from_customer_id.Name, ReportEnum.Align.Left, "${received_from_customer_id}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Equipment_inventoryTable.received_from_contact_id.Name, ReportEnum.Align.Left, "${received_from_contact_id}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Equipment_inventoryTable.make_id.Name, ReportEnum.Align.Left, "${make_id}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Equipment_inventoryTable.model_id.Name, ReportEnum.Align.Left, "${model_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.customer_ein.Name, ReportEnum.Align.Left, "${customer_ein}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventoryTable.other_id_num.Name, ReportEnum.Align.Left, "${other_id_num}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.description.Name, ReportEnum.Align.Left, "${description}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.category_id.Name, ReportEnum.Align.Left, "${category_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.repair_notes.Name, ReportEnum.Align.Left, "${repair_notes}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.require_accessories.Name, ReportEnum.Align.Left, "${require_accessories}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventoryTable.equipment_phi.Name, ReportEnum.Align.Left, "${equipment_phi}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventoryTable.purchase_price.Name, ReportEnum.Align.Right, "${purchase_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventoryTable.pd_date.Name, ReportEnum.Align.Left, "${pd_date}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.doc_num.Name, ReportEnum.Align.Left, "${doc_num}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.disposition_id.Name, ReportEnum.Align.Left, "${disposition_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Equipment_inventoryTable.sale_method_id.Name, ReportEnum.Align.Left, "${sale_method_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Equipment_inventoryTable.proposed_sale_price.Name, ReportEnum.Align.Right, "${proposed_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventoryTable.date_sold.Name, ReportEnum.Align.Left, "${date_sold}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.date_disposed.Name, ReportEnum.Align.Left, "${date_disposed}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.sold_from_id.Name, ReportEnum.Align.Left, "${sold_from_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.final_sale_price.Name, ReportEnum.Align.Right, "${final_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventoryTable.warehouse_id.Name, ReportEnum.Align.Left, "${warehouse_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Equipment_inventoryTable.warehouse_location_id.Name, ReportEnum.Align.Left, "${warehouse_location_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Equipment_inventoryTable.cogs.Name, ReportEnum.Align.Right, "${cogs}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventoryTable.inventory_status_id.Name, ReportEnum.Align.Right, "${inventory_status_id}", ReportEnum.Align.Right, 20);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Equipment_inventoryTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Equipment_inventoryTable.GetRecordCount(joinFilter,whereClause);
                Equipment_inventoryRecord[] records = null;
                
                do
                {
                    
                    records = Equipment_inventoryTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Equipment_inventoryRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${date_received}", record.Format(Equipment_inventoryTable.date_received), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.received_from_customer_id)){
                                 report.AddData("${received_from_customer_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_customer_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.received_from_customer_id.ToString(), Equipment_inventoryTable.received_from_customer_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.received_from_customer_id.IsApplyDisplayAs){
                                     report.AddData("${received_from_customer_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${received_from_customer_id}", record.Format(Equipment_inventoryTable.received_from_customer_id), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.received_from_contact_id)){
                                 report.AddData("${received_from_contact_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_contact_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.received_from_contact_id.ToString(), Equipment_inventoryTable.received_from_contact_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.received_from_contact_id.IsApplyDisplayAs){
                                     report.AddData("${received_from_contact_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${received_from_contact_id}", record.Format(Equipment_inventoryTable.received_from_contact_id), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${make_id}", record.Format(Equipment_inventoryTable.make_id), ReportEnum.Align.Left, 300);
                             report.AddData("${model_id}", record.Format(Equipment_inventoryTable.model_id), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Equipment_inventoryTable.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${customer_ein}", record.Format(Equipment_inventoryTable.customer_ein), ReportEnum.Align.Left, 300);
                             report.AddData("${other_id_num}", record.Format(Equipment_inventoryTable.other_id_num), ReportEnum.Align.Left, 300);
                             report.AddData("${description}", record.Format(Equipment_inventoryTable.description), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.category_id)){
                                 report.AddData("${category_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.category_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.category_id.ToString(), Equipment_inventoryTable.category_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.category_id.IsApplyDisplayAs){
                                     report.AddData("${category_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${category_id}", record.Format(Equipment_inventoryTable.category_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${repair_notes}", record.Format(Equipment_inventoryTable.repair_notes), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.condition_id)){
                                 report.AddData("${condition_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.condition_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.condition_id.ToString(), Equipment_inventoryTable.condition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.condition_id.IsApplyDisplayAs){
                                     report.AddData("${condition_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${condition_id}", record.Format(Equipment_inventoryTable.condition_id), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${require_accessories}", record.Format(Equipment_inventoryTable.require_accessories), ReportEnum.Align.Left, 300);
                             report.AddData("${equipment_phi}", record.Format(Equipment_inventoryTable.equipment_phi), ReportEnum.Align.Left, 300);
                             report.AddData("${purchase_price}", record.Format(Equipment_inventoryTable.purchase_price), ReportEnum.Align.Right, 300);
                             report.AddData("${pd_date}", record.Format(Equipment_inventoryTable.pd_date), ReportEnum.Align.Left, 300);
                             report.AddData("${doc_num}", record.Format(Equipment_inventoryTable.doc_num), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.disposition_id)){
                                 report.AddData("${disposition_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.disposition_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.disposition_id.ToString(), Equipment_inventoryTable.disposition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.disposition_id.IsApplyDisplayAs){
                                     report.AddData("${disposition_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${disposition_id}", record.Format(Equipment_inventoryTable.disposition_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.sale_method_id)){
                                 report.AddData("${sale_method_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sale_method_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.sale_method_id.ToString(), Equipment_inventoryTable.sale_method_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.sale_method_id.IsApplyDisplayAs){
                                     report.AddData("${sale_method_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${sale_method_id}", record.Format(Equipment_inventoryTable.sale_method_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${proposed_sale_price}", record.Format(Equipment_inventoryTable.proposed_sale_price), ReportEnum.Align.Right, 300);
                             report.AddData("${date_sold}", record.Format(Equipment_inventoryTable.date_sold), ReportEnum.Align.Left, 300);
                             report.AddData("${date_disposed}", record.Format(Equipment_inventoryTable.date_disposed), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.sold_from_id)){
                                 report.AddData("${sold_from_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sold_from_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.sold_from_id.ToString(), Equipment_inventoryTable.sold_from_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.sold_from_id.IsApplyDisplayAs){
                                     report.AddData("${sold_from_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${sold_from_id}", record.Format(Equipment_inventoryTable.sold_from_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${final_sale_price}", record.Format(Equipment_inventoryTable.final_sale_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_id)){
                                 report.AddData("${warehouse_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.warehouse_id.ToString(), Equipment_inventoryTable.warehouse_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.warehouse_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_id}", record.Format(Equipment_inventoryTable.warehouse_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_location_id)){
                                 report.AddData("${warehouse_location_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_location_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.warehouse_location_id.ToString(), Equipment_inventoryTable.warehouse_location_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.warehouse_location_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_location_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_location_id}", record.Format(Equipment_inventoryTable.warehouse_location_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${cogs}", record.Format(Equipment_inventoryTable.cogs), ReportEnum.Align.Right, 300);
                             report.AddData("${inventory_status_id}", record.Format(Equipment_inventoryTable.inventory_status_id), ReportEnum.Align.Right, 300);

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
                
              this.inventory_status_idFromFilter.Text = "";
            
              this.inventory_status_idToFilter.Text = "";
            
              this.SearchText.Text = "";
            
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
        public virtual void SearchButton_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        // event handler for ImageButton
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-Equipment-inventory-Table1.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "equipment_inventory";
                // If Show-Equipment-inventory-Table1.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Equipment_inventoryTable.date_received.Name, ReportEnum.Align.Left, "${date_received}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.received_from_customer_id.Name, ReportEnum.Align.Left, "${received_from_customer_id}", ReportEnum.Align.Left, 18);
                 report.AddColumn(Equipment_inventoryTable.received_from_contact_id.Name, ReportEnum.Align.Left, "${received_from_contact_id}", ReportEnum.Align.Left, 22);
                 report.AddColumn(Equipment_inventoryTable.make_id.Name, ReportEnum.Align.Left, "${make_id}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Equipment_inventoryTable.model_id.Name, ReportEnum.Align.Left, "${model_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.customer_ein.Name, ReportEnum.Align.Left, "${customer_ein}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventoryTable.other_id_num.Name, ReportEnum.Align.Left, "${other_id_num}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.description.Name, ReportEnum.Align.Left, "${description}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.category_id.Name, ReportEnum.Align.Left, "${category_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.repair_notes.Name, ReportEnum.Align.Left, "${repair_notes}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.require_accessories.Name, ReportEnum.Align.Left, "${require_accessories}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventoryTable.equipment_phi.Name, ReportEnum.Align.Left, "${equipment_phi}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventoryTable.purchase_price.Name, ReportEnum.Align.Right, "${purchase_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventoryTable.pd_date.Name, ReportEnum.Align.Left, "${pd_date}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.doc_num.Name, ReportEnum.Align.Left, "${doc_num}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.disposition_id.Name, ReportEnum.Align.Left, "${disposition_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Equipment_inventoryTable.sale_method_id.Name, ReportEnum.Align.Left, "${sale_method_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Equipment_inventoryTable.proposed_sale_price.Name, ReportEnum.Align.Right, "${proposed_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventoryTable.date_sold.Name, ReportEnum.Align.Left, "${date_sold}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.date_disposed.Name, ReportEnum.Align.Left, "${date_disposed}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventoryTable.sold_from_id.Name, ReportEnum.Align.Left, "${sold_from_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventoryTable.final_sale_price.Name, ReportEnum.Align.Right, "${final_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventoryTable.warehouse_id.Name, ReportEnum.Align.Left, "${warehouse_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Equipment_inventoryTable.warehouse_location_id.Name, ReportEnum.Align.Left, "${warehouse_location_id}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Equipment_inventoryTable.cogs.Name, ReportEnum.Align.Right, "${cogs}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventoryTable.inventory_status_id.Name, ReportEnum.Align.Right, "${inventory_status_id}", ReportEnum.Align.Right, 20);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Equipment_inventoryTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Equipment_inventoryTable.GetColumnList();
                Equipment_inventoryRecord[] records = null;
                do
                {
                    records = Equipment_inventoryTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Equipment_inventoryRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${date_received}", record.Format(Equipment_inventoryTable.date_received), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.received_from_customer_id)){
                                 report.AddData("${received_from_customer_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_customer_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.received_from_customer_id.ToString(), Equipment_inventoryTable.received_from_customer_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.received_from_customer_id.IsApplyDisplayAs){
                                     report.AddData("${received_from_customer_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${received_from_customer_id}", record.Format(Equipment_inventoryTable.received_from_customer_id), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.received_from_contact_id)){
                                 report.AddData("${received_from_contact_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.received_from_contact_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.received_from_contact_id.ToString(), Equipment_inventoryTable.received_from_contact_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.received_from_contact_id.IsApplyDisplayAs){
                                     report.AddData("${received_from_contact_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${received_from_contact_id}", record.Format(Equipment_inventoryTable.received_from_contact_id), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${make_id}", record.Format(Equipment_inventoryTable.make_id), ReportEnum.Align.Left, 300);
                             report.AddData("${model_id}", record.Format(Equipment_inventoryTable.model_id), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Equipment_inventoryTable.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${customer_ein}", record.Format(Equipment_inventoryTable.customer_ein), ReportEnum.Align.Left, 300);
                             report.AddData("${other_id_num}", record.Format(Equipment_inventoryTable.other_id_num), ReportEnum.Align.Left, 300);
                             report.AddData("${description}", record.Format(Equipment_inventoryTable.description), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.category_id)){
                                 report.AddData("${category_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.category_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.category_id.ToString(), Equipment_inventoryTable.category_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.category_id.IsApplyDisplayAs){
                                     report.AddData("${category_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${category_id}", record.Format(Equipment_inventoryTable.category_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${repair_notes}", record.Format(Equipment_inventoryTable.repair_notes), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.condition_id)){
                                 report.AddData("${condition_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.condition_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.condition_id.ToString(), Equipment_inventoryTable.condition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.condition_id.IsApplyDisplayAs){
                                     report.AddData("${condition_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${condition_id}", record.Format(Equipment_inventoryTable.condition_id), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${require_accessories}", record.Format(Equipment_inventoryTable.require_accessories), ReportEnum.Align.Left, 300);
                             report.AddData("${equipment_phi}", record.Format(Equipment_inventoryTable.equipment_phi), ReportEnum.Align.Left, 300);
                             report.AddData("${purchase_price}", record.Format(Equipment_inventoryTable.purchase_price), ReportEnum.Align.Right, 300);
                             report.AddData("${pd_date}", record.Format(Equipment_inventoryTable.pd_date), ReportEnum.Align.Left, 300);
                             report.AddData("${doc_num}", record.Format(Equipment_inventoryTable.doc_num), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.disposition_id)){
                                 report.AddData("${disposition_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.disposition_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.disposition_id.ToString(), Equipment_inventoryTable.disposition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.disposition_id.IsApplyDisplayAs){
                                     report.AddData("${disposition_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${disposition_id}", record.Format(Equipment_inventoryTable.disposition_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.sale_method_id)){
                                 report.AddData("${sale_method_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sale_method_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.sale_method_id.ToString(), Equipment_inventoryTable.sale_method_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.sale_method_id.IsApplyDisplayAs){
                                     report.AddData("${sale_method_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${sale_method_id}", record.Format(Equipment_inventoryTable.sale_method_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${proposed_sale_price}", record.Format(Equipment_inventoryTable.proposed_sale_price), ReportEnum.Align.Right, 300);
                             report.AddData("${date_sold}", record.Format(Equipment_inventoryTable.date_sold), ReportEnum.Align.Left, 300);
                             report.AddData("${date_disposed}", record.Format(Equipment_inventoryTable.date_disposed), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.sold_from_id)){
                                 report.AddData("${sold_from_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.sold_from_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.sold_from_id.ToString(), Equipment_inventoryTable.sold_from_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.sold_from_id.IsApplyDisplayAs){
                                     report.AddData("${sold_from_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${sold_from_id}", record.Format(Equipment_inventoryTable.sold_from_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${final_sale_price}", record.Format(Equipment_inventoryTable.final_sale_price), ReportEnum.Align.Right, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_id)){
                                 report.AddData("${warehouse_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.warehouse_id.ToString(), Equipment_inventoryTable.warehouse_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.warehouse_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_id}", record.Format(Equipment_inventoryTable.warehouse_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.warehouse_location_id)){
                                 report.AddData("${warehouse_location_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventoryTable.warehouse_location_id);
                                 _DFKA = Equipment_inventoryTable.GetDFKA(record.warehouse_location_id.ToString(), Equipment_inventoryTable.warehouse_location_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventoryTable.warehouse_location_id.IsApplyDisplayAs){
                                     report.AddData("${warehouse_location_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${warehouse_location_id}", record.Format(Equipment_inventoryTable.warehouse_location_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${cogs}", record.Format(Equipment_inventoryTable.cogs), ReportEnum.Align.Right, 300);
                             report.AddData("${inventory_status_id}", record.Format(Equipment_inventoryTable.inventory_status_id), ReportEnum.Align.Right, 300);

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
            
            
        


        // Generate the event handling functions for filter and search events.
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = Equipment_inventoryTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Equipment_inventoryRecord[] DataSource {
             
            get {
                return (Equipment_inventoryRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton ImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox inventory_status_idFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_status_idFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal inventory_status_idLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_status_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox inventory_status_idToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_status_idToFilter");
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
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox SearchText {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchText");
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
                Equipment_inventoryTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_inventoryRecord rec = null;
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
                Equipment_inventoryTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_inventoryRecord rec = null;
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
          
        public virtual Equipment_inventoryTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Equipment_inventoryTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Equipment_inventoryTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Equipment_inventory_Table1.Equipment_inventoryTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Equipment_inventoryTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Equipment_inventoryTableControlRow recCtl in recordList)
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

        public virtual Equipment_inventoryTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Equipment_inventoryTableControlRow");
	          List<Equipment_inventoryTableControlRow> list = new List<Equipment_inventoryTableControlRow>();
	          foreach (Equipment_inventoryTableControlRow recCtrl in recCtrls) {
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

  