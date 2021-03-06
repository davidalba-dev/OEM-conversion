﻿
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Equipment_inventory_batch_detail_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Equipment_inventory_batch_detail_Table
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

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Equipment_inventory_batch_detailTableControlRow control on the Show_Equipment_inventory_batch_detail_Table page.
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
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.condition_id.Click += condition_id_Click;
                        
                    this.equipment_inventory_batch_id.Click += equipment_inventory_batch_id_Click;
                        
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
        
                Setaccepted();
                SetacceptedLabel();
                Setaccessories();
                SetaccessoriesLabel();
                Setcomment();
                SetcommentLabel();
                Setcondition_id();
                Setcondition_idLabel();
                
                
                SetEIN();
                SetEINLabel();
                Setequipment_inventory_batch_id();
                Setequipment_inventory_batch_idLabel();
                Setequipment_inventory_disposition_id();
                Setequipment_inventory_disposition_idLabel();
                Setmake();
                SetmakeLabel();
                Setmodel();
                SetmodelLabel();
                Setoem_barcode_approve();
                Setoem_barcode_approveLabel();
                Setoem_ein();
                Setoem_einLabel();
                Setphi();
                SetphiLabel();
                Setprocessed();
                SetprocessedLabel();
                Setpurchase_price();
                Setpurchase_priceLabel();
                Setserial_number();
                Setserial_numberLabel();
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
            
            // If the accepted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.accepted.Text == null ||
                this.accepted.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.accepted.Text = "&nbsp;";
            }
                                     
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
            
            // If the accessories is NULL or blank, then use the value specified  
            // on Properties.
            if (this.accessories.Text == null ||
                this.accessories.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.accessories.Text = "&nbsp;";
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
            
            // If the comment is NULL or blank, then use the value specified  
            // on Properties.
            if (this.comment.Text == null ||
                this.comment.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.comment.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setcondition_id()
        {
            
                    
            // Set the condition_id LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.condition_id is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.condition_idSpecified) {
                								
                // If the condition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.condition_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventory_batch_detailTable.condition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventory_batch_detailTable.GetDFKA(this.DataSource.condition_id.ToString(),Equipment_inventory_batch_detailTable.condition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.condition_id);
                                  
                                
                this.condition_id.Text = formattedValue;
                
                  this.condition_id.ToolTip = "Go to " + this.condition_id.Text.Replace("<wbr/>", "");
                   
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
            
            // If the EIN is NULL or blank, then use the value specified  
            // on Properties.
            if (this.EIN.Text == null ||
                this.EIN.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.EIN.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setequipment_inventory_batch_id()
        {
            
                    
            // Set the equipment_inventory_batch_id LinkButton on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.equipment_inventory_batch_id is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.equipment_inventory_batch_idSpecified) {
                								
                // If the equipment_inventory_batch_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventory_batch_detailTable.GetDFKA(this.DataSource.equipment_inventory_batch_id.ToString(),Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                                  
                                
                this.equipment_inventory_batch_id.Text = formattedValue;
                
                  this.equipment_inventory_batch_id.ToolTip = "Go to " + this.equipment_inventory_batch_id.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // equipment_inventory_batch_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.equipment_inventory_batch_id.Text = Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.Format(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.DefaultValue);
            		
            }
                               
        }
                
        public virtual void Setequipment_inventory_disposition_id()
        {
            
                    
            // Set the equipment_inventory_disposition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.equipment_inventory_disposition_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.equipment_inventory_disposition_idSpecified) {
                								
                // If the equipment_inventory_disposition_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id);
               if(_isExpandableNonCompositeForeignKey &&Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id.IsApplyDisplayAs)
                                  
                     formattedValue = Equipment_inventory_batch_detailTable.GetDFKA(this.DataSource.equipment_inventory_disposition_id.ToString(),Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.equipment_inventory_disposition_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // equipment_inventory_disposition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.equipment_inventory_disposition_id.Text = Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id.Format(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id.DefaultValue);
            		
            }
            
            // If the equipment_inventory_disposition_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.equipment_inventory_disposition_id.Text == null ||
                this.equipment_inventory_disposition_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.equipment_inventory_disposition_id.Text = "&nbsp;";
            }
                                     
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
            
            // If the model is NULL or blank, then use the value specified  
            // on Properties.
            if (this.model.Text == null ||
                this.model.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.model.Text = "&nbsp;";
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
            
            // If the oem_barcode_approve is NULL or blank, then use the value specified  
            // on Properties.
            if (this.oem_barcode_approve.Text == null ||
                this.oem_barcode_approve.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.oem_barcode_approve.Text = "&nbsp;";
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
            
            // If the oem_ein is NULL or blank, then use the value specified  
            // on Properties.
            if (this.oem_ein.Text == null ||
                this.oem_ein.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.oem_ein.Text = "&nbsp;";
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
            
            // If the phi is NULL or blank, then use the value specified  
            // on Properties.
            if (this.phi.Text == null ||
                this.phi.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.phi.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setprocessed()
        {
            
                    
            // Set the processed Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.processed is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.processedSpecified) {
                								
                // If the processed is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.processed);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.processed.Text = formattedValue;
                   
            } 
            
            else {
            
                // processed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.processed.Text = Equipment_inventory_batch_detailTable.processed.Format(Equipment_inventory_batch_detailTable.processed.DefaultValue);
            		
            }
            
            // If the processed is NULL or blank, then use the value specified  
            // on Properties.
            if (this.processed.Text == null ||
                this.processed.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.processed.Text = "&nbsp;";
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
            
            // If the purchase_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.purchase_price.Text == null ||
                this.purchase_price.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.purchase_price.Text = "&nbsp;";
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
            
            // If the serial_number is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serial_number.Text == null ||
                this.serial_number.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serial_number.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetacceptedLabel()
                  {
                  
                    
        }
                
        public virtual void SetaccessoriesLabel()
                  {
                  
                    
        }
                
        public virtual void SetcommentLabel()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetEINLabel()
                  {
                  
                    
        }
                
        public virtual void Setequipment_inventory_batch_idLabel()
                  {
                  
                    
        }
                
        public virtual void Setequipment_inventory_disposition_idLabel()
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
                  
                    
        }
                
        public virtual void Setoem_einLabel()
                  {
                  
                    
        }
                
        public virtual void SetphiLabel()
                  {
                  
                    
        }
                
        public virtual void SetprocessedLabel()
                  {
                  
                    
        }
                
        public virtual void Setpurchase_priceLabel()
                  {
                  
                        this.purchase_priceLabel.Text = EvaluateFormula("\"Bid Price\"");
                      
                    
        }
                
        public virtual void Setserial_numberLabel()
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
        
            Getaccepted();
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
            Getprocessed();
            Getpurchase_price();
            Getserial_number();
        }
        
        
        public virtual void Getaccepted()
        {
            
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
            
        }
                
        public virtual void Getequipment_inventory_disposition_id()
        {
            
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
                
        public virtual void Getprocessed()
        {
            
        }
                
        public virtual void Getpurchase_price()
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
            
            string url = @"../equipment_inventory_batch_detail/Edit-Equipment-inventory-batch-detail.aspx?Equipment_inventory_batch_detail={PK}";
            
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
            
            string url = @"../Conditions/Show-Conditions.aspx?Conditions={Equipment_inventory_batch_detailTableControlRow:FK:FK_equipment_inventory_batch_detail_Conditions}";
            
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
        public virtual void equipment_inventory_batch_id_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../equipment_inventory_batch/Show-Equipment-inventory-batch.aspx?Equipment_inventory_batch={Equipment_inventory_batch_detailTableControlRow:FK:FK_equipment_inventory_batch_detail_equipment_inventory_batch}";
            
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
        
        public System.Web.UI.WebControls.Literal accepted {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accepted");
            }
        }
            
        public System.Web.UI.WebControls.Literal acceptedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "acceptedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal accessories {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accessories");
            }
        }
            
        public System.Web.UI.WebControls.Literal accessoriesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accessoriesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal comment {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "comment");
            }
        }
            
        public System.Web.UI.WebControls.Literal commentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "commentLabel");
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
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
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
            
        public System.Web.UI.WebControls.Literal EINLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EINLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton equipment_inventory_batch_id {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_batch_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal equipment_inventory_batch_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_batch_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal equipment_inventory_disposition_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_disposition_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal equipment_inventory_disposition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_disposition_idLabel");
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
        
        public System.Web.UI.WebControls.Literal oem_barcode_approve {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_barcode_approve");
            }
        }
            
        public System.Web.UI.WebControls.Literal oem_barcode_approveLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "oem_barcode_approveLabel");
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
        
        public System.Web.UI.WebControls.Literal phi {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phi");
            }
        }
            
        public System.Web.UI.WebControls.Literal phiLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phiLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal processed {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "processed");
            }
        }
            
        public System.Web.UI.WebControls.Literal processedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "processedLabel");
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

  
// Base class for the Equipment_inventory_batch_detailTableControl control on the Show_Equipment_inventory_batch_detail_Table page.
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
                if  (this.InSession(this.modelFilter)) 				
                    initialVal = this.GetFromSession(this.modelFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"model\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] modelFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in modelFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.modelFilter.Items.Add(item);
                            this.modelFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.modelFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
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
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
            
              this.modelFilter.SelectedIndexChanged += modelFilter_SelectedIndexChanged;                  
                        
        
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
        
                
                
                
                
                
                SetmodelFilter();
                SetmodelLabel1();
                
                
                
                
                
                SetSearchText();
                SetSortByLabel();
                SetSortControl();
                
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetResetButton();
              
                SetSearchButton();
              
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
          
            this.Page.PregetDfkaRecords(Equipment_inventory_batch_detailTable.condition_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, this.DataSource);
            this.Page.PregetDfkaRecords(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id, this.DataSource);
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


            
            this.modelFilter.ClearSelection();
            
            this.SortControl.ClearSelection();
            
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
            
        
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
          
            if (MiscUtils.IsValueSelected(this.modelFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.modelFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.modelFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(Equipment_inventory_batch_detailTable.model, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
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
      
      cols.Add(Equipment_inventory_batch_detailTable.condition_id, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
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
            
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String modelFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "modelFilter_Ajax"];
            if (MiscUtils.IsValueSelected(modelFilterSelectedValue)) {

              
        if (modelFilterSelectedValue != null){
                        string[] modelFilteritemListFromSession = modelFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in modelFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(Equipment_inventory_batch_detailTable.model, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
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
      
      cols.Add(Equipment_inventory_batch_detailTable.condition_id, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(Equipment_inventory_batch_detailTable.condition_id, true);
      
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

        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Equipment_inventory_batch_detailTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"equipment_inventory_batch_detail_.equipment_inventory_batch_id"), EvaluateFormula("URL(\"batch_id\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"batch_id\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"batch_id\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual string[] GetAutoCompletionList_SearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            OEMConversion.Business.Equipment_inventory_batch_detailRecord[] recordList  = Equipment_inventory_batch_detailTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (Equipment_inventory_batch_detailRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(Equipment_inventory_batch_detailTable.condition_id);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(Equipment_inventory_batch_detailTable.condition_id.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Equipment_inventory_batch_detailTable.condition_id.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Equipment_inventory_batch_detailTableControlRow recControl = (Equipment_inventory_batch_detailTableControlRow)(repItem.FindControl("Equipment_inventory_batch_detailTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Equipment_inventory_batch_detailRecord rec = new Equipment_inventory_batch_detailRecord();
        
                        if (recControl.accepted.Text != "") {
                            rec.Parse(recControl.accepted.Text, Equipment_inventory_batch_detailTable.accepted);
                  }
                
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
                
                        if (recControl.equipment_inventory_batch_id.Text != "") {
                            rec.Parse(recControl.equipment_inventory_batch_id.Text, Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                  }
                
                        if (recControl.equipment_inventory_disposition_id.Text != "") {
                            rec.Parse(recControl.equipment_inventory_disposition_id.Text, Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id);
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
                
                        if (recControl.processed.Text != "") {
                            rec.Parse(recControl.processed.Text, Equipment_inventory_batch_detailTable.processed);
                  }
                
                        if (recControl.purchase_price.Text != "") {
                            rec.Parse(recControl.purchase_price.Text, Equipment_inventory_batch_detailTable.purchase_price);
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
        
        public virtual void SetmodelLabel1()
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
            
        public virtual void SetmodelFilter()
        {
            
            ArrayList modelFilterselectedFilterItemList = new ArrayList();
            string modelFilteritemsString = null;
            if (this.InSession(this.modelFilter))
                modelFilteritemsString = this.GetFromSession(this.modelFilter);
            
            if (modelFilteritemsString != null)
            {
                string[] modelFilteritemListFromSession = modelFilteritemsString.Split(',');
                foreach (string item in modelFilteritemListFromSession)
                {
                    modelFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulatemodelFilter(MiscUtils.GetSelectedValueList(this.modelFilter, modelFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../equipment_inventory_batch_detail/Equipment-inventory-batch-detail-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.modelFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("model")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.modelFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(modelFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for SortControl.
                
        protected virtual void PopulateSortControl(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accepted {Txt:Ascending}"), "accepted Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accepted {Txt:Descending}"), "accepted Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accessories {Txt:Ascending}"), "accessories Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Accessories {Txt:Descending}"), "accessories Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Ascending}"), "condition_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Condition {Txt:Descending}"), "condition_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("EIN {Txt:Ascending}"), "EIN Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("EIN {Txt:Descending}"), "EIN Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Ascending}"), "equipment_inventory_batch_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Batch {Txt:Descending}"), "equipment_inventory_batch_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Disposition {Txt:Ascending}"), "equipment_inventory_disposition_id Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Equipment Inventory Disposition {Txt:Descending}"), "equipment_inventory_disposition_id Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM Barcode Approve {Txt:Ascending}"), "oem_barcode_approve Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM Barcode Approve {Txt:Descending}"), "oem_barcode_approve Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Ascending}"), "oem_ein Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("OEM EIN {Txt:Descending}"), "oem_ein Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Purchase Price {Txt:Ascending}"), "purchase_price Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Purchase Price {Txt:Descending}"), "purchase_price Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Ascending}"), "serial_number Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Serial Number {Txt:Descending}"), "serial_number Desc"));
              
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
            
        // Get the filters' data for modelFilter.
                
        protected virtual void PopulatemodelFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_modelFilter();            
            this.modelFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_modelFilter function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Equipment_inventory_batch_detailTable.model, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Equipment_inventory_batch_detailTable.GetValues(Equipment_inventory_batch_detailTable.model, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Equipment_inventory_batch_detailTable.model.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Equipment_inventory_batch_detailTable.model.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.modelFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.modelFilter.Items.Add(newItem);

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
            
            
            this.modelFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.modelFilter.Items.Count == 0)
                this.modelFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.modelFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_modelFilter()
        {
            // Create a where clause for the filter modelFilter.
            // This function is called by the Populate method to load the items 
            // in the modelFilterQuickSelector
        
            ArrayList modelFilterselectedFilterItemList = new ArrayList();
            string modelFilteritemsString = null;
            if (this.InSession(this.modelFilter))
                modelFilteritemsString = this.GetFromSession(this.modelFilter);
            
            if (modelFilteritemsString != null)
            {
                string[] modelFilteritemListFromSession = modelFilteritemsString.Split(',');
                foreach (string item in modelFilteritemListFromSession)
                {
                    modelFilterselectedFilterItemList.Add(item);
                }
            }
              
            modelFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.modelFilter, modelFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (modelFilterselectedFilterItemList == null || modelFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in modelFilterselectedFilterItemList)
                {
            
      
   
                    wc.iOR(Equipment_inventory_batch_detailTable.model, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
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
                  
            ArrayList modelFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.modelFilter, null);
            string modelFilterSessionString = "";
            if (modelFilterselectedFilterItemList != null){
                foreach (string item in modelFilterselectedFilterItemList){
                    modelFilterSessionString = String.Concat(modelFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.modelFilter, modelFilterSessionString);
                  
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
          
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
            ArrayList modelFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.modelFilter, null);
            string modelFilterSessionString = "";
            if (modelFilterselectedFilterItemList != null){
                foreach (string item in modelFilterselectedFilterItemList){
                    modelFilterSessionString = String.Concat(modelFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("modelFilter_Ajax", modelFilterSessionString);
          
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.modelFilter);
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
        
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetImportButton()                
              
        {
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=Equipment_inventory_batch_detail" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../equipment_inventory_batch_detail/Add-Equipment-inventory-batch-detail.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
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
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(modelFilter))
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


              this.TotalRecords = Equipment_inventory_batch_detailTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Equipment_inventory_batch_detailTable.equipment_inventory_batch_id,
             Equipment_inventory_batch_detailTable.make,
             Equipment_inventory_batch_detailTable.model,
             Equipment_inventory_batch_detailTable.serial_number,
             Equipment_inventory_batch_detailTable.EIN,
             Equipment_inventory_batch_detailTable.purchase_price,
             Equipment_inventory_batch_detailTable.comment,
             Equipment_inventory_batch_detailTable.accepted,
             Equipment_inventory_batch_detailTable.processed,
             Equipment_inventory_batch_detailTable.accessories,
             Equipment_inventory_batch_detailTable.phi,
             Equipment_inventory_batch_detailTable.condition_id,
             Equipment_inventory_batch_detailTable.oem_ein,
             Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id,
             Equipment_inventory_batch_detailTable.oem_barcode_approve,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Equipment_inventory_batch_detailTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Equipment_inventory_batch_detailTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Equipment_inventory_batch_detailTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Equipment_inventory_batch_detailTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id, "Standard"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.make, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.model, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.serial_number, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.EIN, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.purchase_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.comment, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.accepted, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.processed, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.accessories, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.phi, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.condition_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.oem_ein, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Equipment_inventory_batch_detailTable.oem_barcode_approve, "Default"));


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
                val = Equipment_inventory_batch_detailTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
            
            string url = @"../equipment_inventory_batch_detail/Add-Equipment-inventory-batch-detail.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-Equipment-inventory-batch-detail-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "equipment_inventory_batch_detail";
                // If Show-Equipment-inventory-batch-detail-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.Name, ReportEnum.Align.Right, "${equipment_inventory_batch_id}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.make.Name, ReportEnum.Align.Left, "${make}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.model.Name, ReportEnum.Align.Left, "${model}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.EIN.Name, ReportEnum.Align.Left, "${EIN}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.purchase_price.Name, ReportEnum.Align.Right, "${purchase_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.comment.Name, ReportEnum.Align.Left, "${comment}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.accepted.Name, ReportEnum.Align.Left, "${accepted}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventory_batch_detailTable.processed.Name, ReportEnum.Align.Left, "${processed}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventory_batch_detailTable.accessories.Name, ReportEnum.Align.Left, "${accessories}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventory_batch_detailTable.phi.Name, ReportEnum.Align.Left, "${phi}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventory_batch_detailTable.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.oem_ein.Name, ReportEnum.Align.Left, "${oem_ein}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id.Name, ReportEnum.Align.Left, "${equipment_inventory_disposition_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.oem_barcode_approve.Name, ReportEnum.Align.Left, "${oem_barcode_approve}", ReportEnum.Align.Left, 15);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Equipment_inventory_batch_detailTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Equipment_inventory_batch_detailTable.GetRecordCount(joinFilter,whereClause);
                Equipment_inventory_batch_detailRecord[] records = null;
                
                do
                {
                    
                    records = Equipment_inventory_batch_detailTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Equipment_inventory_batch_detailRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 if (BaseClasses.Utils.MiscUtils.IsNull(record.equipment_inventory_batch_id)){
                                 report.AddData("${equipment_inventory_batch_id}", "",ReportEnum.Align.Right);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                                 _DFKA = Equipment_inventory_batch_detailTable.GetDFKA(record.equipment_inventory_batch_id.ToString(), Equipment_inventory_batch_detailTable.equipment_inventory_batch_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.IsApplyDisplayAs){
                                     report.AddData("${equipment_inventory_batch_id}", _DFKA,ReportEnum.Align.Right);
                                 }else{
                                     report.AddData("${equipment_inventory_batch_id}", record.Format(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id), ReportEnum.Align.Right);
                                 }
                             }
                             report.AddData("${make}", record.Format(Equipment_inventory_batch_detailTable.make), ReportEnum.Align.Left, 300);
                             report.AddData("${model}", record.Format(Equipment_inventory_batch_detailTable.model), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Equipment_inventory_batch_detailTable.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${EIN}", record.Format(Equipment_inventory_batch_detailTable.EIN), ReportEnum.Align.Left, 300);
                             report.AddData("${purchase_price}", record.Format(Equipment_inventory_batch_detailTable.purchase_price), ReportEnum.Align.Right, 300);
                             report.AddData("${comment}", record.Format(Equipment_inventory_batch_detailTable.comment), ReportEnum.Align.Left, 300);
                             report.AddData("${accepted}", record.Format(Equipment_inventory_batch_detailTable.accepted), ReportEnum.Align.Left, 300);
                             report.AddData("${processed}", record.Format(Equipment_inventory_batch_detailTable.processed), ReportEnum.Align.Left, 300);
                             report.AddData("${accessories}", record.Format(Equipment_inventory_batch_detailTable.accessories), ReportEnum.Align.Left, 300);
                             report.AddData("${phi}", record.Format(Equipment_inventory_batch_detailTable.phi), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.condition_id)){
                                 report.AddData("${condition_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.condition_id);
                                 _DFKA = Equipment_inventory_batch_detailTable.GetDFKA(record.condition_id.ToString(), Equipment_inventory_batch_detailTable.condition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventory_batch_detailTable.condition_id.IsApplyDisplayAs){
                                     report.AddData("${condition_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${condition_id}", record.Format(Equipment_inventory_batch_detailTable.condition_id), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${oem_ein}", record.Format(Equipment_inventory_batch_detailTable.oem_ein), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.equipment_inventory_disposition_id)){
                                 report.AddData("${equipment_inventory_disposition_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id);
                                 _DFKA = Equipment_inventory_batch_detailTable.GetDFKA(record.equipment_inventory_disposition_id.ToString(), Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id.IsApplyDisplayAs){
                                     report.AddData("${equipment_inventory_disposition_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${equipment_inventory_disposition_id}", record.Format(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${oem_barcode_approve}", record.Format(Equipment_inventory_batch_detailTable.oem_barcode_approve), ReportEnum.Align.Left, 300);

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
                
              this.modelFilter.ClearSelection();
            
           
            this.SortControl.ClearSelection();
          
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-Equipment-inventory-batch-detail-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "equipment_inventory_batch_detail";
                // If Show-Equipment-inventory-batch-detail-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.Name, ReportEnum.Align.Right, "${equipment_inventory_batch_id}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.make.Name, ReportEnum.Align.Left, "${make}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.model.Name, ReportEnum.Align.Left, "${model}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.serial_number.Name, ReportEnum.Align.Left, "${serial_number}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.EIN.Name, ReportEnum.Align.Left, "${EIN}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.purchase_price.Name, ReportEnum.Align.Right, "${purchase_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.comment.Name, ReportEnum.Align.Left, "${comment}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.accepted.Name, ReportEnum.Align.Left, "${accepted}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventory_batch_detailTable.processed.Name, ReportEnum.Align.Left, "${processed}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventory_batch_detailTable.accessories.Name, ReportEnum.Align.Left, "${accessories}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventory_batch_detailTable.phi.Name, ReportEnum.Align.Left, "${phi}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Equipment_inventory_batch_detailTable.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Equipment_inventory_batch_detailTable.oem_ein.Name, ReportEnum.Align.Left, "${oem_ein}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id.Name, ReportEnum.Align.Left, "${equipment_inventory_disposition_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Equipment_inventory_batch_detailTable.oem_barcode_approve.Name, ReportEnum.Align.Left, "${oem_barcode_approve}", ReportEnum.Align.Left, 15);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Equipment_inventory_batch_detailTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Equipment_inventory_batch_detailTable.GetColumnList();
                Equipment_inventory_batch_detailRecord[] records = null;
                do
                {
                    records = Equipment_inventory_batch_detailTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Equipment_inventory_batch_detailRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.equipment_inventory_batch_id)){
                                 report.AddData("${equipment_inventory_batch_id}", "",ReportEnum.Align.Right);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id);
                                 _DFKA = Equipment_inventory_batch_detailTable.GetDFKA(record.equipment_inventory_batch_id.ToString(), Equipment_inventory_batch_detailTable.equipment_inventory_batch_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventory_batch_detailTable.equipment_inventory_batch_id.IsApplyDisplayAs){
                                     report.AddData("${equipment_inventory_batch_id}", _DFKA,ReportEnum.Align.Right);
                                 }else{
                                     report.AddData("${equipment_inventory_batch_id}", record.Format(Equipment_inventory_batch_detailTable.equipment_inventory_batch_id), ReportEnum.Align.Right);
                                 }
                             }
                             report.AddData("${make}", record.Format(Equipment_inventory_batch_detailTable.make), ReportEnum.Align.Left, 300);
                             report.AddData("${model}", record.Format(Equipment_inventory_batch_detailTable.model), ReportEnum.Align.Left, 300);
                             report.AddData("${serial_number}", record.Format(Equipment_inventory_batch_detailTable.serial_number), ReportEnum.Align.Left, 300);
                             report.AddData("${EIN}", record.Format(Equipment_inventory_batch_detailTable.EIN), ReportEnum.Align.Left, 300);
                             report.AddData("${purchase_price}", record.Format(Equipment_inventory_batch_detailTable.purchase_price), ReportEnum.Align.Right, 300);
                             report.AddData("${comment}", record.Format(Equipment_inventory_batch_detailTable.comment), ReportEnum.Align.Left, 300);
                             report.AddData("${accepted}", record.Format(Equipment_inventory_batch_detailTable.accepted), ReportEnum.Align.Left, 300);
                             report.AddData("${processed}", record.Format(Equipment_inventory_batch_detailTable.processed), ReportEnum.Align.Left, 300);
                             report.AddData("${accessories}", record.Format(Equipment_inventory_batch_detailTable.accessories), ReportEnum.Align.Left, 300);
                             report.AddData("${phi}", record.Format(Equipment_inventory_batch_detailTable.phi), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.condition_id)){
                                 report.AddData("${condition_id}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.condition_id);
                                 _DFKA = Equipment_inventory_batch_detailTable.GetDFKA(record.condition_id.ToString(), Equipment_inventory_batch_detailTable.condition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventory_batch_detailTable.condition_id.IsApplyDisplayAs){
                                     report.AddData("${condition_id}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${condition_id}", record.Format(Equipment_inventory_batch_detailTable.condition_id), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${oem_ein}", record.Format(Equipment_inventory_batch_detailTable.oem_ein), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.equipment_inventory_disposition_id)){
                                 report.AddData("${equipment_inventory_disposition_id}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = Equipment_inventory_batch_detailTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id);
                                 _DFKA = Equipment_inventory_batch_detailTable.GetDFKA(record.equipment_inventory_disposition_id.ToString(), Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id.IsApplyDisplayAs){
                                     report.AddData("${equipment_inventory_disposition_id}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${equipment_inventory_disposition_id}", record.Format(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${oem_barcode_approve}", record.Format(Equipment_inventory_batch_detailTable.oem_barcode_approve), ReportEnum.Align.Left, 300);

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
        protected virtual void modelFilter_SelectedIndexChanged(object sender, EventArgs args)
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector modelFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal modelLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel1");
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
        
            return (Equipment_inventory_batch_detailTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Equipment_inventory_batch_detail_Table.Equipment_inventory_batch_detailTableControlRow")));
          
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
  

#endregion
    
  
}

  