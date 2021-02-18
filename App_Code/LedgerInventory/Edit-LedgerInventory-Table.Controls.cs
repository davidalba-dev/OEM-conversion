
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_LedgerInventory_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Edit_LedgerInventory_Table
{
  

#region "Section 1: Place your customizations here."

    
public class LedgerInventoryTableControlRow : BaseLedgerInventoryTableControlRow
{
      
        // The BaseLedgerInventoryTableControlRow implements code for a ROW within the
        // the LedgerInventoryTableControl table.  The BaseLedgerInventoryTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of LedgerInventoryTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class LedgerInventoryTableControl : BaseLedgerInventoryTableControl
{
    // The BaseLedgerInventoryTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The LedgerInventoryTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the LedgerInventoryTableControlRow control on the Edit_LedgerInventory_Table page.
// Do not modify this class. Instead override any method in LedgerInventoryTableControlRow.
public class BaseLedgerInventoryTableControlRow : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseLedgerInventoryTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in LedgerInventoryTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in LedgerInventoryTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "OEMConversion") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
              this.LdgExportInclude.CheckedChanged += LdgExportInclude_CheckedChanged;
            
              this.LdgExportRecordChanged.CheckedChanged += LdgExportRecordChanged_CheckedChanged;
            
              this.LdgBin.TextChanged += LdgBin_TextChanged;
            
              this.LdgBuyPrice.TextChanged += LdgBuyPrice_TextChanged;
            
              this.LdgExported.TextChanged += LdgExported_TextChanged;
            
              this.LdgFormNo.TextChanged += LdgFormNo_TextChanged;
            
              this.LdgFormType.TextChanged += LdgFormType_TextChanged;
            
              this.LdgLocation.TextChanged += LdgLocation_TextChanged;
            
              this.LdgPartNo.TextChanged += LdgPartNo_TextChanged;
            
              this.LdgQuantity.TextChanged += LdgQuantity_TextChanged;
            
              this.LdgRecDate.TextChanged += LdgRecDate_TextChanged;
            
              this.LdgReference.TextChanged += LdgReference_TextChanged;
            
              this.LdgSellPrice.TextChanged += LdgSellPrice_TextChanged;
            
              this.LdgSerialNo.TextChanged += LdgSerialNo_TextChanged;
            
              this.LdgTrnDate.TextChanged += LdgTrnDate_TextChanged;
            
              this.LdgUser.TextChanged += LdgUser_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = LedgerInventoryTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseLedgerInventoryTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new LedgerInventoryRecord();
            
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
        
                
                
                SetLdgBin();
                SetLdgBinLabel();
                SetLdgBuyPrice();
                SetLdgBuyPriceLabel();
                SetLdgExported();
                SetLdgExportedLabel();
                SetLdgExportInclude();
                SetLdgExportIncludeLabel();
                SetLdgExportRecordChanged();
                SetLdgExportRecordChangedLabel();
                SetLdgFormNo();
                SetLdgFormNoLabel();
                SetLdgFormType();
                SetLdgFormTypeLabel();
                SetLdgLocation();
                SetLdgLocationLabel();
                SetLdgPartNo();
                SetLdgPartNoLabel();
                SetLdgQuantity();
                SetLdgQuantityLabel();
                SetLdgRecDate();
                SetLdgRecDateLabel();
                SetLdgReference();
                SetLdgReferenceLabel();
                SetLdgSellPrice();
                SetLdgSellPriceLabel();
                SetLdgSerialNo();
                SetLdgSerialNoLabel();
                SetLdgTrnDate();
                SetLdgTrnDateLabel();
                SetLdgUser();
                SetLdgUserLabel();
                
                
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
        
        
        public virtual void SetLdgBin()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgBin.ID))
            {
            
                this.LdgBin.Text = this.PreviousUIData[this.LdgBin.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgBin TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgBin is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgBinSpecified) {
                								
                // If the LdgBin is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgBin);
                                
                this.LdgBin.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgBin is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgBin.Text = LedgerInventoryTable.LdgBin.Format(LedgerInventoryTable.LdgBin.DefaultValue);
            		
            }
            
              this.LdgBin.TextChanged += LdgBin_TextChanged;
                               
        }
                
        public virtual void SetLdgBuyPrice()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgBuyPrice.ID))
            {
            
                this.LdgBuyPrice.Text = this.PreviousUIData[this.LdgBuyPrice.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgBuyPrice TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgBuyPrice is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgBuyPriceSpecified) {
                								
                // If the LdgBuyPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgBuyPrice, @"C");
                                
                this.LdgBuyPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgBuyPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgBuyPrice.Text = LedgerInventoryTable.LdgBuyPrice.Format(LedgerInventoryTable.LdgBuyPrice.DefaultValue, @"C");
            		
            }
            
              this.LdgBuyPrice.TextChanged += LdgBuyPrice_TextChanged;
                               
        }
                
        public virtual void SetLdgExported()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgExported.ID))
            {
            
                this.LdgExported.Text = this.PreviousUIData[this.LdgExported.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgExported TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgExported is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportedSpecified) {
                								
                // If the LdgExported is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgExported, @"g");
                                
                this.LdgExported.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgExported is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgExported.Text = LedgerInventoryTable.LdgExported.Format(LedgerInventoryTable.LdgExported.DefaultValue, @"g");
            		
            }
            
              this.LdgExported.TextChanged += LdgExported_TextChanged;
                               
        }
                
        public virtual void SetLdgExportInclude()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgExportInclude.ID))
            {
                this.LdgExportInclude.Checked = Convert.ToBoolean(this.PreviousUIData[this.LdgExportInclude.ID]);
                return;
            }	
            
                    
            // Set the LdgExportInclude CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgExportInclude is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportIncludeSpecified) {
                							
                // If the LdgExportInclude is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.LdgExportInclude.Checked = this.DataSource.LdgExportInclude;
                    				
            } else {
            
                // LdgExportInclude is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.LdgExportInclude.Checked = LedgerInventoryTable.LdgExportInclude.ParseValue(LedgerInventoryTable.LdgExportInclude.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetLdgExportRecordChanged()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgExportRecordChanged.ID))
            {
                this.LdgExportRecordChanged.Checked = Convert.ToBoolean(this.PreviousUIData[this.LdgExportRecordChanged.ID]);
                return;
            }	
            
                    
            // Set the LdgExportRecordChanged CheckBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgExportRecordChanged is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgExportRecordChangedSpecified) {
                							
                // If the LdgExportRecordChanged is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.LdgExportRecordChanged.Checked = this.DataSource.LdgExportRecordChanged;
                    				
            } else {
            
                // LdgExportRecordChanged is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.LdgExportRecordChanged.Checked = LedgerInventoryTable.LdgExportRecordChanged.ParseValue(LedgerInventoryTable.LdgExportRecordChanged.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetLdgFormNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgFormNo.ID))
            {
            
                this.LdgFormNo.Text = this.PreviousUIData[this.LdgFormNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgFormNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgFormNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgFormNoSpecified) {
                								
                // If the LdgFormNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgFormNo);
                                
                this.LdgFormNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgFormNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgFormNo.Text = LedgerInventoryTable.LdgFormNo.Format(LedgerInventoryTable.LdgFormNo.DefaultValue);
            		
            }
            
              this.LdgFormNo.TextChanged += LdgFormNo_TextChanged;
                               
        }
                
        public virtual void SetLdgFormType()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgFormType.ID))
            {
            
                this.LdgFormType.Text = this.PreviousUIData[this.LdgFormType.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgFormType TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgFormType is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgFormTypeSpecified) {
                								
                // If the LdgFormType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgFormType);
                                
                this.LdgFormType.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgFormType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgFormType.Text = LedgerInventoryTable.LdgFormType.Format(LedgerInventoryTable.LdgFormType.DefaultValue);
            		
            }
            
              this.LdgFormType.TextChanged += LdgFormType_TextChanged;
                               
        }
                
        public virtual void SetLdgLocation()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgLocation.ID))
            {
            
                this.LdgLocation.Text = this.PreviousUIData[this.LdgLocation.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgLocation TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgLocation is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgLocationSpecified) {
                								
                // If the LdgLocation is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgLocation);
                                
                this.LdgLocation.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgLocation is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgLocation.Text = LedgerInventoryTable.LdgLocation.Format(LedgerInventoryTable.LdgLocation.DefaultValue);
            		
            }
            
              this.LdgLocation.TextChanged += LdgLocation_TextChanged;
                               
        }
                
        public virtual void SetLdgPartNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgPartNo.ID))
            {
            
                this.LdgPartNo.Text = this.PreviousUIData[this.LdgPartNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgPartNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgPartNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgPartNoSpecified) {
                								
                // If the LdgPartNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgPartNo);
                                
                this.LdgPartNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgPartNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgPartNo.Text = LedgerInventoryTable.LdgPartNo.Format(LedgerInventoryTable.LdgPartNo.DefaultValue);
            		
            }
            
              this.LdgPartNo.TextChanged += LdgPartNo_TextChanged;
                               
        }
                
        public virtual void SetLdgQuantity()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgQuantity.ID))
            {
            
                this.LdgQuantity.Text = this.PreviousUIData[this.LdgQuantity.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgQuantity TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgQuantity is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgQuantitySpecified) {
                								
                // If the LdgQuantity is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgQuantity);
                                
                this.LdgQuantity.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgQuantity is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgQuantity.Text = LedgerInventoryTable.LdgQuantity.Format(LedgerInventoryTable.LdgQuantity.DefaultValue);
            		
            }
            
              this.LdgQuantity.TextChanged += LdgQuantity_TextChanged;
                               
        }
                
        public virtual void SetLdgRecDate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgRecDate.ID))
            {
            
                this.LdgRecDate.Text = this.PreviousUIData[this.LdgRecDate.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgRecDate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgRecDate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgRecDateSpecified) {
                								
                // If the LdgRecDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgRecDate, @"g");
                                
                this.LdgRecDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgRecDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgRecDate.Text = LedgerInventoryTable.LdgRecDate.Format(LedgerInventoryTable.LdgRecDate.DefaultValue, @"g");
            		
            }
            
              this.LdgRecDate.TextChanged += LdgRecDate_TextChanged;
                               
        }
                
        public virtual void SetLdgReference()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgReference.ID))
            {
            
                this.LdgReference.Text = this.PreviousUIData[this.LdgReference.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgReference TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgReference is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgReferenceSpecified) {
                								
                // If the LdgReference is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgReference);
                                
                this.LdgReference.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgReference is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgReference.Text = LedgerInventoryTable.LdgReference.Format(LedgerInventoryTable.LdgReference.DefaultValue);
            		
            }
            
              this.LdgReference.TextChanged += LdgReference_TextChanged;
                               
        }
                
        public virtual void SetLdgSellPrice()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgSellPrice.ID))
            {
            
                this.LdgSellPrice.Text = this.PreviousUIData[this.LdgSellPrice.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgSellPrice TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgSellPrice is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgSellPriceSpecified) {
                								
                // If the LdgSellPrice is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgSellPrice, @"C");
                                
                this.LdgSellPrice.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgSellPrice is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgSellPrice.Text = LedgerInventoryTable.LdgSellPrice.Format(LedgerInventoryTable.LdgSellPrice.DefaultValue, @"C");
            		
            }
            
              this.LdgSellPrice.TextChanged += LdgSellPrice_TextChanged;
                               
        }
                
        public virtual void SetLdgSerialNo()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgSerialNo.ID))
            {
            
                this.LdgSerialNo.Text = this.PreviousUIData[this.LdgSerialNo.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgSerialNo TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgSerialNo is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgSerialNoSpecified) {
                								
                // If the LdgSerialNo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgSerialNo);
                                
                this.LdgSerialNo.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgSerialNo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgSerialNo.Text = LedgerInventoryTable.LdgSerialNo.Format(LedgerInventoryTable.LdgSerialNo.DefaultValue);
            		
            }
            
              this.LdgSerialNo.TextChanged += LdgSerialNo_TextChanged;
                               
        }
                
        public virtual void SetLdgTrnDate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgTrnDate.ID))
            {
            
                this.LdgTrnDate.Text = this.PreviousUIData[this.LdgTrnDate.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgTrnDate TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgTrnDate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgTrnDateSpecified) {
                								
                // If the LdgTrnDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgTrnDate, @"g");
                                
                this.LdgTrnDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgTrnDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgTrnDate.Text = LedgerInventoryTable.LdgTrnDate.Format(LedgerInventoryTable.LdgTrnDate.DefaultValue, @"g");
            		
            }
            
              this.LdgTrnDate.TextChanged += LdgTrnDate_TextChanged;
                               
        }
                
        public virtual void SetLdgUser()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LdgUser.ID))
            {
            
                this.LdgUser.Text = this.PreviousUIData[this.LdgUser.ID].ToString();
              
                return;
            }
            
                    
            // Set the LdgUser TextBox on the webpage with value from the
            // DatabaseAYS_OEM%dbo.LedgerInventory database record.

            // this.DataSource is the DatabaseAYS_OEM%dbo.LedgerInventory record retrieved from the database.
            // this.LdgUser is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LdgUserSpecified) {
                								
                // If the LdgUser is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(LedgerInventoryTable.LdgUser);
                                
                this.LdgUser.Text = formattedValue;
                   
            } 
            
            else {
            
                // LdgUser is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LdgUser.Text = LedgerInventoryTable.LdgUser.Format(LedgerInventoryTable.LdgUser.DefaultValue);
            		
            }
            
              this.LdgUser.TextChanged += LdgUser_TextChanged;
                               
        }
                
        public virtual void SetLdgBinLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgBuyPriceLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgExportedLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgExportIncludeLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgExportRecordChangedLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgFormNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgFormTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgLocationLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgPartNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgQuantityLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgRecDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgReferenceLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgSellPriceLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgSerialNoLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgTrnDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetLdgUserLabel()
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
                ((LedgerInventoryTableControl)MiscUtils.GetParentControlObject(this, "LedgerInventoryTableControl")).DataChanged = true;
                ((LedgerInventoryTableControl)MiscUtils.GetParentControlObject(this, "LedgerInventoryTableControl")).ResetData = true;
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
        
            GetLdgBin();
            GetLdgBuyPrice();
            GetLdgExported();
            GetLdgExportInclude();
            GetLdgExportRecordChanged();
            GetLdgFormNo();
            GetLdgFormType();
            GetLdgLocation();
            GetLdgPartNo();
            GetLdgQuantity();
            GetLdgRecDate();
            GetLdgReference();
            GetLdgSellPrice();
            GetLdgSerialNo();
            GetLdgTrnDate();
            GetLdgUser();
        }
        
        
        public virtual void GetLdgBin()
        {
            
            // Retrieve the value entered by the user on the LdgBin ASP:TextBox, and
            // save it into the LdgBin field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgBin.Text, LedgerInventoryTable.LdgBin);							
                          
                      
        }
                
        public virtual void GetLdgBuyPrice()
        {
            
            // Retrieve the value entered by the user on the LdgBuyPrice ASP:TextBox, and
            // save it into the LdgBuyPrice field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgBuyPrice.Text, LedgerInventoryTable.LdgBuyPrice);							
                          
                      
        }
                
        public virtual void GetLdgExported()
        {
            
            // Retrieve the value entered by the user on the LdgExported ASP:TextBox, and
            // save it into the LdgExported field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgExported.Text, LedgerInventoryTable.LdgExported);							
                          
                      
        }
                
        public virtual void GetLdgExportInclude()
        {	
        		
            // Retrieve the value entered by the user on the LdgExportInclude ASP:CheckBox, and
            // save it into the LdgExportInclude field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.LdgExportInclude = this.LdgExportInclude.Checked;						
                    
        }
                
        public virtual void GetLdgExportRecordChanged()
        {	
        		
            // Retrieve the value entered by the user on the LdgExportRecordChanged ASP:CheckBox, and
            // save it into the LdgExportRecordChanged field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.LdgExportRecordChanged = this.LdgExportRecordChanged.Checked;						
                    
        }
                
        public virtual void GetLdgFormNo()
        {
            
            // Retrieve the value entered by the user on the LdgFormNo ASP:TextBox, and
            // save it into the LdgFormNo field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgFormNo.Text, LedgerInventoryTable.LdgFormNo);							
                          
                      
        }
                
        public virtual void GetLdgFormType()
        {
            
            // Retrieve the value entered by the user on the LdgFormType ASP:TextBox, and
            // save it into the LdgFormType field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgFormType.Text, LedgerInventoryTable.LdgFormType);							
                          
                      
        }
                
        public virtual void GetLdgLocation()
        {
            
            // Retrieve the value entered by the user on the LdgLocation ASP:TextBox, and
            // save it into the LdgLocation field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgLocation.Text, LedgerInventoryTable.LdgLocation);							
                          
                      
        }
                
        public virtual void GetLdgPartNo()
        {
            
            // Retrieve the value entered by the user on the LdgPartNo ASP:TextBox, and
            // save it into the LdgPartNo field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgPartNo.Text, LedgerInventoryTable.LdgPartNo);							
                          
                      
        }
                
        public virtual void GetLdgQuantity()
        {
            
            // Retrieve the value entered by the user on the LdgQuantity ASP:TextBox, and
            // save it into the LdgQuantity field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgQuantity.Text, LedgerInventoryTable.LdgQuantity);							
                          
                      
        }
                
        public virtual void GetLdgRecDate()
        {
            
            // Retrieve the value entered by the user on the LdgRecDate ASP:TextBox, and
            // save it into the LdgRecDate field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgRecDate.Text, LedgerInventoryTable.LdgRecDate);							
                          
                      
        }
                
        public virtual void GetLdgReference()
        {
            
            // Retrieve the value entered by the user on the LdgReference ASP:TextBox, and
            // save it into the LdgReference field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgReference.Text, LedgerInventoryTable.LdgReference);							
                          
                      
        }
                
        public virtual void GetLdgSellPrice()
        {
            
            // Retrieve the value entered by the user on the LdgSellPrice ASP:TextBox, and
            // save it into the LdgSellPrice field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            // Parse will also validate the amount to ensure it is of the proper format
            // and valid.  The format is verified based on the current culture 
            // settings including the currency symbol and decimal separator
            // (no currency conversion is performed).
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgSellPrice.Text, LedgerInventoryTable.LdgSellPrice);							
                          
                      
        }
                
        public virtual void GetLdgSerialNo()
        {
            
            // Retrieve the value entered by the user on the LdgSerialNo ASP:TextBox, and
            // save it into the LdgSerialNo field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgSerialNo.Text, LedgerInventoryTable.LdgSerialNo);							
                          
                      
        }
                
        public virtual void GetLdgTrnDate()
        {
            
            // Retrieve the value entered by the user on the LdgTrnDate ASP:TextBox, and
            // save it into the LdgTrnDate field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgTrnDate.Text, LedgerInventoryTable.LdgTrnDate);							
                          
                      
        }
                
        public virtual void GetLdgUser()
        {
            
            // Retrieve the value entered by the user on the LdgUser ASP:TextBox, and
            // save it into the LdgUser field in DataSource DatabaseAYS_OEM%dbo.LedgerInventory record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LdgUser.Text, LedgerInventoryTable.LdgUser);							
                          
                      
        }
                

      // To customize, override this method in LedgerInventoryTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersLedgerInventoryTableControl = false;
            hasFiltersLedgerInventoryTableControl = hasFiltersLedgerInventoryTableControl && false; // suppress warning
      
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
          LedgerInventoryTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((LedgerInventoryTableControl)MiscUtils.GetParentControlObject(this, "LedgerInventoryTableControl")).DataChanged = true;
            ((LedgerInventoryTableControl)MiscUtils.GetParentControlObject(this, "LedgerInventoryTableControl")).ResetData = true;
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
        LedgerInventoryTableControl tc= ((LedgerInventoryTableControl)MiscUtils.GetParentControlObject(this, "LedgerInventoryTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((LedgerInventoryTableControlRow)this);
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
            
            string url = @"../LedgerInventory/Edit-LedgerInventory.aspx?LedgerInventory={PK}";
            
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
            
            string url = @"../LedgerInventory/Show-LedgerInventory.aspx?LedgerInventory={PK}";
            
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
            
            
        
        protected virtual void LdgExportInclude_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void LdgExportRecordChanged_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void LdgBin_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgBuyPrice_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgExported_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgFormNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgFormType_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgLocation_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgPartNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgQuantity_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgRecDate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgReference_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgSellPrice_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgSerialNo_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgTrnDate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LdgUser_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseLedgerInventoryTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseLedgerInventoryTableControlRow_Rec"] = value;
            }
        }
        
        public LedgerInventoryRecord DataSource {
            get {
                return (LedgerInventoryRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox LdgBin {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgBin");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgBinLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgBinLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgBuyPrice {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgBuyPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgBuyPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgBuyPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgExported {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExported");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportedLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox LdgExportInclude {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportInclude");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportIncludeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportIncludeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox LdgExportRecordChanged {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportRecordChanged");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgExportRecordChangedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgExportRecordChangedLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgFormNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgFormNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgFormType {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormType");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgFormTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgLocation {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgLocation");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgLocationLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgLocationLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgPartNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgPartNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgPartNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgPartNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgQuantity {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgQuantity");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgQuantityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgQuantityLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgRecDate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgRecDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgRecDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgReference {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgReference");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgReferenceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgReferenceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgSellPrice {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgSellPrice");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgSellPriceLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgSellPriceLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgSerialNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgSerialNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgSerialNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgSerialNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgTrnDate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTrnDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgTrnDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgTrnDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgUser {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgUser");
            }
        }
            
        public System.Web.UI.WebControls.Literal LdgUserLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgUserLabel");
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
        LedgerInventoryRecord rec = null;
             
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
    LedgerInventoryRecord rec = null;
    
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

        
        public virtual LedgerInventoryRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return LedgerInventoryTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the LedgerInventoryTableControl control on the Edit_LedgerInventory_Table page.
// Do not modify this class. Instead override any method in LedgerInventoryTableControl.
public class BaseLedgerInventoryTableControl : OEMConversion.UI.BaseApplicationTableControl
{
         
       public BaseLedgerInventoryTableControl()
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
                if  (this.InSession(this.LdgFormNoFromFilter)) 				
                    initialVal = this.GetFromSession(this.LdgFormNoFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"LdgFormNoFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.LdgFormNoFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.LdgFormNoToFilter)) 				
                    initialVal = this.GetFromSession(this.LdgFormNoToFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"LdgFormNoTo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.LdgFormNoToFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.LdgFormTypeFilter)) 				
                    initialVal = this.GetFromSession(this.LdgFormTypeFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"LdgFormType\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] LdgFormTypeFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in LdgFormTypeFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.LdgFormTypeFilter.Items.Add(item);
                            this.LdgFormTypeFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.LdgFormTypeFilter.Items)
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
            
              this.LdgFormTypeFilter.SelectedIndexChanged += LdgFormTypeFilter_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(OEMConversion.Business.LedgerInventoryRecord);
                      this.DataSource = (LedgerInventoryRecord[])(alist.ToArray(myrec));
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
                    foreach (LedgerInventoryTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(OEMConversion.Business.LedgerInventoryRecord);
                    this.DataSource = (LedgerInventoryRecord[])(postdata.ToArray(myrec));
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
        
        public virtual LedgerInventoryRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(LedgerInventoryTable.Column1, true);          
            // selCols.Add(LedgerInventoryTable.Column2, true);          
            // selCols.Add(LedgerInventoryTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return LedgerInventoryTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                LedgerInventoryTable databaseTable = new LedgerInventoryTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(LedgerInventoryRecord)) as LedgerInventoryRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(LedgerInventoryTable.Column1, true);          
            // selCols.Add(LedgerInventoryTable.Column2, true);          
            // selCols.Add(LedgerInventoryTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return LedgerInventoryTable.GetRecordCount(join, where);
            else
            {
                LedgerInventoryTable databaseTable = new LedgerInventoryTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerInventoryTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            LedgerInventoryTableControlRow recControl = (LedgerInventoryTableControlRow)(repItem.FindControl("LedgerInventoryTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                SetLdgFormNoLabel1();
                
                
                SetLdgFormTypeFilter();
                SetLdgFormTypeLabel1();
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


            
            this.LdgFormTypeFilter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
            this.LdgFormNoFromFilter.Text = "";
            
            this.LdgFormNoToFilter.Text = "";
            
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
    
            // Bind the buttons for LedgerInventoryTableControl pagination.
        
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
              
            foreach (LedgerInventoryTableControlRow recCtl in this.GetRecordControls())
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
            foreach (LedgerInventoryTableControlRow recCtl in this.GetRecordControls()){
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
            LedgerInventoryTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.LdgFormNoFromFilter)) {
                        
                wc.iAND(LedgerInventoryTable.LdgFormNo, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(this.LdgFormNoFromFilter, this.GetFromSession(this.LdgFormNoFromFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.LdgFormNoToFilter)) {
                        
                wc.iAND(LedgerInventoryTable.LdgFormNo, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(this.LdgFormNoToFilter, this.GetFromSession(this.LdgFormNoToFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.LdgFormTypeFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.LdgFormTypeFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.LdgFormTypeFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(LedgerInventoryTable.LdgFormType, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
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
      
      cols.Add(LedgerInventoryTable.LdgFormType, true);
      
      cols.Add(LedgerInventoryTable.LdgPartNo, true);
      
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
            LedgerInventoryTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String LdgFormNoFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "LdgFormNoFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(LdgFormNoFromFilterSelectedValue)) {

              
                wc.iAND(LedgerInventoryTable.LdgFormNo, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, LdgFormNoFromFilterSelectedValue, false, false);
                      
      }
                      
      String LdgFormNoToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "LdgFormNoToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(LdgFormNoToFilterSelectedValue)) {

              
                wc.iAND(LedgerInventoryTable.LdgFormNo, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, LdgFormNoToFilterSelectedValue, false, false);
                      
      }
                      
      String LdgFormTypeFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "LdgFormTypeFilter_Ajax"];
            if (MiscUtils.IsValueSelected(LdgFormTypeFilterSelectedValue)) {

              
        if (LdgFormTypeFilterSelectedValue != null){
                        string[] LdgFormTypeFilteritemListFromSession = LdgFormTypeFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in LdgFormTypeFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(LedgerInventoryTable.LdgFormType, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
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
      
      cols.Add(LedgerInventoryTable.LdgFormType, true);
      
      cols.Add(LedgerInventoryTable.LdgPartNo, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(LedgerInventoryTable.LdgFormType, true);
      
      cols.Add(LedgerInventoryTable.LdgPartNo, true);
      
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
            OEMConversion.Business.LedgerInventoryRecord[] recordList  = LedgerInventoryTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (LedgerInventoryRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(LedgerInventoryTable.LdgFormType);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(LedgerInventoryTable.LdgFormType.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, LedgerInventoryTable.LdgFormType.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(LedgerInventoryTable.LdgPartNo);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(LedgerInventoryTable.LdgPartNo.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, LedgerInventoryTable.LdgPartNo.IsFullTextSearchable);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LedgerInventoryTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                LedgerInventoryTableControlRow recControl = (LedgerInventoryTableControlRow)(repItem.FindControl("LedgerInventoryTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      LedgerInventoryRecord rec = new LedgerInventoryRecord();
        
                        if (recControl.LdgBin.Text != "") {
                            rec.Parse(recControl.LdgBin.Text, LedgerInventoryTable.LdgBin);
                  }
                
                        if (recControl.LdgBuyPrice.Text != "") {
                            rec.Parse(recControl.LdgBuyPrice.Text, LedgerInventoryTable.LdgBuyPrice);
                  }
                
                        if (recControl.LdgExported.Text != "") {
                            rec.Parse(recControl.LdgExported.Text, LedgerInventoryTable.LdgExported);
                  }
                
                        rec.LdgExportInclude = recControl.LdgExportInclude.Checked;
                
                        rec.LdgExportRecordChanged = recControl.LdgExportRecordChanged.Checked;
                
                        if (recControl.LdgFormNo.Text != "") {
                            rec.Parse(recControl.LdgFormNo.Text, LedgerInventoryTable.LdgFormNo);
                  }
                
                        if (recControl.LdgFormType.Text != "") {
                            rec.Parse(recControl.LdgFormType.Text, LedgerInventoryTable.LdgFormType);
                  }
                
                        if (recControl.LdgLocation.Text != "") {
                            rec.Parse(recControl.LdgLocation.Text, LedgerInventoryTable.LdgLocation);
                  }
                
                        if (recControl.LdgPartNo.Text != "") {
                            rec.Parse(recControl.LdgPartNo.Text, LedgerInventoryTable.LdgPartNo);
                  }
                
                        if (recControl.LdgQuantity.Text != "") {
                            rec.Parse(recControl.LdgQuantity.Text, LedgerInventoryTable.LdgQuantity);
                  }
                
                        if (recControl.LdgRecDate.Text != "") {
                            rec.Parse(recControl.LdgRecDate.Text, LedgerInventoryTable.LdgRecDate);
                  }
                
                        if (recControl.LdgReference.Text != "") {
                            rec.Parse(recControl.LdgReference.Text, LedgerInventoryTable.LdgReference);
                  }
                
                        if (recControl.LdgSellPrice.Text != "") {
                            rec.Parse(recControl.LdgSellPrice.Text, LedgerInventoryTable.LdgSellPrice);
                  }
                
                        if (recControl.LdgSerialNo.Text != "") {
                            rec.Parse(recControl.LdgSerialNo.Text, LedgerInventoryTable.LdgSerialNo);
                  }
                
                        if (recControl.LdgTrnDate.Text != "") {
                            rec.Parse(recControl.LdgTrnDate.Text, LedgerInventoryTable.LdgTrnDate);
                  }
                
                        if (recControl.LdgUser.Text != "") {
                            rec.Parse(recControl.LdgUser.Text, LedgerInventoryTable.LdgUser);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new LedgerInventoryRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(OEMConversion.Business.LedgerInventoryRecord);
                this.DataSource = (LedgerInventoryRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(LedgerInventoryTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(LedgerInventoryTableControlRow rec)            
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
        
        public virtual void SetLdgFormNoLabel1()
                  {
                  
                    
        }
                
        public virtual void SetLdgFormTypeLabel1()
                  {
                  
                    
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
            
        public virtual void SetLdgFormTypeFilter()
        {
            
            ArrayList LdgFormTypeFilterselectedFilterItemList = new ArrayList();
            string LdgFormTypeFilteritemsString = null;
            if (this.InSession(this.LdgFormTypeFilter))
                LdgFormTypeFilteritemsString = this.GetFromSession(this.LdgFormTypeFilter);
            
            if (LdgFormTypeFilteritemsString != null)
            {
                string[] LdgFormTypeFilteritemListFromSession = LdgFormTypeFilteritemsString.Split(',');
                foreach (string item in LdgFormTypeFilteritemListFromSession)
                {
                    LdgFormTypeFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateLdgFormTypeFilter(MiscUtils.GetSelectedValueList(this.LdgFormTypeFilter, LdgFormTypeFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../LedgerInventory/LedgerInventory-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.LdgFormTypeFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("LdgFormType")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.LdgFormTypeFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(LdgFormTypeFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
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
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Binary {Txt:Ascending}"), "LdgBin Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Binary {Txt:Descending}"), "LdgBin Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Exported {Txt:Ascending}"), "LdgExported Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Exported {Txt:Descending}"), "LdgExported Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Include {Txt:Ascending}"), "LdgExportInclude Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Include {Txt:Descending}"), "LdgExportInclude Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Record Changed {Txt:Ascending}"), "LdgExportRecordChanged Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Export Record Changed {Txt:Descending}"), "LdgExportRecordChanged Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Form Number {Txt:Ascending}"), "LdgFormNo Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Form Number {Txt:Descending}"), "LdgFormNo Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Form Type {Txt:Ascending}"), "LdgFormType Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Form Type {Txt:Descending}"), "LdgFormType Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Location {Txt:Ascending}"), "LdgLocation Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Location {Txt:Descending}"), "LdgLocation Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Part Number {Txt:Ascending}"), "LdgPartNo Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Part Number {Txt:Descending}"), "LdgPartNo Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Received Date {Txt:Ascending}"), "LdgRecDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG Received Date {Txt:Descending}"), "LdgRecDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG TRN Date {Txt:Ascending}"), "LdgTrnDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("LDG TRN Date {Txt:Descending}"), "LdgTrnDate Desc"));
              
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
            
        // Get the filters' data for LdgFormTypeFilter.
                
        protected virtual void PopulateLdgFormTypeFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_LdgFormTypeFilter();            
            this.LdgFormTypeFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_LdgFormTypeFilter function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(LedgerInventoryTable.LdgFormType, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = LedgerInventoryTable.GetValues(LedgerInventoryTable.LdgFormType, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( LedgerInventoryTable.LdgFormType.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = LedgerInventoryTable.LdgFormType.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.LdgFormTypeFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.LdgFormTypeFilter.Items.Add(newItem);

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
            
            
            this.LdgFormTypeFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.LdgFormTypeFilter.Items.Count == 0)
                this.LdgFormTypeFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "OEMConversion"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.LdgFormTypeFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_LdgFormTypeFilter()
        {
            // Create a where clause for the filter LdgFormTypeFilter.
            // This function is called by the Populate method to load the items 
            // in the LdgFormTypeFilterQuickSelector
        
            ArrayList LdgFormTypeFilterselectedFilterItemList = new ArrayList();
            string LdgFormTypeFilteritemsString = null;
            if (this.InSession(this.LdgFormTypeFilter))
                LdgFormTypeFilteritemsString = this.GetFromSession(this.LdgFormTypeFilter);
            
            if (LdgFormTypeFilteritemsString != null)
            {
                string[] LdgFormTypeFilteritemListFromSession = LdgFormTypeFilteritemsString.Split(',');
                foreach (string item in LdgFormTypeFilteritemListFromSession)
                {
                    LdgFormTypeFilterselectedFilterItemList.Add(item);
                }
            }
              
            LdgFormTypeFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.LdgFormTypeFilter, LdgFormTypeFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (LdgFormTypeFilterselectedFilterItemList == null || LdgFormTypeFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in LdgFormTypeFilterselectedFilterItemList)
                {
            
      
   
                    wc.iOR(LedgerInventoryTable.LdgFormType, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
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
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("LedgerInventoryTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                LedgerInventoryTableControlRow recControl = (LedgerInventoryTableControlRow)repItem.FindControl("LedgerInventoryTableControlRow");
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
                  
            this.SaveToSession(this.LdgFormNoFromFilter, this.LdgFormNoFromFilter.Text);
                  
            this.SaveToSession(this.LdgFormNoToFilter, this.LdgFormNoToFilter.Text);
                  
            ArrayList LdgFormTypeFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.LdgFormTypeFilter, null);
            string LdgFormTypeFilterSessionString = "";
            if (LdgFormTypeFilterselectedFilterItemList != null){
                foreach (string item in LdgFormTypeFilterselectedFilterItemList){
                    LdgFormTypeFilterSessionString = String.Concat(LdgFormTypeFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.LdgFormTypeFilter, LdgFormTypeFilterSessionString);
                  
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
                  
      this.SaveToSession("LdgFormNoFromFilter_Ajax", this.LdgFormNoFromFilter.Text);
              
      this.SaveToSession("LdgFormNoToFilter_Ajax", this.LdgFormNoToFilter.Text);
              
            ArrayList LdgFormTypeFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.LdgFormTypeFilter, null);
            string LdgFormTypeFilterSessionString = "";
            if (LdgFormTypeFilterselectedFilterItemList != null){
                foreach (string item in LdgFormTypeFilterselectedFilterItemList){
                    LdgFormTypeFilterSessionString = String.Concat(LdgFormTypeFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("LdgFormTypeFilter_Ajax", LdgFormTypeFilterSessionString);
          
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.LdgFormNoFromFilter);
            this.RemoveFromSession(this.LdgFormNoToFilter);
            this.RemoveFromSession(this.LdgFormTypeFilter);
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

            string orderByStr = (string)ViewState["LedgerInventoryTableControl_OrderBy"];
          
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
                this.ViewState["LedgerInventoryTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
    
      
            if (MiscUtils.IsValueSelected(LdgFormNoFromFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(LdgFormNoToFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(LdgFormTypeFilter))
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
                
              this.LdgFormTypeFilter.ClearSelection();
            
           
            this.OrderSort.ClearSelection();
          
              this.LdgFormNoFromFilter.Text = "";
            
              this.LdgFormNoToFilter.Text = "";
            
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
           
                foreach (LedgerInventoryTableControlRow recCtl in this.GetRecordControls()){
                     
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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in LedgerInventoryTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(LedgerInventoryTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (LedgerInventoryTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && LedgerInventoryTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(LedgerInventoryTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(LedgerInventoryTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void LdgFormTypeFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = LedgerInventoryTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  LedgerInventoryRecord[] DataSource {
             
            get {
                return (LedgerInventoryRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox LdgFormNoFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormNoFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal LdgFormNoLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormNoLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LdgFormNoToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormNoToFilter");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector LdgFormTypeFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormTypeFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal LdgFormTypeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LdgFormTypeLabel1");
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
                LedgerInventoryTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        LedgerInventoryRecord rec = null;
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
                LedgerInventoryTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
                }

        LedgerInventoryRecord rec = null;
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
            foreach (LedgerInventoryTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual LedgerInventoryTableControlRow GetSelectedRecordControl()
        {
        LedgerInventoryTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual LedgerInventoryTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (LedgerInventoryTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow != null && recControl.SelectRow.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (LedgerInventoryTableControlRow[])(selectedList.ToArray(Type.GetType("OEMConversion.UI.Controls.Edit_LedgerInventory_Table.LedgerInventoryTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            LedgerInventoryTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "OEMConversion"));
            }
            
            foreach (LedgerInventoryTableControlRow recCtl in recordList)
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

        public virtual LedgerInventoryTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "LedgerInventoryTableControlRow");
	          List<LedgerInventoryTableControlRow> list = new List<LedgerInventoryTableControlRow>();
	          foreach (LedgerInventoryTableControlRow recCtrl in recCtrls) {
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

  