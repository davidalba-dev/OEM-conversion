
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Import_Equipment_inventory_batch.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Import_Equipment_inventory_batch
{
  

#region "Section 1: Place your customizations here."

    
//public class Equipment_inventory_batch_detailTableControlRow : BaseEquipment_inventory_batch_detailTableControlRow
//{
//      
//        // The BaseEquipment_inventory_batch_detailTableControlRow implements code for a ROW within the
//        // the Equipment_inventory_batch_detailTableControl table.  The BaseEquipment_inventory_batch_detailTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of Equipment_inventory_batch_detailTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class Equipment_inventory_batch_detailTableControl : BaseEquipment_inventory_batch_detailTableControl
//{
//    // The BaseEquipment_inventory_batch_detailTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The Equipment_inventory_batch_detailTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//

  
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

  
//public class Equipment_inventory_batch_detailTableControl2Row : BaseEquipment_inventory_batch_detailTableControl2Row
//{
//      
//        // The BaseEquipment_inventory_batch_detailTableControl2Row implements code for a ROW within the
//        // the Equipment_inventory_batch_detailTableControl2 table.  The BaseEquipment_inventory_batch_detailTableControl2Row implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of Equipment_inventory_batch_detailTableControl2.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class Equipment_inventory_batch_detailTableControl2 : BaseEquipment_inventory_batch_detailTableControl2
//{
//    // The BaseEquipment_inventory_batch_detailTableControl2 class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The Equipment_inventory_batch_detailTableControl2Row class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//

  
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
    
    
// Base class for the Equipment_inventory_batch_detailTableControl1Row control on the Import_Equipment_inventory_batch page.
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
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton1.Click += EditRowButton1_Click;
                        
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
        
                Setaccepted1();
                Setaccessories1();
                Setcomment1();
                SetcommentLabel();
                Setcondition_id1();
                
                
                SetEIN1();
                Setmake1();
                Setmodel1();
                Setoem_barcode_approve1();
                Setphi1();
                Setpurchase_price2();
                Setpurchase_price4();
                Setserial_number1();
                SetDeleteRowButton();
              
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
        
        
        public virtual void Setaccepted1()
        {
            
                    
            // Set the accepted Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.accepted1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.acceptedSpecified) {
                								
                // If the accepted is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.accepted);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.accepted1.Text = formattedValue;
                   
            } 
            
            else {
            
                // accepted is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.accepted1.Text = Equipment_inventory_batch_detailTable.accepted.Format(Equipment_inventory_batch_detailTable.accepted.DefaultValue);
            		
            }
            
            // If the accepted is NULL or blank, then use the value specified  
            // on Properties.
            if (this.accepted1.Text == null ||
                this.accepted1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.accepted1.Text = "&nbsp;";
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
            
            // If the accessories is NULL or blank, then use the value specified  
            // on Properties.
            if (this.accessories1.Text == null ||
                this.accessories1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.accessories1.Text = "&nbsp;";
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
            
            // If the comment is NULL or blank, then use the value specified  
            // on Properties.
            if (this.comment1.Text == null ||
                this.comment1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.comment1.Text = "&nbsp;";
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
            
            // If the EIN is NULL or blank, then use the value specified  
            // on Properties.
            if (this.EIN1.Text == null ||
                this.EIN1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.EIN1.Text = "&nbsp;";
            }
                                     
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
            
            // If the make is NULL or blank, then use the value specified  
            // on Properties.
            if (this.make1.Text == null ||
                this.make1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.make1.Text = "&nbsp;";
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
            
            // If the model is NULL or blank, then use the value specified  
            // on Properties.
            if (this.model1.Text == null ||
                this.model1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.model1.Text = "&nbsp;";
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
            
            // If the oem_barcode_approve is NULL or blank, then use the value specified  
            // on Properties.
            if (this.oem_barcode_approve1.Text == null ||
                this.oem_barcode_approve1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.oem_barcode_approve1.Text = "&nbsp;";
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
            
            // If the phi is NULL or blank, then use the value specified  
            // on Properties.
            if (this.phi1.Text == null ||
                this.phi1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.phi1.Text = "&nbsp;";
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
            
            // If the purchase_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.purchase_price2.Text == null ||
                this.purchase_price2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.purchase_price2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setpurchase_price4()
        {
            
                    
            // Set the purchase_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch_detail record retrieved from the database.
            // this.purchase_price4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.purchase_priceSpecified) {
                								
                // If the purchase_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batch_detailTable.purchase_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.purchase_price4.Text = formattedValue;
                   
            } 
            
            else {
            
                // purchase_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.purchase_price4.Text = Equipment_inventory_batch_detailTable.purchase_price.Format(Equipment_inventory_batch_detailTable.purchase_price.DefaultValue, @"C");
            		
            }
            
            // If the purchase_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.purchase_price4.Text == null ||
                this.purchase_price4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.purchase_price4.Text = "&nbsp;";
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
            
            // If the serial_number is NULL or blank, then use the value specified  
            // on Properties.
            if (this.serial_number1.Text == null ||
                this.serial_number1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.serial_number1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetcommentLabel()
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
        
            Getaccepted1();
            Getaccessories1();
            Getcomment1();
            Getcondition_id1();
            GetEIN1();
            Getmake1();
            Getmodel1();
            Getoem_barcode_approve1();
            Getphi1();
            Getpurchase_price2();
            Getpurchase_price4();
            Getserial_number1();
        }
        
        
        public virtual void Getaccepted1()
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
                
        public virtual void Getpurchase_price2()
        {
            
        }
                
        public virtual void Getpurchase_price4()
        {
            
        }
                
        public virtual void Getserial_number1()
        {
            
        }
                

      // To customize, override this method in Equipment_inventory_batch_detailTableControl1Row.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
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
            
        public virtual void SetEditRowButton1()                
              
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
        public virtual void EditRowButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../equipment_inventory_batch_detail/Edit-Equipment-inventory-batch-detail.aspx?equipment_inventory_batch_detail={Equipment_inventory_batch_detailTableControl1Row:FV:equipment_inventory_batch_details_id}";
            
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
        
        public System.Web.UI.WebControls.Literal accepted1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accepted1");
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
            
        public System.Web.UI.WebControls.Literal commentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "commentLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal condition_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id1");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
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
            
        public System.Web.UI.WebControls.Literal purchase_price2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_price2");
            }
        }
            
        public System.Web.UI.WebControls.Literal purchase_price4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_price4");
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

  
// Base class for the Equipment_inventory_batch_detailTableControl1 control on the Import_Equipment_inventory_batch page.
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
                if  (this.InSession(this.acceptedFilter)) 				
                    initialVal = this.GetFromSession(this.acceptedFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"accepted\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.acceptedFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.acceptedFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.condition_idFilter)) 				
                    initialVal = this.GetFromSession(this.condition_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"condition_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.condition_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.condition_idFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.equipment_inventory_disposition_idFilter)) 				
                    initialVal = this.GetFromSession(this.equipment_inventory_disposition_idFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"equipment_inventory_disposition_id\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.equipment_inventory_disposition_idFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.equipment_inventory_disposition_idFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.makeFilter)) 				
                    initialVal = this.GetFromSession(this.makeFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"make\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.makeFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.makeFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.phiFilter)) 				
                    initialVal = this.GetFromSession(this.phiFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"phi\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.phiFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.phiFilter.SelectedValue = initialVal;
                            
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
        
              this.acceptedLabel1.Click += acceptedLabel1_Click;
            
              this.accessoriesLabel1.Click += accessoriesLabel1_Click;
            
              this.condition_idLabel1.Click += condition_idLabel1_Click;
            
              this.EINLabel1.Click += EINLabel1_Click;
            
              this.makeLabel1.Click += makeLabel1_Click;
            
              this.modelLabel1.Click += modelLabel1_Click;
            
              this.oem_barcode_approveLabel1.Click += oem_barcode_approveLabel1_Click;
            
              this.phiLabel1.Click += phiLabel1_Click;
            
              this.purchase_priceLabel1.Click += purchase_priceLabel1_Click;
            
              this.purchase_priceLabel3.Click += purchase_priceLabel3_Click;
            
              this.serial_numberLabel1.Click += serial_numberLabel1_Click;
            
            // Setup the button events.
          
                    this.ImportButton.Click += ImportButton_Click;
                        
                    this.ImportButton1.Click += ImportButton1_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.Button6.Button.Click += Button6_Click;
                        
                    this.FilterButton1.Button.Click += FilterButton1_Click;
                        
                    this.Filters1Button.Button.Click += Filters1Button_Click;
                        
            this.acceptedFilter.SelectedIndexChanged += new EventHandler(acceptedFilter_SelectedIndexChanged);
            
            this.condition_idFilter.SelectedIndexChanged += new EventHandler(condition_idFilter_SelectedIndexChanged);
            
            this.equipment_inventory_disposition_idFilter.SelectedIndexChanged += new EventHandler(equipment_inventory_disposition_idFilter_SelectedIndexChanged);
            
            this.makeFilter.SelectedIndexChanged += new EventHandler(makeFilter_SelectedIndexChanged);
            
            this.phiFilter.SelectedIndexChanged += new EventHandler(phiFilter_SelectedIndexChanged);
                    
        
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
        
                SetacceptedFilter();
                SetacceptedLabel1();
                SetacceptedLabel2();
                SetaccessoriesLabel1();
                
                Setcondition_idFilter();
                Setcondition_idLabel1();
                Setcondition_idLabel2();
                SetEINLabel1();
                Setequipment_inventory_disposition_idFilter();
                Setequipment_inventory_disposition_idLabel();
                
                
                
                
                SetmakeFilter();
                SetmakeLabel1();
                SetmakeLabel2();
                SetmodelLabel1();
                Setoem_barcode_approveLabel1();
                
                SetphiFilter();
                SetphiLabel1();
                SetphiLabel2();
                Setpurchase_priceLabel1();
                Setpurchase_priceLabel3();
                
                Setserial_numberLabel1();
                
                SetImportButton();
              
                SetImportButton1();
              
                SetResetButton();
              
                SetButton6();
              
                SetFilterButton1();
              
                SetFilters1Button();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFilters1Button();
                     
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


            
            this.acceptedFilter.ClearSelection();
            
            this.condition_idFilter.ClearSelection();
            
            this.equipment_inventory_disposition_idFilter.ClearSelection();
            
            this.makeFilter.ClearSelection();
            
            this.phiFilter.ClearSelection();
            
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
    
            if (MiscUtils.IsValueSelected(this.acceptedFilter)) {
                        
                wc.iAND(Equipment_inventory_batch_detailTable.accepted, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.acceptedFilter, this.GetFromSession(this.acceptedFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.condition_idFilter)) {
                        
                wc.iAND(Equipment_inventory_batch_detailTable.condition_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.condition_idFilter, this.GetFromSession(this.condition_idFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.equipment_inventory_disposition_idFilter)) {
                        
                wc.iAND(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.equipment_inventory_disposition_idFilter, this.GetFromSession(this.equipment_inventory_disposition_idFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.makeFilter)) {
                        
                wc.iAND(Equipment_inventory_batch_detailTable.make, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.makeFilter, this.GetFromSession(this.makeFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.phiFilter)) {
                        
                wc.iAND(Equipment_inventory_batch_detailTable.phi, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.phiFilter, this.GetFromSession(this.phiFilter)), false, false);
                    
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
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String acceptedFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "acceptedFilter_Ajax"];
            if (MiscUtils.IsValueSelected(acceptedFilterSelectedValue)) {

              
                wc.iAND(Equipment_inventory_batch_detailTable.accepted, BaseFilter.ComparisonOperator.EqualsTo, acceptedFilterSelectedValue, false, false);
                      
      }
                      
      String condition_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "condition_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(condition_idFilterSelectedValue)) {

              
                wc.iAND(Equipment_inventory_batch_detailTable.condition_id, BaseFilter.ComparisonOperator.EqualsTo, condition_idFilterSelectedValue, false, false);
                      
      }
                      
      String equipment_inventory_disposition_idFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "equipment_inventory_disposition_idFilter_Ajax"];
            if (MiscUtils.IsValueSelected(equipment_inventory_disposition_idFilterSelectedValue)) {

              
                wc.iAND(Equipment_inventory_batch_detailTable.equipment_inventory_disposition_id, BaseFilter.ComparisonOperator.EqualsTo, equipment_inventory_disposition_idFilterSelectedValue, false, false);
                      
      }
                      
      String makeFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "makeFilter_Ajax"];
            if (MiscUtils.IsValueSelected(makeFilterSelectedValue)) {

              
                wc.iAND(Equipment_inventory_batch_detailTable.make, BaseFilter.ComparisonOperator.EqualsTo, makeFilterSelectedValue, false, false);
                      
      }
                      
      String phiFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "phiFilter_Ajax"];
            if (MiscUtils.IsValueSelected(phiFilterSelectedValue)) {

              
                wc.iAND(Equipment_inventory_batch_detailTable.phi, BaseFilter.ComparisonOperator.EqualsTo, phiFilterSelectedValue, false, false);
                      
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
        
                        if (recControl.accepted1.Text != "") {
                            rec.Parse(recControl.accepted1.Text, Equipment_inventory_batch_detailTable.accepted);
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
                
                        if (recControl.purchase_price2.Text != "") {
                            rec.Parse(recControl.purchase_price2.Text, Equipment_inventory_batch_detailTable.purchase_price);
                  }
                
                        if (recControl.purchase_price4.Text != "") {
                            rec.Parse(recControl.purchase_price4.Text, Equipment_inventory_batch_detailTable.purchase_price);
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
                
        public virtual void SetacceptedLabel2()
                  {
                  
                    
        }
                
        public virtual void SetaccessoriesLabel1()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel1()
                  {
                  
                    
        }
                
        public virtual void Setcondition_idLabel2()
                  {
                  
                    
        }
                
        public virtual void SetEINLabel1()
                  {
                  
                    
        }
                
        public virtual void Setequipment_inventory_disposition_idLabel()
                  {
                  
                    
        }
                
        public virtual void SetmakeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetmakeLabel2()
                  {
                  
                    
        }
                
        public virtual void SetmodelLabel1()
                  {
                  
                    
        }
                
        public virtual void Setoem_barcode_approveLabel1()
                  {
                  
                    
        }
                
        public virtual void SetphiLabel1()
                  {
                  
                    
        }
                
        public virtual void SetphiLabel2()
                  {
                  
                    
        }
                
        public virtual void Setpurchase_priceLabel1()
                  {
                  
                        this.purchase_priceLabel1.Text = EvaluateFormula("\"Bid Price\"");
                      
                    
        }
                
        public virtual void Setpurchase_priceLabel3()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.purchase_priceLabel3.Text = "Some value";
                    
                    
        }
                
        public virtual void Setserial_numberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetacceptedFilter()
        {
            
            this.PopulateacceptedFilter(MiscUtils.GetSelectedValue(this.acceptedFilter,  GetFromSession(this.acceptedFilter)), 500);					
                                     
        }
            
        public virtual void Setcondition_idFilter()
        {
            
            this.Populatecondition_idFilter(MiscUtils.GetSelectedValue(this.condition_idFilter,  GetFromSession(this.condition_idFilter)), 500);					
                                     
        }
            
        public virtual void Setequipment_inventory_disposition_idFilter()
        {
            
            this.Populateequipment_inventory_disposition_idFilter(MiscUtils.GetSelectedValue(this.equipment_inventory_disposition_idFilter,  GetFromSession(this.equipment_inventory_disposition_idFilter)), 500);					
                                     
        }
            
        public virtual void SetmakeFilter()
        {
            
            this.PopulatemakeFilter(MiscUtils.GetSelectedValue(this.makeFilter,  GetFromSession(this.makeFilter)), 500);					
                                     
        }
            
        public virtual void SetphiFilter()
        {
            
            this.PopulatephiFilter(MiscUtils.GetSelectedValue(this.phiFilter,  GetFromSession(this.phiFilter)), 500);					
                                     
        }
            
        // Get the filters' data for acceptedFilter.
                
        protected virtual void PopulateacceptedFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.acceptedFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_acceptedFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_acceptedFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.acceptedFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Equipment_inventory_batch_detailTable.accepted, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Equipment_inventory_batch_detailTable.GetValues(Equipment_inventory_batch_detailTable.accepted, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Equipment_inventory_batch_detailTable.accepted.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Equipment_inventory_batch_detailTable.accepted.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.acceptedFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.acceptedFilter.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.acceptedFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.acceptedFilter.SelectedValue != null && this.acceptedFilter.Items.FindByValue(this.acceptedFilter.SelectedValue) == null)
                this.acceptedFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for condition_idFilter.
                
        protected virtual void Populatecondition_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.condition_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_condition_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_condition_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.condition_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ConditionsTable.Condition, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            ConditionsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            if (counter < maxItems && this.condition_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("= Conditions.Condition", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.condition_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.condition_idFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.condition_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.condition_idFilter.SelectedValue != null && this.condition_idFilter.Items.FindByValue(this.condition_idFilter.SelectedValue) == null)
                this.condition_idFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for equipment_inventory_disposition_idFilter.
                
        protected virtual void Populateequipment_inventory_disposition_idFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.equipment_inventory_disposition_idFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_equipment_inventory_disposition_idFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_equipment_inventory_disposition_idFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.equipment_inventory_disposition_idFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Equipment_inventory_dispositionTable.equipment_inventory_disposition, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "OEMConversion");

            Equipment_inventory_dispositionRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            cvalue = itemValue.equipment_inventory_disposition_id.ToString();
                            if (counter < maxItems && this.equipment_inventory_disposition_idFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                variables.Clear();
                                     
                                        
                                variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue);
                                fvalue = EvaluateFormula("= Equipment_inventory_disposition.equipment_inventory_disposition", itemValue , variables, evaluator);
                                    					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.equipment_inventory_disposition_idFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.equipment_inventory_disposition_idFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.equipment_inventory_disposition_idFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.equipment_inventory_disposition_idFilter.SelectedValue != null && this.equipment_inventory_disposition_idFilter.Items.FindByValue(this.equipment_inventory_disposition_idFilter.SelectedValue) == null)
                this.equipment_inventory_disposition_idFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for makeFilter.
                
        protected virtual void PopulatemakeFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.makeFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_makeFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_makeFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.makeFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Equipment_inventory_batch_detailTable.make, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Equipment_inventory_batch_detailTable.GetValues(Equipment_inventory_batch_detailTable.make, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Equipment_inventory_batch_detailTable.make.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Equipment_inventory_batch_detailTable.make.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.makeFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.makeFilter.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.makeFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.makeFilter.SelectedValue != null && this.makeFilter.Items.FindByValue(this.makeFilter.SelectedValue) == null)
                this.makeFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for phiFilter.
                
        protected virtual void PopulatephiFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.phiFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_phiFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_phiFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.phiFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
              
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(Equipment_inventory_batch_detailTable.phi, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = Equipment_inventory_batch_detailTable.GetValues(Equipment_inventory_batch_detailTable.phi, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( Equipment_inventory_batch_detailTable.phi.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = Equipment_inventory_batch_detailTable.phi.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.phiFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.phiFilter.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.phiFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.phiFilter.SelectedValue != null && this.phiFilter.Items.FindByValue(this.phiFilter.SelectedValue) == null)
                this.phiFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_acceptedFilter()
        {
            // Create a where clause for the filter acceptedFilter.
            // This function is called by the Populate method to load the items 
            // in the acceptedFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      
        public virtual WhereClause CreateWhereClause_condition_idFilter()
        {
            // Create a where clause for the filter condition_idFilter.
            // This function is called by the Populate method to load the items 
            // in the condition_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.ConditionsTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Conditions_.condition_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_equipment_inventory_disposition_idFilter()
        {
            // Create a where clause for the filter equipment_inventory_disposition_idFilter.
            // This function is called by the Populate method to load the items 
            // in the equipment_inventory_disposition_idFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Equipment_inventory_dispositionTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"equipment_inventory_disposition_.equipment_inventory_disposition_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      
        public virtual WhereClause CreateWhereClause_makeFilter()
        {
            // Create a where clause for the filter makeFilter.
            // This function is called by the Populate method to load the items 
            // in the makeFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      
        public virtual WhereClause CreateWhereClause_phiFilter()
        {
            // Create a where clause for the filter phiFilter.
            // This function is called by the Populate method to load the items 
            // in the phiFilterDropDownList
        
            WhereClause wc = new WhereClause();
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
        
            this.SaveToSession(this.acceptedFilter, this.acceptedFilter.SelectedValue);
                  
            this.SaveToSession(this.condition_idFilter, this.condition_idFilter.SelectedValue);
                  
            this.SaveToSession(this.equipment_inventory_disposition_idFilter, this.equipment_inventory_disposition_idFilter.SelectedValue);
                  
            this.SaveToSession(this.makeFilter, this.makeFilter.SelectedValue);
                  
            this.SaveToSession(this.phiFilter, this.phiFilter.SelectedValue);
                  
            
                    
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
          
      this.SaveToSession("acceptedFilter_Ajax", this.acceptedFilter.SelectedValue);
              
      this.SaveToSession("condition_idFilter_Ajax", this.condition_idFilter.SelectedValue);
              
      this.SaveToSession("equipment_inventory_disposition_idFilter_Ajax", this.equipment_inventory_disposition_idFilter.SelectedValue);
              
      this.SaveToSession("makeFilter_Ajax", this.makeFilter.SelectedValue);
              
      this.SaveToSession("phiFilter_Ajax", this.phiFilter.SelectedValue);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.acceptedFilter);
            this.RemoveFromSession(this.condition_idFilter);
            this.RemoveFromSession(this.equipment_inventory_disposition_idFilter);
            this.RemoveFromSession(this.makeFilter);
            this.RemoveFromSession(this.phiFilter);
            
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
        
        public virtual void SetImportButton()                
              
        {
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=Equipment_inventory_batch_detail" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetImportButton1()                
              
        {
        							
                    this.ImportButton1.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=Equipment_inventory_batch_detail" ;
                    this.ImportButton1.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton1.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetButton6()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton1()                
              
        {
        
   
        }
            
        public virtual void SetFilters1Button()                
              
        {
                
         IThemeButtonWithArrow themeButtonFilters1Button = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Filters1Button"));
         themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(acceptedFilter))
                themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(condition_idFilter))
                themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(equipment_inventory_disposition_idFilter))
                themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(makeFilter))
                themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(phiFilter))
                themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
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
        
        public virtual void acceptedLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by accepted when clicked.
              
            // Get previous sorting state for accepted.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.accepted);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for accepted.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.accepted, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by accepted, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
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
            
        public virtual void EINLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by EIN when clicked.
              
            // Get previous sorting state for EIN.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.EIN);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for EIN.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.EIN, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by EIN, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void makeLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by make when clicked.
              
            // Get previous sorting state for make.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.make);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for make.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.make, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by make, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void modelLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by model when clicked.
              
            // Get previous sorting state for model.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.model);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for model.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.model, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by model, so just reverse.
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
            
        public virtual void purchase_priceLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by purchase_price when clicked.
              
            // Get previous sorting state for purchase_price.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.purchase_price);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for purchase_price.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.purchase_price, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by purchase_price, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void purchase_priceLabel3_Click(object sender, EventArgs args)
        {
            //Sorts by purchase_price when clicked.
              
            // Get previous sorting state for purchase_price.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.purchase_price);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for purchase_price.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.purchase_price, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by purchase_price, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void serial_numberLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by serial_number when clicked.
              
            // Get previous sorting state for serial_number.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Equipment_inventory_batch_detailTable.serial_number);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for serial_number.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Equipment_inventory_batch_detailTable.serial_number, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by serial_number, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
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
        public virtual void ImportButton1_Click(object sender, ImageClickEventArgs args)
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
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.acceptedFilter.ClearSelection();
            
              this.condition_idFilter.ClearSelection();
            
              this.equipment_inventory_disposition_idFilter.ClearSelection();
            
              this.makeFilter.ClearSelection();
            
              this.phiFilter.ClearSelection();
            
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
            
            
        
        // event handler for Button
        public virtual void Filters1Button_Click(object sender, EventArgs args)
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
        protected virtual void acceptedFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void condition_idFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void equipment_inventory_disposition_idFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void makeFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void phiFilter_SelectedIndexChanged(object sender, EventArgs args)
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
        
        public System.Web.UI.WebControls.DropDownList acceptedFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "acceptedFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton acceptedLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "acceptedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal acceptedLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "acceptedLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton accessoriesLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "accessoriesLabel1");
            }
        }
        
        public OEMConversion.UI.IThemeButton Button6 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button6");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList condition_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton condition_idLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal condition_idLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_idLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton EINLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EINLabel1");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList equipment_inventory_disposition_idFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_disposition_idFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal equipment_inventory_disposition_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_disposition_idLabel");
            }
        }
        
        public OEMConversion.UI.IThemeButton FilterButton1 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton1");
            }
        }
        
        public OEMConversion.UI.IThemeButtonWithArrow Filters1Button {
            get {
                return (OEMConversion.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters1Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ImportButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton1");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList makeFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton makeLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal makeLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "makeLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton modelLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "modelLabel1");
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
        
        public System.Web.UI.WebControls.DropDownList phiFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phiFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton phiLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phiLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal phiLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "phiLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton purchase_priceLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_priceLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton purchase_priceLabel3 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "purchase_priceLabel3");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton serial_numberLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "serial_numberLabel1");
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
        
            return (Equipment_inventory_batch_detailTableControl1Row[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Import_Equipment_inventory_batch.Equipment_inventory_batch_detailTableControl1Row")));
          
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
  
// Base class for the Equipment_inventory_batchRecordControl control on the Import_Equipment_inventory_batch page.
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

          
                    this.Button3.Button.Click += Button3_Click;
                        
              this.batch_status_id.SelectedIndexChanged += batch_status_id_SelectedIndexChanged;
            
              this.custno.SelectedIndexChanged += custno_SelectedIndexChanged;
            
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
                
                Setequipment_inventory_batch_id1();
                
                Settechnician_id();
                Settechnician_idLabel();
                
                Setwarehouse_id();
                Setwarehouse_idLabel();
                Setwarehouse_location_id();
                Setwarehouse_location_idLabel();
                SetButton3();
              

      

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
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the batch_status_id DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch record retrieved from the database.
            // this.batch_status_id is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setbatch_status_id();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.batch_status_idSpecified)
            {
                            
                // If the batch_status_id is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.batch_status_id.ToString();
                
            }
            else
            {
                
                // batch_status_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Equipment_inventory_batchTable.batch_status_id.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.Populatebatch_status_idDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setcustno()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the custno DropDownList on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch database record.
            
            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch record retrieved from the database.
            // this.custno is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.Setcustno();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.custno.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"custno\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulatecustnoDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void Setequipment_inventory_batch_id1()
        {
            
                    
            // Set the equipment_inventory_batch_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_batch database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_batch record retrieved from the database.
            // this.equipment_inventory_batch_id1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.equipment_inventory_batch_idSpecified) {
                								
                // If the equipment_inventory_batch_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_batchTable.equipment_inventory_batch_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.equipment_inventory_batch_id1.Text = formattedValue;
                   
            } 
            
            else {
            
                // equipment_inventory_batch_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.equipment_inventory_batch_id1.Text = Equipment_inventory_batchTable.equipment_inventory_batch_id.Format(Equipment_inventory_batchTable.equipment_inventory_batch_id.DefaultValue);
            		
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
            Getequipment_inventory_batch_id1();
            Gettechnician_id();
            Getwarehouse_id();
            Getwarehouse_location_id();
        }
        
        
        public virtual void Getbatch_date()
        {
            
        }
                
        public virtual void Getbatch_status_id()
        {
         // Retrieve the value entered by the user on the batch_status_id ASP:DropDownList, and
            // save it into the batch_status_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.batch_status_id), Equipment_inventory_batchTable.batch_status_id);			
                			 
        }
                
        public virtual void Getcustno()
        {
         // Retrieve the value entered by the user on the custno ASP:DropDownList, and
            // save it into the custno field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_batch record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.custno), Equipment_inventory_batchTable.custno);			
                			 
        }
                
        public virtual void Getequipment_inventory_batch_id1()
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
            HttpContext.Current.Session["QueryString in Import-Equipment-inventory-batch"] = recId;
                  
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
                
            this.Page.Authorize((Control)Equipment_inventory_batch_detailTableControl1, "Everyone");
					
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
        
        public virtual void SetButton3()                
              
        {
        
                    this.Button3.Button.Attributes.Add("onclick", "SubmitHRefOnce(this, \"" + this.Page.GetResourceValue("Txt:SaveRecord", "OEMConversion") + "\");");
                  
   
        }
            
        public virtual WhereClause CreateWhereClause_batch_status_idDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.equipment_batch_status table.
            // Examples:
            // wc.iAND(Equipment_batch_statusTable.batch_status, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(Equipment_batch_statusTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_custnoDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseAYS_OEM%dbo.Customers table.
            // Examples:
            // wc.iAND(CustomersTable.CustNo, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CustomersTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.customer_active"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
            if (EvaluateFormula("1", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.CustomersTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"Customers_.customer_inventory"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;
         if (EvaluateFormula("1", false) == "--PLEASE_SELECT--" || EvaluateFormula("1", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;				
        }
        
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
        
        // Fill the batch_status_id list.
        protected virtual void Populatebatch_status_idDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.batch_status_id.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.batch_status_id.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_batch_status_idDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_batch_status_idDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(Equipment_batch_statusTable.batch_status, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the batch_status_idDropDownList.
            Equipment_batch_statusRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = Equipment_batch_statusTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (Equipment_batch_statusRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.equipment_batch_status_idSpecified) 
                        {
                            cvalue = itemValue.equipment_batch_status_id.ToString().ToString();
                            if (counter < maxItems && this.batch_status_id.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batchTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batchTable.batch_status_id);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventory_batchTable.batch_status_id.IsApplyDisplayAs)
                                    fvalue = Equipment_inventory_batchTable.GetDFKA(itemValue, Equipment_inventory_batchTable.batch_status_id);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(Equipment_batch_statusTable.batch_status);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.batch_status_id.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.batch_status_id.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.batch_status_id, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.batch_status_id, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseAYS_OEM%dbo.equipment_batch_status.equipment_batch_status_id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(Equipment_batch_statusTable.equipment_batch_status_id, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    Equipment_batch_statusRecord[] rc = Equipment_batch_statusTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        Equipment_batch_statusRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.equipment_batch_status_idSpecified)
                            cvalue = itemValue.equipment_batch_status_id.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batchTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batchTable.batch_status_id);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventory_batchTable.batch_status_id.IsApplyDisplayAs)
                            fvalue = Equipment_inventory_batchTable.GetDFKA(itemValue, Equipment_inventory_batchTable.batch_status_id);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(Equipment_batch_statusTable.batch_status);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.batch_status_id, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the custno list.
        protected virtual void PopulatecustnoDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.custno.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.custno.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "OEMConversion"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_custnoDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_custnoDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CustomersTable.CustName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the custnoDropDownList.
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
                            if (counter < maxItems && this.custno.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batchTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batchTable.custno);
                                if(_isExpandableNonCompositeForeignKey && Equipment_inventory_batchTable.custno.IsApplyDisplayAs)
                                    fvalue = Equipment_inventory_batchTable.GetDFKA(itemValue, Equipment_inventory_batchTable.custno);
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

                                ListItem dupItem = this.custno.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.custno.Items.Add(newItem);

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
                        Boolean _isExpandableNonCompositeForeignKey = Equipment_inventory_batchTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Equipment_inventory_batchTable.custno);
                        if(_isExpandableNonCompositeForeignKey && Equipment_inventory_batchTable.custno.IsApplyDisplayAs)
                            fvalue = Equipment_inventory_batchTable.GetDFKA(itemValue, Equipment_inventory_batchTable.custno);
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
                  
        // event handler for Button
        public virtual void Button3_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Customers/Add-Customers-Basic.aspx?CustomerNo={Max_customerRecordControl:FV:Expr}&SaveAndNewVisible=True&TabVisible=True";
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
        
              if (!this.Page.IsPageRefresh)
              {
                  this.SaveData();
              }

          
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              this.Page.CommitTransaction(sender);
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.custno.ClientID) + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Customers.CustName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CustNo");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(this, '" + url + "', false, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "Button3_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        protected virtual void batch_status_id_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[batch_status_id.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[batch_status_id.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.batch_status_id.Items.Add(new ListItem(displayText, val));
	            this.batch_status_id.SelectedIndex = this.batch_status_id.Items.Count - 1;
	            this.Page.Session.Remove(batch_status_id.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(batch_status_id.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void custno_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[custno.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[custno.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.custno.Items.Add(new ListItem(displayText, val));
	            this.custno.SelectedIndex = this.custno.Items.Count - 1;
	            this.Page.Session.Remove(custno.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(custno.ClientID + "_SelectedDisplayText");
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
        
        public System.Web.UI.WebControls.DropDownList batch_status_id {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "batch_status_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal batch_status_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "batch_status_idLabel");
            }
        }
        
        public OEMConversion.UI.IThemeButton Button3 {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button3");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList custno {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custno");
            }
        }
            
        public System.Web.UI.WebControls.Literal custnoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "custnoLabel");
            }
        }
        
        public Equipment_inventory_batch_detailTableControl1 Equipment_inventory_batch_detailTableControl1 {
            get {
                return (Equipment_inventory_batch_detailTableControl1)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Equipment_inventory_batch_detailTableControl1");
            }
        }
        
        public System.Web.UI.WebControls.Literal equipment_inventory_batch_id1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "equipment_inventory_batch_id1");
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

  
// Base class for the Max_customerRecordControl control on the Import_Equipment_inventory_batch page.
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

  