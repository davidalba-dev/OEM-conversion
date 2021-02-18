
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_Inventory_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_Inventory_Table
{
  

#region "Section 1: Place your customizations here."

    
public class InventoryTableControlRow : BaseInventoryTableControlRow
{
      
        // The BaseInventoryTableControlRow implements code for a ROW within the
        // the InventoryTableControl table.  The BaseInventoryTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of InventoryTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class InventoryTableControl : BaseInventoryTableControl
{
    // The BaseInventoryTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The InventoryTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the InventoryTableControlRow control on the Edit_Inventory_Table page.
// Do not modify this class. Instead override any method in InventoryTableControlRow.
public class BaseInventoryTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseInventoryTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in InventoryTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in InventoryTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
              this.InvExportInclude.CheckedChanged += InvExportInclude_CheckedChanged;
            
              this.InvExportRecordChanged.CheckedChanged += InvExportRecordChanged_CheckedChanged;
            
              this.InvNonStockItem.CheckedChanged += InvNonStockItem_CheckedChanged;
            
              this.InvShare.CheckedChanged += InvShare_CheckedChanged;
            
              this.LastExtraction.CheckedChanged += LastExtraction_CheckedChanged;
            
              this.InvAvgBuyPrice.TextChanged += InvAvgBuyPrice_TextChanged;
            
              this.InvBin.TextChanged += InvBin_TextChanged;
            
              this.InvCategory.TextChanged += InvCategory_TextChanged;
            
              this.InvCustom1.TextChanged += InvCustom1_TextChanged;
            
              this.InvCustom2.TextChanged += InvCustom2_TextChanged;
            
              this.InvDateRecordAdded.TextChanged += InvDateRecordAdded_TextChanged;
            
              this.InvDateRecordUpdated.TextChanged += InvDateRecordUpdated_TextChanged;
            
              this.InvItemDesc.TextChanged += InvItemDesc_TextChanged;
            
              this.InvLastBuyPrice.TextChanged += InvLastBuyPrice_TextChanged;
            
              this.InvLocation.TextChanged += InvLocation_TextChanged;
            
              this.InvMake.TextChanged += InvMake_TextChanged;
            
              this.InvMarkupRate0.TextChanged += InvMarkupRate0_TextChanged;
            
              this.InvMarkupRate1.TextChanged += InvMarkupRate1_TextChanged;
            
              this.InvMarkupRate2.TextChanged += InvMarkupRate2_TextChanged;
            
              this.InvMarkupRate3.TextChanged += InvMarkupRate3_TextChanged;
            
              this.InvMarkupRate4.TextChanged += InvMarkupRate4_TextChanged;
            
              this.InvMarkupType0.TextChanged += InvMarkupType0_TextChanged;
            
              this.InvMarkupType1.TextChanged += InvMarkupType1_TextChanged;
            
              this.InvMarkupType2.TextChanged += InvMarkupType2_TextChanged;
            
              this.InvMarkupType3.TextChanged += InvMarkupType3_TextChanged;
            
              this.InvMarkupType4.TextChanged += InvMarkupType4_TextChanged;
            
              this.InvMinOrder.TextChanged += InvMinOrder_TextChanged;
            
              this.InvMinRequired.TextChanged += InvMinRequired_TextChanged;
            
              this.InvModels.TextChanged += InvModels_TextChanged;
            
              this.InvNotes.TextChanged += InvNotes_TextChanged;
            
              this.InvPartNo.TextChanged += InvPartNo_TextChanged;
            
              this.InvPickQuantity.TextChanged += InvPickQuantity_TextChanged;
            
              this.InvPicturePath.TextChanged += InvPicturePath_TextChanged;
            
              this.InvPrevBuyPrice.TextChanged += InvPrevBuyPrice_TextChanged;
            
              this.InvQuantity.TextChanged += InvQuantity_TextChanged;
            
              this.InvReference1.TextChanged += InvReference1_TextChanged;
            
              this.InvReference2.TextChanged += InvReference2_TextChanged;
            
              this.InvReference3.TextChanged += InvReference3_TextChanged;
            
              this.InvReference4.TextChanged += InvReference4_TextChanged;
            
              this.InvReplacement.TextChanged += InvReplacement_TextChanged;
            
              this.InvSellPrice0.TextChanged += InvSellPrice0_TextChanged;
            
              this.InvSellPrice1.TextChanged += InvSellPrice1_TextChanged;
            
              this.InvSellPrice2.TextChanged += InvSellPrice2_TextChanged;
            
              this.InvSellPrice3.TextChanged += InvSellPrice3_TextChanged;
            
              this.InvSellPrice4.TextChanged += InvSellPrice4_TextChanged;
            
              this.InvStatus.TextChanged += InvStatus_TextChanged;
            
              this.InvVendNo1.TextChanged += InvVendNo1_TextChanged;
            
              this.InvVendNo2.TextChanged += InvVendNo2_TextChanged;
            
              this.InvVendNo3.TextChanged += InvVendNo3_TextChanged;
            
              this.InvVendorPartNo1.TextChanged += InvVendorPartNo1_TextChanged;
            
              this.InvVendorPartNo2.TextChanged += InvVendorPartNo2_TextChanged;
            
              this.InvVendorPartNo3.TextChanged += InvVendorPartNo3_TextChanged;
            
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
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseInventoryTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new InventoryRecord();
            
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
                
                
                SetDeleteRowButton();
              
                SetEditRowButton();
              
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
        
        
        public virtual void SetInvAvgBuyPrice()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvAvgBuyPrice.ID))
            {
            
                this.InvAvgBuyPrice.Text = this.PreviousUIData[this.InvAvgBuyPrice.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvAvgBuyPrice TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvAvgBuyPrice is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvAvgBuyPriceSpecified) {
                								
                // If the InvAvgBuyPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvAvgBuyPrice, @"C");
                                
                this.InvAvgBuyPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvAvgBuyPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvAvgBuyPrice.Text = InventoryTable.InvAvgBuyPrice.Format(InventoryTable.InvAvgBuyPrice.DefaultValue, @"C");
            		
            }
            
              this.InvAvgBuyPrice.TextChanged += InvAvgBuyPrice_TextChanged;
                               
        }
                
        public virtual void SetInvBin()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvBin.ID))
            {
            
                this.InvBin.Text = this.PreviousUIData[this.InvBin.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvBin TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvBin is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvBinSpecified) {
                								
                // If the InvBin is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvBin);
                                
                this.InvBin.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvBin is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvBin.Text = InventoryTable.InvBin.Format(InventoryTable.InvBin.DefaultValue);
            		
            }
            
              this.InvBin.TextChanged += InvBin_TextChanged;
                               
        }
                
        public virtual void SetInvCategory()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvCategory.ID))
            {
            
                this.InvCategory.Text = this.PreviousUIData[this.InvCategory.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvCategory TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvCategory is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvCategorySpecified) {
                								
                // If the InvCategory is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvCategory);
                                
                this.InvCategory.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvCategory is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvCategory.Text = InventoryTable.InvCategory.Format(InventoryTable.InvCategory.DefaultValue);
            		
            }
            
              this.InvCategory.TextChanged += InvCategory_TextChanged;
                               
        }
                
        public virtual void SetInvCustom1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvCustom1.ID))
            {
            
                this.InvCustom1.Text = this.PreviousUIData[this.InvCustom1.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvCustom1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvCustom1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvCustom1Specified) {
                								
                // If the InvCustom1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvCustom1);
                                
                this.InvCustom1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvCustom1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvCustom1.Text = InventoryTable.InvCustom1.Format(InventoryTable.InvCustom1.DefaultValue);
            		
            }
            
              this.InvCustom1.TextChanged += InvCustom1_TextChanged;
                               
        }
                
        public virtual void SetInvCustom2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvCustom2.ID))
            {
            
                this.InvCustom2.Text = this.PreviousUIData[this.InvCustom2.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvCustom2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvCustom2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvCustom2Specified) {
                								
                // If the InvCustom2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvCustom2);
                                
                this.InvCustom2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvCustom2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvCustom2.Text = InventoryTable.InvCustom2.Format(InventoryTable.InvCustom2.DefaultValue);
            		
            }
            
              this.InvCustom2.TextChanged += InvCustom2_TextChanged;
                               
        }
                
        public virtual void SetInvDateRecordAdded()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvDateRecordAdded.ID))
            {
            
                this.InvDateRecordAdded.Text = this.PreviousUIData[this.InvDateRecordAdded.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvDateRecordAdded TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvDateRecordAdded is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvDateRecordAddedSpecified) {
                								
                // If the InvDateRecordAdded is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvDateRecordAdded, @"g");
                                
                this.InvDateRecordAdded.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvDateRecordAdded is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvDateRecordAdded.Text = InventoryTable.InvDateRecordAdded.Format(InventoryTable.InvDateRecordAdded.DefaultValue, @"g");
            		
            }
            
              this.InvDateRecordAdded.TextChanged += InvDateRecordAdded_TextChanged;
                               
        }
                
        public virtual void SetInvDateRecordUpdated()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvDateRecordUpdated.ID))
            {
            
                this.InvDateRecordUpdated.Text = this.PreviousUIData[this.InvDateRecordUpdated.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvDateRecordUpdated TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvDateRecordUpdated is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvDateRecordUpdatedSpecified) {
                								
                // If the InvDateRecordUpdated is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvDateRecordUpdated, @"g");
                                
                this.InvDateRecordUpdated.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvDateRecordUpdated is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvDateRecordUpdated.Text = InventoryTable.InvDateRecordUpdated.Format(InventoryTable.InvDateRecordUpdated.DefaultValue, @"g");
            		
            }
            
              this.InvDateRecordUpdated.TextChanged += InvDateRecordUpdated_TextChanged;
                               
        }
                
        public virtual void SetInvExportInclude()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvExportInclude.ID))
            {
                this.InvExportInclude.Checked = Convert.ToBoolean(this.PreviousUIData[this.InvExportInclude.ID]);
                return;
            }	
            
                    
            // Set the InvExportInclude CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvExportInclude is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvExportIncludeSpecified) {
                							
                // If the InvExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.InvExportInclude.Checked = this.DataSource.InvExportInclude;
                    				
            } else {
            
                // InvExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.InvExportInclude.Checked = InventoryTable.InvExportInclude.ParseValue(InventoryTable.InvExportInclude.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetInvExportRecordChanged()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvExportRecordChanged.ID))
            {
                this.InvExportRecordChanged.Checked = Convert.ToBoolean(this.PreviousUIData[this.InvExportRecordChanged.ID]);
                return;
            }	
            
                    
            // Set the InvExportRecordChanged CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvExportRecordChanged is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvExportRecordChangedSpecified) {
                							
                // If the InvExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.InvExportRecordChanged.Checked = this.DataSource.InvExportRecordChanged;
                    				
            } else {
            
                // InvExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.InvExportRecordChanged.Checked = InventoryTable.InvExportRecordChanged.ParseValue(InventoryTable.InvExportRecordChanged.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetInvItemDesc()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvItemDesc.ID))
            {
            
                this.InvItemDesc.Text = this.PreviousUIData[this.InvItemDesc.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvItemDesc TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvItemDesc is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvItemDescSpecified) {
                								
                // If the InvItemDesc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvItemDesc);
                                
                this.InvItemDesc.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvItemDesc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvItemDesc.Text = InventoryTable.InvItemDesc.Format(InventoryTable.InvItemDesc.DefaultValue);
            		
            }
            
              this.InvItemDesc.TextChanged += InvItemDesc_TextChanged;
                               
        }
                
        public virtual void SetInvLastBuyPrice()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvLastBuyPrice.ID))
            {
            
                this.InvLastBuyPrice.Text = this.PreviousUIData[this.InvLastBuyPrice.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvLastBuyPrice TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvLastBuyPrice is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvLastBuyPriceSpecified) {
                								
                // If the InvLastBuyPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvLastBuyPrice, @"C");
                                
                this.InvLastBuyPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvLastBuyPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvLastBuyPrice.Text = InventoryTable.InvLastBuyPrice.Format(InventoryTable.InvLastBuyPrice.DefaultValue, @"C");
            		
            }
            
              this.InvLastBuyPrice.TextChanged += InvLastBuyPrice_TextChanged;
                               
        }
                
        public virtual void SetInvLocation()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvLocation.ID))
            {
            
                this.InvLocation.Text = this.PreviousUIData[this.InvLocation.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvLocation TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvLocation is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvLocationSpecified) {
                								
                // If the InvLocation is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvLocation);
                                
                this.InvLocation.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvLocation is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvLocation.Text = InventoryTable.InvLocation.Format(InventoryTable.InvLocation.DefaultValue);
            		
            }
            
              this.InvLocation.TextChanged += InvLocation_TextChanged;
                               
        }
                
        public virtual void SetInvMake()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMake.ID))
            {
            
                this.InvMake.Text = this.PreviousUIData[this.InvMake.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMake TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMake is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMakeSpecified) {
                								
                // If the InvMake is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMake);
                                
                this.InvMake.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMake is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMake.Text = InventoryTable.InvMake.Format(InventoryTable.InvMake.DefaultValue);
            		
            }
            
              this.InvMake.TextChanged += InvMake_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupRate0()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupRate0.ID))
            {
            
                this.InvMarkupRate0.Text = this.PreviousUIData[this.InvMarkupRate0.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupRate0 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate0 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate0Specified) {
                								
                // If the InvMarkupRate0 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate0);
                                
                this.InvMarkupRate0.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate0 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate0.Text = InventoryTable.InvMarkupRate0.Format(InventoryTable.InvMarkupRate0.DefaultValue);
            		
            }
            
              this.InvMarkupRate0.TextChanged += InvMarkupRate0_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupRate1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupRate1.ID))
            {
            
                this.InvMarkupRate1.Text = this.PreviousUIData[this.InvMarkupRate1.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupRate1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate1Specified) {
                								
                // If the InvMarkupRate1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate1);
                                
                this.InvMarkupRate1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate1.Text = InventoryTable.InvMarkupRate1.Format(InventoryTable.InvMarkupRate1.DefaultValue);
            		
            }
            
              this.InvMarkupRate1.TextChanged += InvMarkupRate1_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupRate2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupRate2.ID))
            {
            
                this.InvMarkupRate2.Text = this.PreviousUIData[this.InvMarkupRate2.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupRate2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate2Specified) {
                								
                // If the InvMarkupRate2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate2);
                                
                this.InvMarkupRate2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate2.Text = InventoryTable.InvMarkupRate2.Format(InventoryTable.InvMarkupRate2.DefaultValue);
            		
            }
            
              this.InvMarkupRate2.TextChanged += InvMarkupRate2_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupRate3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupRate3.ID))
            {
            
                this.InvMarkupRate3.Text = this.PreviousUIData[this.InvMarkupRate3.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupRate3 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate3Specified) {
                								
                // If the InvMarkupRate3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate3);
                                
                this.InvMarkupRate3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate3.Text = InventoryTable.InvMarkupRate3.Format(InventoryTable.InvMarkupRate3.DefaultValue);
            		
            }
            
              this.InvMarkupRate3.TextChanged += InvMarkupRate3_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupRate4()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupRate4.ID))
            {
            
                this.InvMarkupRate4.Text = this.PreviousUIData[this.InvMarkupRate4.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupRate4 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupRate4 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupRate4Specified) {
                								
                // If the InvMarkupRate4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupRate4);
                                
                this.InvMarkupRate4.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupRate4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupRate4.Text = InventoryTable.InvMarkupRate4.Format(InventoryTable.InvMarkupRate4.DefaultValue);
            		
            }
            
              this.InvMarkupRate4.TextChanged += InvMarkupRate4_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupType0()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupType0.ID))
            {
            
                this.InvMarkupType0.Text = this.PreviousUIData[this.InvMarkupType0.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupType0 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType0 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType0Specified) {
                								
                // If the InvMarkupType0 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType0);
                                
                this.InvMarkupType0.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType0 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType0.Text = InventoryTable.InvMarkupType0.Format(InventoryTable.InvMarkupType0.DefaultValue);
            		
            }
            
              this.InvMarkupType0.TextChanged += InvMarkupType0_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupType1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupType1.ID))
            {
            
                this.InvMarkupType1.Text = this.PreviousUIData[this.InvMarkupType1.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupType1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType1Specified) {
                								
                // If the InvMarkupType1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType1);
                                
                this.InvMarkupType1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType1.Text = InventoryTable.InvMarkupType1.Format(InventoryTable.InvMarkupType1.DefaultValue);
            		
            }
            
              this.InvMarkupType1.TextChanged += InvMarkupType1_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupType2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupType2.ID))
            {
            
                this.InvMarkupType2.Text = this.PreviousUIData[this.InvMarkupType2.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupType2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType2Specified) {
                								
                // If the InvMarkupType2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType2);
                                
                this.InvMarkupType2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType2.Text = InventoryTable.InvMarkupType2.Format(InventoryTable.InvMarkupType2.DefaultValue);
            		
            }
            
              this.InvMarkupType2.TextChanged += InvMarkupType2_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupType3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupType3.ID))
            {
            
                this.InvMarkupType3.Text = this.PreviousUIData[this.InvMarkupType3.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupType3 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType3Specified) {
                								
                // If the InvMarkupType3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType3);
                                
                this.InvMarkupType3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType3.Text = InventoryTable.InvMarkupType3.Format(InventoryTable.InvMarkupType3.DefaultValue);
            		
            }
            
              this.InvMarkupType3.TextChanged += InvMarkupType3_TextChanged;
                               
        }
                
        public virtual void SetInvMarkupType4()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMarkupType4.ID))
            {
            
                this.InvMarkupType4.Text = this.PreviousUIData[this.InvMarkupType4.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMarkupType4 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMarkupType4 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMarkupType4Specified) {
                								
                // If the InvMarkupType4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMarkupType4);
                                
                this.InvMarkupType4.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMarkupType4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMarkupType4.Text = InventoryTable.InvMarkupType4.Format(InventoryTable.InvMarkupType4.DefaultValue);
            		
            }
            
              this.InvMarkupType4.TextChanged += InvMarkupType4_TextChanged;
                               
        }
                
        public virtual void SetInvMinOrder()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMinOrder.ID))
            {
            
                this.InvMinOrder.Text = this.PreviousUIData[this.InvMinOrder.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMinOrder TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMinOrder is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMinOrderSpecified) {
                								
                // If the InvMinOrder is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMinOrder);
                                
                this.InvMinOrder.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMinOrder is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMinOrder.Text = InventoryTable.InvMinOrder.Format(InventoryTable.InvMinOrder.DefaultValue);
            		
            }
            
              this.InvMinOrder.TextChanged += InvMinOrder_TextChanged;
                               
        }
                
        public virtual void SetInvMinRequired()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvMinRequired.ID))
            {
            
                this.InvMinRequired.Text = this.PreviousUIData[this.InvMinRequired.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvMinRequired TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvMinRequired is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvMinRequiredSpecified) {
                								
                // If the InvMinRequired is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvMinRequired);
                                
                this.InvMinRequired.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvMinRequired is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvMinRequired.Text = InventoryTable.InvMinRequired.Format(InventoryTable.InvMinRequired.DefaultValue);
            		
            }
            
              this.InvMinRequired.TextChanged += InvMinRequired_TextChanged;
                               
        }
                
        public virtual void SetInvModels()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvModels.ID))
            {
            
                this.InvModels.Text = this.PreviousUIData[this.InvModels.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvModels TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvModels is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvModelsSpecified) {
                								
                // If the InvModels is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvModels);
                                
                this.InvModels.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvModels is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvModels.Text = InventoryTable.InvModels.Format(InventoryTable.InvModels.DefaultValue);
            		
            }
            
              this.InvModels.TextChanged += InvModels_TextChanged;
                               
        }
                
        public virtual void SetInvNonStockItem()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvNonStockItem.ID))
            {
                this.InvNonStockItem.Checked = Convert.ToBoolean(this.PreviousUIData[this.InvNonStockItem.ID]);
                return;
            }	
            
                    
            // Set the InvNonStockItem CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvNonStockItem is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvNonStockItemSpecified) {
                							
                // If the InvNonStockItem is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.InvNonStockItem.Checked = this.DataSource.InvNonStockItem;
                    				
            } else {
            
                // InvNonStockItem is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.InvNonStockItem.Checked = InventoryTable.InvNonStockItem.ParseValue(InventoryTable.InvNonStockItem.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetInvNotes()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvNotes.ID))
            {
            
                this.InvNotes.Text = this.PreviousUIData[this.InvNotes.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvNotes TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvNotes is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvNotesSpecified) {
                								
                // If the InvNotes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvNotes);
                                
                this.InvNotes.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvNotes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvNotes.Text = InventoryTable.InvNotes.Format(InventoryTable.InvNotes.DefaultValue);
            		
            }
            
              this.InvNotes.TextChanged += InvNotes_TextChanged;
                               
        }
                
        public virtual void SetInvPartNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvPartNo.ID))
            {
            
                this.InvPartNo.Text = this.PreviousUIData[this.InvPartNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvPartNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvPartNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvPartNoSpecified) {
                								
                // If the InvPartNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvPartNo);
                                
                this.InvPartNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvPartNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvPartNo.Text = InventoryTable.InvPartNo.Format(InventoryTable.InvPartNo.DefaultValue);
            		
            }
            
              this.InvPartNo.TextChanged += InvPartNo_TextChanged;
                               
        }
                
        public virtual void SetInvPickQuantity()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvPickQuantity.ID))
            {
            
                this.InvPickQuantity.Text = this.PreviousUIData[this.InvPickQuantity.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvPickQuantity TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvPickQuantity is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvPickQuantitySpecified) {
                								
                // If the InvPickQuantity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvPickQuantity);
                                
                this.InvPickQuantity.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvPickQuantity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvPickQuantity.Text = InventoryTable.InvPickQuantity.Format(InventoryTable.InvPickQuantity.DefaultValue);
            		
            }
            
              this.InvPickQuantity.TextChanged += InvPickQuantity_TextChanged;
                               
        }
                
        public virtual void SetInvPicturePath()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvPicturePath.ID))
            {
            
                this.InvPicturePath.Text = this.PreviousUIData[this.InvPicturePath.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvPicturePath TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvPicturePath is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvPicturePathSpecified) {
                								
                // If the InvPicturePath is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvPicturePath);
                                
                this.InvPicturePath.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvPicturePath is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvPicturePath.Text = InventoryTable.InvPicturePath.Format(InventoryTable.InvPicturePath.DefaultValue);
            		
            }
            
              this.InvPicturePath.TextChanged += InvPicturePath_TextChanged;
                               
        }
                
        public virtual void SetInvPrevBuyPrice()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvPrevBuyPrice.ID))
            {
            
                this.InvPrevBuyPrice.Text = this.PreviousUIData[this.InvPrevBuyPrice.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvPrevBuyPrice TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvPrevBuyPrice is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvPrevBuyPriceSpecified) {
                								
                // If the InvPrevBuyPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvPrevBuyPrice, @"C");
                                
                this.InvPrevBuyPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvPrevBuyPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvPrevBuyPrice.Text = InventoryTable.InvPrevBuyPrice.Format(InventoryTable.InvPrevBuyPrice.DefaultValue, @"C");
            		
            }
            
              this.InvPrevBuyPrice.TextChanged += InvPrevBuyPrice_TextChanged;
                               
        }
                
        public virtual void SetInvQuantity()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvQuantity.ID))
            {
            
                this.InvQuantity.Text = this.PreviousUIData[this.InvQuantity.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvQuantity TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvQuantity is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvQuantitySpecified) {
                								
                // If the InvQuantity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvQuantity);
                                
                this.InvQuantity.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvQuantity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvQuantity.Text = InventoryTable.InvQuantity.Format(InventoryTable.InvQuantity.DefaultValue);
            		
            }
            
              this.InvQuantity.TextChanged += InvQuantity_TextChanged;
                               
        }
                
        public virtual void SetInvReference1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvReference1.ID))
            {
            
                this.InvReference1.Text = this.PreviousUIData[this.InvReference1.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvReference1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReference1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReference1Specified) {
                								
                // If the InvReference1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReference1);
                                
                this.InvReference1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReference1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReference1.Text = InventoryTable.InvReference1.Format(InventoryTable.InvReference1.DefaultValue);
            		
            }
            
              this.InvReference1.TextChanged += InvReference1_TextChanged;
                               
        }
                
        public virtual void SetInvReference2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvReference2.ID))
            {
            
                this.InvReference2.Text = this.PreviousUIData[this.InvReference2.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvReference2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReference2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReference2Specified) {
                								
                // If the InvReference2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReference2);
                                
                this.InvReference2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReference2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReference2.Text = InventoryTable.InvReference2.Format(InventoryTable.InvReference2.DefaultValue);
            		
            }
            
              this.InvReference2.TextChanged += InvReference2_TextChanged;
                               
        }
                
        public virtual void SetInvReference3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvReference3.ID))
            {
            
                this.InvReference3.Text = this.PreviousUIData[this.InvReference3.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvReference3 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReference3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReference3Specified) {
                								
                // If the InvReference3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReference3);
                                
                this.InvReference3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReference3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReference3.Text = InventoryTable.InvReference3.Format(InventoryTable.InvReference3.DefaultValue);
            		
            }
            
              this.InvReference3.TextChanged += InvReference3_TextChanged;
                               
        }
                
        public virtual void SetInvReference4()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvReference4.ID))
            {
            
                this.InvReference4.Text = this.PreviousUIData[this.InvReference4.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvReference4 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReference4 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReference4Specified) {
                								
                // If the InvReference4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReference4);
                                
                this.InvReference4.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReference4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReference4.Text = InventoryTable.InvReference4.Format(InventoryTable.InvReference4.DefaultValue);
            		
            }
            
              this.InvReference4.TextChanged += InvReference4_TextChanged;
                               
        }
                
        public virtual void SetInvReplacement()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvReplacement.ID))
            {
            
                this.InvReplacement.Text = this.PreviousUIData[this.InvReplacement.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvReplacement TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvReplacement is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvReplacementSpecified) {
                								
                // If the InvReplacement is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvReplacement);
                                
                this.InvReplacement.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvReplacement is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvReplacement.Text = InventoryTable.InvReplacement.Format(InventoryTable.InvReplacement.DefaultValue);
            		
            }
            
              this.InvReplacement.TextChanged += InvReplacement_TextChanged;
                               
        }
                
        public virtual void SetInvSellPrice0()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvSellPrice0.ID))
            {
            
                this.InvSellPrice0.Text = this.PreviousUIData[this.InvSellPrice0.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvSellPrice0 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice0 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice0Specified) {
                								
                // If the InvSellPrice0 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice0, @"C");
                                
                this.InvSellPrice0.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice0 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice0.Text = InventoryTable.InvSellPrice0.Format(InventoryTable.InvSellPrice0.DefaultValue, @"C");
            		
            }
            
              this.InvSellPrice0.TextChanged += InvSellPrice0_TextChanged;
                               
        }
                
        public virtual void SetInvSellPrice1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvSellPrice1.ID))
            {
            
                this.InvSellPrice1.Text = this.PreviousUIData[this.InvSellPrice1.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvSellPrice1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice1Specified) {
                								
                // If the InvSellPrice1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice1, @"C");
                                
                this.InvSellPrice1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice1.Text = InventoryTable.InvSellPrice1.Format(InventoryTable.InvSellPrice1.DefaultValue, @"C");
            		
            }
            
              this.InvSellPrice1.TextChanged += InvSellPrice1_TextChanged;
                               
        }
                
        public virtual void SetInvSellPrice2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvSellPrice2.ID))
            {
            
                this.InvSellPrice2.Text = this.PreviousUIData[this.InvSellPrice2.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvSellPrice2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice2Specified) {
                								
                // If the InvSellPrice2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice2, @"C");
                                
                this.InvSellPrice2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice2.Text = InventoryTable.InvSellPrice2.Format(InventoryTable.InvSellPrice2.DefaultValue, @"C");
            		
            }
            
              this.InvSellPrice2.TextChanged += InvSellPrice2_TextChanged;
                               
        }
                
        public virtual void SetInvSellPrice3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvSellPrice3.ID))
            {
            
                this.InvSellPrice3.Text = this.PreviousUIData[this.InvSellPrice3.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvSellPrice3 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice3Specified) {
                								
                // If the InvSellPrice3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice3, @"C");
                                
                this.InvSellPrice3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice3.Text = InventoryTable.InvSellPrice3.Format(InventoryTable.InvSellPrice3.DefaultValue, @"C");
            		
            }
            
              this.InvSellPrice3.TextChanged += InvSellPrice3_TextChanged;
                               
        }
                
        public virtual void SetInvSellPrice4()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvSellPrice4.ID))
            {
            
                this.InvSellPrice4.Text = this.PreviousUIData[this.InvSellPrice4.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvSellPrice4 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvSellPrice4 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvSellPrice4Specified) {
                								
                // If the InvSellPrice4 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvSellPrice4, @"C");
                                
                this.InvSellPrice4.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvSellPrice4 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvSellPrice4.Text = InventoryTable.InvSellPrice4.Format(InventoryTable.InvSellPrice4.DefaultValue, @"C");
            		
            }
            
              this.InvSellPrice4.TextChanged += InvSellPrice4_TextChanged;
                               
        }
                
        public virtual void SetInvShare()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvShare.ID))
            {
                this.InvShare.Checked = Convert.ToBoolean(this.PreviousUIData[this.InvShare.ID]);
                return;
            }	
            
                    
            // Set the InvShare CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvShare is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvShareSpecified) {
                							
                // If the InvShare is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.InvShare.Checked = this.DataSource.InvShare;
                    				
            } else {
            
                // InvShare is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.InvShare.Checked = InventoryTable.InvShare.ParseValue(InventoryTable.InvShare.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetInvStatus()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvStatus.ID))
            {
            
                this.InvStatus.Text = this.PreviousUIData[this.InvStatus.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvStatus TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvStatus is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvStatusSpecified) {
                								
                // If the InvStatus is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvStatus);
                                
                this.InvStatus.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvStatus is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvStatus.Text = InventoryTable.InvStatus.Format(InventoryTable.InvStatus.DefaultValue);
            		
            }
            
              this.InvStatus.TextChanged += InvStatus_TextChanged;
                               
        }
                
        public virtual void SetInvVendNo1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvVendNo1.ID))
            {
            
                this.InvVendNo1.Text = this.PreviousUIData[this.InvVendNo1.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvVendNo1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendNo1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendNo1Specified) {
                								
                // If the InvVendNo1 is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = this.DataSource.InvVendNo1.ToString();
                            
                this.InvVendNo1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendNo1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendNo1.Text = InventoryTable.InvVendNo1.DefaultValue;
            		
            }
            
              this.InvVendNo1.TextChanged += InvVendNo1_TextChanged;
                               
        }
                
        public virtual void SetInvVendNo2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvVendNo2.ID))
            {
            
                this.InvVendNo2.Text = this.PreviousUIData[this.InvVendNo2.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvVendNo2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendNo2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendNo2Specified) {
                								
                // If the InvVendNo2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendNo2);
                                
                this.InvVendNo2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendNo2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendNo2.Text = InventoryTable.InvVendNo2.Format(InventoryTable.InvVendNo2.DefaultValue);
            		
            }
            
              this.InvVendNo2.TextChanged += InvVendNo2_TextChanged;
                               
        }
                
        public virtual void SetInvVendNo3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvVendNo3.ID))
            {
            
                this.InvVendNo3.Text = this.PreviousUIData[this.InvVendNo3.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvVendNo3 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendNo3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendNo3Specified) {
                								
                // If the InvVendNo3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendNo3);
                                
                this.InvVendNo3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendNo3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendNo3.Text = InventoryTable.InvVendNo3.Format(InventoryTable.InvVendNo3.DefaultValue);
            		
            }
            
              this.InvVendNo3.TextChanged += InvVendNo3_TextChanged;
                               
        }
                
        public virtual void SetInvVendorPartNo1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvVendorPartNo1.ID))
            {
            
                this.InvVendorPartNo1.Text = this.PreviousUIData[this.InvVendorPartNo1.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvVendorPartNo1 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendorPartNo1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendorPartNo1Specified) {
                								
                // If the InvVendorPartNo1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendorPartNo1);
                                
                this.InvVendorPartNo1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendorPartNo1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendorPartNo1.Text = InventoryTable.InvVendorPartNo1.Format(InventoryTable.InvVendorPartNo1.DefaultValue);
            		
            }
            
              this.InvVendorPartNo1.TextChanged += InvVendorPartNo1_TextChanged;
                               
        }
                
        public virtual void SetInvVendorPartNo2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvVendorPartNo2.ID))
            {
            
                this.InvVendorPartNo2.Text = this.PreviousUIData[this.InvVendorPartNo2.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvVendorPartNo2 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendorPartNo2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendorPartNo2Specified) {
                								
                // If the InvVendorPartNo2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendorPartNo2);
                                
                this.InvVendorPartNo2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendorPartNo2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendorPartNo2.Text = InventoryTable.InvVendorPartNo2.Format(InventoryTable.InvVendorPartNo2.DefaultValue);
            		
            }
            
              this.InvVendorPartNo2.TextChanged += InvVendorPartNo2_TextChanged;
                               
        }
                
        public virtual void SetInvVendorPartNo3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvVendorPartNo3.ID))
            {
            
                this.InvVendorPartNo3.Text = this.PreviousUIData[this.InvVendorPartNo3.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvVendorPartNo3 TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.InvVendorPartNo3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvVendorPartNo3Specified) {
                								
                // If the InvVendorPartNo3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InventoryTable.InvVendorPartNo3);
                                
                this.InvVendorPartNo3.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvVendorPartNo3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvVendorPartNo3.Text = InventoryTable.InvVendorPartNo3.Format(InventoryTable.InvVendorPartNo3.DefaultValue);
            		
            }
            
              this.InvVendorPartNo3.TextChanged += InvVendorPartNo3_TextChanged;
                               
        }
                
        public virtual void SetLastExtraction()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LastExtraction.ID))
            {
                this.LastExtraction.Checked = Convert.ToBoolean(this.PreviousUIData[this.LastExtraction.ID]);
                return;
            }	
            
                    
            // Set the LastExtraction CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.Inventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.Inventory record retrieved from the database.
            // this.LastExtraction is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastExtractionSpecified) {
                							
                // If the LastExtraction is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.LastExtraction.Checked = this.DataSource.LastExtraction;
                    				
            } else {
            
                // LastExtraction is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.LastExtraction.Checked = InventoryTable.LastExtraction.ParseValue(InventoryTable.LastExtraction.DefaultValue).ToBoolean();                
                    									
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
                ((InventoryTableControl)MiscUtils.GetParentControlObject(this, "InventoryTableControl")).DataChanged = true;
                ((InventoryTableControl)MiscUtils.GetParentControlObject(this, "InventoryTableControl")).ResetData = true;
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
            
            // Retrieve the value entered by the user on the InvAvgBuyPrice ASP:TextBox, and
            // save it into the InvAvgBuyPrice field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvAvgBuyPrice.Text, InventoryTable.InvAvgBuyPrice);							
                          
                      
        }
                
        public virtual void GetInvBin()
        {
            
            // Retrieve the value entered by the user on the InvBin ASP:TextBox, and
            // save it into the InvBin field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvBin.Text, InventoryTable.InvBin);							
                          
                      
        }
                
        public virtual void GetInvCategory()
        {
            
            // Retrieve the value entered by the user on the InvCategory ASP:TextBox, and
            // save it into the InvCategory field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvCategory.Text, InventoryTable.InvCategory);							
                          
                      
        }
                
        public virtual void GetInvCustom1()
        {
            
            // Retrieve the value entered by the user on the InvCustom1 ASP:TextBox, and
            // save it into the InvCustom1 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvCustom1.Text, InventoryTable.InvCustom1);							
                          
                      
        }
                
        public virtual void GetInvCustom2()
        {
            
            // Retrieve the value entered by the user on the InvCustom2 ASP:TextBox, and
            // save it into the InvCustom2 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvCustom2.Text, InventoryTable.InvCustom2);							
                          
                      
        }
                
        public virtual void GetInvDateRecordAdded()
        {
            
            // Retrieve the value entered by the user on the InvDateRecordAdded ASP:TextBox, and
            // save it into the InvDateRecordAdded field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvDateRecordAdded.Text, InventoryTable.InvDateRecordAdded);							
                          
                      
        }
                
        public virtual void GetInvDateRecordUpdated()
        {
            
            // Retrieve the value entered by the user on the InvDateRecordUpdated ASP:TextBox, and
            // save it into the InvDateRecordUpdated field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvDateRecordUpdated.Text, InventoryTable.InvDateRecordUpdated);							
                          
                      
        }
                
        public virtual void GetInvExportInclude()
        {	
        		
            // Retrieve the value entered by the user on the InvExportInclude ASP:CheckBox, and
            // save it into the InvExportInclude field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.InvExportInclude = this.InvExportInclude.Checked;						
                    
        }
                
        public virtual void GetInvExportRecordChanged()
        {	
        		
            // Retrieve the value entered by the user on the InvExportRecordChanged ASP:CheckBox, and
            // save it into the InvExportRecordChanged field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.InvExportRecordChanged = this.InvExportRecordChanged.Checked;						
                    
        }
                
        public virtual void GetInvItemDesc()
        {
            
            // Retrieve the value entered by the user on the InvItemDesc ASP:TextBox, and
            // save it into the InvItemDesc field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvItemDesc.Text, InventoryTable.InvItemDesc);							
                          
                      
        }
                
        public virtual void GetInvLastBuyPrice()
        {
            
            // Retrieve the value entered by the user on the InvLastBuyPrice ASP:TextBox, and
            // save it into the InvLastBuyPrice field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvLastBuyPrice.Text, InventoryTable.InvLastBuyPrice);							
                          
                      
        }
                
        public virtual void GetInvLocation()
        {
            
            // Retrieve the value entered by the user on the InvLocation ASP:TextBox, and
            // save it into the InvLocation field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvLocation.Text, InventoryTable.InvLocation);							
                          
                      
        }
                
        public virtual void GetInvMake()
        {
            
            // Retrieve the value entered by the user on the InvMake ASP:TextBox, and
            // save it into the InvMake field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMake.Text, InventoryTable.InvMake);							
                          
                      
        }
                
        public virtual void GetInvMarkupRate0()
        {
            
            // Retrieve the value entered by the user on the InvMarkupRate0 ASP:TextBox, and
            // save it into the InvMarkupRate0 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupRate0.Text, InventoryTable.InvMarkupRate0);							
                          
                      
        }
                
        public virtual void GetInvMarkupRate1()
        {
            
            // Retrieve the value entered by the user on the InvMarkupRate1 ASP:TextBox, and
            // save it into the InvMarkupRate1 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupRate1.Text, InventoryTable.InvMarkupRate1);							
                          
                      
        }
                
        public virtual void GetInvMarkupRate2()
        {
            
            // Retrieve the value entered by the user on the InvMarkupRate2 ASP:TextBox, and
            // save it into the InvMarkupRate2 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupRate2.Text, InventoryTable.InvMarkupRate2);							
                          
                      
        }
                
        public virtual void GetInvMarkupRate3()
        {
            
            // Retrieve the value entered by the user on the InvMarkupRate3 ASP:TextBox, and
            // save it into the InvMarkupRate3 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupRate3.Text, InventoryTable.InvMarkupRate3);							
                          
                      
        }
                
        public virtual void GetInvMarkupRate4()
        {
            
            // Retrieve the value entered by the user on the InvMarkupRate4 ASP:TextBox, and
            // save it into the InvMarkupRate4 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupRate4.Text, InventoryTable.InvMarkupRate4);							
                          
                      
        }
                
        public virtual void GetInvMarkupType0()
        {
            
            // Retrieve the value entered by the user on the InvMarkupType0 ASP:TextBox, and
            // save it into the InvMarkupType0 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupType0.Text, InventoryTable.InvMarkupType0);							
                          
                      
        }
                
        public virtual void GetInvMarkupType1()
        {
            
            // Retrieve the value entered by the user on the InvMarkupType1 ASP:TextBox, and
            // save it into the InvMarkupType1 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupType1.Text, InventoryTable.InvMarkupType1);							
                          
                      
        }
                
        public virtual void GetInvMarkupType2()
        {
            
            // Retrieve the value entered by the user on the InvMarkupType2 ASP:TextBox, and
            // save it into the InvMarkupType2 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupType2.Text, InventoryTable.InvMarkupType2);							
                          
                      
        }
                
        public virtual void GetInvMarkupType3()
        {
            
            // Retrieve the value entered by the user on the InvMarkupType3 ASP:TextBox, and
            // save it into the InvMarkupType3 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupType3.Text, InventoryTable.InvMarkupType3);							
                          
                      
        }
                
        public virtual void GetInvMarkupType4()
        {
            
            // Retrieve the value entered by the user on the InvMarkupType4 ASP:TextBox, and
            // save it into the InvMarkupType4 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMarkupType4.Text, InventoryTable.InvMarkupType4);							
                          
                      
        }
                
        public virtual void GetInvMinOrder()
        {
            
            // Retrieve the value entered by the user on the InvMinOrder ASP:TextBox, and
            // save it into the InvMinOrder field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMinOrder.Text, InventoryTable.InvMinOrder);							
                          
                      
        }
                
        public virtual void GetInvMinRequired()
        {
            
            // Retrieve the value entered by the user on the InvMinRequired ASP:TextBox, and
            // save it into the InvMinRequired field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvMinRequired.Text, InventoryTable.InvMinRequired);							
                          
                      
        }
                
        public virtual void GetInvModels()
        {
            
            // Retrieve the value entered by the user on the InvModels ASP:TextBox, and
            // save it into the InvModels field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvModels.Text, InventoryTable.InvModels);							
                          
                      
        }
                
        public virtual void GetInvNonStockItem()
        {	
        		
            // Retrieve the value entered by the user on the InvNonStockItem ASP:CheckBox, and
            // save it into the InvNonStockItem field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.InvNonStockItem = this.InvNonStockItem.Checked;						
                    
        }
                
        public virtual void GetInvNotes()
        {
            
            // Retrieve the value entered by the user on the InvNotes ASP:TextBox, and
            // save it into the InvNotes field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvNotes.Text, InventoryTable.InvNotes);							
                          
                      
        }
                
        public virtual void GetInvPartNo()
        {
            
            // Retrieve the value entered by the user on the InvPartNo ASP:TextBox, and
            // save it into the InvPartNo field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvPartNo.Text, InventoryTable.InvPartNo);							
                          
                      
        }
                
        public virtual void GetInvPickQuantity()
        {
            
            // Retrieve the value entered by the user on the InvPickQuantity ASP:TextBox, and
            // save it into the InvPickQuantity field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvPickQuantity.Text, InventoryTable.InvPickQuantity);							
                          
                      
        }
                
        public virtual void GetInvPicturePath()
        {
            
            // Retrieve the value entered by the user on the InvPicturePath ASP:TextBox, and
            // save it into the InvPicturePath field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvPicturePath.Text, InventoryTable.InvPicturePath);							
                          
                      
        }
                
        public virtual void GetInvPrevBuyPrice()
        {
            
            // Retrieve the value entered by the user on the InvPrevBuyPrice ASP:TextBox, and
            // save it into the InvPrevBuyPrice field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvPrevBuyPrice.Text, InventoryTable.InvPrevBuyPrice);							
                          
                      
        }
                
        public virtual void GetInvQuantity()
        {
            
            // Retrieve the value entered by the user on the InvQuantity ASP:TextBox, and
            // save it into the InvQuantity field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvQuantity.Text, InventoryTable.InvQuantity);							
                          
                      
        }
                
        public virtual void GetInvReference1()
        {
            
            // Retrieve the value entered by the user on the InvReference1 ASP:TextBox, and
            // save it into the InvReference1 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvReference1.Text, InventoryTable.InvReference1);							
                          
                      
        }
                
        public virtual void GetInvReference2()
        {
            
            // Retrieve the value entered by the user on the InvReference2 ASP:TextBox, and
            // save it into the InvReference2 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvReference2.Text, InventoryTable.InvReference2);							
                          
                      
        }
                
        public virtual void GetInvReference3()
        {
            
            // Retrieve the value entered by the user on the InvReference3 ASP:TextBox, and
            // save it into the InvReference3 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvReference3.Text, InventoryTable.InvReference3);							
                          
                      
        }
                
        public virtual void GetInvReference4()
        {
            
            // Retrieve the value entered by the user on the InvReference4 ASP:TextBox, and
            // save it into the InvReference4 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvReference4.Text, InventoryTable.InvReference4);							
                          
                      
        }
                
        public virtual void GetInvReplacement()
        {
            
            // Retrieve the value entered by the user on the InvReplacement ASP:TextBox, and
            // save it into the InvReplacement field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvReplacement.Text, InventoryTable.InvReplacement);							
                          
                      
        }
                
        public virtual void GetInvSellPrice0()
        {
            
            // Retrieve the value entered by the user on the InvSellPrice0 ASP:TextBox, and
            // save it into the InvSellPrice0 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvSellPrice0.Text, InventoryTable.InvSellPrice0);							
                          
                      
        }
                
        public virtual void GetInvSellPrice1()
        {
            
            // Retrieve the value entered by the user on the InvSellPrice1 ASP:TextBox, and
            // save it into the InvSellPrice1 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvSellPrice1.Text, InventoryTable.InvSellPrice1);							
                          
                      
        }
                
        public virtual void GetInvSellPrice2()
        {
            
            // Retrieve the value entered by the user on the InvSellPrice2 ASP:TextBox, and
            // save it into the InvSellPrice2 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvSellPrice2.Text, InventoryTable.InvSellPrice2);							
                          
                      
        }
                
        public virtual void GetInvSellPrice3()
        {
            
            // Retrieve the value entered by the user on the InvSellPrice3 ASP:TextBox, and
            // save it into the InvSellPrice3 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvSellPrice3.Text, InventoryTable.InvSellPrice3);							
                          
                      
        }
                
        public virtual void GetInvSellPrice4()
        {
            
            // Retrieve the value entered by the user on the InvSellPrice4 ASP:TextBox, and
            // save it into the InvSellPrice4 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvSellPrice4.Text, InventoryTable.InvSellPrice4);							
                          
                      
        }
                
        public virtual void GetInvShare()
        {	
        		
            // Retrieve the value entered by the user on the InvShare ASP:CheckBox, and
            // save it into the InvShare field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.InvShare = this.InvShare.Checked;						
                    
        }
                
        public virtual void GetInvStatus()
        {
            
            // Retrieve the value entered by the user on the InvStatus ASP:TextBox, and
            // save it into the InvStatus field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvStatus.Text, InventoryTable.InvStatus);							
                          
                      
        }
                
        public virtual void GetInvVendNo1()
        {
            
            // Retrieve the value entered by the user on the InvVendNo1 ASP:TextBox, and
            // save it into the InvVendNo1 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvVendNo1.Text, InventoryTable.InvVendNo1);							
                          
                      
        }
                
        public virtual void GetInvVendNo2()
        {
            
            // Retrieve the value entered by the user on the InvVendNo2 ASP:TextBox, and
            // save it into the InvVendNo2 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvVendNo2.Text, InventoryTable.InvVendNo2);							
                          
                      
        }
                
        public virtual void GetInvVendNo3()
        {
            
            // Retrieve the value entered by the user on the InvVendNo3 ASP:TextBox, and
            // save it into the InvVendNo3 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvVendNo3.Text, InventoryTable.InvVendNo3);							
                          
                      
        }
                
        public virtual void GetInvVendorPartNo1()
        {
            
            // Retrieve the value entered by the user on the InvVendorPartNo1 ASP:TextBox, and
            // save it into the InvVendorPartNo1 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvVendorPartNo1.Text, InventoryTable.InvVendorPartNo1);							
                          
                      
        }
                
        public virtual void GetInvVendorPartNo2()
        {
            
            // Retrieve the value entered by the user on the InvVendorPartNo2 ASP:TextBox, and
            // save it into the InvVendorPartNo2 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvVendorPartNo2.Text, InventoryTable.InvVendorPartNo2);							
                          
                      
        }
                
        public virtual void GetInvVendorPartNo3()
        {
            
            // Retrieve the value entered by the user on the InvVendorPartNo3 ASP:TextBox, and
            // save it into the InvVendorPartNo3 field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvVendorPartNo3.Text, InventoryTable.InvVendorPartNo3);							
                          
                      
        }
                
        public virtual void GetLastExtraction()
        {	
        		
            // Retrieve the value entered by the user on the LastExtraction ASP:CheckBox, and
            // save it into the LastExtraction field in DataSource DatabaseAYS_OEM%dbo.Inventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.LastExtraction = this.LastExtraction.Checked;						
                    
        }
                

      // To customize, override this method in InventoryTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersInventoryTableControl = false;
            hasFiltersInventoryTableControl = hasFiltersInventoryTableControl && false; // suppress warning
      
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
          InventoryTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((InventoryTableControl)MiscUtils.GetParentControlObject(this, "InventoryTableControl")).DataChanged = true;
            ((InventoryTableControl)MiscUtils.GetParentControlObject(this, "InventoryTableControl")).ResetData = true;
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
            
        public virtual void SetViewRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        InventoryTableControl tc= ((InventoryTableControl)MiscUtils.GetParentControlObject(this, "InventoryTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((InventoryTableControlRow)this);
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
            
            
        
        // event handler for ImageButton
        public virtual void ViewRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Inventory/Show-Inventory.aspx?Inventory={PK}";
            
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
            
            
        
        protected virtual void InvExportInclude_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void InvExportRecordChanged_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void InvNonStockItem_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void InvShare_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void LastExtraction_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void InvAvgBuyPrice_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvBin_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvCategory_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvCustom1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvCustom2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvDateRecordAdded_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvDateRecordUpdated_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvItemDesc_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvLastBuyPrice_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvLocation_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMake_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupRate0_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupRate1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupRate2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupRate3_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupRate4_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupType0_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupType1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupType2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupType3_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMarkupType4_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMinOrder_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvMinRequired_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvModels_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvNotes_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvPartNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvPickQuantity_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvPicturePath_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvPrevBuyPrice_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvQuantity_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvReference1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvReference2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvReference3_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvReference4_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvReplacement_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvSellPrice0_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvSellPrice1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvSellPrice2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvSellPrice3_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvSellPrice4_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvStatus_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvVendNo1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvVendNo2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvVendNo3_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvVendorPartNo1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvVendorPartNo2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvVendorPartNo3_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseInventoryTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseInventoryTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.TextBox InvAvgBuyPrice {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvAvgBuyPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvAvgBuyPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvAvgBuyPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvBin {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvBin");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvBinLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvBinLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvCategory {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCategory");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvCategoryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCategoryLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvCustom1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCustom1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvCustom1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCustom1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvCustom2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCustom2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvCustom2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCustom2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvDateRecordAdded {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvDateRecordAdded");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvDateRecordAddedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvDateRecordAddedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvDateRecordUpdated {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvDateRecordUpdated");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvDateRecordUpdatedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvDateRecordUpdatedLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox InvExportInclude {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvExportInclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvExportIncludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvExportIncludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox InvExportRecordChanged {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvExportRecordChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvExportRecordChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvExportRecordChangedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvItemDesc {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvItemDesc");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvItemDescLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvItemDescLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvLastBuyPrice {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLastBuyPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvLastBuyPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLastBuyPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvLocation {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLocation");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvLocationLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLocationLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMake {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMake");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMakeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMakeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupRate0 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate0");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate0Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate0Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupRate1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupRate2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupRate3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate3Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupRate4 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate4");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupRate4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupRate4Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupType0 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType0");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType0Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType0Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupType1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupType2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupType3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType3Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMarkupType4 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType4");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMarkupType4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMarkupType4Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMinOrder {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMinOrder");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMinOrderLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMinOrderLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvMinRequired {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMinRequired");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvMinRequiredLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvMinRequiredLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvModels {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvModels");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvModelsLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvModelsLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox InvNonStockItem {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNonStockItem");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvNonStockItemLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNonStockItemLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvNotes {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNotes");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvNotesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvNotesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvPartNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPartNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvPartNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPartNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvPickQuantity {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPickQuantity");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvPickQuantityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPickQuantityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvPicturePath {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPicturePath");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvPicturePathLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPicturePathLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvPrevBuyPrice {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPrevBuyPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvPrevBuyPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvPrevBuyPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvQuantity {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvQuantity");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvQuantityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvQuantityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvReference1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReference1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvReference2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReference2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvReference3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReference3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference3Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvReference4 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference4");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReference4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReference4Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvReplacement {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReplacement");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvReplacementLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvReplacementLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvSellPrice0 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice0");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice0Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice0Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvSellPrice1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvSellPrice2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvSellPrice3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice3Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvSellPrice4 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice4");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvSellPrice4Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvSellPrice4Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox InvShare {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvShare");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvShareLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvShareLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvStatus {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvStatus");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvStatusLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvStatusLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvVendNo1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendNo1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvVendNo2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendNo2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvVendNo3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendNo3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendNo3Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvVendorPartNo1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendorPartNo1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvVendorPartNo2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendorPartNo2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvVendorPartNo3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo3");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvVendorPartNo3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvVendorPartNo3Label");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox LastExtraction {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastExtraction");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastExtractionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastExtractionLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SelectRow {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow");
            }
        }              
            
        public System.Web.UI.WebControls.ImageButton ViewRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ViewRowButton");
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

  
// Base class for the InventoryTableControl control on the Edit_Inventory_Table page.
// Do not modify this class. Instead override any method in InventoryTableControl.
public class BaseInventoryTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseInventoryTableControl()
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
                
                if  (this.InSession(this.OrderSort)) 				
                    initialVal = this.GetFromSession(this.OrderSort);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.InvCategoryFilter)) 				
                    initialVal = this.GetFromSession(this.InvCategoryFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"InvCategory\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] InvCategoryFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in InvCategoryFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.InvCategoryFilter.Items.Add(item);
                            this.InvCategoryFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.InvCategoryFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.InvLocationFromFilter)) 				
                    initialVal = this.GetFromSession(this.InvLocationFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"InvLocationFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.InvLocationFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.InvLocationToFilter)) 				
                    initialVal = this.GetFromSession(this.InvLocationToFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"InvLocationTo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.InvLocationToFilter.Text = initialVal;
                            
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
        
              // Show confirmation message on Click
              this.DeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "OEMConversion") + "\"));");
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
          
                    this.AddButton.Click += AddButton_Click;
                        
                    this.DeleteButton.Click += DeleteButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SaveButton.Click += SaveButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
              this.InvCategoryFilter.SelectedIndexChanged += InvCategoryFilter_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.InventoryRecord);
                      this.DataSource = (InventoryRecord[])(alist.ToArray(myrec));
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
                    foreach (InventoryTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.InventoryRecord);
                    this.DataSource = (InventoryRecord[])(postdata.ToArray(myrec));
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
        
        public virtual InventoryRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(InventoryTable.Column1, true);          
            // selCols.Add(InventoryTable.Column2, true);          
            // selCols.Add(InventoryTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return InventoryTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                InventoryTable databaseTable = new InventoryTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(InventoryRecord)) as InventoryRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(InventoryTable.Column1, true);          
            // selCols.Add(InventoryTable.Column2, true);          
            // selCols.Add(InventoryTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return InventoryTable.GetRecordCount(join, where);
            else
            {
                InventoryTable databaseTable = new InventoryTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InventoryTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            InventoryTableControlRow recControl = (InventoryTableControlRow)(repItem.FindControl("InventoryTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                SetInvCategoryFilter();
                SetInvCategoryLabel1();
                
                SetInvLocationLabel1();
                
                
                SetOrderSort();
                
                
                
                
                SetSearchText();
                SetSortByLabel();
                
                
                SetAddButton();
              
                SetDeleteButton();
              
                SetResetButton();
              
                SetSaveButton();
              
                SetSearchButton();
              
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
          
            this.Page.PregetDfkaRecords(InventoryTable.InvVendNo1, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"SaveButton"));
                                
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


            
            this.InvCategoryFilter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
            this.InvLocationFromFilter.Text = "";
            
            this.InvLocationToFilter.Text = "";
            
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
    
            // Bind the buttons for InventoryTableControl pagination.
        
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
              
            foreach (InventoryTableControlRow recCtl in this.GetRecordControls())
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
            foreach (InventoryTableControlRow recCtl in this.GetRecordControls()){
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
            InventoryTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.InvCategoryFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.InvCategoryFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.InvCategoryFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(InventoryTable.InvCategory, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.InvLocationFromFilter)) {
                        
                wc.iAND(InventoryTable.InvLocation, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(this.InvLocationFromFilter, this.GetFromSession(this.InvLocationFromFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.InvLocationToFilter)) {
                        
                wc.iAND(InventoryTable.InvLocation, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(this.InvLocationToFilter, this.GetFromSession(this.InvLocationToFilter)), false, false);
                    
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
      
      cols.Add(InventoryTable.InvCategory, true);
      
      cols.Add(InventoryTable.InvMake, true);
      
      cols.Add(InventoryTable.InvPartNo, true);
      
      cols.Add(InventoryTable.InvReference1, true);
      
      cols.Add(InventoryTable.InvReference2, true);
      
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
            InventoryTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String InvCategoryFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "InvCategoryFilter_Ajax"];
            if (MiscUtils.IsValueSelected(InvCategoryFilterSelectedValue)) {

              
        if (InvCategoryFilterSelectedValue != null){
                        string[] InvCategoryFilteritemListFromSession = InvCategoryFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in InvCategoryFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(InventoryTable.InvCategory, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
      String InvLocationFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "InvLocationFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(InvLocationFromFilterSelectedValue)) {

              
                wc.iAND(InventoryTable.InvLocation, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, InvLocationFromFilterSelectedValue, false, false);
                      
      }
                      
      String InvLocationToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "InvLocationToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(InvLocationToFilterSelectedValue)) {

              
                wc.iAND(InventoryTable.InvLocation, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, InvLocationToFilterSelectedValue, false, false);
                      
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
      
      cols.Add(InventoryTable.InvCategory, true);
      
      cols.Add(InventoryTable.InvMake, true);
      
      cols.Add(InventoryTable.InvPartNo, true);
      
      cols.Add(InventoryTable.InvReference1, true);
      
      cols.Add(InventoryTable.InvReference2, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(InventoryTable.InvCategory, true);
      
      cols.Add(InventoryTable.InvMake, true);
      
      cols.Add(InventoryTable.InvPartNo, true);
      
      cols.Add(InventoryTable.InvReference1, true);
      
      cols.Add(InventoryTable.InvReference2, true);
      
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
            OEMConversion.Business.InventoryRecord[] recordList  = InventoryTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (InventoryRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(InventoryTable.InvCategory);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(InventoryTable.InvCategory.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, InventoryTable.InvCategory.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(InventoryTable.InvMake);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(InventoryTable.InvMake.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, InventoryTable.InvMake.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(InventoryTable.InvPartNo);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(InventoryTable.InvPartNo.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, InventoryTable.InvPartNo.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(InventoryTable.InvReference1);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(InventoryTable.InvReference1.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, InventoryTable.InvReference1.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(InventoryTable.InvReference2);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(InventoryTable.InvReference2.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, InventoryTable.InvReference2.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InventoryTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                InventoryTableControlRow recControl = (InventoryTableControlRow)(repItem.FindControl("InventoryTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      InventoryRecord rec = new InventoryRecord();
        
                        if (recControl.InvAvgBuyPrice.Text != "") {
                            rec.Parse(recControl.InvAvgBuyPrice.Text, InventoryTable.InvAvgBuyPrice);
                  }
                
                        if (recControl.InvBin.Text != "") {
                            rec.Parse(recControl.InvBin.Text, InventoryTable.InvBin);
                  }
                
                        if (recControl.InvCategory.Text != "") {
                            rec.Parse(recControl.InvCategory.Text, InventoryTable.InvCategory);
                  }
                
                        if (recControl.InvCustom1.Text != "") {
                            rec.Parse(recControl.InvCustom1.Text, InventoryTable.InvCustom1);
                  }
                
                        if (recControl.InvCustom2.Text != "") {
                            rec.Parse(recControl.InvCustom2.Text, InventoryTable.InvCustom2);
                  }
                
                        if (recControl.InvDateRecordAdded.Text != "") {
                            rec.Parse(recControl.InvDateRecordAdded.Text, InventoryTable.InvDateRecordAdded);
                  }
                
                        if (recControl.InvDateRecordUpdated.Text != "") {
                            rec.Parse(recControl.InvDateRecordUpdated.Text, InventoryTable.InvDateRecordUpdated);
                  }
                
                        rec.InvExportInclude = recControl.InvExportInclude.Checked;
                
                        rec.InvExportRecordChanged = recControl.InvExportRecordChanged.Checked;
                
                        if (recControl.InvItemDesc.Text != "") {
                            rec.Parse(recControl.InvItemDesc.Text, InventoryTable.InvItemDesc);
                  }
                
                        if (recControl.InvLastBuyPrice.Text != "") {
                            rec.Parse(recControl.InvLastBuyPrice.Text, InventoryTable.InvLastBuyPrice);
                  }
                
                        if (recControl.InvLocation.Text != "") {
                            rec.Parse(recControl.InvLocation.Text, InventoryTable.InvLocation);
                  }
                
                        if (recControl.InvMake.Text != "") {
                            rec.Parse(recControl.InvMake.Text, InventoryTable.InvMake);
                  }
                
                        if (recControl.InvMarkupRate0.Text != "") {
                            rec.Parse(recControl.InvMarkupRate0.Text, InventoryTable.InvMarkupRate0);
                  }
                
                        if (recControl.InvMarkupRate1.Text != "") {
                            rec.Parse(recControl.InvMarkupRate1.Text, InventoryTable.InvMarkupRate1);
                  }
                
                        if (recControl.InvMarkupRate2.Text != "") {
                            rec.Parse(recControl.InvMarkupRate2.Text, InventoryTable.InvMarkupRate2);
                  }
                
                        if (recControl.InvMarkupRate3.Text != "") {
                            rec.Parse(recControl.InvMarkupRate3.Text, InventoryTable.InvMarkupRate3);
                  }
                
                        if (recControl.InvMarkupRate4.Text != "") {
                            rec.Parse(recControl.InvMarkupRate4.Text, InventoryTable.InvMarkupRate4);
                  }
                
                        if (recControl.InvMarkupType0.Text != "") {
                            rec.Parse(recControl.InvMarkupType0.Text, InventoryTable.InvMarkupType0);
                  }
                
                        if (recControl.InvMarkupType1.Text != "") {
                            rec.Parse(recControl.InvMarkupType1.Text, InventoryTable.InvMarkupType1);
                  }
                
                        if (recControl.InvMarkupType2.Text != "") {
                            rec.Parse(recControl.InvMarkupType2.Text, InventoryTable.InvMarkupType2);
                  }
                
                        if (recControl.InvMarkupType3.Text != "") {
                            rec.Parse(recControl.InvMarkupType3.Text, InventoryTable.InvMarkupType3);
                  }
                
                        if (recControl.InvMarkupType4.Text != "") {
                            rec.Parse(recControl.InvMarkupType4.Text, InventoryTable.InvMarkupType4);
                  }
                
                        if (recControl.InvMinOrder.Text != "") {
                            rec.Parse(recControl.InvMinOrder.Text, InventoryTable.InvMinOrder);
                  }
                
                        if (recControl.InvMinRequired.Text != "") {
                            rec.Parse(recControl.InvMinRequired.Text, InventoryTable.InvMinRequired);
                  }
                
                        if (recControl.InvModels.Text != "") {
                            rec.Parse(recControl.InvModels.Text, InventoryTable.InvModels);
                  }
                
                        rec.InvNonStockItem = recControl.InvNonStockItem.Checked;
                
                        if (recControl.InvNotes.Text != "") {
                            rec.Parse(recControl.InvNotes.Text, InventoryTable.InvNotes);
                  }
                
                        if (recControl.InvPartNo.Text != "") {
                            rec.Parse(recControl.InvPartNo.Text, InventoryTable.InvPartNo);
                  }
                
                        if (recControl.InvPickQuantity.Text != "") {
                            rec.Parse(recControl.InvPickQuantity.Text, InventoryTable.InvPickQuantity);
                  }
                
                        if (recControl.InvPicturePath.Text != "") {
                            rec.Parse(recControl.InvPicturePath.Text, InventoryTable.InvPicturePath);
                  }
                
                        if (recControl.InvPrevBuyPrice.Text != "") {
                            rec.Parse(recControl.InvPrevBuyPrice.Text, InventoryTable.InvPrevBuyPrice);
                  }
                
                        if (recControl.InvQuantity.Text != "") {
                            rec.Parse(recControl.InvQuantity.Text, InventoryTable.InvQuantity);
                  }
                
                        if (recControl.InvReference1.Text != "") {
                            rec.Parse(recControl.InvReference1.Text, InventoryTable.InvReference1);
                  }
                
                        if (recControl.InvReference2.Text != "") {
                            rec.Parse(recControl.InvReference2.Text, InventoryTable.InvReference2);
                  }
                
                        if (recControl.InvReference3.Text != "") {
                            rec.Parse(recControl.InvReference3.Text, InventoryTable.InvReference3);
                  }
                
                        if (recControl.InvReference4.Text != "") {
                            rec.Parse(recControl.InvReference4.Text, InventoryTable.InvReference4);
                  }
                
                        if (recControl.InvReplacement.Text != "") {
                            rec.Parse(recControl.InvReplacement.Text, InventoryTable.InvReplacement);
                  }
                
                        if (recControl.InvSellPrice0.Text != "") {
                            rec.Parse(recControl.InvSellPrice0.Text, InventoryTable.InvSellPrice0);
                  }
                
                        if (recControl.InvSellPrice1.Text != "") {
                            rec.Parse(recControl.InvSellPrice1.Text, InventoryTable.InvSellPrice1);
                  }
                
                        if (recControl.InvSellPrice2.Text != "") {
                            rec.Parse(recControl.InvSellPrice2.Text, InventoryTable.InvSellPrice2);
                  }
                
                        if (recControl.InvSellPrice3.Text != "") {
                            rec.Parse(recControl.InvSellPrice3.Text, InventoryTable.InvSellPrice3);
                  }
                
                        if (recControl.InvSellPrice4.Text != "") {
                            rec.Parse(recControl.InvSellPrice4.Text, InventoryTable.InvSellPrice4);
                  }
                
                        rec.InvShare = recControl.InvShare.Checked;
                
                        if (recControl.InvStatus.Text != "") {
                            rec.Parse(recControl.InvStatus.Text, InventoryTable.InvStatus);
                  }
                
                        if (recControl.InvVendNo1.Text != "") {
                            rec.Parse(recControl.InvVendNo1.Text, InventoryTable.InvVendNo1);
                  }
                
                        if (recControl.InvVendNo2.Text != "") {
                            rec.Parse(recControl.InvVendNo2.Text, InventoryTable.InvVendNo2);
                  }
                
                        if (recControl.InvVendNo3.Text != "") {
                            rec.Parse(recControl.InvVendNo3.Text, InventoryTable.InvVendNo3);
                  }
                
                        if (recControl.InvVendorPartNo1.Text != "") {
                            rec.Parse(recControl.InvVendorPartNo1.Text, InventoryTable.InvVendorPartNo1);
                  }
                
                        if (recControl.InvVendorPartNo2.Text != "") {
                            rec.Parse(recControl.InvVendorPartNo2.Text, InventoryTable.InvVendorPartNo2);
                  }
                
                        if (recControl.InvVendorPartNo3.Text != "") {
                            rec.Parse(recControl.InvVendorPartNo3.Text, InventoryTable.InvVendorPartNo3);
                  }
                
                        rec.LastExtraction = recControl.LastExtraction.Checked;
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new InventoryRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.InventoryRecord);
                this.DataSource = (InventoryRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(InventoryTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(InventoryTableControlRow rec)            
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
        
        public virtual void SetInvCategoryLabel1()
                  {
                  
                        this.InvCategoryLabel1.Text = EvaluateFormula("\"Category\"");
                      
                    
        }
                
        public virtual void SetInvLocationLabel1()
                  {
                  
                        this.InvLocationLabel1.Text = EvaluateFormula("\"Location\"");
                      
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort()
        {
            
                this.PopulateOrderSort(MiscUtils.GetSelectedValue(this.OrderSort,  GetFromSession(this.OrderSort)), 500);					
                    

        }
            
        public virtual void SetInvCategoryFilter()
        {
            
            ArrayList InvCategoryFilterselectedFilterItemList = new ArrayList();
            string InvCategoryFilteritemsString = null;
            if (this.InSession(this.InvCategoryFilter))
                InvCategoryFilteritemsString = this.GetFromSession(this.InvCategoryFilter);
            
            if (InvCategoryFilteritemsString != null)
            {
                string[] InvCategoryFilteritemListFromSession = InvCategoryFilteritemsString.Split(',');
                foreach (string item in InvCategoryFilteritemListFromSession)
                {
                    InvCategoryFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateInvCategoryFilter(MiscUtils.GetSelectedValueList(this.InvCategoryFilter, InvCategoryFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Inventory/Inventory-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.InvCategoryFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("InvCategory")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.InvCategoryFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(InvCategoryFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for OrderSort.
                
        protected virtual void PopulateOrderSort(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Binary {Txt:Ascending}"), "InvBin Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Binary {Txt:Descending}"), "InvBin Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date Record Added {Txt:Ascending}"), "InvDateRecordAdded Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date Record Added {Txt:Descending}"), "InvDateRecordAdded Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date Record Updated {Txt:Ascending}"), "InvDateRecordUpdated Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date Record Updated {Txt:Descending}"), "InvDateRecordUpdated Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Export Include {Txt:Ascending}"), "InvExportInclude Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Export Include {Txt:Descending}"), "InvExportInclude Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Export Record Changed {Txt:Ascending}"), "InvExportRecordChanged Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Export Record Changed {Txt:Descending}"), "InvExportRecordChanged Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Location {Txt:Ascending}"), "InvLocation Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Location {Txt:Descending}"), "InvLocation Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Markup Rate 0 {Txt:Ascending}"), "InvMarkupRate0 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Markup Rate 0 {Txt:Descending}"), "InvMarkupRate0 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Markup Rate 1 {Txt:Ascending}"), "InvMarkupRate1 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Markup Rate 1 {Txt:Descending}"), "InvMarkupRate1 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice NON Stock Item {Txt:Ascending}"), "InvNonStockItem Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice NON Stock Item {Txt:Descending}"), "InvNonStockItem Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Share {Txt:Ascending}"), "InvShare Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Share {Txt:Descending}"), "InvShare Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Inventory Active {Txt:Ascending}"), "Inventory_active Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Inventory Active {Txt:Descending}"), "Inventory_active Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort.SelectedValue != null && this.OrderSort.Items.FindByValue(this.OrderSort.SelectedValue) == null)
                this.OrderSort.SelectedValue = null;
              
        }
            
        // Get the filters' data for InvCategoryFilter.
                
        protected virtual void PopulateInvCategoryFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_InvCategoryFilter();            
            this.InvCategoryFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_InvCategoryFilter function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(InventoryTable.InvCategory, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = InventoryTable.GetValues(InventoryTable.InvCategory, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( InventoryTable.InvCategory.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = InventoryTable.InvCategory.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.InvCategoryFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.InvCategoryFilter.Items.Add(newItem);

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
            
            
            this.InvCategoryFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.InvCategoryFilter.Items.Count == 0)
                this.InvCategoryFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.InvCategoryFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_InvCategoryFilter()
        {
            // Create a where clause for the filter InvCategoryFilter.
            // This function is called by the Populate method to load the items 
            // in the InvCategoryFilterQuickSelector
        
            ArrayList InvCategoryFilterselectedFilterItemList = new ArrayList();
            string InvCategoryFilteritemsString = null;
            if (this.InSession(this.InvCategoryFilter))
                InvCategoryFilteritemsString = this.GetFromSession(this.InvCategoryFilter);
            
            if (InvCategoryFilteritemsString != null)
            {
                string[] InvCategoryFilteritemListFromSession = InvCategoryFilteritemsString.Split(',');
                foreach (string item in InvCategoryFilteritemListFromSession)
                {
                    InvCategoryFilterselectedFilterItemList.Add(item);
                }
            }
              
            InvCategoryFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.InvCategoryFilter, InvCategoryFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (InvCategoryFilterselectedFilterItemList == null || InvCategoryFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in InvCategoryFilterselectedFilterItemList)
                {
            
      
   
                    wc.iOR(InventoryTable.InvCategory, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
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
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("InventoryTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                InventoryTableControlRow recControl = (InventoryTableControlRow)repItem.FindControl("InventoryTableControlRow");
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
        
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            ArrayList InvCategoryFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.InvCategoryFilter, null);
            string InvCategoryFilterSessionString = "";
            if (InvCategoryFilterselectedFilterItemList != null){
                foreach (string item in InvCategoryFilterselectedFilterItemList){
                    InvCategoryFilterSessionString = String.Concat(InvCategoryFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.InvCategoryFilter, InvCategoryFilterSessionString);
                  
            this.SaveToSession(this.InvLocationFromFilter, this.InvLocationFromFilter.Text);
                  
            this.SaveToSession(this.InvLocationToFilter, this.InvLocationToFilter.Text);
                  
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
          
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            ArrayList InvCategoryFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.InvCategoryFilter, null);
            string InvCategoryFilterSessionString = "";
            if (InvCategoryFilterselectedFilterItemList != null){
                foreach (string item in InvCategoryFilterselectedFilterItemList){
                    InvCategoryFilterSessionString = String.Concat(InvCategoryFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("InvCategoryFilter_Ajax", InvCategoryFilterSessionString);
          
      this.SaveToSession("InvLocationFromFilter_Ajax", this.InvLocationFromFilter.Text);
              
      this.SaveToSession("InvLocationToFilter_Ajax", this.InvLocationToFilter.Text);
              
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.InvCategoryFilter);
            this.RemoveFromSession(this.InvLocationFromFilter);
            this.RemoveFromSession(this.InvLocationToFilter);
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

            string orderByStr = (string)ViewState["InventoryTableControl_OrderBy"];
          
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
                this.ViewState["InventoryTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
            
        public virtual void SetDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetSaveButton()                
              
        {
        
                    this.SaveButton.Attributes.Add("onclick", "SubmitHRefOnce(this, \"" + this.Page.GetResourceValue("Txt:SaveRecord", "OEMConversion") + "\");");
                  
   
        }
            
        public virtual void SetSearchButton()                
              
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
    
      
            if (MiscUtils.IsValueSelected(InvCategoryFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(InvLocationFromFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(InvLocationToFilter))
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
        public virtual void AddButton_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        // event handler for ImageButton
        public virtual void DeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
                this.SetFormulaControls();
          
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
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.InvCategoryFilter.ClearSelection();
            
           
            this.OrderSort.ClearSelection();
          
              this.InvLocationFromFilter.Text = "";
            
              this.InvLocationToFilter.Text = "";
            
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
        public virtual void SaveButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
        
              if (!this.Page.IsPageRefresh)
              {
                  this.SaveData();
              }

          this.Page.CommitTransaction(sender);
          // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
           
                foreach (InventoryTableControlRow recCtl in this.GetRecordControls()){
                     
                    recCtl.IsNewRecord = false;
                }
      
          // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
          
                this.DeletedRecordIds = null;
            
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
        protected virtual void OrderSort_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in InventoryTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(InventoryTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (InventoryTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && InventoryTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(InventoryTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(InventoryTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void InvCategoryFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = InventoryTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  InventoryRecord[] DataSource {
             
            get {
                return (InventoryRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton DeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteButton");
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector InvCategoryFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCategoryFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal InvCategoryLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvCategoryLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvLocationFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLocationFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvLocationLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLocationLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvLocationToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvLocationToFilter");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort");
          }
          }
        
        public OEMConversion.UI.IPaginationModern Pagination {
            get {
                return (OEMConversion.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SaveButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SaveButton");
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
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ToggleAll");
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
                InventoryTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        InventoryRecord rec = null;
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
                InventoryTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        InventoryRecord rec = null;
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
          
        public virtual int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (InventoryTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual InventoryTableControlRow GetSelectedRecordControl()
        {
        InventoryTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual InventoryTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (InventoryTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow != null && recControl.SelectRow.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (InventoryTableControlRow[])(selectedList.ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_Inventory_Table.InventoryTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            InventoryTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (InventoryTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.SelectRow.Checked = false;
                
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

        public virtual InventoryTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "InventoryTableControlRow");
	          List<InventoryTableControlRow> list = new List<InventoryTableControlRow>();
	          foreach (InventoryTableControlRow recCtrl in recCtrls) {
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

  