
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_Inventory.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Show_Inventory
{
  

#region "Section 1: Place your customizations here."

    
public class InventoryRecordControl : BaseInventoryRecordControl
{
      
        // The BaseInventoryRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the InventoryRecordControl control on the Show_Inventory page.
// Do not modify this class. Instead override any method in InventoryRecordControl.
public class BaseInventoryRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseInventoryRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in InventoryRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in InventoryRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.DialogEditButton.Click += DialogEditButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = InventoryTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "InventoryRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new InventoryRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            InventoryRecord[] recList = InventoryTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = InventoryTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                
                SetInvAvgBuyPrice();
                SetInvAvgBuyPriceLabel();
                SetInvBin();
                SetInvBinLabel();
                SetInvCategory();
                SetInvCategoryLabel();
                SetInvCustom1();
                SetInvCustom1Label();
                SetInvCustom2();
                SetInvCustom2Label();
                SetInvDateRecordAdded();
                SetInvDateRecordAddedLabel();
                SetInvDateRecordUpdated();
                SetInvDateRecordUpdatedLabel();
                SetInvExportInclude();
                SetInvExportIncludeLabel();
                SetInvExportRecordChanged();
                SetInvExportRecordChangedLabel();
                SetInvItemDesc();
                SetInvItemDescLabel();
                SetInvLastBuyPrice();
                SetInvLastBuyPriceLabel();
                SetInvLocation();
                SetInvLocationLabel();
                SetInvMake();
                SetInvMakeLabel();
                SetInvMarkupRate0();
                SetInvMarkupRate0Label();
                SetInvMarkupRate1();
                SetInvMarkupRate1Label();
                SetInvMarkupRate2();
                SetInvMarkupRate2Label();
                SetInvMarkupRate3();
                SetInvMarkupRate3Label();
                SetInvMarkupRate4();
                SetInvMarkupRate4Label();
                SetInvMarkupType0();
                SetInvMarkupType0Label();
                SetInvMarkupType1();
                SetInvMarkupType1Label();
                SetInvMarkupType2();
                SetInvMarkupType2Label();
                SetInvMarkupType3();
                SetInvMarkupType3Label();
                SetInvMarkupType4();
                SetInvMarkupType4Label();
                SetInvMinOrder();
                SetInvMinOrderLabel();
                SetInvMinRequired();
                SetInvMinRequiredLabel();
                SetInvModels();
                SetInvModelsLabel();
                SetInvNonStockItem();
                SetInvNonStockItemLabel();
                SetInvNotes();
                SetInvNotesLabel();
                SetInvPartNo();
                SetInvPartNoLabel();
                SetInvPickQuantity();
                SetInvPickQuantityLabel();
                SetInvPicturePath();
                SetInvPicturePathLabel();
                SetInvPrevBuyPrice();
                SetInvPrevBuyPriceLabel();
                SetInvQuantity();
                SetInvQuantityLabel();
                SetInvReference1();
                SetInvReference1Label();
                SetInvReference2();
                SetInvReference2Label();
                SetInvReference3();
                SetInvReference3Label();
                SetInvReference4();
                SetInvReference4Label();
                SetInvReplacement();
                SetInvReplacementLabel();
                SetInvSellPrice0();
                SetInvSellPrice0Label();
                SetInvSellPrice1();
                SetInvSellPrice1Label();
                SetInvSellPrice2();
                SetInvSellPrice2Label();
                SetInvSellPrice3();
                SetInvSellPrice3Label();
                SetInvSellPrice4();
                SetInvSellPrice4Label();
                SetInvShare();
                SetInvShareLabel();
                SetInvStatus();
                SetInvStatusLabel();
                SetInvVendNo1();
                SetInvVendNo1Label();
                SetInvVendNo2();
                SetInvVendNo2Label();
                SetInvVendNo3();
                SetInvVendNo3Label();
                SetInvVendorPartNo1();
                SetInvVendorPartNo1Label();
                SetInvVendorPartNo2();
                SetInvVendorPartNo2Label();
                SetInvVendorPartNo3();
                SetInvVendorPartNo3Label();
                SetLastExtraction();
                SetLastExtractionLabel();
                
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
        
        
        public virtual void SetInvAvgBuyPrice()
        {
            
                    
            // Set the InvAvgBuyPrice Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvAvgBuyPrice is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvAvgBuyPriceSpecified) {
                								
                // If the InvAvgBuyPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvAvgBuyPrice, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvAvgBuyPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvAvgBuyPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvAvgBuyPrice.Text = InventoryTable.InvAvgBuyPrice.Format(InventoryTable.InvAvgBuyPrice.DefaultValue, @"C");
            		
            }
            
            // If the InvAvgBuyPrice is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvAvgBuyPrice.Text == null ||
                this.InvAvgBuyPrice.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvAvgBuyPrice.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvBin()
        {
            
                    
            // Set the InvBin Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvBin is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvBinSpecified) {
                								
                // If the InvBin is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvBin);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvBin.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvBin is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvBin.Text = InventoryTable.InvBin.Format(InventoryTable.InvBin.DefaultValue);
            		
            }
            
            // If the InvBin is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvBin.Text == null ||
                this.InvBin.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvBin.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvCategory()
        {
            
                    
            // Set the InvCategory Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvCategory is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvCategorySpecified) {
                								
                // If the InvCategory is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvCategory);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvCategory.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvCategory is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvCategory.Text = InventoryTable.InvCategory.Format(InventoryTable.InvCategory.DefaultValue);
            		
            }
            
            // If the InvCategory is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvCategory.Text == null ||
                this.InvCategory.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvCategory.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvCustom1()
        {
            
                    
            // Set the InvCustom1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvCustom1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvCustom1Specified) {
                								
                // If the InvCustom1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvCustom1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvCustom1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvCustom1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvCustom1.Text = InventoryTable.InvCustom1.Format(InventoryTable.InvCustom1.DefaultValue);
            		
            }
            
            // If the InvCustom1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvCustom1.Text == null ||
                this.InvCustom1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvCustom1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvCustom2()
        {
            
                    
            // Set the InvCustom2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvCustom2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvCustom2Specified) {
                								
                // If the InvCustom2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvCustom2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvCustom2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvCustom2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvCustom2.Text = InventoryTable.InvCustom2.Format(InventoryTable.InvCustom2.DefaultValue);
            		
            }
            
            // If the InvCustom2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvCustom2.Text == null ||
                this.InvCustom2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvCustom2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvDateRecordAdded()
        {
            
                    
            // Set the InvDateRecordAdded Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvDateRecordAdded is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvDateRecordAddedSpecified) {
                								
                // If the InvDateRecordAdded is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvDateRecordAdded, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvDateRecordAdded.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvDateRecordAdded is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvDateRecordAdded.Text = InventoryTable.InvDateRecordAdded.Format(InventoryTable.InvDateRecordAdded.DefaultValue, @"g");
            		
            }
            
            // If the InvDateRecordAdded is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvDateRecordAdded.Text == null ||
                this.InvDateRecordAdded.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvDateRecordAdded.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvDateRecordUpdated()
        {
            
                    
            // Set the InvDateRecordUpdated Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvDateRecordUpdated is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvDateRecordUpdatedSpecified) {
                								
                // If the InvDateRecordUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvDateRecordUpdated, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvDateRecordUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvDateRecordUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvDateRecordUpdated.Text = InventoryTable.InvDateRecordUpdated.Format(InventoryTable.InvDateRecordUpdated.DefaultValue, @"g");
            		
            }
            
            // If the InvDateRecordUpdated is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvDateRecordUpdated.Text == null ||
                this.InvDateRecordUpdated.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvDateRecordUpdated.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvExportInclude()
        {
            
                    
            // Set the InvExportInclude Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvExportInclude is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvExportIncludeSpecified) {
                								
                // If the InvExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvExportInclude);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvExportInclude.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvExportInclude.Text = InventoryTable.InvExportInclude.Format(InventoryTable.InvExportInclude.DefaultValue);
            		
            }
            
            // If the InvExportInclude is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvExportInclude.Text == null ||
                this.InvExportInclude.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvExportInclude.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvExportRecordChanged()
        {
            
                    
            // Set the InvExportRecordChanged Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvExportRecordChanged is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvExportRecordChangedSpecified) {
                								
                // If the InvExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvExportRecordChanged);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvExportRecordChanged.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvExportRecordChanged.Text = InventoryTable.InvExportRecordChanged.Format(InventoryTable.InvExportRecordChanged.DefaultValue);
            		
            }
            
            // If the InvExportRecordChanged is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvExportRecordChanged.Text == null ||
                this.InvExportRecordChanged.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvExportRecordChanged.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvItemDesc()
        {
            
                    
            // Set the InvItemDesc Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvItemDesc is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvItemDescSpecified) {
                								
                // If the InvItemDesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvItemDesc);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvItemDesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvItemDesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvItemDesc.Text = InventoryTable.InvItemDesc.Format(InventoryTable.InvItemDesc.DefaultValue);
            		
            }
            
            // If the InvItemDesc is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvItemDesc.Text == null ||
                this.InvItemDesc.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvItemDesc.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvLastBuyPrice()
        {
            
                    
            // Set the InvLastBuyPrice Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvLastBuyPrice is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvLastBuyPriceSpecified) {
                								
                // If the InvLastBuyPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvLastBuyPrice, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvLastBuyPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvLastBuyPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvLastBuyPrice.Text = InventoryTable.InvLastBuyPrice.Format(InventoryTable.InvLastBuyPrice.DefaultValue, @"C");
            		
            }
            
            // If the InvLastBuyPrice is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvLastBuyPrice.Text == null ||
                this.InvLastBuyPrice.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvLastBuyPrice.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvLocation()
        {
            
                    
            // Set the InvLocation Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvLocation is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvLocationSpecified) {
                								
                // If the InvLocation is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvLocation);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvLocation.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvLocation is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvLocation.Text = InventoryTable.InvLocation.Format(InventoryTable.InvLocation.DefaultValue);
            		
            }
            
            // If the InvLocation is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvLocation.Text == null ||
                this.InvLocation.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvLocation.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMake()
        {
            
                    
            // Set the InvMake Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMake is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMakeSpecified) {
                								
                // If the InvMake is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMake);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMake.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMake is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMake.Text = InventoryTable.InvMake.Format(InventoryTable.InvMake.DefaultValue);
            		
            }
            
            // If the InvMake is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMake.Text == null ||
                this.InvMake.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMake.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupRate0()
        {
            
                    
            // Set the InvMarkupRate0 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate0 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate0Specified) {
                								
                // If the InvMarkupRate0 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate0);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupRate0.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate0 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate0.Text = InventoryTable.InvMarkupRate0.Format(InventoryTable.InvMarkupRate0.DefaultValue);
            		
            }
            
            // If the InvMarkupRate0 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupRate0.Text == null ||
                this.InvMarkupRate0.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupRate0.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupRate1()
        {
            
                    
            // Set the InvMarkupRate1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate1Specified) {
                								
                // If the InvMarkupRate1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupRate1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate1.Text = InventoryTable.InvMarkupRate1.Format(InventoryTable.InvMarkupRate1.DefaultValue);
            		
            }
            
            // If the InvMarkupRate1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupRate1.Text == null ||
                this.InvMarkupRate1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupRate1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupRate2()
        {
            
                    
            // Set the InvMarkupRate2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate2Specified) {
                								
                // If the InvMarkupRate2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupRate2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate2.Text = InventoryTable.InvMarkupRate2.Format(InventoryTable.InvMarkupRate2.DefaultValue);
            		
            }
            
            // If the InvMarkupRate2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupRate2.Text == null ||
                this.InvMarkupRate2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupRate2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupRate3()
        {
            
                    
            // Set the InvMarkupRate3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate3Specified) {
                								
                // If the InvMarkupRate3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupRate3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate3.Text = InventoryTable.InvMarkupRate3.Format(InventoryTable.InvMarkupRate3.DefaultValue);
            		
            }
            
            // If the InvMarkupRate3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupRate3.Text == null ||
                this.InvMarkupRate3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupRate3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupRate4()
        {
            
                    
            // Set the InvMarkupRate4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate4Specified) {
                								
                // If the InvMarkupRate4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate4);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupRate4.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate4.Text = InventoryTable.InvMarkupRate4.Format(InventoryTable.InvMarkupRate4.DefaultValue);
            		
            }
            
            // If the InvMarkupRate4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupRate4.Text == null ||
                this.InvMarkupRate4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupRate4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupType0()
        {
            
                    
            // Set the InvMarkupType0 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType0 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType0Specified) {
                								
                // If the InvMarkupType0 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType0);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupType0.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType0 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType0.Text = InventoryTable.InvMarkupType0.Format(InventoryTable.InvMarkupType0.DefaultValue);
            		
            }
            
            // If the InvMarkupType0 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupType0.Text == null ||
                this.InvMarkupType0.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupType0.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupType1()
        {
            
                    
            // Set the InvMarkupType1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType1Specified) {
                								
                // If the InvMarkupType1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupType1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType1.Text = InventoryTable.InvMarkupType1.Format(InventoryTable.InvMarkupType1.DefaultValue);
            		
            }
            
            // If the InvMarkupType1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupType1.Text == null ||
                this.InvMarkupType1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupType1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupType2()
        {
            
                    
            // Set the InvMarkupType2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType2Specified) {
                								
                // If the InvMarkupType2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupType2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType2.Text = InventoryTable.InvMarkupType2.Format(InventoryTable.InvMarkupType2.DefaultValue);
            		
            }
            
            // If the InvMarkupType2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupType2.Text == null ||
                this.InvMarkupType2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupType2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupType3()
        {
            
                    
            // Set the InvMarkupType3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType3Specified) {
                								
                // If the InvMarkupType3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupType3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType3.Text = InventoryTable.InvMarkupType3.Format(InventoryTable.InvMarkupType3.DefaultValue);
            		
            }
            
            // If the InvMarkupType3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupType3.Text == null ||
                this.InvMarkupType3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupType3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMarkupType4()
        {
            
                    
            // Set the InvMarkupType4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType4Specified) {
                								
                // If the InvMarkupType4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType4);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMarkupType4.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType4.Text = InventoryTable.InvMarkupType4.Format(InventoryTable.InvMarkupType4.DefaultValue);
            		
            }
            
            // If the InvMarkupType4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMarkupType4.Text == null ||
                this.InvMarkupType4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMarkupType4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMinOrder()
        {
            
                    
            // Set the InvMinOrder Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMinOrder is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMinOrderSpecified) {
                								
                // If the InvMinOrder is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMinOrder);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMinOrder.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMinOrder is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMinOrder.Text = InventoryTable.InvMinOrder.Format(InventoryTable.InvMinOrder.DefaultValue);
            		
            }
            
            // If the InvMinOrder is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMinOrder.Text == null ||
                this.InvMinOrder.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMinOrder.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvMinRequired()
        {
            
                    
            // Set the InvMinRequired Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMinRequired is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMinRequiredSpecified) {
                								
                // If the InvMinRequired is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMinRequired);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvMinRequired.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMinRequired is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMinRequired.Text = InventoryTable.InvMinRequired.Format(InventoryTable.InvMinRequired.DefaultValue);
            		
            }
            
            // If the InvMinRequired is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvMinRequired.Text == null ||
                this.InvMinRequired.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvMinRequired.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvModels()
        {
            
                    
            // Set the InvModels Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvModels is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvModelsSpecified) {
                								
                // If the InvModels is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvModels);
                                
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
                        String name = HttpUtility.HtmlEncode(InventoryTable.InvModels.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.InventoryTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"InvModels\\\", \\\"InvModels\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.InvModels.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvModels is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvModels.Text = InventoryTable.InvModels.Format(InventoryTable.InvModels.DefaultValue);
            		
            }
            
            // If the InvModels is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvModels.Text == null ||
                this.InvModels.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvModels.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvNonStockItem()
        {
            
                    
            // Set the InvNonStockItem Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvNonStockItem is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvNonStockItemSpecified) {
                								
                // If the InvNonStockItem is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvNonStockItem);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvNonStockItem.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvNonStockItem is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvNonStockItem.Text = InventoryTable.InvNonStockItem.Format(InventoryTable.InvNonStockItem.DefaultValue);
            		
            }
            
            // If the InvNonStockItem is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvNonStockItem.Text == null ||
                this.InvNonStockItem.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvNonStockItem.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvNotes()
        {
            
                    
            // Set the InvNotes Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvNotes is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvNotesSpecified) {
                								
                // If the InvNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvNotes);
                                
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
                        String name = HttpUtility.HtmlEncode(InventoryTable.InvNotes.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"OEMConversion.Business.InventoryTable, App_Code\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"InvNotes\\\", \\\"InvNotes\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "OEMConversion") + "\\\", " +
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
                
                this.InvNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvNotes.Text = InventoryTable.InvNotes.Format(InventoryTable.InvNotes.DefaultValue);
            		
            }
            
            // If the InvNotes is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvNotes.Text == null ||
                this.InvNotes.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvNotes.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvPartNo()
        {
            
                    
            // Set the InvPartNo Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvPartNo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvPartNoSpecified) {
                								
                // If the InvPartNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvPartNo);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvPartNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvPartNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvPartNo.Text = InventoryTable.InvPartNo.Format(InventoryTable.InvPartNo.DefaultValue);
            		
            }
            
            // If the InvPartNo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvPartNo.Text == null ||
                this.InvPartNo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvPartNo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvPickQuantity()
        {
            
                    
            // Set the InvPickQuantity Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvPickQuantity is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvPickQuantitySpecified) {
                								
                // If the InvPickQuantity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvPickQuantity);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvPickQuantity.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvPickQuantity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvPickQuantity.Text = InventoryTable.InvPickQuantity.Format(InventoryTable.InvPickQuantity.DefaultValue);
            		
            }
            
            // If the InvPickQuantity is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvPickQuantity.Text == null ||
                this.InvPickQuantity.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvPickQuantity.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvPicturePath()
        {
            
                    
            // Set the InvPicturePath Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvPicturePath is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvPicturePathSpecified) {
                								
                // If the InvPicturePath is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvPicturePath);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvPicturePath.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvPicturePath is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvPicturePath.Text = InventoryTable.InvPicturePath.Format(InventoryTable.InvPicturePath.DefaultValue);
            		
            }
            
            // If the InvPicturePath is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvPicturePath.Text == null ||
                this.InvPicturePath.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvPicturePath.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvPrevBuyPrice()
        {
            
                    
            // Set the InvPrevBuyPrice Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvPrevBuyPrice is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvPrevBuyPriceSpecified) {
                								
                // If the InvPrevBuyPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvPrevBuyPrice, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvPrevBuyPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvPrevBuyPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvPrevBuyPrice.Text = InventoryTable.InvPrevBuyPrice.Format(InventoryTable.InvPrevBuyPrice.DefaultValue, @"C");
            		
            }
            
            // If the InvPrevBuyPrice is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvPrevBuyPrice.Text == null ||
                this.InvPrevBuyPrice.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvPrevBuyPrice.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvQuantity()
        {
            
                    
            // Set the InvQuantity Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvQuantity is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvQuantitySpecified) {
                								
                // If the InvQuantity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvQuantity);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvQuantity.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvQuantity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvQuantity.Text = InventoryTable.InvQuantity.Format(InventoryTable.InvQuantity.DefaultValue);
            		
            }
            
            // If the InvQuantity is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvQuantity.Text == null ||
                this.InvQuantity.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvQuantity.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvReference1()
        {
            
                    
            // Set the InvReference1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReference1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReference1Specified) {
                								
                // If the InvReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReference1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReference1.Text = InventoryTable.InvReference1.Format(InventoryTable.InvReference1.DefaultValue);
            		
            }
            
            // If the InvReference1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvReference1.Text == null ||
                this.InvReference1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvReference1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvReference2()
        {
            
                    
            // Set the InvReference2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReference2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReference2Specified) {
                								
                // If the InvReference2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReference2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvReference2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReference2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReference2.Text = InventoryTable.InvReference2.Format(InventoryTable.InvReference2.DefaultValue);
            		
            }
            
            // If the InvReference2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvReference2.Text == null ||
                this.InvReference2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvReference2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvReference3()
        {
            
                    
            // Set the InvReference3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReference3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReference3Specified) {
                								
                // If the InvReference3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReference3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvReference3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReference3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReference3.Text = InventoryTable.InvReference3.Format(InventoryTable.InvReference3.DefaultValue);
            		
            }
            
            // If the InvReference3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvReference3.Text == null ||
                this.InvReference3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvReference3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvReference4()
        {
            
                    
            // Set the InvReference4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReference4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReference4Specified) {
                								
                // If the InvReference4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReference4);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvReference4.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReference4.Text = InventoryTable.InvReference4.Format(InventoryTable.InvReference4.DefaultValue);
            		
            }
            
            // If the InvReference4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvReference4.Text == null ||
                this.InvReference4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvReference4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvReplacement()
        {
            
                    
            // Set the InvReplacement Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReplacement is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReplacementSpecified) {
                								
                // If the InvReplacement is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReplacement);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvReplacement.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReplacement is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReplacement.Text = InventoryTable.InvReplacement.Format(InventoryTable.InvReplacement.DefaultValue);
            		
            }
            
            // If the InvReplacement is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvReplacement.Text == null ||
                this.InvReplacement.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvReplacement.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvSellPrice0()
        {
            
                    
            // Set the InvSellPrice0 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice0 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice0Specified) {
                								
                // If the InvSellPrice0 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice0, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvSellPrice0.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice0 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice0.Text = InventoryTable.InvSellPrice0.Format(InventoryTable.InvSellPrice0.DefaultValue, @"C");
            		
            }
            
            // If the InvSellPrice0 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvSellPrice0.Text == null ||
                this.InvSellPrice0.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvSellPrice0.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvSellPrice1()
        {
            
                    
            // Set the InvSellPrice1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice1Specified) {
                								
                // If the InvSellPrice1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice1, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvSellPrice1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice1.Text = InventoryTable.InvSellPrice1.Format(InventoryTable.InvSellPrice1.DefaultValue, @"C");
            		
            }
            
            // If the InvSellPrice1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvSellPrice1.Text == null ||
                this.InvSellPrice1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvSellPrice1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvSellPrice2()
        {
            
                    
            // Set the InvSellPrice2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice2Specified) {
                								
                // If the InvSellPrice2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice2, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvSellPrice2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice2.Text = InventoryTable.InvSellPrice2.Format(InventoryTable.InvSellPrice2.DefaultValue, @"C");
            		
            }
            
            // If the InvSellPrice2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvSellPrice2.Text == null ||
                this.InvSellPrice2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvSellPrice2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvSellPrice3()
        {
            
                    
            // Set the InvSellPrice3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice3Specified) {
                								
                // If the InvSellPrice3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice3, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvSellPrice3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice3.Text = InventoryTable.InvSellPrice3.Format(InventoryTable.InvSellPrice3.DefaultValue, @"C");
            		
            }
            
            // If the InvSellPrice3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvSellPrice3.Text == null ||
                this.InvSellPrice3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvSellPrice3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvSellPrice4()
        {
            
                    
            // Set the InvSellPrice4 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice4 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice4Specified) {
                								
                // If the InvSellPrice4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice4, @"C");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvSellPrice4.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice4.Text = InventoryTable.InvSellPrice4.Format(InventoryTable.InvSellPrice4.DefaultValue, @"C");
            		
            }
            
            // If the InvSellPrice4 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvSellPrice4.Text == null ||
                this.InvSellPrice4.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvSellPrice4.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvShare()
        {
            
                    
            // Set the InvShare Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvShare is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvShareSpecified) {
                								
                // If the InvShare is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvShare);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvShare.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvShare is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvShare.Text = InventoryTable.InvShare.Format(InventoryTable.InvShare.DefaultValue);
            		
            }
            
            // If the InvShare is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvShare.Text == null ||
                this.InvShare.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvShare.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvStatus()
        {
            
                    
            // Set the InvStatus Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvStatus is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvStatusSpecified) {
                								
                // If the InvStatus is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvStatus);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvStatus.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvStatus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvStatus.Text = InventoryTable.InvStatus.Format(InventoryTable.InvStatus.DefaultValue);
            		
            }
            
            // If the InvStatus is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvStatus.Text == null ||
                this.InvStatus.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvStatus.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvVendNo1()
        {
            
                    
            // Set the InvVendNo1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendNo1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendNo1Specified) {
                								
                // If the InvVendNo1 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = InventoryTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InventoryTable.InvVendNo1);
               if(_isExpandableNonCompositeForeignKey &&InventoryTable.InvVendNo1.IsApplyDisplayAs)
                                  
                     formattedValue = InventoryTable.GetDFKA(this.DataSource.InvVendNo1.ToString(),InventoryTable.InvVendNo1, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(InventoryTable.InvVendNo1);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvVendNo1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendNo1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendNo1.Text = InventoryTable.InvVendNo1.Format(InventoryTable.InvVendNo1.DefaultValue);
            		
            }
            
            // If the InvVendNo1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvVendNo1.Text == null ||
                this.InvVendNo1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvVendNo1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvVendNo2()
        {
            
                    
            // Set the InvVendNo2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendNo2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendNo2Specified) {
                								
                // If the InvVendNo2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendNo2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvVendNo2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendNo2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendNo2.Text = InventoryTable.InvVendNo2.Format(InventoryTable.InvVendNo2.DefaultValue);
            		
            }
            
            // If the InvVendNo2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvVendNo2.Text == null ||
                this.InvVendNo2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvVendNo2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvVendNo3()
        {
            
                    
            // Set the InvVendNo3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendNo3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendNo3Specified) {
                								
                // If the InvVendNo3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendNo3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvVendNo3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendNo3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendNo3.Text = InventoryTable.InvVendNo3.Format(InventoryTable.InvVendNo3.DefaultValue);
            		
            }
            
            // If the InvVendNo3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvVendNo3.Text == null ||
                this.InvVendNo3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvVendNo3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvVendorPartNo1()
        {
            
                    
            // Set the InvVendorPartNo1 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendorPartNo1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendorPartNo1Specified) {
                								
                // If the InvVendorPartNo1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendorPartNo1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvVendorPartNo1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendorPartNo1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendorPartNo1.Text = InventoryTable.InvVendorPartNo1.Format(InventoryTable.InvVendorPartNo1.DefaultValue);
            		
            }
            
            // If the InvVendorPartNo1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvVendorPartNo1.Text == null ||
                this.InvVendorPartNo1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvVendorPartNo1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvVendorPartNo2()
        {
            
                    
            // Set the InvVendorPartNo2 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendorPartNo2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendorPartNo2Specified) {
                								
                // If the InvVendorPartNo2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendorPartNo2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvVendorPartNo2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendorPartNo2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendorPartNo2.Text = InventoryTable.InvVendorPartNo2.Format(InventoryTable.InvVendorPartNo2.DefaultValue);
            		
            }
            
            // If the InvVendorPartNo2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvVendorPartNo2.Text == null ||
                this.InvVendorPartNo2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvVendorPartNo2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvVendorPartNo3()
        {
            
                    
            // Set the InvVendorPartNo3 Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendorPartNo3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendorPartNo3Specified) {
                								
                // If the InvVendorPartNo3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendorPartNo3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvVendorPartNo3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendorPartNo3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendorPartNo3.Text = InventoryTable.InvVendorPartNo3.Format(InventoryTable.InvVendorPartNo3.DefaultValue);
            		
            }
            
            // If the InvVendorPartNo3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvVendorPartNo3.Text == null ||
                this.InvVendorPartNo3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvVendorPartNo3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLastExtraction()
        {
            
                    
            // Set the LastExtraction Literal on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.LastExtraction is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastExtractionSpecified) {
                								
                // If the LastExtraction is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.LastExtraction);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LastExtraction.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastExtraction is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastExtraction.Text = InventoryTable.LastExtraction.Format(InventoryTable.LastExtraction.DefaultValue);
            		
            }
            
            // If the LastExtraction is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LastExtraction.Text == null ||
                this.LastExtraction.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LastExtraction.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvAvgBuyPriceLabel()
                  {
                  
                        this.InvAvgBuyPriceLabel.Text = EvaluateFormula("\"Avg Buy Price\"");
                      
                    
        }
                
        public virtual void SetInvBinLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvCategoryLabel()
                  {
                  
                        this.InvCategoryLabel.Text = EvaluateFormula("\"Category\"");
                      
                    
        }
                
        public virtual void SetInvCustom1Label()
                  {
                  
                    
        }
                
        public virtual void SetInvCustom2Label()
                  {
                  
                    
        }
                
        public virtual void SetInvDateRecordAddedLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvDateRecordUpdatedLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvExportIncludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvExportRecordChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvItemDescLabel()
                  {
                  
                        this.InvItemDescLabel.Text = EvaluateFormula("\"Item Description\"");
                      
                    
        }
                
        public virtual void SetInvLastBuyPriceLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvLocationLabel()
                  {
                  
                        this.InvLocationLabel.Text = EvaluateFormula("\"Location\"");
                      
                    
        }
                
        public virtual void SetInvMakeLabel()
                  {
                  
                        this.InvMakeLabel.Text = EvaluateFormula("\"Make\"");
                      
                    
        }
                
        public virtual void SetInvMarkupRate0Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMarkupRate1Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMarkupRate2Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMarkupRate3Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMarkupRate4Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMarkupType0Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMarkupType1Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMarkupType2Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMarkupType3Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMarkupType4Label()
                  {
                  
                    
        }
                
        public virtual void SetInvMinOrderLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvMinRequiredLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvModelsLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvNonStockItemLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvNotesLabel()
                  {
                  
                        this.InvNotesLabel.Text = EvaluateFormula("\"Notes\"");
                      
                    
        }
                
        public virtual void SetInvPartNoLabel()
                  {
                  
                        this.InvPartNoLabel.Text = EvaluateFormula("\"Part Number\"");
                      
                    
        }
                
        public virtual void SetInvPickQuantityLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvPicturePathLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvPrevBuyPriceLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvQuantityLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvReference1Label()
                  {
                  
                    
        }
                
        public virtual void SetInvReference2Label()
                  {
                  
                    
        }
                
        public virtual void SetInvReference3Label()
                  {
                  
                    
        }
                
        public virtual void SetInvReference4Label()
                  {
                  
                    
        }
                
        public virtual void SetInvReplacementLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvSellPrice0Label()
                  {
                  
                        this.InvSellPrice0Label.Text = EvaluateFormula("\"Sell Price\"");
                      
                    
        }
                
        public virtual void SetInvSellPrice1Label()
                  {
                  
                    
        }
                
        public virtual void SetInvSellPrice2Label()
                  {
                  
                    
        }
                
        public virtual void SetInvSellPrice3Label()
                  {
                  
                    
        }
                
        public virtual void SetInvSellPrice4Label()
                  {
                  
                    
        }
                
        public virtual void SetInvShareLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvStatusLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvVendNo1Label()
                  {
                  
                    
        }
                
        public virtual void SetInvVendNo2Label()
                  {
                  
                    
        }
                
        public virtual void SetInvVendNo3Label()
                  {
                  
                    
        }
                
        public virtual void SetInvVendorPartNo1Label()
                  {
                  
                    
        }
                
        public virtual void SetInvVendorPartNo2Label()
                  {
                  
                    
        }
                
        public virtual void SetInvVendorPartNo3Label()
                  {
                  
                    
        }
                
        public virtual void SetLastExtractionLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "InventoryRecordControlPanel");
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
        
            GetInvAvgBuyPrice();
            GetInvBin();
            GetInvCategory();
            GetInvCustom1();
            GetInvCustom2();
            GetInvDateRecordAdded();
            GetInvDateRecordUpdated();
            GetInvExportInclude();
            GetInvExportRecordChanged();
            GetInvItemDesc();
            GetInvLastBuyPrice();
            GetInvLocation();
            GetInvMake();
            GetInvMarkupRate0();
            GetInvMarkupRate1();
            GetInvMarkupRate2();
            GetInvMarkupRate3();
            GetInvMarkupRate4();
            GetInvMarkupType0();
            GetInvMarkupType1();
            GetInvMarkupType2();
            GetInvMarkupType3();
            GetInvMarkupType4();
            GetInvMinOrder();
            GetInvMinRequired();
            GetInvModels();
            GetInvNonStockItem();
            GetInvNotes();
            GetInvPartNo();
            GetInvPickQuantity();
            GetInvPicturePath();
            GetInvPrevBuyPrice();
            GetInvQuantity();
            GetInvReference1();
            GetInvReference2();
            GetInvReference3();
            GetInvReference4();
            GetInvReplacement();
            GetInvSellPrice0();
            GetInvSellPrice1();
            GetInvSellPrice2();
            GetInvSellPrice3();
            GetInvSellPrice4();
            GetInvShare();
            GetInvStatus();
            GetInvVendNo1();
            GetInvVendNo2();
            GetInvVendNo3();
            GetInvVendorPartNo1();
            GetInvVendorPartNo2();
            GetInvVendorPartNo3();
            GetLastExtraction();
        }
        
        
        public virtual void GetInvAvgBuyPrice()
        {
            
        }
                
        public virtual void GetInvBin()
        {
            
        }
                
        public virtual void GetInvCategory()
        {
            
        }
                
        public virtual void GetInvCustom1()
        {
            
        }
                
        public virtual void GetInvCustom2()
        {
            
        }
                
        public virtual void GetInvDateRecordAdded()
        {
            
        }
                
        public virtual void GetInvDateRecordUpdated()
        {
            
        }
                
        public virtual void GetInvExportInclude()
        {
            
        }
                
        public virtual void GetInvExportRecordChanged()
        {
            
        }
                
        public virtual void GetInvItemDesc()
        {
            
        }
                
        public virtual void GetInvLastBuyPrice()
        {
            
        }
                
        public virtual void GetInvLocation()
        {
            
        }
                
        public virtual void GetInvMake()
        {
            
        }
                
        public virtual void GetInvMarkupRate0()
        {
            
        }
                
        public virtual void GetInvMarkupRate1()
        {
            
        }
                
        public virtual void GetInvMarkupRate2()
        {
            
        }
                
        public virtual void GetInvMarkupRate3()
        {
            
        }
                
        public virtual void GetInvMarkupRate4()
        {
            
        }
                
        public virtual void GetInvMarkupType0()
        {
            
        }
                
        public virtual void GetInvMarkupType1()
        {
            
        }
                
        public virtual void GetInvMarkupType2()
        {
            
        }
                
        public virtual void GetInvMarkupType3()
        {
            
        }
                
        public virtual void GetInvMarkupType4()
        {
            
        }
                
        public virtual void GetInvMinOrder()
        {
            
        }
                
        public virtual void GetInvMinRequired()
        {
            
        }
                
        public virtual void GetInvModels()
        {
            
        }
                
        public virtual void GetInvNonStockItem()
        {
            
        }
                
        public virtual void GetInvNotes()
        {
            
        }
                
        public virtual void GetInvPartNo()
        {
            
        }
                
        public virtual void GetInvPickQuantity()
        {
            
        }
                
        public virtual void GetInvPicturePath()
        {
            
        }
                
        public virtual void GetInvPrevBuyPrice()
        {
            
        }
                
        public virtual void GetInvQuantity()
        {
            
        }
                
        public virtual void GetInvReference1()
        {
            
        }
                
        public virtual void GetInvReference2()
        {
            
        }
                
        public virtual void GetInvReference3()
        {
            
        }
                
        public virtual void GetInvReference4()
        {
            
        }
                
        public virtual void GetInvReplacement()
        {
            
        }
                
        public virtual void GetInvSellPrice0()
        {
            
        }
                
        public virtual void GetInvSellPrice1()
        {
            
        }
                
        public virtual void GetInvSellPrice2()
        {
            
        }
                
        public virtual void GetInvSellPrice3()
        {
            
        }
                
        public virtual void GetInvSellPrice4()
        {
            
        }
                
        public virtual void GetInvShare()
        {
            
        }
                
        public virtual void GetInvStatus()
        {
            
        }
                
        public virtual void GetInvVendNo1()
        {
            
        }
                
        public virtual void GetInvVendNo2()
        {
            
        }
                
        public virtual void GetInvVendNo3()
        {
            
        }
                
        public virtual void GetInvVendorPartNo1()
        {
            
        }
                
        public virtual void GetInvVendorPartNo2()
        {
            
        }
                
        public virtual void GetInvVendorPartNo3()
        {
            
        }
                
        public virtual void GetLastExtraction()
        {
            
        }
                

      // To customize, override this method in InventoryRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersInventoryRecordControl = false;
            hasFiltersInventoryRecordControl = hasFiltersInventoryRecordControl && false; // suppress warning
      
            WhereClause wc;
            InventoryTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["Inventory"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "OEMConversion").Replace("{URL}", "Inventory"));
            }
            HttpContext.Current.Session["QueryString in Show-Inventory"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(InventoryTable.InvKey, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(InventoryTable.InvKey));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(InventoryTable.InvKey, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            InventoryTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersInventoryRecordControl = false;
            hasFiltersInventoryRecordControl = hasFiltersInventoryRecordControl && false; // suppress warning
      
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
          InventoryTable.DeleteRecord(pkValue);
          
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
            
            string url = @"../Inventory/Edit-Inventory.aspx?Inventory={PK}";
            
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
                return (string)this.ViewState["BaseInventoryRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseInventoryRecordControl_Rec"] = value;
            }
        }
        
        public InventoryRecord DataSource {
            get {
                return (InventoryRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal InvAvgBuyPrice {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvAvgBuyPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvAvgBuyPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvAvgBuyPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvBin {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvBin");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvBinLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvBinLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvCategory {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCategory");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvCategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCategoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvCustom1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCustom1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvCustom1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCustom1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvCustom2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCustom2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvCustom2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCustom2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvDateRecordAdded {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvDateRecordAdded");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvDateRecordAddedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvDateRecordAddedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvDateRecordUpdated {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvDateRecordUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvDateRecordUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvDateRecordUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvExportInclude {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvExportInclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvExportIncludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvExportIncludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvExportRecordChanged {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvExportRecordChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvExportRecordChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvExportRecordChangedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvItemDesc {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvItemDesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvItemDescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvItemDescLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvLastBuyPrice {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLastBuyPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvLastBuyPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLastBuyPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvLocation {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLocation");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvLocationLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLocationLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMake {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMake");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupRate0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate0");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate0Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate0Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupRate1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupRate2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupRate3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupRate4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate4");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate4Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupType0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType0");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType0Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType0Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupType1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupType2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupType3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMarkupType4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType4");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType4Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMinOrder {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMinOrder");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMinOrderLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMinOrderLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvMinRequired {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMinRequired");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMinRequiredLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMinRequiredLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvModels {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvModels");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvModelsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvModelsLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvNonStockItem {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNonStockItem");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvNonStockItemLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNonStockItemLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvNotes {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvPartNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPartNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvPartNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPartNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvPickQuantity {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPickQuantity");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvPickQuantityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPickQuantityLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvPicturePath {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPicturePath");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvPicturePathLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPicturePathLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvPrevBuyPrice {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPrevBuyPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvPrevBuyPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPrevBuyPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvQuantity {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvQuantity");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvQuantityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvQuantityLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvReference1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvReference2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReference2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvReference3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReference3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvReference4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReference4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvReplacement {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReplacement");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReplacementLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReplacementLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvSellPrice0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice0");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice0Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice0Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvSellPrice1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvSellPrice2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvSellPrice3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvSellPrice4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice4");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice4Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvShare {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvShare");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvShareLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvShareLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvStatus {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvStatus");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvStatusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvStatusLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvVendNo1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendNo1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvVendNo2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendNo2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvVendNo3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendNo3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvVendorPartNo1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendorPartNo1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvVendorPartNo2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendorPartNo2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvVendorPartNo3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendorPartNo3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal LastExtraction {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastExtraction");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastExtractionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastExtractionLabel");
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
        InventoryRecord rec = null;
             
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
    InventoryRecord rec = null;
    
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

        
        public virtual InventoryRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return InventoryTable.GetRecord(this.RecordUniqueId, true);
              
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

  