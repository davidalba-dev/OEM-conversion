
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Vw_dotmed_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Vw_dotmed_Table
{
  

#region "Section 1: Place your customizations here."

    
//public class Vw_dotmedTableControlRow : BaseVw_dotmedTableControlRow
//{
//      
//        // The BaseVw_dotmedTableControlRow implements code for a ROW within the
//        // the Vw_dotmedTableControl table.  The BaseVw_dotmedTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of Vw_dotmedTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class Vw_dotmedTableControl : BaseVw_dotmedTableControl
//{
//    // The BaseVw_dotmedTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The Vw_dotmedTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//

  

//public class Vw_dotmedTableControl1 : BaseVw_dotmedTableControl1
//{
//    // The BaseVw_dotmedTableControl1 class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The Vw_dotmedTableControl1Row class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//
//public class Vw_dotmedTableControl1Row : BaseVw_dotmedTableControl1Row
//{
//      
//        // The BaseVw_dotmedTableControl1Row implements code for a ROW within the
//        // the Vw_dotmedTableControl1 table.  The BaseVw_dotmedTableControl1Row implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of Vw_dotmedTableControl1.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//
//public class Equipment_inventory_dotmedTableControl : BaseEquipment_inventory_dotmedTableControl
//{
//    // The BaseEquipment_inventory_dotmedTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The Equipment_inventory_dotmedTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//
//public class Equipment_inventory_dotmedTableControlRow : BaseEquipment_inventory_dotmedTableControlRow
//{
//      
//        // The BaseEquipment_inventory_dotmedTableControlRow implements code for a ROW within the
//        // the Equipment_inventory_dotmedTableControl table.  The BaseEquipment_inventory_dotmedTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of Equipment_inventory_dotmedTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//
public class Equipment_inventory_dotmedRecordControl : BaseEquipment_inventory_dotmedRecordControl
{
      
        // The BaseEquipment_inventory_dotmedRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}
public class Vw_dotmedTableControl : BaseVw_dotmedTableControl
{
    // The BaseVw_dotmedTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Vw_dotmedTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}
public class Vw_dotmedTableControlRow : BaseVw_dotmedTableControlRow
{
      
        // The BaseVw_dotmedTableControlRow implements code for a ROW within the
        // the Vw_dotmedTableControl table.  The BaseVw_dotmedTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Vw_dotmedTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Vw_dotmedTableControlRow control on the Show_Vw_dotmed_Table page.
// Do not modify this class. Instead override any method in Vw_dotmedTableControlRow.
public class BaseVw_dotmedTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseVw_dotmedTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Vw_dotmedTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Vw_dotmedTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.EditRowButton.Click += EditRowButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.vw_dotmed record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Vw_dotmedView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseVw_dotmedTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Vw_dotmedRecord();
            
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
        
                Setcondition_id();
                Setdescription();
                Setdotmed_auto_accept();
                Setdotmed_auto_reject();
                Setdotmed_avail_parts();
                Setdotmed_currency();
                Setdotmed_d2d_price();
                Setdotmed_delete();
                Setdotmed_depth();
                Setdotmed_height();
                Setdotmed_image1();
                Setdotmed_image10();
                Setdotmed_image2();
                Setdotmed_image3();
                Setdotmed_image4();
                Setdotmed_image5();
                Setdotmed_image6();
                Setdotmed_image7();
                Setdotmed_image8();
                Setdotmed_image9();
                Setdotmed_in_stock();
                Setdotmed_item_id_type();
                Setdotmed_listing_id();
                Setdotmed_listing_type();
                Setdotmed_make_offer();
                Setdotmed_part_mfg();
                Setdotmed_part_name();
                Setdotmed_part_num();
                Setdotmed_paypal();
                Setdotmed_paypal_shipping();
                Setdotmed_qty();
                Setdotmed_request_type();
                Setdotmed_spec_name1();
                Setdotmed_spec_name2();
                Setdotmed_spec_name3();
                Setdotmed_spec_name4();
                Setdotmed_spec_value1();
                Setdotmed_spec_value2();
                Setdotmed_spec_value3();
                Setdotmed_spec_value4();
                Setdotmed_video_url();
                Setdotmed_vts_price();
                Setdotmed_weight();
                Setdotmed_weight_units();
                Setdotmed_width();
                Setdotmed_will_rent();
                Setdotmed_your_item_id();
                Setdotmed_youtube_url();
                
                Setinventory_id();
                Setmake_id();
                Setmodel_id();
                Setnew_category_id();
                Setproposed_sale_price();
                Setproposed_sale_price1();
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
        
        
        public virtual void Setcondition_id()
        {
            
                    
            // Set the condition_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.condition_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.condition_idSpecified) {
                								
                // If the condition_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.condition_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.condition_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // condition_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.condition_id.Text = Vw_dotmedView.condition_id.Format(Vw_dotmedView.condition_id.DefaultValue);
            		
            }
            
            // If the condition_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.condition_id.Text == null ||
                this.condition_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.condition_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdescription()
        {
            
                    
            // Set the description Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.description is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.descriptionSpecified) {
                								
                // If the description is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.description);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.description.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
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
        
              this.description.Text = Vw_dotmedView.description.Format(Vw_dotmedView.description.DefaultValue);
            		
            }
            
            // If the description is NULL or blank, then use the value specified  
            // on Properties.
            if (this.description.Text == null ||
                this.description.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.description.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_auto_accept()
        {
            
                    
            // Set the dotmed_auto_accept Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_auto_accept is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_auto_acceptSpecified) {
                								
                // If the dotmed_auto_accept is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_auto_accept);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_auto_accept.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_auto_accept is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_auto_accept.Text = Vw_dotmedView.dotmed_auto_accept.Format(Vw_dotmedView.dotmed_auto_accept.DefaultValue);
            		
            }
            
            // If the dotmed_auto_accept is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_auto_accept.Text == null ||
                this.dotmed_auto_accept.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_auto_accept.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_auto_reject()
        {
            
                    
            // Set the dotmed_auto_reject Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_auto_reject is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_auto_rejectSpecified) {
                								
                // If the dotmed_auto_reject is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_auto_reject);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_auto_reject.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_auto_reject is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_auto_reject.Text = Vw_dotmedView.dotmed_auto_reject.Format(Vw_dotmedView.dotmed_auto_reject.DefaultValue);
            		
            }
            
            // If the dotmed_auto_reject is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_auto_reject.Text == null ||
                this.dotmed_auto_reject.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_auto_reject.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_avail_parts()
        {
            
                    
            // Set the dotmed_avail_parts Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_avail_parts is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_avail_partsSpecified) {
                								
                // If the dotmed_avail_parts is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_avail_parts);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_avail_parts.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_avail_parts is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_avail_parts.Text = Vw_dotmedView.dotmed_avail_parts.Format(Vw_dotmedView.dotmed_avail_parts.DefaultValue);
            		
            }
            
            // If the dotmed_avail_parts is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_avail_parts.Text == null ||
                this.dotmed_avail_parts.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_avail_parts.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_currency()
        {
            
                    
            // Set the dotmed_currency Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_currency is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_currencySpecified) {
                								
                // If the dotmed_currency is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_currency, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_currency.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_currency is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_currency.Text = Vw_dotmedView.dotmed_currency.Format(Vw_dotmedView.dotmed_currency.DefaultValue, @"C");
            		
            }
            
            // If the dotmed_currency is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_currency.Text == null ||
                this.dotmed_currency.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_currency.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_d2d_price()
        {
            
                    
            // Set the dotmed_d2d_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_d2d_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_d2d_priceSpecified) {
                								
                // If the dotmed_d2d_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_d2d_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_d2d_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_d2d_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_d2d_price.Text = Vw_dotmedView.dotmed_d2d_price.Format(Vw_dotmedView.dotmed_d2d_price.DefaultValue, @"C");
            		
            }
            
            // If the dotmed_d2d_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_d2d_price.Text == null ||
                this.dotmed_d2d_price.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_d2d_price.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_delete()
        {
            
                    
            // Set the dotmed_delete Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_delete is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_deleteSpecified) {
                								
                // If the dotmed_delete is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_delete);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_delete.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_delete is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_delete.Text = Vw_dotmedView.dotmed_delete.Format(Vw_dotmedView.dotmed_delete.DefaultValue);
            		
            }
            
            // If the dotmed_delete is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_delete.Text == null ||
                this.dotmed_delete.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_delete.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_depth()
        {
            
                    
            // Set the dotmed_depth Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_depth is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_depthSpecified) {
                								
                // If the dotmed_depth is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_depth);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_depth.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_depth is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_depth.Text = Vw_dotmedView.dotmed_depth.Format(Vw_dotmedView.dotmed_depth.DefaultValue);
            		
            }
            
            // If the dotmed_depth is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_depth.Text == null ||
                this.dotmed_depth.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_depth.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_height()
        {
            
                    
            // Set the dotmed_height Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_height is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_heightSpecified) {
                								
                // If the dotmed_height is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_height);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_height.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_height is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_height.Text = Vw_dotmedView.dotmed_height.Format(Vw_dotmedView.dotmed_height.DefaultValue);
            		
            }
            
            // If the dotmed_height is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_height.Text == null ||
                this.dotmed_height.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_height.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image1()
        {
            
                    
            // Set the dotmed_image1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image1Specified) {
                								
                // If the dotmed_image1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image1);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image1.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image1\\\", \\\"dotmed_image1\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image1.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image1.Text = Vw_dotmedView.dotmed_image1.Format(Vw_dotmedView.dotmed_image1.DefaultValue);
            		
            }
            
            // If the dotmed_image1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image1.Text == null ||
                this.dotmed_image1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image10()
        {
            
                    
            // Set the dotmed_image10 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image10 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image10Specified) {
                								
                // If the dotmed_image10 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image10);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image10.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image10\\\", \\\"dotmed_image10\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image10.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image10 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image10.Text = Vw_dotmedView.dotmed_image10.Format(Vw_dotmedView.dotmed_image10.DefaultValue);
            		
            }
            
            // If the dotmed_image10 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image10.Text == null ||
                this.dotmed_image10.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image10.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image2()
        {
            
                    
            // Set the dotmed_image2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image2Specified) {
                								
                // If the dotmed_image2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image2);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image2.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image2\\\", \\\"dotmed_image2\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image2.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image2.Text = Vw_dotmedView.dotmed_image2.Format(Vw_dotmedView.dotmed_image2.DefaultValue);
            		
            }
            
            // If the dotmed_image2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image2.Text == null ||
                this.dotmed_image2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image3()
        {
            
                    
            // Set the dotmed_image3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image3Specified) {
                								
                // If the dotmed_image3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image3);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image3.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image3\\\", \\\"dotmed_image3\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image3.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image3.Text = Vw_dotmedView.dotmed_image3.Format(Vw_dotmedView.dotmed_image3.DefaultValue);
            		
            }
            
            // If the dotmed_image3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image3.Text == null ||
                this.dotmed_image3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image4()
        {
            
                    
            // Set the dotmed_image4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image4Specified) {
                								
                // If the dotmed_image4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image4);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image4.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image4\\\", \\\"dotmed_image4\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image4.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image4.Text = Vw_dotmedView.dotmed_image4.Format(Vw_dotmedView.dotmed_image4.DefaultValue);
            		
            }
            
            // If the dotmed_image4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image4.Text == null ||
                this.dotmed_image4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image5()
        {
            
                    
            // Set the dotmed_image5 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image5 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image5Specified) {
                								
                // If the dotmed_image5 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image5);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image5.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image5\\\", \\\"dotmed_image5\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image5.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image5 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image5.Text = Vw_dotmedView.dotmed_image5.Format(Vw_dotmedView.dotmed_image5.DefaultValue);
            		
            }
            
            // If the dotmed_image5 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image5.Text == null ||
                this.dotmed_image5.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image5.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image6()
        {
            
                    
            // Set the dotmed_image6 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image6 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image6Specified) {
                								
                // If the dotmed_image6 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image6);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image6.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image6\\\", \\\"dotmed_image6\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image6.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image6 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image6.Text = Vw_dotmedView.dotmed_image6.Format(Vw_dotmedView.dotmed_image6.DefaultValue);
            		
            }
            
            // If the dotmed_image6 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image6.Text == null ||
                this.dotmed_image6.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image6.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image7()
        {
            
                    
            // Set the dotmed_image7 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image7 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image7Specified) {
                								
                // If the dotmed_image7 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image7);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image7.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image7\\\", \\\"dotmed_image7\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image7.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image7 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image7.Text = Vw_dotmedView.dotmed_image7.Format(Vw_dotmedView.dotmed_image7.DefaultValue);
            		
            }
            
            // If the dotmed_image7 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image7.Text == null ||
                this.dotmed_image7.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image7.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image8()
        {
            
                    
            // Set the dotmed_image8 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image8 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image8Specified) {
                								
                // If the dotmed_image8 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image8);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image8.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image8\\\", \\\"dotmed_image8\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image8.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image8 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image8.Text = Vw_dotmedView.dotmed_image8.Format(Vw_dotmedView.dotmed_image8.DefaultValue);
            		
            }
            
            // If the dotmed_image8 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image8.Text == null ||
                this.dotmed_image8.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image8.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_image9()
        {
            
                    
            // Set the dotmed_image9 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_image9 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_image9Specified) {
                								
                // If the dotmed_image9 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_image9);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_image9.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_image9\\\", \\\"dotmed_image9\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_image9.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_image9 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_image9.Text = Vw_dotmedView.dotmed_image9.Format(Vw_dotmedView.dotmed_image9.DefaultValue);
            		
            }
            
            // If the dotmed_image9 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_image9.Text == null ||
                this.dotmed_image9.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_image9.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_in_stock()
        {
            
                    
            // Set the dotmed_in_stock Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_in_stock is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_in_stockSpecified) {
                								
                // If the dotmed_in_stock is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_in_stock);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_in_stock.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_in_stock is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_in_stock.Text = Vw_dotmedView.dotmed_in_stock.Format(Vw_dotmedView.dotmed_in_stock.DefaultValue);
            		
            }
            
            // If the dotmed_in_stock is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_in_stock.Text == null ||
                this.dotmed_in_stock.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_in_stock.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_item_id_type()
        {
            
                    
            // Set the dotmed_item_id_type Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_item_id_type is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_item_id_typeSpecified) {
                								
                // If the dotmed_item_id_type is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_item_id_type);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_item_id_type.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_item_id_type is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_item_id_type.Text = Vw_dotmedView.dotmed_item_id_type.Format(Vw_dotmedView.dotmed_item_id_type.DefaultValue);
            		
            }
            
            // If the dotmed_item_id_type is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_item_id_type.Text == null ||
                this.dotmed_item_id_type.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_item_id_type.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_listing_id()
        {
            
                    
            // Set the dotmed_listing_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_listing_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_listing_idSpecified) {
                								
                // If the dotmed_listing_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_listing_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_listing_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_listing_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_listing_id.Text = Vw_dotmedView.dotmed_listing_id.Format(Vw_dotmedView.dotmed_listing_id.DefaultValue);
            		
            }
            
            // If the dotmed_listing_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_listing_id.Text == null ||
                this.dotmed_listing_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_listing_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_listing_type()
        {
            
                    
            // Set the dotmed_listing_type Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_listing_type is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_listing_typeSpecified) {
                								
                // If the dotmed_listing_type is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_listing_type);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_listing_type.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_listing_type is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_listing_type.Text = Vw_dotmedView.dotmed_listing_type.Format(Vw_dotmedView.dotmed_listing_type.DefaultValue);
            		
            }
            
            // If the dotmed_listing_type is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_listing_type.Text == null ||
                this.dotmed_listing_type.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_listing_type.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_make_offer()
        {
            
                    
            // Set the dotmed_make_offer Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_make_offer is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_make_offerSpecified) {
                								
                // If the dotmed_make_offer is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_make_offer);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_make_offer.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_make_offer is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_make_offer.Text = Vw_dotmedView.dotmed_make_offer.Format(Vw_dotmedView.dotmed_make_offer.DefaultValue);
            		
            }
            
            // If the dotmed_make_offer is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_make_offer.Text == null ||
                this.dotmed_make_offer.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_make_offer.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_part_mfg()
        {
            
                    
            // Set the dotmed_part_mfg Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_part_mfg is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_part_mfgSpecified) {
                								
                // If the dotmed_part_mfg is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_part_mfg);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_part_mfg.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_part_mfg is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_part_mfg.Text = Vw_dotmedView.dotmed_part_mfg.Format(Vw_dotmedView.dotmed_part_mfg.DefaultValue);
            		
            }
            
            // If the dotmed_part_mfg is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_part_mfg.Text == null ||
                this.dotmed_part_mfg.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_part_mfg.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_part_name()
        {
            
                    
            // Set the dotmed_part_name Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_part_name is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_part_nameSpecified) {
                								
                // If the dotmed_part_name is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_part_name);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_part_name.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_part_name is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_part_name.Text = Vw_dotmedView.dotmed_part_name.Format(Vw_dotmedView.dotmed_part_name.DefaultValue);
            		
            }
            
            // If the dotmed_part_name is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_part_name.Text == null ||
                this.dotmed_part_name.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_part_name.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_part_num()
        {
            
                    
            // Set the dotmed_part_num Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_part_num is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_part_numSpecified) {
                								
                // If the dotmed_part_num is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_part_num);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_part_num.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_part_num is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_part_num.Text = Vw_dotmedView.dotmed_part_num.Format(Vw_dotmedView.dotmed_part_num.DefaultValue);
            		
            }
            
            // If the dotmed_part_num is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_part_num.Text == null ||
                this.dotmed_part_num.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_part_num.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_paypal()
        {
            
                    
            // Set the dotmed_paypal Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_paypal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_paypalSpecified) {
                								
                // If the dotmed_paypal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_paypal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_paypal.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_paypal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_paypal.Text = Vw_dotmedView.dotmed_paypal.Format(Vw_dotmedView.dotmed_paypal.DefaultValue);
            		
            }
            
            // If the dotmed_paypal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_paypal.Text == null ||
                this.dotmed_paypal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_paypal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_paypal_shipping()
        {
            
                    
            // Set the dotmed_paypal_shipping Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_paypal_shipping is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_paypal_shippingSpecified) {
                								
                // If the dotmed_paypal_shipping is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_paypal_shipping, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_paypal_shipping.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_paypal_shipping is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_paypal_shipping.Text = Vw_dotmedView.dotmed_paypal_shipping.Format(Vw_dotmedView.dotmed_paypal_shipping.DefaultValue, @"C");
            		
            }
            
            // If the dotmed_paypal_shipping is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_paypal_shipping.Text == null ||
                this.dotmed_paypal_shipping.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_paypal_shipping.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_qty()
        {
            
                    
            // Set the dotmed_qty Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_qty is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_qtySpecified) {
                								
                // If the dotmed_qty is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_qty);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_qty.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_qty is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_qty.Text = Vw_dotmedView.dotmed_qty.Format(Vw_dotmedView.dotmed_qty.DefaultValue);
            		
            }
            
            // If the dotmed_qty is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_qty.Text == null ||
                this.dotmed_qty.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_qty.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_request_type()
        {
            
                    
            // Set the dotmed_request_type Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_request_type is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_request_typeSpecified) {
                								
                // If the dotmed_request_type is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_request_type);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_request_type.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_request_type is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_request_type.Text = Vw_dotmedView.dotmed_request_type.Format(Vw_dotmedView.dotmed_request_type.DefaultValue);
            		
            }
            
            // If the dotmed_request_type is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_request_type.Text == null ||
                this.dotmed_request_type.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_request_type.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_spec_name1()
        {
            
                    
            // Set the dotmed_spec_name1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_spec_name1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_spec_name1Specified) {
                								
                // If the dotmed_spec_name1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_spec_name1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_spec_name1.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_spec_name1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_spec_name1.Text = Vw_dotmedView.dotmed_spec_name1.Format(Vw_dotmedView.dotmed_spec_name1.DefaultValue);
            		
            }
            
            // If the dotmed_spec_name1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_spec_name1.Text == null ||
                this.dotmed_spec_name1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_spec_name1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_spec_name2()
        {
            
                    
            // Set the dotmed_spec_name2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_spec_name2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_spec_name2Specified) {
                								
                // If the dotmed_spec_name2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_spec_name2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_spec_name2.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_spec_name2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_spec_name2.Text = Vw_dotmedView.dotmed_spec_name2.Format(Vw_dotmedView.dotmed_spec_name2.DefaultValue);
            		
            }
            
            // If the dotmed_spec_name2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_spec_name2.Text == null ||
                this.dotmed_spec_name2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_spec_name2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_spec_name3()
        {
            
                    
            // Set the dotmed_spec_name3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_spec_name3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_spec_name3Specified) {
                								
                // If the dotmed_spec_name3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_spec_name3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_spec_name3.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_spec_name3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_spec_name3.Text = Vw_dotmedView.dotmed_spec_name3.Format(Vw_dotmedView.dotmed_spec_name3.DefaultValue);
            		
            }
            
            // If the dotmed_spec_name3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_spec_name3.Text == null ||
                this.dotmed_spec_name3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_spec_name3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_spec_name4()
        {
            
                    
            // Set the dotmed_spec_name4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_spec_name4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_spec_name4Specified) {
                								
                // If the dotmed_spec_name4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_spec_name4);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_spec_name4.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_spec_name4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_spec_name4.Text = Vw_dotmedView.dotmed_spec_name4.Format(Vw_dotmedView.dotmed_spec_name4.DefaultValue);
            		
            }
            
            // If the dotmed_spec_name4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_spec_name4.Text == null ||
                this.dotmed_spec_name4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_spec_name4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_spec_value1()
        {
            
                    
            // Set the dotmed_spec_value1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_spec_value1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_spec_value1Specified) {
                								
                // If the dotmed_spec_value1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_spec_value1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_spec_value1.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_spec_value1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_spec_value1.Text = Vw_dotmedView.dotmed_spec_value1.Format(Vw_dotmedView.dotmed_spec_value1.DefaultValue);
            		
            }
            
            // If the dotmed_spec_value1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_spec_value1.Text == null ||
                this.dotmed_spec_value1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_spec_value1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_spec_value2()
        {
            
                    
            // Set the dotmed_spec_value2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_spec_value2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_spec_value2Specified) {
                								
                // If the dotmed_spec_value2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_spec_value2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_spec_value2.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_spec_value2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_spec_value2.Text = Vw_dotmedView.dotmed_spec_value2.Format(Vw_dotmedView.dotmed_spec_value2.DefaultValue);
            		
            }
            
            // If the dotmed_spec_value2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_spec_value2.Text == null ||
                this.dotmed_spec_value2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_spec_value2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_spec_value3()
        {
            
                    
            // Set the dotmed_spec_value3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_spec_value3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_spec_value3Specified) {
                								
                // If the dotmed_spec_value3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_spec_value3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_spec_value3.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_spec_value3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_spec_value3.Text = Vw_dotmedView.dotmed_spec_value3.Format(Vw_dotmedView.dotmed_spec_value3.DefaultValue);
            		
            }
            
            // If the dotmed_spec_value3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_spec_value3.Text == null ||
                this.dotmed_spec_value3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_spec_value3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_spec_value4()
        {
            
                    
            // Set the dotmed_spec_value4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_spec_value4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_spec_value4Specified) {
                								
                // If the dotmed_spec_value4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_spec_value4);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_spec_value4.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_spec_value4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_spec_value4.Text = Vw_dotmedView.dotmed_spec_value4.Format(Vw_dotmedView.dotmed_spec_value4.DefaultValue);
            		
            }
            
            // If the dotmed_spec_value4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_spec_value4.Text == null ||
                this.dotmed_spec_value4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_spec_value4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_video_url()
        {
            
                    
            // Set the dotmed_video_url Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_video_url is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_video_urlSpecified) {
                								
                // If the dotmed_video_url is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_video_url);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_video_url.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_video_url\\\", \\\"dotmed_video_url\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_video_url.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_video_url is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_video_url.Text = Vw_dotmedView.dotmed_video_url.Format(Vw_dotmedView.dotmed_video_url.DefaultValue);
            		
            }
            
            // If the dotmed_video_url is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_video_url.Text == null ||
                this.dotmed_video_url.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_video_url.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_vts_price()
        {
            
                    
            // Set the dotmed_vts_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_vts_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_vts_priceSpecified) {
                								
                // If the dotmed_vts_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_vts_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_vts_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_vts_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_vts_price.Text = Vw_dotmedView.dotmed_vts_price.Format(Vw_dotmedView.dotmed_vts_price.DefaultValue, @"C");
            		
            }
            
            // If the dotmed_vts_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_vts_price.Text == null ||
                this.dotmed_vts_price.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_vts_price.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_weight()
        {
            
                    
            // Set the dotmed_weight Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_weight is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_weightSpecified) {
                								
                // If the dotmed_weight is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_weight);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_weight.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_weight is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_weight.Text = Vw_dotmedView.dotmed_weight.Format(Vw_dotmedView.dotmed_weight.DefaultValue);
            		
            }
            
            // If the dotmed_weight is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_weight.Text == null ||
                this.dotmed_weight.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_weight.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_weight_units()
        {
            
                    
            // Set the dotmed_weight_units Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_weight_units is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_weight_unitsSpecified) {
                								
                // If the dotmed_weight_units is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_weight_units);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_weight_units.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_weight_units is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_weight_units.Text = Vw_dotmedView.dotmed_weight_units.Format(Vw_dotmedView.dotmed_weight_units.DefaultValue);
            		
            }
            
            // If the dotmed_weight_units is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_weight_units.Text == null ||
                this.dotmed_weight_units.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_weight_units.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_width()
        {
            
                    
            // Set the dotmed_width Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_width is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_widthSpecified) {
                								
                // If the dotmed_width is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_width);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_width.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_width is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_width.Text = Vw_dotmedView.dotmed_width.Format(Vw_dotmedView.dotmed_width.DefaultValue);
            		
            }
            
            // If the dotmed_width is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_width.Text == null ||
                this.dotmed_width.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_width.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_will_rent()
        {
            
                    
            // Set the dotmed_will_rent Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_will_rent is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_will_rentSpecified) {
                								
                // If the dotmed_will_rent is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_will_rent);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_will_rent.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_will_rent is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_will_rent.Text = Vw_dotmedView.dotmed_will_rent.Format(Vw_dotmedView.dotmed_will_rent.DefaultValue);
            		
            }
            
            // If the dotmed_will_rent is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_will_rent.Text == null ||
                this.dotmed_will_rent.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_will_rent.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_your_item_id()
        {
            
                    
            // Set the dotmed_your_item_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_your_item_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_your_item_idSpecified) {
                								
                // If the dotmed_your_item_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_your_item_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.dotmed_your_item_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_your_item_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_your_item_id.Text = Vw_dotmedView.dotmed_your_item_id.Format(Vw_dotmedView.dotmed_your_item_id.DefaultValue);
            		
            }
            
            // If the dotmed_your_item_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_your_item_id.Text == null ||
                this.dotmed_your_item_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_your_item_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setdotmed_youtube_url()
        {
            
                    
            // Set the dotmed_youtube_url Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.dotmed_youtube_url is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_youtube_urlSpecified) {
                								
                // If the dotmed_youtube_url is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.dotmed_youtube_url);
                                
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
                        String name = HttpUtility.HtmlEncode(Vw_dotmedView.dotmed_youtube_url.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.Vw_dotmedView, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"dotmed_youtube_url\\\", \\\"dotmed_youtube_url\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.dotmed_youtube_url.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_youtube_url is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_youtube_url.Text = Vw_dotmedView.dotmed_youtube_url.Format(Vw_dotmedView.dotmed_youtube_url.DefaultValue);
            		
            }
            
            // If the dotmed_youtube_url is NULL or blank, then use the value specified  
            // on Properties.
            if (this.dotmed_youtube_url.Text == null ||
                this.dotmed_youtube_url.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.dotmed_youtube_url.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setinventory_id()
        {
            
                    
            // Set the inventory_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.inventory_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.inventory_idSpecified) {
                								
                // If the inventory_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.inventory_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.inventory_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // inventory_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.inventory_id.Text = Vw_dotmedView.inventory_id.Format(Vw_dotmedView.inventory_id.DefaultValue);
            		
            }
            
            // If the inventory_id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.inventory_id.Text == null ||
                this.inventory_id.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.inventory_id.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setmake_id()
        {
            
                    
            // Set the make_id Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.make_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.make_idSpecified) {
                								
                // If the make_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.make_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.make_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // make_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.make_id.Text = Vw_dotmedView.make_id.Format(Vw_dotmedView.make_id.DefaultValue);
            		
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
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.model_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.model_idSpecified) {
                								
                // If the model_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.model_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.model_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // model_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.model_id.Text = Vw_dotmedView.model_id.Format(Vw_dotmedView.model_id.DefaultValue);
            		
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
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.new_category_id is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.new_category_idSpecified) {
                								
                // If the new_category_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.new_category_id);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.new_category_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // new_category_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.new_category_id.Text = Vw_dotmedView.new_category_id.Format(Vw_dotmedView.new_category_id.DefaultValue);
            		
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
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.proposed_sale_price is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.proposed_sale_priceSpecified) {
                								
                // If the proposed_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.proposed_sale_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.proposed_sale_price.Text = formattedValue;
                   
            } 
            
            else {
            
                // proposed_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.proposed_sale_price.Text = Vw_dotmedView.proposed_sale_price.Format(Vw_dotmedView.proposed_sale_price.DefaultValue, @"C");
            		
            }
            
            // If the proposed_sale_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.proposed_sale_price.Text == null ||
                this.proposed_sale_price.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.proposed_sale_price.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void Setproposed_sale_price1()
        {
            
                    
            // Set the proposed_sale_price Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.vw_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.vw_dotmed record retrieved from the database.
            // this.proposed_sale_price1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.proposed_sale_priceSpecified) {
                								
                // If the proposed_sale_price is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Vw_dotmedView.proposed_sale_price, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.proposed_sale_price1.Text = formattedValue;
                   
            } 
            
            else {
            
                // proposed_sale_price is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.proposed_sale_price1.Text = Vw_dotmedView.proposed_sale_price.Format(Vw_dotmedView.proposed_sale_price.DefaultValue, @"C");
            		
            }
            
            // If the proposed_sale_price is NULL or blank, then use the value specified  
            // on Properties.
            if (this.proposed_sale_price1.Text == null ||
                this.proposed_sale_price1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.proposed_sale_price1.Text = "&nbsp;";
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
                ((Vw_dotmedTableControl)MiscUtils.GetParentControlObject(this, "Vw_dotmedTableControl")).DataChanged = true;
                ((Vw_dotmedTableControl)MiscUtils.GetParentControlObject(this, "Vw_dotmedTableControl")).ResetData = true;
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
            Getdescription();
            Getdotmed_auto_accept();
            Getdotmed_auto_reject();
            Getdotmed_avail_parts();
            Getdotmed_currency();
            Getdotmed_d2d_price();
            Getdotmed_delete();
            Getdotmed_depth();
            Getdotmed_height();
            Getdotmed_image1();
            Getdotmed_image10();
            Getdotmed_image2();
            Getdotmed_image3();
            Getdotmed_image4();
            Getdotmed_image5();
            Getdotmed_image6();
            Getdotmed_image7();
            Getdotmed_image8();
            Getdotmed_image9();
            Getdotmed_in_stock();
            Getdotmed_item_id_type();
            Getdotmed_listing_id();
            Getdotmed_listing_type();
            Getdotmed_make_offer();
            Getdotmed_part_mfg();
            Getdotmed_part_name();
            Getdotmed_part_num();
            Getdotmed_paypal();
            Getdotmed_paypal_shipping();
            Getdotmed_qty();
            Getdotmed_request_type();
            Getdotmed_spec_name1();
            Getdotmed_spec_name2();
            Getdotmed_spec_name3();
            Getdotmed_spec_name4();
            Getdotmed_spec_value1();
            Getdotmed_spec_value2();
            Getdotmed_spec_value3();
            Getdotmed_spec_value4();
            Getdotmed_video_url();
            Getdotmed_vts_price();
            Getdotmed_weight();
            Getdotmed_weight_units();
            Getdotmed_width();
            Getdotmed_will_rent();
            Getdotmed_your_item_id();
            Getdotmed_youtube_url();
            Getinventory_id();
            Getmake_id();
            Getmodel_id();
            Getnew_category_id();
            Getproposed_sale_price();
            Getproposed_sale_price1();
        }
        
        
        public virtual void Getcondition_id()
        {
            
        }
                
        public virtual void Getdescription()
        {
            
        }
                
        public virtual void Getdotmed_auto_accept()
        {
            
        }
                
        public virtual void Getdotmed_auto_reject()
        {
            
        }
                
        public virtual void Getdotmed_avail_parts()
        {
            
        }
                
        public virtual void Getdotmed_currency()
        {
            
        }
                
        public virtual void Getdotmed_d2d_price()
        {
            
        }
                
        public virtual void Getdotmed_delete()
        {
            
        }
                
        public virtual void Getdotmed_depth()
        {
            
        }
                
        public virtual void Getdotmed_height()
        {
            
        }
                
        public virtual void Getdotmed_image1()
        {
            
        }
                
        public virtual void Getdotmed_image10()
        {
            
        }
                
        public virtual void Getdotmed_image2()
        {
            
        }
                
        public virtual void Getdotmed_image3()
        {
            
        }
                
        public virtual void Getdotmed_image4()
        {
            
        }
                
        public virtual void Getdotmed_image5()
        {
            
        }
                
        public virtual void Getdotmed_image6()
        {
            
        }
                
        public virtual void Getdotmed_image7()
        {
            
        }
                
        public virtual void Getdotmed_image8()
        {
            
        }
                
        public virtual void Getdotmed_image9()
        {
            
        }
                
        public virtual void Getdotmed_in_stock()
        {
            
        }
                
        public virtual void Getdotmed_item_id_type()
        {
            
        }
                
        public virtual void Getdotmed_listing_id()
        {
            
        }
                
        public virtual void Getdotmed_listing_type()
        {
            
        }
                
        public virtual void Getdotmed_make_offer()
        {
            
        }
                
        public virtual void Getdotmed_part_mfg()
        {
            
        }
                
        public virtual void Getdotmed_part_name()
        {
            
        }
                
        public virtual void Getdotmed_part_num()
        {
            
        }
                
        public virtual void Getdotmed_paypal()
        {
            
        }
                
        public virtual void Getdotmed_paypal_shipping()
        {
            
        }
                
        public virtual void Getdotmed_qty()
        {
            
        }
                
        public virtual void Getdotmed_request_type()
        {
            
        }
                
        public virtual void Getdotmed_spec_name1()
        {
            
        }
                
        public virtual void Getdotmed_spec_name2()
        {
            
        }
                
        public virtual void Getdotmed_spec_name3()
        {
            
        }
                
        public virtual void Getdotmed_spec_name4()
        {
            
        }
                
        public virtual void Getdotmed_spec_value1()
        {
            
        }
                
        public virtual void Getdotmed_spec_value2()
        {
            
        }
                
        public virtual void Getdotmed_spec_value3()
        {
            
        }
                
        public virtual void Getdotmed_spec_value4()
        {
            
        }
                
        public virtual void Getdotmed_video_url()
        {
            
        }
                
        public virtual void Getdotmed_vts_price()
        {
            
        }
                
        public virtual void Getdotmed_weight()
        {
            
        }
                
        public virtual void Getdotmed_weight_units()
        {
            
        }
                
        public virtual void Getdotmed_width()
        {
            
        }
                
        public virtual void Getdotmed_will_rent()
        {
            
        }
                
        public virtual void Getdotmed_your_item_id()
        {
            
        }
                
        public virtual void Getdotmed_youtube_url()
        {
            
        }
                
        public virtual void Getinventory_id()
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
                
        public virtual void Getproposed_sale_price1()
        {
            
        }
                

      // To customize, override this method in Vw_dotmedTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_inventory_dotmedRecordControl = false;
            hasFiltersEquipment_inventory_dotmedRecordControl = hasFiltersEquipment_inventory_dotmedRecordControl && false; // suppress warning
      
            bool hasFiltersVw_dotmedTableControl = false;
            hasFiltersVw_dotmedTableControl = hasFiltersVw_dotmedTableControl && false; // suppress warning
      
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
          Vw_dotmedView.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Vw_dotmedTableControl)MiscUtils.GetParentControlObject(this, "Vw_dotmedTableControl")).DataChanged = true;
            ((Vw_dotmedTableControl)MiscUtils.GetParentControlObject(this, "Vw_dotmedTableControl")).ResetData = true;
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
        
        public virtual void SetEditRowButton()                
              
        {
        
   
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
                return (string)this.ViewState["BaseVw_dotmedTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseVw_dotmedTableControlRow_Rec"] = value;
            }
        }
        
        public Vw_dotmedRecord DataSource {
            get {
                return (Vw_dotmedRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal condition_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "condition_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal description {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "description");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_auto_accept {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_auto_accept");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_auto_reject {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_auto_reject");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_avail_parts {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_avail_parts");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_currency {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_currency");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_d2d_price {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_d2d_price");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_delete {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_delete");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_depth {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_depth");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_height {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_height");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image1");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image10 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image10");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image2");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image3");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image4");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image5 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image5");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image6 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image6");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image7 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image7");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image8 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image8");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_image9 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_image9");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_in_stock {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_in_stock");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_item_id_type {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_item_id_type");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_listing_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_listing_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_listing_type {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_listing_type");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_make_offer {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_make_offer");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_part_mfg {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_part_mfg");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_part_name {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_part_name");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_part_num {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_part_num");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_paypal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_paypal");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_paypal_shipping {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_paypal_shipping");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_qty {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_qty");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_request_type {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_request_type");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_spec_name1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_spec_name1");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_spec_name2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_spec_name2");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_spec_name3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_spec_name3");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_spec_name4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_spec_name4");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_spec_value1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_spec_value1");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_spec_value2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_spec_value2");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_spec_value3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_spec_value3");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_spec_value4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_spec_value4");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_video_url {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_video_url");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_vts_price {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_vts_price");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_weight {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_weight");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_weight_units {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_weight_units");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_width {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_width");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_will_rent {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_will_rent");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_your_item_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_your_item_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal dotmed_youtube_url {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_youtube_url");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal inventory_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal make_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal model_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_id");
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
            
        public System.Web.UI.WebControls.Literal proposed_sale_price1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposed_sale_price1");
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
        Vw_dotmedRecord rec = null;
             
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
    Vw_dotmedRecord rec = null;
    
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

        
        public virtual Vw_dotmedRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Vw_dotmedView.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Vw_dotmedTableControl control on the Show_Vw_dotmed_Table page.
