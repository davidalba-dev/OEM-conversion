
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Equipment_inventory_batch.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Equipment_inventory_batch
{
  

#region "Section 1: Place your customizations here."

    
public class Equipment_inventory_batch_detailTableControlRow : BaseEquipment_inventory_batch_detailTableControlRow
{
      
        // The BaseEquipment_inventory_batch_detailTableControlRow implements code for a ROW within the
        // the Equipment_inventory_batch_detailTableControl table.  The BaseEquipment_inventory_batch_detailTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Equipment_inventory_batch_detailTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Equipment_inventory_batch_detailTableControl : BaseEquipment_inventory_batch_detailTableControl
{
    // The BaseEquipment_inventory_batch_detailTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Equipment_inventory_batch_detailTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  
public class Equipment_inventory_batch_detailTableControl1Row : BaseEquipment_inventory_batch_detailTableControl1Row
{
      
        // The BaseEquipment_inventory_batch_detailTableControl1Row implements code for a ROW within the
        // the Equipment_inventory_batch_detailTableControl1 table.  The BaseEquipment_inventory_batch_detailTableControl1Row implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Equipment_inventory_batch_detailTableControl1.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Equipment_inventory_batch_detailTableControl1 : BaseEquipment_inventory_batch_detailTableControl1
{
    // The BaseEquipment_inventory_batch_detailTableControl1 class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Equipment_inventory_batch_detailTableControl1Row class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  
public class Equipment_inventory_batchRecordControl : BaseEquipment_inventory_batchRecordControl
{
      
        // The BaseEquipment_inventory_batchRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  
public class Max_customerRecordControl : BaseMax_customerRecordControl
{
      
        // The BaseMax_customerRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_inventory_batch_detailTableControlRow control on the Show_Equipment_inventory_batch page.
// Do not modify this class. Instead override any method in Equipment_inventory_batch_detailTableControlRow.
public class BaseEquipment_inventory_batch_detailTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_inventory_batch_detailTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_inventory_batch_detailTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Equipment_inventory_batch_detailTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton.Click += EditRowButton_Click;
                        
              this.equipment_inventory_batch_id.SelectedIndexChanged += equipment_inventory_batch_id_SelectedIndexChanged;
            
              this.equipment_inventory_disposition_id.SelectedIndexChanged += equipment_inventory_disposition_id_SelectedIndexChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_inventory_batch_detailTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseEquipment_inventory_batch_detailTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Equipment_inventory_batch_detailRecord();
            
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
        
                Setaccessories();
                Setcomment();
                Setcondition_id();
                
                SetEIN();
                Setequipment_inventory_batch_id();
                Setequipment_inventory_disposition_id();
                Setmake();
                Setmodel();
                Setoem_barcode_approve();
                Setoem_ein();
                Setphi();
                Setpurchase_price();
                Setpurchase_price2();
                Setserial_number();
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
        
        
        public virtual void Setaccessories()
        {
            
                    
            // Set the accessories Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.accessories is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.accessoriesSpecified) {
                								
                // If the accessories is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.accessories);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.accessories.Text = formattedValue;
                   
            } 
            
            else {
            
                // accessories is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.accessories.Text = Equipment_inventory_batch_detailTable.accessories.Format(Equipment_inventory_batch_detailTable.accessories.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setcomment()
        {
            
                    
            // Set the comment Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.comment is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.commentSpecified) {
                								
                // If the comment is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.comment);
                                
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
                        String name = HttpUtility.HtmlEncode(Equipment_inventory_batch_detailTable.comment.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Equipment_inventory_batch_detailTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"comment\\\", \\\"comment\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.comment.Text = formattedValue;
                   
            } 
            
            else {
            
                // comment is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.comment.Text = Equipment_inventory_batch_detailTable.comment.Format(Equipment_inventory_batch_detailTable.comment.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setcondition_id()
        {
            
                    
            // Set the condition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.condition_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.condition_idSpecified) {
                								
                // If the condition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.condition_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventory_batch_detailTable.condition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventory_batch_detailTable.GetDFKA(this.DataSource.condition_id.ToString(),Equipment_inventory_batch_detailTable.condition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.condition_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.condition_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.condition_id.Text = Equipment_inventory_batch_detailTable.condition_id.Format(Equipment_inventory_batch_detailTable.condition_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetEIN()
        {
            
                    
            // Set the EIN Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.EIN is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EINSpecified) {
                								
                // If the EIN is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.EIN);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.EIN.Text = formattedValue;
                   
            } 
            
            else {
            
                // EIN is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EIN.Text = Equipment_inventory_batch_detailTable.EIN.Format(Equipment_inventory_batch_detailTable.EIN.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setequipment_inventory_batch_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.equipment_inventory_batch_id.ID))
            {
                if (this.PreviousUIData[this.equipment_inventory_batch_id.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.equipment_inventory_batch_id.ID].ToString();
            }
            
            
            // Set the equipment_inventory_batch_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.equipment_inventory_batch_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setequipment_inventory_batch_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.equipment_inventory_batch_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"Equipment_Inventory_Batch\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateequipment_inventory_batch_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setequipment_inventory_disposition_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.equipment_inventory_disposition_id.ID))
            {
                if (this.PreviousUIData[this.equipment_inventory_disposition_id.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.equipment_inventory_disposition_id.ID].ToString();
            }
            
            
            // Set the equipment_inventory_disposition_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.equipment_inventory_disposition_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setequipment_inventory_disposition_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.equipment_inventory_disposition_idSpecified)
            {
                            
                // If the equipment_inventory_disposition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.equipment_inventory_disposition_id.ToString();
                
            }
            else
            {
                
                // equipment_inventory_disposition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populateequipment_inventory_disposition_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setmake()
        {
            
                    
            // Set the make Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.make is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.makeSpecified) {
                								
                // If the make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.make);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.make.Text = formattedValue;
                   
            } 
            
            else {
            
                // make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make.Text = Equipment_inventory_batch_detailTable.make.Format(Equipment_inventory_batch_detailTable.make.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setmodel()
        {
            
                    
            // Set the model Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.model is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.modelSpecified) {
                								
                // If the model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.model);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.model.Text = formattedValue;
                   
            } 
            
            else {
            
                // model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model.Text = Equipment_inventory_batch_detailTable.model.Format(Equipment_inventory_batch_detailTable.model.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setoem_barcode_approve()
        {
            
                    
            // Set the oem_barcode_approve Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.oem_barcode_approve is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.oem_barcode_approveSpecified) {
                								
                // If the oem_barcode_approve is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.oem_barcode_approve);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.oem_barcode_approve.Text = formattedValue;
                   
            } 
            
            else {
            
                // oem_barcode_approve is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.oem_barcode_approve.Text = Equipment_inventory_batch_detailTable.oem_barcode_approve.Format(Equipment_inventory_batch_detailTable.oem_barcode_approve.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setoem_ein()
        {
            
                    
            // Set the oem_ein Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.oem_ein is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.oem_einSpecified) {
                								
                // If the oem_ein is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.oem_ein);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.oem_ein.Text = formattedValue;
                   
            } 
            
            else {
            
                // oem_ein is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.oem_ein.Text = Equipment_inventory_batch_detailTable.oem_ein.Format(Equipment_inventory_batch_detailTable.oem_ein.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setphi()
        {
            
                    
            // Set the phi Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.phi is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.phiSpecified) {
                								
                // If the phi is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.phi);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.phi.Text = formattedValue;
                   
            } 
            
            else {
            
                // phi is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.phi.Text = Equipment_inventory_batch_detailTable.phi.Format(Equipment_inventory_batch_detailTable.phi.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setpurchase_price()
        {
            
                    
            // Set the purchase_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.purchase_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchase_priceSpecified) {
                								
                // If the purchase_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.purchase_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.purchase_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase_price.Text = Equipment_inventory_batch_detailTable.purchase_price.Format(Equipment_inventory_batch_detailTable.purchase_price.DefaultValue, @"C");
            		
            }
                               
        }
                
        public virtual void Setpurchase_price2()
        {
            
                    
            // Set the purchase_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.purchase_price2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchase_priceSpecified) {
                								
                // If the purchase_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.purchase_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.purchase_price2.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase_price2.Text = Equipment_inventory_batch_detailTable.purchase_price.Format(Equipment_inventory_batch_detailTable.purchase_price.DefaultValue, @"C");
            		
            }
                               
        }
                
        public virtual void Setserial_number()
        {
            
                    
            // Set the serial_number Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.serial_number is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.serial_number);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_number.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number.Text = Equipment_inventory_batch_detailTable.serial_number.Format(Equipment_inventory_batch_detailTable.serial_number.DefaultValue);
            		
            }
                               
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
        Equipment_inventory_batchRecordControl parentCtrl;
      
            parentCtrl = (Equipment_inventory_batchRecordControl)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batchRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.equipment_inventory_batch_id = parentCtrl.DataSource.equipment_inventory_batch_id;
        
          
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
                ((Equipment_inventory_batch_detailTableControl)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batch_detailTableControl")).DataChanged = true;
                ((Equipment_inventory_batch_detailTableControl)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batch_detailTableControl")).ResetData = true;
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
        
            Getaccessories();
            Getcomment();
            Getcondition_id();
            GetEIN();
            Getequipment_inventory_batch_id();
            Getequipment_inventory_disposition_id();
            Getmake();
            Getmodel();
            Getoem_barcode_approve();
            Getoem_ein();
            Getphi();
            Getpurchase_price();
            Getpurchase_price2();
            Getserial_number();
        }
        
        
        public virtual void Getaccessories()
        {
            
        }
                
        public virtual void Getcomment()
        {
            
        }
                
        public virtual void Getcondition_id()
        {
            
        }
                
        public virtual void GetEIN()
        {
            
        }
                
        public virtual void Getequipment_inventory_batch_id()
        {
         // Retrieve the value entered by the user on the equipment_inventory_batch_id ASP:DropDownList, and
            // save it into the equipment_inventory_batch_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.equipment_inventory_batch_id), Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);			
                			 
        }
                
        public virtual void Getequipment_inventory_disposition_id()
        {
         // Retrieve the value entered by the user on the equipment_inventory_disposition_id ASP:DropDownList, and
            // save it into the equipment_inventory_disposition_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.equipment_inventory_disposition_id), Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id);			
                			 
        }
                
        public virtual void Getmake()
        {
            
        }
                
        public virtual void Getmodel()
        {
            
        }
                
        public virtual void Getoem_barcode_approve()
        {
            
        }
                
        public virtual void Getoem_ein()
        {
            
        }
                
        public virtual void Getphi()
        {
            
        }
                
        public virtual void Getpurchase_price()
        {
            
        }
                
        public virtual void Getpurchase_price2()
        {
            
        }
                
        public virtual void Getserial_number()
        {
            
        }
                

      // To customize, override this method in Equipment_inventory_batch_detailTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_inventory_batch_detailTableControl = false;
            hasFiltersEquipment_inventory_batch_detailTableControl = hasFiltersEquipment_inventory_batch_detailTableControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batch_detailTableControl1 = false;
            hasFiltersEquipment_inventory_batch_detailTableControl1 = hasFiltersEquipment_inventory_batch_detailTableControl1 && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batchRecordControl = false;
            hasFiltersEquipment_inventory_batchRecordControl = hasFiltersEquipment_inventory_batchRecordControl && false; // suppress warning
      
            bool hasFiltersMax_customerRecordControl = false;
            hasFiltersMax_customerRecordControl = hasFiltersMax_customerRecordControl && false; // suppress warning
      
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
          Equipment_inventory_batch_detailTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Equipment_inventory_batch_detailTableControl)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batch_detailTableControl")).DataChanged = true;
            ((Equipment_inventory_batch_detailTableControl)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batch_detailTableControl")).ResetData = true;
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
                
            this.Page.Authorize((Control)oem_barcode_approve, "3");
					
            this.Page.Authorize((Control)purchase_price, "3");
					
            this.Page.Authorize((Control)purchase_price2, "1;2");
									
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
        
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        public virtual WhereClause CreateWhereClause_equipment_inventory_batch_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.equipment_inventory_batch table.
            // Examples:
            // wc.iAND(Equipment_inventory_batchTable.equipment_inventory_batch_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Equipment_inventory_batchTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_equipment_inventory_disposition_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.equipment_inventory_disposition table.
            // Examples:
            // wc.iAND(Equipment_inventory_dispositionTable.equipment_inventory_disposition, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Equipment_inventory_dispositionTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Equipment_inventory_dispositionTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"equipment_inventory_disposition_.equipment_inventory_disposition_id"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the equipment_inventory_batch_id list.
        protected virtual void Populateequipment_inventory_batch_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.equipment_inventory_batch_id.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_equipment_inventory_batch_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_equipment_inventory_batch_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Equipment_inventory_batchTable.equipment_inventory_batch_id, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the equipment_inventory_batch_idDropDownList.
            Equipment_inventory_batchRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Equipment_inventory_batchTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Equipment_inventory_batchRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.equipment_inventory_batch_idSpecified) 
                        {
                            cvalue = itemValue.equipment_inventory_batch_id.ToString().ToString();
                            if (counter < maxItems && this.equipment_inventory_batch_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventory_batch_detailTable.GetDFKA(itemValue, Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Equipment_inventory_batchTable.equipment_inventory_batch_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.equipment_inventory_batch_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.equipment_inventory_batch_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.equipment_inventory_batch_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.equipment_inventory_batch_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.equipment_inventory_batch.equipment_inventory_batch_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Equipment_inventory_batchTable.equipment_inventory_batch_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Equipment_inventory_batchRecord[] rc = Equipment_inventory_batchTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Equipment_inventory_batchRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.equipment_inventory_batch_idSpecified)
                            cvalue = itemValue.equipment_inventory_batch_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventory_batch_detailTable.GetDFKA(itemValue, Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Equipment_inventory_batchTable.equipment_inventory_batch_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.equipment_inventory_batch_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the equipment_inventory_disposition_id list.
        protected virtual void Populateequipment_inventory_disposition_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.equipment_inventory_disposition_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.equipment_inventory_disposition_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_equipment_inventory_disposition_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_equipment_inventory_disposition_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Equipment_inventory_dispositionTable.equipment_inventory_disposition, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the equipment_inventory_disposition_idDropDownList.
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
                            if (counter < maxItems && this.equipment_inventory_disposition_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Equipment_inventory_disposition.equipment_inventory_disposition", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.equipment_inventory_disposition_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.equipment_inventory_disposition_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.equipment_inventory_disposition_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.equipment_inventory_disposition_id, selectedValue))
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
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Equipment_inventory_disposition.equipment_inventory_disposition", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.equipment_inventory_disposition_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
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
            
            
        
        protected virtual void equipment_inventory_batch_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[equipment_inventory_batch_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[equipment_inventory_batch_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.equipment_inventory_batch_id.Items.Add(new ListItem(displayText, val));
	            this.equipment_inventory_batch_id.SelectedIndex = this.equipment_inventory_batch_id.Items.Count - 1;
	            this.Page.Session.Remove(equipment_inventory_batch_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(equipment_inventory_batch_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void equipment_inventory_disposition_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[equipment_inventory_disposition_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[equipment_inventory_disposition_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.equipment_inventory_disposition_id.Items.Add(new ListItem(displayText, val));
	            this.equipment_inventory_disposition_id.SelectedIndex = this.equipment_inventory_disposition_id.Items.Count - 1;
	            this.Page.Session.Remove(equipment_inventory_disposition_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(equipment_inventory_disposition_id.ClientID + "_SelectedDisplayText");
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
                return (string)this.ViewState["BaseEquipment_inventory_batch_detailTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_inventory_batch_detailTableControlRow_Rec"] = value;
            }
        }
        
        public Equipment_inventory_batch_detailRecord DataSource {
            get {
                return (Equipment_inventory_batch_detailRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal accessories {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accessories");
            }
        }
            
        public System.Web.UI.WebControls.Literal comment {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "comment");
            }
        }
            
        public System.Web.UI.WebControls.Literal condition_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal EIN {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EIN");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList equipment_inventory_batch_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_batch_id");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList equipment_inventory_disposition_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_disposition_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal make {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make");
            }
        }
            
        public System.Web.UI.WebControls.Literal model {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model");
            }
        }
            
        public System.Web.UI.WebControls.Literal oem_barcode_approve {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_barcode_approve");
            }
        }
            
        public System.Web.UI.WebControls.Literal oem_ein {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_ein");
            }
        }
            
        public System.Web.UI.WebControls.Literal phi {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phi");
            }
        }
            
        public System.Web.UI.WebControls.Literal purchase_price {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_price");
            }
        }
            
        public System.Web.UI.WebControls.Literal purchase_price2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_price2");
            }
        }
            
        public System.Web.UI.WebControls.Literal serial_number {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_number");
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
        Equipment_inventory_batch_detailRecord rec = null;
             
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
    Equipment_inventory_batch_detailRecord rec = null;
    
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

        
        public virtual Equipment_inventory_batch_detailRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_inventory_batch_detailTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Equipment_inventory_batch_detailTableControl control on the Show_Equipment_inventory_batch page.
// Do not modify this class. Instead override any method in Equipment_inventory_batch_detailTableControl.
public class BaseEquipment_inventory_batch_detailTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseEquipment_inventory_batch_detailTableControl()
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
                if  (this.InSession(this.EINFilter1)) 				
                    initialVal = this.GetFromSession(this.EINFilter1);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"EIN\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] EINFilter1itemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in EINFilter1itemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.EINFilter1.Items.Add(item);
                            this.EINFilter1.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.EINFilter1.Items)
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
            
                this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, OrderByItem.OrderDir.Desc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "50"));
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
        
              this.accessoriesLabel.Click += accessoriesLabel_Click;
            
              this.condition_idLabel.Click += condition_idLabel_Click;
            
              this.oem_barcode_approveLabel.Click += oem_barcode_approveLabel_Click;
            
              this.oem_einLabel.Click += oem_einLabel_Click;
            
              this.phiLabel.Click += phiLabel_Click;
            
            // Setup the button events.
          
                    this.Button.Button.Click += Button_Click;
                        
                    this.Button1.Button.Click += Button1_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
            
              this.EINFilter1.SelectedIndexChanged += EINFilter1_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.Equipment_inventory_batch_detailRecord);
                      this.DataSource = (Equipment_inventory_batch_detailRecord[])(alist.ToArray(myrec));
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
                    foreach (Equipment_inventory_batch_detailTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Equipment_inventory_batch_detailRecord);
                    this.DataSource = (Equipment_inventory_batch_detailRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Equipment_inventory_batch_detailRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Equipment_inventory_batch_detailTable.Column1, true);          
            // selCols.Add(Equipment_inventory_batch_detailTable.Column2, true);          
            // selCols.Add(Equipment_inventory_batch_detailTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Equipment_inventory_batch_detailTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Equipment_inventory_batch_detailTable databaseTable = new Equipment_inventory_batch_detailTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Equipment_inventory_batch_detailRecord)) as Equipment_inventory_batch_detailRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Equipment_inventory_batch_detailTable.Column1, true);          
            // selCols.Add(Equipment_inventory_batch_detailTable.Column2, true);          
            // selCols.Add(Equipment_inventory_batch_detailTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Equipment_inventory_batch_detailTable.GetRecordCount(join, where);
            else
            {
                Equipment_inventory_batch_detailTable databaseTable = new Equipment_inventory_batch_detailTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Equipment_inventory_batch_detailTableControlRow recControl = (Equipment_inventory_batch_detailTableControlRow)(repItem.FindControl("Equipment_inventory_batch_detailTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetaccessoriesLabel();
                
                
                Setcondition_idLabel();
                SetEINFilter1();
                SetEINLabel();
                SetEINLabel2();
                
                SetmakeLabel();
                SetmodelLabel();
                Setoem_barcode_approveLabel();
                Setoem_einLabel();
                
                SetphiLabel();
                Setpurchase_priceLabel();
                Setserial_numberLabel();
                SetSortByLabel();
                SetSortControl();
                
                SetButton();
              
                SetButton1();
              
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

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Equipment_inventory_batch_detailTable.condition_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id, this.DataSource);
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


            
            this.EINFilter1.ClearSelection();
            
            this.SortControl.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, OrderByItem.OrderDir.Desc);
                 
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
    
            // Bind the buttons for Equipment_inventory_batch_detailTableControl pagination.
        
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
              
            foreach (Equipment_inventory_batch_detailTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Equipment_inventory_batch_detailTableControlRow recCtl in this.GetRecordControls()){
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
            Equipment_inventory_batch_detailTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    Equipment_inventory_batchRecordControl equipment_inventory_batchRecordControlObj = (MiscUtils.GetParentControlObject(this, "Equipment_inventory_batchRecordControl") as Equipment_inventory_batchRecordControl);
          
              if (equipment_inventory_batchRecordControlObj != null && equipment_inventory_batchRecordControlObj.GetRecord() != null && equipment_inventory_batchRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, BaseFilter.ComparisonOperator.EqualsTo, equipment_inventory_batchRecordControlObj.GetRecord().equipment_inventory_batch_id.ToString());
              selectedRecordKeyValue.AddElement(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.InternalName, equipment_inventory_batchRecordControlObj.GetRecord().equipment_inventory_batch_id.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["Equipment_inventory_batch_detailTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
          
            if (MiscUtils.IsValueSelected(this.EINFilter1)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.EINFilter1.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.EINFilter1.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(Equipment_inventory_batch_detailTable.EIN, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_inventory_batch_detailTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInEquipment_inventory_batchRecordControl = HttpContext.Current.Session["Equipment_inventory_batch_detailTableControlWhereClause"] as string;
      
      if (selectedRecordInEquipment_inventory_batchRecordControl != null && KeyValue.IsXmlKey(selectedRecordInEquipment_inventory_batchRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInEquipment_inventory_batchRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id))
      {
      wc.iAND(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id).ToString());
      }
    
      }
    
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String EINFilter1SelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "EINFilter1_Ajax"];
            if (MiscUtils.IsValueSelected(EINFilter1SelectedValue)) {

              
        if (EINFilter1SelectedValue != null){
                        string[] EINFilter1itemListFromSession = EINFilter1SelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in EINFilter1itemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(Equipment_inventory_batch_detailTable.EIN, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
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
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Equipment_inventory_batch_detailTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"equipment_inventory_batch_detail_.oem_barcode_approve"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Equipment_inventory_batch_detailTableControlRow recControl = (Equipment_inventory_batch_detailTableControlRow)(repItem.FindControl("Equipment_inventory_batch_detailTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Equipment_inventory_batch_detailRecord rec = new Equipment_inventory_batch_detailRecord();
        
                        if (recControl.accessories.Text != "") {
                            rec.Parse(recControl.accessories.Text, Equipment_inventory_batch_detailTable.accessories);
                  }
                
                        if (recControl.comment.Text != "") {
                            rec.Parse(recControl.comment.Text, Equipment_inventory_batch_detailTable.comment);
                  }
                
                        if (recControl.condition_id.Text != "") {
                            rec.Parse(recControl.condition_id.Text, Equipment_inventory_batch_detailTable.condition_id);
                  }
                
                        if (recControl.EIN.Text != "") {
                            rec.Parse(recControl.EIN.Text, Equipment_inventory_batch_detailTable.EIN);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.equipment_inventory_batch_id)) {
                            rec.Parse(recControl.equipment_inventory_batch_id.SelectedItem.Value, Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                        }
                        if (MiscUtils.IsValueSelected(recControl.equipment_inventory_disposition_id)) {
                            rec.Parse(recControl.equipment_inventory_disposition_id.SelectedItem.Value, Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id);
                        }
                        if (recControl.make.Text != "") {
                            rec.Parse(recControl.make.Text, Equipment_inventory_batch_detailTable.make);
                  }
                
                        if (recControl.model.Text != "") {
                            rec.Parse(recControl.model.Text, Equipment_inventory_batch_detailTable.model);
                  }
                
                        if (recControl.oem_barcode_approve.Text != "") {
                            rec.Parse(recControl.oem_barcode_approve.Text, Equipment_inventory_batch_detailTable.oem_barcode_approve);
                  }
                
                        if (recControl.oem_ein.Text != "") {
                            rec.Parse(recControl.oem_ein.Text, Equipment_inventory_batch_detailTable.oem_ein);
                  }
                
                        if (recControl.phi.Text != "") {
                            rec.Parse(recControl.phi.Text, Equipment_inventory_batch_detailTable.phi);
                  }
                
                        if (recControl.purchase_price.Text != "") {
                            rec.Parse(recControl.purchase_price.Text, Equipment_inventory_batch_detailTable.purchase_price);
                  }
                
                        if (recControl.purchase_price2.Text != "") {
                            rec.Parse(recControl.purchase_price2.Text, Equipment_inventory_batch_detailTable.purchase_price);
                  }
                
                        if (recControl.serial_number.Text != "") {
                            rec.Parse(recControl.serial_number.Text, Equipment_inventory_batch_detailTable.serial_number);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Equipment_inventory_batch_detailRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Equipment_inventory_batch_detailRecord);
                this.DataSource = (Equipment_inventory_batch_detailRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Equipment_inventory_batch_detailTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Equipment_inventory_batch_detailTableControlRow rec)            
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
        
        public virtual void SetaccessoriesLabel()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetEINLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.EINLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetEINLabel2()
                  {
                  
                    
        }
                
        public virtual void SetmakeLabel()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel()
                  {
                  
                    
        }
                
        public virtual void Setoem_barcode_approveLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.oem_barcode_approveLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void Setoem_einLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.oem_einLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetphiLabel()
                  {
                  
                    
        }
                
        public virtual void Setpurchase_priceLabel()
                  {
                  
                        this.purchase_priceLabel.Text = EvaluateFormula("\"Bid Price\"");
                      
                    
        }
                
        public virtual void Setserial_numberLabel()
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
            
        public virtual void SetEINFilter1()
        {
            
            ArrayList EINFilter1selectedFilterItemList = new ArrayList();
            string EINFilter1itemsString = null;
            if (this.InSession(this.EINFilter1))
                EINFilter1itemsString = this.GetFromSession(this.EINFilter1);
            
            if (EINFilter1itemsString != null)
            {
                string[] EINFilter1itemListFromSession = EINFilter1itemsString.Split(',');
                foreach (string item in EINFilter1itemListFromSession)
                {
                    EINFilter1selectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateEINFilter1(MiscUtils.GetSelectedValueList(this.EINFilter1, EINFilter1selectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../equipment_inventory_batch_detail/Equipment-inventory-batch-detail-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.EINFilter1.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("EIN")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.EINFilter1.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(EINFilter1.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for SortControl.
                
        protected virtual void PopulateSortControl(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accepted {Txt:Ascending}"), "accepted Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accepted {Txt:Descending}"), "accepted Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Comment {Txt:Ascending}"), "comment Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Comment {Txt:Descending}"), "comment Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("EIN {Txt:Ascending}"), "EIN Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("EIN {Txt:Descending}"), "EIN Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Ascending}"), "equipment_inventory_batch_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Descending}"), "equipment_inventory_batch_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Ascending}"), "make Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Descending}"), "make Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Ascending}"), "model Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Descending}"), "model Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Purchase Price {Txt:Ascending}"), "purchase_price Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Purchase Price {Txt:Descending}"), "purchase_price Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Ascending}"), "serial_number Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Descending}"), "serial_number Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed {Txt:Ascending}"), "processed Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed {Txt:Descending}"), "processed Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Ascending}"), "condition_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Descending}"), "condition_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accessories {Txt:Ascending}"), "accessories Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accessories {Txt:Descending}"), "accessories Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("PHI {Txt:Ascending}"), "phi Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("PHI {Txt:Descending}"), "phi Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Ascending}"), "oem_ein Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Descending}"), "oem_ein Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Ebay Fee {Txt:Ascending}"), "ebay_fee Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Ebay Fee {Txt:Descending}"), "ebay_fee Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Wire Fee {Txt:Ascending}"), "wire_fee Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Wire Fee {Txt:Descending}"), "wire_fee Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Paypal Fee {Txt:Ascending}"), "paypal_fee Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Paypal Fee {Txt:Descending}"), "paypal_fee Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Credit Card Fee {Txt:Ascending}"), "credit_card_fee Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Credit Card Fee {Txt:Descending}"), "credit_card_fee Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse Location {Txt:Ascending}"), "warehouse_location_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse Location {Txt:Descending}"), "warehouse_location_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse {Txt:Ascending}"), "warehouse_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse {Txt:Descending}"), "warehouse_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 1 {Txt:Ascending}"), "equip_inv_ad_cat_id_1 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 1 {Txt:Descending}"), "equip_inv_ad_cat_id_1 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 3 {Txt:Ascending}"), "equip_inv_ad_cat_id_3 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 3 {Txt:Descending}"), "equip_inv_ad_cat_id_3 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 2 {Txt:Ascending}"), "equip_inv_ad_cat_id_2 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 2 {Txt:Descending}"), "equip_inv_ad_cat_id_2 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Profit {Txt:Ascending}"), "profit Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Profit {Txt:Descending}"), "profit Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Other Fee {Txt:Ascending}"), "other_fee Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Other Fee {Txt:Descending}"), "other_fee Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Tracking {Txt:Ascending}"), "shipping_tracking Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Tracking {Txt:Descending}"), "shipping_tracking Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Retail {Txt:Ascending}"), "shipping_retail Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Retail {Txt:Descending}"), "shipping_retail Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Ship Via {Txt:Ascending}"), "shipvia Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Ship Via {Txt:Descending}"), "shipvia Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Date {Txt:Ascending}"), "shipping_date Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Date {Txt:Descending}"), "shipping_date Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Ascending}"), "oem_ein Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Descending}"), "oem_ein Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Disposition {Txt:Ascending}"), "equipment_inventory_disposition_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Disposition {Txt:Descending}"), "equipment_inventory_disposition_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Purchased {Txt:Ascending}"), "customer_purchased Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Purchased {Txt:Descending}"), "customer_purchased Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Vendno {Txt:Ascending}"), "vendno Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Vendno {Txt:Descending}"), "vendno Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custcontact Key {Txt:Ascending}"), "custcontactkey Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custcontact Key {Txt:Descending}"), "custcontactkey Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM Barcode Approve {Txt:Ascending}"), "oem_barcode_approve Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM Barcode Approve {Txt:Descending}"), "oem_barcode_approve Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch Details {Txt:Ascending}"), "equipment_inventory_batch_details_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch Details {Txt:Descending}"), "equipment_inventory_batch_details_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Ascending}"), "equipment_inventory_batch_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Descending}"), "equipment_inventory_batch_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Category {Txt:Ascending}"), "new_category_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Category {Txt:Descending}"), "new_category_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 10 {Txt:Ascending}"), "equipment_inventory_pic10 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 10 {Txt:Descending}"), "equipment_inventory_pic10 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 9 {Txt:Ascending}"), "equipment_inventory_pic9 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 9 {Txt:Descending}"), "equipment_inventory_pic9 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 4 {Txt:Ascending}"), "equipment_inventory_pic4 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 4 {Txt:Descending}"), "equipment_inventory_pic4 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 5 {Txt:Ascending}"), "equipment_inventory_pic5 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 5 {Txt:Descending}"), "equipment_inventory_pic5 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 6 {Txt:Ascending}"), "equipment_inventory_pic6 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 6 {Txt:Descending}"), "equipment_inventory_pic6 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 8 {Txt:Ascending}"), "equipment_inventory_pic8 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 8 {Txt:Descending}"), "equipment_inventory_pic8 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 7 {Txt:Ascending}"), "equipment_inventory_pic7 Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 7 {Txt:Descending}"), "equipment_inventory_pic7 Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sold By {Txt:Ascending}"), "sold_by Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sold By {Txt:Descending}"), "sold_by Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sold By {Txt:Ascending}"), "sold_by Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sold By {Txt:Descending}"), "sold_by Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Quantity {Txt:Ascending}"), "equipment_qty Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Quantity {Txt:Descending}"), "equipment_qty Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 3 Name {Txt:Ascending}"), "equipment_inventory_pic3_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 3 Name {Txt:Descending}"), "equipment_inventory_pic3_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 2 Name {Txt:Ascending}"), "equipment_inventory_pic2_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 2 Name {Txt:Descending}"), "equipment_inventory_pic2_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 1 Name {Txt:Ascending}"), "equipment_inventory_pic1_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 1 Name {Txt:Descending}"), "equipment_inventory_pic1_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 10 Name {Txt:Ascending}"), "equipment_inventory_pic10_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 10 Name {Txt:Descending}"), "equipment_inventory_pic10_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 7 Name {Txt:Ascending}"), "equipment_inventory_pic7_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 7 Name {Txt:Descending}"), "equipment_inventory_pic7_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 4 Name {Txt:Ascending}"), "equipment_inventory_pic4_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 4 Name {Txt:Descending}"), "equipment_inventory_pic4_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 9 Name {Txt:Ascending}"), "equipment_inventory_pic9_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 9 Name {Txt:Descending}"), "equipment_inventory_pic9_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 6 Name {Txt:Ascending}"), "equipment_inventory_pic6_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 6 Name {Txt:Descending}"), "equipment_inventory_pic6_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 5 Name {Txt:Ascending}"), "equipment_inventory_pic5_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 5 Name {Txt:Descending}"), "equipment_inventory_pic5_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 8 Name {Txt:Ascending}"), "equipment_inventory_pic8_name Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 8 Name {Txt:Descending}"), "equipment_inventory_pic8_name Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Encoded Inventory {Txt:Ascending}"), "encoded_inventory_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Encoded Inventory {Txt:Descending}"), "encoded_inventory_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated By {Txt:Ascending}"), "last_updated_by Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated By {Txt:Descending}"), "last_updated_by Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created By {Txt:Ascending}"), "created_by Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created By {Txt:Descending}"), "created_by Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated Date And Time {Txt:Ascending}"), "last_updated_datetime Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated Date And Time {Txt:Descending}"), "last_updated_datetime Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Ascending}"), "created_datetime Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Descending}"), "created_datetime Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated By {Txt:Ascending}"), "last_updated_by Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated By {Txt:Descending}"), "last_updated_by Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Reprocess Batch {Txt:Ascending}"), "reprocess_batch_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Reprocess Batch {Txt:Descending}"), "reprocess_batch_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Ascending}"), "model_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Descending}"), "model_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Ascending}"), "make_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Descending}"), "make_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Dotmed It {Txt:Ascending}"), "equipment_dotmed_it Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Dotmed It {Txt:Descending}"), "equipment_dotmed_it Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Old {Txt:Ascending}"), "equipment_inventory_old Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Old {Txt:Descending}"), "equipment_inventory_old Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Old Inventory {Txt:Ascending}"), "old_inventory_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Old Inventory {Txt:Descending}"), "old_inventory_id Desc"));
              
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
            
        // Get the filters' data for EINFilter1.
                
        protected virtual void PopulateEINFilter1(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_EINFilter1();            
            this.EINFilter1.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_EINFilter1 function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Equipment_inventory_batch_detailTable.EIN, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Equipment_inventory_batch_detailTable.GetValues(Equipment_inventory_batch_detailTable.EIN, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Equipment_inventory_batch_detailTable.EIN.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Equipment_inventory_batch_detailTable.EIN.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.EINFilter1.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.EINFilter1.Items.Add(newItem);

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
            
            
            this.EINFilter1.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.EINFilter1.Items.Count == 0)
                this.EINFilter1.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.EINFilter1.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_EINFilter1()
        {
            // Create a where clause for the filter EINFilter1.
            // This function is called by the Populate method to load the items 
            // in the EINFilter1QuickSelector
        
            ArrayList EINFilter1selectedFilterItemList = new ArrayList();
            string EINFilter1itemsString = null;
            if (this.InSession(this.EINFilter1))
                EINFilter1itemsString = this.GetFromSession(this.EINFilter1);
            
            if (EINFilter1itemsString != null)
            {
                string[] EINFilter1itemListFromSession = EINFilter1itemsString.Split(',');
                foreach (string item in EINFilter1itemListFromSession)
                {
                    EINFilter1selectedFilterItemList.Add(item);
                }
            }
              
            EINFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.EINFilter1, EINFilter1selectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (EINFilter1selectedFilterItemList == null || EINFilter1selectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in EINFilter1selectedFilterItemList)
                {
            
      
   
                    wc.iOR(Equipment_inventory_batch_detailTable.EIN, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
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
                
            this.Page.Authorize((Control)oem_barcode_approveLabel, "3");
					                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            protected virtual void SetFocusToAddedRow()
            {
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("Equipment_inventory_batch_detailTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Equipment_inventory_batch_detailTableControlRow recControl = (Equipment_inventory_batch_detailTableControlRow)repItem.FindControl("Equipment_inventory_batch_detailTableControlRow");
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
                  
            ArrayList EINFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.EINFilter1, null);
            string EINFilter1SessionString = "";
            if (EINFilter1selectedFilterItemList != null){
                foreach (string item in EINFilter1selectedFilterItemList){
                    EINFilter1SessionString = String.Concat(EINFilter1SessionString ,"," , item);
                }
            }
            this.SaveToSession(this.EINFilter1, EINFilter1SessionString);
                  
            
                    
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
                  
            ArrayList EINFilter1selectedFilterItemList = MiscUtils.GetSelectedValueList(this.EINFilter1, null);
            string EINFilter1SessionString = "";
            if (EINFilter1selectedFilterItemList != null){
                foreach (string item in EINFilter1selectedFilterItemList){
                    EINFilter1SessionString = String.Concat(EINFilter1SessionString ,"," , item);
                }
            }
            this.SaveToSession("EINFilter1_Ajax", EINFilter1SessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.EINFilter1);
            
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

            string orderByStr = (string)ViewState["Equipment_inventory_batch_detailTableControl_OrderBy"];
          
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
                this.ViewState["Equipment_inventory_batch_detailTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetButton()                
              
        {
        
   
        }
            
        public virtual void SetButton1()                
              
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
        
        public virtual void accessoriesLabel_Click(object sender, EventArgs args)
        {
            //Sorts by accessories when clicked.
              
            // Get previous sorting state for accessories.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.accessories);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for accessories.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.accessories, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by accessories, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void condition_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by condition_id when clicked.
              
            // Get previous sorting state for condition_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.condition_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for condition_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.condition_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by condition_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void oem_barcode_approveLabel_Click(object sender, EventArgs args)
        {
            //Sorts by oem_barcode_approve when clicked.
              
            // Get previous sorting state for oem_barcode_approve.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.oem_barcode_approve);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for oem_barcode_approve.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.oem_barcode_approve, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by oem_barcode_approve, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void oem_einLabel_Click(object sender, EventArgs args)
        {
            //Sorts by oem_ein when clicked.
              
            // Get previous sorting state for oem_ein.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.oem_ein);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for oem_ein.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.oem_ein, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by oem_ein, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void phiLabel_Click(object sender, EventArgs args)
        {
            //Sorts by phi when clicked.
              
            // Get previous sorting state for phi.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.phi);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for phi.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.phi, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by phi, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for Button
        public virtual void Button_Click(object sender, EventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
        public virtual void Button1_Click(object sender, EventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
        
        // event handler for OrderSort
        protected virtual void SortControl_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.SortControl.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Equipment_inventory_batch_detailTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void EINFilter1_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Equipment_inventory_batch_detailTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Equipment_inventory_batch_detailRecord[] DataSource {
             
            get {
                return (Equipment_inventory_batch_detailRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.LinkButton accessoriesLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accessoriesLabel");
            }
        }
        
        public OEMConversion.UI.IThemeButton Button {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button");
            }
        }
        
        public OEMConversion.UI.IThemeButton Button1 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton condition_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector EINFilter1 {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EINFilter1");
            }
        }              
        
        public System.Web.UI.WebControls.Literal EINLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EINLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal EINLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EINLabel2");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal makeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal modelLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton oem_barcode_approveLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_barcode_approveLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton oem_einLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_einLabel");
            }
        }
        
        public OEMConversion.UI.IPaginationModern Pagination {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton phiLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phiLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal purchase_priceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_priceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_numberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_numberLabel");
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
        
        public System.Web.UI.WebControls.Literal Title1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title1");
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
                Equipment_inventory_batch_detailTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_inventory_batch_detailRecord rec = null;
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
                Equipment_inventory_batch_detailTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_inventory_batch_detailRecord rec = null;
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
          
        public virtual Equipment_inventory_batch_detailTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Equipment_inventory_batch_detailTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Equipment_inventory_batch_detailTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Equipment_inventory_batch.Equipment_inventory_batch_detailTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Equipment_inventory_batch_detailTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Equipment_inventory_batch_detailTableControlRow recCtl in recordList)
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

        public virtual Equipment_inventory_batch_detailTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Equipment_inventory_batch_detailTableControlRow");
	          List<Equipment_inventory_batch_detailTableControlRow> list = new List<Equipment_inventory_batch_detailTableControlRow>();
	          foreach (Equipment_inventory_batch_detailTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the Equipment_inventory_batch_detailTableControl1Row control on the Show_Equipment_inventory_batch page.
// Do not modify this class. Instead override any method in Equipment_inventory_batch_detailTableControl1Row.
public class BaseEquipment_inventory_batch_detailTableControl1Row : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_inventory_batch_detailTableControl1Row()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_inventory_batch_detailTableControl1Row.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Equipment_inventory_batch_detailTableControl1Row.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton1.Click += EditRowButton1_Click;
                        
              this.equipment_inventory_batch_id1.SelectedIndexChanged += equipment_inventory_batch_id1_SelectedIndexChanged;
            
              this.equipment_inventory_disposition_id1.SelectedIndexChanged += equipment_inventory_disposition_id1_SelectedIndexChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_inventory_batch_detailTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseEquipment_inventory_batch_detailTableControl1 when the data for the entire
            // table is loaded.
            
            this.DataSource = new Equipment_inventory_batch_detailRecord();
            
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
        
                Setaccepted();
                Setaccessories1();
                Setcomment1();
                Setcondition_id1();
                
                SetEIN1();
                Setequipment_inventory_batch_id1();
                Setequipment_inventory_disposition_id1();
                Setmake1();
                Setmodel1();
                Setoem_barcode_approve1();
                Setphi1();
                Setpurchase_price1();
                Setpurchase_price3();
                Setserial_number1();
                SetEditRowButton1();
              

      

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
        
        
        public virtual void Setaccepted()
        {
            
                    
            // Set the accepted Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.accepted is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.acceptedSpecified) {
                								
                // If the accepted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.accepted);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.accepted.Text = formattedValue;
                   
            } 
            
            else {
            
                // accepted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.accepted.Text = Equipment_inventory_batch_detailTable.accepted.Format(Equipment_inventory_batch_detailTable.accepted.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setaccessories1()
        {
            
                    
            // Set the accessories Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.accessories1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.accessoriesSpecified) {
                								
                // If the accessories is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.accessories);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.accessories1.Text = formattedValue;
                   
            } 
            
            else {
            
                // accessories is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.accessories1.Text = Equipment_inventory_batch_detailTable.accessories.Format(Equipment_inventory_batch_detailTable.accessories.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setcomment1()
        {
            
                    
            // Set the comment Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.comment1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.commentSpecified) {
                								
                // If the comment is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.comment);
                                
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
                        String name = HttpUtility.HtmlEncode(Equipment_inventory_batch_detailTable.comment.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Equipment_inventory_batch_detailTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"comment\\\", \\\"comment1\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.comment1.Text = formattedValue;
                   
            } 
            
            else {
            
                // comment is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.comment1.Text = Equipment_inventory_batch_detailTable.comment.Format(Equipment_inventory_batch_detailTable.comment.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setcondition_id1()
        {
            
                    
            // Set the condition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.condition_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.condition_idSpecified) {
                								
                // If the condition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.condition_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventory_batch_detailTable.condition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventory_batch_detailTable.GetDFKA(this.DataSource.condition_id.ToString(),Equipment_inventory_batch_detailTable.condition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.condition_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.condition_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.condition_id1.Text = Equipment_inventory_batch_detailTable.condition_id.Format(Equipment_inventory_batch_detailTable.condition_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetEIN1()
        {
            
                    
            // Set the EIN Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.EIN1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EINSpecified) {
                								
                // If the EIN is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.EIN);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.EIN1.Text = formattedValue;
                   
            } 
            
            else {
            
                // EIN is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EIN1.Text = Equipment_inventory_batch_detailTable.EIN.Format(Equipment_inventory_batch_detailTable.EIN.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setequipment_inventory_batch_id1()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.equipment_inventory_batch_id1.ID))
            {
                if (this.PreviousUIData[this.equipment_inventory_batch_id1.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.equipment_inventory_batch_id1.ID].ToString();
            }
            
            
            // Set the equipment_inventory_batch_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.equipment_inventory_batch_id1 is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setequipment_inventory_batch_id1();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.equipment_inventory_batch_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"Equipment_Inventory_Batch\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populateequipment_inventory_batch_id1DropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setequipment_inventory_disposition_id1()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.equipment_inventory_disposition_id1.ID))
            {
                if (this.PreviousUIData[this.equipment_inventory_disposition_id1.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.equipment_inventory_disposition_id1.ID].ToString();
            }
            
            
            // Set the equipment_inventory_disposition_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.equipment_inventory_disposition_id1 is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setequipment_inventory_disposition_id1();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.equipment_inventory_disposition_idSpecified)
            {
                            
                // If the equipment_inventory_disposition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.equipment_inventory_disposition_id.ToString();
                
            }
            else
            {
                
                // equipment_inventory_disposition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populateequipment_inventory_disposition_id1DropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setmake1()
        {
            
                    
            // Set the make Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.make1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.makeSpecified) {
                								
                // If the make is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.make);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.make1.Text = formattedValue;
                   
            } 
            
            else {
            
                // make is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make1.Text = Equipment_inventory_batch_detailTable.make.Format(Equipment_inventory_batch_detailTable.make.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setmodel1()
        {
            
                    
            // Set the model Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.model1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.modelSpecified) {
                								
                // If the model is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.model);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.model1.Text = formattedValue;
                   
            } 
            
            else {
            
                // model is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model1.Text = Equipment_inventory_batch_detailTable.model.Format(Equipment_inventory_batch_detailTable.model.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setoem_barcode_approve1()
        {
            
                    
            // Set the oem_barcode_approve Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.oem_barcode_approve1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.oem_barcode_approveSpecified) {
                								
                // If the oem_barcode_approve is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.oem_barcode_approve);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.oem_barcode_approve1.Text = formattedValue;
                   
            } 
            
            else {
            
                // oem_barcode_approve is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.oem_barcode_approve1.Text = Equipment_inventory_batch_detailTable.oem_barcode_approve.Format(Equipment_inventory_batch_detailTable.oem_barcode_approve.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setphi1()
        {
            
                    
            // Set the phi Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.phi1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.phiSpecified) {
                								
                // If the phi is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.phi);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.phi1.Text = formattedValue;
                   
            } 
            
            else {
            
                // phi is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.phi1.Text = Equipment_inventory_batch_detailTable.phi.Format(Equipment_inventory_batch_detailTable.phi.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setpurchase_price1()
        {
            
                    
            // Set the purchase_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.purchase_price1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchase_priceSpecified) {
                								
                // If the purchase_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.purchase_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.purchase_price1.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase_price1.Text = Equipment_inventory_batch_detailTable.purchase_price.Format(Equipment_inventory_batch_detailTable.purchase_price.DefaultValue, @"C");
            		
            }
                               
        }
                
        public virtual void Setpurchase_price3()
        {
            
                    
            // Set the purchase_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.purchase_price3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchase_priceSpecified) {
                								
                // If the purchase_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.purchase_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.purchase_price3.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase_price3.Text = Equipment_inventory_batch_detailTable.purchase_price.Format(Equipment_inventory_batch_detailTable.purchase_price.DefaultValue, @"C");
            		
            }
                               
        }
                
        public virtual void Setserial_number1()
        {
            
                    
            // Set the serial_number Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.serial_number1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.serial_numberSpecified) {
                								
                // If the serial_number is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.serial_number);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.serial_number1.Text = formattedValue;
                   
            } 
            
            else {
            
                // serial_number is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.serial_number1.Text = Equipment_inventory_batch_detailTable.serial_number.Format(Equipment_inventory_batch_detailTable.serial_number.DefaultValue);
            		
            }
                               
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
        Equipment_inventory_batchRecordControl parentCtrl;
      
            parentCtrl = (Equipment_inventory_batchRecordControl)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batchRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "OEMConversion"));
        }
        
          this.DataSource.equipment_inventory_batch_id = parentCtrl.DataSource.equipment_inventory_batch_id;
        
          
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
                ((Equipment_inventory_batch_detailTableControl1)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batch_detailTableControl1")).DataChanged = true;
                ((Equipment_inventory_batch_detailTableControl1)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batch_detailTableControl1")).ResetData = true;
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
        
            Getaccepted();
            Getaccessories1();
            Getcomment1();
            Getcondition_id1();
            GetEIN1();
            Getequipment_inventory_batch_id1();
            Getequipment_inventory_disposition_id1();
            Getmake1();
            Getmodel1();
            Getoem_barcode_approve1();
            Getphi1();
            Getpurchase_price1();
            Getpurchase_price3();
            Getserial_number1();
        }
        
        
        public virtual void Getaccepted()
        {
            
        }
                
        public virtual void Getaccessories1()
        {
            
        }
                
        public virtual void Getcomment1()
        {
            
        }
                
        public virtual void Getcondition_id1()
        {
            
        }
                
        public virtual void GetEIN1()
        {
            
        }
                
        public virtual void Getequipment_inventory_batch_id1()
        {
         // Retrieve the value entered by the user on the equipment_inventory_batch_id ASP:DropDownList, and
            // save it into the equipment_inventory_batch_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.equipment_inventory_batch_id1), Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);			
                			 
        }
                
        public virtual void Getequipment_inventory_disposition_id1()
        {
         // Retrieve the value entered by the user on the equipment_inventory_disposition_id ASP:DropDownList, and
            // save it into the equipment_inventory_disposition_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.equipment_inventory_disposition_id1), Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id);			
                			 
        }
                
        public virtual void Getmake1()
        {
            
        }
                
        public virtual void Getmodel1()
        {
            
        }
                
        public virtual void Getoem_barcode_approve1()
        {
            
        }
                
        public virtual void Getphi1()
        {
            
        }
                
        public virtual void Getpurchase_price1()
        {
            
        }
                
        public virtual void Getpurchase_price3()
        {
            
        }
                
        public virtual void Getserial_number1()
        {
            
        }
                

      // To customize, override this method in Equipment_inventory_batch_detailTableControl1Row.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_inventory_batch_detailTableControl = false;
            hasFiltersEquipment_inventory_batch_detailTableControl = hasFiltersEquipment_inventory_batch_detailTableControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batch_detailTableControl1 = false;
            hasFiltersEquipment_inventory_batch_detailTableControl1 = hasFiltersEquipment_inventory_batch_detailTableControl1 && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batchRecordControl = false;
            hasFiltersEquipment_inventory_batchRecordControl = hasFiltersEquipment_inventory_batchRecordControl && false; // suppress warning
      
            bool hasFiltersMax_customerRecordControl = false;
            hasFiltersMax_customerRecordControl = hasFiltersMax_customerRecordControl && false; // suppress warning
      
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
          Equipment_inventory_batch_detailTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Equipment_inventory_batch_detailTableControl1)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batch_detailTableControl1")).DataChanged = true;
            ((Equipment_inventory_batch_detailTableControl1)MiscUtils.GetParentControlObject(this, "Equipment_inventory_batch_detailTableControl1")).ResetData = true;
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
                
            this.Page.Authorize((Control)oem_barcode_approve1, "3");
					
            this.Page.Authorize((Control)purchase_price1, "3");
					
            this.Page.Authorize((Control)purchase_price3, "1;2");
									
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
        
        public virtual void SetEditRowButton1()                
              
        {
        
   
        }
            
        public virtual WhereClause CreateWhereClause_equipment_inventory_batch_id1DropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.equipment_inventory_batch table.
            // Examples:
            // wc.iAND(Equipment_inventory_batchTable.equipment_inventory_batch_id, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Equipment_inventory_batchTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_equipment_inventory_disposition_id1DropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.equipment_inventory_disposition table.
            // Examples:
            // wc.iAND(Equipment_inventory_dispositionTable.equipment_inventory_disposition, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Equipment_inventory_dispositionTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Equipment_inventory_dispositionTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"equipment_inventory_disposition_.equipment_inventory_disposition_id"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        // Fill the equipment_inventory_batch_id1 list.
        protected virtual void Populateequipment_inventory_batch_id1DropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.equipment_inventory_batch_id1.Items.Clear();
            
            // 1. Setup the static list items        
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_equipment_inventory_batch_id1DropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_equipment_inventory_batch_id1DropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Equipment_inventory_batchTable.equipment_inventory_batch_id, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the equipment_inventory_batch_id1DropDownList.
            Equipment_inventory_batchRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Equipment_inventory_batchTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Equipment_inventory_batchRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.equipment_inventory_batch_idSpecified) 
                        {
                            cvalue = itemValue.equipment_inventory_batch_id.ToString().ToString();
                            if (counter < maxItems && this.equipment_inventory_batch_id1.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventory_batch_detailTable.GetDFKA(itemValue, Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Equipment_inventory_batchTable.equipment_inventory_batch_id);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.equipment_inventory_batch_id1.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.equipment_inventory_batch_id1.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.equipment_inventory_batch_id1, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.equipment_inventory_batch_id1, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.equipment_inventory_batch.equipment_inventory_batch_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Equipment_inventory_batchTable.equipment_inventory_batch_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Equipment_inventory_batchRecord[] rc = Equipment_inventory_batchTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Equipment_inventory_batchRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.equipment_inventory_batch_idSpecified)
                            cvalue = itemValue.equipment_inventory_batch_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventory_batch_detailTable.GetDFKA(itemValue, Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Equipment_inventory_batchTable.equipment_inventory_batch_id);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.equipment_inventory_batch_id1, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the equipment_inventory_disposition_id1 list.
        protected virtual void Populateequipment_inventory_disposition_id1DropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.equipment_inventory_disposition_id1.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.equipment_inventory_disposition_id1.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_equipment_inventory_disposition_id1DropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_equipment_inventory_disposition_id1DropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Equipment_inventory_dispositionTable.equipment_inventory_disposition, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the equipment_inventory_disposition_id1DropDownList.
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
                            if (counter < maxItems && this.equipment_inventory_disposition_id1.Items.FindByValue(cvalue) == null)
                            {
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Equipment_inventory_disposition.equipment_inventory_disposition", itemValue, variables2, evaluator);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.equipment_inventory_disposition_id1.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.equipment_inventory_disposition_id1.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.equipment_inventory_disposition_id1, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.equipment_inventory_disposition_id1, selectedValue))
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
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Equipment_inventory_disposition.equipment_inventory_disposition", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.equipment_inventory_disposition_id1, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // event handler for ImageButton
        public virtual void EditRowButton1_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        protected virtual void equipment_inventory_batch_id1_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[equipment_inventory_batch_id1.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[equipment_inventory_batch_id1.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.equipment_inventory_batch_id1.Items.Add(new ListItem(displayText, val));
	            this.equipment_inventory_batch_id1.SelectedIndex = this.equipment_inventory_batch_id1.Items.Count - 1;
	            this.Page.Session.Remove(equipment_inventory_batch_id1.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(equipment_inventory_batch_id1.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void equipment_inventory_disposition_id1_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[equipment_inventory_disposition_id1.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[equipment_inventory_disposition_id1.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.equipment_inventory_disposition_id1.Items.Add(new ListItem(displayText, val));
	            this.equipment_inventory_disposition_id1.SelectedIndex = this.equipment_inventory_disposition_id1.Items.Count - 1;
	            this.Page.Session.Remove(equipment_inventory_disposition_id1.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(equipment_inventory_disposition_id1.ClientID + "_SelectedDisplayText");
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
                return (string)this.ViewState["BaseEquipment_inventory_batch_detailTableControl1Row_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_inventory_batch_detailTableControl1Row_Rec"] = value;
            }
        }
        
        public Equipment_inventory_batch_detailRecord DataSource {
            get {
                return (Equipment_inventory_batch_detailRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal accepted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accepted");
            }
        }
            
        public System.Web.UI.WebControls.Literal accessories1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accessories1");
            }
        }
            
        public System.Web.UI.WebControls.Literal comment1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "comment1");
            }
        }
            
        public System.Web.UI.WebControls.Literal condition_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id1");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton EditRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton1");
            }
        }
        
        public System.Web.UI.WebControls.Literal EIN1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EIN1");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList equipment_inventory_batch_id1 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_batch_id1");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList equipment_inventory_disposition_id1 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_disposition_id1");
            }
        }
            
        public System.Web.UI.WebControls.Literal make1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make1");
            }
        }
            
        public System.Web.UI.WebControls.Literal model1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model1");
            }
        }
            
        public System.Web.UI.WebControls.Literal oem_barcode_approve1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_barcode_approve1");
            }
        }
            
        public System.Web.UI.WebControls.Literal phi1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phi1");
            }
        }
            
        public System.Web.UI.WebControls.Literal purchase_price1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_price1");
            }
        }
            
        public System.Web.UI.WebControls.Literal purchase_price3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_price3");
            }
        }
            
        public System.Web.UI.WebControls.Literal serial_number1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_number1");
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
        Equipment_inventory_batch_detailRecord rec = null;
             
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
    Equipment_inventory_batch_detailRecord rec = null;
    
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

        
        public virtual Equipment_inventory_batch_detailRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_inventory_batch_detailTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Equipment_inventory_batch_detailTableControl1 control on the Show_Equipment_inventory_batch page.
// Do not modify this class. Instead override any method in Equipment_inventory_batch_detailTableControl1.
public class BaseEquipment_inventory_batch_detailTableControl1 : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseEquipment_inventory_batch_detailTableControl1()
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
                
                if  (this.InSession(this.SortControl1)) 				
                    initialVal = this.GetFromSession(this.SortControl1);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SortControl1.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.SortControl1.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.EINFilter)) 				
                    initialVal = this.GetFromSession(this.EINFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"EIN\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] EINFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in EINFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.EINFilter.Items.Add(item);
                            this.EINFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.EINFilter.Items)
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
            
                this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, OrderByItem.OrderDir.Desc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "50"));
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
        
              this.accessoriesLabel1.Click += accessoriesLabel1_Click;
            
              this.condition_idLabel1.Click += condition_idLabel1_Click;
            
              this.oem_barcode_approveLabel1.Click += oem_barcode_approveLabel1_Click;
            
              this.phiLabel1.Click += phiLabel1_Click;
            
            // Setup the button events.
          
                    this.Button4.Button.Click += Button4_Click;
                        
                    this.Button6.Button.Click += Button6_Click;
                        
                    this.FilterButton1.Button.Click += FilterButton1_Click;
                        
            this.SortControl1.SelectedIndexChanged += new EventHandler(SortControl1_SelectedIndexChanged);
            
              this.EINFilter.SelectedIndexChanged += EINFilter_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.Equipment_inventory_batch_detailRecord);
                      this.DataSource = (Equipment_inventory_batch_detailRecord[])(alist.ToArray(myrec));
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
                    foreach (Equipment_inventory_batch_detailTableControl1Row rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Equipment_inventory_batch_detailRecord);
                    this.DataSource = (Equipment_inventory_batch_detailRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Equipment_inventory_batch_detailRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Equipment_inventory_batch_detailTable.Column1, true);          
            // selCols.Add(Equipment_inventory_batch_detailTable.Column2, true);          
            // selCols.Add(Equipment_inventory_batch_detailTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Equipment_inventory_batch_detailTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Equipment_inventory_batch_detailTable databaseTable = new Equipment_inventory_batch_detailTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Equipment_inventory_batch_detailRecord)) as Equipment_inventory_batch_detailRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Equipment_inventory_batch_detailTable.Column1, true);          
            // selCols.Add(Equipment_inventory_batch_detailTable.Column2, true);          
            // selCols.Add(Equipment_inventory_batch_detailTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Equipment_inventory_batch_detailTable.GetRecordCount(join, where);
            else
            {
                Equipment_inventory_batch_detailTable databaseTable = new Equipment_inventory_batch_detailTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl1Repeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Equipment_inventory_batch_detailTableControl1Row recControl = (Equipment_inventory_batch_detailTableControl1Row)(repItem.FindControl("Equipment_inventory_batch_detailTableControl1Row"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetacceptedLabel1();
                SetaccessoriesLabel1();
                
                
                Setcondition_idLabel1();
                SetEINFilter();
                SetEINLabel1();
                SetEINLabel3();
                
                SetmakeLabel1();
                SetmodelLabel1();
                Setoem_barcode_approveLabel1();
                
                SetphiLabel1();
                Setpurchase_priceLabel1();
                Setserial_numberLabel1();
                SetSortByLabel1();
                SetSortControl1();
                
                SetButton4();
              
                SetButton6();
              
                SetFilterButton1();
              
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

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Equipment_inventory_batch_detailTable.condition_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id, this.DataSource);
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


            
            this.EINFilter.ClearSelection();
            
            this.SortControl1.ClearSelection();
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, OrderByItem.OrderDir.Desc);
                 
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
    
            // Bind the buttons for Equipment_inventory_batch_detailTableControl1 pagination.
        
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
              
            foreach (Equipment_inventory_batch_detailTableControl1Row recCtl in this.GetRecordControls())
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
            foreach (Equipment_inventory_batch_detailTableControl1Row recCtl in this.GetRecordControls()){
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
            Equipment_inventory_batch_detailTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    Equipment_inventory_batchRecordControl equipment_inventory_batchRecordControlObj = (MiscUtils.GetParentControlObject(this, "Equipment_inventory_batchRecordControl") as Equipment_inventory_batchRecordControl);
          
              if (equipment_inventory_batchRecordControlObj != null && equipment_inventory_batchRecordControlObj.GetRecord() != null && equipment_inventory_batchRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, BaseFilter.ComparisonOperator.EqualsTo, equipment_inventory_batchRecordControlObj.GetRecord().equipment_inventory_batch_id.ToString());
              selectedRecordKeyValue.AddElement(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.InternalName, equipment_inventory_batchRecordControlObj.GetRecord().equipment_inventory_batch_id.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["Equipment_inventory_batch_detailTableControl1WhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
          
            if (MiscUtils.IsValueSelected(this.EINFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.EINFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.EINFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(Equipment_inventory_batch_detailTable.EIN, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_inventory_batch_detailTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInEquipment_inventory_batchRecordControl = HttpContext.Current.Session["Equipment_inventory_batch_detailTableControl1WhereClause"] as string;
      
      if (selectedRecordInEquipment_inventory_batchRecordControl != null && KeyValue.IsXmlKey(selectedRecordInEquipment_inventory_batchRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInEquipment_inventory_batchRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id))
      {
      wc.iAND(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id).ToString());
      }
    
      }
    
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String EINFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "EINFilter_Ajax"];
            if (MiscUtils.IsValueSelected(EINFilterSelectedValue)) {

              
        if (EINFilterSelectedValue != null){
                        string[] EINFilteritemListFromSession = EINFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in EINFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(Equipment_inventory_batch_detailTable.EIN, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
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
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Equipment_inventory_batch_detailTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"equipment_inventory_batch_detail_.oem_barcode_approve"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.Not_Equals, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl1Repeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Equipment_inventory_batch_detailTableControl1Row recControl = (Equipment_inventory_batch_detailTableControl1Row)(repItem.FindControl("Equipment_inventory_batch_detailTableControl1Row"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Equipment_inventory_batch_detailRecord rec = new Equipment_inventory_batch_detailRecord();
        
                        if (recControl.accepted.Text != "") {
                            rec.Parse(recControl.accepted.Text, Equipment_inventory_batch_detailTable.accepted);
                  }
                
                        if (recControl.accessories1.Text != "") {
                            rec.Parse(recControl.accessories1.Text, Equipment_inventory_batch_detailTable.accessories);
                  }
                
                        if (recControl.comment1.Text != "") {
                            rec.Parse(recControl.comment1.Text, Equipment_inventory_batch_detailTable.comment);
                  }
                
                        if (recControl.condition_id1.Text != "") {
                            rec.Parse(recControl.condition_id1.Text, Equipment_inventory_batch_detailTable.condition_id);
                  }
                
                        if (recControl.EIN1.Text != "") {
                            rec.Parse(recControl.EIN1.Text, Equipment_inventory_batch_detailTable.EIN);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.equipment_inventory_batch_id1)) {
                            rec.Parse(recControl.equipment_inventory_batch_id1.SelectedItem.Value, Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                        }
                        if (MiscUtils.IsValueSelected(recControl.equipment_inventory_disposition_id1)) {
                            rec.Parse(recControl.equipment_inventory_disposition_id1.SelectedItem.Value, Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id);
                        }
                        if (recControl.make1.Text != "") {
                            rec.Parse(recControl.make1.Text, Equipment_inventory_batch_detailTable.make);
                  }
                
                        if (recControl.model1.Text != "") {
                            rec.Parse(recControl.model1.Text, Equipment_inventory_batch_detailTable.model);
                  }
                
                        if (recControl.oem_barcode_approve1.Text != "") {
                            rec.Parse(recControl.oem_barcode_approve1.Text, Equipment_inventory_batch_detailTable.oem_barcode_approve);
                  }
                
                        if (recControl.phi1.Text != "") {
                            rec.Parse(recControl.phi1.Text, Equipment_inventory_batch_detailTable.phi);
                  }
                
                        if (recControl.purchase_price1.Text != "") {
                            rec.Parse(recControl.purchase_price1.Text, Equipment_inventory_batch_detailTable.purchase_price);
                  }
                
                        if (recControl.purchase_price3.Text != "") {
                            rec.Parse(recControl.purchase_price3.Text, Equipment_inventory_batch_detailTable.purchase_price);
                  }
                
                        if (recControl.serial_number1.Text != "") {
                            rec.Parse(recControl.serial_number1.Text, Equipment_inventory_batch_detailTable.serial_number);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Equipment_inventory_batch_detailRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Equipment_inventory_batch_detailRecord);
                this.DataSource = (Equipment_inventory_batch_detailRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Equipment_inventory_batch_detailTableControl1Row rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Equipment_inventory_batch_detailTableControl1Row rec)            
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
        
        public virtual void SetacceptedLabel1()
                  {
                  
                    
        }
                
        public virtual void SetaccessoriesLabel1()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel1()
                  {
                  
                    
        }
                
        public virtual void SetEINLabel1()
                  {
                  
                    
        }
                
        public virtual void SetEINLabel3()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.EINLabel3.Text = "Some value";
                    
                    
        }
                
        public virtual void SetmakeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel1()
                  {
                  
                    
        }
                
        public virtual void Setoem_barcode_approveLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.oem_barcode_approveLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void SetphiLabel1()
                  {
                  
                    
        }
                
        public virtual void Setpurchase_priceLabel1()
                  {
                  
                        this.purchase_priceLabel1.Text = EvaluateFormula("\"Bid Price\"");
                      
                    
        }
                
        public virtual void Setserial_numberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void SetSortControl1()
        {
            
                this.PopulateSortControl1(MiscUtils.GetSelectedValue(this.SortControl1,  GetFromSession(this.SortControl1)), 500);					
                    

        }
            
        public virtual void SetEINFilter()
        {
            
            ArrayList EINFilterselectedFilterItemList = new ArrayList();
            string EINFilteritemsString = null;
            if (this.InSession(this.EINFilter))
                EINFilteritemsString = this.GetFromSession(this.EINFilter);
            
            if (EINFilteritemsString != null)
            {
                string[] EINFilteritemListFromSession = EINFilteritemsString.Split(',');
                foreach (string item in EINFilteritemListFromSession)
                {
                    EINFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateEINFilter(MiscUtils.GetSelectedValueList(this.EINFilter, EINFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../equipment_inventory_batch_detail/Equipment-inventory-batch-detail-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.EINFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("EIN")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.EINFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(EINFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for SortControl1.
                
        protected virtual void PopulateSortControl1(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl1.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accepted {Txt:Ascending}"), "accepted Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accepted {Txt:Descending}"), "accepted Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Comment {Txt:Ascending}"), "comment Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Comment {Txt:Descending}"), "comment Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("EIN {Txt:Ascending}"), "EIN Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("EIN {Txt:Descending}"), "EIN Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Ascending}"), "equipment_inventory_batch_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Descending}"), "equipment_inventory_batch_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Ascending}"), "make Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Descending}"), "make Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Ascending}"), "model Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Descending}"), "model Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Purchase Price {Txt:Ascending}"), "purchase_price Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Purchase Price {Txt:Descending}"), "purchase_price Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Ascending}"), "serial_number Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Descending}"), "serial_number Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed {Txt:Ascending}"), "processed Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Processed {Txt:Descending}"), "processed Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Ascending}"), "condition_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Descending}"), "condition_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accessories {Txt:Ascending}"), "accessories Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accessories {Txt:Descending}"), "accessories Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("PHI {Txt:Ascending}"), "phi Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("PHI {Txt:Descending}"), "phi Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Ascending}"), "oem_ein Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Descending}"), "oem_ein Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Ebay Fee {Txt:Ascending}"), "ebay_fee Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Ebay Fee {Txt:Descending}"), "ebay_fee Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Wire Fee {Txt:Ascending}"), "wire_fee Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Wire Fee {Txt:Descending}"), "wire_fee Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Paypal Fee {Txt:Ascending}"), "paypal_fee Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Paypal Fee {Txt:Descending}"), "paypal_fee Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Credit Card Fee {Txt:Ascending}"), "credit_card_fee Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Credit Card Fee {Txt:Descending}"), "credit_card_fee Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse Location {Txt:Ascending}"), "warehouse_location_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse Location {Txt:Descending}"), "warehouse_location_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse {Txt:Ascending}"), "warehouse_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Warehouse {Txt:Descending}"), "warehouse_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 1 {Txt:Ascending}"), "equip_inv_ad_cat_id_1 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 1 {Txt:Descending}"), "equip_inv_ad_cat_id_1 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 3 {Txt:Ascending}"), "equip_inv_ad_cat_id_3 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 3 {Txt:Descending}"), "equip_inv_ad_cat_id_3 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 2 {Txt:Ascending}"), "equip_inv_ad_cat_id_2 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Invoice Advertiseme~ory 2 {Txt:Descending}"), "equip_inv_ad_cat_id_2 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Profit {Txt:Ascending}"), "profit Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Profit {Txt:Descending}"), "profit Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Other Fee {Txt:Ascending}"), "other_fee Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Other Fee {Txt:Descending}"), "other_fee Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Tracking {Txt:Ascending}"), "shipping_tracking Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Tracking {Txt:Descending}"), "shipping_tracking Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Retail {Txt:Ascending}"), "shipping_retail Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Retail {Txt:Descending}"), "shipping_retail Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Ship Via {Txt:Ascending}"), "shipvia Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Ship Via {Txt:Descending}"), "shipvia Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Date {Txt:Ascending}"), "shipping_date Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Shipping Date {Txt:Descending}"), "shipping_date Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Ascending}"), "oem_ein Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Descending}"), "oem_ein Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Disposition {Txt:Ascending}"), "equipment_inventory_disposition_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Disposition {Txt:Descending}"), "equipment_inventory_disposition_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Purchased {Txt:Ascending}"), "customer_purchased Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Purchased {Txt:Descending}"), "customer_purchased Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Vendno {Txt:Ascending}"), "vendno Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Vendno {Txt:Descending}"), "vendno Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custcontact Key {Txt:Ascending}"), "custcontactkey Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Custcontact Key {Txt:Descending}"), "custcontactkey Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM Barcode Approve {Txt:Ascending}"), "oem_barcode_approve Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM Barcode Approve {Txt:Descending}"), "oem_barcode_approve Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch Details {Txt:Ascending}"), "equipment_inventory_batch_details_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch Details {Txt:Descending}"), "equipment_inventory_batch_details_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Ascending}"), "equipment_inventory_batch_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Descending}"), "equipment_inventory_batch_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Category {Txt:Ascending}"), "new_category_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("New Category {Txt:Descending}"), "new_category_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 10 {Txt:Ascending}"), "equipment_inventory_pic10 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 10 {Txt:Descending}"), "equipment_inventory_pic10 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 9 {Txt:Ascending}"), "equipment_inventory_pic9 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 9 {Txt:Descending}"), "equipment_inventory_pic9 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 4 {Txt:Ascending}"), "equipment_inventory_pic4 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 4 {Txt:Descending}"), "equipment_inventory_pic4 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 5 {Txt:Ascending}"), "equipment_inventory_pic5 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 5 {Txt:Descending}"), "equipment_inventory_pic5 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 6 {Txt:Ascending}"), "equipment_inventory_pic6 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 6 {Txt:Descending}"), "equipment_inventory_pic6 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 8 {Txt:Ascending}"), "equipment_inventory_pic8 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 8 {Txt:Descending}"), "equipment_inventory_pic8 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 7 {Txt:Ascending}"), "equipment_inventory_pic7 Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 7 {Txt:Descending}"), "equipment_inventory_pic7 Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sold By {Txt:Ascending}"), "sold_by Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sold By {Txt:Descending}"), "sold_by Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sold By {Txt:Ascending}"), "sold_by Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sold By {Txt:Descending}"), "sold_by Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Quantity {Txt:Ascending}"), "equipment_qty Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Quantity {Txt:Descending}"), "equipment_qty Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 3 Name {Txt:Ascending}"), "equipment_inventory_pic3_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 3 Name {Txt:Descending}"), "equipment_inventory_pic3_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 2 Name {Txt:Ascending}"), "equipment_inventory_pic2_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 2 Name {Txt:Descending}"), "equipment_inventory_pic2_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 1 Name {Txt:Ascending}"), "equipment_inventory_pic1_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 1 Name {Txt:Descending}"), "equipment_inventory_pic1_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 10 Name {Txt:Ascending}"), "equipment_inventory_pic10_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 10 Name {Txt:Descending}"), "equipment_inventory_pic10_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 7 Name {Txt:Ascending}"), "equipment_inventory_pic7_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 7 Name {Txt:Descending}"), "equipment_inventory_pic7_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 4 Name {Txt:Ascending}"), "equipment_inventory_pic4_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 4 Name {Txt:Descending}"), "equipment_inventory_pic4_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 9 Name {Txt:Ascending}"), "equipment_inventory_pic9_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 9 Name {Txt:Descending}"), "equipment_inventory_pic9_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 6 Name {Txt:Ascending}"), "equipment_inventory_pic6_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 6 Name {Txt:Descending}"), "equipment_inventory_pic6_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 5 Name {Txt:Ascending}"), "equipment_inventory_pic5_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 5 Name {Txt:Descending}"), "equipment_inventory_pic5_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 8 Name {Txt:Ascending}"), "equipment_inventory_pic8_name Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Picture 8 Name {Txt:Descending}"), "equipment_inventory_pic8_name Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Encoded Inventory {Txt:Ascending}"), "encoded_inventory_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Encoded Inventory {Txt:Descending}"), "encoded_inventory_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated By {Txt:Ascending}"), "last_updated_by Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated By {Txt:Descending}"), "last_updated_by Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created By {Txt:Ascending}"), "created_by Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created By {Txt:Descending}"), "created_by Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated Date And Time {Txt:Ascending}"), "last_updated_datetime Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated Date And Time {Txt:Descending}"), "last_updated_datetime Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Ascending}"), "created_datetime Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Created Date And Time {Txt:Descending}"), "created_datetime Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated By {Txt:Ascending}"), "last_updated_by Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Last Updated By {Txt:Descending}"), "last_updated_by Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Reprocess Batch {Txt:Ascending}"), "reprocess_batch_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Reprocess Batch {Txt:Descending}"), "reprocess_batch_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Ascending}"), "model_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Model {Txt:Descending}"), "model_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Ascending}"), "make_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Make {Txt:Descending}"), "make_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Dotmed It {Txt:Ascending}"), "equipment_dotmed_it Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Dotmed It {Txt:Descending}"), "equipment_dotmed_it Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Old {Txt:Ascending}"), "equipment_inventory_old Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Old {Txt:Descending}"), "equipment_inventory_old Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Old Inventory {Txt:Ascending}"), "old_inventory_id Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Old Inventory {Txt:Descending}"), "old_inventory_id Desc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Dotmed Active {Txt:Ascending}"), "dotmed_active Asc"));
              
                this.SortControl1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Dotmed Active {Txt:Descending}"), "dotmed_active Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.SortControl1, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.SortControl1.SelectedValue != null && this.SortControl1.Items.FindByValue(this.SortControl1.SelectedValue) == null)
                this.SortControl1.SelectedValue = null;
              
        }
            
        // Get the filters' data for EINFilter.
                
        protected virtual void PopulateEINFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_EINFilter();            
            this.EINFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_EINFilter function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Equipment_inventory_batch_detailTable.EIN, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Equipment_inventory_batch_detailTable.GetValues(Equipment_inventory_batch_detailTable.EIN, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Equipment_inventory_batch_detailTable.EIN.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Equipment_inventory_batch_detailTable.EIN.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.EINFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.EINFilter.Items.Add(newItem);

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
            
            
            this.EINFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.EINFilter.Items.Count == 0)
                this.EINFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.EINFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_EINFilter()
        {
            // Create a where clause for the filter EINFilter.
            // This function is called by the Populate method to load the items 
            // in the EINFilterQuickSelector
        
            ArrayList EINFilterselectedFilterItemList = new ArrayList();
            string EINFilteritemsString = null;
            if (this.InSession(this.EINFilter))
                EINFilteritemsString = this.GetFromSession(this.EINFilter);
            
            if (EINFilteritemsString != null)
            {
                string[] EINFilteritemListFromSession = EINFilteritemsString.Split(',');
                foreach (string item in EINFilteritemListFromSession)
                {
                    EINFilterselectedFilterItemList.Add(item);
                }
            }
              
            EINFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.EINFilter, EINFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (EINFilterselectedFilterItemList == null || EINFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in EINFilterselectedFilterItemList)
                {
            
      
   
                    wc.iOR(Equipment_inventory_batch_detailTable.EIN, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
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
                
            this.Page.Authorize((Control)oem_barcode_approveLabel1, "3");
					                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            protected virtual void SetFocusToAddedRow()
            {
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("Equipment_inventory_batch_detailTableControl1Repeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Equipment_inventory_batch_detailTableControl1Row recControl = (Equipment_inventory_batch_detailTableControl1Row)repItem.FindControl("Equipment_inventory_batch_detailTableControl1Row");
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
        
            this.SaveToSession(this.SortControl1, this.SortControl1.SelectedValue);
                  
            ArrayList EINFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.EINFilter, null);
            string EINFilterSessionString = "";
            if (EINFilterselectedFilterItemList != null){
                foreach (string item in EINFilterselectedFilterItemList){
                    EINFilterSessionString = String.Concat(EINFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.EINFilter, EINFilterSessionString);
                  
            
                    
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
          
            this.SaveToSession(this.SortControl1, this.SortControl1.SelectedValue);
                  
            ArrayList EINFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.EINFilter, null);
            string EINFilterSessionString = "";
            if (EINFilterselectedFilterItemList != null){
                foreach (string item in EINFilterselectedFilterItemList){
                    EINFilterSessionString = String.Concat(EINFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("EINFilter_Ajax", EINFilterSessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl1);
            this.RemoveFromSession(this.EINFilter);
            
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

            string orderByStr = (string)ViewState["Equipment_inventory_batch_detailTableControl1_OrderBy"];
          
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
                this.ViewState["Equipment_inventory_batch_detailTableControl1_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetButton4()                
              
        {
        
   
        }
            
        public virtual void SetButton6()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton1()                
              
        {
        
   
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
        
        public virtual void accessoriesLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by accessories when clicked.
              
            // Get previous sorting state for accessories.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.accessories);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for accessories.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.accessories, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by accessories, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void condition_idLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by condition_id when clicked.
              
            // Get previous sorting state for condition_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.condition_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for condition_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.condition_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by condition_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void oem_barcode_approveLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by oem_barcode_approve when clicked.
              
            // Get previous sorting state for oem_barcode_approve.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.oem_barcode_approve);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for oem_barcode_approve.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.oem_barcode_approve, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by oem_barcode_approve, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void phiLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by phi when clicked.
              
            // Get previous sorting state for phi.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.phi);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for phi.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.phi, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by phi, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for Button
        public virtual void Button4_Click(object sender, EventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
        public virtual void Button6_Click(object sender, EventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for OrderSort
        protected virtual void SortControl1_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.SortControl1.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in Equipment_inventory_batch_detailTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void EINFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Equipment_inventory_batch_detailTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Equipment_inventory_batch_detailRecord[] DataSource {
             
            get {
                return (Equipment_inventory_batch_detailRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal acceptedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "acceptedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton accessoriesLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accessoriesLabel1");
            }
        }
        
        public OEMConversion.UI.IThemeButton Button4 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button4");
            }
        }
        
        public OEMConversion.UI.IThemeButton Button6 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button6");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton condition_idLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel1");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector EINFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EINFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal EINLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EINLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal EINLabel3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EINLabel3");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton1 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton1");
            }
        }
        
        public System.Web.UI.WebControls.Literal makeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal modelLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton oem_barcode_approveLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_barcode_approveLabel1");
            }
        }
        
        public OEMConversion.UI.IPaginationModern Pagination1 {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton phiLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phiLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal purchase_priceLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_priceLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal serial_numberLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_numberLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel1 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel1");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList SortControl1 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortControl1");
          }
          }
        
        public System.Web.UI.WebControls.Literal Title2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title2");
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
                Equipment_inventory_batch_detailTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_inventory_batch_detailRecord rec = null;
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
                Equipment_inventory_batch_detailTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Equipment_inventory_batch_detailRecord rec = null;
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
          
        public virtual Equipment_inventory_batch_detailTableControl1Row GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Equipment_inventory_batch_detailTableControl1Row[] GetSelectedRecordControls()
        {
        
            return (Equipment_inventory_batch_detailTableControl1Row[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Equipment_inventory_batch.Equipment_inventory_batch_detailTableControl1Row")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Equipment_inventory_batch_detailTableControl1Row[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Equipment_inventory_batch_detailTableControl1Row recCtl in recordList)
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

        public virtual Equipment_inventory_batch_detailTableControl1Row[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Equipment_inventory_batch_detailTableControl1Row");
	          List<Equipment_inventory_batch_detailTableControl1Row> list = new List<Equipment_inventory_batch_detailTableControl1Row>();
	          foreach (Equipment_inventory_batch_detailTableControl1Row recCtrl in recCtrls) {
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
  
// Base class for the Equipment_inventory_batchRecordControl control on the Show_Equipment_inventory_batch page.
// Do not modify this class. Instead override any method in Equipment_inventory_batchRecordControl.
public class BaseEquipment_inventory_batchRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_inventory_batchRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_inventory_batchRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Equipment_inventory_batchRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.warehouse_id.SelectedIndexChanged += warehouse_id_SelectedIndexChanged;
            
              this.warehouse_location_id.SelectedIndexChanged += warehouse_location_id_SelectedIndexChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_inventory_batchTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_inventory_batchRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Equipment_inventory_batchRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Equipment_inventory_batchRecord[] recList = Equipment_inventory_batchTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Equipment_inventory_batchTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                Setbatch_date();
                Setbatch_dateLabel();
                Setbatch_status_id();
                Setbatch_status_idLabel();
                Setcustno();
                SetcustnoLabel();
                
                
                
                Settechnician_id();
                Settechnician_idLabel();
                
                Setwarehouse_id();
                Setwarehouse_idLabel();
                Setwarehouse_location_id();
                Setwarehouse_location_idLabel();

      

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
            
            if (shouldResetControl || this.Page.IsPageRefresh)
              Equipment_inventory_batch_detailTableControl.ResetControl();
                    
        SetEquipment_inventory_batch_detailTableControl();

        
            if (shouldResetControl || this.Page.IsPageRefresh)
              Equipment_inventory_batch_detailTableControl1.ResetControl();
                    
        SetEquipment_inventory_batch_detailTableControl1();

        
        SetMax_customerRecordControl();


        
        }
        
        
        public virtual void Setbatch_date()
        {
            
                    
            // Set the batch_date Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch record retrieved from the database.
            // this.batch_date is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.batch_dateSpecified) {
                								
                // If the batch_date is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batchTable.batch_date, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.batch_date.Text = formattedValue;
                   
            } 
            
            else {
            
                // batch_date is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.batch_date.Text = Equipment_inventory_batchTable.batch_date.Format(Equipment_inventory_batchTable.batch_date.DefaultValue, @"d");
            		
            }
                               
        }
                
        public virtual void Setbatch_status_id()
        {
            
                    
            // Set the batch_status_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch record retrieved from the database.
            // this.batch_status_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.batch_status_idSpecified) {
                								
                // If the batch_status_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batchTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batchTable.batch_status_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventory_batchTable.batch_status_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventory_batchTable.GetDFKA(this.DataSource.batch_status_id.ToString(),Equipment_inventory_batchTable.batch_status_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventory_batchTable.batch_status_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.batch_status_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // batch_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.batch_status_id.Text = Equipment_inventory_batchTable.batch_status_id.Format(Equipment_inventory_batchTable.batch_status_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setcustno()
        {
            
                    
            // Set the custno Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch record retrieved from the database.
            // this.custno is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IsCreated) {
                								
                // If the custno is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batchTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batchTable.custno);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventory_batchTable.custno.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventory_batchTable.GetDFKA(this.DataSource.custno.ToString(),Equipment_inventory_batchTable.custno, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventory_batchTable.custno);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.custno.Text = formattedValue;
                   
            } 
            
            else {
            
                // custno is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.custno.Text = EvaluateFormula("URL(\"custno\")", this.DataSource);
            		
            }
                               
        }
                
        public virtual void Settechnician_id()
        {
            
                    
            // Set the technician_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch record retrieved from the database.
            // this.technician_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.technician_idSpecified) {
                								
                // If the technician_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batchTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batchTable.technician_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventory_batchTable.technician_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventory_batchTable.GetDFKA(this.DataSource.technician_id.ToString(),Equipment_inventory_batchTable.technician_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventory_batchTable.technician_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.technician_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // technician_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.technician_id.Text = Equipment_inventory_batchTable.technician_id.Format(Equipment_inventory_batchTable.technician_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setwarehouse_id()
        {
            
            // Set AutoPostBack to true so that when the control value is changed, to refresh warehouse_location_id controls
            this.warehouse_id.AutoPostBack = true;
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the warehouse_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch record retrieved from the database.
            // this.warehouse_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setwarehouse_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.warehouse_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"warehouse_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatewarehouse_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setwarehouse_location_id()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the warehouse_location_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch record retrieved from the database.
            // this.warehouse_location_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setwarehouse_location_id();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.warehouse_location_id.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"warehouse_location_id\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.Populatewarehouse_location_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setbatch_dateLabel()
                  {
                  
                    
        }
                
        public virtual void Setbatch_status_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetcustnoLabel()
                  {
                  
                        this.custnoLabel.Text = EvaluateFormula("\"Customer\"");
                      
                    
        }
                
        public virtual void Settechnician_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setwarehouse_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setwarehouse_location_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetEquipment_inventory_batch_detailTableControl()           
        
        {        
            if (Equipment_inventory_batch_detailTableControl.Visible)
            {
                Equipment_inventory_batch_detailTableControl.LoadData();
                Equipment_inventory_batch_detailTableControl.DataBind();
            }
        }
      
        public virtual void SetEquipment_inventory_batch_detailTableControl1()           
        
        {        
            if (Equipment_inventory_batch_detailTableControl1.Visible)
            {
                Equipment_inventory_batch_detailTableControl1.LoadData();
                Equipment_inventory_batch_detailTableControl1.DataBind();
            }
        }
      
        public virtual void SetMax_customerRecordControl()           
        
        {        
            if (Max_customerRecordControl.Visible)
            {
                Max_customerRecordControl.LoadData();
                Max_customerRecordControl.DataBind();
            }
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_inventory_batchRecordControlPanel");
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
          Equipment_inventory_batch_detailTableControl recEquipment_inventory_batch_detailTableControl = (Equipment_inventory_batch_detailTableControl)(MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl"));
        recEquipment_inventory_batch_detailTableControl.SaveData();
        Equipment_inventory_batch_detailTableControl1 recEquipment_inventory_batch_detailTableControl1 = (Equipment_inventory_batch_detailTableControl1)(MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl1"));
        recEquipment_inventory_batch_detailTableControl1.SaveData();
        Max_customerRecordControl recMax_customerRecordControl = (Max_customerRecordControl)(MiscUtils.FindControlRecursively(this, "Max_customerRecordControl"));
        recMax_customerRecordControl.SaveData();
        
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            Getbatch_date();
            Getbatch_status_id();
            Getcustno();
            Gettechnician_id();
            Getwarehouse_id();
            Getwarehouse_location_id();
        }
        
        
        public virtual void Getbatch_date()
        {
            
        }
                
        public virtual void Getbatch_status_id()
        {
            
        }
                
        public virtual void Getcustno()
        {
            
        }
                
        public virtual void Gettechnician_id()
        {
            
        }
                
        public virtual void Getwarehouse_id()
        {
         // Retrieve the value entered by the user on the warehouse_id ASP:DropDownList, and
            // save it into the warehouse_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.warehouse_id), Equipment_inventory_batchTable.warehouse_id);			
                			 
        }
                
        public virtual void Getwarehouse_location_id()
        {
         // Retrieve the value entered by the user on the warehouse_location_id ASP:DropDownList, and
            // save it into the warehouse_location_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.warehouse_location_id), Equipment_inventory_batchTable.warehouse_location_id);			
                			 
        }
                

      // To customize, override this method in Equipment_inventory_batchRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_inventory_batch_detailTableControl = false;
            hasFiltersEquipment_inventory_batch_detailTableControl = hasFiltersEquipment_inventory_batch_detailTableControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batch_detailTableControl1 = false;
            hasFiltersEquipment_inventory_batch_detailTableControl1 = hasFiltersEquipment_inventory_batch_detailTableControl1 && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batchRecordControl = false;
            hasFiltersEquipment_inventory_batchRecordControl = hasFiltersEquipment_inventory_batchRecordControl && false; // suppress warning
      
            bool hasFiltersMax_customerRecordControl = false;
            hasFiltersMax_customerRecordControl = hasFiltersMax_customerRecordControl && false; // suppress warning
      
            WhereClause wc;
            Equipment_inventory_batchTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Equipment_inventory_batch"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Equipment_inventory_batch"));
            }
            HttpContext.Current.Session["QueryString in Show-Equipment-inventory-batch"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(Equipment_inventory_batchTable.equipment_inventory_batch_id, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Equipment_inventory_batchTable.equipment_inventory_batch_id));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(Equipment_inventory_batchTable.equipment_inventory_batch_id, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_inventory_batchTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEquipment_inventory_batch_detailTableControl = false;
            hasFiltersEquipment_inventory_batch_detailTableControl = hasFiltersEquipment_inventory_batch_detailTableControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batch_detailTableControl1 = false;
            hasFiltersEquipment_inventory_batch_detailTableControl1 = hasFiltersEquipment_inventory_batch_detailTableControl1 && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batchRecordControl = false;
            hasFiltersEquipment_inventory_batchRecordControl = hasFiltersEquipment_inventory_batchRecordControl && false; // suppress warning
      
            bool hasFiltersMax_customerRecordControl = false;
            hasFiltersMax_customerRecordControl = hasFiltersMax_customerRecordControl && false; // suppress warning
      
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
          Equipment_inventory_batchTable.DeleteRecord(pkValue);
          
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
                
            this.Page.Authorize((Control)Max_customerRecordControl, "Everyone");
									
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
        
        public virtual WhereClause CreateWhereClause_warehouse_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.warehouse table.
            // Examples:
            // wc.iAND(WarehouseTable.warehouse_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(WarehouseTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.WarehouseTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"warehouse_.warehouse_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
        public virtual WhereClause CreateWhereClause_warehouse_location_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.warehouse_location table.
            // Examples:
            // wc.iAND(Warehouse_locationTable.warehouse_location, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Warehouse_locationTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Warehouse_locationTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"warehouse_location_.warehouse_location_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("Equipment_inventory_batchRecordControl.warehouse_id.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Warehouse_locationTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"warehouse_location_.warehouse_id"), EvaluateFormula("Equipment_inventory_batchRecordControl.warehouse_id.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("Equipment_inventory_batchRecordControl.warehouse_id.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("Equipment_inventory_batchRecordControl.warehouse_id.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
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
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Warehouse.warehouse_name", itemValue, variables2, evaluator);
                                    		

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
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Warehouse.warehouse_name", itemValue, variables2, evaluator2);
                            					
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
                                     
                                System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                                      
                                variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                            
                                fvalue = EvaluateFormula("= Warehouse_location.warehouse_location", itemValue, variables2, evaluator);
                                    		

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
                        FormulaEvaluator evaluator2 = new FormulaEvaluator();      
                        System.Collections.Generic.IDictionary<string, object> variables2 = new System.Collections.Generic.Dictionary<string, object>();

                              
                        variables2.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                    
                        fvalue = EvaluateFormula("= Warehouse_location.warehouse_location", itemValue, variables2, evaluator2);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.warehouse_location_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
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
           
                try
                {
                    // Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction();
                    // Because Set methods will be called, it is important to initialize the data source ahead of time
                    
                    if (this.RecordUniqueId != null)
                        this.DataSource = this.GetRecord();                        
                      
                Setwarehouse_location_id();
                            
                    this.Page.CommitTransaction(sender);
                }
                catch
                {
                    // Upon error, rollback the transaction
                    this.Page.RollBackTransaction(sender);
                }
                finally
                {
                    DbUtils.EndTransaction();
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
                return (string)this.ViewState["BaseEquipment_inventory_batchRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_inventory_batchRecordControl_Rec"] = value;
            }
        }
        
        public Equipment_inventory_batchRecord DataSource {
            get {
                return (Equipment_inventory_batchRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal batch_date {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "batch_date");
            }
        }
            
        public System.Web.UI.WebControls.Literal batch_dateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "batch_dateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal batch_status_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "batch_status_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal batch_status_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "batch_status_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal custno {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
            }
        }
            
        public System.Web.UI.WebControls.Literal custnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoLabel");
            }
        }
        
        public Equipment_inventory_batch_detailTableControl Equipment_inventory_batch_detailTableControl {
            get {
                return (Equipment_inventory_batch_detailTableControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl");
            }
        }
        
        public Equipment_inventory_batch_detailTableControl1 Equipment_inventory_batch_detailTableControl1 {
            get {
                return (Equipment_inventory_batch_detailTableControl1)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl1");
            }
        }
        
        public Max_customerRecordControl Max_customerRecordControl {
            get {
                return (Max_customerRecordControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Max_customerRecordControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal technician_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal technician_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "technician_idLabel");
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
        Equipment_inventory_batchRecord rec = null;
             
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
    Equipment_inventory_batchRecord rec = null;
    
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

        
        public virtual Equipment_inventory_batchRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_inventory_batchTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Max_customerRecordControl control on the Show_Equipment_inventory_batch page.
// Do not modify this class. Instead override any method in Max_customerRecordControl.
public class BaseMax_customerRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseMax_customerRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Max_customerRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Max_customerRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.Expr.TextChanged += Expr_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.max_customer record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Max_customerView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Max_customerRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Max_customerRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Max_customerRecord[] recList = Max_customerView.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Max_customerView.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetExpr();

      

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
        
        
        public virtual void SetExpr()
        {
            
                    
            // Set the Expr TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.max_customer database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.max_customer record retrieved from the database.
            // this.Expr is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ExprSpecified) {
                								
                // If the Expr is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Max_customerView.Expr);
                                
                this.Expr.Text = formattedValue;
                   
            } 
            
            else {
            
                // Expr is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Expr.Text = Max_customerView.Expr.Format(Max_customerView.Expr.DefaultValue);
            		
            }
            
              this.Expr.TextChanged += Expr_TextChanged;
                               
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Max_customerRecordControlPanel");
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
            
            this.Page.Session["MyExprSessionVariable"] = EvaluateFormula("Max_customerRecordControl.Expr.Text");		
                 		  
      
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
        
            GetExpr();
        }
        
        
        public virtual void GetExpr()
        {
            
            // Retrieve the value entered by the user on the Expr ASP:TextBox, and
            // save it into the Expr field in DataSource DatabaseAYS_OEM%dbo.max_customer record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Expr.Text, Max_customerView.Expr);							
                          
                      
        }
                

      // To customize, override this method in Max_customerRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_inventory_batch_detailTableControl = false;
            hasFiltersEquipment_inventory_batch_detailTableControl = hasFiltersEquipment_inventory_batch_detailTableControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batch_detailTableControl1 = false;
            hasFiltersEquipment_inventory_batch_detailTableControl1 = hasFiltersEquipment_inventory_batch_detailTableControl1 && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batchRecordControl = false;
            hasFiltersEquipment_inventory_batchRecordControl = hasFiltersEquipment_inventory_batchRecordControl && false; // suppress warning
      
            bool hasFiltersMax_customerRecordControl = false;
            hasFiltersMax_customerRecordControl = hasFiltersMax_customerRecordControl && false; // suppress warning
      
            WhereClause wc;
            Max_customerView.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Max_customerView.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEquipment_inventory_batch_detailTableControl = false;
            hasFiltersEquipment_inventory_batch_detailTableControl = hasFiltersEquipment_inventory_batch_detailTableControl && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batch_detailTableControl1 = false;
            hasFiltersEquipment_inventory_batch_detailTableControl1 = hasFiltersEquipment_inventory_batch_detailTableControl1 && false; // suppress warning
      
            bool hasFiltersEquipment_inventory_batchRecordControl = false;
            hasFiltersEquipment_inventory_batchRecordControl = hasFiltersEquipment_inventory_batchRecordControl && false; // suppress warning
      
            bool hasFiltersMax_customerRecordControl = false;
            hasFiltersMax_customerRecordControl = hasFiltersMax_customerRecordControl && false; // suppress warning
      
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
          Max_customerView.DeleteRecord(pkValue);
          
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
        
        protected virtual void Expr_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseMax_customerRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseMax_customerRecordControl_Rec"] = value;
            }
        }
        
        public Max_customerRecord DataSource {
            get {
                return (Max_customerRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox Expr {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Expr");
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
        Max_customerRecord rec = null;
             
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
    Max_customerRecord rec = null;
    
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

        
        public virtual Max_customerRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Max_customerView.GetRecord(this.RecordUniqueId, true);
              
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

  