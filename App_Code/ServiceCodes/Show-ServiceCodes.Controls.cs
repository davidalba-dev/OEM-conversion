
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_ServiceCodes.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_ServiceCodes
{
  

#region "Section 1: Place your customizations here."

    
public class ServiceCodesRecordControl : BaseServiceCodesRecordControl
{
      
        // The BaseServiceCodesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the ServiceCodesRecordControl control on the Show_ServiceCodes page.
// Do not modify this class. Instead override any method in ServiceCodesRecordControl.
public class BaseServiceCodesRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseServiceCodesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in ServiceCodesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in ServiceCodesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.DialogEditButton.Click += DialogEditButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.ServiceCodes record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = ServiceCodesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "ServiceCodesRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new ServiceCodesRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            ServiceCodesRecord[] recList = ServiceCodesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = ServiceCodesTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                
                SetServCategory();
                SetServCategoryLabel();
                SetServCharge();
                SetServChargeLabel();
                SetServCode();
                SetServCodeGroup();
                SetServCodeGroupLabel();
                SetServCodeLabel();
                SetServDateRecordAdded();
                SetServDateRecordAddedLabel();
                SetServDefault();
                SetServDefaultLabel();
                SetServDesc();
                SetServDescLabel();
                SetServDropdown();
                SetServDropdownLabel();
                SetServNotes();
                SetServNotesLabel();
                SetServQBItemCode();
                SetServQBItemCodeLabel();
                SetServReference1();
                SetServReference1Label();
                SetServReference2();
                SetServReference2Label();
                SetServReference3();
                SetServReference3Label();
                SetServReference4();
                SetServReference4Label();
                SetServRepairStep();
                SetServRepairStepLabel();
                SetServType();
                SetServTypeLabel();
                
                SetDialogEditButton();
              

      

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
        
        
        public virtual void SetServCategory()
        {
            
                    
            // Set the ServCategory Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServCategory is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServCategorySpecified) {
                								
                // If the ServCategory is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServCategory);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServCategory.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServCategory is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServCategory.Text = ServiceCodesTable.ServCategory.Format(ServiceCodesTable.ServCategory.DefaultValue);
            		
            }
            
            // If the ServCategory is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServCategory.Text == null ||
                this.ServCategory.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServCategory.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServCharge()
        {
            
                    
            // Set the ServCharge Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServCharge is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServChargeSpecified) {
                								
                // If the ServCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServCharge, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServCharge.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServCharge.Text = ServiceCodesTable.ServCharge.Format(ServiceCodesTable.ServCharge.DefaultValue, @"C");
            		
            }
            
            // If the ServCharge is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServCharge.Text == null ||
                this.ServCharge.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServCharge.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServCode()
        {
            
                    
            // Set the ServCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServCodeSpecified) {
                								
                // If the ServCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServCode.Text = ServiceCodesTable.ServCode.Format(ServiceCodesTable.ServCode.DefaultValue);
            		
            }
            
            // If the ServCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServCode.Text == null ||
                this.ServCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServCodeGroup()
        {
            
                    
            // Set the ServCodeGroup Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServCodeGroup is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServCodeGroupSpecified) {
                								
                // If the ServCodeGroup is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServCodeGroup);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServCodeGroup.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServCodeGroup is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServCodeGroup.Text = ServiceCodesTable.ServCodeGroup.Format(ServiceCodesTable.ServCodeGroup.DefaultValue);
            		
            }
            
            // If the ServCodeGroup is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServCodeGroup.Text == null ||
                this.ServCodeGroup.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServCodeGroup.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServDateRecordAdded()
        {
            
                    
            // Set the ServDateRecordAdded Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServDateRecordAdded is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServDateRecordAddedSpecified) {
                								
                // If the ServDateRecordAdded is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServDateRecordAdded, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServDateRecordAdded.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServDateRecordAdded is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServDateRecordAdded.Text = ServiceCodesTable.ServDateRecordAdded.Format(ServiceCodesTable.ServDateRecordAdded.DefaultValue, @"g");
            		
            }
            
            // If the ServDateRecordAdded is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServDateRecordAdded.Text == null ||
                this.ServDateRecordAdded.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServDateRecordAdded.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServDefault()
        {
            
                    
            // Set the ServDefault Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServDefault is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServDefaultSpecified) {
                								
                // If the ServDefault is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServDefault);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServDefault.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServDefault is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServDefault.Text = ServiceCodesTable.ServDefault.Format(ServiceCodesTable.ServDefault.DefaultValue);
            		
            }
            
            // If the ServDefault is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServDefault.Text == null ||
                this.ServDefault.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServDefault.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServDesc()
        {
            
                    
            // Set the ServDesc Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServDesc is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServDescSpecified) {
                								
                // If the ServDesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServDesc);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServDesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServDesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServDesc.Text = ServiceCodesTable.ServDesc.Format(ServiceCodesTable.ServDesc.DefaultValue);
            		
            }
            
            // If the ServDesc is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServDesc.Text == null ||
                this.ServDesc.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServDesc.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServDropdown()
        {
            
                    
            // Set the ServDropdown Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServDropdown is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServDropdownSpecified) {
                								
                // If the ServDropdown is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServDropdown);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(ServiceCodesTable.ServDropdown.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.ServiceCodesTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"ServDropdown\\\", \\\"ServDropdown\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.ServDropdown.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServDropdown is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServDropdown.Text = ServiceCodesTable.ServDropdown.Format(ServiceCodesTable.ServDropdown.DefaultValue);
            		
            }
            
            // If the ServDropdown is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServDropdown.Text == null ||
                this.ServDropdown.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServDropdown.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServNotes()
        {
            
                    
            // Set the ServNotes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServNotes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServNotesSpecified) {
                								
                // If the ServNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServNotes);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(ServiceCodesTable.ServNotes.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.ServiceCodesTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"ServNotes\\\", \\\"ServNotes\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.ServNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServNotes.Text = ServiceCodesTable.ServNotes.Format(ServiceCodesTable.ServNotes.DefaultValue);
            		
            }
            
            // If the ServNotes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServNotes.Text == null ||
                this.ServNotes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServNotes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServQBItemCode()
        {
            
                    
            // Set the ServQBItemCode Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServQBItemCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServQBItemCodeSpecified) {
                								
                // If the ServQBItemCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServQBItemCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServQBItemCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServQBItemCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServQBItemCode.Text = ServiceCodesTable.ServQBItemCode.Format(ServiceCodesTable.ServQBItemCode.DefaultValue);
            		
            }
            
            // If the ServQBItemCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServQBItemCode.Text == null ||
                this.ServQBItemCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServQBItemCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServReference1()
        {
            
                    
            // Set the ServReference1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServReference1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServReference1Specified) {
                								
                // If the ServReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServReference1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServReference1.Text = ServiceCodesTable.ServReference1.Format(ServiceCodesTable.ServReference1.DefaultValue);
            		
            }
            
            // If the ServReference1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServReference1.Text == null ||
                this.ServReference1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServReference1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServReference2()
        {
            
                    
            // Set the ServReference2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServReference2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServReference2Specified) {
                								
                // If the ServReference2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServReference2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServReference2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServReference2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServReference2.Text = ServiceCodesTable.ServReference2.Format(ServiceCodesTable.ServReference2.DefaultValue);
            		
            }
            
            // If the ServReference2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServReference2.Text == null ||
                this.ServReference2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServReference2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServReference3()
        {
            
                    
            // Set the ServReference3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServReference3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServReference3Specified) {
                								
                // If the ServReference3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServReference3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServReference3.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServReference3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServReference3.Text = ServiceCodesTable.ServReference3.Format(ServiceCodesTable.ServReference3.DefaultValue);
            		
            }
            
            // If the ServReference3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServReference3.Text == null ||
                this.ServReference3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServReference3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServReference4()
        {
            
                    
            // Set the ServReference4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServReference4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServReference4Specified) {
                								
                // If the ServReference4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServReference4);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServReference4.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServReference4.Text = ServiceCodesTable.ServReference4.Format(ServiceCodesTable.ServReference4.DefaultValue);
            		
            }
            
            // If the ServReference4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServReference4.Text == null ||
                this.ServReference4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServReference4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServRepairStep()
        {
            
                    
            // Set the ServRepairStep Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServRepairStep is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServRepairStepSpecified) {
                								
                // If the ServRepairStep is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServRepairStep);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServRepairStep.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServRepairStep is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServRepairStep.Text = ServiceCodesTable.ServRepairStep.Format(ServiceCodesTable.ServRepairStep.DefaultValue);
            		
            }
            
            // If the ServRepairStep is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServRepairStep.Text == null ||
                this.ServRepairStep.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServRepairStep.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServType()
        {
            
                    
            // Set the ServType Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.ServiceCodes database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.ServiceCodes record retrieved from the database.
            // this.ServType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServTypeSpecified) {
                								
                // If the ServType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceCodesTable.ServType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServType.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServType.Text = ServiceCodesTable.ServType.Format(ServiceCodesTable.ServType.DefaultValue);
            		
            }
            
            // If the ServType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServType.Text == null ||
                this.ServType.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServType.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServCategoryLabel()
                  {
                  
                        this.ServCategoryLabel.Text = EvaluateFormula("\"Service Category\"");
                      
                    
        }
                
        public virtual void SetServChargeLabel()
                  {
                  
                        this.ServChargeLabel.Text = EvaluateFormula("\"Service Charge\"");
                      
                    
        }
                
        public virtual void SetServCodeGroupLabel()
                  {
                  
                        this.ServCodeGroupLabel.Text = EvaluateFormula("\"Service Code Group\"");
                      
                    
        }
                
        public virtual void SetServCodeLabel()
                  {
                  
                        this.ServCodeLabel.Text = EvaluateFormula("\"Service Code\"");
                      
                    
        }
                
        public virtual void SetServDateRecordAddedLabel()
                  {
                  
                        this.ServDateRecordAddedLabel.Text = EvaluateFormula("\"Date Record Added\"");
                      
                    
        }
                
        public virtual void SetServDefaultLabel()
                  {
                  
                        this.ServDefaultLabel.Text = EvaluateFormula("\"Service Default\"");
                      
                    
        }
                
        public virtual void SetServDescLabel()
                  {
                  
                        this.ServDescLabel.Text = EvaluateFormula("\"Service Description\"");
                      
                    
        }
                
        public virtual void SetServDropdownLabel()
                  {
                  
                    
        }
                
        public virtual void SetServNotesLabel()
                  {
                  
                        this.ServNotesLabel.Text = EvaluateFormula("\"Service Notes\"");
                      
                    
        }
                
        public virtual void SetServQBItemCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetServReference1Label()
                  {
                  
                    
        }
                
        public virtual void SetServReference2Label()
                  {
                  
                    
        }
                
        public virtual void SetServReference3Label()
                  {
                  
                    
        }
                
        public virtual void SetServReference4Label()
                  {
                  
                    
        }
                
        public virtual void SetServRepairStepLabel()
                  {
                  
                    
        }
                
        public virtual void SetServTypeLabel()
                  {
                  
                        this.ServTypeLabel.Text = EvaluateFormula("\"Service Type\"");
                      
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "ServiceCodesRecordControlPanel");
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
        
            GetServCategory();
            GetServCharge();
            GetServCode();
            GetServCodeGroup();
            GetServDateRecordAdded();
            GetServDefault();
            GetServDesc();
            GetServDropdown();
            GetServNotes();
            GetServQBItemCode();
            GetServReference1();
            GetServReference2();
            GetServReference3();
            GetServReference4();
            GetServRepairStep();
            GetServType();
        }
        
        
        public virtual void GetServCategory()
        {
            
        }
                
        public virtual void GetServCharge()
        {
            
        }
                
        public virtual void GetServCode()
        {
            
        }
                
        public virtual void GetServCodeGroup()
        {
            
        }
                
        public virtual void GetServDateRecordAdded()
        {
            
        }
                
        public virtual void GetServDefault()
        {
            
        }
                
        public virtual void GetServDesc()
        {
            
        }
                
        public virtual void GetServDropdown()
        {
            
        }
                
        public virtual void GetServNotes()
        {
            
        }
                
        public virtual void GetServQBItemCode()
        {
            
        }
                
        public virtual void GetServReference1()
        {
            
        }
                
        public virtual void GetServReference2()
        {
            
        }
                
        public virtual void GetServReference3()
        {
            
        }
                
        public virtual void GetServReference4()
        {
            
        }
                
        public virtual void GetServRepairStep()
        {
            
        }
                
        public virtual void GetServType()
        {
            
        }
                

      // To customize, override this method in ServiceCodesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersServiceCodesRecordControl = false;
            hasFiltersServiceCodesRecordControl = hasFiltersServiceCodesRecordControl && false; // suppress warning
      
            WhereClause wc;
            ServiceCodesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["ServiceCodes"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "ServiceCodes"));
            }
            HttpContext.Current.Session["QueryString in Show-ServiceCodes"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(ServiceCodesTable.ServKey, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(ServiceCodesTable.ServKey));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(ServiceCodesTable.ServKey, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            ServiceCodesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersServiceCodesRecordControl = false;
            hasFiltersServiceCodesRecordControl = hasFiltersServiceCodesRecordControl && false; // suppress warning
      
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
          ServiceCodesTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetDialogEditButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DialogEditButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../ServiceCodes/Edit-ServiceCodes.aspx?ServiceCodes={PK}";
            
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
                return (string)this.ViewState["BaseServiceCodesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseServiceCodesRecordControl_Rec"] = value;
            }
        }
        
        public ServiceCodesRecord DataSource {
            get {
                return (ServiceCodesRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton DialogEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DialogEditButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServCategory {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCategory");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServCategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCategoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServCharge {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCharge");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServChargeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServChargeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServCodeGroup {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCodeGroup");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServCodeGroupLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCodeGroupLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServDateRecordAdded {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDateRecordAdded");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServDateRecordAddedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDateRecordAddedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServDefault {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDefault");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServDefaultLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDefaultLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServDesc {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServDescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDescLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServDropdown {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDropdown");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServDropdownLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServDropdownLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServNotes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServQBItemCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServQBItemCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServQBItemCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServQBItemCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServReference1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServReference2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServReference2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServReference2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServReference2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServReference3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServReference3");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServReference3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServReference3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServReference4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServReference4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServRepairStep {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServRepairStep");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServRepairStepLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServRepairStepLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServType {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServType");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
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
        ServiceCodesRecord rec = null;
             
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
    ServiceCodesRecord rec = null;
    
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

        
        public virtual ServiceCodesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return ServiceCodesTable.GetRecord(this.RecordUniqueId, true);
              
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

  