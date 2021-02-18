
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_LedgerInventory.aspx page.  The Row or RecordControl classes are the 
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

  
namespace OEMConversion.UI.Controls.Add_LedgerInventory
{
  

#region "Section 1: Place your customizations here."

    
public class LedgerInventoryRecordControl : BaseLedgerInventoryRecordControl
{
      
        // The BaseLedgerInventoryRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the LedgerInventoryRecordControl control on the Add_LedgerInventory page.
// Do not modify this class. Instead override any method in LedgerInventoryRecordControl.
public class BaseLedgerInventoryRecordControl : OEMConversion.UI.BaseApplicationRecordControl
{
        public BaseLedgerInventoryRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in LedgerInventoryRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in LedgerInventoryRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
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
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new LedgerInventoryRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            LedgerInventoryRecord[] recList = LedgerInventoryTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (LedgerInventoryRecord)LedgerInventoryRecord.Copy(recList[0], false);
                  
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
                

      // To customize, override this method in LedgerInventoryRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersLedgerInventoryRecordControl = false;
            hasFiltersLedgerInventoryRecordControl = hasFiltersLedgerInventoryRecordControl && false; // suppress warning
      
            WhereClause wc;
            LedgerInventoryTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["LedgerInventory"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-LedgerInventory"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(LedgerInventoryTable.LdgKey, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(LedgerInventoryTable.LdgKey));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(LedgerInventoryTable.LdgKey, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            LedgerInventoryTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersLedgerInventoryRecordControl = false;
            hasFiltersLedgerInventoryRecordControl = hasFiltersLedgerInventoryRecordControl && false; // suppress warning
      
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
          LedgerInventoryTable.DeleteRecord(pkValue);
          
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
                return (string)this.ViewState["BaseLedgerInventoryRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseLedgerInventoryRecordControl_Rec"] = value;
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
            
            return new LedgerInventoryRecord();
            
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

  