// Do not modify this class. Instead override any method in Vw_dotmedTableControl.
public class BaseVw_dotmedTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseVw_dotmedTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "500"));
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
        
              this.dotmed_deleteLabel.Click += dotmed_deleteLabel_Click;
            
              this.dotmed_listing_idLabel.Click += dotmed_listing_idLabel_Click;
            
              this.make_idLabel.Click += make_idLabel_Click;
            
              this.model_idLabel.Click += model_idLabel_Click;
            
              this.proposed_sale_priceLabel.Click += proposed_sale_priceLabel_Click;
            
            // Setup the button events.
          
                    this.CSVButton.Click += CSVButton_Click;
                        
                    this.CSVButton1.Click += CSVButton1_Click;
                        
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                                
        
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
                      Type myrec = typeof(OEMConversion.Business.Vw_dotmedRecord);
                      this.DataSource = (Vw_dotmedRecord[])(alist.ToArray(myrec));
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
                    foreach (Vw_dotmedTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.Vw_dotmedRecord);
                    this.DataSource = (Vw_dotmedRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Vw_dotmedRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Vw_dotmedView.Column1, true);          
            // selCols.Add(Vw_dotmedView.Column2, true);          
            // selCols.Add(Vw_dotmedView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Vw_dotmedView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Vw_dotmedView databaseTable = new Vw_dotmedView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Vw_dotmedRecord)) as Vw_dotmedRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Vw_dotmedView.Column1, true);          
            // selCols.Add(Vw_dotmedView.Column2, true);          
            // selCols.Add(Vw_dotmedView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Vw_dotmedView.GetRecordCount(join, where);
            else
            {
                Vw_dotmedView databaseTable = new Vw_dotmedView();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vw_dotmedTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Vw_dotmedTableControlRow recControl = (Vw_dotmedTableControlRow)(repItem.FindControl("Vw_dotmedTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                Setdotmed_deleteLabel();
                Setdotmed_listing_idLabel();
                
                
                
                Setinventory_idLabel();
                Setmake_idLabel();
                Setmodel_idLabel();
                
                
                Setproposed_sale_priceLabel();
                
                
                SetCSVButton();
              
                SetCSVButton1();
              
                SetExcelButton();
              
                SetPDFButton();
              
                SetWordButton();
              
                SetActionsButton();
              
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
          this.CSVButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm","OEMConversion") + "'));");
        else
          this.CSVButton.Attributes.Remove("onClick");
      
        if (this.TotalRecords > 10000)
          this.CSVButton1.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm","OEMConversion") + "'));");
        else
          this.CSVButton1.Attributes.Remove("onClick");
      
        if (this.TotalRecords > 10000)
          this.ExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "OEMConversion") + "'));");
        else
          this.ExcelButton.Attributes.Remove("onClick");
      
    }
  

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"CSVButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"CSVButton1"));
                        
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
    
            // Bind the buttons for Vw_dotmedTableControl pagination.
        
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
              
            foreach (Vw_dotmedTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Vw_dotmedTableControlRow recCtl in this.GetRecordControls()){
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
            Vw_dotmedView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
             
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Vw_dotmedView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Vw_dotmedTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Vw_dotmedTableControlRow recControl = (Vw_dotmedTableControlRow)(repItem.FindControl("Vw_dotmedTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Vw_dotmedRecord rec = new Vw_dotmedRecord();
        
                        if (recControl.condition_id.Text != "") {
                            rec.Parse(recControl.condition_id.Text, Vw_dotmedView.condition_id);
                  }
                
                        if (recControl.description.Text != "") {
                            rec.Parse(recControl.description.Text, Vw_dotmedView.description);
                  }
                
                        if (recControl.dotmed_auto_accept.Text != "") {
                            rec.Parse(recControl.dotmed_auto_accept.Text, Vw_dotmedView.dotmed_auto_accept);
                  }
                
                        if (recControl.dotmed_auto_reject.Text != "") {
                            rec.Parse(recControl.dotmed_auto_reject.Text, Vw_dotmedView.dotmed_auto_reject);
                  }
                
                        if (recControl.dotmed_avail_parts.Text != "") {
                            rec.Parse(recControl.dotmed_avail_parts.Text, Vw_dotmedView.dotmed_avail_parts);
                  }
                
                        if (recControl.dotmed_currency.Text != "") {
                            rec.Parse(recControl.dotmed_currency.Text, Vw_dotmedView.dotmed_currency);
                  }
                
                        if (recControl.dotmed_d2d_price.Text != "") {
                            rec.Parse(recControl.dotmed_d2d_price.Text, Vw_dotmedView.dotmed_d2d_price);
                  }
                
                        if (recControl.dotmed_delete.Text != "") {
                            rec.Parse(recControl.dotmed_delete.Text, Vw_dotmedView.dotmed_delete);
                  }
                
                        if (recControl.dotmed_depth.Text != "") {
                            rec.Parse(recControl.dotmed_depth.Text, Vw_dotmedView.dotmed_depth);
                  }
                
                        if (recControl.dotmed_height.Text != "") {
                            rec.Parse(recControl.dotmed_height.Text, Vw_dotmedView.dotmed_height);
                  }
                
                        if (recControl.dotmed_image1.Text != "") {
                            rec.Parse(recControl.dotmed_image1.Text, Vw_dotmedView.dotmed_image1);
                  }
                
                        if (recControl.dotmed_image10.Text != "") {
                            rec.Parse(recControl.dotmed_image10.Text, Vw_dotmedView.dotmed_image10);
                  }
                
                        if (recControl.dotmed_image2.Text != "") {
                            rec.Parse(recControl.dotmed_image2.Text, Vw_dotmedView.dotmed_image2);
                  }
                
                        if (recControl.dotmed_image3.Text != "") {
                            rec.Parse(recControl.dotmed_image3.Text, Vw_dotmedView.dotmed_image3);
                  }
                
                        if (recControl.dotmed_image4.Text != "") {
                            rec.Parse(recControl.dotmed_image4.Text, Vw_dotmedView.dotmed_image4);
                  }
                
                        if (recControl.dotmed_image5.Text != "") {
                            rec.Parse(recControl.dotmed_image5.Text, Vw_dotmedView.dotmed_image5);
                  }
                
                        if (recControl.dotmed_image6.Text != "") {
                            rec.Parse(recControl.dotmed_image6.Text, Vw_dotmedView.dotmed_image6);
                  }
                
                        if (recControl.dotmed_image7.Text != "") {
                            rec.Parse(recControl.dotmed_image7.Text, Vw_dotmedView.dotmed_image7);
                  }
                
                        if (recControl.dotmed_image8.Text != "") {
                            rec.Parse(recControl.dotmed_image8.Text, Vw_dotmedView.dotmed_image8);
                  }
                
                        if (recControl.dotmed_image9.Text != "") {
                            rec.Parse(recControl.dotmed_image9.Text, Vw_dotmedView.dotmed_image9);
                  }
                
                        if (recControl.dotmed_in_stock.Text != "") {
                            rec.Parse(recControl.dotmed_in_stock.Text, Vw_dotmedView.dotmed_in_stock);
                  }
                
                        if (recControl.dotmed_item_id_type.Text != "") {
                            rec.Parse(recControl.dotmed_item_id_type.Text, Vw_dotmedView.dotmed_item_id_type);
                  }
                
                        if (recControl.dotmed_listing_id.Text != "") {
                            rec.Parse(recControl.dotmed_listing_id.Text, Vw_dotmedView.dotmed_listing_id);
                  }
                
                        if (recControl.dotmed_listing_type.Text != "") {
                            rec.Parse(recControl.dotmed_listing_type.Text, Vw_dotmedView.dotmed_listing_type);
                  }
                
                        if (recControl.dotmed_make_offer.Text != "") {
                            rec.Parse(recControl.dotmed_make_offer.Text, Vw_dotmedView.dotmed_make_offer);
                  }
                
                        if (recControl.dotmed_part_mfg.Text != "") {
                            rec.Parse(recControl.dotmed_part_mfg.Text, Vw_dotmedView.dotmed_part_mfg);
                  }
                
                        if (recControl.dotmed_part_name.Text != "") {
                            rec.Parse(recControl.dotmed_part_name.Text, Vw_dotmedView.dotmed_part_name);
                  }
                
                        if (recControl.dotmed_part_num.Text != "") {
                            rec.Parse(recControl.dotmed_part_num.Text, Vw_dotmedView.dotmed_part_num);
                  }
                
                        if (recControl.dotmed_paypal.Text != "") {
                            rec.Parse(recControl.dotmed_paypal.Text, Vw_dotmedView.dotmed_paypal);
                  }
                
                        if (recControl.dotmed_paypal_shipping.Text != "") {
                            rec.Parse(recControl.dotmed_paypal_shipping.Text, Vw_dotmedView.dotmed_paypal_shipping);
                  }
                
                        if (recControl.dotmed_qty.Text != "") {
                            rec.Parse(recControl.dotmed_qty.Text, Vw_dotmedView.dotmed_qty);
                  }
                
                        if (recControl.dotmed_request_type.Text != "") {
                            rec.Parse(recControl.dotmed_request_type.Text, Vw_dotmedView.dotmed_request_type);
                  }
                
                        if (recControl.dotmed_spec_name1.Text != "") {
                            rec.Parse(recControl.dotmed_spec_name1.Text, Vw_dotmedView.dotmed_spec_name1);
                  }
                
                        if (recControl.dotmed_spec_name2.Text != "") {
                            rec.Parse(recControl.dotmed_spec_name2.Text, Vw_dotmedView.dotmed_spec_name2);
                  }
                
                        if (recControl.dotmed_spec_name3.Text != "") {
                            rec.Parse(recControl.dotmed_spec_name3.Text, Vw_dotmedView.dotmed_spec_name3);
                  }
                
                        if (recControl.dotmed_spec_name4.Text != "") {
                            rec.Parse(recControl.dotmed_spec_name4.Text, Vw_dotmedView.dotmed_spec_name4);
                  }
                
                        if (recControl.dotmed_spec_value1.Text != "") {
                            rec.Parse(recControl.dotmed_spec_value1.Text, Vw_dotmedView.dotmed_spec_value1);
                  }
                
                        if (recControl.dotmed_spec_value2.Text != "") {
                            rec.Parse(recControl.dotmed_spec_value2.Text, Vw_dotmedView.dotmed_spec_value2);
                  }
                
                        if (recControl.dotmed_spec_value3.Text != "") {
                            rec.Parse(recControl.dotmed_spec_value3.Text, Vw_dotmedView.dotmed_spec_value3);
                  }
                
                        if (recControl.dotmed_spec_value4.Text != "") {
                            rec.Parse(recControl.dotmed_spec_value4.Text, Vw_dotmedView.dotmed_spec_value4);
                  }
                
                        if (recControl.dotmed_video_url.Text != "") {
                            rec.Parse(recControl.dotmed_video_url.Text, Vw_dotmedView.dotmed_video_url);
                  }
                
                        if (recControl.dotmed_vts_price.Text != "") {
                            rec.Parse(recControl.dotmed_vts_price.Text, Vw_dotmedView.dotmed_vts_price);
                  }
                
                        if (recControl.dotmed_weight.Text != "") {
                            rec.Parse(recControl.dotmed_weight.Text, Vw_dotmedView.dotmed_weight);
                  }
                
                        if (recControl.dotmed_weight_units.Text != "") {
                            rec.Parse(recControl.dotmed_weight_units.Text, Vw_dotmedView.dotmed_weight_units);
                  }
                
                        if (recControl.dotmed_width.Text != "") {
                            rec.Parse(recControl.dotmed_width.Text, Vw_dotmedView.dotmed_width);
                  }
                
                        if (recControl.dotmed_will_rent.Text != "") {
                            rec.Parse(recControl.dotmed_will_rent.Text, Vw_dotmedView.dotmed_will_rent);
                  }
                
                        if (recControl.dotmed_your_item_id.Text != "") {
                            rec.Parse(recControl.dotmed_your_item_id.Text, Vw_dotmedView.dotmed_your_item_id);
                  }
                
                        if (recControl.dotmed_youtube_url.Text != "") {
                            rec.Parse(recControl.dotmed_youtube_url.Text, Vw_dotmedView.dotmed_youtube_url);
                  }
                
                        if (recControl.inventory_id.Text != "") {
                            rec.Parse(recControl.inventory_id.Text, Vw_dotmedView.inventory_id);
                  }
                
                        if (recControl.make_id.Text != "") {
                            rec.Parse(recControl.make_id.Text, Vw_dotmedView.make_id);
                  }
                
                        if (recControl.model_id.Text != "") {
                            rec.Parse(recControl.model_id.Text, Vw_dotmedView.model_id);
                  }
                
                        if (recControl.new_category_id.Text != "") {
                            rec.Parse(recControl.new_category_id.Text, Vw_dotmedView.new_category_id);
                  }
                
                        if (recControl.proposed_sale_price.Text != "") {
                            rec.Parse(recControl.proposed_sale_price.Text, Vw_dotmedView.proposed_sale_price);
                  }
                
                        if (recControl.proposed_sale_price1.Text != "") {
                            rec.Parse(recControl.proposed_sale_price1.Text, Vw_dotmedView.proposed_sale_price);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Vw_dotmedRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.Vw_dotmedRecord);
                this.DataSource = (Vw_dotmedRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Vw_dotmedTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Vw_dotmedTableControlRow rec)            
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
        
        public virtual void Setdotmed_deleteLabel()
                  {
                  
                        this.dotmed_deleteLabel.Text = EvaluateFormula("\"Delete\"");
                      
                    
        }
                
        public virtual void Setdotmed_listing_idLabel()
                  {
                  
                        this.dotmed_listing_idLabel.Text = EvaluateFormula("\"Listing ID\"");
                      
                    
        }
                
        public virtual void Setinventory_idLabel()
                  {
                  
                        this.inventory_idLabel.Text = EvaluateFormula("\"Item ID\"");
                      
                    
        }
                
        public virtual void Setmake_idLabel()
                  {
                  
                        this.make_idLabel.Text = EvaluateFormula("\"System Mfg\"");
                      
                    
        }
                
        public virtual void Setmodel_idLabel()
                  {
                  
                        this.model_idLabel.Text = EvaluateFormula("\"System Model\"");
                      
                    
        }
                
        public virtual void Setproposed_sale_priceLabel()
                  {
                  
                        this.proposed_sale_priceLabel.Text = EvaluateFormula("\"Price\"");
                      
                    
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
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            
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

            string orderByStr = (string)ViewState["Vw_dotmedTableControl_OrderBy"];
          
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
                this.ViewState["Vw_dotmedTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetCSVButton()                
              
        {
        
   
        }
            
        public virtual void SetCSVButton1()                
              
        {
        
   
        }
            
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
        {
        
   
        }
            
        public virtual void SetActionsButton()                
              
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
        
        public virtual void dotmed_deleteLabel_Click(object sender, EventArgs args)
        {
            //Sorts by dotmed_delete when clicked.
              
            // Get previous sorting state for dotmed_delete.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_dotmedView.dotmed_delete);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for dotmed_delete.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_dotmedView.dotmed_delete, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by dotmed_delete, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void dotmed_listing_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by dotmed_listing_id when clicked.
              
            // Get previous sorting state for dotmed_listing_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_dotmedView.dotmed_listing_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for dotmed_listing_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_dotmedView.dotmed_listing_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by dotmed_listing_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void make_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by make_id when clicked.
              
            // Get previous sorting state for make_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_dotmedView.make_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for make_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_dotmedView.make_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by make_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void model_idLabel_Click(object sender, EventArgs args)
        {
            //Sorts by model_id when clicked.
              
            // Get previous sorting state for model_id.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_dotmedView.model_id);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for model_id.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_dotmedView.model_id, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by model_id, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void proposed_sale_priceLabel_Click(object sender, EventArgs args)
        {
            //Sorts by proposed_sale_price when clicked.
              
            // Get previous sorting state for proposed_sale_price.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Vw_dotmedView.proposed_sale_price);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for proposed_sale_price.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Vw_dotmedView.proposed_sale_price, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by proposed_sale_price, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void CSVButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                    WhereClause wc = null;
                    wc = CreateWhereClause();
                    OrderBy orderBy = null;
                    
                    orderBy = CreateOrderBy();
                    
                BaseColumn[] columns = new BaseColumn[] {
                             Vw_dotmedView.new_category_id,
             Vw_dotmedView.model_id,
             Vw_dotmedView.make_id,
             Vw_dotmedView.dotmed_part_mfg,
             Vw_dotmedView.description,
             Vw_dotmedView.dotmed_part_num,
             Vw_dotmedView.dotmed_part_name,
             Vw_dotmedView.condition_id,
             Vw_dotmedView.dotmed_listing_type,
             Vw_dotmedView.dotmed_request_type,
             Vw_dotmedView.proposed_sale_price,
             Vw_dotmedView.dotmed_d2d_price,
             Vw_dotmedView.dotmed_vts_price,
             Vw_dotmedView.dotmed_currency,
             Vw_dotmedView.dotmed_qty,
             Vw_dotmedView.dotmed_paypal,
             Vw_dotmedView.dotmed_paypal_shipping,
             Vw_dotmedView.dotmed_make_offer,
             Vw_dotmedView.dotmed_auto_accept,
             Vw_dotmedView.dotmed_auto_reject,
             Vw_dotmedView.dotmed_weight,
             Vw_dotmedView.dotmed_weight_units,
             Vw_dotmedView.dotmed_height,
             Vw_dotmedView.dotmed_width,
             Vw_dotmedView.dotmed_depth,
             Vw_dotmedView.dotmed_will_rent,
             Vw_dotmedView.dotmed_avail_parts,
             Vw_dotmedView.dotmed_in_stock,
             Vw_dotmedView.inventory_id,
             Vw_dotmedView.dotmed_item_id_type,
             Vw_dotmedView.dotmed_your_item_id,
             Vw_dotmedView.dotmed_youtube_url,
             Vw_dotmedView.dotmed_video_url,
             Vw_dotmedView.dotmed_listing_id,
             Vw_dotmedView.dotmed_delete,
             Vw_dotmedView.dotmed_spec_name1,
             Vw_dotmedView.dotmed_spec_value1,
             Vw_dotmedView.dotmed_spec_name2,
             Vw_dotmedView.dotmed_spec_value2,
             Vw_dotmedView.dotmed_spec_name3,
             Vw_dotmedView.dotmed_spec_value3,
             Vw_dotmedView.dotmed_spec_name4,
             Vw_dotmedView.dotmed_spec_value4,
             Vw_dotmedView.dotmed_image1,
             Vw_dotmedView.dotmed_image2,
             Vw_dotmedView.dotmed_image3,
             Vw_dotmedView.dotmed_image4,
             Vw_dotmedView.dotmed_image5,
             Vw_dotmedView.dotmed_image6,
             Vw_dotmedView.dotmed_image7,
             Vw_dotmedView.dotmed_image8,
             Vw_dotmedView.dotmed_image9,
             Vw_dotmedView.dotmed_image10,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Vw_dotmedView.Instance,wc,orderBy,columns);
                
                Boolean done = false;

                int totalRowsReturned = 0;
                CompoundFilter join = CreateCompoundJoinFilter();
                DataForExport data = new DataForExport(Vw_dotmedView.Instance, wc, orderBy, columns,join);

                this.TotalRecords = Vw_dotmedView.GetRecordCount(join, wc);
                Boolean exportRawValues = false;
                if (this.TotalRecords > 10000)
                  exportRawValues = true;
                exportData.StartExport(this.Page.Response, exportRawValues);
                
                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = data.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in data.ColumnList)
                {
                if (col == null)
                continue;

                if (!data.IncludeInExport(col))
                continue;

                String val = "";

                if (exportRawValues )
                val = rec.GetValue(col).ToString();
                else{
                Boolean _isExpandableNonCompositeForeignKey = col.TableDefinition.IsExpandableNonCompositeForeignKey(col);
                if (_isExpandableNonCompositeForeignKey && col.IsApplyDisplayAs)
                val = Vw_dotmedView.GetDFKA(rec.GetValue(col).ToString(), col, null);
                if( (!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(val)))
                val = exportData.GetDataForExport(col, rec);
                }                
                exportData.WriteColumnData(val, data.IsString(col));
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
        public virtual void CSVButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                    WhereClause wc = null;
                    wc = CreateWhereClause();
                    OrderBy orderBy = null;
                    
                    orderBy = CreateOrderBy();
                    
                BaseColumn[] columns = new BaseColumn[] {
                             Vw_dotmedView.new_category_id,
             Vw_dotmedView.model_id,
             Vw_dotmedView.make_id,
             Vw_dotmedView.dotmed_part_mfg,
             Vw_dotmedView.description,
             Vw_dotmedView.dotmed_part_num,
             Vw_dotmedView.dotmed_part_name,
             Vw_dotmedView.condition_id,
             Vw_dotmedView.dotmed_listing_type,
             Vw_dotmedView.dotmed_request_type,
             Vw_dotmedView.proposed_sale_price,
             Vw_dotmedView.dotmed_d2d_price,
             Vw_dotmedView.dotmed_vts_price,
             Vw_dotmedView.dotmed_currency,
             Vw_dotmedView.dotmed_qty,
             Vw_dotmedView.dotmed_paypal,
             Vw_dotmedView.dotmed_paypal_shipping,
             Vw_dotmedView.dotmed_make_offer,
             Vw_dotmedView.dotmed_auto_accept,
             Vw_dotmedView.dotmed_auto_reject,
             Vw_dotmedView.dotmed_weight,
             Vw_dotmedView.dotmed_weight_units,
             Vw_dotmedView.dotmed_height,
             Vw_dotmedView.dotmed_width,
             Vw_dotmedView.dotmed_depth,
             Vw_dotmedView.dotmed_will_rent,
             Vw_dotmedView.dotmed_avail_parts,
             Vw_dotmedView.dotmed_in_stock,
             Vw_dotmedView.inventory_id,
             Vw_dotmedView.dotmed_item_id_type,
             Vw_dotmedView.dotmed_your_item_id,
             Vw_dotmedView.dotmed_youtube_url,
             Vw_dotmedView.dotmed_video_url,
             Vw_dotmedView.dotmed_listing_id,
             Vw_dotmedView.dotmed_delete,
             Vw_dotmedView.dotmed_spec_name1,
             Vw_dotmedView.dotmed_spec_value1,
             Vw_dotmedView.dotmed_spec_name2,
             Vw_dotmedView.dotmed_spec_value2,
             Vw_dotmedView.dotmed_spec_name3,
             Vw_dotmedView.dotmed_spec_value3,
             Vw_dotmedView.dotmed_spec_name4,
             Vw_dotmedView.dotmed_spec_value4,
             Vw_dotmedView.dotmed_image1,
             Vw_dotmedView.dotmed_image2,
             Vw_dotmedView.dotmed_image3,
             Vw_dotmedView.dotmed_image4,
             Vw_dotmedView.dotmed_image5,
             Vw_dotmedView.dotmed_image6,
             Vw_dotmedView.dotmed_image7,
             Vw_dotmedView.dotmed_image8,
             Vw_dotmedView.dotmed_image9,
             Vw_dotmedView.dotmed_image10,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Vw_dotmedView.Instance,wc,orderBy,columns);
                
                Boolean done = false;

                int totalRowsReturned = 0;
                CompoundFilter join = CreateCompoundJoinFilter();
                DataForExport data = new DataForExport(Vw_dotmedView.Instance, wc, orderBy, columns,join);

                this.TotalRecords = Vw_dotmedView.GetRecordCount(join, wc);
                Boolean exportRawValues = false;
                if (this.TotalRecords > 10000)
                  exportRawValues = true;
                exportData.StartExport(this.Page.Response, exportRawValues);
                
                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = data.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in data.ColumnList)
                {
                if (col == null)
                continue;

                if (!data.IncludeInExport(col))
                continue;

                String val = "";

                if (exportRawValues )
                val = rec.GetValue(col).ToString();
                else{
                Boolean _isExpandableNonCompositeForeignKey = col.TableDefinition.IsExpandableNonCompositeForeignKey(col);
                if (_isExpandableNonCompositeForeignKey && col.IsApplyDisplayAs)
                val = Vw_dotmedView.GetDFKA(rec.GetValue(col).ToString(), col, null);
                if( (!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(val)))
                val = exportData.GetDataForExport(col, rec);
                }                
                exportData.WriteColumnData(val, data.IsString(col));
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


              this.TotalRecords = Vw_dotmedView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             Vw_dotmedView.new_category_id,
             Vw_dotmedView.model_id,
             Vw_dotmedView.make_id,
             Vw_dotmedView.dotmed_part_mfg,
             Vw_dotmedView.description,
             Vw_dotmedView.dotmed_part_num,
             Vw_dotmedView.dotmed_part_name,
             Vw_dotmedView.condition_id,
             Vw_dotmedView.dotmed_listing_type,
             Vw_dotmedView.dotmed_request_type,
             Vw_dotmedView.proposed_sale_price,
             Vw_dotmedView.dotmed_d2d_price,
             Vw_dotmedView.dotmed_vts_price,
             Vw_dotmedView.dotmed_currency,
             Vw_dotmedView.dotmed_qty,
             Vw_dotmedView.dotmed_paypal,
             Vw_dotmedView.dotmed_paypal_shipping,
             Vw_dotmedView.dotmed_make_offer,
             Vw_dotmedView.dotmed_auto_accept,
             Vw_dotmedView.dotmed_auto_reject,
             Vw_dotmedView.dotmed_weight,
             Vw_dotmedView.dotmed_weight_units,
             Vw_dotmedView.dotmed_height,
             Vw_dotmedView.dotmed_width,
             Vw_dotmedView.dotmed_depth,
             Vw_dotmedView.dotmed_will_rent,
             Vw_dotmedView.dotmed_avail_parts,
             Vw_dotmedView.dotmed_in_stock,
             Vw_dotmedView.inventory_id,
             Vw_dotmedView.dotmed_item_id_type,
             Vw_dotmedView.dotmed_your_item_id,
             Vw_dotmedView.dotmed_youtube_url,
             Vw_dotmedView.dotmed_video_url,
             Vw_dotmedView.dotmed_listing_id,
             Vw_dotmedView.dotmed_delete,
             Vw_dotmedView.dotmed_spec_name1,
             Vw_dotmedView.dotmed_spec_value1,
             Vw_dotmedView.dotmed_spec_name2,
             Vw_dotmedView.dotmed_spec_value2,
             Vw_dotmedView.dotmed_spec_name3,
             Vw_dotmedView.dotmed_spec_value3,
             Vw_dotmedView.dotmed_spec_name4,
             Vw_dotmedView.dotmed_spec_value4,
             Vw_dotmedView.dotmed_image1,
             Vw_dotmedView.dotmed_image2,
             Vw_dotmedView.dotmed_image3,
             Vw_dotmedView.dotmed_image4,
             Vw_dotmedView.dotmed_image5,
             Vw_dotmedView.dotmed_image6,
             Vw_dotmedView.dotmed_image7,
             Vw_dotmedView.dotmed_image8,
             Vw_dotmedView.dotmed_image9,
             Vw_dotmedView.dotmed_image10,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(Vw_dotmedView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(Vw_dotmedView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(Vw_dotmedView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(Vw_dotmedView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.new_category_id, "Standard"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.model_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.make_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_part_mfg, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.description, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_part_num, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_part_name, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.condition_id, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_listing_type, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_request_type, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.proposed_sale_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_d2d_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_vts_price, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_currency, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_qty, "0"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_paypal, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_paypal_shipping, "Currency"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_make_offer, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_auto_accept, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_auto_reject, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_weight, "Standard"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_weight_units, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_height, "Standard"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_width, "Standard"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_depth, "Standard"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_will_rent, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_avail_parts, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_in_stock, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.inventory_id, "Standard"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_item_id_type, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_your_item_id, "Standard"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_youtube_url, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_video_url, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_listing_id, "0"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_delete, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_spec_name1, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_spec_value1, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_spec_name2, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_spec_value2, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_spec_name3, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_spec_value3, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_spec_name4, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_spec_value4, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image1, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image2, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image3, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image4, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image5, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image6, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image7, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image8, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image9, "Default"));
             data.ColumnList.Add(new ExcelColumn(Vw_dotmedView.dotmed_image10, "Default"));


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
                val = Vw_dotmedView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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

                report.SpecificReportFileName = Page.Server.MapPath("Show-Vw-dotmed-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_dotmed";
                // If Show-Vw-dotmed-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Vw_dotmedView.new_category_id.Name, ReportEnum.Align.Right, "${new_category_id}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.model_id.Name, ReportEnum.Align.Left, "${model_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.make_id.Name, ReportEnum.Align.Left, "${make_id}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Vw_dotmedView.dotmed_part_mfg.Name, ReportEnum.Align.Left, "${dotmed_part_mfg}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.description.Name, ReportEnum.Align.Left, "${description}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_part_num.Name, ReportEnum.Align.Left, "${dotmed_part_num}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_part_name.Name, ReportEnum.Align.Left, "${dotmed_part_name}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_listing_type.Name, ReportEnum.Align.Left, "${dotmed_listing_type}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_request_type.Name, ReportEnum.Align.Left, "${dotmed_request_type}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.proposed_sale_price.Name, ReportEnum.Align.Right, "${proposed_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_d2d_price.Name, ReportEnum.Align.Right, "${dotmed_d2d_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_vts_price.Name, ReportEnum.Align.Right, "${dotmed_vts_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_currency.Name, ReportEnum.Align.Right, "${dotmed_currency}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_qty.Name, ReportEnum.Align.Right, "${dotmed_qty}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_paypal.Name, ReportEnum.Align.Left, "${dotmed_paypal}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_paypal_shipping.Name, ReportEnum.Align.Right, "${dotmed_paypal_shipping}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_make_offer.Name, ReportEnum.Align.Left, "${dotmed_make_offer}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_auto_accept.Name, ReportEnum.Align.Left, "${dotmed_auto_accept}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_auto_reject.Name, ReportEnum.Align.Left, "${dotmed_auto_reject}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_weight.Name, ReportEnum.Align.Right, "${dotmed_weight}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_weight_units.Name, ReportEnum.Align.Left, "${dotmed_weight_units}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_height.Name, ReportEnum.Align.Right, "${dotmed_height}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_width.Name, ReportEnum.Align.Right, "${dotmed_width}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_depth.Name, ReportEnum.Align.Right, "${dotmed_depth}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_will_rent.Name, ReportEnum.Align.Left, "${dotmed_will_rent}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_avail_parts.Name, ReportEnum.Align.Left, "${dotmed_avail_parts}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_in_stock.Name, ReportEnum.Align.Left, "${dotmed_in_stock}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.inventory_id.Name, ReportEnum.Align.Right, "${inventory_id}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_item_id_type.Name, ReportEnum.Align.Left, "${dotmed_item_id_type}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_your_item_id.Name, ReportEnum.Align.Right, "${dotmed_your_item_id}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_youtube_url.Name, ReportEnum.Align.Left, "${dotmed_youtube_url}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_dotmedView.dotmed_video_url.Name, ReportEnum.Align.Left, "${dotmed_video_url}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_dotmedView.dotmed_listing_id.Name, ReportEnum.Align.Right, "${dotmed_listing_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_delete.Name, ReportEnum.Align.Left, "${dotmed_delete}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_name1.Name, ReportEnum.Align.Left, "${dotmed_spec_name1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_value1.Name, ReportEnum.Align.Left, "${dotmed_spec_value1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_name2.Name, ReportEnum.Align.Left, "${dotmed_spec_name2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_value2.Name, ReportEnum.Align.Left, "${dotmed_spec_value2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_name3.Name, ReportEnum.Align.Left, "${dotmed_spec_name3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_value3.Name, ReportEnum.Align.Left, "${dotmed_spec_value3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_name4.Name, ReportEnum.Align.Left, "${dotmed_spec_name4}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_value4.Name, ReportEnum.Align.Left, "${dotmed_spec_value4}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image1.Name, ReportEnum.Align.Left, "${dotmed_image1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image2.Name, ReportEnum.Align.Left, "${dotmed_image2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image3.Name, ReportEnum.Align.Left, "${dotmed_image3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image4.Name, ReportEnum.Align.Left, "${dotmed_image4}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image5.Name, ReportEnum.Align.Left, "${dotmed_image5}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image6.Name, ReportEnum.Align.Left, "${dotmed_image6}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image7.Name, ReportEnum.Align.Left, "${dotmed_image7}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image8.Name, ReportEnum.Align.Left, "${dotmed_image8}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image9.Name, ReportEnum.Align.Left, "${dotmed_image9}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image10.Name, ReportEnum.Align.Left, "${dotmed_image10}", ReportEnum.Align.Left, 28);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = Vw_dotmedView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = Vw_dotmedView.GetRecordCount(joinFilter,whereClause);
                Vw_dotmedRecord[] records = null;
                
                do
                {
                    
                    records = Vw_dotmedView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Vw_dotmedRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${new_category_id}", record.Format(Vw_dotmedView.new_category_id), ReportEnum.Align.Right, 300);
                             report.AddData("${model_id}", record.Format(Vw_dotmedView.model_id), ReportEnum.Align.Left, 300);
                             report.AddData("${make_id}", record.Format(Vw_dotmedView.make_id), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_part_mfg}", record.Format(Vw_dotmedView.dotmed_part_mfg), ReportEnum.Align.Left, 300);
                             report.AddData("${description}", record.Format(Vw_dotmedView.description), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_part_num}", record.Format(Vw_dotmedView.dotmed_part_num), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_part_name}", record.Format(Vw_dotmedView.dotmed_part_name), ReportEnum.Align.Left, 300);
                             report.AddData("${condition_id}", record.Format(Vw_dotmedView.condition_id), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_listing_type}", record.Format(Vw_dotmedView.dotmed_listing_type), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_request_type}", record.Format(Vw_dotmedView.dotmed_request_type), ReportEnum.Align.Left, 300);
                             report.AddData("${proposed_sale_price}", record.Format(Vw_dotmedView.proposed_sale_price), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_d2d_price}", record.Format(Vw_dotmedView.dotmed_d2d_price), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_vts_price}", record.Format(Vw_dotmedView.dotmed_vts_price), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_currency}", record.Format(Vw_dotmedView.dotmed_currency), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_qty}", record.Format(Vw_dotmedView.dotmed_qty), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_paypal}", record.Format(Vw_dotmedView.dotmed_paypal), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_paypal_shipping}", record.Format(Vw_dotmedView.dotmed_paypal_shipping), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_make_offer}", record.Format(Vw_dotmedView.dotmed_make_offer), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_auto_accept}", record.Format(Vw_dotmedView.dotmed_auto_accept), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_auto_reject}", record.Format(Vw_dotmedView.dotmed_auto_reject), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_weight}", record.Format(Vw_dotmedView.dotmed_weight), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_weight_units}", record.Format(Vw_dotmedView.dotmed_weight_units), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_height}", record.Format(Vw_dotmedView.dotmed_height), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_width}", record.Format(Vw_dotmedView.dotmed_width), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_depth}", record.Format(Vw_dotmedView.dotmed_depth), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_will_rent}", record.Format(Vw_dotmedView.dotmed_will_rent), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_avail_parts}", record.Format(Vw_dotmedView.dotmed_avail_parts), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_in_stock}", record.Format(Vw_dotmedView.dotmed_in_stock), ReportEnum.Align.Left, 300);
                             report.AddData("${inventory_id}", record.Format(Vw_dotmedView.inventory_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_item_id_type}", record.Format(Vw_dotmedView.dotmed_item_id_type), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_your_item_id}", record.Format(Vw_dotmedView.dotmed_your_item_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_youtube_url}", record.Format(Vw_dotmedView.dotmed_youtube_url), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_video_url}", record.Format(Vw_dotmedView.dotmed_video_url), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_listing_id}", record.Format(Vw_dotmedView.dotmed_listing_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_delete}", record.Format(Vw_dotmedView.dotmed_delete), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_name1}", record.Format(Vw_dotmedView.dotmed_spec_name1), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_value1}", record.Format(Vw_dotmedView.dotmed_spec_value1), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_name2}", record.Format(Vw_dotmedView.dotmed_spec_name2), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_value2}", record.Format(Vw_dotmedView.dotmed_spec_value2), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_name3}", record.Format(Vw_dotmedView.dotmed_spec_name3), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_value3}", record.Format(Vw_dotmedView.dotmed_spec_value3), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_name4}", record.Format(Vw_dotmedView.dotmed_spec_name4), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_value4}", record.Format(Vw_dotmedView.dotmed_spec_value4), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image1}", record.Format(Vw_dotmedView.dotmed_image1), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image2}", record.Format(Vw_dotmedView.dotmed_image2), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image3}", record.Format(Vw_dotmedView.dotmed_image3), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image4}", record.Format(Vw_dotmedView.dotmed_image4), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image5}", record.Format(Vw_dotmedView.dotmed_image5), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image6}", record.Format(Vw_dotmedView.dotmed_image6), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image7}", record.Format(Vw_dotmedView.dotmed_image7), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image8}", record.Format(Vw_dotmedView.dotmed_image8), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image9}", record.Format(Vw_dotmedView.dotmed_image9), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image10}", record.Format(Vw_dotmedView.dotmed_image10), ReportEnum.Align.Left, 300);

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
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-Vw-dotmed-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_dotmed";
                // If Show-Vw-dotmed-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(Vw_dotmedView.new_category_id.Name, ReportEnum.Align.Right, "${new_category_id}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.model_id.Name, ReportEnum.Align.Left, "${model_id}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.make_id.Name, ReportEnum.Align.Left, "${make_id}", ReportEnum.Align.Left, 24);
                 report.AddColumn(Vw_dotmedView.dotmed_part_mfg.Name, ReportEnum.Align.Left, "${dotmed_part_mfg}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.description.Name, ReportEnum.Align.Left, "${description}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_part_num.Name, ReportEnum.Align.Left, "${dotmed_part_num}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_part_name.Name, ReportEnum.Align.Left, "${dotmed_part_name}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.condition_id.Name, ReportEnum.Align.Left, "${condition_id}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_listing_type.Name, ReportEnum.Align.Left, "${dotmed_listing_type}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_request_type.Name, ReportEnum.Align.Left, "${dotmed_request_type}", ReportEnum.Align.Left, 20);
                 report.AddColumn(Vw_dotmedView.proposed_sale_price.Name, ReportEnum.Align.Right, "${proposed_sale_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_d2d_price.Name, ReportEnum.Align.Right, "${dotmed_d2d_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_vts_price.Name, ReportEnum.Align.Right, "${dotmed_vts_price}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_currency.Name, ReportEnum.Align.Right, "${dotmed_currency}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_qty.Name, ReportEnum.Align.Right, "${dotmed_qty}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_paypal.Name, ReportEnum.Align.Left, "${dotmed_paypal}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_paypal_shipping.Name, ReportEnum.Align.Right, "${dotmed_paypal_shipping}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_make_offer.Name, ReportEnum.Align.Left, "${dotmed_make_offer}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_auto_accept.Name, ReportEnum.Align.Left, "${dotmed_auto_accept}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_auto_reject.Name, ReportEnum.Align.Left, "${dotmed_auto_reject}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_weight.Name, ReportEnum.Align.Right, "${dotmed_weight}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_weight_units.Name, ReportEnum.Align.Left, "${dotmed_weight_units}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_height.Name, ReportEnum.Align.Right, "${dotmed_height}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_width.Name, ReportEnum.Align.Right, "${dotmed_width}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_depth.Name, ReportEnum.Align.Right, "${dotmed_depth}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_will_rent.Name, ReportEnum.Align.Left, "${dotmed_will_rent}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_avail_parts.Name, ReportEnum.Align.Left, "${dotmed_avail_parts}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_in_stock.Name, ReportEnum.Align.Left, "${dotmed_in_stock}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.inventory_id.Name, ReportEnum.Align.Right, "${inventory_id}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_item_id_type.Name, ReportEnum.Align.Left, "${dotmed_item_id_type}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_your_item_id.Name, ReportEnum.Align.Right, "${dotmed_your_item_id}", ReportEnum.Align.Right, 20);
                 report.AddColumn(Vw_dotmedView.dotmed_youtube_url.Name, ReportEnum.Align.Left, "${dotmed_youtube_url}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_dotmedView.dotmed_video_url.Name, ReportEnum.Align.Left, "${dotmed_video_url}", ReportEnum.Align.Left, 30);
                 report.AddColumn(Vw_dotmedView.dotmed_listing_id.Name, ReportEnum.Align.Right, "${dotmed_listing_id}", ReportEnum.Align.Right, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_delete.Name, ReportEnum.Align.Left, "${dotmed_delete}", ReportEnum.Align.Left, 15);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_name1.Name, ReportEnum.Align.Left, "${dotmed_spec_name1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_value1.Name, ReportEnum.Align.Left, "${dotmed_spec_value1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_name2.Name, ReportEnum.Align.Left, "${dotmed_spec_name2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_value2.Name, ReportEnum.Align.Left, "${dotmed_spec_value2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_name3.Name, ReportEnum.Align.Left, "${dotmed_spec_name3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_value3.Name, ReportEnum.Align.Left, "${dotmed_spec_value3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_name4.Name, ReportEnum.Align.Left, "${dotmed_spec_name4}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_spec_value4.Name, ReportEnum.Align.Left, "${dotmed_spec_value4}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image1.Name, ReportEnum.Align.Left, "${dotmed_image1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image2.Name, ReportEnum.Align.Left, "${dotmed_image2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image3.Name, ReportEnum.Align.Left, "${dotmed_image3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image4.Name, ReportEnum.Align.Left, "${dotmed_image4}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image5.Name, ReportEnum.Align.Left, "${dotmed_image5}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image6.Name, ReportEnum.Align.Left, "${dotmed_image6}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image7.Name, ReportEnum.Align.Left, "${dotmed_image7}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image8.Name, ReportEnum.Align.Left, "${dotmed_image8}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image9.Name, ReportEnum.Align.Left, "${dotmed_image9}", ReportEnum.Align.Left, 28);
                 report.AddColumn(Vw_dotmedView.dotmed_image10.Name, ReportEnum.Align.Left, "${dotmed_image10}", ReportEnum.Align.Left, 28);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = Vw_dotmedView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "OEMConversion");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = Vw_dotmedView.GetColumnList();
                Vw_dotmedRecord[] records = null;
                do
                {
                    records = Vw_dotmedView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( Vw_dotmedRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${new_category_id}", record.Format(Vw_dotmedView.new_category_id), ReportEnum.Align.Right, 300);
                             report.AddData("${model_id}", record.Format(Vw_dotmedView.model_id), ReportEnum.Align.Left, 300);
                             report.AddData("${make_id}", record.Format(Vw_dotmedView.make_id), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_part_mfg}", record.Format(Vw_dotmedView.dotmed_part_mfg), ReportEnum.Align.Left, 300);
                             report.AddData("${description}", record.Format(Vw_dotmedView.description), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_part_num}", record.Format(Vw_dotmedView.dotmed_part_num), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_part_name}", record.Format(Vw_dotmedView.dotmed_part_name), ReportEnum.Align.Left, 300);
                             report.AddData("${condition_id}", record.Format(Vw_dotmedView.condition_id), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_listing_type}", record.Format(Vw_dotmedView.dotmed_listing_type), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_request_type}", record.Format(Vw_dotmedView.dotmed_request_type), ReportEnum.Align.Left, 300);
                             report.AddData("${proposed_sale_price}", record.Format(Vw_dotmedView.proposed_sale_price), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_d2d_price}", record.Format(Vw_dotmedView.dotmed_d2d_price), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_vts_price}", record.Format(Vw_dotmedView.dotmed_vts_price), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_currency}", record.Format(Vw_dotmedView.dotmed_currency), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_qty}", record.Format(Vw_dotmedView.dotmed_qty), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_paypal}", record.Format(Vw_dotmedView.dotmed_paypal), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_paypal_shipping}", record.Format(Vw_dotmedView.dotmed_paypal_shipping), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_make_offer}", record.Format(Vw_dotmedView.dotmed_make_offer), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_auto_accept}", record.Format(Vw_dotmedView.dotmed_auto_accept), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_auto_reject}", record.Format(Vw_dotmedView.dotmed_auto_reject), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_weight}", record.Format(Vw_dotmedView.dotmed_weight), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_weight_units}", record.Format(Vw_dotmedView.dotmed_weight_units), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_height}", record.Format(Vw_dotmedView.dotmed_height), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_width}", record.Format(Vw_dotmedView.dotmed_width), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_depth}", record.Format(Vw_dotmedView.dotmed_depth), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_will_rent}", record.Format(Vw_dotmedView.dotmed_will_rent), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_avail_parts}", record.Format(Vw_dotmedView.dotmed_avail_parts), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_in_stock}", record.Format(Vw_dotmedView.dotmed_in_stock), ReportEnum.Align.Left, 300);
                             report.AddData("${inventory_id}", record.Format(Vw_dotmedView.inventory_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_item_id_type}", record.Format(Vw_dotmedView.dotmed_item_id_type), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_your_item_id}", record.Format(Vw_dotmedView.dotmed_your_item_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_youtube_url}", record.Format(Vw_dotmedView.dotmed_youtube_url), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_video_url}", record.Format(Vw_dotmedView.dotmed_video_url), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_listing_id}", record.Format(Vw_dotmedView.dotmed_listing_id), ReportEnum.Align.Right, 300);
                             report.AddData("${dotmed_delete}", record.Format(Vw_dotmedView.dotmed_delete), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_name1}", record.Format(Vw_dotmedView.dotmed_spec_name1), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_value1}", record.Format(Vw_dotmedView.dotmed_spec_value1), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_name2}", record.Format(Vw_dotmedView.dotmed_spec_name2), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_value2}", record.Format(Vw_dotmedView.dotmed_spec_value2), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_name3}", record.Format(Vw_dotmedView.dotmed_spec_name3), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_value3}", record.Format(Vw_dotmedView.dotmed_spec_value3), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_name4}", record.Format(Vw_dotmedView.dotmed_spec_name4), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_spec_value4}", record.Format(Vw_dotmedView.dotmed_spec_value4), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image1}", record.Format(Vw_dotmedView.dotmed_image1), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image2}", record.Format(Vw_dotmedView.dotmed_image2), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image3}", record.Format(Vw_dotmedView.dotmed_image3), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image4}", record.Format(Vw_dotmedView.dotmed_image4), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image5}", record.Format(Vw_dotmedView.dotmed_image5), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image6}", record.Format(Vw_dotmedView.dotmed_image6), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image7}", record.Format(Vw_dotmedView.dotmed_image7), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image8}", record.Format(Vw_dotmedView.dotmed_image8), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image9}", record.Format(Vw_dotmedView.dotmed_image9), ReportEnum.Align.Left, 300);
                             report.AddData("${dotmed_image10}", record.Format(Vw_dotmedView.dotmed_image10), ReportEnum.Align.Left, 300);

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
            
            
        


        // Generate the event handling functions for filter and search events.
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = Vw_dotmedView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Vw_dotmedRecord[] DataSource {
             
            get {
                return (Vw_dotmedRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton CSVButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CSVButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton CSVButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CSVButton1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton dotmed_deleteLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_deleteLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton dotmed_listing_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_listing_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal HTMLText {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HTMLText");
            }
        }
        
        public System.Web.UI.WebControls.Image Image {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Image");
            }
        }
        
        public System.Web.UI.WebControls.Literal inventory_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "inventory_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton make_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "make_idLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton model_idLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "model_idLabel");
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
        
        public System.Web.UI.WebControls.LinkButton proposed_sale_priceLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "proposed_sale_priceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title1");
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
                Vw_dotmedTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Vw_dotmedRecord rec = null;
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
                Vw_dotmedTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        Vw_dotmedRecord rec = null;
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
          
        public virtual Vw_dotmedTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual Vw_dotmedTableControlRow[] GetSelectedRecordControls()
        {
        
            return (Vw_dotmedTableControlRow[])((new ArrayList()).ToArray(Type.GetType("OEMConversion.UI.Controls.Show_Vw_dotmed_Table.Vw_dotmedTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Vw_dotmedTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (Vw_dotmedTableControlRow recCtl in recordList)
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

        public virtual Vw_dotmedTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Vw_dotmedTableControlRow");
	          List<Vw_dotmedTableControlRow> list = new List<Vw_dotmedTableControlRow>();
	          foreach (Vw_dotmedTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the Equipment_inventory_dotmedRecordControl control on the Show_Vw_dotmed_Table page.
// Do not modify this class. Instead override any method in Equipment_inventory_dotmedRecordControl.
public class BaseEquipment_inventory_dotmedRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseEquipment_inventory_dotmedRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Equipment_inventory_dotmedRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in Equipment_inventory_dotmedRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.Button.Button.Click += Button_Click;
                        
              this.dotmed_processed.CheckedChanged += dotmed_processed_CheckedChanged;
            
              this.dotmed_item_id.TextChanged += dotmed_item_id_TextChanged;
            
              this.listing_id.TextChanged += listing_id_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Equipment_inventory_dotmedTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_inventory_dotmedRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new Equipment_inventory_dotmedRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            Equipment_inventory_dotmedRecord[] recList = Equipment_inventory_dotmedTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = Equipment_inventory_dotmedTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                
                Setdotmed_item_id();
                Setdotmed_processed();
                Setlisting_id();
                SetButton();
              

      

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
        
        
        public virtual void Setdotmed_item_id()
        {
            
                    
            // Set the dotmed_item_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_item_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_item_idSpecified) {
                								
                // If the dotmed_item_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_dotmedTable.dotmed_item_id);
                                
                this.dotmed_item_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // dotmed_item_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.dotmed_item_id.Text = Equipment_inventory_dotmedTable.dotmed_item_id.Format(Equipment_inventory_dotmedTable.dotmed_item_id.DefaultValue);
            		
            }
            
              this.dotmed_item_id.TextChanged += dotmed_item_id_TextChanged;
                               
        }
                
        public virtual void Setdotmed_processed()
        {
            
                    
            // Set the dotmed_processed CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.dotmed_processed is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.dotmed_processedSpecified) {
                							
                // If the dotmed_processed is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.dotmed_processed.Checked = this.DataSource.dotmed_processed;
                    				
            } else {
            
                // dotmed_processed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.dotmed_processed.Checked = Equipment_inventory_dotmedTable.dotmed_processed.ParseValue(Equipment_inventory_dotmedTable.dotmed_processed.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void Setlisting_id()
        {
            
                    
            // Set the listing_id TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.equipment_inventory_dotmed database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record retrieved from the database.
            // this.listing_id is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.listing_idSpecified) {
                								
                // If the listing_id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(Equipment_inventory_dotmedTable.listing_id);
                                
                this.listing_id.Text = formattedValue;
                   
            } 
            
            else {
            
                // listing_id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.listing_id.Text = Equipment_inventory_dotmedTable.listing_id.Format(Equipment_inventory_dotmedTable.listing_id.DefaultValue);
            		
            }
            
              this.listing_id.TextChanged += listing_id_TextChanged;
                               
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "Equipment_inventory_dotmedRecordControlPanel");
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
        
            Getdotmed_item_id();
            Getdotmed_processed();
            Getlisting_id();
        }
        
        
        public virtual void Getdotmed_item_id()
        {
            
            // Retrieve the value entered by the user on the dotmed_item_id ASP:TextBox, and
            // save it into the dotmed_item_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.dotmed_item_id.Text, Equipment_inventory_dotmedTable.dotmed_item_id);							
                          
                      
        }
                
        public virtual void Getdotmed_processed()
        {	
        		
            // Retrieve the value entered by the user on the dotmed_processed ASP:CheckBox, and
            // save it into the dotmed_processed field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            // Custom validation should be performed in Validate, not here.
            
            if (StringUtils.InvariantLCase(EvaluateFormula("\"True\"")).Equals("true"))
                this.DataSource.dotmed_processed = true;
            else
                this.DataSource.dotmed_processed = false;
                        
                    
        }
                
        public virtual void Getlisting_id()
        {
            
            // Retrieve the value entered by the user on the listing_id ASP:TextBox, and
            // save it into the listing_id field in DataSource DatabaseAYS_OEM%dbo.equipment_inventory_dotmed record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.listing_id.Text, Equipment_inventory_dotmedTable.listing_id);							
                          
                      
        }
                

      // To customize, override this method in Equipment_inventory_dotmedRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEquipment_inventory_dotmedRecordControl = false;
            hasFiltersEquipment_inventory_dotmedRecordControl = hasFiltersEquipment_inventory_dotmedRecordControl && false; // suppress warning
      
            bool hasFiltersVw_dotmedTableControl = false;
            hasFiltersVw_dotmedTableControl = hasFiltersVw_dotmedTableControl && false; // suppress warning
      
            WhereClause wc;
            Equipment_inventory_dotmedTable.Instance.InnerFilter = null;
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
            
            if (EvaluateFormula("URL(\"equipment_inventory_dotmed\")", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"OEMConversion.Business.Equipment_inventory_dotmedTable, App_Code").TableDefinition.ColumnList.GetByUniqueName(@"equipment_inventory_dotmed_.inventory_id"), EvaluateFormula("URL(\"equipment_inventory_dotmed\")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("URL(\"equipment_inventory_dotmed\")", false) == "--PLEASE_SELECT--" || EvaluateFormula("URL(\"equipment_inventory_dotmed\")", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Equipment_inventory_dotmedTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEquipment_inventory_dotmedRecordControl = false;
            hasFiltersEquipment_inventory_dotmedRecordControl = hasFiltersEquipment_inventory_dotmedRecordControl && false; // suppress warning
      
            bool hasFiltersVw_dotmedTableControl = false;
            hasFiltersVw_dotmedTableControl = hasFiltersVw_dotmedTableControl && false; // suppress warning
      
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
          Equipment_inventory_dotmedTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetButton()                
              
        {
        
                    this.Button.Button.Attributes.Add("onclick", "SubmitHRefOnce(this, \"" + this.Page.GetResourceValue("Txt:SaveRecord", "OEMConversion") + "\");");
                  
   
        }
            
        // event handler for Button
        public virtual void Button_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../equipment_inventory/Show-Equipment-inventory-Table.aspx";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"])) 
                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        protected virtual void dotmed_processed_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void dotmed_item_id_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void listing_id_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseEquipment_inventory_dotmedRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEquipment_inventory_dotmedRecordControl_Rec"] = value;
            }
        }
        
        public Equipment_inventory_dotmedRecord DataSource {
            get {
                return (Equipment_inventory_dotmedRecord)(this._DataSource);
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
        
        public OEMConversion.UI.IThemeButton Button {
            get {
                return (OEMConversion.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Button");
            }
        }
        
        public System.Web.UI.WebControls.TextBox dotmed_item_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_item_id");
            }
        }
            
        public System.Web.UI.WebControls.CheckBox dotmed_processed {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "dotmed_processed");
            }
        }
            
        public System.Web.UI.WebControls.TextBox listing_id {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "listing_id");
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
        Equipment_inventory_dotmedRecord rec = null;
             
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
    Equipment_inventory_dotmedRecord rec = null;
    
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

        
        public virtual Equipment_inventory_dotmedRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Equipment_inventory_dotmedTable.GetRecord(this.RecordUniqueId, true);
              
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

  